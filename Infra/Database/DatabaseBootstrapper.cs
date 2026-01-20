using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace GVC.Infra.Database
{
    public static class DatabaseBootstrapper
    {
        public static void EnsureDatabaseCreated()
        {
            var csMaster = DatabaseConnectionResolver
                           .ResolverMasterConnectionString();

            if (BancoExiste(csMaster))
                return;

            ScriptSqlEmbeddedExecutor.EnsureDatabase(csMaster);
        }


        private static string AjustarParaMaster(string cs)
        {
            var builder = new SqlConnectionStringBuilder(cs)
            {
                InitialCatalog = "master"
            };
            return builder.ToString();
        }

        private static bool BancoExiste(string cs)
        {
            using var conn = new SqlConnection(cs);
            conn.Open();

            using var cmd = new SqlCommand(
                "SELECT 1 FROM sys.databases WHERE name = 'bdsiscontrol'",
                conn);

            return cmd.ExecuteScalar() != null;
        }
    }
}

