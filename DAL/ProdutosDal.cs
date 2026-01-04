using Dapper;
using GVC.Model;
using GVC.UTIL;
using Microsoft.Data.SqlClient; // Alterado para SQL Server
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
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

        private readonly string _connectionString = Conexao.Conex().ConnectionString;

        // ==================== LISTAR TODOS ====================
        public List<ProdutoModel> ListarTodos()
        {
            var lista = new List<ProdutoModel>();
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
ORDER BY p.NomeProduto;
";

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
        public List<ProdutoModel> ListarProdutosVenda()
        {
            var lista = new List<ProdutoModel>();
            using (var con = new SqlConnection(_connectionString)) // Alterado para SqlConnection
            {
                // SQL Server usa TOP para limitar resultados
                string sql = @"
                            SELECT TOP 100 
                                ProdutoID, 
                                NomeProduto, 
                                Referencia,
                                PrecoDeVenda, 
                                Estoque, 
                                Unidade, 
                                Marca
                            FROM Produtos
                            ORDER BY NomeProduto;";

                using (var cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(MapearPesquisaProdutoVenda(reader));
                        }
                    }
                }
            }
            return lista;
        }
        public List<ProdutoModel> ListarProdutoDinamico(string filtro = "")
        {
            var lista = new List<ProdutoModel>();

            using (var conn = Conexao.Conex())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
    SELECT 
         ProdutoID,
         NomeProduto,
         Unidade,
         PrecoDeVenda
     FROM Produtos
    WHERE Status = 'Disponível' 
      AND Situacao = 'Ativo' 
      AND NomeProduto COLLATE Latin1_General_CI_AI LIKE @filtro
    ORDER BY NomeProduto";


                cmd.Parameters.AddWithValue("@filtro", $"%{filtro}%");

                conn.Open();
                using (var dr = cmd.ExecuteReader())
                {
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
                }
            }

            return lista;
        }
        // ==================== BUSCAR POR ID ====================
        public ProdutoModel? BuscarPorId(long id)
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
        public long Inserir(ProdutoModel produto)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                // Alterado last_insert_rowid() para SCOPE_IDENTITY()
                string sql = @"INSERT INTO Produtos 
                    (NomeProduto, Referencia, PrecoCusto, Lucro, PrecoDeVenda, Estoque, DataDeEntrada, 
                     Status, Situacao, Unidade, Marca, DataValidade, GtinEan, Imagem)
                    VALUES (@NomeProduto, @Referencia, @Custo, @Lucro, @PrecoDeVenda, @Estoque, @DataDeEntrada, 
                     @Status, @Situacao, @Unidade, @Marca, @Validade, @Gtin, @Imagem); 
                    SELECT CAST(SCOPE_IDENTITY() AS BIGINT);";

                using (var cmd = new SqlCommand(sql, con))
                {
                    AdicionarParametros(cmd, produto, true);
                    con.Open();
                    // SCOPE_IDENTITY retorna decimal por padrão, por isso o CAST no SQL e no C#
                    return (long)cmd.ExecuteScalar();
                }
            }
        }

        // ==================== ATUALIZAR ====================
        public bool Alterar(ProdutoModel produto)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                string sql = @"
UPDATE Produtos SET 
    NomeProduto     = @NomeProduto,
    Referencia      = @Referencia,
    PrecoCusto      = @Custo,
    Lucro           = @Lucro,
    PrecoDeVenda    = @PrecoDeVenda,
    Estoque         = @Estoque,  
    Status          = @Status,
    Situacao        = @Situacao,
    Unidade         = @Unidade,
    Marca           = @Marca,
    DataValidade    = @Validade,
    GtinEan         = @Gtin,
    Imagem          = @Imagem,
    FornecedorID    = @FornecedorID
