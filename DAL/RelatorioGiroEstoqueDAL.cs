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
    public class RelatorioGiroEstoqueDAL
    {
        public DataTable ObterGiro(DateTime inicio, DateTime fim)
        {
            var dt = new DataTable();

            using var conn = Conexao_.Conex();
            conn.Open();

            string sql = /* SQL acima */"";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Inicio", inicio);
            cmd.Parameters.AddWithValue("@Fim", fim);

            using var da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
    }

}
