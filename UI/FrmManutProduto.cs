using GVC.BLL;
using GVC.Helpers;
using GVC.Infra.Helpers;
using GVC.Infra.Repository;
using GVC.Model;
using GVC.UTIL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Font = System.Drawing.Font;
using Image = System.Drawing.Image;

namespace GVC.View
{
    public partial class FrmManutProduto : KryptonForm
    {
        private new string StatusOperacao;
        private readonly ProdutosBLL _produtosBll = new ProdutosBLL();
        private int linhaAtual = -1;
        private int ProdutoiD;
        private string NomeProduto;
        private decimal PrecoCusto;
        private int _totalRegistrosBanco;
        public FrmManutProduto(string statusOperacao)
        {
            InitializeComponent();
        }

        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        public void ListarProduto()
        {
            ProdutosBLL objetoBll = new ProdutosBLL();
            dgvProdutos.DataSource = objetoBll.ListarTodos();
            PersonalizarDataGridView();
            Utilitario.AtualizarTotalKrypton(lblStatus, dgvProdutos);
        }
        public void PersonalizarDataGridView()
        {
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // ⭐⭐ PASSO 1: Remover TODAS as colunas de navegação/objetos complexos ⭐⭐
            // Estas são as colunas que NÃO vêm do seu SQL direto
            string[] colunasParaRemover = {

            "ItemVenda",
            "MovimentacaoEstoques" };


            foreach (var nome in colunasParaRemover)
            {
                if (dgvProdutos.Columns.Contains(nome))
                {
                    dgvProdutos.Columns.Remove(nome);
                }
            }

            // ⭐⭐ PASSO 2: Garantir que só as colunas do SELECT permaneçam ⭐⭐
            // Estas são as colunas que vêm do seu SQL (SqlBase) - ATUALIZADO
            var colunasDoSQL = new HashSet<string>
            {
                "ProdutoID", "NomeProduto", "Referencia", "PrecoCompra", "PrecoCusto", "Lucro",
                "PrecoDeVenda", "Estoque", "DataDeEntrada", "Status", "Situacao",
                "Unidade", "MarcaID", "NomeMarca", "DataValidade", "GtinEan", "Imagem",  // 🔹 ATUALIZADO
                "FornecedorID", "NomeFornecedor", "EmpresaID"
            };

            // Remover do final para o início para não bagunçar os índices
            for (int i = dgvProdutos.Columns.Count - 1; i >= 0; i--)
            {
                string nomeColuna = dgvProdutos.Columns[i].Name;
                if (!colunasDoSQL.Contains(nomeColuna))
                {
                    dgvProdutos.Columns.RemoveAt(i);
                }
            }

            // ⭐⭐ PASSO 3: Ocultar colunas primeiro ⭐⭐
            string[] colunasParaOcultar = {
                "ProdutoID",
                "FornecedorID",
                "Status",
                "Situacao",
                "DataDeEntrada",
                "GtinEan",
                "DataValidade",
                "Imagem",
                "EmpresaID",
                "MarcaID"  // 🔹 ADICIONE ESTA LINHA (novo campo)
            };

            foreach (var nome in colunasParaOcultar)
            {
                if (dgvProdutos.Columns.Contains(nome))
                {
                    dgvProdutos.Columns[nome].Visible = false;
                }
            }

            // ⭐⭐ PASSO 5: Cabeçalhos ⭐⭐
            // Use Contains para evitar exceções
            if (dgvProdutos.Columns.Contains("NomeProduto"))
                dgvProdutos.Columns["NomeProduto"].HeaderText = "Nome Produto";

            if (dgvProdutos.Columns.Contains("PrecoCompra"))
                dgvProdutos.Columns["PrecoCompra"].HeaderText = "Preço de Compra";

            if (dgvProdutos.Columns.Contains("PrecoCusto"))
                dgvProdutos.Columns["PrecoCusto"].HeaderText = "Preço Custo";

            if (dgvProdutos.Columns.Contains("Lucro"))
                dgvProdutos.Columns["Lucro"].HeaderText = "Lucro";

            if (dgvProdutos.Columns.Contains("PrecoDeVenda"))
                dgvProdutos.Columns["PrecoDeVenda"].HeaderText = "Preço Venda";

            if (dgvProdutos.Columns.Contains("Estoque"))
                dgvProdutos.Columns["Estoque"].HeaderText = "Estoque";

            if (dgvProdutos.Columns.Contains("DataValidade"))
                dgvProdutos.Columns["DataValidade"].HeaderText = "Validade";

            if (dgvProdutos.Columns.Contains("Referencia"))
                dgvProdutos.Columns["Referencia"].HeaderText = "Referência";

            // 🔹 ALTERE ESTA LINHA (de "Marca" para "NomeMarca"):
            if (dgvProdutos.Columns.Contains("NomeMarca"))
                dgvProdutos.Columns["NomeMarca"].HeaderText = "Marca";

            if (dgvProdutos.Columns.Contains("NomeFornecedor"))
                dgvProdutos.Columns["NomeFornecedor"].HeaderText = "Fornecedor";

            if (dgvProdutos.Columns.Contains("Status"))
                dgvProdutos.Columns["Status"].HeaderText = "Status";

            if (dgvProdutos.Columns.Contains("Situacao"))
                dgvProdutos.Columns["Situacao"].HeaderText = "Situação";

            if (dgvProdutos.Columns.Contains("Unidade"))
                dgvProdutos.Columns["Unidade"].HeaderText = "Unidade";

            if (dgvProdutos.Columns.Contains("GtinEan"))
                dgvProdutos.Columns["GtinEan"].HeaderText = "Código EAN";

            // ⭐⭐ PASSO 6: Colunas fixas ⭐⭐
            var colunasFixas = new (string nome, int largura)[]
            {
                ("NomeProduto", 400),
                ("PrecoCompra", 100),
                ("PrecoCusto", 80),
                ("Lucro", 80),
                ("PrecoDeVenda", 80),
                ("Estoque", 80),
                ("DataValidade", 100),
                ("Status", 100),
                ("Situacao", 100),
                ("Unidade", 80),
                ("GtinEan", 120),
                ("NomeFornecedor", 200),
                ("NomeMarca", 150),  // 🔹 ADICIONE ESTA LINHA (novo campo)
                ("FornecedorID", 80)
                        };

            foreach (var (nome, largura) in colunasFixas)
            {
                if (dgvProdutos.Columns.Contains(nome))
                {
                    var col = dgvProdutos.Columns[nome];
                    col.Width = largura;
                    col.ReadOnly = true;
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }
            }

            // ⭐⭐ PASSO 7: Colunas dinâmicas ⭐⭐
            // 🔹 REMOVA "Marca" daqui, pois agora é NomeMarca e está nas colunas fixas
            foreach (var nome in new[] { "Referencia" })  // 🔹 REMOVIDO "Marca"
            {
                if (dgvProdutos.Columns.Contains(nome))
                {
                    var col = dgvProdutos.Columns[nome];
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    col.ReadOnly = true;
                }
            }

            // ⭐⭐ PASSO 8: Estilo cabeçalho ⭐⭐
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProdutos.ColumnHeadersHeight = 25;
            dgvProdutos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Regular);
            dgvProdutos.RowHeadersWidth = 30;

