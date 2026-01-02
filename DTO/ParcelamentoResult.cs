using GVC.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.DTO
{
    public class ParcelamentoResult
    {
        public List<ParcelaModel> Parcelas { get; set; } = new();
    }

}
