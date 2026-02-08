
using GVC.UTIL;
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

        private void icbtnBackup_Click(object sender, EventArgs e)
        {
            FrmBackup frmBackup = new FrmBackup();
            frmBackup.ShowDialog();
        }



        private void icbtnCertificadoDigital_Click(object sender, EventArgs e)
        {
            new FrmConfigCertificado(_empresaId).ShowDialog();
        }

        private void icbtnDadosFiscais_Click(object sender, EventArgs e)
        {

        }

        private void icbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void icbtnLogo_Click(object sender, EventArgs e)
        {
            int empresaId = 1; // ou pegar a empresa selecionada do sistema
            FrmConfigLogo frm = new FrmConfigLogo();
            frm.ShowDialog();
        }

        private void icbConvertScript_Click(object sender, EventArgs e)
        {
            FrmSqlBatchGenerator frmConverterScriptBancoSql = new FrmSqlBatchGenerator();
            frmConverterScriptBancoSql.ShowDialog();
        }

        private void FrmConfiguracoes_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

        }
    }
}
