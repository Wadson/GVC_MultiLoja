using GVC.UTIL;

public static class ValidadorSessao
{
    public static bool Validar(Form form)
    {
        if (!Sessao.Logado || Sessao.EmpresaID <= 0)
        {
            MessageBox.Show(
                "Sessão inválida ou empresa não selecionada.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            form.Close();
            return false;
        }

        return true;
    }
}
