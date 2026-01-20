using Microsoft.Data.SqlClient;
using System.Reflection;

namespace GVC.Infra.Database
{
    internal static class ScriptSqlEmbeddedExecutor
    {
        public static void EnsureDatabase(string masterConnectionString)
        {
            foreach (var script in ScriptManifest.Scripts)
            {
                ExecutarScript(script, masterConnectionString);
            }
        }

        private static void ExecutarScript(string scriptName, string masterCs)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName =
                $"GVC.Infra.Database.Scripts.{scriptName}";

            using var stream = assembly.GetManifestResourceStream(resourceName)
                ?? throw new InvalidOperationException($"Script não encontrado: {scriptName}");

            using var reader = new StreamReader(stream);
            var scriptSql = reader.ReadToEnd();

            using var conn = new SqlConnection(masterCs);
            conn.Open();

            using var cmd = new SqlCommand(scriptSql, conn)
            {
                CommandTimeout = 0
            };

            cmd.ExecuteNonQuery();
        }
    }
}
