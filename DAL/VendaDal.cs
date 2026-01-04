using GVC.Model;
using GVC.Model.Enums;
using GVC.Model.Extensions;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GVC.DALL
{
    public class VendaDal
    {
        public int AddVendaCompleta(VendaModel venda, List<ItemVendaModel> itens, List<ParcelaModel> parcelas = null)
        {
            string sqlVenda = @"
                INSERT INTO Venda (DataVenda, ClienteID, ValorTotal, FormaPgtoID, Desconto, Observacoes, StatusVenda, VendedorID)
                VALUES (@DataVenda, @ClienteID, @ValorTotal, @FormaPgtoID, @Desconto, @Observacoes, @StatusVenda, @VendedorID);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            string sqlItem = @" INSERT INTO ItemVenda (VendaID, ProdutoID, Quantidade, PrecoUnitario, Subtotal, DescontoItem)
            VALUES (@VendaID, @ProdutoID, @Quantidade, @PrecoUnitario, CAST(@Quantidade AS DECIMAL(18,2)) * @PrecoUnitario, @DescontoItem)";

            string sqlParcela = @"
                INSERT INTO Parcela (VendaID, NumeroParcela, DataVencimento, ValorParcela, ValorRecebido,
                                     Status, DataPagamento, Juros, Multa, Observacao)
                VALUES (@VendaID, @NumeroParcela, @DataVencimento, @ValorParcela, @ValorRecebido,
                        @Status, @DataPagamento, @Juros, @Multa, @Observacao)";

            string sqlBaixarEstoque = @" UPDATE Produtos 
                                         SET Estoque = Estoque - @Quantidade
                                         WHERE ProdutoID = @ProdutoID AND Estoque >= @Quantidade";


            using var conn = Conexao.Conex();
            conn.Open();
            using var transaction = conn.BeginTransaction();

            try
            {
                // 1️⃣ Inserir Venda e obter o ID gerado
                using (var cmdVenda = new SqlCommand(sqlVenda, conn, transaction))
                {
                    cmdVenda.Parameters.AddWithValue("@DataVenda", venda.DataVenda);
                    cmdVenda.Parameters.AddWithValue("@ClienteID", venda.ClienteID);
                    cmdVenda.Parameters.AddWithValue("@ValorTotal", venda.ValorTotal);
                    cmdVenda.Parameters.AddWithValue("@FormaPgtoID",venda.FormaPgtoID ?? (object)DBNull.Value);
                    cmdVenda.Parameters.AddWithValue("@Desconto", venda.Desconto);                    
                    cmdVenda.Parameters.AddWithValue("@Observacoes", (object)venda.Observacoes ?? DBNull.Value);
                    cmdVenda.Parameters.AddWithValue("@StatusVenda", venda.StatusVenda.ToDb());
                    cmdVenda.Parameters.AddWithValue("@VendedorID", venda.VendedorID);

                    int vendaId = (int)cmdVenda.ExecuteScalar();

                    // 2️⃣ Inserir Itens
                    if (itens != null && itens.Any())
                    {
                        // NO VendaDal, método AddVendaCompleta:
                        foreach (var item in itens)
                        {
                            item.VendaID = vendaId;
                                                       
                            // Atualiza o subtotal internamente
                            item.AtualizarSubtotal();

                            using var cmdItem = new SqlCommand(sqlItem, conn, transaction);
                            cmdItem.Parameters.AddWithValue("@VendaID", item.VendaID);
                            cmdItem.Parameters.AddWithValue("@ProdutoID", item.ProdutoID);
                            cmdItem.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                            cmdItem.Parameters.AddWithValue("@PrecoUnitario", item.PrecoUnitario);
                            cmdItem.Parameters.AddWithValue("@Subtotal", item.Subtotal); // já calculado
                            // ⭐⭐ SOLUÇÃO DEFINITIVA PARA DescontoItem nullable ⭐⭐
                            decimal descontoItemValor = (decimal)item.DescontoItem;
                            cmdItem.Parameters.AddWithValue("@DescontoItem", descontoItemValor);

                            cmdItem.ExecuteNonQuery();

                            using var cmdEstoque = new SqlCommand(sqlBaixarEstoque, conn, transaction);
                            cmdEstoque.Parameters.AddWithValue("@ProdutoID", item.ProdutoID);
                            cmdEstoque.Parameters.AddWithValue("@Quantidade", item.Quantidade);

                            int linhasAfetadas = cmdEstoque.ExecuteNonQuery();

                            if (linhasAfetadas == 0)
                            {
                                throw new Exception(
                                    $"Estoque insuficiente para o produto ID {item.ProdutoID}."
                                );
                            }

                        }
                    }

                    // 3️⃣ Inserir Parcelas
                    if (parcelas != null && parcelas.Any())
                    {
                        foreach (var p in parcelas)
                        {
                            p.VendaID = vendaId;
                            using var cmdParcela = new SqlCommand(sqlParcela, conn, transaction);
                           
                            cmdParcela.Parameters.AddWithValue("@VendaID", p.VendaID);
                            cmdParcela.Parameters.AddWithValue("@NumeroParcela", p.NumeroParcela);
                            cmdParcela.Parameters.AddWithValue("@DataVencimento", p.DataVencimento);

                            cmdParcela.Parameters.Add("@ValorParcela", SqlDbType.Decimal).Value = Math.Round(p.ValorParcela, 2, MidpointRounding.AwayFromZero);
                            cmdParcela.Parameters["@ValorParcela"].Precision = 18;
                            cmdParcela.Parameters["@ValorParcela"].Scale = 2;

                            cmdParcela.Parameters.Add("@ValorRecebido", SqlDbType.Decimal).Value =
                                p.ValorRecebido.HasValue ? Math.Round(Math.Min(p.ValorRecebido.Value, p.ValorParcela), 2, MidpointRounding.AwayFromZero) : (object)DBNull.Value;
                            cmdParcela.Parameters["@ValorRecebido"].Precision = 18;
                            cmdParcela.Parameters["@ValorRecebido"].Scale = 2;


                            // Status
                            cmdParcela.Parameters.AddWithValue("@Status", p.Status.ToDb());

                            // DataPagamento
                            cmdParcela.Parameters.AddWithValue("@DataPagamento", (object?)p.DataPagamento ?? DBNull.Value);

                            // Juros e Multa (somente uma vez, usando null quando zero)
                            cmdParcela.Parameters.AddWithValue("@Juros", p.Juros == 0 ? (object)DBNull.Value : p.Juros);
                            cmdParcela.Parameters.AddWithValue("@Multa", p.Multa == 0 ? (object)DBNull.Value : p.Multa);

                            // Observacao
                            cmdParcela.Parameters.AddWithValue("@Observacao", (object?)p.Observacao ?? DBNull.Value);
                                                        
                            cmdParcela.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    return vendaId;
                }
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public void UpdateVenda(VendaModel venda)
        {
            string sql = @"
                UPDATE Venda
                SET DataVenda = @DataVenda,
                    ClienteID = @ClienteID,
                    ValorTotal = @ValorTotal,
                    FormaPgtoID = @FormaPgtoID,
                    Desconto = @Desconto,
                    Observacoes = @Observacoes,
                    StatusVenda = @StatusVenda
                    VendedorID = @VendedorID
                WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", venda.VendaID);
            cmd.Parameters.AddWithValue("@DataVenda", venda.DataVenda);
            cmd.Parameters.AddWithValue("@ClienteID", venda.ClienteID);
            cmd.Parameters.AddWithValue("@ValorTotal", venda.ValorTotal);
            cmd.Parameters.AddWithValue("@FormaPgtoID", venda.FormaPgtoID);
            cmd.Parameters.AddWithValue("@Desconto", venda.Desconto == 0 ? (object)DBNull.Value : venda.Desconto);
            cmd.Parameters.AddWithValue("@Observacoes", (object)venda.Observacoes ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@StatusVenda", (object)venda.StatusVenda ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@VendedorID",venda.VendedorID);
            cmd.ExecuteNonQuery();
        }

        public void DeleteVenda(long vendaId)
        {
            using var conn = Conexao.Conex();
            conn.Open();
            using var trans = conn.BeginTransaction();
            try
            {
                using var cmd1 = new SqlCommand("DELETE FROM ItemVenda WHERE VendaID = @Id", conn, trans);
                cmd1.Parameters.AddWithValue("@Id", vendaId);
                cmd1.ExecuteNonQuery();

                using var cmd2 = new SqlCommand("DELETE FROM Parcela WHERE VendaID = @Id", conn, trans);
                cmd2.Parameters.AddWithValue("@Id", vendaId);
                cmd2.ExecuteNonQuery();

                using var cmd3 = new SqlCommand("DELETE FROM Venda WHERE VendaID = @Id", conn, trans);
                cmd3.Parameters.AddWithValue("@Id", vendaId);
                cmd3.ExecuteNonQuery();

                trans.Commit();
            }
            catch
            {
                trans.Rollback();
                throw;
            }
        }

        public void DeleteVenda(VendaModel venda) => DeleteVenda(venda.VendaID);

        public VendaModel? GetVenda(long vendaId)
        {
            string sql = "SELECT * FROM Venda WHERE VendaID = @VendaID";
            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new VendaModel
                {
                    VendaID = reader.GetInt32("VendaID"),
                    DataVenda = reader.GetDateTime("DataVenda"),
                    ClienteID = reader.GetInt32("ClienteID"),
                    ValorTotal = reader.GetDecimal("ValorTotal"),
                    FormaPgtoID = reader.GetInt32("FormaPgtoID"),
                    Desconto = (decimal)(reader.IsDBNull("Desconto") ? (decimal?)null : reader.GetDecimal("Desconto")),
                    Observacoes = reader.IsDBNull("Observacoes") ? null : reader.GetString("Observacoes") as string,
                    StatusVenda = reader.IsDBNull("StatusVenda")? EnumStatusVenda.Aberta : reader.GetString("StatusVenda").ToEnumStatusVenda(),

                    VendedorID = reader.GetInt32("VendedorID")
                };
            }
            return null;
        }

        public DataTable ListarVendas()
        {
            string sql = @"SELECT
        v.VendaID,
        v.DataVenda,
        c.Nome AS Cliente,
        v.ValorTotal,
        v.Desconto,
        v.Observacoes,
        v.StatusVenda,
        v.VendedorID,
        f.NomeFormaPagamento AS NomeFormaPagamento
    FROM Venda v
    INNER JOIN Cliente c ON v.ClienteID = c.ClienteID
    LEFT JOIN FormaPagamento f ON v.FormaPgtoID = f.FormaPgtoID
    ORDER BY v.DataVenda DESC";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            var dt = new DataTable();
            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }


        public DataTable VendaLocalizarPorCliente(long clienteId)
        {
            string sql = @" SELECT
                v.VendaID,
                v.DataVenda,
                v.ValorTotal,
                v.Desconto,
                v.Observacoes,
                v.StatusVenda,
                v.VendedorID
                f.NomeFormaPagamento AS NomeFormaPagamento
            FROM Venda v
            LEFT JOIN FormaPagamento f ON v.FormaPgtoID = f.FormaPgtoID
            WHERE v.ClienteID = @ClienteID
            ORDER BY v.DataVenda DESC";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ClienteID", clienteId);
            var dt = new DataTable();
            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        public DataTable RelatorioVendasPorPeriodo(DateTime inicio, DateTime fim)
        {
            string sql = @" SELECT
                v.VendaID,
                v.DataVenda,
                c.Nome,
                v.ValorTotal,
                v.Desconto,
                v.Observacoes,
                v.StatusVenda,
                v.VendedorID
                f.NomeFormaPagamento AS NomeFormaPagamento
            FROM Venda v
            INNER JOIN Cliente c ON v.ClienteID = c.ClienteID
            LEFT JOIN FormaPagamento f ON v.FormaPgtoID = f.FormaPgtoID
            WHERE v.DataVenda BETWEEN @Inicio AND @Fim
            ORDER BY v.DataVenda DESC";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Inicio", inicio.Date);
            cmd.Parameters.AddWithValue("@Fim", fim.Date.AddDays(1).AddSeconds(-1));
            var dt = new DataTable();
            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        public decimal TotalVendidoHoje()
        {
            string sql = @" SELECT COALESCE(SUM(ValorTotal), 0)
                            FROM Venda 
                            WHERE CAST(DataVenda AS DATE) = CAST(GETDATE() AS DATE)";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            return (decimal)cmd.ExecuteScalar();
        }

        public int UltimaVendaId()
        {
            string sql = "SELECT ISNULL(MAX(VendaID), 0) FROM Venda";
            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            return (int)cmd.ExecuteScalar();
        }
        public void AtualizarStatusVenda(long vendaId, string novoStatus)
        {
            string sql = @"UPDATE Venda SET StatusVenda = @Status WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.Parameters.AddWithValue("@Status", novoStatus);
            cmd.ExecuteNonQuery();
        }

        public void AtualizarStatusVenda(long vendaId, string novoStatus, string motivo)
        {
            string sql = @"
        UPDATE Venda 
        SET StatusVenda = @Status,
            Observacoes =
                CASE 
                    WHEN Observacoes IS NULL OR Observacoes = ''
                        THEN @Motivo
                    ELSE Observacoes + CHAR(13) + CHAR(10) + @Motivo
                END
        WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.Parameters.AddWithValue("@Status", novoStatus);
            cmd.Parameters.AddWithValue("@Motivo", $"CANCELAMENTO: {motivo}");
            cmd.ExecuteNonQuery();
        }

        public VendaModel ObterVendaPorId(long vendaId)
        {
            string sql = @" SELECT
    v.VendaID,
    v.ClienteID,
    v.FormaPgtoID,
    v.DataVenda,
    v.ValorTotal,
    v.Desconto,
    v.Observacoes,
    v.StatusVenda,
    v.VendedorID,
    c.Nome AS NomeCliente
FROM Venda v
LEFT JOIN Clientes c ON c.ClienteID = v.ClienteID
WHERE v.VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var venda = new VendaModel
                {
                    VendaID = reader.GetInt32("VendaID"),
                    ClienteID = reader.GetInt32("ClienteID"),
                    FormaPgtoID = reader.GetInt32("FormaPgtoID"),
                    DataVenda = reader.GetDateTime("DataVenda"),
                    ValorTotal = reader.GetDecimal("ValorTotal"),
                    Desconto = (decimal)(reader.IsDBNull("Desconto") ? (decimal?)null : reader.GetDecimal("Desconto")),
                    Observacoes = reader.IsDBNull("Observacoes") ? null : reader.GetString("Observacoes") as string,
                    //StatusVenda Corrigido da Forma Correta em 02/01/2026 use Este MODELO
                    StatusVenda = reader.IsDBNull("StatusVenda") ? EnumStatusVenda.Aberta
                    : Enum.Parse<EnumStatusVenda>(reader.GetString("StatusVenda").Replace(" ", "")),

                    VendedorID = reader.GetInt32("VendedorID")
                };

                return venda;
            }
            return null;
        }
        public void Excluir(long vendaID)
        {
            using var conn = Conexao.Conex();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Venda WHERE VendaID = @id";
            cmd.Parameters.AddWithValue("@id", vendaID);
            cmd.ExecuteNonQuery();
        }
    }
}