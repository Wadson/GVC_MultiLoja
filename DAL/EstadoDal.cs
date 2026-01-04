using Dapper;
using GVC.Model;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;


namespace GVC.DAL
{
    internal class EstadoDal
    {
        // ================== LISTAR TODOS ==================
        public DataTable Listar()
        {
            const string sql = "SELECT EstadoID, Nome, Uf FROM Estado ORDER BY Nome";

            using var conn = Conexao.Conex();
            var dt = new DataTable();
            dt.Load(conn.ExecuteReader(sql));
            return dt;
        }
        // ================== LISTAR COMO LISTA TIPADA (recomendado para ComboBox, etc) ==================
        public List<EstadoModel> ListarTodos()
        {
            const string sql = "SELECT EstadoID, Nome AS Nome, Uf AS Uf FROM Estado ORDER BY Nome";

            using var conn = Conexao.Conex();
            return conn.Query<EstadoModel>(sql).AsList();
        }
        // ================== SALVAR (INSERT) ==================
        public void Salvar(EstadoModel estado)
        {
            const string sql = @" INSERT INTO Estado (EstadoID, Nome, Uf) VALUES (@EstadoID, @Nome, @Uf)";

            using var conn = Conexao.Conex();
            conn.Execute(sql, estado);
        }
        // ================== ATUALIZAR ==================
        public void Atualizar(EstadoModel estado)
        {
            const string sql = @" UPDATE Estado SET Nome = @Nome, Uf = @Uf WHERE EstadoID = @EstadoID";
            using var conn = Conexao.Conex();
            conn.Execute(sql, estado);
        }
        // ================== EXCLUIR ==================
        public void Excluir(int EstadoID)
        {
            const string sql = "DELETE FROM Estado WHERE EstadoID = @EstadoID";
            using var conn = Conexao.Conex();
            conn.Execute(sql, new { EstadoID = EstadoID });
        }
        // Ou se preferir passar o objeto inteiro:
        public void Excluir(EstadoModel estado) => Excluir(estado.EstadoID);
        // ================== PESQUISAR POR NOME ==================
        public DataTable PesquisarPorNome(string nome)
        {
            const string sql = @" SELECT EstadoID, Nome, Uf FROM Estado WHERE Nome LIKE @Nome ORDER BY Nome LIMIT 50";

            using var conn = Conexao.Conex();
            var dt = new DataTable();
            dt.Load(conn.ExecuteReader(sql, new { Nome = $"%{nome}%" }));
            return dt;
        }
 
        public DataTable PesquisarPorCodigo(int codigo)
        {
            const string sql = "SELECT EstadoID, Nome, Uf FROM Estado WHERE EstadoID = @EstadoID";
            using var conn = Conexao.Conex();
            var dt = new DataTable();
            dt.Load(conn.ExecuteReader(sql, new { EstadoID = codigo }));
            return dt;
        }
        // ================== BUSCAR POR ID (retorna objeto) ==================
        public EstadoModel? BuscarPorId(int id)
        {
            const string sql = "SELECT EstadoID, Nome AS Nome, Uf AS Uf FROM Estado WHERE EstadoID = @Id";
            using var conn = Conexao.Conex();
            return conn.QueryFirstOrDefault<EstadoModel>(sql, new { Id = id });
        }

    }
}
