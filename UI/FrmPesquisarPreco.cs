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
            dataGridPesquisar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // 🔹 Oculta todas as colunas inicialmente
            foreach (DataGridViewColumn col in dataGridPesquisar.Columns)
            {
                col.Visible = false;
            }

            // 🔹 Cabeçalhos bonitos + visibilidade
            if (dataGridPesquisar.Columns["ProdutoID"] != null)
            {
                dataGridPesquisar.Columns["ProdutoID"].HeaderText = "Código";
                dataGridPesquisar.Columns["ProdutoID"].Visible = true;
            }

            if (dataGridPesquisar.Columns["NomeProduto"] != null)
            {
                dataGridPesquisar.Columns["NomeProduto"].HeaderText = "Produto";
                dataGridPesquisar.Columns["NomeProduto"].Visible = true;
                dataGridPesquisar.Columns["NomeProduto"].DefaultCellStyle.Font =
                    new Font("Segoe UI", 9.5f, FontStyle.Bold);
            }

            if (dataGridPesquisar.Columns["Referencia"] != null)
            {
                dataGridPesquisar.Columns["Referencia"].HeaderText = "Referência";
                dataGridPesquisar.Columns["Referencia"].Visible = true;
            }

            if (dataGridPesquisar.Columns["PrecoDeVenda"] != null)
            {
                dataGridPesquisar.Columns["PrecoDeVenda"].HeaderText = "Preço Venda";
                dataGridPesquisar.Columns["PrecoDeVenda"].Visible = true;
            }

            if (dataGridPesquisar.Columns["Estoque"] != null)
            {
                dataGridPesquisar.Columns["Estoque"].HeaderText = "Estoque";
                dataGridPesquisar.Columns["Estoque"].Visible = true;
            }

            if (dataGridPesquisar.Columns["Unidade"] != null)
            {
                dataGridPesquisar.Columns["Unidade"].HeaderText = "UN";
                dataGridPesquisar.Columns["Unidade"].Visible = true;
            }

            if (dataGridPesquisar.Columns["Marca"] != null)
            {
                dataGridPesquisar.Columns["Marca"].HeaderText = "Marca";
                dataGridPesquisar.Columns["Marca"].Visible = true;
            }

            // 🔹 Larguras fixas
            var largurasFixas = new (string nome, int largura)[]
            {
        ("ProdutoID",     50),
        ("NomeProduto", 570),
        ("Referencia",   120),
        ("PrecoDeVenda", 80),
        ("Estoque",      60),
        ("Unidade",      60),
        ("Marca",       150)
            };

            dataGridPesquisar.AllowUserToResizeColumns = true;

            foreach (var (nome, largura) in largurasFixas)
            {
                if (dataGridPesquisar.Columns[nome] != null)
                {
                    var col = dataGridPesquisar.Columns[nome];
                    col.Width = largura;
                    col.Resizable = DataGridViewTriState.False;
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }
            }
            // 🔹 Configuração FINAL da coluna NomeProduto
            if (dataGridPesquisar.Columns["NomeProduto"] != null)
            {
                var col = dataGridPesquisar.Columns["NomeProduto"];

               
                // permite redimensionar com o mouse
                col.Resizable = DataGridViewTriState.True;

                // evita colapsar ao arrastar
                col.MinimumWidth = 150;

                col.ReadOnly = true;
            }

            // 🔹 Estilo do cabeçalho
            dataGridPesquisar.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dataGridPesquisar.ColumnHeadersHeight = 25;
            dataGridPesquisar.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);

            dataGridPesquisar.ColumnHeadersDefaultCellStyle.WrapMode =
                DataGridViewTriState.False;

            // 🔹 Remove cabeçalho de linhas
            dataGridPesquisar.RowHeadersVisible = false;
            dataGridPesquisar.AdvancedRowHeadersBorderStyle.All =
                DataGridViewAdvancedCellBorderStyle.None;

            // 🔹 Estilo especial para Preço e Estoque
            if (dataGridPesquisar.Columns["PrecoDeVenda"] != null)
            {
                var col = dataGridPesquisar.Columns["PrecoDeVenda"];
                col.DefaultCellStyle.Font =
                    new Font("Arial", 10F, FontStyle.Bold);
                col.DefaultCellStyle.ForeColor = Color.DarkGreen;
                col.DefaultCellStyle.BackColor = Color.LightYellow;
            }

            if (dataGridPesquisar.Columns["Estoque"] != null)
            {
                dataGridPesquisar.Columns["Estoque"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }

            dataGridPesquisar.PerformLayout();
        }


        public new int ObterLinhaAtual()
        {
            return LinhaAtual;
        }

        public void ListarProduto()
        {
            ProdutoDALL dao = new();
            dataGridPesquisar.DataSource = dao.ListarProdutosVenda();
            PersonalizarDataGridView();
        }
        private void FrmLocalizarProduto_Load(object sender, EventArgs e)
        {
            ListarProduto();
            txtPesquisar.Focus();

            if (!string.IsNullOrEmpty(txtPesquisar.Text))
            {
                txtPesquisar.Select(txtPesquisar.Text.Length, 0);
            }
        }
      
        private void PesquisarProduto()
        {
            string textoPesquisa = txtPesquisar.Text.Trim();
            ProdutoDALL dao = new ProdutoDALL();

            // 🔹 Pesquisa apenas por nome
            dataGridPesquisar.DataSource = dao.PesquisarProdutoPorNome(textoPesquisa);
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
            PesquisarProduto();
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
    }
}

