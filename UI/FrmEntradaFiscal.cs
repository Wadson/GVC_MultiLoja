using GVC.UTIL;
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
    public partial class FrmEntradaFiscal : KryptonForm
    {
        private bool bloqueiaPesquisa = false;
        private bool _ignorarEventosBusca = false;
        private bool _ignorandoBuscar = false;
        private int FornecedorID { get; set; }
        private int ProdutoID { get; set; }
        private string FornecedorSelecionado { get; set; }
        public FrmEntradaFiscal()
        {
            InitializeComponent();
        }

        private void FrmEntradaFiscal_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;
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
                        txtFornecedorID.Text = FornecedorID.ToString();
                        txtFornecedor.Text = pesquisaFornecedor.FornecedorSelecionado;
                    }
                    finally
                    {
                        _ignorandoBuscar = false;
                    }
                }
            }

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
                        ProdutoID = pesquisaProduto.ProdutoID;

                        txtProduto.Text = pesquisaProduto.ProdutoSelecionado;
                        txtReferencia.Text = pesquisaProduto.Referencia  + "-" + ProdutoID;
                        txtPrecoCusto.Text = pesquisaProduto.PrecoCusto
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
        }
    }
}
