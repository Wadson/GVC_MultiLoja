using System.Data;
using Microsoft.Data.SqlClient;
using GVC.Infra.Repository;

namespace GVC.DAL
{
    public class RelatorioLucroProdutoDAL : RepositoryBase
    {
        public DataTable RankingLucro()
        {
            var dt = new DataTable();

            const string sql = /* SQL acima */ "";

            using var cmd = CreateCommand(sql);
            using var da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
    }
}
