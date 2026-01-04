using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.Model
{
    public class ProdutoLucrativo
    {
        public int ProdutoID { get; set; }
        public string NomeProduto { get; set; }
        public int Estoque { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoDeVenda { get; set; }
        public decimal LucroUnitario { get; set; }
        public decimal LucroTotal { get; set; }
    }
}
