O fluxo normal de uma venda era para a Tela princi

✅ FLUXO CORRETO (ERP / PDV PROFISSIONAL)
📌 Regra de ouro

Quem FINALIZA a venda é o FrmPDVendas.
Quem ESCOLHE como pagar é o FrmFinalizarVenda.

🔁 FLUXO CORRETO (passo a passo)
🟢 FrmPDVendas

1- Usuário informa:
*Cliente
*Vendedor
*Itens

2 - Pressiona F12
3 - Abre FrmFinalizarVenda
4 - Espera o retorno

🟡 FrmFinalizarVenda

1 - Recebe os dados da venda (DTO)
2- Usuário:
* Escolhe forma de pagamento
* Gera parcelas (se houver)
3 - CONFIRMA
4 - NÃO salva nada
5 - Apenas:
* Retorna dados para o PDV
* Fecha com DialogResult.OK

🔵 De volta ao FrmPDVendas

1 - Agora SIM:
* Salva venda
* Salva itens
* Salva parcelas
* Atualiza estoque
* Gera cupom
2 - Limpa tela
3 - Cursor volta para txtClienteBuscar

1️⃣ FrmFinalizarVenda — o que ELE PODE FAZER
✔️ Pode

* Validar forma de pagamento
* Gerar parcelas
* Preencher DTO
* Retornar dados

❌ NÃO pode

* Salvar venda
* Definir status final
* Emitir cupom
* Atualizar estoque

✅ RESULTADO FINAL (COMPORTAMENTO)

✔ Usuário pressiona F12
✔ Abre FrmSelecionarPagamento
✔ Nada pode finalizar enquanto ele estiver aberto
✔ Usuário confirma pagamento
✔ FrmPDVendas recebe DTO
✔ Só então:

* salva venda
* salva itens
* salva parcelas
* baixa estoque
* gera cupom
* limpa tela
* foco volta para cliente

