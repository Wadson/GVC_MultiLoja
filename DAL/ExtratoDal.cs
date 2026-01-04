using Dapper;
using GVC.Model;
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
        private const string SQL_RESUMIDO = @"
    SELECT
        pc.ParcelaID,
        pc.VendaID,
        pc.NumeroParcela,
        v.DataVenda,
        pc.DataVencimento,
        pc.ValorParcela,

        ISNULL(SUM(pg.ValorPago), 0) AS ValorRecebido,
        pc.ValorParcela - ISNULL(SUM(pg.ValorPago), 0) AS Saldo,

        CASE
            WHEN ISNULL(SUM(pg.ValorPago), 0) = 0 THEN 'Em aberto'
            WHEN ISNULL(SUM(pg.ValorPago), 0) < pc.ValorParcela THEN 'Parcialmente paga'
            ELSE 'Paga'
        END AS Status
    FROM Parcela pc
    INNER JOIN Venda v ON v.VendaID = pc.VendaID
    LEFT JOIN PagamentosParciais pg ON pg.ParcelaID = pc.ParcelaID
    WHERE v.ClienteID = @ClienteID
    GROUP BY
        pc.ParcelaID,
        pc.VendaID,
        pc.NumeroParcela,
        v.DataVenda,
        pc.DataVencimento,
        pc.ValorParcela
    ORDER BY v.DataVenda, pc.NumeroParcela;
    ";

        private const string SQL_DETALHADO = @"
    SELECT
        pc.ParcelaID,
        pc.VendaID,
        pc.NumeroParcela,
        v.DataVenda,
        pc.DataVencimento,
        pc.ValorParcela,

        pg.DataPagamento,
        pg.ValorPago AS ValorRecebido,
        pc.ValorParcela - pg.ValorPago AS Saldo,
        'Pagamento' AS Status
    FROM Parcela pc
    INNER JOIN Venda v ON v.VendaID = pc.VendaID
    LEFT JOIN PagamentosParciais pg ON pg.ParcelaID = pc.ParcelaID
    WHERE v.ClienteID = @ClienteID
    ORDER BY v.DataVenda, pc.NumeroParcela, pg.DataPagamento;
    ";

        public List<ParcelaExtrato> ObterExtratoPorCliente(int clienteId, bool detalhado)
        {
            using var conn = Conexao.Conex();

            return conn.Query<ParcelaExtrato>(
                detalhado ? SQL_DETALHADO : SQL_RESUMIDO,
                new { ClienteID = clienteId }
            ).ToList();
        }
    }
}
