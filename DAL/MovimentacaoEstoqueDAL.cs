using System;
using System.Data;
using GVC.Infra.Repository;

namespace GVC.DAL
{
    public class MovimentacaoEstoqueDAL : RepositoryBase
    {
        public DataTable Consultar(
            int? produtoId,
            string tipo,
            string origem,
            DateTime inicio,
            DateTime fim)
        {
            var sql = @"
            SELECT me.*, p.NomeProduto
            FROM MovimentacaoEstoque me
            INNER JOIN Produtos p ON p.ProdutoID = me.ProdutoID
            WHERE me.EmpresaID = @EmpresaID
              AND me.DataMovimentacao BETWEEN @Inicio AND @Fim";

            if (produtoId.HasValue) sql += " AND me.ProdutoID = @ProdutoID";
            if (!string.IsNullOrEmpty(tipo)) sql += " AND me.TipoMovimentacao = @Tipo";
            if (!string.IsNullOrEmpty(origem)) sql += " AND me.Origem = @Origem";

            using var cmd = CreateCommand(sql);
            cmd.Parameters.AddWithValue("@Inicio", inicio);
            cmd.Parameters.AddWithValue("@Fim", fim);
            if (produtoId.HasValue) cmd.Parameters.AddWithValue("@ProdutoID", produtoId);
            if (!string.IsNullOrEmpty(tipo)) cmd.Parameters.AddWithValue("@Tipo", tipo);
            if (!string.IsNullOrEmpty(origem)) cmd.Parameters.AddWithValue("@Origem", origem);

            var dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
    }
}
