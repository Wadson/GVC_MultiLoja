using Dapper;
using GVC.MODEL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GVC.DALL
{
    internal class PagamentoParcialDal
    {
        // 1. INSERIR PAGAMENTO PARCIAL       
        public void InserirPagamentoParcial(PagamentoParcialModel pagamentoParcial)
        {
            const string sql = @"INSERT INTO PagamentosParciais (ParcelaID, ValorPago, DataPagamento) 
                VALUES (@ParcelaID, @ValorPago, @DataPagamento)";
            using var conn = GVC.Helpers.Conexao.Conex();
            conn.Execute(sql, pagamentoParcial);
        }

        // 2. EXCLUIR PAGAMENTO PARCIAL POR ID
        public void ExcluirPagamentoParcial(long pagamentoParcialId)
        {
            const string sql = "DELETE FROM PagamentosParciais WHERE PagamentoParcialID = @Id";
            using var conn = GVC.Helpers.Conexao.Conex();
            conn.Execute(sql, new { Id = pagamentoParcialId });
        }

        public void Excluir(PagamentoParcialModel pagamentoParcial)
            => ExcluirPagamentoParcial(pagamentoParcial.PagamentoID);

        // 3. LISTAR PAGAMENTOS PARCIAIS DE UMA PARCELA        
        public List<PagamentoParcialModel> ObterPagamentosParciaisPorParcela(long parcelaId)
        {
            const string sql = @" SELECT PagamentoParcialID,
                       ParcelaID,
                       ValorPago,
                       DataPagamento
                FROM PagamentosParciais 
                WHERE ParcelaID = @ParcelaID 
                ORDER BY DataPagamento DESC";

            using var conn = GVC.Helpers.Conexao.Conex();
            return conn.Query<PagamentoParcialModel>(sql, new { ParcelaID = parcelaId }).AsList();
        }

        // 4. EXCLUIR TODOS OS PAGAMENTOS PARCIAIS DE UMA PARCELA        
        public void ExcluirPagamentosParciaisPorParcelaID(long parcelaId)
        {
            const string sql = "DELETE FROM PagamentosParciais WHERE ParcelaID = @ParcelaID";
            using var conn = GVC.Helpers.Conexao.Conex();
            conn.Execute(sql, new { ParcelaID = parcelaId });
        }

        // 5. LISTAR TODOS OS PAGAMENTOS PARCIAIS (para relatório)       
        public DataTable ListarPagamentosParciais()
        {
            const string sql = @" SELECT pp.PagamentoParcialID,
                       pp.ParcelaID,
                       p.NumeroParcela,
                       c.Nome,
                       pp.ValorPago,
                       pp.DataPagamento
                FROM PagamentosParciais pp
                INNER JOIN Parcela p ON pp.ParcelaID = p.ParcelaID
                INNER JOIN Venda v ON p.VendaID = v.VendaID
                INNER JOIN Cliente c ON v.ClienteID = c.ClienteID
                ORDER BY pp.DataPagamento DESC";

            using var conn = GVC.Helpers.Conexao.Conex();
            var dt = new DataTable();
            dt.Load(conn.ExecuteReader(sql));
            return dt;
        }

        // 6. TOTAL PAGO PARCIALMENTE EM UMA PARCELA
        public decimal TotalPagoParcialmente(long parcelaId)
        {
            const string sql = @" SELECT ISNULL(SUM(ValorPago), 0) 
                FROM PagamentosParciais WHERE ParcelaID = @ParcelaID";  // ✅ Ajuste para SQL Server

            using var conn = GVC.Helpers.Conexao.Conex();
            return conn.QuerySingle<decimal>(sql, new { ParcelaID = parcelaId });
        }

        // 7. REGISTRAR PAGAMENTO PARCIAL + ATUALIZAR PARCELA AUTOMATICAMENTE       
        public void RegistrarPagamentoParcial(long parcelaId, decimal valorPago, DateTime? dataPagamento = null)
        {
            if (valorPago <= 0) return;
            dataPagamento ??= DateTime.Now;
            using var conn = GVC.Helpers.Conexao.Conex(); conn.Open();
            using var trans = conn.BeginTransaction();

            try
            {
                // 1. Insere o pagamento parcial
                const string sqlInsert = @" INSERT INTO PagamentosParciais (ParcelaID, ValorPago, DataPagamento) 
                    VALUES (@ParcelaID, @ValorPago, @DataPagamento)";

                conn.Execute(sqlInsert, new
                {
                    ParcelaID = parcelaId,
                    ValorPago = valorPago,
                    DataPagamento = dataPagamento
                }, trans);

                // 2. Atualiza a parcela
                const string sqlUpdate = @" UPDATE Parcela SET ValorRecebido = ValorRecebido + @ValorPago,
                        SaldoRestante = ValorParcela - (ValorRecebido + @ValorPago),
                        Pago = CASE WHEN (ValorParcela - (ValorRecebido + @ValorPago)) <= 0.005 THEN 1 ELSE 0 END
                        WHERE ParcelaID = @ParcelaID";   // ✅ Ajuste: expressão booleana convertida em CASE para SQL Server

                conn.Execute(sqlUpdate, new { ParcelaID = parcelaId, ValorPago = valorPago }, trans);
                trans.Commit();
            }
            catch
            {
                trans.Rollback();
                throw;
            }
        }
        public List<PagamentoExtratoModel> ListarPagamentosPorParcela(long parcelaId)
        {
            const string sql = @"
                SELECT
                    pp.PagamentoID,
                    pp.ParcelaID,
                    pp.DataPagamento,
                    pp.ValorPago,
                    fp.FormaPgto AS FormaPagamento,
                    pp.Observacao
                FROM PagamentosParciais pp
                LEFT JOIN FormaPgto fp ON fp.FormaPgtoID = pp.FormaPgtoID
                WHERE pp.ParcelaID = @ParcelaID
                ORDER BY pp.DataPagamento";

            using var conn = Helpers.Conexao.Conex();
            return conn.Query<PagamentoExtratoModel>(sql, new { ParcelaID = parcelaId }).ToList();
        }
        public List<PagamentoExtratoModel> ListarPagamentosPorParcelaCompleto(long parcelaId)
        {
            const string sql = @"
        -- 🔹 PAGAMENTOS PARCIAIS
        SELECT
            pp.PagamentoID,
            pp.ParcelaID,
            pp.DataPagamento,
            pp.ValorPago,
            fp.FormaPgto AS FormaPagamento,
            pp.Observacao
        FROM PagamentosParciais pp
        LEFT JOIN FormaPgto fp ON fp.FormaPgtoID = pp.FormaPgtoID
        WHERE pp.ParcelaID = @ParcelaID

        UNION ALL

        -- 🔹 PAGAMENTO ÚNICO (BAIXA DIRETA)
        SELECT
            0 AS PagamentoID,
            p.ParcelaID,
            v.DataVenda AS DataPagamento,
            p.ValorRecebido AS ValorPago,
            fp.FormaPgto AS FormaPagamento,
            'Pagamento Único' AS Observacao
        FROM Parcela p
        INNER JOIN Venda v ON v.VendaID = p.VendaID
        LEFT JOIN FormaPgto fp ON fp.FormaPgtoID = v.FormaPgtoID
        WHERE p.ParcelaID = @ParcelaID
          AND p.ValorRecebido > 0
          AND NOT EXISTS (
              SELECT 1
              FROM PagamentosParciais pp
              WHERE pp.ParcelaID = p.ParcelaID
          )

        ORDER BY DataPagamento";

            using var conn = Helpers.Conexao.Conex();
            return conn.Query<PagamentoExtratoModel>(sql, new { ParcelaID = parcelaId }).ToList();
        }



        // 8. BUSCAR PAGAMENTO PARCIAL POR ID
        public PagamentoParcialModel? BuscarPorId(long pagamentoId)
        {
            const string sql = "SELECT * FROM PagamentosParciais WHERE PagamentoID = @Id";
            using var conn = GVC.Helpers.Conexao.Conex();
            return conn.QueryFirstOrDefault<PagamentoParcialModel>(sql, new { Id = pagamentoId });
        }
        public void ExcluirPorVenda(long vendaId)
        {
            string sql = @"
                DELETE FROM PagamentosParciais
                WHERE ParcelaID IN (
                    SELECT ParcelaID 
                    FROM Parcela 
                    WHERE VendaID = @VendaID
                )";

            using var conn = GVC.Helpers.Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.ExecuteNonQuery();
        }


    }
}
