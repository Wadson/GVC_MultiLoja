using GVC.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace GVC.Infra.Repository
{
    public class ProdutoRepository : RepositoryBase
    {
        public int ObterProximoNumeroProdutoID()
        {
            const string sql = @"  SELECT ISNULL(MAX(ProdutoID), 0) + 1  FROM Produto WHERE EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private const string SqlBase = @"
            SELECT
                p.ProdutoID,
                p.NomeProduto,
                p.Referencia,
                p.PrecoCusto,
                p.Lucro,
                p.PrecoDeVenda,
                p.Estoque,
                p.DataDeEntrada,
                p.Status,
                p.Situacao,
                p.Unidade,
                p.Marca,
                p.DataValidade,
                p.GtinEan,
                p.Imagem,
                p.FornecedorID,
                ISNULL(f.Nome, '') AS NomeFornecedor
            FROM Produtos p
            LEFT JOIN Fornecedor f ON f.FornecedorID = p.FornecedorID
            WHERE p.EmpresaID = @EmpresaID";

        // =========================
        // AUXILIAR
        // =========================
        private DataTable ExecuteDataTable(string sql, params SqlParameter[] parameters)
        {
            using var cmd = CreateCommand(sql);

            if (parameters != null && parameters.Length > 0)
                cmd.Parameters.AddRange(parameters);

            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // =========================
        // LISTAR
        // =========================
        //public DataTable ListarTodos() => ExecuteDataTable(SqlBase + " ORDER BY p.NomeProduto");

        public List<ProdutoModel> ListarTodos()
        {
            var lista = new List<ProdutoModel>();

            // Reaproveita o SqlBase e adiciona TOP 100 + ORDER BY
            string sql = SqlBase + " ORDER BY p.NomeProduto OFFSET 0 ROWS FETCH NEXT 100 ROWS ONLY";

            using var cmd = CreateCommand(sql);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(Mapear(reader));
            }

            return lista;
        }

        public List<ProdutoModel> ListarProdutosVenda()
        {
            var lista = new List<ProdutoModel>();

            using var cmd = CreateCommand(@"
                SELECT TOP 100
                    ProdutoID,
                    NomeProduto,
                    Referencia,
                    PrecoDeVenda,
                    Estoque,
                    Unidade,
                    Marca
                FROM Produtos
                WHERE EmpresaID = @EmpresaID
                ORDER BY NomeProduto");

            using var dr = cmd.ExecuteReader();
            while (dr.Read())
                lista.Add(MapearPesquisaVenda(dr));

            return lista;
        }

        public List<ProdutoModel> ListarProdutoDinamico(string filtro = "")
        {
            var lista = new List<ProdutoModel>();

            using var cmd = CreateCommand(@"
                SELECT
                    ProdutoID,
                    NomeProduto,
                    Unidade,
                    PrecoDeVenda
                FROM Produtos
                WHERE EmpresaID = @EmpresaID
                  AND Status = 'Disponível'
                  AND Situacao = 'Ativo'
                  AND NomeProduto COLLATE Latin1_General_CI_AI LIKE @Filtro
                ORDER BY NomeProduto");

            cmd.Parameters.Add("@Filtro", SqlDbType.NVarChar).Value = $"%{filtro}%";

            using var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new ProdutoModel
                {
                    ProdutoID = dr.GetInt32(0),
                    NomeProduto = dr.GetString(1),
                    Unidade = dr.IsDBNull(2) ? "" : dr.GetString(2),
                    PrecoDeVenda = dr.GetDecimal(3)
                });
            }

            return lista;
        }

        // =========================
        // BUSCAR
        // =========================
        public ProdutoModel? BuscarPorId(long id)
        {
            using var cmd = CreateCommand(SqlBase + " AND p.ProdutoID = @ID");
            cmd.Parameters.Add("@ID", SqlDbType.BigInt).Value = id;

            using var dr = cmd.ExecuteReader();
            return dr.Read() ? Mapear(dr) : null;
        }

        // =========================
        // INSERT
        // =========================
        public long Inserir(ProdutoModel p)
        {
            const string sql = @"
                INSERT INTO Produtos (
                    NomeProduto, Referencia, PrecoCusto, Lucro, PrecoDeVenda,
                    Estoque, DataDeEntrada, Status, Situacao,
                    Unidade, Marca, DataValidade, GtinEan, Imagem,
                    FornecedorID, EmpresaID
                )
                VALUES (
                    @NomeProduto, @Referencia, @PrecoCusto, @Lucro, @PrecoDeVenda,
                    @Estoque, @DataDeEntrada, @Status, @Situacao,
                    @Unidade, @Marca, @DataValidade, @GtinEan, @Imagem,
                    @FornecedorID, @EmpresaID
                );
                SELECT CAST(SCOPE_IDENTITY() AS BIGINT);";

            using var cmd = CreateCommand(sql);
            PreencherParametros(cmd, p, true);

            return Convert.ToInt64(cmd.ExecuteScalar());
        }

        // =========================
        // UPDATE
        // =========================
        public bool Alterar(ProdutoModel p)
        {
            const string sql = @"
                UPDATE Produtos SET
                    NomeProduto = @NomeProduto,
                    Referencia = @Referencia,
                    PrecoCusto = @PrecoCusto,
                    Lucro = @Lucro,
                    PrecoDeVenda = @PrecoDeVenda,
                    Estoque = @Estoque,
                    Status = @Status,
                    Situacao = @Situacao,
                    Unidade = @Unidade,
                    Marca = @Marca,
                    DataValidade = @DataValidade,
                    GtinEan = @GtinEan,
                    Imagem = @Imagem,
                    FornecedorID = @FornecedorID
                WHERE ProdutoID = @ProdutoID
                  AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.Add("@ProdutoID", SqlDbType.BigInt).Value = p.ProdutoID;

            PreencherParametros(cmd, p, false);
            return cmd.ExecuteNonQuery() > 0;
        }

        // =========================
        // DELETE
        // =========================
        public bool Excluir(long id)
        {
            using var cmd = CreateCommand(@"
                DELETE FROM Produtos
                WHERE ProdutoID = @ID
                  AND EmpresaID = @EmpresaID");

            cmd.Parameters.Add("@ID", SqlDbType.BigInt).Value = id;
            return cmd.ExecuteNonQuery() > 0;
        }

        // =========================
        // PESQUISAS
        // =========================
        public List<ProdutoModel> PesquisarProdutoPorNome(string nome)
            => MapearLista( ExecuteDataTable( SqlBase + " AND p.NomeProduto LIKE @Nome ORDER BY p.NomeProduto", new SqlParameter("@Nome", $"%{nome}%")));

        public List<ProdutoModel> PesquisarProdutoPorCodigo(string codigo)
            => MapearLista(
                ExecuteDataTable(
                    SqlBase + @"
                        AND (
                            p.NomeProduto LIKE @Filtro
                            OR CAST(p.ProdutoID AS VARCHAR) LIKE @Filtro
                            OR p.Referencia LIKE @Filtro
                        )",
                    new SqlParameter("@Filtro", $"%{codigo}%")));

        // =========================
        // ESTOQUE
        // =========================
        public void BaixarEstoque(long produtoId, int quantidade)
        {
            using var cmd = CreateCommand(@"
                UPDATE Produtos
                   SET Estoque = Estoque - @Qtd
                 WHERE ProdutoID = @ID
                   AND EmpresaID = @EmpresaID
                   AND Estoque >= @Qtd");

            cmd.Parameters.Add("@ID", SqlDbType.BigInt).Value = produtoId;
            cmd.Parameters.Add("@Qtd", SqlDbType.Int).Value = quantidade;

            if (cmd.ExecuteNonQuery() == 0)
                throw new Exception("Estoque insuficiente.");
        }
        private static List<ProdutoModel> MapearLista(DataTable dt)
        {
            var lista = new List<ProdutoModel>();
            foreach (DataRow r in dt.Rows)
            {
                lista.Add(Mapear(r));
            }
            return lista;
        }

        private static ProdutoModel Mapear(DataRow r)
        {
            return new ProdutoModel
            {
                ProdutoID = Convert.ToInt32(r["ProdutoID"]),
                NomeProduto = r["NomeProduto"].ToString(),
                Referencia = r["Referencia"] == DBNull.Value ? null : r["Referencia"].ToString(),
                PrecoCusto = r["PrecoCusto"] == DBNull.Value ? 0 : Convert.ToDecimal(r["PrecoCusto"]),
                Lucro = r["Lucro"] == DBNull.Value ? 0 : Convert.ToDecimal(r["Lucro"]),
                PrecoDeVenda = r["PrecoDeVenda"] == DBNull.Value ? 0 : Convert.ToDecimal(r["PrecoDeVenda"]),
                Estoque = r["Estoque"] == DBNull.Value ? 0 : Convert.ToInt32(r["Estoque"]),
                DataDeEntrada = r["DataDeEntrada"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(r["DataDeEntrada"]),
                Status = r["Status"] == DBNull.Value ? "" : r["Status"].ToString(),
                Situacao = r["Situacao"] == DBNull.Value ? "" : r["Situacao"].ToString(),
                Unidade = r["Unidade"] == DBNull.Value ? "" : r["Unidade"].ToString(),
                Marca = r["Marca"] == DBNull.Value ? "" : r["Marca"].ToString(),
                DataValidade = r["DataValidade"] == DBNull.Value ? null : (DateTime?)r["DataValidade"],
                GtinEan = r["GtinEan"] == DBNull.Value ? "" : r["GtinEan"].ToString(),
                Imagem = r["Imagem"] == DBNull.Value ? null : r["Imagem"].ToString(),
                FornecedorID = r["FornecedorID"] == DBNull.Value ? null : (int?)Convert.ToInt32(r["FornecedorID"]),
                Fornecedor = new FornecedorModel
                {
                    FornecedorID = r["FornecedorID"] == DBNull.Value ? 0 : Convert.ToInt32(r["FornecedorID"]),
                    Nome = r["NomeFornecedor"] == DBNull.Value ? "" : r["NomeFornecedor"].ToString()
                }
            };
        }
        // =========================
        // MAP (inalterado)
        // =========================
        private static ProdutoModel Mapear(SqlDataReader r)
        {
            return new ProdutoModel
            {
                ProdutoID = Convert.ToInt32(r["ProdutoID"]),
                NomeProduto = r["NomeProduto"].ToString(),
                Referencia = r["Referencia"] == DBNull.Value ? null : r["Referencia"].ToString(),
                PrecoCusto = r["PrecoCusto"] == DBNull.Value ? 0 : Convert.ToDecimal(r["PrecoCusto"]),
                Lucro = r["Lucro"] == DBNull.Value ? 0 : Convert.ToDecimal(r["Lucro"]),
                PrecoDeVenda = r["PrecoDeVenda"] == DBNull.Value ? 0 : Convert.ToDecimal(r["PrecoDeVenda"]),
                Estoque = r["Estoque"] == DBNull.Value ? 0 : Convert.ToInt32(r["Estoque"]),
                DataDeEntrada = r["DataDeEntrada"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(r["DataDeEntrada"]),
                Status = r["Status"] == DBNull.Value ? "" : r["Status"].ToString(),
                Situacao = r["Situacao"] == DBNull.Value ? "" : r["Situacao"].ToString(),
                Unidade = r["Unidade"] == DBNull.Value ? "" : r["Unidade"].ToString(),
                Marca = r["Marca"] == DBNull.Value ? "" : r["Marca"].ToString(),
                DataValidade = r["DataValidade"] == DBNull.Value ? null : (DateTime?)r["DataValidade"],
                GtinEan = r["GtinEan"] == DBNull.Value ? "" : r["GtinEan"].ToString(),
                Imagem = r["Imagem"] == DBNull.Value ? null : r["Imagem"].ToString(),
                FornecedorID = r["FornecedorID"] == DBNull.Value ? null : (int?)Convert.ToInt32(r["FornecedorID"]),
                Fornecedor = new FornecedorModel
                {
                    FornecedorID = r["FornecedorID"] == DBNull.Value ? 0 : Convert.ToInt32(r["FornecedorID"]),
                    Nome = r["NomeFornecedor"] == DBNull.Value ? "" : r["NomeFornecedor"].ToString()  // Alterado aqui
                }
            };
        }


        private static ProdutoModel MapearPesquisaVenda(SqlDataReader r)
        {
            return new ProdutoModel
            {
                ProdutoID = Convert.ToInt32(r["ProdutoID"]),
                NomeProduto = r["NomeProduto"].ToString(),
                Referencia = r["Referencia"]?.ToString(),
                PrecoDeVenda = Convert.ToDecimal(r["PrecoDeVenda"]),
                Estoque = Convert.ToInt32(r["Estoque"]),
                Unidade = r["Unidade"]?.ToString(),
                Marca = r["Marca"]?.ToString()
            };
        }

       

        // =========================
        // PARAMS (inalterado)
        // =========================
        private void PreencherParametros(SqlCommand cmd, ProdutoModel p, bool isInsert)
        {
            cmd.Parameters.Add("@NomeProduto", SqlDbType.NVarChar).Value = (object?)p.NomeProduto ?? DBNull.Value;
            cmd.Parameters.Add("@Referencia", SqlDbType.NVarChar).Value = (object?)p.Referencia ?? DBNull.Value;
            cmd.Parameters.Add("@PrecoCusto", SqlDbType.Decimal).Value = p.PrecoCusto;
            cmd.Parameters.Add("@Lucro", SqlDbType.Decimal).Value = p.Lucro;
            cmd.Parameters.Add("@PrecoDeVenda", SqlDbType.Decimal).Value = p.PrecoDeVenda;
            cmd.Parameters.Add("@Estoque", SqlDbType.Int).Value = p.Estoque;
            cmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = (object?)p.Status ?? DBNull.Value;
            cmd.Parameters.Add("@Situacao", SqlDbType.NVarChar).Value = (object?)p.Situacao ?? DBNull.Value;
            cmd.Parameters.Add("@Unidade", SqlDbType.NVarChar).Value = (object?)p.Unidade ?? DBNull.Value;
            cmd.Parameters.Add("@Marca", SqlDbType.NVarChar).Value = (object?)p.Marca ?? DBNull.Value;
            cmd.Parameters.Add("@DataValidade", SqlDbType.Date).Value = p.DataValidade.HasValue ? p.DataValidade.Value : DBNull.Value;
            cmd.Parameters.Add("@GtinEan", SqlDbType.NVarChar).Value = (object?)p.GtinEan ?? DBNull.Value;
            cmd.Parameters.Add("@Imagem", SqlDbType.VarChar).Value = (object?)p.Imagem ?? DBNull.Value;
            cmd.Parameters.Add("@FornecedorID", SqlDbType.Int).Value = p.FornecedorID.HasValue ? p.FornecedorID.Value : DBNull.Value;

            if (isInsert)
                cmd.Parameters.Add("@DataDeEntrada", SqlDbType.DateTime).Value = p.DataDeEntrada;
        }
    }
}
