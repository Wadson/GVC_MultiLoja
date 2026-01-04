using GVC.BLL;
using GVC.DAL;
using GVC.DAL;
using GVC.UTIL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GVC.View
{
    public partial class FrmManutFormaPgto : KryptonForm
    {
        private bool _gridConfigurado = false; //Faz parte da configuração do grid
        private readonly FormaPagamentoBLL _formaPgtoBll = new FormaPagamentoBLL();
        public FrmManutFormaPgto(string statusOperacao)
        {           
            InitializeComponent();
            dgvFormaPgto.CellFormatting += dgvFormaPgto_CellFormatting;

            // Personalização do título
            this.Text = "Manutenção de FormaPgtos";
            this.StateCommon.Header.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            this.StateCommon.Header.Content.ShortText.Color2 = Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI", 12);
        }
        public void ListarFormaPgto()
        {
            FormaPagamentoBLL bll = new FormaPagamentoBLL();

            dgvFormaPgto.SuspendLayout();
            dgvFormaPgto.DataSource = bll.Listar();
            dgvFormaPgto.ResumeLayout();

            if (!_gridConfigurado)
            {
                PersonalizarDataGridView();
                _gridConfigurado = true;
            }

            Utilitario.AtualizarTotal(lblTotalRegistros, dgvFormaPgto);
        }
        private void ConfigurarColunaFill(string coluna, int larguraMinima, int peso)
        {
            var col = dgvFormaPgto.Columns[coluna];
            if (col == null) return;

            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col.MinimumWidth = larguraMinima;
            col.FillWeight = peso;
        }

        private void PersonalizarDataGridView()
        {
            // Campos que EXPANDEM
            ConfigurarColunaFill("NomeFormaPagamento", 250, 1);
          
            // Cabeçalhos
            dgvFormaPgto.Columns["FormaPgtoID"].HeaderText = "Código";
            dgvFormaPgto.Columns["NomeFormaPagamento"].HeaderText = "Forma de Pagamento";

            // Larguras FIXAS
            dgvFormaPgto.Columns["FormaPgtoID"].Width = 60;

            // Campos que EXPANDEM
            dgvFormaPgto.Columns["NomeFormaPagamento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgvFormaPgto.Columns["FormaPgtoID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Estilo
            dgvFormaPgto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvFormaPgto.ColumnHeadersHeight = 35;
            dgvFormaPgto.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvFormaPgto.RowHeadersWidth = 28;
        }
        private void CarregarFormaPgtos()
        {
            dgvFormaPgto.DataSource = _formaPgtoBll.Listar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            
            FrmCadFormaPgto cad = new FrmCadFormaPgto
            {
                StatusOperacao = "NOVO",
                CarregandoDados = false
            };

            cad.ShowDialog();
            if (cad.HouveAlteracao)
                CarregarFormaPgtos(); // método que preenche o DataGrid
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvFormaPgto.CurrentRow == null)
            {
                Utilitario.Mensagens.Aviso("Selecione uma formaPgto!");
                return;
            }

            FrmCadFormaPgto cad = new FrmCadFormaPgto
            {
                StatusOperacao = "ALTERAR",
                FormaPgtoID = Convert.ToInt32(dgvFormaPgto.CurrentRow.Cells["FormaPgtoID"].Value),
                CarregandoDados = true
            };

            cad.ShowDialog();
            if (cad.HouveAlteracao)
                CarregarFormaPgtos(); // método que preenche o DataGrid

        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFormaPgto.CurrentRow == null)
            {
                Utilitario.Mensagens.Aviso("Selecione uma formaPgto!");
                return;
            }

            FrmCadFormaPgto cad = new FrmCadFormaPgto
            {
                StatusOperacao = "EXCLUSAO",
                FormaPgtoID = Convert.ToInt32(dgvFormaPgto.CurrentRow.Cells["FormaPgtoID"].Value),
                CarregandoDados = true
            };

            cad.ShowDialog();
            if (cad.HouveAlteracao)
                CarregarFormaPgtos(); // método que preenche o DataGrid
        }

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }
        private void rbtDescricao_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string texto = txtPesquisa.Text.Trim();

            FormaPagamentoDal dao = new FormaPagamentoDal();
            DataTable dt;

            if (string.IsNullOrEmpty(texto))
            {
                dt = dao.ListaFormaPgto();
            }
            else if (rbtCodigo.Checked && int.TryParse(texto, out int id))
            {
                dt = dao.PesquisarPorCodigo(id);
            }
            else if (rbtDescricao.Checked)
            {
                dt = dao.PesquisarPorNome(texto);
            }
            else
            {
                return;
            }

            dgvFormaPgto.DataSource = dt;
            Utilitario.AtualizarTotal(lblTotalRegistros, dgvFormaPgto);
        }

        private void FrmManutFormaPgto_Load(object sender, EventArgs e)
        {
            ListarFormaPgto();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ListarFormaPgto();
            timer1.Enabled = false;
        }

        private void dgvFormaPgto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {  
        }
    }
}
