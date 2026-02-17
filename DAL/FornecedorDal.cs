using Dapper;
using GVC.Infra.Conexao;
using GVC.Infra.Repository;
using GVC.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GVC.DAL
{
    internal class FornecedorDal : RepositoryBase
    {
        private const string SqlBase = @"
        SELECT
            f.FornecedorID,
            f.Nome,
            f.Cnpj,
            f.IE,
            f.Telefone,
            f.Email,
            f.Logradouro,
            f.Numero,
            f.Bairro,
            f.Cep,
            f.DataCriacao,
            f.Observacoes,
            f.CidadeID,
            ci.Nome AS NomeCidade,
            e.Uf AS Estado
        FROM Fornecedor f
        LEFT JOIN Cidade ci ON ci.CidadeID = f.CidadeID
        LEFT JOIN Estado e ON e.EstadoID = ci.EstadoID
        WHERE f.EmpresaID = @EmpresaID";

        public DataTable ListarFornecedores()
        {
            using var cmd = CreateCommand(SqlBase + " ORDER BY f.Nome");
            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        public bool FornecedorExiste(string? nome, string? cnpj)
        {
            const string sql = @"
            SELECT 1 FROM Fornecedor
            WHERE EmpresaID = @EmpresaID
              AND (Nome = @Nome OR Cnpj = @Cnpj)";

            return Connection.ExecuteScalar<int?>(
                sql,
                new { Nome = nome, Cnpj = cnpj, EmpresaID }
            ) != null;
        }

        public void SalvarFornecedor(FornecedorModel fornecedor)
        {
            if (FornecedorExiste(fornecedor.Fornecedor, fornecedor.Cnpj))
                throw new InvalidOperationException("Fornecedor já cadastrado.");

            const string sql = @"
            INSERT INTO Fornecedor
            (Nome, Cnpj, IE, Telefone, Email, CidadeID,
             Logradouro, Numero, Bairro, Cep, DataCriacao, Observacoes, EmpresaID)
            VALUES
            (@Nome, @Cnpj, @IE, @Telefone, @Email, @CidadeID,
             @Logradouro, @Numero, @Bairro, @Cep, @DataCriacao, @Observacoes, @EmpresaID)";

            Connection.Execute(sql, new
            {
                Nome = fornecedor.Fornecedor,  // ✅ Correto: mapeia Fornecedor para Nome
                fornecedor.Cnpj,
                fornecedor.IE,
                fornecedor.Telefone,
                fornecedor.Email,
                fornecedor.CidadeID,
                fornecedor.Logradouro,
                fornecedor.Numero,
                fornecedor.Bairro,
                fornecedor.Cep,
                DataCriacao = fornecedor.DataCriacao ?? DateTime.Now, // ✅ Valor padrão
                fornecedor.Observacoes,
                EmpresaID  // ✅ Vem da propriedade da RepositoryBase
            });
        }

        public void Atualizar(FornecedorModel fornecedor)
        {
            const string sql = @"
                UPDATE Fornecedor SET
                    Nome = @Nome,
                    Cnpj = @Cnpj,
                    IE = @IE,
                    Telefone = @Telefone,
                    Email = @Email,
                    CidadeID = @CidadeID,
                    Logradouro = @Logradouro,
                    Numero = @Numero,
                    Bairro = @Bairro,
                    Cep = @Cep,
                    Observacoes = @Observacoes,
                    DataCriacao = @DataCriacao
                WHERE FornecedorID = @FornecedorID
                  AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);

            cmd.Parameters.AddWithValue("@FornecedorID", fornecedor.FornecedorID);
            cmd.Parameters.AddWithValue("@Nome", fornecedor.Fornecedor ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Cnpj", fornecedor.Cnpj ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@IE", fornecedor.IE ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Telefone", fornecedor.Telefone ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", fornecedor.Email ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@CidadeID", fornecedor.CidadeID);
            cmd.Parameters.AddWithValue("@Logradouro", fornecedor.Logradouro ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Numero", fornecedor.Numero ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Bairro", fornecedor.Bairro ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Cep", fornecedor.Cep ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Observacoes", fornecedor.Observacoes ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@DataCriacao", fornecedor.DataCriacao ?? DateTime.Now);

            cmd.ExecuteNonQuery();
        }
        public void ExcluirFornecedor(int fornecedorID)
        {
            const string sql = @"
        DELETE FROM Fornecedor
        WHERE FornecedorID = @FornecedorID
          AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@FornecedorID", fornecedorID);
            cmd.ExecuteNonQuery();
        }
        public DataTable PesquisarPorCodigo(int codigo)
        {
            const string sql = SqlBase + " AND f.FornecedorID = @FornecedorID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@FornecedorID", codigo);

            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable PesquisarGeral(string texto = "")
        {
                    const string sql = SqlBase + @"
                AND (
                    f.Nome LIKE @Texto
                    OR f.Cnpj LIKE @Texto
                    OR f.Telefone LIKE @Texto
                    OR f.Email LIKE @Texto
                    OR f.Logradouro LIKE @Texto
                    OR f.Bairro LIKE @Texto
                    OR ci.Nome LIKE @Texto
                )
                ORDER BY f.Nome
                OFFSET 0 ROWS FETCH NEXT 100 ROWS ONLY";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@Texto", $"%{texto?.Trim() ?? ""}%");

            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable PesquisarPorNome(string texto = "")
        {
            const string sql = SqlBase + @"
            AND f.Nome LIKE @Texto
            ORDER BY f.Nome
            OFFSET 0 ROWS FETCH NEXT 100 ROWS ONLY";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@Texto", $"%{texto?.Trim() ?? string.Empty}%");

            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public FornecedorModel? BuscarPorCnpj(string? cnpj)
        {
            const string sql = @"
        SELECT TOP 1 *
        FROM Fornecedor
        WHERE Cnpj = @Cnpj
          AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@Cnpj",
                string.IsNullOrWhiteSpace(cnpj) ? (object)DBNull.Value : cnpj);

            using var dr = cmd.ExecuteReader();
            if (!dr.Read()) return null;

            return new FornecedorModel
            {
                FornecedorID = Convert.ToInt32(dr["FornecedorID"]),
                Fornecedor = dr["Nome"].ToString(),
                Cnpj = dr["Cnpj"].ToString(),
                Telefone = dr["Telefone"].ToString(),
                Email = dr["Email"].ToString()
                // complete conforme seu model
            };
        }
        public FornecedorModel? BuscarPorId(int fornecedorID)
        {
            const string sql = SqlBase + " AND f.FornecedorID = @Id";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@Id", fornecedorID);

            using var dr = cmd.ExecuteReader();
            if (!dr.Read()) return null;

            return new FornecedorModel
            {
                FornecedorID = Convert.ToInt32(dr["FornecedorID"]),
                Fornecedor = dr["Nome"].ToString(),
                Cnpj = dr["Cnpj"].ToString(),
                Telefone = dr["Telefone"].ToString()
            };
        }
        public List<FornecedorModel> Listar()
        {
            const string sql = @"
        SELECT FornecedorID, Nome, Telefone, Cnpj
        FROM Fornecedor
        WHERE EmpresaID = @EmpresaID
        ORDER BY Nome";

            using var cmd = CreateCommand(sql);
            using var dr = cmd.ExecuteReader();

            var lista = new List<FornecedorModel>();
            while (dr.Read())
            {
                lista.Add(new FornecedorModel
                {
                    FornecedorID = Convert.ToInt32(dr["FornecedorID"]),
                    Fornecedor = dr["Nome"].ToString(),
                    Telefone = dr["Telefone"].ToString(),
                    Cnpj = dr["Cnpj"].ToString()
                });
            }

            return lista;
        }

    }
}
