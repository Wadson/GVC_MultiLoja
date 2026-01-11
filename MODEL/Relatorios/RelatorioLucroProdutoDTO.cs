using System;
using System.Collections.Generic;
using System.Text;

namespace GVC.MODEL.Relatorios
{
    public class RelatorioLucroProdutoDTO
    {
        public int ProdutoID { get; set; }
        public string Produto { get; set; }

        public int QuantidadeVendida { get; set; }

        public decimal CustoTotal { get; set; }
        public decimal VendaTotal { get; set; }

        public decimal Lucro => VendaTotal - CustoTotal;
        // ✅ ESTA PROPRIEDADE PRECISA EXISTIR
        public decimal LucroTotal { get; set; }
    }

}
