using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace GVC.UTIL
{
    public partial class FrmModelo : KryptonForm
    {
        public FrmModelo()
        {
            InitializeComponent();
        }

        private void FrmModelo_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

        }
    }
}