            // Exibe e configura PrecoCompra
            if (dgvProdutos
                .Columns.Contains("PrecoCompra"))
            {
                var col = dgvProdutos.Columns["PrecoCompra"];
                col.Visible = true;
                col.HeaderText = "Preço de Compra";
                col.DefaultCellStyle.BackColor = Color.LightBlue;   // azul claro
                col.DefaultCellStyle.ForeColor = Color.Blue;
            }

            // Exibe e configura PrecoCusto
            if (dgvProdutos.Columns.Contains("PrecoCusto"))
            {
                var col = dgvProdutos.Columns["PrecoCusto"];
                col.Visible = true;
                col.HeaderText = "Preço de Custo";
                col.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow; // amarelo suave
                col.DefaultCellStyle.ForeColor = Color.Red;
            }

            // Exibe e configura PrecoDeVenda
            if (dgvProdutos.Columns.Contains("PrecoDeVenda"))
            {
                var col = dgvProdutos.Columns["PrecoDeVenda"];
                col.Visible = true;
                col.HeaderText = "Preço de Venda";
                col.DefaultCellStyle.BackColor = Color.LightGreen;  // verde claro
                col.DefaultCellStyle.ForeColor = Color.Green
                    ;
            }

            // ⭐⭐ PASSO 10: Atualizar grid ⭐⭐
            dgvProdutos.Refresh();
        }
        // ⭐⭐ Método ReordenarColunas ATUALIZADO ⭐⭐
        private void ReordenarColunas()
        {
            // Ordem desejada das colunas (da esquerda para direita)
            // Apenas colunas que REALMENTE existem no DataGridView após a limpeza
            string[] ordemColunas =
            {
                "ProdutoID",           // Oculto
                "NomeProduto",         // Primeira coluna visível
                "Referencia",
                "PrecoCompra",
                "PrecoCusto",
                "Lucro",
                "PrecoDeVenda",
                "Estoque",
                "DataDeEntrada",       // Oculto
                "DataValidade",
                "NomeFornecedor",      // Coluna do fornecedor
                "NomeMarca",           // 🔹 ALTERADO de "Marca" para "NomeMarca"
                "Unidade",
                "Status",
                "Situacao",
                "GtinEan",
                "MarcaID",             // 🔹 ADICIONADO (será oculto)
                "FornecedorID",        // Oculto
                "Imagem",              // Oculto
                "EmpresaID"            // Oculto
            };

            // Aplica a ordem apenas para colunas que existem
            int displayIndex = 0;
            foreach (string nomeColuna in ordemColunas)
            {
                if (dgvProdutos.Columns.Contains(nomeColuna))
                {
                    dgvProdutos.Columns[nomeColuna].DisplayIndex = displayIndex;
                    displayIndex++;
                }
            }
        }

