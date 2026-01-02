using GVC.BLL;
using GVC.DAL;
using GVC.DALL;
using GVC.DTO;
using GVC.MODEL;
using GVC.MODEL.Enums;
using GVC.UTIL;
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


namespace GVC.View
{
    public partial class FrmPDVendas : KryptonForm
    {
        private readonly ModoVenda _modo;
        private readonly long _vendaId;
        public long VendaID { get; private set; }

        private bool _clienteFoiSelecionado = false;
        private bool _ignorarEventosBusca = false;

        public long VendedorID { get; set; }


        public long ClienteID { get; set; }
        public long ProdutoID { get; set; }
        public string NomeCliente { get; set; }

        // ----------------------
        // Valores Financeiros
        // ----------------------
        private decimal _subtotal = 0m;
        private decimal _desconto = 0m;
        private decimal _valorTotal = 0m;

        // ----------------------
        // Itens e Parcelas
        // ----------------------
        private BindingList<ItemVendaModel> _itensBinding = new BindingList<ItemVendaModel>();
        private BindingSource _itensBindingSource = new BindingSource();

        // ----------------------
        // Modelos e Serviços
        // ----------------------
        private VendaModel venda = new VendaModel();
        private readonly VendaService _vendaService = new VendaService();

        // ----------------------
        // Interface
        // ----------------------
        private FrmLocalizarCliente frmPesquisaCliente;
        private bool formularioPesquisaAberto = false;
        private bool _ignorandoBuscar = false;

        private readonly string QueryVenda = "SELECT MAX(VendaID) FROM Venda";

        public FrmPDVendas()// NOVA VENDA
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
        public FrmPDVendas(long vendaId) // MODO EDIÇÃO
        {
            InitializeComponent();

            _modo = ModoVenda.Edicao;
            _vendaId = vendaId;

            InicializarFormulario();
        }
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
            AtualizarTotais();
        }

