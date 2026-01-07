using GVC.Model.Enums.GVC.Model.Enums;
using GVC.Model.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace GVC.MODEL.Extensions
{
    public static class ParcelaContabilHelper
    {
        public static bool EntraEmAberto(string statusDb)
        {
            var status = statusDb.ToEnumStatusParcela();

            return status == EnumStatusParcela.Pendente
                || status == EnumStatusParcela.ParcialmentePago
                || status == EnumStatusParcela.Atrasada;
        }

        public static bool EntraComoRecebido(string statusDb)
        {
            var status = statusDb.ToEnumStatusParcela();

            return status == EnumStatusParcela.Pago;
        }
    }
}
