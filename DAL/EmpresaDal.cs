using Dapper;
using GVC.Model;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using GVC.Infra.Conexao;
using GVC.Infra.Repository;

namespace GVC.DAL
{
    internal class EmpresaDal:RepositoryBase
    {

        public EmpresaModel? BuscarEmpresaPrincipal()
        {
            const string sql = @"SELECT TOP 1 * FROM Empresa";

            using var cmd = CreateCommand(sql);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
                return MapEmpresa(reader);

            return null;
        }

        public EmpresaModel? ObterEmpresaAtual()
        {
            const string sql = @"
        SELECT TOP 1
            EmpresaID,
            RazaoSocial,
            NomeFantasia,
            Logo,
            FundoTela
        FROM Empresa
        ORDER BY EmpresaID";

            using var cmd = CreateCommand(sql);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
                return MapEmpresa(reader);

            return null;
        }

        public List<EmpresaSimples> ListarEmpresasSimples()
        {
            var lista = new List<EmpresaSimples>();

            const string sql = @"
        SELECT EmpresaID, NomeFantasia, RazaoSocial
        FROM Empresa
        ORDER BY NomeFantasia";

            using var cmd = CreateCommand(sql);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string nomeExibido =
                    reader.GetStringOrNull("NomeFantasia")
                    ?? reader.GetString(reader.GetOrdinal("RazaoSocial"));

                lista.Add(new EmpresaSimples
                {
                    EmpresaID = reader.GetInt32(reader.GetOrdinal("EmpresaID")),
                    NomeFantasia = nomeExibido
                });
            }

            return lista;
        }

        public byte[]? ObterImagem(int empresaId)
        {
            const string sql = @"
        SELECT Logo
        FROM Empresa
        WHERE EmpresaID = @Id";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = empresaId;

            var result = cmd.ExecuteScalar();
            return result as byte[];
        }


        public void AtualizarLogo(int empresaId, byte[]? logo)
        {
            if (empresaId <= 0)
                throw new ArgumentException("ID da empresa inválido.");

            const string sql = @"
        UPDATE Empresa
        SET Logo = @Logo,
            DataAtualizacao = GETDATE()
        WHERE EmpresaID = @Id";

            using var cmd = CreateCommand(sql);

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = empresaId;

            var logoParam = cmd.Parameters.Add("@Logo", SqlDbType.VarBinary, -1);
            logoParam.Value = (object?)logo ?? DBNull.Value;

            int afetadas = cmd.ExecuteNonQuery();

            if (afetadas == 0)
                Utilitario.Mensagens.Aviso(
                    "Nenhuma empresa encontrada com esse ID. Logo não foi atualizada.");
        }



        public void AtualizarCertificado(int empresaId, string? caminho)
        {
            if (empresaId <= 0)
                throw new ArgumentException("ID da empresa inválido.");

                const string sql = @"
            UPDATE Empresa
            SET CertificadoDigital = @Certificado,
                DataAtualizacao = GETDATE()
            WHERE EmpresaID = @Id";

            using var cmd = CreateCommand(sql);

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = empresaId;
            cmd.Parameters.Add("@Certificado", SqlDbType.VarChar, 300) .Value = (object?)caminho ?? DBNull.Value;
            cmd.ExecuteNonQuery();
        }


        private const string SqlBase = @"
SELECT
    em.EmpresaID,
    em.RazaoSocial,
    em.NomeFantasia,
    em.CNPJ,
    em.InscricaoEstadual,
    em.InscricaoMunicipal,
    em.CNAE,
    em.Logradouro,
    em.Numero,
    em.Bairro,
    em.Cep,
    em.Cidade,
    em.UF,
    em.Telefone,
    em.Email,
    em.Site,
    em.Responsavel,
    em.CertificadoDigital,
    em.DataCriacao,
    em.DataAtualizacao,
    em.UsuarioCriacao,
    em.UsuarioAtualizacao,
    em.Logo
    em.FundoTela
FROM Empresa em";


        // Método auxiliar para executar SQL e retornar DataTable
        private DataTable ExecuteReaderToDataTable(
     string sql,
     params SqlParameter[] parameters)
        {
            var dt = new DataTable();

            using var cmd = CreateCommand(sql);

            if (parameters != null && parameters.Length > 0)
                cmd.Parameters.AddRange(parameters);

            using var reader = cmd.ExecuteReader();
            dt.Load(reader);

            return dt;
        }

        public DataTable ListarEmpresas()
        {
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

            var dt = new DataTable();

            using var cmd = CreateCommand(sql);
            using var reader = cmd.ExecuteReader();

            dt.Load(reader);

            return dt;
        }

        public bool EmpresaExiste(string? razaoSocial, string? cnpj)
        {
            const string sql = @"
                SELECT TOP 1 1
                FROM Empresa
                WHERE (RazaoSocial = @RazaoSocial OR Cnpj = @Cnpj)";

            using var cmd = CreateCommand(sql);

            cmd.Parameters.Add("@RazaoSocial", SqlDbType.VarChar, 200)
                .Value = string.IsNullOrWhiteSpace(razaoSocial)
                    ? DBNull.Value
                    : razaoSocial;

            cmd.Parameters.Add("@Cnpj", SqlDbType.VarChar, 20)
                .Value = string.IsNullOrWhiteSpace(cnpj)
                    ? DBNull.Value
                    : cnpj;

            var result = cmd.ExecuteScalar();
            return result != null;
        }


