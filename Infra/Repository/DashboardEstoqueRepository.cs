using Dapper;
using GVC.Model;
using GVC.UTIL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GVC.Infra.Repository
{
    public class DashboardEstoqueRepository : RepositoryBase
    {
        // ======================================================
        // 📊 RESUMO DE ESTOQUE (CUSTO / VENDA / LUCRO)
        // ======================================================
        public (decimal custo, decimal venda, decimal lucro) ObterResumo()
        {
            const string sql = @"
                SELECT
                    ISNULL(SUM(Estoque * PrecoCusto), 0)   AS TotalCusto,
                    ISNULL(SUM(Estoque * PrecoDeVenda), 0) AS TotalVenda,
                    ISNULL(SUM((PrecoDeVenda - PrecoCusto) * Estoque), 0) AS TotalLucro
                FROM Produtos
                WHERE Status = 'Ativo'
                  AND EmpresaID = @EmpresaID;";

            using var cmd = CreateCommand(sql);

            using var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return (
                    dr.GetDecimal(dr.GetOrdinal("TotalCusto")),
                    dr.GetDecimal(dr.GetOrdinal("TotalVenda")),
                    dr.GetDecimal(dr.GetOrdinal("TotalLucro"))
                );
            }

            return (0m, 0m, 0m);
        }

        // ======================================================
        // 🔝 TOP PRODUTOS MAIS LUCRATIVOS
        // ======================================================
        public List<ProdutoLucrativo> ObterTopProdutosLucrativos(int top = 10)
        {
            const string sql = @"
                SELECT TOP (@Top)
                    ProdutoID,
                    NomeProduto,
                    Estoque,
                    PrecoCusto,
                    PrecoDeVenda,
                    (PrecoDeVenda - PrecoCusto) AS LucroUnitario,
                    ((PrecoDeVenda - PrecoCusto) * Estoque) AS LucroTotal
                FROM Produtos
                WHERE Status = 'Ativo'
                  AND EmpresaID = @EmpresaID
                ORDER BY LucroTotal DESC;";

            // ⚠️ Dapper usando a MESMA connection do RepositoryBase
            return Connection.Query<ProdutoLucrativo>(
                sql,
                new
                {
                    Top = top,
                    EmpresaID
                }
            ).ToList();
        }

        // ======================================================
        // ⚠️ PRODUTOS COM ESTOQUE BAIXO
        // ======================================================
        public List<ProdutoEstoqueBaixo> ObterEstoqueBaixo(int limite = 5)
        {
            const string sql = @"
                SELECT
                    ProdutoID,
                    NomeProduto,
                    Estoque,
                    Unidade,
                    Marca
                FROM Produtos
                WHERE Estoque <= @Limite
                  AND Status = 'Ativo'
                  AND EmpresaID = @EmpresaID
                ORDER BY Estoque ASC;";

            return Connection.Query<ProdutoEstoqueBaixo>(
                sql,
                new
                {
                    Limite = limite,
                    EmpresaID
                }
            ).ToList();
        }
    }
}
