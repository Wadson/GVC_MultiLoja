using GVC.BLL;
using GVC.Model;
using GVC.MUI;
using GVC.UTIL;
using GVC.View;
using Krypton.Toolkit;
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
            FrmEntradaEstoque frm = new FrmEntradaEstoque();
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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
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
    }
}