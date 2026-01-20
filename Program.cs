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

          

            Application.DoEvents(); // força pintura inicial

            using var frm = new FrmDatabaseSetup();

            frm.Shown += (_, __) =>
            {
                DatabaseInstaller.Run(frm.AtualizarProgressoThreadSafe);
                frm.Close();
            };

            Application.Run(frm);



            using var login = new FrmLogin();
            if (login.ShowDialog() == DialogResult.OK)
                Application.Run(new FrmPrincipal());
        }



    }
}
