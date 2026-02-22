using System.Drawing;
using System.Windows.Forms;

namespace GVC.Helpers
{
    public enum StatusTipo
    {
        Info,
        Sucesso,
        Alerta,
        Erro,
        Neutro
    }

    public static class StatusBarPadrao
    {
        public static int ContarLinhasValidas(DataGridView grid)
        {
            if (grid == null) return 0;

            int count = grid.Rows.Count;
            if (grid.AllowUserToAddRows) count -= 1;
            return count < 0 ? 0 : count;
        }

        public static void AtualizarTotalBanco(ToolStripStatusLabel lblTotalBanco, int totalNoBanco)
        {
            lblTotalBanco.Text = $"Total cadastrado: {totalNoBanco:N0}";
            lblTotalBanco.ForeColor = Color.DimGray;
        }

        public static void Mensagem(ToolStripStatusLabel lblStatus, string texto, StatusTipo tipo)
        {
            lblStatus.Text = texto;
            lblStatus.ForeColor = CorPorTipo(tipo);
        }

        public static void MensagemPesquisa(
            ToolStripStatusLabel lblStatus,
            DataGridView grid,
            string nomeEntidadeSingular,
            string textoPesquisa)
        {
            int exibidos = ContarLinhasValidas(grid);

            if (string.IsNullOrWhiteSpace(textoPesquisa))
            {
                Mensagem(lblStatus, $"Exibindo {exibidos:N0} {nomeEntidadeSingular}(s).", StatusTipo.Info);
                return;
            }

            if (exibidos > 0)
                Mensagem(lblStatus, $"Resultado: {exibidos:N0} {nomeEntidadeSingular}(s) para '{textoPesquisa}'.", StatusTipo.Sucesso);
            else
                Mensagem(lblStatus, $"Nenhum {nomeEntidadeSingular} encontrado para '{textoPesquisa}'.", StatusTipo.Alerta);
        }

        private static Color CorPorTipo(StatusTipo tipo) => tipo switch
        {
            StatusTipo.Sucesso => Color.ForestGreen,
            StatusTipo.Alerta => Color.Red,
            StatusTipo.Erro => Color.DarkRed,
            StatusTipo.Neutro => Color.DimGray,
            _ => Color.RoyalBlue,
        };
    }
}