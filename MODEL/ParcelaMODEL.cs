using GVC.Model.Enums;
using GVC.Model.Enums.GVC.Model.Enums;
using System;
using System.Collections.Generic;

namespace GVC.Model;

public partial class ParcelaModel
{
    public int ParcelaID { get; set; }

    public int VendaID { get; set; }

    public int NumeroParcela { get; set; }

    public DateTime DataVencimento { get; set; }

    public decimal ValorParcela { get; set; }

    public decimal? ValorRecebido { get; set; }
   
    public EnumStatusParcela Status { get; set; }

    public DateTime? DataPagamento { get; set; }

    public decimal? Juros { get; set; }

    public decimal? Multa { get; set; }
    public decimal Saldo { get; set; }

    public string? Observacao { get; set; }

    public virtual ICollection<PagamentosParcialModel> PagamentosParciais { get; set; } = new List<PagamentosParcialModel>();

    public virtual VendaModel Venda { get; set; } = null!;
}
