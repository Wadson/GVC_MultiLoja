/* ============================================================
   SCRIPT: 05_Procedures.sql
   DESCRIÇÃO: Stored Procedures do sistema
   BANCO: bdsiscontrol
   ============================================================ */

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
GO

/* ============================================================
   PROCEDURE: sp_backup_diario
   DESCRIÇÃO: Backup diário automático do banco
   ============================================================ */
IF OBJECT_ID('dbo.sp_backup_diario', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_backup_diario;
GO

CREATE PROCEDURE dbo.sp_backup_diario
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CaminhoBackup NVARCHAR(500);
    DECLARE @NomeArquivo NVARCHAR(500);

    SET @CaminhoBackup = 'C:\BackupSQL\';
    SET @NomeArquivo = @CaminhoBackup + 'bdsiscontrol_' +
                       CONVERT(NVARCHAR(8), GETDATE(), 112) + '_' +
                       REPLACE(CONVERT(NVARCHAR(8), GETDATE(), 108), ':', '') +
                       '.bak';

    -- Criar diretório se não existir
    EXEC xp_create_subdir @CaminhoBackup;

    -- Executar backup
    BACKUP DATABASE bdsiscontrol
    TO DISK = @NomeArquivo
    WITH INIT, STATS = 10;

    PRINT 'Backup realizado com sucesso: ' + @NomeArquivo;
END;
GO

/* ============================================================
   PROCEDURE: sp_gerar_parcelas
   DESCRIÇÃO: Geração automática de parcelas
   ============================================================ */
IF OBJECT_ID('dbo.sp_gerar_parcelas', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_gerar_parcelas;
GO

CREATE PROCEDURE dbo.sp_gerar_parcelas
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

        -- Obter valor total da venda
        SELECT @ValorTotal = ValorTotal
        FROM Venda
        WHERE VendaID = @VendaID;

        IF @ValorTotal IS NULL
        BEGIN
            RAISERROR('Venda não encontrada.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Calcular valor da parcela
        SET @ValorParcela = @ValorTotal / @NumeroParcelas;

        -- Gerar parcelas
        WHILE @Contador <= @NumeroParcelas
        BEGIN
            INSERT INTO Parcela (VendaID, NumeroParcela, DataVencimento, ValorParcela)
            VALUES (
                @VendaID,
                @Contador,
                DATEADD(MONTH, @Contador - 1, @DataPrimeiroVencimento),
                @ValorParcela
            );

            SET @Contador += 1;
        END

        -- Atualizar forma de pagamento da venda
        IF @FormaPgtoID IS NOT NULL
        BEGIN
            UPDATE Venda
               SET FormaPgtoID = @FormaPgtoID
             WHERE VendaID = @VendaID;
        END

        COMMIT TRANSACTION;

        SELECT 'Parcelas geradas com sucesso' AS Mensagem;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

/* ============================================================
   PROCEDURE: sp_registrar_pagamento
   DESCRIÇÃO: Registro de pagamentos (parcial ou total)
   ============================================================ */
IF OBJECT_ID('dbo.sp_registrar_pagamento', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_registrar_pagamento;
GO

CREATE PROCEDURE dbo.sp_registrar_pagamento
    @ParcelaID INT,
    @ValorPago DECIMAL(18,2),
    @FormaPgtoID INT = NULL,
    @Observacao NVARCHAR(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Verificar existência da parcela
        IF NOT EXISTS (SELECT 1 FROM Parcela WHERE ParcelaID = @ParcelaID)
        BEGIN
            RAISERROR('Parcela não encontrada.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Registrar pagamento
        INSERT INTO PagamentosParciais (ParcelaID, ValorPago, FormaPgtoID, Observacao)
        VALUES (@ParcelaID, @ValorPago, @FormaPgtoID, @Observacao);

        -- Finalizar venda se todas as parcelas estiverem pagas
        UPDATE v
           SET v.StatusVenda = 'Finalizada'
        FROM Venda v
        WHERE v.VendaID = (
            SELECT VendaID FROM Parcela WHERE ParcelaID = @ParcelaID
        )
        AND NOT EXISTS (
            SELECT 1
            FROM Parcela p
            WHERE p.VendaID = v.VendaID
              AND p.Status <> 'Pago'
        );

        COMMIT TRANSACTION;

        SELECT 'Pagamento registrado com sucesso' AS Mensagem;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

/* ============================================================
   PROCEDURE: sp_registrar_venda
   DESCRIÇÃO: Registro de venda com itens via JSON
   ============================================================ */
IF OBJECT_ID('dbo.sp_registrar_venda', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_registrar_venda;
GO

CREATE PROCEDURE dbo.sp_registrar_venda
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

        -- Calcular total da venda
        SELECT @ValorTotal = SUM(
            CAST(JSON_VALUE(item.value, '$.Quantidade') AS INT) *
            CAST(JSON_VALUE(item.value, '$.PrecoUnitario') AS DECIMAL(18,2))
        )
        FROM OPENJSON(@Itens) AS item;

        -- Inserir venda
        INSERT INTO Venda (ClienteID, FormaPgtoID, ValorTotal, Observacoes)
        VALUES (@ClienteID, @FormaPgtoID, @ValorTotal, @Observacoes);

        SET @VendaID = SCOPE_IDENTITY();

        -- Inserir itens
        INSERT INTO ItemVenda (VendaID, ProdutoID, Quantidade, PrecoUnitario)
        SELECT
            @VendaID,
            CAST(JSON_VALUE(item.value, '$.ProdutoID') AS INT),
            CAST(JSON_VALUE(item.value, '$.Quantidade') AS INT),
            CAST(JSON_VALUE(item.value, '$.PrecoUnitario') AS DECIMAL(18,2))
        FROM OPENJSON(@Itens) AS item;

        COMMIT TRANSACTION;

        SELECT @VendaID AS VendaID, 'Venda registrada com sucesso' AS Mensagem;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

/* ============================================================
   PROCEDURE: sp_relatorio_vendas_periodo
   DESCRIÇÃO: Relatório de vendas por período
   ============================================================ */
IF OBJECT_ID('dbo.sp_relatorio_vendas_periodo', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_relatorio_vendas_periodo;
GO

CREATE PROCEDURE dbo.sp_relatorio_vendas_periodo
    @DataInicio DATE,
    @DataFim DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        v.DataVenda,
        c.Nome AS Cliente,
        fp.NomeFormaPagamento AS FormaPagamento,
        v.ValorTotal,
        v.Desconto,
        (v.ValorTotal - v.Desconto) AS ValorLiquido,
        v.StatusVenda,
        COUNT(iv.ItemVendaID) AS QuantidadeItens,
        STRING_AGG(p.NomeProduto, ', ') WITHIN GROUP (ORDER BY p.NomeProduto) AS Produtos
    FROM Venda v
    INNER JOIN Clientes c ON v.ClienteID = c.ClienteID
    LEFT JOIN FormaPagamento fp ON v.FormaPgtoID = fp.FormaPgtoID
    LEFT JOIN ItemVenda iv ON v.VendaID = iv.VendaID
    LEFT JOIN Produtos p ON iv.ProdutoID = p.ProdutoID
    WHERE CAST(v.DataVenda AS DATE) BETWEEN @DataInicio AND @DataFim
    GROUP BY
        v.DataVenda,
        c.Nome,
        fp.NomeFormaPagamento,
        v.ValorTotal,
        v.Desconto,
        v.StatusVenda
    ORDER BY v.DataVenda DESC;
END;
GO
