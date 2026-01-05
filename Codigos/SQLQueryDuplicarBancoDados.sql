USE master;
GO

-- PASSO 1: Limpar
IF DB_ID('bdsiscontrol_teste') IS NOT NULL
BEGIN
    ALTER DATABASE bdsiscontrol_teste SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE bdsiscontrol_teste;
    PRINT '1. Banco de teste anterior removido.';
END

-- PASSO 2: Restaurar
PRINT '2. Restaurando bdsiscontrol_teste...';
RESTORE DATABASE bdsiscontrol_teste 
FROM DISK = 'D:\Program Files\Microsoft SQL Server\MSSQL17.SQLEXPRESS\MSSQL\DATA\bdsiscontrol_backup.bak'
WITH 
    MOVE 'bdsiscontrol_Data' TO 'D:\Program Files\Microsoft SQL Server\MSSQL17.SQLEXPRESS\MSSQL\DATA\bdsiscontrol_teste.mdf',
    MOVE 'bdsiscontrol_Log' TO 'D:\Program Files\Microsoft SQL Server\MSSQL17.SQLEXPRESS\MSSQL\DATA\bdsiscontrol_teste.ldf',
    STATS = 5,
    REPLACE;

-- PASSO 3: Verificar
PRINT '3. Verificando criação...';
IF DB_ID('bdsiscontrol_teste') IS NOT NULL
BEGIN
    PRINT '=======================================';
    PRINT '✅ BANCO CRIADO COM SUCESSO!';
    PRINT '=======================================';
    PRINT 'Nome: bdsiscontrol_teste';
    PRINT 'Local: D:\Program Files\Microsoft SQL Server\MSSQL17.SQLEXPRESS\MSSQL\DATA\';
    PRINT '=======================================';
    
    -- Listar ambos bancos
    SELECT 
        name AS [Banco],
        CASE name 
            WHEN 'bdsiscontrol' THEN 'ORIGINAL'
            WHEN 'bdsiscontrol_teste' THEN 'CÓPIA'
        END AS [Tipo],
        create_date AS [Criado em],
        state_desc AS [Status]
    FROM sys.databases 
    WHERE name IN ('bdsiscontrol', 'bdsiscontrol_teste')
    ORDER BY name;
END
ELSE
    PRINT '❌ Falha na criação do banco.';
GO