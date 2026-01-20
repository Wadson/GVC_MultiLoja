

CREATE OR ALTER VIEW dbo.vw_dashboard_financeiro
AS
SELECT
    (SELECT SUM(v.ValorTotal)
       FROM dbo.Venda v
      WHERE MONTH(v.DataVenda) = MONTH(GETDATE())
        AND YEAR(v.DataVenda) = YEAR(GETDATE())
    ) AS TotalVendasMes,

    (SELECT SUM(pp.ValorPago)
       FROM dbo.PagamentosParciais pp
      WHERE MONTH(pp.DataPagamento) = MONTH(GETDATE())
        AND YEAR(pp.DataPagamento) = YEAR(GETDATE())
    ) AS TotalRecebidoMes,

    (SELECT SUM(p.ValorParcela + p.Juros + p.Multa - p.ValorRecebido)
       FROM dbo.Parcela p
      WHERE p.Status IN ('Pendente', 'ParcialmentePago')
    ) AS TotalPendente,

    (SELECT COUNT(*)
       FROM dbo.Clientes c
      WHERE c.Status = 1
    ) AS TotalClientesAtivos,

    (SELECT COUNT(*)
       FROM dbo.vw_produtos_estoque_baixo
    ) AS ProdutosEstoqueBaixo,

    (SELECT COUNT(*)
       FROM dbo.Venda v
      WHERE CAST(v.DataVenda AS DATE) = CAST(GETDATE() AS DATE)
    ) AS VendasHoje;
