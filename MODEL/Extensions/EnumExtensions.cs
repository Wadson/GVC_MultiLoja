using GVC.Model.Enums;
using GVC.Model.Enums.GVC.Model.Enums;
using System;

namespace GVC.Model.Extensions
{
    public static class StatusExtensions
    {
        // =========================
        // VENDA → DB
        // =========================
        public static string ToDb(this EnumStatusVenda status)
        {
            return status.ToString();
        }

        // =========================
        // DB → VENDA
        // =========================
        public static EnumStatusVenda ToEnumStatusVenda(this string status)
        {
            if (Enum.TryParse<EnumStatusVenda>(status?.Trim(), out var result))
                return result;

            throw new Exception($"Status de venda inválido: {status}");
        }

        // =========================
        // PARCELA → DB
        // =========================
        public static string ToDb(this EnumStatusParcela status)
        {
            return status.ToString();
        }

        // =========================
        // DB → PARCELA
        // =========================
        public static EnumStatusParcela ToEnumStatusParcela(this string status)
        {
            if (Enum.TryParse<EnumStatusParcela>(status?.Trim(), out var result))
                return result;

            throw new Exception($"Status de parcela inválido: {status}");
        }
    }
}
