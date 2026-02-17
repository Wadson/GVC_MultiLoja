using System;
using System.Collections.Generic;

namespace GVC.DTO
{
    public class VendaVisualizacaoDTO
    {
        public int VendaID { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal Desconto { get; set; }
        public string StatusVenda { get; set; } = "";
        public int ClienteID { get; set; }
        public string ClienteNome { get; set; } = "";

        public List<VendaItemVisualizacaoDTO> Itens { get; set; } = new();
        public List<VendaParcelaVisualizacaoDTO> Parcelas { get; set; } = new();
    }

    public class VendaItemVisualizacaoDTO
    {
        public int ProdutoID { get; set; }
        public string NomeProduto { get; set; } = "";
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Subtotal { get; set; }
        public decimal DescontoItem { get; set; }
    }

    public class VendaParcelaVisualizacaoDTO
    {
        public int ParcelaID { get; set; }
        public int NumeroParcela { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal ValorParcela { get; set; }
        public decimal Juros { get; set; }
        public decimal Multa { get; set; }
        public decimal ValorRecebido { get; set; }
        public string Status { get; set; } = "";
        public DateTime? DataPagamento { get; set; }
    }
}
