// GVC.DTO/DadosExclusaoVenda.cs
using System;
using System.Collections.Generic;

namespace GVC.DTO
{
    public class DadosExclusaoVenda
    {
        public int VendaID { get; set; }
        public int ClienteID { get; set; }
        public string ClienteNome { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorTotal { get; set; }
        public int QuantidadeItens { get; set; }
        public int QuantidadeParcelas { get; set; }
        public bool TemParcelasPagas { get; set; }
        public decimal TotalPago { get; set; }
        public List<string> Produtos { get; set; } = new List<string>();

        // Propriedade calculada
        public bool PodeExcluir => !TemParcelasPagas;
        // Para debug
        public string StatusExclusao => PodeExcluir ? "✅ PODE EXCLUIR" : "❌ BLOQUEADO";
    }
}