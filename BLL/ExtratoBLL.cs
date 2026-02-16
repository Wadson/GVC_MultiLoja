using Dapper;
using GVC.DAL;
using GVC.Model;
using GVC.Model.Enums.GVC.Model.Enums;
using GVC.Model.Extensions;
using GVC.UTIL;
using System;
using System.Collections.Generic;
using System.Linq;
using GVC.Infra.Conexao;
using GVC.Infra.Repository;

public class ExtratoBLL
{
    private readonly ExtratoDal _extratoDal = new();
    private readonly ClienteRepository _clienteRepository = new();

    // ======================================================
    // EXTRATO PARA RECIBO (LOTE - VÁRIAS PARCELAS)
    // ======================================================
    public ExtratoCliente ObterExtratoPorParcelas(List<long> parcelasIds, DateTime dataEmissao)
    {
        if (parcelasIds == null || parcelasIds.Count == 0)
            throw new Exception("Nenhuma parcela informada para o extrato do lote.");

        using var conn = Conexao.Conex();

        var ids = parcelasIds.Select(x => (int)x).ToList();

        // Busca itens do lote (somente as parcelas selecionadas)
        var sql = @"
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
        INNER JOIN Venda v ON v.VendaID = p.VendaID
        INNER JOIN Clientes c ON c.ClienteID = v.ClienteID
        WHERE p.ParcelaID IN @Ids
        ORDER BY p.VendaID, p.NumeroParcela;";

        var rows = conn.Query(sql, new { Ids = ids }).ToList();

        if (rows == null || rows.Count == 0)
            throw new Exception("Parcelas não encontradas para gerar o recibo do lote.");

        // Segurança: lote deve ser de 1 único cliente (sua tela é por cliente)
        var clienteIdsDistintos = rows.Select(r => (int)r.ClienteID).Distinct().ToList();
        if (clienteIdsDistintos.Count > 1)
            throw new Exception("Não é permitido gerar recibo de lote com parcelas de clientes diferentes.");

        int clienteId = (int)rows[0].ClienteID;
        string nomeCliente = (string)rows[0].NomeCliente;

        var itens = rows.Select(r => new ItemExtrato
        {
            VendaID = (int)r.VendaID,
            ParcelaID = (int)r.ParcelaID,
            NumeroParcela = (int)r.NumeroParcela,
            DataVencimento = (DateTime)r.DataVencimento,
            ValorParcela = (decimal)r.ValorParcela,
            ValorRecebido = (decimal)r.ValorRecebido,
            Saldo = (decimal)r.Saldo,
            Status = (string)r.Status
        }).ToList();

        // Totais do extrato (para o recibo, o importante é TotalPago do lote)
        var extrato = new ExtratoCliente
        {
            ClienteID = clienteId,
            NomeCliente = nomeCliente,
            DataEmissao = dataEmissao,
            ItensExtrato = itens,
            TotalPago = itens.Sum(i => i.ValorRecebido), // no lote quitado, isso vira o total recebido
            TotalDevendo = itens.Sum(i => i.Saldo),
            SaldoAtual = itens.Sum(i => i.Saldo)
        };

        return extrato;
    }

    // ======================================================
    // EXTRATO POR VENDA (ANTIGO)
    // ======================================================

    public List<ExtratoCliente> ObterContasPendentesAgrupadasPorCliente(
    List<ContaAReceberDTO> dadosGrid)
    {
        var statusValidos = new[]
        {
        EnumStatusParcela.Pendente,
        EnumStatusParcela.ParcialmentePago,
        EnumStatusParcela.Atrasada
    };

        var filtradas = dadosGrid
            .Where(p => statusValidos.Contains(
                p.StatusParcela.ToEnumStatusParcela()))
            .ToList();

        var extratos = filtradas
            .GroupBy(p => new { p.ClienteID, p.NomeCliente })
            .Select(g =>
            {
                var itens = g
                    .OrderBy(p => p.DataVencimento)
                    .Select(p => new ItemExtrato
                    {
                        VendaID = p.VendaID,
                        ParcelaID = p.ParcelaID,
                        DataVencimento = p.DataVencimento,
                        ValorParcela = p.ValorParcela,
                        ValorRecebido = p.ValorRecebido,
                        Saldo = p.Saldo,
                        Status = p.StatusParcela
                    })
                    .ToList();

                return new ExtratoCliente
                {
                    ClienteID = g.Key.ClienteID,
                    NomeCliente = g.Key.NomeCliente,
                    DataEmissao = DateTime.Now,
                    ItensExtrato = itens,
                    TotalDevendo = itens.Sum(i => i.Saldo),
                    SaldoAtual = itens.Sum(i => i.Saldo)
                };
            })
            .OrderBy(e => e.NomeCliente)
            .ToList();

        return extratos;
    }




