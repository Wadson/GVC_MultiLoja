using System;
using System.Collections.Generic;
using System.Text;

namespace GVC.MODEL.Relatorios
{
    public class RelatorioProdutoEstoqueDTO
    {
        public int ProdutoID { get; set; }
        public string Produto { get; set; }
        public int Estoque { get; set; }

        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }

        public decimal LucroUnitario => PrecoVenda - PrecoCusto;
        public decimal LucroEstoque => LucroUnitario * Estoque;
    }
}
