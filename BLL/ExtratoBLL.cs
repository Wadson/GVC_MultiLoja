using Dapper;
using GVC.DAL;
using GVC.Model;
using GVC.UTIL;
using System;
using System.Collections.Generic;
using System.Linq;

public class ExtratoBLL
{
    private readonly ExtratoDal _extratoDal = new();
    private readonly ClienteDal _clienteDal = new();

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
        var cliente = _clienteDal.BuscarPorId(clienteId)
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
}
