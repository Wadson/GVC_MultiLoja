using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.MODEL
{
    public class PagamentoExtratoModel
    {
        public DateTime DataPagamento { get; set; }
        public decimal ValorPago { get; set; }
        public string FormaPagamento { get; set; }
        public string Observacao { get; set; }
    }

}
