using GVC.Model;
using GVC.Model.Enums.GVC.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GVC.Service
{
    public class FinanceiroService
    {
        public void DefinirStatusVenda(
            VendaModel venda,
            List<ParcelaModel>? parcelas)
        {
            if (parcelas == null || parcelas.Count == 0)
            {
                venda.StatusVenda = EnumStatusVenda.Concluida;
                return;
            }

            bool todasQuitadas = parcelas.All(p =>
                p.ValorRecebido.HasValue &&
                p.ValorRecebido.Value >= p.ValorParcela);

            venda.StatusVenda = todasQuitadas
                ? EnumStatusVenda.Concluida
                : EnumStatusVenda.AguardandoPagamento;
        }
    }

}
