using Dapper;
using GVC.DAL;
using GVC.DTO;
using GVC.Infra.Conexao;
using GVC.Infra.Repository;
using GVC.Model;
using GVC.Model.Enums;
using GVC.Model.Extensions;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace GVC.BLL
{
    internal class ParcelaBLL
    {
        private readonly ParcelaRepository _parcelaRepository;
        private readonly VendaRepository _vendaRepository;
        private readonly VendaBLL _vendaBLL;
        private readonly PagamentoParcialDal _pagamentoParcialDal;

        // ✅ CONSTRUTOR PADRÃO (não quebra forms existentes)
        public ParcelaBLL()
        {
            _parcelaRepository = new ParcelaRepository();
            _vendaRepository = new VendaRepository();
            _vendaBLL = new VendaBLL();
            _pagamentoParcialDal = new PagamentoParcialDal();
        }

        // ✅ CONSTRUTOR PARA TRANSAÇÃO ÚNICA
        public ParcelaBLL(SqlConnection conn)
        {
            _parcelaRepository = new ParcelaRepository(conn);
            _vendaRepository = new VendaRepository(conn);
            _vendaBLL = new VendaBLL(conn);
            _pagamentoParcialDal = new PagamentoParcialDal();
        }
        //Criado para calcular o status da parcela sem precisar usar Trigger no banco, o que causava lentidão 13/02/2026
        public string CalcularStatusParcela(ParcelaModel p)
        {
            if (p.Status == EnumStatusParcela.Cancelada)
                return "Cancelada";


            var total = p.ValorParcela + (p.Juros ?? 0) + (p.Multa ?? 0);

            if (p.ValorRecebido >= total - 0.01m)
                return "Pago";

            if (p.ValorRecebido > 0)
                return "ParcialmentePago";

            if (p.DataVencimento < DateTime.Today)
                return "Atrasada";

            return "Pendente";
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
            var parcela = _parcelaRepository.BuscarParcelaPorId(parcelaId)
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

            var parcela = _parcelaRepository.BuscarParcelaPorId(parcelaId)
                ?? throw new Exception("Parcela não encontrada.");

            if (parcela.Status == EnumStatusParcela.Cancelada)
                throw new Exception("Parcela cancelada não pode receber pagamento.");

            decimal totalDevido =
                parcela.ValorParcela
                + (parcela.Juros ?? 0m)
                + (parcela.Multa ?? 0m);

            decimal recebidoAtual = parcela.ValorRecebido ?? 0m;
            decimal saldoAtual = totalDevido - recebidoAtual;

            valorPago = Math.Round(valorPago, 2, MidpointRounding.AwayFromZero);

            if (valorPago > saldoAtual)
                throw new Exception("Valor pago maior que o saldo devido.");

            // 1) Atualiza o OBJETO em memória (status / data pagamento / valor recebido)
            var financeiroService = new FinanceiroService();
            financeiroService.RegistrarPagamento(parcela, valorPago, "Manual");

            // 2) TUDO EM UMA TRANSAÇÃO ÚNICA (Pagamento + Parcela + Venda)
            using var conn = Conexao.Conex();
            conn.Open();
            using var tran = conn.BeginTransaction();

            try
            {
                using var parcelaRepo = new ParcelaRepository(conn);
                using var vendaRepo = new VendaRepository(conn);

                // 2.1) Salva pagamento + atualiza parcela na MESMA transação
                parcelaRepo.RegistrarPagamentoSeguro(
                    parcela,
                    valorPago,
                    parcela.DataPagamento ?? DateTime.Now,
                    formaPgtoId,
                    observacao,
                    tran);

                // 2.2) Recalcula status com leitura dentro da transação ✅
                var parcelasVendaBanco = parcelaRepo.GetParcelas(parcela.VendaID, tran);
                var statusVendaCalculado = _vendaBLL.CalcularStatusVendaPorParcelas(parcelasVendaBanco);

                // 2.3) Atualiza venda na mesma transação
                vendaRepo.AtualizarStatusVenda(parcela.VendaID, statusVendaCalculado, tran);

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }

            // 3) Recibo fora da transação (não influencia integridade)
            GerarReciboAutomatico(parcelaId);
        }



        // ==========================================================
        // ALTERAR STATUS
        // ==========================================================
        public void AlterarStatus(long parcelaId, EnumStatusParcela novoStatus)
        {
            var parcela = _parcelaRepository.BuscarParcelaPorId(parcelaId)
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

            var parcela = _parcelaRepository.BuscarParcelaPorId(parcelaId)
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
            EnumStatusVenda statusEnum = statusVenda;



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
            // ✅ Agora tudo via RepositoryBase (multiempresa + conexão centralizada)
            return _parcelaRepository.ObterDetalheParcela(parcelaId);
        }
       
        public string? GerarReciboAutomatico(long parcelaId, bool perguntarAbrir = true)
        {
            var extratoBLL = new ExtratoBLL();
            var extrato = extratoBLL.ObterExtratoPorParcela(parcelaId);

            var pagamentoBLL = new PagamentoBLL();
            var pagamentos = pagamentoBLL.ListarPagamentosPorParcela(parcelaId);

            if (pagamentos == null || pagamentos.Count == 0)
                return null;

            var empresaBLL = new EmpresaBll();
            var empresa = empresaBLL.ObterDadosParaPdf();

            string pasta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "GVC",
                "Recibos");

            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            // ✅ evita colisão (milissegundos)
            string caminhoPdf = Path.Combine(
                pasta,
                $"Recibo_Parcela_{parcelaId}_{DateTime.Now:yyyyMMddHHmmssfff}.pdf");

            PDFGenerator.GerarReciboPagamentos(
                extrato,
                pagamentos,
                empresa,
                caminhoPdf);

            if (perguntarAbrir && Utilitario.Mensagens.Confirmacao(
                "Recibo gerado automaticamente.\nDeseja abrir agora?"))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = caminhoPdf,
                    UseShellExecute = true
                });
            }

            return caminhoPdf;
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

            // ✅ UM RECIBO ÚNICO DO LOTE
            GerarReciboAutomaticoLote(parcelasIds, dataPagamento);
        }

       
        public void GerarReciboAutomaticoLote(List<long> parcelasIds, DateTime dataPagamento)
        {
            var extratoBLL = new ExtratoBLL();
            var extrato = extratoBLL.ObterExtratoPorParcelas(parcelasIds, DateTime.Now);

            var pagamentoBLL = new PagamentoBLL();
            var pagamentos = pagamentoBLL.ListarPagamentosPorParcelasLote(parcelasIds, dataPagamento);

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
                $"Recibo_Lote_{DateTime.Now:yyyyMMddHHmmssfff}.pdf");

            // ✅ Vamos usar um NOVO PDF que também mostra as parcelas quitadas
            PDFGenerator.GerarReciboPagamentosLote(extrato, pagamentos, empresa, caminhoPdf);
        }


    }
}
