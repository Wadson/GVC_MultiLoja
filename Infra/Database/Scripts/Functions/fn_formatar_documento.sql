

CREATE OR ALTER FUNCTION dbo.fn_formatar_documento
(
    @Documento NVARCHAR(20)
)
RETURNS NVARCHAR(20)
AS
BEGIN
    DECLARE @Resultado NVARCHAR(20);

    IF LEN(@Documento) = 11
    BEGIN
        SET @Resultado =
            SUBSTRING(@Documento, 1, 3) + '.' +
            SUBSTRING(@Documento, 4, 3) + '.' +
            SUBSTRING(@Documento, 7, 3) + '-' +
            SUBSTRING(@Documento, 10, 2);
    END
    ELSE IF LEN(@Documento) = 14
    BEGIN
        SET @Resultado =
            SUBSTRING(@Documento, 1, 2) + '.' +
            SUBSTRING(@Documento, 3, 3) + '.' +
            SUBSTRING(@Documento, 6, 3) + '/' +
            SUBSTRING(@Documento, 9, 4) + '-' +
            SUBSTRING(@Documento, 13, 2);
    END
    ELSE
    BEGIN
        SET @Resultado = @Documento;
    END

    RETURN @Resultado;
END;
