using GVC.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace GVC.Infra.Repository
{
    public class ItemVendaRepository : RepositoryBase
    {

        // 1. ADICIONAR ITEM NA VENDA
        public void AddItemVenda(ItemVendaModel itemVenda)
        {
            const string sql = @"
                INSERT INTO ItemVenda (
                    VendaID, ProdutoID, Quantidade, PrecoUnitario, Subtotal, DescontoItem, EmpresaID )
                VALUES (@VendaID, @ProdutoID, @Quantidade, @PrecoUnitario, @Subtotal, @DescontoItem, @EmpresaID)";

            using var cmd = CreateCommand(sql);
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
            const string sql = @"
                UPDATE ItemVenda
                SET ProdutoID = @ProdutoID,
                    Quantidade = @Quantidade,
                    PrecoUnitario = @PrecoUnitario,
                    Subtotal = @Subtotal,
                    DescontoItem = @DescontoItem
                WHERE ItemVendaID = @ItemVendaID AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
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
            using var cmd = CreateCommand(
                "DELETE FROM ItemVenda WHERE ItemVendaID = @ItemVendaID AND EmpresaID = @EmpresaID");

            cmd.Parameters.AddWithValue("@ItemVendaID", itemVendaId);
            cmd.ExecuteNonQuery();
        }

        public void Excluir(ItemVendaModel itemVenda)
            => DeleteItemVenda(itemVenda.ItemVendaID);

        // 4. LISTAR ITENS DE UMA VENDA
        public List<ItemVendaModel> ConsultarItensVenda(int vendaId)
        {
            const string sql = @"
                SELECT ItemVendaID, VendaID, ProdutoID,
                       Quantidade, PrecoUnitario, Subtotal, DescontoItem
                FROM ItemVenda
                WHERE VendaID = @VendaID AND EmpresaID = @EmpresaID
                ORDER BY ItemVendaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);

            using var dr = cmd.ExecuteReader();
            var lista = new List<ItemVendaModel>();

            while (dr.Read())
            {
                lista.Add(new ItemVendaModel
                {
                    ItemVendaID = dr.GetInt32("ItemVendaID"),
                    VendaID = dr.GetInt32("VendaID"),
                    ProdutoID = dr.GetInt32("ProdutoID"),
                    Quantidade = dr.GetInt32("Quantidade"),
                    PrecoUnitario = dr.GetDecimal("PrecoUnitario"),
                    DescontoItem = dr.IsDBNull("DescontoItem") ? 0 : dr.GetDecimal("DescontoItem")
                });
            }

            return lista;
        }

        // 5. EXCLUIR ITENS POR VENDA
        public void ExcluirItensPorVendaID(int vendaID)
        {
            using var cmd = CreateCommand(
                "DELETE FROM ItemVenda WHERE VendaID = @VendaID AND EmpresaID = @EmpresaID");

            cmd.Parameters.AddWithValue("@VendaID", vendaID);
            cmd.ExecuteNonQuery();
        }

        // 6. LISTAR ITENS (RELATÓRIOS)
        public DataTable ListarItensVenda()
        {
            using var cmd = CreateCommand("SELECT * FROM ItemVenda WHERE EmpresaID = @EmpresaID ORDER BY VendaID, ItemVendaID ");
            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // 7. BUSCAR ITEM POR ID
        public ItemVendaModel? BuscarPorId(int itemVendaId)
        {
            using var cmd = CreateCommand(
                "SELECT * FROM ItemVenda WHERE ItemVendaID = @Id AND EmpresaID = @EmpresaID");

            cmd.Parameters.AddWithValue("@Id", itemVendaId);

            using var dr = cmd.ExecuteReader();
            if (!dr.Read()) return null;

            var item = new ItemVendaModel
            {
                ItemVendaID = dr.GetInt32("ItemVendaID"),
                VendaID = dr.GetInt32("VendaID"),
                ProdutoID = dr.GetInt32("ProdutoID"),
                Quantidade = dr.GetInt32("Quantidade"),
                PrecoUnitario = dr.GetDecimal("PrecoUnitario"),
                DescontoItem = dr.IsDBNull("DescontoItem") ? 0 : dr.GetDecimal("DescontoItem")
            };

            item.AtualizarSubtotal();
            return item;
        }

        // 8. CALCULAR TOTAL DA VENDA
        public decimal CalcularTotalVenda(int vendaId)
        {
            using var cmd = CreateCommand(@"
                SELECT ISNULL(SUM((Quantidade * PrecoUnitario) - ISNULL(DescontoItem, 0)), 0)
                FROM ItemVenda
                WHERE VendaID = @VendaID AND EmpresaID = @EmpresaID");

            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            return Convert.ToDecimal(cmd.ExecuteScalar());
        }

        // 9. ITENS COM PRODUTO
        public DataTable ListarItensComProduto(int vendaId)
        {
            const string sql = @"
                SELECT iv.ItemVendaID, iv.VendaID, iv.ProdutoID,
                       p.NomeProduto AS ProdutoDescricao,
                       iv.Quantidade, iv.PrecoUnitario,
                       iv.Subtotal, iv.DescontoItem
                FROM ItemVenda iv
                INNER JOIN Produtos p ON iv.ProdutoID = p.ProdutoID
                WHERE iv.VendaID = @VendaID AND iv.EmpresaID = @EmpresaID
                ORDER BY iv.ItemVendaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);

            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // 10. LISTAR ITENS POR VENDA
        public List<ItemVendaModel> ListarItensPorVenda(long vendaId) => ConsultarItensVenda((int)vendaId);
    }
}
