using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.MODEL
{
    public class ExtratoCliente
    {
        public long ClienteID { get; set; }
        public string NomeCliente { get; set; }
        public string CPF_CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public decimal TotalPago { get; set; }
        public decimal TotalDevendo { get; set; }
        public decimal SaldoAtual { get; set; }
        public List<ItemExtrato> ItensExtrato { get; set; } = new();

        public DateTime DataEmissao { get; set; } = DateTime.Now;

       
    }

    public class ItemExtrato
    {
        public DateTime DataVenda { get; set; }
        public long VendaID { get; set; }
        public string Descricao { get; set; }
        public int NumeroParcela { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; }
        public decimal ValorParcela { get; set; }
        public decimal ValorRecebido { get; set; }
        public decimal Desconto { get; set; }
        public decimal Juros { get; set; }
        public decimal Saldo { get; set; }
        public string Status { get; set; }
        public string FormaPagamento { get; set; }
        public decimal TotalPago { get; set; }
        // 🔥 NOVO
        public List<PagamentoExtratoModel> Pagamentos { get; set; } = new();

       
    }
}
