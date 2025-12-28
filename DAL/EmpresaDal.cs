using GVC.MODEL;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

public class EmpresaDal
{
    private readonly string _connectionString;

    public EmpresaDal(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void Inserir(EmpresaModel empresa)
    {
        const string sql = @"
    INSERT INTO Empresa (
        RazaoSocial, NomeFantasia, CNPJ, InscricaoEstadual, InscricaoMunicipal, CNAE,
        Logradouro, Numero, Bairro, Cep, Cidade, UF,
        Telefone, Email, Site,
        Responsavel, CertificadoDigital,
        Status,
        DataCriacao, UsuarioCriacao, Logo
    )
    VALUES (
        @RazaoSocial, @NomeFantasia, @CNPJ, @InscricaoEstadual, @InscricaoMunicipal, @CNAE,
        @Logradouro, @Numero, @Bairro, @Cep, @Cidade, @UF,
        @Telefone, @Email, @Site,
        @Responsavel, @CertificadoDigital,
        @Status,
        @DataCriacao, @UsuarioCriacao, Logo
    )";

        using (var conn = new SqlConnection(_connectionString))
        using (var cmd = new SqlCommand(sql, conn))
        {
            cmd.Parameters.AddWithValue("@RazaoSocial", empresa.RazaoSocial);
            cmd.Parameters.AddWithValue("@NomeFantasia", (object)empresa.NomeFantasia ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@CNPJ", empresa.CNPJ);
            cmd.Parameters.AddWithValue("@InscricaoEstadual", (object)empresa.InscricaoEstadual ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@InscricaoMunicipal", (object)empresa.InscricaoMunicipal ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@CNAE", (object)empresa.CNAE ?? DBNull.Value);

            cmd.Parameters.AddWithValue("@Logradouro", empresa.Logradouro);
            cmd.Parameters.AddWithValue("@Numero", (object)empresa.Numero ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Bairro", empresa.Bairro);
            cmd.Parameters.AddWithValue("@Cep", empresa.Cep);
            cmd.Parameters.AddWithValue("@Cidade", empresa.Cidade);
            cmd.Parameters.AddWithValue("@UF", empresa.UF);

            cmd.Parameters.AddWithValue("@Telefone", (object)empresa.Telefone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object)empresa.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Site", (object)empresa.Site ?? DBNull.Value);

            cmd.Parameters.AddWithValue("@Responsavel", (object)empresa.Responsavel ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@CertificadoDigital", (object)empresa.CertificadoDigital ?? DBNull.Value);

            cmd.Parameters.AddWithValue("@DataCriacao", empresa.DataCriacao);
            cmd.Parameters.AddWithValue("@UsuarioCriacao", (object)empresa.UsuarioCriacao ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Status", empresa.Status);
            cmd.Parameters.AddWithValue("@Logo", (object)empresa.Logo ?? DBNull.Value);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public EmpresaModel ObterPorId(int empresaId)
    {
        const string sql = "SELECT * FROM Empresa WHERE EmpresaID = @EmpresaID";

        using (var conn = new SqlConnection(_connectionString))
        using (var cmd = new SqlCommand(sql, conn))
        {
            cmd.Parameters.AddWithValue("@EmpresaID", empresaId);
            conn.Open();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new EmpresaModel
                    {
                        EmpresaID = (int)reader["EmpresaID"],
                        RazaoSocial = reader["RazaoSocial"].ToString(),
                        NomeFantasia = reader["NomeFantasia"].ToString(),
                        CNPJ = reader["CNPJ"].ToString(),
                        InscricaoEstadual = reader["InscricaoEstadual"].ToString(),
                        InscricaoMunicipal = reader["InscricaoMunicipal"].ToString(),
                        CNAE = reader["CNAE"].ToString(),
                        Logradouro = reader["Logradouro"].ToString(),
                        Numero = reader["Numero"].ToString(),
                        Bairro = reader["Bairro"].ToString(),
                        Cep = reader["Cep"].ToString(),
                        Cidade = reader["Cidade"].ToString(),
                        UF = reader["UF"].ToString(),
                        Telefone = reader["Telefone"].ToString(),
                        Email = reader["Email"].ToString(),
                        Site = reader["Site"].ToString(),
                        Responsavel = reader["Responsavel"].ToString(),
                        CertificadoDigital = reader["CertificadoDigital"].ToString(),
                        DataCriacao = (DateTime)reader["DataCriacao"],
                        DataAtualizacao = reader["DataAtualizacao"] as DateTime?,
                        UsuarioCriacao = reader["UsuarioCriacao"].ToString(),
                        UsuarioAtualizacao = reader["UsuarioAtualizacao"].ToString(),
                        Logo = reader["Logo"] as byte[]
                    };
                }
            }
        }
        return null;
    }
    public void Excluir(int empresaId)
    {
        const string sql = @"
        UPDATE Empresa 
        SET Status = 0, DataAtualizacao = GETDATE() 
        WHERE EmpresaID = @EmpresaID";

        using (var conn = new SqlConnection(_connectionString))
        using (var cmd = new SqlCommand(sql, conn))
        {
            cmd.Parameters.AddWithValue("@EmpresaID", empresaId);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }



    public void Atualizar(EmpresaModel empresa)
    {
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
        Status = @Status,
        DataAtualizacao = @DataAtualizacao,
        UsuarioAtualizacao = @UsuarioAtualizacao, Logo = @Logo
    WHERE EmpresaID = @EmpresaID";

        


        using (var conn = new SqlConnection(_connectionString))
        using (var cmd = new SqlCommand(sql, conn))
        {
            cmd.Parameters.AddWithValue("@EmpresaID", empresa.EmpresaID);
            cmd.Parameters.AddWithValue("@RazaoSocial", empresa.RazaoSocial);
            cmd.Parameters.AddWithValue("@NomeFantasia", (object)empresa.NomeFantasia ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@CNPJ", empresa.CNPJ);
            cmd.Parameters.AddWithValue("@InscricaoEstadual", (object)empresa.InscricaoEstadual ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@InscricaoMunicipal", (object)empresa.InscricaoMunicipal ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@CNAE", (object)empresa.CNAE ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Logradouro", empresa.Logradouro);
            cmd.Parameters.AddWithValue("@Numero", (object)empresa.Numero ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Bairro", empresa.Bairro);
            cmd.Parameters.AddWithValue("@Cep", empresa.Cep);
            cmd.Parameters.AddWithValue("@Cidade", empresa.Cidade);
            cmd.Parameters.AddWithValue("@UF", empresa.UF);
            cmd.Parameters.AddWithValue("@Telefone", (object)empresa.Telefone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object)empresa.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Site", (object)empresa.Site ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Responsavel", (object)empresa.Responsavel ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@CertificadoDigital", (object)empresa.CertificadoDigital ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@DataAtualizacao", empresa.DataAtualizacao ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@UsuarioAtualizacao", (object)empresa.UsuarioAtualizacao ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Status", empresa.Status);
            cmd.Parameters.AddWithValue("@Logo", (object)empresa.Logo ?? DBNull.Value);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

    }
}

