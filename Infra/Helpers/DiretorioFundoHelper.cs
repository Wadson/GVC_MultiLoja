using System;
using System.IO;

namespace GVC.Infra.Helpers
{
    public static class DiretorioFundoHelper
    {
        //public static string ObterDiretorioFundos()
        //{
        //    var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        //    var caminho = Path.Combine(basePath, "GVC", "Fundos");

        //    if (!Directory.Exists(caminho))
        //        Directory.CreateDirectory(caminho);

        //    return caminho;
        //}
        public static string ObterDiretorioFundos()
        {
            var baseDir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "GVC",
                "Fundos"
            );

            Directory.CreateDirectory(baseDir);
            return baseDir;
        }





        // ✅ Caminho do fundo padrão (você coloca um arquivo padrão nessa pasta)
        public static string ObterFundoPadrao()
        {
            var dir = ObterDiretorioFundos();
            return Path.Combine(dir, "fundo_padrao.png");
        }

        // ✅ Validação: o arquivo está dentro da pasta Fundos?
        public static bool EstaDentroDaPastaFundos(string caminho)
        {
            if (string.IsNullOrWhiteSpace(caminho))
                return false;

            try
            {
                var dirFundos = Path.GetFullPath(ObterDiretorioFundos())
                    .TrimEnd(Path.DirectorySeparatorChar) + Path.DirectorySeparatorChar;

                var full = Path.GetFullPath(caminho);

                return full.StartsWith(dirFundos, StringComparison.OrdinalIgnoreCase);
            }
            catch
            {
                return false;
            }
        }
    }
}
