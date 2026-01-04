using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GVC.Model.Enums;

namespace GVC.Model.Extensions
{
    public static class StatusExtensions
    {
        // =========================
        // VENDA → DB
        // =========================
        public static string ToDb(this EnumStatusVenda status)
        {
            return status switch
            {
                EnumStatusVenda.Aberta => "Aberta",              
                EnumStatusVenda.AguardandoPagamento => "Aguardando Pagamento",
                EnumStatusVenda.Concluida => "Concluída",
                EnumStatusVenda.Cancelada => "Cancelada", 
                EnumStatusVenda.ParcialmentePago => "Parcialmente Pago",
                EnumStatusVenda.Suspensa => "Suspensa",
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        // =========================
        // DB → VENDA
        // =========================
        public static EnumStatusVenda ToEnumStatusVenda(this string status)
        {
            return status switch
            {
                "Aberta" => EnumStatusVenda.Aberta,               
                "Aguardando Pagamento" => EnumStatusVenda.AguardandoPagamento,
                "Concluída" => EnumStatusVenda.Concluida,
                "Cancelada" => EnumStatusVenda.Cancelada,              
                "Parcialmente Pago" => EnumStatusVenda.ParcialmentePago,
                "Suspensa" => EnumStatusVenda.Suspensa,
                _ => throw new Exception($"Status de venda inválido: {status}")
            };
        }

        // =========================
        // PARCELA → DB
        // =========================
        public static string ToDb(this EnumStatusParcela status)
        {
            return status switch
            {
                EnumStatusParcela.Pendente => "Pendente",
                EnumStatusParcela.Atrasada => "Atrasada",                
                EnumStatusParcela.Pago => "Pago",
                EnumStatusParcela.Cancelada => "Cancelada",              
                EnumStatusParcela.ParcialmentePago => "Parcialmente Pago",
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        // =========================
        // DB → PARCELA
        // =========================
        public static EnumStatusParcela ToEnumStatusParcela(this string status)
        {
            return status switch
            {
                "Aberta" => EnumStatusParcela.Pendente,
                "Atrasada" => EnumStatusParcela.Atrasada,               
                "Pago" => EnumStatusParcela.Pago,
                "Cancelada" => EnumStatusParcela.Cancelada,              
                "Parcialmente Pago" => EnumStatusParcela.ParcialmentePago,
                _ => throw new Exception($"Status de parcela inválido: {status}")
            };
        }
    }


}