Formulário FrmPDVendas

    public partial class FrmPDVendas : KryptonForm
    {
        private readonly ModoVenda _modo;
        private readonly int _vendaId;
        public int VendaID { get; private set; }
        private bool _clienteFoiSelecionado = false;
        private bool _ignorarEventosBusca = false;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int VendedorID { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ClienteID { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ProdutoID { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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


        private enum EstadoVenda
        {
            Inicial,              // Tela recém aberta
            ClienteSelecionado,   // Cliente escolhido
            VendedorSelecionado,  // Vendedor escolhido
            ComItens,             // Tem pelo menos 1 item no grid
            ProntaParaFinalizar,  // Já passou pela tela de finalização
            Finalizada            // Venda gravada com sucesso
        }
        private EstadoVenda _estadoVenda = EstadoVenda.Inicial;


        public FrmPDVendas()// NOVA VENDA
        {
            InitializeComponent();

            _modo = ModoVenda.Nova;
            _vendaId = 0;

            InicializarFormulario(); // <<< OBRIGATÓRIO

            dgvItensVenda.CellEndEdit += dgvItensVenda_CellEndEdit;
            this.Text = "Frente de Caixa";
            this.StateCommon.Header.Content.ShortText.Color1 = Color.Red;
            this.StateCommon.Header.Content.ShortText.Color2 = Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI", 18);
        }

        // ACIMA NOVA IMPLEMENTAÇÃO DE COMBOBOX
        public FrmPDVendas(int vendaId) // MODO EDIÇÃO
        {
            InitializeComponent();

            _modo = ModoVenda.Edicao;
            _vendaId = vendaId;

            InicializarFormulario();
        }        

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
        private void AtualizarEstadoTela()
        {
            // Regra de ouro: desabilita tudo primeiro
            txtClienteBuscar.Enabled = false;
            txtVendedorBuscar.Enabled = false;
            txtProdutoBuscar.Enabled = false;
            dgvItensVenda.Enabled = false;

            btnNovaVenda.Enabled = false;
            btnFinalizarVenda.Enabled = false;
            btnSair.Enabled = true;

            switch (_estadoVenda)
            {
                case EstadoVenda.Inicial:
                    txtClienteBuscar.Enabled = true;
                    if (txtClienteBuscar.CanFocus)
                    {
                        txtClienteBuscar.Focus();
                        txtClienteBuscar.SelectAll();
                    }
                    break;

                case EstadoVenda.ClienteSelecionado:
                    txtClienteBuscar.Enabled = true;     // permite trocar cliente
                    txtVendedorBuscar.Enabled = true;
                    if (txtVendedorBuscar.CanFocus)
                    {
                        txtVendedorBuscar.Focus();
                        txtVendedorBuscar.SelectAll();
                    }
                    break;

                case EstadoVenda.VendedorSelecionado:
                    txtClienteBuscar.Enabled = true;
                    txtVendedorBuscar.Enabled = true;
                    txtProdutoBuscar.Enabled = true;
                    if (txtProdutoBuscar.CanFocus)
                    {
                        txtProdutoBuscar.Focus();
                        txtProdutoBuscar.SelectAll();
                    }
                    break;

                case EstadoVenda.ComItens:
                    txtClienteBuscar.Enabled = true;
                    txtVendedorBuscar.Enabled = true;
                    txtProdutoBuscar.Enabled = true;
                    dgvItensVenda.Enabled = true;
                    btnFinalizarVenda.Enabled = true;   // Libera F12 ou botão de finalizar
                    break;

                case EstadoVenda.ProntaParaFinalizar:
                    txtClienteBuscar.Enabled = true;
                    txtVendedorBuscar.Enabled = true;
                    txtProdutoBuscar.Enabled = true;
                    dgvItensVenda.Enabled = true;
                    btnFinalizarVenda.Enabled = true;
                    btnNovaVenda.Enabled = true;        // Permite iniciar nova venda
                    break;

                case EstadoVenda.Finalizada:
                    // Tudo bloqueado, exceto nova venda e sair
                    btnNovaVenda.Enabled = true;
                    btnSair.Enabled = true;
                    break;
            }
        }
               

        // Chame este método sempre que adicionar ou remover um item do grid
       

        // Captura F12 para abrir tela de finalização
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F12 && _estadoVenda >= EstadoVenda.ComItens)
            {
                // Apenas executa o mesmo método que o botão usa — NÃO abre o form aqui manualmente
                FinalizarVenda();
                return true; // Impede que a tecla F12 faça outro comportamento padrão
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FrmPDVendas_Load(object sender, EventArgs e)
        {
            // Permite capturar teclas como F12 no form
            this.KeyPreview = true;

            // 1. Define o estado inicial ANTES de tudo
            _estadoVenda = EstadoVenda.Inicial;

            // 2. Configura o BindingList e o grid
            _itensBinding = new BindingList<ItemVendaModel>();

            // Evento que monitora adição/remoção de itens
            _itensBinding.ListChanged += (s, a) =>
            {
                if (_itensBinding.Count > 0)
                {
                    if (_estadoVenda < EstadoVenda.ComItens)
                        _estadoVenda = EstadoVenda.ComItens;
                }
                else
                {
                    // Se esvaziou o grid, volta para o estado anterior correto
                    if (_estadoVenda >= EstadoVenda.ComItens)
                        _estadoVenda = EstadoVenda.VendedorSelecionado;
                }

                // IMPORTANTE: Atualiza a tela sempre que a lista mudar
                AtualizarEstadoTela();
            };

            _itensBindingSource.DataSource = _itensBinding;
            dgvItensVenda.DataSource = _itensBindingSource;

            // 3. Configurações iniciais para nova venda
            if (_modo == ModoVenda.Nova)
            {
                int proximaVendaID = Utilitario.ProximoId(QueryVenda);
                txtVendaID.Text = Utilitario.ZerosEsquerda(proximaVendaID, 4);
                txtDataVenda.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            else if (_modo == ModoVenda.Edicao)
            {
                // CarregarVenda(); // descomente quando implementar
                AjustarCamposEdicao();
                this.Text = $"Alterando Venda Nº {_vendaId}";
                // btnFinalizarVenda.Text = "Salvar Alterações";
            }

            // 4. Finalmente: atualiza a tela e coloca foco no primeiro campo
            AtualizarEstadoTela();

            // Garante o foco no campo de busca de cliente
            if (txtClienteBuscar.CanFocus)
            {
                txtClienteBuscar.Focus();
                txtClienteBuscar.SelectAll();
            }
        }
      

        
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

            // 🔹 Estilo de seleção
            dgvItensVenda.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvItensVenda.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

       

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            if (ProdutoID <= 0)
            {
                Utilitario.Mensagens.Aviso("Produto inválido.");
                return;
            }

            if (!int.TryParse(txtQuantidade.Text, out int qtd) || qtd <= 0)
                return;

            if (!decimal.TryParse(txtPrecoUnitario.Text, out decimal preco))
                return;

            int estoqueAtual = new EstoqueDAL().ObterEstoqueAtualizado(ProdutoID);

            if (estoqueAtual <= 0)
            {
                Utilitario.Mensagens.Aviso("Produto sem estoque.");
                return;
            }

            if (qtd > estoqueAtual)
            {
                Utilitario.Mensagens.Aviso(
                    $"Estoque insuficiente. Disponível: {estoqueAtual}"
                );
                return;
            }

            var item = _itensBinding.FirstOrDefault(i => i.ProdutoID == ProdutoID);

            if (item != null)
            {
                if (item.Quantidade + qtd > estoqueAtual)
                {
                    Utilitario.Mensagens.Aviso(
                        $"Quantidade total excede o estoque ({estoqueAtual})."
                    );
                    return;
                }

                item.Quantidade += qtd; // Subtotal será recalculado automaticamente
            }
            else
            {
                _itensBinding.Add(new ItemVendaModel
                {
                    VendaID = venda.VendaID,
                    ProdutoID = ProdutoID,
                    Quantidade = qtd,
                    PrecoUnitario = preco,
                    EstoqueAtual = estoqueAtual,
                    ProdutoDescricao = txtProdutoBuscar.Text
                });
            }


            AtualizarTotais();
            // 🔥 AQUI: Volta o foco para buscar o próximo produto
            LimparCamposProduto(); // já zera ProdutoID e limpa os textos

            // Garante que o campo esteja habilitado (deve estar, pois já tem itens ou vendedor)
            if (txtProdutoBuscar.CanFocus)
            {
                txtProdutoBuscar.Focus();
                txtProdutoBuscar.SelectAll(); // seleciona tudo para digitar por cima rapidamente
            }
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

            // Blindagem: desconto não pode ser negativo nem maior que o subtotal
            if (_desconto < 0m) _desconto = 0m;
            if (_desconto > _subtotal) _desconto = _subtotal;

            // Calcula o total final
            _valorTotal = _subtotal - _desconto;

            // Atualiza os campos na tela
            lblSubTotal.Text = _subtotal.ToString("N2");
        }

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

            lblSubTotal.Text = "0,00";

            // ===== PRODUTO =====
            LimparCamposProduto();

            // ===== NOVO ID DE VENDA =====
            int vendaID = Utilitario.ProximoId(QueryVenda);
            txtVendaID.Text = Utilitario.ZerosEsquerda(vendaID, 4);

            // ===== FOCO =====
            txtClienteBuscar.Focus();

        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            AtualizarTotais();
        }

      
        private bool ValidarEstoqueAntesFinalizar()
        {
            foreach (var item in _itensBinding)
            {
                if (item.Quantidade <= 0)
                {
                    Utilitario.Mensagens.Aviso(
                        $"Informe uma quantidade válida para o produto {item.ProdutoDescricao}");
                    return false;
                }

                if (item.Quantidade > item.EstoqueAtual)
                {
                    Utilitario.Mensagens.Aviso(
                        $"Estoque insuficiente para {item.ProdutoDescricao}\n" +
                        $"Disponível: {item.EstoqueAtual}");
                    return false;
                }
            }

            return true;
        }

        private void FinalizarVenda()
        {
            dgvItensVenda.EndEdit();
            _itensBindingSource.EndEdit();

            if (!ValidarEstoqueAntesFinalizar())
                return;

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
            using (var frm = new FrmSelecionarPagamento(dto))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // 🔥 AQUI É O ÚNICO LUGAR QUE FINALIZA
                    new VendaBLL().SalvarVendaCompleta(
                        frm.VendaFinal,
                        frm.Itens,
                        frm.Parcelas
                    );

                    // 🔥 CUPOM SÓ AQUI
                    CupomNaoFiscalPdf.Gerar(frm.VendaFinal, frm.Itens);

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
        private ProdutoListaItem CriarLinhaProduto(ProdutoModel p)
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

        private void FrmPDV_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }
       
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
            lblSubTotal.Text = "0,00";
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

                        // 🔥 AQUI: avança o estado e atualiza a tela
                        if (_estadoVenda < EstadoVenda.ClienteSelecionado)
                        {
                            _estadoVenda = EstadoVenda.ClienteSelecionado;
                            AtualizarEstadoTela();
                        }

                    }
                    finally
                    {
                        _ignorandoBuscar = false;
                    }
                }
            }

            txtVendedorBuscar.Select();
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

                        // 🔥 Avança o estado
                        if (_estadoVenda < EstadoVenda.VendedorSelecionado)
                        {
                            _estadoVenda = EstadoVenda.VendedorSelecionado;
                            AtualizarEstadoTela();
                        }
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
                        txtQuantidade.Focus();
                        txtQuantidade.SelectAll();
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
        private void AbrirBuscaCliente()
        {
            if (_ignorarEventosBusca || _ignorandoBuscar)
                return;

            // Foca no campo cliente primeiro
            txtClienteBuscar.Focus();
            Application.DoEvents();

            var texto = txtClienteBuscar.Text.Trim();

            // **MUDANÇA IMPORTANTE**: Permite abrir mesmo se estiver vazio!
            // O formulário de pesquisa deve lidar com texto vazio
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

                        // 🔥 AQUI: avança o estado e atualiza a tela
                        if (_estadoVenda < EstadoVenda.ClienteSelecionado)
                        {
                            _estadoVenda = EstadoVenda.ClienteSelecionado;
                            AtualizarEstadoTela();
                        }
                    }
                    finally
                    {
                        _ignorandoBuscar = false;
                    }
                }
            }

            txtVendedorBuscar.Select();
        }

        private void AbrirBuscaVendedor()
        {
            if (_ignorarEventosBusca || _ignorandoBuscar)
                return;

            // Foca no campo vendedor primeiro
            txtVendedorBuscar.Focus();
            Application.DoEvents();

            var texto = txtVendedorBuscar.Text.Trim();

            // **MUDANÇA IMPORTANTE**: Permite abrir mesmo se estiver vazio!
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

                        // 🔥 Avança o estado
                        if (_estadoVenda < EstadoVenda.VendedorSelecionado)
                        {
                            _estadoVenda = EstadoVenda.VendedorSelecionado;
                            AtualizarEstadoTela();
                        }
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

        private void AbrirBuscaProduto()
        {
            if (_ignorarEventosBusca || _ignorandoBuscar)
                return;

            // Foca no campo produto primeiro
            txtProdutoBuscar.Focus();
            Application.DoEvents();

            var texto = txtProdutoBuscar.Text.Trim();

            // **MUDANÇA IMPORTANTE**: Permite abrir mesmo se estiver vazio!
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
                        txtQuantidade.Focus();
                        txtQuantidade.SelectAll();
                    }
                }
            }

            txtQuantidade.Select();
        }

        private void FrmPDVendas_KeyDown(object sender, KeyEventArgs e)
        {
           // Debug: mostra qual tecla está sendo pressionada
            Console.WriteLine($"Tecla pressionada: {e.KeyCode}");
            Debug.WriteLine($"Tecla pressionada: {e.KeyCode}");

            if (e.KeyCode == Keys.F12)
            {
                e.SuppressKeyPress = true;
            }

            switch (e.KeyCode)
            {
                case Keys.F2:                  
                    AbrirBuscaCliente();
                    e.SuppressKeyPress = true;
                    e.Handled = true; // Adiciona esta linha
                    break;

                case Keys.F3:                  
                    AbrirBuscaVendedor();
                    e.SuppressKeyPress = true;
                    e.Handled = true; // Adiciona esta linha
                    break;

                case Keys.F4:                  
                    AbrirBuscaProduto();
                    e.SuppressKeyPress = true;
                    e.Handled = true; // Adiciona esta linha
                    break;

                case Keys.F6:                   
                    btnAdicionarItem.PerformClick();
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                    break;

                case Keys.F12:                   
                    FinalizarVenda();
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                    break;

                case Keys.Escape:                  
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                    break;
            }
        
        }

        private void dgvItensVenda_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            dgvItensVenda.CommitEdit(DataGridViewDataErrorContexts.Commit);

            var item = dgvItensVenda.Rows[e.RowIndex].DataBoundItem as ItemVendaModel;
            if (item == null) return;

            // Blindagem + recálculo automático
            if (item.Quantidade <= 0)
                item.Quantidade = 1;

            if (item.Quantidade > item.EstoqueAtual)
                item.Quantidade = (int)item.EstoqueAtual;

            if (item.PrecoUnitario < 0)
                item.PrecoUnitario = 0;

            if (item.DescontoItem < 0)
                item.DescontoItem = 0;

            decimal subtotalBruto = item.Quantidade * item.PrecoUnitario;

            if (item.DescontoItem > subtotalBruto)
                item.DescontoItem = subtotalBruto;

            // ❌ Remover esta linha:
            // item.Subtotal = subtotalBruto - item.DescontoItem;

            // Atualiza bindings
            _itensBindingSource.ResetBindings(false);
            AtualizarTotais();
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            // Limpa todos os dados
            ClienteID = 0;
            VendedorID = 0;
            dgvItensVenda.Rows.Clear();
            txtClienteBuscar.Clear();
            txtVendedorBuscar.Clear();
            txtProdutoBuscar.Clear();
            // Limpe outros campos (totais, descontos, etc.)

            _estadoVenda = EstadoVenda.Inicial;
            AtualizarEstadoTela();
        }
    }
}

