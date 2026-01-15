using GVC.BLL;
using Krypton.Toolkit;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace GVC.View
{
    public partial class FrmItensVenda : KryptonForm
    {
        private readonly ItensVendaBLL _itensVendaBll = new ItensVendaBLL();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public long VendaId { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SubTitulo { get; set; }


        public FrmItensVenda()
        {
            InitializeComponent();
        }
        private void ConfigurarCabecalho()
        {
            panelHeader.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);

            lblTitulo.Text = "ITENS DA VENDA";
            lblTitulo.ForeColor = System.Drawing.Color.White;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.AutoSize = true;

            lblSubTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblSubTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblSubTitulo.AutoSize = true;
        }







        private void btnSair_Click(object sender, EventArgs e)
        {
        }
        private void ConfigurarGridItensVenda()
        {
            dgvItensVenda.AutoGenerateColumns = false;
            dgvItensVenda.Columns.Clear();

            // 🔹 Coluna ProdutoID (Cód. Prod.) - Centralizada
            var colProdutoID = new DataGridViewTextBoxColumn
            {
                Name = "ProdutoID",
                DataPropertyName = "ProdutoID",
                HeaderText = "Cód. Prod.",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };
            dgvItensVenda.Columns.Add(colProdutoID);

            // 🔹 Coluna NomeProduto
            var colNomeProduto = new DataGridViewTextBoxColumn
            {
                Name = "ProdutoDescricao",
                DataPropertyName = "ProdutoDescricao",
                HeaderText = "Produto",
                Width = 450,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dgvItensVenda.Columns.Add(colNomeProduto);

            // 🔹 Coluna Quantidade - Centralizada
            var colQuantidade = new DataGridViewTextBoxColumn
            {
                Name = "Quantidade",
                DataPropertyName = "Quantidade",
                HeaderText = "Qtd",
                Width = 60,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };
            dgvItensVenda.Columns.Add(colQuantidade);

            // 🔹 Coluna PrecoUnitario (Preço Unitário) - Formato moeda
            var colPrecoUnitario = new DataGridViewTextBoxColumn
            {
                Name = "PrecoUnitario",
                DataPropertyName = "PrecoUnitario",
                HeaderText = "Preço Unitário",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            };
            dgvItensVenda.Columns.Add(colPrecoUnitario);

            // 🔹 Coluna DescontoItem (Desconto) - Formato moeda
            var colDescontoItem = new DataGridViewTextBoxColumn
            {
                Name = "DescontoItem",
                DataPropertyName = "DescontoItem",
                HeaderText = "Desconto",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            };
            dgvItensVenda.Columns.Add(colDescontoItem);

            // 🔹 Coluna Subtotal - Formato moeda
            var colSubtotal = new DataGridViewTextBoxColumn
            {
                Name = "Subtotal",
                DataPropertyName = "Subtotal",
                HeaderText = "Subtotal",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            };
            dgvItensVenda.Columns.Add(colSubtotal);

            // 🔹 Configurações gerais do grid
            dgvItensVenda.AllowUserToAddRows = false;
            dgvItensVenda.AllowUserToDeleteRows = false;
            dgvItensVenda.ReadOnly = true;
            dgvItensVenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItensVenda.MultiSelect = false;
            dgvItensVenda.RowHeadersVisible = false;
        }

        private void AplicarFormatacaoItensVenda()
        {
            // Garante que os valores monetários sejam formatados corretamente
            foreach (DataGridViewRow row in dgvItensVenda.Rows)
            {
                // Formata PrecoUnitario
                if (row.Cells["PrecoUnitario"].Value != null &&
                    decimal.TryParse(row.Cells["PrecoUnitario"].Value.ToString(), out decimal preco))
                {
                    row.Cells["PrecoUnitario"].Value = preco;
                }

                // Formata Subtotal
                if (row.Cells["Subtotal"].Value != null &&
                    decimal.TryParse(row.Cells["Subtotal"].Value.ToString(), out decimal subtotal))
                {
                    row.Cells["Subtotal"].Value = subtotal;
                }

                // Formata DescontoItem
                if (row.Cells["DescontoItem"].Value != null &&
                    decimal.TryParse(row.Cells["DescontoItem"].Value.ToString(), out decimal desconto))
                {
                    row.Cells["DescontoItem"].Value = desconto;
                }
            }
        }
        private void CarregarItensVenda()
        {
            if (VendaId <= 0)
                return;

            var itens = _itensVendaBll.ListarItensPorVenda(VendaId);
            dgvItensVenda.DataSource = itens;

            lblSubTitulo.Text = SubTitulo;
        }

        private void dgvItensVenda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void FrmItensVenda_Load(object sender, EventArgs e)
        {
            ConfigurarGridItensVenda();
            ConfigurarCabecalho();
            CarregarItensVenda(); // 🔥 ESTA LINHA É A CHAVE
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
