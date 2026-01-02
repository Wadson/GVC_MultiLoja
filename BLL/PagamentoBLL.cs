using GVC.DALL;
using GVC.MODEL;
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
