using System;
using System.Collections.Generic;

namespace GVC.Model;

public partial class VwFluxoCaixaModel
{
    public DateOnly? Data { get; set; }

    public string? FormaPagamento { get; set; }

    public int? ParcelasRecebidas { get; set; }

    public int? PagamentosRealizados { get; set; }

    public decimal? TotalRecebido { get; set; }

    public decimal? ValorMedioPagamento { get; set; }
}
