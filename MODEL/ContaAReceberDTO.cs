using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.Model
{
    public class ContaAReceberDTO
    {
        public int ParcelaID { get; set; }
        public int ClienteID { get; set; }
        public int VendaID { get; set; }
        public int NumeroParcela { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal ValorParcela { get; set; }
        public decimal ValorRecebido { get; set; }
        public decimal Saldo { get; set; }
        public string StatusParcela { get; set; }
        public string NomeFormaPagamento { get; set; }
        public string Observacoes { get; set; } // ⬅️ aqui

        public List<ContaAReceberDTO> Parcelas { get; set; } = new();
        public decimal TotalCliente => Parcelas.Sum(p => p.Saldo);
    }
}
