using Dapper;
using GVC.DALL;
using GVC.MODEL;
using GVC.UTIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GVC.View.FrmVendas;

namespace GVC.BLL
{
    internal class ParcelaBLL
    {
        private readonly ParcelaDal _parcelaDal;
        private readonly VendaDal _vendaDal = new VendaDal();
        private readonly VendaBLL _vendaBLL;
        private readonly PagamentoParcialDal _pagamentoParcialDal = new PagamentoParcialDal();
        public ParcelaBLL()
        {
            _parcelaDal = new ParcelaDal();
            _vendaDal = new VendaDal();
            _vendaBLL = new VendaBLL();
        }

        // ==========================================================
        // 1. BAIXA TOTAL DE UMA PARCELA (força pagamento completo)
        // ==========================================================
        public void BaixarParcelaTotal(long parcelaId)
        {
            var parcela = _parcelaDal.BuscarPorId(parcelaId)
                ?? throw new Exception("Parcela não encontrada.");

            // Calcular o saldo restante em decimal
            decimal totalDevido = (parcela.ValorParcela + parcela.Juros + parcela.Multa);
            decimal valorRecebido = parcela.ValorRecebido;
            decimal saldoRestante = totalDevido - valorRecebido;

            if (saldoRestante <= 0)
                return; // Já está quitada

            // Arredondar para evitar problemas de precisão
            saldoRestante = Math.Round(saldoRestante, 2, MidpointRounding.AwayFromZero);

            // Inserir pagamento do saldo restante
            _parcelaDal.BaixarParcela(parcelaId, saldoRestante, DateTime.Now);
        }

        // ==========================================================
        // 2. BAIXA PARCIAL DE UMA PARCELA (valor informado pelo usuário)
        // ==========================================================
        public void BaixarParcelaParcial(
      int parcelaId,
      decimal valorPago,
      int? formaPgtoId,
      string? comprovante = null,
      string? observacao = null)
        {
            if (valorPago <= 0)
                throw new Exception("O valor pago deve ser maior que zero.");

            var parcela = _parcelaDal.BuscarPorId(parcelaId)
                ?? throw new Exception("Parcela não encontrada.");

            decimal totalDevido = parcela.ValorParcela + parcela.Juros + parcela.Multa;
            decimal saldoAtual = totalDevido - parcela.ValorRecebido;

            valorPago = Math.Round(valorPago, 2, MidpointRounding.AwayFromZero);

            if (valorPago > saldoAtual)
                throw new Exception("Valor pago maior que o saldo devido.");

            // 🧠 OBSERVAÇÃO PADRÃO
            string obsFinal = string.IsNullOrWhiteSpace(observacao)
                ? "Baixa parcial"
                : $"Baixa parcial – {observacao.Trim()}";

            _pagamentoParcialDal.RegistrarPagamentoParcial(
                parcelaId,
                valorPago,
                DateTime.Now,
                formaPgtoId,
                obsFinal
            );

            // 🔥 Trigger cuida de:
            // - ValorRecebido
            // - Status
            // - DataPagamento
        }


        // ==========================================================
        // 3. BAIXA EM LOTE (várias parcelas selecionadas no grid)
        // ==========================================================

