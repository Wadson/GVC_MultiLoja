using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.Model
{
    public class ReciboModel
    {
        public long ReciboID { get; set; }
        public long ParcelaID { get; set; }
        public DateTime DataGeracao { get; set; }
        public string CaminhoArquivo { get; set; }
        public decimal ValorTotal { get; set; }
    }

}
