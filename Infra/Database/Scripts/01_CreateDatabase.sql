IF NOT EXISTS (SELECT 1 FROM sys.databases WHERE name = 'bdsiscontrol')
BEGIN
    CREATE DATABASE bdsiscontrol;
END;

DECLARE @user SYSNAME = SUSER_SNAME();

IF NOT EXISTS (
    SELECT 1
    FROM sys.database_principals
    WHERE name = @user
)
BEGIN
    DECLARE @sql NVARCHAR(MAX) =
        'CREATE USER [' + @user + '] FOR LOGIN [' + @user + ']';
    EXEC sp_executesql @sql;
END;

ALTER ROLE db_owner ADD MEMBER [WR-PC\iConnect];