        private void AtualizarContadorItens()
        {
            int totalItens = _itensBinding.Count;
            txtTotalItens.Text = totalItens.ToString();
        }
        private void FrmPDVendas_Load(object sender, EventArgs e)
        {
            txtProdutoBuscar.Enabled = true;
            this.KeyPreview = true;

            _itensBinding = new BindingList<ItemVendaModel>();
            _itensBinding.ListChanged += (sender, args) => AtualizarContadorItens();
            dgvItensVenda.DataSource = _itensBinding;


            if (_modo == ModoVenda.Edicao)
            {
                AjustarCamposEdicao();

                this.Text = $"Alterando Venda Nº {_vendaId}";
                //btnSalvarVenda.Text = "Salvar Alterações";
            }
            else
            {
                int vendaID = Utilitario.ProximoId(QueryVenda);
                txtVendaID.Text = Utilitario.ZerosEsquerda(vendaID, 4);
                txtDataVenda.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            if (_modo == ModoVenda.Nova)
            {
                //EstadoInicial();
            }
        }
        #endregion

        #region ===== GRID =========================================

        private void ConfigurarGridItensVenda()
        {
            dgvItensVenda.AutoGenerateColumns = false;
            dgvItensVenda.Columns.Clear();

            // 🔹 Coluna Código
            dgvItensVenda.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cód",
                DataPropertyName = nameof(ItemVendaModel.ProdutoID),
                Width = 50, // 🔹 Largura reduzida
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 9F, FontStyle.Regular)
                },
                HeaderCell = { Style = { Alignment = DataGridViewContentAlignment.MiddleCenter } }
            });

            // 🔹 Coluna Descrição
            // 🔹 Coluna Descrição
            dgvItensVenda.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Descrição",
                DataPropertyName = nameof(ItemVendaModel.ProdutoDescricao),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, // 🔑 Expande dinamicamente
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
                Width = 50,
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
                Width = 70,
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
                Width = 90,
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
            dgvItensVenda.ColumnHeadersHeight = 25; // 🔹 Altura padrão
            dgvItensVenda.RowHeadersVisible = false;
            dgvItensVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvItensVenda.AllowUserToResizeRows = false;
            dgvItensVenda.RowTemplate.Height = 28; // 🔹 Altura das linhas

            // 🔹 Estilo dos cabeçalhos
            dgvItensVenda.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 9.5F, FontStyle.Regular),
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
                Utilitario.Mensagens.Aviso("Ops! Esse produto não existe no cadastro. Deseja tentar outro?");
                return;
            }

            if (!decimal.TryParse(txtPrecoUnitario.Text, out decimal preco))
                return;

            if (!int.TryParse(txtQuantidade.Text, out int qtd) || qtd <= 0)
                return;

            // Busca o item na lista
            var item = _itensBinding.FirstOrDefault(i => i.ProdutoID == ProdutoID);

            if (item != null)
            {
                item.Quantidade += qtd;
                item.Subtotal = item.Quantidade * item.PrecoUnitario;
            }
            else
            {
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

            // Atualizações visuais
            _itensBindingSource.ResetBindings(false);
            dgvItensVenda.Refresh();

            AtualizarTotais();

            // Limpeza controlada (SEM disparar busca)
            _ignorandoBuscar = true;

            LimparCamposProduto(); // ← aqui deve limpar txtProdutoBuscar, txtQuantidade, txtPrecoUnitario

            ProdutoID = 0;

            _ignorandoBuscar = false;

            txtProdutoBuscar.Focus();
        }


        #endregion

        #region ===== CÁLCULOS =========================


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

            // Blindagem: desconto não pode ser negativo nem maior que o subtotal
            if (_desconto < 0m) _desconto = 0m;
            if (_desconto > _subtotal) _desconto = _subtotal;

            // Calcula o total final
            _valorTotal = _subtotal - _desconto;

            // Atualiza os campos na tela
            txtSubTotal.Text = _subtotal.ToString("N2");
        }

        private void btnSalvarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                // ===============================
                // 🔒 VALIDAÇÕES OBRIGATÓRIAS
                // ===============================

                if (ClienteID <= 0)
                {
                    Utilitario.Mensagens.Aviso("Selecione um cliente.");
                    return;
                }

                if (_itensBinding.Count == 0)
                {
                    Utilitario.Mensagens.Aviso("Adicione itens à venda.");
                    return;
                }
                // ===============================
                // MONTAR VENDA
                // ===============================
                var vendaModel = new VendaModel
                {
                    ClienteID = ClienteID,
                    //FormaPgtoID = forma.Id,
                    DataVenda = DateTime.Now,
                    //Observacoes = txtObservacao.Text,
                    //StatusVenda = CalcularStatusVendaPorFormaPgto(forma.Descricao),
                    VendedorID = VendedorID > 0 ? VendedorID : 0,
                };


                // ===============================
                // SALVAR (NOVA x EDIÇÃO)
                // ===============================
                var bll = new VendaBLL();

                if (_modo == ModoVenda.Nova)
                {
                    //bll.SalvarVendaCompleta(vendaModel, _itensBinding.ToList(), parcelas);

                    var resposta = MessageBox.Show(
                        "✅ VENDA CONCLUÍDA COM SUCESSO ✅\n\n" +
                        "Os dados foram registrados corretamente.\n\n" +
                        "Deseja imprimir o cupom não fiscal?",
                        "CONFIRMAÇÃO DE VENDA",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1
                    );

                    if (resposta == DialogResult.Yes)
                    {
                        CupomNaoFiscalPdf.Gerar(
                            vendaModel,
                            _itensBinding.ToList(),
                            "Yago Brandão dos Passos",
                            "60.252.955/0001-68",
                            "Rua Cinco, Nº 379 - Bela Vista - Xinguara",
                            "(94) 9 3300-4134"
                        );
                    }

                    LimparFormulario();
                }

                else // EDIÇÃO
                {
                    vendaModel.VendaID = _vendaId;
                    //bll.AtualizarVendaCompleta(vendaModel, _itensBinding.ToList(), parcelas);

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
                Utilitario.Mensagens.Erro($"Erro SQL (Número: {sqlEx.Number}): {sqlEx.Message}");

            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso(ex.Message);
            }
        }

        #endregion

        #region ===== AUXILIARES =====

        private void LimparCamposProduto()
        {
            ProdutoID = 0;
            txtProdutoBuscar.Clear();
            txtQuantidade.Clear();
            txtPrecoUnitario.Clear();
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

            txtSubTotal.Text = "0,00";

            // ===== PRODUTO =====
            LimparCamposProduto();

            // ===== NOVO ID DE VENDA =====
            int vendaID = Utilitario.ProximoId(QueryVenda);
            txtVendaID.Text = Utilitario.ZerosEsquerda(vendaID, 4);

            // ===== FOCO =====
            txtClienteBuscar.Focus();

        }

        #endregion
        #region Eventos

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            AtualizarTotais();
        }

        #region Helpers


        private void FinalizarVenda()
        {
            if (ClienteID <= 0)
            {
                Utilitario.Mensagens.Aviso("Selecione um cliente.");
                return;
            }
            if (VendedorID <= 0)
            {
                Utilitario.Mensagens.Aviso("Selecione um vendedor.");
                return;
            }
            if (_itensBinding.Count == 0)
            {
                Utilitario.Mensagens.Aviso("Adicione itens à venda.");
                return;
            }

            var dto = new VendaFinalizacaoDTO
            {
                Venda = new VendaModel
                {
                    ClienteID = ClienteID,
                    NomeCliente = txtClienteBuscar.Text, // 🔥 AQUI
                    VendedorID = VendedorID > 0 ? VendedorID : null,
                    DataVenda = DateTime.Now,
                    ValorTotal = _valorTotal,
                    Desconto = _desconto
                },
                Itens = _itensBinding.ToList(),
                Total = _valorTotal
            };


            // FrmPDVendas
            using (var frm = new FrmFinalizarVenda(dto))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    new VendaBLL().SalvarVendaCompleta(
                        frm.VendaFinal,
                        frm.Itens,
                        frm.Parcelas   // 🔥 veio do FrmFinalizarVenda
                    );

                    if (MessageBox.Show("Deseja imprimir o cupom?", "Cupom",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CupomNaoFiscalPdf.Gerar(frm.VendaFinal, frm.Itens);
                    }

                    LimparFormulario();
                }
            }

        }

        private ProdutoListaItem CriarCabecalhoProduto()
        {
            return new ProdutoListaItem
            {
                ProdutoID = 0,
                Texto =
                    "Código ".PadRight(8) +
                    "Descrição".PadRight(70) +
                    "Unid ".PadRight(10) +
                    "PC Venda"
            };
        }
        private ProdutoListaItem CriarLinhaProduto(ProdutosModel p)
        {
            return new ProdutoListaItem
            {
                ProdutoID = p.ProdutoID,
                PrecoUnitario = p.PrecoDeVenda,
                Texto =
            p.ProdutoID.ToString("0000").PadRight(8) +
            p.NomeProduto.PadRight(70).Substring(0, 70) +
            p.Unidade.PadRight(10) +
            p.PrecoDeVenda.ToString("C2")
            };
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

        #region ==========INICIO DOS MÉTODOS DE VENDA==========



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
            dgvItensVenda.ClearSelection();

            // Define o resultado do diálogo como Cancelar
            this.DialogResult = DialogResult.Cancel;
            txtQuantidade.Text = "1";
            txtPrecoUnitario.Text = "0,00";
            txtSubTotal.Text = "0,00";
            AtualizarTotais();
            LimparFormulario();
        }
        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            FinalizarVenda();
        }
        private void AjustarCamposEdicao()
        {
            bool possuiPagamento = new VendaBLL().ExistePagamento(_vendaId);

            if (possuiPagamento)
            {
                dgvItensVenda.Enabled = false;
                btnAdicionarItem.Enabled = false;
                Utilitario.Mensagens.Aviso("Venda possui pagamentos. Alteração bloqueada");
            }
        }

        private void btnListarControles_Click(object sender, EventArgs e)
        {
            // Caminho onde o arquivo será salvo
            string caminho = @"D:\ControlesFormFrmPDV.txt";

            FrmBaixarParcela.SalvarNomesControles(this, caminho);

            Utilitario.Mensagens.Aviso("Lista de controles salva em: " + caminho);
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

        private void lstVendedores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtVendedorBuscar.Focus();
            }
        }
        private void txtVendedorBuscar_TextChanged(object sender, EventArgs e)
        {
            // Se estamos ignorando eventos, sai imediatamente
            if (_ignorarEventosBusca || _ignorandoBuscar)
                return;

            var texto = txtVendedorBuscar.Text.Trim();
            if (string.IsNullOrEmpty(texto))
                return;

            using (var pesquisaVendedor = new FrmLocalizarVendedor(this, texto))
            {
                // Calcula posição logo abaixo do TextBox
                var textBoxLocation = txtVendedorBuscar.PointToScreen(Point.Empty);

                pesquisaVendedor.StartPosition = FormStartPosition.Manual;
                pesquisaVendedor.Location = new Point(
                    textBoxLocation.X,
                    textBoxLocation.Y + txtVendedorBuscar.Height
                );

                // 🔑 Ajusta largura do formulário para acompanhar o TextBox
                pesquisaVendedor.Width = txtVendedorBuscar.Width;

                if (pesquisaVendedor.ShowDialog() == DialogResult.OK)
                {
                    // Ativa flag para bloquear reentrância
                    _ignorandoBuscar = true;
                    try
                    {
                        VendedorID = pesquisaVendedor.VendedorID;
                        txtVendedorBuscar.Text = pesquisaVendedor.VendedorSelecionado;
                    }
                    finally
                    {
                        // Libera flag após atualização
                        _ignorandoBuscar = false;
                    }
                }
            }

            txtProdutoBuscar.Select();
        }
        private void txtClienteBuscar_TextChanged(object sender, EventArgs e)
        {
            if (_ignorarEventosBusca || _ignorandoBuscar)
                return;

            var texto = txtClienteBuscar.Text.Trim();
            if (string.IsNullOrEmpty(texto))
                return;

            using (var pesquisaCliente = new FrmLocalizarCliente(this, texto))
            {
                // Calcula posição logo abaixo do TextBox
                var textBoxLocation = txtClienteBuscar.PointToScreen(Point.Empty);

                pesquisaCliente.StartPosition = FormStartPosition.Manual;
                pesquisaCliente.Location = new Point(
                    textBoxLocation.X,
                    textBoxLocation.Y + txtClienteBuscar.Height
                );

                // 🔑 Ajusta largura do formulário para acompanhar o TextBox
                pesquisaCliente.Width = txtClienteBuscar.Width;

                if (pesquisaCliente.ShowDialog() == DialogResult.OK)
                {
                    _ignorandoBuscar = true;
                    try
                    {
                        ClienteID = pesquisaCliente.ClienteID;
                        txtClienteBuscar.Text = pesquisaCliente.ClienteSelecionado;
                        NomeCliente = pesquisaCliente.ClienteSelecionado;

                    }
                    finally
                    {
                        _ignorandoBuscar = false;
                    }
                }
            }

            txtVendedorBuscar.Select();
        }

        private void txtProdutoBuscar_TextChanged(object sender, EventArgs e)
        {
            // Se estamos ignorando eventos, sai imediatamente
            if (_ignorarEventosBusca || _ignorandoBuscar)
                return;

            var texto = txtProdutoBuscar.Text.Trim();
            if (string.IsNullOrEmpty(texto))
                return;

            using (var pesquisaProduto = new FrmLocalizarProduto(this, texto))
            {
                // Calcula posição logo abaixo do TextBox
                var textBoxLocation = txtProdutoBuscar.PointToScreen(Point.Empty);

                pesquisaProduto.StartPosition = FormStartPosition.Manual;
                pesquisaProduto.Location = new Point(
                    textBoxLocation.X,
                    textBoxLocation.Y + txtProdutoBuscar.Height
                );

                // 🔑 Ajusta largura do formulário para acompanhar o TextBox
                pesquisaProduto.Width = txtProdutoBuscar.Width;

                if (pesquisaProduto.ShowDialog() == DialogResult.OK)
                {
                    // Ativa flag para bloquear reentrância
                    _ignorandoBuscar = true;
                    try
                    {
                        ProdutoID = pesquisaProduto.ProdutoID;
                        txtProdutoBuscar.Text = pesquisaProduto.ProdutoSelecionado;
                        txtPrecoUnitario.Text = pesquisaProduto.PrecoUnitario.ToString("N2");
                        txtQuantidade.Text = "1";
                        Utilitario.FormatarMoeda(txtPrecoUnitario);
                    }
                    finally
                    {
                        // Libera flag após atualização
                        _ignorandoBuscar = false;
                    }
                }
            }

            txtQuantidade.Select();
        }
        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPrecoUnitario.Focus();
            }
        }

        private void txtPrecoUnitario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnAdicionarItem.Focus();
            }
        }

        private void btnAdicionarItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnAdicionarItem.PerformClick();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPDVendas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //case Keys.F2:
                //    AbrirBuscaCliente();
                //    e.SuppressKeyPress = true;
                //    break;

                //case Keys.F3:
                //    AbrirBuscaVendedor();
                //    e.SuppressKeyPress = true;
                //    break;

                //case Keys.F4:
                //    AbrirBuscaProduto();
                //    e.SuppressKeyPress = true;
                //    break;

                case Keys.F6:
                    btnAdicionarItem.PerformClick();
                    e.SuppressKeyPress = true;
                    break;

                case Keys.F12:
                    FinalizarVenda();
                    e.SuppressKeyPress = true;
                    break;

                case Keys.Escape:
                    e.SuppressKeyPress = true;
                    break;
            }
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