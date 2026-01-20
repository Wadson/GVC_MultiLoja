

CREATE OR ALTER VIEW dbo.vw_produtos_estoque_baixo
AS
SELECT
    p.ProdutoID,
    p.NomeProduto,
    p.Referencia,
    p.Estoque,
    p.PrecoDeVenda,
    p.Status,
    f.Nome AS Fornecedor,
    CASE 
        WHEN p.Estoque = 0 THEN 'ESGOTADO'
        WHEN p.Estoque <= 10 THEN 'BAIXO'
        ELSE 'NORMAL'
    END AS NivelEstoque
FROM dbo.Produtos p
LEFT JOIN dbo.Fornecedor f ON p.FornecedorID = f.FornecedorID
WHERE p.Estoque <= 10;
