using GVC.DALL;
using GVC.Model;
using GVC.UTIL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GVC.View
{
    public partial class FrmConfiguracoes : KryptonForm
    {
        private readonly int _empresaId;

        public FrmConfiguracoes(int empresaId)
        {
            InitializeComponent();
            _empresaId = empresaId;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConfiguracoes_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            int empresaId = 1; // ou pegar a empresa selecionada do sistema
            FrmConfigLogo frm = new FrmConfigLogo();
            frm.ShowDialog();
        }


        private void FrmConfiguracoes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnCertificadoDigital_Click(object sender, EventArgs e)
        {
            new FrmConfigCertificado(_empresaId).ShowDialog();
        }
    }
}
