

CREATE OR ALTER FUNCTION dbo.fn_calcular_idade
(
    @DataNascimento DATE
)
RETURNS INT
AS
BEGIN
    DECLARE @Idade INT;

    SET @Idade =
        DATEDIFF(YEAR, @DataNascimento, GETDATE()) -
        CASE
            WHEN DATEADD(
                    YEAR,
                    DATEDIFF(YEAR, @DataNascimento, GETDATE()),
                    @DataNascimento
                 ) > GETDATE()
            THEN 1
            ELSE 0
        END;

    RETURN @Idade;
END;
