using Krypton.Toolkit;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.IO;
using GVC.UTIL;
using GVC.Infra.Conexao;

namespace GVC.MUI
{
    public partial class FrmRecuperarSenhaOffline : KryptonForm
    {
        public FrmRecuperarSenhaOffline()
        {
            InitializeComponent();

            Utilitario.AdicionarEfeitoFocoEmTodos(this);
            Utilitario.ConfigurarEnterComoTab(this);
        }

        // ====================== REDEFINIR SENHA ======================
        private bool RedefinirSenha(string token, string novaSenha)
        {
            using (var con = Conexao.Conex())
            {
                string query = "SELECT UsuarioID, DataExpiracao FROM TokensRedefinicao WHERE Token = @Token";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Token", token.Trim().ToLower());
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime expira = Convert.ToDateTime(reader["DataExpiracao"]);

                            if (DateTime.Now > expira)
                            {
                                Utilitario.Mensagens.Erro("Token expirado.");
                                return false;
                            }

                            int usuarioID = Convert.ToInt32(reader["UsuarioID"]);
                            string hashSenha = GerarHashSHA256(novaSenha);

                            string update = "UPDATE Usuarios SET Senha = @Senha WHERE UsuarioID = @UsuarioID";
                            using (var cmdUpd = new SqlCommand(update, con))
                            {
                                cmdUpd.Parameters.AddWithValue("@Senha", hashSenha);
                                cmdUpd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                                cmdUpd.ExecuteNonQuery();
                            }

                            string delete = "DELETE FROM TokensRedefinicao WHERE Token = @Token";
                            using (var cmdDel = new SqlCommand(delete, con))
                            {
                                cmdDel.Parameters.AddWithValue("@Token", token.Trim().ToLower());
                                cmdDel.ExecuteNonQuery();
                            }

                            return true;
                        }
                    }
                }
            }
            return false;
        }

        // ====================== HASH SHA256 ======================
        private string GerarHashSHA256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        // ====================== BUSCAR USUÁRIO POR CPF + DATA ======================
        private Usuario ObterUsuarioPorCPFDataNascimento(string cpfDigitado, DateTime dataNascimentoDigitado)
        {
            string cpfLimpo = Utilitario.ApenasNumeros(cpfDigitado ?? string.Empty).Trim();
            DateTime dataNascimento = dataNascimentoDigitado.Date; // pega só a parte da data

            try
            {
                using (var con = Conexao.Conex())
                {
                    string sql = @"
                SELECT UsuarioID, Email
                FROM Usuarios
                WHERE REPLACE(REPLACE(REPLACE(CPF, '.', ''), '-', ''), ' ', '') = @CPF
                  AND CAST(DataNascimento AS DATE) = @DataNasc";   // ✅ ajuste para SQL Server

                    using (var cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@CPF", cpfLimpo);
                        cmd.Parameters.AddWithValue("@DataNasc", dataNascimento);

                        con.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Usuario
                                {
                                    UsuarioID = Convert.ToInt32(reader["UsuarioID"]),
                                    Email = reader["Email"].ToString()
                                };
                            }
                        }

                        // Se não achou com data, tenta só pelo CPF
                        string sqlCpfOnly = @"
                    SELECT UsuarioID, Email, DataNascimento
                    FROM Usuarios
                    WHERE REPLACE(REPLACE(REPLACE(CPF, '.', ''), '-', ''), ' ', '') = @CPFOnly";

                        using (var cmd2 = new SqlCommand(sqlCpfOnly, con))
                        {
                            cmd2.Parameters.AddWithValue("@CPFOnly", cpfLimpo);
                            using (var r2 = cmd2.ExecuteReader())
                            {
                                var debugLines = new List<string>
                        {
                            "=== DEBUG ObterUsuarioPorCPFDataNascimento ===",
                            "Pesquisa CPF (limpo): " + cpfLimpo,
                            "Pesquisa Data: " + dataNascimento.ToString("yyyy-MM-dd"),
                            "Resultados encontrados:"
                        };

                                while (r2.Read())
                                {
                                    string dbData = r2["DataNascimento"] == DBNull.Value ? "<NULL>" : r2["DataNascimento"].ToString();
                                    debugLines.Add($"UsuarioID={r2["UsuarioID"]}, Email={r2["Email"]}, DataNascimento='{dbData}' (len={dbData?.Length ?? 0})");
                                }

                                try { File.WriteAllLines("debug_recuperacao_usuario.txt", debugLines); } catch { }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                try { File.AppendAllText("debug_recuperacao_usuario.txt", "\nERR: " + ex.ToString()); } catch { }
            }

            return null;
        }


        // ====================== GERAR E SALVAR TOKEN ======================
        private string GerarToken() => Guid.NewGuid().ToString("N");

        private bool SalvarToken(int usuarioID, string token)
        {
            string tokenLower = token.ToLower();

            using (var con = Conexao.Conex())
            {
                string query = @"
                INSERT INTO TokensRedefinicao (UsuarioID, Token, DataExpiracao) 
                VALUES (@UsuarioID, @Token, @DataExpiracao)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                    cmd.Parameters.AddWithValue("@Token", tokenLower);
                    cmd.Parameters.AddWithValue("@DataExpiracao", DateTime.Now.AddMinutes(15));
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ====================== EVENTO: Gerar Token ======================
        private void btnRecuperarSenha_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf = txtCpf.Text.Trim();

                if (!DateTime.TryParse(txtDataNascimento.Text, out DateTime dataNascimento))
                {
                    Utilitario.Mensagens.Erro("Data de nascimento inválida.");
                    return;
                }

                var usuario = ObterUsuarioPorCPFDataNascimento(cpf, dataNascimento);
                if (usuario == null)
                {
                    Utilitario.Mensagens.Aviso("CPF ou Data de Nascimento não encontrados.");
                    return;
                }

                string token = GerarToken();
                if (!SalvarToken(usuario.UsuarioID, token))
                {
                    Utilitario.Mensagens.Aviso("Erro ao gerar token.");
                    return;
                }

                txtTokens.Text = token;
                lblTokenInfo.Text = "Token válido por 15 minutos.";

                Utilitario.Mensagens.Aviso("Token gerado com sucesso! Use-o para redefinir sua senha.");

                // *** AGORA SIM — TROCA DE PAINEL ***
                painelRedefinir.BringToFront();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso("Erro inesperado: " + ex.Message);
            }
        }

        // ====================== EVENTO: Redefinir Senha ======================
        private void btnRedefinirPass_Click(object sender, EventArgs e)
        {
            string token = txtTokens.Text.Trim();

            if (string.IsNullOrWhiteSpace(token))
            {
                Utilitario.Mensagens.Aviso("Digite o token recebido.");
                return;
            }

            string novaSenha = txtNovaSenha.Text ?? "";
            string confirmarSenha = txtConfirmarSenha.Text ?? "";

            if (novaSenha.Length != confirmarSenha.Length)
            {
                Utilitario.Mensagens.Aviso("As senhas não conferem!");
                return;
            }

            if (novaSenha.Length < 6)
            {
                Utilitario.Mensagens.Aviso("A senha deve ter pelo menos 6 caracteres.");
                return;
            }

            if (RedefinirSenha(token, novaSenha))
            {
                Utilitario.Mensagens.Aviso("Senha redefinida com sucesso!");
                this.Close();
            }
            else
            {
                Utilitario.Mensagens.Aviso("Token inválido ou expirado.");
            }
        }

        // ====================== BOTÕES ======================
        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();
        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
        private void btnSair_Click(object sender, EventArgs e) => this.Close();

        private void FrmRecuperarSenhaOffline_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                e.Handled = true;
            }
        }

        // ====================== ENTRADA / SAÍDA CPF ======================
        private void txtCpf_Enter(object sender, EventArgs e) =>
            AtivarCampo(txtCpf, pictureBoxCpf, panelCpf, Properties.Resources.cpfAzul24);

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            DesativarCampo(txtCpf, pictureBoxCpf, panelCpf, Properties.Resources.cpfBranco24);
            txtCpf.Text = Utilitario.FormatarCPF(txtCpf.Text);
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            int pos = txtCpf.SelectionStart;
            string formatado = Utilitario.FormatarCPF(txtCpf.Text);

            if (txtCpf.Text != formatado)
            {
                txtCpf.Text = formatado;
                txtCpf.SelectionStart = Math.Min(pos + 1, txtCpf.Text.Length);
            }
        }

        // ====================== ENTRADA / SAÍDA DATA ======================
        private void txtDataNascimento_Enter(object sender, EventArgs e) =>
            AtivarCampo(txtDataNascimento, pictureBoxDataNasc, panelDataNascimento, Properties.Resources.calendarioAzul24);

        private void txtDataNascimento_Leave(object sender, EventArgs e)
        {
            DesativarCampo(txtDataNascimento, pictureBoxDataNasc, panelDataNascimento, Properties.Resources.calendarioBranco24);

            string texto = txtDataNascimento.Text.Trim();
            if (string.IsNullOrWhiteSpace(texto)) return;

            if (DateTime.TryParse(texto, out DateTime dt))
                txtDataNascimento.Text = dt.ToString("dd/MM/yyyy");
            else
                Utilitario.Mensagens.Aviso("Data inválida.");
        }

        private void txtDataNascimento_TextChanged(object sender, EventArgs e)
        {
            string apenasNums = Utilitario.ApenasNumeros(txtDataNascimento.Text);

            if (apenasNums.Length > 8)
                apenasNums = apenasNums.Substring(0, 8);

            string formatado = apenasNums;

            if (apenasNums.Length >= 3)
                formatado = apenasNums.Insert(2, "/");

            if (apenasNums.Length >= 5)
                formatado = formatado.Insert(5, "/");

            int pos = txtDataNascimento.SelectionStart;
            txtDataNascimento.Text = formatado;
            txtDataNascimento.SelectionStart = Math.Min(pos + 1, txtDataNascimento.Text.Length);
        }

        // ====================== ESTILO ======================
        private void AtivarCampo(KryptonTextBox textBox, PictureBox pictureBox, Panel panel, Image imagemAtiva)
        {
            pictureBox.Image = imagemAtiva;
            panel.BackColor = Color.FromArgb(8, 142, 254);
            textBox.ForeColor = Color.FromArgb(78, 184, 206);
            textBox.StateCommon.Back.Color1 = Color.FromArgb(200, 255, 200); // Verde claro
        }

        private void DesativarCampo(KryptonTextBox textBox, PictureBox pictureBox, Panel panel, Image imagemInativa)
        {
            pictureBox.Image = imagemInativa;
            panel.BackColor = Color.White;
            textBox.ForeColor = Color.White;
            textBox.StateCommon.Back.Color1 = Color.White;
        }

        // ====================== CLASSE USUÁRIO ======================
        public class Usuario
        {
            public int UsuarioID { get; set; }
            public string Email { get; set; }
        }

        // ====================== LOAD ======================
        private void FrmRecuperarSenhaOffline_Load(object sender, EventArgs e)
        {
            painelRecuperacao.BringToFront();
        }

        private void txtTokens_Enter(object sender, EventArgs e)
        {
        }

        private void txtNovaSenha_Enter(object sender, EventArgs e)
        {
            AtivarCampo(txtNovaSenha, pictureBoxCpf, panelCpf, Properties.Resources.cpfAzul24);
        }

        private void txtConfirmarSenha_Enter(object sender, EventArgs e)
        {
            AtivarCampo(txtConfirmarSenha, pictureBoxCpf, panelCpf, Properties.Resources.cpfAzul24);
        }

        private void txtNovaSenha_Leave(object sender, EventArgs e)
        {
            DesativarCampo(txtNovaSenha, pictureBoxCpf, panelCpf, Properties.Resources.cpfBranco24);
        }

        private void txtConfirmarSenha_Leave(object sender, EventArgs e)
        {
            DesativarCampo(txtConfirmarSenha, pictureBoxCpf, panelCpf, Properties.Resources.cpfBranco24);
        }
    }
}
