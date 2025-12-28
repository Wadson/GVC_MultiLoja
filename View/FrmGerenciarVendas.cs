using GVC.BLL;
using GVC.DALL;
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
        public int ClienteID { get; set; }
        public FrmGerenciarVendas()
        {
            InitializeComponent();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (dgvVendas.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma venda para visualizar.");
                return;
            }

            long vendaId = Convert.ToInt64(
                dgvVendas.CurrentRow.Cells["VendaID"].Value
            );

            var frm = new FrmPDV(vendaId);
            frm.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvVendas.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma venda para alterar.");
                return;
            }

            long vendaId = Convert.ToInt64(
                dgvVendas.CurrentRow.Cells["VendaID"].Value
            );

            var frm = new FrmPDV(vendaId);
            frm.btnCancelarParcelas.Enabled = false;
            frm.btnCancelarVenda.Enabled = false;
            frm.btnImprimirCupomNaoFiscal.Enabled = false;
            frm.btnSalvarVenda.Enabled = false;
            frm.btnCancelarParcelas.Enabled = false;  
            frm.pnlFormaPgto.Enabled = false;
            frm.flowLayoutPanelTotais.Enabled = false;
            frm.pnlObservacoes.Enabled = false;   
            frm.txtClienteBuscar.Enabled = false;
            frm.txtProdutoBuscar.Enabled = false;                       
            frm.btnNovaVenda.Enabled = false;   
            frm.ShowDialog();

            // opcional e comum:
            // Recarregar a lista após fechar
            // CarregarVendas();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            long vendaId = ObterVendaSelecionada();

            using (var frmMotivo = new FrmMotivoOperacao("Cancelamento de Venda"))
            {
                if (frmMotivo.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    new VendaBLL().CancelarVenda(vendaId, frmMotivo.Motivo);
                    MessageBox.Show("Venda cancelada com sucesso.");
                    CarregarVendas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            long vendaId = ObterVendaSelecionada();

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
                MessageBox.Show("Venda excluída definitivamente.");
                CarregarVendas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private long ObterVendaSelecionada()
        {
            if (dgvVendas.SelectedRows.Count == 0)
                throw new Exception("Selecione uma venda.");

            var valor = dgvVendas.SelectedRows[0].Cells["VendaID"].Value;

            if (valor == null || valor == DBNull.Value)
                throw new Exception("Venda inválida.");

            return Convert.ToInt64(valor);
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

            using var conn = GVC.Helpers.Conexao.Conex();
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

            // Cabeçalhos
            dgvVendas.Columns["VendaID"].HeaderText = "Venda";
            dgvVendas.Columns["Cliente"].HeaderText = "Cliente";
            dgvVendas.Columns["DataVenda"].HeaderText = "Data";
            dgvVendas.Columns["ValorTotal"].HeaderText = "Total";
            dgvVendas.Columns["Desconto"].HeaderText = "Desconto";
            dgvVendas.Columns["StatusVenda"].HeaderText = "Status";

            // Larguras
            dgvVendas.Columns["VendaID"].Width = 100;
            dgvVendas.Columns["Cliente"].Width = 400; // aumentada
            dgvVendas.Columns["DataVenda"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvVendas.Columns["ValorTotal"].DefaultCellStyle.Format = "C2";
            dgvVendas.Columns["Desconto"].DefaultCellStyle.Format = "C2";

            // Centralizar VendaID
            dgvVendas.Columns["VendaID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Seleção e leitura
            dgvVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVendas.MultiSelect = false;
            dgvVendas.ReadOnly = true;

            // Evento para colorir Status
            dgvVendas.CellFormatting += (s, e) =>
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
            };
        }

        private void FrmGerenciarVendas_Load(object sender, EventArgs e)
        {
            dtpDataInicio.Value = DateTime.Today.AddMonths(-1);
            dtpDataFim.Value = DateTime.Today;
            CarregarVendas();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarVendas();
        }
        private void btnLocalizarCliente_Click(object sender, EventArgs e)
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
                MessageBox.Show(ex.Message);
            }
        }
       
    }
}
