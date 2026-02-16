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
            DataVenda,
            PeriodoVenda,            
            PeriodoVencimento,
            StatusParcela
        }
    }
    public class FormaPagamentoItem
    {
        // 🔑 Banco
        public int FormaPgtoID { get; set; }
        public bool Ativo { get; set; } = true;

        // 🧠 Regra
       

        // 🎨 UI (compatível com código antigo)
        public string NomeFormaPagamento { get; set; }

        // 🔁 Alias para novos formulários
        public string Descricao
        {
            get => NomeFormaPagamento;
            set => NomeFormaPagamento = value;
        }

        public override string ToString()
        {
            return NomeFormaPagamento;
        }
        public EnumFormaPagamento FormaEnum
        {
            get
            {
                string nome = (NomeFormaPagamento ?? "").Trim().ToUpperInvariant();

                // remove acentos (rápido e seguro)
                nome = nome
                    .Replace("Á", "A").Replace("À", "A").Replace("Â", "A").Replace("Ã", "A")
                    .Replace("É", "E").Replace("Ê", "E")
                    .Replace("Í", "I")
                    .Replace("Ó", "O").Replace("Ô", "O").Replace("Õ", "O")
                    .Replace("Ú", "U")
                    .Replace("Ç", "C");

                if (nome.Contains("DINHEIRO")) return EnumFormaPagamento.Dinheiro;
                if (nome.Contains("PIX")) return EnumFormaPagamento.Pix;
                if (nome.Contains("TRANSFER")) return EnumFormaPagamento.Transferencia;
                if (nome.Contains("DEBITO")) return EnumFormaPagamento.CartaoDebito;
                if (nome.Contains("CREDITO")) return EnumFormaPagamento.CartaoCredito;
                if (nome.Contains("CREDIARIO")) return EnumFormaPagamento.Crediario;
                if (nome.Contains("CHEQUE")) return EnumFormaPagamento.Cheque;
                if (nome.Contains("BOLETO")) return EnumFormaPagamento.Boleto;

                throw new Exception("Forma de pagamento não mapeada: " + NomeFormaPagamento);
            }
        }

    }

}
