using GVC.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using GVC.UTIL;
using GVC.Infra.Repository;

namespace GVC.DAL
{
    public class EstoqueDAL : RepositoryBase
    {
        // ===============================
        // 🔹 MÉTODO USADO DENTRO DE TRANSAÇÃO (VENDA)
        // ===============================
        public int ObterEstoqueAtual(int produtoId, SqlConnection conn, SqlTransaction tran)
        {
            const string sql = @"
                SELECT Estoque 
                FROM Produtos 
                WHERE ProdutoID = @ProdutoID
                  AND EmpresaID = @EmpresaID";

            using var cmd = new SqlCommand(sql, conn, tran);
            cmd.Parameters.AddWithValue("@ProdutoID", produtoId);
            cmd.Parameters.AddWithValue("@EmpresaID", Sessao.EmpresaID);

            var result = cmd.ExecuteScalar();
            return result == null ? 0 : Convert.ToInt32(result);
        }

        // ===============================
        // 🔹 MÉTODO SIMPLES (FORA DE TRANSAÇÃO)
        // ===============================
        public int ObterEstoqueAtualizado(long produtoId)
        {
            const string sql = @"
                SELECT Estoque 
                FROM Produtos 
                WHERE ProdutoID = @ProdutoID
                  AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);

            cmd.Parameters.Add("@ProdutoID", SqlDbType.BigInt).Value = produtoId;

            var result = cmd.ExecuteScalar();
            return result == null ? 0 : Convert.ToInt32(result);
        }

        // ===============================
        // 🔹 ATUALIZAR ESTOQUE (TRANSAÇÃO)
        // ===============================
        public void AtualizarEstoque(int produtoId, int novoEstoque, SqlConnection conn, SqlTransaction tran)
        {
            const string sql = @"
                UPDATE Produtos 
                SET Estoque = @Estoque 
                WHERE ProdutoID = @ProdutoID
                  AND EmpresaID = @EmpresaID";

            using var cmd = new SqlCommand(sql, conn, tran);

            cmd.Parameters.AddWithValue("@Estoque", novoEstoque);
            cmd.Parameters.AddWithValue("@ProdutoID", produtoId);
            cmd.Parameters.AddWithValue("@EmpresaID", Sessao.EmpresaID);

            cmd.ExecuteNonQuery();
        }

        // ===============================
        // 🔹 REGISTRAR MOVIMENTAÇÃO
        // ===============================
        public void RegistrarMovimentacao(MovimentacaoEstoqueModel mov, SqlConnection conn, SqlTransaction tran)
        {
            const string sql = @"
                INSERT INTO MovimentacaoEstoque
                    (ProdutoID, TipoMovimentacao, Quantidade, EstoqueAnterior, EstoqueAtual,
                     Origem, Documento, Observacao, Usuario, EmpresaID,
                     PrecoCompra, PrecoCustoEntrada, FornecedorID)
                    VALUES
                    (@ProdutoID, @Tipo, @Quantidade, @Anterior, @Atual,
                     @Origem, @Documento, @Observacao, @Usuario, @EmpresaID,
                     @PrecoCompra, @PrecoCustoEntrada, @FornecedorID)
";

            

            using var cmd = new SqlCommand(sql, conn, tran);

            cmd.Parameters.AddWithValue("@ProdutoID", mov.ProdutoID);
            cmd.Parameters.AddWithValue("@Tipo", mov.TipoMovimentacao);
            cmd.Parameters.AddWithValue("@Quantidade", mov.Quantidade);
            cmd.Parameters.AddWithValue("@Anterior", mov.EstoqueAnterior);
            cmd.Parameters.AddWithValue("@Atual", mov.EstoqueAtual);
            cmd.Parameters.AddWithValue("@Origem", mov.Origem);
            cmd.Parameters.AddWithValue("@Documento", (object?)mov.Documento ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Observacao", (object?)mov.Observacao ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Usuario", (object?)mov.Usuario ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@EmpresaID", Sessao.EmpresaID);            
            cmd.Parameters.AddWithValue("@PrecoCompra", (object?)mov.PrecoCompra ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@PrecoCustoEntrada", (object?)mov.PrecoCustoEntrada ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@FornecedorID", (object?)mov.FornecedorID ?? DBNull.Value);


            cmd.ExecuteNonQuery();
        }
    }
}
