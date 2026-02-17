using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.Model
{
    public class ExtratoCliente
    {
        public int ClienteID { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataEmissao { get; set; }
        public List<ItemExtrato> ItensExtrato { get; set; } = new();
        public decimal TotalPago { get; set; }
        public decimal TotalDevendo { get; set; }
        public decimal SaldoAtual { get; set; }
    }


    public class ItemExtrato
    {
        public int VendaID { get; set; }
        public int ParcelaID { get; set; }
        public int NumeroParcela { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; }
        public decimal ValorParcela { get; set; }
        public decimal ValorRecebido { get; set; }
        public decimal Saldo { get; set; }
        public string Status { get; set; }
    }
}
