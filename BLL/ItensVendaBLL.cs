using GVC.Model;
using GVC.Infra.Repository;
using System.Collections.Generic;
using System.Data;

namespace GVC.BLL
{
    internal class ItensVendaBLL
    {
        public void Salvar(ItemVendaModel item)
        {
            using var repo = new ItemVendaRepository();
            repo.AddItemVenda(item);
        }

        public void Atualizar(ItemVendaModel item)
        {
            using var repo = new ItemVendaRepository();
            repo.UpdateItemVenda(item);
        }

        public void Excluir(ItemVendaModel item)
        {
            using var repo = new ItemVendaRepository();
            repo.Excluir(item);
        }

        public ItemVendaModel? BuscarPorId(int id)
        {
            using var repo = new ItemVendaRepository();
            return repo.BuscarPorId(id);
        }

        public List<ItemVendaModel> ListarItensPorVenda(long vendaId)
        {
            using var repo = new ItemVendaRepository();
            return repo.ListarItensPorVenda(vendaId);
        }

        public DataTable ListarItensVenda()
        {
            using var repo = new ItemVendaRepository();
            return repo.ListarItensVenda();
        }

        public decimal CalcularTotalVenda(int vendaId)
        {
            using var repo = new ItemVendaRepository();
            return repo.CalcularTotalVenda(vendaId);
        }
    }
}
