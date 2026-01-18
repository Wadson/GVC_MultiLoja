using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace GVC.Infra.Database
{
    public static class DatabaseConnectionResolver
    {
        public static string ResolverConnectionString()
        {
            var servidores = new[]
            {
                @"WR-PC\SQLEXPRESS",
                @".\SQLEXPRESS",
                ".",
                @"(localdb)\MSSQLLocalDB"
            };

            foreach (var servidor in servidores)
            {
                var cs =
                    $"Server={servidor};" +
                    $"Trusted_Connection=True;" +
                    $"TrustServerCertificate=True;";

                try
                {
                    using var conn = new SqlConnection(cs);
                    conn.Open();
                    return cs; // ✅ encontrou servidor válido
                }
                catch
                {
                    // ignora e tenta o próximo
                }
            }

            throw new Exception(
                "Nenhuma instância do SQL Server foi encontrada.\n\n" +
                "Instale o SQL Server Express e tente novamente.");
        }
    }

}
