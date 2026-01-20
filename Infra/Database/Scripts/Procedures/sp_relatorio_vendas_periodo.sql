CREATE OR ALTER PROCEDURE dbo.sp_relatorio_vendas_periodo
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
    FROM dbo.Venda v
    INNER JOIN dbo.Clientes c ON v.ClienteID = c.ClienteID
    LEFT JOIN dbo.FormaPagamento fp ON v.FormaPgtoID = fp.FormaPgtoID
    LEFT JOIN dbo.ItemVenda iv ON v.VendaID = iv.VendaID
    LEFT JOIN dbo.Produtos p ON iv.ProdutoID = p.ProdutoID
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
