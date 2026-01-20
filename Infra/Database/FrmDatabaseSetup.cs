using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace GVC.Infra.Database
{
    public partial class FrmDatabaseSetup : KryptonForm
    {
        public FrmDatabaseSetup()
        {
            InitializeComponent();
            progressBar.Minimum = 0;
            progressBar.Step = 1;
        }
        public void AtualizarProgressoThreadSafe(
     int atual, int total, string script)
        {
            if (InvokeRequired)
            {
                Invoke(() => AtualizarProgressoThreadSafe(atual, total, script));
                return;
            }

            progressBar.Maximum = total;
            progressBar.Value = atual;
            lblStatus.Text = $"Executando {script} ({atual}/{total})";
        }

    }
}
