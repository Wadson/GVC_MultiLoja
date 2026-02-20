using GVC.BLL;
using GVC.DTO;
using GVC.Infra.Conexao;
using GVC.Model;
using GVC.MUI;
using GVC.UTIL;
using GVC.View;
using Krypton.Toolkit;
using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace GVC
{
    public partial class FrmPrincipal : KryptonForm
    {
        private string StatusOperacao = "";
        private System.Timers.Timer timer;


        private bool _backupEmExecucao = false;
        private int _empresaId;
        private string PastaBackupAutomatica => @"C:\BackupsGVC";
        private bool _carregandoEmpresas = true;
        public FrmPrincipal()
        {
            InitializeComponent();
          
            // 🔥 Conecte o evento AQUI (ou no designer)
            cmbEmpresaToolStrip.SelectedIndexChanged += cmbEmpresaToolStrip_SelectedIndexChanged;

            StatusOperacao = "";
        }
        private void TrocarEmpresa(int empresaID, string nomeEmpresa)
        {
            // Se for a mesma empresa, não faz nada
            if (Sessao.EmpresaID == empresaID)
                return;

            var result = MessageBox.Show(
                "Trocar a empresa fechará todas as telas abertas.\nDeseja continuar?",
                "Trocar Empresa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                // volta o combo para a empresa atual
                _carregandoEmpresas = true;
                SelecionarEmpresaAtualNoCombo();
                _carregandoEmpresas = false;
                return;
            }

            // 🔥 Atualiza sessão
            Sessao.EmpresaID = empresaID;
            Sessao.EmpresaNome = nomeEmpresa;

            // 🔥 Fecha todas as telas abertas (exceto principal)
            FecharTelasAbertas();

            // 🔥 Atualiza UI
            AtualizaBarraStatus();
            AtualizarTituloFormulario();
        }
        private void SelecionarEmpresaAtualNoCombo()
        {
            foreach (var item in cmbEmpresaToolStrip.Items)
            {
                if (item is EmpresaDTO empresa &&
                    empresa.EmpresaID == Sessao.EmpresaID)
                {
                    cmbEmpresaToolStrip.SelectedItem = item;
                    break;
                }
            }
        }

        private void AtualizarTituloFormulario()
        {
            this.Text = $"GVC ERP - {Sessao.EmpresaNome}";
        }


        private void FecharTelasAbertas()
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (form != this)
                    form.Close();
            }
        }


        private void InicializarRelogio()
        {
            if (timer != null)
                return; // 🔒 impede duplicidade

            timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Start();
        }


        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            if (IsDisposed || !IsHandleCreated)
                return;

            try
            {
                BeginInvoke(new Action(() =>
                {
                    if (IsDisposed) return;

                    lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    lblHoraAtual.Text = DateTime.Now.ToString("HH:mm:ss");
                }));
            }
            catch (ObjectDisposedException)
            {
                // ignora – formulário já foi fechado
            }
        }


        private void btnPDV_Click(object sender, EventArgs e)
        {
            FrmPDVendas frm = new FrmPDVendas();
            frm.Show();
        }


        private void btnBackup_Click(object sender, EventArgs e)
        {
            FrmBackup frm = new FrmBackup();
            frm.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBackup frm = new FrmBackup();
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCliente frm = new FrmCadCliente();
            frm.StatusOperacao = "NOVO";
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusOperacao = "NOVO";
            FrmCadProdutos frm = new FrmCadProdutos(StatusOperacao);

            frm.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadFornecedor frm = new FrmCadFornecedor();
            frm.StatusOperacao = "NOVO";
            frm.Show();
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManutEmpresa frm = new FrmManutEmpresa("NOVO");
            frm.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadUser frm = new FrmCadUser(StatusOperacao);
            StatusOperacao = "NOVO";
            frm.Show();
        }

        private void pDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPDVendas frm = new FrmPDVendas();
            frm.Show();
        }


        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFinanceiro frm = new FrmFinanceiro();
            frm.Show();
        }

        private void financeiroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRelatoriosFinanceiros frm = new FrmRelatoriosFinanceiros();
            frm.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorioEstoque frm = new FrmRelatorioEstoque();
            frm.Show();
        }

        private bool JaExisteBackupHoje()
        {
            string flag = Path.Combine(PastaBackupAutomatica, "backup.ok");

            if (!File.Exists(flag))
                return false;

            return File.GetLastWriteTime(flag).Date == DateTime.Today;
        }

        private void RealizarBackupAutomatico()
        {
            try
            {
                if (!Directory.Exists(PastaBackupAutomatica))
                    Directory.CreateDirectory(PastaBackupAutomatica);

                string nomeArquivo = $"Backup_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
                string destino = Path.Combine(PastaBackupAutomatica, nomeArquivo);

                using (var con = Conexao.Conex())
                {
                    con.Open();

                    string sql = $@"BACKUP DATABASE [bdsiscontrol]
                            TO DISK = @Destino
                            WITH INIT";

                    using (var cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Destino", destino);
                        cmd.CommandTimeout = 0;
                        cmd.ExecuteNonQuery();
                    }
                    File.WriteAllText(
                    Path.Combine(PastaBackupAutomatica, "backup.ok"),
                    DateTime.Now.ToString());

                }
            }
            catch
            {
                // SILENCIOSO: não mostra mensagem
            }
        }


        private void IniciarBackupAutomatico()
        {
            // garante que não duplica evento
            timerBackupAtomatico.Stop();
            timerBackupAtomatico.Tick -= timerBackupAtomatico_Tick;

            timerBackupAtomatico.Interval = 1000 * 60 * 60 * 6; // a cada 6 horas

            timerBackupAtomatico.Tick += timerBackupAtomatico_Tick;
            timerBackupAtomatico.Start();
        }
        private int BuscarPrimeiraEmpresaId()
        {
            string sql = "SELECT TOP 1 EmpresaID FROM Empresa ORDER BY EmpresaID ASC";

            using (var con = Conexao.Conex())
            using (var cmd = new SqlCommand(sql, con))
            {
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    _empresaId = Convert.ToInt32(result);
                }
            }

            return _empresaId;
        }
        private async void BuscarAtualizacaoSistema()
        {
            await GVC.Infra.Update.UpdateService.VerificarAtualizacaoAsync(false);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            _carregandoEmpresas = true;

            Utilitario.CarregarEmpresaToolStrip(cmbEmpresaToolStrip);
            ConfigurarComboEmpresaOwnerDraw(); // 🔥 aqui
            _carregandoEmpresas = false;
            cmbEmpresaToolStrip.Width = 380;
            cmbEmpresaToolStrip.ComboBox.TabStop = false;


            AplicarFundoEmpresa(Sessao.FundoTela);
            BuscarAtualizacaoSistema();
            AtualizarTituloFormulario();
            BuscarPrimeiraEmpresaId();
            IniciarBackupAutomatico();
            AtualizaBarraStatus();
            InicializarRelogio();
        }
        private void AtualizaBarraStatus()
        {

            var version = Assembly.GetExecutingAssembly()
                                  .GetName()
                                  .Version?.ToString();

            lblVersaoSistema.Text = $"SGVendas • Versão {version} • © 2026 WR Soft";

            // Obtém o caminho do diretório de execução
            string currentPath = Path.GetDirectoryName(Application.ExecutablePath);

            // Atualiza a label de usuário na barra de status
            string usuarioLogado = FrmLogin.UsuarioConectado;
            string nivelAcesso = FrmLogin.NivelAcesso;

            lblTipoUsuarioo.Text = $"{nivelAcesso}";

            lblUsuarioLogadoo.Text = Sessao.NomeUsuario;
            lblEmpresa.Text = $"Empresa: {Sessao.EmpresaNome}";

            // Atualiza a data
            string data = DateTime.Now.ToLongDateString();
            data = data.Substring(0, 1).ToUpper() + data.Substring(1);
            lblData.Text = data;

            // Exibe informações do computador
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            var informacao = Environment.UserName;
            var nomeComputador = Environment.MachineName;

            lblEstacao.Text = nomeComputador;
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHoraAtual.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnContasAReceber_Click(object sender, EventArgs e)
        {
            FrmFinanceiro frm = new FrmFinanceiro();
            frm.Show();

        }
        private void timerBackupAtomatico_Tick(object sender, EventArgs e)
        {
            if (_backupEmExecucao)
                return;

            _backupEmExecucao = true;

            try
            {
                if (JaExisteBackupHoje())
                    return;

                RealizarBackupAutomatico();
            }
            finally
            {
                _backupEmExecucao = false;
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmManutCliente frm = new FrmManutCliente(StatusOperacao);
            StatusOperacao = "NOVO";
            frm.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmManutUsuario frm = new FrmManutUsuario(StatusOperacao);
            StatusOperacao = "NOVO";
            frm.Show();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            FrmManutFornecedor frm = new FrmManutFornecedor(StatusOperacao);
            StatusOperacao = "NOVO";
            frm.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FrmManutProduto frm = new FrmManutProduto(StatusOperacao);
            StatusOperacao = "NOVO";
            frm.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            //FrmPDVendas frm = new FrmPDVendas();
            //frm.Show();
            FrmPDV frm = new FrmPDV();
            frm.Show();

        }

        private void btnContasReceber_Click(object sender, EventArgs e)
        {
            FrmFinanceiro frm = new FrmFinanceiro();
            frm.Show();
        }
        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            FrmRelatoriosFinanceiros frm = new FrmRelatoriosFinanceiros();
            frm.Show();
        }


        private void btnPesquisarPrecos_Click(object sender, EventArgs e)
        {
            FrmPesquisarPreco frm = new FrmPesquisarPreco();
            frm.Show();
        }

        private void btnFerramentas_Click(object sender, EventArgs e)
        {
            FrmConfiguracoes frm = new FrmConfiguracoes(_empresaId);
            frm.Show();
        }

        private void consultarMovimentaçãoDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaMovimentacaoEstoque frm = new FrmConsultaMovimentacaoEstoque();
            frm.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRelatorioProdutos frm = new FrmRelatorioProdutos();
            frm.Show();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Elapsed -= OnTimedEvent;
                timer.Dispose();
                timer = null;
            }
        }

        private void gerenciamentoDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGerenciarVendas frm = new FrmGerenciarVendas();
            frm.Show();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModelo frm = new FrmModelo();
            frm.Show();
        }

        private async void verificarAtualizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await GVC.Infra.Update.UpdateService.VerificarAtualizacaoAsync(true);
        }

        private void correçãoDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMovimentacaoEstoque frmMovimentacaoEstoq = new FrmMovimentacaoEstoque();
            frmMovimentacaoEstoq.Show();

        }

        private void btnCorrecaoEstoque_Click(object sender, EventArgs e)
        {
            FrmMovimentacaoEstoque frmMovimentacaoEstoque = new FrmMovimentacaoEstoque();
            frmMovimentacaoEstoque.Show();
        }

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {  
        }
        private void AplicarFundoEmpresa(string caminhoImagem)
        {
            if (string.IsNullOrWhiteSpace(caminhoImagem))
                return;

            if (!File.Exists(caminhoImagem))
                return;

            picBackground.Image?.Dispose();
            picBackground.Image = Image.FromFile(caminhoImagem);
            picBackground.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManutMarca frm = new FrmManutMarca(StatusOperacao);
            StatusOperacao = "NOVO";
            frm.Show();
        }

        private void entradaDeEstoqueNFeOuManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntradaFiscal frm = new FrmEntradaFiscal();
            frm.Show();
        }

        private void históricoDoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistoricoProduto frm = new FrmHistoricoProduto();
            frm.Show();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManutVendedor frm = new FrmManutVendedor(StatusOperacao);
            StatusOperacao = "NOVO";
            frm.Show();
        }

        private void cmbEmpresaToolStrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_carregandoEmpresas)
                return;

            if (sender is not ToolStripComboBox toolStripCombo)
                return;

            if (toolStripCombo.SelectedItem is not EmpresaDTO empresa)
                return;

            if (empresa.EmpresaID <= 0)
                return;

            // 🎨 Aplica fundo
            AplicarFundoEmpresa(empresa.FundoTela);

            if (Sessao.EmpresaID != empresa.EmpresaID)
            {
                TrocarEmpresa(empresa.EmpresaID, empresa.NomeFantasia);
                Sessao.FundoTela = empresa.FundoTela;
            }
            cmbEmpresaToolStrip.ComboBox.BackColor = Color.LightYellow;            
        }
        private void ConfigurarComboEmpresaOwnerDraw()
        {
            var combo = cmbEmpresaToolStrip.ComboBox;

            combo.DrawMode = DrawMode.OwnerDrawFixed;
            combo.DrawItem -= ComboEmpresa_DrawItem; // evita duplicação
            combo.DrawItem += ComboEmpresa_DrawItem;
        }
        private void ComboEmpresa_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            var combo = (ComboBox)sender!;
            var item = (EmpresaDTO)combo.Items[e.Index];

            e.DrawBackground();

            bool empresaAtiva = item.EmpresaID == Sessao.EmpresaID;

            var fonte = empresaAtiva ? new Font(combo.Font, FontStyle.Bold) : combo.Font;

            var corTexto = empresaAtiva ? Color.DarkGreen : Color.Black;

            TextRenderer.DrawText(e.Graphics, item.NomeFantasia, fonte,  e.Bounds, corTexto,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

            e.DrawFocusRectangle();
        }

    }
}