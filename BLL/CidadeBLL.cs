using GVC.DALL;
using GVC.Model;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using GVC.UTIL;
using GVC.Model;

namespace GVC.BLL
{
    internal class CidadeBLL
    {
        CidadeDal? CidadeDal = null;

        public DataTable Listar()
        {
            DataTable dtable = new DataTable();
            try
            {
                CidadeDal = new CidadeDal();
                dtable = CidadeDal.Listar_Cidades();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }

        public void Salvar(CidadeModel cidades)
        {
            try
            {
                CidadeDal = new CidadeDal();
                CidadeDal.Salvar(cidades);
                CidadeDal.Salvar(cidades);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Excluir(CidadeModel cidades)
        {
            try
            {
                CidadeDal = new CidadeDal();
                CidadeDal.Excluir(cidades);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Atualizar(CidadeModel cidades)
        {
            try
            {
                CidadeDal = new CidadeDal();
                CidadeDal.Atualizar(cidades);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public CidadeModel Pesquisar(string pesquisa)
        {
            var conn = Conexao.Conex();
            try
            {
                var sql = new SqlCommand("SELECT TOP 1 * FROM Cidade WHERE Nome LIKE @Nome", conn);
                sql.Parameters.AddWithValue("@Nome", pesquisa + "%");  // ✅ parâmetro seguro

                conn.Open();
                var datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);

                CidadeModel obj_cidade = null;
                if (datareader.Read())
                {
                    obj_cidade = new CidadeModel
                    {
                        CidadeID = Convert.ToInt32(datareader["CidadeID"]),
                        Nome = datareader["Nome"].ToString()
                    };
                }
                return obj_cidade;
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
