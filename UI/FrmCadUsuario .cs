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
    public partial class FrmCadUser : KryptonForm
    {
        private string QueryUsuario = "SELECT MAX(UsuarioID) FROM Usuarios";
        private string StatusOperacao;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int UsuarioID { get; set; }
        private string HashSenhaAtualNoBanco; // Armazena o hash da senha atual

        public FrmCadUser(string statusOperacao)
        {
            InitializeComponent();
            this.StatusOperacao = statusOperacao;
        }

        public static string HashSHA256(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("x2"));
                return builder.ToString();
            }
        }

        private void ConfigurarCamposPorOperacao()
        {
            // Sempre limpar
            txtSenhaAtual.Text = "";
            txtNovaSenha.Text = "";
            txtRepitaSenha.Text = "";

            if (StatusOperacao == "NOVO")
            {
                lblSenhaAtual.Visible = false;
                txtSenhaAtual.Visible = false;

                lblNovaSenha.Text = "Senha:";
                lblRepitaSenha.Text = "Repita a Senha:";

                txtNovaSenha.Visible = true;
                txtRepitaSenha.Visible = true;

                // Personalização do título
                this.Text = "Novo Usuário";
                this.StateCommon.Header.Content.ShortText.Color1 = Color.Green;
                this.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                this.StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI", 12);
            }
            else if (StatusOperacao == "ALTERAR")
            {
                lblSenhaAtual.Visible = true;
                txtSenhaAtual.Visible = true;

                lblNovaSenha.Text = "Nova Senha (deixe em branco para manter atual):";
                lblRepitaSenha.Text = "Repita a Nova Senha:";

                txtNovaSenha.Visible = true;
                txtRepitaSenha.Visible = true;

                CarregarHashSenhaAtual(); // Carrega o hash real do banco
                // Personalização do título
                this.Text = "Alterar Usuário";
                this.StateCommon.Header.Content.ShortText.Color1 = Color.Orange;
                this.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                this.StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI", 12);
            }
            else if (StatusOperacao == "EXCLUSÃO")
            {
                // Esconde tudo relacionado a senha
                lblSenhaAtual.Visible = false;
                txtSenhaAtual.Visible = false;
                lblNovaSenha.Visible = false;
                txtNovaSenha.Visible = false;
                lblRepitaSenha.Visible = false;
                txtRepitaSenha.Visible = false;
                // Personalização do título
                this.Text = "Excluir Usuário";
                this.StateCommon.Header.Content.ShortText.Color1 = Color.Red;
                this.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                this.StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI", 12);
            }
        }

        private void CarregarHashSenhaAtual()
        {
            try
            {
                UsuarioBLL bll = new UsuarioBLL();
                HashSenhaAtualNoBanco = bll.ObterSenhaHashPorId(UsuarioID); // Você precisa criar esse método na BLL
            }
            catch
            {
                HashSenhaAtualNoBanco = null;
            }
        }

        private void txtSenhaAtual_TextChanged(object sender, EventArgs e)
        {
            if (StatusOperacao != "ALTERAR") return;

            if (string.IsNullOrEmpty(txtSenhaAtual.Text))
            {
                txtNovaSenha.Enabled = false;
                txtRepitaSenha.Enabled = false;
                txtNovaSenha.Text = "";
                txtRepitaSenha.Text = "";
                return;
            }

            string hashDigitado = HashSHA256(txtSenhaAtual.Text);
            if (hashDigitado == HashSenhaAtualNoBanco)
            {
                txtNovaSenha.Enabled = true;
                txtRepitaSenha.Enabled = true;
                txtNovaSenha.Focus();
                txtSenhaAtual.StateCommon.Border.Color1 = Color.MediumSeaGreen;
            }
            else
            {
                txtNovaSenha.Enabled = false;
                txtRepitaSenha.Enabled = false;
                txtNovaSenha.Text = "";
                txtRepitaSenha.Text = "";
                txtSenhaAtual.StateCommon.Border.Color1 = Color.Crimson;
            }
        }

        public void SalvarRegistro()
        {
            if (string.IsNullOrWhiteSpace(txtNomeUsuario.Text) ||
                string.IsNullOrWhiteSpace(cmbTipoUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtNovaSenha.Text) ||
                txtNovaSenha.Text != txtRepitaSenha.Text)
            {
                Utilitario.Mensagens.Aviso("Preencha todos os campos obrigatórios e confirme a senha!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCPF.Text))
            {
                Utilitario.Mensagens.Aviso("O campo CPF é obrigatório.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !ValidarEmail(txtEmail.Text))
            {
                Utilitario.Mensagens.Aviso("Informe um e-mail válido.");
                return;
            }

            UsuarioModel obj = new UsuarioModel
            {
                UsuarioID = UsuarioID,
                NomeCompleto = txtNomeCompleto.Text,
                NomeUsuario = txtNomeUsuario.Text,
                Email = txtEmail.Text,
                Senha = HashSHA256(txtNovaSenha.Text),
                TipoUsuario = cmbTipoUsuario.Text,
                Cpf = txtCPF.Text,
                DataNascimento = dtpDataNascimento.Value,
                DataCriacao = DateTime.Now
            };

            try
            {
                new UsuarioBLL().Salvar(obj);
                Utilitario.Mensagens.Info("Usuário cadastrado com sucesso!");
                FecharEAtualizarManutencao();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro($"Erro ao salvar usuário: {ex.Message}");
            }
        }

        // Validação simples de e-mail
        private bool ValidarEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        public void AlterarRegistro()
        {
            if (string.IsNullOrWhiteSpace(txtNomeUsuario.Text) || string.IsNullOrWhiteSpace(cmbTipoUsuario.Text))
            {
                Utilitario.Mensagens.Aviso("Preencha os campos obrigatórios!");
                return;
            }

            // Sempre exige senha atual para qualquer alteração
            if (string.IsNullOrEmpty(txtSenhaAtual.Text) || HashSHA256(txtSenhaAtual.Text) != HashSenhaAtualNoBanco)
            {
                Utilitario.Mensagens.Aviso("Senha atual incorreta!");
                txtSenhaAtual.Focus();
                return;
            }

            // Se quiser alterar senha, valida repetição
            string senhaFinal = HashSenhaAtualNoBanco; // mantém a senha atual por padrão
            if (!string.IsNullOrEmpty(txtNovaSenha.Text))
            {
                if (txtNovaSenha.Text != txtRepitaSenha.Text)
                {
                    Utilitario.Mensagens.Aviso("A nova senha e a repetição não coincidem!");
                    return;
                }
                senhaFinal = HashSHA256(txtNovaSenha.Text);
            }

            try
            {
                UsuarioModel obj = new UsuarioModel
                {
                    UsuarioID = UsuarioID,
                    NomeCompleto = txtNomeCompleto.Text,
                    NomeUsuario = txtNomeUsuario.Text,
                    Email = txtEmail.Text,
                    TipoUsuario = cmbTipoUsuario.Text,
                    Cpf = txtCPF.Text,
                    DataNascimento = dtpDataNascimento.Value,
                    Senha = senhaFinal // sempre define senha (atual ou nova)
                };

                new UsuarioBLL().Alterar(obj);

                Utilitario.Mensagens.Info("Usuário alterado com sucesso!");
                FecharEAtualizarManutencao();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso("Erro ao alterar: " + ex.Message);
            }
        }


        public void ExcluirRegistro()
        {
            if (MessageBox.Show($"Tem certeza que deseja excluir o usuário {txtNomeUsuario.Text}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new UsuarioBLL().Excluir(new UsuarioModel { UsuarioID = UsuarioID });
                    Utilitario.Mensagens.Info("Usuário excluído com sucesso!");
                    FecharEAtualizarManutencao();
                }
                catch (Exception ex)
                {
                    Utilitario.Mensagens.Aviso("Erro ao excluir: " + ex.Message);
                }
            }
        }

        private void FecharEAtualizarManutencao()
        {
            var frm = Application.OpenForms["FrmManutUsuario"] as FrmManutUsuario;
            frm?.HabilitarTimer(true);
            this.Close();
        }

        private void FrmCadUser_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

            ConfigurarCamposPorOperacao();

            if (StatusOperacao == "NOVO")
            {
                int novoId = Utilitario.ProximoId(QueryUsuario);
                UsuarioID = novoId;
                txtNovaSenha.Enabled = true;        // Novo usuário: já pode digitar senha
                txtRepitaSenha.Enabled = true;
                lblDataCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                // Define "Operador" como padrão apenas em novo cadastro
                cmbTipoUsuario.SelectedItem = "Operador";
            }
            else if (StatusOperacao == "ALTERAR")
            {
                // Campos de dados pessoais ficam habilitados normalmente
                txtNomeUsuario.Enabled = true;
                txtEmail.Enabled = true;
                txtCPF.Enabled = true;
                cmbTipoUsuario.Enabled = true;
                dtpDataNascimento.Enabled = true;

                // Apenas os campos de senha ficam aguardando a senha atual
                txtSenhaAtual.Enabled = true;
                txtNovaSenha.Enabled = false;       // Só habilita após senha atual correta
                txtRepitaSenha.Enabled = false;
                txtSenhaAtual.Focus();
            }

            txtCPF.KeyPress += Utilitario.MascaraCPF;
        }


        private void txtSenhaAtual_TextChanged_1(object sender, EventArgs e)
        {
            if (StatusOperacao != "ALTERAR") return;

            // Se o campo estiver vazio → desabilita os campos de nova senha (normal)
            if (string.IsNullOrWhiteSpace(txtSenhaAtual.Text))
            {
                txtNovaSenha.Enabled = false;
                txtRepitaSenha.Enabled = false;
                txtNovaSenha.Text = "";
                txtRepitaSenha.Text = "";
                txtSenhaAtual.StateCommon.Border.Color1 = Color.Gray;
                return;
            }

            // Verifica se a senha atual digitada bate com o hash do banco
            string hashDigitado = HashSHA256(txtSenhaAtual.Text);

            if (hashDigitado.Equals(HashSenhaAtualNoBanco, StringComparison.OrdinalIgnoreCase))
            {
                // SENHA ATUAL CORRETA → libera os campos de nova senha
                txtNovaSenha.Enabled = true;
                txtRepitaSenha.Enabled = true;
                txtNovaSenha.Focus();
                txtSenhaAtual.StateCommon.Border.Color1 = Color.MediumSeaGreen;
            }
            else
            {
                // Senha atual errada → bloqueia novamente
                txtNovaSenha.Enabled = false;
                txtRepitaSenha.Enabled = false;
                txtNovaSenha.Text = "";
                txtRepitaSenha.Text = "";
                txtSenhaAtual.StateCommon.Border.Color1 = Color.Crimson;
            }
        }

        private void FrmCadUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void FrmCadUser_Shown(object sender, EventArgs e)
        {
            Utilitario.AplicarCorFocoNosTextBox(this);
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            int pos = txtCPF.SelectionStart;
            string formatado = Utilitario.FormatarCPF(txtCPF.Text);

            if (txtCPF.Text != formatado)
            {
                txtCPF.Text = formatado;
                txtCPF.SelectionStart = Math.Min(pos + 1, txtCPF.Text.Length);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Utilitario.LimparCampos(this);
            int novoId = Utilitario.ProximoId(QueryUsuario);
            UsuarioID = novoId;
            ConfigurarCamposPorOperacao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (StatusOperacao == "NOVO") SalvarRegistro();
            else if (StatusOperacao == "ALTERAR") AlterarRegistro();
            else if (StatusOperacao == "EXCLUSÃO") ExcluirRegistro();
        }
    }
}