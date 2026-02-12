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
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Width = 480;
            this.Height = 300;
            this.Padding = new Padding(10);

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

            // Label do Produto (com ícone)
            var lblProduto = new KryptonLabel
            {
                Text = $"Produto: {nomeProduto}",
                Location = new Point(20, 20),
                AutoSize = true,
                StateCommon =
                {
                    ShortText =
                    {
                        Font = fonteNegrito,
                        Color1 = Color.FromArgb(52, 58, 64)
                    }
                }
            };

            // Preço de Custo (com ícone)
            var lblCustoTexto = new KryptonLabel
            {
                Text = "Preço de Custo:",
                Location = new Point(20, 70),
                AutoSize = true,
                StateCommon =
                {
                    ShortText =
                    {
                        Font = fontePadrao,
                        Color1 = Color.FromArgb(73, 80, 87)
                    }
                }
            };

            var lblCustoValor = new KryptonLabel
            {
                Text = $"{precoCusto:N2}",
                Location = new Point(200, 70),
                AutoSize = true,
                StateCommon =
                {
                    ShortText =
                    {
                        Font = fonteNegrito,
                        Color1 = corCusto
                    }
                }
            };

            // Preço de Venda (com ícone)
            var lblVendaTexto = new KryptonLabel
            {
                Text = "Preço de Venda:",
                Location = new Point(20, 110),
                AutoSize = true,
                StateCommon =
                {
                    ShortText =
                    {
                        Font = fontePadrao,
                        Color1 = Color.FromArgb(73, 80, 87)
                    }
                }
            };

            var lblVendaValor = new KryptonLabel
            {
                Text = $"{precoVenda:N2}",
                Location = new Point(200, 110),
                AutoSize = true,
                StateCommon =
                {
                    ShortText =
                    {
                        Font = fonteNegrito,
                        Color1 = corVenda
                    }
                }
            };

            // Lucro (com ícone)
            var lblLucroTexto = new KryptonLabel
            {
                Text = "Lucro:",
                Location = new Point(20, 150),
                AutoSize = true,
                StateCommon =
                {
                    ShortText =
                    {
                        Font = fontePadrao,
                        Color1 = Color.FromArgb(73, 80, 87)
                    }
                }
            };

            var lblLucroValor = new KryptonLabel
            {
                Text = $"{lucro:N2}  ({margem:N2}%)",
                Location = new Point(200, 150),
                AutoSize = true,
                StateCommon =
                {
                    ShortText =
                    {
                        Font = fonteNegrito,
                        Color1 = corLucro
                    }
                }
            };


            // Linha separadora
            var separador = new KryptonBorderEdge
            {
                Location = new Point(20, 190),
                Size = new Size(420, 2),
                BorderStyle = (PaletteBorderStyle)BorderStyle.FixedSingle,
                StateCommon =
                {
                    Color1 = Color.FromArgb(222, 226, 230)
                }
            };

            // Botão Fechar com ícone
            var btnFechar = new KryptonButton
            {
                Text = "✔️  Fechar",
                Location = new Point(330, 210),
                Width = 120,
                Height = 35,
                StateCommon =
                {
                    Content =
                    {
                        ShortText =
                        {
                            Font = new Font("Segoe UI", 12, FontStyle.Bold),
                            Color1 = Color.White
                        }
                    },
                    Back =
                    {
                        Color1 = Color.FromArgb(0, 123, 255),
                        Color2 = Color.FromArgb(0, 105, 217)
                    },
                    Border =
                    {
                        Color1 = Color.FromArgb(0, 86, 179),
                        Draw = InheritBool.True,
                        Rounding = 5
                    }
                }
            };

            btnFechar.Click += (s, e) => this.Close();

            // Adicionar todos os controles
            Controls.Add(lblProduto);
            Controls.Add(lblCustoTexto);
            Controls.Add(lblCustoValor);
            Controls.Add(lblVendaTexto);
            Controls.Add(lblVendaValor);
            Controls.Add(lblLucroTexto);
            Controls.Add(lblLucroValor);
            Controls.Add(separador);
            Controls.Add(btnFechar);
        }
    }
}