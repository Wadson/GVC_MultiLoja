using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GVC.MODEL.Enums;


namespace GVC.MODEL
{
    
    public class ParcelaModel
    {
        public int ParcelaID { get; set; }
        public int VendaID { get; set; }
        public int NumeroParcela { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal ValorParcela { get; set; }
        public decimal ValorRecebido { get; set; }
        public decimal Juros { get; set; }
        public decimal Multa { get; set; }
        public decimal Saldo { get; set; }

        // ✅ SOMENTE ENUM
        public EnumStatusParcela Status { get; set; }

        public DateTime? DataPagamento { get; set; }
        public string? Observacao { get; set; }
    }

}
