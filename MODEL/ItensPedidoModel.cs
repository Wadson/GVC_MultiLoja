using System;
using System.Collections.Generic;

namespace GVC.Model;

public partial class ItensPedidoModel
{
    public int ItensPedidoID { get; set; }

    public int PedidoID { get; set; }

    public string? Referencia { get; set; }

    public int Quantidade { get; set; }

    public virtual PedidoModel Pedido { get; set; } = null!;
}
