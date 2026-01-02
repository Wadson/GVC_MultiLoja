using GVC.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.DTO
{
    public class VendaFinalizacaoDTO
    {
        public VendaModel Venda { get; set; }
        public List<ItemVendaModel> Itens { get; set; }
        public decimal Total { get; set; }
    }

}
