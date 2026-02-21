using Dapper;
using GVC.Infra.Conexao;
using GVC.Infra.Repository;
using GVC.Model;
using System.Collections.Generic;
using System.Linq;

namespace GVC.DAL
{
    public class ExtratoDal : RepositoryBase
    {
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
          AND pc.EmpresaID = @EmpresaID
        ORDER BY v.DataVenda, pc.NumeroParcela";

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
          AND pc.EmpresaID = @EmpresaID
        GROUP BY
            pc.ParcelaID, pc.VendaID, pc.NumeroParcela,
            v.DataVenda, pc.DataVencimento, pc.ValorParcela
        ORDER BY v.DataVenda, pc.NumeroParcela";

        public List<ParcelaExtratoDetalhado> ObterParcelas(int clienteId)
            => Connection.Query<ParcelaExtratoDetalhado>(
                SQL_PARCELAS,
                new { ClienteID = clienteId, EmpresaID }
            ).ToList();

        public List<ParcelaExtrato> ObterExtratoResumido(int clienteId)
            => Connection.Query<ParcelaExtrato>(
                SQL_RESUMIDO,
                new { ClienteID = clienteId, EmpresaID }
            ).ToList();



        public List<PagamentoExtratoModel> ObterPagamentosPorCliente(int clienteId)
        {
            return Connection.Query<PagamentoExtratoModel>(@"
        SELECT
            pg.ParcelaID,
            pg.DataPagamento,
            pg.ValorPago,
            pg.Observacao
        FROM PagamentosParciais pg
        INNER JOIN Parcela pc ON pc.ParcelaID = pg.ParcelaID
        INNER JOIN Venda v ON v.VendaID = pc.VendaID
        WHERE v.ClienteID = @ClienteID AND pc.EmpresaID = @EmpresaID
        ORDER BY pg.DataPagamento",
                new { ClienteID = clienteId, EmpresaID }
            ).ToList();
        }

        public List<PagamentoExtratoModel> ObterPagamentosPorParcela(long parcelaId)
        {            
            return Connection.Query<PagamentoExtratoModel>(
                @"SELECT DataPagamento, ValorPago, Observacao
                  FROM PagamentosParciais
                  WHERE ParcelaID = @ParcelaID AND EmpresaID = @EmpresaID
                  ORDER BY DataPagamento",
                new { ParcelaID = parcelaId, EmpresaID}
            ).ToList();
        }
    }
}
