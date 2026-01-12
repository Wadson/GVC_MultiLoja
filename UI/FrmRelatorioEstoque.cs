using GVC.BLL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GVC.View
{
    public partial class FrmRelatorioEstoque : KryptonForm
    {
        public FrmRelatorioEstoque()
        {
            InitializeComponent();
        }
        private void ConfigurarGridEstoque()
        {
            dgvEstoque.AutoGenerateColumns = false;
            dgvEstoque.Columns.Clear();

            // ProdutoID centralizado
            dgvEstoque.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProdutoID",
                HeaderText = "ID",
                DataPropertyName = "ProdutoID",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            // NomeProduto com largura maior
            dgvEstoque.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NomeProduto",
                HeaderText = "Produto",
                DataPropertyName = "NomeProduto",
                Width = 450
            });

            // Estoque centralizado
            dgvEstoque.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estoque",
                HeaderText = "Estoque",
                DataPropertyName = "Estoque",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            // Preço de Custo
            dgvEstoque.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PrecoCusto",
                HeaderText = "Preço de Custo",
                DataPropertyName = "PrecoCusto",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            // Preço de Venda
            dgvEstoque.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PrecoDeVenda",
                HeaderText = "Preço de Venda",
                DataPropertyName = "PrecoDeVenda",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            // Valor Total Custo
            dgvEstoque.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ValorTotalCusto",
                HeaderText = "Total Custo",
                DataPropertyName = "ValorTotalCusto",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            // Valor Total Venda
            dgvEstoque.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ValorTotalVenda",
                HeaderText = "Total Venda",
                DataPropertyName = "ValorTotalVenda",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            // Lucro Total Produto
            dgvEstoque.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LucroTotalProduto",
                HeaderText = "Lucro Total",
                DataPropertyName = "LucroTotalProduto",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });
        }

        private void FrmRelatorioEstoque_Load(object sender, EventArgs e)
        {
            // Configura colunas e estilos
            ConfigurarGridEstoque();            
            var bll = new RelatorioEstoqueBLL();

            decimal totalCusto, totalVenda, totalLucro;
            dgvEstoque.DataSource = bll.ObterRelatorioEstoque(out totalCusto, out totalVenda, out totalLucro);

            txtTotalCusto.Text = totalCusto.ToString("N2");
            txtTotalVenda.Text = totalVenda.ToString("N2");
            txtTotalLucro.Text = totalLucro.ToString("N2");
        }

        private void dgvEstoque_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEstoque.Columns[e.ColumnIndex].Name == "Estoque")
            {
                int estoque = Convert.ToInt32(e.Value);

                if (estoque <= 2)
                {
                    e.CellStyle.BackColor = Color.LightCoral;
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
                if (estoque >= 3)
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
