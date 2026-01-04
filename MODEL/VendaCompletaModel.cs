using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.Model
{
    public class VendaCompletaModel
    {
        public long VendaID { get; set; }

        // ===== DATA DA VENDA =====
        public DateTime DataVenda { get; set; }

        public long ClienteID { get; set; }
        public string ClienteNome { get; set; }
        public string CpfCliente { get; set; }

        public decimal ValorTotal { get; set; }
        public decimal Desconto { get; set; }

        public long FormaPgtoID { get; set; }
        public string Observacoes { get; set; }

        // ===== LISTAS ===============
        public List<ItemVendaModel> Itens { get; set; }
        public List<ParcelaModel> Parcelas { get; set; }
        public long VendedorID { get; set; }
        public string VendedorNome { get; set; }
    }


}
