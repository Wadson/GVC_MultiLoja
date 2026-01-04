using System;
using System.Collections.Generic;

namespace GVC.Model;

public partial class VwParcelasEmAbertoModel
{
    public int ParcelaID { get; set; }

    public int NumeroParcela { get; set; }

    public DateOnly DataVencimento { get; set; }

    public int? DiasParaVencer { get; set; }

    public decimal ValorParcela { get; set; }

    public decimal ValorRecebido { get; set; }

    public decimal? ValorPendente { get; set; }

    public string Status { get; set; } = null!;

    public int VendaID { get; set; }

    public string Cliente { get; set; } = null!;
}
