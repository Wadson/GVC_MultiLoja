using GVC.DAL;
using GVC.DTO;
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
        private readonly ParcelaRepository _parcelaDAL;

        public void RecalcularValorRecebido(int parcelaId, SqlConnection conn, SqlTransaction tran)
        {
            

            var totalPago = _pagamentoParcialDal.SomarPagamentos(parcelaId, conn, tran);
            _parcelaDAL.AtualizarValorRecebido(parcelaId, totalPago, conn, tran);
        }

        public List<PagamentoExtratoModel> ListarPagamentosPorParcela(long parcelaId)
        {
            return _pagamentoParcialDal.ListarPagamentosPorParcelaCompleto(parcelaId);
        }
        public PagamentoExtratoModel ObterPagamentoPorId(long pagamentoId)
        {
            return _pagamentoParcialDal.ObterPagamentoPorId(pagamentoId);
        }
    }
}
