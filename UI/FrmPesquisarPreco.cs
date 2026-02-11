using GVC.BLL;
using GVC.DAL;
using GVC.DAL;
using GVC.UTIL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Windows.Forms;

namespace GVC.View
{
    public partial class FrmPesquisarPreco : KryptonForm
    {
        private string _ClienteID;
        protected int LinhaAtual = -1;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ProdutoID { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public decimal PrecoUnitario { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Unidade { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public decimal Estoque { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Marca { get; set; }
        private String referencia;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ProdutoSelecionado { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]


        public string Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Form FormChamador { get; set; }

        private bool _usuarioRedimensionando = false;

        public FrmPesquisarPreco()
        {
            InitializeComponent();

            txtPesquisar.Focus(); // Foca o campo para continuar digitando

            //Configurar o TextBox para capturar o evento KeyDown
            this.txtPesquisar.KeyDown += new KeyEventHandler(dataGridPesquisar_KeyDown);
            this.dataGridPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridPesquisar_KeyDown);

            // Configurar o DataGridView (apenas exemplo, configure conforme necessário)
            dataGridPesquisar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void PersonalizarDataGridView()
        {
            // 🔹 Não gerar colunas automaticamente
            dataGridPesquisar.AutoGenerateColumns = false;
            dataGridPesquisar.Columns.Clear();

            // 🔹 Código
            dataGridPesquisar.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Código",
                DataPropertyName = "ProdutoID",
                Width = 70
            });

            // 🔹 Referência
            dataGridPesquisar.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Referência",
                DataPropertyName = "Referencia",
                Width = 120
            });

            // 🔹 Produto (dinâmica)
            dataGridPesquisar.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Produto",
                DataPropertyName = "NomeProduto",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                MinimumWidth = 200,
                FillWeight = 1,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Segoe UI", 8f, FontStyle.Bold)
                }
            });

            // 🔹 Marca
            dataGridPesquisar.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Marca",
                DataPropertyName = "NomeMarca",
                Width = 150
            });

            // 🔹 Unidade
            dataGridPesquisar.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "UN",
                DataPropertyName = "Unidade",
                Width = 40
            });

            // 🔹 Preço de Venda
            dataGridPesquisar.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Preço Venda",
                DataPropertyName = "PrecoDeVenda",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Arial", 8F, FontStyle.Bold),
                    ForeColor = Color.DarkGreen,
                    BackColor = Color.LightYellow,
                    Format = "N2"
                }
            });

            // 🔹 Estoque
            dataGridPesquisar.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Estoque",
                DataPropertyName = "Estoque",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Segoe UI", 8f, FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            // ======================================================
            // 🔹 Ajustes gerais
            // ======================================================
            dataGridPesquisar.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridPesquisar.ColumnHeadersHeight = 25;
            dataGridPesquisar.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);
            dataGridPesquisar.ColumnHeadersDefaultCellStyle.WrapMode =
                DataGridViewTriState.False;

            dataGridPesquisar.RowHeadersVisible = false;
            dataGridPesquisar.AdvancedRowHeadersBorderStyle.All =
                DataGridViewAdvancedCellBorderStyle.None;

            dataGridPesquisar.DefaultCellStyle.Font =
                new Font("Segoe UI", 8);

            dataGridPesquisar.ScrollBars = ScrollBars.Vertical;
        }


        public new int ObterLinhaAtual()
        {
            return LinhaAtual;
        }

        public void ListarProduto()
        {
            ProdutosBLL bll = new();
            dataGridPesquisar.DataSource = bll.ListarTodos();
            PersonalizarDataGridView();
        }
        private void FrmLocalizarProduto_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

            ListarProduto();
            txtPesquisar.Focus();

            if (!string.IsNullOrEmpty(txtPesquisar.Text))
            {
                txtPesquisar.Select(txtPesquisar.Text.Length, 0);
            }
        }

        private void PesquisarProduto(string termo)
        {
            var bll = new ProdutosBLL();
            var produtos = bll.BuscarPorNome(termo);

            dataGridPesquisar.DataSource = produtos;
            PersonalizarDataGridView();

            if (produtos.Count == 0)
            {
                lblMensagem.Text = $"Nenhum produto encontrado para '{termo}'";
                lblMensagem.Visible = true;
                lblMensagem.ForeColor = Color.Red;
            }
            else
            {
                lblMensagem.Visible = false;
            }
        }


        private void dataGridPesquisar_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Enter:
                    // Enter no DataGridView: seleciona cliente
                    //SelecionarProduto(); // Chama seu método existente
                    e.Handled = true;
                    break;

                case Keys.Up:
                    // Tecla para cima na primeira linha: volta para o txtPesquisa
                    if (dataGridPesquisar.CurrentRow != null &&
                        dataGridPesquisar.CurrentRow.Index == 0)
                    {
                        txtPesquisar.Focus();
                        e.Handled = true;
                    }
                    break;

                case Keys.Down:
                    // Tecla para baixo na última linha: não faz nada especial
                    // O próprio DataGridView já trata a navegação
                    e.Handled = false; // Permite o comportamento padrão
                    break;

                case Keys.Escape:
                    this.Close();
                    e.Handled = true;
                    break;
            }

        }
        private void dataGridPesquisar_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridPesquisar.CurrentRow != null)
            {
                LinhaAtual = dataGridPesquisar.CurrentRow.Index;
            }
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dataGridPesquisar.Focus();
            }
        }
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string termo = txtPesquisar.Text.Trim();

                // 🔥 Se limpou o textbox → carrega TODOS os produtos
                if (string.IsNullOrWhiteSpace(termo))
                {
                    CarregarTodosProdutos();
                    lblMensagem.Visible = false;
                    return;
                }

                // Opcional: só pesquisar com 2+ caracteres
                if (termo.Length < 2)
                    return;

                PesquisarProduto(termo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarTodosProdutos()
        {
            var bll = new ProdutosBLL();
            var produtos = bll.ListarTodos(); // 🔥 Crie este método se não existir

            dataGridPesquisar.DataSource = produtos;
            PersonalizarDataGridView();
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dataGridPesquisar.Focus();
                if (dataGridPesquisar.Rows.Count > 0)
                {
                    dataGridPesquisar.CurrentCell = dataGridPesquisar.Rows[0].Cells[0];
                }
            }
        }

        private void btnSai_Click(object sender, EventArgs e)
        {
            // SE TEM ALGUMA LINHA SELECIONADA → carrega os dados antes de sair
            if (dataGridPesquisar.CurrentRow != null && dataGridPesquisar.CurrentRow.Index >= 0)
            {
                LinhaAtual = dataGridPesquisar.CurrentRow.Index;
                //SelecionarProduto(); // ← agora carrega mesmo clicando em Sair
                return; // sai com DialogResult.OK
            }

            // Se não tem nada selecionado → só fecha (sem carregar nada)
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmLocalizarProduto_Shown(object sender, EventArgs e)
        {
            txtPesquisar.Focus();
            // Em vez disso, posicione o cursor no final
            if (!string.IsNullOrEmpty(txtPesquisar.Text))
            {
                txtPesquisar.Select(txtPesquisar.Text.Length, 0);
            }
        }

        private void dataGridPesquisar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //SelecionarProduto();
        }
        private void MostrarDetalheProduto()
        {
            if (dataGridPesquisar.CurrentRow == null)
                return;

            var produto = dataGridPesquisar.CurrentRow.DataBoundItem;

            if (produto == null)
                return;

            // 🔹 Cast para seu tipo real de produto
            var p = (dynamic)produto;

            decimal precoCusto = p.PrecoCusto;
            decimal precoVenda = p.PrecoDeVenda;
            string nomeProduto = p.NomeProduto;

            var frm = new FrmDetalhePrecoProduto(
                nomeProduto,
                precoCusto,
                precoVenda);

            frm.ShowDialog(this);
        }

        private void FrmPesquisarPreco_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    MostrarDetalheProduto();
                    e.Handled = true;
                    break;
            }
        }
    }
}

