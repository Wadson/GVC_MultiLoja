using GVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.FISCAL
{
    internal interface INfceService
    {
        void Emitir(VendaModel venda, List<ItemVendaModel> itens);
    }
}
