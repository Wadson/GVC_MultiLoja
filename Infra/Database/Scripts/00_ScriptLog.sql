IF NOT EXISTS (
    SELECT 1
    FROM sys.tables
    WHERE name = '__DatabaseScriptLog'
)
BEGIN
    CREATE TABLE __DatabaseScriptLog
    (
        ScriptName NVARCHAR(255) NOT NULL PRIMARY KEY,
        ExecutedAt DATETIME2 NOT NULL DEFAULT (SYSDATETIME())
    );
END;