Formulário para selecionar forma de pagamento FrmSelecionarPagamento


    public partial class FrmSelecionarPagamento : KryptonForm
    {
        private readonly VendaFinalizacaoDTO _dto;
        private readonly FinanceiroService _financeiroService;
        private BindingList<ParcelaModel> _parcelasBinding;

        // FrmFinalizarVenda
        public List<ParcelaModel> Parcelas { get; private set; }

        private List<ParcelaModel> _parcelasGeradas;
        public VendaModel VendaFinal { get; private set; }
        public List<ItemVendaModel> Itens { get; private set; }

        public FrmSelecionarPagamento(VendaFinalizacaoDTO dto)
        {
            InitializeComponent();
            _dto = dto;
            _financeiroService = new FinanceiroService();

            Itens = dto.Itens;
            VendaFinal = dto.Venda;

            cmbFormaPagamento.SelectedIndexChanged += cmbFormaPagamento_SelectedIndexChanged;

        }
        public enum EnumFormaPagamento
        {
            Dinheiro,
            Pix,
            Credito,
            Debito
        }
        private void InicializarControles()
        {
            // Bloquear todos os controles de pagamento
            txtValorRecebido.Enabled = false;
            numParcelas.Enabled = false;
            dtpPrimeiraParcela.Enabled = false;
            numIntervalo.Enabled = false;
            btnGerarParcelas.Enabled = false;

            // Apenas forma de pagamento liberada
            cmbFormaPagamento.Enabled = true;

            // Limpar valores
            txtValorRecebido.Text = string.Empty;
            numParcelas.Value = 1;
            numIntervalo.Value = 30;
        }
        // Atualiza o estado do botão Confirmar
        private void AtualizarBotaoConfirmar()
        {
            // Habilita somente se houver linhas no DataGridView
            btnConfirmar.Enabled = dgvParcelas.Rows.Count > 0;
        }
        public void ValidarFormaPagamento(EnumFormaPagamento forma, int qtdParcelas)
        {
            if (forma == EnumFormaPagamento.Pix && qtdParcelas > 1)
                throw new Exception("PIX não permite parcelamento.");

            if (forma == EnumFormaPagamento.Dinheiro && qtdParcelas > 1)
                throw new Exception("Dinheiro não permite parcelamento.");

            if (forma == EnumFormaPagamento.Credito && qtdParcelas < 1)
                throw new Exception("Informe o número de parcelas.");
        }

        private void AtualizarParcelas()
        {
            int qtd = (int)numParcelas.Value;
            DateTime venc = dtpPrimeiraParcela.Value;

            var parcelas = _financeiroService.GerarParcelas(
                _dto.Total,
                qtd,
                30,
                venc
            );

            // 🔒 GARANTIA: parcelamento nasce pendente
            foreach (var p in parcelas)
            {
                p.Status = EnumStatusParcela.Pendente;
                p.ValorRecebido = null;
                p.DataPagamento = null;
            }

            _parcelasBinding = new BindingList<ParcelaModel>(parcelas);
            dgvParcelas.DataSource = _parcelasBinding;
        }

        private void CarregarGridParcelas(List<ParcelaModel> parcelas)
        {
            dgvParcelas.DataSource = null;
            dgvParcelas.DataSource = parcelas;
            // Atualiza o botão Confirmar
            AtualizarBotaoConfirmar();
        }

        private void ConfigurarGridParcelas()
        {
            // Geralmente no Load do Form ou no InitializeComponent customizado
            dgvParcelas.DataError += (s, e) =>
            {
                // Ignora o erro de índice fora do intervalo
                e.ThrowException = false;
            };

            dgvParcelas.AutoGenerateColumns = false;
            dgvParcelas.Columns.Clear();

            dgvParcelas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumeroParcela",
                HeaderText = "Parc",
                Width = 60
            });

            dgvParcelas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataVencimento",
                HeaderText = "Vencimento",
                Width = 110,
                DefaultCellStyle = { Format = "dd/MM/yyyy" }
            });

            dgvParcelas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorParcela",
                HeaderText = "Valor",
                Width = 120,
                DefaultCellStyle = { Format = "C2" }
            });
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var forma = cmbFormaPagamento.SelectedItem as FormaPagamentoItem;

            if (forma == null || forma.FormaPgtoID == 0)
            {
                Utilitario.Mensagens.Aviso("Selecione a forma de pagamento.");
                return;
            }

            // Apenas define dados, NÃO salva
            _dto.Venda.FormaPgtoID = forma.FormaPgtoID;

            VendaFinal = _dto.Venda;
            Itens = _dto.Itens;
            Parcelas = _parcelasGeradas;

            // 🔴 EVITA IndexOutOfRange no fechamento
            dgvParcelas.DataSource = null;

            DialogResult = DialogResult.OK;
            Close();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerarParcelas_Click(object sender, EventArgs e)
        {
            _parcelasGeradas = _financeiroService.GerarParcelas(
         _dto.Total,
         (int)numParcelas.Value,
         (int)numIntervalo.Value,
         dtpPrimeiraParcela.Value.Date);

            CarregarGridParcelas(_parcelasGeradas);

            foreach (var p in _parcelasGeradas)
            {
                p.ValorParcela = Math.Round(p.ValorParcela, 2);

                if (p.ValorRecebido.HasValue)
                {
                    p.ValorRecebido = Math.Round(Math.Min(p.ValorRecebido.Value, p.ValorParcela), 2);
                }
            }
        }

        private void FrmFinalizarVenda_Load(object sender, EventArgs e)
        {

            lblCliente.Text = _dto.Venda.NomeCliente ?? "CLIENTE NÃO INFORMADO";
            lblVendaNumero.Text = _dto.Venda.VendaID > 0 ? $"VENDA Nº {_dto.Venda.VendaID}" : "NOVA VENDA";
            lblTotal.Text = _dto.Total.ToString("C2");

            Utilitario.CarregarFormasPagamento(cmbFormaPagamento);
            ConfigurarGridParcelas();
            // 🔹 Inicializa controles bloqueados
            InicializarControles();
            // Garantir que o botão Confirmar comece desabilitado
            AtualizarBotaoConfirmar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
      
        private void cmbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            var forma = cmbFormaPagamento.SelectedItem as FormaPagamentoItem;
            if (forma == null) return;

            InicializarControles(); // resetar antes

            // Formas de pagamento com parcela automática
            if (forma.NomeFormaPagamento.Equals("Dinheiro", StringComparison.OrdinalIgnoreCase) ||
                forma.NomeFormaPagamento.Equals("PIX", StringComparison.OrdinalIgnoreCase) ||
                forma.NomeFormaPagamento.Equals("Transferência", StringComparison.OrdinalIgnoreCase) ||
                forma.NomeFormaPagamento.Equals("Cartão de Débito", StringComparison.OrdinalIgnoreCase))
            {
                // Cria parcela única com DataPagamento atual
                _parcelasGeradas = new List<ParcelaModel>
                {
                    new ParcelaModel
                    {
                        NumeroParcela = 1,
                        DataVencimento = DateTime.Now,
                        DataPagamento = DateTime.Now,
                        ValorParcela = _dto.Total,
                        ValorRecebido = _dto.Total,
                        Status = EnumStatusParcela.Pago
                    }
                };

                // 🔹 Arredondamento seguro
                foreach (var p in _parcelasGeradas)
                {
                    p.ValorParcela = Math.Round(p.ValorParcela, 2);
                    p.ValorRecebido = Math.Round(Math.Min((decimal)p.ValorRecebido, p.ValorParcela), 2);
                }

                CarregarGridParcelas(_parcelasGeradas);

            }           
            else if (forma.NomeFormaPagamento.Equals("Crediário", StringComparison.OrdinalIgnoreCase))
            {
                txtValorRecebido.Enabled = false; // 🔒
                numParcelas.Enabled = true;
                dtpPrimeiraParcela.Enabled = true;
                numIntervalo.Enabled = true;
                btnGerarParcelas.Enabled = true;

                dgvParcelas.DataSource = null;
            }

        }
    }
}
