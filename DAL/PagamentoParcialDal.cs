using Dapper;
using GVC.Infra.Repository;
using GVC.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GVC.DAL
{
    internal class PagamentoParcialDal : RepositoryBase
    {

        public decimal SomarPagamentos(int parcelaId, SqlConnection conn, SqlTransaction tran)
        {
            using var cmd = new SqlCommand(@"  SELECT ISNULL(SUM(ValorPago), 0)
                FROM PagamentosParciais  WHERE ParcelaID = @ParcelaID ", conn, tran);

            cmd.Parameters.AddWithValue("@ParcelaID", parcelaId);

            return Convert.ToDecimal(cmd.ExecuteScalar());
        }

        public void InserirPagamentoParcial(PagamentosParcialModel pagamento)
        {
            const string sql = @"
            INSERT INTO PagamentosParciais
            (ParcelaID, ValorPago, DataPagamento, EmpresaID)
            VALUES (@ParcelaID, @ValorPago, @DataPagamento, @EmpresaID)";

            Connection.Execute(sql, new
            {
                pagamento.ParcelaID,
                pagamento.ValorPago,
                pagamento.DataPagamento,
                EmpresaID
            });
        }

        public List<PagamentosParcialModel> ObterPagamentosParciaisPorParcela(long parcelaId)
            => Connection.Query<PagamentosParcialModel>(
                @"SELECT * FROM PagamentosParciais
                  WHERE ParcelaID = @ParcelaID
                    AND EmpresaID = @EmpresaID
                  ORDER BY DataPagamento DESC",
                new { ParcelaID = parcelaId, EmpresaID }
            ).ToList();

        public List<PagamentoExtratoModel> ListarPagamentosPorParcelaCompleto(long parcelaId)
        {
            const string sql = @"
            SELECT 
                pp.DataPagamento,
                pp.ValorPago,
                fp.NomeFormaPagamento AS NomeFormaPagamento,
                ISNULL(pp.Observacao, 'Baixa parcial') AS Observacao
            FROM PagamentosParciais pp
            LEFT JOIN FormaPagamento fp ON fp.FormaPgtoID = pp.FormaPgtoID
            INNER JOIN Parcela pc ON pc.ParcelaID = pp.ParcelaID
            WHERE pp.ParcelaID = @ParcelaID
              AND pc.EmpresaID = @EmpresaID
            ORDER BY pp.DataPagamento";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.Add("@ParcelaID", SqlDbType.BigInt).Value = parcelaId;

            using var reader = cmd.ExecuteReader();
            var lista = new List<PagamentoExtratoModel>();

            while (reader.Read())
            {
                lista.Add(new PagamentoExtratoModel
                {
                    DataPagamento = reader.GetDateTime(reader.GetOrdinal("DataPagamento")),
                    ValorPago = reader.GetDecimal(reader.GetOrdinal("ValorPago")),
                    NomeFormaPagamento = reader.IsDBNull(reader.GetOrdinal("NomeFormaPagamento")) ? string.Empty : reader.GetString(reader.GetOrdinal("NomeFormaPagamento")),
                    Observacao = reader.GetString(reader.GetOrdinal("Observacao"))
                });
            }

            return lista;
        }
        public PagamentoExtratoModel? ObterPagamentoPorId(long pagamentoId)
        {
            const string sql = @"
            SELECT
                pp.DataPagamento,
                pp.ValorPago,
                fp.NomeFormaPagamento AS NomeFormaPagamento,
                pp.Observacao
            FROM PagamentosParciais pp
            LEFT JOIN FormaPagamento fp ON fp.FormaPgtoID = pp.FormaPgtoID
            WHERE pp.PagamentoID = @PagamentoID
              AND pp.EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.Add("@PagamentoID", SqlDbType.BigInt).Value = pagamentoId;

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new PagamentoExtratoModel
                {
                    DataPagamento = reader.GetDateTime(reader.GetOrdinal("DataPagamento")),
                    ValorPago = reader.GetDecimal(reader.GetOrdinal("ValorPago")),
                    NomeFormaPagamento = reader.IsDBNull(reader.GetOrdinal("NomeFormaPagamento")) ? string.Empty : reader.GetString(reader.GetOrdinal("NomeFormaPagamento")),
                    Observacao = reader.IsDBNull(reader.GetOrdinal("Observacao")) ? string.Empty : reader.GetString(reader.GetOrdinal("Observacao"))
                };
            }

            return null;
        }
        public void ExcluirPagamentosParciaisPorParcelaID(long parcelaId)
        {
            const string sql = @"
            DELETE FROM PagamentosParciais 
            WHERE ParcelaID = @ParcelaID
              AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.Add("@ParcelaID", SqlDbType.BigInt).Value = parcelaId;

            cmd.ExecuteNonQuery();
        }
        public List<PagamentoExtratoModel> ObterExtratoPorParcela(long parcelaId)
        {
            const string sql = @"
            SELECT
                pp.DataPagamento,
                pp.ValorPago,
                fp.NomeFormaPagamento AS FormaPagamento,
                pp.Observacao
            FROM PagamentosParciais pp
            LEFT JOIN FormaPagamento fp ON fp.FormaPgtoID = pp.FormaPgtoID
            INNER JOIN Parcela pc ON pc.ParcelaID = pp.ParcelaID
            WHERE pp.ParcelaID = @ParcelaID
              AND pc.EmpresaID = @EmpresaID
            ORDER BY pp.DataPagamento";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.Add("@ParcelaID", SqlDbType.BigInt).Value = parcelaId;

            using var reader = cmd.ExecuteReader();
            var lista = new List<PagamentoExtratoModel>();

            while (reader.Read())
            {
                lista.Add(new PagamentoExtratoModel
                {
                    DataPagamento = reader.GetDateTime(reader.GetOrdinal("DataPagamento")),
                    ValorPago = reader.GetDecimal(reader.GetOrdinal("ValorPago")),
                    NomeFormaPagamento = reader.IsDBNull(reader.GetOrdinal("FormaPagamento"))? string.Empty : reader.GetString(reader.GetOrdinal("FormaPagamento")),
                    Observacao = reader.IsDBNull(reader.GetOrdinal("Observacao")) ? string.Empty : reader.GetString(reader.GetOrdinal("Observacao"))
                });
            }

            return lista;
        }
        public void RegistrarPagamentoParcial(long parcelaId, decimal valorPago, DateTime dataPagamento, long? formaPgtoId = null, string? observacao = null)
        {
            const string sql = @"
            INSERT INTO PagamentosParciais
                (ParcelaID, ValorPago, DataPagamento, FormaPgtoID, Observacao, EmpresaID)
            VALUES
                (@ParcelaID, @ValorPago, @DataPagamento, @FormaPgtoID, @Observacao, @EmpresaID)";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.Add("@ParcelaID", SqlDbType.BigInt).Value = parcelaId;
            cmd.Parameters.Add("@ValorPago", SqlDbType.Decimal).Value = valorPago;
            cmd.Parameters.Add("@DataPagamento", SqlDbType.DateTime).Value = dataPagamento;
            cmd.Parameters.Add("@FormaPgtoID", SqlDbType.BigInt).Value = (object?)formaPgtoId ?? DBNull.Value;
            cmd.Parameters.Add("@Observacao", SqlDbType.NVarChar).Value = (object?)observacao ?? DBNull.Value;

            // EmpresaID é injetado automaticamente pelo RepositoryBase
            cmd.ExecuteNonQuery();
        }
    }
}
