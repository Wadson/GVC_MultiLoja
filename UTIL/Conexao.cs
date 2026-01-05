using Microsoft.Data.SqlClient; // biblioteca para SQL Server
using System;
using System.Configuration;

namespace GVC.UTIL
{
    internal class Conexao
    {
        public static SqlConnection Conex(string ambiente = null)
        {
            try
            {
                string ambienteFinal = ambiente ?? Sessao.AmbienteSelecionado;
                string connString = ConfigurationManager.ConnectionStrings[ambienteFinal].ConnectionString;
                return new SqlConnection(connString);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar ao banco SQL Server: " + ex.Message, ex);
            }
        }
    }
    public enum ModoVenda
    {
        Nova = 1,
        Edicao = 2
    }
}

/*
 * // Para homologação
using (SqlConnection conn = Conexao.Conex("Homologacao"))
{
    conn.Open();
    // comandos SQL aqui
}

// Para teste
using (SqlConnection conn = Conexao.Conex("Teste"))
{
    conn.Open();
    // comandos SQL aqui
}

 * */