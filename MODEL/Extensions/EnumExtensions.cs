using System;
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
                EnumStatusVenda.Suspensa => "Suspensa",
                _ => throw new ArgumentOutOfRangeException(nameof(status))
            };
        }

        // =========================
        // DB → VENDA
        // =========================
        public static EnumStatusVenda ToEnumStatusVenda(this string status)
        {
            status = status?.Trim();

            return status switch
            {
                "Aberta" => EnumStatusVenda.Aberta,
                "Aguardando Pagamento" => EnumStatusVenda.AguardandoPagamento,              
                "Concluída" => EnumStatusVenda.Concluida,
                "Cancelada" => EnumStatusVenda.Cancelada,
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
                EnumStatusParcela.ParcialmentePago => "Parcialmente Pago",
                EnumStatusParcela.Pago => "Pago",
                EnumStatusParcela.Atrasada => "Atrasada",
                EnumStatusParcela.Cancelada => "Cancelada",
                _ => throw new ArgumentOutOfRangeException(nameof(status))
            };
        }

        // =========================
        // DB → PARCELA
        // =========================
        public static EnumStatusParcela ToEnumStatusParcela(this string status)
        {
            status = status?.Trim();

            return status switch
            {
                "Pendente" => EnumStatusParcela.Pendente,
                "Parcialmente Pago" => EnumStatusParcela.ParcialmentePago,
                "Pago" => EnumStatusParcela.Pago,
                "Atrasada" => EnumStatusParcela.Atrasada,
                "Cancelada" => EnumStatusParcela.Cancelada,
                _ => throw new Exception($"Status de parcela inválido: {status}")
            };
        }
    }
}
