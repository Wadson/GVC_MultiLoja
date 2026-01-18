using GVC.Infra.Database;
using GVC.Infra.Database;
using GVC.MUI;
using GVC.View;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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

            // Acima não mexer

           


            //// Abaixo não mexer

            //try
            //{
            //    var connectionString = DatabaseConnectionResolver.ResolverConnectionString();

            //    ScriptSqlEmbeddedExecutor.EnsureDatabase(connectionString);

            //    using var frmLogin = new FrmLogin();
            //    if (frmLogin.ShowDialog() == DialogResult.OK)
            //    {
            //        Application.Run(new FrmPrincipal());
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(
            //        "Erro crítico ao inicializar o sistema:\n\n" + ex.Message,
            //        "Erro",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);

            //    Application.Exit();
            //}


            // escolha um dos blocos abaixo, ou acima


            //FrmLogin frmLogin = new FrmLogin();

            //if (frmLogin.ShowDialog() == DialogResult.OK) // Se o login for bem-sucedido
            //{
            //    Application.Run(new FrmPrincipal()); // Abre a tela principal
            //}
            //else
            //{
            //    Application.Exit(); // Fecha o aplicativo se o login for cancelado
            //}

            // só este abaixo ou um dos blocos acima

            Application.Run(new FrmPrincipal());
        }


    }
}
