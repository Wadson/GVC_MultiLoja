using GVC.BLL;
using GVC.Model;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GVC.DALL
{
    internal class ClienteDal
    {
        private const string SqlBase = @"
            SELECT
                c.ClienteID,
                c.Nome,
                c.Cpf,
                c.RG,
                c.OrgaoExpedidorRG,
                c.Cnpj,
                c.IE,
                c.Telefone,
                c.Email,
                c.Logradouro,
                c.Numero,
                c.Bairro,
                c.Cep,
                c.DataNascimento,
                c.TipoCliente,
                c.Status,
                c.Observacoes,
                c.DataUltimaCompra,
                c.LimiteCredito,
                c.DataCriacao,
                c.DataAtualizacao,
                c.UsuarioCriacao,
                c.UsuarioAtualizacao,
                c.CidadeID,
                c.IsVendedor,                
                ci.Nome AS NomeCidade,                
                e.Uf AS Estado
            FROM Clientes c
            LEFT JOIN Cidade ci ON ci.CidadeID = c.CidadeID
            LEFT JOIN Estado e ON e.EstadoID = ci.EstadoID";

        // Método auxiliar para executar SQL e retornar DataTable
        private DataTable ExecuteReaderToDataTable(string sql, params SqlParameter[] parameters)
        {
            var dt = new DataTable();
            using (var conn = Conexao.Conex())
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }

        public DataTable ListarClientes()
        {
            const string sql = SqlBase + " ORDER BY c.Nome";
            return ExecuteReaderToDataTable(sql);
        }

        public bool ClienteExiste(string? nome, string? cpf)
        {
            const string sql = @"
                SELECT TOP 1 1
                FROM Clientes
                WHERE (Nome = @Nome OR Cpf = @Cpf)";

            using (var conn = Conexao.Conex())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Nome", string.IsNullOrWhiteSpace(nome) ? (object)DBNull.Value : nome);
                cmd.Parameters.AddWithValue("@Cpf", string.IsNullOrWhiteSpace(cpf) ? (object)DBNull.Value : cpf);

                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != null;
            }
        }

        public void SalvarCliente(ClienteModel cliente)
        {
            if (cliente == null) throw new ArgumentNullException(nameof(cliente));
            if (ClienteExiste(cliente.Nome, cliente.Cpf))
                throw new InvalidOperationException("Já existe um cliente com este nome ou CPF.");

            const string sql = @"
                INSERT INTO Clientes (
                  Nome, Cpf, RG, OrgaoExpedidorRG, Cnpj, IE, Telefone, Email, CidadeID,
                  Logradouro, Numero, Bairro, Cep, DataNascimento, TipoCliente, Status,
                  Observacoes, LimiteCredito, DataCriacao, DataAtualizacao, UsuarioCriacao, UsuarioAtualizacao, IsVendedor
                )
                VALUES (
                  @Nome, @Cpf, @RG, @OrgaoExpedidorRG, @Cnpj, @IE, @Telefone, @Email, @CidadeID,
                  @Logradouro, @Numero, @Bairro, @Cep, @DataNascimento, @TipoCliente, @Status,
                  @Observacoes, @LimiteCredito, @DataCriacao, @DataAtualizacao, @UsuarioCriacao, @UsuarioAtualizacao, @IsVendedor
                );
                SELECT SCOPE_IDENTITY();"; // SQL Server equivalente ao LAST_INSERT_ROWID()

            using (var conn = Conexao.Conex())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Nome", cliente.Nome ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cpf", cliente.Cpf ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@RG", cliente.RG ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@OrgaoExpedidorRG", cliente.OrgaoExpedidorRG ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cnpj", cliente.Cnpj ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IE", cliente.IE ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", cliente.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CidadeID", cliente.CidadeID == 0 ? (object)DBNull.Value : cliente.CidadeID);
                cmd.Parameters.AddWithValue("@Logradouro", cliente.Logradouro ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Numero", cliente.Numero ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Bairro", cliente.Bairro ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cep", cliente.Cep ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
                cmd.Parameters.AddWithValue("@TipoCliente", cliente.TipoCliente ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Status", cliente.Status);
                cmd.Parameters.AddWithValue("@Observacoes", cliente.Observacoes ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@LimiteCredito", cliente.LimiteCredito);
                cmd.Parameters.AddWithValue("@DataCriacao", cliente.DataCriacao);
                cmd.Parameters.AddWithValue("@DataAtualizacao", cliente.DataAtualizacao ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@UsuarioCriacao", cliente.UsuarioCriacao ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@UsuarioAtualizacao", cliente.UsuarioAtualizacao ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IsVendedor", cliente.IsVendedor);


                conn.Open();
                cliente.ClienteID = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void Atualizar(ClienteModel cliente)
        {
            const string sql = @"
                UPDATE Clientes SET
                    Nome = @Nome,
                    Cpf = @Cpf,
                    RG = @RG,
                    OrgaoExpedidorRG = @OrgaoExpedidorRG,
                    Cnpj = @Cnpj,
                   IE = @IE,
                    Telefone = @Telefone,
                    Email = @Email,
                    CidadeID = @CidadeID,
                    Logradouro = @Logradouro,
                    Numero = @Numero,
                    Bairro = @Bairro,
                    Cep = @Cep,
                    DataNascimento = @DataNascimento,
                    TipoCliente = @TipoCliente,
                    Status = @Status,
                    Observacoes = @Observacoes,
                    LimiteCredito = @LimiteCredito,
                    DataAtualizacao = @DataAtualizacao,
                    UsuarioAtualizacao = @UsuarioAtualizacao,
                    IsVendedor = @IsVendedor WHERE ClienteID = @ClienteID";

            using (var conn = Conexao.Conex())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@ClienteID", cliente.ClienteID);
                cmd.Parameters.AddWithValue("@Nome", cliente.Nome ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cpf", cliente.Cpf ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@RG", cliente.RG ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@OrgaoExpedidorRG", cliente.OrgaoExpedidorRG ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cnpj", cliente.Cnpj ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IE", cliente.IE ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", cliente.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CidadeID", cliente.CidadeID == 0 ? (object)DBNull.Value : cliente.CidadeID);
                cmd.Parameters.AddWithValue("@Logradouro", cliente.Logradouro ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Numero", cliente.Numero ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Bairro", cliente.Bairro ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cep", cliente.Cep ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
                cmd.Parameters.AddWithValue("@TipoCliente", cliente.TipoCliente ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Status", cliente.Status);
                cmd.Parameters.AddWithValue("@Observacoes", cliente.Observacoes ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@LimiteCredito", cliente.LimiteCredito);
                cmd.Parameters.AddWithValue("@DataAtualizacao", cliente.DataAtualizacao ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@UsuarioAtualizacao", cliente.UsuarioAtualizacao ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IsVendedor", cliente.IsVendedor);


                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ExcluirCliente(int clienteID)
        {
            const string sql = "DELETE FROM Clientes WHERE ClienteID = @ClienteID";
            using (var conn = Conexao.Conex())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ExcluirCliente(ClienteModel cliente) => ExcluirCliente(cliente.ClienteID);

        public DataTable PesquisarPorNome(string nome)
        {
            const string sql = SqlBase + " WHERE c.Nome LIKE @Nome ORDER BY c.Nome";
            return ExecuteReaderToDataTable(sql,
                new SqlParameter("@Nome", $"%{nome?.Trim()}%"));
        }
        public DataTable PesquisarVendedorPorNome(string nome)
        {
            const string sql = @"
        SELECT c.ClienteID, c.Nome
        FROM Clientes c
        WHERE c.IsVendedor = 1
          AND c.Nome LIKE @Nome
        ORDER BY c.Nome;";

            return ExecuteReaderToDataTable(sql,
                new SqlParameter("@Nome", $"%{nome?.Trim()}%"));
        }

        public DataTable PesquisarPorCodigo(int codigo)
        {
            const string sql = SqlBase + " WHERE c.ClienteID = @ClienteID";
            return ExecuteReaderToDataTable(sql,
                new SqlParameter("@ClienteID", codigo));
        }

        public DataTable ListarPorTipoDePessoa(string tipoCliente)
        {
            const string sql = SqlBase + " WHERE c.TipoCliente = @TipoCliente";
            return ExecuteReaderToDataTable(sql,
                new SqlParameter("@TipoCliente", tipoCliente));
        }

        public DataTable PesquisarGeral(string texto = "")
        {
            const string sql = @"
    SELECT
        c.ClienteID,
        c.Nome,              
        c.Logradouro,
        c.Numero,
        c.Bairro
    FROM Clientes c
    WHERE c.Nome LIKE @Texto 
       OR c.Logradouro LIKE @Texto
       OR c.Numero LIKE @Texto
       OR c.Bairro LIKE @Texto
    ORDER BY c.Nome
    OFFSET 0 ROWS FETCH NEXT 100 ROWS ONLY;";
            // LIMIT -> OFFSET/FETCH

            var filtro = $"%{texto?.Trim() ?? ""}%";
            return ExecuteReaderToDataTable(sql,
                new SqlParameter("@Texto", filtro));
        }
        public DataTable PesquisarVendedores(string texto = "")
        {
            const string sql = @"
        SELECT c.ClienteID, c.Nome
        FROM Clientes c
        WHERE c.IsVendedor = 1
          AND c.Nome LIKE @Texto
        ORDER BY c.Nome
        OFFSET 0 ROWS FETCH NEXT 100 ROWS ONLY;";

            var filtro = $"%{texto?.Trim() ?? ""}%";
            return ExecuteReaderToDataTable(sql,
                new SqlParameter("@Texto", filtro));
        }

        public ClienteModel? BuscarPorCpf(string? cpf)
        {
            const string sql = @"
                SELECT TOP 1 *
                FROM Clientes
                WHERE Cpf = @Cpf";

            using (var conn = Conexao.Conex())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Cpf", string.IsNullOrWhiteSpace(cpf) ? (object)DBNull.Value : cpf);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapCliente(reader);
                    }
                }
            }
            return null;
        }

        public ClienteModel? BuscarPorCnpj(string? cnpj)
        {
            const string sql = @"
                SELECT TOP 1 *
                FROM Clientes
                WHERE Cnpj = @Cnpj";

            using (var conn = Conexao.Conex())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Cnpj", string.IsNullOrWhiteSpace(cnpj) ? (object)DBNull.Value : cnpj);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapCliente(reader);
                    }
                }
            }
            return null;
        }

        public ClienteModel? BuscarPorId(int clienteID)
        {
            string sql = SqlBase + " WHERE c.ClienteID = @Id";
            using (var conn = Conexao.Conex())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Id", clienteID);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapCliente(reader);
                    }
                }
            }
            return null;
        }

        // ========================= NOVA TELA DE VENDAS =========================
        public List<Cliente> Listar()
        {
            const string sql = @"SELECT ClienteID, Nome, Telefone, Cpf 
                                 FROM Clientes ORDER BY Nome";

            var lista = new List<Cliente>();
            using (var conn = Conexao.Conex())
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Cliente
                        {
                            ClienteID = reader.GetInt32(reader.GetOrdinal("ClienteID")),
                            Nome = reader["Nome"].ToString() ?? "",
                            Telefone = reader["Telefone"].ToString() ?? "",
                            CPF = reader["Cpf"].ToString() ?? ""
                        });
                    }
                }
            }
            return lista;
        }

        // Método auxiliar para mapear ClienteModel a partir de SqlDataReader
        private ClienteModel MapCliente(SqlDataReader reader)
        {
            var cliente = new ClienteModel
            {
                ClienteID = reader.GetInt32(reader.GetOrdinal("ClienteID")),
                Nome = reader["Nome"].ToString() ?? "",
                Cpf = reader["Cpf"].ToString() ?? "",
                RG = reader["RG"].ToString(),
                OrgaoExpedidorRG = reader["OrgaoExpedidorRG"].ToString(),
                Cnpj = reader["Cnpj"].ToString(),
               IE = reader["IE"].ToString(),
                Telefone = reader["Telefone"].ToString(),
                Email = reader["Email"].ToString(),
                Logradouro = reader["Logradouro"].ToString(),
                Numero = reader["Numero"].ToString(),
                Bairro = reader["Bairro"].ToString(),
                Cep = reader["Cep"].ToString(),
                TipoCliente = reader["TipoCliente"].ToString(),
                Status = reader["Status"] != DBNull.Value ? Convert.ToInt64(reader["Status"]) : 0,
                Observacoes = reader["Observacoes"].ToString(),
                UsuarioCriacao = reader["UsuarioCriacao"].ToString(),
                UsuarioAtualizacao = reader["UsuarioAtualizacao"].ToString(),
                IsVendedor = reader["IsVendedor"] != DBNull.Value ? Convert.ToBoolean(reader["IsVendedor"]) : null,                
                // Adicione os demais campos conforme sua classe ClienteModel
            };
            return cliente;
        }
        public List<ClienteModel> ListarClienteDinamico(string filtro = "")
        {
            var lista = new List<ClienteModel>();

            using (var conn = Conexao.Conex())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
            SELECT ClienteID, Nome
            FROM Clientes
            WHERE IsVendedor = 0
              AND Status = 1
              AND Nome LIKE @filtro
            ORDER BY Nome";

                cmd.Parameters.AddWithValue("@filtro", $"%{filtro}%");

                conn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new ClienteModel
                        {
                            ClienteID = dr.GetInt32(0),
                            Nome = dr.GetString(1)
                        });
                    }
                }
            }

            return lista;
        }

        public List<ClienteModel> ListarVendedores(string filtro = "")
        {
            var lista = new List<ClienteModel>();

            using (var conn = Conexao.Conex())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
            SELECT ClienteID, Nome
            FROM Clientes
            WHERE IsVendedor = 1
              AND Status = 1
              AND Nome LIKE @filtro
            ORDER BY Nome";

                cmd.Parameters.AddWithValue("@filtro", $"%{filtro}%");

                conn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new ClienteModel
                        {
                            ClienteID = dr.GetInt32(0),
                            Nome = dr.GetString(1)
                        });
                    }
                }
            }

            return lista;
        }

    }

    // Classe simples para lista de vendas
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; } = "";
        public string Telefone { get; set; } = "";
        public string CPF { get; set; } = "";
    }
}
