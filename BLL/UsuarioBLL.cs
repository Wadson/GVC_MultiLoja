using GVC.DAL;
using GVC.Model;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using GVC.UTIL;

namespace GVC.BLL
{
    internal class UsuarioBLL
    {
        UsuarioDal usuariodal = null;

        public string ObterSenhaHashPorId(int usuarioId)
        {
            string sql = "SELECT Senha FROM Usuarios WHERE UsuarioID = @id";

            using (var conn = Conexao_.Conex(Sessao.AmbienteSelecionado))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", usuarioId);

                conn.Open();
                object result = cmd.ExecuteScalar();
                return result?.ToString(); // retorna a senha como string
            }

        }
        public DataTable Listar()
        {
            DataTable dtable = new DataTable();
            try
            {
                usuariodal = new UsuarioDal();
                dtable = usuariodal.ListaUsuario();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }

        public void Salvar(UsuarioModel usuarios)
        {
            if (string.IsNullOrWhiteSpace(usuarios.Cpf))
                throw new ArgumentException("O campo CPF não pode ser nulo ou vazio.");

            try
            {
                usuariodal = new UsuarioDal();
                usuariodal.GravaUsuario(usuarios);
            }
            catch (SqlException sqlEx)
            {
                // Tratamento específico para erros de banco
                if (sqlEx.Message.Contains("CHK_Usuarios_Email_Format"))
                    throw new Exception("O e-mail informado não está em formato válido.");
                else
                    throw new Exception("Erro ao gravar usuário no banco: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro inesperado: " + ex.Message);
            }
        }



        public void Excluir(UsuarioModel usuarios)
        {
            try
            {
                usuariodal = new UsuarioDal();
                usuariodal.ExcluiUsuario(usuarios);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public void Alterar(UsuarioModel usuarios)
        {
            try
            {
                usuariodal = new UsuarioDal();
                usuariodal.Atualizar(usuarios);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void AtualizaUsuarioDalSenha(UsuarioModel usuarios)
        {
            try
            {
                usuariodal = new UsuarioDal();
                usuariodal.AtualizaUsuarioSenha(usuarios);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
      
        public UsuarioModel PesquisarNo(DataGridView DataGridPesquisa, string pesquisa)
        {
            var conn = Conexao_.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("SELECT * FROM Usuarios WHERE NomeUsuario like '" + pesquisa + "%'", conn);
                conn.Open();
                SqlDataReader datareader;
                UsuarioModel obj_usuario = new UsuarioModel();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);

                while (datareader.Read())
                {
                    obj_usuario.UsuarioID = Convert.ToInt32(datareader["UsuarioID"]);
                    obj_usuario.NomeUsuario = datareader["NomeUsuario"].ToString();
                }
                return obj_usuario;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conn.Close();
            }
        }
        public UsuarioModel PesquisarCodigo(string pesquisa)
        {
            var conn = Conexao_.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("SELECT * FROM Usuarios WHERE UsuarioID like '" + pesquisa + "%'", conn);
                conn.Open();
                SqlDataReader datareader;
                UsuarioModel obj_usuario = new UsuarioModel();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);

                while (datareader.Read())
                {
                    obj_usuario.UsuarioID = Convert.ToInt32(datareader["UsuarioID"]);
                    obj_usuario.NomeUsuario = datareader["NomeUsuario"].ToString();
                }
                return obj_usuario;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
