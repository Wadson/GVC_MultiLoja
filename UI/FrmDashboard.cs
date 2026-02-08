using GVC.DAL;
using GVC.Infra.Repository;
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
    public partial class FrmDashboard : KryptonForm
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

            // 🔹 Configura títulos
            lblTituloTopProdutos.Text = "🔝 TOP 10 PRODUTOS MAIS LUCRATIVOS";
            lblTituloEstoqueBaixo.Text = "⚠️ PRODUTOS COM ESTOQUE BAIXO";
            var dal = new DashboardEstoqueRepository();

            // 🔹 Labels
            var resumo = dal.ObterResumo();
            lblTotalCusto.Text = resumo.custo.ToString("C2");
            lblTotalVenda.Text = resumo.venda.ToString("C2");
            lblTotalLucro.Text = resumo.lucro.ToString("C2");

            // 🔹 Top produtos
            ConfigurarGridTopProdutos();
            dgvTopProdutos.AutoGenerateColumns = false; // IMPORTANTE: Desativa geração automática
            dgvTopProdutos.DataSource = dal.ObterTopProdutosLucrativos(10);

            // 🔹 Estoque baixo
            ConfigurarGridEstoqueBaixo();
            dgvEstoqueBaixo.AutoGenerateColumns = false; // IMPORTANTE: Desativa geração automática
            dgvEstoqueBaixo.DataSource = dal.ObterEstoqueBaixo(5);
        }
        private void ConfigurarGridTopProdutos()
        {
            // Limpa colunas existentes
            dgvTopProdutos.Columns.Clear();

            // ProdutoID centralizado
            dgvTopProdutos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProdutoID",
                HeaderText = "ID",
                DataPropertyName = "ProdutoID",
                Width = 50,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvTopProdutos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NomeProduto",
                HeaderText = "Produto",
                DataPropertyName = "NomeProduto",
                Width = 450
            });

            // Estoque centralizado e verde
            dgvTopProdutos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estoque",
                HeaderText = "Estoque",
                DataPropertyName = "Estoque",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    ForeColor = Color.Green,
                    Font = new Font(dgvTopProdutos.Font, FontStyle.Bold)
                }
            });

            dgvTopProdutos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PrecoCusto",
                HeaderText = "Custo",
                DataPropertyName = "PrecoCusto",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvTopProdutos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PrecoDeVenda",
                HeaderText = "Venda",
                DataPropertyName = "PrecoDeVenda",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvTopProdutos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LucroUnitario",
                HeaderText = "Lucro Unit.",
                DataPropertyName = "LucroUnitario",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvTopProdutos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LucroTotal",
                HeaderText = "Lucro Total",
                DataPropertyName = "LucroTotal",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });
        }

        private void ConfigurarGridEstoqueBaixo()
        {
            // Limpa colunas existentes
            dgvEstoqueBaixo.Columns.Clear();

            // ProdutoID centralizado
            dgvEstoqueBaixo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProdutoID",
                HeaderText = "ID",
                DataPropertyName = "ProdutoID",
                Width = 50,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvEstoqueBaixo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NomeProduto",
                HeaderText = "Produto",
                DataPropertyName = "NomeProduto",
                Width = 450
            });

            // Estoque centralizado e vermelho
            dgvEstoqueBaixo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estoque",
                HeaderText = "Estoque",
                DataPropertyName = "Estoque",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    ForeColor = Color.Red,
                    Font = new Font(dgvEstoqueBaixo.Font, FontStyle.Bold)
                }
            });

            dgvEstoqueBaixo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Unidade",
                HeaderText = "Unidade",
                DataPropertyName = "Unidade",
                Width = 70
            });

            dgvEstoqueBaixo.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Marca",
                HeaderText = "Marca",
                DataPropertyName = "Marca",
                Width = 100
            });
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void ConfigurarGridTopProdutos()
        //{
        //    // Limpa colunas existentes
        //    dgvTopProdutos.Columns.Clear();

        //    // Adiciona colunas manualmente
        //    dgvTopProdutos.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "ProdutoID",
        //        HeaderText = "ID",
        //        DataPropertyName = "ProdutoID",
        //        Width = 50
        //    });

        //    dgvTopProdutos.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "NomeProduto",
        //        HeaderText = "Produto",
        //        DataPropertyName = "NomeProduto",
        //        Width = 200
        //    });

        //    dgvTopProdutos.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "Estoque",
        //        HeaderText = "Estoque",
        //        DataPropertyName = "Estoque",
        //        Width = 70
        //    });

        //    dgvTopProdutos.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "PrecoCusto",
        //        HeaderText = "Custo",
        //        DataPropertyName = "PrecoCusto",
        //        Width = 80,
        //        DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
        //    });

        //    dgvTopProdutos.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "PrecoDeVenda",
        //        HeaderText = "Venda",
        //        DataPropertyName = "PrecoDeVenda",
        //        Width = 80,
        //        DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
        //    });

        //    dgvTopProdutos.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "LucroUnitario",
        //        HeaderText = "Lucro Unit.",
        //        DataPropertyName = "LucroUnitario",
        //        Width = 90,
        //        DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
        //    });

        //    dgvTopProdutos.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "LucroTotal",
        //        HeaderText = "Lucro Total",
        //        DataPropertyName = "LucroTotal",
        //        Width = 90,
        //        DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
        //    });
        //}

        //private void ConfigurarGridEstoqueBaixo()
        //{
        //    // Limpa colunas existentes
        //    dgvEstoqueBaixo.Columns.Clear();

        //    // Adiciona colunas manualmente
        //    dgvEstoqueBaixo.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "ProdutoID",
        //        HeaderText = "ID",
        //        DataPropertyName = "ProdutoID",
        //        Width = 50
        //    });

        //    dgvEstoqueBaixo.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "NomeProduto",
        //        HeaderText = "Produto",
        //        DataPropertyName = "NomeProduto",
        //        Width = 200
        //    });

        //    dgvEstoqueBaixo.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "Estoque",
        //        HeaderText = "Estoque",
        //        DataPropertyName = "Estoque",
        //        Width = 70,
        //        DefaultCellStyle = new DataGridViewCellStyle
        //        {
        //            ForeColor = Color.Red,
        //            Font = new Font(dgvEstoqueBaixo.Font, FontStyle.Bold)
        //        }
        //    });

        //    dgvEstoqueBaixo.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "Unidade",
        //        HeaderText = "Unidade",
        //        DataPropertyName = "Unidade",
        //        Width = 70
        //    });

        //    dgvEstoqueBaixo.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "Marca",
        //        HeaderText = "Marca",
        //        DataPropertyName = "Marca",
        //        Width = 100
        //    });
        //}

    }
}
