

CREATE OR ALTER VIEW dbo.vw_parcelas_em_aberto
AS
SELECT
    p.ParcelaID,
    p.NumeroParcela,
    p.DataVencimento,
    DATEDIFF(DAY, GETDATE(), p.DataVencimento) AS DiasParaVencer,
    p.ValorParcela,
    p.ValorRecebido,
    (p.ValorParcela + p.Juros + p.Multa - p.ValorRecebido) AS ValorPendente,
    p.Status,
    v.VendaID,
    c.Nome AS Cliente
FROM dbo.Parcela p
INNER JOIN dbo.Venda v ON p.VendaID = v.VendaID
INNER JOIN dbo.Clientes c ON v.ClienteID = c.ClienteID
WHERE p.Status IN ('Pendente', 'ParcialmentePago');
