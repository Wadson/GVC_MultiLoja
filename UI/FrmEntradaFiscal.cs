using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace GVC.View
{
    public partial class FrmEntradaFiscal : KryptonForm
    {
        public FrmEntradaFiscal()
        {
            InitializeComponent();
        }

        private void FrmEntradaFiscal_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

        }
    }
}
