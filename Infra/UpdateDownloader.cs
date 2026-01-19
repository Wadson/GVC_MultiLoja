using GVC.Infra;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class UpdateDownloader
{
    public static async Task BaixarEAtualizarAsync(UpdateInfo info)
    {
        try
        {
            var pastaTemp = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "GVC_Update");

            Directory.CreateDirectory(pastaTemp);

            var caminhoInstalador = Path.Combine(pastaTemp, "GVC_Setup.exe");

            using var http = new HttpClient();
            using var response = await http.GetAsync(info.url);
            response.EnsureSuccessStatusCode();

            await using (var fs = new FileStream(caminhoInstalador, FileMode.Create, FileAccess.Write))
            {
                await response.Content.CopyToAsync(fs);
            }

            // Abre o instalador
            Process.Start(new ProcessStartInfo
            {
                FileName = caminhoInstalador,
                UseShellExecute = true
            });

            // Fecha o sistema atual
            Application.Exit();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Erro ao baixar atualização:\n\n" + ex.Message,
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}
