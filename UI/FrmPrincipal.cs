using GVC.BLL;
using GVC.Model;
using GVC.MUI;
using GVC.UTIL;
using GVC.View;
using Krypton.Toolkit;
using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Drawing;
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

        public FrmPrincipal()
        {
            InitializeComponent();
            StatusOperacao = "";
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
            FrmCadEmpresa frm = new FrmCadEmpresa();
            frm.StatusOperacao = "NOVO";
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

                using (var con = Conexao.Conex(Sessao.AmbienteSelecionado))
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


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            BuscarPrimeiraEmpresaId();
            IniciarBackupAutomatico();
            AtualizaBarraStatus();
            InicializarRelogio(); // ✅ inicia UMA vez
        }
        private void AtualizaBarraStatus()
        {
            lblAmbienteStatus.Text = $"Ambiente: {Sessao.AmbienteSelecionado}";
            // Obtém o caminho do diretório de execução
            string currentPath = Path.GetDirectoryName(Application.ExecutablePath);

            // Atualiza a label de usuário na barra de status

            string usuarioLogado = FrmLogin.UsuarioConectado;
            string nivelAcesso = FrmLogin.NivelAcesso;
            lblUsuarioLogadoo.Text = $"{usuarioLogado}";
            lblTipoUsuarioo.Text = $"{nivelAcesso}";

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
            FrmPDVendas frm = new FrmPDVendas();
            frm.Show();
        }

        private void btnContasReceber_Click(object sender, EventArgs e)
        {
            FrmFinanceiro frm = new FrmFinanceiro();
            frm.Show();
        }

        private void btnContasPagar_Click(object sender, EventArgs e)
        {

        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {

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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}