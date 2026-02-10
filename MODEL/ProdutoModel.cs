using System;
using System.Collections.Generic;

namespace GVC.Model;

public partial class ProdutoModel
{
    public int ProdutoID { get; set; }
    public string NomeProduto { get; set; } = null!;
    public string? Referencia { get; set; }
    public decimal PrecoCusto { get; set; }
    public decimal Lucro { get; set; }
    public decimal PrecoDeVenda { get; set; }
    public int Estoque { get; set; }
    public DateTime DataDeEntrada { get; set; }
    public string Status { get; set; } = null!;
    public string? Situacao { get; set; }
    public string? Unidade { get; set; }
    public int? MarcaID { get; set; }
    public string NomeMarca { get; set; } // 🔹 nova propriedade
    public DateTime? DataValidade { get; set; }
    public string? GtinEan { get; set; }
    public string? Imagem { get; set; }    
    public int EmpresaID { get; set; }   
    public FornecedorModel? Fornecedor { get; set; }
    public int? FornecedorID { get; set; }
    public string? NomeFornecedor => Fornecedor?.Nome;
    

    public virtual ICollection<ItemVendaModel> ItemVenda { get; set; } = new List<ItemVendaModel>();
    public virtual ICollection<MovimentacaoEstoqueModel> MovimentacaoEstoques { get; set; } = new List<MovimentacaoEstoqueModel>();
}
