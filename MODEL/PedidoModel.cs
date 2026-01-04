using System;
using System.Collections.Generic;

namespace GVC.Model;

public partial class PedidoModel
{
    public int PedidoID { get; set; }

    public int FornecedorID { get; set; }

    public DateOnly DataPedido { get; set; }

    public decimal ValorTotalPedido { get; set; }

    public virtual FornecedorModel Fornecedor { get; set; } = null!;

    public virtual ICollection<ItensPedidoModel> ItensPedidos { get; set; } = new List<ItensPedidoModel>();
}
