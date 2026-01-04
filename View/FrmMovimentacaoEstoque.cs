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
        public int ProdutoID { get; set; }
        public FrmMovimentacaoEstoque()
        {
            InitializeComponent();
        }

        private void btnListarControlesDoForm_Click(object sender, EventArgs e)
        {
            // Caminho onde o arquivo será salvo
            string caminho = @"D:\ControlesFormFrmMovimentoFinanceiro.txt";

            FrmBaixarParcela.SalvarNomesControles(this, caminho);

            Utilitario.Mensagens.Aviso("Lista de controles salva em: " + caminho);
        }

        private void FrmMovimentacaoEstoque_Load(object sender, EventArgs e)
        {
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
        }
        private void ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtProdutoID.Text))
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
            txtProdutoID.Clear();
            txtNomeProduto.Clear();
            txtObservacao.Clear();
            numQuantidade.Value = 1;
            lblEstoqueAtual.Text = "0";
            cmbTipoMovimentacao.SelectedIndex = 0;
            cmbOrigem.SelectedIndex = 0;
        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            // SALVA O TEXTO ATUAL ANTES DE PERDER O FOCO
            string textoDigitado = txtNomeProduto.Text;

            using (var pesquisaProduto = new FrmLocalizarProduto(this, textoDigitado))
            {
                pesquisaProduto.Owner = this;

                if (pesquisaProduto.ShowDialog() == DialogResult.OK)
                {
                    txtNomeProduto.Text = pesquisaProduto.ProdutoSelecionado;
                    lblEstoqueAtual.Text = pesquisaProduto.Estoque.ToString("N2");
                    ProdutoID = pesquisaProduto.ProdutoID;
                    txtNomeProduto.SelectionStart = txtNomeProduto.Text.Length;
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarFormulario();

                var mov = new MovimentacaoEstoqueModel
                {
                    ProdutoID = Convert.ToInt32(txtProdutoID.Text),
                    TipoMovimentacao = cmbTipoMovimentacao.Text,
                    Quantidade = (int)numQuantidade.Value,
                    Origem = cmbOrigem.Text,
                    Documento = null, // pode ligar depois
                    Observacao = txtObservacao.Text,
                    Usuario = Environment.UserName
                };

                new EstoqueBLL().MovimentarEstoque(mov);

                Utilitario.Mensagens.Aviso("Movimentação realizada com sucesso!");

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
    }
}
