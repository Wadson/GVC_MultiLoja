using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace GVC.Infra.Database
{
    public static class ScriptSqlEmbeddedExecutor
    {
        private const string LOG_TABLE = "__DatabaseScriptLog";

        // ===== PONTO DE ENTRADA =====
        public static void ExecuteScriptsComLog()
        {
            GarantirTabelaLog();

            var scripts = ListarScriptsOrdenados();

            foreach (var script in scripts)
            {
                if (ScriptJaExecutado(script))
                    continue;

                ExecutarScript(script);
                RegistrarExecucao(script);
            }
        }

        // ===== EXECUÇÃO =====
        private static void ExecutarScript(string scriptName)
        {
            var connectionString =
                scriptName.StartsWith("01_")
                    ? DatabaseConnectionResolver.ResolverMasterConnectionString()
                    : DatabaseConnectionResolver.ResolverConnectionString();

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            var sql = LerScriptEmbedded(scriptName);

            foreach (var comando in QuebrarComandos(sql))
            {
                using var cmd = new SqlCommand(comando, conn)
                {
                    CommandTimeout = 0
                };
                cmd.ExecuteNonQuery();
            }
        }

        // ===== LOG =====
        private static void GarantirTabelaLog()
        {
            using var conn = new SqlConnection(
                DatabaseConnectionResolver.ResolverConnectionString());

            conn.Open();

            var sql = $@"
IF NOT EXISTS (
    SELECT 1 FROM sys.tables WHERE name = '{LOG_TABLE}'
)
BEGIN
    CREATE TABLE {LOG_TABLE} (
        ScriptName NVARCHAR(200) NOT NULL PRIMARY KEY,
        DataExecucao DATETIME2 NOT NULL
    );
END";

            using var cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        private static bool ScriptJaExecutado(string script)
        {
            using var conn = new SqlConnection(
                DatabaseConnectionResolver.ResolverConnectionString());

            conn.Open();

            using var cmd = new SqlCommand(
                $"SELECT 1 FROM {LOG_TABLE} WHERE ScriptName = @Script",
                conn);

            cmd.Parameters.AddWithValue("@Script", script);

            return cmd.ExecuteScalar() != null;
        }

        private static void RegistrarExecucao(string script)
        {
            using var conn = new SqlConnection(
                DatabaseConnectionResolver.ResolverConnectionString());

            conn.Open();

            using var cmd = new SqlCommand(
                $"INSERT INTO {LOG_TABLE} VALUES (@Script, GETDATE())",
                conn);

            cmd.Parameters.AddWithValue("@Script", script);
            cmd.ExecuteNonQuery();
        }

        // ===== EMBEDDED RESOURCES =====
        private static List<string> ListarScriptsOrdenados()
        {
            var asm = Assembly.GetExecutingAssembly();

            return asm.GetManifestResourceNames()
                .Where(n => n.Contains(".Infra.Database.") && n.EndsWith(".sql"))
                .OrderBy(n => n)
                .Select(ExtrairNomeArquivo)
                .ToList();
        }

        private static string LerScriptEmbedded(string scriptName)
        {
            var asm = Assembly.GetExecutingAssembly();
            var resourceName = asm.GetManifestResourceNames()
                .FirstOrDefault(n => n.EndsWith(scriptName));

            if (resourceName == null)
                throw new Exception($"Script não encontrado: {scriptName}");

            using var stream = asm.GetManifestResourceStream(resourceName);
            using var reader = new StreamReader(stream, Encoding.UTF8);

            return reader.ReadToEnd();
        }

        private static string ExtrairNomeArquivo(string resourceName)
        {
            return resourceName.Split('.').Last();
        }

        // ===== SUPORTE =====
        private static IEnumerable<string> QuebrarComandos(string sql)
        {
            return sql
                .Split(new[] { "\r\nGO\r\n", "\nGO\n" },
                    StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
