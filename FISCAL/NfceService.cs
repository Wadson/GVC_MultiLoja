using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GVC.FISCAL;
using GVC.Model;

namespace GVC.FISCAL
{
    internal class NfceService : INfceService
    {
        public void Emitir(VendaModel venda, List<ItemVendaModel> itens)
        {
            // FUTURO:
            // 1. Gerar XML
            // 2. Assinar
            // 3. Enviar SEFAZ
            // 4. Salvar retorno
            // 5. Imprimir DANFE

            throw new NotImplementedException("NFC-e ainda não configurada.");
        }
    }
}
