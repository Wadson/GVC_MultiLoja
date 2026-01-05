using GVC.Model;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GVC.DAL
{
    internal class CidadeDal
    {
        private const string SqlBase = @"SELECT ci.CidadeID, ci.Nome, ci.EstadoID FROM Cidade ci";

        public DataTable Listar_Cidades()
        {
            var conn = Conexao.Conex();
            try
            {
                DataTable dt = new DataTable();

                string sql = @"SELECT TOP 30 Cidade.CidadeID, Cidade.Nome, Cidade.EstadoID, Estado.Uf
                               FROM Cidade  
                               INNER JOIN Estado ON Cidade.EstadoID = Estado.EstadoID";

                using var cmd = new SqlCommand(sql, conn);
                conn.Open();
                using var reader = cmd.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao listar cidades: " + erro.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Salvar(CidadeModel Cidades)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sqlcomando = new SqlCommand(
                    "INSERT INTO Cidade (CidadeID, Nome, EstadoID) VALUES (@CidadeID, @Nome, @EstadoID)", conn);

                sqlcomando.Parameters.AddWithValue("@CidadeID", Cidades.CidadeID);
                sqlcomando.Parameters.AddWithValue("@Nome", Cidades.Nome);
                sqlcomando.Parameters.AddWithValue("@EstadoID", Cidades.EstadoID);

                conn.Open();
                sqlcomando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void Excluir(CidadeModel Cidades)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sqlcomando = new SqlCommand("DELETE FROM Cidade WHERE CidadeID = @CidadeID", conn);
                sqlcomando.Parameters.AddWithValue("@CidadeID", Cidades.CidadeID);
                conn.Open();
                sqlcomando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conn.Close();
            }
        }

        public void Atualizar(CidadeModel Cidades)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sqlcomando = new SqlCommand(
                    "UPDATE Cidade SET Nome = @Nome, EstadoID = @EstadoID WHERE CidadeID = @CidadeID", conn);

                sqlcomando.Parameters.AddWithValue("@Nome", Cidades.Nome);
                sqlcomando.Parameters.AddWithValue("@EstadoID", Cidades.EstadoID);
                sqlcomando.Parameters.AddWithValue("@CidadeID", Cidades.CidadeID);

                conn.Open();
                sqlcomando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable PesquisarPorNome(string nome)
        {
            var conn = Conexao.Conex();
            try
            {
                DataTable dt = new DataTable();

                string sql = @"SELECT TOP 30 Cidade.CidadeID, Cidade.Nome, Cidade.EstadoID, Estado.Uf
                               FROM Cidade 
                               INNER JOIN Estado ON Cidade.EstadoID = Estado.EstadoID 
                               WHERE Cidade.Nome LIKE @Nome";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nome", $"%{nome}%");

                conn.Open();
                using var reader = cmd.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso("Erro ao executar a pesquisa: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public DataTable PesquisarPorCodigo(int codigo)
        {
            string sql = SqlBase + " WHERE CidadeID = @CidadeID";
            var dt = new DataTable();
            using (var conn = Conexao.Conex(Sessao.AmbienteSelecionado))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@CidadeID", codigo);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }

        public DataTable PesquisarPorCodigo(string nome)
        {
            var conn = Conexao.Conex();
            try
            {
                DataTable dt = new DataTable();

                string sqlconn = @"SELECT TOP 30 Cidade.CidadeID, Cidade.Nome, Cidade.EstadoID, Estado.Uf
                                   FROM Cidade 
                                   INNER JOIN Estado ON Cidade.EstadoID = Estado.EstadoID 
                                   WHERE CidadeID LIKE @CidadeID";

                using (SqlCommand cmd = new SqlCommand(sqlconn, conn))
                {
                    cmd.Parameters.AddWithValue("@CidadeID", "%" + nome + "%");
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso("Erro ao executar a pesquisa: " + ex.Message);
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Dispose();
            }
        }

        public DataTable PesquisarGeral()
        {
            var conn = Conexao.Conex();
            try
            {
                DataTable dt = new DataTable();
                string sqlconn = @"SELECT TOP 30 Cidade.CidadeID, Cidade.Nome, Cidade.EstadoID, Estado.Uf 
                                   FROM Cidade 
                                   INNER JOIN Estado ON Cidade.EstadoID = Estado.EstadoID";

                using (SqlCommand cmd = new SqlCommand(sqlconn, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso("Erro ao executar a pesquisa: " + ex.Message);
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Dispose();
            }
        }
    }
}
