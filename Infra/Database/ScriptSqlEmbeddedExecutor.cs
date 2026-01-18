using Microsoft.Data.SqlClient;
using System;
using System.IO;
using System.Reflection;

namespace GVC.Infra.Database
{
    public static class ScriptSqlEmbeddedExecutor
    {
        private const string SCRIPT_RESOURCE =
            "GVC.Infra.Database.ScriptCriacaoBanco.sql";

        public static void EnsureDatabase(string connectionString)
        {
            var script = LerScriptEmbedded();

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            using var cmd = new SqlCommand(script, conn)
            {
                CommandTimeout = 0 // scripts grandes
            };

            cmd.ExecuteNonQuery();
        }

        private static string LerScriptEmbedded()
        {
            var assembly = Assembly.GetExecutingAssembly();

            using var stream = assembly.GetManifestResourceStream(SCRIPT_RESOURCE);

            if (stream == null)
            {
                var recursos = string.Join("\n", assembly.GetManifestResourceNames());
                throw new Exception(
                    "Script SQL embedded não encontrado.\n\nRecursos disponíveis:\n" + recursos);
            }

            using var reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }
    }
}
