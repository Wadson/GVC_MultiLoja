using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.DAL
{
    public class RelatorioEstoqueDAL
    {
        public DataTable ObterRelatorioEstoque()
        {
            var dt = new DataTable();

            using var conn = Conexao_.Conex();
            conn.Open();

            string sql = @"
        SELECT
            p.ProdutoID,
            p.NomeProduto,
            p.Estoque,
            p.PrecoCusto,
            p.PrecoDeVenda,
            (p.Estoque * p.PrecoCusto)   AS ValorTotalCusto,
            (p.Estoque * p.PrecoDeVenda) AS ValorTotalVenda,
            ((p.PrecoDeVenda - p.PrecoCusto) * p.Estoque) AS LucroTotalProduto
        FROM Produtos p
        WHERE p.Situacao = 'Ativo'
        ORDER BY p.NomeProduto";

            using var da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            return dt;
        }
    }

}
