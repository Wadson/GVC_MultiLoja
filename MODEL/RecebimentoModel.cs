using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.Model
{
    internal class RecebimentoModel
    {
        public Guid RecebimentoID { get; set; }
        public Guid VendaID { get; set; }
        public DateTime? DataRecebimento { get; set; }
        public decimal? ValorRecebido { get; set; }
        public Guid ParcelaID { get; set; }
        public Guid ContaReceberID { get; set; }
        public DateTime? DataRegistro { get; set; }
    }
}
