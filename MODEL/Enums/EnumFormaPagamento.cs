using System;

namespace GVC.Model.Enums
{
    public enum EnumFormaPagamento
    {
        Dinheiro,
        CartaoCredito,
        CartaoDebito,
        Pix,
        Boleto,
        Transferencia,
        Cheque,
        Crediario
    }

    public static class FormaPagamentoExtensions
    {
        // =========================
        // FORMA PAGAMENTO → DB
        // =========================
        public static string ToDb(this EnumFormaPagamento forma)
        {
            return forma switch
            {
                EnumFormaPagamento.Dinheiro => "Dinheiro",
                EnumFormaPagamento.CartaoCredito => "Cartão de Crédito",
                EnumFormaPagamento.CartaoDebito => "Cartão de Débito",
                EnumFormaPagamento.Pix => "PIX",
                EnumFormaPagamento.Boleto => "Boleto",
                EnumFormaPagamento.Transferencia => "Transferência",
                EnumFormaPagamento.Cheque => "Cheque",
                EnumFormaPagamento.Crediario => "Crediário",
                _ => throw new ArgumentOutOfRangeException(nameof(forma))
            };
        }

        // =========================
        // DB → FORMA PAGAMENTO
        // =========================
        public static EnumFormaPagamento ToEnumFormaPagamento(this string forma)
        {
            forma = forma?.Trim();

            return forma switch
            {
                "Dinheiro" => EnumFormaPagamento.Dinheiro,
                "Cartão de Crédito" => EnumFormaPagamento.CartaoCredito,
                "Cartão de Débito" => EnumFormaPagamento.CartaoDebito,
                "PIX" => EnumFormaPagamento.Pix,
                "Boleto" => EnumFormaPagamento.Boleto,
                "Transferência" => EnumFormaPagamento.Transferencia,
                "Cheque" => EnumFormaPagamento.Cheque,
                "Crediário" => EnumFormaPagamento.Crediario,
                _ => throw new Exception($"Forma de pagamento inválida: {forma}")
            };
        }


        public enum TipoPesquisaContasReceber
        {
            Todos,
            NomeCliente,
            NumeroVenda,
            DataVenda,
            PeriodoVenda,
            Vencimento,
            PeriodoVencimento,
            StatusParcela
        }
    }
}