        public void SalvarEmpresa(EmpresaModel empresa)
        {
            if (empresa == null)
                throw new ArgumentNullException(nameof(empresa));

            if (EmpresaExiste(empresa.RazaoSocial, empresa.CNPJ))
                throw new InvalidOperationException(
                    "Já existe uma empresa com esta Razão Social ou CNPJ.");

            const string sql = @"
                INSERT INTO Empresa (
                    RazaoSocial, NomeFantasia, CNPJ,
                    InscricaoEstadual, InscricaoMunicipal, CNAE,
                    Logradouro, Numero, Bairro, Cep, Cidade, UF,
                    Telefone, Email, Site,
                    Responsavel, CertificadoDigital,
                    DataCriacao, UsuarioCriacao, FundoTela
                )
                VALUES (
                    @RazaoSocial, @NomeFantasia, @Cnpj,
                    @InscricaoEstadual, @InscricaoMunicipal, @Cnae,
                    @Logradouro, @Numero, @Bairro, @Cep, @Cidade, @Uf,
                    @Telefone, @Email, @Site,
                    @Responsavel, @CertificadoDigital,
                    @DataCriacao, @UsuarioCriacao, @FundoTela
                );
                SELECT SCOPE_IDENTITY();";

            using var cmd = CreateCommand(sql);

            cmd.Parameters.Add("@RazaoSocial", SqlDbType.VarChar, 200).Value = (object?)empresa.RazaoSocial ?? DBNull.Value;
            cmd.Parameters.Add("@NomeFantasia", SqlDbType.VarChar, 200).Value = (object?)empresa.NomeFantasia ?? DBNull.Value;
            cmd.Parameters.Add("@Cnpj", SqlDbType.VarChar, 20).Value = (object?)empresa.CNPJ ?? DBNull.Value;
            cmd.Parameters.Add("@InscricaoEstadual", SqlDbType.VarChar, 50).Value = (object?)empresa.InscricaoEstadual ?? DBNull.Value;
            cmd.Parameters.Add("@InscricaoMunicipal", SqlDbType.VarChar, 50).Value = (object?)empresa.InscricaoMunicipal ?? DBNull.Value;
            cmd.Parameters.Add("@Cnae", SqlDbType.VarChar, 20).Value = (object?)empresa.CNAE ?? DBNull.Value;
            cmd.Parameters.Add("@Logradouro", SqlDbType.VarChar, 200).Value = (object?)empresa.Logradouro ?? DBNull.Value;
            cmd.Parameters.Add("@Numero", SqlDbType.VarChar, 20).Value = (object?)empresa.Numero ?? DBNull.Value;
            cmd.Parameters.Add("@Bairro", SqlDbType.VarChar, 100).Value = (object?)empresa.Bairro ?? DBNull.Value;
            cmd.Parameters.Add("@Cep", SqlDbType.VarChar, 20).Value = (object?)empresa.Cep ?? DBNull.Value;
            cmd.Parameters.Add("@Cidade", SqlDbType.VarChar, 100).Value = (object?)empresa.Cidade ?? DBNull.Value;
            cmd.Parameters.Add("@Uf", SqlDbType.VarChar, 2).Value = (object?)empresa.UF ?? DBNull.Value;
            cmd.Parameters.Add("@Telefone", SqlDbType.VarChar, 20).Value = (object?)empresa.Telefone ?? DBNull.Value;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 150).Value = (object?)empresa.Email ?? DBNull.Value;
            cmd.Parameters.Add("@Site", SqlDbType.VarChar, 150).Value = (object?)empresa.Site ?? DBNull.Value;
            cmd.Parameters.Add("@Responsavel", SqlDbType.VarChar, 150).Value = (object?)empresa.Responsavel ?? DBNull.Value;
            cmd.Parameters.Add("@CertificadoDigital", SqlDbType.VarChar, 300).Value = (object?)empresa.CertificadoDigital ?? DBNull.Value;
            cmd.Parameters.Add("@DataCriacao", SqlDbType.DateTime).Value = empresa.DataCriacao;
            cmd.Parameters.Add("@UsuarioCriacao", SqlDbType.VarChar, 100).Value = (object?)empresa.UsuarioCriacao ?? DBNull.Value;
            cmd.Parameters.Add("@FundoTela", SqlDbType.VarChar, 300).Value = (object?)empresa.FundoTela ?? DBNull.Value;

            empresa.EmpresaID = Convert.ToInt32(cmd.ExecuteScalar());
        }

        // 🔹 Mantém compatibilidade com TODOS os forms antigos
      
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
                UsuarioAtualizacao = @UsuarioAtualizacao,
                FundoTela = @FundoTela");

            // 🔒 só atualiza a imagem se uma nova for enviada
            if (imagemNova != null && imagemNova.Length > 0)
                sql.Append(", Logo = @Logo");

            sql.Append(" WHERE EmpresaID = @EmpresaID");

            using (var conn = Conexao.Conex())
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
                cmd.Parameters.AddWithValue("@FundoTela", empresa.FundoTela ?? (object)DBNull.Value);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ExcluirEmpresa(int empresaID)
        {
            const string sql = "DELETE FROM Empresa WHERE EmpresaID = @EmpresaID";
            using (var conn = Conexao.Conex())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@EmpresaID", empresaID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

      

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

            using (var conn = Conexao.Conex())
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

        public EmpresaModel? BuscarEmpresaPorId(int empresaID)
        {
            const string sql = SqlBase + " WHERE em.EmpresaID = @Id";

            using var cmd = CreateCommand(sql);

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = empresaID;

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
                return MapEmpresa(reader);

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
                Logo = reader["Logo"] != DBNull.Value ? (byte[])reader["Logo"] : null,
                FundoTela = reader["FundoTela"] != DBNull.Value  ? reader["FundoTela"].ToString(): null

            };
        }
        public static string ObterCaminhoCertificado(int empresaId)
        {
            const string sql = "SELECT CertificadoDigital FROM Empresa WHERE EmpresaID = @EmpresaID";

            using var conn = Conexao.Conex();
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