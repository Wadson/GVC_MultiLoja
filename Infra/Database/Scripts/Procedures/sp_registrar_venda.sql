CREATE OR ALTER PROCEDURE dbo.sp_registrar_venda
    @ClienteID INT,
    @FormaPgtoID INT = NULL,
    @Observacoes NVARCHAR(MAX) = NULL,
    @Itens NVARCHAR(MAX) -- JSON
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @ValorTotal DECIMAL(18,2) = 0;
        DECLARE @VendaID INT;

        SELECT @ValorTotal = SUM(
            CAST(JSON_VALUE(item.value, '$.Quantidade') AS INT) *
            CAST(JSON_VALUE(item.value, '$.PrecoUnitario') AS DECIMAL(18,2))
        )
        FROM OPENJSON(@Itens) AS item;

        INSERT INTO dbo.Venda (ClienteID, FormaPgtoID, ValorTotal, Observacoes)
        VALUES (@ClienteID, @FormaPgtoID, @ValorTotal, @Observacoes);

        SET @VendaID = SCOPE_IDENTITY();

        INSERT INTO dbo.ItemVenda (VendaID, ProdutoID, Quantidade, PrecoUnitario)
        SELECT
            @VendaID,
            CAST(JSON_VALUE(item.value, '$.ProdutoID') AS INT),
            CAST(JSON_VALUE(item.value, '$.Quantidade') AS INT),
            CAST(JSON_VALUE(item.value, '$.PrecoUnitario') AS DECIMAL(18,2))
        FROM OPENJSON(@Itens) AS item;

        COMMIT TRANSACTION;

        SELECT @VendaID AS VendaID, N'Venda registrada com sucesso' AS Mensagem;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
