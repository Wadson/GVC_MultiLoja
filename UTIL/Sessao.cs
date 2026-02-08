namespace GVC.UTIL
{
    public static class Sessao
    {
        // 🔹 Usuário logado
        public static int UsuarioID { get; set; }
        public static string NomeUsuario { get; set; }

        // 🔹 Empresa atual (multi-loja)
        public static int EmpresaID { get; set; }
        public static string EmpresaNome { get; set; }

        // 🔹 Estado da sessão
        public static bool Logado =>
            UsuarioID > 0 &&
            EmpresaID > 0;

        public static void Limpar()
        {
            UsuarioID = 0;
            NomeUsuario = null;
            EmpresaID = 0;
            EmpresaNome = null;
        }
    }
}
