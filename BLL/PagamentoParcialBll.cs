using GVC.DAL;
using GVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.BLL
{
    internal class PagamentoParcialBll
    {
        private PagamentoParcialDal _dal;

        PagamentoParcialDal pagamentoParcialDAL = null;
        public void Excluir(PagamentosParcialModel pagamentoParcial)
        {
            try
            {
                _dal.ExcluirPagamentosParciaisPorParcelaID(pagamentoParcial.ParcelaID);
            }
            catch (Exception erro)
            {
                throw; // mantém a exceção original
            }
        }
        public PagamentoParcialBll()
        {
            _dal = new PagamentoParcialDal();
        }


        public void RegistrarPagamentoParcial(PagamentosParcialModel pagamentoParcial)
        {
            // Lógica de negócios antes de inserir o pagamento parcial, se necessário
            _dal.InserirPagamentoParcial(pagamentoParcial);
        }

        public List<PagamentosParcialModel> ObterPagamentosParciaisPorParcela(int parcelaID)
        {
            // Lógica de negócios antes de obter os pagamentos parciais, se necessário
            return _dal.ObterPagamentosParciaisPorParcela(parcelaID);
        }
        public List<PagamentoExtratoModel> ObterExtratoRecibo(long parcelaId)
        {
            return _dal.ObterExtratoPorParcela(parcelaId);
        }

    }
}
