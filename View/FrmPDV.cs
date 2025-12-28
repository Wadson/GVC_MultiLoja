using GVC.BLL;
using GVC.DALL;
using GVC.MODEL;
using Krypton.Toolkit;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using GVC.Helpers;
using GVC.DAL;


namespace GVC.View
{
    public partial class FrmPDV : KryptonForm
    {
        public enum EnumStatusVendaPDV
        {
            Aberta,
            EmAnalise,
            AguardandoPagamento,
            Concluida,
            Cancelada,
            Devolvida,
            Expirada,
            ParcialmentePago,
            Suspensa
        }
        // Definição do EnumStatusParcela em 18/12/2025
        public enum EnumStatusParcelaPDV
        {
            Pendente,
            Paga,
            Atrasada,
            ParcialmentePaga,
            Cancelada,
            Devolvida
        }


        // Imcluído acima em 18/12/2025
        #region ===== CAMPOS / ESTADO ======================================       
        private bool _clienteFoiSelecionado = false;
        private readonly string QueryVenda = "SELECT MAX(VendaID) FROM Venda";
        public int ClienteID { get; set; }
        public int ProdutoID { get; set; }
        private decimal _subtotal = 0m;
        private decimal _desconto = 0m;
        private decimal _valorTotal = 0m;
        public string StatusVenda { get; set; }

        private BindingList<ItemVendaModel> _itensBinding = new BindingList<ItemVendaModel>();
        private BindingSource _itensBindingSource = new BindingSource();

        private List<ParcelaModel> parcelasDaVenda = new List<ParcelaModel>();
        private VendaModel venda = new VendaModel();

        #endregion

        private readonly VendaService _vendaService = new VendaService();
        public string clienteSelecionado { get; set; } // não serve para nada só para preencher o parametro do construtor
        public string produtoSelecionado { get; set; } // não serve para nada só para preencher o parametro do construtor
        public long VendaID { get; private set; }

        // guarda as parcelas geradas pelo FrmGeraParcelas (mantém separadas até salvar)
        private List<ParcelaModel> _parcelasGeradas = new List<ParcelaModel>();
        private FrmLocalizarCliente frmPesquisaCliente;
        private bool formularioPesquisaAberto = false;
        // Fim ANTIGO
        private readonly ModoVenda _modo;
        private readonly long _vendaId;
        private bool _carregandoVenda = false;
        private long _vendedorId;
        private long _clienteId;
        private long _produtoId;

        #region ===== CONSTRUTOR ==============================

        public FrmPDV()// NOVA VENDA
        {
            InitializeComponent();

            _modo = ModoVenda.Nova;
            _vendaId = 0;

            InicializarFormulario(); // <<< OBRIGATÓRIO

            dgvItensVenda.CellEndEdit += dgvitens_CellEndEdit;
            this.Text = "Frente de Caixa";
            this.StateCommon.Header.Content.ShortText.Color1 = Color.Red;
            this.StateCommon.Header.Content.ShortText.Color2 = Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI", 18);
        }

        // ACIMA NOVA IMPLEMENTAÇÃO DE COMBOBOX
        public FrmPDV(long vendaId) // MODO EDIÇÃO
        {
            InitializeComponent();

            _modo = ModoVenda.Edicao;
            _vendaId = vendaId;

            InicializarFormulario();
        }
        #endregion

        #region ===== INICIALIZAÇÃO =========================================

        private void InicializarFormulario()
        {
            this.Text = "Frente de Caixa";
            this.StateCommon.Header.Content.ShortText.Color1 = Color.Red;
            this.StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI", 18);

            ConfigurarGridItensVenda();

            _itensBindingSource.DataSource = _itensBinding;
            dgvItensVenda.DataSource = _itensBindingSource;

            txtQuantidade.Text = "1";
            txtPrecoUnitario.Text = "0,00";
            txtDesconto.Text = "0,00";
            txtTotalGeral.Text = "0,00";

            AtualizarTotais();
        }
        private void CarregarVenda()
        {
            _carregandoVenda = true; // 🔒 BLOQUEIA EVENTOS

            var vendaCompleta = new VendaBLL().ObterVendaCompleta(_vendaId);

            // ===== CLIENTE =====
            ClienteID = vendaCompleta.ClienteID;
            txtClienteBuscar.Text = vendaCompleta.ClienteNome;
            txtDesconto.Text = vendaCompleta.Desconto.ToString("N2");
            txtObservacao.Text = vendaCompleta.Observacoes;

            // ===== ITENS =====
            _itensBinding.Clear();
            foreach (var item in vendaCompleta.Itens)
                _itensBinding.Add(item);

            _itensBindingSource.ResetBindings(false);

            // ===== TOTAIS =====
            AtualizarTotais();
            // ===== PARCELAS =====
            dgvParcelas.Rows.Clear();
            parcelasDaVenda.Clear();

            foreach (var p in vendaCompleta.Parcelas)
            {
                parcelasDaVenda.Add(p);

                dgvParcelas.Rows.Add(
                    p.NumeroParcela,
                    p.DataVencimento.ToString("dd/MM/yyyy"),
                    p.ValorParcela.ToString("N2"),
                    p.Status
                );
            }

            if (vendaCompleta.Parcelas.Count > 0)
            {
                numParcelas.Value = Math.Min(
                    numParcelas.Maximum,
                    Math.Max(numParcelas.Minimum, vendaCompleta.Parcelas.Count)
                );
            }

            SelecionarFormaPagamento(vendaCompleta.FormaPgtoID);

            _carregandoVenda = false; // 🔓 LIBERA EVENTOS
        }

