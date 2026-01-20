IF NOT EXISTS (SELECT 1 FROM dbo.VersaoSistema WHERE Id = 1)
BEGIN
    INSERT INTO dbo.VersaoSistema (Id, Versao, DataAtualizacao)
    VALUES (1, '1.0.0', GETDATE());
END;