WHERE ProdutoID = @Id";


                using (var cmd = new SqlCommand(sql, con))
                {
                    AdicionarParametros(cmd, produto,false);
                    cmd.Parameters.AddWithValue("@Id", produto.ProdutoID);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        private void AdicionarParametros(SqlCommand cmd, ProdutoModel p,bool isInsert)
        {
            cmd.Parameters.AddWithValue("@NomeProduto", p.NomeProduto ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Referencia", p.Referencia ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Custo", p.PrecoCusto);
            cmd.Parameters.AddWithValue("@Lucro", p.Lucro);
            cmd.Parameters.AddWithValue("@PrecoDeVenda", p.PrecoDeVenda);
            cmd.Parameters.AddWithValue("@Estoque", p.Estoque);
            //cmd.Parameters.AddWithValue("@DataDeEntrada",p.DataDeEntrada < (DateTime)SqlDateTime.MinValue ? (object)DBNull.Value : p.DataDeEntrada);

            if (isInsert)
            { 
                //Só no cadastro 
                    cmd.Parameters.AddWithValue("@DataDeEntrada", p.DataDeEntrada);              
            }

                cmd.Parameters.AddWithValue("@FornecedorID", p.FornecedorID.HasValue ? (object)p.FornecedorID.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@Status", p.Status ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Situacao", p.Situacao ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Unidade", p.Unidade ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Marca", p.Marca ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Validade", p.DataValidade.HasValue ? (object)p.DataValidade.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@Gtin", p.GtinEan ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Imagem", p.Imagem ?? (object)DBNull.Value);
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
        private ProdutoModel Mapear(SqlDataReader reader)
        {
            return new ProdutoModel
            {
                ProdutoID = Convert.ToInt32(reader["ProdutoID"]),
                NomeProduto = reader["NomeProduto"].ToString(),
                Referencia = reader["Referencia"]?.ToString() ?? "",
                PrecoCusto = Convert.ToDecimal(reader["PrecoCusto"]),
                Lucro = Convert.ToDecimal(reader["Lucro"]),
                PrecoDeVenda = Convert.ToDecimal(reader["PrecoDeVenda"]),
                Estoque = Convert.ToInt32(reader["Estoque"]),
                DataDeEntrada = Convert.ToDateTime(reader["DataDeEntrada"]),
                Status = reader["Status"].ToString(),
                Situacao = reader["Situacao"]?.ToString() ?? "",
                Unidade = reader["Unidade"]?.ToString() ?? "",
                Marca = reader["Marca"]?.ToString() ?? "",
                DataValidade = reader["DataValidade"] != DBNull.Value ? Convert.ToDateTime(reader["DataValidade"]) : (DateTime?)null,
                GtinEan = reader["GtinEan"]?.ToString() ?? "",
                Imagem = reader["Imagem"]?.ToString() ?? "",
                FornecedorID = reader["FornecedorID"] != DBNull.Value ? Convert.ToInt32(reader["FornecedorID"]) : 0,
                Fornecedor = reader.HasColumn("NomeFornecedor")? new FornecedorModel{Nome = reader["NomeFornecedor"].ToString() ?? "" }: null

            };
        }
        private ProdutoModel MapearPesquisaProdutoVenda(SqlDataReader reader)
        {
            return new ProdutoModel
            {
                ProdutoID = reader.IsDBNull(reader.GetOrdinal("ProdutoID")) ? 0 : Convert.ToInt32(reader["ProdutoID"]),
                NomeProduto = reader.IsDBNull(reader.GetOrdinal("NomeProduto")) ? string.Empty : reader["NomeProduto"]?.ToString() ?? string.Empty,
                Referencia = reader.IsDBNull(reader.GetOrdinal("Referencia")) ? string.Empty : reader["Referencia"]?.ToString() ?? string.Empty,
                PrecoDeVenda = reader.IsDBNull(reader.GetOrdinal("PrecoDeVenda")) ? 0m : Convert.ToDecimal(reader["PrecoDeVenda"]),
                Estoque = (int)(reader.IsDBNull(reader.GetOrdinal("Estoque")) ? 0m : (reader["Estoque"])),
                Unidade = reader.IsDBNull(reader.GetOrdinal("Unidade")) ? string.Empty : reader["Unidade"]?.ToString() ?? string.Empty,
                Marca = reader.IsDBNull(reader.GetOrdinal("Marca")) ? string.Empty : reader["Marca"]?.ToString() ?? string.Empty,
            };
        }

        // ==================== PESQUISAR POR NOME ====================
        public List<ProdutoModel> PesquisarProdutoPorNome(string nome)
        {
            var lista = new List<ProdutoModel>();
            // SqlServer usa TOP em vez de LIMIT
            string sql = @"
SELECT TOP 100 
    p.ProdutoID, p.NomeProduto, p.Referencia, p.PrecoCusto, p.Lucro, 
    p.PrecoDeVenda, p.Estoque, p.DataDeEntrada, p.Status, p.Situacao, 
    p.Unidade, p.Marca, p.DataValidade, p.GtinEan, p.Imagem, p.FornecedorID,
    COALESCE(f.Nome, '') AS NomeFornecedor
FROM Produtos p
LEFT JOIN Fornecedor f ON p.FornecedorID = f.FornecedorID
WHERE p.NomeProduto LIKE @nome
ORDER BY p.NomeProduto;";


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
        public List<ProdutoModel> PesquisarProdutoPorCodigo(string codigo)
        {
            var lista = new List<ProdutoModel>();
            string sql = @"
SELECT TOP 100 
    p.ProdutoID, p.NomeProduto, p.Referencia, p.PrecoCusto, p.Lucro, 
    p.PrecoDeVenda, p.Estoque, p.DataDeEntrada, p.Status, p.Situacao, 
    p.Unidade, p.Marca, p.DataValidade, p.GtinEan, p.Imagem, p.FornecedorID,
    COALESCE(f.Nome, '') AS NomeFornecedor
FROM Produtos p
LEFT JOIN Fornecedor f ON p.FornecedorID = f.FornecedorID
WHERE p.NomeProduto LIKE @codigo
   OR CAST(p.ProdutoID AS VARCHAR) LIKE @codigo
   OR p.Referencia LIKE @codigo
ORDER BY p.ProdutoID;";


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