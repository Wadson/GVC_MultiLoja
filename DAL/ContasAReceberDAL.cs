using Dapper;
using GVC.Infra.Repository;
using GVC.Model;
using GVC.Model.Enums;
using GVC.Model.Enums.GVC.Model.Enums;
using GVC.UTIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static GVC.Model.Enums.FormaPagamentoExtensions;

namespace GVC.DAL
{
    public class ContasAReceberDAL : RepositoryBase
    {
        public List<ContaAReceberDTO> ListarContasAReceber(
            TipoPesquisaContasReceber tipoPesquisa,
            string nomeCliente,
            DateTime? dataInicial,
            DateTime? dataFinal,
            List<EnumStatusParcela> statusSelecionados
        )
        {
            var sql = new StringBuilder(@"
                SELECT 
                    p.ParcelaID,
                    p.VendaID,
                    p.NumeroParcela,
                    c.Nome AS NomeCliente,
                    v.DataVenda,
                    p.DataVencimento,
                    p.ValorParcela,
                    p.ValorRecebido,
                    (
                        ISNULL(p.ValorParcela,0)
                      + ISNULL(p.Juros,0)
                      + ISNULL(p.Multa,0)
                      - ISNULL(p.ValorRecebido,0)
                    ) AS Saldo,
                    p.Status AS StatusParcela,
                    fp.NomeFormaPagamento,
                    v.Observacoes
                FROM Parcela p
                INNER JOIN Venda v 
                    ON v.VendaID = p.VendaID
                INNER JOIN Clientes c 
                    ON c.ClienteID = v.ClienteID
                LEFT JOIN FormaPagamento fp 
                    ON fp.FormaPgtoID = v.FormaPgtoID
                WHERE v.EmpresaID = @EmpresaID
            ");

            var param = new DynamicParameters();
            param.Add("@EmpresaID", EmpresaID);

            // =========================
            // 🔹 FILTRO STATUS (checkbox)
            // =========================
            if (statusSelecionados != null && statusSelecionados.Any())
            {
                sql.Append(" AND p.Status IN @Status ");
                param.Add("@Status", statusSelecionados.Select(s => s.ToString()));
            }

            // =========================
            // 🔹 FILTRO PRINCIPAL
            // =========================
            switch (tipoPesquisa)
            {
                case TipoPesquisaContasReceber.NomeCliente:
                    if (!string.IsNullOrWhiteSpace(nomeCliente))
                    {
                        sql.Append(" AND c.Nome LIKE @NomeCliente ");
                        param.Add("@NomeCliente", $"%{nomeCliente}%");
                    }
                    break;

                case TipoPesquisaContasReceber.DataVenda:
                    if (dataInicial.HasValue)
                    {
                        sql.Append(" AND CAST(v.DataVenda AS DATE) = @DataVenda ");
                        param.Add("@DataVenda", dataInicial.Value.Date);
                    }
                    break;

                case TipoPesquisaContasReceber.PeriodoVenda:
                    if (dataInicial.HasValue && dataFinal.HasValue)
                    {
                        sql.Append(" AND v.DataVenda >= @VendaIni AND v.DataVenda < @VendaFim ");
                        param.Add("@VendaIni", dataInicial.Value.Date);
                        param.Add("@VendaFim", dataFinal.Value.Date.AddDays(1));
                    }
                    break;

                case TipoPesquisaContasReceber.PeriodoVencimento:
                    if (dataInicial.HasValue && dataFinal.HasValue)
                    {
                        sql.Append(" AND p.DataVencimento >= @VencIni AND p.DataVencimento < @VencFim ");
                        param.Add("@VencIni", dataInicial.Value.Date);
                        param.Add("@VencFim", dataFinal.Value.Date.AddDays(1));
                    }
                    break;

                case TipoPesquisaContasReceber.StatusParcela:
                case TipoPesquisaContasReceber.Todos:
                default:
                    break;
            }

            sql.Append(" ORDER BY c.Nome, p.DataVencimento ");

            // 🔥 USA A CONEXÃO DO RepositoryBase
            return Connection.Query<ContaAReceberDTO>(
                sql.ToString(),
                param
            ).ToList();
        }
    }
}
