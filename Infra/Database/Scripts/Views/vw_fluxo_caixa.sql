

CREATE OR ALTER VIEW dbo.vw_fluxo_caixa
AS
SELECT
    CAST(pp.DataPagamento AS DATE) AS Data,
    COALESCE(fp.NomeFormaPagamento, 'Sem Forma') AS FormaPagamento,
    COUNT(DISTINCT pp.ParcelaID) AS ParcelasRecebidas,
    COUNT(pp.PagamentoID) AS PagamentosRealizados,
    SUM(pp.ValorPago) AS TotalRecebido,
    AVG(pp.ValorPago) AS ValorMedioPagamento
FROM dbo.PagamentosParciais pp
LEFT JOIN dbo.FormaPagamento fp ON pp.FormaPgtoID = fp.FormaPgtoID
GROUP BY
    CAST(pp.DataPagamento AS DATE),
    fp.FormaPgtoID,
    fp.NomeFormaPagamento;
