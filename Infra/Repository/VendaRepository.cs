using GVC.Model;
using GVC.Model.Enums;
using GVC.Model.Enums.GVC.Model.Enums;
using GVC.Model.Extensions;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GVC.Infra.Repository
{
    public class VendaRepository : RepositoryBase
    {
        // ✅ mantém o padrão (usa conexão interna do RepositoryBase)
        public VendaRepository() : base() { }

        // ✅ permite usar conexão externa + transação única
        public VendaRepository(SqlConnection connection) : base(connection) { }
      
        public int ObterProximoNumeroVenda()
        {
            const string sql = @"  SELECT ISNULL(MAX(VendaID), 0) + 1  FROM Venda WHERE EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        // ======================================================
        // 🔹 INSERIR VENDA COMPLETA
        // ======================================================
        public int AddVendaCompleta(
            VendaModel venda,
            List<ItemVendaModel> itens,
            List<ParcelaModel>? parcelas = null)
        {
            using var tran = Connection.BeginTransaction();

            try
            {
                BlindarStatusVenda(venda, parcelas);

                int vendaId = InserirVenda(venda, tran);

                InserirItensEBaixarEstoque(vendaId, itens, tran);

                if (parcelas != null && parcelas.Any())
                    InserirParcelas(vendaId, parcelas, tran);

                tran.Commit();
                return vendaId;
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }
        public void InserirParcelas(
         int vendaId,
         List<ParcelaModel> parcelas,
         SqlTransaction tran)
        {
            const string sql = @"
            INSERT INTO Parcela
            (VendaID, NumeroParcela, DataVencimento, ValorParcela,
             ValorRecebido, Status, DataPagamento, Juros, Multa, Observacao, EmpresaID)
            VALUES
            (@VendaID, @NumeroParcela, @DataVencimento, @ValorParcela,
             @ValorRecebido, @Status, @DataPagamento, @Juros, @Multa, @Observacao, @EmpresaID)";

            foreach (var p in parcelas)
            {
                using var cmd = CreateCommand(sql);
                cmd.Transaction = tran;

                cmd.Parameters.Add("@VendaID", SqlDbType.Int).Value = vendaId;
                cmd.Parameters.Add("@NumeroParcela", SqlDbType.Int).Value = p.NumeroParcela;
                cmd.Parameters.Add("@DataVencimento", SqlDbType.Date).Value = p.DataVencimento;
                cmd.Parameters.Add("@ValorParcela", SqlDbType.Decimal).Value = p.ValorParcela;
                cmd.Parameters.Add("@ValorRecebido", SqlDbType.Decimal).Value = (object?)p.ValorRecebido ?? DBNull.Value;
                cmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = p.Status.ToDb();
                cmd.Parameters.Add("@DataPagamento", SqlDbType.Date).Value = (object?)p.DataPagamento ?? DBNull.Value;
                cmd.Parameters.Add("@Juros", SqlDbType.Decimal).Value = (object?)p.Juros ?? DBNull.Value;
                cmd.Parameters.Add("@Multa", SqlDbType.Decimal).Value = (object?)p.Multa ?? DBNull.Value;
                cmd.Parameters.Add("@Observacao", SqlDbType.NVarChar).Value =  (object?)p.Observacao ?? DBNull.Value;

                cmd.ExecuteNonQuery();
            }
        }

        // ======================================================
        // 🔹 UPDATE VENDA
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
                WHERE VendaID = @VendaID
                  AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
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

        // ======================================================
        // 🔹 EXCLUIR VENDA
        // ======================================================
        //public void Excluir(int vendaID)
        //{
        //    using var cmd = CreateCommand("DELETE FROM Venda WHERE VendaID = @id AND EmpresaID = @EmpresaID");

        //    cmd.Parameters.AddWithValue("@id", vendaID);
        //    cmd.ExecuteNonQuery();
        //}

        // ======================================================
        // 🔹 STATUS
        // ======================================================
        public void AtualizarStatusVenda(int vendaId, EnumStatusVenda status)
        {
            using var cmd = CreateCommand(@"
                UPDATE Venda 
                SET StatusVenda = @Status
                WHERE VendaID = @VendaID
                  AND EmpresaID = @EmpresaID");

            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.Parameters.AddWithValue("@Status", status.ToDb());
            cmd.ExecuteNonQuery();
        }

        public void AtualizarStatusVenda(int vendaId, string novoStatus, string motivo)
        {
            using var cmd = CreateCommand(@"
                UPDATE Venda 
                SET StatusVenda = @Status,
                    Observacoes =
                        CASE 
                            WHEN Observacoes IS NULL OR Observacoes = ''
                                THEN @Motivo
                            ELSE Observacoes + CHAR(13) + CHAR(10) + @Motivo
                        END
                WHERE VendaID = @VendaID
                  AND EmpresaID = @EmpresaID");

            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.Parameters.AddWithValue("@Status", novoStatus);
            cmd.Parameters.AddWithValue("@Motivo", motivo);
            cmd.ExecuteNonQuery();
        }

        // ======================================================
        // 🔹 OBTENÇÕES
        // ======================================================
        public VendaModel? ObterPorId(int vendaId)
        {
            using var cmd = CreateCommand(@"
                SELECT *
                FROM Venda
                WHERE VendaID = @VendaID
                  AND EmpresaID = @EmpresaID");

            cmd.Parameters.AddWithValue("@VendaID", vendaId);

            using var dr = cmd.ExecuteReader();
            return dr.Read() ? MapVenda(dr) : null;
        }

        public VendaModel ObterVendaCompleta(int vendaId)
        {
            var venda = ObterPorId(vendaId)
                ?? throw new Exception("Venda não encontrada.");

            venda.ItemVenda = BuscarItens(vendaId);
            venda.Parcelas = BuscarParcelas(vendaId);

            return venda;
        }

        // ======================================================
        // 🔧 AUXILIARES PRIVADOS
        // ======================================================
        public int InserirVenda(VendaModel venda, SqlTransaction tran)
        {
            const string sql = @"
        INSERT INTO Venda
        (DataVenda, ClienteID, ValorTotal, FormaPgtoID,
         Desconto, Observacoes, StatusVenda, VendedorID, EmpresaID)
        VALUES
        (@DataVenda, @ClienteID, @ValorTotal, @FormaPgtoID,
         @Desconto, @Observacoes, @StatusVenda, @VendedorID, @EmpresaID);
        SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using var cmd = CreateCommand(sql);
            cmd.Transaction = tran;

            cmd.Parameters.AddWithValue("@DataVenda", venda.DataVenda);
            cmd.Parameters.AddWithValue("@ClienteID", venda.ClienteID);
            cmd.Parameters.AddWithValue("@ValorTotal", venda.ValorTotal);
            cmd.Parameters.AddWithValue("@FormaPgtoID",
                venda.FormaPgtoID ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Desconto",
                venda.Desconto ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Observacoes",
                (object?)venda.Observacoes ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@StatusVenda",
                venda.StatusVenda.ToDb());
            cmd.Parameters.AddWithValue("@VendedorID",
                venda.VendedorID ?? (object)DBNull.Value);

            // 🔒 @EmpresaID já é injetado automaticamente pelo CreateCommand

            return Convert.ToInt32(cmd.ExecuteScalar());
        }


        public void InserirItensEBaixarEstoque(
     int vendaId,
     List<ItemVendaModel> itens,
     SqlTransaction tran)
        {
            const string sql = @"
        INSERT INTO ItemVenda
        (VendaID, ProdutoID, Quantidade, PrecoUnitario, Subtotal, DescontoItem, EmpresaID)
        VALUES
        (@VendaID, @ProdutoID, @Quantidade, @PrecoUnitario, @Subtotal, @DescontoItem, @EmpresaID)";

            foreach (var item in itens)
            {
                item.VendaID = vendaId;
                item.AtualizarSubtotal();

                using var cmd = CreateCommand(sql);
                cmd.Transaction = tran;

                cmd.Parameters.AddWithValue("@VendaID", vendaId);
                cmd.Parameters.AddWithValue("@ProdutoID", item.ProdutoID);
                cmd.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                cmd.Parameters.AddWithValue("@PrecoUnitario", item.PrecoUnitario);
                cmd.Parameters.AddWithValue("@Subtotal", item.Subtotal);
                cmd.Parameters.AddWithValue("@DescontoItem",
                    item.DescontoItem ?? (object)DBNull.Value);

                // 🔒 @EmpresaID já é injetado automaticamente pelo CreateCommand

                cmd.ExecuteNonQuery();

                // Mantém mesma regra original de baixa de estoque
                AjustarEstoque(item.ProdutoID, item.Quantidade, false, tran);
            }
        }



        private void AjustarEstoque(
            int produtoId,
            int quantidade,
            bool somar,
            SqlTransaction tran)
        {
            string sql = somar
                ? @"UPDATE Produtos
           SET Estoque = Estoque + @Qtd
           WHERE ProdutoID = @ProdutoID
             AND EmpresaID = @EmpresaID"
                : @"UPDATE Produtos
           SET Estoque = Estoque - @Qtd
           WHERE ProdutoID = @ProdutoID
             AND EmpresaID = @EmpresaID
             AND Estoque >= @Qtd";

            using var cmd = CreateCommand(sql);
            cmd.Transaction = tran;

            cmd.Parameters.AddWithValue("@ProdutoID", produtoId);
            cmd.Parameters.AddWithValue("@Qtd", quantidade);

            if (!somar && cmd.ExecuteNonQuery() == 0)
                throw new Exception($"Estoque insuficiente para o produto {produtoId}");

            if (somar)
                cmd.ExecuteNonQuery();
        }

        private void AjustarEstoque(
            int produtoId,
            int quantidade,
            SqlTransaction tran,
            bool somar)
        {
            string sql = somar
                ? @"UPDATE Produtos
           SET Estoque = Estoque + @Qtd
           WHERE ProdutoID = @ProdutoID
             AND EmpresaID = @EmpresaID"
                : @"UPDATE Produtos
           SET Estoque = Estoque - @Qtd
           WHERE ProdutoID = @ProdutoID
             AND EmpresaID = @EmpresaID
             AND Estoque >= @Qtd";

            using var cmd = CreateCommand(sql);
            cmd.Transaction = tran;

            cmd.Parameters.Add("@ProdutoID", SqlDbType.Int).Value = produtoId;
            cmd.Parameters.Add("@Qtd", SqlDbType.Int).Value = quantidade;

            if (!somar && cmd.ExecuteNonQuery() == 0)
                throw new Exception($"Estoque insuficiente para o produto {produtoId}");

            if (somar)
                cmd.ExecuteNonQuery();
        }


        private static void BlindarStatusVenda(
            VendaModel venda,
            List<ParcelaModel>? parcelas)
        {
            if (parcelas != null && parcelas.Any())
            {
                venda.StatusVenda = parcelas.All(p => p.Status == EnumStatusParcela.Pago)
                    ? EnumStatusVenda.Concluida
                    : EnumStatusVenda.AguardandoPagamento;
            }
            else
            {
                venda.StatusVenda = EnumStatusVenda.Concluida;
            }
        }

        private static VendaModel MapVenda(SqlDataReader r)
        {
            return new VendaModel
            {
                VendaID = r.GetInt32("VendaID"),
                ClienteID = r.GetInt32("ClienteID"),
                DataVenda = r.GetDateTime("DataVenda"),
                ValorTotal = r.GetDecimal("ValorTotal"),
                Desconto = r["Desconto"] as decimal?,
                Observacoes = r["Observacoes"] as string,
                FormaPgtoID = r["FormaPgtoID"] as int?,
                StatusVenda = r["StatusVenda"].ToString().ToEnumStatusVenda(),
                VendedorID = r["VendedorID"] as int?
            };
        }

        private List<ItemVendaModel> BuscarItens(int vendaId)
        {
            var lista = new List<ItemVendaModel>();

            const string sql = @"
            SELECT *
            FROM ItemVenda
            WHERE VendaID = @VendaID
          AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);

            using var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new ItemVendaModel
                {
                    ProdutoID = dr.GetInt32("ProdutoID"),
                    Quantidade = dr.GetInt32("Quantidade"),
                    PrecoUnitario = dr.GetDecimal("PrecoUnitario"),
                    DescontoItem = dr["DescontoItem"] as decimal?
                });
            }

            return lista;
        }


        private List<ParcelaModel> BuscarParcelas(int vendaId)
        {
            var lista = new List<ParcelaModel>();

            const string sql = @"
        SELECT *
        FROM Parcela
        WHERE VendaID = @VendaID
          AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);

            using var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new ParcelaModel
                {
                    ParcelaID = dr.GetInt32("ParcelaID"),
                    NumeroParcela = dr.GetInt32("NumeroParcela"),
                    DataVencimento = dr.GetDateTime("DataVencimento"),
                    ValorParcela = dr.GetDecimal("ValorParcela"),
                    Status = dr["Status"].ToString().ToEnumStatusParcela()
                });
            }

            return lista;
        }
        public void AtualizarStatusVenda(int vendaId, EnumStatusVenda status, SqlTransaction tran)
        {
            using var cmd = CreateCommand(@"
            UPDATE Venda
            SET StatusVenda = @Status
            WHERE VendaID = @VendaID
              AND EmpresaID = @EmpresaID");

            cmd.Transaction = tran;
            cmd.Parameters.Add("@VendaID", SqlDbType.Int).Value = vendaId;
            cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 20).Value = status.ToDb();

            if (cmd.ExecuteNonQuery() == 0)
                throw new Exception("Falha ao atualizar status da venda (não encontrada).");
        }

        //cancelar venda - verificar se existe venda, verificar se existe parcela paga, devolver estoque, cancelar parcelas, cancelar venda
        public void CancelarVenda(int vendaId, string motivo)
        {
            using var tran = Connection.BeginTransaction();

            try
            {
                // 1️⃣ Verifica venda
                var venda = ObterVendaParaCancelamento(vendaId, tran);
                if (venda == null)
                    throw new Exception("Venda não encontrada.");

                if (venda.StatusVenda == EnumStatusVenda.Cancelada)
                    throw new Exception("Esta venda já está cancelada.");

                // 2️⃣ Verifica parcelas pagas
                if (ExisteParcelaPaga(vendaId, tran))
                    throw new Exception(
                        "Não é possível cancelar uma venda com parcelas pagas.");

                // 3️⃣ Devolver estoque
                DevolverEstoque(vendaId, tran);

                // 4️⃣ Cancelar parcelas
                CancelarParcelasPorVenda(vendaId, tran);

                // 5️⃣ Cancelar venda
                AtualizarVendaCancelada(vendaId, motivo, tran);

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }
        private VendaModel? ObterVendaParaCancelamento(int vendaId, SqlTransaction tran)
        {
            const string sql = @"
        SELECT VendaID, StatusVenda
        FROM Venda
        WHERE VendaID = @VendaID
          AND EmpresaID = @EmpresaID;";

            using var cmd = CreateCommand(sql);
            cmd.Transaction = tran;
            cmd.Parameters.Add("@VendaID", SqlDbType.Int).Value = vendaId;

            using var dr = cmd.ExecuteReader();
            if (!dr.Read())
                return null;

            var statusString = dr["StatusVenda"]?.ToString();
            if (string.IsNullOrWhiteSpace(statusString))
                throw new InvalidOperationException($"StatusVenda inválido para a venda {vendaId}.");

            return new VendaModel
            {
                VendaID = Convert.ToInt32(dr["VendaID"]),
                StatusVenda = statusString.ToEnumStatusVenda()
            };
        }



        private bool ExisteParcelaPaga(int vendaId, SqlTransaction tran)
        {
            const string sql = @"
        SELECT TOP 1 1
        FROM Parcela
        WHERE VendaID = @VendaID
          AND EmpresaID = @EmpresaID
          AND ISNULL(ValorRecebido, 0) > 0";

            using var cmd = CreateCommand(sql);
            cmd.Transaction = tran;
            cmd.Parameters.Add("@VendaID", SqlDbType.Int).Value = vendaId;

            return cmd.ExecuteScalar() != null;
        }


        private void DevolverEstoque(int vendaId, SqlTransaction tran)
        {
            const string sqlItens = @"
        SELECT ProdutoID, Quantidade
        FROM ItemVenda
        WHERE VendaID = @VendaID
          AND EmpresaID = @EmpresaID";

            using var cmdItens = CreateCommand(sqlItens);
            cmdItens.Transaction = tran;


            cmdItens.Parameters.AddWithValue("@VendaID", vendaId);

            using var dr = cmdItens.ExecuteReader();
            var itens = new List<(int ProdutoID, int Quantidade)>();

            while (dr.Read())
                itens.Add((dr.GetInt32(0), dr.GetInt32(1)));

            dr.Close();

            foreach (var item in itens)
            {
                const string sql = @"
            UPDATE Produtos
            SET Estoque = Estoque + @Qtd
            WHERE ProdutoID = @ProdutoID
              AND EmpresaID = @EmpresaID";

                using var cmd = CreateCommand(sql);
                cmd.Transaction = tran;

                cmd.Parameters.AddWithValue("@ProdutoID", item.ProdutoID);
                cmd.Parameters.AddWithValue("@Qtd", item.Quantidade);

                cmd.ExecuteNonQuery();
            }
        }

        public void CancelarParcelasPorVenda(long vendaId)
        {
            const string sql = @"
        UPDATE Parcela
           SET Status = 'Cancelada',
               ValorRecebido = 0,
               DataPagamento = NULL
         WHERE VendaID = @VendaID
           AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.Add("@VendaID", SqlDbType.Int).Value = (int)vendaId;

            cmd.ExecuteNonQuery();
        }
        private void CancelarParcelasPorVenda(long vendaId, SqlTransaction tran)
        {
            const string sql = @"
            UPDATE Parcela
               SET Status = 'Cancelada',
                   ValorRecebido = 0,
                   DataPagamento = NULL
             WHERE VendaID = @VendaID
               AND EmpresaID = @EmpresaID;";

            using var cmd = CreateCommand(sql);
            cmd.Transaction = tran;
            cmd.Parameters.Add("@VendaID", SqlDbType.Int).Value = (int)vendaId;

            cmd.ExecuteNonQuery();
        }

        private void AtualizarVendaCancelada(int vendaId, string motivo, SqlTransaction tran)
        {
            const string sql = @"
        UPDATE Venda
        SET StatusVenda = 'Cancelada',
            Observacoes =
                CASE
                    WHEN Observacoes IS NULL OR Observacoes = ''
                        THEN @Motivo
                    ELSE Observacoes + CHAR(13) + CHAR(10) + @Motivo
                END
        WHERE VendaID = @VendaID
          AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Transaction = tran;

            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.Parameters.AddWithValue("@Motivo", motivo);

            cmd.ExecuteNonQuery();
        }
        //ACIMA TUDO FAZ PARTE DE CANCELAR VENDA-----------------------------

        public void AtualizarVendaCompleta(
     VendaModel venda,
     List<ItemVendaModel> itens,
     List<ParcelaModel> parcelas)
        {
            using var tran = Connection.BeginTransaction();

            try
            {
                // 1️⃣ Atualiza cabeçalho
                AtualizarVenda(venda, tran);

                // 2️⃣ Busca itens antigos
                var itensAntigos = ObterItensPorVenda(venda.VendaID, tran);

                // 3️⃣ Devolve estoque antigo
                foreach (var antigo in itensAntigos)
                    AjustarEstoque(antigo.ProdutoID, antigo.Quantidade, tran, somar: true);

                // 4️⃣ Remove itens antigos
                ExcluirItens(venda.VendaID, tran);

                // 5️⃣ Insere novos itens + baixa estoque
                foreach (var item in itens)
                {
                    item.VendaID = venda.VendaID;
                    item.AtualizarSubtotal();

                    InserirItem(item, tran);
                    AjustarEstoque(item.ProdutoID, item.Quantidade, tran, somar: false);
                }

                // 6️⃣ Remove parcelas antigas
                ExcluirParcelas(venda.VendaID, tran);

                // 7️⃣ Insere novas parcelas
                InserirParcelas(venda.VendaID, parcelas, tran);

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }
        private void AtualizarVenda(VendaModel venda, SqlTransaction tran)
        {
            const string sql = @"
        UPDATE Venda
        SET ClienteID   = @ClienteID,
            FormaPgtoID = @FormaPgtoID,
            DataVenda   = @DataVenda,
            ValorTotal  = @ValorTotal,
            Desconto    = @Desconto,
            Observacoes = @Observacoes,
            StatusVenda = @StatusVenda
        WHERE VendaID = @VendaID
          AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Transaction = tran;

            cmd.Parameters.Add("@VendaID", SqlDbType.Int).Value = venda.VendaID;
            cmd.Parameters.Add("@ClienteID", SqlDbType.Int).Value = venda.ClienteID;
            cmd.Parameters.Add("@FormaPgtoID", SqlDbType.Int).Value =
                (object?)venda.FormaPgtoID ?? DBNull.Value;
            cmd.Parameters.Add("@DataVenda", SqlDbType.DateTime2).Value = venda.DataVenda;
            cmd.Parameters.Add("@ValorTotal", SqlDbType.Decimal).Value = venda.ValorTotal;
            cmd.Parameters.Add("@Desconto", SqlDbType.Decimal).Value =
                (object?)venda.Desconto ?? DBNull.Value;
            cmd.Parameters.Add("@Observacoes", SqlDbType.NVarChar).Value =
                (object?)venda.Observacoes ?? DBNull.Value;
            cmd.Parameters.Add("@StatusVenda", SqlDbType.NVarChar).Value =
                venda.StatusVenda.ToDb();

            cmd.ExecuteNonQuery();
        }

        private List<ItemVendaModel> ObterItensPorVenda(int vendaId, SqlTransaction tran)
        {
            const string sql = @"
        SELECT ProdutoID, Quantidade
        FROM ItemVenda
        WHERE VendaID = @VendaID
          AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Transaction = tran;
            cmd.Parameters.Add("@VendaID", SqlDbType.Int).Value = vendaId;

            using var dr = cmd.ExecuteReader();

            var lista = new List<ItemVendaModel>();
            while (dr.Read())
            {
                lista.Add(new ItemVendaModel
                {
                    ProdutoID = dr.GetInt32("ProdutoID"),
                    Quantidade = dr.GetInt32("Quantidade")
                });
            }

            return lista;
        }

        public void InserirItem(ItemVendaModel item, SqlTransaction tran)
        {
            const string sql = @"
        INSERT INTO ItemVenda
        (VendaID, ProdutoID, Quantidade, PrecoUnitario, Subtotal, DescontoItem)
        VALUES
        (@VendaID, @ProdutoID, @Quantidade, @PrecoUnitario, @Subtotal, @DescontoItem)";

            using var cmd = CreateCommand(sql);
            cmd.Transaction = tran;

            cmd.Parameters.Add("@VendaID", SqlDbType.Int).Value = item.VendaID;
            cmd.Parameters.Add("@ProdutoID", SqlDbType.Int).Value = item.ProdutoID;
            cmd.Parameters.Add("@Quantidade", SqlDbType.Int).Value = item.Quantidade;
            cmd.Parameters.Add("@PrecoUnitario", SqlDbType.Decimal).Value = item.PrecoUnitario;
            cmd.Parameters.Add("@Subtotal", SqlDbType.Decimal).Value = item.Subtotal;
            cmd.Parameters.Add("@DescontoItem", SqlDbType.Decimal).Value =
                (object?)item.DescontoItem ?? DBNull.Value;

            cmd.ExecuteNonQuery();
        }
        private void ExcluirItens(int vendaId, SqlTransaction tran)
        {
            const string sql = @"
        DELETE FROM ItemVenda
        WHERE VendaID = @VendaID
          AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Transaction = tran;
            cmd.Parameters.Add("@VendaID", SqlDbType.Int).Value = vendaId;

            cmd.ExecuteNonQuery();
        }

        private void ExcluirParcelas(int vendaId, SqlTransaction tran)
        {
            const string sql = @"
        DELETE FROM Parcela
        WHERE VendaID = @VendaID
          AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Transaction = tran;
            cmd.Parameters.Add("@VendaID", SqlDbType.Int).Value = vendaId;

            cmd.ExecuteNonQuery();
        }
        //Abaixo métodos adicionados em 16/02/2026 para facilitar estorno/cancelamento de venda 
        public List<(int ProdutoID, int Quantidade)> ObterItensParaEstorno(int vendaId, SqlTransaction tran)
        {
            const string sql = @"
            SELECT ProdutoID, Quantidade
            FROM ItemVenda
            WHERE VendaID = @VendaID
              AND EmpresaID = @EmpresaID;";

            using var cmd = CreateCommand(sql);
            cmd.Transaction = tran;
            cmd.Parameters.Add("@VendaID", SqlDbType.Int).Value = vendaId;

            using var dr = cmd.ExecuteReader();
            var itens = new List<(int, int)>();

            while (dr.Read())
                itens.Add((dr.GetInt32(0), dr.GetInt32(1)));

            return itens;
        }
        public void ReporEstoque(int produtoId, int quantidade, SqlTransaction tran)
        {
            const string sql = @"
                UPDATE Produtos
                SET Estoque = Estoque + @Qtd
                WHERE ProdutoID = @ProdutoID
                  AND EmpresaID = @EmpresaID;";

            using var cmd = CreateCommand(sql);
            cmd.Transaction = tran;

            cmd.Parameters.Add("@ProdutoID", SqlDbType.Int).Value = produtoId;
            cmd.Parameters.Add("@Qtd", SqlDbType.Int).Value = quantidade;

            cmd.ExecuteNonQuery();
        }
        public void ExcluirItensPorVenda(int vendaId, SqlTransaction tran)
        {
            const string sql = @"
            DELETE FROM ItemVenda
            WHERE VendaID = @VendaID
              AND EmpresaID = @EmpresaID;";

            using var cmd = CreateCommand(sql);
            cmd.Transaction = tran;
            cmd.Parameters.Add("@VendaID", SqlDbType.Int).Value = vendaId;

            cmd.ExecuteNonQuery();
        }
        //✅ 4) Excluir venda (transacional) com overload
        public void Excluir(int vendaID)
        {
            using var tran = Connection.BeginTransaction();

            try
            {
                // 1) DEVOLVE ESTOQUE (itens da venda)
                const string sqlItens = @"
            SELECT ProdutoID, Quantidade
            FROM ItemVenda
            WHERE VendaID = @VendaID
              AND EmpresaID = @EmpresaID;";

                var itens = new List<(int ProdutoID, int Quantidade)>();

                using (var cmdItens = CreateCommand(sqlItens))
                {
                    cmdItens.Transaction = tran;
                    cmdItens.Parameters.Add("@VendaID", SqlDbType.Int).Value = vendaID;

                    using var dr = cmdItens.ExecuteReader();
                    while (dr.Read())
                        itens.Add((dr.GetInt32(0), dr.GetInt32(1)));
                }

                foreach (var it in itens)
                {
                    const string sqlRepor = @"
                UPDATE Produtos
                SET Estoque = Estoque + @Qtd
                WHERE ProdutoID = @ProdutoID
                  AND EmpresaID = @EmpresaID;";

                    using var cmdRepor = CreateCommand(sqlRepor);
                    cmdRepor.Transaction = tran;
                    cmdRepor.Parameters.Add("@ProdutoID", SqlDbType.Int).Value = it.ProdutoID;
                    cmdRepor.Parameters.Add("@Qtd", SqlDbType.Int).Value = it.Quantidade;
                    cmdRepor.ExecuteNonQuery();
                }

                // 2) EXCLUI PAGAMENTOS PARCIAIS (por venda via parcelas)
                // ✅ Usa o método que você já tem no ParcelaRepository (SEM duplicar SQL)
                using (var parcelaRepo = new ParcelaRepository(Connection))
                {
                    parcelaRepo.ExcluirPagamentosParciaisPorVenda(vendaID, tran);
                }

                // 3) EXCLUI PARCELAS
                using (var parcelaRepo = new ParcelaRepository(Connection))
                {
                    parcelaRepo.ExcluirParcelasPorVenda(vendaID, tran);
                }

                // 4) EXCLUI ITENS
                const string sqlDelItens = @"
                    DELETE FROM ItemVenda
                    WHERE VendaID = @VendaID
                      AND EmpresaID = @EmpresaID;";

                using (var cmdDelItens = CreateCommand(sqlDelItens))
                {
                    cmdDelItens.Transaction = tran;
                    cmdDelItens.Parameters.Add("@VendaID", SqlDbType.Int).Value = vendaID;
                    cmdDelItens.ExecuteNonQuery();
                }

                // 5) EXCLUI VENDA
                const string sqlDelVenda = @"
                    DELETE FROM Venda
                    WHERE VendaID = @VendaID
                      AND EmpresaID = @EmpresaID;";

                using (var cmdDelVenda = CreateCommand(sqlDelVenda))
                {
                    cmdDelVenda.Transaction = tran;
                    cmdDelVenda.Parameters.Add("@VendaID", SqlDbType.Int).Value = vendaID;
                    cmdDelVenda.ExecuteNonQuery();
                }

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }
    }
}
