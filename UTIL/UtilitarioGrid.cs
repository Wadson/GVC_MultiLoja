using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.UTIL
{
    public static class UtilitarioGrid
    {
        public static void ConfigurarPadrao(DataGridView dgv)
        {
            dgv.SuspendLayout();

            dgv.AutoGenerateColumns = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;

            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 35;
            dgv.RowHeadersWidth = 28;

            dgv.ResumeLayout();
        }

        public static void ColunaFixa(DataGridView dgv, string nome, int largura)
        {
            if (dgv.Columns[nome] == null) return;

            var col = dgv.Columns[nome];
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col.Width = largura;
            col.MinimumWidth = largura;
        }

        public static void ColunaExpandir(DataGridView dgv, string nome, int larguraMinima, int peso = 1)
        {
            if (dgv.Columns[nome] == null) return;

            var col = dgv.Columns[nome];
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col.MinimumWidth = larguraMinima;
            col.FillWeight = peso;
        }

        public static void Header(DataGridView dgv, string nome, string texto)
        {
            if (dgv.Columns[nome] != null)
                dgv.Columns[nome].HeaderText = texto;
        }

        public static void AplicarMascaraVisual(DataGridView dgv)
        {
            dgv.CellFormatting += (s, e) =>
            {
                if (e.Value == null) return;

                string col = dgv.Columns[e.ColumnIndex].Name;
                string raw = e.Value.ToString();

                string Digitos(string v) => new string(v.Where(char.IsDigit).ToArray());

                if (col == "Cnpj")
                {
                    string c = Digitos(raw);
                    if (c.Length == 14 && ulong.TryParse(c, out ulong n))
                    {
                        e.Value = n.ToString(@"00\.000\.000\/0000\-00");
                        e.FormattingApplied = true;
                    }
                }
                else if (col == "Telefone")
                {
                    string t = Digitos(raw);
                    if (t.Length == 11)
                    {
                        e.Value = $"({t[..2]}) {t[2]} {t.Substring(3, 4)}-{t.Substring(7)}";
                        e.FormattingApplied = true;
                    }
                }
                else if (col == "Cep")
                {
                    string c = Digitos(raw);
                    if (c.Length == 8)
                    {
                        e.Value = $"{c[..2]}.{c.Substring(2, 3)}-{c.Substring(5)}";
                        e.FormattingApplied = true;
                    }
                }
            };
        }
    }
}

/*
 * 
 * Exemplo de uso:
 * private bool _gridConfigurado = false;

private void FrmManutEmpresa_Load(object sender, EventArgs e)
{
    ListarEmpresa();

    if (!_gridConfigurado)
    {
        UtilitarioGrid.ConfigurarPadrao(dgvEmpresa);

        UtilitarioGrid.Header(dgvEmpresa, "EmpresaID", "Código");
        UtilitarioGrid.Header(dgvEmpresa, "RazaoSocial", "Razão Social");
        UtilitarioGrid.Header(dgvEmpresa, "NomeFantasia", "Nome Fantasia");

        UtilitarioGrid.ColunaFixa(dgvEmpresa, "EmpresaID", 70);
        UtilitarioGrid.ColunaExpandir(dgvEmpresa, "RazaoSocial", 250, 3);
        UtilitarioGrid.ColunaExpandir(dgvEmpresa, "NomeFantasia", 220, 2);

        UtilitarioGrid.ColunaFixa(dgvEmpresa, "Cnpj", 160);
        UtilitarioGrid.ColunaFixa(dgvEmpresa, "Telefone", 140);
        UtilitarioGrid.ColunaFixa(dgvEmpresa, "Cep", 90);

        UtilitarioGrid.AplicarMascaraVisual(dgvEmpresa);

        _gridConfigurado = true;
    }
}

 * */