using GVC.DALL;
using GVC.MODEL;
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
        private bool _logoAlterada = false;
        private bool _certificadoAlterado = false;

        private readonly EmpresaDal _empresaDal = new EmpresaDal();
        private EmpresaModel empresa;
        private readonly int _empresaId;
        public decimal ValorEstorno { get; private set; }
        public string Motivo { get; private set; }

        public FrmConfiguracoes(int empresaId)
        {
            InitializeComponent();
            _empresaId = empresaId;
        }
        private void CarregarLogo(int empresaId)
        {
            var logoBytes = EmpresaDal.ObterImagem(empresaId);
            picLogo.Image = Utilitario.BytesParaImagem(logoBytes);
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

        private void btnAlterarLogo_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Imagens (*.png;*.jpg)|*.png;*.jpg"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picLogo.Image = Image.FromFile(ofd.FileName);
                _logoAlterada = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_logoAlterada)
            {
                var bytes = Utilitario.ImagemParaBytes(picLogo.Image);
                _empresaDal.Atualizar(empresa, bytes);
            }

            if (_certificadoAlterado)
            {
                empresa.CertificadoDigital =
                    Utilitario.SalvarCertificado(txtCertificado.Text, empresa.EmpresaID);

                _empresaDal.Atualizar(empresa);
            }

            Close();
        }

        private void txtSelecionarCertificado_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Certificado Digital (*.pfx)|*.pfx"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtCertificado.Text = ofd.FileName;
                _certificadoAlterado = true;
            }
        }

        private void FrmConfiguracoes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void FrmConfiguracoes_Load(object sender, EventArgs e)
        {
            empresa = _empresaDal.BuscarPorId(_empresaId);
            if (empresa == null)
            {
                MessageBox.Show("Empresa não encontrada.");
                Close();
                return;
            }

            CarregarLogo(_empresaId);
            txtCertificado.Text = empresa.CertificadoDigital;
        }
    }
}
