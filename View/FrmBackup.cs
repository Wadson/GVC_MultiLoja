using Krypton.Toolkit;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using GVC.UTIL;

namespace GVC.View
{
    public partial class FrmBackup : KryptonForm
    {
        public FrmBackup()
        {
            InitializeComponent();
        }

        // Nome do banco de dados no SQL Server (ajuste conforme seu banco real)
        private string NomeBanco => "bdsiscontrol";

        // Caminho padrão para salvar backups (pasta do sistema + Bkp)
        private string GetDefaultBackupFolder()
        {
            // Pega a pasta onde o sistema está rodando
            string pastaSistema = Application.StartupPath;

            // Cria subpasta "Bkp" dentro da pasta do sistema
            string pastaBackup = Path.Combine(pastaSistema, "Bkp");

            if (!Directory.Exists(pastaBackup))
                Directory.CreateDirectory(pastaBackup);

            return pastaBackup;
        }

        // Verifica permissão de gravação no diretório
        private bool VerificarPermissoesGravacao(string caminho)
        {
            try
            {
                if (!Directory.Exists(caminho))
                    Directory.CreateDirectory(caminho);

                string tempFile = Path.Combine(caminho, "gvc_perm_test.tmp");
                using (FileStream fs = File.Create(tempFile)) { }
                File.Delete(tempFile);
                return true;
            }
            catch
            {
                MessageBox.Show("Sem permissão para gravar no diretório selecionado.");
                return false;
            }
        }

        // ================================
        //   GERAR BACKUP (SQL Server)
        // ================================
        private bool RealizarBackupSqlServer(string pastaDestino)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(pastaDestino))
                {
                    Utilitario.Mensagens.Aviso("Selecione a pasta de destino do backup.");
                    return false;
                }

                if (!VerificarPermissoesGravacao(pastaDestino))
                    return false;

                string nomeArquivo = $"Backup_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
                string destino = Path.Combine(pastaDestino, nomeArquivo);

                using (var con = Conexao.Conex(Sessao.AmbienteSelecionado))
                {
                    string sql = $"BACKUP DATABASE [{NomeBanco}] TO DISK = @Destino";
                    using (var cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Destino", destino);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                Utilitario.Mensagens.Aviso($"Backup gerado com sucesso:\n{destino}");
                return true;
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso($"Erro ao gerar backup: {ex.Message}");
                return false;
            }
        }

        // ================================
        //   RESTAURAR BACKUP (SQL Server)
        // ================================
        private bool RestaurarBackupSqlServer(string arquivoBackup)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(arquivoBackup) || !File.Exists(arquivoBackup))
                {
                    Utilitario.Mensagens.Aviso("Arquivo de backup não encontrado ou inválido.");
                    return false;
                }

                var resp = MessageBox.Show(
                    "A restauração irá substituir o banco atual. Deseja prosseguir?\nRecomenda-se fazer backup antes.",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resp != DialogResult.Yes) return false;

                using (var con = Conexao.Conex(Sessao.AmbienteSelecionado))
                {
                    string sql = $"RESTORE DATABASE [{NomeBanco}] FROM DISK = @Arquivo WITH REPLACE";
                    using (var cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Arquivo", arquivoBackup);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                Utilitario.Mensagens.Aviso("Restauração concluída com sucesso!");
                return true;
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso($"Erro ao restaurar backup: {ex.Message}");
                return false;
            }
        }

        private void rbtGerarBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtGerarBackup.Checked)
            {
                lblRotulo.Text = "Escolha o local para salvar o backup";
                txtCaminhoBackup.Text = GetDefaultBackupFolder();
                btnExecutar.Text = "Gerar Backup";
            }
        }

        private void rbtRestaurarBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtRestaurarBackup.Checked)
            {
                lblRotulo.Text = "Escolha o arquivo de backup";
                txtCaminhoBackup.Clear();
                btnExecutar.Text = "Restaurar Backup";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocalBackup_Click(object sender, EventArgs e)
        {
            if (rbtGerarBackup.Checked)
            {
                using (FolderBrowserDialog dialog = new FolderBrowserDialog())
                {
                    dialog.SelectedPath = GetDefaultBackupFolder();
                    if (dialog.ShowDialog() == DialogResult.OK)
                        txtCaminhoBackup.Text = dialog.SelectedPath;
                }
            }
            else if (rbtRestaurarBackup.Checked)
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Filter = "Backup SQL Server (*.bak)|*.bak|Todos os Arquivos (*.*)|*.*";
                    if (dialog.ShowDialog() == DialogResult.OK)
                        txtCaminhoBackup.Text = dialog.FileName;
                }
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string caminho = txtCaminhoBackup.Text?.Trim();

            if (rbtGerarBackup.Checked)
            {
                if (string.IsNullOrWhiteSpace(caminho))
                {
                    Utilitario.Mensagens.Aviso("Selecione o destino do backup.");
                    return;
                }

                RealizarBackupSqlServer(caminho);
            }
            else if (rbtRestaurarBackup.Checked)
            {
                if (string.IsNullOrWhiteSpace(caminho) || !File.Exists(caminho))
                {
                    Utilitario.Mensagens.Aviso("Selecione um arquivo de backup válido para restaurar.");
                    return;
                }

                RestaurarBackupSqlServer(caminho);
            }
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {
        }
    }
}
