using GVC.Infra.Repository;
using GVC.View;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GVC.UTIL
{
    public partial class FrmHistoricoProduto : KryptonForm
    {
        public int produtoID = 0;
        private bool _ignorarEventosBusca = false;
        private bool _ignorandoBuscar = false;
        public FrmHistoricoProduto()
        {
            InitializeComponent();
        }

        private void FormatarGrid()
        {
            dgvHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Configuração das colunas
            ConfigurarColuna("Quantidade", 60, "Qtd", DataGridViewContentAlignment.MiddleCenter);
            ConfigurarColuna("EstoqueAnterior", 90, "Estoque Ant.", DataGridViewContentAlignment.MiddleCenter);
            ConfigurarColuna("EstoqueAtual", 80, "Estoque Atual", DataGridViewContentAlignment.MiddleCenter);
            ConfigurarColuna("PrecoCompra", 90, "Preço Compra", DataGridViewContentAlignment.MiddleRight, "C2");
            ConfigurarColuna("PrecoCustoEntrada", 90, "Custo Entrada", DataGridViewContentAlignment.MiddleRight, "C2");
            ConfigurarColuna("DataMovimentacao", 120, "Data", DataGridViewContentAlignment.MiddleCenter);
            ConfigurarColuna("TipoMovimentacao", 100, "Tipo", DataGridViewContentAlignment.MiddleCenter);
            ConfigurarColuna("Documento", 100, "Documento");

            // Colunas que devem expandir
            dgvHistorico.Columns["Fornecedor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHistorico.Columns["Fornecedor"].FillWeight = 40;
            dgvHistorico.Columns["Fornecedor"].HeaderText = "Fornecedor";

            dgvHistorico.Columns["Usuario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHistorico.Columns["Usuario"].FillWeight = 30;
            dgvHistorico.Columns["Usuario"].HeaderText = "Usuário";

            // Configurações visuais adicionais
            dgvHistorico.RowTemplate.Height = 30;
            dgvHistorico.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            // Congela as primeiras colunas para facilitar navegação (opcional)
            dgvHistorico.Columns["DataMovimentacao"].Frozen = true;
        }

        private void ConfigurarColuna(string nomeColuna, int largura, string headerText,
                                      DataGridViewContentAlignment? alinhamento = null, string formato = "")
        {
            if (dgvHistorico.Columns.Contains(nomeColuna))
            {
                var coluna = dgvHistorico.Columns[nomeColuna];
                coluna.Width = largura;
                coluna.HeaderText = headerText;

                if (!string.IsNullOrEmpty(formato))
                    coluna.DefaultCellStyle.Format = formato;

                if (alinhamento.HasValue)
                {
                    coluna.DefaultCellStyle.Alignment = alinhamento.Value;
                    coluna.HeaderCell.Style.Alignment = alinhamento.Value;
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            // Se estamos ignorando eventos, sai imediatamente
            if (_ignorarEventosBusca || _ignorandoBuscar)
                return;

            var texto = txtProduto.Text.Trim();
            if (string.IsNullOrEmpty(texto))
                return;

            using (var pesquisaProduto = new FrmLocalizarProduto(texto))
            {
                // Calcula posição logo abaixo do TextBox
                var textBoxLocation = txtProduto.PointToScreen(Point.Empty);

                pesquisaProduto.StartPosition = FormStartPosition.Manual;
                pesquisaProduto.Location = new Point(
                    textBoxLocation.X,
                    textBoxLocation.Y + txtProduto.Height
                );

                // 🔑 Ajusta largura do formulário para acompanhar o TextBox
                pesquisaProduto.Width = txtProduto.Width;

                if (pesquisaProduto.ShowDialog() == DialogResult.OK)
                {
                    // Ativa flag para bloquear reentrância
                    _ignorandoBuscar = true;
                    try
                    {
                        produtoID = pesquisaProduto.ProdutoID;
                        txtProduto.Text = pesquisaProduto.ProdutoSelecionado;
                    }
                    finally
                    {
                        // Libera flag após atualização
                        _ignorandoBuscar = false;
                    }
                }
            }
            btnPesquisar.Select();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (produtoID == 0)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }

            try
            {
                using var repo = new EntradaFiscalRepository();

                var dt = repo.BuscarHistoricoProduto(
                    produtoID,
                    dtInicial.Value.Date,
                    dtFinal.Value.Date.AddDays(1).AddSeconds(-1),
                    cmbTipoMovimentacao.Text
                );

                dgvHistorico.DataSource = dt;

                FormatarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar histórico:\n" + ex.Message);
            }
        }

        private void FrmHistoricoProduto_Load(object sender, EventArgs e)
        {
            if (cmbTipoMovimentacao.Items.Count > 0)
            {
                cmbTipoMovimentacao.SelectedIndex = 0; // seleciona "Entrada"
            }
        }

        private void FrmHistoricoProduto_Shown(object sender, EventArgs e)
        {
            Utilitario.AplicarCorFocoNosTextBox(this);
        }

        private void FrmHistoricoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
