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

        public FrmRelatorioProdutos()
        {
            InitializeComponent();
        }
        private void AtualizarEstadoFiltros()
        {
            bool usaPeriodo =
                rbLucroProduto.Checked || rbResumoGeral.Checked;

            dtpInicio.Enabled = usaPeriodo;
            dtpFim.Enabled = usaPeriodo;

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

            // ===============================
            // 1️⃣ LISTAGEM DE PRODUTOS
            // ===============================
            if (rbListagemProdutos.Checked)
            {
                var lista = bll.ObterProdutosEstoque();

                // Filtros visuais
                if (chkSomenteComEstoque.Checked)
                    lista = lista.Where(p => p.Estoque > 0).ToList();

                if (chkEstoqueBaixo.Checked)
                    lista = lista.Where(p => p.Estoque > 0 && p.Estoque <= 5).ToList();

                dgvProdutos.DataSource = lista;

                AtualizarCardsProdutos(lista);
            }

            // ===============================
            // 2️⃣ LUCRO POR PRODUTO
            // ===============================
            else if (rbLucroProduto.Checked)
            {
                var lista = bll.ObterLucroPorProduto(
                    dtpInicio.Value.Date,
                    dtpFim.Value.Date
                );

                dgvProdutos.DataSource = lista;

                AtualizarCardsLucro(lista);
            }

            // ===============================
            // 3️⃣ RESUMO GERAL
            // ===============================
            else if (rbResumoGeral.Checked)
            {
                var lista = bll.ObterLucroPorProduto(
                    dtpInicio.Value.Date,
                    dtpFim.Value.Date
                );

                dgvProdutos.DataSource = lista;

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
            if (_dadosRelatorio == null || !_dadosRelatorio.Any())
            {
                MessageBox.Show("Nenhum dado para gerar o relatório.");
                return;
            }

            using var sfd = new SaveFileDialog
            {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = "Relatorio_Produtos.pdf"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            var empresa = new EmpresaBll().ObterDadosParaPdf();

            PDFGenerator.GerarRelatorioProdutos(
                _dadosRelatorio,
                empresa,
                "Relatório de Produtos",
                sfd.FileName
            );
        }
    }
}
