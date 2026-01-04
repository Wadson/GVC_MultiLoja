using System;
using System.Collections.Generic;

namespace GVC.Model;

public partial class FornecedorModel
{
    public int FornecedorID { get; set; }

    public string Nome { get; set; } = null!;

    public string? Cnpj { get; set; }

    public string?IE { get; set; }

    public string? Telefone { get; set; }

    public string? Email { get; set; }

    public int CidadeID { get; set; }

    public string? Logradouro { get; set; }

    public string? Numero { get; set; }

    public string? Bairro { get; set; }

    public string? Cep { get; set; }

    public DateTime? DataCriacao { get; set; }

    public string? Observacoes { get; set; }

    public virtual CidadeModel Cidade { get; set; } = null!;

    public virtual ICollection<PedidoModel> Pedidos { get; set; } = new List<PedidoModel>();

    public virtual ICollection<ProdutoModel> Produtos { get; set; } = new List<ProdutoModel>();
}
