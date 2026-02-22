// GVC.Infra.Repository\VendedorRepository.cs

using System;
using System.Data;
using Microsoft.Data.SqlClient;
using GVC.DOMAIN.Models;
using System.Collections.Generic;

namespace GVC.Infra.Repository
{
    public class VendedorRepository : RepositoryBase
    {

        public int ContarTotal()
        {
            var cmd = CreateCommand(@"SELECT COUNT(*) FROM Vendedores WHERE EmpresaID = @EmpresaID");
            cmd.ExecuteNonQuery();

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        private const string SqlBase = @"
            SELECT 
            v.VendedorID,
            v.Nome,
            v.CPF,
            v.RG,
            v.Telefone,
            v.Email,
            v.DataNascimento,
            v.DataContratacao,
            v.Comissao,
            v.Endereco,
            v.Numero,
            v.Bairro,
            v.CidadeID,
            c.Nome AS NomeCidade, -- nome da cidade
            v.UF,
            v.CEP,
            v.Observacoes,
            v.Status,
            v.EmpresaID,
            v.DataCriacao,
            v.DataAtualizacao,
            v.UsuarioCriacao,
            v.UsuarioAtualizacao
        FROM Vendedores v
        LEFT JOIN Cidade c ON v.CidadeID = c.CidadeID
        WHERE v.EmpresaID = @EmpresaID";

        public VendedorRepository() : base() { }
        public VendedorRepository(SqlConnection connection) : base(connection) { }

        public DataTable ListarTodos()
        {
            string sql = SqlBase + " ORDER BY Nome";

            using (var cmd = CreateCommand(sql))
            {
                var dt = new DataTable();
                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                return dt;
            }
        }

        public DataTable PesquisarPorNome(string nome)
        {
            // Use v.Nome para especificar a tabela correta
            string sql = SqlBase + " AND v.Nome LIKE @Nome AND v.Status = 1 ORDER BY v.Nome";

            using (var cmd = CreateCommand(sql))
            {
                cmd.Parameters.AddWithValue("@Nome", $"%{nome.Trim()}%");

                var dt = new DataTable();
                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                return dt;
            }
        }

        public VendedorModel ObterPorId(int id)
        {
            string sql = SqlBase + " AND VendedorID = @VendedorID";

            using (var cmd = CreateCommand(sql))
            {
                cmd.Parameters.AddWithValue("@VendedorID", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapToModel(reader);
                    }
                }
            }
            return null;
        }

        public int Inserir(VendedorModel vendedor)
        {
            string sql = @"
                INSERT INTO Vendedores (
                    Nome, CPF, RG, Telefone, Email, DataNascimento, 
                    DataContratacao, Comissao, Endereco, Bairro, CidadeID, UF, CEP,
                    Observacoes, Status, EmpresaID, UsuarioCriacao
                ) VALUES (
                    @Nome, @CPF, @RG, @Telefone, @Email, @DataNascimento,
                    @DataContratacao, @Comissao, @Endereco, @Bairro, @CidadeID, @UF, @CEP,
                    @Observacoes, @Status, @EmpresaID, @UsuarioCriacao
                );
                SELECT SCOPE_IDENTITY();";

            using (var cmd = CreateCommand(sql))
            {
                PreencherParametros(cmd, vendedor, true);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void Atualizar(VendedorModel vendedor)
        {
            string sql = @"
                UPDATE Vendedores SET
                    Nome = @Nome,
                    CPF = @CPF,
                    RG = @RG,
                    Telefone = @Telefone,
                    Email = @Email,
                    DataNascimento = @DataNascimento,
                    DataContratacao = @DataContratacao,
                    Comissao = @Comissao,
                    Endereco = @Endereco,
                    Bairro = @Bairro,
                    CidadeID = @CidadeID,
                    UF = @UF,
                    CEP = @CEP,
                    Observacoes = @Observacoes,
                    Status = @Status,
                    DataAtualizacao = GETDATE(),
                    UsuarioAtualizacao = @UsuarioAtualizacao
                WHERE VendedorID = @VendedorID AND EmpresaID = @EmpresaID";

            using (var cmd = CreateCommand(sql))
            {
                PreencherParametros(cmd, vendedor, false);
                cmd.Parameters.AddWithValue("@VendedorID", vendedor.VendedorID);
                cmd.ExecuteNonQuery();
            }
        }

        public void Excluir(int id)
        {
            string sql = "DELETE FROM Vendedores WHERE VendedorID = @VendedorID AND EmpresaID = @EmpresaID";

            using (var cmd = CreateCommand(sql))
            {
                cmd.Parameters.AddWithValue("@VendedorID", id);
                cmd.ExecuteNonQuery();
            }
        }

        private void PreencherParametros(SqlCommand cmd, VendedorModel v, bool isInsert)
        {
            cmd.Parameters.AddWithValue("@Nome", v.Nome);
            cmd.Parameters.AddWithValue("@CPF", (object)v.CPF ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@RG", (object)v.RG ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Telefone", (object)v.Telefone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object)v.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@DataNascimento", (object)v.DataNascimento ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@DataContratacao", (object)v.DataContratacao ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Comissao", (object)v.Comissao ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Endereco", (object)v.Endereco ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Bairro", (object)v.Bairro ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@CidadeID", v.CidadeID);
            cmd.Parameters.AddWithValue("@UF", (object)v.UF ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@CEP", (object)v.CEP ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Observacoes", (object)v.Observacoes ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Status", v.Status);

            if (isInsert)
            {
                cmd.Parameters.Add("@DataCriacao", SqlDbType.DateTime).Value = v.DataCriacao;
                cmd.Parameters.Add("@UsuarioCriacao", SqlDbType.NVarChar).Value = v.UsuarioCriacao;
            }
            else
            {
                cmd.Parameters.Add("@DataAtualizacao", SqlDbType.DateTime).Value = v.DataAtualizacao;
                cmd.Parameters.Add("@UsuarioAtualizacao", SqlDbType.NVarChar).Value = v.UsuarioAtualizacao;
            }
        }

        private VendedorModel MapToModel(SqlDataReader reader)
        {
            return new VendedorModel
            {
                VendedorID = Convert.ToInt32(reader["VendedorID"]),
                Nome = reader["Nome"].ToString(),
                CPF = reader["CPF"]?.ToString(),
                RG = reader["RG"]?.ToString(),
                Telefone = reader["Telefone"]?.ToString(),
                Email = reader["Email"]?.ToString(),
                DataNascimento = reader["DataNascimento"] as DateTime?,
                DataContratacao = reader["DataContratacao"] as DateTime?,
                Comissao = reader["Comissao"] as decimal?,
                Endereco = reader["Endereco"]?.ToString(),
                Bairro = reader["Bairro"]?.ToString(),
                CidadeID = Convert.ToInt32(reader["CidadeID"]),
                UF = reader["UF"]?.ToString(),
                CEP = reader["CEP"]?.ToString(),
                Observacoes = reader["Observacoes"]?.ToString(),
                Status = Convert.ToInt32(reader["Status"]),
                EmpresaID = Convert.ToInt32(reader["EmpresaID"]),
                DataCriacao = Convert.ToDateTime(reader["DataCriacao"]),
                DataAtualizacao = reader["DataAtualizacao"] as DateTime?,
                UsuarioCriacao = reader["UsuarioCriacao"]?.ToString(),
                UsuarioAtualizacao = reader["UsuarioAtualizacao"]?.ToString()
            };
        }
    }
}