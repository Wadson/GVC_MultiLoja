using Microsoft.Data.SqlClient;
using System;

namespace GVC.Infra.Database
{
    public static class DatabaseBootstrapper
    {
        private const string DATABASE_NAME = "bdsiscontrol";

        public static void EnsureDatabaseCreated(
            Action<int, int, string> onProgress)
        {
            CriarBancoSeNaoExistir();

            // A partir daqui o banco existe
            ScriptSqlEmbeddedExecutor.ExecuteScriptsComLog(onProgress);
        }

        private static void CriarBancoSeNaoExistir()
        {
            using var conn = new SqlConnection(DatabaseConnectionResolver.ResolverMasterConnectionString());

            conn.Open();

            var sql = $@"
IF NOT EXISTS (
    SELECT 1 FROM sys.databases WHERE name = '{DATABASE_NAME}'
)
BEGIN
    CREATE DATABASE [{DATABASE_NAME}];
END";

            using var cmd = new SqlCommand(sql, conn)
            {
                CommandTimeout = 0
            };

            cmd.ExecuteNonQuery();
        }
    }
}
