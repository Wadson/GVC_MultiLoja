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
    public class MovimentacaoEstoqueDAL
    {
        public DataTable Consultar(
            int? produtoId,
            string tipo,
            string origem,
            DateTime inicio,
            DateTime fim)
        {
            var dt = new DataTable();

            using var conn = Conexao_.Conex();
            conn.Open();

            string sql = @"
        SELECT
            me.MovimentacaoID,
            me.DataMovimentacao,
            me.TipoMovimentacao,
            me.Quantidade,
            me.EstoqueAnterior,
            me.EstoqueAtual,
            me.Origem,
            me.Documento,
            me.Observacao,
            me.Usuario,
            p.ProdutoID,
            p.NomeProduto
        FROM MovimentacaoEstoque me
        INNER JOIN Produtos p ON p.ProdutoID = me.ProdutoID
        WHERE me.DataMovimentacao BETWEEN @Inicio AND @Fim";

            if (produtoId.HasValue)
                sql += " AND me.ProdutoID = @ProdutoID";

            if (!string.IsNullOrEmpty(tipo))
                sql += " AND me.TipoMovimentacao = @Tipo";

            if (!string.IsNullOrEmpty(origem))
                sql += " AND me.Origem = @Origem";

            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Inicio", inicio);
            cmd.Parameters.AddWithValue("@Fim", fim);

            if (produtoId.HasValue)
                cmd.Parameters.AddWithValue("@ProdutoID", produtoId.Value);

            if (!string.IsNullOrEmpty(tipo))
                cmd.Parameters.AddWithValue("@Tipo", tipo);

            if (!string.IsNullOrEmpty(origem))
                cmd.Parameters.AddWithValue("@Origem", origem);

            using var da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
    }

}
