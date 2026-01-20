using Microsoft.Data.SqlClient;

namespace GVC.Infra.Database
{
    public static class DatabaseBootstrapper
    {
        private const string DatabaseName = "bdsiscontrol";

        public static void EnsureDatabaseCreated()
        {
            var csMaster =
                DatabaseConnectionResolver.ResolverMasterConnectionString();

            if (BancoExiste(csMaster))
                return;

            ScriptSqlEmbeddedExecutor.EnsureDatabase(csMaster);
        }

        private static bool BancoExiste(string cs)
        {
            using var conn = new SqlConnection(cs);
            conn.Open();

            using var cmd = new SqlCommand(
                "SELECT 1 FROM sys.databases WHERE name = @db",
                conn);

            cmd.Parameters.AddWithValue("@db", DatabaseName);

            return cmd.ExecuteScalar() != null;
        }
    }
}
