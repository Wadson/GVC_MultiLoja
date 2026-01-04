using Dapper;
using GVC.DAL;
using GVC.DALL;
using GVC.Model;
using GVC.UTIL;

public class ExtratoBLL
{
    private readonly ExtratoDal _extratoDal = new();
    private readonly ClienteDal _clienteDal = new();

    // ======================================================
    // EXTRATO POR VENDA
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
    // EXTRATO POR CLIENTE (CORE)
    // ======================================================
    public ExtratoCliente ObterExtratoCliente(int clienteId, bool detalhado)
    {
        // 🔹 Busca o cliente
        var cliente = _clienteDal.BuscarPorId(clienteId)
            ?? throw new Exception("Cliente não encontrado.");

        // 🔹 Busca os dados do DAL
        List<ParcelaExtrato> parcelas =
            _extratoDal.ObterExtratoPorCliente(clienteId, detalhado);

        // 🔹 CONVERSÃO EXPLÍCITA → ItemExtrato
        List<ItemExtrato> itens = parcelas.Select(p => new ItemExtrato
        {
            VendaID = p.VendaID,
            ParcelaID = p.ParcelaID,
            NumeroParcela = p.NumeroParcela,
            DataVencimento = p.DataVencimento,
            DataPagamento = p.DataPagamento, // só vem no detalhado
            ValorParcela = p.ValorParcela,
            ValorRecebido = p.ValorRecebido,
            Saldo = p.Saldo,
            Status = p.Status
        }).ToList();

        // 🔹 AGORA SIM CRIA O EXTRATO
        var extrato = new ExtratoCliente
        {
            ClienteID = cliente.ClienteID,
            NomeCliente = cliente.Nome,
            DataEmissao = DateTime.Now,
            ItensExtrato = itens
        };

        extrato.TotalPago = itens.Sum(i => i.ValorRecebido);
        extrato.TotalDevendo = itens.Sum(i => i.Saldo);
        extrato.SaldoAtual = extrato.TotalDevendo;

        return extrato;
    }

    // ======================================================
    // EXTRATO A PARTIR DE UMA PARCELA (RECIBO)
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

        // 🔹 RECIBO USA SEMPRE RESUMIDO
        return ObterExtratoCliente(clienteId.Value, false);
    }
}
