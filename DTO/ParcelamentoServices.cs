using GVC.Model;
using GVC.Model.Enums;
using GVC.Model.Enums.GVC.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.DTO
{
    public class ParcelamentoService
    {
        //public ParcelamentoResult Gerar(ParcelamentoRequest request)
        //{
        //    Validar(request);

        //    var parcelas = new List<ParcelaModel>();

        //    decimal valorBase = Math.Round(
        //        request.ValorTotal / request.QuantidadeParcelas, 2);

        //    decimal diferenca = request.ValorTotal -
        //                       (valorBase * request.QuantidadeParcelas);

        //    for (int i = 1; i <= request.QuantidadeParcelas; i++)
        //    {
        //        decimal valor = valorBase;

        //        if (i == request.QuantidadeParcelas)
        //            valor += diferenca;

        //        parcelas.Add(new ParcelaModel
        //        {
        //            NumeroParcela = i,
        //            DataVencimento = request.DataPrimeiroVencimento
        //                .AddDays(request.IntervaloDias * (i - 1)),
        //            ValorParcela = valor,
        //            ValorRecebido = request.PagamentoAVista ? valor : 0m,
        //            Saldo = request.PagamentoAVista ? 0m : valor,
        //            Status = request.PagamentoAVista ? EnumStatusParcela.Pago : EnumStatusParcela.Pendente
        //        });
        //    }

        //    return new ParcelamentoResult
        //    {
        //        Parcelas = parcelas
        //    };
        //}
        public ParcelamentoResult Gerar(ParcelamentoRequest request)
        {
            Validar(request);

            var parcelas = new List<ParcelaModel>();

            int quantidade = request.QuantidadeParcelas;
            decimal valorTotal = request.ValorTotal;

            // Converte para inteiro (remove centavos)
            int valorTotalInteiro = (int)Math.Floor(valorTotal);

            // Calcula o valor base inteiro
            int valorBase = valorTotalInteiro / quantidade;

            // Calcula o resto que vai para a última parcela
            int resto = valorTotalInteiro % quantidade;

            // Ajusta: as primeiras 'resto' parcelas recebem 1 a mais
            for (int i = 1; i <= quantidade; i++)
            {
                decimal valor;

                if (i <= resto)
                {
                    valor = valorBase + 1;
                }
                else
                {
                    valor = valorBase;
                }

                parcelas.Add(new ParcelaModel
                {
                    NumeroParcela = i,
                    DataVencimento = request.DataPrimeiroVencimento
                        .AddDays(request.IntervaloDias * (i - 1)),
                    ValorParcela = valor,
                    ValorRecebido = request.PagamentoAVista ? valor : 0m,
                    Saldo = request.PagamentoAVista ? 0m : valor,
                    Status = request.PagamentoAVista ? EnumStatusParcela.Pago : EnumStatusParcela.Pendente
                });
            }

            return new ParcelamentoResult
            {
                Parcelas = parcelas
            };
        }
        private void Validar(ParcelamentoRequest request)
        {
            if (request.ValorTotal <= 0)
                throw new Exception("Valor total inválido.");

            if (request.QuantidadeParcelas <= 0)
                throw new Exception("Quantidade de parcelas inválida.");

            if (request.IntervaloDias < 0)
                throw new Exception("Intervalo inválido.");

            if (request.DataPrimeiroVencimento == DateTime.MinValue)
                throw new Exception("Data do primeiro vencimento inválida.");
        }
    }

}
