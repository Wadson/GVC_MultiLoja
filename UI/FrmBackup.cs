using FontAwesome.Sharp;
using GVC.UTIL;
using Krypton.Toolkit;
using Microsoft.Data.SqlClient;
using System;
using System.IO;
using System.Windows.Forms;
using GVC.Infra.Conexao;

namespace GVC.View
{
    public partial class FrmBackup : KryptonForm
    {
        private string PastaBackupAutomatica => @"C:\BackupsGVC";

        public FrmBackup()
        {
            InitializeComponent();
        }
        private enum ModoBackup
        {
            Gerar,
            Restaurar
        }

        private ModoBackup _modoAtual;

        // ================================
        // CONFIGURAÇÕES
        // ================================

        private string NomeBanco => "bdgvc";

        private string PastaBackupPadrao => @"C:\GVCSqlExpress\Bkp";


        // ================================
        // UTILITÁRIOS
        // ================================

        private string GetDefaultBackupFolder()
        {
            if (!Directory.Exists(PastaBackupPadrao))
                Directory.CreateDirectory(PastaBackupPadrao);

            return PastaBackupPadrao;
        }

        private bool VerificarPermissoesGravacao(string caminho)
        {
            try
            {
                string arquivoTeste = Path.Combine(caminho, "perm_test.tmp");
                using (File.Create(arquivoTeste)) { }
                File.Delete(arquivoTeste);
                return true;
            }
            catch
            {
                Utilitario.Mensagens.Aviso(
                    "O SQL Server não possui permissão para gravar na pasta selecionada.\n" +
                    "Verifique as permissões do serviço MSSQL."
                );
                return false;
            }
        }

        // ================================
        // GERAR BACKUP
        // ================================

        private string RealizarBackupSqlServer(string pastaDestino, bool silencioso = false)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(pastaDestino))
                    return null;

                if (!Directory.Exists(pastaDestino))
                    Directory.CreateDirectory(pastaDestino);

                if (!VerificarPermissoesGravacao(pastaDestino))
                    return null;

                string nomeArquivo = $"Backup_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
                string destino = Path.Combine(pastaDestino, nomeArquivo);

                bool suportaCompression;

                using (var con = Conexao.Conex())
                {
                    con.Open();

                    using (var cmdEdicao = new SqlCommand(
                        "SELECT SERVERPROPERTY('Edition')", con))
                    {
                        string edicao = cmdEdicao.ExecuteScalar()?.ToString() ?? "";
                        suportaCompression = !edicao.Contains("Express", StringComparison.OrdinalIgnoreCase);
                    }

                    string sqlBackup = suportaCompression
                        ? $@"BACKUP DATABASE [{NomeBanco}] TO DISK = @Destino WITH INIT, COMPRESSION"
                        : $@"BACKUP DATABASE [{NomeBanco}] TO DISK = @Destino WITH INIT";

                    using (var cmdBackup = new SqlCommand(sqlBackup, con))
                    {
                        cmdBackup.Parameters.AddWithValue("@Destino", destino);
                        cmdBackup.CommandTimeout = 0;
                        cmdBackup.ExecuteNonQuery();
                    }
                }

                if (!File.Exists(destino))
                    return null;

                if (!silencioso)
                {
                    Utilitario.Mensagens.Info(
                        $"Backup gerado com sucesso!\n\nArquivo:\n{destino}"
                    );
                }

