using Microsoft.Extensions.Configuration;
using System;

namespace GVC.UTIL
{
    public static class DatabaseConfig
    {
        private static readonly IConfiguration _config;

        static DatabaseConfig()
        {
            _config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }

        public static string ObterConnectionString()
        {
            var db = _config.GetSection("Database");

            if (!db.Exists())
                throw new Exception("Seção 'Database' não encontrada.");

            var server = db["Server"];
            var database = db["Database"];
            var user = db["User"];
            var password = db["Password"];

            // 🔴 DEBUG ABSOLUTO
            System.IO.File.WriteAllText(
                System.IO.Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "db_debug.txt"),
                $"Server='{server}'\nDatabase='{database}'\nUser='{user}'\nPassword='{password}'"
            );

            if (string.IsNullOrWhiteSpace(server) ||
                string.IsNullOrWhiteSpace(database) ||
                string.IsNullOrWhiteSpace(user))
            {
                throw new Exception("Configuração do banco de dados incompleta.");
            }

            return
                $"Server={server};" +
                $"Database={database};" +
                $"User Id={user};" +
                $"Password={password};" +
                $"Encrypt=False;" +
                $"TrustServerCertificate=True;";
        }


    }
}
