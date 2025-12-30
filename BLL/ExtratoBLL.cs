using Dapper;
using GVC.DAL;
using GVC.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.BLL
{
    public class ExtratoBLL
    {
        private readonly ExtratoDal _extratoDal = new ExtratoDal();

        public ExtratoCliente ObterExtratoClientePorVenda(long vendaId, bool detalhado)
        {
            using var conn = Helpers.Conexao.Conex();

            // 🔹 BUSCA O CLIENTE DA VENDA
            long clienteId = conn.ExecuteScalar<long>(
                "SELECT ClienteID FROM Venda WHERE VendaID = @id",
                new { id = vendaId });

            // 🔹 AGORA SIM BUSCA O EXTRATO
            return ObterExtratoCliente(clienteId, detalhado);
        }

        // Método interno reaproveitável
        private ExtratoCliente ObterExtratoCliente(long clienteId, bool detalhado)
        {
            var dados = _extratoDal.ObterExtratoPorCliente(clienteId);

            var extrato = new ExtratoCliente();
            var lookup = new Dictionary<long, ItemExtrato>();

            foreach (var r in dados)
            {
                if (!lookup.TryGetValue(r.ParcelaID, out var item))
                {
                    item = new ItemExtrato
                    {
                        VendaID = r.VendaID,
                        NumeroParcela = r.NumeroParcela,
                        DataVenda = r.DataVenda,
                        DataVencimento = r.DataVencimento,
                        ValorParcela = r.ValorParcela
                    };

                    lookup.Add(r.ParcelaID, item);
                    extrato.ItensExtrato.Add(item);
                }

                if (r.PagamentoID.HasValue && detalhado)
                {
                    item.Pagamentos.Add(new PagamentoExtratoModel
                    {
                        PagamentoID = r.PagamentoID.Value,
                        ParcelaID = r.ParcelaID,
                        DataPagamento = r.DataPagamento.Value,
                        ValorPago = r.ValorPago.Value,
                        FormaPagamento = r.FormaPagamento,
                        Observacao = r.Observacao
                    });
                }
            }

            foreach (var i in extrato.ItensExtrato)
            {
                i.TotalPago = i.Pagamentos.Sum(p => p.ValorPago);
                i.Saldo = i.ValorParcela - i.TotalPago;

                i.Status = i.Saldo <= 0
                    ? "Paga"
                    : i.TotalPago > 0
                        ? "Parcialmente Paga"
                        : "Em Aberto";

                extrato.TotalPago += i.TotalPago;
                extrato.TotalDevendo += i.Saldo;
            }

            extrato.SaldoAtual = extrato.TotalDevendo;
            return extrato;
        }
    }
}
