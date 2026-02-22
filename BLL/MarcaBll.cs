using GVC.Infra.Repository;
using GVC.Model;
using System;
using System.Collections.Generic;

namespace GVC.BLL
{
    public class MarcaBll
    {
        private readonly MarcaDal _dal = new MarcaDal();
        public int ContarTotal()
        {
            return _dal.ContarTotal();
        }
        public List<MarcaModel> Listar(string filtro = "")
        {
            using var repo = new MarcaDal();
            return repo.Listar(filtro);
        }

        public MarcaModel BuscarPorId(int id)
        {
            using var repo = new MarcaDal();
            return repo.BuscarPorId(id);
        }

        public void Salvar(MarcaModel marca)
        {
            if (string.IsNullOrWhiteSpace(marca.NomeMarca))
                throw new Exception("Informe o nome da marca.");

            using var repo = new MarcaDal();

            if (marca.MarcaID == 0)
                repo.Inserir(marca);
            else
                repo.Atualizar(marca);
        }

        public void Excluir(int marcaId)
        {
            using var repo = new MarcaDal();
            repo.Excluir(marcaId);
        }
    }
}
