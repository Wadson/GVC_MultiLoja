using Dapper;
using GVC.DAL;
using GVC.Model;
using GVC.Model.Enums;
using GVC.Model.Extensions;
using GVC.UTIL;
using System;
using System.Collections.Generic;
using System.Linq;
using GVC.Infra.Conexao;
using GVC.Infra.Repository; 

public class ExtratoBLL
{
    private readonly ExtratoRepository _extratoRepository = new();
    private readonly ClienteRepository _clienteRepository = new();


    // ======================================================
    // EXTRATO PARA RECIBO (LOTE - VÁRIAS PARCELAS)
    // ======================================================
    public ExtratoCliente ObterExtratoPorParcelas(List<long> parcelasIds, DateTime dataEmissao)
    {
        if (parcelasIds == null || parcelasIds.Count == 0)
            throw new Exception("Nenhuma parcela informada para o extrato do lote.");

        var ids = parcelasIds.Select(x => (int)x).ToList();

        var rows = _extratoRepository.ObterExtratoPorParcelas(ids);

        if (rows == null || rows.Count == 0)
            throw new Exception("Parcelas não encontradas para gerar o recibo do lote.");

        var clienteIdsDistintos = rows.Select(r => r.ClienteID).Distinct().ToList();
        if (clienteIdsDistintos.Count > 1)
            throw new Exception("Não é permitido gerar recibo de lote com parcelas de clientes diferentes.");

        int clienteId = rows[0].ClienteID;
        string nomeCliente = rows[0].NomeCliente;

        var itens = rows.Select(r => new ItemExtrato
        {
            VendaID = r.VendaID,
            ParcelaID = r.ParcelaID,
            NumeroParcela = r.NumeroParcela,
            DataVencimento = r.DataVencimento,
            ValorParcela = r.ValorParcela,
            ValorRecebido = r.ValorRecebido,
            Saldo = r.Saldo,
            Status = r.Status
        }).ToList();

        return new ExtratoCliente
        {
            ClienteID = clienteId,
            NomeCliente = nomeCliente,
            DataEmissao = dataEmissao,
            ItensExtrato = itens,
            TotalPago = itens.Sum(i => i.ValorRecebido),
            TotalDevendo = itens.Sum(i => i.Saldo),
            SaldoAtual = itens.Sum(i => i.Saldo)
        };
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
        int? clienteId = _extratoRepository.ObterClienteIdPorVenda(vendaId);

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

        var parcelas = _extratoRepository.ObterExtratoResumido(clienteId);

        if (parcelas == null || parcelas.Count == 0)
        {
            return new ExtratoCliente
            {
                ClienteID = cliente.ClienteID,
                NomeCliente = cliente.Nome,
                DataEmissao = DateTime.Now,
                ItensExtrato = new List<ItemExtrato>(),
                TotalPago = 0m,
                TotalDevendo = 0m,
                SaldoAtual = 0m
            };
        }

        var itens = parcelas.Select(p => new ItemExtrato
        {
            VendaID = p.VendaID,
            ParcelaID = p.ParcelaID,
            NumeroParcela = p.NumeroParcela,
            DataVencimento = p.DataVencimento,
            ValorParcela = p.ValorParcela,
            ValorRecebido = p.ValorRecebido,
            Saldo = p.Saldo,

            // ✅ AQUI É A CORREÇÃO
            Status = p.StatusParcela
        }).ToList();

        var extrato = new ExtratoCliente
        {
            ClienteID = cliente.ClienteID,
            NomeCliente = cliente.Nome,
            DataEmissao = DateTime.Now,
            ItensExtrato = itens
        };

        // Evita duplicidade caso venha repetido
        var parcelasUnicas = itens
            .GroupBy(i => i.ParcelaID)
            .Select(g => g.First())
            .ToList();

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
        var parcelas = _extratoRepository.ObterParcelasDetalhado(clienteId);
        var pagamentos = _extratoRepository.ObterPagamentosPorCliente(clienteId);

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
        int? clienteId = _extratoRepository.ObterClienteIdPorParcela(parcelaId);

        if (clienteId == null)
            throw new Exception("Parcela não vinculada a cliente.");

        return ObterExtratoCliente(clienteId.Value, false);
    }



