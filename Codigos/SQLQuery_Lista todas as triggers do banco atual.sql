-- Lista todas as triggers do banco atual
SELECT 
    t.name AS TriggerName,
    s.name AS SchemaName,
    o.name AS TableName,
    t.is_instead_of_trigger,
    t.is_disabled
FROM sys.triggers t
INNER JOIN sys.objects o ON t.parent_id = o.object_id
INNER JOIN sys.schemas s ON o.schema_id = s.schema_id
ORDER BY s.name, o.name, t.name;

-- Exibe o código (definição) de cada trigger
SELECT 
    t.name AS TriggerName,
    sm.definition AS TriggerCode
FROM sys.triggers t
INNER JOIN sys.sql_modules sm ON t.object_id = sm.object_id
ORDER BY t.name;
