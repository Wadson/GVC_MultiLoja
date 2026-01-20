using System.Reflection;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace GVC.Infra.Database
{
    public static class ScriptSqlEmbeddedExecutor
    {
        private const string SCRIPT_RESOURCE ="GVC.Infra.Database.ScriptCriacaoBanco.sql";

        public static void EnsureDatabase(string connectionString)
        {
            var script = LerScriptEmbedded();

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            using var cmd = new SqlCommand(script, conn)
            {
                CommandTimeout = 0
            };

            cmd.ExecuteNonQuery();
        }

        private static string LerScriptEmbedded()
        {
            var assembly = Assembly.GetExecutingAssembly();

            using var stream = assembly.GetManifestResourceStream(SCRIPT_RESOURCE);

            if (stream == null)
                throw new Exception("Script SQL não encontrado: " + SCRIPT_RESOURCE);

            using var reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }
    }

}