    // ======================================================
    // RECIBO (usa histórico)
    // ======================================================
    public List<PagamentoExtratoModel> ObterReciboPorParcela(long parcelaId)
    {
        return _extratoRepository.ObterPagamentosPorParcela(parcelaId);
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
        if (statusSelecionados == null || statusSelecionados.Count == 0)
            return new List<ExtratoCliente>();

        var emissao = DateTime.Now;

        var statusStrings = statusSelecionados.Select(MapearStatusParcelaParaBanco)
            .Distinct()
            .ToList();

        var parcelas = _extratoRepository.ObterRelatorioContasReceber(
            clienteId,
            dataInicio,
            dataFim,
            statusStrings
        );

        if (parcelas == null || !parcelas.Any())
            return new List<ExtratoCliente>();

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
                    DataEmissao = emissao,
                    ItensExtrato = itens,

                    TotalPago = itens
                    .Where(i => ParseStatusParcela(i.Status) == EnumStatusParcela.Pago)
                    .Sum(i => i.ValorRecebido),

                                    TotalDevendo = itens
                    .Where(i => ParseStatusParcela(i.Status) != EnumStatusParcela.Pago)
                    .Sum(i => i.Saldo),

                    SaldoAtual = itens.Sum(i => i.Saldo)
                };
            })
            .OrderBy(e => e.NomeCliente)
            .ToList();

        return extratos;
    }
    private static EnumStatusParcela? ParseStatusParcela(string? statusDb)
    {
        if (string.IsNullOrWhiteSpace(statusDb))
            return null;

        var s = statusDb.Trim().ToUpperInvariant();

        return s switch
        {
            "PENDENTE" => EnumStatusParcela.Pendente,
            "EM ABERTO" => EnumStatusParcela.Pendente,

            "PAGO" => EnumStatusParcela.Pago,
            "PAGA" => EnumStatusParcela.Pago,

            "ATRASADA" => EnumStatusParcela.Atrasada,

            "CANCELADA" => EnumStatusParcela.Cancelada,

            "PARCIALMENTEPAGO" => EnumStatusParcela.ParcialmentePago,
            "PARCIALMENTE PAGO" => EnumStatusParcela.ParcialmentePago,
            "PARCIALMENTEPAGA" => EnumStatusParcela.ParcialmentePago,
            "PARCIALMENTE PAGA" => EnumStatusParcela.ParcialmentePago,

            _ => null
        };
    }

    private static string MapearStatusParcelaParaBanco(EnumStatusParcela status)
    {
        return status switch
        {
            EnumStatusParcela.Pendente => "Pendente",
            EnumStatusParcela.ParcialmentePago => "ParcialmentePago",
            EnumStatusParcela.Pago => "Pago",
            EnumStatusParcela.Atrasada => "Atrasada",
            EnumStatusParcela.Cancelada => "Cancelada",
            _ => "Pendente"
        };
    }

    private static string NormalizarStatus(string statusDb)
    {
        return statusDb?.Trim().ToUpperInvariant() switch
        {
            "PAGA" => "Pago",
            "PAGO" => "Pago",
            "EM ABERTO" => "Pendente",
            "PENDENTE" => "Pendente",
            "PARCIALMENTEPAGA" => "ParcialmentePago",
            "PARCIALMENTE PAGA" => "ParcialmentePago",
            "PARCIALMENTEPAGO" => "ParcialmentePago",
            "PARCIALMENTE PAGO" => "ParcialmentePago",
            "ATRASADA" => "Atrasada",
            "CANCELADA" => "Cancelada",
            _ => statusDb?.Trim() ?? ""
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
