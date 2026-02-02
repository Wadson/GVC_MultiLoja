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
        // ==============================
        // PARCELAS (posição financeira)
        // ==============================
        private const string SQL_PARCELAS = @"
        SELECT
            pc.ParcelaID,
            pc.VendaID,
            pc.NumeroParcela,
            pc.DataVencimento,
            pc.ValorParcela,
            pc.ValorRecebido,
            (pc.ValorParcela + ISNULL(pc.Juros,0) + ISNULL(pc.Multa,0)) - pc.ValorRecebido AS Saldo,
            pc.Status
        FROM Parcela pc
        INNER JOIN Venda v ON v.VendaID = pc.VendaID
        WHERE v.ClienteID = @ClienteID
        ORDER BY v.DataVenda, pc.NumeroParcela;";

        // ==============================
        // PAGAMENTOS (histórico)
        // ==============================
        private const string SQL_PAGAMENTOS = @"
        SELECT
            pg.ParcelaID,
            pg.DataPagamento,
            pg.ValorPago,
            pg.Observacao
        FROM PagamentosParciais pg
        INNER JOIN Parcela pc ON pc.ParcelaID = pg.ParcelaID
        INNER JOIN Venda v ON v.VendaID = pc.VendaID
        WHERE v.ClienteID = @ClienteID
        ORDER BY pg.DataPagamento;";

        // ==============================
        // EXTRATO RESUMIDO (antigo)
        // ==============================
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
                ELSE 'Pago'
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
        ORDER BY v.DataVenda, pc.NumeroParcela;";

        // ==============================
        // MÉTODOS
        // ==============================
        public List<ParcelaExtratoDetalhado> ObterParcelas(int clienteId)
        {
            using var conn = Conexao_.Conex();
            return conn.Query<ParcelaExtratoDetalhado>(
                SQL_PARCELAS,
                new { ClienteID = clienteId }
            ).ToList();
        }

        public List<PagamentoExtratoModel> ObterPagamentosPorParcela(long parcelaId)
        {
            using var conn = Conexao_.Conex();
            return conn.Query<PagamentoExtratoModel>(
                @"SELECT DataPagamento, ValorPago, Observacao
          FROM PagamentosParciais
          WHERE ParcelaID = @ParcelaID
          ORDER BY DataPagamento",
                new { ParcelaID = parcelaId }
            ).ToList();
        }
        public List<PagamentoExtratoModel> ObterPagamentosPorCliente(int clienteId)
        {
            using var conn = Conexao_.Conex();

            return conn.Query<PagamentoExtratoModel>(@"
        SELECT
            pg.ParcelaID,
            pg.DataPagamento,
            pg.ValorPago,
            pg.Observacao
        FROM PagamentosParciais pg
        INNER JOIN Parcela pc ON pc.ParcelaID = pg.ParcelaID
        INNER JOIN Venda v ON v.VendaID = pc.VendaID
        WHERE v.ClienteID = @ClienteID
        ORDER BY pg.DataPagamento",
                new { ClienteID = clienteId }
            ).ToList();
        }

        public List<ParcelaExtrato> ObterExtratoResumido(int clienteId)
        {
            using var conn = Conexao_.Conex();
            return conn.Query<ParcelaExtrato>(
                SQL_RESUMIDO,
                new { ClienteID = clienteId }
            ).ToList();
        }
    }
}