        private void CarregaDados()
        {
            FrmCadProdutos frm = new FrmCadProdutos(StatusOperacao);

            // Se for NOVO, não precisa de linha selecionada
            if (StatusOperacao == "NOVO")
            {
                frm.btnSalvar.Text = "&Salvar";
                StatusOperacao = "NOVO";

                // Personalização do título
                frm.Text = "Novo Produto";
                frm.StateCommon.Header.Content.ShortText.Color1 = Color.Green;
                frm.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                frm.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8);

                HabilitarTimer(true);
                frm.ShowDialog();

                return;
            }

            // Para ALTERAR ou EXCLUSÃO, precisa ter linha selecionada
            if (dgvProdutos.CurrentRow == null)
            {
                Utilitario.Mensagens.Aviso("Selecione um registro primeiro.");
                return;
            }

            // Carregar dados do produto selecionado
            var produto = (ProdutoModel)dgvProdutos.CurrentRow.DataBoundItem;

            frm.txtProdutoID.Text = produto.ProdutoID.ToString();
            frm.txtReferencia.Text = produto.Referencia ?? "";
            frm.txtNomeProduto.Text = produto.NomeProduto;
            frm.txtPrecoCompra.Text = produto.PrecoCompra.HasValue ? produto.PrecoCompra.Value.ToString("N2") : "";
            frm.txtPrecoCusto.Text = produto.PrecoCusto.ToString("N2");
            frm.txtLucro.Text = produto.Lucro.ToString("N2");
            frm.txtPrecoDeVenda.Text = produto.PrecoDeVenda.ToString("N2");
            frm.txtEstoque.Text = produto.Estoque.ToString();
            frm.cmbUnidade.Text = produto.Unidade ?? "";

            // Substitua por:
            int marcaId = produto.MarcaID ?? 0;

            // Primeiro, certifique-se que o combobox foi carregado
            // O combobox já deve estar carregado no Load do FrmCadProdutos
            // Então apenas selecione o item correto
            frm.SelecionarMarcaPorId(marcaId);

