using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.MODEL
{
    public class EmpresaModel
    {
        public int EmpresaID { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string CNAE { get; set; }
        public int Status { get; set; } // ✅ novo campo
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }

        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }

        public string Responsavel { get; set; }
        public string CertificadoDigital { get; set; }

        public DateTime DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public string UsuarioCriacao { get; set; }
        public string UsuarioAtualizacao { get; set; }
        public byte[] Logo { get; set; }

    }

}
