using Dapper;
using GVC.DTO;
using GVC.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GVC.Infra.Repository
{
    public class ExtratoRepository : RepositoryBase
    {
        public ExtratoRepository() : base() { }
        public ExtratoRepository(SqlConnection conn) : base(conn) { }

        // ======================================================
        // LOTE: extrato por várias parcelas (recibo)
        // ======================================================
        public List<RowExtratoParcelaLote> ObterExtratoPorParcelas(List<int> parcelasIds)
        {
            const string sql = @"
SELECT
    v.ClienteID,
    c.Nome AS NomeCliente,
    p.VendaID,
    p.ParcelaID,
    p.NumeroParcela,
    p.DataVencimento,
    p.ValorParcela,
    ISNULL(p.ValorRecebido, 0) AS ValorRecebido,
    (p.ValorParcela + ISNULL(p.Juros,0) + ISNULL(p.Multa,0) - ISNULL(p.ValorRecebido,0)) AS Saldo,
    p.Status
FROM Parcela p
INNER JOIN Venda v 
    ON v.VendaID = p.VendaID
   AND v.EmpresaID = p.EmpresaID
INNER JOIN Clientes c 
    ON c.ClienteID = v.ClienteID
   AND c.EmpresaID = v.EmpresaID
WHERE
    p.EmpresaID = @EmpresaID
    AND p.ParcelaID IN @Ids
ORDER BY p.VendaID, p.NumeroParcela;";

            return Connection.Query<RowExtratoParcelaLote>(
                sql,
                new { Ids = parcelasIds, EmpresaID }
            ).ToList();
        }

        // ======================================================
        // Descobrir clienteId por venda (com filtro Empresa)
        // ======================================================
        public int? ObterClienteIdPorVenda(long vendaId)
        {
            const string sql = @"
SELECT v.ClienteID
FROM Venda v
WHERE v.VendaID = @VendaID
  AND v.EmpresaID = @EmpresaID;";

            return Connection.ExecuteScalar<int?>(
                sql, new { VendaID = vendaId, EmpresaID }
            );
        }

        // ======================================================
        // Descobrir clienteId por parcela (com filtro Empresa)
        // ======================================================
        public int? ObterClienteIdPorParcela(long parcelaId)
        {
            const string sql = @"
SELECT v.ClienteID
FROM Parcela p
INNER JOIN Venda v 
    ON v.VendaID = p.VendaID
   AND v.EmpresaID = p.EmpresaID
WHERE p.ParcelaID = @ParcelaID
  AND p.EmpresaID = @EmpresaID;";

            return Connection.ExecuteScalar<int?>(
                sql, new { ParcelaID = parcelaId, EmpresaID }
            );
        }

        // ======================================================
        // Extrato resumido por cliente (substitui ExtratoDal)
        // ======================================================
        public List<ContaAReceberDTO> ObterExtratoResumido(int clienteId)
        {
            const string sql = @"
SELECT
    p.ParcelaID,
    p.VendaID,
    v.ClienteID,
    c.Nome AS NomeCliente,
    p.NumeroParcela,
    p.DataVencimento,
    p.ValorParcela,
    ISNULL(p.ValorRecebido,0) AS ValorRecebido,
    (p.ValorParcela + ISNULL(p.Juros,0) + ISNULL(p.Multa,0) - ISNULL(p.ValorRecebido,0)) AS Saldo,
    p.Status AS StatusParcela
FROM Parcela p
INNER JOIN Venda v
    ON v.VendaID = p.VendaID
   AND v.EmpresaID = p.EmpresaID
INNER JOIN Clientes c
    ON c.ClienteID = v.ClienteID
   AND c.EmpresaID = v.EmpresaID
WHERE
    v.ClienteID = @ClienteID
    AND v.EmpresaID = @EmpresaID
ORDER BY p.DataVencimento;";

            return Connection.Query<ContaAReceberDTO>(
                sql, new { ClienteID = clienteId, EmpresaID }
            ).ToList();
        }

        // ======================================================
        // Extrato detalhado: parcelas do cliente (base)
        // ======================================================
        public List<ParcelaExtratoDetalhado> ObterParcelasDetalhado(int clienteId)
        {
            const string sql = @"
SELECT
    p.ParcelaID,
    p.VendaID,
    p.NumeroParcela,
    p.DataVencimento,
    p.ValorParcela,
    ISNULL(p.ValorRecebido,0) AS ValorRecebido,
    (p.ValorParcela + ISNULL(p.Juros,0) + ISNULL(p.Multa,0) - ISNULL(p.ValorRecebido,0)) AS Saldo,
    p.Status
FROM Parcela p
INNER JOIN Venda v
    ON v.VendaID = p.VendaID
   AND v.EmpresaID = p.EmpresaID
WHERE
    v.ClienteID = @ClienteID
    AND v.EmpresaID = @EmpresaID
ORDER BY p.DataVencimento;";

            return Connection.Query<ParcelaExtratoDetalhado>(
                sql, new { ClienteID = clienteId, EmpresaID }
            ).ToList();
        }

        // ======================================================
        // Extrato detalhado: pagamentos do cliente (base)
        // ======================================================
        public List<PagamentoExtratoModel> ObterPagamentosPorCliente(int clienteId)
        {
            const string sql = @"
SELECT
    pp.PagamentoID,
    pp.ParcelaID,
    pp.ValorPago,
    pp.DataPagamento,
    pp.Observacao
FROM PagamentosParciais pp
INNER JOIN Parcela p
    ON p.ParcelaID = pp.ParcelaID
   AND p.EmpresaID = pp.EmpresaID
INNER JOIN Venda v
    ON v.VendaID = p.VendaID
   AND v.EmpresaID = p.EmpresaID
WHERE
    v.ClienteID = @ClienteID
    AND pp.EmpresaID = @EmpresaID
ORDER BY pp.DataPagamento;";

            return Connection.Query<PagamentoExtratoModel>(
                sql, new { ClienteID = clienteId, EmpresaID }
            ).ToList();
        }

        // ======================================================
        // Recibo: pagamentos por parcela
        // ======================================================
        public List<PagamentoExtratoModel> ObterPagamentosPorParcela(long parcelaId)
        {
            const string sql = @"
SELECT
    PagamentoID,
    ParcelaID,
    ValorPago,
    DataPagamento,
    Observacao
FROM PagamentosParciais
WHERE ParcelaID = @ParcelaID
  AND EmpresaID = @EmpresaID
ORDER BY DataPagamento;";

            return Connection.Query<PagamentoExtratoModel>(
                sql, new { ParcelaID = parcelaId, EmpresaID }
            ).ToList();
        }

        // ======================================================
        // Relatório contas a receber (com filtro Empresa)
        // ======================================================
        public List<ContaAReceberDTO> ObterRelatorioContasReceber(
            int? clienteId,
            DateTime dataInicio,
            DateTime dataFim,
            List<string> statusStrings)
        {
            const string sql = @"
SELECT
    p.ParcelaID,
    p.VendaID,
    v.ClienteID,
    c.Nome AS NomeCliente,
    p.DataVencimento,
    p.ValorParcela,
    ISNULL(p.ValorRecebido,0) AS ValorRecebido,
    (p.ValorParcela + ISNULL(p.Juros,0) + ISNULL(p.Multa,0) - ISNULL(p.ValorRecebido,0)) AS Saldo,
    p.Status AS StatusParcela
FROM Parcela p
INNER JOIN Venda v 
    ON v.VendaID = p.VendaID
   AND v.EmpresaID = p.EmpresaID
INNER JOIN Clientes c 
    ON c.ClienteID = v.ClienteID
   AND c.EmpresaID = v.EmpresaID
WHERE
    p.EmpresaID = @EmpresaID
    AND (@ClienteID IS NULL OR v.ClienteID = @ClienteID)
    AND p.Status IN @Status
    AND (
        (p.Status = 'Pago' AND p.DataPagamento BETWEEN @Inicio AND @Fim)
        OR (p.Status = 'Atrasada' AND p.DataVencimento BETWEEN @Inicio AND @Fim)
        OR (p.Status IN ('Pendente', 'ParcialmentePago'))
    )
ORDER BY c.Nome, p.DataVencimento;";

            return Connection.Query<ContaAReceberDTO>(sql, new
            {
                EmpresaID,
                ClienteID = clienteId,
                Inicio = dataInicio,
                Fim = dataFim,
                Status = statusStrings
            }).ToList();
        }
    }

    // DTO interno para o lote
    public class RowExtratoParcelaLote
    {
        public int ClienteID { get; set; }
        public string NomeCliente { get; set; }
        public int VendaID { get; set; }
        public int ParcelaID { get; set; }
        public int NumeroParcela { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal ValorParcela { get; set; }
        public decimal ValorRecebido { get; set; }
        public decimal Saldo { get; set; }
        public string Status { get; set; }
    }
}
