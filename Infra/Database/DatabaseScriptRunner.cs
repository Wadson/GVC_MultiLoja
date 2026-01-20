using Microsoft.Data.SqlClient;
using System.Reflection;

namespace GVC.Infra.Database
{
    internal static class DatabaseScriptRunner
    {
        public static void RunScripts(string connectionString)
        {
            foreach (var script in ScriptManifest.Scripts)
            {
                if (ScriptJaExecutado(connectionString, script))
                    continue;

                ExecutarScript(connectionString, script);
            }
        }

        private static bool ScriptJaExecutado(string cs, string scriptName)
        {
            using var conn = new SqlConnection(cs);
            conn.Open();

            using var cmd = new SqlCommand(
                @"SELECT 1 
                  FROM __DatabaseScriptLog 
                  WHERE ScriptName = @script 
                    AND Success = 1",
                conn);

            cmd.Parameters.AddWithValue("@script", scriptName);

            return cmd.ExecuteScalar() != null;
        }

        private static void ExecutarScript(string cs, string scriptName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = $"GVC.Infra.Database.Scripts.{scriptName}";

            using var stream = assembly.GetManifestResourceStream(resourceName)
                ?? throw new InvalidOperationException($"Script não encontrado: {scriptName}");

            using var reader = new StreamReader(stream);
            var sql = reader.ReadToEnd();

            using var conn = new SqlConnection(cs);
            conn.Open();

            using var tran = conn.BeginTransaction();

            try
            {
                using var cmd = new SqlCommand(sql, conn, tran)
                {
                    CommandTimeout = 0
                };

                cmd.ExecuteNonQuery();

                RegistrarLog(conn, tran, scriptName, true, null);

                tran.Commit();
            }
            catch (Exception ex)
            {
                RegistrarLog(conn, tran, scriptName, false, ex.Message);
                tran.Rollback();
                throw;
            }
        }

        private static void RegistrarLog(
            SqlConnection conn,
            SqlTransaction tran,
            string scriptName,
            bool success,
            string? error)
        {
            using var cmd = new SqlCommand(
                @"INSERT INTO __DatabaseScriptLog
                  (ScriptName, ExecutedAt, Success, ErrorMessage)
                  VALUES (@script, GETDATE(), @success, @error)",
                conn, tran);

            cmd.Parameters.AddWithValue("@script", scriptName);
            cmd.Parameters.AddWithValue("@success", success);
            cmd.Parameters.AddWithValue("@error", (object?)error ?? DBNull.Value);

            cmd.ExecuteNonQuery();
        }
    }
}
