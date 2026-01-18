using Dapper;
using GVC.DAL;
using GVC.DTO;
using GVC.Model;
using GVC.Model.Enums.GVC.Model.Enums;
using GVC.Model.Extensions;
using GVC.UTIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

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
        public void GerarReciboAutomatico(long parcelaId)
        {
            // 🔹 1. Buscar extrato da parcela
            var extratoBLL = new ExtratoBLL();
            ExtratoCliente extrato = extratoBLL.ObterExtratoPorParcela(parcelaId);

            // 🔹 2. Buscar pagamentos da parcela
            var pagamentoBLL = new PagamentoBLL();
            var pagamentos = pagamentoBLL.ListarPagamentosPorParcela(parcelaId);

            if (pagamentos == null || pagamentos.Count == 0)
                return; // segurança

            // 🔹 3. Buscar dados da empresa
            var empresaBLL = new EmpresaBll();
            var empresa = empresaBLL.ObterDadosParaPdf();

            // 🔹 4. Definir pasta padrão
            string pasta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "GVC",
                "Recibos"
            );

            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            // 🔹 5. Nome do arquivo
            string caminhoPdf = Path.Combine(
                pasta,
                $"Recibo_Parcela_{parcelaId}_{DateTime.Now:yyyyMMddHHmmss}.pdf"
            );

            // 🔹 6. Gerar PDF
            PDFGenerator.GerarReciboPagamentos(
                extrato,
                pagamentos,
                empresa,
                caminhoPdf
            );

            // 🔹 7. Perguntar se deseja abrir
            if (Utilitario.Mensagens.Confirmacao(
                "Recibo gerado automaticamente.\nDeseja abrir agora?"))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = caminhoPdf,
                    UseShellExecute = true
                });
            }
        }

        // ==========================================================
        // 1. BAIXA TOTAL DE UMA PARCELA (força pagamento completo)
        // ==========================================================
        public void BaixarParcelaTotal(long parcelaId)
        {
            var parcela = _parcelaDal.BuscarPorId(parcelaId) ?? throw new Exception("Parcela não encontrada.");

            // Calcular o saldo restante em decimal
            decimal? totalDevido = parcela.ValorParcela + parcela.Juros + parcela.Multa;
            decimal? valorRecebido = parcela.ValorRecebido;
            decimal? saldoRestante = totalDevido - valorRecebido;

            if (saldoRestante <= 0)
                return; // Já está quitada

            // Arredondar para evitar problemas de precisão
            saldoRestante = Math.Round(saldoRestante ?? 0m, 2, MidpointRounding.AwayFromZero);

            // Inserir pagamento do saldo restante
            _parcelaDal.BaixarParcela(parcelaId, (decimal)saldoRestante, DateTime.Now);

            // 🧾 RECIBO AUTOMÁTICO
            GerarReciboAutomatico(parcelaId);

        }

        // ==========================================================
        // 2. BAIXA PARCIAL DE UMA PARCELA (valor informado pelo usuário)
        // ==========================================================
        public void BaixarParcelaParcial(
      long parcelaId,
      decimal valorPago,
      int? formaPgtoId,
      string? comprovante = null,
      string? observacao = null)
        {
            if (valorPago <= 0)
                throw new Exception("O valor pago deve ser maior que zero.");

            var parcela = _parcelaDal.BuscarPorId(parcelaId)
                ?? throw new Exception("Parcela não encontrada.");

            decimal? totalDevido = parcela.ValorParcela + parcela.Juros + parcela.Multa;
            decimal? saldoAtual = totalDevido - parcela.ValorRecebido;

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
            // 🧾 RECIBO AUTOMÁTICO
               GerarReciboAutomatico(parcelaId);

            // 🔥 Trigger cuida de:
            // - ValorRecebido
            // - Status
            // - DataPagamento

        }


        // ==========================================================
        // 3. BAIXA EM LOTE (várias parcelas selecionadas no grid)
        // ==========================================================

        public void BaixarParcelasEmLote( List<long> parcelasIds,DateTime dataPagamento, long formaPgtoId,
     string? observacao = null)
        {
            if (parcelasIds == null || parcelasIds.Count == 0)
                throw new Exception("Nenhuma parcela selecionada.");

            string obsFinal = string.IsNullOrWhiteSpace(observacao)
                ? "Baixa total em lote"  : $"Baixa total em lote – {observacao.Trim()}";

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
    (ValorParcela
        + ISNULL(Juros, 0)
        + ISNULL(Multa, 0)
        - ISNULL(ValorRecebido, 0)),
    @Observacao
FROM Parcela
WHERE ParcelaID = @ParcelaID";


                const string sqlBaixa = @"
                    UPDATE Parcela
                    SET ValorRecebido =
                            ValorParcela
                            + ISNULL(Juros, 0)
                            + ISNULL(Multa, 0),
                        DataPagamento = @DataPagamento
                    WHERE ParcelaID = @ParcelaID";


                foreach (var parcelaId in parcelasIds)
                {
                    // 1️⃣ INSERE O HISTÓRICO (usa saldo ANTES da baixa)
                    conn.Execute(sqlHistorico, new
                    {
                        ParcelaID = parcelaId,
                        DataPagamento = dataPagamento,
                        FormaPgtoID = formaPgtoId,
                        Observacao = obsFinal
                    }, transaction);

                    // 2️⃣ ATUALIZA A PARCELA
                    conn.Execute(sqlBaixa, new
                    {
                        ParcelaID = parcelaId,
                        DataPagamento = dataPagamento
                    }, transaction);
                }


                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
            // 🔥 GERAR RECIBOS (fora da transação)
            foreach (var parcelaId in parcelasIds)
            {
                GerarReciboAutomatico(parcelaId);
            }
        }

        // ==========================================================
        // ALTERAR STATUS MANUALMENTE
        // ==========================================================
        public void AlterarStatus(long parcelaId, EnumStatusParcela novoStatus)
        {
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
       //"EnumStatusVenda" não contém uma definição para "ParcialmentePago"

        public void EstornarPagamentosEmLote(List<int> parcelasIds, decimal valorEstorno, string motivo)
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

                decimal? estornoNestaParcela = Math.Min((decimal)parcela.ValorRecebido, valorRestante);

                if (estornoNestaParcela <= 0)
                    continue;

                _parcelaDal.EstornarPagamento((long)parcelaId,
                    (decimal)estornoNestaParcela,
                    DateTime.Now,
                    motivo
                );

                valorRestante -= (decimal)estornoNestaParcela;
            }

            // 🔁 Recalcula status da venda UMA VEZ
            int vendaId = _parcelaDal.BuscarPorId(parcelasIds.First()).VendaID;
            var parcelasVenda = _parcelaDal.GetParcelas((long)vendaId);

            string statusVenda = _vendaBLL.CalcularStatusVendaPorParcelas(parcelasVenda);

            // 🔒 CHECK constraint do SQLite

            EnumStatusVenda statusVendaEnum = (EnumStatusVenda)Enum.Parse(typeof(EnumStatusVenda), statusVenda);

            if (statusVendaEnum == EnumStatusVenda.Aberta)
                statusVendaEnum =  EnumStatusVenda.AguardandoPagamento;

            _vendaDal.AtualizarStatusVenda(vendaId, statusVendaEnum);

        }
        public void EstornarPagamento(long parcelaId, decimal valorEstorno, string motivo)
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


            EnumStatusVenda statusVendaEnum = (EnumStatusVenda)Enum.Parse(typeof(EnumStatusVenda), statusVenda);

            if (statusVenda == EnumStatusVenda.Aberta.ToDb() && parcelasVenda.All(p => p.ValorRecebido == 0))
            {
                statusVenda = EnumStatusVenda.AguardandoPagamento.ToDb();
            }

            _vendaDal.AtualizarStatusVenda(parcela.VendaID, statusVendaEnum);
        }
        public ParcelaDetalheDTO ObterDetalheParcela(long parcelaId)
        {
            using var conn = Conexao.Conex();

            const string sql = @"
                       SELECT
                    p.ParcelaID,
                    p.VendaID,
                    p.NumeroParcela,
                    c.Nome AS NomeCliente,
                    v.DataVenda,
                    p.DataVencimento,
                    p.ValorParcela,
                    ISNULL(p.ValorRecebido, 0) AS ValorRecebido,
                    (ISNULL(p.ValorParcela,0)
                     + ISNULL(p.Juros,0)
                     + ISNULL(p.Multa,0)
                     - ISNULL(p.ValorRecebido,0)) AS Saldo,
                    p.Status AS Status        -- 🔥 ESTA LINHA ESTAVA FALTANDO
                FROM Parcela p
                INNER JOIN Venda v ON v.VendaID = p.VendaID
                INNER JOIN Clientes c ON c.ClienteID = v.ClienteID
                WHERE p.ParcelaID = @ParcelaID";

            return conn.QueryFirstOrDefault<ParcelaDetalheDTO>(
                sql,
                new { parcelaId }
            );
        }

    }
}
