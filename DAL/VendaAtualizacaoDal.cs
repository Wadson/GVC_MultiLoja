using GVC.Model;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace GVC.DALL
{
    public class VendaAtualizacaoDal
    {
        // ============================
        // MÉTODO PÚBLICO (ENTRY POINT)
        // ============================
        public void AtualizarVendaCompleta(
            VendaModel venda,
            List<ItemVendaModel> itens,
            List<ParcelaModel> parcelas)
        {
            using var conn = Conexao.Conex();
            conn.Open();

            using var tran = conn.BeginTransaction();

            try
            {
                // 1️⃣ Atualiza cabeçalho da venda
                AtualizarVenda(venda, conn, tran);

                // 2️⃣ Itens
                ExcluirItens(venda.VendaID, conn, tran);
                InserirItens(venda.VendaID, itens, conn, tran);

                // 3️⃣ Parcelas
                ExcluirParcelas(venda.VendaID, conn, tran);
                InserirParcelas(venda.VendaID, parcelas, conn, tran);

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }

        // ============================
        // MÉTODOS PRIVADOS (AUXILIARES)
        // ============================

        private void AtualizarVenda(
            VendaModel venda,
            SqlConnection conn,
            SqlTransaction tran)
        {
            string sql = @"
                UPDATE Venda
                SET ClienteID   = @ClienteID,
                    FormaPgtoID = @FormaPgtoID,
                    DataVenda   = @DataVenda,
                    ValorTotal  = @ValorTotal,
                    Desconto    = @Desconto,
                    Observacoes = @Observacoes,
                    StatusVenda = @StatusVenda
                WHERE VendaID = @VendaID";

            using var cmd = new SqlCommand(sql, conn, tran);
            cmd.Parameters.AddWithValue("@VendaID", venda.VendaID);
            cmd.Parameters.AddWithValue("@ClienteID", venda.ClienteID);
            cmd.Parameters.AddWithValue("@FormaPgtoID", venda.FormaPgtoID ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@DataVenda", venda.DataVenda);
            cmd.Parameters.AddWithValue("@ValorTotal", venda.ValorTotal);
            cmd.Parameters.AddWithValue("@Desconto", venda.Desconto);
            cmd.Parameters.AddWithValue("@Observacoes", (object)venda.Observacoes ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@StatusVenda", venda.StatusVenda);

            cmd.ExecuteNonQuery();
        }

        private void ExcluirItens(
            long vendaId,
            SqlConnection conn,
            SqlTransaction tran)
        {
            string sql = "DELETE FROM ItemVenda WHERE VendaID = @VendaID";

            using var cmd = new SqlCommand(sql, conn, tran);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.ExecuteNonQuery();
        }

        private void InserirItens(long vendaId, List<ItemVendaModel> itens, SqlConnection conn, SqlTransaction tran)
        {
            string sql = @"
        INSERT INTO ItemVenda
        (VendaID, ProdutoID, Quantidade, PrecoUnitario, Subtotal, DescontoItem)
        VALUES
        (@VendaID, @ProdutoID, @Quantidade, @PrecoUnitario, @Subtotal, @DescontoItem)";

            foreach (var item in itens)
            {
                using var cmd = new SqlCommand(sql, conn, tran);
                cmd.Parameters.AddWithValue("@VendaID", vendaId);
                cmd.Parameters.AddWithValue("@ProdutoID", item.ProdutoID);
                cmd.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                cmd.Parameters.AddWithValue("@PrecoUnitario", item.PrecoUnitario);
                cmd.Parameters.AddWithValue("@Subtotal", item.Subtotal); // leitura ok
                cmd.Parameters.AddWithValue("@DescontoItem", item.DescontoItem); // já não é nullable

                cmd.ExecuteNonQuery();
            }
        }


        private void ExcluirParcelas(
            long vendaId,
            SqlConnection conn,
            SqlTransaction tran)
        {
            string sql = "DELETE FROM Parcela WHERE VendaID = @VendaID";

            using var cmd = new SqlCommand(sql, conn, tran);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.ExecuteNonQuery();
        }

        private void InserirParcelas(
            long vendaId,
            List<ParcelaModel> parcelas,
            SqlConnection conn,
            SqlTransaction tran)
        {
            string sql = @"
                INSERT INTO Parcela
                (VendaID, NumeroParcela, DataVencimento, ValorParcela,
                 ValorRecebido, Status, DataPagamento, Juros, Multa, Observacao)
                VALUES
                (@VendaID, @NumeroParcela, @DataVencimento, @ValorParcela,
                 @ValorRecebido, @Status, @DataPagamento, @Juros, @Multa, @Observacao)";

            foreach (var p in parcelas)
            {
                using var cmd = new SqlCommand(sql, conn, tran);
                cmd.Parameters.AddWithValue("@VendaID", vendaId);
                cmd.Parameters.AddWithValue("@NumeroParcela", p.NumeroParcela);
                cmd.Parameters.AddWithValue("@DataVencimento", p.DataVencimento);
                cmd.Parameters.AddWithValue("@ValorParcela", p.ValorParcela);
                cmd.Parameters.AddWithValue("@ValorRecebido", p.ValorRecebido);
                cmd.Parameters.AddWithValue("@Status", p.Status);
                cmd.Parameters.AddWithValue("@DataPagamento", (object)p.DataPagamento ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Juros", p.Juros);
                cmd.Parameters.AddWithValue("@Multa", p.Multa);
                cmd.Parameters.AddWithValue("@Observacao", (object)p.Observacao ?? DBNull.Value);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
