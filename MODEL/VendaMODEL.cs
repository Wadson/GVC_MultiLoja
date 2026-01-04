using GVC.Model.Enums;
using System;
using System.Collections.Generic;

namespace GVC.Model;

public partial class VendaModel
{
    public int VendaID { get; set; }

    public int ClienteID { get; set; }

    public int? FormaPgtoID { get; set; }

    public DateTime DataVenda { get; set; }

    public decimal ValorTotal { get; set; }

    public decimal? Desconto { get; set; }

    public string? Observacoes { get; set; }

    public string NomeCliente { get; set; }
    public EnumStatusVenda StatusVenda { get; set; }

    public int? VendedorID { get; set; }

    public virtual ClienteModel Cliente { get; set; } = null!;

    public virtual FormaPagamentoModel? FormaPgto { get; set; }

    public virtual ICollection<ItemVendaModel> ItemVenda { get; set; } = new List<ItemVendaModel>();

    public virtual ICollection<ParcelaModel> Parcelas { get; set; } = new List<ParcelaModel>();

    public virtual ClienteModel? Vendedor { get; set; }
}
