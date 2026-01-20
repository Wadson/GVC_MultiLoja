/* ============================================================
   SCRIPT: 03_Functions.sql
   DESCRIÇÃO: Funções auxiliares do sistema
   BANCO: bdsiscontrol
   ============================================================ */

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;


/* ============================================================
   FUNÇÃO: fn_calcular_dias_atraso
   DESCRIÇÃO: Retorna a quantidade de dias em atraso
   ============================================================ */
IF OBJECT_ID('dbo.fn_calcular_dias_atraso', 'FN') IS NOT NULL
    DROP FUNCTION dbo.fn_calcular_dias_atraso;


CREATE FUNCTION dbo.fn_calcular_dias_atraso
(
    @DataVencimento DATE
)
RETURNS INT
AS
BEGIN
    DECLARE @DiasAtraso INT;

    SET @DiasAtraso = DATEDIFF(DAY, @DataVencimento, GETDATE());

    IF @DiasAtraso < 0
        SET @DiasAtraso = 0;

    RETURN @DiasAtraso;
END;


/* ============================================================
   FUNÇÃO: fn_calcular_idade
   DESCRIÇÃO: Calcula idade com base na data de nascimento
   ============================================================ */
IF OBJECT_ID('dbo.fn_calcular_idade', 'FN') IS NOT NULL
    DROP FUNCTION dbo.fn_calcular_idade;


CREATE FUNCTION dbo.fn_calcular_idade
(
    @DataNascimento DATE
)
RETURNS INT
AS
BEGIN
    RETURN 
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
END;


/* ============================================================
   FUNÇÃO: fn_formatar_documento
   DESCRIÇÃO: Formata CPF ou CNPJ
   ============================================================ */
IF OBJECT_ID('dbo.fn_formatar_documento', 'FN') IS NOT NULL
    DROP FUNCTION dbo.fn_formatar_documento;


CREATE FUNCTION dbo.fn_formatar_documento
(
    @Documento NVARCHAR(20)
)
RETURNS NVARCHAR(20)
AS
BEGIN
    DECLARE @Resultado NVARCHAR(20);

    IF LEN(@Documento) = 11 -- CPF
    BEGIN
        SET @Resultado =
            SUBSTRING(@Documento, 1, 3) + '.' +
            SUBSTRING(@Documento, 4, 3) + '.' +
            SUBSTRING(@Documento, 7, 3) + '-' +
            SUBSTRING(@Documento, 10, 2);
    END
    ELSE IF LEN(@Documento) = 14 -- CNPJ
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

