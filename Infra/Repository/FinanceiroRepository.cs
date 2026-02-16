using GVC.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GVC.Infra.Repository
{
    public class FinanceiroRepository: RepositoryBase
    {

        // Na aplicação (exemplo):
        /*
        var service = new FinanceiroService();
        var repo = new FinanceiroRepository();
        */

        public void SalvarPagamento(
        int parcelaId,
        decimal valorPago,
        DateTime dataPagamento,
        string formaPagamento,
        decimal valorRecebidoAtual,
        string statusParcela)
        {
            using var transaction = Connection.BeginTransaction();

            try
            {
                // 1️⃣ Inserir pagamento
                var insert = CreateCommand(@"
            INSERT INTO PagamentosParciais
            (ParcelaID, ValorPago, DataPagamento, FormaPagamento, EmpresaID)
            VALUES
            (@ParcelaID, @ValorPago, @DataPagamento, @FormaPagamento, @EmpresaID)
        ");

                insert.Transaction = transaction;
                insert.Parameters.AddWithValue("@ParcelaID", parcelaId);
                insert.Parameters.AddWithValue("@ValorPago", valorPago);
                insert.Parameters.AddWithValue("@DataPagamento", dataPagamento);
                insert.Parameters.AddWithValue("@FormaPagamento", formaPagamento);
                insert.ExecuteNonQuery();

                // 2️⃣ Atualizar parcela
                var update = CreateCommand(@"
            UPDATE Parcela
            SET 
                ValorRecebido = @ValorRecebido,
                Status = @Status,
                DataPagamento = 
                    CASE 
                        WHEN @Status = 'Pago' THEN @DataPagamento
                        ELSE DataPagamento
                    END
            WHERE ParcelaID = @ParcelaID
            AND EmpresaID = @EmpresaID
        ");

                update.Transaction = transaction;
                update.Parameters.AddWithValue("@ParcelaID", parcelaId);
                update.Parameters.AddWithValue("@ValorRecebido", valorRecebidoAtual);
                update.Parameters.AddWithValue("@Status", statusParcela);
                update.Parameters.AddWithValue("@DataPagamento", dataPagamento);
                update.ExecuteNonQuery();

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public void AtualizarStatusVenda(int vendaId)
        {
            var cmd = CreateCommand(@"
                UPDATE v
                SET StatusVenda =
                    CASE
                        WHEN NOT EXISTS (
                            SELECT 1
                            FROM Parcela p
                            WHERE p.VendaID = v.VendaID
                            AND p.Status <> 'Cancelada'
                            AND p.Status <> 'Pago'
                            AND p.EmpresaID = @EmpresaID
                        )
                        THEN 'Concluida'
                        ELSE 'AguardandoPagamento'
                    END
                FROM Venda v
                WHERE v.VendaID = @VendaID
                AND v.EmpresaID = @EmpresaID
            ");

            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.ExecuteNonQuery();
        }

    }
}
