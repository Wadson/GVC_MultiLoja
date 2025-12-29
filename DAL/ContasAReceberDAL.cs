using Dapper;
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
            DateTime dtIni,
            DateTime dtFim,
            string statusParcela)
        {
            var sql = new StringBuilder(@"
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
        JOIN Venda v        ON v.VendaID = p.VendaID
        JOIN Clientes c     ON c.ClienteID = v.ClienteID
        LEFT JOIN FormaPgto fp ON fp.FormaPgtoID = v.FormaPgtoID
        WHERE 1 = 1");

            var param = new DynamicParameters();

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
                    param.Add("@DataVenda", dtIni.Date);
                    break;

                case "Período da Venda":
                    sql.Append(" AND v.DataVenda >= @Ini AND v.DataVenda < @Fim ");
                    param.Add("@Ini", dtIni.Date);
                    param.Add("@Fim", dtFim.Date.AddDays(1));
                    break;

                case "Vencimento":
                    sql.Append(" AND CAST(p.DataVencimento AS DATE) = @Venc ");
                    param.Add("@Venc", dtIni.Date);
                    break;

                case "Período de Vencimento":
                    sql.Append(" AND p.DataVencimento >= @VencIni AND p.DataVencimento < @VencFim ");
                    param.Add("@VencIni", dtIni.Date);
                    param.Add("@VencFim", dtFim.Date.AddDays(1));
                    break;

                case "Status da Parcela":
                    sql.Append(" AND p.Status = @Status ");
                    param.Add("@Status", statusParcela);
                    break;
            }

            using var conn = Helpers.Conexao.Conex();
            return conn.Query<ContaAReceberDTO>(sql.ToString(), param).ToList();
        }
    }
}