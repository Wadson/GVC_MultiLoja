

CREATE OR ALTER VIEW dbo.vw_status_descricao
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
