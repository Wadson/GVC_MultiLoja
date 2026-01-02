using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.MODEL.Enums
{
    public enum EnumStatusParcela
    {
        Aberta,
        Atrasada,
        AguardandoPagamento,
        Pago,
        Cancelada,
        Devolvida,
        ParcialmentePago
    }

    public enum EnumStatusVenda
    {
        Aberta,
        EmAnalise,
        AguardandoPagamento,
        Concluida,
        Cancelada,
        Devolvida,
        Expirada,
        ParcialmentePago,
        Suspensa
    }


}
