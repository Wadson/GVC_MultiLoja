using System;
using System.Collections.Generic;

namespace GVC.Model;

public partial class VwDashboardFinanceiroModel
{
    public decimal? TotalVendasMes { get; set; }

    public decimal? TotalRecebidoMes { get; set; }

    public decimal? TotalPendente { get; set; }

    public int? TotalClientesAtivos { get; set; }

    public int? ProdutosEstoqueBaixo { get; set; }

    public int? VendasHoje { get; set; }
}
