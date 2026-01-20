/* ===============================
   CHECK CONSTRAINTS
   =============================== */

----------------------------------------------------------------
-- CLIENTES
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.check_constraints WHERE name = 'CHK_Clientes_Cnpj_Length')
ALTER TABLE dbo.Clientes
ADD CONSTRAINT CHK_Clientes_Cnpj_Length
CHECK (Cnpj IS NULL OR LEN(Cnpj) = 14);

IF NOT EXISTS (SELECT 1 FROM sys.check_constraints WHERE name = 'CHK_Clientes_Cpf_Length')
ALTER TABLE dbo.Clientes
ADD CONSTRAINT CHK_Clientes_Cpf_Length
CHECK (Cpf IS NULL OR LEN(Cpf) = 11);

IF NOT EXISTS (SELECT 1 FROM sys.check_constraints WHERE name = 'CHK_Clientes_Email_Format')
ALTER TABLE dbo.Clientes
ADD CONSTRAINT CHK_Clientes_Email_Format
CHECK (Email IS NULL OR Email LIKE '%_@_%._%');

----------------------------------------------------------------
-- ITEM VENDA
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.check_constraints WHERE name = 'CHK_ItemVenda_Quantidade_Positivo')
ALTER TABLE dbo.ItemVenda
ADD CONSTRAINT CHK_ItemVenda_Quantidade_Positivo
CHECK (Quantidade > 0);

----------------------------------------------------------------
-- PARCELA
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.check_constraints WHERE name = 'CK_Parcela_Status')
ALTER TABLE dbo.Parcela
ADD CONSTRAINT CK_Parcela_Status
CHECK (Status IN ('Cancelada','Atrasada','Pago','ParcialmentePago','Pendente'));

----------------------------------------------------------------
-- PRODUTOS
----------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM sys.check_constraints WHERE name = 'CHK_Produtos_Estoque_Positivo')
ALTER TABLE dbo.Produtos
ADD CONSTRAINT CHK_Produtos_Estoque_Positivo
CHECK (Estoque >= 0);
