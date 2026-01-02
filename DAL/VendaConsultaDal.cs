using GVC.MODEL;
using GVC.MODEL.Extensions;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace GVC.DALL
{
    public class VendaConsultaDal
    {
        public VendaCompletaModel ObterVendaCompleta(long vendaId)
        {
            var venda = new VendaCompletaModel
            {
                Itens = new List<ItemVendaModel>(),
                Parcelas = new List<ParcelaModel>()
            };

            using var conn = Conexao.Conex();
            conn.Open();

            // =========================
            // VENDA + CLIENTE
            // =========================
            string sqlVenda = @"
       SELECT
    v.VendaID,
    v.DataVenda,
    v.ClienteID,
    c.Nome AS ClienteNome,
    c.Cpf AS CpfCliente,
    v.Desconto,
    v.Observacoes,
    v.FormaPgtoID,
    v.VendedorID,
    vend.Nome AS VendedorNome
FROM Venda v
INNER JOIN Clientes c 
    ON c.ClienteID = v.ClienteID
INNER JOIN Clientes vend 
    ON vend.ClienteID = v.VendedorID AND vend.IsVendedor = 1
WHERE v.VendaID = @VendaID";

            using (var cmd = new SqlCommand(sqlVenda, conn))
            {
                cmd.Parameters.AddWithValue("@VendaID", vendaId);

                using var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    venda.VendaID = (long)dr["VendaID"];
                    venda.DataVenda = (DateTime)dr["DataVenda"];
                    venda.ClienteID = (long)dr["ClienteID"];
                    venda.ClienteNome = dr["ClienteNome"].ToString();
                    venda.CpfCliente = dr["CpfCliente"]?.ToString();
                    venda.Desconto = (decimal)dr["Desconto"];
                    venda.Observacoes = dr["Observacoes"]?.ToString();
                    venda.FormaPgtoID = (int)dr["FormaPgtoID"];

                    // 🔹 Novos campos do vendedor
                    venda.VendedorID = (long)dr["VendedorID"];
                    venda.VendedorNome = dr["VendedorNome"].ToString();
                }
            }


            // =========================
            // ITENS
            // =========================
            string sqlItens = @"
        SELECT
            iv.ProdutoID,
            p.NomeProduto AS ProdutoDescricao,
            iv.Quantidade,
            iv.PrecoUnitario,
            iv.Subtotal,
            iv.DescontoItem
        FROM ItemVenda iv
        INNER JOIN Produtos p ON p.ProdutoID = iv.ProdutoID
        WHERE iv.VendaID = @VendaID";

            using (var cmd = new SqlCommand(sqlItens, conn))
            {
                cmd.Parameters.AddWithValue("@VendaID", vendaId);
                using var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    venda.Itens.Add(new ItemVendaModel
                    {
                        ProdutoID = (long)dr["ProdutoID"],
                        ProdutoDescricao = dr["ProdutoDescricao"].ToString(),
                        Quantidade = (int)dr["Quantidade"],
                        PrecoUnitario = (decimal)dr["PrecoUnitario"],
                        Subtotal = (decimal)dr["Subtotal"],
                        DescontoItem = dr["DescontoItem"] as decimal?
                    });
                }
            }

            // =========================
            // PARCELAS
            // =========================
            string sqlParcelas = @"SELECT * FROM Parcela WHERE VendaID = @VendaID";
            using (var cmd = new SqlCommand(sqlParcelas, conn))
            {
                cmd.Parameters.AddWithValue("@VendaID", vendaId);
                using var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    venda.Parcelas.Add(new ParcelaModel
                    {
                        NumeroParcela = (int)dr["NumeroParcela"],
                        DataVencimento = (DateTime)dr["DataVencimento"],
                        ValorParcela = (decimal)dr["ValorParcela"],

                        // ✅ CONVERSÃO CORRETA
                        Status = dr["Status"].ToString().ToEnumStatusParcela()
                    });
                }
            }


            return venda;
        }

    }
}
