using Dapper;
using GVC.Model;
using GVC.Model.Enums.GVC.Model.Enums;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;

namespace GVC.Infra.Repository
{
    public class ParcelaRepository : RepositoryBase
    {
        public void InsertParcela(ParcelaModel parcela)
        {
            const string sql = @"
                INSERT INTO Parcela (
                    VendaID, NumeroParcela, DataVencimento, ValorParcela, ValorRecebido,
                    Status, DataPagamento, Juros, Multa, Observacao, EmpresaID
                )
                VALUES (
                    @VendaID, @NumeroParcela, @DataVencimento, @ValorParcela, @ValorRecebido,
                    @Status, @DataPagamento, @Juros, @Multa, @Observacao, @EmpresaID
                )";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@VendaID", parcela.VendaID);
            cmd.Parameters.AddWithValue("@NumeroParcela", parcela.NumeroParcela);
            cmd.Parameters.AddWithValue("@DataVencimento", parcela.DataVencimento);
            cmd.Parameters.AddWithValue("@ValorParcela", parcela.ValorParcela);
            cmd.Parameters.AddWithValue("@ValorRecebido", parcela.ValorRecebido ?? 0m);
            cmd.Parameters.AddWithValue("@Status", parcela.Status);
            cmd.Parameters.AddWithValue("@DataPagamento", (object?)parcela.DataPagamento ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Juros", parcela.Juros ?? 0m);
            cmd.Parameters.AddWithValue("@Multa", parcela.Multa ?? 0m);
            cmd.Parameters.AddWithValue("@Observacao", (object?)parcela.Observacao ?? DBNull.Value);

            cmd.ExecuteNonQuery();
        }
        public ClienteModel BuscarPorId(int clienteId)
        {
            const string sql = @"
            SELECT ClienteID, Nome
            FROM Clientes
            WHERE ClienteID = @ClienteID
              AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@ClienteID", clienteId);

            using var dr = cmd.ExecuteReader();
            if (!dr.Read())
                return null;

            return new ClienteModel
            {
                ClienteID = dr.GetInt32(0),
                Nome = dr.GetString(1)
            };
        }
        public int AtualizarParcelasAtrasadas()
        {
            const string sql = @"
            UPDATE Parcela
            SET Status = 'Atrasada'
            WHERE EmpresaID = @EmpresaID
              AND DataVencimento < CAST(GETDATE() AS DATE)
              AND Status NOT IN ('Paga','ParcialmentePaga','Cancelada','Atrasada')";

            using var cmd = CreateCommand(sql);
            return cmd.ExecuteNonQuery();
        }
        public void InsertParcelas(List<ParcelaModel> parcelas)
        {
            if (parcelas == null || parcelas.Count == 0)
                return;

            foreach (var parcela in parcelas)
                InsertParcela(parcela);
        }

