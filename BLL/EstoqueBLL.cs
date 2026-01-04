using GVC.DAL;
using GVC.Model;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.BLL
{
    public class EstoqueBLL
    {
        private readonly EstoqueDAL _dal = new EstoqueDAL();

        public void MovimentarEstoque(MovimentacaoEstoqueModel mov)
        {
            using var conn = Conexao.Conex();
            conn.Open();
            using var tran = conn.BeginTransaction();

            try
            {
                int estoqueAtual = _dal.ObterEstoqueAtual(mov.ProdutoID, conn, tran);
                int novoEstoque;

                switch (mov.TipoMovimentacao)
                {
                    case "Entrada":
                        novoEstoque = estoqueAtual + mov.Quantidade;
                        break;

                    case "Saida":
                        if (estoqueAtual < mov.Quantidade)
                            throw new Exception("Estoque insuficiente para saída.");

                        novoEstoque = estoqueAtual - mov.Quantidade;
                        break;

                    case "Ajuste":
                        // Ajuste define o estoque final diretamente
                        novoEstoque = mov.Quantidade;
                        break;

                    default:
                        throw new Exception("Tipo de movimentação inválido.");
                }

                _dal.AtualizarEstoque(mov.ProdutoID, novoEstoque, conn, tran);

                mov.EstoqueAnterior = estoqueAtual;
                mov.EstoqueAtual = novoEstoque;

                _dal.RegistrarMovimentacao(mov, conn, tran);

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }       

    }
}
