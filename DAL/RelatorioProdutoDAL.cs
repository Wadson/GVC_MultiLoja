using Dapper;
using GVC.MODEL.Relatorios;
using GVC.UTIL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GVC.DAL
{
    public class RelatorioProdutoDAL
    {
        // ============================
        // 1️⃣ PRODUTOS – ESTOQUE / PREÇOS
        // ============================
        public List<RelatorioProdutoEstoqueDTO> ObterProdutosEstoque()
        {
            const string sql = @"
SELECT
    ProdutoID,
    NomeProduto AS Produto,
    Estoque,
    PrecoCusto,
    PrecoDeVenda AS PrecoVenda
FROM Produtos
WHERE Status = 'Disponível'
ORDER BY NomeProduto";

            using var conn = Conexao.Conex();
            return conn.Query<RelatorioProdutoEstoqueDTO>(sql).ToList();
        }

        // ============================
        // 2️⃣ LUCRO POR PRODUTO (VENDAS)
        // ============================

        public List<RelatorioLucroProdutoDTO> ObterLucroPorProduto(
    DateTime? dataInicial,
    DateTime? dataFinal)
        {
            var sql = @"
SELECT
    p.ProdutoID,
    p.NomeProduto AS Produto,
    SUM(iv.Quantidade) AS QuantidadeVendida,
    SUM(iv.Quantidade * p.PrecoCusto) AS CustoTotal,
    SUM(iv.Subtotal) AS VendaTotal,
    (SUM(iv.Subtotal) - SUM(iv.Quantidade * p.PrecoCusto)) AS LucroTotal
FROM ItemVenda iv
INNER JOIN Produtos p ON p.ProdutoID = iv.ProdutoID
INNER JOIN Venda v ON v.VendaID = iv.VendaID
WHERE v.StatusVenda <> 'Cancelada'";

            if (dataInicial.HasValue)
                sql += " AND v.DataVenda >= @DataInicial";

            if (dataFinal.HasValue)
                sql += " AND v.DataVenda < DATEADD(DAY,1,@DataFinal)";

            sql += @"
GROUP BY p.ProdutoID, p.NomeProduto
ORDER BY LucroTotal DESC";

            using var conn = Conexao.Conex();
            return conn.Query<RelatorioLucroProdutoDTO>(sql, new
            {
                DataInicial = dataInicial,
                DataFinal = dataFinal
            }).ToList();
        }


    }
}
