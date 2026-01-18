using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.Model
{
    public class PagamentoExtratoModel
    {
        public long PagamentoID { get; set; }
        public long ParcelaID { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal ValorPago { get; set; }
        public string NomeFormaPagamento { get; set; }
        public string Observacao { get; set; }
    }

}
