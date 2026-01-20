using GVC.Infra;
using GVC.Infra.Update;
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
        if (info == null || string.IsNullOrWhiteSpace(info.url))
            throw new Exception("URL de atualização inválida.");

        var pastaTemp = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "GVC_Update");

        Directory.CreateDirectory(pastaTemp);

        var caminhoInstalador = Path.Combine(pastaTemp, "GVC_Setup.exe");

        using var http = new HttpClient();
        using var response = await http.GetAsync(
            info.url,
            HttpCompletionOption.ResponseHeadersRead);

        response.EnsureSuccessStatusCode();

        // 🔒 VALIDAÇÃO CRÍTICA
        var contentType = response.Content.Headers.ContentType?.MediaType;
        if (contentType != "application/octet-stream")
            throw new Exception(
                "Link inválido para atualização.\n" +
                "O servidor não retornou um instalador válido."
            );

        await using (var fs = new FileStream(caminhoInstalador, FileMode.Create, FileAccess.Write))
        {
            await response.Content.CopyToAsync(fs);
        }

        Application.Exit();

        Process.Start(new ProcessStartInfo
        {
            FileName = caminhoInstalador,
            UseShellExecute = true
        });
    }

}
