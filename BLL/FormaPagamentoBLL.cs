using GVC.DAL;
using GVC.DAL;
using GVC.Model;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GVC.Infra.Conexao;

namespace GVC.BLL
{
    internal class FormaPagamentoBLL
    {
        FormaPagamentoDal formaPgtodal = null;
        

        public DataTable Listar()
        {
            DataTable dtable = new DataTable();
            try
            {
                formaPgtodal = new FormaPagamentoDal();
                dtable = formaPgtodal.ListaFormaPgto();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }

        public void Salvar(FormaPagamentoModel formaPgto)
        {
            try
            {
                formaPgtodal = new FormaPagamentoDal();
                formaPgtodal.GravaFormaPgto(formaPgto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Excluir(FormaPagamentoModel formaPgto)
        {
            try
            {
                formaPgtodal = new FormaPagamentoDal();
                formaPgtodal.ExcluiFormaPgto(formaPgto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public void Alterar(FormaPagamentoModel formaPgto)
        {
            try
            {
                formaPgtodal = new FormaPagamentoDal();
                formaPgtodal.Atualizar(formaPgto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public FormaPagamentoModel? BuscarPorId(int formaPgtoId)
        {
            formaPgtodal = new FormaPagamentoDal();
            return formaPgtodal.BuscarPorId(formaPgtoId);
        }
        public FormaPagamentoModel PesquisarNo(DataGridView DataGridPesquisa, string pesquisa)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("SELECT * FROM FormaPagamento WHERE NomeFormaPagamento like '" + pesquisa + "%'", conn);
                conn.Open();
                SqlDataReader datareader;
                FormaPagamentoModel obj_formaPgto = new FormaPagamentoModel();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);

                while (datareader.Read())
                {
                    obj_formaPgto.FormaPgtoID = Convert.ToInt32(datareader["FormaPgtoID"]);
                    obj_formaPgto.NomeFormaPagamento = datareader["NomeFormaPagamento"].ToString();
                }
                return obj_formaPgto;
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
        public FormaPagamentoModel PesquisarCodigo(string pesquisa)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("SELECT * FROM FormaPagamento WHERE FormaPgtoID like '" + pesquisa + "%'", conn);
                conn.Open();
                SqlDataReader datareader;
                FormaPagamentoModel obj_formaPgto = new FormaPagamentoModel();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);

                while (datareader.Read())
                {
                    obj_formaPgto.FormaPgtoID = Convert.ToInt32(datareader["FormaPgtoID"]);
                    obj_formaPgto.NomeFormaPagamento = datareader["NomeFormaPagamento"].ToString();
                }
                return obj_formaPgto;
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
