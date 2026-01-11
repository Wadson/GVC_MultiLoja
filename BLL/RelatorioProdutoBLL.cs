using GVC.DAL;
using GVC.MODEL.Relatorios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GVC.BLL
{
    public class RelatorioProdutoBLL
    {
        private readonly RelatorioProdutoDAL _dal = new();

        // ============================
        // PRODUTOS / ESTOQUE
        // ============================
        public List<RelatorioProdutoEstoqueDTO> ObterProdutosEstoque()
        {
            return _dal.ObterProdutosEstoque();
        }

        // ============================
        // LUCRO POR PRODUTO
        // ============================



        public List<RelatorioLucroProdutoDTO> ObterLucroPorProduto(bool somenteComEstoque)
        {
            return _dal.ObterLucroPorProduto(somenteComEstoque);
        }

        // ============================
        // RESUMO GERAL
        // ============================
        public (decimal custo, decimal venda, decimal lucro) CalcularResumo(
            List<RelatorioLucroProdutoDTO> dados)
        {
            var custo = dados.Sum(x => x.CustoTotal);
            var venda = dados.Sum(x => x.VendaTotal);
            var lucro = venda - custo;

            return (custo, venda, lucro);
        }
    }
}
