using GVC.BLL;
using GVC.DAL;
using GVC.UTIL;
using Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;

namespace GVC.View
{
    public partial class FrmLocalizarVendedor : KryptonForm
    {
        // Variável para controlar a linha atual
        private int linhaAtual = -1;
        public int VendedorID { get; private set; }  // Adicione esta linha na classe
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int numeroComZeros { get; set; }
       
        private Form _formChamador;
        private bool recebendoTextoExterno = false;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string VendedorSelecionado { get; set; }
        private readonly ClienteBLL _bll;

        public FrmLocalizarVendedor(Form formChamador, string textoDigitado)
        {
            InitializeComponent();

            _bll = new ClienteBLL();
            ConfigurarEventosTeclado();
            _formChamador = formChamador;

            // Configura DataGridView
            dataGridPesquisar.SelectionChanged += dataGridPesquisar_SelectionChanged;
            this.dataGridPesquisar.KeyDown += dataGridPesquisar_KeyDown;
            this.txtPesquisar.KeyDown += txtPesquisar_KeyDown; // Corrigido: txtPesquisar_KeyDown
            this.dataGridPesquisar.Enter += dataGridPesquisar_Enter;
            this.KeyPreview = true;
            dataGridPesquisar.SelectionChanged += dataGridPesquisar_SelectionChanged;
            this.dataGridPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridPesquisar_KeyDown);

            // Define o texto inicial passado pelo form chamador
            if (!string.IsNullOrEmpty(textoDigitado))
            {
                DefinirTextoPesquisa(textoDigitado);
            }
        }

