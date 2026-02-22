// GVC.BLL\VendedorBLL.cs

using GVC.DAL;
using GVC.DOMAIN.Models;
using GVC.Infra.Repository;
using GVC.UTIL;
using System;
using System.Data;

namespace GVC.BLL
{
    public class VendedorBLL
    {
        private readonly VendedorRepository _repository;

        public VendedorBLL()
        {
            _repository = new VendedorRepository();
        }
        public int ContarTotal()
        {
            return _repository.ContarTotal();
        }

        public DataTable ListarTodos()
        {
            return _repository.ListarTodos();
        }

        public DataTable PesquisarVendedor(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                return _repository.ListarTodos();

            return _repository.PesquisarPorNome(nome);
        }

        public VendedorModel ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public int Inserir(VendedorModel vendedor)
        {
            // Validações
            if (string.IsNullOrWhiteSpace(vendedor.Nome))
                throw new Exception("Nome do vendedor é obrigatório.");

            vendedor.UsuarioCriacao = Sessao.NomeUsuario;
            vendedor.EmpresaID = Sessao.EmpresaID;
            vendedor.Status = 1; // Ativo por padrão

            return _repository.Inserir(vendedor);
        }

        public void Atualizar(VendedorModel vendedor)
        {
            if (vendedor.VendedorID <= 0)
                throw new Exception("ID do vendedor inválido.");

            if (string.IsNullOrWhiteSpace(vendedor.Nome))
                throw new Exception("Nome do vendedor é obrigatório.");

            vendedor.UsuarioAtualizacao = Sessao.NomeUsuario;
            vendedor.EmpresaID = Sessao.EmpresaID;

            _repository.Atualizar(vendedor);
        }

        public void Excluir(int id)
        {
            if (id <= 0)
                throw new Exception("ID do vendedor inválido.");

            // Verificar se o vendedor pode ser excluído (não tem vendas vinculadas)
            if (TemVendasVinculadas(id))
                throw new Exception("Este vendedor possui vendas vinculadas e não pode ser excluído.");

            _repository.Excluir(id);
        }

        private bool TemVendasVinculadas(int vendedorID)
        {
            // Implementar verificação se existem vendas para este vendedor
            // Por enquanto retorna false
            return false;
        }
    }
}