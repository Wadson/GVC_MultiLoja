
using GVC.DALL;
using GVC.Model;
using GVC.UTIL;
using Krypton.Toolkit;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace GVC.View
{
    public partial class FrmLocalizarCidade : KryptonForm
    {
        private Form _formChamador;
        protected int LinhaAtual = -1;
        public int CidadeID { get; private set; }
        public string Uf { get; private set; }
        private bool recebendoTextoExterno = false;
        public string cidadeSelecionado { get; set; } // não serve para nada só para preencher o parametro do construtor
        public FrmLocalizarCidade(Form formChamador, string textoDigitado)
        {
            InitializeComponent();
            ConfigurarEventosTeclado();
            _formChamador = formChamador; // Use apenas uma variável

            // Restante do código...

            // Configura DataGridView
            dataGridPesquisar.SelectionChanged += dataGridPesquisar_SelectionChanged;
            this.dataGridPesquisar.KeyDown += dataGridPesquisar_KeyDown;
            this.txtPesquisar.KeyDown += txtPesquisar_KeyDown; // Corrigido o nome do método

            // Define o texto inicial
            if (!string.IsNullOrEmpty(textoDigitado))
            {
                DefinirTextoPesquisa(textoDigitado);
            }




            dataGridPesquisar.SelectionChanged += dataGridPesquisar_SelectionChanged;
            this.dataGridPesquisar.KeyDown += dataGridPesquisar_KeyDown;
            this.txtPesquisar.KeyDown += txtPesquisa_KeyDown; // Corrigido: txtPesquisar_KeyDown
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
        public new int ObterLinhaAtual()
        {
            return LinhaAtual;
        }
        // Seleciona o primeiro cliente da lista
        private void SelecionarPrimeiraCidade()
        {
            if (dataGridPesquisar.Rows.Count > 0)
            {
                dataGridPesquisar.Rows[0].Selected = true;
                dataGridPesquisar.CurrentCell = dataGridPesquisar.Rows[0].Cells[0];
            }
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
                PesquisarCidade();
                SelecionarPrimeiraCidade();
            }
        }
        // Adicione este método para seleção rápida quando houver apenas um resultado
        private void VerificarSelecaoAutomatica()
        {
            // Se houver apenas um resultado na pesquisa, seleciona automaticamente
            if (dataGridPesquisar.Rows.Count == 1)
            {
                // Opção 1: Seleciona automaticamente
                // dataGridPesquisar.Rows[0].Selected = true;
                // dataGridPesquisar.CurrentCell = dataGridPesquisar.Rows[0].Cells[0];
                // SelecionarCliente();

                // Opção 2: Apenas seleciona a linha mas não confirma (deixa usuário decidir)
                dataGridPesquisar.Rows[0].Selected = true;
                dataGridPesquisar.CurrentCell = dataGridPesquisar.Rows[0].Cells[0];
                dataGridPesquisar.Focus();
            }
        }
        private void PesquisarCidade()
        {
            CidadeDal dao = new CidadeDal();

            if (rbtCodigo.Checked)
            {
                if (int.TryParse(txtPesquisar.Text, out int id))
                {
                    dataGridPesquisar.DataSource = dao.PesquisarPorCodigo(id);
                }
                else
                {
                    dataGridPesquisar.DataSource = null;
                }
            }
            else
            {
                string nome = "%" + txtPesquisar.Text + "%";
                dataGridPesquisar.DataSource = dao.PesquisarPorNome(nome);
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
        public void ListarCidade()
        {
            CidadeDal dao = new CidadeDal();
            dataGridPesquisar.DataSource = dao.PesquisarGeral();

            InicializaDataGridView();
        }
        private void FrmLocalizarCliente_Load(object sender, EventArgs e)
        {
            ListarCidade();

            if (!string.IsNullOrEmpty(txtPesquisar.Text))
            {
                txtPesquisar.Select(txtPesquisar.Text.Length, 0);
            }
        }
        private void InicializaDataGridView()
        {
            dataGridPesquisar.AutoGenerateColumns = false;
            dataGridPesquisar.Columns.Clear();

            dataGridPesquisar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CidadeID",
                DataPropertyName = "CidadeID", // nome do campo no SELECT
                HeaderText = "CidadeID",
                Width = 80
            });

            dataGridPesquisar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nome",
                DataPropertyName = "Nome",
                HeaderText = "Cidade",
                Width = 300
            });

            dataGridPesquisar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Uf",
                DataPropertyName = "Uf",
                HeaderText = "Uf",
                Width = 60
            });

            dataGridPesquisar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EstadoID",
                DataPropertyName = "EstadoID",
                HeaderText = "Código Uf",
                Width = 100
            });
        }
        private void SelecionarCidade()
        {
            try
            {
                // Valida se há linha selecionada
                if (dataGridPesquisar.CurrentRow == null || dataGridPesquisar.CurrentRow.Index < 0)
                {
                    Utilitario.Mensagens.Erro("Nenhuma cidade selecionada.");
                    return;
                }

                // Obtenha os dados da linha selecionada
                DataGridViewRow row = dataGridPesquisar.CurrentRow;

                // Valida as células (ajuste os índices conforme sua grid)
                if (row.Cells["CidadeID"].Value == null || row.Cells["Nome"].Value == null)
                {
                    Utilitario.Mensagens.Erro("Dados da cidade incompletos.");
                    return;
                }

                CidadeID = Convert.ToInt32(row.Cells["CidadeID"].Value);
                cidadeSelecionado = row.Cells["Nome"].Value.ToString();

                // Se houver coluna de Uf
                if (row.Cells["Uf"] != null && row.Cells["Uf"].Value != null)
                {
                    Uf = row.Cells["Uf"].Value.ToString();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro($"Erro ao selecionar cidade: {ex.Message}");
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

        private void dataGridPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    // Enter no DataGridView: seleciona cliente
                    SelecionarCidade(); // Chama seu método existente
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
            string nome = "%" + txtPesquisar.Text + "%";
            CidadeDal dao = new CidadeDal();

            if (rbtCodigo.Checked)
            {
                dataGridPesquisar.DataSource = dao.PesquisarPorCodigo(nome);
            }
            else
            {
                dataGridPesquisar.DataSource = dao.PesquisarPorNome(nome);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLocalizarCidade_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }

        private void FrmLocalizarCidade_FormClosed(object sender, FormClosedEventArgs e)
        {
            isSelectingProduct = false;
        }
        private bool isSelectingProduct = false;
        private Form formChamador;

        private void FrmLocalizarCidade_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    // Mesmo comportamento do botão Sair
                    if (dataGridPesquisar.CurrentRow != null && dataGridPesquisar.CurrentRow.Index >= 0)
                    {
                        LinhaAtual = dataGridPesquisar.CurrentRow.Index;
                        SelecionarCidade();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                    }
                    e.Handled = true;
                    break;
            }
        }

        private void dataGridPesquisar_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridPesquisar.CurrentRow != null)
            {
                SelecionarCidade();
            }
        }

        private void dataGridPesquisar_Enter(object sender, EventArgs e)
        {
            // Quando o DataGridView recebe foco, seleciona a primeira linha se nenhuma estiver selecionada
            if (dataGridPesquisar.Rows.Count > 0 && dataGridPesquisar.CurrentRow == null)
            {
                dataGridPesquisar.Rows[0].Selected = true;
                dataGridPesquisar.CurrentCell = dataGridPesquisar.Rows[0].Cells[0];
            }
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {

        }
        // Adicione este método no FrmLocalizarCidade
        private bool ValidarFormChamador()
        {
            if (_formChamador == null)
            {
                Utilitario.Mensagens.Erro("Formulário chamador não foi especificado.");
                return false;
            }

            if (_formChamador.IsDisposed)
            {
                Utilitario.Mensagens.Erro("Formulário chamador não está mais disponível.");
                return false;
            }

            return true;
        }
    }
}
