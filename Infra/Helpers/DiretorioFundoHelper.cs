using System;
using System.IO;

namespace GVC.Infra.Helpers
{
    public static class DiretorioFundoHelper
    {
        public static string ObterDiretorioFundos()
        {
            var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var caminho = Path.Combine(basePath, "GVC", "Fundos");

            if (!Directory.Exists(caminho))
                Directory.CreateDirectory(caminho);

            return caminho;
        }
    }
}