                return destino;
            }
            catch (Exception ex)
            {
                if (!silencioso)
                {
                    Utilitario.Mensagens.Aviso(
                        $"Erro ao gerar backup:\n{ex.Message}"
                    );
                }
                return null;
            }
        }




        // ================================
        // RESTAURAR BACKUP
        // ================================

        private bool RestaurarBackupSqlServer(string arquivoBackup)
        {
            SqlConnection con = null;

            try
            {
                // ================================
                // VALIDAÇÕES
                // ================================

                if (string.IsNullOrWhiteSpace(arquivoBackup))
                {
                    Utilitario.Mensagens.Aviso("Informe o arquivo de backup.");
                    return false;
                }

                if (!File.Exists(arquivoBackup))
                {
                    Utilitario.Mensagens.Aviso("Arquivo de backup não encontrado.");
                    return false;
                }

                string pastaPermitida = GetDefaultBackupFolder();

                if (!arquivoBackup.StartsWith(pastaPermitida, StringComparison.OrdinalIgnoreCase))
                {
                    Utilitario.Mensagens.Aviso(
                        "O arquivo de backup deve estar localizado em:\n\n" + pastaPermitida
                    );
                    return false;
                }

                var resp = MessageBox.Show(
                    "ATENÇÃO!\n\n" +
                    "A restauração irá SUBSTITUIR o banco atual.\n" +
                    "Todas as conexões ativas serão encerradas.\n\n" +
                    "Deseja continuar?",
                    "Confirmação de Restauração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resp != DialogResult.Yes)
                    return false;

                // ================================
                // EXECUÇÃO SEGURA
                // ================================

                con = Conexao.Conex();
                con.Open();

                // IMPORTANTE: usa master
                con.ChangeDatabase("master");

                string sql = $@"
ALTER DATABASE [{NomeBanco}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
RESTORE DATABASE [{NomeBanco}] FROM DISK = @Arquivo WITH REPLACE;
ALTER DATABASE [{NomeBanco}] SET MULTI_USER;";

                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Arquivo", arquivoBackup);
                    cmd.CommandTimeout = 0; // sem timeout
                    cmd.ExecuteNonQuery();
                }

                Utilitario.Mensagens.Info("Banco restaurado com sucesso!");
                return true;
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso(
                    "Erro ao restaurar backup:\n\n" + ex.Message
                );
                return false;
            }
            finally
            {
                // ================================
                // GARANTIA DE SEGURANÇA
                // ================================

                try
                {
                    if (con != null && con.State == System.Data.ConnectionState.Open)
                    {
                        using (var cmd = new SqlCommand(
                            $"ALTER DATABASE [{NomeBanco}] SET MULTI_USER;", con))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch
                {
                    // Evita exceção em cascata
                }
                finally
                {
                    con?.Close();
                    con?.Dispose();
                }
            }
        }

        private void AtualizarLayoutBackup(
    string rotulo,
    string textoBotao,
    IconChar iconeAcao,
    IconChar iconeCaminho,
    IconChar iconeBotao,
    Color corAcao)
        {
            lblRotulo.Text = rotulo;
            btnExecutar.Text = textoBotao;

            iconAcao.IconChar = iconeAcao;
            iconAcao.IconColor = corAcao;

            iconCaminho.IconChar = iconeCaminho;
            iconCaminho.IconColor = Color.Gray;

            btnExecutar.IconChar = iconeBotao;
            btnExecutar.IconColor = Color.White;
        }

        // ================================
        // EVENTOS
        // ================================

        private void FrmBackup_Load(object sender, EventArgs e)
        {
            // Estado inicial do formulário
            rbtGerarBackup.Checked = true;
            txtCaminhoBackup.Text = GetDefaultBackupFolder();
            lblRotulo.Text = "Local onde o backup será salvo";
            btnExecutar.Text = "Gerar Backup";
        }

        private void rbtGerarBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbtGerarBackup.Checked) return;

            _modoAtual = ModoBackup.Gerar;
            txtCaminhoBackup.Text = GetDefaultBackupFolder();

            AtualizarLayoutBackup(
                "Local onde o backup será salvo",
                "Gerar",
                IconChar.Upload,
                IconChar.FolderOpen,
                IconChar.Save,
                Color.DodgerBlue
            );
        }

        private void rbtRestaurarBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbtRestaurarBackup.Checked) return;

            _modoAtual = ModoBackup.Restaurar;
            txtCaminhoBackup.Clear();

            AtualizarLayoutBackup(
                "Selecione o arquivo de backup",
                "Restaurar",
                IconChar.Download,
                IconChar.FileArchive,
                IconChar.Database,
                Color.SeaGreen
            );
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string caminho = txtCaminhoBackup.Text?.Trim();

            if (string.IsNullOrWhiteSpace(caminho))
            {
                Utilitario.Mensagens.Info("Atenção! Informe o caminho do backup.");
                return;
            }

            if (rbtRestaurarBackup.Checked)
            {
                RestaurarBackupSqlServer(caminho);
            }
            else
            {
                RealizarBackupSqlServer(caminho, silencioso: false);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLocalBackup_Click(object sender, EventArgs e)
        {
            if (rbtGerarBackup.Checked)
            {
                using (var dialog = new FolderBrowserDialog())
                {
                    dialog.SelectedPath = GetDefaultBackupFolder();
                    if (dialog.ShowDialog() == DialogResult.OK)
                        txtCaminhoBackup.Text = dialog.SelectedPath;
                }
            }
            else
            {
                using (var dialog = new OpenFileDialog())
                {
                    dialog.Filter = "Backup SQL Server (*.bak)|*.bak";
                    if (dialog.ShowDialog() == DialogResult.OK)
                        txtCaminhoBackup.Text = dialog.FileName;
                }
            }
        }
    }
}
