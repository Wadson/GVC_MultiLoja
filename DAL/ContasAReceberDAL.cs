using Dapper;
using GVC.MODEL;
using System;
using System.Collections.Generic;
using System.Text;

namespace GVC.DAL
{
    public class ContasAReceberDAL
    {
        public List<ContaAReceberDTO> ListarContasAReceber(
    string tipoPesquisa,
    string nomeCliente,
    string numeroVenda,
    DateTime dataInicial,
    DateTime dataFinal,
    string statusParcela)
        {
            var sql = new StringBuilder();
            sql.Append(@"
        SELECT 
            p.ParcelaID       AS ParcelaID,
            p.VendaID         AS VendaID,
            p.NumeroParcela   AS NumeroParcela,
            c.Nome            AS NomeCliente,
            v.DataVenda       AS DataVenda,
            p.DataVencimento  AS DataVencimento,
            p.ValorParcela    AS ValorParcela,
            p.ValorRecebido   AS ValorRecebido,
            (p.ValorParcela + p.Juros + p.Multa - p.ValorRecebido) AS Saldo,
            p.Status          AS StatusParcela,
            fp.FormaPgto      AS FormaPgto,
            v.Observacoes     AS Observacoes
        FROM Parcela p
        JOIN Venda v       ON v.VendaID = p.VendaID
        JOIN Clientes c    ON c.ClienteID = v.ClienteID
        LEFT JOIN FormaPgto fp ON fp.FormaPgtoID = v.FormaPgtoID
        WHERE 1 = 1
    ");

            var param = new DynamicParameters();

            // 🔎 filtros (exatamente como você já tinha)
            switch (tipoPesquisa)
            {
                case "Nome do Cliente":
                    sql.Append(" AND c.Nome LIKE @Nome ");
                    param.Add("@Nome", $"%{nomeCliente}%");
                    break;

                case "Número da Venda":
                    sql.Append(" AND v.VendaID = @VendaID ");
                    param.Add("@VendaID", int.Parse(numeroVenda));
                    break;

                case "Data da Venda":
                    sql.Append(" AND CAST(v.DataVenda AS DATE) = @DataVenda ");
                    param.Add("@DataVenda", dataInicial.Date);
                    break;

                case "Período da Venda":
                    sql.Append(" AND v.DataVenda >= @Ini AND v.DataVenda < @Fim ");
                    param.Add("@Ini", dataInicial.Date);
                    param.Add("@Fim", dataFinal.Date.AddDays(1));
                    break;

                case "Vencimento":
                    sql.Append(" AND CAST(p.DataVencimento AS DATE) = @Venc ");
                    param.Add("@Venc", dataInicial.Date);
                    break;

                case "Período de Vencimento":
                    sql.Append(" AND p.DataVencimento >= @VencIni AND p.DataVencimento < @VencFim ");
                    param.Add("@VencIni", dataInicial.Date);
                    param.Add("@VencFim", dataFinal.Date.AddDays(1));
                    break;

                case "Status da Parcela":
                    sql.Append(" AND p.Status = @Status ");
                    param.Add("@Status", statusParcela);
                    break;
            }

            using var conn = Helpers.Conexao.Conex();

            // ✅ AQUI entra o código que você perguntou
            var lista = conn.Query<ContaAReceberDTO>(
                sql.ToString(),
                param
            ).ToList();

            return lista;
        }

    }

}