    // ======================================================
    // EXTRATO POR VENDA (ANTIGO)
    // ======================================================
    public ExtratoCliente ObterExtratoClientePorVenda(long vendaId, bool detalhado)
    {
        using var conn = Conexao.Conex();

        int? clienteId = conn.ExecuteScalar<int?>(@"
            SELECT ClienteID
            FROM Venda
            WHERE VendaID = @id",
            new { id = vendaId });

        if (clienteId == null)
            throw new Exception("Venda não encontrada.");

        return ObterExtratoCliente(clienteId.Value, detalhado);
    }

    // ======================================================
    // EXTRATO RESUMIDO / SIMPLES (ANTIGO)
    // ======================================================
    public ExtratoCliente ObterExtratoCliente(int clienteId, bool detalhado)
    {
        var cliente = _clienteRepository.BuscarPorId(clienteId)
            ?? throw new Exception("Cliente não encontrado.");

        var parcelas = _extratoDal.ObterExtratoResumido(clienteId);

        var itens = parcelas.Select(p => new ItemExtrato
        {
            VendaID = p.VendaID,
            ParcelaID = p.ParcelaID,
            NumeroParcela = p.NumeroParcela,
            DataVencimento = p.DataVencimento,
            ValorParcela = p.ValorParcela,
            ValorRecebido = p.ValorRecebido,
            Saldo = p.Saldo,
            Status = p.Status
        }).ToList();

        var extrato = new ExtratoCliente
        {
            ClienteID = cliente.ClienteID,
            NomeCliente = cliente.Nome,
            DataEmissao = DateTime.Now,
            ItensExtrato = itens
        };

        var parcelasUnicas = itens
            .GroupBy(i => i.ParcelaID)
            .Select(g => g.First());

        extrato.TotalPago = parcelasUnicas.Sum(p => p.ValorRecebido);
        extrato.TotalDevendo = parcelasUnicas.Sum(p => p.Saldo);
        extrato.SaldoAtual = extrato.TotalDevendo;

        return extrato;
    }

    // ======================================================
    // EXTRATO DETALHADO PROFISSIONAL (NOVO)
    // ======================================================
    public List<ParcelaExtratoDetalhado> ObterExtratoDetalhado(int clienteId)
    {
        var parcelas = _extratoDal.ObterParcelas(clienteId);
        var pagamentos = _extratoDal.ObterPagamentosPorCliente(clienteId); // ✅ CORRETO

        foreach (var parcela in parcelas)
        {
            parcela.Pagamentos = pagamentos
                .Where(p => p.ParcelaID == parcela.ParcelaID)
                .Select(p => new PagamentoExtrato
                {
                    DataPagamento = p.DataPagamento,
                    ValorPago = p.ValorPago,
                    Observacao = p.Observacao
                })
                .ToList();
        }

        return parcelas;
    }

    // ======================================================
    // EXTRATO PARA RECIBO (PARCELA ESPECÍFICA)
    // ======================================================
    public ExtratoCliente ObterExtratoPorParcela(long parcelaId)
    {
        using var conn = Conexao.Conex();

        int? clienteId = conn.ExecuteScalar<int?>(@"
        SELECT v.ClienteID
        FROM Parcela p
        INNER JOIN Venda v ON v.VendaID = p.VendaID
        WHERE p.ParcelaID = @id",
            new { id = parcelaId });

        if (clienteId == null)
            throw new Exception("Parcela não vinculada a cliente.");

        // 🔹 Recibo SEMPRE usa extrato resumido
        return ObterExtratoCliente(clienteId.Value, false);
    }


