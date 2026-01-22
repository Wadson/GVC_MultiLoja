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
    public partial class FrmConsultaMovimentacaoEstoque : KryptonForm
    {
        public FrmConsultaMovimentacaoEstoque()
        {
            InitializeComponent();
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
                    txtProdutoID.Text = pesquisaProduto.ProdutoID.ToString();
                    txtNomeProduto.SelectionStart = txtNomeProduto.Text.Length;
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultaMovimentacaoEstoque_Load(object sender, EventArgs e)
        {
            cmbOrigem.SelectedIndex = 0;
            cmbTipoMovimentacao.SelectedIndex = 0;
        }
      
        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            int? produtoId = string.IsNullOrWhiteSpace(txtProdutoID.Text)
       ? null
       : Convert.ToInt32(txtProdutoID.Text);

            string? tipo = cmbTipoMovimentacao.SelectedIndex <= 0
                ? null
                : cmbTipoMovimentacao.Text;

            string? origem = cmbOrigem.SelectedIndex <= 0
                ? null
                : cmbOrigem.Text;

            var dt = new MovimentacaoEstoqueBLL().ConsultarMovimentacoes(
                produtoId,
                tipo,
                origem,
                dtInicio.Value.Date,
                dtFim.Value.Date.AddDays(1)
            );

            dgvMovimentacoes.DataSource = dt;
        }
    }
}
