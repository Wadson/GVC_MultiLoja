using System;
using System.Collections.Generic;

namespace GVC.Model;

public partial class UsuarioModel
{
    public int UsuarioID { get; set; }

    public string TipoUsuario { get; set; } = null!;

    public string NomeCompleto { get; set; } = null!;

    public string Cpf { get; set; } = null!;

    public DateTime DataNascimento { get; set; }

    public string NomeUsuario { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public DateTime DataCriacao { get; set; }
    public int EmpresaID { get; set; }

    public virtual ICollection<TokensRedefinicaoModel> TokensRedefinicaos { get; set; } = new List<TokensRedefinicaoModel>();
}
