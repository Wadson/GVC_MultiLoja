using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GVC.MODEL.Enums;

namespace GVC.MODEL
{
    public class VendaModel
    {
        public long VendaID { get; set; }
        public DateTime DataVenda { get; set; }
        public string NomeCliente { get; set; }
        public long ClienteID { get; set; }
        public decimal ValorTotal { get; set; }
        public long? FormaPgtoID { get; set; }
        public decimal? Desconto { get; set; }
        public string? Observacoes { get; set; }

        // ✅ SOMENTE ENUM
        public EnumStatusVenda StatusVenda { get; set; }

        public long? VendedorID { get; set; }
    }
}
