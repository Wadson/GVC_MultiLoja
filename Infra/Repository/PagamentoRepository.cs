using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using GVC.Model;
using Microsoft.Data.SqlClient;

namespace GVC.Infra.Repository
{
    public class PagamentoRepository : RepositoryBase
    {
        public PagamentoRepository() : base() { }
        public PagamentoRepository(SqlConnection conn) : base(conn) { }

        public List<PagamentoExtratoModel> ListarPagamentosPorParcelasLote(
            List<long> parcelasIds,
            DateTime dataPagamento,
            string? observacaoPrefixo = "Baixa total em lote")
        {
            if (parcelasIds == null || parcelasIds.Count == 0)
                return new List<PagamentoExtratoModel>();

            var ids = parcelasIds.Select(x => (int)x).ToList();

            // ⚠️ Ajuste nomes se sua tabela/colunas forem diferentes
                    var sql = @"
        SELECT
            pp.DataPagamento,
            pp.ValorPago,
            fp.NomeFormaPagamento,
            pp.Observacao
        FROM PagamentosParciais pp
        LEFT JOIN FormaPagamento fp ON fp.FormaPgtoID = pp.FormaPgtoID
        WHERE pp.EmpresaID = @EmpresaID
          AND pp.ParcelaID IN @Ids
          AND CAST(pp.DataPagamento AS date) = @Data
          AND (@ObsPrefixo IS NULL OR pp.Observacao LIKE @ObsPrefixo + '%')
        ORDER BY pp.DataPagamento, pp.ParcelaID;";

            // ✅ Usa a Connection do RepositoryBase + EmpresaID centralizado
            return Connection.Query<PagamentoExtratoModel>(sql, new
            {
                EmpresaID,
                Ids = ids,
                Data = dataPagamento.Date,
                ObsPrefixo = observacaoPrefixo
            }).ToList();
        }
    }
}
