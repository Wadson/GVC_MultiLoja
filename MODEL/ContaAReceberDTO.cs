using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.MODEL
{
    public class ContaAReceberDTO
    {
        public int ParcelaID { get; set; }
        public int VendaID { get; set; }
        public int NumeroParcela { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal ValorParcela { get; set; }
        public decimal ValorRecebido { get; set; }
        public decimal Saldo { get; set; }
        public string StatusParcela { get; set; }
        public string FormaPgto { get; set; }
        public string Observacoes { get; set; } // ⬅️ aqui
    }
}
