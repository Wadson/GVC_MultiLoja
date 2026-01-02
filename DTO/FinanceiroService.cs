using GVC.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GVC.MODEL.Enums;
using GVC.MODEL.Extensions;


namespace GVC.DTO
{
    public class FinanceiroService
    {
        private readonly ParcelamentoService _parcelamentoService;

        public FinanceiroService()
        {
            _parcelamentoService = new ParcelamentoService();
        }

        // ================================
        // 1️⃣ GERAÇÃO DE PARCELAS
        // ================================
        public List<ParcelaModel> GerarParcelas(
            decimal valorTotal,
            int quantidadeParcelas,
            int intervaloDias,
            DateTime dataPrimeiroVencimento
        )
        {
            bool pagamentoAVista = quantidadeParcelas == 1;

            var request = new ParcelamentoRequest
            {
                ValorTotal = valorTotal,
                QuantidadeParcelas = quantidadeParcelas,
                IntervaloDias = intervaloDias,
                DataPrimeiroVencimento = dataPrimeiroVencimento,
                PagamentoAVista = pagamentoAVista
            };

            var result = _parcelamentoService.Gerar(request);
            return result.Parcelas;
        }

        // ================================
        // 2️⃣ STATUS DA VENDA
        // ================================
        public EnumStatusVenda DefinirStatusVenda(int quantidadeParcelas)
        {
            return quantidadeParcelas == 1
                ? EnumStatusVenda.Concluida
                : EnumStatusVenda.AguardandoPagamento;
        }

        // ================================
        // 3️⃣ STATUS DA PARCELA
        // ================================
        public string DefinirStatusParcela(bool pagamentoAVista)
        {
            return pagamentoAVista ? "Paga" : "Pendente";
        }

        // ================================
        // 4️⃣ SALDO DA PARCELA
        // ================================
        public decimal CalcularSaldoParcela(decimal valorParcela, decimal valorRecebido)
        {
            decimal saldo = valorParcela - valorRecebido;
            return saldo < 0 ? 0 : saldo;
        }

        // ================================
        // 5️⃣ APLICA REGRAS NA VENDA
        // ================================
        public void AplicarRegrasFinanceiras(
            VendaModel venda,
            List<ParcelaModel> parcelas
        )
        {
            if (parcelas == null || parcelas.Count == 0)
                throw new Exception("Venda sem parcelas.");

            venda.StatusVenda = DefinirStatusVenda(parcelas.Count);

            foreach (var p in parcelas)
            {
                p.Saldo = CalcularSaldoParcela(p.ValorParcela, p.ValorRecebido);
            }
        }

        // ================================
        // 1️⃣ APLICA REGRAS FINANCEIRAS
        // ================================
        public void ProcessarFinanceiroVenda(
     VendaModel venda,
     List<ParcelaModel> parcelas
 )
        {
            if (parcelas == null || !parcelas.Any())
                throw new Exception("Venda sem parcelas.");

            NormalizarParcelas(parcelas);
            ValidarTotalParcelas(venda.ValorTotal, parcelas);

            venda.StatusVenda = CalcularStatusVendaEnum(parcelas);
        }


        // ================================
        // 2️⃣ NORMALIZA PARCELAS
        // ================================
        private void NormalizarParcelas(List<ParcelaModel> parcelas)
        {
            foreach (var p in parcelas)
            {
                p.ValorParcela = Math.Max(0m, p.ValorParcela);
                p.ValorRecebido = Math.Max(0m, p.ValorRecebido);
                p.Juros = Math.Max(0m, p.Juros);
                p.Multa = Math.Max(0m, p.Multa);

                if (p.Status == EnumStatusParcela.Pago)
                {
                    if (p.DataPagamento == null)
                        p.DataPagamento = DateTime.Now;

                    p.ValorRecebido = p.ValorParcela + p.Juros + p.Multa;
                }

                p.Saldo = Math.Max(
                    0m,
                    (p.ValorParcela + p.Juros + p.Multa) - p.ValorRecebido
                );
            }
        }


        // ================================
        // 3️⃣ SALDO
        // ================================
        private decimal CalcularSaldo(decimal total, decimal recebido)
        {
            var saldo = total - recebido;
            return saldo < 0 ? 0 : saldo;
        }

        // ================================
        // 4️⃣ TOTAL DAS PARCELAS
        // ================================
        private void ValidarTotalParcelas(
            decimal valorVenda,
            List<ParcelaModel> parcelas
        )
        {
            decimal totalParcelas = parcelas.Sum(p =>
                p.ValorParcela + p.Juros + p.Multa
            );

            if (Math.Abs(totalParcelas - valorVenda) > 0.01m)
            {
                throw new Exception(
                    $"Total parcelas (R$ {totalParcelas:N2}) " +
                    $"não confere com valor da venda (R$ {valorVenda:N2})."
                );
            }
        }

        // ================================
        // 5️⃣ STATUS DA VENDA
        // ================================
        private EnumStatusVenda CalcularStatusVendaEnum(List<ParcelaModel> parcelas)
        {
            if (parcelas.All(p => p.Status == EnumStatusParcela.Pago))
                return EnumStatusVenda.Concluida;

            if (parcelas.Any(p => p.Status == EnumStatusParcela.Pago))
                return EnumStatusVenda.ParcialmentePago;

            return EnumStatusVenda.AguardandoPagamento;
        }

    }

}
