/* ===============================
   FOREIGN KEYS
   =============================== */

----------------------------------------------------------------
-- CIDADE → ESTADO
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = 'FK_Cidade_EstadoID')
ALTER TABLE dbo.Cidade
ADD CONSTRAINT FK_Cidade_EstadoID
FOREIGN KEY (EstadoID)
REFERENCES dbo.Estado (EstadoID);

----------------------------------------------------------------
-- CLIENTES → CIDADE
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = 'FK_Clientes_CidadeID')
ALTER TABLE dbo.Clientes
ADD CONSTRAINT FK_Clientes_CidadeID
FOREIGN KEY (CidadeID)
REFERENCES dbo.Cidade (CidadeID);

----------------------------------------------------------------
-- FORNECEDOR → CIDADE
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = 'FK_Fornecedor_CidadeID')
ALTER TABLE dbo.Fornecedor
ADD CONSTRAINT FK_Fornecedor_CidadeID
FOREIGN KEY (CidadeID)
REFERENCES dbo.Cidade (CidadeID);

----------------------------------------------------------------
-- ITEM VENDA → PRODUTOS
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = 'FK_ItemVenda_ProdutoID')
ALTER TABLE dbo.ItemVenda
ADD CONSTRAINT FK_ItemVenda_ProdutoID
FOREIGN KEY (ProdutoID)
REFERENCES dbo.Produtos (ProdutoID);

----------------------------------------------------------------
-- ITEM VENDA → VENDA
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = 'FK_ItemVenda_VendaID')
ALTER TABLE dbo.ItemVenda
ADD CONSTRAINT FK_ItemVenda_VendaID
FOREIGN KEY (VendaID)
REFERENCES dbo.Venda (VendaID);

----------------------------------------------------------------
-- PARCELA → VENDA
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = 'FK_Parcela_VendaID')
ALTER TABLE dbo.Parcela
ADD CONSTRAINT FK_Parcela_VendaID
FOREIGN KEY (VendaID)
REFERENCES dbo.Venda (VendaID);

----------------------------------------------------------------
-- PAGAMENTOS PARCIAIS → FORMA PAGAMENTO
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = 'FK_PagamentosParciais_FormaPgtoID')
ALTER TABLE dbo.PagamentosParciais
ADD CONSTRAINT FK_PagamentosParciais_FormaPgtoID
FOREIGN KEY (FormaPgtoID)
REFERENCES dbo.FormaPagamento (FormaPgtoID);

----------------------------------------------------------------
-- PAGAMENTOS PARCIAIS → PARCELA
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = 'FK_PagamentosParciais_ParcelaID')
ALTER TABLE dbo.PagamentosParciais
ADD CONSTRAINT FK_PagamentosParciais_ParcelaID
FOREIGN KEY (ParcelaID)
REFERENCES dbo.Parcela (ParcelaID);

----------------------------------------------------------------
-- PRODUTOS → FORNECEDOR
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = 'FK_Produtos_FornecedorID')
ALTER TABLE dbo.Produtos
ADD CONSTRAINT FK_Produtos_FornecedorID
FOREIGN KEY (FornecedorID)
REFERENCES dbo.Fornecedor (FornecedorID)
ON UPDATE CASCADE
ON DELETE SET NULL;

----------------------------------------------------------------
-- VENDA → CLIENTES
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = 'FK_Venda_ClienteID')
ALTER TABLE dbo.Venda
ADD CONSTRAINT FK_Venda_ClienteID
FOREIGN KEY (ClienteID)
REFERENCES dbo.Clientes (ClienteID);

----------------------------------------------------------------
-- VENDA → FORMA PAGAMENTO
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = 'FK_Venda_FormaPgtoID')
ALTER TABLE dbo.Venda
ADD CONSTRAINT FK_Venda_FormaPgtoID
FOREIGN KEY (FormaPgtoID)
REFERENCES dbo.FormaPagamento (FormaPgtoID);
