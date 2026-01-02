using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GVC.MODEL.Enums;

namespace GVC.MODEL.Extensions
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
                EnumStatusVenda.EmAnalise => "Em Análise",
                EnumStatusVenda.AguardandoPagamento => "Aguardando Pagamento",
                EnumStatusVenda.Concluida => "Concluída",
                EnumStatusVenda.Cancelada => "Cancelada",
                EnumStatusVenda.Devolvida => "Devolvida",
                EnumStatusVenda.Expirada => "Expirada",
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
                "Em Análise" => EnumStatusVenda.EmAnalise,
                "Aguardando Pagamento" => EnumStatusVenda.AguardandoPagamento,
                "Concluída" => EnumStatusVenda.Concluida,
                "Cancelada" => EnumStatusVenda.Cancelada,
                "Devolvida" => EnumStatusVenda.Devolvida,
                "Expirada" => EnumStatusVenda.Expirada,
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
                EnumStatusParcela.Aberta => "Aberta",
                EnumStatusParcela.Atrasada => "Atrasada",
                EnumStatusParcela.AguardandoPagamento => "Aguardando Pagamento",
                EnumStatusParcela.Pago => "Pago",
                EnumStatusParcela.Cancelada => "Cancelada",
                EnumStatusParcela.Devolvida => "Devolvida",
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
                "Aberta" => EnumStatusParcela.Aberta,
                "Atrasada" => EnumStatusParcela.Atrasada,
                "Aguardando Pagamento" => EnumStatusParcela.AguardandoPagamento,
                "Pago" => EnumStatusParcela.Pago,
                "Cancelada" => EnumStatusParcela.Cancelada,
                "Devolvida" => EnumStatusParcela.Devolvida,
                "Parcialmente Pago" => EnumStatusParcela.ParcialmentePago,
                _ => throw new Exception($"Status de parcela inválido: {status}")
            };
        }
    }


}
