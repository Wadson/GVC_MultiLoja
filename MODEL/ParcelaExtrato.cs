using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.Model
{
    public class ParcelaExtrato
    {

        public int ParcelaID { get; set; }
        public int VendaID { get; set; }
        public int NumeroParcela { get; set; }

        public DateTime DataVenda { get; set; }
        public DateTime DataVencimento { get; set; }

        public decimal ValorParcela { get; set; }

        // Pagamento
        public long? PagamentoID { get; set; }
        public DateTime? DataPagamento { get; set; }
        public decimal? ValorPago { get; set; }
        public string FormaPagamento { get; set; }
        public string Observacao { get; set; }


       
        public decimal ValorRecebido { get; set; }
        public decimal Juros { get; set; }
        public decimal Multa { get; set; }
        public decimal Saldo { get; set; }
        public string Status { get; set; }        
    }
}
