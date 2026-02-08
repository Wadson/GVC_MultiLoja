using GVC.Infra.Update;
using GVC.MUI;
using GVC.View;
using QuestPDF.Infrastructure;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GVC
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            QuestPDF.Settings.License = LicenseType.Community;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.DoEvents();

            // =============================
            // LOGIN
            // =============================

            using (var login = new FrmLogin())
            {
                if (login.ShowDialog() != DialogResult.OK)
                    return;
            }

            // =============================
            // VERIFICAÇÃO DE ATUALIZAÇÃO
            // =============================
            try
            {
                var update =
                    UpdateChecker.VerificarAsync()
                                 .GetAwaiter()
                                 .GetResult();

                if (update != null)
                {
                    MessageBox.Show(
                        $"Nova versão disponível!\n\n" +
                        $"Versão: {update.versao}\n\n" +
                        $"{update.descricao}",
                        "Atualização do Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = update.url,
                        UseShellExecute = true
                    });

                    return; // encerra o sistema
                }
            }
            catch
            {
                // falha silenciosa
            }

            // =============================
            // TELA PRINCIPAL
            // =============================
            Application.Run(new FrmPrincipal());
        }
    }
}
