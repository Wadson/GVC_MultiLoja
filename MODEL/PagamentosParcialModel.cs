using System;
using System.Collections.Generic;

namespace GVC.Model;

public partial class PagamentosParcialModel
{
    public int PagamentoID { get; set; }

    public int ParcelaID { get; set; }

    public decimal ValorPago { get; set; }

    public DateOnly DataPagamento { get; set; }

    public int? FormaPgtoID { get; set; }

    public string? Observacao { get; set; }
    public int EmpresaID { get; set; }

    public virtual FormaPagamentoModel? FormaPgto { get; set; }

    public virtual ParcelaModel Parcela { get; set; } = null!;
}