    // ======================================================
    // RECIBO (usa histórico)
    // ======================================================
    public List<PagamentoExtratoModel> ObterReciboPorParcela(long parcelaId)
    {
        return _extratoDal.ObterPagamentosPorParcela(parcelaId);
    }
    // ======================================================
    // RELATÓRIO CONTAS A RECEBER (FORM DEDICADO)
    // ======================================================
    public List<ExtratoCliente> ObterRelatorioContasReceber(
      int? clienteId,
      DateTime dataInicio,
      DateTime dataFim,
      List<EnumStatusParcela> statusSelecionados)
    {
        using var conn = Conexao.Conex();

        var statusStrings = statusSelecionados
            .Select(s => s.ToString())
            .ToList();

        var parcelas = conn.Query<ContaAReceberDTO>(@"
    SELECT
        p.ParcelaID,
        p.VendaID,
        v.ClienteID,
        c.Nome AS NomeCliente,
        p.DataVencimento,
        p.ValorParcela,
        p.ValorRecebido,
        (p.ValorParcela - p.ValorRecebido) AS Saldo,
        p.Status AS StatusParcela
    FROM Parcela p
    INNER JOIN Venda v ON v.VendaID = p.VendaID
    INNER JOIN Clientes c ON c.ClienteID = v.ClienteID
    WHERE
        (@clienteId IS NULL OR v.ClienteID = @clienteId)
        AND p.Status IN @status
        AND (
            (p.Status = 'Pago' AND p.DataPagamento BETWEEN @inicio AND @fim)
            OR (p.Status = 'Atrasada' AND p.DataVencimento BETWEEN @inicio AND @fim)
            OR (p.Status IN ('Pendente', 'ParcialmentePago'))
        )
    ORDER BY c.Nome, p.DataVencimento",
    new
    {
        clienteId,
        inicio = dataInicio,
        fim = dataFim,
        status = statusStrings
    }).ToList();


        if (!parcelas.Any())
            return new List<ExtratoCliente>();

        // 🔹 AGRUPAMENTO FINAL (SEM FILTRAR STATUS!)
        var extratos = parcelas
            .GroupBy(p => new { p.ClienteID, p.NomeCliente })
            .Select(g =>
            {
                var itens = g
                    .OrderBy(p => p.DataVencimento)
                    .Select(p => new ItemExtrato
                    {
                        VendaID = p.VendaID,
                        ParcelaID = p.ParcelaID,
                        DataVencimento = p.DataVencimento,
                        ValorParcela = p.ValorParcela,
                        ValorRecebido = p.ValorRecebido,
                        Saldo = p.Saldo,
                        Status = p.StatusParcela
                    })
                    .ToList();

                return new ExtratoCliente
                {
                    ClienteID = g.Key.ClienteID,
                    NomeCliente = g.Key.NomeCliente,
                    DataEmissao = DateTime.Now,
                    ItensExtrato = itens,

                    // 🔥 TOTAIS CORRETOS
                    TotalPago = itens
                        .Where(i => i.Status == EnumStatusParcela.Pago.ToString())
                        .Sum(i => i.ValorRecebido),

                    TotalDevendo = itens
                        .Where(i => i.Status != EnumStatusParcela.Pago.ToString())
                        .Sum(i => i.Saldo),

                    SaldoAtual = itens.Sum(i => i.Saldo)
                };
            })
            .OrderBy(e => e.NomeCliente)
            .ToList();

        return extratos;
    }




    private static string MapStatusParcelaBanco(EnumStatusParcela status)
    {
        return status switch
        {
            EnumStatusParcela.Pendente => "Pendente",
            EnumStatusParcela.ParcialmentePago => "ParcialmentePago",
            EnumStatusParcela.Pago => "Pago",
            EnumStatusParcela.Atrasada => "Atrasada",
            EnumStatusParcela.Cancelada => "Cancelada",
            _ => throw new ArgumentOutOfRangeException(nameof(status), status, null)
        };
    }

    private static List<ExtratoCliente> AgruparPorCliente(
    List<ContaAReceberDTO> parcelas)
    {
        return parcelas
            .GroupBy(p => new { p.ClienteID, p.NomeCliente })
            .Select(g =>
            {
                var itens = g.Select(p => new ItemExtrato
                {
                    VendaID = p.VendaID,
                    ParcelaID = p.ParcelaID,
                    DataVencimento = p.DataVencimento,
                    ValorParcela = p.ValorParcela,
                    ValorRecebido = p.ValorRecebido,
                    Saldo = p.Saldo,
                    Status = p.StatusParcela
                }).ToList();

                decimal totalPago = itens
                    .Where(i => i.Status == "Pago")
                    .Sum(i => i.ValorRecebido);

                decimal totalDevendo = itens
                    .Where(i => i.Status != "Pago")
                    .Sum(i => i.Saldo);

                return new ExtratoCliente
                {
                    ClienteID = g.Key.ClienteID,
                    NomeCliente = g.Key.NomeCliente,
                    DataEmissao = DateTime.Now,
                    ItensExtrato = itens,

                    // 🔑 TOTAIS CORRETOS
                    TotalPago = totalPago,
                    TotalDevendo = totalDevendo,
                    SaldoAtual = totalDevendo
                };
            })
            .OrderBy(e => e.NomeCliente)
            .ToList();
    }

    // ======================================================
    // RELATÓRIO CONTAS PAGAS POR CLIENTE
    // ======================================================
    public List<ExtratoCliente> ObterRelatorioContasPagasPorCliente(int? clienteId, DateTime dataInicio, DateTime dataFim)
    {
        return ObterRelatorioContasReceber(
            clienteId,
            dataInicio,
            dataFim,
            new List<EnumStatusParcela>
            {
            EnumStatusParcela.Pago
            });
    }
}
