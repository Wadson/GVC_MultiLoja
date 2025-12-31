using GVC.MODEL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace GVC.DALL
{
    internal class EmpresaDal
    {
        private const string SqlBase = @"
            SELECT
                e.EmpresaID,
                e.RazaoSocial,
                e.NomeFantasia,
                e.CNPJ,
                e.InscricaoEstadual,
                e.InscricaoMunicipal,
                e.CNAE,
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
                e.Logo,
                ci.Nome AS Cidade,
                es.Uf AS UF
            FROM Empresa e
            LEFT JOIN Cidade ci ON ci.CidadeID = (SELECT CidadeID FROM Cidade WHERE Nome = e.Cidade) -- Ajuste se houver CidadeID direto
            LEFT JOIN Estado es ON es.EstadoID = ci.EstadoID";

        // Método auxiliar para executar SQL e retornar DataTable
        private DataTable ExecuteReaderToDataTable(string sql, params SqlParameter[] parameters)
        {
            var dt = new DataTable();
            using (var conn = Helpers.Conexao.Conex())
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
            const string sql = SqlBase + " ORDER BY e.RazaoSocial";
            return ExecuteReaderToDataTable(sql);
        }

        public bool EmpresaExiste(string? razaoSocial, string? cnpj)
        {
            const string sql = @"
                SELECT TOP 1 1
                FROM Empresa
                WHERE (RazaoSocial = @RazaoSocial OR CNPJ = @CNPJ)";

            using (var conn = Helpers.Conexao.Conex())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@RazaoSocial", string.IsNullOrWhiteSpace(razaoSocial) ? (object)DBNull.Value : razaoSocial);
                cmd.Parameters.AddWithValue("@CNPJ", string.IsNullOrWhiteSpace(cnpj) ? (object)DBNull.Value : cnpj);
                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != null;
            }
        }

        public void SalvarEmpresa(EmpresaModel empresa)
        {
            if (empresa == null) throw new ArgumentNullException(nameof(empresa));

            if (EmpresaExiste(empresa.RazaoSocial, empresa.CNPJ))
                throw new InvalidOperationException("Já existe uma empresa com esta Razão Social ou CNPJ.");

            const string sql = @"
                INSERT INTO Empresa (
                    RazaoSocial, NomeFantasia, CNPJ, InscricaoEstadual, InscricaoMunicipal, CNAE,
                    Logradouro, Numero, Bairro, Cep, Cidade, UF,
                    Telefone, Email, Site,
                    Responsavel, CertificadoDigital,
                    DataCriacao, UsuarioCriacao, Logo
                )
                VALUES (
                    @RazaoSocial, @NomeFantasia, @CNPJ, @InscricaoEstadual, @InscricaoMunicipal, @CNAE,
                    @Logradouro, @Numero, @Bairro, @Cep, @Cidade, @UF,
                    @Telefone, @Email, @Site,
                    @Responsavel, @CertificadoDigital,
                    @DataCriacao, @UsuarioCriacao, @Logo
                );
                SELECT SCOPE_IDENTITY();";

            using (var conn = Helpers.Conexao.Conex())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@RazaoSocial", empresa.RazaoSocial ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@NomeFantasia", empresa.NomeFantasia ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CNPJ", empresa.CNPJ ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@InscricaoEstadual", empresa.InscricaoEstadual ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@InscricaoMunicipal", empresa.InscricaoMunicipal ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CNAE", empresa.CNAE ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Logradouro", empresa.Logradouro ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Numero", empresa.Numero ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Bairro", empresa.Bairro ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cep", empresa.Cep ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cidade", empresa.Cidade ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@UF", empresa.UF ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefone", empresa.Telefone ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", empresa.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Site", empresa.Site ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Responsavel", empresa.Responsavel ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CertificadoDigital", empresa.CertificadoDigital ?? (object)DBNull.Value);              
                cmd.Parameters.AddWithValue("@DataCriacao", empresa.DataCriacao);
                cmd.Parameters.AddWithValue("@UsuarioCriacao", empresa.UsuarioCriacao ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Logo", empresa.Logo ?? (object)DBNull.Value);

                conn.Open();
                empresa.EmpresaID = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void Atualizar(EmpresaModel empresa)
        {
            if (empresa == null) throw new ArgumentNullException(nameof(empresa));
            if (empresa.EmpresaID <= 0) throw new ArgumentException("ID da empresa inválido para atualização");

            const string sql = @"
                UPDATE Empresa SET
                    RazaoSocial = @RazaoSocial,
                    NomeFantasia = @NomeFantasia,
                    CNPJ = @CNPJ,
                    InscricaoEstadual = @InscricaoEstadual,
                    InscricaoMunicipal = @InscricaoMunicipal,
                    CNAE = @CNAE,
                    Logradouro = @Logradouro,
                    Numero = @Numero,
                    Bairro = @Bairro,
                    Cep = @Cep,
                    Cidade = @Cidade,
                    UF = @UF,
                    Telefone = @Telefone,
                    Email = @Email,
                    Site = @Site,
                    Responsavel = @Responsavel,
                    CertificadoDigital = @CertificadoDigital,                   
                    DataAtualizacao = GETDATE(),
                    UsuarioAtualizacao = @UsuarioAtualizacao,
                    Logo = @Logo
                WHERE EmpresaID = @EmpresaID";

            using (var conn = Helpers.Conexao.Conex())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@EmpresaID", empresa.EmpresaID);
                cmd.Parameters.AddWithValue("@RazaoSocial", empresa.RazaoSocial ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@NomeFantasia", empresa.NomeFantasia ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CNPJ", empresa.CNPJ ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@InscricaoEstadual", empresa.InscricaoEstadual ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@InscricaoMunicipal", empresa.InscricaoMunicipal ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CNAE", empresa.CNAE ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Logradouro", empresa.Logradouro ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Numero", empresa.Numero ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Bairro", empresa.Bairro ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cep", empresa.Cep ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cidade", empresa.Cidade ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@UF", empresa.UF ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefone", empresa.Telefone ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", empresa.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Site", empresa.Site ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Responsavel", empresa.Responsavel ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CertificadoDigital", empresa.CertificadoDigital ?? (object)DBNull.Value);              
                cmd.Parameters.AddWithValue("@UsuarioAtualizacao", empresa.UsuarioAtualizacao ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Logo", empresa.Logo ?? (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ExcluirEmpresa(int empresaID)
        {
            const string sql = "DELETE FROM Empresa WHERE EmpresaID = @EmpresaID";
            using (var conn = Helpers.Conexao.Conex())
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
                WHERE CNPJ = @CNPJ";

            using (var conn = Helpers.Conexao.Conex())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@CNPJ", string.IsNullOrWhiteSpace(cnpj) ? (object)DBNull.Value : cnpj);
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
            using (var conn = Helpers.Conexao.Conex())
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
                Logo = reader["Logo"] != DBNull.Value ? (byte[])reader["Logo"] : null
            };
        }
    }
}