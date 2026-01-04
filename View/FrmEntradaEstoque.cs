using GVC.BLL;
using GVC.DAL;
using GVC.DAL;
using GVC.Model;
using GVC.UTIL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace GVC.View
{
    public partial class FrmEntradaEstoque : KryptonForm
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string produtoSelecionado { get; set; }
        public FrmEntradaEstoque()
        {
            InitializeComponent();
            // Utiliza a classe Utilitario para adicionar os efeitos de foco a todos os TextBoxes no formulário
            Utilitario.AdicionarEfeitoFocoEmTodos(this);
        }
              
        private void AbrirFrmLocalizarProduto()
        {
            FrmLocalizarProduto frmLocalizarProduto = new FrmLocalizarProduto(this, txtNomeProduto.Text)
            {
                Owner = this,
                ProdutoSelecionado = txtNomeProduto.Text
            };
            frmLocalizarProduto.ShowDialog();
            frmLocalizarProduto.Text = "Localizar Produtos";
        }
        private void CalcularLucro()
        {
            if (txtPrecoCusto.Text != "" && txtPrecoDeVenda.Text != "")
            {
                decimal precoCusto = Convert.ToDecimal(txtPrecoCusto.Text);
                decimal precoVenda = Convert.ToDecimal(txtPrecoDeVenda.Text);
                decimal lucro = precoVenda - precoCusto;
                txtLucro.Text = lucro.ToString("N2");
            }
        }
        private void LocalizarProduto()
        {
            // Cria uma instância do FrmLocalizarProduto e define o Owner como o FrmVendas
            FrmLocalizarProduto frmLocalizarProduto = new FrmLocalizarProduto(this, txtNomeProduto.Text)
            {
                Owner = this,
                ProdutoSelecionado = txtNomeProduto.Text
            };
            frmLocalizarProduto.ShowDialog();
            frmLocalizarProduto.Text = "Localizar Produtos";
        }

        private void btnLocalizarProduto_Click(object sender, EventArgs e)
        {
            AbrirFrmLocalizarProduto();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            // Validações
            if (string.IsNullOrWhiteSpace(txtNomeProduto.Text))
            {
                Utilitario.Mensagens.Aviso("O nome do produto é obrigatório.");
                txtNomeProduto.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecoCusto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal precoCusto))
            {
                Utilitario.Mensagens.Aviso("Preço de custo inválido.");
                return;
            }

            if (!decimal.TryParse(txtPrecoDeVenda.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal precoVenda))
            {
                Utilitario.Mensagens.Aviso("Preço de venda inválido.");
                return;
            }

            if (!int.TryParse(txtQuantidade.Text, out int estoque))
            {
                Utilitario.Mensagens.Aviso("Estoque inválido.");
                return;
            }

            try
            {
                // Monta o objeto completo
                var produto = new ProdutoModel
                {
                    ProdutoID = int.Parse(txtProdutoID.Text),
                    NomeProduto = txtNomeProduto.Text.Trim(),
                    Referencia = txtReferencia.Text.Trim(),
                    PrecoCusto = precoCusto,
                    Lucro = precoVenda - precoCusto,
                    PrecoDeVenda = precoVenda,
                    Estoque = estoque,
                    DataDeEntrada = dtpDataDeEntrada.Value.Date,
                    Status = "Ativo", // ou pegue do ComboBox                   
                };

                ProdutosBLL bll = new ProdutosBLL();
                bool sucesso = bll.Alterar(produto); // ← Agora passa o objeto inteiro

                if (sucesso)
                {
                    Utilitario.Mensagens.Info("Entrada de estoque registrada com sucesso!");

                    // Atualiza a lista principal
                    var frmManut = Application.OpenForms["FrmManutProduto"] as FrmManutProduto;
                    frmManut?.HabilitarTimer(true);

                    Utilitario.LimparCampos(this);
                    txtReferencia.Focus();
                }
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso("Erro ao salvar: " + ex.Message);
            }
        }

       
        private void FrmEntradaEstoque_Load(object sender, EventArgs e)
        {
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Utilitario.LimparCampos(this);
            txtNomeProduto.Focus();
        }

        private void txtReferencia_Leave(object sender, EventArgs e)
        {
            Utilitario.PesquisarProdutoPorReferencia(
            referencia: txtReferencia.Text.Trim(),
            txtReferencia: txtReferencia,
            txtNomeProduto: txtNomeProduto,
            txtProdutoID: txtProdutoID,
            txtPrecoVenda: txtPrecoDeVenda  // opcional
             );

            // Foco no próximo campo
            if (!string.IsNullOrEmpty(txtProdutoID.Text))
                txtQuantidade.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
