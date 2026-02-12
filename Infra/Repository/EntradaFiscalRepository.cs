using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace GVC.Infra.Repository
{
    public class EntradaFiscalRepository : RepositoryBase
    {
        public void ConfirmarEntrada(
     int produtoID,
     int quantidade,
     decimal precoCompraEntrada,
     decimal precoCustoEntrada,
     string tipoMovimentacao,
     string documento,
     string observacao,
     string usuario)
        {
            using var transaction = Connection.BeginTransaction();

            try
            {
                // 1️⃣ Buscar produto atual
                var cmdSelect = new SqlCommand(@"
            SELECT Estoque, PrecoCusto
            FROM Produtos
            WHERE ProdutoID = @ProdutoID
            AND EmpresaID = @EmpresaID", Connection, transaction);

                cmdSelect.Parameters.AddWithValue("@ProdutoID", produtoID);
                cmdSelect.Parameters.AddWithValue("@EmpresaID", EmpresaID);

                int estoqueAtual = 0;
                decimal custoAtual = 0;

                using (var reader = cmdSelect.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        estoqueAtual = Convert.ToInt32(reader["Estoque"]);
                        custoAtual = Convert.ToDecimal(reader["PrecoCusto"]);
                    }
                    else
                        throw new Exception("Produto não encontrado.");
                }

                // 2️⃣ Novo estoque
                int estoqueNovo = estoqueAtual + quantidade;

                // 3️⃣ Novo custo médio ponderado
                decimal novoCustoMedio;

                if (estoqueAtual == 0)
                {
                    novoCustoMedio = precoCustoEntrada;
                }
                else
                {
                    novoCustoMedio =
                        ((estoqueAtual * custoAtual) +
                        (quantidade * precoCustoEntrada))
                        / estoqueNovo;
                }

                // 4️⃣ Atualizar Produto
                var cmdUpdate = new SqlCommand(@"
            UPDATE Produtos
            SET Estoque = @Estoque,
                PrecoCompra = @PrecoCompra,
                PrecoCusto = @PrecoCusto,
                DataDeEntrada = GETDATE()
            WHERE ProdutoID = @ProdutoID
            AND EmpresaID = @EmpresaID", Connection, transaction);

                cmdUpdate.Parameters.AddWithValue("@Estoque", estoqueNovo);
                cmdUpdate.Parameters.AddWithValue("@PrecoCompra", precoCompraEntrada);
                cmdUpdate.Parameters.AddWithValue("@PrecoCusto", novoCustoMedio);
                cmdUpdate.Parameters.AddWithValue("@ProdutoID", produtoID);
                cmdUpdate.Parameters.AddWithValue("@EmpresaID", EmpresaID);

                cmdUpdate.ExecuteNonQuery();

                // 5️⃣ Gravar Movimentação
                var cmdInsert = new SqlCommand(@"
                    INSERT INTO MovimentacaoEstoque
                    (ProdutoID, TipoMovimentacao, Quantidade,
                     EstoqueAnterior, EstoqueAtual,
                     Origem, Documento, Observacao,
                     DataMovimentacao, Usuario, EmpresaID)
                    VALUES
                    (@ProdutoID, @TipoMovimentacao, @Quantidade,
                     @EstoqueAnterior, @EstoqueAtual,
                     @Origem, @Documento, @Observacao,
                     GETDATE(), @Usuario, @EmpresaID)", Connection, transaction);

                cmdInsert.Parameters.AddWithValue("@ProdutoID", produtoID);
                cmdInsert.Parameters.AddWithValue("@TipoMovimentacao", tipoMovimentacao);
                cmdInsert.Parameters.AddWithValue("@Quantidade", quantidade);
                cmdInsert.Parameters.AddWithValue("@EstoqueAnterior", estoqueAtual);
                cmdInsert.Parameters.AddWithValue("@EstoqueAtual", estoqueNovo);
                cmdInsert.Parameters.AddWithValue("@Origem", "ENTRADA_FISCAL");
                cmdInsert.Parameters.AddWithValue("@Documento", documento ?? "");
                cmdInsert.Parameters.AddWithValue("@Observacao", observacao ?? "");
                cmdInsert.Parameters.AddWithValue("@Usuario", usuario ?? "");
                cmdInsert.Parameters.AddWithValue("@EmpresaID", EmpresaID);

                cmdInsert.ExecuteNonQuery();

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

    }
}
