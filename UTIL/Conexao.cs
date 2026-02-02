using System;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace GVC.UTIL
{
    internal static class Conexao
    {
        /// <summary>
        /// Retorna uma conexão SQL Server baseada no ambiente informado
        /// ou no ambiente selecionado na sessão.
        /// </summary>
        public static SqlConnection Conex(AmbienteBanco? ambiente = null)
        {
            try
            {
                // Se não informar ambiente, usa o da sessão
                string ambienteFinal = ambiente?.ToString()
                    ?? Sessao.AmbienteSelecionado;

                if (string.IsNullOrWhiteSpace(ambienteFinal))
                    throw new Exception("Ambiente do banco de dados não foi definido.");

                ConnectionStringSettings settings =
                    ConfigurationManager.ConnectionStrings[ambienteFinal];

                if (settings == null)
                    throw new Exception($"ConnectionString '{ambienteFinal}' não encontrada no app.config.");

                return new SqlConnection(settings.ConnectionString);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao criar conexão com o SQL Server.", ex);
            }
        }
    }

    /// <summary>
    /// Ambientes possíveis do banco de dados
    /// </summary>
    public enum AmbienteBanco
    {       
        Homologacao,
        Teste
    }   
}
