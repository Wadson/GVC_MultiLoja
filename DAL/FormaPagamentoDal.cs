using GVC.Model;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.DAL
{
    internal class FormaPagamentoDal
    {
        private const string SqlBase = @"
            SELECT FormaPgtoID, NomeFormaPagamento FROM FormaPagamento";
        public DataTable ListaFormaPgto()
        {
            var conn = Conexao.Conex();
            try
            {
                var comando = new SqlCommand("SELECT FormaPgtoID, NomeFormaPagamento FROM FormaPagamento", conn);

                conn.Open();
                var reader = comando.ExecuteReader();

                var dtFormaPgto = new DataTable();
                dtFormaPgto.Load(reader);
                return dtFormaPgto;
            }
            finally
            {
                conn.Close();
            }
        }

        public void GravaFormaPgto(FormaPagamentoModel formaPgtos)
        {
            var conn = Conexao.Conex();
            try
            {
                var sqlcomm = new SqlCommand("INSERT INTO FormaPagamento (NomeFormaPagamento) VALUES (@NomeFormaPagamento)", conn);

                sqlcomm.Parameters.AddWithValue("@NomeFormaPagamento", formaPgtos.NomeFormaPagamento);
                conn.Open();
                sqlcomm.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void ExcluiFormaPgto(FormaPagamentoModel formaPgto)
        {
            var conn = Conexao.Conex();
            try
            {
                var sqlcomando = new SqlCommand("DELETE FROM FormaPagamento WHERE FormaPgtoID = @FormaPgtoID", conn);
                sqlcomando.Parameters.AddWithValue("@FormaPgtoID", formaPgto.FormaPgtoID);

                conn.Open();
                sqlcomando.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void Atualizar(FormaPagamentoModel formaPgto)
        {
            var conn = Conexao.Conex();
            try
            {
                var sqlcomm = new SqlCommand("UPDATE FormaPagamento SET NomeFormaPagamento = @NomeFormaPgto WHERE FormaPgtoID = @FormaPgtoID", conn);

                sqlcomm.Parameters.AddWithValue("@NomeFormaPgto", formaPgto.NomeFormaPagamento);               
                sqlcomm.Parameters.AddWithValue("@FormaPgtoID", formaPgto.FormaPgtoID);

                conn.Open();
                sqlcomm.ExecuteNonQuery();
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
                var sqlconn = "SELECT FormaPgtoID, NomeFormaPagamento FROM FormaPagamento WHERE NomeFormaPagamento LIKE @NomeFormaPgto";
                var cmd = new SqlCommand(sqlconn, conn);
                cmd.Parameters.AddWithValue("@NomeFormaPgto", "%" + nome + "%");

                conn.Open();
                var reader = cmd.ExecuteReader();

                var dt = new DataTable();
                dt.Load(reader);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar a pesquisa: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public FormaPagamentoModel? BuscarPorId(int formaPgtoID)
        {
            string sql = SqlBase + " WHERE FormaPgtoID = @Id";
            using (var conn = Conexao.Conex())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Id", formaPgtoID);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapFormaPgto(reader);
                    }
                }
            }
            return null;
        }
        public DataTable PesquisarPorCodigo(int nome)
        {
            var conn = Conexao.Conex();
            try
            {
                DataTable dt = new DataTable();

                string sqlconn = "SELECT FormaPgtoID, NomeFormaPagamento FROM FormaPagamento WHERE FormaPgtoID = @FormaPgtoID";

                using (SqlCommand cmd = new SqlCommand(sqlconn, conn))
                {
                    cmd.Parameters.AddWithValue("@FormaPgtoID", Convert.ToInt32(nome));

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
                MessageBox.Show("Erro ao executar a pesquisa: " + ex.Message);
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
        public DataTable Listar()
        {
            var conn = Conexao.Conex();
            try
            {
                var sql = "SELECT FormaPgtoID, NomeFormaPagamento FROM FormaPagamento";
                var cmd = new SqlCommand(sql, conn);

                conn.Open();
                var reader = cmd.ExecuteReader();

                var dt = new DataTable();
                dt.Load(reader);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar formas de pagamento: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        // Método auxiliar para mapear EmpresaModel a partir de SqlDataReader
        private FormaPagamentoModel MapFormaPgto(SqlDataReader reader)
        {
            return new FormaPagamentoModel
            {
                FormaPgtoID = reader.GetInt32(reader.GetOrdinal("FormaPgtoID")),
                NomeFormaPagamento = reader["NomeFormaPagamento"]?.ToString() ?? "",              
            };
        }
    }
}
