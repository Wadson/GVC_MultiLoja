Tenho todas as tabelas mais aqui está as principais para a venda

TABLE [dbo].[Produtos](
	[ProdutoID] [int] IDENTITY(1,1) NOT NULL,
	[NomeProduto] [nvarchar](100) NOT NULL,
	[Referencia] [nvarchar](15) NULL,
	[PrecoCusto] [decimal](18, 2) NOT NULL,
	[Lucro] [decimal](18, 2) NOT NULL,
	[PrecoDeVenda] [decimal](18, 2) NOT NULL,
	[Estoque] [int] NOT NULL,
	[DataDeEntrada] [datetime2](7) NOT NULL,
	[Status] [nvarchar](20) NOT NULL,
	[Situacao] [nvarchar](50) NULL,
	[Unidade] [nvarchar](20) NULL,
	[Marca] [nvarchar](50) NULL,
	[DataValidade] [datetime2](7) NULL,
	[GtinEan] [nvarchar](20) NULL,
	[Imagem] [nvarchar](255) NULL,
	[FornecedorID] [int] NULL,
 CONSTRAINT [PK_Produtos] PRIMARY KEY CLUSTERED 


TABLE [dbo].[Clientes](
	[ClienteID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[Cpf] [nvarchar](11) NULL,
	[RG] [nvarchar](20) NULL,
	[Cnpj] [nvarchar](14) NULL,
	[IE] [nvarchar](20) NULL,
	[Telefone] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NULL,
	[CidadeID] [int] NULL,
	[Logradouro] [nvarchar](150) NULL,
	[Numero] [nvarchar](10) NULL,
	[Bairro] [nvarchar](100) NULL,
	[Cep] [nvarchar](10) NULL,
	[DataNascimento] [date] NULL,
	[TipoCliente] [nvarchar](20) NULL,
	[Status] [int] NOT NULL,
	[Observacoes] [nvarchar](max) NULL,
	[DataUltimaCompra] [datetime2](7) NULL,
	[LimiteCredito] [decimal](18, 2) NULL,
	[DataCriacao] [datetime2](7) NOT NULL,
	[DataAtualizacao] [datetime2](7) NULL,
	[UsuarioCriacao] [nvarchar](50) NULL,
	[UsuarioAtualizacao] [nvarchar](50) NULL,
	[OrgaoExpedidorRG] [nvarchar](20) NULL,
	[IsVendedor] [bit] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 


TABLE [dbo].[Venda](
	[VendaID] [int] IDENTITY(1,1) NOT NULL,
	[ClienteID] [int] NOT NULL,
	[FormaPgtoID] [int] NULL,
	[DataVenda] [datetime2](7) NOT NULL,
	[ValorTotal] [decimal](18, 2) NOT NULL,
	[Desconto] [decimal](18, 2) NOT NULL,
	[Observacoes] [nvarchar](max) NULL,
	[StatusVenda] [nvarchar](20) NOT NULL,
	[VendedorID] [int] NULL,
CONSTRAINT [PK_Venda] PRIMARY KEY CLUSTERED 


TABLE [dbo].[ItemVenda](
	[ItemVendaID] [int] IDENTITY(1,1) NOT NULL,
	[VendaID] [int] NOT NULL,
	[ProdutoID] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[PrecoUnitario] [decimal](18, 2) NOT NULL,
	[Subtotal] [decimal](18, 2) NOT NULL,
	[DescontoItem] [decimal](18, 2) NULL,
 CONSTRAINT [PK_ItemVenda] PRIMARY KEY CLUSTERED 

 TABLE [dbo].[Parcela](
	[ParcelaID] [int] IDENTITY(1,1) NOT NULL,
	[VendaID] [int] NOT NULL,
	[NumeroParcela] [int] NOT NULL,
	[DataVencimento] [date] NOT NULL,
	[ValorParcela] [decimal](18, 2) NOT NULL,
	[ValorRecebido] [decimal](18, 2) NULL,
	[Status] [nvarchar](20) NOT NULL,
	[DataPagamento] [date] NULL,
	[Juros] [decimal](18, 2) NULL,
	[Multa] [decimal](18, 2) NULL,
	[Observacao] [nvarchar](max) NULL,
 CONSTRAINT [PK_Parcela] PRIMARY KEY CLUSTERED 

TABLE [dbo].[PagamentosParciais](
	[PagamentoID] [int] IDENTITY(1,1) NOT NULL,
	[ParcelaID] [int] NOT NULL,
	[ValorPago] [decimal](18, 2) NOT NULL,
	[DataPagamento] [date] NOT NULL,
	[FormaPgtoID] [int] NULL,
	[Observacao] [nvarchar](max) NULL,
 CONSTRAINT [PK_PagamentosParciais] PRIMARY KEY CLUSTERED 

TABLE [dbo].[FormaPagamento](
	[FormaPgtoID] [int] IDENTITY(1,1) NOT NULL,
	[NomeFormaPagamento] [nvarchar](50) NOT NULL,
	[Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_FormaPgto] PRIMARY KEY CLUSTERED 

REGRAS DE NEGÓCIO DO SISTEMA GVC

🔄 Fluxo completo com formas de pagamento
1. Venda à vista (Dinheiro, Débito, PIX, Transferência)
Tabela Venda: criada com StatusVenda = 'Concluída' se o pagamento é imediato.
ItemVenda: todos os produtos/serviços.
Tabela Parcela: uma única parcela com Status = 'Pago', DataVencimento = DateTime.Now, DataPagamento = DateTime.Now
Tabela PagamentosParciais: registro único com o ValorPago, DataPagamento = DateTime.Now, e FormaPagamentoID = (ID da Forma de Pagamento A Vista)

👉 Exemplo:

1. FormaPgto = Dinheiro, Cartão de Débito, PIX, Transferência:
Venda → Concluída
Parcela → Pago
Pagamento → único, valor total.

2. FormaPgto = Cartão de Crédito, Boleto, Cheque, Crediário.

Tabela Venda: criada com StatusVenda = 'AguardandoPagamento' até o recebimento das parcelas
Tabela ItemVenda: produtos/serviços.

Tabela Parcela:
Se parcelado: gera N parcelas com Status = "Pendente".
Se Dinheiro, Cartão de Débito, PIX, Transferência: gera 1 parcela "Pago".







Tabela PagamentosParciais:

Quando a operadora confirma, ou as parcelas são baixadas manualmente, grava pagamento.
Parcela(s) passam para "Pago" ou "ParcialmentePago".
Venda: muda para Concluída quando todas as parcelas estão quitadas.

👉 Exemplo:

FormaPgto = Cartão de Crédito (3x)
Venda → AguardandoPagamento
Parcelas → 3 registros Pendente
Conforme liquidação → ParcialmentePago → Concluída.

3. Venda com Boleto

Venda: criada com StatusVenda = "AguardandoPagamento".
ItemVenda: produtos/serviços.
Parcela:
Uma parcela com vencimento futuro (Status = "Pendente").
PagamentosParciais:
Quando o cliente paga o boleto, registra pagamento.
Parcela → "Pago".
Venda: muda para "Concluida".

👉 Exemplo:

FormaPgto = Boleto
Venda → AguardandoPagamento
Parcela → "Pendente" até liquidação
Pagamento → único, valor total.

4. Venda com Cheque

Venda: criada com StatusVenda = 'Em Análise' ou AguardandoPagamento (aguarda compensação).
ItemVenda: produtos/serviços.
Parcela:
Uma parcela com vencimento na data do cheque.
PagamentosParciais:
Quando o cheque compensa, registra pagamento.
Parcela → "Pagi".
Venda: muda para "Concluída".

👉 Exemplo:

FormaPgto = Cheque
Venda → Em Análise
Parcela → Pendente
Após compensação → Paga → Venda Concluída.

📊 StatusVenda (Tabela Venda)
 public enum EnumStatusVenda
 {
     Aberta,
     AguardandoPagamento,
     ParcialmentePago,
     Concluida,
     Cancelada, 
     Suspensa
 }

📊 Status (Tabela Parcela)

public enum EnumStatusParcela
{
    Pendente,
    ParcialmentePago,
    Pago,
    Atrasada,        
    Cancelada   
}
 public static class StatusExtensions
 {
     // =========================
     // VENDA → DB
     // =========================
     public static string ToDb(this EnumStatusVenda status)
     {
         return status switch
         {
             EnumStatusVenda.Aberta => "Aberta",              
             EnumStatusVenda.AguardandoPagamento => "AguardandoPagamento",
             EnumStatusVenda.Concluida => "Concluída",
             EnumStatusVenda.Cancelada => "Cancelada", 
             EnumStatusVenda.ParcialmentePago => "ParcialmentePago",
             EnumStatusVenda.Suspensa => "Suspensa",
             _ => throw new ArgumentOutOfRangeException()
         };
     }

     // =========================
     // DB → VENDA
     // =========================
     public static EnumStatusVenda ToEnumStatusVenda(this string status)
     {
         return status switch
         {
             "Aberta" => EnumStatusVenda.Aberta,               
             "AguardandoPagamento" => EnumStatusVenda.AguardandoPagamento,
             "Concluída" => EnumStatusVenda.Concluida,
             "Cancelada" => EnumStatusVenda.Cancelada,              
             "ParcialmentePago" => EnumStatusVenda.ParcialmentePago,
             "Suspensa" => EnumStatusVenda.Suspensa,
             _ => throw new Exception($"Status de venda inválido: {status}")
         };
     }

     // =========================
     // PARCELA → DB
     // =========================
     public static string ToDb(this EnumStatusParcela status)
     {
         return status switch
         {
             EnumStatusParcela.Pendente => "Pendente",
             EnumStatusParcela.Atrasada => "Atrasada",                
             EnumStatusParcela.Pago => "Pago",
             EnumStatusParcela.Cancelada => "Cancelada",              
             EnumStatusParcela.ParcialmentePago => "ParcialmentePago",
             _ => throw new ArgumentOutOfRangeException()
         };
     }

     // =========================
     // DB → PARCELA
     // =========================
     public static EnumStatusParcela ToEnumStatusParcela(this string status)
     {
         return status switch
         {
             "Aberta" => EnumStatusParcela.Pendente,
             "Atrasada" => EnumStatusParcela.Atrasada,               
             "Pago" => EnumStatusParcela.Pago,
             "Cancelada" => EnumStatusParcela.Cancelada,              
             "ParcialmentePago" => EnumStatusParcela.ParcialmentePago,
             _ => throw new Exception($"Status de parcela inválido: {status}")
         };
     }
 }



👉 Esse é o fluxo do sistema GVC:

À vista (Dinheiro, Débito, PIX, Transferência) → Venda já nasce Concluída.
Crédito, Boleto, Cheque, Crediário → Venda nasce AguardandoPagamento ou Em Análise, 
e só vira Concluída após quitação das parcelas.

using GVC.DTO;
using GVC.DTO;
using GVC.Model;
using GVC.Model.Enums;
using GVC.UTIL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GVC.View
{
    public partial class FrmFinalizarVenda : KryptonForm
    {
        private readonly VendaFinalizacaoDTO _dto;
        private readonly FinanceiroService _financeiroService;
        private BindingList<ParcelaModel> _parcelasBinding;

        // FrmFinalizarVenda
        public List<ParcelaModel> Parcelas { get; private set; }

        private List<ParcelaModel> _parcelasGeradas;
        public VendaModel VendaFinal { get; private set; }
        public List<ItemVendaModel> Itens { get; private set; }

        public FrmFinalizarVenda(VendaFinalizacaoDTO dto)
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
using GVC.BLL;
using GVC.DAL;
using GVC.DAL;
using GVC.DTO;
using GVC.Model;
using GVC.Model.Enums;
using GVC.UTIL;
using Krypton.Toolkit;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using SistemaVendas.CustomControls;
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

        #endregion

        #region ===== ITENS =======================================

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
            lblSubTotal.Text = _subtotal.ToString("N2");
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

            lblSubTotal.Text = "0,00";

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
            using (var frm = new FrmFinalizarVenda(dto))
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

        #endregion

        private void FrmPDV_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
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

/*
                   
            📊 Status para a Tabela Venda coluna "StatusVenda"
            
            Aberta               → em edição.
            Em Análise           → aguardando aprovação (crédito/cheque).
            AguardandoPagamento → emitida, aguardando liquidação.
            ParcialmentePago    → parte quitada.
            Concluída            → 100% liquidada.
            Cancelada            → anulada.
            Suspensa             → bloqueada temporariamente.
           
           📊 Status para a Tabela Parcela coluna "Status"

            Pendente          → AguardandoPagamento.
            Parcialmente Paga → recebeu parte.
            Paga              → liquidada.
            Atrasada          → vencida sem quitação.
            Cancelada         → anulada.
        

                    */
#endregion





using GVC.Model;
using GVC.Model.Enums;
using GVC.Model.Extensions;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GVC.DAL
{
    public class VendaDal
    {
        public int AddVendaCompleta(VendaModel venda, List<ItemVendaModel> itens, List<ParcelaModel> parcelas = null)
        {
            string sqlVenda = @"
                INSERT INTO Venda (DataVenda, ClienteID, ValorTotal, FormaPgtoID, Desconto, Observacoes, StatusVenda, VendedorID)
                VALUES (@DataVenda, @ClienteID, @ValorTotal, @FormaPgtoID, @Desconto, @Observacoes, @StatusVenda, @VendedorID);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            string sqlItem = @" INSERT INTO ItemVenda (VendaID, ProdutoID, Quantidade, PrecoUnitario, Subtotal, DescontoItem)
            VALUES (@VendaID, @ProdutoID, @Quantidade, @PrecoUnitario, CAST(@Quantidade AS DECIMAL(18,2)) * @PrecoUnitario, @DescontoItem)";

            string sqlParcela = @"
                INSERT INTO Parcela (VendaID, NumeroParcela, DataVencimento, ValorParcela, ValorRecebido,
                                     Status, DataPagamento, Juros, Multa, Observacao)
                VALUES (@VendaID, @NumeroParcela, @DataVencimento, @ValorParcela, @ValorRecebido,
                        @Status, @DataPagamento, @Juros, @Multa, @Observacao)";

            string sqlBaixarEstoque = @" UPDATE Produtos 
                                         SET Estoque = Estoque - @Quantidade
                                         WHERE ProdutoID = @ProdutoID AND Estoque >= @Quantidade";


            using var conn = Conexao.Conex();
            conn.Open();
            using var transaction = conn.BeginTransaction();

            try
            {
                // 1️⃣ Inserir Venda e obter o ID gerado
                using (var cmdVenda = new SqlCommand(sqlVenda, conn, transaction))
                {
                    cmdVenda.Parameters.AddWithValue("@DataVenda", venda.DataVenda);
                    cmdVenda.Parameters.AddWithValue("@ClienteID", venda.ClienteID);
                    cmdVenda.Parameters.AddWithValue("@ValorTotal", venda.ValorTotal);
                    cmdVenda.Parameters.AddWithValue("@FormaPgtoID",venda.FormaPgtoID ?? (object)DBNull.Value);
                    cmdVenda.Parameters.AddWithValue("@Desconto", venda.Desconto);                    
                    cmdVenda.Parameters.AddWithValue("@Observacoes", (object)venda.Observacoes ?? DBNull.Value);
                    cmdVenda.Parameters.AddWithValue("@StatusVenda", venda.StatusVenda.ToDb());
                    cmdVenda.Parameters.AddWithValue("@VendedorID", venda.VendedorID);

                    int vendaId = (int)cmdVenda.ExecuteScalar();

                    // 2️⃣ Inserir Itens
                    if (itens != null && itens.Any())
                    {
                        // NO VendaDal, método AddVendaCompleta:
                        foreach (var item in itens)
                        {
                            item.VendaID = vendaId;
                                                       
                            // Atualiza o subtotal internamente
                            item.AtualizarSubtotal();

                            using var cmdItem = new SqlCommand(sqlItem, conn, transaction);
                            cmdItem.Parameters.AddWithValue("@VendaID", item.VendaID);
                            cmdItem.Parameters.AddWithValue("@ProdutoID", item.ProdutoID);
                            cmdItem.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                            cmdItem.Parameters.AddWithValue("@PrecoUnitario", item.PrecoUnitario);
                            cmdItem.Parameters.AddWithValue("@Subtotal", item.Subtotal); // já calculado
                            // ⭐⭐ SOLUÇÃO DEFINITIVA PARA DescontoItem nullable ⭐⭐
                            decimal descontoItemValor = (decimal)item.DescontoItem;
                            cmdItem.Parameters.AddWithValue("@DescontoItem", descontoItemValor);

                            cmdItem.ExecuteNonQuery();

                            using var cmdEstoque = new SqlCommand(sqlBaixarEstoque, conn, transaction);
                            cmdEstoque.Parameters.AddWithValue("@ProdutoID", item.ProdutoID);
                            cmdEstoque.Parameters.AddWithValue("@Quantidade", item.Quantidade);

                            int linhasAfetadas = cmdEstoque.ExecuteNonQuery();

                            if (linhasAfetadas == 0)
                            {
                                throw new Exception(
                                    $"Estoque insuficiente para o produto ID {item.ProdutoID}."
                                );
                            }

                        }
                    }

                    // 3️⃣ Inserir Parcelas
                    if (parcelas != null && parcelas.Any())
                    {
                        foreach (var p in parcelas)
                        {
                            p.VendaID = vendaId;
                            using var cmdParcela = new SqlCommand(sqlParcela, conn, transaction);
                           
                            cmdParcela.Parameters.AddWithValue("@VendaID", p.VendaID);
                            cmdParcela.Parameters.AddWithValue("@NumeroParcela", p.NumeroParcela);
                            cmdParcela.Parameters.AddWithValue("@DataVencimento", p.DataVencimento);

                            cmdParcela.Parameters.Add("@ValorParcela", SqlDbType.Decimal).Value = Math.Round(p.ValorParcela, 2, MidpointRounding.AwayFromZero);
                            cmdParcela.Parameters["@ValorParcela"].Precision = 18;
                            cmdParcela.Parameters["@ValorParcela"].Scale = 2;

                            cmdParcela.Parameters.Add("@ValorRecebido", SqlDbType.Decimal).Value =
                                p.ValorRecebido.HasValue ? Math.Round(Math.Min(p.ValorRecebido.Value, p.ValorParcela), 2, MidpointRounding.AwayFromZero) : (object)DBNull.Value;
                            cmdParcela.Parameters["@ValorRecebido"].Precision = 18;
                            cmdParcela.Parameters["@ValorRecebido"].Scale = 2;


                            // Status
                            cmdParcela.Parameters.AddWithValue("@Status", p.Status.ToDb());

                            // DataPagamento
                            cmdParcela.Parameters.AddWithValue("@DataPagamento", (object?)p.DataPagamento ?? DBNull.Value);

                            // Juros e Multa (somente uma vez, usando null quando zero)
                            cmdParcela.Parameters.AddWithValue("@Juros", p.Juros == 0 ? (object)DBNull.Value : p.Juros);
                            cmdParcela.Parameters.AddWithValue("@Multa", p.Multa == 0 ? (object)DBNull.Value : p.Multa);

                            // Observacao
                            cmdParcela.Parameters.AddWithValue("@Observacao", (object?)p.Observacao ?? DBNull.Value);
                                                        
                            cmdParcela.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    return vendaId;
                }
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public void UpdateVenda(VendaModel venda)
        {
            string sql = @"
                UPDATE Venda
                SET DataVenda = @DataVenda,
                    ClienteID = @ClienteID,
                    ValorTotal = @ValorTotal,
                    FormaPgtoID = @FormaPgtoID,
                    Desconto = @Desconto,
                    Observacoes = @Observacoes,
                    StatusVenda = @StatusVenda
                    VendedorID = @VendedorID
                WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", venda.VendaID);
            cmd.Parameters.AddWithValue("@DataVenda", venda.DataVenda);
            cmd.Parameters.AddWithValue("@ClienteID", venda.ClienteID);
            cmd.Parameters.AddWithValue("@ValorTotal", venda.ValorTotal);
            cmd.Parameters.AddWithValue("@FormaPgtoID", venda.FormaPgtoID);
            cmd.Parameters.AddWithValue("@Desconto", venda.Desconto == 0 ? (object)DBNull.Value : venda.Desconto);
            cmd.Parameters.AddWithValue("@Observacoes", (object)venda.Observacoes ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@StatusVenda", (object)venda.StatusVenda ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@VendedorID",venda.VendedorID);
            cmd.ExecuteNonQuery();
        }

        public void DeleteVenda(long vendaId)
        {
            using var conn = Conexao.Conex();
            conn.Open();
            using var trans = conn.BeginTransaction();
            try
            {
                using var cmd1 = new SqlCommand("DELETE FROM ItemVenda WHERE VendaID = @Id", conn, trans);
                cmd1.Parameters.AddWithValue("@Id", vendaId);
                cmd1.ExecuteNonQuery();

                using var cmd2 = new SqlCommand("DELETE FROM Parcela WHERE VendaID = @Id", conn, trans);
                cmd2.Parameters.AddWithValue("@Id", vendaId);
                cmd2.ExecuteNonQuery();

                using var cmd3 = new SqlCommand("DELETE FROM Venda WHERE VendaID = @Id", conn, trans);
                cmd3.Parameters.AddWithValue("@Id", vendaId);
                cmd3.ExecuteNonQuery();

                trans.Commit();
            }
            catch
            {
                trans.Rollback();
                throw;
            }
        }

        public void DeleteVenda(VendaModel venda) => DeleteVenda(venda.VendaID);

        public VendaModel? GetVenda(long vendaId)
        {
            string sql = "SELECT * FROM Venda WHERE VendaID = @VendaID";
            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new VendaModel
                {
                    VendaID = reader.GetInt32("VendaID"),
                    DataVenda = reader.GetDateTime("DataVenda"),
                    ClienteID = reader.GetInt32("ClienteID"),
                    ValorTotal = reader.GetDecimal("ValorTotal"),
                    FormaPgtoID = reader.GetInt32("FormaPgtoID"),
                    Desconto = (decimal)(reader.IsDBNull("Desconto") ? (decimal?)null : reader.GetDecimal("Desconto")),
                    Observacoes = reader.IsDBNull("Observacoes") ? null : reader.GetString("Observacoes") as string,
                    StatusVenda = reader.IsDBNull("StatusVenda")? EnumStatusVenda.Aberta : reader.GetString("StatusVenda").ToEnumStatusVenda(),

                    VendedorID = reader.GetInt32("VendedorID")
                };
            }
            return null;
        }

        public DataTable ListarVendas()
        {
            string sql = @"SELECT
        v.VendaID,
        v.DataVenda,
        c.Nome AS Cliente,
        v.ValorTotal,
        v.Desconto,
        v.Observacoes,
        v.StatusVenda,
        v.VendedorID,
        f.NomeFormaPagamento AS NomeFormaPagamento
    FROM Venda v
    INNER JOIN Cliente c ON v.ClienteID = c.ClienteID
    LEFT JOIN FormaPagamento f ON v.FormaPgtoID = f.FormaPgtoID
    ORDER BY v.DataVenda DESC";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            var dt = new DataTable();
            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }


        public DataTable VendaLocalizarPorCliente(long clienteId)
        {
            string sql = @" SELECT
                v.VendaID,
                v.DataVenda,
                v.ValorTotal,
                v.Desconto,
                v.Observacoes,
                v.StatusVenda,
                v.VendedorID
                f.NomeFormaPagamento AS NomeFormaPagamento
            FROM Venda v
            LEFT JOIN FormaPagamento f ON v.FormaPgtoID = f.FormaPgtoID
            WHERE v.ClienteID = @ClienteID
            ORDER BY v.DataVenda DESC";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ClienteID", clienteId);
            var dt = new DataTable();
            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        public DataTable RelatorioVendasPorPeriodo(DateTime inicio, DateTime fim)
        {
            string sql = @" SELECT
                v.VendaID,
                v.DataVenda,
                c.Nome,
                v.ValorTotal,
                v.Desconto,
                v.Observacoes,
                v.StatusVenda,
                v.VendedorID
                f.NomeFormaPagamento AS NomeFormaPagamento
            FROM Venda v
            INNER JOIN Cliente c ON v.ClienteID = c.ClienteID
            LEFT JOIN FormaPagamento f ON v.FormaPgtoID = f.FormaPgtoID
            WHERE v.DataVenda BETWEEN @Inicio AND @Fim
            ORDER BY v.DataVenda DESC";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Inicio", inicio.Date);
            cmd.Parameters.AddWithValue("@Fim", fim.Date.AddDays(1).AddSeconds(-1));
            var dt = new DataTable();
            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        public decimal TotalVendidoHoje()
        {
            string sql = @" SELECT COALESCE(SUM(ValorTotal), 0)
                            FROM Venda 
                            WHERE CAST(DataVenda AS DATE) = CAST(GETDATE() AS DATE)";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            return (decimal)cmd.ExecuteScalar();
        }

        public int UltimaVendaId()
        {
            string sql = "SELECT ISNULL(MAX(VendaID), 0) FROM Venda";
            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            return (int)cmd.ExecuteScalar();
        }
        public void AtualizarStatusVenda(long vendaId, string novoStatus)
        {
            string sql = @"UPDATE Venda SET StatusVenda = @Status WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.Parameters.AddWithValue("@Status", novoStatus);
            cmd.ExecuteNonQuery();
        }

        public void AtualizarStatusVenda(long vendaId, string novoStatus, string motivo)
        {
            string sql = @"
        UPDATE Venda 
        SET StatusVenda = @Status,
            Observacoes =
                CASE 
                    WHEN Observacoes IS NULL OR Observacoes = ''
                        THEN @Motivo
                    ELSE Observacoes + CHAR(13) + CHAR(10) + @Motivo
                END
        WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.Parameters.AddWithValue("@Status", novoStatus);
            cmd.Parameters.AddWithValue("@Motivo", $"CANCELAMENTO: {motivo}");
            cmd.ExecuteNonQuery();
        }

        public VendaModel ObterVendaPorId(long vendaId)
        {
            string sql = @" SELECT
    v.VendaID,
    v.ClienteID,
    v.FormaPgtoID,
    v.DataVenda,
    v.ValorTotal,
    v.Desconto,
    v.Observacoes,
    v.StatusVenda,
    v.VendedorID,
    c.Nome AS NomeCliente
FROM Venda v
LEFT JOIN Clientes c ON c.ClienteID = v.ClienteID
WHERE v.VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var venda = new VendaModel
                {
                    VendaID = reader.GetInt32("VendaID"),
                    ClienteID = reader.GetInt32("ClienteID"),
                    FormaPgtoID = reader.GetInt32("FormaPgtoID"),
                    DataVenda = reader.GetDateTime("DataVenda"),
                    ValorTotal = reader.GetDecimal("ValorTotal"),
                    Desconto = (decimal)(reader.IsDBNull("Desconto") ? (decimal?)null : reader.GetDecimal("Desconto")),
                    Observacoes = reader.IsDBNull("Observacoes") ? null : reader.GetString("Observacoes") as string,
                    //StatusVenda Corrigido da Forma Correta em 02/01/2026 use Este MODELO
                    StatusVenda = reader.IsDBNull("StatusVenda") ? EnumStatusVenda.Aberta
                    : Enum.Parse<EnumStatusVenda>(reader.GetString("StatusVenda").Replace(" ", "")),

                    VendedorID = reader.GetInt32("VendedorID")
                };

                return venda;
            }
            return null;
        }
        public void Excluir(long vendaID)
        {
            using var conn = Conexao.Conex();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Venda WHERE VendaID = @id";
            cmd.Parameters.AddWithValue("@id", vendaID);
            cmd.ExecuteNonQuery();
        }
    }
}
using GVC.Model;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace GVC.DAL
{
    public class VendaAtualizacaoDal
    {
        // ============================
        // MÉTODO PÚBLICO (ENTRY POINT)
        // ============================
        public void AtualizarVendaCompleta(
            VendaModel venda,
            List<ItemVendaModel> itens,
            List<ParcelaModel> parcelas)
        {
            using var conn = Conexao.Conex();
            conn.Open();

            using var tran = conn.BeginTransaction();

            try
            {
                // 1️⃣ Atualiza cabeçalho da venda
                AtualizarVenda(venda, conn, tran);

                // 2️⃣ Itens
                ExcluirItens(venda.VendaID, conn, tran);
                InserirItens(venda.VendaID, itens, conn, tran);

                // 3️⃣ Parcelas
                ExcluirParcelas(venda.VendaID, conn, tran);
                InserirParcelas(venda.VendaID, parcelas, conn, tran);

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }

        // ============================
        // MÉTODOS PRIVADOS (AUXILIARES)
        // ============================

        private void AtualizarVenda(
            VendaModel venda,
            SqlConnection conn,
            SqlTransaction tran)
        {
            string sql = @"
                UPDATE Venda
                SET ClienteID   = @ClienteID,
                    FormaPgtoID = @FormaPgtoID,
                    DataVenda   = @DataVenda,
                    ValorTotal  = @ValorTotal,
                    Desconto    = @Desconto,
                    Observacoes = @Observacoes,
                    StatusVenda = @StatusVenda
                WHERE VendaID = @VendaID";

            using var cmd = new SqlCommand(sql, conn, tran);
            cmd.Parameters.AddWithValue("@VendaID", venda.VendaID);
            cmd.Parameters.AddWithValue("@ClienteID", venda.ClienteID);
            cmd.Parameters.AddWithValue("@FormaPgtoID", venda.FormaPgtoID ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@DataVenda", venda.DataVenda);
            cmd.Parameters.AddWithValue("@ValorTotal", venda.ValorTotal);
            cmd.Parameters.AddWithValue("@Desconto", venda.Desconto);
            cmd.Parameters.AddWithValue("@Observacoes", (object)venda.Observacoes ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@StatusVenda", venda.StatusVenda);

            cmd.ExecuteNonQuery();
        }

        private void ExcluirItens(
            long vendaId,
            SqlConnection conn,
            SqlTransaction tran)
        {
            string sql = "DELETE FROM ItemVenda WHERE VendaID = @VendaID";

            using var cmd = new SqlCommand(sql, conn, tran);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.ExecuteNonQuery();
        }

        private void InserirItens(long vendaId, List<ItemVendaModel> itens, SqlConnection conn, SqlTransaction tran)
        {
            string sql = @"
        INSERT INTO ItemVenda
        (VendaID, ProdutoID, Quantidade, PrecoUnitario, Subtotal, DescontoItem)
        VALUES
        (@VendaID, @ProdutoID, @Quantidade, @PrecoUnitario, @Subtotal, @DescontoItem)";

            foreach (var item in itens)
            {
                using var cmd = new SqlCommand(sql, conn, tran);
                cmd.Parameters.AddWithValue("@VendaID", vendaId);
                cmd.Parameters.AddWithValue("@ProdutoID", item.ProdutoID);
                cmd.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                cmd.Parameters.AddWithValue("@PrecoUnitario", item.PrecoUnitario);
                cmd.Parameters.AddWithValue("@Subtotal", item.Subtotal); // leitura ok
                cmd.Parameters.AddWithValue("@DescontoItem", item.DescontoItem); // já não é nullable

                cmd.ExecuteNonQuery();
            }
        }


        private void ExcluirParcelas(
            long vendaId,
            SqlConnection conn,
            SqlTransaction tran)
        {
            string sql = "DELETE FROM Parcela WHERE VendaID = @VendaID";

            using var cmd = new SqlCommand(sql, conn, tran);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.ExecuteNonQuery();
        }

        private void InserirParcelas(
            long vendaId,
            List<ParcelaModel> parcelas,
            SqlConnection conn,
            SqlTransaction tran)
        {
            string sql = @"
                INSERT INTO Parcela
                (VendaID, NumeroParcela, DataVencimento, ValorParcela,
                 ValorRecebido, Status, DataPagamento, Juros, Multa, Observacao)
                VALUES
                (@VendaID, @NumeroParcela, @DataVencimento, @ValorParcela,
                 @ValorRecebido, @Status, @DataPagamento, @Juros, @Multa, @Observacao)";

            foreach (var p in parcelas)
            {
                using var cmd = new SqlCommand(sql, conn, tran);
                cmd.Parameters.AddWithValue("@VendaID", vendaId);
                cmd.Parameters.AddWithValue("@NumeroParcela", p.NumeroParcela);
                cmd.Parameters.AddWithValue("@DataVencimento", p.DataVencimento);
                cmd.Parameters.AddWithValue("@ValorParcela", p.ValorParcela);
                cmd.Parameters.AddWithValue("@ValorRecebido", p.ValorRecebido);
                cmd.Parameters.AddWithValue("@Status", p.Status);
                cmd.Parameters.AddWithValue("@DataPagamento", (object)p.DataPagamento ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Juros", p.Juros);
                cmd.Parameters.AddWithValue("@Multa", p.Multa);
                cmd.Parameters.AddWithValue("@Observacao", (object)p.Observacao ?? DBNull.Value);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
using Dapper;
using GVC.Model;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GVC.DAL
{
    public class ParcelaDal
    {
        public void InsertParcela(ParcelaModel parcela)
        {
            const string sql = @" INSERT INTO Parcela (
                    VendaID, NumeroParcela, DataVencimento, ValorParcela, ValorRecebido,
                    Status, DataPagamento, Juros, Multa, Observacao)
                VALUES ( @VendaID, @NumeroParcela, @DataVencimento, @ValorParcela, @ValorRecebido,
                    @Status, @DataPagamento, @Juros, @Multa, @Observacao )";
            using var conn = Conexao.Conex();
            conn.Execute(sql, parcela);
        }

        public void InsertParcelas(List<ParcelaModel> parcelas)
        {
            if (!parcelas.Any()) return;

            const string sql = @" INSERT INTO Parcela (
                    VendaID, NumeroParcela, DataVencimento, ValorParcela, ValorRecebido,
                    Status, DataPagamento, Juros, Multa, Observacao
                )
                VALUES (
                    @VendaID, @NumeroParcela, @DataVencimento, @ValorParcela, @ValorRecebido,
                    @Status, @DataPagamento, @Juros, @Multa, @Observacao
                )";

            using var conn = Conexao.Conex();
            conn.Execute(sql, parcelas);
        }

        public void UpdateParcela(ParcelaModel parcela)
        {
            const string sql = @"UPDATE Parcela 
                SET DataVencimento = @DataVencimento,
                    ValorParcela   = @ValorParcela,
                    ValorRecebido  = @ValorRecebido,
                    Status         = @Status,
                    DataPagamento  = @DataPagamento,
                    Juros          = @Juros,
                    Multa          = @Multa,
                    Observacao     = @Observacao
                WHERE ParcelaID = @ParcelaID";

            using var conn = Conexao.Conex();
            conn.Execute(sql, parcela);
        }

        public void BaixarParcela(long parcelaId, decimal valorPago, DateTime dataPagamento)
        {
            const string sql = @" UPDATE Parcela
           SET ValorRecebido = ValorRecebido + @ValorPago,
               DataPagamento = @DataPagamento
         WHERE ParcelaID = @ParcelaID";

            using var conn = Conexao.Conex();
            conn.Execute(sql, new
            {
                ParcelaID = parcelaId,
                ValorPago = valorPago,
                DataPagamento = dataPagamento
            });
        }

        public void BaixarParcelasEmLote(List<long> parcelasIds, DateTime dataPagamento)
        {
            if (parcelasIds == null || parcelasIds.Count == 0)
                return;

            using var conn = Conexao.Conex();
            conn.Open();
            using var transaction = conn.BeginTransaction();

            try
            {
                const string sqlBaixa = @"
            UPDATE Parcela
            SET ValorRecebido = ValorParcela + Juros + Multa,
                DataPagamento = @DataPagamento
            WHERE ParcelaID = @ParcelaID";

                foreach (var parcelaId in parcelasIds)
                {
                    conn.Execute(sqlBaixa, new
                    {
                        ParcelaID = parcelaId,
                        DataPagamento = dataPagamento
                    }, transaction);
                }

                const string sqlHistorico = @"
            INSERT INTO PagamentosParciais (ParcelaID, DataPagamento,FormaPgtoID, ValorPago, Observacao)
            SELECT 
                ParcelaID,
                @DataPagamento,
                (ValorParcela + Juros + Multa - ValorRecebido),
                'Baixa total em lote'
            FROM Parcela
            WHERE ParcelaID = @ParcelaID";

                foreach (var parcelaId in parcelasIds)
                {
                    conn.Execute(sqlHistorico, new
                    {
                        ParcelaID = parcelaId,
                        DataPagamento = dataPagamento
                    }, transaction);
                }

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public ParcelaModel? BuscarPorId(decimal parcelaId)
        {
            const string sql = "SELECT * FROM Parcela WHERE ParcelaID = @Id";
            using var conn = Conexao.Conex();
            return conn.QueryFirstOrDefault<ParcelaModel>(sql, new { Id = parcelaId });
        }

        public List<ParcelaModel> GetParcelas(long vendaId)
        {
            const string sql = @"SELECT * FROM Parcela WHERE VendaID = @VendaID ORDER BY NumeroParcela";

            using var conn = Conexao.Conex();
            return conn.Query<ParcelaModel>(sql, new { VendaID = vendaId }).AsList();
        }

        public DataTable ListarParcelas()
        {
            AtualizarParcelasAtrasadas();
            const string sql = "SELECT * FROM Parcela ORDER BY DataVencimento";

            using var conn = Conexao.Conex();
            var dt = new DataTable();
            dt.Load(conn.ExecuteReader(sql));
            return dt;
        }

        public DataTable ListarParcelasPendentesPorCliente(int clienteId)
        {
            const string sql = @"SELECT p.*,
                       v.DataVenda,
                       c.Nome
                FROM Parcela p
                INNER JOIN Venda v   ON p.VendaID = v.VendaID
                INNER JOIN Cliente c ON v.ClienteID = c.ClienteID
                WHERE c.ClienteID = @ClienteID
                  AND p.Status = 'Pendente'
                ORDER BY p.DataVencimento";

            using var conn = Conexao.Conex();
            var dt = new DataTable();
            dt.Load(conn.ExecuteReader(sql, new { ClienteID = clienteId }));
            return dt;
        }

        public void Excluir(ParcelaModel parcela)
        {
            const string sql = "DELETE FROM Parcela WHERE ParcelaID = @Id";
            using var conn = Conexao.Conex();
            conn.Execute(sql, new { Id = parcela.ParcelaID });
        }

        public void EstornarPagamento(long parcelaId, decimal valorEstorno, DateTime dataEstorno, string motivo = null)
        {
            if (valorEstorno <= 0m)
                throw new ArgumentException("Valor do estorno deve ser maior que zero.");

            if (string.IsNullOrWhiteSpace(motivo))
                motivo = "Estorno sem motivo informado";

            // Observação que será gravada junto ao estorno
            string observacao = $"[{dataEstorno:dd/MM/yyyy HH:mm}] Estorno de {valorEstorno:C2} - Motivo: {motivo}";

            const string sql = @"INSERT INTO PagamentosParciais 
            (ParcelaID, ValorPago, DataPagamento, FormaPgtoID, Observacao)
            VALUES (@ParcelaID, -@ValorEstorno, @DataEstorno, NULL, @Observacao);";

            using var conn = Conexao.Conex();
            conn.Execute(sql, new
            {
                ParcelaID = parcelaId,
                ValorEstorno = valorEstorno,
                DataEstorno = dataEstorno,
                Observacao = observacao
            });
        }


        public void AtualizarParcelasAtrasadas()
        {
            const string sql = @"
                UPDATE Parcela
                SET Status = 'Atrasada'
                WHERE Status IN ('Pendente', 'Parcialmente Paga')
                  AND DataVencimento < GETDATE()";   // ✅ Ajuste para SQL Server

            using var conn = Conexao.Conex();
            conn.Execute(sql);
        }

        public void CancelarParcelasPorVenda(long vendaId)
        {
            string sql = @"
        UPDATE Parcela 
        SET Status = 'CANCELADA',
            ValorRecebido = 0,
            DataPagamento = NULL
        WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.ExecuteNonQuery();
        }       
        public bool ExistePagamentoPorVenda(long vendaId)
        {
            string sql = @" SELECT COUNT(1)
        FROM Parcela p
        LEFT JOIN PagamentosParciais pp ON pp.ParcelaID = p.ParcelaID
        WHERE p.VendaID = @VendaID
          AND ( p.ValorRecebido > 0 OR pp.PagamentoID IS NOT NULL )";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }
        public void ExcluirPorVenda(long vendaId)
        {
            string sql = "DELETE FROM Parcela WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.ExecuteNonQuery();
        }
        // 26/12/2025
    }
}
using Dapper;
using GVC.Model;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GVC.DAL
{
    internal class PagamentoParcialDal
    {
        // 1. INSERIR PAGAMENTO PARCIAL       
        public void InserirPagamentoParcial(PagamentosParcialModel pagamentoParcial)
        {
            const string sql = @"INSERT INTO PagamentosParciais (ParcelaID, ValorPago, DataPagamento) 
                VALUES (@ParcelaID, @ValorPago, @DataPagamento)";
            using var conn = Conexao.Conex();
            conn.Execute(sql, pagamentoParcial);
        }

        // 2. EXCLUIR PAGAMENTO PARCIAL POR ID
        public void ExcluirPagamentoParcial(long pagamentoParcialId)
        {
            const string sql = "DELETE FROM PagamentosParciais WHERE PagamentoParcialID = @Id";
            using var conn = Conexao.Conex();
            conn.Execute(sql, new { Id = pagamentoParcialId });
        }

        public void Excluir(PagamentosParcialModel pagamentoParcial)
            => ExcluirPagamentoParcial(pagamentoParcial.PagamentoID);

        // 3. LISTAR PAGAMENTOS PARCIAIS DE UMA PARCELA        
        public List<PagamentosParcialModel> ObterPagamentosParciaisPorParcela(long parcelaId)
        {
            const string sql = @" SELECT PagamentoParcialID,
                       ParcelaID,
                       ValorPago,
                       DataPagamento
                FROM PagamentosParciais 
                WHERE ParcelaID = @ParcelaID 
                ORDER BY DataPagamento DESC";

            using var conn = Conexao.Conex();
            return conn.Query<PagamentosParcialModel>(sql, new { ParcelaID = parcelaId }).AsList();
        }
        public PagamentoExtratoModel ObterPagamentoPorId(long pagamentoId)
        {
            const string sql = @"
        SELECT
            pp.DataPagamento,
            pp.ValorPago,
            fp.NomeFormaPagamento AS NOmeFormaPagamento,
            pp.Observacao
        FROM PagamentosParciais pp
        LEFT JOIN FormaPagamento fp ON fp.FormaPgtoID = pp.FormaPgtoID
        WHERE pp.PagamentoID = @PagamentoID";

            using var conn = Conexao.Conex();
            return conn.QueryFirstOrDefault<PagamentoExtratoModel>(
                sql, new { PagamentoID = pagamentoId });
        }

        // 4. EXCLUIR TODOS OS PAGAMENTOS PARCIAIS DE UMA PARCELA        
        public void ExcluirPagamentosParciaisPorParcelaID(long parcelaId)
        {
            const string sql = "DELETE FROM PagamentosParciais WHERE ParcelaID = @ParcelaID";
            using var conn = Conexao.Conex();
            conn.Execute(sql, new { ParcelaID = parcelaId });
        }

        // 5. LISTAR TODOS OS PAGAMENTOS PARCIAIS (para relatório)       
        public DataTable ListarPagamentosParciais()
        {
            const string sql = @" SELECT pp.PagamentoParcialID,
                       pp.ParcelaID,
                       p.NumeroParcela,
                       c.Nome,
                       pp.ValorPago,
                       pp.DataPagamento
                FROM PagamentosParciais pp
                INNER JOIN Parcela p ON pp.ParcelaID = p.ParcelaID
                INNER JOIN Venda v ON p.VendaID = v.VendaID
                INNER JOIN Cliente c ON v.ClienteID = c.ClienteID
                ORDER BY pp.DataPagamento DESC";

            using var conn = Conexao.Conex();
            var dt = new DataTable();
            dt.Load(conn.ExecuteReader(sql));
            return dt;
        }

        // 6. TOTAL PAGO PARCIALMENTE EM UMA PARCELA
        public decimal TotalPagoParcialmente(long parcelaId)
        {
            const string sql = @" SELECT ISNULL(SUM(ValorPago), 0) 
                FROM PagamentosParciais WHERE ParcelaID = @ParcelaID";  // ✅ Ajuste para SQL Server

            using var conn = Conexao.Conex();
            return conn.QuerySingle<decimal>(sql, new { ParcelaID = parcelaId });
        }

        // 7. REGISTRAR PAGAMENTO PARCIAL + ATUALIZAR PARCELA AUTOMATICAMENTE       
        public void RegistrarPagamentoParcial(long parcelaId, decimal valorPago, DateTime dataPagamento,
                long? formaPgtoId = null, string? observacao = null)
        {
            const string sql = @"INSERT INTO PagamentosParciais
        (ParcelaID, ValorPago, DataPagamento, FormaPgtoID, Observacao)
        VALUES(@ParcelaID, @ValorPago, @DataPagamento, @FormaPgtoID, @Observacao)";

            using var conn = Conexao.Conex();
            conn.Execute(sql, new
            {
                ParcelaID = parcelaId,
                ValorPago = valorPago,
                DataPagamento = dataPagamento,
                FormaPgtoID = formaPgtoId,               
                Observacao = observacao
            });
        }


        public List<PagamentoExtratoModel> ListarPagamentosPorParcela(long parcelaId)
        {
            const string sql = @"
                SELECT
                    pp.PagamentoID,
                    pp.ParcelaID,
                    pp.DataPagamento,
                    pp.ValorPago,
                    fp.NomeFormaPagamento AS NomeFormaPagamento,
                    pp.Observacao
                FROM PagamentosParciais pp
                LEFT JOIN FormaPagamento fp ON fp.FormaPgtoID = pp.FormaPgtoID
                WHERE pp.ParcelaID = @ParcelaID
                ORDER BY pp.DataPagamento";

            using var conn = Conexao.Conex();
            return conn.Query<PagamentoExtratoModel>(sql, new { ParcelaID = parcelaId }).ToList();
        }
        public List<PagamentoExtratoModel> ListarPagamentosPorParcelaCompleto(long parcelaId)
        {
            const string sql = @"
        SELECT 
            pp.DataPagamento,
            pp.ValorPago,
            fp.NomeFormaPagamento AS NomeFormaPagamento,
            ISNULL(pp.Observacao, 'Baixa parcial') AS Observacao
        FROM PagamentosParciais pp
        LEFT JOIN FormaPagamento fp ON fp.FormaPgtoID = pp.FormaPgtoID
        WHERE pp.ParcelaID = @ParcelaID
        ORDER BY pp.DataPagamento";

            using var conn = Conexao.Conex();
            return conn.Query<PagamentoExtratoModel>(sql, new { ParcelaID = parcelaId }).ToList();
        }




        // 8. BUSCAR PAGAMENTO PARCIAL POR ID
        public PagamentosParcialModel? BuscarPorId(long pagamentoId)
        {
            const string sql = "SELECT * FROM PagamentosParciais WHERE PagamentoID = @Id";
            using var conn = Conexao.Conex();
            return conn.QueryFirstOrDefault<PagamentosParcialModel>(sql, new { Id = pagamentoId });
        }
        public void ExcluirPorVenda(long vendaId)
        {
            string sql = @"
                DELETE FROM PagamentosParciais
                WHERE ParcelaID IN (
                    SELECT ParcelaID 
                    FROM Parcela 
                    WHERE VendaID = @VendaID
                )";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.ExecuteNonQuery();
        }

        public List<PagamentoExtratoModel> ObterExtratoPorParcela(long parcelaId)
        {
            const string sql = @"
SELECT
    pp.DataPagamento,
    pp.ValorPago,
    fp.NomeFormaPagamento AS FormaPagamento,
    pp.Observacao
FROM PagamentosParciais pp
LEFT JOIN FormaPagamento fp ON fp.FormaPgtoID = pp.FormaPgtoID
WHERE pp.ParcelaID = @ParcelaID
ORDER BY pp.DataPagamento";

            using var conn = Conexao.Conex();
            return conn.Query<PagamentoExtratoModel>(sql, new { ParcelaID = parcelaId }).ToList();
        }

    }
}
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.DAL
{
    public class MovimentacaoEstoqueDAL
    {
        public DataTable Consultar(
            int? produtoId,
            string tipo,
            string origem,
            DateTime inicio,
            DateTime fim)
        {
            var dt = new DataTable();

            using var conn = Conexao.Conex();
            conn.Open();

            string sql = @"
        SELECT
            me.MovimentacaoID,
            me.DataMovimentacao,
            me.TipoMovimentacao,
            me.Quantidade,
            me.EstoqueAnterior,
            me.EstoqueAtual,
            me.Origem,
            me.Documento,
            me.Observacao,
            me.Usuario,
            p.ProdutoID,
            p.NomeProduto
        FROM MovimentacaoEstoque me
        INNER JOIN Produtos p ON p.ProdutoID = me.ProdutoID
        WHERE me.DataMovimentacao BETWEEN @Inicio AND @Fim";

            if (produtoId.HasValue)
                sql += " AND me.ProdutoID = @ProdutoID";

            if (!string.IsNullOrEmpty(tipo))
                sql += " AND me.TipoMovimentacao = @Tipo";

            if (!string.IsNullOrEmpty(origem))
                sql += " AND me.Origem = @Origem";

            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Inicio", inicio);
            cmd.Parameters.AddWithValue("@Fim", fim);

            if (produtoId.HasValue)
                cmd.Parameters.AddWithValue("@ProdutoID", produtoId.Value);

            if (!string.IsNullOrEmpty(tipo))
                cmd.Parameters.AddWithValue("@Tipo", tipo);

            if (!string.IsNullOrEmpty(origem))
                cmd.Parameters.AddWithValue("@Origem", origem);

            using var da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
    }
}
using GVC.Model;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace GVC.DAL
{
    public class ItemVendaDal
    {
        // 1. ADICIONAR ITEM NA VENDA
        public void AddItemVenda(ItemVendaModel itemVenda)
        {
            string sql = @"
                INSERT INTO ItemVenda (
                    VendaID, ProdutoID, Quantidade, PrecoUnitario, Subtotal, DescontoItem
                )
                VALUES (
                    @VendaID, @ProdutoID, @Quantidade, @PrecoUnitario, @Subtotal, @DescontoItem
                )";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", itemVenda.VendaID);
            cmd.Parameters.AddWithValue("@ProdutoID", itemVenda.ProdutoID);
            cmd.Parameters.AddWithValue("@Quantidade", itemVenda.Quantidade);
            cmd.Parameters.AddWithValue("@PrecoUnitario", itemVenda.PrecoUnitario);
            cmd.Parameters.AddWithValue("@Subtotal", itemVenda.Subtotal);
            cmd.Parameters.AddWithValue("@DescontoItem", itemVenda.DescontoItem);
            cmd.ExecuteNonQuery();
        }

        // 2. ATUALIZAR ITEM DA VENDA
        public void UpdateItemVenda(ItemVendaModel itemVenda)
        {
            string sql = @"
                UPDATE ItemVenda
                SET ProdutoID = @ProdutoID,
                    Quantidade = @Quantidade,
                    PrecoUnitario = @PrecoUnitario,
                    Subtotal = @Subtotal,
                    DescontoItem = @DescontoItem
                WHERE ItemVendaID = @ItemVendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ItemVendaID", itemVenda.ItemVendaID);
            cmd.Parameters.AddWithValue("@ProdutoID", itemVenda.ProdutoID);
            cmd.Parameters.AddWithValue("@Quantidade", itemVenda.Quantidade);
            cmd.Parameters.AddWithValue("@PrecoUnitario", itemVenda.PrecoUnitario);
            cmd.Parameters.AddWithValue("@Subtotal", itemVenda.Subtotal);
            cmd.Parameters.AddWithValue("@DescontoItem", itemVenda.DescontoItem);
            cmd.ExecuteNonQuery();
        }

        // 3. EXCLUIR ITEM POR ID
        public void DeleteItemVenda(long itemVendaId)
        {
            string sql = "DELETE FROM ItemVenda WHERE ItemVendaID = @ItemVendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ItemVendaID", itemVendaId);
            cmd.ExecuteNonQuery();
        }

        public void Excluir(ItemVendaModel itemVenda) => DeleteItemVenda(itemVenda.ItemVendaID);

        // 4. LISTAR TODOS OS ITENS DE UMA VENDA
        public List<ItemVendaModel> ConsultarItensVenda(int vendaId)
        {
            string sql = @"
        SELECT ItemVendaID,
               VendaID,
               ProdutoID,
               Quantidade,
               PrecoUnitario,
               Subtotal,
               DescontoItem
        FROM ItemVenda
        WHERE VendaID = @VendaID
        ORDER BY ItemVendaID";

            var lista = new List<ItemVendaModel>();

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var quantidade = reader.GetInt32("Quantidade");
                var precoUnitario = reader.GetDecimal("PrecoUnitario");
                var descontoItem = reader.IsDBNull("DescontoItem") ? 0m : reader.GetDecimal("DescontoItem");

                var item = new ItemVendaModel
                {
                    ItemVendaID = reader.GetInt32("ItemVendaID"),
                    VendaID = reader.GetInt32("VendaID"),
                    ProdutoID = reader.GetInt32("ProdutoID"),
                    Quantidade = quantidade,
                    PrecoUnitario = precoUnitario,
                    DescontoItem = descontoItem
                };

                // ✅ Calcula Subtotal automaticamente
                lista.Add(item);
            }
            return lista;
        }

        // 5. EXCLUIR TODOS OS ITENS DE UMA VENDA
        public void ExcluirItensPorVendaID(int vendaID)
        {
            string sql = "DELETE FROM ItemVenda WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaID);
            cmd.ExecuteNonQuery();
        }

        // 6. LISTAR TODOS OS ITENS (para relatórios)
        public DataTable ListarItensVenda()
        {
            string sql = "SELECT * FROM ItemVenda ORDER BY VendaID, ItemVendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            var dt = new DataTable();
            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        // 7. BUSCAR ITEM POR ID
        public ItemVendaModel? BuscarPorId(int itemVendaId)
        {
            string sql = "SELECT * FROM ItemVenda WHERE ItemVendaID = @Id";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", itemVendaId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var quantidade = reader.GetInt32("Quantidade");
                var precoUnitario = reader.GetDecimal("PrecoUnitario");
                var descontoItem = reader.IsDBNull("DescontoItem") ? 0m : reader.GetDecimal("DescontoItem");

                // ✅ Criar item primeiro
                var item = new ItemVendaModel
                {
                    ItemVendaID = reader.GetInt32("ItemVendaID"),
                    VendaID = reader.GetInt32("VendaID"),
                    ProdutoID = reader.GetInt32("ProdutoID"),
                    Quantidade = quantidade,
                    PrecoUnitario = precoUnitario,
                    DescontoItem = descontoItem
                };

                // ✅ Calcular subtotal usando método interno
                item.AtualizarSubtotal();

                return item;
            }
            return null;
        }


        // 8. CALCULAR TOTAL DA VENDA
        public decimal CalcularTotalVenda(int vendaId)
        {
            string sql = @"
                SELECT ISNULL(SUM((Quantidade * PrecoUnitario) - ISNULL(DescontoItem, 0)), 0)
                FROM ItemVenda
                WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            return (decimal)cmd.ExecuteScalar();
        }

        // 9. LISTAR ITENS COM DADOS DO PRODUTO
        public DataTable ListarItensComProduto(int vendaId)
        {
            string sql = @"
                SELECT
                    iv.ItemVendaID,
                    iv.VendaID,
                    iv.ProdutoID,
                    p.NomeProduto AS ProdutoDescricao,
                    p.CodigoBarras,
                    iv.Quantidade,
                    iv.PrecoUnitario,
                    iv.Subtotal,
                    iv.DescontoItem,
                    (iv.Quantidade * iv.PrecoUnitario - ISNULL(iv.DescontoItem, 0)) AS TotalItem
                FROM ItemVenda iv
                INNER JOIN Produtos p ON iv.ProdutoID = p.ProdutoID
                WHERE iv.VendaID = @VendaID
                ORDER BY iv.ItemVendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            var dt = new DataTable();
            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        // 10. LISTAR ITENS POR VENDA COM NOME DO PRODUTO
        public List<ItemVendaModel> ListarItensPorVenda(long vendaId)
        {
            string sql = @"
        SELECT
            iv.ItemVendaID,
            iv.VendaID,
            iv.ProdutoID,
            p.NomeProduto AS ProdutoDescricao,
            iv.Quantidade,
            iv.PrecoUnitario,
            iv.DescontoItem
        FROM ItemVenda iv
        INNER JOIN Produtos p ON iv.ProdutoID = p.ProdutoID
        WHERE iv.VendaID = @VendaID
        ORDER BY iv.ItemVendaID";

            var itens = new List<ItemVendaModel>();

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var quantidade = reader.GetInt32("Quantidade");
                var precoUnitario = reader.GetDecimal("PrecoUnitario");
                var descontoItem = reader.IsDBNull("DescontoItem") ? 0m : reader.GetDecimal("DescontoItem");

                var item = new ItemVendaModel
                {
                    ItemVendaID = reader.GetInt32("ItemVendaID"),
                    VendaID = reader.GetInt32("VendaID"),
                    ProdutoID = reader.GetInt32("ProdutoID"),
                    Quantidade = quantidade,
                    PrecoUnitario = precoUnitario,
                    DescontoItem = descontoItem,
                    ProdutoDescricao = reader.IsDBNull("ProdutoDescricao") ? string.Empty : reader.GetString("ProdutoDescricao")
                };

                // ✅ Subtotal será calculado automaticamente pelo model
                itens.Add(item);
            }
            return itens;
        }
        public void ExcluirPorVenda(long vendaId)
        {
            string sql = "DELETE FROM ItemVenda WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.ExecuteNonQuery();
        }
    }
}










