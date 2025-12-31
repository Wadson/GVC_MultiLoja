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
        private readonly PagamentoParcialDal _dal = new();

        public List<PagamentoExtratoModel> ListarPagamentos(long parcelaId)
        {
            return _dal.ListarPagamentosPorParcelaCompleto(parcelaId);
        }
    }
}
