using System;
using System.Collections.Generic;
using System.Text;

namespace GVC.Model
{
    public class ParcelaExtratoDetalhado
    {
        public int ParcelaID { get; set; }
        public int VendaID { get; set; }
        public int NumeroParcela { get; set; }
        public DateTime DataVencimento { get; set; }

        public decimal ValorParcela { get; set; }
        public decimal ValorRecebido { get; set; }
        public decimal Saldo { get; set; }
        public string Status { get; set; }

        public List<PagamentoExtrato> Pagamentos { get; set; } = new();
    }
    public class PagamentoExtrato
    {
        public DateTime DataPagamento { get; set; }
        public decimal ValorPago { get; set; }
        public string Observacao { get; set; }
    }


}
