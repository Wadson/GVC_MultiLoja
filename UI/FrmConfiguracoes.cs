
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

        private void txtBackup_Click(object sender, EventArgs e)
        {
            FrmBackup frmBackup = new FrmBackup();
            frmBackup.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertBanco_Click(object sender, EventArgs e)
        {
        }

        private void FrmModeloUI_Click(object sender, EventArgs e)
        {           
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            int empresaId = 1; // ou pegar a empresa selecionada do sistema
            FrmConfigLogo frm = new FrmConfigLogo();
            frm.ShowDialog();
        }

        private void btnCertificadoDigital_Click(object sender, EventArgs e)
        {
            new FrmConfigCertificado(_empresaId).ShowDialog();
        }

        private void btnDadosFiscais_Click(object sender, EventArgs e)
        {

        }
    }
}
