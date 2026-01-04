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

FormaPgto = Dinheiro, Cartão de Débito, PIX, Transferência:
Venda → Concluída
Parcela → Pago
Pagamento → único, valor total.

2. FormaPgto = Cartão de Crédito, Boleto, Cheque, Crediário.

Tabela Venda: criada com StatusVenda = 'Aguardando Pagamento' até confirmação da operadora. e/ou recebimento das parcelas
Tabela ItemVenda: produtos/serviços.

Tabela Parcela:

Se parcelado: gera N parcelas com Status = "Pendente".
Se à vista no crédito: gera 1 parcela "Pendente".

Tabela PagamentosParciais:

Quando a operadora confirma, ou as parcelas são baixadas manualmente, grava pagamento.
Parcela(s) passam para "Pago" ou "Parcialmente Pago".
Venda: muda para Concluída quando todas as parcelas estão quitadas.

👉 Exemplo:

FormaPgto = Cartão de Crédito (3x)
Venda → Aguardando Pagamento
Parcelas → 3 registros Pendente
Conforme liquidação → Parcialmente Pago → Concluída.

3. Venda com Boleto

Venda: criada com StatusVenda = "Aguardando Pagamento".
ItemVenda: produtos/serviços.
Parcela:
Uma parcela com vencimento futuro (Status = "Pendente").
PagamentosParciais:
Quando o cliente paga o boleto, registra pagamento.
Parcela → "Pago".
Venda: muda para "Concluida".

👉 Exemplo:

FormaPgto = Boleto
Venda → Aguardando Pagamento
Parcela → "Pendente" até liquidação
Pagamento → único, valor total.

4. Venda com Cheque

Venda: criada com StatusVenda = 'Em Análise' ou Aguardando Pagamento (aguarda compensação).
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
             EnumStatusVenda.AguardandoPagamento => "Aguardando Pagamento",
             EnumStatusVenda.Concluida => "Concluída",
             EnumStatusVenda.Cancelada => "Cancelada", 
             EnumStatusVenda.ParcialmentePago => "Parcialmente Pago",
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
             "Aguardando Pagamento" => EnumStatusVenda.AguardandoPagamento,
             "Concluída" => EnumStatusVenda.Concluida,
             "Cancelada" => EnumStatusVenda.Cancelada,              
             "Parcialmente Pago" => EnumStatusVenda.ParcialmentePago,
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
             EnumStatusParcela.ParcialmentePago => "Parcialmente Pago",
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
             "Parcialmente Pago" => EnumStatusParcela.ParcialmentePago,
             _ => throw new Exception($"Status de parcela inválido: {status}")
         };
     }
 }



👉 Esse é o fluxo do sistema GVC:

À vista (Dinheiro, Débito, PIX, Transferência) → Venda já nasce Concluída.
Crédito, Boleto, Cheque, Crediário → Venda nasce Aguardando Pagamento ou Em Análise, 
e só vira Concluída após quitação das parcelas.
