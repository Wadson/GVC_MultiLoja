using System;
using System.Collections.Generic;
using System.Text;

namespace GVC.MODEL.Relatorios
{
    public class RelatorioProdutoDTO
    {
        public string NomeProduto { get; set; } = "";
        public int Quantidade { get; set; }
        public decimal PrecoDeVenda { get; set; }
        public decimal LucroTotal { get; set; }
    }

}