        public void UpdateParcela(ParcelaModel parcela)
        {
            const string sql = @"
                UPDATE Parcela SET
                    DataVencimento = @DataVencimento,
                    ValorParcela   = @ValorParcela,
                    ValorRecebido  = @ValorRecebido,
                    Status         = @Status,
                    DataPagamento  = @DataPagamento,
                    Juros          = @Juros,
                    Multa          = @Multa,
                    Observacao     = @Observacao
                WHERE ParcelaID = @ParcelaID
                  AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@ParcelaID", parcela.ParcelaID);
            cmd.Parameters.AddWithValue("@DataVencimento", parcela.DataVencimento);
            cmd.Parameters.AddWithValue("@ValorParcela", parcela.ValorParcela);
            cmd.Parameters.AddWithValue("@ValorRecebido", parcela.ValorRecebido ?? 0m);
            cmd.Parameters.AddWithValue("@Status", parcela.Status);
            cmd.Parameters.AddWithValue("@DataPagamento", (object?)parcela.DataPagamento ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Juros", parcela.Juros ?? 0m);
            cmd.Parameters.AddWithValue("@Multa", parcela.Multa ?? 0m);
            cmd.Parameters.AddWithValue("@Observacao", (object?)parcela.Observacao ?? DBNull.Value);

            cmd.ExecuteNonQuery();
        }
        public void BaixarParcelasEmLote(
    List<long> parcelasIds,
    DateTime dataPagamento,
    long formaPgtoId,
    string? observacao = null)
        {
            if (parcelasIds == null || parcelasIds.Count == 0)
                throw new Exception("Nenhuma parcela selecionada.");

            string obsFinal = string.IsNullOrWhiteSpace(observacao)
                ? "Baixa total em lote"
                : $"Baixa total em lote – {observacao.Trim()}";

            using var conn = Connection;
            conn.Open();
            using var transaction = conn.BeginTransaction();

            try
            {
                const string sqlHistorico = @"
                                INSERT INTO PagamentosParciais
                                    (ParcelaID, DataPagamento, FormaPgtoID, ValorPago, Observacao)
                                SELECT
                                    ParcelaID,
                                    @DataPagamento,
                                    @FormaPgtoID,
                                    (ValorParcela
                                        + ISNULL(Juros, 0)
                                        + ISNULL(Multa, 0)
                                        - ISNULL(ValorRecebido, 0)),
                                    @Observacao
                                FROM Parcela
                                WHERE ParcelaID = @ParcelaID";

                                                const string sqlBaixa = @"
                                UPDATE Parcela
                                SET ValorRecebido =
                                        ValorParcela
                                        + ISNULL(Juros, 0)
                                        + ISNULL(Multa, 0),
                                    DataPagamento = @DataPagamento
                                WHERE ParcelaID = @ParcelaID";

                foreach (var parcelaId in parcelasIds)
                {
                    // 1️⃣ HISTÓRICO (antes da baixa)
                    conn.Execute(sqlHistorico, new
                    {
                        ParcelaID = parcelaId,
                        DataPagamento = dataPagamento,
                        FormaPgtoID = formaPgtoId,
                        Observacao = obsFinal
                    }, transaction);

                    // 2️⃣ ATUALIZA PARCELA
                    conn.Execute(sqlBaixa, new
                    {
                        ParcelaID = parcelaId,
                        DataPagamento = dataPagamento
                    }, transaction);
                }

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public void BaixarParcela(long parcelaId, decimal valorPago, DateTime dataPagamento)
        {
            const string sql = @"
                UPDATE Parcela
                   SET ValorRecebido = ValorRecebido + @ValorPago,
                       DataPagamento = @DataPagamento
                 WHERE ParcelaID = @ParcelaID
                   AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@ParcelaID", parcelaId);
            cmd.Parameters.AddWithValue("@ValorPago", valorPago);
            cmd.Parameters.AddWithValue("@DataPagamento", dataPagamento);

            cmd.ExecuteNonQuery();
        }

        public ParcelaModel? BuscarPorId(decimal parcelaId)
        {
            const string sql = @"
                SELECT *
                FROM Parcela
                WHERE ParcelaID = @Id
                  AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@Id", parcelaId);

            using var dr = cmd.ExecuteReader();
            if (!dr.Read()) return null;

            return Mapear(dr);
        }

        public List<ParcelaModel> GetParcelas(long vendaId)
        {
            const string sql = @"
                SELECT *
                FROM Parcela
                WHERE VendaID = @VendaID
                  AND EmpresaID = @EmpresaID
                ORDER BY NumeroParcela";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);

            using var dr = cmd.ExecuteReader();
            var lista = new List<ParcelaModel>();

            while (dr.Read())
                lista.Add(Mapear(dr));

            return lista;
        }

        public DataTable ListarParcelas()
        {
            AtualizarParcelasAtrasadas();

            const string sql = @"
                SELECT *
                FROM Parcela
                WHERE EmpresaID = @EmpresaID
                ORDER BY DataVencimento";

            using var cmd = CreateCommand(sql);
            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        public void Excluir(ParcelaModel parcela)
        {
            const string sql = @"
                DELETE FROM Parcela
                WHERE ParcelaID = @Id
                  AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@Id", parcela.ParcelaID);
            cmd.ExecuteNonQuery();
        }

        public void CancelarParcelasPorVenda(long vendaId)
        {
            const string sql = @"
                UPDATE Parcela
                   SET Status = 'CANCELADA',
                       ValorRecebido = 0,
                       DataPagamento = NULL
                 WHERE VendaID = @VendaID
                   AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.ExecuteNonQuery();
        }

        public bool ExistePagamentoPorVenda(long vendaId)
        {
            const string sql = @"
                SELECT COUNT(1)
                FROM Parcela p
                LEFT JOIN PagamentosParciais pp ON pp.ParcelaID = p.ParcelaID
                WHERE p.VendaID = @VendaID
                  AND p.EmpresaID = @EmpresaID
                  AND (p.ValorRecebido > 0 OR pp.PagamentoID IS NOT NULL)";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        public void ExcluirPorVenda(long vendaId)
        {
            const string sql = @"
                DELETE FROM Parcela
                WHERE VendaID = @VendaID
                  AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.ExecuteNonQuery();
        }

        // =========================
        // MAP
        // =========================
        private static ParcelaModel Mapear(SqlDataReader r)
        {
            return new ParcelaModel
            {
                ParcelaID = (int)Convert.ToInt64(r["ParcelaID"]),
                VendaID = (int)Convert.ToInt64(r["VendaID"]),
                NumeroParcela = Convert.ToInt32(r["NumeroParcela"]),
                DataVencimento = Convert.ToDateTime(r["DataVencimento"]),
                ValorParcela = Convert.ToDecimal(r["ValorParcela"]),
                ValorRecebido = r["ValorRecebido"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(r["ValorRecebido"]),
                Status = (EnumStatusParcela)Enum.Parse(typeof(EnumStatusParcela), r["Status"].ToString()),
                DataPagamento = r["DataPagamento"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["DataPagamento"]),
                Juros = r["Juros"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(r["Juros"]),
                Multa = r["Multa"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(r["Multa"]),
                Observacao = r["Observacao"] == DBNull.Value ? null : r["Observacao"].ToString()
            };

        }
        private IDbTransaction? Transaction;

        public void EstornarPagamento(
             long parcelaId,
             decimal valorEstorno,
             DateTime dataEstorno,
             string motivo)
        {
            const string sqlHistorico = @"
                                INSERT INTO PagamentosParciais
                                    (ParcelaID, DataPagamento, ValorPago, Observacao)
                                VALUES
                                    (@ParcelaID, @DataPagamento, -@ValorEstorno, @Motivo);
                                ";

                                            const string sqlUpdateParcela = @"
                                UPDATE Parcela
                                SET
                                    ValorRecebido = ISNULL(ValorRecebido, 0) - @ValorEstorno,
                                    Status = CASE
                                        WHEN (ISNULL(ValorRecebido, 0) - @ValorEstorno) <= 0
                                            THEN @StatusAberta
                                        ELSE @StatusParcial
                                    END,
                                    DataPagamento = CASE
                                        WHEN (ISNULL(ValorRecebido, 0) - @ValorEstorno) <= 0
                                            THEN NULL
                                        ELSE DataPagamento
                                    END
                                WHERE ParcelaID = @ParcelaID;";

            // 1️⃣ Histórico de estorno
            Connection.Execute(sqlHistorico, new
            {
                ParcelaID = parcelaId,
                DataPagamento = dataEstorno,
                ValorEstorno = valorEstorno,
                Motivo = motivo
            }, Transaction);

            // 2️⃣ Atualiza parcela
            Connection.Execute(sqlUpdateParcela, new
            {
                ParcelaID = parcelaId,
                ValorEstorno = valorEstorno,
                StatusAberta = EnumStatusParcela.Pendente,
                StatusParcial = EnumStatusParcela.ParcialmentePago
            }, Transaction);
        }

    }
}
