using GVC.DALL;
using GVC.Model;
using System;
using Microsoft.Data.SqlClient;
using System.Data;
using GVC.UTIL;

namespace GVC.BLL
{
    internal class EstadoBLL
    {
        EstadoDal estadoDal = null;

        public DataTable Listar()
        {
            try
            {
                estadoDal = new EstadoDal();
                return estadoDal.Listar();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Salvar(EstadoModel estado)
        {
            try
            {
                estadoDal = new EstadoDal();
                estadoDal.Salvar(estado);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Excluir(EstadoModel estado)
        {
            try
            {
                estadoDal = new EstadoDal();
                estadoDal.Excluir(estado);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Atualizar(EstadoModel estado)
        {
            try
            {
                estadoDal = new EstadoDal();
                estadoDal.Atualizar(estado);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public EstadoModel Pesquisar(string pesquisa)
        {
            using var conn = Conexao.Conex();
            try
            {
                var sql = new SqlCommand(
                    "SELECT TOP 1 EstadoID, CodigoUf, Nome, Uf FROM Estado WHERE Nome LIKE @Nome", conn);
                sql.Parameters.AddWithValue("@Nome", pesquisa + "%");  // ✅ parâmetro seguro

                conn.Open();
                var datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);

                EstadoModel obj_estado = null;
                if (datareader.Read())
                {
                    obj_estado = new EstadoModel
                    {
                        EstadoID = Convert.ToInt32(datareader["EstadoID"]),
                        Nome = datareader["Nome"].ToString(),
                        Uf = datareader["Uf"].ToString()
                    };
                }
                return obj_estado;
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
    }
}
