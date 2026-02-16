using System;
using System.Collections.Generic;
using System.Text;

namespace GVC.DTO
{
    public class ItemEntradaDTO
    {
        public int ProdutoID { get; set; }
        public int FornecedorID { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoCompra { get; set; }
        public decimal PrecoCusto { get; set; }
    }

}
