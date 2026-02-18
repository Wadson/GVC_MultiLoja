using FontAwesome.Sharp;
using GVC.DTO;
using GVC.Infra.Conexao;
using GVC.UTIL;
using GVC.View;
using Krypton.Toolkit;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using GVC.Infra.Conexao;

namespace GVC.MUI
{
    public partial class FrmLogin : KryptonForm
    {
        // Propriedades estáticas para armazenar os dados do usuário
        public static string UsuarioConectado { get; set; }
        public static string NivelAcesso { get; set; }
        public static int EmpresaID { get; set; }
        private bool _carregandoEmpresas = true;
        public FrmLogin()
        {
            InitializeComponent();

            this.KeyPreview = true; // habilita o preview das teclas            
        }


        private void ResetarCampos()
        {
            // Usuário
            iconPictureBoxUser.IconChar = IconChar.User;
            iconPictureBoxUser.Visible = false;
            iconPictureBoxUser.IconColor = Color.Blue; // já define azul para quando for ativado
            pnDestaqueUsuario.BackColor = Color.White;
            txtUsuario.ForeColor = Color.White;
            txtUsuario.StateCommon.Back.Color1 = Color.White;

            // Senha
            iconPictureBoxPassword.IconChar = IconChar.UnlockKeyhole;
            iconPictureBoxPassword.Visible = false;
            iconPictureBoxPassword.IconColor = Color.Blue;
            pnDestaqueSenha.BackColor = Color.White;
            txtSenha.ForeColor = Color.White;
            txtSenha.StateCommon.Back.Color1 = Color.White;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AtivarCampo(KryptonTextBox textBox, PictureBox pictureBox, Panel panel, Image imagemAtiva)
        {
            ResetarCampos();

            pictureBox.Image = imagemAtiva;
            panel.BackColor = Color.FromArgb(8, 142, 254);
            textBox.ForeColor = Color.FromArgb(78, 184, 206);

            // Fundo verde claro
            textBox.StateCommon.Back.Color1 = Color.FromArgb(200, 255, 200);
        }

        private void DesativarCampo(KryptonTextBox textBox, PictureBox pictureBox, Panel panel, Image imagemInativa)
        {
            pictureBox.Image = imagemInativa;
            panel.BackColor = Color.White;
            textBox.ForeColor = Color.White;

            // Fundo branco
            textBox.StateCommon.Back.Color1 = Color.White;
        }

        private void txtRepetPass_Leave(object sender, EventArgs e)
        {
            ResetarCampos();
        }

        private void ObterDadosUsuario(string usuario, string senhaHash)
        {
            string query = "SELECT NomeUsuario, TipoUsuario FROM Usuarios WHERE NomeUsuario = @Usuario AND Senha = @Senha";

            using (var con = Conexao.Conex())
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Senha", senhaHash);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        UsuarioConectado = reader["NomeUsuario"].ToString();
                        NivelAcesso = reader["TipoUsuario"].ToString();
                    }
                }
            }
        }
        private UsuarioDTO ValidarLogin(string usuario, string password)
        {
            string senhaHash = GerarHashSHA256(password);

            using (var con = Conexao.Conex())
            {
                // Primeiro: verificar se o usuário existe
                string queryUsuario = "SELECT UsuarioID, NomeUsuario, NomeCompleto, Senha, TipoUsuario FROM Usuarios WHERE NomeUsuario = @Usuario";
                using (SqlCommand cmd = new SqlCommand(queryUsuario, con))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);

                    con.Open();
                    var reader = cmd.ExecuteReader();

                    if (!reader.Read())
                    {
                        // Usuário não encontrado → mas vamos checar se a senha existe em algum usuário
                        con.Close();

                        string querySenha = "SELECT 1 FROM Usuarios WHERE Senha = @Senha";
                        using (var cmdSenha = new SqlCommand(querySenha, con))
                        {
                            cmdSenha.Parameters.AddWithValue("@Senha", senhaHash);
                            con.Open();
                            var senhaReader = cmdSenha.ExecuteReader();

                            if (!senhaReader.Read())
                            {
                                return null; // Usuário e senha incorretos!
                            }
                            else
                            {
                                return null; // Usuário incorreto!
                            }
                        }
                    }

                    // Usuário existe → verificar senha
                    string senhaBanco = reader["Senha"].ToString();

                    if (senhaBanco != senhaHash)
                    {
                        return null; // Senha incorreta!
                    }

                    // Se chegou aqui, login válido
                    var usuarioDto = new UsuarioDTO
                    {
                        UsuarioID = Convert.ToInt32(reader["UsuarioID"]),
                        Usuario = reader["NomeUsuario"].ToString(),
                        NomeCompleto = reader["NomeCompleto"].ToString()
                    };

                    UsuarioConectado = usuarioDto.Usuario;
                    NivelAcesso = reader["TipoUsuario"].ToString();
                    return usuarioDto;
                }
            }
        }
        private bool VerificarSenhaHash(string senhaDigitada, string hashBanco)
        {
            // Gera o hash da senha digitada para comparar com o hash armazenado
            string hashSenhaDigitada = GerarHashSHA256(senhaDigitada);
            return hashSenhaDigitada == hashBanco;
        }
        private string GerarHashSHA256(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            string login = txtUsuario.Text.Trim();
            string password = txtSenha.Text;

            if (EmpresaID <= 0)
            {
                Utilitario.Mensagens.Aviso("Selecione uma empresa para continuar.");
                cmbEmpresa.Focus();
                return;
            }


            UsuarioDTO usuarioLogado = ValidarLogin(login, password);

            if (usuarioLogado != null)
            {
                Utilitario.Mensagens.Info("Login realizado com sucesso!");

                // 🔥 SETA SESSÃO
                var empresa = cmbEmpresa.SelectedItem as EmpresaDTO;

                Sessao.UsuarioID = usuarioLogado.UsuarioID;
                Sessao.NomeUsuario = usuarioLogado.NomeCompleto;
                Sessao.EmpresaID = empresa.EmpresaID;
                Sessao.EmpresaNome = empresa.NomeFantasia;
                Sessao.FundoTela = empresa.FundoTela; // 🔥 ESSENCIAL


                // 🔥 FUNDAMENTAL: DEFINE FUNDO DA EMPRESA
                if (cmbEmpresa.SelectedItem is EmpresaDTO empresaSelecionada)
                    Sessao.FundoTela = empresaSelecionada.FundoTela;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                Utilitario.Mensagens.Erro("Usuário ou senha inválidos.");
            }

        }
        private void txtRepetPass_Validating(object sender, CancelEventArgs e)
        {
            ResetarCampos();
        }
        private void lblEsqueciSenha_Click(object sender, EventArgs e)
        {
            FrmRecuperarSenhaOffline frmRecuperarSenhaOffline = new FrmRecuperarSenhaOffline();
            frmRecuperarSenhaOffline.ShowDialog();
        }
        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                // Exemplo: fecha o formulário
                this.Close();
                e.Handled = true;
            }
        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            iconPictureBoxUser.Visible = true; 
            pnDestaqueUsuario.Visible = true; 
            pnDestaqueUsuario.BackColor = Color.FromArgb(0, 120, 254);
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {

            iconPictureBoxUser.Visible = false; 
            pnDestaqueUsuario.Visible = false;
        }
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            iconPictureBoxPassword.Visible = true;
            pnDestaqueSenha.Visible = true; 
            pnDestaqueSenha.BackColor = Color.FromArgb(0, 120, 254);
        }
        private void txtSenha_Leave(object sender, EventArgs e)
        {          

            iconPictureBoxPassword.Visible = false; 
            pnDestaqueSenha.Visible = false;
        }
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Impede que o Enter dentro do campo acione o login
                e.Handled = true;
                e.SuppressKeyPress = true;

                // Opcional: mover para o próximo campo
                txtSenha.Focus();
            }
        }
        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Impede que o Enter dentro do campo acione o login
                e.Handled = true;
                e.SuppressKeyPress = true;

                // Opcional: acionar o botão de login só aqui
                btnLogin.PerformClick();
            }
        }
       
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Utilitario.CarregarEmpresa(cmbEmpresa);
            _carregandoEmpresas = false;

            // Aguarda um momento para garantir que o combobox foi totalmente carregado
            // Isso evita problemas de timing
            this.BeginInvoke(new Action(() =>
            {
                // Verifica o que está selecionado atualmente
                if (cmbEmpresa.SelectedItem is EmpresaDTO empresaSelecionada)
                {
                    // Se está selecionado "Selecione a empresa" (ID = 0)
                    if (empresaSelecionada.EmpresaID == 0)
                    {
                        // Seleciona a primeira empresa REAL
                        if (cmbEmpresa.Items.Count > 1)
                        {
                            cmbEmpresa.SelectedIndex = 2;
                        }
                    }
                }
            }));

            txtUsuario.Focus();
            var version = Assembly.GetExecutingAssembly().GetName().Version?.ToString();
            this.Text = "Versão: " + version;
        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            Utilitario.AplicarCorFocoNosTextBox(this);
        }

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_carregandoEmpresas)
                return;

            if (cmbEmpresa.SelectedItem is not EmpresaDTO empresa)
                return;

            if (empresa.EmpresaID <= 0)
                return;

            EmpresaID = empresa.EmpresaID;

            // 📍 APLICA FUNDO NO LOGIN
            AplicarFundoEmpresa(empresa.FundoTela);
        }
        private void AplicarFundoEmpresa(string caminhoImagem)
        {
            if (string.IsNullOrWhiteSpace(caminhoImagem))
                return;

            if (!File.Exists(caminhoImagem))
                return;

            // Libera imagem anterior (evita travamento de arquivo)
            //if (picBackground.Image != null)
            //{
            //    picBackground.Image.Dispose();
            //    picBackground.Image = null;
            //}

            using var fs = new FileStream(caminhoImagem, FileMode.Open, FileAccess.Read);
            //picBackground.Image = Image.FromStream(fs);
            //picBackground.SizeMode = PictureBoxSizeMode.StretchImage;
        }

    }
}
