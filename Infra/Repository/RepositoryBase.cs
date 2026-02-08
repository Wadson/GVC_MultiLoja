using System;
using System.Data;
using Microsoft.Data.SqlClient;
using GVC.Infra.Conexao;
using GVC.UTIL;

namespace GVC.Infra.Repository
{
    public abstract class RepositoryBase : IDisposable
    {
        protected SqlConnection Connection { get; }

        protected int EmpresaID => Sessao.EmpresaID;

        protected RepositoryBase()
        {
            if (!Sessao.Logado)
                throw new Exception("Sessão inválida. Empresa não definida.");

            Connection = Conexao.Conexao.Conex();
            Connection.Open();
        }

        protected SqlCommand CreateCommand(string sql)
        {
            var cmd = new SqlCommand(sql, Connection);

            // 🔒 MULTIEMPRESA CENTRALIZADO
            if (sql.Contains("@EmpresaID"))
                cmd.Parameters.Add("@EmpresaID", SqlDbType.Int).Value = EmpresaID;

            return cmd;
        }

        public void Dispose()
        {
            if (Connection?.State == ConnectionState.Open)
                Connection.Close();
        }
    }
}