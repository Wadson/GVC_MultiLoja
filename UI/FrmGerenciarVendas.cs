using GVC.BLL;
using GVC.DAL;
using GVC.UTIL;
using Krypton.Toolkit;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GVC.View
{
    public partial class FrmGerenciarVendas : KryptonForm
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ClienteID { get; set; }
        public FrmGerenciarVendas()
        {
            InitializeComponent();
        }

        private int ObterVendaSelecionada()
        {
            if (dgvVendas.SelectedRows.Count == 0)
                throw new Exception("Selecione uma venda.");

            var valor = dgvVendas.SelectedRows[0].Cells["VendaID"].Value;

            if (valor == null || valor == DBNull.Value)
                throw new Exception("Venda inválida.");

            return Convert.ToInt32(valor);
        }
        private void CarregarVendas()
        {
            string sql = @" SELECT  v.VendaID, c.Nome AS Cliente, v.DataVenda, v.ValorTotal, v.Desconto, v.StatusVenda
        FROM Venda v INNER JOIN Clientes c ON c.ClienteID = v.ClienteID WHERE 1 = 1 ";

            if (!string.IsNullOrWhiteSpace(txtVendaID.Text))
                sql += " AND v.VendaID = @VendaID";

            if (!string.IsNullOrWhiteSpace(txtCliente.Text))
                sql += " AND c.Nome LIKE @Cliente";

            sql += " AND v.DataVenda >= @DataInicio AND v.DataVenda < @DataFim\r\n";

            using var conn = Conexao.Conex();
            conn.Open();

            using var cmd = new SqlCommand(sql, conn);

            if (!string.IsNullOrWhiteSpace(txtVendaID.Text))
                cmd.Parameters.AddWithValue("@VendaID", Convert.ToInt64(txtVendaID.Text));

            if (!string.IsNullOrWhiteSpace(txtCliente.Text))
                cmd.Parameters.AddWithValue("@Cliente", $"%{txtCliente.Text}%");

            cmd.Parameters.Add("@DataInicio", SqlDbType.DateTime).Value = dtpDataInicio.Value.Date;
            cmd.Parameters.Add("@DataFim", SqlDbType.DateTime).Value = dtpDataFim.Value.Date.AddDays(1);


            var dt = new DataTable();
            using var da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dgvVendas.DataSource = dt;

            FormatarGridVendas();
        }
        private void FormatarGridVendas()
        {
            if (dgvVendas.Columns.Count == 0) return;

            // ===============================
            // Cabeçalhos
            // ===============================
            dgvVendas.Columns["VendaID"].HeaderText = "Venda";
            dgvVendas.Columns["Cliente"].HeaderText = "Cliente";
            dgvVendas.Columns["DataVenda"].HeaderText = "Data";
            dgvVendas.Columns["ValorTotal"].HeaderText = "Total";
            dgvVendas.Columns["Desconto"].HeaderText = "Desconto";
            dgvVendas.Columns["StatusVenda"].HeaderText = "Status";

            // ===============================
            // Colunas FIXAS
            // ===============================
            dgvVendas.Columns["VendaID"].Width = 60;
            dgvVendas.Columns["DataVenda"].Width = 100;
            dgvVendas.Columns["ValorTotal"].Width = 110;
            dgvVendas.Columns["Desconto"].Width = 110;
            dgvVendas.Columns["StatusVenda"].Width = 140;

            // ===============================
            // Coluna Cliente FLEXÍVEL
            // ===============================
            dgvVendas.Columns["Cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvVendas.Columns["Cliente"].MinimumWidth = 200;

            // ===============================
            // Formatação
            // ===============================
            dgvVendas.Columns["DataVenda"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvVendas.Columns["ValorTotal"].DefaultCellStyle.Format = "C2";
            dgvVendas.Columns["Desconto"].DefaultCellStyle.Format = "C2";

            dgvVendas.Columns["VendaID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVendas.Columns["ValorTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVendas.Columns["Desconto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVendas.Columns["StatusVenda"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // ===============================
            // Grid
            // ===============================
            dgvVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVendas.MultiSelect = false;
            dgvVendas.ReadOnly = true;
            dgvVendas.AllowUserToResizeColumns = false;
            dgvVendas.AllowUserToResizeRows = false;
            dgvVendas.RowHeadersVisible = false;
            dgvVendas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            // ===============================
            // Evento Status (remove duplicação)
            // ===============================
            dgvVendas.CellFormatting -= dgvVendas_CellFormatting;
            dgvVendas.CellFormatting += dgvVendas_CellFormatting;
        }

        private void dgvVendas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvVendas.Columns[e.ColumnIndex].Name == "StatusVenda" && e.Value != null)
            {
                string status = e.Value.ToString();

                if (status.Equals("Vencida", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (status.Equals("Aberta", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = Color.Orange;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else if (status.Equals("Pago", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }
        private void FrmGerenciarVendas_Load(object sender, EventArgs e)
        {
            dtpDataInicio.Value = DateTime.Today.AddMonths(-1);
            dtpDataFim.Value = DateTime.Today;
            CarregarVendas();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            // SALVA O TEXTO ATUAL ANTES DE PERDER O FOCO
            string textoDigitado = txtCliente.Text;

            try
            {
                using (var pesquisaCliente = new FrmLocalizarCliente(this, textoDigitado))
                {
                    pesquisaCliente.Owner = this;

                    if (pesquisaCliente.ShowDialog() == DialogResult.OK)
                    {
                        txtCliente.Text = pesquisaCliente.ClienteSelecionado;
                        ClienteID = pesquisaCliente.ClienteID;
                        txtCliente.SelectionStart = txtCliente.Text.Length;

                    }
                }
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso(ex.Message);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregarVendas();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int vendaId = ObterVendaSelecionada();

            var confirmacao = MessageBox.Show(
                "⚠️ ATENÇÃO – EXCLUSÃO TOTAL ⚠️\n\n" +
                "Esta ação irá EXCLUIR DEFINITIVAMENTE:\n" +
                "• A VENDA\n" +
                "• TODOS OS ITENS\n" +
                "• TODAS AS PARCELAS\n\n" +
                "❌ ESTA OPERAÇÃO NÃO PODERÁ SER DESFEITA ❌\n\n" +
                "Deseja continuar?",
                "CONFIRMAÇÃO CRÍTICA",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            if (confirmacao != DialogResult.Yes)
                return;

            try
            {
                new VendaBLL().ExcluirVendaFisicamente(vendaId);
                Utilitario.Mensagens.Aviso("Venda excluída definitivamente.");
                CarregarVendas();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            int vendaId = ObterVendaSelecionada();

            using (var frmMotivo = new FrmMotivoOperacao("Cancelamento de Venda"))
            {
                if (frmMotivo.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    new VendaBLL().CancelarVenda(vendaId, frmMotivo.Motivo);
                    Utilitario.Mensagens.Aviso("Venda cancelada com sucesso.");
                    CarregarVendas();
                }
                catch (Exception ex)
                {
                    Utilitario.Mensagens.Aviso(ex.Message);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvVendas.CurrentRow == null)
            {
                Utilitario.Mensagens.Aviso("Selecione uma venda para alterar.");
                return;
            }

            int vendaId = Convert.ToInt32(dgvVendas.CurrentRow.Cells["VendaID"].Value);

            var frm = new FrmPDVendas(vendaId);
            //Falta implementação de mais botões e controles aqui
            frm.txtClienteBuscar.Enabled = false;
            frm.txtProdutoBuscar.Enabled = false;
            frm.btnNovaVenda.Enabled = false;
            frm.ShowDialog();

            // opcional e comum:
            // Recarregar a lista após fechar
            // CarregarVendas();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (dgvVendas.CurrentRow == null)
            {
                Utilitario.Mensagens.Aviso("Selecione uma venda para visualizar.");
                return;
            }

            int vendaId = Convert.ToInt32(dgvVendas.CurrentRow.Cells["VendaID"].Value);
            var frm = new FrmPDVendas(vendaId);
            frm.ShowDialog();
        }
    }
}
