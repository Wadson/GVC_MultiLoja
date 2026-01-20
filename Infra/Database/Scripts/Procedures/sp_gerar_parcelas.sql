CREATE OR ALTER PROCEDUREE dbo.sp_gerar_parcelas
    @VendaID INT,
    @NumeroParcelas INT,
    @DataPrimeiroVencimento DATE,
    @FormaPgtoID INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @ValorTotal DECIMAL(18,2);
        DECLARE @ValorParcela DECIMAL(18,2);
        DECLARE @Contador INT = 1;

        SELECT @ValorTotal = ValorTotal
        FROM dbo.Venda
        WHERE VendaID = @VendaID;

        IF @ValorTotal IS NULL
        BEGIN
            RAISERROR(N'Venda não encontrada.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END

        SET @ValorParcela = @ValorTotal / @NumeroParcelas;

        WHILE @Contador <= @NumeroParcelas
        BEGIN
            INSERT INTO dbo.Parcela (VendaID, NumeroParcela, DataVencimento, ValorParcela)
            VALUES (
                @VendaID,
                @Contador,
                DATEADD(MONTH, @Contador - 1, @DataPrimeiroVencimento),
                @ValorParcela
            );

            SET @Contador += 1;
        END

        IF @FormaPgtoID IS NOT NULL
        BEGIN
            UPDATE dbo.Venda
               SET FormaPgtoID = @FormaPgtoID
             WHERE VendaID = @VendaID;
        END

        COMMIT TRANSACTION;

        SELECT N'Parcelas geradas com sucesso' AS Mensagem;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
