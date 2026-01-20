
IF NOT EXISTS (SELECT 1 FROM sys.databases WHERE name = 'bdsiscontrol')
BEGIN
    CREATE DATABASE bdsiscontrol;
END;