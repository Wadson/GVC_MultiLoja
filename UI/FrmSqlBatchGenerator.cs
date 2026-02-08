using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GVC.UTIL
{
    public partial class FrmSqlBatchGenerator : KryptonForm
    {
        public FrmSqlBatchGenerator()
        {
            InitializeComponent();
            nudLote.Value = 1000;
        }

        private void btnSelecionarOrigem_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Filter = "SQL (*.sql)|*.sql"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
                txtScriptOrigem.Text = ofd.FileName;
        }

        private void btnSelecionarDestino_Click(object sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog
            {
                Filter = "SQL (*.sql)|*.sql"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
                txtScriptDestino.Text = sfd.FileName;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtScriptOrigem.Text))
                    throw new Exception("Informe o arquivo de script de origem.");

                if (!File.Exists(txtScriptOrigem.Text))
                    throw new FileNotFoundException("Arquivo de origem não encontrado.");

                if (string.IsNullOrWhiteSpace(txtScriptDestino.Text))
                    throw new Exception("Informe o arquivo de destino.");

                var tabela = string.IsNullOrWhiteSpace(txtNomeTabela.Text)
                    ? "Cidade"
                    : txtNomeTabela.Text.Trim();

                var colunas = string.IsNullOrWhiteSpace(txtColunas.Text)
                    ? "CidadeID, Nome, EstadoID, codigoIbge"
                    : txtColunas.Text.Trim();

                var scriptOrigem = File.ReadAllText(txtScriptOrigem.Text, Encoding.UTF8);

                var scriptFinal = GerarScriptBlindado(
                    scriptOrigem,
                    tabela,
                    colunas,
                    (int)nudLote.Value
                );

                File.WriteAllText(txtScriptDestino.Text, scriptFinal, Encoding.UTF8);

                MessageBox.Show(
                    "Script gerado com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Erro ao gerar script",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }


        }
        private string GerarScriptBlindado(
            string scriptOrigem,
            string tabela,
            string colunas,
            int tamanhoLote)
        {
            if (string.IsNullOrWhiteSpace(scriptOrigem))
                throw new Exception("Script de origem vazio.");

            if (string.IsNullOrWhiteSpace(tabela))
                throw new Exception("Informe o nome da tabela.");

            if (string.IsNullOrWhiteSpace(colunas))
                throw new Exception("Informe as colunas.");

            var valores = ExtrairValues(scriptOrigem);

            if (valores.Count == 0)
                throw new Exception("Nenhum VALUES encontrado.");

            var sb = new StringBuilder();

            sb.AppendLine($"IF NOT EXISTS (SELECT 1 FROM dbo.{tabela})");
            sb.AppendLine("BEGIN");
            sb.AppendLine("    SET NOCOUNT ON;");
            sb.AppendLine("    BEGIN TRY");
            sb.AppendLine("        BEGIN TRANSACTION;");
            sb.AppendLine();
            sb.AppendLine($"        SET IDENTITY_INSERT dbo.{tabela} ON;");
            sb.AppendLine();

            int contador = 0;
            foreach (var lote in valores.Chunk(tamanhoLote))
            {
                sb.AppendLine($"        INSERT dbo.{tabela} ({colunas}) VALUES");

                sb.AppendLine(string.Join("," + Environment.NewLine,
                    lote.Select(v => "        " + v)));

                sb.AppendLine(";");
                sb.AppendLine();
                contador += lote.Count();
            }

            sb.AppendLine($"        SET IDENTITY_INSERT dbo.{tabela} OFF;");
            sb.AppendLine("        COMMIT TRANSACTION;");
            sb.AppendLine("    END TRY");
            sb.AppendLine("    BEGIN CATCH");
            sb.AppendLine("        ROLLBACK TRANSACTION;");
            sb.AppendLine("        THROW;");
            sb.AppendLine("    END CATCH");
            sb.AppendLine("END");

            return sb.ToString();
        }

        private List<string> ExtrairValues(string script)
        {
            var lista = new List<string>();

            // Captura: VALUES ( ... )
            var regex = new Regex(
                @"VALUES\s*\((.*?)\)",
                RegexOptions.IgnoreCase | RegexOptions.Singleline
            );

            foreach (Match match in regex.Matches(script))
            {
                lista.Add("(" + match.Groups[1].Value.Trim() + ")");
            }

            return lista;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSqlBatchGenerator_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

        }
    }
}

