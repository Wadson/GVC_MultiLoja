using GVC.UTIL;
using Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace GVC.View
{
    public class BaseForm : KryptonForm
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // 🔒 Validação mínima de sessão
            if (!Sessao.Logado)
            {
                MessageBox.Show(
                    "Sessão inválida. Faça login novamente.",
                    "Sessão expirada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Close();
                return;
            }

            // 🔒 Validação de empresa
            if (Sessao.EmpresaID <= 0)
            {
                MessageBox.Show(
                    "Nenhuma empresa selecionada.",
                    "Empresa não definida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Close();
                return;
            }
        }
    }
}
