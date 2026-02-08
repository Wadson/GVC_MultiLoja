using GVC.DAL;
using GVC.Infra.Repository;
using GVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC
{
    internal class VendaService
    {
        private readonly VendaRepository _vendaRepository;
        private readonly ItemVendaRepository _itemRepository;
        private readonly ParcelaRepository _parcelaRepository;

        public VendaService()
        {
        }

        public VendaService(VendaRepository vendaRepository, ItemVendaRepository itemRepository, ParcelaRepository parcelaRepository)
        {
            _vendaRepository = vendaRepository;
            _itemRepository = itemRepository;
            _parcelaRepository = parcelaRepository;
        }

        //public int CriarVenda(VendaModel venda, List<ItemVendaModel> itens, List<ParcelaModel> parcelas)
        //{
        //    // 1 – Cria venda
        //    // 2 – Salva itens
        //    // 3 – Salva parcelas
        //    // 4 – Atualiza estoque
        //    // Tudo dentro de uma transação!
        //}
    }
}
