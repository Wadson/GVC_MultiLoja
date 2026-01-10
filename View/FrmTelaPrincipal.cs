using GVC.BLL;
using GVC.MUI;
using GVC.UTIL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Timers;
using System.Windows.Forms;


namespace GVC.View
{
    public partial class FrmTelaPrincipal : KryptonForm
    {
        private System.Timers.Timer timer;
        public FrmTelaPrincipal()
        {
            InitializeComponent();
            StatusOperacao = "";
        }
        private string StatusOperacao = "";
       

        private void btnUsuario_Click(object sender, EventArgs e)
        {
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmManutCliente frm = new FrmManutCliente(StatusOperacao);
            StatusOperacao = "NOVO";
            frm.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            FrmManutProduto frm = new FrmManutProduto(StatusOperacao);
            StatusOperacao = "NOVO";
            frm.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            //FrmPedidoVendaNovo frm = new FrmPedidoVendaNovo();
            FrmPDVendas frm = new FrmPDVendas();
            frm.Show();
        }

        private void btnFerramentas_Click(object sender, EventArgs e)
        {
            var empresaBll = new EmpresaBll();
            var empresa = empresaBll.ObterTodas().FirstOrDefault();

            if (empresa == null)
            {
                MessageBox.Show("Nenhuma empresa cadastrada.");
                return;
            }

            FrmConfiguracoes frm = new FrmConfiguracoes(empresa.EmpresaID);
            frm.ShowDialog();
        }

        private void btnContaReceber_Click(object sender, EventArgs e)
        {
            FrmContasReceber frm = new FrmContasReceber();
            frm.Show();
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
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
            lblDataa.Text = data;

            // Exibe informações do computador
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            var informacao = Environment.UserName;
            var nomeComputador = Environment.MachineName;

            lblEstacao.Text = nomeComputador;
            lblDataa.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHoraAtuall.Text = DateTime.Now.ToString("HH:mm:ss");

            // Configuração do timer para atualizar a hora e a data
            timer = new System.Timers.Timer(1000); // Atualiza a cada segundo
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            AtualizaBarraStatus();
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmCadCidade frmCadCidade = new FrmCadCidade(StatusOperacao);
            //StatusOperacao = "NOVO";
            //frmCadCidade.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraAtuall.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void cidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmManutCidade frmManutCidade = new FrmManutCidade(StatusOperacao);
            StatusOperacao = "NOVO";
            frmManutCidade.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmManutCliente frm = new FrmManutCliente(StatusOperacao);
            StatusOperacao = "NOVO";
            frm.Show();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManutEstado frm = new FrmManutEstado(StatusOperacao);
            StatusOperacao = "NOVO";
            frm.Show();
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmManutProduto frm = new FrmManutProduto(StatusOperacao);
            StatusOperacao = "NOVO";
            frm.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmManutProduto frm = new FrmManutProduto(StatusOperacao);
            StatusOperacao = "NOVO";
            frm.Show();
        }

        private void btnUsuario_Click_1(object sender, EventArgs e)
        {
            FrmManutUsuario frm = new FrmManutUsuario(StatusOperacao);
            StatusOperacao = "NOVO";
            frm.Show();
        }    

        private void FrmTelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            FrmManutFornecedor frm = new FrmManutFornecedor(StatusOperacao);
            frm.Show();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
        }

        private void cancelarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGerenciarVendas frm = new FrmGerenciarVendas();
            frm.Show();
        }

        private void movimentaçãoDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMovimentacaoEstoque frm = new FrmMovimentacaoEstoque();
            frm.Show();
        }

        private void consultaMovimentaçãoDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaMovimentacaoEstoque frm = new FrmConsultaMovimentacaoEstoque();
            frm.Show();
        }

        private void relatórioEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorioEstoque frm = new FrmRelatorioEstoque();
            frm.Show();
        }

        private void dashbordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
        }

        private void ToolStripMenuItemConfiguracoes_Click(object sender, EventArgs e)
        {           
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManutEmpresa frm = new FrmManutEmpresa(StatusOperacao);
            frm.Show();
        }

        private void formaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManutFormaPgto frm = new FrmManutFormaPgto(StatusOperacao);
            frm.Show();
        }
    }
}
