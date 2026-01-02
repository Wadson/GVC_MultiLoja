using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.DTO
{
    public class ParcelamentoRequest
    {
        public decimal ValorTotal { get; set; }
        public int QuantidadeParcelas { get; set; }
        public int IntervaloDias { get; set; }
        public DateTime DataPrimeiroVencimento { get; set; }
        public bool PagamentoAVista { get; set; }
    }

}
