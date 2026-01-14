using GVC.BLL;
using GVC.Model;
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
    public partial class FrmMovimentacaoEstoque : KryptonForm
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ProdutoID { get; set; }
        private bool _ignorandoBuscar = false;
        private bool _ignorarEventosBusca = false;
        public FrmMovimentacaoEstoque()
        {
            InitializeComponent();
        }
        private void ConfigurarHeader()
        {
            pnlHeader.StateCommon.Color1 = Color.FromArgb(30, 136, 229); // Azul ERP
            pnlHeader.StateCommon.Color2 = Color.FromArgb(30, 136, 229);

            lblTitulo.Text = "Movimentação de Estoque";
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Font =
                new Font("Segoe UI", 13, FontStyle.Bold);

            lblSubTitulo.Text = "Entrada, saída ou ajuste manual de produtos";
            lblSubTitulo.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Font =
                new Font("Segoe UI", 9);
        }
        private void EstilizarCard(GroupBox grupo)
        {
            grupo.BackColor = Color.White;
            grupo.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Rectangle rect = grupo.ClientRectangle;
                rect.Inflate(-1, -1);

                using (var pen = new Pen(Color.Gainsboro, 1))
                using (var brush = new SolidBrush(grupo.BackColor))
                {
                    var path = RoundedRect(rect, 8); // raio 8
                    g.FillPath(brush, path);
                    g.DrawPath(pen, path);
                }
            };
        }

        // Função auxiliar para criar retângulo arredondado
        private System.Drawing.Drawing2D.GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int d = radius * 2;
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }


        private void btnListarControlesDoForm_Click(object sender, EventArgs e)
        {
            // Caminho onde o arquivo será salvo
            string caminho = @"D:\ControlesFormFrmMovimentoFinanceiro.txt";

            FrmBaixarParcela.SalvarNomesControles(this, caminho);

            Utilitario.Mensagens.Info("Lista de controles salva em: " + caminho);
        }
        private void AtualizarEstoqueVisual(int estoque)
        {
            lblEstoqueAtual.Text = estoque.ToString();

            lblEstoqueAtual.StateCommon.ShortText.Font =
                new Font("Segoe UI", 11, FontStyle.Bold);

            if (estoque > 0)
                lblEstoqueAtual.StateCommon.ShortText.Color1 = Color.ForestGreen;
            else
                lblEstoqueAtual.StateCommon.ShortText.Color1 = Color.Firebrick;
        }

        private void FrmMovimentacaoEstoque_Load(object sender, EventArgs e)
        {
            EstilizarCard(grpProduto);
            EstilizarCard(grpMovimentacao);

            ConfigurarHeader();
            // Tipo de movimentação
            cmbTipoMovimentacao.Items.Clear();
            cmbTipoMovimentacao.Items.Add("Entrada");
            cmbTipoMovimentacao.Items.Add("Saida");
            cmbTipoMovimentacao.Items.Add("Ajuste");
            cmbTipoMovimentacao.SelectedIndex = 0;

            // Origem
            cmbOrigem.Items.Clear();
            cmbOrigem.Items.Add("NF-e");
            cmbOrigem.Items.Add("Cupom Fiscal");
            cmbOrigem.Items.Add("Cupom Não Fiscal");
            cmbOrigem.Items.Add("Venda");
            cmbOrigem.Items.Add("Ajuste Manual");
            cmbOrigem.SelectedIndex = 0;

            numQuantidade.Minimum = 0;
            numQuantidade.Value = 1;

            // 🔹 AQUI
            txtProdutoBuscar.CueHint.CueHintText =
                "Digite o nome ou código do produto...";
        }
        private void ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(lblIdProduto.Text))
                throw new Exception("Selecione um produto.");

            if (cmbTipoMovimentacao.SelectedIndex < 0)
                throw new Exception("Selecione o tipo de movimentação.");

            if (cmbOrigem.SelectedIndex < 0)
                throw new Exception("Selecione a origem da movimentação.");

            if (numQuantidade.Value <= 0)
                throw new Exception("Quantidade inválida.");
        }
        private void LimparFormulario()
        {
            lblIdProduto.Text = "0";
            txtProdutoBuscar.Clear();
            txtObservacao.Clear();
            numQuantidade.Value = 1;
            lblEstoqueAtual.Text = "0";
            cmbTipoMovimentacao.SelectedIndex = 0;
            cmbOrigem.SelectedIndex = 0;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarFormulario();

                var mov = new MovimentacaoEstoqueModel
                {
                    ProdutoID = Convert.ToInt32(lblIdProduto.Text),
                    TipoMovimentacao = cmbTipoMovimentacao.Text,
                    Quantidade = (int)numQuantidade.Value,
                    Origem = cmbOrigem.Text,
                    Documento = null, // pode ligar depois
                    Observacao = txtObservacao.Text,
                    Usuario = Environment.UserName
                };

                new EstoqueBLL().MovimentarEstoque(mov);

                Utilitario.Mensagens.Info("Movimentação realizada com sucesso!");

                LimparFormulario();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso(ex.Message);
            }
        }

        private void bnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProdutoBuscar_TextChanged(object sender, EventArgs e)
        {
            // Se estamos ignorando eventos, sai imediatamente
            if (_ignorarEventosBusca || _ignorandoBuscar)
                return;

            var texto = txtProdutoBuscar.Text.Trim();
            if (string.IsNullOrEmpty(texto))
                return;

            using (var pesquisaProduto = new FrmLocalizarProduto(this, texto))
            {
                // Calcula posição logo abaixo do TextBox
                var textBoxLocation = txtProdutoBuscar.PointToScreen(Point.Empty);

                pesquisaProduto.StartPosition = FormStartPosition.Manual;
                pesquisaProduto.Location = new Point(
                    textBoxLocation.X,
                    textBoxLocation.Y + txtProdutoBuscar.Height
                );

                // 🔑 Ajusta largura do formulário para acompanhar o TextBox
                pesquisaProduto.Width = txtProdutoBuscar.Width;

                if (pesquisaProduto.ShowDialog() == DialogResult.OK)
                {
                    _ignorandoBuscar = true;
                    try
                    {
                        txtProdutoBuscar.Text = pesquisaProduto.ProdutoSelecionado;

                        ProdutoID = pesquisaProduto.ProdutoID;
                        lblIdProduto.Text = ProdutoID.ToString();

                        // 🔹 AQUI
                        AtualizarEstoqueVisual((int)pesquisaProduto.Estoque);

                        txtProdutoBuscar.SelectionStart = txtProdutoBuscar.Text.Length;
                    }
                    finally
                    {
                        _ignorandoBuscar = false;
                        cmbTipoMovimentacao.Select();
                    }
                }

            }
        }

        private void txtProdutoBuscar_Enter(object sender, EventArgs e)
        {
            txtProdutoBuscar.SelectAll();
        }

    }
}
