/* ===============================
   DEFAULT CONSTRAINTS
   =============================== */

----------------------------------------------------------------
-- CLIENTES
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.default_constraints WHERE name = 'DF_Clientes_Status')
ALTER TABLE dbo.Clientes
ADD CONSTRAINT DF_Clientes_Status
DEFAULT (1) FOR Status;

IF NOT EXISTS (SELECT 1 FROM sys.default_constraints WHERE name = 'DF_Clientes_DataCriacao')
ALTER TABLE dbo.Clientes
ADD CONSTRAINT DF_Clientes_DataCriacao
DEFAULT (GETDATE()) FOR DataCriacao;

IF NOT EXISTS (SELECT 1 FROM sys.default_constraints WHERE name = 'DF_Clientes_IsVendedor')
ALTER TABLE dbo.Clientes
ADD CONSTRAINT DF_Clientes_IsVendedor
DEFAULT (0) FOR IsVendedor;

----------------------------------------------------------------
-- EMPRESA
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.default_constraints WHERE name = 'DF_Empresa_DataCriacao')
ALTER TABLE dbo.Empresa
ADD CONSTRAINT DF_Empresa_DataCriacao
DEFAULT (GETDATE()) FOR DataCriacao;

----------------------------------------------------------------
-- FORMA PAGAMENTO
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.default_constraints WHERE name = 'DF_FormaPagamento_Ativo')
ALTER TABLE dbo.FormaPagamento
ADD CONSTRAINT DF_FormaPagamento_Ativo
DEFAULT (1) FOR Ativo;

----------------------------------------------------------------
-- FORNECEDOR
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.default_constraints WHERE name = 'DF_Fornecedor_DataCriacao')
ALTER TABLE dbo.Fornecedor
ADD CONSTRAINT DF_Fornecedor_DataCriacao
DEFAULT (GETDATE()) FOR DataCriacao;

----------------------------------------------------------------
-- ITEM VENDA
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.default_constraints WHERE name = 'DF_ItemVenda_Subtotal')
ALTER TABLE dbo.ItemVenda
ADD CONSTRAINT DF_ItemVenda_Subtotal
DEFAULT (0) FOR Subtotal;

IF NOT EXISTS (SELECT 1 FROM sys.default_constraints WHERE name = 'DF_ItemVenda_DescontoItem')
ALTER TABLE dbo.ItemVenda
ADD CONSTRAINT DF_ItemVenda_DescontoItem
DEFAULT (0) FOR DescontoItem;

----------------------------------------------------------------
-- MOVIMENTAÇÃO ESTOQUE
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.default_constraints WHERE name = 'DF_MovimentacaoEstoque_DataMovimentacao')
ALTER TABLE dbo.MovimentacaoEstoque
ADD CONSTRAINT DF_MovimentacaoEstoque_DataMovimentacao
DEFAULT (GETDATE()) FOR DataMovimentacao;

----------------------------------------------------------------
-- PAGAMENTOS PARCIAIS
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.default_constraints WHERE name = 'DF_PagamentosParciais_DataPagamento')
ALTER TABLE dbo.PagamentosParciais
ADD CONSTRAINT DF_PagamentosParciais_DataPagamento
DEFAULT (GETDATE()) FOR DataPagamento;

----------------------------------------------------------------
-- PARCELA
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.default_constraints WHERE name = 'DF_Parcela_ValorRecebido')
ALTER TABLE dbo.Parcela
ADD CONSTRAINT DF_Parcela_ValorRecebido
DEFAULT (0) FOR ValorRecebido;

IF NOT EXISTS (SELECT 1 FROM sys.default_constraints WHERE name = 'DF_Parcela_Status')
ALTER TABLE dbo.Parcela
ADD CONSTRAINT DF_Parcela_Status
DEFAULT ('Pendente') FOR Status;

IF NOT EXISTS (SELECT 1 FROM sys.default_constraints WHERE name = 'DF_Parcela_Juros')
ALTER TABLE dbo.Parcela
ADD CONSTRAINT DF_Parcela_Juros
DEFAULT (0) FOR Juros;

IF NOT EXISTS (SELECT 1 FROM sys.default_constraints WHERE name = 'DF_Parcela_Multa')
ALTER TABLE dbo.Parcela
ADD CONSTRAINT DF_Parcela_Multa
DEFAULT (0) FOR Multa;

----------------------------------------------------------------
-- PRODUTOS
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.default_constraints WHERE name = 'DF_Produtos_DataDeEntrada')
ALTER TABLE dbo.Produtos
ADD CONSTRAINT DF_Produtos_DataDeEntrada
DEFAULT (GETDATE()) FOR DataDeEntrada;

----------------------------------------------------------------
-- USUÁRIOS
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.default_constraints WHERE name = 'DF_Usuarios_TipoUsuario')
ALTER TABLE dbo.Usuarios
ADD CONSTRAINT DF_Usuarios_TipoUsuario
DEFAULT ('Normal') FOR TipoUsuario;

IF NOT EXISTS (SELECT 1 FROM sys.default_constraints WHERE name = 'DF_Usuarios_NomeCompleto')
ALTER TABLE dbo.Usuarios
ADD CONSTRAINT DF_Usuarios_NomeCompleto
DEFAULT ('') FOR NomeCompleto;

IF NOT EXISTS (SELECT 1 FROM sys.default_constraints WHERE name = 'DF_Usuarios_DataCriacao')
ALTER TABLE dbo.Usuarios
ADD CONSTRAINT DF_Usuarios_DataCriacao
DEFAULT (GETDATE()) FOR DataCriacao;

----------------------------------------------------------------
-- VENDA
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.default_constraints WHERE name = 'DF_Venda_DataVenda')
ALTER TABLE dbo.Venda
ADD CONSTRAINT DF_Venda_DataVenda
DEFAULT (GETDATE()) FOR DataVenda;

IF NOT EXISTS (SELECT 1 FROM sys.default_constraints WHERE name = 'DF_Venda_Desconto')
ALTER TABLE dbo.Venda
ADD CONSTRAINT DF_Venda_Desconto
DEFAULT (0) FOR Desconto;

IF NOT EXISTS (SELECT 1 FROM sys.default_constraints WHERE name = 'DF_Venda_StatusVenda')
ALTER TABLE dbo.Venda
ADD CONSTRAINT DF_Venda_StatusVenda
DEFAULT ('Aberta') FOR StatusVenda;
