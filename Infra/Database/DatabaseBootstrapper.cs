using Microsoft.Data.SqlClient;
using System;
using System.Data.SqlClient;

namespace GVC.Infra.Database
{
    public static class DatabaseBootstrapper
    {
        public static void EnsureDatabaseCreated()
        {
            var csMaster = DatabaseConnectionResolver.ResolverMasterConnectionString();

            if (!BancoExiste(csMaster))
            {
                ScriptSqlEmbeddedExecutor.ExecuteScriptsComLog();
            }
        }


        private static bool BancoExiste(string csMaster)
        {
            using var conn = new SqlConnection(csMaster);
            conn.Open();

            using var cmd = new SqlCommand(
                "SELECT 1 FROM sys.databases WHERE name = 'bdsiscontrol'",
                conn);

            return cmd.ExecuteScalar() != null;
        }
    }
}
