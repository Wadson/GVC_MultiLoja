using Microsoft.Data.SqlClient;
using System.Reflection;

namespace GVC.Infra.Database
{
    public static class DatabaseInstaller
    {
        private const string DATABASE = "bdsiscontrol";

        public static void Run(Action<int, int, string> progress)
        {
            CriarBanco();
            CriarTabelaLog();
            ExecutarScripts(progress);
        }

        // ======================================================
        // CRIA BANCO
        // ======================================================
        private static void CriarBanco()
        {
            using var conn = new SqlConnection(
                DatabaseConnectionResolver.ResolverMasterConnectionString());

            conn.Open();

            var sql = $@"
IF NOT EXISTS (SELECT 1 FROM sys.databases WHERE name = '{DATABASE}')
BEGIN
    CREATE DATABASE [{DATABASE}];
END";

            using var cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            // Garante que o banco esteja disponível
            using var wait = new SqlCommand("WAITFOR DELAY '00:00:01'", conn);
            wait.ExecuteNonQuery();
        }

        // ======================================================
        // CRIA TABELA DE LOG
        // ======================================================
        private static void CriarTabelaLog()
        {
            using var conn = new SqlConnection(
                DatabaseConnectionResolver.ResolverMasterConnectionString());

            conn.Open();

            var sql = $@"
IF DB_ID('{DATABASE}') IS NOT NULL
BEGIN
    USE [{DATABASE}];

    IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = '__ScriptLog')
    BEGIN
        CREATE TABLE __ScriptLog (
            ScriptName NVARCHAR(200) PRIMARY KEY,
            ExecutedAt DATETIME2 NOT NULL
        );
    END
END";

            using var cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        // ======================================================
        // EXECUTA SCRIPTS
        // ======================================================
        private static void ExecutarScripts(Action<int, int, string> progress)
        {
            var asm = Assembly.GetExecutingAssembly();

            var scripts = asm.GetManifestResourceNames()
                .Where(n =>
                    n.Contains(".Infra.Database.Scripts.") ||
                    n.Contains(".Infra.Database.Functions.") ||
                    n.Contains(".Infra.Database.Views.") ||
                    n.Contains(".Infra.Database.Procedures.") ||
                    n.Contains(".Infra.Database.Seed.") ||
                    n.Contains(".Infra.Database.Carga.")
                )
                .Where(n => n.EndsWith(".sql"))
                .OrderBy(n => n)
                .ToList();

            int total = scripts.Count;
            int atual = 0;

            foreach (var resource in scripts)
            {
                atual++;

                var nomeScript = resource.Split('.').Last();
                progress?.Invoke(atual, total, nomeScript);

                if (JaExecutado(nomeScript))
                    continue;

                Executar(resource);
                Registrar(nomeScript);
            }
        }

        // ======================================================
        // VERIFICA LOG
        // ======================================================
        private static bool JaExecutado(string script)
        {
            using var conn = new SqlConnection(
                DatabaseConnectionResolver.ResolverConnectionString());

            conn.Open();

            using var cmd = new SqlCommand(
                "SELECT 1 FROM __ScriptLog WHERE ScriptName = @s",
                conn);

            cmd.Parameters.AddWithValue("@s", script);
            return cmd.ExecuteScalar() != null;
        }

        // ======================================================
        // EXECUTA SCRIPT (1 ARQUIVO = 1 LOTE)
        // ======================================================
        private static void Executar(string resource)
        {
            var asm = Assembly.GetExecutingAssembly();

            using var stream = asm.GetManifestResourceStream(resource)
                ?? throw new InvalidOperationException($"Script não encontrado: {resource}");

            using var reader = new StreamReader(stream);
            var sql = reader.ReadToEnd();

            using var conn = new SqlConnection(
                DatabaseConnectionResolver.ResolverConnectionString());

            conn.Open();

            using var cmd = new SqlCommand(sql, conn)
            {
                CommandTimeout = 0
            };

            cmd.ExecuteNonQuery();
        }

        // ======================================================
        // REGISTRA EXECUÇÃO
        // ======================================================
        private static void Registrar(string script)
        {
            using var conn = new SqlConnection(
                DatabaseConnectionResolver.ResolverConnectionString());

            conn.Open();

            using var cmd = new SqlCommand(
                "INSERT INTO __ScriptLog (ScriptName, ExecutedAt) VALUES (@s, GETDATE())",
                conn);

            cmd.Parameters.AddWithValue("@s", script);
            cmd.ExecuteNonQuery();
        }
    }
}
