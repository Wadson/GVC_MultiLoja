using GVC.Infra.Repository;
using GVC.UTIL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GVC.View
{
    public partial class FrmEntradaFiscal : KryptonForm
    {
        private bool bloqueiaPesquisa = false;
        private bool _ignorarEventosBusca = false;
        private bool _ignorandoBuscar = false;
        private int FornecedorID { get; set; }
        private int produtoID { get; set; }
        private string FornecedorSelecionado { get; set; }
        public FrmEntradaFiscal()
        {
            InitializeComponent();
            this.KeyPreview = true; // Adicione esta linha
        }

        private void FrmEntradaFiscal_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;
            InicializarDatagridView();
            cmbTipoDocumento.SelectedIndex = 2;
            cmbTipoEntrada.SelectedIndex = 0;
        }

        private void btnVerControlesDoForm_Click(object sender, EventArgs e)
        {
            string caminhoArquivo = Path.Combine(Application.StartupPath, "ControlesForm.txt");

            using (StreamWriter sw = new StreamWriter(caminhoArquivo, false))
            {
                foreach (Control ctrl in this.Controls)
                {
                    ListarControleRecursivo(ctrl, sw);
                }
            }

            MessageBox.Show("Lista de controles salva em: " + caminhoArquivo);
        }
        private void ListarControleRecursivo(Control ctrl, StreamWriter sw)
        {
            // Escreve o tipo e o nome do controle
            sw.WriteLine($"{ctrl.GetType().Name} - {ctrl.Name}");

            // Se o controle tiver filhos (ex.: GroupBox, Panel, TabControl), percorre recursivamente
            foreach (Control child in ctrl.Controls)
            {
                ListarControleRecursivo(child, sw);
            }
        }

        private void txtFornecedor_TextChanged(object sender, EventArgs e)
        {
            if (_ignorarEventosBusca || _ignorandoBuscar)
                return;

            var texto = txtFornecedor.Text.Trim();
            if (string.IsNullOrEmpty(texto))
                return;

            using (var pesquisaFornecedor = new FrmLocalizarFornecedor(texto)) // ← remove "this"
            {
                // posição abaixo do textbox
                var textBoxLocation = txtFornecedor.PointToScreen(Point.Empty);

                pesquisaFornecedor.StartPosition = FormStartPosition.Manual;
                pesquisaFornecedor.Location = new Point(
                    textBoxLocation.X,
                    textBoxLocation.Y + txtFornecedor.Height
                );

                pesquisaFornecedor.Width = txtFornecedor.Width;

                if (pesquisaFornecedor.ShowDialog() == DialogResult.OK)
                {
                    _ignorandoBuscar = true;
                    try
                    {
                        FornecedorID = pesquisaFornecedor.FornecedorID;
                        txtFornecedor.Text = pesquisaFornecedor.FornecedorSelecionado;
                    }
                    finally
                    {
                        _ignorandoBuscar = false;
                    }
                }
            }
            txtProduto.Select();

        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            // Se estamos ignorando eventos, sai imediatamente
            if (_ignorarEventosBusca || _ignorandoBuscar)
                return;

            var texto = txtProduto.Text.Trim();
            if (string.IsNullOrEmpty(texto))
                return;

            using (var pesquisaProduto = new FrmLocalizarProdutos(texto))
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
                        txtPrecoCompra.Text = pesquisaProduto.PrecoCusto
                            .ToString("F2");
                    }
                    finally
                    {
                        // Libera flag após atualização
                        _ignorandoBuscar = false;
                        // Aqui pode colocar próximo campo para focar, se necessário
                    }
                }
            }
            txtQuantidade.Select();
        }

        private void FrmEntradaFiscal_Shown(object sender, EventArgs e)
        {
            Utilitario.AplicarCorFocoNosTextBox(this);
        }

        private void FrmEntradaFiscal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dgvItensDocumento.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum item para confirmar.");
                return;
            }

            try
            {
                using var repo = new EntradaFiscalRepository();

                foreach (DataGridViewRow row in dgvItensDocumento.Rows)
                {
                    if (row.IsNewRow) continue;

                    int produtoID = Convert.ToInt32(row.Cells["ProdutoID"].Value);
                    int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);
                    decimal precoCompra = Convert.ToDecimal(row.Cells["PrecoCompra"].Value);
                    decimal precoCusto = Convert.ToDecimal(row.Cells["PrecoCusto"].Value);

                    repo.ConfirmarEntrada(
                        produtoID,
                        quantidade,
                        precoCompra,
                        precoCusto,
                        cmbTipoEntrada.Text,
                        txtNumeroDocumento.Text,
                        "Entrada via formulário fiscal",
                        Sessao.NomeUsuario ?? "Sistema"

                    );
                }

                MessageBox.Show("Entrada confirmada com sucesso!");
                dgvItensDocumento.Rows.Clear();
                AtualizarTotais();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao confirmar entrada:\n" + ex.Message);
            }
        }
        private void AtualizarTotais()
        {
            decimal totalNota = 0;
            int totalItens = 0;

            foreach (DataGridViewRow row in dgvItensDocumento.Rows)
            {
                if (row.IsNewRow) continue;

                totalNota += Convert.ToDecimal(row.Cells["Total"].Value);
                totalItens += Convert.ToInt32(row.Cells["Quantidade"].Value);
            }

            lblTotal.Text = totalNota.ToString("N2");
            lblTotalItens.Text = totalItens.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void InicializarDatagridView()
        {
            dgvItensDocumento.Columns.Clear();

            dgvItensDocumento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvItensDocumento.AllowUserToAddRows = false;

            // 🔹 Coluna oculta
            dgvItensDocumento.Columns.Add("ProdutoID", "ProdutoID");
            dgvItensDocumento.Columns["ProdutoID"].Visible = false;

            // 🔹 Produto (DINÂMICA)
            var colProduto = new DataGridViewTextBoxColumn();
            colProduto.Name = "Produto";
            colProduto.HeaderText = "Produto";
            colProduto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // 🔥 AQUI É O SEGREDO
            dgvItensDocumento.Columns.Add(colProduto);

            // 🔹 Quantidade (fixa)
            var colQuantidade = new DataGridViewTextBoxColumn();
            colQuantidade.Name = "Quantidade";
            colQuantidade.HeaderText = "Qtd";
            colQuantidade.Width = 80;
            colQuantidade.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvItensDocumento.Columns.Add(colQuantidade);

            // 🔹 Preço Custo (fixa)
            var colPrecoCusto = new DataGridViewTextBoxColumn();
            colPrecoCusto.Name = "PrecoCusto";
            colPrecoCusto.HeaderText = "Preço Custo";
            colPrecoCusto.Width = 110;
            colPrecoCusto.DefaultCellStyle.Format = "N2";
            colPrecoCusto.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvItensDocumento.Columns.Add(colPrecoCusto);

            // 🔹 Total (fixa)
            var colTotal = new DataGridViewTextBoxColumn();
            colTotal.Name = "Total";
            colTotal.HeaderText = "Total";
            colTotal.Width = 120;
            colTotal.DefaultCellStyle.Format = "N2";
            colTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvItensDocumento.Columns.Add(colTotal);
        }
        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantidade.Text) || string.IsNullOrEmpty(txtPrecoCusto.Text))
            {
                MessageBox.Show("Preencha quantidade e preço.");
                return;
            }

            if (!int.TryParse(txtQuantidade.Text, out int quantidade))
            {
                MessageBox.Show("Quantidade inválida.");
                return;
            }

            // Limpa e converte o valor para decimal
            if (!decimal.TryParse(txtPrecoCusto.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal precoCusto))
            {
                MessageBox.Show("Preço de custo inválido.");
                return;
            }

            decimal total = quantidade * precoCusto;

            // Adiciona no DataGridView apenas valores numéricos (sem formatação)
            dgvItensDocumento.Rows.Add(
                produtoID,          // ID oculto
                txtProduto.Text,    // Nome do produto
                quantidade,         // int
                precoCusto,         // decimal puro
                total               // decimal puro
            );

            AtualizarTotais();
            Utilitario.LimparCampos(this);
        }
             

        private void txtPrecoCusto_Enter(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrecoCusto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal valor))
            {
                txtPrecoCusto.Text = valor.ToString("N2"); // apenas número com 2 casas
            }
        }

        private void txtPrecoCusto_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrecoCusto.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal valor))
            {
                txtPrecoCusto.Text = valor.ToString("C2"); // formato monetário (R$ 0,00)
            }
        }

        private void txtPrecoCompra_Enter(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrecoCompra.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal valor))
            {
                txtPrecoCompra.Text = valor.ToString("N2");
            }
        }

        private void txtPrecoCompra_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrecoCompra.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal valor))
            {
                txtPrecoCompra.Text = valor.ToString("C2");
            }
        }
    }
}
