using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.MODEL
{
    public class ItensExtrato
    {


        public long ClienteID { get; set; }
        public string NomeCliente { get; set; }
        public string CPF_CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public decimal TotalPago { get; set; }
        public decimal TotalDevendo { get; set; }
        public decimal SaldoAtual { get; set; }
        public long ParcelaID { get; set; }
        public long VendaID { get; set; }
        public int NumeroParcela { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal ValorParcela { get; set; }
        public decimal Saldo { get; set; }
        public string Status { get; set; }

        public List<PagamentoExtratoModel> Pagamentos { get; set; } = new();

        public string Descricao { get; set; }      
        public DateTime? DataPagamento { get; set; }      
        public decimal ValorRecebido { get; set; }
        public decimal Desconto { get; set; }
        public decimal Juros { get; set; }       
        public string FormaPagamento { get; set; }
    }
}
