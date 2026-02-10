using GVC.BLL;
using GVC.Model;
using GVC.UTIL;
using GVC.View;
using Krypton.Toolkit;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace GVC
{
    public partial class FrmCadMarcas : KryptonForm
    {
        private string QueryMarca = "SELECT MAX(MarcaID) FROM Marca";
        private string StatusOperacao;

        // Variáveis para armazenar os dados
        private int _marcaId;
        private string _nomeMarca;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
       
        public int MarcaID
        {
            get { return _marcaId; }
            set { _marcaId = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NomeMarca
        {
            get { return txtNomeMarca.Text; }
            set { txtNomeMarca.Text = value; }
        }

        public FrmCadMarcas(string statusOperacao, int marcaId = 0, string nomeMarca = "")
        {
            InitializeComponent();
            this.StatusOperacao = statusOperacao;
            _marcaId = marcaId;
            _nomeMarca = nomeMarca;

            // Se for alteração ou exclusão, já carrega os dados
            if (statusOperacao == "ALTERAR" || statusOperacao == "EXCLUSÃO")
            {
                CarregarDados();
            }
        }
       
        // Método para carregar dados na interface
        private void CarregarDados()
        {
            if (!string.IsNullOrEmpty(_nomeMarca))
            {
                txtNomeMarca.Text = _nomeMarca;
            }

            // Armazena o ID para uso posterior
            // Você pode usar uma variável de classe ou um campo oculto
            lblMarcaId.Text = _marcaId.ToString(); // Ou use um TextBox oculto
        }
        // Método público para carregar dados de fora
        public void CarregarDadosParaEdicao(int marcaId, string nomeMarca)
        {
            _marcaId = marcaId;
            _nomeMarca = nomeMarca;
            CarregarDados();
        }



        private void GerarNovoCodigo()
        {
            int novoId = Utilitario.ProximoId(QueryMarca);
            lblMarcaId.Text = novoId.ToString();
            lblMarcaId.Text = Utilitario.ZerosEsquerda(novoId, 4);
        }
        private void ConfigurarCamposPorOperacao()
        {
            switch (StatusOperacao)
            {
                case "NOVO":
                    txtNomeMarca.Enabled = true;
                    txtNomeMarca.Clear();
                    btnSalvar.Text = "Salvar";
                    btnNovo.Enabled = true;
                    break;

                case "ALTERAR":
                    txtNomeMarca.Enabled = true;
                    btnSalvar.Text = "Alterar";
                    btnNovo.Enabled = false;
                    break;

                case "EXCLUSÃO":
                    txtNomeMarca.Enabled = false; // Campo somente leitura
                    btnSalvar.Text = "Excluir";
                    btnNovo.Enabled = false;
                    break;
            }
        }
        // ======================================================
        // SALVAR
        // ======================================================
        private void SalvarRegistro()
        {
            if (string.IsNullOrWhiteSpace(txtNomeMarca.Text))
            {
                Utilitario.Mensagens.Aviso("Informe o nome da marca.");
                txtNomeMarca.Focus();
                return;
            }

            var marca = new MarcaModel
            {
                MarcaID = MarcaID,
                NomeMarca = txtNomeMarca.Text.Trim()
            };

            try
            {
                new MarcaBll().Salvar(marca);
                Utilitario.Mensagens.Info("Marca cadastrada com sucesso!");
                AtualizarManutencao();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro("Erro ao salvar marca: " + ex.Message);
            }
        }

        // ======================================================
        // ALTERAR
        // ======================================================
        private void AlterarRegistro()
        {
            if (string.IsNullOrWhiteSpace(txtNomeMarca.Text))
            {
                Utilitario.Mensagens.Aviso("Informe o nome da marca.");
                txtNomeMarca.Focus();
                return;
            }

            try
            {
                var marca = new MarcaModel
                {
                    MarcaID = MarcaID,
                    NomeMarca = txtNomeMarca.Text.Trim()
                };

                new MarcaBll().Salvar(marca);

                Utilitario.Mensagens.Info("Marca alterada com sucesso!");
                AtualizarManutencao();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso("Erro ao alterar: " + ex.Message);
            }
        }

        // ======================================================
        // EXCLUIR
        // ======================================================
        private void ExcluirRegistro()
        {
            if (MessageBox.Show(
                $"Tem certeza que deseja excluir a marca \"{txtNomeMarca.Text}\"?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new MarcaBll().Excluir(MarcaID);
                    Utilitario.Mensagens.Info("Marca excluída com sucesso!");
                    AtualizarManutencao();
                    this.Close();
                }
                catch (Exception ex)
                {
                    Utilitario.Mensagens.Aviso("Erro ao excluir: " + ex.Message);
                }
            }
        }

        // ======================================================
        // FECHAR + ATUALIZAR MANUTENÇÃO

        // ======================================================
        private void AtualizarManutencao()
        {
            var frm = Application.OpenForms["FrmManutMarca"] as FrmManutMarca;
            frm?.HabilitarTimer(true);
            Utilitario.LimparCampos(this);
            GerarNovoCodigo();
            txtNomeMarca.Focus();
        }


        private void FrmCadUser_Shown(object sender, EventArgs e)
        {
            Utilitario.AplicarCorFocoNosTextBox(this);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Utilitario.LimparCampos(this);
            int novoId = Utilitario.ProximoId(QueryMarca
                );
            MarcaID = novoId;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (StatusOperacao == "NOVO")
                SalvarRegistro();
            else if (StatusOperacao == "ALTERAR")
                AlterarRegistro();
            else if (StatusOperacao == "EXCLUSÃO")
                ExcluirRegistro();
        }

        private void FrmCadMarcas_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

            ConfigurarCamposPorOperacao();

            // Só foca no campo se for NOVO e se o campo estiver vazio
            if (StatusOperacao == "NOVO" && string.IsNullOrEmpty(txtNomeMarca.Text))
            {
                GerarNovoCodigo();
                txtNomeMarca.Focus();
            }

            // Para alteração, já carrega os dados se ainda não carregou
            if ((StatusOperacao == "ALTERAR" || StatusOperacao == "EXCLUSÃO") &&
                string.IsNullOrEmpty(txtNomeMarca.Text) && !string.IsNullOrEmpty(_nomeMarca))
            {
                CarregarDados();
            }
        }

        private void FrmCadMarcas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}