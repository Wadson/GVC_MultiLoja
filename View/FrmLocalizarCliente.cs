using GVC.DAL;
using GVC.UTIL;
using Krypton.Toolkit;
using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace GVC.View
{
    public partial class FrmLocalizarCliente : KryptonForm
    {
        // Variável para controlar a linha atual
        private int linhaAtual = -1;
        public int ClienteID { get; private set; }  // Adicione esta linha na classe
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int numeroComZeros { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Cpf { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Cnpj { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Telefone { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Logradouro { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Numero { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Bairro { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Cidade { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Estado { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Cep { get; set; }

        private Form _formChamador;
        private bool recebendoTextoExterno = false;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ClienteSelecionado { get; set; }

        public FrmLocalizarCliente(Form formChamador, string textoDigitado)
        {
            InitializeComponent();
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
                PesquisarCliente();
                SelecionarPrimeiroCliente();
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
            if (dataGridPesquisar.Columns["Logradouro"] != null)
            {
                dataGridPesquisar.Columns["Logradouro"].HeaderText = "Logradouro";
                dataGridPesquisar.Columns["Logradouro"].Visible = true;
            }
            if (dataGridPesquisar.Columns["Numero"] != null)
            {
                dataGridPesquisar.Columns["Numero"].HeaderText = "Número";
                dataGridPesquisar.Columns["Numero"].Visible = true;
            }
            if (dataGridPesquisar.Columns["Bairro"] != null)
            {
                dataGridPesquisar.Columns["Bairro"].HeaderText = "Bairro";
                dataGridPesquisar.Columns["Bairro"].Visible = true;
            }

            // 4. Colunas fixas (largura definida e não mudam)
            var colunasFixas = new (string nome, int largura)[]
            {
        ("ClienteID", 50), 
        ("Nome", 300),
        ("Logradouro", 250),
        ("Numero", 60),
        ("Bairro", 250)        
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

            //// 5. NomeProduto dinâmico (ocupa espaço restante)
            //if (dataGridPesquisar.Columns["Nome"] != null)
            //{
            //    var col = dataGridPesquisar.Columns["Nome"];
            //    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // 🔄 ajusta ao grid
            //    col.ReadOnly = true;
            //}

            // 6. Cabeçalho mais estreito
            dataGridPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridPesquisar.ColumnHeadersHeight = 25;

            dataGridPesquisar.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Bold);
            dataGridPesquisar.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

            // ❗ Remover cabeçalho de linhas (sem alterar largura)
            dataGridPesquisar.RowHeadersVisible = false;

            // (opcional) remove borda do cabeçalho de linhas, caso algum tema desenhe algo
            dataGridPesquisar.AdvancedRowHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;

            dataGridPesquisar.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Bold);
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
        public void ListarCliente()
        {
            ClienteDal dao = new();
            dataGridPesquisar.DataSource = dao.PesquisarGeral();
            PersonalizarDataGridView();
        }
        private void FrmLocalizarCliente_Load(object sender, EventArgs e)
        {
            // Altura fixa
            this.MinimumSize = new Size(this.Width, this.Height); this.MaximumSize = new Size(int.MaxValue, this.Height);
            ListarCliente();
            txtPesquisar.Focus();

            if (!string.IsNullOrEmpty(txtPesquisar.Text))
            {
                txtPesquisar.Select(txtPesquisar.Text.Length, 0);
            }
        }

        private void PesquisarCliente()
        {
            string textoPesquisa = txtPesquisar.Text.Trim();
            ClienteDal dao = new ClienteDal();

            // 🔹 Pesquisa apenas por nome
            dataGridPesquisar.DataSource = dao.PesquisarGeral(textoPesquisa);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLocalizarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            isSelectingProduct = false;
        }

        private bool isSelectingProduct = false;
        private Form formChamador;
        private void SelecionarCliente()
        {
            if (isSelectingProduct) return;
            isSelectingProduct = true;

            try
            {
                // Obtém a linha atual selecionada na grid
                linhaAtual = ObterLinhaAtual();
                if (linhaAtual < 0 || linhaAtual >= dataGridPesquisar.Rows.Count)
                {
                    Utilitario.Mensagens.Aviso("Linha inválida.");
                    return;
                }

                if (dataGridPesquisar["ClienteID", linhaAtual]?.Value == null ||
                    dataGridPesquisar["Nome", linhaAtual]?.Value == null ||
                    dataGridPesquisar["Logradouro", linhaAtual]?.Value == null ||
                    dataGridPesquisar["Numero", linhaAtual]?.Value == null ||
                    dataGridPesquisar["Bairro", linhaAtual]?.Value == null)
                {
                    Utilitario.Mensagens.Aviso("Dados do cliente inválidos.");
                    return;
                }

                // Preenche as propriedades públicas que o chamador vai ler
                ClienteID = Convert.ToInt32(dataGridPesquisar["ClienteID", linhaAtual].Value);
                ClienteSelecionado = dataGridPesquisar["Nome", linhaAtual].Value.ToString();
                Logradouro = dataGridPesquisar["Logradouro", linhaAtual].Value.ToString();
                Numero = dataGridPesquisar["Numero", linhaAtual].Value.ToString();
                Bairro = dataGridPesquisar["Bairro", linhaAtual].Value.ToString();

                // Retorna sucesso para o ShowDialog()
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
                    // Enter no DataGridView: seleciona cliente
                    SelecionarCliente(); // Chama seu método existente
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
        private void AtualizarFormularioChamador()
        {
        }
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            PesquisarCliente();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            // SE TEM ALGUMA LINHA SELECIONADA → carrega os dados antes de sair
            if (dataGridPesquisar.CurrentRow != null && dataGridPesquisar.CurrentRow.Index >= 0)
            {
                linhaAtual = dataGridPesquisar.CurrentRow.Index;
                SelecionarCliente(); // ← agora carrega mesmo clicando em Sair
                return; // sai com DialogResult.OK
            }

            // Se não tem nada selecionado → só fecha (sem carregar nada)
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmLocalizarCliente_Shown(object sender, EventArgs e)
        {
            txtPesquisar.Focus();
            // Em vez disso, posicione o cursor no final
            if (!string.IsNullOrEmpty(txtPesquisar.Text))
            {
                txtPesquisar.Select(txtPesquisar.Text.Length, 0);
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
                        SelecionarCliente(); // Chama seu método existente
                    }
                    e.Handled = true;
                    break;

                case Keys.Escape:
                    this.Close();
                    e.Handled = true;
                    break;
            }
        }
        // Seleciona o primeiro cliente da lista
        private void SelecionarPrimeiroCliente()
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
            //// Quando o DataGridView recebe foco, seleciona a primeira linha se nenhuma estiver selecionada
            //if (dataGridPesquisar.Rows.Count > 0 && dataGridPesquisar.CurrentRow == null)
            //{
            //    dataGridPesquisar.Rows[0].Selected = true;
            //    dataGridPesquisar.CurrentCell = dataGridPesquisar.Rows[0].Cells[0];
            //}
        }

        private void dataGridPesquisar_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridPesquisar.CurrentRow != null)
            {
                SelecionarCliente();
            }
        }

        private void FrmLocalizarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    // Mesmo comportamento do botão Sair
                    if (dataGridPesquisar.CurrentRow != null && dataGridPesquisar.CurrentRow.Index >= 0)
                    {
                        linhaAtual = dataGridPesquisar.CurrentRow.Index;
                        SelecionarCliente();
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