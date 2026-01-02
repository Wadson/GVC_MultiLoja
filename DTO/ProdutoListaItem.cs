using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.DTO
{
    public class ProdutoListaItem
    {
        public long ProdutoID { get; set; }
        public decimal PrecoUnitario { get; set; }
        public string Texto { get; set; }
    }
}
