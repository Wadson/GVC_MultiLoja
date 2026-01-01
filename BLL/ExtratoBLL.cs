using Dapper;
using GVC.DAL;
using GVC.DALL;
using GVC.MODEL;
using GVC.UTIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.BLL
{
    public class ExtratoBLL
    {
        private readonly ExtratoDal _dal = new();
        private readonly PagamentoBLL _pagamentoBll = new();
        private readonly ParcelaDal _parcelaDal = new ParcelaDal();
        private readonly ClienteDal _clienteDal = new ClienteDal();
        private readonly ExtratoDal _extratoDal = new ExtratoDal();
        

        public ExtratoCliente ObterExtratoClientePorVenda(long vendaId, bool detalhado)
        {
            using var conn = Conexao.Conex();

            // 🔹 BUSCA O CLIENTE DA VENDA
            int clienteId = conn.ExecuteScalar<int>( "SELECT ClienteID FROM Venda WHERE VendaID = @id",
                new { id = vendaId });

            // 🔹 AGORA SIM BUSCA O EXTRATO
            return ObterExtratoCliente(clienteId, detalhado);
        }

        // Método interno reaproveitável
        public ExtratoCliente ObterExtratoCliente(int clienteId, bool detalhado)
        {
            var cliente = _clienteDal.BuscarPorId(clienteId)
                ?? throw new Exception("Cliente não encontrado.");

            // Conversão explícita de List<ParcelaExtrato> para List<ItemExtrato>
            var parcelasExtrato = _extratoDal.ObterExtratoPorCliente(clienteId);
            var itensExtrato = parcelasExtrato.Select(p => new ItemExtrato
            {
                VendaID = p.VendaID,
                ParcelaID = p.ParcelaID,
                NumeroParcela = p.NumeroParcela,
                DataVencimento = p.DataVencimento,
                DataPagamento = p.DataPagamento,
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
                ItensExtrato = itensExtrato
            };

            extrato.TotalPago = extrato.ItensExtrato.Sum(x => x.ValorRecebido);
            extrato.TotalDevendo = extrato.ItensExtrato.Sum(x => x.Saldo);
            extrato.SaldoAtual = extrato.TotalDevendo;

            return extrato;
        }
    }
}
