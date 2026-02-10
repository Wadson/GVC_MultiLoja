using GVC.BLL;
using GVC.DAL;
using GVC.DAL;
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
            Utilitario.AtualizarTotalKrypton(lblMensagemStatus, dgvProdutos);
        }
        public void PersonalizarDataGridView()
        {
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // ⭐⭐ PASSO 1: Remover TODAS as colunas de navegação/objetos complexos ⭐⭐
            // Estas são as colunas que NÃO vêm do seu SQL direto
            string[] colunasParaRemover = {
            "ItemVenda",
            "MovimentacaoEstoques",  // Note o "s" no final - está no plural no seu model
            "Fornecedor" };       // Objeto complexo FornecedorModel

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
                "ProdutoID", "NomeProduto", "Referencia", "PrecoCusto", "Lucro",
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
                "DataDeEntrada",
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

            // ⭐⭐ PASSO 9: Formatações especiais ⭐⭐
            if (dgvProdutos.Columns.Contains("PrecoDeVenda"))
            {
                dgvProdutos.Columns["PrecoDeVenda"].DefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Regular);
                dgvProdutos.Columns["PrecoDeVenda"].DefaultCellStyle.ForeColor = Color.DarkGreen;
                dgvProdutos.Columns["PrecoDeVenda"].DefaultCellStyle.BackColor = Color.LightYellow;
            }

            if (dgvProdutos.Columns.Contains("Estoque"))
            {
                dgvProdutos.Columns["Estoque"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProdutos.Columns["Estoque"].DefaultCellStyle.Font = new Font("Segoe UI", 8F, FontStyle.Regular);
            }

            // ⭐⭐ PASSO 10: Atualizar grid ⭐⭐
            dgvProdutos.Refresh();
        }

        // ⭐⭐ Método ReordenarColunas ATUALIZADO ⭐⭐
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
            frm.txtFornecedor.Text = produto.Fornecedor?.Nome ?? "";
            frm.txtFornecedorID.Text = produto.FornecedorID.ToString();
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

            if (string.IsNullOrEmpty(texto))
            {
                ListarProduto();
                AtualizarStatusBar("Mostrando todos os produtos", Color.Blue); // Cor azul para lista completa
                return;
            }

            try
            {
                var produtoRepository = new ProdutoRepository();
                List<ProdutoModel> lista = produtoRepository.PesquisarProdutoPorNome(texto);

                dgvProdutos.DataSource = lista ?? new List<ProdutoModel>();
                PersonalizarDataGridView();

                // Atualizar contagem
                int totalRegistros = lista?.Count ?? 0;
                Utilitario.AtualizarTotalToolStatusStrip(lblMensagemStatus, dgvProdutos);

                // Atualizar barra de status com cor apropriada
                if (totalRegistros == 0)
                {
                    AtualizarStatusBar($"Nenhum produto encontrado para '{texto}'", Color.Red);
                }
                else
                {
                    AtualizarStatusBar($"{totalRegistros} produto(s) encontrado(s) para '{texto}'", Color.Green);
                }
            }
            catch (Exception ex)
            {
                AtualizarStatusBar($"Erro na pesquisa: {ex.Message}", Color.DarkRed);
            }
        }

        // Método para atualizar a barra de status
        private void AtualizarStatusBar(string mensagem, Color cor)
        {
            // Assumindo que você tem um StatusStrip com uma ToolStripStatusLabel
            if (kryptonStatusStrip1 != null && kryptonStatusStrip1.Items.Count > 0)
            {
                // Exemplo se você tiver um ToolStripStatusLabel chamado lblStatus
                if (kryptonStatusStrip1.Items[0] is ToolStripStatusLabel lblStatus)
                {
                    lblStatus.Text = mensagem;
                    lblStatus.ForeColor = cor;
                    lblStatus.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                }
            }

            // Alternativa: se você estiver usando um Label comum
            if (lblMensagemStatus != null)
            {
                lblMensagemStatus.Text = mensagem;
                lblMensagemStatus.ForeColor = cor;
                lblMensagemStatus.Visible = true;
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
    }
}
