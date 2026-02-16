using System;
using System.Collections.Generic;

namespace GVC.Model;

public partial class MovimentacaoEstoqueModel
{
    public int MovimentacaoID { get; set; }

    public int ProdutoID { get; set; }

    public string TipoMovimentacao { get; set; } = null!;

    public int Quantidade { get; set; }

    public int EstoqueAnterior { get; set; }

    public int EstoqueAtual { get; set; }

    public string Origem { get; set; } = null!;

    public string? Documento { get; set; }

    public string? Observacao { get; set; }

   

    public string? Usuario { get; set; }
    public int EmpresaID { get; set; }

    public virtual ProdutoModel Produto { get; set; } = null!;
    //DataMovimentacao, PrecoCompra, PrecoCustoEntrada, FornecedorID
    public DateTime DataMovimentacao { get; set; }
    public decimal? PrecoCompra { get; set; }
    public decimal? PrecoCustoEntrada { get; set; }
    public int? FornecedorID { get; set; }

}
