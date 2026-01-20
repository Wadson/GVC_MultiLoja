IF NOT EXISTS (SELECT 1 FROM dbo.FormaPagamento WHERE NomeFormaPagamento = 'Dinheiro')
INSERT INTO dbo.FormaPagamento (NomeFormaPagamento, Ativo) VALUES ('Dinheiro', 1);

IF NOT EXISTS (SELECT 1 FROM dbo.FormaPagamento WHERE NomeFormaPagamento = 'Cart�o de Cr�dito')
INSERT INTO dbo.FormaPagamento (NomeFormaPagamento, Ativo) VALUES ('Cart�o de Cr�dito', 1);

IF NOT EXISTS (SELECT 1 FROM dbo.FormaPagamento WHERE NomeFormaPagamento = 'Cart�o de D�bito')
INSERT INTO dbo.FormaPagamento (NomeFormaPagamento, Ativo) VALUES ('Cart�o de D�bito', 1);

IF NOT EXISTS (SELECT 1 FROM dbo.FormaPagamento WHERE NomeFormaPagamento = 'PIX')
INSERT INTO dbo.FormaPagamento (NomeFormaPagamento, Ativo) VALUES ('PIX', 1);

IF NOT EXISTS (SELECT 1 FROM dbo.FormaPagamento WHERE NomeFormaPagamento = 'Boleto')
INSERT INTO dbo.FormaPagamento (NomeFormaPagamento, Ativo) VALUES ('Boleto', 1);

IF NOT EXISTS (SELECT 1 FROM dbo.FormaPagamento WHERE NomeFormaPagamento = 'Transfer�ncia')
INSERT INTO dbo.FormaPagamento (NomeFormaPagamento, Ativo) VALUES ('Transfer�ncia', 1);

IF NOT EXISTS (SELECT 1 FROM dbo.FormaPagamento WHERE NomeFormaPagamento = 'Cheque')
INSERT INTO dbo.FormaPagamento (NomeFormaPagamento, Ativo) VALUES ('Cheque', 1);

IF NOT EXISTS (SELECT 1 FROM dbo.FormaPagamento WHERE NomeFormaPagamento = 'Credi�rio')
INSERT INTO dbo.FormaPagamento (NomeFormaPagamento, Ativo) VALUES ('Credi�rio', 1);