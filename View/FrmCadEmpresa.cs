using GVC.BLL;
using GVC.MODEL;
using GVC.MUI;
using GVC.UTIL;
using iText.StyledXmlParser.Jsoup.Nodes;
using Krypton.Toolkit;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GVC.UTIL.BrasilApiCepResponse;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GVC.View
{
    public partial class FrmCadEmpresa : KryptonForm
    {      
        public FrmCadEmpresa()
        {
            InitializeComponent();
        }             
    }
}