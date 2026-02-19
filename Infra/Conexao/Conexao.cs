using Microsoft.Data.SqlClient;
using System;
using GVC.UTIL;

namespace GVC.Infra.Conexao
{
    internal static class Conexao
    {
        public static SqlConnection Conex()
        {
            try
            {
                string connString = DatabaseConfig.ObterConnectionString();
                return new SqlConnection(connString);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao criar conexão com o SQL Server.", ex);
            }
        }
    }
  
}
