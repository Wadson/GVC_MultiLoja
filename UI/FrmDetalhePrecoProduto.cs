using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace GVC.UTIL
{
    public partial class FrmDetalhePrecoProduto : KryptonForm
    {
        public FrmDetalhePrecoProduto( string nomeProduto,     decimal precoCusto,     decimal precoVenda)
        {
            InitializeComponent();

            this.Text = "Detalhe Financeiro do Produto";
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Width = 400;
            this.Height = 250;

            decimal lucro = precoVenda - precoCusto;
            decimal margem = precoCusto > 0
                ? (lucro / precoCusto) * 100
                : 0;

            var lblProduto = new KryptonLabel
            {
                Text = $"Produto: {nomeProduto}",
                Location = new Point(20, 20),
                AutoSize = true
            };

            var lblCusto = new KryptonLabel
            {
                Text = $"Preço de Custo: {precoCusto:N2}",
                Location = new Point(20, 60),
                AutoSize = true
            };

            var lblVenda = new KryptonLabel
            {
                Text = $"Preço de Venda: {precoVenda:N2}",
                Location = new Point(20, 90),
                AutoSize = true
            };

            var lblLucro = new KryptonLabel
            {
                Text = $"Lucro: {lucro:N2}  ({margem:N2}%)",
                Location = new Point(20, 120),
                AutoSize = true,
                StateCommon =
                {
                    ShortText =
                    {
                        Color1 = Color.DarkGreen,
                        Font = new Font("Segoe UI", 10, FontStyle.Bold)
                    }
                }
            };

            var btnFechar = new KryptonButton
            {
                Text = "Fechar",
                Location = new Point(260, 160),
                Width = 100
            };

            btnFechar.Click += (s, e) => this.Close();

            Controls.Add(lblProduto);
            Controls.Add(lblCusto);
            Controls.Add(lblVenda);
            Controls.Add(lblLucro);
            Controls.Add(btnFechar);
        }
    }
}
