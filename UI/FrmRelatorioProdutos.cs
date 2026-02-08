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

        private IEnumerable<RelatorioProdutoEstoqueDTO>? _dadosEstoque;
        private IEnumerable<RelatorioLucroProdutoDTO>? _dadosLucro;
        private DateTime _cacheEstoqueTime;
        private DateTime _cacheLucroTime;

        private const int CACHE_MINUTOS = 5;

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
        private void AtualizarCardsPorTipoRelatorio()
        {
            if (rbListagemProdutos.Checked)
                MostrarCardsProdutos();
            else
                MostrarCardsLucro();
        }

        private void MostrarCardsProdutos()
        {
            if (_dadosEstoque == null) return;

            var lista = _dadosEstoque.ToList();

            lblCard1Titulo.Text = "Total de Produtos";
            lblCard2Titulo.Text = "Qtd. em Estoque";
            lblCard3Titulo.Text = "Valor de Custo";
            lblCard4Titulo.Text = "Valor de Venda";

            lblCard1Valor.Text = lista.Count.ToString();
            lblCard2Valor.Text = lista.Sum(x => x.Estoque).ToString();
            lblCard3Valor.Text = lista.Sum(x => x.Estoque * x.PrecoCusto).ToString("C2");
            lblCard4Valor.Text = lista.Sum(x => x.Estoque * x.PrecoVenda).ToString("C2");

            pnlCard4.Visible = true;

            SetIcon(iconPictureBox1, FontAwesome.Sharp.IconChar.Box, Color.SteelBlue);
            SetIcon(iconPictureBox2, FontAwesome.Sharp.IconChar.Boxes, Color.DarkOrange);
            SetIcon(iconPictureBox3, FontAwesome.Sharp.IconChar.Coins, Color.Gray);
            SetIcon(iconPictureBox4, FontAwesome.Sharp.IconChar.DollarSign, Color.ForestGreen);

        }


        private void MostrarCardsLucro()
        {
            if (_dadosLucro == null || !_dadosLucro.Any())
                return;


            decimal venda = _dadosLucro.Sum(x => x.VendaTotal);
            decimal custo = _dadosLucro.Sum(x => x.CustoTotal);
            decimal lucro = _dadosLucro.Sum(x => x.LucroTotal);

            SetCard(lblCard1Titulo, lblCard1Valor, "Venda Total", venda);
            SetCard(lblCard2Titulo, lblCard2Valor, "Custo Total", custo);
            SetCard(lblCard3Titulo, lblCard3Valor, "Lucro Total", lucro);


            pnlCard4.Visible = false;

            SetIcon(iconPictureBox1, FontAwesome.Sharp.IconChar.ChartLine, Color.SteelBlue);
            SetIcon(iconPictureBox2, FontAwesome.Sharp.IconChar.Coins, Color.DarkOrange);
            SetIcon(iconPictureBox3, FontAwesome.Sharp.IconChar.MoneyBillWave, Color.ForestGreen);
            iconPictureBox4.Visible = false;

        }

        private void MostrarCardsResumo()
        {
            lblCard1Titulo.Text = "Venda Geral";
            lblCard2Titulo.Text = "Custo Geral";
            lblCard3Titulo.Text = "Lucro Geral";
            lblCard4Titulo.Text = "";

            var lista = (List<RelatorioLucroProdutoDTO>)_dadosLucro;

            decimal venda = lista.Sum(x => x.VendaTotal);
            decimal custo = lista.Sum(x => x.CustoTotal);
            decimal lucro = lista.Sum(x => x.LucroTotal);

            lblCard1Valor.Text = venda.ToString("C2");
            lblCard2Valor.Text = custo.ToString("C2");
            lblCard3Valor.Text = lucro.ToString("C2");

            OcultarCard4();
        }
        private void MostrarTodosCards()
        {
            pnlCard4.Visible = true;
        }

        private void OcultarCard4()
        {
            pnlCard4.Visible = false;
        }
        private void SetCard(KryptonLabel titulo, KryptonLabel valor, string texto, decimal numero)
        {
            titulo.Text = texto;
            valor.Text = numero.ToString("C2");

            if (texto.Contains("Lucro"))
                valor.ForeColor = numero >= 0 ? Color.ForestGreen : Color.DarkRed;
            else if (texto.Contains("Custo"))
                valor.ForeColor = Color.DarkOrange;
            else
                valor.ForeColor = Color.SteelBlue;
        }

        private void AtualizarEstadoFiltrosRelatorio()
        {
            bool isListagem = rbListagemProdutos.Checked;

            chkSomenteComEstoque.Enabled = isListagem;
            chkEstoqueBaixo.Enabled = isListagem;

            if (!isListagem)
            {
                chkSomenteComEstoque.Checked = false;
                chkEstoqueBaixo.Checked = false;
            }
        }
        private void AjustarColunaFixa(
    string nome,
    int largura,
    DataGridViewContentAlignment alinhamento,
    string formato = null)
        {
            if (!dgvProdutos.Columns.Contains(nome))
                return;

            var col = dgvProdutos.Columns[nome];

            col.Visible = true;
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col.Width = largura;
            col.MinimumWidth = largura;
            col.DefaultCellStyle.Alignment = alinhamento;

            if (!string.IsNullOrEmpty(formato))
                col.DefaultCellStyle.Format = formato;
        }

        private void AjustarColunaProdutoFill(string nomeColuna)
        {
            if (!dgvProdutos.Columns.Contains(nomeColuna))
                return;

            var col = dgvProdutos.Columns[nomeColuna];

            col.Visible = true;
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col.FillWeight = 100; // ocupa todo espaço restante
            col.MinimumWidth = 250;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void ConfigurarGridBase()
        {
            dgvProdutos.AutoGenerateColumns = true;

            // 🔴 IMPORTANTE
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvProdutos.EnableHeadersVisualStyles = false;
            dgvProdutos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 246, 248);
            dgvProdutos.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvProdutos.DefaultCellStyle.Font =
                new Font("Segoe UI", 9F);

            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.AllowUserToResizeRows = false;
            dgvProdutos.AllowUserToResizeColumns = false;
        }

        private void AjustarGridPorTipo()
        {
            foreach (DataGridViewColumn col in dgvProdutos.Columns)
                col.Visible = false;

            // 🔹 PRODUTO sempre dinâmico
            AjustarColunaProdutoFill("Produto");

            if (rbListagemProdutos.Checked)
            {
                AjustarColunaFixa("Estoque", 90, DataGridViewContentAlignment.MiddleCenter);
                AjustarColunaFixa("PrecoCusto", 120, DataGridViewContentAlignment.MiddleRight, "C2");
                AjustarColunaFixa("PrecoVenda", 120, DataGridViewContentAlignment.MiddleRight, "C2");
                AjustarColunaFixa("LucroEstoque", 130, DataGridViewContentAlignment.MiddleRight, "C2");
            }
            else
            {
                AjustarColunaFixa("QuantidadeVendida", 130, DataGridViewContentAlignment.MiddleCenter);
                AjustarColunaFixa("CustoTotal", 130, DataGridViewContentAlignment.MiddleRight, "C2");
                AjustarColunaFixa("VendaTotal", 130, DataGridViewContentAlignment.MiddleRight, "C2");
                AjustarColunaFixa("LucroTotal", 130, DataGridViewContentAlignment.MiddleRight, "C2");
            }
        }

        private void AjustarColuna(
    string nome,
    int largura,
    DataGridViewContentAlignment alinhamento,
    string formato = null)
        {
            if (!dgvProdutos.Columns.Contains(nome))
                return;

            var col = dgvProdutos.Columns[nome];
            col.Visible = true;
            col.Width = largura;
            col.DefaultCellStyle.Alignment = alinhamento;

            if (!string.IsNullOrEmpty(formato))
                col.DefaultCellStyle.Format = formato;
        }
        private void SetIcon(
    FontAwesome.Sharp.IconPictureBox icon,
    FontAwesome.Sharp.IconChar iconChar,
    Color cor)
        {
            icon.IconChar = iconChar;
            icon.IconColor = cor;
            icon.IconSize = 32;
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
            lblCard1Valor.Text = lista.Count.ToString();

            lblCard2Valor.Text = lista
                .Sum(p => p.PrecoCusto * p.Estoque)
                .ToString("C2");

            lblCard3Valor.Text = lista
                .Sum(p => p.PrecoVenda * p.Estoque)
                .ToString("C2");

            lblCard4Valor.Text = lista
                .Sum(p => p.LucroEstoque)
                .ToString("C2");
        }
        private void AtualizarCardsLucro(List<RelatorioLucroProdutoDTO> lista)
        {
            if (lista == null || lista.Count == 0)
            {
                lblCard1Valor.Text = "0";
                lblCard2Valor.Text = "R$ 0,00";
                lblCard3Valor.Text = "R$ 0,00";
                lblCard4Valor.Text = "R$ 0,00";
                return;
            }

            lblCard1Valor.Text = lista.Count.ToString();

            decimal totalCusto = lista.Sum(x => x.CustoTotal);
            decimal totalVenda = lista.Sum(x => x.VendaTotal);
            decimal totalLucro = totalVenda - totalCusto;

            lblCard2Valor.Text = totalCusto.ToString("C2");
            lblCard3Valor.Text = totalVenda.ToString("C2");
            lblCard4Valor.Text = totalLucro.ToString("C2");
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


        private void rbListagemProdutos_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarEstadoFiltrosRelatorio();
            AtualizarCardsPorTipoRelatorio();

        }

        private void rbLucroProduto_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarEstadoFiltrosRelatorio();
            AtualizarCardsPorTipoRelatorio();

        }

        private void rbResumoGeral_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarEstadoFiltrosRelatorio();
            AtualizarCardsPorTipoRelatorio();

        }

        private void dgvProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var col = dgvProdutos.Columns[e.ColumnIndex].Name;

            // 🔴 Estoque baixo
            if (col == "Estoque" && e.Value != null &&
                int.TryParse(e.Value.ToString(), out int estoque))
            {
                if (estoque <= 5)
                    e.CellStyle.ForeColor = Color.DarkRed;
            }

            // 💰 Lucro
            if ((col == "LucroTotal" || col == "LucroEstoque") &&
                e.Value != null &&
                decimal.TryParse(e.Value.ToString(), out decimal lucro))
            {
                e.CellStyle.ForeColor =
                    lucro >= 0 ? Color.ForestGreen : Color.DarkRed;

                e.CellStyle.Font =
                    new Font(dgvProdutos.Font, FontStyle.Bold);
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog
            {
                Filter = "Excel (*.xlsx)|*.xlsx",
                FileName = "Relatorio_Produtos.xlsx"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            if (rbListagemProdutos.Checked)
                ExcelGenerator.ExportarProdutosEstoque(_dadosEstoque.ToList(), sfd.FileName);
            else
                ExcelGenerator.ExportarLucroProduto(_dadosLucro.ToList(), sfd.FileName);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var bll = new RelatorioProdutoBLL();
            dgvProdutos.DataSource = null;

            // ===============================
            // 📦 LISTAGEM DE PRODUTOS
            // ===============================
            if (rbListagemProdutos.Checked)
            {
                if (_dadosEstoque == null ||
                DateTime.Now.Subtract(_cacheEstoqueTime).TotalMinutes > CACHE_MINUTOS)
                {
                    _dadosEstoque = bll.ObterProdutosEstoque();
                    _cacheEstoqueTime = DateTime.Now;
                }


                if (chkSomenteComEstoque.Checked)
                    _dadosEstoque = _dadosEstoque.Where(p => p.Estoque > 0);

                if (chkEstoqueBaixo.Checked)
                    _dadosEstoque = _dadosEstoque.Where(p => p.Estoque > 0 && p.Estoque <= 5);

                dgvProdutos.DataSource = _dadosEstoque.ToList();
                MostrarCardsProdutos();
                AjustarGridPorTipo();
            }
            // ===============================
            // 💰 LUCRO / RESUMO
            // ===============================
            else
            {
                if (_dadosLucro == null ||
                DateTime.Now.Subtract(_cacheLucroTime).TotalMinutes > CACHE_MINUTOS)
                {
                    _dadosLucro = bll.ObterLucroPorProduto(null, null, false);
                    _cacheLucroTime = DateTime.Now;
                }

                dgvProdutos.DataSource = _dadosLucro.ToList();
                MostrarCardsLucro();
                AjustarGridPorTipo();
            }
        }

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog
            {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = "Relatorio_Produtos.pdf"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            var empresa = new EmpresaBll().ObterDadosParaPdf();

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
            else
            {
                if (_dadosLucro == null || !_dadosLucro.Any())
                {
                    MessageBox.Show("Nenhum dado para gerar o relatório.");
                    return;
                }

                PDFGenerator.GerarRelatorioLucroProduto(
                    _dadosLucro.ToList(),
                    empresa,
                    sfd.FileName);
            }
        }

        private void FrmRelatorioProdutos_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

        }
    }
}
