using GVC.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.BLL
{
    
    public class EmpresaBLL
    {
        private readonly EmpresaDal _empresaDal;
        public void Cadastrar(EmpresaModel empresa)
        {
            empresa.Status = 1; // sempre ativo ao inserir
            empresa.DataCriacao = DateTime.Now;
            _empresaDal.Inserir(empresa);
        }

    }
}
