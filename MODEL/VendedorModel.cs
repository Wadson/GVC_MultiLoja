// GVC.DOMAIN\Models\VendedorModel.cs

using System;

namespace GVC.DOMAIN.Models
{
    public class VendedorModel
    {
        public int VendedorID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime? DataNascimento { get; set; }
        public DateTime? DataContratacao { get; set; }
        public decimal? Comissao { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public int CidadeID { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string Observacoes { get; set; }
        public int Status { get; set; } // 1=Ativo, 0=Inativo
        public int EmpresaID { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public string UsuarioCriacao { get; set; }
        public string UsuarioAtualizacao { get; set; }

        // Propriedade de apoio
        public string StatusDescricao => Status == 1 ? "Ativo" : "Inativo";
    }
}