using System;
using System.Collections.Generic;

namespace GVC.Model;

public partial class FormaPagamentoModel
{
    public int FormaPgtoID { get; set; }

    public string NomeFormaPagamento { get; set; } = null!;

    public bool Ativo { get; set; }

    public virtual ICollection<PagamentosParcialModel> PagamentosParciais { get; set; } = new List<PagamentosParcialModel>();

    public virtual ICollection<VendaModel> Venda { get; set; } = new List<VendaModel>();
}
