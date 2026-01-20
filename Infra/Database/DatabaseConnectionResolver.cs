using Microsoft.Data.SqlClient;

namespace GVC.Infra.Database
{
    public static class DatabaseConnectionResolver
    {
        public static string ResolverConnectionString()
        {
            return
                "Server=localhost\\SQLEXPRESS;" +
                "Database=bdsiscontrol;" +
                "Integrated Security=True;" +
                "TrustServerCertificate=True;";
        }

        public static string ResolverMasterConnectionString()
        {
            return
                "Server=localhost\\SQLEXPRESS;" +
                "Database=master;" +
                "Integrated Security=True;" +
                "TrustServerCertificate=True;";
        }
    }
}
