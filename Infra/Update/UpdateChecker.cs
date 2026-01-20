using GVC.Infra;
using GVC.Infra.Update;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public static class UpdateChecker
{
    private const string URL_VERSAO = "https://raw.githubusercontent.com/Wadson/GVC/main/version.json";

    public static async Task<UpdateInfo> VerificarAsync()
    {
        try
        {
            using var http = new HttpClient();
            var json = await http.GetStringAsync(URL_VERSAO);

            var info = JsonSerializer.Deserialize<UpdateInfo>(json);

            var versaoAtual = new Version(Application.ProductVersion);
            var versaoOnline = new Version(info.versao);

            if (versaoOnline > versaoAtual)
                return info;

            return null;
        }
        catch
        {
            return null; // falha silenciosa
        }
    }
}
