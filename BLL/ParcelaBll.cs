using Dapper;
using GVC.DAL;
using GVC.DTO;
using GVC.Infra.Conexao;
using GVC.Infra.Repository;
using GVC.Model;
using GVC.Model.Enums;
using GVC.Model.Enums.GVC.Model.Enums;
using GVC.Model.Extensions;
using GVC.UTIL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GVC.BLL
{
    internal class ParcelaBLL
    {
        private readonly ParcelaRepository _parcelaRepository;
        private readonly VendaRepository _vendaRepository;
        private readonly VendaBLL _vendaBLL;
        private readonly PagamentoParcialDal _pagamentoParcialDal;

        public ParcelaBLL()
        {
            _parcelaRepository = new ParcelaRepository();
            _vendaRepository = new VendaRepository();
            _vendaBLL = new VendaBLL();
            _pagamentoParcialDal = new PagamentoParcialDal();
        }
        public int AtualizarParcelasAtrasadas()
        {
            using var repo = new ParcelaRepository();
            return repo.AtualizarParcelasAtrasadas();
        }
        public ClienteModel BuscarClienteVenda(int clienteId)
        {
            using var repo = new ClienteRepository();
            return repo.BuscarPorId(clienteId);
        }

        // ==========================================================
        // BAIXA TOTAL
        // ==========================================================
        public void BaixarParcelaTotal(long parcelaId)
        {
            var parcela = _parcelaRepository.BuscarPorId(parcelaId)
                ?? throw new Exception("Parcela não encontrada.");

            decimal totalDevido =
                parcela.ValorParcela
                + (parcela.Juros ?? 0m)
                + (parcela.Multa ?? 0m);

            decimal recebido = parcela.ValorRecebido ?? 0m;
            decimal saldo = totalDevido - recebido;

            if (saldo <= 0)
                return;

            saldo = Math.Round(saldo, 2, MidpointRounding.AwayFromZero);

            _parcelaRepository.BaixarParcela(parcelaId, saldo, DateTime.Now);

            GerarReciboAutomatico(parcelaId);
        }

        // ==========================================================
        // BAIXA PARCIAL
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

            var parcela = _parcelaRepository.BuscarPorId(parcelaId)
                ?? throw new Exception("Parcela não encontrada.");

            decimal totalDevido =
                parcela.ValorParcela
                + (parcela.Juros ?? 0m)
                + (parcela.Multa ?? 0m);

            decimal saldoAtual = totalDevido - (parcela.ValorRecebido ?? 0m);

            valorPago = Math.Round(valorPago, 2, MidpointRounding.AwayFromZero);

            if (valorPago > saldoAtual)
                throw new Exception("Valor pago maior que o saldo devido.");

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

            GerarReciboAutomatico(parcelaId);
        }

        // ==========================================================
        // ALTERAR STATUS
        // ==========================================================
        public void AlterarStatus(long parcelaId, EnumStatusParcela novoStatus)
        {
            var parcela = _parcelaRepository.BuscarPorId(parcelaId)
                ?? throw new Exception("Parcela não encontrada.");

            parcela.Status = novoStatus;
            _parcelaRepository.UpdateParcela(parcela);
        }

        // ==========================================================
        // EXCLUSÃO
        // ==========================================================
        public void Excluir(ParcelaModel parcela)
        {
            if (parcela == null)
                throw new Exception("Parcela inválida.");

            _parcelaRepository.Excluir(parcela);
        }

        // ==========================================================
        // ESTORNO INDIVIDUAL
        // ==========================================================
        public void EstornarPagamento(long parcelaId, decimal valorEstorno, string motivo)
        {
            if (valorEstorno <= 0)
                throw new Exception("Valor de estorno inválido.");

            var parcela = _parcelaRepository.BuscarPorId(parcelaId)
                ?? throw new Exception("Parcela não encontrada.");

            if (valorEstorno > (parcela.ValorRecebido ?? 0m))
                throw new Exception("Valor do estorno maior que o valor recebido.");

            _parcelaRepository.EstornarPagamento(
                parcelaId,
                valorEstorno,
                DateTime.Now,
                motivo
            );

            var parcelasVenda = _parcelaRepository.GetParcelas(parcela.VendaID);
            var statusVenda = _vendaBLL.CalcularStatusVendaPorParcelas(parcelasVenda);

            var statusEnum =
                (EnumStatusVenda)Enum.Parse(typeof(EnumStatusVenda), statusVenda);

            if (statusEnum == EnumStatusVenda.Aberta &&
                parcelasVenda.All(p => (p.ValorRecebido ?? 0m) == 0m))
            {
                statusEnum = EnumStatusVenda.AguardandoPagamento;
            }

            _vendaRepository.AtualizarStatusVenda(parcela.VendaID, statusEnum);
        }

        // ==========================================================
        // DETALHE PARCELA (continua com Dapper)
        // ==========================================================
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
                    p.Status
                FROM Parcela p
                INNER JOIN Venda v ON v.VendaID = p.VendaID
                INNER JOIN Clientes c ON c.ClienteID = v.ClienteID
                WHERE p.ParcelaID = @ParcelaID";

            return conn.QueryFirstOrDefault<ParcelaDetalheDTO>(
                sql,
                new { ParcelaID = parcelaId }
            );
        }

        // ==========================================================
        // RECIBO
        // ==========================================================
        public void GerarReciboAutomatico(long parcelaId)
        {
            var extratoBLL = new ExtratoBLL();
            var extrato = extratoBLL.ObterExtratoPorParcela(parcelaId);

            var pagamentoBLL = new PagamentoBLL();
            var pagamentos = pagamentoBLL.ListarPagamentosPorParcela(parcelaId);

            if (pagamentos == null || pagamentos.Count == 0)
                return;

            var empresaBLL = new EmpresaBll();
            var empresa = empresaBLL.ObterDadosParaPdf();

            string pasta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "GVC",
                "Recibos");

            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            string caminhoPdf = Path.Combine(
                pasta,
                $"Recibo_Parcela_{parcelaId}_{DateTime.Now:yyyyMMddHHmmss}.pdf");

            PDFGenerator.GerarReciboPagamentos(
                extrato,
                pagamentos,
                empresa,
                caminhoPdf);

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
        public void BaixarParcelasEmLote(
           List<long> parcelasIds,
           DateTime dataPagamento,
           long formaPgtoId,
           string? observacao = null)
        {
            if (parcelasIds == null || parcelasIds.Count == 0)
                throw new Exception("Nenhuma parcela selecionada.");

            _parcelaRepository.BaixarParcelasEmLote(
                parcelasIds,
                dataPagamento,
                formaPgtoId,
                observacao
            );

            // 🔥 Recibos fora da transação
            foreach (var parcelaId in parcelasIds)
            {
                GerarReciboAutomatico(parcelaId);
            }
        }       
    }
}
