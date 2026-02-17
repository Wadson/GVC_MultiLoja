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
                Utilitario.Mensagens.Aviso("Sessão expirada, inválida. Faça login novamente");

                Close();
                return;
            }

            // 🔒 Validação de empresa
            if (Sessao.EmpresaID <= 0)
            {
                Utilitario.Mensagens.Info(
                    "Empresa não definida, Nenhuma empresa selecionada.");

                Close();
                return;
            }
        }
    }
}
