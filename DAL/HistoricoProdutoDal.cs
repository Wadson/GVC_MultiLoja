using Dapper;
using System.Collections.Generic;
using System.Linq;
using GVC.Infra.Repository;

namespace GVC.DAL
{
    internal class HistoricoProdutoDal : RepositoryBase
    {
        public void InserirHistorico(BLL.HistoricoPrecoBLL historico)
        {
            const string sql = @"
            INSERT INTO HistoricoPreco
            (ProdutoID, DataRegistro, PrecoCusto, Lucro, PrecoVenda, EmpresaID)
            VALUES (@ProdutoID, @DataRegistro, @PrecoCusto, @Lucro, @PrecoVenda, @EmpresaID)";

            Connection.Execute(sql, new
            {
                historico.ProdutoID,
                historico.DataRegistro,
                historico.PrecoCusto,
                historico.Lucro,
                historico.PrecoVenda,
                EmpresaID
            });
        }

        public List<BLL.HistoricoPrecoBLL> ObterHistoricoPorProduto(int produtoID)
            => Connection.Query<BLL.HistoricoPrecoBLL>(
                @"SELECT * FROM HistoricoPreco
                  WHERE ProdutoID = @ProdutoID
                    AND EmpresaID = @EmpresaID
                  ORDER BY DataRegistro DESC",
                new { ProdutoID = produtoID, EmpresaID }
            ).ToList();
    }
}
