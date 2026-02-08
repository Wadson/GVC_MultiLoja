using System;
using System.Collections.Generic;
using GVC.Model;
using GVC.Infra.Repository;

namespace GVC.BLL
{
    public class ProdutosBLL
    {
        private readonly ProdutoRepository _repository;

        public ProdutosBLL()
        {
            _repository = new ProdutoRepository();
        }

        // =========================
        // LISTAR
        // =========================
        public List<ProdutoModel> ListarTodos()
        {
            try
            {
                return _repository.ListarTodos();
            }
            catch (Exception erro)
            {
                throw; // mantém o stack trace original
            }
        }

        // =========================
        // BUSCAR
        // =========================
        public ProdutoModel? BuscarPorId(long id)
        {
            if (id <= 0)
                throw new Exception("ID do produto inválido.");

            return _repository.BuscarPorId(id);
        }
        public List<ProdutoModel> BuscarPorNome(string nome)
        {
            // Retorna lista vazia se nome for inválido
            if (string.IsNullOrWhiteSpace(nome))
            {
                return new List<ProdutoModel>();
            }

            return _repository.PesquisarProdutoPorNome(nome);
        }

        // =========================
        // INSERT
        // =========================
        public long Inserir(ProdutoModel produto)
        {
            ValidarProduto(produto, isInsert: true);
            return _repository.Inserir(produto);
        }

        // =========================
        // UPDATE
        // =========================
        public bool Alterar(ProdutoModel produto)
        {
            if (produto.ProdutoID <= 0)
                throw new Exception("ID do produto inválido.");

            ValidarProduto(produto, isInsert: false);
            return _repository.Alterar(produto);
        }

        // =========================
        // DELETE
        // =========================
        public bool Excluir(long id)
        {
            if (id <= 0)
                throw new Exception("ID inválido.");

            return _repository.Excluir(id);
        }

        // =========================
        // REGRAS DE NEGÓCIO
        // =========================
        private static void ValidarProduto(ProdutoModel produto, bool isInsert)
        {
            if (string.IsNullOrWhiteSpace(produto.NomeProduto))
                throw new Exception("Nome do produto é obrigatório.");

            if (produto.PrecoCusto < 0)
                throw new Exception("Preço de custo não pode ser negativo.");

            if (produto.PrecoDeVenda < 0)
                throw new Exception("Preço de venda não pode ser negativo.");

            if (produto.Estoque < 0)
                throw new Exception("Estoque não pode ser negativo.");

            if (isInsert && produto.DataDeEntrada == DateTime.MinValue)
                produto.DataDeEntrada = DateTime.Now;
        }

        // =========================
        // AUXILIAR (DataTable → List)
        // =========================
        private static List<ProdutoModel> MapearLista(System.Data.DataTable dt)
        {
            var lista = new List<ProdutoModel>();

            foreach (System.Data.DataRow r in dt.Rows)
            {
                lista.Add(new ProdutoModel
                {
                    ProdutoID = Convert.ToInt32(r["ProdutoID"]),
                    NomeProduto = r["NomeProduto"].ToString()
                });
            }

            return lista;
        }
    }
}
