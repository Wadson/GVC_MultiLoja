using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace GVC.UTIL
{
    public partial class FrmDetalhePrecoProduto : KryptonForm
    {
        public FrmDetalhePrecoProduto(string nomeProduto, decimal precoCusto, decimal precoVenda)
        {
            InitializeComponent();

            this.Text = "Detalhe Financeiro do Produto";           

            decimal lucro = precoVenda - precoCusto;
            decimal margem = precoCusto > 0
                ? (lucro / precoCusto) * 100
                : 0;

            // Fonte padrão para todos os labels (tamanho 14)
            Font fontePadrao = new Font("Segoe UI", 14, FontStyle.Regular);
            Font fonteNegrito = new Font("Segoe UI", 14, FontStyle.Bold);

            // Cores para os valores
            Color corCusto = Color.FromArgb(220, 53, 69);      // Vermelho
            Color corVenda = Color.FromArgb(40, 167, 69);     // Verde
            Color corLucro = Color.FromArgb(0, 123, 255);     // Azul

            lblNomeProduto.Text = $"Produto: {nomeProduto}";

            // Preço de Custo (com ícone)

            lblCusto.Text = precoCusto.ToString("C2");
            lblPrecoVenda.Text = precoVenda.ToString("C2");
            lblLucro.Text = lucro.ToString("C2");
            lblMargem.Text = margem.ToString("N2") + "%";
            // Botão Fechar com ícone
        }



    }
}