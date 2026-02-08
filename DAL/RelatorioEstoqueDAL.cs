using System.Data;
using Microsoft.Data.SqlClient;
using GVC.Infra.Repository;

namespace GVC.DAL
{
    public class RelatorioEstoqueDAL : RepositoryBase
    {
        public DataTable ObterRelatorioEstoque()
        {
            var dt = new DataTable();

            const string sql = @"
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
                  AND p.EmpresaID = @EmpresaID
                ORDER BY p.NomeProduto";

            using var cmd = CreateCommand(sql);
            using var da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
    }
}
