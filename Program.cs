using GVC.MUI;
using GVC.View;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GVC
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            QuestPDF.Settings.License = LicenseType.Community;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //FrmLogin frmLogin = new FrmLogin();
            //if (frmLogin.ShowDialog() == DialogResult.OK) // Se o login for bem-sucedido
            //{
            //    Application.Run(new FrmPrincipal()); // Abre a tela principal
            //}
            //else
            //{
            //    Application.Exit(); // Fecha o aplicativo se o login for cancelado
            //}


            Application.Run(new FrmPrincipal());
        }
    }
}
