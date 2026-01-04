using Dapper;
using GVC.Model;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GVC.DAL
{
    public class ParcelaDal
    {
        public void InsertParcela(ParcelaModel parcela)
        {
            const string sql = @" INSERT INTO Parcela (
                    VendaID, NumeroParcela, DataVencimento, ValorParcela, ValorRecebido,
                    Status, DataPagamento, Juros, Multa, Observacao)
                VALUES ( @VendaID, @NumeroParcela, @DataVencimento, @ValorParcela, @ValorRecebido,
                    @Status, @DataPagamento, @Juros, @Multa, @Observacao )";
            using var conn = Conexao.Conex();
            conn.Execute(sql, parcela);
        }

        public void InsertParcelas(List<ParcelaModel> parcelas)
        {
            if (!parcelas.Any()) return;

            const string sql = @" INSERT INTO Parcela (
                    VendaID, NumeroParcela, DataVencimento, ValorParcela, ValorRecebido,
                    Status, DataPagamento, Juros, Multa, Observacao
                )
                VALUES (
                    @VendaID, @NumeroParcela, @DataVencimento, @ValorParcela, @ValorRecebido,
                    @Status, @DataPagamento, @Juros, @Multa, @Observacao
                )";

            using var conn = Conexao.Conex();
            conn.Execute(sql, parcelas);
        }

        public void UpdateParcela(ParcelaModel parcela)
        {
            const string sql = @"UPDATE Parcela 
                SET DataVencimento = @DataVencimento,
                    ValorParcela   = @ValorParcela,
                    ValorRecebido  = @ValorRecebido,
                    Status         = @Status,
                    DataPagamento  = @DataPagamento,
                    Juros          = @Juros,
                    Multa          = @Multa,
                    Observacao     = @Observacao
                WHERE ParcelaID = @ParcelaID";

            using var conn = Conexao.Conex();
            conn.Execute(sql, parcela);
        }

        public void BaixarParcela(long parcelaId, decimal valorPago, DateTime dataPagamento)
        {
            const string sql = @" UPDATE Parcela
           SET ValorRecebido = ValorRecebido + @ValorPago,
               DataPagamento = @DataPagamento
         WHERE ParcelaID = @ParcelaID";

            using var conn = Conexao.Conex();
            conn.Execute(sql, new
            {
                ParcelaID = parcelaId,
                ValorPago = valorPago,
                DataPagamento = dataPagamento
            });
        }

        public void BaixarParcelasEmLote(List<long> parcelasIds, DateTime dataPagamento)
        {
            if (parcelasIds == null || parcelasIds.Count == 0)
                return;

            using var conn = Conexao.Conex();
            conn.Open();
            using var transaction = conn.BeginTransaction();

            try
            {
                const string sqlBaixa = @"
            UPDATE Parcela
            SET ValorRecebido = ValorParcela + Juros + Multa,
                DataPagamento = @DataPagamento
            WHERE ParcelaID = @ParcelaID";

                foreach (var parcelaId in parcelasIds)
                {
                    conn.Execute(sqlBaixa, new
                    {
                        ParcelaID = parcelaId,
                        DataPagamento = dataPagamento
                    }, transaction);
                }

                const string sqlHistorico = @"
            INSERT INTO PagamentosParciais (ParcelaID, DataPagamento,FormaPgtoID, ValorPago, Observacao)
            SELECT 
                ParcelaID,
                @DataPagamento,
                (ValorParcela + Juros + Multa - ValorRecebido),
                'Baixa total em lote'
            FROM Parcela
            WHERE ParcelaID = @ParcelaID";

                foreach (var parcelaId in parcelasIds)
                {
                    conn.Execute(sqlHistorico, new
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

        public ParcelaModel? BuscarPorId(decimal parcelaId)
        {
            const string sql = "SELECT * FROM Parcela WHERE ParcelaID = @Id";
            using var conn = Conexao.Conex();
            return conn.QueryFirstOrDefault<ParcelaModel>(sql, new { Id = parcelaId });
        }

        public List<ParcelaModel> GetParcelas(long vendaId)
        {
            const string sql = @"SELECT * FROM Parcela WHERE VendaID = @VendaID ORDER BY NumeroParcela";

            using var conn = Conexao.Conex();
            return conn.Query<ParcelaModel>(sql, new { VendaID = vendaId }).AsList();
        }

        public DataTable ListarParcelas()
        {
            AtualizarParcelasAtrasadas();
            const string sql = "SELECT * FROM Parcela ORDER BY DataVencimento";

            using var conn = Conexao.Conex();
            var dt = new DataTable();
            dt.Load(conn.ExecuteReader(sql));
            return dt;
        }

        public DataTable ListarParcelasPendentesPorCliente(int clienteId)
        {
            const string sql = @"SELECT p.*,
                       v.DataVenda,
                       c.Nome
                FROM Parcela p
                INNER JOIN Venda v   ON p.VendaID = v.VendaID
                INNER JOIN Cliente c ON v.ClienteID = c.ClienteID
                WHERE c.ClienteID = @ClienteID
                  AND p.Status = 'Pendente'
                ORDER BY p.DataVencimento";

            using var conn = Conexao.Conex();
            var dt = new DataTable();
            dt.Load(conn.ExecuteReader(sql, new { ClienteID = clienteId }));
            return dt;
        }

        public void Excluir(ParcelaModel parcela)
        {
            const string sql = "DELETE FROM Parcela WHERE ParcelaID = @Id";
            using var conn = Conexao.Conex();
            conn.Execute(sql, new { Id = parcela.ParcelaID });
        }

        public void EstornarPagamento(long parcelaId, decimal valorEstorno, DateTime dataEstorno, string motivo = null)
        {
            if (valorEstorno <= 0m)
                throw new ArgumentException("Valor do estorno deve ser maior que zero.");

            if (string.IsNullOrWhiteSpace(motivo))
                motivo = "Estorno sem motivo informado";

            // Observação que será gravada junto ao estorno
            string observacao = $"[{dataEstorno:dd/MM/yyyy HH:mm}] Estorno de {valorEstorno:C2} - Motivo: {motivo}";

            const string sql = @"INSERT INTO PagamentosParciais 
            (ParcelaID, ValorPago, DataPagamento, FormaPgtoID, Observacao)
            VALUES (@ParcelaID, -@ValorEstorno, @DataEstorno, NULL, @Observacao);";

            using var conn = Conexao.Conex();
            conn.Execute(sql, new
            {
                ParcelaID = parcelaId,
                ValorEstorno = valorEstorno,
                DataEstorno = dataEstorno,
                Observacao = observacao
            });
        }


        public void AtualizarParcelasAtrasadas()
        {
            const string sql = @"
                UPDATE Parcela
                SET Status = 'Atrasada'
                WHERE Status IN ('Pendente', 'Parcialmente Paga')
                  AND DataVencimento < GETDATE()";   // ✅ Ajuste para SQL Server

            using var conn = Conexao.Conex();
            conn.Execute(sql);
        }

        public void CancelarParcelasPorVenda(long vendaId)
        {
            string sql = @"
        UPDATE Parcela 
        SET Status = 'CANCELADA',
            ValorRecebido = 0,
            DataPagamento = NULL
        WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.ExecuteNonQuery();
        }       
        public bool ExistePagamentoPorVenda(long vendaId)
        {
            string sql = @" SELECT COUNT(1)
        FROM Parcela p
        LEFT JOIN PagamentosParciais pp ON pp.ParcelaID = p.ParcelaID
        WHERE p.VendaID = @VendaID
          AND ( p.ValorRecebido > 0 OR pp.PagamentoID IS NOT NULL )";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }
        public void ExcluirPorVenda(long vendaId)
        {
            string sql = "DELETE FROM Parcela WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.ExecuteNonQuery();
        }
        // 26/12/2025


    }
}
