using System;
using System.Collections.Generic;

namespace GVC.Model;

public partial class VwProdutosEstoqueBaixoModel
{
    public int ProdutoID { get; set; }

    public string NomeProduto { get; set; } = null!;

    public string? Referencia { get; set; }

    public int Estoque { get; set; }

    public decimal PrecoDeVenda { get; set; }

    public string Status { get; set; } = null!;

    public string? Fornecedor { get; set; }

    public string NivelEstoque { get; set; } = null!;
}
