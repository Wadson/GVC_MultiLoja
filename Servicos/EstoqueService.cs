using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace GVC.Service
{
    public class EstoqueService
    {
        private readonly SqlConnection _connection;

        public EstoqueService(SqlConnection connection)
        {
            _connection = connection;
        }

        public void BaixarEstoque(int produtoId, int quantidade, SqlTransaction tran)
        {
            const string sql = @"
        UPDATE Produtos
        SET Estoque = Estoque - @Qtd
        WHERE ProdutoID = @ProdutoID
          AND EmpresaID = @EmpresaID
          AND Estoque >= @Qtd";

            using var cmd = _connection.CreateCommand();
            cmd.Transaction = tran;
            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue("@ProdutoID", produtoId);
            cmd.Parameters.AddWithValue("@Qtd", quantidade);

            if (cmd.ExecuteNonQuery() == 0)
                throw new Exception($"Estoque insuficiente para o produto {produtoId}");

            AtualizarStatusProduto(produtoId, tran);
        }

        public void DevolverEstoque(int produtoId, int quantidade, SqlTransaction tran)
        {
            const string sql = @"
        UPDATE Produtos
        SET Estoque = Estoque + @Qtd
        WHERE ProdutoID = @ProdutoID
          AND EmpresaID = @EmpresaID";

            using var cmd = _connection.CreateCommand();
            cmd.Transaction = tran;
            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue("@ProdutoID", produtoId);
            cmd.Parameters.AddWithValue("@Qtd", quantidade);

            cmd.ExecuteNonQuery();

            AtualizarStatusProduto(produtoId, tran);
        }

        private void AtualizarStatusProduto(int produtoId, SqlTransaction tran)
        {
            const string sql = @"
        UPDATE Produtos
        SET Status =
            CASE WHEN Estoque <= 0
                 THEN 'Indisponível'
                 ELSE 'Disponível'
            END
        WHERE ProdutoID = @ProdutoID
          AND EmpresaID = @EmpresaID";

            using var cmd = _connection.CreateCommand();
            cmd.Transaction = tran;
            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue("@ProdutoID", produtoId);

            cmd.ExecuteNonQuery();
        }
    }

}
