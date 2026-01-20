CREATE OR ALTER PROCEDURE dbo.sp_backup_diario
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CaminhoBackup NVARCHAR(500) = N'C:\BackupSQL\';
    DECLARE @NomeArquivo NVARCHAR(500);

    SET @NomeArquivo = @CaminhoBackup + N'bdsiscontrol_' +
                       CONVERT(NVARCHAR(8), GETDATE(), 112) + N'_' +
                       REPLACE(CONVERT(NVARCHAR(8), GETDATE(), 108), ':', '') +
                       N'.bak';

    -- Criar diretório se não existir
    EXEC xp_create_subdir @CaminhoBackup;

    -- Executar backup
    BACKUP DATABASE bdsiscontrol
    TO DISK = @NomeArquivo
    WITH INIT, STATS = 10;

    PRINT N'Backup realizado com sucesso: ' + @NomeArquivo;
END;