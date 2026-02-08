using Microsoft.Data.SqlClient;

namespace GVC.UTIL
{
    public static class SqlSessao
    {
        public static SqlParameter Empresa()
        {
            if (Sessao.EmpresaID <= 0)
                throw new InvalidOperationException("EmpresaID inválido na sessão.");

            return new SqlParameter("@EmpresaID", Sessao.EmpresaID);
        }
    }
}