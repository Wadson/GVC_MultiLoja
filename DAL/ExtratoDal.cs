using Dapper;
using GVC.MODEL;
using GVC.UTIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.DAL
{
    public class ExtratoDal
    {
        private const string SQL_EXTRATO_CTE = @"
        WITH ParcelasCliente AS (
            SELECT
                p.ParcelaID,
                p.VendaID,
                p.NumeroParcela,
                v.DataVenda,
                p.DataVencimento,
                p.ValorParcela,
                v.ClienteID
            FROM Parcela p
            JOIN Venda v ON v.VendaID = p.VendaID
            WHERE v.ClienteID = @ClienteID
        ),
        Pagamentos AS (
            SELECT
                pp.PagamentoID,
                pp.ParcelaID,
                pp.DataPagamento,
                pp.ValorPago,
                fp.FormaPgto AS FormaPagamento,
                pp.Observacao
            FROM PagamentosParciais pp
            LEFT JOIN FormaPgto fp ON fp.FormaPgtoID = pp.FormaPgtoID
        )
        SELECT
            pc.ParcelaID,
            pc.VendaID,
            pc.NumeroParcela,
            pc.DataVenda,
            pc.DataVencimento,
            pc.ValorParcela,
            pg.PagamentoID,
            pg.DataPagamento,
            pg.ValorPago,
            pg.FormaPagamento,
            pg.Observacao
        FROM ParcelasCliente pc
        LEFT JOIN Pagamentos pg ON pg.ParcelaID = pc.ParcelaID
        ORDER BY pc.DataVenda, pc.NumeroParcela, pg.DataPagamento;
        ";

        // 🔹 ESTE MÉTODO SÓ BUSCA DADOS
        public List<ParcelaExtrato> ObterExtratoPorCliente(int clienteId)
        {
            using var conn = Conexao.Conex();

            return conn.Query<ParcelaExtrato>(
                SQL_EXTRATO_CTE,
                new { ClienteID = clienteId }
            ).ToList();
        }
    }
}
