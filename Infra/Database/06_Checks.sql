USE [bdsiscontrol];
GO

/* ===============================
   CHECK CONSTRAINTS
   =============================== */

ALTER TABLE dbo.Clientes
ADD CONSTRAINT CHK_Clientes_Cnpj_Length
CHECK (Cnpj IS NULL OR LEN(Cnpj) = 14);

ALTER TABLE dbo.Clientes
ADD CONSTRAINT CHK_Clientes_Cpf_Length
CHECK (Cpf IS NULL OR LEN(Cpf) = 11);

ALTER TABLE dbo.Clientes
ADD CONSTRAINT CHK_Clientes_Email_Format
CHECK (Email IS NULL OR Email LIKE '%_@_%._%');

ALTER TABLE dbo.ItemVenda
ADD CONSTRAINT CHK_ItemVenda_Quantidade_Positivo
CHECK (Quantidade > 0);

ALTER TABLE dbo.Parcela
ADD CONSTRAINT CK_Parcela_Status
CHECK (Status IN ('Cancelada','Atrasada','Pago','ParcialmentePago','Pendente'));

ALTER TABLE dbo.Produtos
ADD CONSTRAINT CHK_Produtos_Estoque_Positivo
CHECK (Estoque >= 0);

GO
