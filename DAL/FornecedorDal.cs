using Dapper;
using GVC.DAL;
using GVC.Model;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System.Data;

namespace GVC.DAL
{
    internal class FornecedorDal
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
        LEFT JOIN Estado e ON e.EstadoID = ci.EstadoID";

        public DataTable ListarFornecedores()
        {
            const string sql = SqlBase + " ORDER BY f.Nome";
            using var conn = Conexao.Conex();
            return conn.ExecuteReaderToDataTable(sql);
        }

        public bool FornecedorExiste(string? nome, string? cnpj)
        {
            const string sql = @"
        SELECT TOP 1 1
        FROM Fornecedor
        WHERE (Nome = @Nome OR Cnpj = @Cnpj);";

            var p = new
            {
                Nome = string.IsNullOrWhiteSpace(nome) ? null : nome,
                Cnpj = string.IsNullOrWhiteSpace(cnpj) ? null : cnpj
            };

            using var conn = Conexao.Conex();
            return conn.ExecuteScalar<int?>(sql, p) != null;
        }

        public void SalvarFornecedor(FornecedorModel fornecedor)
        {
            if (fornecedor == null) throw new ArgumentNullException(nameof(fornecedor));
            if (FornecedorExiste(fornecedor.Nome, fornecedor.Cnpj))
                throw new InvalidOperationException("Já existe um fornecedor com este nome ou Cnpj.");

            const string sql = @"
INSERT INTO Fornecedor (
  Nome, Cnpj, IE, Telefone, Email, CidadeID,
  Logradouro, Numero, Bairro, Cep, DataCriacao, Observacoes
)
VALUES (
  @Nome, @Cnpj, @IE, @Telefone, @Email, @CidadeID,
  @Logradouro, @Numero, @Bairro, @Cep, @DataCriacao, @Observacoes
);
SELECT SCOPE_IDENTITY();";   // ✅ SQL Server

            string? NullIfEmpty(string? s) => string.IsNullOrWhiteSpace(s) ? null : s;

            var p = new
            {
                Nome = NullIfEmpty(fornecedor.Nome),
                Cnpj = NullIfEmpty(fornecedor.Cnpj),
               IE = NullIfEmpty(fornecedor.IE),
                Telefone = NullIfEmpty(fornecedor.Telefone),
                Email = NullIfEmpty(fornecedor.Email),
                CidadeID = fornecedor.CidadeID,
                Logradouro = NullIfEmpty(fornecedor.Logradouro),
                Numero = NullIfEmpty(fornecedor.Numero),
                Bairro = NullIfEmpty(fornecedor.Bairro),
                Cep = NullIfEmpty(fornecedor.Cep),
                DataCriacao = fornecedor.DataCriacao ?? DateTime.Now,
                Observacoes = NullIfEmpty(fornecedor.Observacoes)
            };

            using var conn = Conexao.Conex();
            fornecedor.FornecedorID = (int)conn.QuerySingle<int>(sql, p);
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
            WHERE FornecedorID = @FornecedorID";

            using var conn = Conexao.Conex();
            conn.Execute(sql, fornecedor);
        }

        public void ExcluirFornecedor(int fornecedorID)
        {
            const string sql = "DELETE FROM Fornecedor WHERE FornecedorID = @FornecedorID";
            using var conn = Conexao.Conex();
            conn.Execute(sql, new { FornecedorID = fornecedorID });
        }

        public void ExcluirFornecedor(FornecedorModel fornecedor) => ExcluirFornecedor((int)fornecedor.FornecedorID);

        public DataTable PesquisarPorNome(string nome)
        {
            const string sql = SqlBase + " WHERE f.Nome LIKE @Nome ORDER BY f.Nome";
            using var conn = Conexao.Conex();
            return conn.ExecuteReaderToDataTable(sql, new { Nome = $"%{nome?.Trim()}%" });
        }

        public DataTable PesquisarPorCodigo(int codigo)
        {
            const string sql = SqlBase + " WHERE f.FornecedorID = @FornecedorID";
            using var conn = Conexao.Conex();
            return conn.ExecuteReaderToDataTable(sql, new { FornecedorID = codigo });
        }

        public DataTable PesquisarGeral(string texto = "")
        {
            const string sql = SqlBase + @"
            WHERE f.Nome LIKE @Texto
               OR f.Cnpj LIKE @Texto
               OR f.Telefone LIKE @Texto
               OR f.Email LIKE @Texto
               OR f.Logradouro LIKE @Texto
               OR f.Bairro LIKE @Texto
               OR ci.Nome LIKE @Texto
            ORDER BY f.Nome
            OFFSET 0 ROWS FETCH NEXT 100 ROWS ONLY";  // ✅ SQL Server

            var filtro = $"%{texto?.Trim() ?? ""}%";
            using var conn = Conexao.Conex();
            return conn.ExecuteReaderToDataTable(sql, new { Texto = filtro });
        }

        public FornecedorModel? BuscarPorCnpj(string? cnpj)
        {
            const string sql = @"
            SELECT TOP 1 *
            FROM Fornecedor
            WHERE Cnpj = @Cnpj;";   // ✅ SQL Server

            var p = new { Cnpj = string.IsNullOrWhiteSpace(cnpj) ? null : cnpj };

            using var conn = Conexao.Conex();
            return conn.QueryFirstOrDefault<FornecedorModel>(sql, p);
        }

        public FornecedorModel? BuscarPorId(int fornecedorID)
        {
            const string sql = SqlBase + " WHERE f.FornecedorID = @Id";
            using var conn = Conexao.Conex();
            return conn.QueryFirstOrDefault<FornecedorModel>(sql, new { Id = fornecedorID });
        }

        public List<FornecedorModel> Listar()
        {
            const string sql = @"SELECT FornecedorID, Nome, Telefone, Cnpj 
                 FROM Fornecedor ORDER BY Nome";

            using var conn = Conexao.Conex();
            return conn.Query<FornecedorModel>(sql).ToList();
        }
    }
}
