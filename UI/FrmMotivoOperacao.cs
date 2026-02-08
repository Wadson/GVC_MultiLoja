using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GVC.UTIL;
using Krypton.Toolkit;

namespace GVC.View
{
    public partial class FrmMotivoOperacao : KryptonForm
    {
        public string Motivo { get; private set; }

        public FrmMotivoOperacao(string titulo)
        {
            InitializeComponent();
            this.Text = titulo;
        }
       
        private void FrmMotivoOperacao_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }

        private void FrmMotivoOperacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void FrmMotivoOperacao_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

            txtMotivo.Focus();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                Utilitario.Mensagens.Aviso("Informe o motivo da operação.");
                return;
            }

            Motivo = txtMotivo.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