            frm.txtDataValidade.Text = produto.DataValidade.HasValue ? produto.DataValidade.Value.ToString("dd/MM/yyyy") : "";
            frm.txtGtinEan.Text = produto.GtinEan ?? "";
            //frm.txtFornecedor.Text = produto.Fornecedor?.Fornecedor ?? "";
            //frm.txtFornecedorID.Text = produto.FornecedorID.ToString();

            // No método CarregaDados()
            frm.txtFornecedor.Text = produto.NomeFornecedor ?? "";  // ← Use NomeFornecedor            
            frm.txtFornecedorID.Text = produto.FornecedorID?.ToString() ?? "0";

            frm.cmbSituacao.Text = produto.Situacao ?? "";
            frm.cmbStatus.Text = produto.Status;

            // Carregar imagem
            if (!string.IsNullOrWhiteSpace(produto.Imagem) && File.Exists(produto.Imagem))
            {
                try
                {
                    frm.pbImagem.Image?.Dispose();
                    using (var fs = new FileStream(produto.Imagem, FileMode.Open, FileAccess.Read))
                        frm.pbImagem.Image = Image.FromStream(fs);
                    frm.txtEnderecoImagem.Text = produto.Imagem;
                    frm.pbImagem.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch { }
            }

            if (StatusOperacao == "ALTERAR")
            {
                frm.btnSalvar.Text = "&Alterar";
                frm.btnNovo.Enabled = false;
                // Personalização do título
                frm.Text = "Alterar Produto";
                frm.StateCommon.Header.Content.ShortText.Color1 = Color.Orange;
                frm.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                frm.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8);
            }
            else if (StatusOperacao == "EXCLUSÃO")
            {
                frm.btnSalvar.Text = "&Excluir";

                // Personalização do título
                frm.Text = "Excluir Produto";
                frm.StateCommon.Header.Content.ShortText.Color1 = Color.Red;
                frm.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                frm.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8);
                // Desabilitar campos
                frm.btnNovo.Enabled = false;
                frm.txtNomeProduto.Enabled = false;
                frm.txtReferencia.Enabled = false;
                frm.txtPrecoCusto.Enabled = false;
                frm.txtLucro.Enabled = false;
                frm.txtPrecoDeVenda.Enabled = false;
                frm.txtEstoque.Enabled = false;
                frm.cmbUnidade.Enabled = false;
                frm.cmbMarca.Enabled = false;
                frm.txtDataValidade.Enabled = false;
                frm.txtGtinEan.Enabled = false;
                frm.txtFornecedor.Enabled = false;
                frm.cmbSituacao.Enabled = false;
                frm.cmbStatus.Enabled = false;
                frm.btnLocalizarImagem.Enabled = false;
            }
            frm.ShowDialog();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ListarProduto();
            timer1.Enabled = false;
        }

        private void FrmManutProduto_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

            ListarProduto();           
            PersonalizarDataGridView();

            _totalRegistrosBanco = new ProdutosBLL().ContarTotal();

            StatusBarPadrao.AtualizarTotalBanco(lblTotalBanco, _totalRegistrosBanco);
            StatusBarPadrao.MensagemPesquisa(lblStatus, dgvProdutos, "produto", txtPesquisa.Text);
        }
       
        private void dataGridPesquisar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvProdutos.Columns[e.ColumnIndex].Name == "PrecoCusto" || dgvProdutos.Columns[e.ColumnIndex].Name == "PrecoVenda") && e.Value != null)
            {
                decimal valor = (decimal)e.Value;
                e.Value = valor.ToString("C", CultureInfo.CurrentCulture);
                e.FormattingApplied = true;
            }
        }

        private void rbtDescricao_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string texto = txtPesquisa.Text.Trim();

            try
            {
                if (string.IsNullOrWhiteSpace(texto))
                {
                    ListarProduto();
                    PersonalizarDataGridView();

                    StatusBarPadrao.AtualizarTotalBanco(lblTotalBanco, _totalRegistrosBanco);
                    StatusBarPadrao.MensagemPesquisa(lblStatus, dgvProdutos, "produto", "");
                    return;
                }

                var repo = new ProdutosBLL();
                var lista = repo.PesquisarProdutoPorNome(texto) ?? new List<ProdutoModel>();

                dgvProdutos.DataSource = lista;
                PersonalizarDataGridView();

                StatusBarPadrao.AtualizarTotalBanco(lblTotalBanco, _totalRegistrosBanco);
                StatusBarPadrao.MensagemPesquisa(lblStatus, dgvProdutos, "produto", texto);
            }
            catch (Exception ex)
            {
                StatusBarPadrao.AtualizarTotalBanco(lblTotalBanco, _totalRegistrosBanco);
                StatusBarPadrao.Mensagem(lblStatus, $"Erro na pesquisa: {ex.Message}", StatusTipo.Erro);
            }
        }

      
        private void btnNovo_Click(object sender, EventArgs e)
        {
            StatusOperacao = "NOVO";
            CarregaDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow == null)
            {
                Utilitario.Mensagens.Aviso("Selecione um usuário para alterar!");
                return;
            }
            StatusOperacao = "ALTERAR";
            CarregaDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow == null)
            {
                Utilitario.Mensagens.Aviso("Selecione um usuário para excluir!");
                return;
            }
            StatusOperacao = "EXCLUSÃO";
            CarregaDados();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            FrmMovimentacaoEstoque frm = new FrmMovimentacaoEstoque();
            frm.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    // Tecla para baixo: move foco para o DataGridView
                    if (dgvProdutos.Rows.Count > 0)
                    {
                        dgvProdutos.Focus();

                        // Seleciona a primeira linha se nenhuma estiver selecionada
                        if (dgvProdutos.CurrentRow == null && dgvProdutos.Rows.Count > 0)
                        {
                            dgvProdutos.Rows[0].Selected = true;
                            dgvProdutos.CurrentCell = dgvProdutos.Rows[0].Cells[0];
                        }
                    }
                    e.Handled = true;
                    break;

                case Keys.Enter:
                    // Enter no campo de pesquisa: seleciona primeiro resultado
                    if (dgvProdutos.Rows.Count > 0)
                    {
                        dgvProdutos.Focus();
                        dgvProdutos.Rows[0].Selected = true;
                        dgvProdutos.CurrentCell = dgvProdutos.Rows[0].Cells[0];
                        SelecionarProduto(); // Chama seu método existente
                    }
                    e.Handled = true;
                    break;

                case Keys.Escape:
                    this.Close();
                    e.Handled = true;
                    break;
            }
        }

        private void dgvProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    // Enter no DataGridView: seleciona cliente
                    CarregaDados(); // Chama seu método existente
                    e.Handled = true;
                    break;

                case Keys.Up:
                    // Tecla para cima na primeira linha: volta para o txtPesquisa
                    if (dgvProdutos.CurrentRow != null &&
                        dgvProdutos.CurrentRow.Index == 0)
                    {
                        txtPesquisa.Focus();
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
        private void SelecionarProduto()
        {
            try
            {
                // Obtém a linha atual selecionada na grid
                linhaAtual = dgvProdutos.CurrentRow?.Index ?? -1;
                if (linhaAtual < 0 || linhaAtual >= dgvProdutos.Rows.Count)
                {
                    Utilitario.Mensagens.Aviso("Linha inválida.");
                    return;
                }

                if (dgvProdutos["ProdutoID", linhaAtual]?.Value == null ||
                    dgvProdutos["NomeProduto", linhaAtual]?.Value == null ||
                    dgvProdutos["PrecoCusto", linhaAtual]?.Value == null)
                {
                    Utilitario.Mensagens.Aviso("Dados do cliente inválidos.");
                    return;
                }

                // Preenche as propriedades públicas que o chamador vai ler
                ProdutoiD = Convert.ToInt32(dgvProdutos["ProdutoID", linhaAtual].Value);
                NomeProduto = dgvProdutos["NomeProduto", linhaAtual].Value.ToString();
                PrecoCusto = Convert.ToDecimal(dgvProdutos["PrecoCusto", linhaAtual].Value);

                // Retorna sucesso para o ShowDialog()
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso("Erro ao selecionar cliente: " + ex.Message);
            }
        }

    }
}
