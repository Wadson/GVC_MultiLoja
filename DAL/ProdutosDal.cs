using Dapper;
using GVC.Helpers;
using GVC.MODEL;
using Microsoft.Data.SqlClient; // Alterado para SQL Server
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace GVC.DAL
{
    public class ProdutoDALL
    {
        private const string SqlBase = @"SELECT 
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
    COALESCE(f.Nome, '') AS NomeFornecedor
FROM Produtos p
LEFT JOIN Fornecedor f ON p.FornecedorID = f.FornecedorID";

        private readonly string _connectionString = GVC.Helpers.Conexao.Conex().ConnectionString;

        // ==================== LISTAR TODOS ====================
        public List<ProdutosModel> ListarTodos()
        {
            var lista = new List<ProdutosModel>();
            using (var con = new SqlConnection(_connectionString)) // Alterado para SqlConnection
            {
                // SQL Server usa TOP para limitar resultados
                string sql = @"SELECT TOP 100 
                                p.ProdutoID, p.NomeProduto, p.Referencia, p.PrecoCusto, p.Lucro, 
                                p.PrecoDeVenda, p.Estoque, p.DataDeEntrada, p.Status, p.Situacao, 
                                p.Unidade, p.Marca, p.DataValidade, p.GtinEan, p.Imagem, p.FornecedorID,
                                COALESCE(f.Nome, '') AS NomeFornecedor
                                FROM Produtos p
                                LEFT JOIN Fornecedor f ON p.FornecedorID = f.FornecedorID
                                ORDER BY p.NomeProduto";

                using (var cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(Mapear(reader));
                        }
                    }
                }
            }
            return lista;
        }
        public List<ProdutosModel> ListarProdutoDinamico(string filtro = "")
        {
            var lista = new List<ProdutosModel>();

            using (var conn = Helpers.Conexao.Conex())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
            SELECT ProdutoID, NomeProduto
            FROM Produtos
            WHERE NomeProduto LIKE @filtro           
              AND Status = Ativo
              AND NomeProduto LIKE @filtro
            ORDER BY NomeProduto";

                cmd.Parameters.AddWithValue("@filtro", $"%{filtro}%");

                conn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new ProdutosModel
                        {
                            ProdutoID = dr.GetInt32(0),
                            NomeProduto = dr.GetString(1)
                        });
                    }
                }
            }

            return lista;
        }
        // ==================== BUSCAR POR ID ====================
        public ProdutosModel? BuscarPorId(long id)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Produtos WHERE ProdutoID = @id";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return Mapear(reader);
                    }
                }
            }
            return null;
        }

        // ==================== INSERIR ====================
        public long Inserir(ProdutosModel produto)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                // Alterado last_insert_rowid() para SCOPE_IDENTITY()
                string sql = @"INSERT INTO Produtos 
                    (NomeProduto, Referencia, PrecoCusto, Lucro, PrecoDeVenda, Estoque, DataDeEntrada, 
                     Status, Situacao, Unidade, Marca, DataValidade, GtinEan, Imagem, FornecedorID)
                    VALUES (@NomeProduto, @Referencia, @Custo, @Lucro, @Venda, @Estoque, @Entrada, 
                     @Status, @Situacao, @Unidade, @Marca, @Validade, @Gtin, @Imagem, @FornecedorID); 
                    SELECT CAST(SCOPE_IDENTITY() AS BIGINT);";

                using (var cmd = new SqlCommand(sql, con))
                {
                    AdicionarParametros(cmd, produto);
                    con.Open();
                    // SCOPE_IDENTITY retorna decimal por padrão, por isso o CAST no SQL e no C#
                    return (long)cmd.ExecuteScalar();
                }
            }
        }

        // ==================== ATUALIZAR ====================
        public bool Alterar(ProdutosModel produto)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                string sql = @"UPDATE Produtos SET NomeProduto = @NomeProduto, Referencia = @Referencia, PrecoCusto = @Custo, Lucro = @Lucro,
                    PrecoDeVenda = @Venda, Estoque = @Estoque, 
                    Status = @Status, Situacao = @Situacao, Unidade = @Unidade, Marca = @Marca,
                    DataValidade = @Validade, GtinEan = @Gtin, Imagem = @Imagem, FornecedorID = @FornecedorID
                    WHERE ProdutoID = @Id";

                using (var cmd = new SqlCommand(sql, con))
                {
                    AdicionarParametros(cmd, produto);
                    cmd.Parameters.AddWithValue("@Id", produto.ProdutoID);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ==================== EXCLUIR ====================
        public bool Excluir(long id)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM Produtos WHERE ProdutoID = @id";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ==================== MÉTODO AUXILIAR MAPEAR ====================
        private ProdutosModel Mapear(SqlDataReader reader)
        {
            return new ProdutosModel
            {
                ProdutoID = Convert.ToInt32(reader["ProdutoID"]),
                NomeProduto = reader["NomeProduto"].ToString(),
                Referencia = reader["Referencia"]?.ToString() ?? "",
                PrecoCusto = Convert.ToDecimal(reader["PrecoCusto"]),
                Lucro = Convert.ToDecimal(reader["Lucro"]),
                PrecoDeVenda = Convert.ToDecimal(reader["PrecoDeVenda"]),
                Estoque = Convert.ToInt64(reader["Estoque"]),
                DataDeEntrada = Convert.ToDateTime(reader["DataDeEntrada"]),
                Status = reader["Status"].ToString(),
                Situacao = reader["Situacao"]?.ToString() ?? "",
                Unidade = reader["Unidade"]?.ToString() ?? "",
                Marca = reader["Marca"]?.ToString() ?? "",
                DataValidade = reader["DataValidade"] != DBNull.Value ? Convert.ToDateTime(reader["DataValidade"]) : (DateTime?)null,
                GtinEan = reader["GtinEan"]?.ToString() ?? "",
                Imagem = reader["Imagem"]?.ToString() ?? "",
                FornecedorID = reader["FornecedorID"] != DBNull.Value ? Convert.ToInt64(reader["FornecedorID"]) : 0,
                Fornecedor = reader.HasColumn("NomeFornecedor") ? reader["NomeFornecedor"].ToString() ?? "" : ""
            };
        }

        // ==================== PESQUISAR POR NOME ====================
        public List<ProdutosModel> PesquisarProdutoPorNome(string nome)
        {
            var lista = new List<ProdutosModel>();
            // SqlServer usa TOP em vez de LIMIT
            string sql = @"SELECT TOP 100 p.*, COALESCE(f.Nome, '') AS NomeFornecedor 
                           FROM Produtos p LEFT JOIN Fornecedor f ON p.FornecedorID = f.FornecedorID
                           WHERE p.NomeProduto LIKE @nome 
                           ORDER BY p.NomeProduto";

            using (var con = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@nome", $"%{nome}%");
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(Mapear(reader));
                        }
                    }
                }
            }
            return lista;
        }
        public void BaixarEstoque(long produtoId, int quantidade, SqlTransaction tran)
        {
            string sql = @"UPDATE ProdutosSET Estoque = Estoque - @Quantidade
                        WHERE ProdutoID = @ProdutoID AND Estoque >= @Quantidade";

            using (var con = new SqlConnection(_connectionString))
            {
                using var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Quantidade", quantidade);
                cmd.Parameters.AddWithValue("@ProdutoID", produtoId);

                int linhas = cmd.ExecuteNonQuery();
                if (linhas == 0)
                    throw new Exception("Estoque insuficiente para o produto.");
            }            
        }

        // ==================== PESQUISAR POR CÓDIGO (Busca parcial) ====================
        public List<ProdutosModel> PesquisarProdutoPorCodigo(string codigo)
        {
            var lista = new List<ProdutosModel>();
            string sql = @"SELECT TOP 100 p.*, COALESCE(f.Nome, '') AS NomeFornecedor 
                           FROM Produtos p LEFT JOIN Fornecedor f ON p.FornecedorID = f.FornecedorID
                           WHERE CAST(p.ProdutoID AS VARCHAR) LIKE @codigo
                              OR p.Referencia LIKE @codigo
                           ORDER BY p.ProdutoID";

            using (var con = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@codigo", $"%{codigo}%");
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(Mapear(reader));
                        }
                    }
                }
            }
            return lista;
        }

        // ==================== PESQUISAR POR CÓDIGO (DataTable/Dapper) ====================
        public DataTable PesquisarPorCodigo(int codigo)
        {
            const string sql = SqlBase + " WHERE p.ProdutoID = @ProdutoID";
            using var conn = new SqlConnection(_connectionString);
            var dt = new DataTable();
            conn.Open();
            // Dapper permite carregar o reader direto no DataTable
            using (var reader = conn.ExecuteReader(sql, new { ProdutoID = codigo }))
            {
                dt.Load(reader);
            }
            return dt;
        }

        private void AdicionarParametros(SqlCommand cmd, ProdutosModel p)
        {
            cmd.Parameters.AddWithValue("@NomeProduto", p.NomeProduto ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Referencia", p.Referencia ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Custo", p.PrecoCusto);
            cmd.Parameters.AddWithValue("@Lucro", p.Lucro);
            cmd.Parameters.AddWithValue("@Venda", p.PrecoDeVenda);
            cmd.Parameters.AddWithValue("@Estoque", p.Estoque);
            cmd.Parameters.AddWithValue("@Entrada", p.DataDeEntrada);
            cmd.Parameters.AddWithValue("@Status", p.Status ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Situacao", p.Situacao ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Unidade", p.Unidade ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Marca", p.Marca ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Validade", p.DataValidade.HasValue ? (object)p.DataValidade.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@Gtin", p.GtinEan ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Imagem", p.Imagem ?? (object)DBNull.Value);

            if (p.FornecedorID > 0)
                cmd.Parameters.AddWithValue("@FornecedorID", p.FornecedorID);
            else
                cmd.Parameters.AddWithValue("@FornecedorID", DBNull.Value);
        }

    }


    // Helper para verificar se a coluna existe no reader
    public static class DataReaderExtensions
    {
        public static bool HasColumn(this IDataRecord dr, string columnName)
        {
            for (int i = 0; i < dr.FieldCount; i++)
            {
                if (dr.GetName(i).Equals(columnName, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}