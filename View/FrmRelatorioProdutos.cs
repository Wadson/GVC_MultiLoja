using GVC.BLL;
using GVC.MODEL.Relatorios;
using GVC.UTIL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace GVC.View
{
    public partial class FrmRelatorioProdutos : KryptonForm
    {
        private List<RelatorioProdutoDTO> _dadosRelatorio = new();
        private IEnumerable<RelatorioProdutoEstoqueDTO>? _dadosEstoque;
        private IEnumerable<RelatorioLucroProdutoDTO>? _dadosLucro;

        public FrmRelatorioProdutos()
        {
            InitializeComponent();
        }
        public enum TipoRelatorioProduto
        {
            ListagemProdutos,
            LucroPorProduto,
            ResumoGeral
        }
        private void ConfigurarGridProdutos(TipoRelatorioProduto tipo)
        {
            // 🔒 Esconde tudo primeiro
            foreach (DataGridViewColumn col in dgvProdutos.Columns)
                col.Visible = false;

            // 🧭 Decide o layout
            switch (tipo)
            {
                case TipoRelatorioProduto.ListagemProdutos:
                    MostrarColunas(
                        "Codigo",
                        "Produto",
                        "Categoria",
                        "Quantidade",
                        "PrecoCusto",
                        "PrecoVenda"
                    );
                    break;

                case TipoRelatorioProduto.LucroPorProduto:
                    MostrarColunas(
                        "Codigo",
                        "Produto",
                        "Quantidade",
                        "PrecoVenda",
                        "LucroUnitario",
                        "LucroTotal"
                    );
                    break;

                case TipoRelatorioProduto.ResumoGeral:
                    MostrarColunas(
                        "Produto",
                        "Quantidade",
                        "CustoTotal",
                        "VendaTotal",
                        "LucroTotal"
                    );
                    break;
            }

            AjustarOrdemColunas();
        }
        private void AjustarOrdemColunas()
        {
            int ordem = 0;

            foreach (DataGridViewColumn col in dgvProdutos.Columns
                     .Cast<DataGridViewColumn>()
                     .Where(c => c.Visible))
            {
                col.DisplayIndex = ordem++;
            }
        }

        private void MostrarColunas(params string[] nomes)
        {
            int ordem = 0;

            foreach (var nome in nomes)
            {
                if (!dgvProdutos.Columns.Contains(nome))
                    continue;

                var col = dgvProdutos.Columns[nome];
                col.Visible = true;
                col.DisplayIndex = ordem++;
            }
        }

        private void ConfigurarGridResumoGeral()
        {
            foreach (DataGridViewColumn col in dgvProdutos.Columns)
                col.Visible = false;

            MostrarColunas(
                "Produto",
                "QuantidadeVendida",
                "VendaTotal",
                "LucroTotal"
            );
        }

        private void ConfigurarGridLucroProduto()
        {
            foreach (DataGridViewColumn col in dgvProdutos.Columns)
                col.Visible = false;

            MostrarColunas(
                "Produto",
                "QuantidadeVendida",
                "CustoTotal",
                "VendaTotal",
                "LucroTotal"
            );
        }

        private void ConfigurarGridListagemProdutos()
        {
            foreach (DataGridViewColumn col in dgvProdutos.Columns)
                col.Visible = false;

            MostrarColunas(
                "Codigo",
                "Produto",
                "Categoria",
                "Quantidade",
                "PrecoCusto",
                "PrecoVenda"
            );
        }

        private void AtualizarEstadoFiltros()
        {
            bool usaPeriodo =
                rbLucroProduto.Checked || rbResumoGeral.Checked;
            chkSomenteComEstoque.Enabled = rbListagemProdutos.Checked;
            chkEstoqueBaixo.Enabled = rbListagemProdutos.Checked;
        }
        private void TipoRelatorio_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarEstadoFiltros();
        }

        private void AtualizarCardsProdutos(List<RelatorioProdutoEstoqueDTO> lista)
        {
            lblTotalProdutos.Text = lista.Count.ToString();

            lblValorCusto.Text = lista
                .Sum(p => p.PrecoCusto * p.Estoque)
                .ToString("C2");

            lblValorVenda.Text = lista
                .Sum(p => p.PrecoVenda * p.Estoque)
                .ToString("C2");

            lblLucroTotal.Text = lista
                .Sum(p => p.LucroEstoque)
                .ToString("C2");
        }
        private void AtualizarCardsLucro(List<RelatorioLucroProdutoDTO> lista)
        {
            if (lista == null || lista.Count == 0)
            {
                lblTotalProdutos.Text = "0";
                lblValorCusto.Text = "R$ 0,00";
                lblValorVenda.Text = "R$ 0,00";
                lblLucroTotal.Text = "R$ 0,00";
                return;
            }

            lblTotalProdutos.Text = lista.Count.ToString();

            decimal totalCusto = lista.Sum(x => x.CustoTotal);
            decimal totalVenda = lista.Sum(x => x.VendaTotal);
            decimal totalLucro = totalVenda - totalCusto;

            lblValorCusto.Text = totalCusto.ToString("C2");
            lblValorVenda.Text = totalVenda.ToString("C2");
            lblLucroTotal.Text = totalLucro.ToString("C2");
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var bll = new RelatorioProdutoBLL();
            dgvProdutos.DataSource = null;

            _dadosEstoque = null;
            _dadosLucro = null;

            // ===============================
            // LISTAGEM DE PRODUTOS
            // ===============================
            if (rbListagemProdutos.Checked)
            {
                var lista = bll.ObterProdutosEstoque();

                if (chkSomenteComEstoque.Checked)
                    lista = lista.Where(p => p.Estoque > 0).ToList();

                if (chkEstoqueBaixo.Checked)
                    lista = lista.Where(p => p.Estoque > 0 && p.Estoque <= 5).ToList();

                dgvProdutos.DataSource = lista;
                _dadosEstoque = lista;

                AtualizarCardsProdutos(lista);
            }
            // ===============================
            // LUCRO / RESUMO
            // ===============================
            else
            {
                var lista = bll.ObterLucroPorProduto(chkSomenteComEstoque.Checked);

                dgvProdutos.DataSource = lista;
                _dadosLucro = lista;

                AtualizarCardsLucro(lista);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum dado para exportar.");
                return;
            }

            using var sfd = new SaveFileDialog
            {
                Filter = "Excel (*.xlsx)|*.xlsx",
                FileName = "Relatorio_Produtos.xlsx"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            var tabela = ConverterGridParaDataTable(dgvProdutos);

            ExcelGenerator.Exportar(tabela, sfd.FileName);

            MessageBox.Show("Excel gerado com sucesso!");
        }
        private DataTable ConverterGridParaDataTable(DataGridView dgv)
        {
            var dt = new DataTable();

            foreach (DataGridViewColumn col in dgv.Columns)
                dt.Columns.Add(col.HeaderText);

            foreach (DataGridViewRow row in dgv.Rows)
            {
                var dr = dt.NewRow();
                for (int i = 0; i < dgv.Columns.Count; i++)
                    dr[i] = row.Cells[i].Value;
                dt.Rows.Add(dr);
            }

            return dt;
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog
            {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = "Relatorio_Produtos.pdf"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            var empresa = new EmpresaBll().ObterDadosParaPdf();

            // ===============================
            // LISTAGEM DE PRODUTOS
            // ===============================
            if (rbListagemProdutos.Checked)
            {
                if (_dadosEstoque == null || !_dadosEstoque.Any())
                {
                    MessageBox.Show("Nenhum dado para gerar o relatório.");
                    return;
                }

                PDFGenerator.GerarRelatorioProdutosEstoque(
                    _dadosEstoque.ToList(),
                    empresa,
                    sfd.FileName);
            }
            // ===============================
            // LUCRO / RESUMO
            // ===============================
            else
            {
                if (_dadosLucro == null || !_dadosLucro.Any())
                {
                    MessageBox.Show("Nenhum dado para gerar o relatório.");
                    return;
                }

                PDFGenerator.GerarRelatorioLucroProduto(_dadosLucro.ToList(),
                    empresa,
                    sfd.FileName);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