        // Adicione este método para seleção rápida quando houver apenas um resultado
        private void VerificarSelecaoAutomatica()
        {
            // Se houver apenas um resultado na pesquisa, seleciona automaticamente
            if (dataGridPesquisar.Rows.Count == 1)
            {
                // Opção 2: Apenas seleciona a linha mas não confirma (deixa usuário decidir)
                dataGridPesquisar.Rows[0].Selected = true;
                dataGridPesquisar.CurrentCell = dataGridPesquisar.Rows[0].Cells[0];
                dataGridPesquisar.Focus();
            }
        }
        private void ConfigurarEventosTeclado()
        {
            // Configura KeyPreview no formulário
            this.KeyPreview = true;

            // Evento de teclado no formulário (opcional, para atalhos globais)
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.F2)
                {
                    txtPesquisar.Focus();
                    e.Handled = true;
                }
            };
        }
        // Método para definir o texto da pesquisa vindo do formulário chamador
        public void DefinirTextoPesquisa(string texto)
        {
            recebendoTextoExterno = true;
            txtPesquisar.Text = texto;
            txtPesquisar.SelectionStart = texto.Length; // cursor no final
            recebendoTextoExterno = false;

            if (!string.IsNullOrEmpty(texto))
            {
                PesquisarVendedor();
                SelecionarPrimeiroVendedor();
            }
        }
        public new int ObterLinhaAtual()
        {
            return linhaAtual;
        }

        public void PersonalizarDataGridView()
        {
            // 1. Desliga o auto‑resize global
            dataGridPesquisar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // 2. Oculta todas as colunas inicialmente
            foreach (DataGridViewColumn col in dataGridPesquisar.Columns)
            {
                col.Visible = false;
            }

            // 3. Cabeçalhos bonitos
            if (dataGridPesquisar.Columns["ClienteID"] != null)
            {
                dataGridPesquisar.Columns["ClienteID"].HeaderText = "Código";
                dataGridPesquisar.Columns["ClienteID"].Visible = true;
            }
            if (dataGridPesquisar.Columns["Nome"] != null)
            {
                dataGridPesquisar.Columns["Nome"].HeaderText = "Cliente";
                dataGridPesquisar.Columns["Nome"].Visible = true;
            }         

            // 4. Colunas fixas (largura definida e não mudam)
            var colunasFixas = new (string nome, int largura)[]
            {
        ("ClienteID", 50),      
            };

            foreach (var (nome, largura) in colunasFixas)
            {
                if (dataGridPesquisar.Columns[nome] != null)
                {
                    var col = dataGridPesquisar.Columns[nome];
                    col.Width = largura;
                    col.Resizable = DataGridViewTriState.False;
                    col.ReadOnly = true;
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; // 🔑 fixa
                }
            }

            // 5. NomeProduto dinâmico (ocupa espaço restante)
            if (dataGridPesquisar.Columns["Nome"] != null)
            {
                var col = dataGridPesquisar.Columns["Nome"];
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // 🔄 ajusta ao grid
                col.ReadOnly = true;
            }

            // 6. Cabeçalho mais estreito
            dataGridPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridPesquisar.ColumnHeadersHeight = 25;

            dataGridPesquisar.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Regular);
            dataGridPesquisar.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

            // ❗ Remover cabeçalho de linhas (sem alterar largura)
            dataGridPesquisar.RowHeadersVisible = false;

            // (opcional) remove borda do cabeçalho de linhas, caso algum tema desenhe algo
            dataGridPesquisar.AdvancedRowHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;

            dataGridPesquisar.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8, FontStyle.Regular);
            dataGridPesquisar.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridPesquisar.RowHeadersWidth = 30;

            // 8. Força o grid a respeitar tudo
            dataGridPesquisar.PerformLayout();
        }

        // Função auxiliar para selecionar a primeira linha em coluna visível
        private void SelecionarPrimeiraLinhaSegura()
        {
            if (dataGridPesquisar.Rows.Count == 0 || dataGridPesquisar.Columns.Count == 0)
                return;

            // Encontra o primeiro índice de coluna VISÍVEL
            int firstVisibleColIndex = -1;
            foreach (DataGridViewColumn col in dataGridPesquisar.Columns)
            {
                if (col.Visible)
                {
                    firstVisibleColIndex = col.Index;
                    break;
                }
            }

            if (firstVisibleColIndex == -1)
                return; // não há nenhuma coluna visível

            var firstRow = dataGridPesquisar.Rows[0];

            // Evita conflito com célula atual em coluna invisível
            if (dataGridPesquisar.CurrentCell != null &&
                !dataGridPesquisar.CurrentCell.OwningColumn.Visible)
            {
                dataGridPesquisar.CurrentCell = null;
            }

            firstRow.Selected = true;
            dataGridPesquisar.CurrentCell = firstRow.Cells[firstVisibleColIndex];
        }
        public void ListarVendedor()
        {
            dataGridPesquisar.DataSource = _bll.ListarVendedores();
            PersonalizarDataGridView();
        }
        private void FrmLocalizarVendedor_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

            // Altura fixa
            this.MinimumSize = new Size(this.Width, this.Height); this.MaximumSize = new Size(int.MaxValue, this.Height);
            ListarVendedor();
            txtPesquisar.Focus();

            if (!string.IsNullOrEmpty(txtPesquisar.Text))
            {
                txtPesquisar.Select(txtPesquisar.Text.Length, 0);
            }
        }

        private void PesquisarVendedor()
        {
            string textoPesquisa = txtPesquisar.Text.Trim();

            // 🔹 Pesquisa apenas por nome
            dataGridPesquisar.DataSource = _bll.PesquisarVendedor(textoPesquisa);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLocalizarVendedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            isSelectingProduct = false;
        }

        private bool isSelectingProduct = false;
        private Form formChamador;
       
        private void SelecionarVendedores()
        {
            if (isSelectingProduct) return;
            isSelectingProduct = true;

            try
            {
                linhaAtual = ObterLinhaAtual();
                if (linhaAtual < 0 || linhaAtual >= dataGridPesquisar.Rows.Count)
                {
                    Utilitario.Mensagens.Aviso("Linha inválida.");
                    return;
                }

                var vendedorIdValue = dataGridPesquisar["ClienteID", linhaAtual]?.Value;
                var nomeValue = dataGridPesquisar["Nome", linhaAtual]?.Value;

                if (vendedorIdValue == null || nomeValue == null)
                {
                    Utilitario.Mensagens.Aviso("Dados do vendedor inválidos.");
                    return;
                }

                // Preenche as propriedades públicas que o chamador vai ler
                VendedorID = int.TryParse(vendedorIdValue.ToString(), out int id) ? id : 0;
                VendedorSelecionado = nomeValue?.ToString() ?? string.Empty;

                // Sinaliza sucesso para o ShowDialog()
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            finally
            {
                isSelectingProduct = false;
            }
        }



        private void dataGridPesquisar_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridPesquisar.CurrentRow != null)
            {
                linhaAtual = dataGridPesquisar.CurrentRow.Index;
            }
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
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

        private void dataGridPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    // Enter no DataGridView: seleciona vendedor
                    SelecionarVendedores(); // Chama seu método existente
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
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            PesquisarVendedor();
        }
        private void FrmLocalizarVendedor_Shown(object sender, EventArgs e)
        {
            txtPesquisar.Focus();
            // Em vez disso, posicione o cursor no final
            if (!string.IsNullOrEmpty(txtPesquisar.Text))
            {
                txtPesquisar.Select(txtPesquisar.Text.Length, 0);
            }

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    // Tecla para baixo: move foco para o DataGridView
                    if (dataGridPesquisar.Rows.Count > 0)
                    {
                        dataGridPesquisar.Focus();

                        // Seleciona a primeira linha se nenhuma estiver selecionada
                        if (dataGridPesquisar.CurrentRow == null && dataGridPesquisar.Rows.Count > 0)
                        {
                            dataGridPesquisar.Rows[0].Selected = true;
                            dataGridPesquisar.CurrentCell = dataGridPesquisar.Rows[0].Cells[0];
                        }
                    }
                    e.Handled = true;
                    break;

                case Keys.Enter:
                    // Enter no campo de pesquisa: seleciona primeiro resultado
                    if (dataGridPesquisar.Rows.Count > 0)
                    {
                        dataGridPesquisar.Focus();
                        dataGridPesquisar.Rows[0].Selected = true;
                        dataGridPesquisar.CurrentCell = dataGridPesquisar.Rows[0].Cells[0];
                        SelecionarVendedores(); // Chama seu método existente
                    }
                    e.Handled = true;
                    break;

                case Keys.Escape:
                    this.Close();
                    e.Handled = true;
                    break;
            }
        }
        // Seleciona o primeiro vendedor da lista
        private void SelecionarPrimeiroVendedor()
        {
            if (dataGridPesquisar.Rows.Count > 0)
            {
                dataGridPesquisar.Rows[0].Selected = true;
                dataGridPesquisar.CurrentCell = dataGridPesquisar.Rows[0].Cells[0];
            }
        }

        private void dataGridPesquisar_Enter(object sender, EventArgs e)
        {
            if (dataGridPesquisar.Rows.Count > 0 && dataGridPesquisar.CurrentRow == null)
            {
                SelecionarPrimeiraLinhaSegura();
            }
            // Quando o DataGridView recebe foco, seleciona a primeira linha se nenhuma estiver selecionada
            if (dataGridPesquisar.Rows.Count > 0 && dataGridPesquisar.CurrentRow == null)
            {
                dataGridPesquisar.Rows[0].Selected = true;
                dataGridPesquisar.CurrentCell = dataGridPesquisar.Rows[0].Cells[0];
            }
        }

        private void dataGridPesquisar_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridPesquisar.CurrentRow != null)
            {
                SelecionarVendedores();
            }
        }

        private void FrmLocalizarVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    // Mesmo comportamento do botão Sair
                    if (dataGridPesquisar.CurrentRow != null && dataGridPesquisar.CurrentRow.Index >= 0)
                    {
                        linhaAtual = dataGridPesquisar.CurrentRow.Index;
                        SelecionarVendedores();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                    }
                    e.Handled = true;
                    break;

                    // Adicione outras teclas aqui, se precisar
                    // case Keys.Enter:
                    //     ...
                    //     break;
            }

        }

        private void dataGridPesquisar_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SelecionarPrimeiraLinhaSegura();
        }
    }
}