using Dapper;
using GVC.DTO;
using GVC.Model;
using GVC.Model.Enums;
using GVC.Model.Extensions;
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
        public ParcelaRepository() : base() { }
        public ParcelaRepository(SqlConnection connection) : base(connection) { }
        public void RegistrarPagamentoSeguro(
     ParcelaModel parcela,
     decimal valorPago,
     DateTime dataPagamento,
     int? formaPgtoId,
     string? observacao)
        {
            using var tran = Connection.BeginTransaction();

            try
            {
                RegistrarPagamentoSeguro(parcela, valorPago, dataPagamento, formaPgtoId, observacao, tran);
                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }
        public void RegistrarPagamentoSeguro(
            ParcelaModel parcela,
            decimal valorPago,
            DateTime dataPagamento,
            int? formaPgtoId,
            string? observacao,
            SqlTransaction tran)
        {
            // 1) Histórico
            const string sqlInsert = @"
                INSERT INTO PagamentosParciais
                    (ParcelaID, DataPagamento, FormaPgtoID, ValorPago, Observacao, EmpresaID)
                VALUES
                    (@ParcelaID, @DataPagamento, @FormaPgtoID, @ValorPago, @Observacao, @EmpresaID);";

            using (var insert = CreateCommand(sqlInsert))
            {
                insert.Transaction = tran;

                insert.Parameters.Add("@ParcelaID", SqlDbType.Int).Value = parcela.ParcelaID;
                insert.Parameters.Add("@DataPagamento", SqlDbType.Date).Value = dataPagamento.Date;
                insert.Parameters.Add("@FormaPgtoID", SqlDbType.Int).Value = (object?)formaPgtoId ?? DBNull.Value;
                insert.Parameters.Add("@ValorPago", SqlDbType.Decimal).Value = valorPago;
                insert.Parameters.Add("@Observacao", SqlDbType.NVarChar).Value = (object?)observacao ?? DBNull.Value;

                insert.ExecuteNonQuery();
            }

            // 2) Atualiza parcela (Status padronizado com ToDb)
            const string sqlUpdate = @"
                UPDATE Parcela
                SET
                    ValorRecebido = @ValorRecebido,
                    Status = @Status,
                    DataPagamento = @DataPagamento
                WHERE ParcelaID = @ParcelaID
                  AND EmpresaID = @EmpresaID;";

            using (var update = CreateCommand(sqlUpdate))
            {
                update.Transaction = tran;

                update.Parameters.Add("@ParcelaID", SqlDbType.Int).Value = parcela.ParcelaID;
                update.Parameters.Add("@ValorRecebido", SqlDbType.Decimal).Value = parcela.ValorRecebido ?? 0m;
                update.Parameters.Add("@Status", SqlDbType.NVarChar, 20).Value = parcela.Status.ToDb();
                update.Parameters.Add("@DataPagamento", SqlDbType.Date).Value =
                    (object?)parcela.DataPagamento?.Date ?? DBNull.Value;

                if (update.ExecuteNonQuery() == 0)
                    throw new Exception("Falha ao atualizar parcela (registro não encontrado ou EmpresaID divergente).");
            }
        }


        public void AtualizarValorRecebido(
        int parcelaId,
        decimal valorRecebido,
        SqlConnection conn,
        SqlTransaction tran)
        {
            using var cmd = new SqlCommand(@"
            UPDATE Parcela
            SET ValorRecebido = @ValorRecebido
            WHERE ParcelaID = @ParcelaID
        ", conn, tran);

            cmd.Parameters.AddWithValue("@ValorRecebido", valorRecebido);
            cmd.Parameters.AddWithValue("@ParcelaID", parcelaId);

            cmd.ExecuteNonQuery();
        }

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
                );";

            using var cmd = CreateCommand(sql);

            cmd.Parameters.Add("@VendaID", SqlDbType.Int).Value = parcela.VendaID;
            cmd.Parameters.Add("@NumeroParcela", SqlDbType.Int).Value = parcela.NumeroParcela;
            cmd.Parameters.Add("@DataVencimento", SqlDbType.Date).Value = parcela.DataVencimento.Date;
            cmd.Parameters.Add("@ValorParcela", SqlDbType.Decimal).Value = parcela.ValorParcela;

            cmd.Parameters.Add("@ValorRecebido", SqlDbType.Decimal).Value = parcela.ValorRecebido ?? 0m;
            cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 20).Value = parcela.Status.ToDb();
            cmd.Parameters.Add("@DataPagamento", SqlDbType.Date).Value = (object?)parcela.DataPagamento?.Date ?? DBNull.Value;

            cmd.Parameters.Add("@Juros", SqlDbType.Decimal).Value = parcela.Juros ?? 0m;
            cmd.Parameters.Add("@Multa", SqlDbType.Decimal).Value = parcela.Multa ?? 0m;
            cmd.Parameters.Add("@Observacao", SqlDbType.NVarChar).Value = (object?)parcela.Observacao ?? DBNull.Value;

            cmd.ExecuteNonQuery();
        }


        public int AtualizarParcelasAtrasadas()
        {
            const string sql = @"
            UPDATE Parcela
            SET Status = 'Atrasada'
            WHERE EmpresaID = @EmpresaID
              AND DataVencimento < CAST(GETDATE() AS DATE)
              AND Status NOT IN ('Pago','ParcialmentePago','Cancelada','Atrasada')";

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
                  AND EmpresaID = @EmpresaID;";

            using var cmd = CreateCommand(sql);

            cmd.Parameters.Add("@ParcelaID", SqlDbType.Int).Value = parcela.ParcelaID;
            cmd.Parameters.Add("@DataVencimento", SqlDbType.Date).Value = parcela.DataVencimento.Date;
            cmd.Parameters.Add("@ValorParcela", SqlDbType.Decimal).Value = parcela.ValorParcela;
            cmd.Parameters.Add("@ValorRecebido", SqlDbType.Decimal).Value = parcela.ValorRecebido ?? 0m;

            cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 20).Value = parcela.Status.ToDb();
            cmd.Parameters.Add("@DataPagamento", SqlDbType.Date).Value = (object?)parcela.DataPagamento?.Date ?? DBNull.Value;

            cmd.Parameters.Add("@Juros", SqlDbType.Decimal).Value = parcela.Juros ?? 0m;
            cmd.Parameters.Add("@Multa", SqlDbType.Decimal).Value = parcela.Multa ?? 0m;
            cmd.Parameters.Add("@Observacao", SqlDbType.NVarChar).Value = (object?)parcela.Observacao ?? DBNull.Value;

            if (cmd.ExecuteNonQuery() == 0)
                throw new Exception("Falha ao atualizar parcela (registro não encontrado ou EmpresaID divergente).");
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

            using var tran = Connection.BeginTransaction();

            try
            {
                // 1) Para cada parcela: calcula saldo, grava histórico e quita
                const string sqlGet = @"
            SELECT ParcelaID,
                   (ValorParcela + ISNULL(Juros,0) + ISNULL(Multa,0) - ISNULL(ValorRecebido,0)) AS Saldo
            FROM Parcela
            WHERE ParcelaID = @ParcelaID
              AND EmpresaID = @EmpresaID;";

                const string sqlHistorico = @"
            INSERT INTO PagamentosParciais
                (ParcelaID, DataPagamento, FormaPgtoID, ValorPago, Observacao, EmpresaID)
            VALUES
                (@ParcelaID, @DataPagamento, @FormaPgtoID, @ValorPago, @Observacao, @EmpresaID);";

                const string sqlQuitar = @"
                UPDATE Parcela
                SET ValorRecebido = (ValorParcela + ISNULL(Juros,0) + ISNULL(Multa,0)),
                    DataPagamento = @DataPagamento,
                    Status = 'Pago'
                WHERE ParcelaID = @ParcelaID
                  AND EmpresaID = @EmpresaID;";



                foreach (var parcelaIdLong in parcelasIds)
                {
                    int parcelaId = (int)parcelaIdLong;

                    decimal saldo;
                    using (var cmdGet = CreateCommand(sqlGet))
                    {
                        cmdGet.Transaction = tran;
                        cmdGet.Parameters.Add("@ParcelaID", SqlDbType.Int).Value = parcelaId;

                        using var dr = cmdGet.ExecuteReader();
                        if (!dr.Read())
                            throw new Exception($"Parcela {parcelaId} não encontrada.");

                        saldo = Convert.ToDecimal(dr["Saldo"]);
                    }

                    // Se já está quitada, ignora silenciosamente (ou você pode lançar)
                    if (saldo <= 0m)
                        continue;

                    using (var cmdHist = CreateCommand(sqlHistorico))
                    {
                        cmdHist.Transaction = tran;
                        cmdHist.Parameters.Add("@ParcelaID", SqlDbType.Int).Value = parcelaId;
                        cmdHist.Parameters.Add("@DataPagamento", SqlDbType.Date).Value = dataPagamento.Date;
                        cmdHist.Parameters.Add("@FormaPgtoID", SqlDbType.Int).Value = (int)formaPgtoId;
                        cmdHist.Parameters.Add("@ValorPago", SqlDbType.Decimal).Value = saldo;
                        cmdHist.Parameters.Add("@Observacao", SqlDbType.NVarChar).Value = obsFinal;

                        cmdHist.ExecuteNonQuery();
                    }

                    using (var cmdQuitar = CreateCommand(sqlQuitar))
                    {
                        cmdQuitar.Transaction = tran;
                        cmdQuitar.Parameters.Add("@ParcelaID", SqlDbType.Int).Value = parcelaId;
                        cmdQuitar.Parameters.Add("@DataPagamento", SqlDbType.Date).Value = dataPagamento.Date;

                        if (cmdQuitar.ExecuteNonQuery() == 0)
                            throw new Exception($"Falha ao quitar a parcela {parcelaId}.");
                    }
                }

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }


        public void BaixarParcela(long parcelaId, decimal valorPago, DateTime dataPagamento)
        {
            const string sql = @"
        UPDATE Parcela
           SET ValorRecebido = ISNULL(ValorRecebido,0) + @ValorPago,
               DataPagamento = @DataPagamento
         WHERE ParcelaID = @ParcelaID
           AND EmpresaID = @EmpresaID;";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.Add("@ParcelaID", SqlDbType.Int).Value = (int)parcelaId;
            cmd.Parameters.Add("@ValorPago", SqlDbType.Decimal).Value = valorPago;
            cmd.Parameters.Add("@DataPagamento", SqlDbType.Date).Value = dataPagamento.Date;

            if (cmd.ExecuteNonQuery() == 0)
                throw new Exception("Falha ao baixar parcela (não encontrada).");

            // ✅ Recalcula status após baixa (padrão ERP)
            var parcela = BuscarParcelaPorId((decimal)parcelaId)
                ?? throw new Exception("Parcela não encontrada para recalcular status.");

            // reaproveita regra já existente no FinanceiroService
            var financeiro = new GVC.DTO.FinanceiroService();
            financeiro.AtualizarStatusParcela(parcela);

            UpdateParcela(parcela); // já grava Status com ToDb
        }


        public ParcelaModel? BuscarParcelaPorId(decimal parcelaId)
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
        public ClienteModel BuscarClientePorId(int clienteId)
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
        // ✅ MÉTODO NORMAL (SEM TRANSAÇÃO)
        public List<ParcelaModel> GetParcelas(long vendaId)
        {
            const string sql = @"
            SELECT *
            FROM Parcela
            WHERE VendaID = @VendaID
              AND EmpresaID = @EmpresaID
            ORDER BY NumeroParcela";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.Add("@VendaID", SqlDbType.Int).Value = (int)vendaId;

            using var dr = cmd.ExecuteReader();
            var lista = new List<ParcelaModel>();

            while (dr.Read())
                lista.Add(Mapear(dr));

            return lista;
        }

        public List<ParcelaModel> GetParcelas(long vendaId, SqlTransaction tran)
        {
            const string sql = @"
                SELECT *
                FROM Parcela
                WHERE VendaID = @VendaID
                  AND EmpresaID = @EmpresaID
                ORDER BY NumeroParcela";

            using var cmd = CreateCommand(sql);
            cmd.Transaction = tran; // ✅ ESSENCIAL
            cmd.Parameters.Add("@VendaID", SqlDbType.Int).Value = (int)vendaId;

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
            if (valorEstorno <= 0m)
                throw new Exception("Valor de estorno inválido.");

            using var tran = Connection.BeginTransaction();

            try
            {
                // 1) Busca parcela atual (com trava opcional)
                const string sqlGet = @"
            SELECT ValorParcela, ISNULL(Juros,0) AS Juros, ISNULL(Multa,0) AS Multa,
                   ISNULL(ValorRecebido,0) AS ValorRecebido, DataVencimento
            FROM Parcela
            WHERE ParcelaID = @ParcelaID
              AND EmpresaID = @EmpresaID;";

                decimal valorParcela, juros, multa, recebido;
                DateTime venc;

                using (var cmdGet = CreateCommand(sqlGet))
                {
                    cmdGet.Transaction = tran;
                    cmdGet.Parameters.Add("@ParcelaID", SqlDbType.Int).Value = (int)parcelaId;

                    using var dr = cmdGet.ExecuteReader();
                    if (!dr.Read())
                        throw new Exception("Parcela não encontrada.");

                    valorParcela = Convert.ToDecimal(dr["ValorParcela"]);
                    juros = Convert.ToDecimal(dr["Juros"]);
                    multa = Convert.ToDecimal(dr["Multa"]);
                    recebido = Convert.ToDecimal(dr["ValorRecebido"]);
                    venc = Convert.ToDateTime(dr["DataVencimento"]);
                }

                if (valorEstorno > recebido)
                    throw new Exception("Valor do estorno maior que o valor recebido.");

                // 2) Histórico (estorno é ValorPago negativo)
                const string sqlHist = @"
                    INSERT INTO PagamentosParciais
                        (ParcelaID, ValorPago, DataPagamento, Observacao, EmpresaID)
                    VALUES
                        (@ParcelaID, @ValorPago, @DataPagamento, @Observacao, @EmpresaID);";

                using (var cmdHist = CreateCommand(sqlHist))
                {
                    cmdHist.Transaction = tran;
                    cmdHist.Parameters.Add("@ParcelaID", SqlDbType.Int).Value = (int)parcelaId;
                    cmdHist.Parameters.Add("@ValorPago", SqlDbType.Decimal).Value = -valorEstorno;
                    cmdHist.Parameters.Add("@DataPagamento", SqlDbType.Date).Value = dataEstorno.Date;
                    cmdHist.Parameters.Add("@Observacao", SqlDbType.NVarChar).Value = motivo;

                    cmdHist.ExecuteNonQuery();
                }

                // 3) Recalcula recebido e status
                decimal novoRecebido = recebido - valorEstorno;
                decimal total = valorParcela + juros + multa;

                string novoStatus;
                DateTime? novaDataPagamento;

                if (novoRecebido <= 0m)
                {
                    novoRecebido = 0m;
                    novoStatus = (venc.Date < DateTime.Today) ? "Atrasada" : "Pendente";
                    novaDataPagamento = null;
                }
                else if (novoRecebido < total)
                {
                    novoStatus = "ParcialmentePago";
                    novaDataPagamento = null; // opcional: manter ou limpar
                }
                else
                {
                    novoStatus = "Pago";
                    novaDataPagamento = dataEstorno.Date;
                }

                // 4) Atualiza parcela
                const string sqlUpd = @"
                    UPDATE Parcela
                    SET ValorRecebido = @ValorRecebido,
                        Status = @Status,
                        DataPagamento = @DataPagamento
                    WHERE ParcelaID = @ParcelaID
                      AND EmpresaID = @EmpresaID;";

                using (var cmdUpd = CreateCommand(sqlUpd))
                {
                    cmdUpd.Transaction = tran;
                    cmdUpd.Parameters.Add("@ParcelaID", SqlDbType.Int).Value = (int)parcelaId;
                    cmdUpd.Parameters.Add("@ValorRecebido", SqlDbType.Decimal).Value = novoRecebido;
                    cmdUpd.Parameters.Add("@Status", SqlDbType.NVarChar, 20).Value = novoStatus;
                    cmdUpd.Parameters.Add("@DataPagamento", SqlDbType.Date).Value =
                        (object?)novaDataPagamento ?? DBNull.Value;

                    if (cmdUpd.ExecuteNonQuery() == 0)
                        throw new Exception("Falha ao atualizar parcela no estorno.");
                }

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }
        public ParcelaDetalheDTO ObterDetalheParcela(long parcelaId)
        {
            const string sql = @"
            SELECT
                p.ParcelaID,
                p.VendaID,
                p.NumeroParcela,
                c.Nome AS NomeCliente,
                v.DataVenda,
                p.DataVencimento,
                p.ValorParcela,
                ISNULL(p.ValorRecebido, 0) AS ValorRecebido,
                (ISNULL(p.ValorParcela,0)
                 + ISNULL(p.Juros,0)
                 + ISNULL(p.Multa,0)
                 - ISNULL(p.ValorRecebido,0)) AS Saldo,
                p.Status
            FROM Parcela p
            INNER JOIN Venda v ON v.VendaID = p.VendaID
            INNER JOIN Clientes c ON c.ClienteID = v.ClienteID
            WHERE p.ParcelaID = @ParcelaID
              AND p.EmpresaID = @EmpresaID;";

            return Connection.QueryFirstOrDefault<ParcelaDetalheDTO>( sql, new { ParcelaID = parcelaId, EmpresaID } );
        }
        //B) ParcelaRepository — adicionar 2 métodos (transacionais)
        public void ExcluirParcelasPorVenda(int vendaId, SqlTransaction tran)
        {
            const string sql = @"
            DELETE FROM Parcela
            WHERE VendaID = @VendaID
              AND EmpresaID = @EmpresaID;";

            using var cmd = CreateCommand(sql);
            cmd.Transaction = tran;
            cmd.Parameters.Add("@VendaID", SqlDbType.Int).Value = vendaId;

            cmd.ExecuteNonQuery();
        }
        public void ExcluirPagamentosParciaisPorVenda(int vendaId, SqlTransaction tran)
        {
            const string sql = @"
            DELETE pp
            FROM PagamentosParciais pp
            INNER JOIN Parcela p ON p.ParcelaID = pp.ParcelaID
            WHERE p.VendaID = @VendaID
              AND p.EmpresaID = @EmpresaID;";

            using var cmd = CreateCommand(sql);
            cmd.Transaction = tran;
            cmd.Parameters.Add("@VendaID", SqlDbType.Int).Value = vendaId;

            cmd.ExecuteNonQuery();
        }

    }
}