        private void SelecionarFormaPagamento(int formaPgtoId)
        {
            for (int i = 0; i < cmbFormaPagamento.Items.Count; i++)
            {
                if (cmbFormaPagamento.Items[i] is FormaPagamentoItem item &&
                    item.Id == formaPgtoId)
                {
                    cmbFormaPagamento.SelectedIndex = i;
                    break;
                }
            }
        }



        private void AtualizarContadorItens()
        {
            int totalItens = _itensBinding.Count;
            txtTotalItens.Text = totalItens.ToString();
        }
        private void FrmPDV_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            InicializarBuscaCliente();
            InicializarBuscaVendedor();
            _itensBinding = new BindingList<ItemVendaModel>();
            _itensBinding.ListChanged += (sender, args) => AtualizarContadorItens();
            dgvItensVenda.DataSource = _itensBinding;


            HabilitarTodosOsKryptonPanels();
            EstadoInicial();


            ConfigurarGridParcelas();
            Utilitario.CarregarFormasPagamento(cmbFormaPagamento);

            if (_modo == ModoVenda.Edicao)
            {
                CarregarVenda();
                AjustarCamposEdicao();

                this.Text = $"Alterando Venda Nº {_vendaId}";
                btnSalvarVenda.Text = "Salvar Alterações";
            }
            else
            {
                int vendaID = Utilitario.ProximoId(QueryVenda);
                lblVendaID.Text = Utilitario.ZerosEsquerda(vendaID, 4);
                lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            if (_modo == ModoVenda.Nova)
            {
                EstadoInicial();
            }
        }
        #endregion

