using GVC.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GVC.UTIL;
using GVC.Infra.Conexao;

namespace GVC.DAL
{
    public class EstoqueDAL
    {
        public int ObterEstoqueAtual(int produtoId, SqlConnection conn, SqlTransaction tran)
        {
            const string sql = "SELECT Estoque FROM Produtos WHERE ProdutoID = @ProdutoID";

            using var cmd = new SqlCommand(sql, conn, tran);
            cmd.Parameters.AddWithValue("@ProdutoID", produtoId);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        public int ObterEstoqueAtualizado(long produtoId)
        {
            using (var conn = Conexao.Conex())
            {
                string sql = "SELECT Estoque FROM Produtos WHERE ProdutoID = @id AND EmpresaID = @EmpresaID";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", produtoId);
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public void AtualizarEstoque(int produtoId, int novoEstoque, SqlConnection conn, SqlTransaction tran)
        {
            const string sql = "UPDATE Produtos SET Estoque = @Estoque WHERE ProdutoID = @ProdutoID";

            using var cmd = new SqlCommand(sql, conn, tran);
            cmd.Parameters.AddWithValue("@Estoque", novoEstoque);
            cmd.Parameters.AddWithValue("@ProdutoID", produtoId);

            cmd.ExecuteNonQuery();
        }

        public void RegistrarMovimentacao(MovimentacaoEstoqueModel mov, SqlConnection conn, SqlTransaction tran)
        {
            const string sql = @"
            INSERT INTO MovimentacaoEstoque
            (ProdutoID, TipoMovimentacao, Quantidade, EstoqueAnterior, EstoqueAtual,
             Origem, Documento, Observacao, Usuario)
            VALUES
            (@ProdutoID, @Tipo, @Quantidade, @Anterior, @Atual,
             @Origem, @Documento, @Observacao, @Usuario)";

            using var cmd = new SqlCommand(sql, conn, tran);

            cmd.Parameters.AddWithValue("@ProdutoID", mov.ProdutoID);
            cmd.Parameters.AddWithValue("@Tipo", mov.TipoMovimentacao);
            cmd.Parameters.AddWithValue("@Quantidade", mov.Quantidade);
            cmd.Parameters.AddWithValue("@Anterior", mov.EstoqueAnterior);
            cmd.Parameters.AddWithValue("@Atual", mov.EstoqueAtual);
            cmd.Parameters.AddWithValue("@Origem", mov.Origem);
            cmd.Parameters.AddWithValue("@Documento", (object)mov.Documento ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Observacao", (object)mov.Observacao ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Usuario", (object)mov.Usuario ?? DBNull.Value);

            cmd.ExecuteNonQuery();
        }
    }

}
