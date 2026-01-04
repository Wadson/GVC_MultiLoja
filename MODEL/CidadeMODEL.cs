using System;
using System.Collections.Generic;

namespace GVC.Model;

public partial class CidadeModel
{
    public int CidadeID { get; set; }

    public string Nome { get; set; } = null!;

    public int EstadoID { get; set; }

    public string? CodigoIbge { get; set; }

    public virtual ICollection<ClienteModel> Clientes { get; set; } = new List<ClienteModel>();

    public virtual EstadoModel Estado { get; set; } = null!;

    public virtual ICollection<FornecedorModel> Fornecedors { get; set; } = new List<FornecedorModel>();
}
