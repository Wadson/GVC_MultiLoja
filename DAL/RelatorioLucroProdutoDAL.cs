using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.DAL
{
    public class RelatorioLucroProdutoDAL
    {
        public DataTable RankingLucro()
        {
            var dt = new DataTable();

            using var conn = Conexao_.Conex();
            conn.Open();

            string sql = /* SQL acima */"";

            using var da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);

            return dt;
        }
    }

}