        public void BaixarParcelasEmLote(
     List<long> parcelasIds,
     DateTime dataPagamento,
     long formaPgtoId,
     string? observacao = null)
        {
            if (parcelasIds == null || parcelasIds.Count == 0)
                throw new Exception("Nenhuma parcela selecionada.");

            string obsFinal = string.IsNullOrWhiteSpace(observacao)
                ? "Baixa total em lote"
                : $"Baixa total em lote – {observacao.Trim()}";

            using var conn = Conexao.Conex();
            conn.Open();
            using var transaction = conn.BeginTransaction();

            try
            {
                const string sqlHistorico = @"
INSERT INTO PagamentosParciais
    (ParcelaID, DataPagamento, FormaPgtoID, ValorPago, Observacao)
SELECT
    ParcelaID,
    @DataPagamento,
    @FormaPgtoID,
    (ValorParcela + Juros + Multa - ValorRecebido),
    @Observacao
FROM Parcela
WHERE ParcelaID = @ParcelaID";

                const string sqlBaixa = @"
UPDATE Parcela
SET ValorRecebido = ValorParcela + Juros + Multa,
    DataPagamento = @DataPagamento
WHERE ParcelaID = @ParcelaID";

                foreach (var parcelaId in parcelasIds)
                {
                    conn.Execute(sqlBaixa, new
                    {
                        ParcelaID = parcelaId,
                        DataPagamento = dataPagamento
                    }, transaction);

                    conn.Execute(sqlHistorico, new
                    {
                        ParcelaID = parcelaId,
                        DataPagamento = dataPagamento,
                        FormaPgtoID = formaPgtoId,
                        Observacao = obsFinal
                    }, transaction);
                }

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        // ==========================================================
        // ALTERAR STATUS MANUALMENTE
        // ==========================================================
        public void AlterarStatus(int parcelaId, string novoStatus)
        {
            if (string.IsNullOrWhiteSpace(novoStatus))
                throw new Exception("Status inválido.");

            ParcelaModel parcela = _parcelaDal.BuscarPorId(parcelaId)
                ?? throw new Exception("Parcela não encontrada.");

            parcela.Status = novoStatus;
            _parcelaDal.UpdateParcela(parcela);
        }

        // ==========================================================
        // EXCLUSÃO
        // ==========================================================
        public void Excluir(ParcelaModel parcela)
        {
            if (parcela == null)
                throw new Exception("Parcela inválida.");

            _parcelaDal.Excluir(parcela);
        }

        /// <summary>
        /// Estorna um pagamento (parcial ou total) de uma parcela
        /// </summary>
        /// <param name="parcelaId">ID da parcela</param>
        /// <param name="valorEstorno">Valor a estornar (positivo)</param>
        /// <param name="motivo">Motivo do estorno (para auditoria)</param>
        public void EstornarPagamento(int parcelaId, decimal valorEstorno, string motivo)
        {
            if (valorEstorno <= 0)
                throw new Exception("Valor de estorno inválido.");

            var parcela = _parcelaDal.BuscarPorId(parcelaId)
                ?? throw new Exception("Parcela não encontrada.");

            if (valorEstorno > parcela.ValorRecebido)
                throw new Exception("Valor do estorno maior que o valor recebido.");

            _parcelaDal.EstornarPagamento(parcelaId, valorEstorno, DateTime.Now, motivo);

            // Recalcula status da venda
            var parcelasVenda = _parcelaDal.GetParcelas(parcela.VendaID);
            var statusVenda = _vendaBLL.CalcularStatusVendaPorParcelas(parcelasVenda);

            if (statusVenda == EnumStatusVenda.ParcialmentePago.ToDb() &&
                parcelasVenda.All(p => p.ValorRecebido == 0))
            {
                statusVenda = EnumStatusVenda.AguardandoPagamento.ToDb();
            }

            _vendaDal.AtualizarStatusVenda(parcela.VendaID, statusVenda);
        }


        public void EstornarPagamentosEmLote(
     List<long> parcelasIds,
     decimal valorEstorno,
     string motivo)
        {
            if (valorEstorno <= 0)
                throw new Exception("Valor de estorno inválido.");

            decimal valorRestante = valorEstorno;

            foreach (var parcelaId in parcelasIds)
            {
                if (valorRestante <= 0)
                    break;

                var parcela = _parcelaDal.BuscarPorId(parcelaId)
                    ?? throw new Exception("Parcela não encontrada.");

                decimal estornoNestaParcela =
                    Math.Min(parcela.ValorRecebido, valorRestante);

                if (estornoNestaParcela <= 0)
                    continue;

                _parcelaDal.EstornarPagamento(
                    (int)parcelaId,
                    estornoNestaParcela,
                    DateTime.Now,
                    motivo
                );

                valorRestante -= estornoNestaParcela;
            }

            // 🔁 Recalcula status da venda UMA VEZ
            long vendaId = _parcelaDal.BuscarPorId(parcelasIds.First()).VendaID;
            var parcelasVenda = _parcelaDal.GetParcelas((int)vendaId);

            string statusVenda =
                _vendaBLL.CalcularStatusVendaPorParcelas(parcelasVenda);

            // 🔒 CHECK constraint do SQLite
            if (statusVenda == EnumStatusVenda.ParcialmentePago.ToDb())
                statusVenda = EnumStatusVenda.AguardandoPagamento.ToDb();

            _vendaDal.AtualizarStatusVenda(vendaId, statusVenda);
        }
    }
}
