using Krypton.Toolkit;
using GVC.BLL;
using GVC.DAL;
using System;
using System.Drawing;
using System.Windows.Forms;
using GVC.View;
using GVC.UTIL;

namespace GVC
{
    public partial class FrmManutEstado : KryptonForm
    {
        private string StatusOperacao;
        public FrmManutEstado(string statusOperacao)
        {
            InitializeComponent();
            PersonalizarDataGridView(dgvPesquisar);
            this.StatusOperacao = statusOperacao;
        }
        public void PersonalizarDataGridView(KryptonDataGridView dgv)
        {
            if (dgv.Columns.Count > 0)
            {
                // Colunas com largura fixa
                dgv.Columns["EstadoID"].Width = 60;
                dgv.Columns["Uf"].Width = 50;

                // Coluna Nome ocupa todo o espaço restante
                var colNome = dgv.Columns["Nome"];
                colNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                colNome.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                // Centralizar cabeçalhos
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }

        private void CarregaDados()
        {
            //FrmCadEstado frm = new FrmCadEstado(StatusOperacao);

            try
            {
                if (StatusOperacao == "NOVO")
                {
                    //frm.lblStatus.Text = "NOVO CADASTRO DE ESTADO";
                    //frm.lblStatus.ForeColor = Color.FromArgb(8, 142, 254);
                    //StatusOperacao = "NOVO";
                    //frm.ShowDialog();

                    //var frmManutEstado = Application.OpenForms["FrmManutEstado"] as FrmManutEstado;
                    //if (frmManutEstado != null)
                    //{
                    //    frmManutEstado.HabilitarTimer(true);
                    //}

                }
                if (StatusOperacao == "ALTERAR")
                {
                    //frm.txtEstadoID.Text = dgvPesquisar.CurrentRow.Cells["EstadoID"].Value.ToString();
                    //frm.txtEstadoID.Text = dgvPesquisar.CurrentRow.Cells["EstadoID"].Value.ToString();
                    //frm.txtNomeEstado.Text = dgvPesquisar.CurrentRow.Cells["Nome"].Value.ToString();
                    //frm.txtUf.Text = dgvPesquisar.CurrentRow.Cells["Uf"].Value.ToString();
                    //frm.txtUf.Text = dgvPesquisar.CurrentRow.Cells["Regiao"].Value.ToString();

                    //frm.lblStatus.Text = "ALTERAR REGISTRO";
                    //frm.lblStatus.ForeColor = Color.Orange;
                    //StatusOperacao = "ALTERAR";

                    //frm.btnSalvar.Text = "Alterar";
                    //frm.btnNovo.Enabled = false;
                    //frm.ShowDialog();
                    //var frmManutEstado = Application.OpenForms["FrmManutEstado"] as FrmManutEstado;
                    //if (frmManutEstado != null)
                    //{
                    //    frmManutEstado.HabilitarTimer(true);
                    //}
                }
                if (StatusOperacao == "EXCLUSÃO")
                {
                //    frm.txtEstadoID.Text = dgvPesquisar.CurrentRow.Cells["EstadoID"].Value.ToString();
                //    frm.txtNomeEstado.Text = dgvPesquisar.CurrentRow.Cells["Nome"].Value.ToString();
                //    frm.txtUf.Text = dgvPesquisar.CurrentRow.Cells["Uf"].Value.ToString();

                //    frm.lblStatus.Text = "EXCLUSÃO DE REGISTRO";
                //    frm.lblStatus.ForeColor = Color.Orange;
                //    StatusOperacao = "EXCLUSÃO";

                //    frm.btnSalvar.Text = "Excluir";
                //    frm.btnNovo.Enabled = false;
                //    frm.ShowDialog();

                //    var frmManutEstado = Application.OpenForms["FrmManutEstado"] as FrmManutEstado;
                //    if (frmManutEstado != null)
                //    {
                //        frmManutEstado.HabilitarTimer(true);
                //    }
                }

                Listar();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso("Erro..." + ex.Message);
            }
        }
        private void FrmManutUsuario_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

            Listar();
        }
        public void Listar()
        {
            EstadoBLL estadobll = new EstadoBLL();
            dgvPesquisar.DataSource = estadobll.Listar();
            PersonalizarDataGridView(dgvPesquisar);
            Utilitario.AtualizarTotalKrypton(toolStripStatusLabelTotalRegistros, dgvPesquisar);
        }
        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Listar();
            timer1.Enabled = false;
        }
        private void rbtDescricao_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
            txtPesquisar.Focus();
        }

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
            txtPesquisar.Focus();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string textoPesquisa = txtPesquisar.Text.Trim();

            if (string.IsNullOrEmpty(textoPesquisa))
            {
                dgvPesquisar.DataSource = null; // ou pode chamar um método ListarUsuarios()
                Utilitario.AtualizarTotalKrypton(toolStripStatusLabelTotalRegistros, dgvPesquisar);
                return;
            }

            UsuarioDal dao = new UsuarioDal();
            string nome = "%" + textoPesquisa.ToLower() + "%";
            dgvPesquisar.DataSource = dao.PesquisarPorNome(nome);

            PersonalizarDataGridView(dgvPesquisar);
            Utilitario.AtualizarTotalKrypton(toolStripStatusLabelTotalRegistros, dgvPesquisar);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            StatusOperacao = "ALTERAR";
            CarregaDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            StatusOperacao = "ALTERAR";
            CarregaDados();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            StatusOperacao = "EXCLUSÃO";
            CarregaDados();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
