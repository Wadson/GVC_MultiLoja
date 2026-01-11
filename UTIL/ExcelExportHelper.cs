using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GVC.UTIL
{
    public static class ExcelExportHelper
    {
        public static void ExportarDataGridView(DataGridView dgv, string arquivo)
        {
            using var sfd = new SaveFileDialog
            {
                Filter = "Excel (*.xlsx)|*.xlsx",
                FileName = arquivo
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            var dt = new DataTable();

            foreach (DataGridViewColumn col in dgv.Columns)
                dt.Columns.Add(col.HeaderText);

            foreach (DataGridViewRow row in dgv.Rows)
            {
                var dr = dt.NewRow();
                for (int i = 0; i < dgv.Columns.Count; i++)
                    dr[i] = row.Cells[i].Value;
                dt.Rows.Add(dr);
            }

            ExcelGenerator.Exportar(dt, sfd.FileName); // usa o que você já tem
        }
    }

}
