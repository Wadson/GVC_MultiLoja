-- SCRIPT DE CLONAGEM COM OS NOMES CORRETOS
USE master;
GO

-- 1. Backup do banco original (se já não fez)
BACKUP DATABASE bdsiscontrol
TO DISK = 'D:\Program Files\Microsoft SQL Server\MSSQL17.SQLEXPRESS\MSSQL\DATA\bdsiscontrol_backup.bak'
WITH FORMAT, STATS = 5;
GO

-- 2. Restaurar como novo banco
RESTORE DATABASE bdsiscontrol_teste
FROM DISK = 'D:\Program Files\Microsoft SQL Server\MSSQL17.SQLEXPRESS\MSSQL\DATA\bdsiscontrol_backup.bak'
WITH 
    MOVE 'bdsiscontrol_Data' TO 'D:\Program Files\Microsoft SQL Server\MSSQL17.SQLEXPRESS\MSSQL\DATA\bdsiscontrol_teste.mdf',
    MOVE 'bdsiscontrol_Log' TO 'D:\Program Files\Microsoft SQL Server\MSSQL17.SQLEXPRESS\MSSQL\DATA\bdsiscontrol_teste_log.ldf',
    STATS = 5,
    REPLACE;
GO

PRINT '=============================================';
PRINT 'BANCO DE DADOS CLONADO COM SUCESSO!';
PRINT 'Original: bdsiscontrol';
PRINT 'Clone: bdsiscontrol_teste';
PRINT '=============================================';
GO