        #region ===== GRID =========================================
        private void ConfigurarGridParcelas()
        {
            dgvParcelas.Columns.Clear();

            dgvParcelas.Columns.Add("Parcela", "Parcela");
            dgvParcelas.Columns.Add("Vencimento", "Vencimento");
            dgvParcelas.Columns.Add("Valor", "Valor");
            dgvParcelas.Columns.Add("Status", "Status");

            // Largura da coluna Parcela
            dgvParcelas.Columns["Parcela"].Width = 60;

            // Centralizar Parcela
            dgvParcelas.Columns["Parcela"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // Centralizar Status
            dgvParcelas.Columns["Status"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // Ocultar coluna "Status"
            dgvParcelas.Columns["Status"].Visible = false;


            // Alinhar Valor à direita
            dgvParcelas.Columns["Valor"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;

            // Configurações gerais
            dgvParcelas.AllowUserToAddRows = false;
            dgvParcelas.RowHeadersVisible = false;
        }
        private void ConfigurarGridItensVenda()
        {
            dgvItensVenda.AutoGenerateColumns = false;
            dgvItensVenda.Columns.Clear();

            // 🔹 Coluna Código
            dgvItensVenda.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Código",
                DataPropertyName = nameof(ItemVendaModel.ProdutoID),
                Width = 70, // 🔹 Largura reduzida
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 9F, FontStyle.Regular)
                },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            // 🔹 Coluna Descrição
            dgvItensVenda.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Descrição",
                DataPropertyName = nameof(ItemVendaModel.ProdutoDescricao),
                Width = 400, // 🔹 Ajuste fino
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleLeft,
                    Font = new Font("Segoe UI", 9F, FontStyle.Regular)
                },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            // 🔹 Coluna Qtde (CENTRALIZADA)
            dgvItensVenda.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Qtde",
                DataPropertyName = nameof(ItemVendaModel.Quantidade),
                Width = 60,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter, // 🔹 CENTRALIZADO
                    Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                    BackColor = Color.WhiteSmoke, // 🔹 Fundo diferenciado para campo editável
                    SelectionBackColor = Color.LightBlue
                },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            // 🔹 Coluna Preço
            dgvItensVenda.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Preço Unit.",
                DataPropertyName = nameof(ItemVendaModel.PrecoUnitario),
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight, // 🔹 Alinhado à direita
                    Font = new Font("Segoe UI", 9F, FontStyle.Regular)
                },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            // 🔹 Coluna Subtotal
            dgvItensVenda.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Subtotal",
                DataPropertyName = nameof(ItemVendaModel.Subtotal),
                Width = 120,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight, // 🔹 Alinhado à direita
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold), // 🔹 Negrito para valor importante
                    ForeColor = Color.DarkGreen, // 🔹 Cor verde para valores monetários
                    BackColor = Color.LightYellow // 🔹 Fundo diferenciado
                },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            // 🔹 Coluna Remover
            dgvItensVenda.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Rm",
                Text = "✕",
                UseColumnTextForButtonValue = true,
                Width = 30,
                FlatStyle = FlatStyle.Flat,
                HeaderText = "Rm", // ← Mantenha só esta

                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(192, 0, 0),
                    SelectionBackColor = Color.FromArgb(220, 0, 0)
                },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            // 🔹 Configurações gerais do Grid
            dgvItensVenda.AllowUserToAddRows = false;
            dgvItensVenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItensVenda.MultiSelect = false; // 🔹 Só permite selecionar uma linha por vez
            dgvItensVenda.EnableHeadersVisualStyles = false;
            dgvItensVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvItensVenda.ColumnHeadersHeight = 30; // 🔹 Altura padrão
            dgvItensVenda.RowHeadersVisible = false;
            dgvItensVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvItensVenda.AllowUserToResizeRows = false;
            dgvItensVenda.RowTemplate.Height = 28; // 🔹 Altura das linhas

            // 🔹 Estilo dos cabeçalhos
            dgvItensVenda.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(0, 2, 0, 2) // 🔹 Espaçamento vertical interno
            };

            // 🔹 Estilo das linhas alternadas (zebra)
            dgvItensVenda.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(245, 245, 245) // 🔹 Cinza muito claro
            };

            // 🔹 Estilo de seleção
            dgvItensVenda.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvItensVenda.DefaultCellStyle.SelectionForeColor = Color.Black;
        }


        #endregion

        #region ===== ITENS =======================================

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {

            if (ProdutoID <= 0)
            {
                MessageBox.Show("Produto inválido.");
                return;
            }

            if (!decimal.TryParse(txtPrecoUnitario.Text, out decimal preco))
                return;

            int qtd = Convert.ToInt32(txtQuantidade.Text);

            // Busca o item na lista de itens
            var item = _itensBinding.FirstOrDefault(i => i.ProdutoID == ProdutoID);

            // Se o item já existir, atualiza a quantidade
            if (item != null)
            {
                item.Quantidade += qtd;
                // 🔴 CORREÇÃO: Recalcular o Subtotal
                item.Subtotal = item.Quantidade * item.PrecoUnitario;
            }
            else
            {
                // Adiciona um novo item com o nome do produto
                _itensBinding.Add(new ItemVendaModel
                {
                    VendaID = venda.VendaID,
                    ProdutoID = ProdutoID,
                    Quantidade = qtd,
                    PrecoUnitario = preco,
                    Subtotal = qtd * preco,
                    DescontoItem = 0m,
                    ProdutoDescricao = txtProdutoBuscar.Text
                });
            }

            // Atualiza o binding da lista de itens
            _itensBindingSource.ResetBindings(false);

            // Força a atualização da grid
            dgvItensVenda.Refresh();

            // Atualiza os totais da venda
            AtualizarTotais();

            // Limpa os campos do produto
            LimparCamposProduto();

            // Foca no campo Nome do Produto
            txtProdutoBuscar.Focus();
            // ✅ LIBERA GRID E PRÓXIMO PASSO
            EstadoItemAdicionado();
        }

        #endregion

        #region ===== CÁLCULOS =========================

        private void AtualizarSubtotalItem()
        {
            decimal.TryParse(txtQuantidade.Text, out decimal qtd);
            decimal.TryParse(txtPrecoUnitario.Text, out decimal preco);
        }
        private void AtualizarTotais()
        {
            // Proteção: se não houver itens ou _itensBinding for null
            if (_itensBinding == null || _itensBinding.Count == 0)
            {
                _subtotal = 0m;
            }
            else
            {
                // Soma apenas os valores não nulos, tratando null como 0
                _subtotal = (decimal)_itensBinding.Sum(i => i.Subtotal);
            }

            // Lê o desconto do textbox
            if (!decimal.TryParse(txtDesconto.Text, out _desconto))
                _desconto = 0m;

            // Blindagem: desconto não pode ser negativo nem maior que o subtotal
            if (_desconto < 0m) _desconto = 0m;
            if (_desconto > _subtotal) _desconto = _subtotal;

            // Calcula o total final
            _valorTotal = _subtotal - _desconto;

            // Lê o valor recebido
            decimal recebido = 0m;
            decimal.TryParse(txtValorRecebido.Text, out recebido);

            // Calcula troco (nunca negativo)
            decimal troco = Math.Max(0m, recebido - _valorTotal);

            // Atualiza os campos na tela
            txtSubTotal.Text = _subtotal.ToString("N2");
            txtTotalGeral.Text = _valorTotal.ToString("N2");
            txtTroco.Text = troco.ToString("N2");
        }

        #endregion

        #region ===== EVENTOS DE TEXTO ====================

        private void txtQuantidade_TextChanged(object sender, EventArgs e) => AtualizarSubtotalItem();
        private void txtPrecoUnitario_TextChanged(object sender, EventArgs e) => AtualizarSubtotalItem();
        private void cmbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        #endregion

        #region Eventos ===== SALVAR =================================


        private void btnSalvarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClienteID <= 0)
                    throw new Exception("Selecione um cliente.");

                if (_itensBinding.Count == 0)
                    throw new Exception("Adicione itens à venda.");

                if (cmbFormaPagamento.SelectedItem is not FormaPagamentoItem forma)
                    throw new Exception("Selecione uma forma de pagamento válida.");

                // ===============================
                // MONTAR VENDA
                // ===============================
                var vendaModel = new VendaModel
                {
                    ClienteID = ClienteID,
                    FormaPgtoID = forma.Id,
                    DataVenda = DateTime.Now,
                    ValorTotal = Convert.ToDecimal(txtTotalGeral.Text),
                    Desconto = Convert.ToDecimal(txtDesconto.Text),
                    Observacoes = txtObservacao.Text,
                    StatusVenda = CalcularStatusVendaPorFormaPgto(forma.Descricao)
                };

                // ===============================
                // MONTAR PARCELAS
                // ===============================
                var parcelas = MontarParcelasDaVenda();

                // ===============================
                // VALIDAÇÃO CREDIÁRIO
                // ===============================
                if (forma.Descricao.Contains("Crediário", StringComparison.OrdinalIgnoreCase))
                {
                    if (parcelas.Count == 0)
                    {
                        MessageBox.Show("Gere as parcelas antes de salvar uma venda no crediário.");
                        return;
                    }
                }

                // ===============================
                // SALVAR (NOVA x EDIÇÃO)
                // ===============================
                var bll = new VendaBLL();

                if (_modo == ModoVenda.Nova)
                {
                    bll.SalvarVendaCompleta(vendaModel, _itensBinding.ToList(), parcelas);
                    MessageBox.Show(
                                    "✅ VENDA CONCLUÍDA COM SUCESSO ✅\n\n" +
                                    "Os dados foram registrados corretamente.\n\n" +
                                    "Deseja continuar para impressão do recibo?",
                                    "CONFIRMAÇÃO DE VENDA",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button1
                                    );

                    LimparFormulario();
                }
                else // EDIÇÃO
                {
                    vendaModel.VendaID = _vendaId;
                    bll.AtualizarVendaCompleta(vendaModel, _itensBinding.ToList(), parcelas);

                    MessageBox.Show(
                                    "🔄 VENDA ATUALIZADA COM SUCESSO 🔄\n\n" +
                                    "Os dados foram modificados corretamente.",
                                    "CONFIRMAÇÃO DE ATUALIZAÇÃO",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button1
                                    );
                    this.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(
                    $"Erro SQL (Número: {sqlEx.Number}): {sqlEx.Message}",
                    "Erro SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Debug.WriteLine("=== ERRO SQL ===");
                Debug.WriteLine(sqlEx);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Erro ao salvar venda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        #endregion

        #region ===== AUXILIARES =====

        private void LimparCamposProduto()
        {
            ProdutoID = 0;
            txtProdutoBuscar.Clear();
            txtQuantidade.Text = "1";
            txtPrecoUnitario.Text = "0,00";
        }
        private void LimparFormulario()
        {
            // ===== ESTADO =====
            ClienteID = 0;
            ProdutoID = 0;
            _clienteFoiSelecionado = false;

            // ===== CLIENTE =====
            txtClienteBuscar.Clear();
            txtVendedorBuscar.Clear();

            // ===== ITENS =====
            _itensBinding.Clear();
            dgvItensVenda.Refresh();

            // ===== PARCELAS =====
            dgvParcelas.Rows.Clear();
            parcelasDaVenda.Clear();
            _parcelasGeradas.Clear();


            // ===== CAMPOS FINANCEIROS =====
            txtDesconto.Text = "0,00";
            txtSubTotal.Text = "0,00";
            txtTotalGeral.Text = "0,00";
            txtValorRecebido.Text = "0,00";
            txtTroco.Text = "0,00";
            txtObservacao.Clear();

            // ===== FORMAS / PARCELAMENTO =====
            cmbFormaPagamento.SelectedIndex = -1;
            numParcelas.Value = 1;
            numIntervalo.Value = 30;
            dtPrimeira.Value = DateTime.Today;

            // ===== PRODUTO =====
            LimparCamposProduto();

            // ===== NOVO ID DE VENDA =====
            int vendaID = Utilitario.ProximoId(QueryVenda);
            lblVendaID.Text = Utilitario.ZerosEsquerda(vendaID, 4);

            // ===== FOCO =====
            txtClienteBuscar.Focus();
        }

        #endregion
        #region Eventos

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            AtualizarTotais();
        }

        private void cmbFormaPgto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se nada estiver selecionado, desabilita o botão
            if (cmbFormaPagamento.SelectedItem == null)
            {
                btnGerarParcelas.Enabled = false;
                btnCancelarParcelas.Enabled = false;
                return;
            }

            // Captura o texto selecionado
            string formaPgto = cmbFormaPagamento.SelectedItem.ToString();

            // Lista de formas de pagamento que habilitam o botão
            var formasValidas = new[] { "Boleto Bancário", "Cheque", "Crediário", "Financiamento" };

            // Habilita o botão se a forma de pagamento estiver na lista
            btnGerarParcelas.Enabled = formasValidas.Contains(formaPgto);
            btnCancelarParcelas.Enabled = formasValidas.Contains(formaPgto);
            // Executa lógica adicional se houver item selecionado
            if (cmbFormaPagamento.SelectedIndex >= 0)
            {
                EstadoFormaPagamentoSelecionada();
            }
        }

        #region Helpers
        private void ConfirmarCliente()
        {
            if (lstClientes.SelectedItem is ClienteMODEL vendedor)
            {
                _vendedorId = vendedor.ClienteID;
                txtClienteBuscar.Text = vendedor.Nome;
            }

            lstClientes.Visible = false;

            // Próximo campo do PDV
            txtProdutoBuscar.Focus();
        }
        private void ConfirmarProduto()
        {
            if (lstProdutos.SelectedItem is ProdutosModel produto)
            {
                _produtoId = produto.ProdutoID;
                txtProdutoBuscar.Text = produto.NomeProduto;
            }

            lstProdutos.Visible = false;

            // Próximo campo do PDV
            txtQuantidade.Focus();
        }
        private void ConfirmarVendedor()
        {
            if (lstVendedores.SelectedItem is ClienteMODEL vendedor)
            {
                _vendedorId = vendedor.ClienteID;
                txtVendedorBuscar.Text = vendedor.Nome;
            }

            lstVendedores.Visible = false;

            // Próximo campo do PDV
            txtProdutoBuscar.Focus();
        }
        private void InicializarBuscaCliente()
        {
            lstClientes.Visible = false;
            lstClientes.BringToFront();
            lstClientes.TabStop = false;

            txtClienteBuscar.TabIndex = 1; // ajuste conforme seu fluxo
        }
        private void SelecionarCliente()
        {
            if (lstClientes.SelectedItem is ClienteMODEL vendedor)
            {
                _clienteId = vendedor.ClienteID;
                txtClienteBuscar.Text = vendedor.Nome;
            }

            lstClientes.Visible = false;
            txtProdutoBuscar.Focus();
        }
        private void SelecionarProduto()
        {
            if (lstProdutos.SelectedItem is ProdutosModel vendedor)
            {
                _produtoId = vendedor.ProdutoID;
                txtProdutoBuscar.Text = vendedor.NomeProduto;
            }

            lstProdutos.Visible = false;
            txtQuantidade.Focus();
        }
        private void InicializarBuscaVendedor()
        {
            lstVendedores.Visible = false;
            lstVendedores.BringToFront();
            lstVendedores.TabStop = false;

            txtVendedorBuscar.TabIndex = 1; // ajuste conforme seu fluxo
        }

        private void SelecionarVendedor()
        {
            if (lstVendedores.SelectedItem is ClienteMODEL vendedor)
            {
                _vendedorId = vendedor.ClienteID;
                txtVendedorBuscar.Text = vendedor.Nome;
            }

            lstVendedores.Visible = false;
            txtProdutoBuscar.Focus();
        }

        private void HabilitarTodosOsKryptonPanels()
        {
            foreach (Control c in tableLayoutPanel2.Controls)
            {
                if (c is KryptonPanel kp)
                    kp.Enabled = true;
            }
        }

        private void EstadoInicial()
        {
            // CLIENTE
            txtClienteBuscar.Enabled = true;

            // PRODUTO
            txtProdutoBuscar.Enabled = false;
            txtProdutoBuscar.Enabled = false;
            txtQuantidade.Enabled = false;
            txtPrecoUnitario.Enabled = false;
            btnAdicionarItem.Enabled = false;

            // ITENS / PAGAMENTO
            dgvItensVenda.Enabled = false;
            cmbFormaPagamento.Enabled = false;
            txtValorRecebido.Enabled = false;
            txtDesconto.Enabled = false;
            txtObservacao.Enabled = false;

            // PARCELAS
            btnGerarParcelas.Enabled = false;
            numParcelas.Enabled = false;
            numIntervalo.Enabled = false;
            dtPrimeira.Enabled = false;
            dgvParcelas.Enabled = false;

            txtClienteBuscar.Focus();
        }


        private void SetEnabledRecursivo(Control parent, bool enabled)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // NÃO desabilita labels
                if (ctrl is Label)
                    continue;

                ctrl.Enabled = enabled;

                // Se tiver filhos, aplica também
                if (ctrl.HasChildren)
                    SetEnabledRecursivo(ctrl, enabled);
            }
        }


        private void EstadoClienteSelecionado()
        {
            txtProdutoBuscar.Enabled = true;
            txtProdutoBuscar.Enabled = true;
            txtQuantidade.Enabled = true;
            txtPrecoUnitario.Enabled = true;
            btnAdicionarItem.Enabled = true;
            txtVendedorBuscar.Enabled = true;
            txtProdutoBuscar.Enabled = true;
        }

        private void EstadoItemAdicionado()
        {
            dgvItensVenda.Enabled = true;

            cmbFormaPagamento.Enabled = true;
            txtValorRecebido.Enabled = true;
            txtDesconto.Enabled = true;
            btnGerarParcelas.Enabled = true;

            cmbFormaPagamento.Focus();
        }


        private void EstadoFormaPagamentoSelecionada()
        {
            btnGerarParcelas.Enabled = true;
            numIntervalo.Enabled = true;
            numParcelas.Enabled = true;
            dtPrimeira.Enabled = true;
            dgvParcelas.Enabled = true;
        }



        private void AtualizarSubtotalItem2()
        {
            decimal quantidade = 0m;
            decimal preco = 0m;

            if (!string.IsNullOrWhiteSpace(txtQuantidade.Text))
                decimal.TryParse(txtQuantidade.Text, out quantidade);

            if (!string.IsNullOrWhiteSpace(txtPrecoUnitario.Text))
                decimal.TryParse(txtPrecoUnitario.Text, out preco);
        }

        #endregion

        private void FrmPDV_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }



        private void FrmPDV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && lstVendedores.Visible && lstVendedores.Focused)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                ConfirmarVendedor();
            }
        }
        private void txtPrecoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            AtualizarSubtotalItem2();
        }
        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            AtualizarSubtotalItem2();
        }
        private void dgvitens_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            dgvItensVenda.CommitEdit(DataGridViewDataErrorContexts.Commit);

            var item = dgvItensVenda.Rows[e.RowIndex].DataBoundItem as ItemVendaModel;
            if (item == null) return;

            // Blindagem + recálculo imediato
            if (item.Quantidade < 0)
                item.Quantidade = 0;

            if (item.PrecoUnitario < 0)
                item.PrecoUnitario = 0;

            if (item.DescontoItem < 0)
                item.DescontoItem = 0;

            decimal subtotalBruto = item.Quantidade * item.PrecoUnitario;

            if (item.DescontoItem > subtotalBruto)
                item.DescontoItem = subtotalBruto;

            item.Subtotal = subtotalBruto - item.DescontoItem;

            _itensBindingSource.ResetBindings(false);
            AtualizarTotais();
        }
        private void txtValorRecebido_Leave(object sender, EventArgs e)
        {
            AtualizarTotais();
        }
        private void btnCancelarParcelas_Click(object sender, EventArgs e)
        {
            //5.AJUSTE IMPORTANTE NO CANCELAR PARCELAS

            dgvParcelas.Rows.Clear();
            parcelasDaVenda.Clear();

            numParcelas.Value = 1;
            numIntervalo.Value = 30;
            dtPrimeira.Value = DateTime.Today;
        }
        private void GerarParcelas()
        {
            if (_carregandoVenda)
                return; // 🔒 NÃO GERA PARCELAS AO CARREGAR

            // pode deletar acima se não der certo
            dgvParcelas.Rows.Clear();

            if (!decimal.TryParse(txtTotalGeral.Text, out decimal total) || total <= 0)
            {
                MessageBox.Show("Total da venda inválido.");
                return;
            }

            int qtdParcelas = (int)numParcelas.Value;
            int intervaloDias = (int)numIntervalo.Value;
            DateTime dataInicial = dtPrimeira.Value.Date;

            if (qtdParcelas <= 0)
            {
                MessageBox.Show("Quantidade de parcelas inválida.");
                return;
            }

            // Valor base da parcela
            decimal valorBase = Math.Round(total / qtdParcelas, 2);

            // Ajuste de centavos
            decimal totalCalculado = valorBase * qtdParcelas;
            decimal diferenca = total - totalCalculado;

            for (int i = 1; i <= qtdParcelas; i++)
            {
                DateTime vencimento = dataInicial.AddDays(intervaloDias * (i - 1));

                decimal valorParcela = valorBase;

                // Última parcela absorve a diferença
                if (i == qtdParcelas)
                    valorParcela += diferenca;

                dgvParcelas.Rows.Add(
                    i,
                    vencimento.ToString("dd/MM/yyyy"),
                    valorParcela.ToString("N2"),
                    1 // Status Aberta
                );
            }
        }
        private void btnGerar_Click(object sender, EventArgs e)
        {
            GerarParcelas();
        }

        private void numParcelas_ValueChanged(object sender, EventArgs e)
        {
            GerarParcelas();
        }
        private void numIntervalo_ValueChanged(object sender, EventArgs e)
        {
            GerarParcelas();
        }

        #region ==========INICIO DOS MÉTODOS DE VENDA==========
        //3. MÉTODO CENTRAL: MONTAR AS PARCELAS DA VENDA
        private List<ParcelaModel> MontarParcelasDaVenda()
        {
            var parcelas = new List<ParcelaModel>();

            int qtd = (int)numParcelas.Value;
            if (qtd <= 0)
                return parcelas;

            decimal valorTotal = Convert.ToDecimal(txtTotalGeral.Text);
            decimal valorParcelaBase = valorTotal / qtd;
            decimal somaParcelas = 0m;

            DateTime dataInicial = dtPrimeira.Value.Date;
            int intervaloDias = (int)numIntervalo.Value;

            bool pagamentoAVista = FormaPagamentoEhAVista(cmbFormaPagamento.Text);

            for (int i = 1; i <= qtd; i++)
            {
                DateTime vencimento = dataInicial.AddDays(intervaloDias * (i - 1));

                decimal valorParcela;
                if (i == qtd)
                    valorParcela = valorTotal - somaParcelas;
                else
                {
                    valorParcela = Math.Round(valorParcelaBase, 2);
                    somaParcelas += valorParcela;
                }

                parcelas.Add(new ParcelaModel
                {
                    NumeroParcela = i,
                    DataVencimento = vencimento,
                    ValorParcela = valorParcela,

                    // 🔥 AQUI ESTÁ A CORREÇÃO
                    ValorRecebido = pagamentoAVista ? valorParcela : 0m,
                    Status = pagamentoAVista ? "Paga" : "Pendente",

                    Juros = 0m,
                    Multa = 0m,
                    Observacao = null
                });
            }

            return parcelas;
        }
        private bool FormaPagamentoEhAVista(string formaPgto)
        {
            if (string.IsNullOrWhiteSpace(formaPgto))
                return false;

            string forma = formaPgto.ToUpperInvariant();

            return forma.Contains("DINHEIRO") ||
                   forma.Contains("PIX") ||
                   forma.Contains("DÉBITO") ||
                   forma.Contains("DEBITO") ||
                   forma.Contains("TRANSFERÊNCIA") ||
                   forma.Contains("TRANSFERENCIA");
        }
        private string CalcularStatusVendaPorParcelas(List<ParcelaModel> parcelas)
        {
            if (parcelas == null || !parcelas.Any())
                return null; // deixa quem chamou decidir

            decimal total = parcelas.Sum(p => p.ValorParcela + p.Juros + p.Multa);
            decimal recebido = parcelas.Sum(p => p.ValorRecebido);

            if (recebido <= 0)
                return EnumStatusVendaPDV.Aberta.ToDb();

            if (recebido >= total)
                return EnumStatusVendaPDV.Concluida.ToDb();

            return EnumStatusVendaPDV.ParcialmentePago.ToDb();
        }


        //4. IMPLEMENTAÇÃO FINAL DO BOTÃO SALVAR VENDA
        private string CalcularStatusVendaPorFormaPgto(string formaPgto)
        {
            if (string.IsNullOrWhiteSpace(formaPgto))
                return "Aguardando Pagamento";
            string forma = formaPgto.ToUpperInvariant();

            if (forma.Contains("DINHEIRO") ||
                forma.Contains("PIX") ||
                forma.Contains("DÉBITO") ||
                forma.Contains("DEBITO") ||
                forma.Contains("CRÉDITO") ||
                forma.Contains("CREDITO") ||
                forma.Contains("TRANSFERÊNCIA") ||
                forma.Contains("TRANSFERENCIA"))
            {
                return "Concluída";
            }

            return "Aberta";
        }


        #endregion
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpa todos os TextBox da tela
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox)
                    ((KryptonTextBox)ctrl).Clear();

                if (ctrl is Krypton.Toolkit.KryptonTextBox)
                    ((Krypton.Toolkit.KryptonTextBox)ctrl).Clear();
            }

            // Limpa o DataGridView
            dgvItensVenda.Rows.Clear();
            dgvParcelas.Rows.Clear();
            // Se quiser também resetar seleções
            dgvItensVenda.ClearSelection();
            dgvParcelas.ClearSelection();

            // Define o resultado do diálogo como Cancelar
            this.DialogResult = DialogResult.Cancel;
            txtQuantidade.Text = "1";
            txtPrecoUnitario.Text = "0,00";
            txtSubTotal.Text = "0,00";
            txtValorRecebido.Text = "0,00";
            txtTroco.Text = "0,00";
            txtTotalGeral.Text = "0,00";

            AtualizarTotais();
            LimparFormulario();
            EstadoInicial();

        }

        private void txtFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjustarCamposEdicao()
        {
            bool possuiPagamento = new VendaBLL().ExistePagamento(_vendaId);

            if (possuiPagamento)
            {
                dgvItensVenda.Enabled = false;
                dgvParcelas.Enabled = false;
                btnAdicionarItem.Enabled = false;
                btnGerarParcelas.Enabled = false;

                txtDesconto.Enabled = false;
                cmbFormaPagamento.Enabled = false;

                //lblAviso.Text = "Venda possui pagamentos. Alteração bloqueada.";
                //lblAviso.Visible = true;
            }
        }

        private void txtObservacao_TextChanged(object sender, EventArgs e)
        {
        }

        private void kryptonPanel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnListarControles_Click(object sender, EventArgs e)
        {
            // Caminho onde o arquivo será salvo
            string caminho = @"D:\ControlesFormFrmPDV.txt";

            FrmBaixarParcela.SalvarNomesControles(this, caminho);

            MessageBox.Show("Lista de controles salva em: " + caminho);
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {

        }

        private void dgvItensVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvItensVenda.Columns.Count - 1 && e.RowIndex >= 0)
            {
                var item = dgvItensVenda.Rows[e.RowIndex].DataBoundItem as ItemVendaModel;
                if (item != null)
                {
                    _itensBinding.Remove(item);
                    AtualizarTotais();
                }
            }
        }

        private void FrmPDV_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void txtVendedorBuscar_TextChanged(object sender, EventArgs e)
        {
            var texto = txtVendedorBuscar.Text.Trim();

            if (texto.Length == 0)
            {
                lstVendedores.Visible = false;
                return;
            }

            var dal = new ClienteDal();
            var vendedores = dal.ListarVendedores(texto);

            lstVendedores.DataSource = null;
            lstVendedores.DataSource = vendedores;
            lstVendedores.DisplayMember = "Nome";
            lstVendedores.ValueMember = "ClienteID";
            if (_vendedorId > 0 && !string.IsNullOrWhiteSpace(txtVendedorBuscar.Text))
            {
                txtProdutoBuscar.Enabled = true;
                txtProdutoBuscar.Focus();
            }
            lstVendedores.Visible = vendedores.Count > 0;
        }

        private void txtVendedorBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && lstVendedores.Visible)
            {
                lstVendedores.Focus();

                if (lstVendedores.SelectedIndex < 0 && lstVendedores.Items.Count > 0)
                    lstVendedores.SelectedIndex = 0;

                e.Handled = true;
            }
        }

        private void lstVendedores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConfirmarVendedor();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                lstVendedores.Visible = false;
                txtVendedorBuscar.Focus();
            }
        }

        private void lstVendedores_DoubleClick(object sender, EventArgs e)
        {
            SelecionarVendedor();
        }

        private void lstVendedores_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.IsInputKey = true;
        }

        private void lstClientes_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.IsInputKey = true;
        }

        private void lstClientes_DoubleClick(object sender, EventArgs e)
        {
            SelecionarCliente();
        }

        private void lstClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConfirmarCliente();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                lstClientes.Visible = false;
                txtClienteBuscar.Focus();
            }
        }

        private void txtClienteBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && lstClientes.Visible)
            {
                lstClientes.Focus();

                if (lstClientes.SelectedIndex < 0 && lstClientes.Items.Count > 0)
                    lstClientes.SelectedIndex = 0;

                e.Handled = true;
            }
        }

        private void txtClienteBuscar_TextChanged(object sender, EventArgs e)
        {
            var texto = txtClienteBuscar.Text.Trim();

            if (texto.Length == 0)
            {
                lstClientes.Visible = false;
                return;
            }

            var dal = new ClienteDal();
            var vendedores = dal.ListarClienteDinamico(texto);

            lstClientes.DataSource = null;
            lstClientes.DataSource = vendedores;
            lstClientes.DisplayMember = "Nome";
            lstClientes.ValueMember = "ClienteID";
            if (_clienteId > 0 && !string.IsNullOrWhiteSpace(txtClienteBuscar.Text))
            {
                EstadoClienteSelecionado();
                txtVendedorBuscar.Focus();
            }

            lstClientes.Visible = vendedores.Count > 0;
        }
        private void txtProdutoBuscar_TextChanged(object sender, EventArgs e)
        {
            var texto = txtProdutoBuscar.Text.Trim();

            if (texto.Length == 0)
            {
                lstProdutos.Visible = false;
                return;
            }

            var dal = new ProdutoDALL();
            var vendedores = dal.ListarProdutoDinamico(texto);

            lstProdutos.DataSource = null;
            lstProdutos.DataSource = vendedores;
            lstProdutos.DisplayMember = "NomeProduto";
            lstProdutos.ValueMember = "ProdutoID";
            if (_produtoId > 0 && !string.IsNullOrWhiteSpace(txtProdutoBuscar.Text))
            {
                txtQuantidade.Focus();
            }
            lstProdutos.Visible = vendedores.Count > 0;
        }

        private void lstProdutos_DoubleClick(object sender, EventArgs e)
        {
            SelecionarProduto();
        }

        private void lstProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConfirmarProduto();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                lstProdutos.Visible = false;
                txtProdutoBuscar.Focus();
            }
        }

        private void lstProdutos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.IsInputKey = true;
        }       
    }
}

