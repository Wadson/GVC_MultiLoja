using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GVC.Model;

public partial class ItemVendaModel
{
    private int quantidade = 1;
    private decimal precoUnitario;
    private decimal subtotal;
    private decimal? descontoItem;
    public int ItemVendaID { get; set; }

    public int VendaID { get; set; }

    public int ProdutoID { get; set; }
    public string? ProdutoDescricao { get; set; }
    public int EmpresaID { get; set; }

    public virtual ProdutoModel Produto { get; set; } = null!;

    public virtual VendaModel Venda { get; set; } = null!;
    public decimal EstoqueAtual { get; set; }

    public int Quantidade
    {
        get => quantidade;
        set
        {
            if (quantidade != value)
            {
                quantidade = value;
                OnPropertyChanged(nameof(Quantidade));
                AtualizarSubtotal();
            }
        }
    }

    public decimal PrecoUnitario
    {
        get => precoUnitario;
        set
        {
            if (precoUnitario != value)
            {
                precoUnitario = value;
                OnPropertyChanged(nameof(PrecoUnitario));
                AtualizarSubtotal();
            }
        }
    }



    public decimal Subtotal
    {
        get => subtotal;
        internal set
        {
            if (subtotal != value)
            {
                subtotal = value;
                OnPropertyChanged(nameof(Subtotal));
            }
        }
    }


    public decimal? DescontoItem
    {
        get => descontoItem;
        set
        {
            descontoItem = value < 0 ? 0 : value;
            OnPropertyChanged(nameof(DescontoItem));
            AtualizarSubtotal();
        }
    }

    // Método para atualizar Subtotal sempre que Quantidade, PrecoUnitario ou DescontoItem mudar
    public void AtualizarSubtotal()
    {
        var desconto = DescontoItem ?? 0m;
        Subtotal = (Quantidade * PrecoUnitario) - desconto;
    }


    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
