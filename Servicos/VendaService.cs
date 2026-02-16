using GVC.DAL;
using GVC.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GVC.Infra.Repository;


namespace GVC.Service
{
    public class VendaService
    {
        private readonly SqlConnection _connection;
        private readonly VendaRepository _vendaRepository;
        private readonly EstoqueService _estoqueService;
        private readonly FinanceiroService _financeiroService;

        public VendaService(
            SqlConnection connection,
            VendaRepository vendaRepository,
            EstoqueService estoqueService,
            FinanceiroService financeiroService)
        {
            _connection = connection;
            _vendaRepository = vendaRepository;
            _estoqueService = estoqueService;
            _financeiroService = financeiroService;
        }

        public int SalvarVendaCompleta(
            VendaModel venda,
            List<ItemVendaModel> itens,
            List<ParcelaModel>? parcelas = null)
        {
            CalcularSubtotais(itens);
            CalcularTotal(venda, itens);

            _financeiroService.DefinirStatusVenda(venda, parcelas);

            using var tran = _connection.BeginTransaction();

            try
            {
                int vendaId = _vendaRepository.InserirVenda(venda, tran);

                foreach (var item in itens)
                {
                    item.VendaID = vendaId;
                    _vendaRepository.InserirItem(item, tran);
                    _estoqueService.BaixarEstoque(item.ProdutoID, item.Quantidade, tran);
                }

                if (parcelas != null && parcelas.Any())
                    _vendaRepository.InserirParcelas(vendaId, parcelas, tran);

                tran.Commit();
                return vendaId;
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }

        private void CalcularSubtotais(List<ItemVendaModel> itens)
        {
            foreach (var item in itens)
            {
                var desconto = item.DescontoItem ?? 0m;
                item.Subtotal = (item.Quantidade * item.PrecoUnitario) - desconto;
            }
        }

        private void CalcularTotal(VendaModel venda, List<ItemVendaModel> itens)
        {
            venda.Desconto ??= 0m;
            venda.ValorTotal = itens.Sum(i => i.Subtotal) - venda.Desconto.Value;
        }
    }

}
