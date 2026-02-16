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
            string usuario,
            int fornecedorId,
            SqlTransaction transaction)
        {
            if (transaction == null)
                throw new ArgumentNullException(nameof(transaction));

            var connection = transaction.Connection;

            // 1️⃣ Buscar dados atuais do produto
            int estoqueAtual;
            decimal custoAtual;

            using (var cmdSelect = new SqlCommand(@"
                SELECT Estoque, PrecoCusto
                FROM Produtos
                WHERE ProdutoID = @ProdutoID
                AND EmpresaID = @EmpresaID",
                connection, transaction))
            {
                cmdSelect.Parameters.Add("@ProdutoID", SqlDbType.Int).Value = produtoID;
                cmdSelect.Parameters.Add("@EmpresaID", SqlDbType.Int).Value = EmpresaID;

                using var reader = cmdSelect.ExecuteReader();

                if (!reader.Read())
                    throw new Exception("Produto não encontrado.");

                estoqueAtual = Convert.ToInt32(reader["Estoque"]);
                custoAtual = Convert.ToDecimal(reader["PrecoCusto"]);
            }

            // 2️⃣ Calcular novo estoque
            int estoqueNovo = estoqueAtual + quantidade;

            // 3️⃣ Calcular custo médio ponderado
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

            // 4️⃣ Atualizar produto
            using (var cmdUpdate = new SqlCommand(@"
                UPDATE Produtos
                SET Estoque = @Estoque,
                    PrecoCompra = @PrecoCompra,
                    PrecoCusto = @PrecoCusto,
                    DataDeEntrada = GETDATE()
                WHERE ProdutoID = @ProdutoID
                AND EmpresaID = @EmpresaID",
                connection, transaction))
            {
                cmdUpdate.Parameters.Add("@Estoque", SqlDbType.Int).Value = estoqueNovo;
                cmdUpdate.Parameters.Add("@PrecoCompra", SqlDbType.Decimal).Value = precoCompraEntrada;
                cmdUpdate.Parameters["@PrecoCompra"].Precision = 18;
                cmdUpdate.Parameters["@PrecoCompra"].Scale = 2;

                cmdUpdate.Parameters.Add("@PrecoCusto", SqlDbType.Decimal).Value = novoCustoMedio;
                cmdUpdate.Parameters["@PrecoCusto"].Precision = 18;
                cmdUpdate.Parameters["@PrecoCusto"].Scale = 4;

                cmdUpdate.Parameters.Add("@ProdutoID", SqlDbType.Int).Value = produtoID;                
                cmdUpdate.Parameters.Add("@EmpresaID", SqlDbType.Int).Value = EmpresaID;

                cmdUpdate.ExecuteNonQuery();
            }

            // 5️⃣ Inserir movimentação de estoque
            using (var cmdInsert = new SqlCommand(@"
                    INSERT INTO MovimentacaoEstoque
                    (ProdutoID,
                     TipoMovimentacao,
                     Quantidade,
                     EstoqueAnterior,
                     EstoqueAtual,
                     PrecoCompra,
                     PrecoCustoEntrada,
                     Origem,
                     Documento,
                     Observacao,
                     DataMovimentacao,
                     Usuario,
                     FornecedorID,
                     EmpresaID)
                    VALUES
                    (@ProdutoID,
                     @TipoMovimentacao,
                     @Quantidade,
                     @EstoqueAnterior,
                     @EstoqueAtual,
                     @PrecoCompra,
                     @PrecoCustoEntrada,
                     @Origem,
                     @Documento,
                     @Observacao,
                     GETDATE(),
                     @Usuario,
                     @FornecedorID,   -- ✅ AGORA CORRETO
                     @EmpresaID)",
                     connection, transaction))

            {
                cmdInsert.Parameters.Add("@ProdutoID", SqlDbType.Int).Value = produtoID;
                cmdInsert.Parameters.Add("@TipoMovimentacao", SqlDbType.VarChar, 50).Value = tipoMovimentacao;
                cmdInsert.Parameters.Add("@Quantidade", SqlDbType.Int).Value = quantidade;
                cmdInsert.Parameters.Add("@EstoqueAnterior", SqlDbType.Int).Value = estoqueAtual;
                cmdInsert.Parameters.Add("@EstoqueAtual", SqlDbType.Int).Value = estoqueNovo;

                cmdInsert.Parameters.Add("@PrecoCompra", SqlDbType.Decimal).Value = precoCompraEntrada;
                cmdInsert.Parameters["@PrecoCompra"].Precision = 18;
                cmdInsert.Parameters["@PrecoCompra"].Scale = 2;

                cmdInsert.Parameters.Add("@PrecoCustoEntrada", SqlDbType.Decimal).Value = precoCustoEntrada;
                cmdInsert.Parameters["@PrecoCustoEntrada"].Precision = 18;
                cmdInsert.Parameters["@PrecoCustoEntrada"].Scale = 4;

                cmdInsert.Parameters.Add("@Origem", SqlDbType.VarChar, 50).Value = "ENTRADA_FISCAL";
                cmdInsert.Parameters.Add("@Documento", SqlDbType.VarChar, 100).Value = documento ?? string.Empty;
                cmdInsert.Parameters.Add("@Observacao", SqlDbType.VarChar, 255).Value = observacao ?? string.Empty;
                cmdInsert.Parameters.Add("@Usuario", SqlDbType.VarChar, 100).Value = usuario ?? string.Empty;
                cmdInsert.Parameters.Add("@FornecedorID", SqlDbType.Int).Value = fornecedorId;
                cmdInsert.Parameters.Add("@EmpresaID", SqlDbType.Int).Value = EmpresaID;

                cmdInsert.ExecuteNonQuery();
            }
        }
        public void ConfirmarEntradaCompleta(
            List<(int ProdutoID, int Quantidade, decimal PrecoCompra, decimal PrecoCusto, int FornecedorID)> itens,
            string tipoMovimentacao,
            string documento,
            string observacao,
            string usuario)
        {
            using var transaction = Connection.BeginTransaction();

            try
            {
                foreach (var item in itens)
                {
                    ConfirmarEntrada(
                        item.ProdutoID,
                        item.Quantidade,
                        item.PrecoCompra,
                        item.PrecoCusto,
                        tipoMovimentacao,
                        documento,
                        observacao,
                        usuario,
                        item.FornecedorID, // ✅ CORRETO
                        transaction
                    );
                }

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public DataTable BuscarHistoricoProduto(
            int produtoId,
            DateTime dataInicial,
            DateTime dataFinal,
            string tipoMovimentacao)
        {
            using var cmd = new SqlCommand(@"
                        SELECT 
                            m.DataMovimentacao,
                            m.TipoMovimentacao,
                            m.Quantidade,
                            m.EstoqueAnterior,
                            m.EstoqueAtual,
                            m.PrecoCompra,
                            m.PrecoCustoEntrada,
                            m.Documento,
                            m.Usuario,
                            f.Nome AS Fornecedor
                        FROM MovimentacaoEstoque m
                        LEFT JOIN Fornecedor
                        f ON f.FornecedorID = m.FornecedorID
                        WHERE m.ProdutoID = @ProdutoID
                        AND m.EmpresaID = @EmpresaID
                        AND m.DataMovimentacao BETWEEN @DataInicial AND @DataFinal
                        AND (@TipoMovimentacao = 'TODOS' OR m.TipoMovimentacao = @TipoMovimentacao)
                        ORDER BY m.DataMovimentacao DESC",
                Connection);

            cmd.Parameters.AddWithValue("@ProdutoID", produtoId);
            cmd.Parameters.AddWithValue("@EmpresaID", EmpresaID);
            cmd.Parameters.AddWithValue("@DataInicial", dataInicial);
            cmd.Parameters.AddWithValue("@DataFinal", dataFinal);
            cmd.Parameters.AddWithValue("@TipoMovimentacao", tipoMovimentacao);

            using var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }




    }
}
