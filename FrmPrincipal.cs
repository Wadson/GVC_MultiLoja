using GVC.BLL;
using GVC.Thema;
using GVC.View;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace GVC
{
    public partial class FrmPrincipal : KryptonForm
    {
        private string StatusOperacao = "";
        // Variável para controlar estado
        bool menuExpandido = true;
        // Importa funções nativas
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormEnPanel(object Form)
        {
            if (this.panelConteiner.Controls.Count > 0)
                this.panelConteiner.Controls.RemoveAt(0);
            Form fh = Form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelConteiner.Controls.Add(fh);
            this.panelConteiner.Tag = fh;
            fh.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmManutUsuario frm = new FrmManutUsuario(StatusOperacao);
            StatusOperacao = "NOVO";
            AbrirFormEnPanel(frm);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmManutCliente frm = new FrmManutCliente(StatusOperacao);
            StatusOperacao = "NOVO";
            AbrirFormEnPanel(frm);
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {

            FrmManutFornecedor frm = new FrmManutFornecedor(StatusOperacao);
            AbrirFormEnPanel(frm);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FrmManutProduto frm = new FrmManutProduto(StatusOperacao);
            StatusOperacao = "NOVO";
            AbrirFormEnPanel(frm);
        }

        private void btnVenda_Click(object sender, EventArgs e)
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

        private void btnContasReceber_Click(object sender, EventArgs e)
        {
            FrmContasReceber frm = new FrmContasReceber();
            AbrirFormEnPanel(frm);
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                // Contrair menu
                panelMenu.Width = 60; // largura mínima para ícones
                foreach (Button btn in panelMenu.Controls.OfType<Button>())
                {
                    btn.Text = ""; // remove texto
                    btn.ImageAlign = ContentAlignment.MiddleCenter; // centraliza ícone
                }
                menuExpandido = false;
            }
            else
            {
                // Expandir menu
                panelMenu.Width = 200; // largura original
                foreach (Button btn in panelMenu.Controls.OfType<Button>())
                {
                    btn.Text = "   " + btn.Tag?.ToString();
                    // usa Tag para armazenar o texto original
                    btn.ImageAlign = ContentAlignment.MiddleLeft; // ícone à esquerda
                }
                menuExpandido = true;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.Bounds = Screen.FromHandle(this.Handle).WorkingArea; // garante ocupar toda a tela
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
