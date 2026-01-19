using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GVC.Infra.Update
{
    public class UpdateInfo
    {
        public string versao { get; set; }
        public string url { get; set; }
        public string descricao { get; set; }
    }

    public static class UpdateService
    {
        private const string VERSION_URL =
            "https://raw.githubusercontent.com/Wadson/GVC/main/version.json";

        public static async Task VerificarAtualizacaoAsync(bool mostrarMensagemSeAtualizado)
        {
            try
            {
                var versaoAtual = Assembly.GetExecutingAssembly()
                                          .GetName()
                                          .Version;

                var info = await ObterVersaoServidorAsync();
                if (info == null)
                {
                    if (mostrarMensagemSeAtualizado)
                        MessageBox.Show(
                            "Não foi possível verificar atualizações no momento.",
                            "Atualização",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                    return;
                }

                var versaoOnline = new Version(info.versao);

                if (versaoOnline <= versaoAtual)
                {
                    if (mostrarMensagemSeAtualizado)
                        MessageBox.Show(
                            "Seu sistema já está atualizado.",
                            "Atualização",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    return;
                }

                var resposta = MessageBox.Show(
                    $"Nova versão disponível!\n\n" +
                    $"Versão atual: {versaoAtual}\n" +
                    $"Nova versão: {versaoOnline}\n\n" +
                    $"{info.descricao}\n\n" +
                    $"Deseja atualizar agora?",
                    "Atualização disponível",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (resposta != DialogResult.Yes)
                    return;

                await BaixarEExecutarAtualizacaoAsync(info.url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao verificar atualização:\n\n" + ex.Message,
                    "Atualização",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


        private static async Task<UpdateInfo> ObterVersaoServidorAsync()
        {
            using var http = new HttpClient();
            http.DefaultRequestHeaders.UserAgent.ParseAdd("GVC-Updater");

            var json = await http.GetStringAsync(VERSION_URL);
            return JsonSerializer.Deserialize<UpdateInfo>(json);
        }

        private static async Task BaixarEExecutarAtualizacaoAsync(string url)
        {
            var pastaTemp = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "GVC_Update");

            Directory.CreateDirectory(pastaTemp);

            var caminhoInstalador = Path.Combine(pastaTemp, "GVC_Setup.exe");

            using var http = new HttpClient();
            http.DefaultRequestHeaders.UserAgent.ParseAdd("GVC-Updater");

            using var response = await http.GetAsync(
                url,
                HttpCompletionOption.ResponseHeadersRead);

            response.EnsureSuccessStatusCode();

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

}
