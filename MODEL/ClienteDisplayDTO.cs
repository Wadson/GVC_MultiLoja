using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.Model
{
    // Este DTO é usado APENAS para exibir no ComboBox
    public class ClienteDisplayDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string DisplayText => $"{Nome} | {Documento}";

        // Construtor para facilitar
        public ClienteDisplayDTO(int id, string nome, string documento)
        {
            Id = id;
            Nome = nome;
            Documento = documento;
        }
    }
}
