using GVC.Model;
using GVC.Model.Enums;
using GVC.Model.Extensions;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GVC.DAL
{
    public class VendaDal
    {
        #region =========================
        #region INSERÇÃO / ATUALIZAÇÃO
        #endregion
        #endregion

        // ======================================================
        // 🔹 INSERIR VENDA COMPLETA (VENDA + ITENS + PARCELAS)
        // ======================================================
        public int AddVendaCompleta(
            VendaModel venda,
            List<ItemVendaModel> itens,
            List<ParcelaModel>? parcelas = null)
        {
            const string sqlVenda = @"
                INSERT INTO Venda
                (DataVenda, ClienteID, ValorTotal, FormaPgtoID, Desconto, Observacoes, StatusVenda, VendedorID)
                VALUES
                (@DataVenda, @ClienteID, @ValorTotal, @FormaPgtoID, @Desconto, @Observacoes, @StatusVenda, @VendedorID);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            const string sqlItem = @"
                INSERT INTO ItemVenda
                (VendaID, ProdutoID, Quantidade, PrecoUnitario, Subtotal, DescontoItem)
                VALUES
                (@VendaID, @ProdutoID, @Quantidade, @PrecoUnitario, @Subtotal, @DescontoItem)";

            const string sqlParcela = @"
                INSERT INTO Parcela
                (VendaID, NumeroParcela, DataVencimento, ValorParcela, ValorRecebido,
                 Status, DataPagamento, Juros, Multa, Observacao)
                VALUES
                (@VendaID, @NumeroParcela, @DataVencimento, @ValorParcela, @ValorRecebido,
                 @Status, @DataPagamento, @Juros, @Multa, @Observacao)";

            const string sqlBaixarEstoque = @"
                UPDATE Produtos
                SET Estoque = Estoque - @Quantidade
                WHERE ProdutoID = @ProdutoID
                  AND Estoque >= @Quantidade";

            using var conn = Conexao.Conex();
            conn.Open();
            using var tran = conn.BeginTransaction();

            try
            {
                // 1️⃣ VENDA
                int vendaId;
                using (var cmd = new SqlCommand(sqlVenda, conn, tran))
                {
                    cmd.Parameters.AddWithValue("@DataVenda", venda.DataVenda);
                    cmd.Parameters.AddWithValue("@ClienteID", venda.ClienteID);
                    cmd.Parameters.AddWithValue("@ValorTotal", venda.ValorTotal);
                    cmd.Parameters.AddWithValue("@FormaPgtoID", venda.FormaPgtoID ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Desconto", venda.Desconto ?? (object)DBNull.Value);

                    cmd.Parameters.AddWithValue("@Observacoes", (object?)venda.Observacoes ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@StatusVenda", venda.StatusVenda.ToDb());
                    cmd.Parameters.AddWithValue("@VendedorID", venda.VendedorID);

                    vendaId = (int)cmd.ExecuteScalar();
                }

                // 2️⃣ ITENS + ESTOQUE
                foreach (var item in itens)
                {
                    item.VendaID = vendaId;
                    item.AtualizarSubtotal();

                    using (var cmd = new SqlCommand(sqlItem, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@VendaID", vendaId);
                        cmd.Parameters.AddWithValue("@ProdutoID", item.ProdutoID);
                        cmd.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                        cmd.Parameters.AddWithValue("@PrecoUnitario", item.PrecoUnitario);
                        cmd.Parameters.AddWithValue("@Subtotal", item.Subtotal);                        
                        cmd.Parameters.AddWithValue("@DescontoItem", item.DescontoItem ?? (object)DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }

                    using (var cmd = new SqlCommand(sqlBaixarEstoque, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@ProdutoID", item.ProdutoID);
                        cmd.Parameters.AddWithValue("@Quantidade", item.Quantidade);

                        if (cmd.ExecuteNonQuery() == 0)
                            throw new Exception($"Estoque insuficiente para o produto {item.ProdutoID}");
                    }
                }

                // 3️⃣ PARCELAS
                if (parcelas != null)
                {
                    foreach (var p in parcelas)
                    {
                        p.VendaID = vendaId;

                        using var cmd = new SqlCommand(sqlParcela, conn, tran);
                        cmd.Parameters.AddWithValue("@VendaID", vendaId);
                        cmd.Parameters.AddWithValue("@NumeroParcela", p.NumeroParcela);
                        cmd.Parameters.AddWithValue("@DataVencimento", p.DataVencimento);
                        cmd.Parameters.AddWithValue("@ValorParcela", p.ValorParcela);
                        cmd.Parameters.AddWithValue("@ValorRecebido", (object?)p.ValorRecebido ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Status", p.Status.ToDb());
                        cmd.Parameters.AddWithValue("@DataPagamento", (object?)p.DataPagamento ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Juros", p.Juros == 0 ? DBNull.Value : p.Juros);
                        cmd.Parameters.AddWithValue("@Multa", p.Multa == 0 ? DBNull.Value : p.Multa);
                        cmd.Parameters.AddWithValue("@Observacao", (object?)p.Observacao ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                tran.Commit();
                return vendaId;
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }

        // ======================================================
        // 🔹 ATUALIZAR VENDA (CABEÇALHO)
        // ======================================================
        public void UpdateVenda(VendaModel venda)
        {
            const string sql = @"
                UPDATE Venda
                SET ClienteID   = @ClienteID,
                    FormaPgtoID = @FormaPgtoID,
                    DataVenda   = @DataVenda,
                    ValorTotal  = @ValorTotal,
                    Desconto    = @Desconto,
                    Observacoes = @Observacoes,
                    StatusVenda = @StatusVenda,
                    VendedorID  = @VendedorID
                WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@VendaID", venda.VendaID);
            cmd.Parameters.AddWithValue("@ClienteID", venda.ClienteID);
            cmd.Parameters.AddWithValue("@FormaPgtoID", venda.FormaPgtoID ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@DataVenda", venda.DataVenda);
            cmd.Parameters.AddWithValue("@ValorTotal", venda.ValorTotal);
            cmd.Parameters.AddWithValue("@Desconto", venda.Desconto ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Observacoes", (object?)venda.Observacoes ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@StatusVenda", venda.StatusVenda.ToDb());
            cmd.Parameters.AddWithValue("@VendedorID", venda.VendedorID);

            cmd.ExecuteNonQuery();
        }

        #region =========================
        #region CONSULTAS
        #endregion
        #endregion

        // ======================================================
        // 🔹 VENDA COMPLETA (VENDA + ITENS + PARCELAS)
        // ======================================================
       
        public void Excluir(int vendaID)
        {
            using var conn = Conexao.Conex();
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Venda WHERE VendaID = @id";
            cmd.Parameters.AddWithValue("@id", vendaID);
            cmd.ExecuteNonQuery();
        }
        public void AtualizarStatusVenda(int vendaId, EnumStatusVenda status)
        {
            const string sql = @"
        UPDATE Venda 
        SET StatusVenda = @Status
        WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.Parameters.AddWithValue("@Status", status.ToDb());
            cmd.ExecuteNonQuery();
        }

        public void AtualizarStatusVenda(int vendaId, string novoStatus, string motivo)
        {
            const string sql = @"
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
            cmd.Parameters.AddWithValue("@Motivo", motivo);
            cmd.ExecuteNonQuery();
        }
        public VendaModel? ObterPorId(int vendaId)
        {
            const string sql = @"
        SELECT
            VendaID,
            ClienteID,
            FormaPgtoID,
            DataVenda,
            ValorTotal,
            Desconto,
            Observacoes,
            StatusVenda,
            VendedorID
        FROM Venda
        WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read())
                return null;

            return new VendaModel
            {
                VendaID = reader.GetInt32("VendaID"),
                ClienteID = reader.GetInt32("ClienteID"),
                FormaPgtoID = reader.IsDBNull("FormaPgtoID")
                    ? null
                    : reader.GetInt32("FormaPgtoID"),
                DataVenda = reader.GetDateTime("DataVenda"),
                ValorTotal = reader.GetDecimal("ValorTotal"),
                Desconto = reader.IsDBNull("Desconto") ? 0 : reader.GetDecimal("Desconto"),
                Observacoes = reader.IsDBNull("Observacoes") ? null : reader.GetString("Observacoes"),
                StatusVenda = reader
                    .GetString("StatusVenda")
                    .ToEnumStatusVenda(),
                VendedorID = reader.IsDBNull("VendedorID")
                    ? null
                    : reader.GetInt32("VendedorID")
            };
        }
        public VendaModel ObterVendaCompleta(int vendaId)
        {
            var venda = new VendaModel
            {
                ItemVenda = new List<ItemVendaModel>(),
                Parcelas = new List<ParcelaModel>(),
                Cliente = new ClienteModel()
            };

            using var conn = Conexao.Conex();
            conn.Open();

            // =========================
            // VENDA + CLIENTE
            // =========================
            string sqlVenda = @"
       SELECT
    v.VendaID,
    v.DataVenda,
    v.ClienteID,
    c.Nome AS ClienteNome,
    c.Cpf AS CpfCliente,
    v.Desconto,
    v.Observacoes,
    v.FormaPgtoID,
    v.VendedorID,
    vend.Nome AS VendedorNome
FROM Venda v
INNER JOIN Clientes c 
    ON c.ClienteID = v.ClienteID
INNER JOIN Clientes vend 
    ON vend.ClienteID = v.VendedorID AND vend.IsVendedor = 1
WHERE v.VendaID = @VendaID";

            using (var cmd = new SqlCommand(sqlVenda, conn))
            {
                cmd.Parameters.AddWithValue("@VendaID", vendaId);

                using var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    venda.VendaID = (int)dr["VendaID"];
                    venda.DataVenda = (DateTime)dr["DataVenda"];
                    venda.ClienteID = (int)dr["ClienteID"];
                    venda.NomeCliente = dr["ClienteNome"].ToString();   
                    venda.Desconto = dr["Desconto"] == DBNull.Value ? 0m: (decimal)dr["Desconto"];
                    venda.Observacoes = dr["Observacoes"]?.ToString();
                    venda.FormaPgtoID = (int)dr["FormaPgtoID"];
                    venda.StatusVenda = dr["StatusVenda"].ToString().ToEnumStatusVenda();
                    // 🔹 Novos campos do vendedor
                    venda.VendedorID = (int)dr["VendedorID"];
                    venda.Vendedor = new ClienteModel
                    {
                        ClienteID = (int)dr["VendedorID"],
                        Nome = dr["VendedorNome"].ToString()
                    };
                }
            }


            // =========================
            // ITENS
            // =========================
            string sqlItens = @"
        SELECT
            iv.ProdutoID,
            p.NomeProduto AS ProdutoDescricao,
            iv.Quantidade,
            iv.PrecoUnitario,
            iv.Subtotal,
            iv.DescontoItem
        FROM ItemVenda iv
        INNER JOIN Produtos p ON p.ProdutoID = iv.ProdutoID
        WHERE iv.VendaID = @VendaID";

            using (var cmd = new SqlCommand(sqlItens, conn))
            {
                cmd.Parameters.AddWithValue("@VendaID", vendaId);
                using var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    venda.ItemVenda.Add(new ItemVendaModel
                    {
                        ProdutoID = (int)dr["ProdutoID"],
                        ProdutoDescricao = dr["ProdutoDescricao"].ToString(),
                        Quantidade = (int)dr["Quantidade"],
                        PrecoUnitario = (decimal)dr["PrecoUnitario"],
                        //Subtotal = (decimal)dr["Subtotal"],
                        DescontoItem = dr["DescontoItem"] == DBNull.Value? 0m : (decimal)dr["DescontoItem"]

                    });
                }
            }

            // =========================
            // PARCELAS
            // =========================
            string sqlParcelas = @"SELECT * FROM Parcela WHERE VendaID = @VendaID";
            using (var cmd = new SqlCommand(sqlParcelas, conn))
            {
                cmd.Parameters.AddWithValue("@VendaID", vendaId);
                using var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    venda.Parcelas.Add(new ParcelaModel
                    {
                        ParcelaID = (int)dr["ParcelaID"],
                        NumeroParcela = (int)dr["NumeroParcela"],
                        DataVencimento = (DateTime)dr["DataVencimento"],
                        ValorParcela = (decimal)dr["ValorParcela"],
                        ValorRecebido = dr["ValorRecebido"] == DBNull.Value ? 0 : (decimal)dr["ValorRecebido"],
                        Juros = dr["Juros"] == DBNull.Value ? 0 : (decimal)dr["Juros"],
                        Multa = dr["Multa"] == DBNull.Value ? 0 : (decimal)dr["Multa"],
                        Status = dr["Status"].ToString().ToEnumStatusParcela()
                    });

                }
            }

            return venda;
        }
        public void AtualizarVendaCompleta(VendaModel venda, List<ItemVendaModel> itens, List<ParcelaModel> parcelas)
        {
            using var conn = Conexao.Conex();
            conn.Open();

            using var tran = conn.BeginTransaction();

            try
            {
                // 1️⃣ Atualiza cabeçalho da venda
                AtualizarVenda(venda, conn, tran);

                if (itens.Any())
                {
                    throw new Exception( "Edição de itens não permitida nesta operação.\n" +
                        "Cancele a venda e gere uma nova.");
                }
                if (parcelas.Any(p => p.ValorRecebido > 0))
                {
                    throw new Exception("Não é possível alterar parcelas com pagamentos registrados.");
                }

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
        private void AtualizarVenda( VendaModel venda, SqlConnection conn, SqlTransaction tran)
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
            cmd.Parameters.AddWithValue("@Desconto", venda.Desconto ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Observacoes", (object)venda.Observacoes ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@StatusVenda", venda.StatusVenda.ToDb());


            cmd.ExecuteNonQuery();
        }
        private void ExcluirItens(
           int vendaId,
           SqlConnection conn,
           SqlTransaction tran)
        {
            string sql = "DELETE FROM ItemVenda WHERE VendaID = @VendaID";

            using var cmd = new SqlCommand(sql, conn, tran);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.ExecuteNonQuery();
        }

        private void InserirItens(
            int vendaId,
            List<ItemVendaModel> itens,
            SqlConnection conn,
            SqlTransaction tran)
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
                cmd.Parameters.AddWithValue("@Subtotal", item.Subtotal);
                cmd.Parameters.AddWithValue("@DescontoItem", item.DescontoItem);

                cmd.ExecuteNonQuery();
            }
        }

        private void ExcluirParcelas(
            int vendaId,
            SqlConnection conn,
            SqlTransaction tran)
        {
            string sql = "DELETE FROM Parcela WHERE VendaID = @VendaID";

            using var cmd = new SqlCommand(sql, conn, tran);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.ExecuteNonQuery();
        }

        private void InserirParcelas(
            int vendaId,
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
                cmd.Parameters.AddWithValue("@Status", p.Status.ToDb());
                cmd.Parameters.AddWithValue("@DataPagamento", (object)p.DataPagamento ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Juros", p.Juros);
                cmd.Parameters.AddWithValue("@Multa", p.Multa);
                cmd.Parameters.AddWithValue("@Observacao", (object)p.Observacao ?? DBNull.Value);

                cmd.ExecuteNonQuery();
            }
        }
    }

}
