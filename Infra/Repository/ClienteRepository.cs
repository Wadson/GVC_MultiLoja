using GVC.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace GVC.Infra.Repository
{
    public class ClienteRepository : RepositoryBase
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
                c.IsVendedor
            FROM Clientes c
            WHERE c.EmpresaID = @EmpresaID";

        // =========================
        // AUXILIAR
        // =========================
        private DataTable ExecuteDataTable(string sql, params SqlParameter[] parameters)
        {
            using var cmd = CreateCommand(sql);

            if (parameters?.Length > 0)
                cmd.Parameters.AddRange(parameters);

            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // =========================
        // LISTAR
        // =========================
        public DataTable ListarClientes()
            => ExecuteDataTable(SqlBase + " ORDER BY c.Nome");

        public DataTable ListarVendedores()
            => ExecuteDataTable(SqlBase + " AND c.IsVendedor = 1 ORDER BY c.Nome");

        // =========================
        // EXISTE
        // =========================
        public bool ClienteExiste(string? nome, string? cpf)
        {
            const string sql = @"
                SELECT 1
                FROM Clientes
                WHERE EmpresaID = @EmpresaID
                  AND (
                        (@Nome IS NOT NULL AND Nome = @Nome)
                     OR (@Cpf IS NOT NULL AND Cpf = @Cpf)
                  )";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = (object?)nome ?? DBNull.Value;
            cmd.Parameters.Add("@Cpf", SqlDbType.NVarChar).Value = (object?)cpf ?? DBNull.Value;

            return cmd.ExecuteScalar() != null;
        }

        // =========================
        // INSERT
        // =========================
        public int Salvar(ClienteModel cliente)
        {
            const string sql = @"
                INSERT INTO Clientes (
                    Nome, Cpf, RG, OrgaoExpedidorRG, Cnpj, IE, Telefone, Email,
                    CidadeID, Logradouro, Numero, Bairro, Cep, DataNascimento,
                    TipoCliente, Status, Observacoes, LimiteCredito,
                    DataCriacao, UsuarioCriacao,
                    IsVendedor, EmpresaID
                )
                VALUES (
                    @Nome, @Cpf, @RG, @OrgaoExpedidorRG, @Cnpj, @IE, @Telefone, @Email,
                    @CidadeID, @Logradouro, @Numero, @Bairro, @Cep, @DataNascimento,
                    @TipoCliente, @Status, @Observacoes, @LimiteCredito,
                    @DataCriacao, @UsuarioCriacao,
                    @IsVendedor, @EmpresaID
                );
                SELECT SCOPE_IDENTITY();";

            using var cmd = CreateCommand(sql);
            PreencherParametros(cmd, cliente, isInsert: true);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        // =========================
        // UPDATE
        // =========================
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
                    IsVendedor = @IsVendedor
                WHERE ClienteID = @ClienteID
                  AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.Add("@ClienteID", SqlDbType.Int).Value = cliente.ClienteID;

            PreencherParametros(cmd, cliente, isInsert: false);
            cmd.ExecuteNonQuery();
        }

        // =========================
        // DELETE
        // =========================
        public void Excluir(int clienteId)
        {
            using var cmd = CreateCommand(
                "DELETE FROM Clientes WHERE ClienteID = @ID AND EmpresaID = @EmpresaID");

            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = clienteId;
            cmd.ExecuteNonQuery();
        }

        // =========================
        // PESQUISAS
        // =========================
        public DataTable PesquisarPorNome(string nome)
            => ExecuteDataTable(
                SqlBase + " AND c.Nome LIKE @Nome ORDER BY c.Nome",
                new SqlParameter("@Nome", $"%{nome.Trim()}%"));

        public DataTable PesquisarVendedores(string nome = "")
            => ExecuteDataTable(
                SqlBase + " AND c.IsVendedor = 1 AND c.Nome LIKE @Nome ORDER BY c.Nome",
                new SqlParameter("@Nome", $"%{nome.Trim()}%"));

        //public ClienteModel? BuscarPorId(int id)
        //{
        //    using var cmd = CreateCommand(SqlBase + " AND c.ClienteID = @ID");
        //    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;

        //    using var dr = cmd.ExecuteReader();
        //    return dr.Read() ? Mapear(dr) : null;
        //}
        public ClienteModel BuscarPorId(int clienteId)
        {
            const string sql = @"
            SELECT
                ClienteID,
                Nome
            FROM Clientes
            WHERE ClienteID = @ClienteID
              AND EmpresaID = @EmpresaID";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@ClienteID", clienteId);

            using var dr = cmd.ExecuteReader();
            if (!dr.Read())
                return null;

            return new ClienteModel
            {
                ClienteID = dr.GetInt32(dr.GetOrdinal("ClienteID")),
                Nome = dr.GetString(dr.GetOrdinal("Nome"))
            };
        }
        // =========================
        // MAP
        // =========================
        private static ClienteModel Mapear(SqlDataReader r)
        {
            return new ClienteModel
            {
                ClienteID = Convert.ToInt32(r["ClienteID"]),
                Nome = r["Nome"].ToString(),
                Cpf = r["Cpf"] as string,
                RG = r["RG"] as string,
                OrgaoExpedidorRG = r["OrgaoExpedidorRG"] as string,
                Cnpj = r["Cnpj"] as string,
                IE = r["IE"] as string,
                Telefone = r["Telefone"] as string,
                Email = r["Email"] as string,
                CidadeID = r["CidadeID"] == DBNull.Value ? 0 : Convert.ToInt32(r["CidadeID"]),
                Logradouro = r["Logradouro"] as string,
                Numero = r["Numero"] as string,
                Bairro = r["Bairro"] as string,
                Cep = r["Cep"] as string,
                DataNascimento = r["DataNascimento"] as DateTime?,
                TipoCliente = r["TipoCliente"] as string,
                Status = Convert.ToInt32(r["Status"]),
                Observacoes = r["Observacoes"] as string,
                LimiteCredito = Convert.ToDecimal(r["LimiteCredito"]),
                DataCriacao = Convert.ToDateTime(r["DataCriacao"]),
                DataAtualizacao = r["DataAtualizacao"] as DateTime?,
                UsuarioCriacao = r["UsuarioCriacao"] as string,
                UsuarioAtualizacao = r["UsuarioAtualizacao"] as string,
                IsVendedor = Convert.ToBoolean(r["IsVendedor"])
            };
        }

        // =========================
        // PARAMS (SEM @EmpresaID)
        // =========================
        private void PreencherParametros(SqlCommand cmd, ClienteModel c, bool isInsert)
        {
            cmd.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = (object?)c.Nome ?? DBNull.Value;
            cmd.Parameters.Add("@Cpf", SqlDbType.NVarChar).Value = (object?)c.Cpf ?? DBNull.Value;
            cmd.Parameters.Add("@RG", SqlDbType.NVarChar).Value = (object?)c.RG ?? DBNull.Value;
            cmd.Parameters.Add("@OrgaoExpedidorRG", SqlDbType.NVarChar).Value = (object?)c.OrgaoExpedidorRG ?? DBNull.Value;
            cmd.Parameters.Add("@Cnpj", SqlDbType.NVarChar).Value = (object?)c.Cnpj ?? DBNull.Value;
            cmd.Parameters.Add("@IE", SqlDbType.NVarChar).Value = (object?)c.IE ?? DBNull.Value;
            cmd.Parameters.Add("@Telefone", SqlDbType.NVarChar).Value = (object?)c.Telefone ?? DBNull.Value;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = (object?)c.Email ?? DBNull.Value;
            cmd.Parameters.Add("@CidadeID", SqlDbType.Int).Value =
                c.CidadeID == 0 ? DBNull.Value : c.CidadeID;
            cmd.Parameters.Add("@Logradouro", SqlDbType.NVarChar).Value = (object?)c.Logradouro ?? DBNull.Value;
            cmd.Parameters.Add("@Numero", SqlDbType.NVarChar).Value = (object?)c.Numero ?? DBNull.Value;
            cmd.Parameters.Add("@Bairro", SqlDbType.NVarChar).Value = (object?)c.Bairro ?? DBNull.Value;
            cmd.Parameters.Add("@Cep", SqlDbType.NVarChar).Value = (object?)c.Cep ?? DBNull.Value;
            cmd.Parameters.Add("@DataNascimento", SqlDbType.Date).Value =
                c.DataNascimento.HasValue ? c.DataNascimento.Value : DBNull.Value;
            cmd.Parameters.Add("@TipoCliente", SqlDbType.NVarChar).Value = (object?)c.TipoCliente ?? DBNull.Value;
            cmd.Parameters.Add("@Status", SqlDbType.Int).Value = c.Status;
            cmd.Parameters.Add("@Observacoes", SqlDbType.NVarChar).Value = (object?)c.Observacoes ?? DBNull.Value;
            cmd.Parameters.Add("@LimiteCredito", SqlDbType.Decimal).Value = c.LimiteCredito;
            cmd.Parameters.Add("@IsVendedor", SqlDbType.Bit).Value = c.IsVendedor ?? false;

            if (isInsert)
            {
                cmd.Parameters.Add("@DataCriacao", SqlDbType.DateTime).Value = c.DataCriacao;
                cmd.Parameters.Add("@UsuarioCriacao", SqlDbType.NVarChar).Value = c.UsuarioCriacao;
            }
            else
            {
                cmd.Parameters.Add("@DataAtualizacao", SqlDbType.DateTime).Value = c.DataAtualizacao;
                cmd.Parameters.Add("@UsuarioAtualizacao", SqlDbType.NVarChar).Value = c.UsuarioAtualizacao;
            }
        }
    }
}