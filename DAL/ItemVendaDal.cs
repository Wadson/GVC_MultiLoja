using GVC.Model;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace GVC.DALL
{
    public class ItemVendaDal
    {
        // 1. ADICIONAR ITEM NA VENDA
        public void AddItemVenda(ItemVendaModel itemVenda)
        {
            string sql = @"
                INSERT INTO ItemVenda (
                    VendaID, ProdutoID, Quantidade, PrecoUnitario, Subtotal, DescontoItem
                )
                VALUES (
                    @VendaID, @ProdutoID, @Quantidade, @PrecoUnitario, @Subtotal, @DescontoItem
                )";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", itemVenda.VendaID);
            cmd.Parameters.AddWithValue("@ProdutoID", itemVenda.ProdutoID);
            cmd.Parameters.AddWithValue("@Quantidade", itemVenda.Quantidade);
            cmd.Parameters.AddWithValue("@PrecoUnitario", itemVenda.PrecoUnitario);
            cmd.Parameters.AddWithValue("@Subtotal", itemVenda.Subtotal);
            cmd.Parameters.AddWithValue("@DescontoItem", itemVenda.DescontoItem);
            cmd.ExecuteNonQuery();
        }

        // 2. ATUALIZAR ITEM DA VENDA
        public void UpdateItemVenda(ItemVendaModel itemVenda)
        {
            string sql = @"
                UPDATE ItemVenda
                SET ProdutoID = @ProdutoID,
                    Quantidade = @Quantidade,
                    PrecoUnitario = @PrecoUnitario,
                    Subtotal = @Subtotal,
                    DescontoItem = @DescontoItem
                WHERE ItemVendaID = @ItemVendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ItemVendaID", itemVenda.ItemVendaID);
            cmd.Parameters.AddWithValue("@ProdutoID", itemVenda.ProdutoID);
            cmd.Parameters.AddWithValue("@Quantidade", itemVenda.Quantidade);
            cmd.Parameters.AddWithValue("@PrecoUnitario", itemVenda.PrecoUnitario);
            cmd.Parameters.AddWithValue("@Subtotal", itemVenda.Subtotal);
            cmd.Parameters.AddWithValue("@DescontoItem", itemVenda.DescontoItem);
            cmd.ExecuteNonQuery();
        }

        // 3. EXCLUIR ITEM POR ID
        public void DeleteItemVenda(long itemVendaId)
        {
            string sql = "DELETE FROM ItemVenda WHERE ItemVendaID = @ItemVendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ItemVendaID", itemVendaId);
            cmd.ExecuteNonQuery();
        }

        public void Excluir(ItemVendaModel itemVenda) => DeleteItemVenda(itemVenda.ItemVendaID);

        // 4. LISTAR TODOS OS ITENS DE UMA VENDA
        public List<ItemVendaModel> ConsultarItensVenda(int vendaId)
        {
            string sql = @"
        SELECT ItemVendaID,
               VendaID,
               ProdutoID,
               Quantidade,
               PrecoUnitario,
               Subtotal,
               DescontoItem
        FROM ItemVenda
        WHERE VendaID = @VendaID
        ORDER BY ItemVendaID";

            var lista = new List<ItemVendaModel>();

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var quantidade = reader.GetInt32("Quantidade");
                var precoUnitario = reader.GetDecimal("PrecoUnitario");
                var descontoItem = reader.IsDBNull("DescontoItem") ? 0m : reader.GetDecimal("DescontoItem");

                var item = new ItemVendaModel
                {
                    ItemVendaID = reader.GetInt32("ItemVendaID"),
                    VendaID = reader.GetInt32("VendaID"),
                    ProdutoID = reader.GetInt32("ProdutoID"),
                    Quantidade = quantidade,
                    PrecoUnitario = precoUnitario,
                    DescontoItem = descontoItem
                };

                // ✅ Calcula Subtotal automaticamente
                lista.Add(item);
            }
            return lista;
        }

        // 5. EXCLUIR TODOS OS ITENS DE UMA VENDA
        public void ExcluirItensPorVendaID(int vendaID)
        {
            string sql = "DELETE FROM ItemVenda WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaID);
            cmd.ExecuteNonQuery();
        }

        // 6. LISTAR TODOS OS ITENS (para relatórios)
        public DataTable ListarItensVenda()
        {
            string sql = "SELECT * FROM ItemVenda ORDER BY VendaID, ItemVendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            var dt = new DataTable();
            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        // 7. BUSCAR ITEM POR ID
        public ItemVendaModel? BuscarPorId(int itemVendaId)
        {
            string sql = "SELECT * FROM ItemVenda WHERE ItemVendaID = @Id";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", itemVendaId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var quantidade = reader.GetInt32("Quantidade");
                var precoUnitario = reader.GetDecimal("PrecoUnitario");
                var descontoItem = reader.IsDBNull("DescontoItem") ? 0m : reader.GetDecimal("DescontoItem");

                // ✅ Criar item primeiro
                var item = new ItemVendaModel
                {
                    ItemVendaID = reader.GetInt32("ItemVendaID"),
                    VendaID = reader.GetInt32("VendaID"),
                    ProdutoID = reader.GetInt32("ProdutoID"),
                    Quantidade = quantidade,
                    PrecoUnitario = precoUnitario,
                    DescontoItem = descontoItem
                };

                // ✅ Calcular subtotal usando método interno
                item.AtualizarSubtotal();

                return item;
            }
            return null;
        }


        // 8. CALCULAR TOTAL DA VENDA
        public decimal CalcularTotalVenda(int vendaId)
        {
            string sql = @"
                SELECT ISNULL(SUM((Quantidade * PrecoUnitario) - ISNULL(DescontoItem, 0)), 0)
                FROM ItemVenda
                WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            return (decimal)cmd.ExecuteScalar();
        }

        // 9. LISTAR ITENS COM DADOS DO PRODUTO
        public DataTable ListarItensComProduto(int vendaId)
        {
            string sql = @"
                SELECT
                    iv.ItemVendaID,
                    iv.VendaID,
                    iv.ProdutoID,
                    p.NomeProduto AS ProdutoDescricao,
                    p.CodigoBarras,
                    iv.Quantidade,
                    iv.PrecoUnitario,
                    iv.Subtotal,
                    iv.DescontoItem,
                    (iv.Quantidade * iv.PrecoUnitario - ISNULL(iv.DescontoItem, 0)) AS TotalItem
                FROM ItemVenda iv
                INNER JOIN Produtos p ON iv.ProdutoID = p.ProdutoID
                WHERE iv.VendaID = @VendaID
                ORDER BY iv.ItemVendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            var dt = new DataTable();
            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        // 10. LISTAR ITENS POR VENDA COM NOME DO PRODUTO
        public List<ItemVendaModel> ListarItensPorVenda(long vendaId)
        {
            string sql = @"
        SELECT
            iv.ItemVendaID,
            iv.VendaID,
            iv.ProdutoID,
            p.NomeProduto AS ProdutoDescricao,
            iv.Quantidade,
            iv.PrecoUnitario,
            iv.DescontoItem
        FROM ItemVenda iv
        INNER JOIN Produtos p ON iv.ProdutoID = p.ProdutoID
        WHERE iv.VendaID = @VendaID
        ORDER BY iv.ItemVendaID";

            var itens = new List<ItemVendaModel>();

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var quantidade = reader.GetInt32("Quantidade");
                var precoUnitario = reader.GetDecimal("PrecoUnitario");
                var descontoItem = reader.IsDBNull("DescontoItem") ? 0m : reader.GetDecimal("DescontoItem");

                var item = new ItemVendaModel
                {
                    ItemVendaID = reader.GetInt32("ItemVendaID"),
                    VendaID = reader.GetInt32("VendaID"),
                    ProdutoID = reader.GetInt32("ProdutoID"),
                    Quantidade = quantidade,
                    PrecoUnitario = precoUnitario,
                    DescontoItem = descontoItem,
                    ProdutoDescricao = reader.IsDBNull("ProdutoDescricao") ? string.Empty : reader.GetString("ProdutoDescricao")
                };

                // ✅ Subtotal será calculado automaticamente pelo model
                itens.Add(item);
            }
            return itens;
        }
        public void ExcluirPorVenda(long vendaId)
        {
            string sql = "DELETE FROM ItemVenda WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.ExecuteNonQuery();
        }
    }
}