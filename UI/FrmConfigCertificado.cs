using GVC.DAL;
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
    public partial class FrmConfigCertificado : KryptonForm
    {
        private readonly int _empresaId;
        private string _caminhoCertificado;
        private bool _alterado;
        public FrmConfigCertificado(int empresaId)
        {
            InitializeComponent();
            _empresaId = empresaId;
        }


        private void FrmConfigCertificado_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }

        private void FrmConfigCertificado_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

            txtCertificadoDigital.Text = EmpresaDal.ObterCaminhoCertificado(_empresaId);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Certificado Digital (*.pfx)|*.pfx"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtCertificadoDigital.Text = ofd.FileName;
                _caminhoCertificado = ofd.FileName;
                _alterado = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!_alterado)
            {
                Utilitario.Mensagens.Aviso("Nenhuma alteração realizada.");
                return;
            }

            string destino = Utilitario.SalvarCertificado(_caminhoCertificado, _empresaId);

            using var dal = new EmpresaDal();
            dal.AtualizarCertificado(_empresaId, destino);

            Utilitario.Mensagens.Info("Certificado salvo com sucesso.");
            Close();
        }
    }
}
