using GVC.Infra.Update;
using System;
using System.Net.Http;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;

public static class UpdateChecker
{
    private const string URL_VERSAO = "https://raw.githubusercontent.com/Wadson/GVC/main/version.json";

    public static async Task<UpdateInfo?> VerificarAsync()
    {
        try
        {
            using var http = new HttpClient();
            var json = await http.GetStringAsync(URL_VERSAO);

            var info = JsonSerializer.Deserialize<UpdateInfo>(json);
            if (info == null) return null;

            var versaoAtual = Assembly.GetEntryAssembly()?.GetName().Version ?? Assembly.GetExecutingAssembly().GetName().Version;

            var versaoOnline = new Version(info.versao);

            return versaoOnline > versaoAtual ? info : null;
        }
        catch
        {
            return null;
        }
    }
}