/*
                   
//========================STATUS PARA VENDA ABAIXO=============================

            Aberta               → Venda registrada, mas ainda não concluída (em andamento).
            Em Análise           → Aguardando aprovação de crédito ou validação interna.
            Aguardando Pagamento → Venda confirmada, mas o cliente ainda não pagou.
            Concluída            → Venda finalizada com sucesso, pagamento confirmado.
            Cancelada            → Venda anulada por desistência, erro ou acordo.
            Devolvida            → Venda concluída, mas houve devolução do produto/serviço.
            Expirada             → Quando o prazo de pagamento ou validade da proposta passou sem conclusão.
            Parcialmente Pago    → Cliente pagou parte do valor, mas ainda há saldo pendente.
            Suspensa             → Venda temporariamente interrompida (ex.: problemas logísticos ou decisão 


// ========================STATUS PARA PARCELA ABAIXO=============================

            Aberta               → não faz sentido para parcela (é mais para venda)
            Atrasada             → Parcela cujo vencimento já passou e não foi paga.
            Aguardando Pagamento → melhor usar "Pendente"
            Pago                 → melhor usar "Paga"
            Cancelada            → Parcela anulada, não precisa mais ser paga (ex.: erro de lançamento, acordo).
            Devolvida            → raro em parcela, mas pode ter
            Parcialmente Pago    → melhor "Parcialmente Paga"

          //===========TABELA PARCELA STATUS==============================================

                    */
#endregion