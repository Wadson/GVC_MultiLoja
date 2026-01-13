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
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if (this.IsDisposed || !this.IsHandleCreated)
                return;

            this.Invoke(new Action(() =>
            {
                lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
                lblHoraAtual.Text = DateTime.Now.ToString("HH:mm:ss");
            }));

        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmManutCliente frm = new FrmManutCliente(StatusOperacao);
            StatusOperacao = "NOVO";
            frm.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FrmManutProduto frm = new FrmManutProduto(StatusOperacao);
            StatusOperacao = "NOVO";
            frm.Show();
        }

        private void btnPDV_Click(object sender, EventArgs e)
        {
            FrmPDVendas frm = new FrmPDVendas();
            frm.Show();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {

        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            FrmMovimentacaoEstoque frm = new FrmMovimentacaoEstoque();
            frm.Show();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            FrmBackup frm = new FrmBackup();
            frm.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trocarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void orçamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContasReceber frm = new FrmContasReceber();
            frm.Show();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

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

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void parâmetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            // Corrigido: converte Icon para Bitmap antes de atribuir à propriedade Image
            //picBackground.Image = Properties.Resources.GVC.ToBitmap();
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

            // Configuração do timer para atualizar a hora e a data
            timer = new System.Timers.Timer(1000); // Atualiza a cada segundo

            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
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

        private void btnContasAReceber_Click(object sender, EventArgs e)
        {
            FrmFinanceiro frm = new FrmFinanceiro();
            frm.Show();

        }

        private void iconMenuItem5_Click(object sender, EventArgs e)
        {
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRelatorioProdutos frm = new FrmRelatorioProdutos();
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

        private void correçãoDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMovimentacaoEstoque frm = new FrmMovimentacaoEstoque();
            frm.Show();
        }

        private void correçãoDeEstoqueToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmMovimentacaoEstoque frm = new FrmMovimentacaoEstoque();
            frm.Show();
        }

        private void formaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadFormaPgto frm = new FrmCadFormaPgto();
            frm.StatusOperacao = "NOVO";
            frm.Show();
        }

        private void btnFerramentas_Click(object sender, EventArgs e)
        {
            FrmConfiguracoes frm = new FrmConfiguracoes(_empresaId);
            frm.Show();
        }
    }
}