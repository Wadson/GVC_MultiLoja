using GVC.DAL;
using GVC.Model;
using GVC.UTIL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;
using static GVC.UTIL.Utilitario;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GVC.View
{
    public partial class FrmConfigLogo : KryptonForm
    {

        private bool _logoAlterada = false;
        private byte[] _logoBytesNovos = null;  // bytes da nova imagem selecionada
        private int _empresaId = 0;  // Agora começa em 0 (nenhuma selecionada)

        // <--- ADICIONE ESTA LINHA AQUI
        private bool _emModoEdicao = false;  // Controla se estamos editando a logo
        public FrmConfigLogo()
        {
            InitializeComponent();
        }
        private void CarregarComboEmpresas()
        {
            try
            {
                var empresas = EmpresaDal.ListarEmpresasSimples();

                if (empresas == null || empresas.Count == 0)
                {
                    Utilitario.Mensagens.Aviso("Nenhuma empresa cadastrada no sistema.");
                    cmbEmpresas.Items.Clear();
                    cmbEmpresas.Enabled = false;
                    _empresaId = 0;
                    btnSalvar.Enabled = false;
                    btnSelecionarLogo.Enabled = false;
                    lblInstrucao.Text = "Nenhuma empresa disponível.";
                    picLogo.Image = Properties.Resources.UsuarioBlue24;
                    return;
                }

                // Configura o ComboBox
                cmbEmpresas.DataSource = null;
                cmbEmpresas.DataSource = empresas;
                cmbEmpresas.DisplayMember = "NomeFantasia";
                cmbEmpresas.ValueMember = "EmpresaID";
                cmbEmpresas.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbEmpresas.Enabled = true;

                // === SELECIONA A PRIMEIRA EMPRESA DIRETAMENTE DA LISTA (SEM DEPENDER DO COMBOBOX) ===
                var empresaSelecionada = empresas[0];  // Pega o primeiro item da lista (índice 0)
                _empresaId = empresaSelecionada.EmpresaID;

                cmbEmpresas.SelectedIndex = 0;  // Apenas para exibir visualmente

                // === ATUALIZA TUDO MANUALMENTE ===
                _emModoEdicao = false;
                _logoAlterada = false;
                _logoBytesNovos = null;

                CarregarLogo();

                btnSalvar.Text = "Alterar";
                btnSalvar.Enabled = true;  // <--- HABILITA O BOTÃO ALTERAR
                btnSelecionarLogo.Enabled = false;
                lblInstrucao.Text = "Clique em 'Alterar' para modificar a logo da empresa selecionada";
                // ================================================================
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro("Erro ao carregar empresas: " + ex.Message);
                cmbEmpresas.Enabled = false;
                btnSalvar.Enabled = false;
            }
        }
        private void FrmConfigLogo_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }

        private void FrmConfigLogo_Load(object sender, EventArgs e)
        {
            btnSalvar.Text = "Alterar";            
            CarregarComboEmpresas();     // <--- Essa linha chama o carregamento            
        }
        private void CarregarLogo()
        {
            try
            {
                if (_empresaId <= 0)
                {
                    picLogo.Image = Properties.Resources.UsuarioBlue24;
                    return;
                }

                var logoBytes = EmpresaDal.ObterImagem(_empresaId);
                picLogo.Image?.Dispose();

                if (logoBytes != null && logoBytes.Length > 0)
                {
                    using var ms = new MemoryStream(logoBytes);
                    picLogo.Image = Image.FromStream(ms);
                }
                else
                {
                    picLogo.Image = Properties.Resources.UsuarioBlue24;
                }

                picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro("Erro ao carregar logo: " + ex.Message);
                picLogo.Image = Properties.Resources.UsuarioBlue24;
            }
        }
        private void btnSelecionarLogo_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Imagens (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _logoBytesNovos = File.ReadAllBytes(ofd.FileName);

                    using var ms = new MemoryStream(_logoBytesNovos);
                    picLogo.Image?.Dispose();
                    picLogo.Image = Image.FromStream(ms);

                    picLogo.SizeMode = PictureBoxSizeMode.Zoom;
                    _logoAlterada = true;
                }
                catch (Exception ex)
                {
                    Utilitario.Mensagens.Erro("Erro ao carregar imagem: " + ex.Message);
                }
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Modo "Alterar" → entra em edição
            if (btnSalvar.Text == "Alterar")
            {
                if (_empresaId <= 0)
                {
                    Mensagens.Aviso("Selecione uma empresa primeiro.");
                    return;
                }

                _emModoEdicao = true;
                ConfigurarEstadoInicial();  // Agora vai habilitar o botão Selecionar Logo
                return;
            }

            // Modo "Salvar"
            if (!_logoAlterada || _logoBytesNovos == null || _logoBytesNovos.Length == 0)
            {
                Mensagens.Aviso("Selecione uma nova imagem antes de salvar.");
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            try
            {
                EmpresaDal.AtualizarLogo(_empresaId, _logoBytesNovos);
                Mensagens.Info("Logo atualizada com sucesso!");

                _logoAlterada = false;
                _logoBytesNovos = null;
                _emModoEdicao = false;  // Sai do modo edição

                CarregarLogo(); // Recarrega para mostrar a nova
                ConfigurarEstadoInicial(); // Volta ao estado inicial
            }
            catch (Exception ex)
            {
                Mensagens.Erro("Erro ao salvar: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ConfigurarEstadoInicial()
        {
            bool temEmpresa = _empresaId > 0;

            if (_emModoEdicao)
            {
                btnSalvar.Text = "Salvar";
                btnSelecionarLogo.Enabled = true;
                lblInstrucao.Text = "Selecione uma nova imagem e clique em Salvar";
            }
            else
            {
                btnSalvar.Text = "Alterar";
                btnSelecionarLogo.Enabled = false;
                lblInstrucao.Text = temEmpresa
                    ? "Clique em 'Alterar' para modificar a logo"
                    : "Selecione uma empresa na lista acima";
            }

            btnSalvar.Enabled = temEmpresa || _emModoEdicao;  // Habilita se tem empresa OU está editando
        }
        private void cmbEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpresas.SelectedIndex < 0)
            {
                _empresaId = 0;
            }
            else
            {
                // Pega direto da lista para garantir
                var empresas = (List<EmpresaSimples>)cmbEmpresas.DataSource;
                var empresaSelecionada = empresas[cmbEmpresas.SelectedIndex];
                _empresaId = empresaSelecionada.EmpresaID;
            }

            _emModoEdicao = false;
            _logoAlterada = false;
            _logoBytesNovos = null;

            CarregarLogo();
            ConfigurarEstadoInicial();  // Ou copie a lógica de habilitação aqui se preferir
        }
    }
}
