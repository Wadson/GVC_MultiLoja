CREATE OR ALTER PROCEDURE dbo.sp_registrar_pagamento
    @ParcelaID INT,
    @ValorPago DECIMAL(18,2),
    @FormaPgtoID INT = NULL,
    @Observacao NVARCHAR(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        IF NOT EXISTS (SELECT 1 FROM dbo.Parcela WHERE ParcelaID = @ParcelaID)
        BEGIN
            RAISERROR(N'Parcela não encontrada.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END

        INSERT INTO dbo.PagamentosParciais (ParcelaID, ValorPago, FormaPgtoID, Observacao)
        VALUES (@ParcelaID, @ValorPago, @FormaPgtoID, @Observacao);

        UPDATE v
           SET v.StatusVenda = 'Finalizada'
        FROM dbo.Venda v
        WHERE v.VendaID = (
            SELECT VendaID FROM dbo.Parcela WHERE ParcelaID = @ParcelaID
        )
        AND NOT EXISTS (
            SELECT 1
            FROM dbo.Parcela p
            WHERE p.VendaID = v.VendaID
              AND p.Status <> 'Pago'
        );

        COMMIT TRANSACTION;

        SELECT N'Pagamento registrado com sucesso' AS Mensagem;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
