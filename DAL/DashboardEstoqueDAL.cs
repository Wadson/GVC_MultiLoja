using Dapper;
using GVC.Model;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.DAL
{
    public class DashboardEstoqueDAL
    {
        public (decimal custo, decimal venda, decimal lucro) ObterResumo()
        {
            using var conn = Conexao_.Conex();
            conn.Open();

            string sql = @" SELECT
                    ISNULL(SUM(Estoque * PrecoCusto), 0)   AS TotalCusto,
                    ISNULL(SUM(Estoque * PrecoDeVenda), 0) AS TotalVenda,
                    ISNULL(SUM((PrecoDeVenda - PrecoCusto) * Estoque), 0) AS TotalLucro
                FROM Produtos
                WHERE Status = 'Ativo'; ";

            using var cmd = new SqlCommand(sql, conn);
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
        public List<ProdutoLucrativo> ObterTopProdutosLucrativos(int top = 10)
        {
            using var conn = Conexao_.Conex();
            conn.Open();

            string sql = @"SELECT TOP (@Top)
        ProdutoID,
        NomeProduto,
        Estoque,
        PrecoCusto,
        PrecoDeVenda,
        (PrecoDeVenda - PrecoCusto) AS LucroUnitario,
        ((PrecoDeVenda - PrecoCusto) * Estoque) AS LucroTotal
    FROM Produtos
    WHERE Status = 'Ativo'
    ORDER BY LucroTotal DESC;";

            return conn.Query<ProdutoLucrativo>(sql, new { Top = top }).ToList();
        }

        public List<ProdutoEstoqueBaixo> ObterEstoqueBaixo(int limite = 5)
        {
            using var conn = Conexao_.Conex();
            conn.Open();

            string sql = @"SELECT
        ProdutoID,
        NomeProduto,
        Estoque,
        Unidade,
        Marca
    FROM Produtos
    WHERE Estoque <= @Limite
      AND Status = 'Ativo'
    ORDER BY Estoque ASC;";

            return conn.Query<ProdutoEstoqueBaixo>(sql, new { Limite = limite }).ToList();
        }
    }

}
