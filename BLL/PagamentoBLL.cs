using GVC.DAL;
using GVC.DTO;
using GVC.Infra.Conexao;
using GVC.Infra.Repository;
using GVC.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.BLL
{
    public class PagamentoBLL
    {
        private readonly PagamentoParcialDal _pagamentoParcialDal = new();
        private readonly ParcelaRepository _parcelaRepository;

        public PagamentoBLL()
        {
            _parcelaRepository = new ParcelaRepository();
        }
        public PagamentoBLL(SqlConnection conn)
        {
            _parcelaRepository = new ParcelaRepository(conn);
        }

        public void RecalcularValorRecebido(int parcelaId, SqlConnection conn, SqlTransaction tran)
        {
            

            var totalPago = _pagamentoParcialDal.SomarPagamentos(parcelaId, conn, tran);
            _parcelaRepository.AtualizarValorRecebido(parcelaId, totalPago, conn, tran);
        }

        public List<PagamentoExtratoModel> ListarPagamentosPorParcela(long parcelaId)
        {
            return _pagamentoParcialDal.ListarPagamentosPorParcelaCompleto(parcelaId);
        }
        public List<PagamentoExtratoModel> ListarPagamentosPorParcelasLote(
             List<long> parcelasIds,
             DateTime dataPagamento,
             string? observacaoPrefixo = "Baixa total em lote")
        {
            using var repo = new PagamentoRepository();
            return repo.ListarPagamentosPorParcelasLote(parcelasIds, dataPagamento, observacaoPrefixo);
        }


        public PagamentoExtratoModel ObterPagamentoPorId(long pagamentoId)
        {
            return _pagamentoParcialDal.ObterPagamentoPorId(pagamentoId);
        }
    }
}
