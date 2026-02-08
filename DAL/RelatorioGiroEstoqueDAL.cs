using System;
using System.Data;
using Microsoft.Data.SqlClient;
using GVC.Infra.Repository;

namespace GVC.DAL
{
    public class RelatorioGiroEstoqueDAL : RepositoryBase
    {
        public DataTable ObterGiro(DateTime inicio, DateTime fim)
        {
            var dt = new DataTable();

            const string sql = /* SQL acima */ "";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.Add("@Inicio", SqlDbType.DateTime).Value = inicio;
            cmd.Parameters.Add("@Fim", SqlDbType.DateTime).Value = fim;

            using var da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
    }
}
