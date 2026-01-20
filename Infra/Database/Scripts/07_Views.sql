/* ============================================================
   SCRIPT: 04_Views.sql
   DESCRIÇÃO: Views do sistema
   BANCO: bdsiscontrol
   ============================================================ */

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;


/* ============================================================
   VIEW: vw_produtos_estoque_baixo
   DESCRIÇÃO: Produtos com estoque baixo ou zerado
   ============================================================ */
IF OBJECT_ID('dbo.vw_produtos_estoque_baixo', 'V') IS NOT NULL
    DROP VIEW dbo.vw_produtos_estoque_baixo;


CREATE VIEW dbo.vw_produtos_estoque_baixo
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
FROM Produtos p
LEFT JOIN Fornecedor f ON p.FornecedorID = f.FornecedorID
WHERE p.Estoque <= 10;


/* ============================================================
   VIEW: vw_dashboard_financeiro
   DESCRIÇÃO: Indicadores financeiros do dashboard
   ============================================================ */
IF OBJECT_ID('dbo.vw_dashboard_financeiro', 'V') IS NOT NULL
    DROP VIEW dbo.vw_dashboard_financeiro;


CREATE VIEW dbo.vw_dashboard_financeiro
AS
SELECT
    (SELECT SUM(v.ValorTotal)
       FROM Venda v
      WHERE MONTH(v.DataVenda) = MONTH(GETDATE())
        AND YEAR(v.DataVenda) = YEAR(GETDATE())
    ) AS TotalVendasMes,

    (SELECT SUM(pp.ValorPago)
       FROM PagamentosParciais pp
      WHERE MONTH(pp.DataPagamento) = MONTH(GETDATE())
        AND YEAR(pp.DataPagamento) = YEAR(GETDATE())
    ) AS TotalRecebidoMes,

    (SELECT SUM(p.ValorParcela + p.Juros + p.Multa - p.ValorRecebido)
       FROM Parcela p
      WHERE p.Status IN ('Pendente', 'ParcialmentePago')
    ) AS TotalPendente,

    (SELECT COUNT(*)
       FROM Clientes c
      WHERE c.Status = 1
    ) AS TotalClientesAtivos,

    (SELECT COUNT(*)
       FROM dbo.vw_produtos_estoque_baixo
    ) AS ProdutosEstoqueBaixo,

    (SELECT COUNT(*)
       FROM Venda v
      WHERE CAST(v.DataVenda AS DATE) = CAST(GETDATE() AS DATE)
    ) AS VendasHoje;


/* ============================================================
   VIEW: vw_fluxo_caixa
   DESCRIÇÃO: Fluxo de caixa diário por forma de pagamento
   ============================================================ */
IF OBJECT_ID('dbo.vw_fluxo_caixa', 'V') IS NOT NULL
    DROP VIEW dbo.vw_fluxo_caixa;


CREATE VIEW dbo.vw_fluxo_caixa
AS
SELECT
    CAST(pp.DataPagamento AS DATE) AS Data,
    COALESCE(fp.NomeFormaPagamento, 'Sem Forma') AS FormaPagamento,
    COUNT(DISTINCT pp.ParcelaID) AS ParcelasRecebidas,
    COUNT(pp.PagamentoID) AS PagamentosRealizados,
    SUM(pp.ValorPago) AS TotalRecebido,
    AVG(pp.ValorPago) AS ValorMedioPagamento
FROM PagamentosParciais pp
LEFT JOIN FormaPagamento fp ON pp.FormaPgtoID = fp.FormaPgtoID
GROUP BY
    CAST(pp.DataPagamento AS DATE),
    fp.FormaPgtoID,
    fp.NomeFormaPagamento;


/* ============================================================
   VIEW: vw_parcelas_em_aberto
   DESCRIÇÃO: Parcelas pendentes ou parcialmente pagas
   ============================================================ */
IF OBJECT_ID('dbo.vw_parcelas_em_aberto', 'V') IS NOT NULL
    DROP VIEW dbo.vw_parcelas_em_aberto;


CREATE VIEW dbo.vw_parcelas_em_aberto
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
FROM Parcela p
INNER JOIN Venda v ON p.VendaID = v.VendaID
INNER JOIN Clientes c ON v.ClienteID = c.ClienteID
WHERE p.Status IN ('Pendente', 'ParcialmentePago');


/* ============================================================
   VIEW: vw_relatorio_vendas
   DESCRIÇÃO: Relatório consolidado de vendas
   ============================================================ */
IF OBJECT_ID('dbo.vw_relatorio_vendas', 'V') IS NOT NULL
    DROP VIEW dbo.vw_relatorio_vendas;


CREATE VIEW dbo.vw_relatorio_vendas
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
FROM Venda v
INNER JOIN Clientes c ON v.ClienteID = c.ClienteID
LEFT JOIN FormaPagamento fp ON v.FormaPgtoID = fp.FormaPgtoID
LEFT JOIN ItemVenda iv ON v.VendaID = iv.VendaID
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


/* ============================================================
   VIEW: vw_status_descricao
   DESCRIÇÃO: Mapeamento de status numérico para texto
   ============================================================ */
IF OBJECT_ID('dbo.vw_status_descricao', 'V') IS NOT NULL
    DROP VIEW dbo.vw_status_descricao;


CREATE VIEW dbo.vw_status_descricao
AS
SELECT 0 AS Codigo, 'Pendente' AS Descricao
UNION ALL
SELECT 1, 'ParcialmentePago'
UNION ALL
SELECT 2, 'Pago'
UNION ALL
SELECT 3, 'Atrasado'
UNION ALL
SELECT 4, 'Cancelado';

