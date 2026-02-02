using Dapper;
using GVC.Model;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GVC.DAL
{
    internal class EmpresaDal
    {
        public EmpresaModel BuscarEmpresaPrincipal()
        {
            const string sql = "SELECT TOP 1 * FROM Empresa";

            using var conn = Conexao_.Conex();
            return conn.QueryFirstOrDefault<EmpresaModel>(sql);
        }
        public EmpresaModel ObterEmpresa()
        {
            const string sql = @"
            SELECT TOP 1
                EmpresaID,
                RazaoSocial,
                NomeFantasia,
                Logo
            FROM Empresa
            ORDER BY EmpresaID";

            using var conn = Conexao_.Conex();
            return conn.QueryFirstOrDefault<EmpresaModel>(sql);
        }
        public static List<EmpresaSimples> ListarEmpresasSimples()
        {
            var lista = new List<EmpresaSimples>();

            using var conn = Conexao_.Conex();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT EmpresaID, NomeFantasia, RazaoSocial FROM Empresa ORDER BY NomeFantasia";

            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nomeExibido = reader.GetStringOrNull("NomeFantasia") ?? reader.GetString("RazaoSocial");

                lista.Add(new EmpresaSimples
                {
                    EmpresaID = reader.GetInt32("EmpresaID"),
                    NomeFantasia = nomeExibido
                });
            }

            return lista;
        }
        public static byte[] ObterImagem(int empresaId)
        {
            using var conn = Conexao_.Conex();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                SELECT Logo 
                FROM Empresa 
                WHERE EmpresaID = @id";
            cmd.Parameters.AddWithValue("@id", empresaId);

            conn.Open();
            return cmd.ExecuteScalar() as byte[];
        }

        public static void AtualizarLogo(int empresaId, byte[] logo)
        {
            if (empresaId <= 0)
                throw new ArgumentException("ID da empresa inválido.");

            using var conn = Conexao_.Conex();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
UPDATE Empresa
SET Logo = @Logo,
    DataAtualizacao = GETDATE()
WHERE EmpresaID = @EmpresaID";

            cmd.Parameters.AddWithValue("@EmpresaID", empresaId);

            var logoParam = cmd.Parameters.Add("@Logo", SqlDbType.VarBinary, -1);

            // ✔ Se logo for null → remove
            // ✔ Se logo tiver bytes → salva
            logoParam.Value = (object)logo ?? DBNull.Value;

            conn.Open();
            int afetadas = cmd.ExecuteNonQuery();

            if (afetadas == 0)
                Utilitario.Mensagens.Aviso(
                    "Nenhuma empresa encontrada com esse ID. Logo não foi atualizada."
                );
        }


        public static void AtualizarCertificado(int empresaId, string caminho)
        {
            if (empresaId <= 0)
                throw new ArgumentException("ID da empresa inválido.");

            using var conn = Conexao_.Conex();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                UPDATE Empresa
                SET CertificadoDigital = @Certificado,
                    DataAtualizacao = GETDATE()
                WHERE EmpresaID = @EmpresaID";
            cmd.Parameters.AddWithValue("@EmpresaID", empresaId);
            cmd.Parameters.AddWithValue("@Certificado", (object)caminho ?? DBNull.Value);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        private const string SqlBase = @"
            SELECT
                e.EmpresaID,
                e.RazaoSocial,
                e.NomeFantasia,
                e.Cnpj,
                e.InscricaoEstadual,
                e.InscricaoMunicipal,
                e.Cnae,
                e.Logradouro,
                e.Numero,
                e.Bairro,
                e.Cep,
                e.Telefone,
                e.Email,
                e.Site,
                e.Responsavel,
                e.CertificadoDigital,               
                e.DataCriacao,
                e.DataAtualizacao,
                e.UsuarioCriacao,
                e.UsuarioAtualizacao,               
                ci.Nome AS Cidade,
                es.Uf AS Uf
            FROM Empresa e
            LEFT JOIN Cidade ci ON ci.CidadeID = (SELECT CidadeID FROM Cidade WHERE Nome = e.Cidade) -- Ajuste se houver CidadeID direto
            LEFT JOIN Estado es ON es.EstadoID = ci.EstadoID";

        // Método auxiliar para executar SQL e retornar DataTable
        private DataTable ExecuteReaderToDataTable(string sql, params SqlParameter[] parameters)
        {
            var dt = new DataTable();
            using (var conn = Conexao_.Conex(Sessao.AmbienteSelecionado))
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
        public DataTable ListarEmpresas()
        {
            // Consulta SQL completa
            const string sql = @"
        SELECT
            EmpresaID,
            RazaoSocial,
            NomeFantasia,
            CNPJ,
            InscricaoEstadual,
            InscricaoMunicipal,
            CNAE,
            Logradouro,
            Numero,
            Bairro,
            Cep,
            Cidade,
            UF,
            Telefone,
            Email,
            Site,
            Responsavel,
            CertificadoDigital,
            DataCriacao,
            DataAtualizacao,
            UsuarioCriacao,
            UsuarioAtualizacao
        FROM Empresa
        ORDER BY RazaoSocial";

            // Cria o DataTable que será retornado
            DataTable dt = new DataTable();

            // Exemplo de uso com SqlConnection (SQL Server)
            using (SqlConnection conn = Conexao_.Conex(Sessao.AmbienteSelecionado))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }
        public bool EmpresaExiste(string? razaoSocial, string? cnpj)
        {
            const string sql = @"
                SELECT TOP 1 1
                FROM Empresa
                WHERE (RazaoSocial = @RazaoSocial OR Cnpj = @Cnpj)";

            using (var conn = Conexao_.Conex(Sessao.AmbienteSelecionado))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@RazaoSocial", string.IsNullOrWhiteSpace(razaoSocial) ? (object)DBNull.Value : razaoSocial);
                cmd.Parameters.AddWithValue("@Cnpj", string.IsNullOrWhiteSpace(cnpj) ? (object)DBNull.Value : cnpj);
                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != null;
            }
        }

        public void SalvarEmpresa(EmpresaModel empresa)
        {
            if (empresa == null) throw new ArgumentNullException(nameof(empresa));

            if (EmpresaExiste(empresa.RazaoSocial, empresa.CNAE))
                throw new InvalidOperationException("Já existe uma empresa com esta Razão Social ou Cnpj.");

            const string sql = @"
                INSERT INTO Empresa (
                    RazaoSocial, NomeFantasia, CNPJ, InscricaoEstadual, InscricaoMunicipal, CNAE,
                    Logradouro, Numero, Bairro, Cep, Cidade, UF,
                    Telefone, Email, Site,
                    Responsavel, CertificadoDigital,
                    DataCriacao, UsuarioCriacao
                )
                VALUES (
                    @RazaoSocial, @NomeFantasia, @Cnpj, @InscricaoEstadual, @InscricaoMunicipal, @Cnae,
                    @Logradouro, @Numero, @Bairro, @Cep, @Cidade, @Uf,
                    @Telefone, @Email, @Site,
                    @Responsavel, @CertificadoDigital,
                    @DataCriacao, @UsuarioCriacao
                );
                SELECT SCOPE_IDENTITY();";

            using (var conn = Conexao_.Conex(Sessao.AmbienteSelecionado))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@RazaoSocial", empresa.RazaoSocial ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@NomeFantasia", empresa.NomeFantasia ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cnpj", empresa.CNPJ ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@InscricaoEstadual", empresa.InscricaoEstadual ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@InscricaoMunicipal", empresa.InscricaoMunicipal ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cnae", empresa.CNAE ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Logradouro", empresa.Logradouro ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Numero", empresa.Numero ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Bairro", empresa.Bairro ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cep", empresa.Cep ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cidade", empresa.Cidade ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Uf", empresa.UF ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefone", empresa.Telefone ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", empresa.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Site", empresa.Site ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Responsavel", empresa.Responsavel ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CertificadoDigital", empresa.CertificadoDigital ?? (object)DBNull.Value);              
                cmd.Parameters.AddWithValue("@DataCriacao", empresa.DataCriacao);
                cmd.Parameters.AddWithValue("@UsuarioCriacao", empresa.UsuarioCriacao ?? (object)DBNull.Value);               

                conn.Open();
                empresa.EmpresaID = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        // 🔹 Mantém compatibilidade com TODOS os forms antigos
        public void Atualizar(EmpresaModel empresa)
        {
            Atualizar(empresa, null);
        }
        public void Atualizar(EmpresaModel empresa, byte[]? imagemNova)
        {
            if (empresa == null)
                throw new ArgumentNullException(nameof(empresa));

            if (empresa.EmpresaID <= 0)
                throw new ArgumentException("ID da empresa inválido para atualização");

            var sql = new StringBuilder(@"
        UPDATE Empresa SET
            RazaoSocial = @RazaoSocial,
            NomeFantasia = @NomeFantasia,
            CNPJ = @Cnpj,
            InscricaoEstadual = @InscricaoEstadual,
            InscricaoMunicipal = @InscricaoMunicipal,
            CNAE = @Cnae,
            Logradouro = @Logradouro,
            Numero = @Numero,
            Bairro = @Bairro,
            Cep = @Cep,
            Cidade = @Cidade,
            UF = @Uf,
            Telefone = @Telefone,
            Email = @Email,
            Site = @Site,
            Responsavel = @Responsavel,
            CertificadoDigital = @CertificadoDigital,
            DataAtualizacao = GETDATE(),
            UsuarioAtualizacao = @UsuarioAtualizacao");

            // 🔒 só atualiza a imagem se uma nova for enviada
            if (imagemNova != null && imagemNova.Length > 0)
                sql.Append(", Logo = @Logo");

            sql.Append(" WHERE EmpresaID = @EmpresaID");

            using (var conn = Conexao_.Conex(Sessao.AmbienteSelecionado))
            using (var cmd = new SqlCommand(sql.ToString(), conn))
            {
                cmd.Parameters.AddWithValue("@EmpresaID", empresa.EmpresaID);
                cmd.Parameters.AddWithValue("@RazaoSocial", empresa.RazaoSocial ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@NomeFantasia", empresa.NomeFantasia ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cnpj", empresa.CNPJ ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@InscricaoEstadual", empresa.InscricaoEstadual ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@InscricaoMunicipal", empresa.InscricaoMunicipal ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cnae", empresa.CNAE ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Logradouro", empresa.Logradouro ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Numero", empresa.Numero ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Bairro", empresa.Bairro ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cep", empresa.Cep ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cidade", empresa.Cidade ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Uf", empresa.UF ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefone", empresa.Telefone ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", empresa.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Site", empresa.Site ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Responsavel", empresa.Responsavel ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CertificadoDigital", empresa.CertificadoDigital ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@UsuarioAtualizacao", empresa.UsuarioAtualizacao ?? (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ExcluirEmpresa(int empresaID)
        {
            const string sql = "DELETE FROM Empresa WHERE EmpresaID = @EmpresaID";
            using (var conn = Conexao_.Conex(Sessao.AmbienteSelecionado))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@EmpresaID", empresaID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ExcluirEmpresa(EmpresaModel empresa) => ExcluirEmpresa(empresa.EmpresaID);

        public DataTable PesquisarPorNome(string nome)
        {
            const string sql = SqlBase + " WHERE e.RazaoSocial LIKE @Nome ORDER BY e.RazaoSocial";
            return ExecuteReaderToDataTable(sql,
                new SqlParameter("@Nome", $"%{nome?.Trim()}%"));
        }

        public DataTable PesquisarPorCodigo(int codigo)
        {
            const string sql = SqlBase + " WHERE e.EmpresaID = @EmpresaID";
            return ExecuteReaderToDataTable(sql,
                new SqlParameter("@EmpresaID", codigo));
        }

        public DataTable PesquisarGeral(string texto = "")
        {
            const string sql = SqlBase + @"
                WHERE e.RazaoSocial LIKE @Texto
                   OR e.NomeFantasia LIKE @Texto
                   OR e.CNPJ LIKE @Texto
                   OR e.Telefone LIKE @Texto
                   OR e.Email LIKE @Texto
                   OR e.Logradouro LIKE @Texto
                   OR e.Bairro LIKE @Texto
                   OR e.Cidade LIKE @Texto
                ORDER BY e.RazaoSocial
                OFFSET 0 ROWS FETCH NEXT 100 ROWS ONLY";

            var filtro = $"%{texto?.Trim() ?? ""}%";
            return ExecuteReaderToDataTable(sql,
                new SqlParameter("@Texto", filtro));
        }

        public EmpresaModel? BuscarPorCnpj(string? cnpj)
        {
            const string sql = @"
                SELECT TOP 1 *
                FROM Empresa
                WHERE Cnpj = @Cnpj";

            using (var conn = Conexao_.Conex(Sessao.AmbienteSelecionado))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Cnpj", string.IsNullOrWhiteSpace(cnpj) ? (object)DBNull.Value : cnpj);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapEmpresa(reader);
                    }
                }
            }
            return null;
        }

        public EmpresaModel? BuscarPorId(int empresaID)
        {
            string sql = SqlBase + " WHERE e.EmpresaID = @Id";
            using (var conn = Conexao_.Conex(Sessao.AmbienteSelecionado))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Id", empresaID);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapEmpresa(reader);
                    }
                }
            }
            return null;
        }

        // Método auxiliar para mapear EmpresaModel a partir de SqlDataReader
        private EmpresaModel MapEmpresa(SqlDataReader reader)
        {
            return new EmpresaModel
            {
                EmpresaID = reader.GetInt32(reader.GetOrdinal("EmpresaID")),
                RazaoSocial = reader["RazaoSocial"]?.ToString() ?? "",
                NomeFantasia = reader["NomeFantasia"]?.ToString() ?? "",
                CNPJ = reader["CNPJ"]?.ToString() ?? "",
                InscricaoEstadual = reader["InscricaoEstadual"]?.ToString() ?? "",
                InscricaoMunicipal = reader["InscricaoMunicipal"]?.ToString() ?? "",
                CNAE = reader["CNAE"]?.ToString() ?? "",
                Logradouro = reader["Logradouro"]?.ToString() ?? "",
                Numero = reader["Numero"]?.ToString() ?? "",
                Bairro = reader["Bairro"]?.ToString() ?? "",
                Cep = reader["Cep"]?.ToString() ?? "",
                Cidade = reader["Cidade"]?.ToString() ?? "",
                UF = reader["UF"]?.ToString() ?? "",
                Telefone = reader["Telefone"]?.ToString() ?? "",
                Email = reader["Email"]?.ToString() ?? "",
                Site = reader["Site"]?.ToString() ?? "",
                Responsavel = reader["Responsavel"]?.ToString() ?? "",
                CertificadoDigital = reader["CertificadoDigital"]?.ToString() ?? "",               
                DataCriacao = reader["DataCriacao"] != DBNull.Value ? reader.GetDateTime(reader.GetOrdinal("DataCriacao")) : DateTime.MinValue,
                DataAtualizacao = reader["DataAtualizacao"] != DBNull.Value ? (DateTime?)reader.GetDateTime(reader.GetOrdinal("DataAtualizacao")) : null,
                UsuarioCriacao = reader["UsuarioCriacao"]?.ToString() ?? "",
                UsuarioAtualizacao = reader["UsuarioAtualizacao"]?.ToString() ?? "",               
            };
        }
        public static string ObterCaminhoCertificado(int empresaId)
        {
            const string sql = "SELECT CertificadoDigital FROM Empresa WHERE EmpresaID = @EmpresaID";

            using var conn = Conexao_.Conex();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EmpresaID", empresaId);

            conn.Open();
            var result = cmd.ExecuteScalar();

            if (result != null && result != DBNull.Value)
                return result.ToString()!;

            return string.Empty; // Nenhum certificado configurado
        }       
    }
    public static class SqlDataReaderExtensions
    {
        public static string GetStringOrNull(this SqlDataReader reader, string columnName)
        {
            int ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? null : reader.GetString(ordinal);
        }

        // Opcional: outros métodos úteis no futuro
        public static int? GetInt32OrNull(this SqlDataReader reader, string columnName)
        {
            int ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? (int?)null : reader.GetInt32(ordinal);
        }
    }
}