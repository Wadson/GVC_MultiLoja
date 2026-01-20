

CREATE OR ALTER FUNCTION dbo.fn_calcular_dias_atraso
(
    @DataVencimento DATE
)
RETURNS INT
AS
BEGIN
    DECLARE @Dias INT;
    SET @Dias = DATEDIFF(DAY, @DataVencimento, GETDATE());
    RETURN CASE WHEN @Dias < 0 THEN 0 ELSE @Dias END;
END;
