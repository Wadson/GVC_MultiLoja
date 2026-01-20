USE [bdsiscontrol];
GO

/* ===============================
   DEFAULT CONSTRAINTS
   =============================== */

-- CLIENTES
ALTER TABLE dbo.Clientes
ADD CONSTRAINT DF_Clientes_Status
DEFAULT (1) FOR Status;

ALTER TABLE dbo.Clientes
ADD CONSTRAINT DF_Clientes_DataCriacao
DEFAULT (GETDATE()) FOR DataCriacao;

ALTER TABLE dbo.Clientes
ADD CONSTRAINT DF_Clientes_IsVendedor
DEFAULT (0) FOR IsVendedor;

-- EMPRESA
ALTER TABLE dbo.Empresa
ADD CONSTRAINT DF_Empresa_DataCriacao
DEFAULT (GETDATE()) FOR DataCriacao;

-- FORMA PAGAMENTO
ALTER TABLE dbo.FormaPagamento
ADD CONSTRAINT DF_FormaPagamento_Ativo
DEFAULT (1) FOR Ativo;

-- FORNECEDOR
ALTER TABLE dbo.Fornecedor
ADD CONSTRAINT DF_Fornecedor_DataCriacao
DEFAULT (GETDATE()) FOR DataCriacao;

-- ITEM VENDA
ALTER TABLE dbo.ItemVenda
ADD CONSTRAINT DF_ItemVenda_Subtotal
DEFAULT (0) FOR Subtotal;

ALTER TABLE dbo.ItemVenda
ADD CONSTRAINT DF_ItemVenda_DescontoItem
DEFAULT (0) FOR DescontoItem;

-- MOVIMENTAÇÃO ESTOQUE
ALTER TABLE dbo.MovimentacaoEstoque
ADD CONSTRAINT DF_MovimentacaoEstoque_DataMovimentacao
DEFAULT (GETDATE()) FOR DataMovimentacao;

-- PAGAMENTOS PARCIAIS
ALTER TABLE dbo.PagamentosParciais
ADD CONSTRAINT DF_PagamentosParciais_DataPagamento
DEFAULT (GETDATE()) FOR DataPagamento;

-- PARCELA
ALTER TABLE dbo.Parcela
ADD CONSTRAINT DF_Parcela_ValorRecebido
DEFAULT (0) FOR ValorRecebido;

ALTER TABLE dbo.Parcela
ADD CONSTRAINT DF_Parcela_Status
DEFAULT ('Pendente') FOR Status;

ALTER TABLE dbo.Parcela
ADD CONSTRAINT DF_Parcela_Juros
DEFAULT (0) FOR Juros;

ALTER TABLE dbo.Parcela
ADD CONSTRAINT DF_Parcela_Multa
DEFAULT (0) FOR Multa;

-- PRODUTOS
ALTER TABLE dbo.Produtos
ADD CONSTRAINT DF_Produtos_DataDeEntrada
DEFAULT (GETDATE()) FOR DataDeEntrada;

-- USUÁRIOS
ALTER TABLE dbo.Usuarios
ADD CONSTRAINT DF_Usuarios_TipoUsuario
DEFAULT ('Normal') FOR TipoUsuario;

ALTER TABLE dbo.Usuarios
ADD CONSTRAINT DF_Usuarios_NomeCompleto
DEFAULT ('') FOR NomeCompleto;

ALTER TABLE dbo.Usuarios
ADD CONSTRAINT DF_Usuarios_DataCriacao
DEFAULT (GETDATE()) FOR DataCriacao;

-- VENDA
ALTER TABLE dbo.Venda
ADD CONSTRAINT DF_Venda_DataVenda
DEFAULT (GETDATE()) FOR DataVenda;

ALTER TABLE dbo.Venda
ADD CONSTRAINT DF_Venda_Desconto
DEFAULT (0) FOR Desconto;

ALTER TABLE dbo.Venda
ADD CONSTRAINT DF_Venda_StatusVenda
DEFAULT ('Aberta') FOR StatusVenda;

GO
