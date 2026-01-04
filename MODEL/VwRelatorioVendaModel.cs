using System;
using System.Collections.Generic;

namespace GVC.Model;

public partial class VwRelatorioVendaModel
{
    public int VendaID { get; set; }

    public DateTime DataVenda { get; set; }

    public string Cliente { get; set; } = null!;

    public string? Cpf { get; set; }

    public string? Telefone { get; set; }

    public decimal ValorTotal { get; set; }

    public decimal Desconto { get; set; }

    public decimal? ValorLiquido { get; set; }

    public string StatusVenda { get; set; } = null!;

    public string? FormaPagamento { get; set; }

    public int? TotalItens { get; set; }

    public int? QuantidadeTotal { get; set; }
}
