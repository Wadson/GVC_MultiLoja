USE [bdsiscontrol];
GO

/* ===============================
   FOREIGN KEYS
   =============================== */

ALTER TABLE dbo.Cidade
ADD CONSTRAINT FK_Cidade_EstadoID
FOREIGN KEY (EstadoID)
REFERENCES dbo.Estado (EstadoID);

ALTER TABLE dbo.Clientes
ADD CONSTRAINT FK_Clientes_CidadeID
FOREIGN KEY (CidadeID)
REFERENCES dbo.Cidade (CidadeID);

ALTER TABLE dbo.Fornecedor
ADD CONSTRAINT FK_Fornecedor_CidadeID
FOREIGN KEY (CidadeID)
REFERENCES dbo.Cidade (CidadeID);

ALTER TABLE dbo.ItemVenda
ADD CONSTRAINT FK_ItemVenda_ProdutoID
FOREIGN KEY (ProdutoID)
REFERENCES dbo.Produtos (ProdutoID);

ALTER TABLE dbo.ItemVenda
ADD CONSTRAINT FK_ItemVenda_VendaID
FOREIGN KEY (VendaID)
REFERENCES dbo.Venda (VendaID);

ALTER TABLE dbo.Parcela
ADD CONSTRAINT FK_Parcela_VendaID
FOREIGN KEY (VendaID)
REFERENCES dbo.Venda (VendaID);

ALTER TABLE dbo.PagamentosParciais
ADD CONSTRAINT FK_PagamentosParciais_FormaPgtoID
FOREIGN KEY (FormaPgtoID)
REFERENCES dbo.FormaPagamento (FormaPgtoID);

ALTER TABLE dbo.PagamentosParciais
ADD CONSTRAINT FK_PagamentosParciais_ParcelaID
FOREIGN KEY (ParcelaID)
REFERENCES dbo.Parcela (ParcelaID);

ALTER TABLE dbo.Produtos
ADD CONSTRAINT FK_Produtos_FornecedorID
FOREIGN KEY (FornecedorID)
REFERENCES dbo.Fornecedor (FornecedorID)
ON UPDATE CASCADE
ON DELETE SET NULL;

ALTER TABLE dbo.Venda
ADD CONSTRAINT FK_Venda_ClienteID
FOREIGN KEY (ClienteID)
REFERENCES dbo.Clientes (ClienteID);

ALTER TABLE dbo.Venda
ADD CONSTRAINT FK_Venda_FormaPgtoID
FOREIGN KEY (FormaPgtoID)
REFERENCES dbo.FormaPagamento (FormaPgtoID);

GO
