

CREATE OR ALTER VIEW dbo.vw_relatorio_vendas
AS
SELECT
    v.VendaID,
    v.DataVenda,
    c.Nome AS Cliente,
    c.Cpf,
    c.Telefone,
    v.ValorTotal,
    v.Desconto,
    (v.ValorTotal - v.Desconto) AS ValorLiquido,
    v.StatusVenda,
    fp.NomeFormaPagamento AS FormaPagamento,
    COUNT(iv.ItemVendaID) AS TotalItens,
    SUM(iv.Quantidade) AS QuantidadeTotal
FROM dbo.Venda v
INNER JOIN dbo.Clientes c ON v.ClienteID = c.ClienteID
LEFT JOIN dbo.FormaPagamento fp ON v.FormaPgtoID = fp.FormaPgtoID
LEFT JOIN dbo.ItemVenda iv ON v.VendaID = iv.VendaID
GROUP BY
    v.VendaID,
    v.DataVenda,
    c.Nome,
    c.Cpf,
    c.Telefone,
    v.ValorTotal,
    v.Desconto,
    v.StatusVenda,
    fp.NomeFormaPagamento;
