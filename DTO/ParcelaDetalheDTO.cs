using System;
using System.Collections.Generic;
using System.Text;

namespace GVC.DTO
{
    public class ParcelaDetalheDTO
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

        public string Status { get; set; }
    }

}
