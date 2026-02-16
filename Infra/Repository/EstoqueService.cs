using System;
using System.Collections.Generic;
using System.Text;

namespace GVC.Infra.Repository
{
    public class EstoqueService
    {
        private readonly ProdutoRepository _produtoRepository;

        public EstoqueService()
        {
            _produtoRepository = new ProdutoRepository();
        }

        public void ValidarEstoque(long produtoId, decimal quantidade)
        {
            var produto = _produtoRepository.BuscarPorId(produtoId)
                ?? throw new Exception("Produto não encontrado.");

            int qtd = Convert.ToInt32(quantidade);

            if (produto.Estoque < qtd)
                throw new Exception("Estoque insuficiente.");
        }

        public void BaixarEstoque(long produtoId, decimal quantidade)
        {
            var produto = _produtoRepository.BuscarPorId(produtoId)
                ?? throw new Exception("Produto não encontrado.");

            int qtd = Convert.ToInt32(quantidade);

            produto.Estoque -= qtd;

            _produtoRepository.AtualizarEstoque(produtoId, produto.Estoque);
        }

        public void ReporEstoque(long produtoId, decimal quantidade)
        {
            var produto = _produtoRepository.BuscarPorId(produtoId)
                ?? throw new Exception("Produto não encontrado.");

            int qtd = Convert.ToInt32(quantidade);

            produto.Estoque += qtd;

            _produtoRepository.AtualizarEstoque(produtoId, produto.Estoque);
        }
    }

}


/*
 * 
 * 📍 ONDE CHAMAR ISSO
🔹 Ao salvar venda

Dentro do método:

VendaBLL.SalvarVenda(...)


ANTES de salvar:

var estoqueService = new EstoqueService();

foreach (var item in venda.Itens)
{
    estoqueService.ValidarEstoque(item.ProdutoID, item.Quantidade);
}


Depois de salvar a venda:

foreach (var item in venda.Itens)
{
    estoqueService.BaixarEstoque(item.ProdutoID, item.Quantidade);
}

📍 SE CANCELAR VENDA

Você precisa repor estoque:

foreach (var item in venda.Itens)
{
    estoqueService.ReporEstoque(item.ProdutoID, item.Quantidade);
}

🚨 MUITO IMPORTANTE

Se você não colocar isso dentro de uma transação, pode dar problema:

Venda salva

Estoque falha

Banco fica inconsistente

*/