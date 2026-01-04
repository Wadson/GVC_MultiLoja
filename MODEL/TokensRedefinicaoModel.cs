using System;
using System.Collections.Generic;

namespace GVC.Model;

public partial class TokensRedefinicaoModel
{
    public int TokenID { get; set; }

    public int UsuarioID { get; set; }

    public string Token { get; set; } = null!;

    public DateTime DataExpiracao { get; set; }

    public virtual UsuarioModel Usuario { get; set; } = null!;
}
