using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.Model
{
    public class ProdutoEstoqueBaixo
    {
        public int ProdutoID { get; set; }
        public string NomeProduto { get; set; }
        public int Estoque { get; set; }
        public string Unidade { get; set; }
        public string Marca { get; set; }
    }
}
