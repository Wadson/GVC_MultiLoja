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
    public partial class FrmManutCidade : KryptonForm
    {
        private string StatusOperacao;
        public FrmManutCidade(string statusOperacao)
        {
            InitializeComponent();

            PersonalizarDataGridView(dataGridPesquisar);
            this.StatusOperacao = statusOperacao;
        }

        private void CarregaDados()
        {
            //FrmCadCidade frmcadcidade = new FrmCadCidade(StatusOperacao);

            try
            {
                if (StatusOperacao == "NOVO")
                {
                    //frmcadcidade.Text = "Novo Cadastro de Cidade";
                    //frmcadcidade.ForeColor = Color.FromArgb(8, 142, 254);
                    //StatusOperacao = "NOVO";
                    //frmcadcidade.ShowDialog();

                    var frmManutCidade = Application.OpenForms["FrmManutCidade"] as FrmManutCidade;
                    if (frmManutCidade != null)
                    {
                        frmManutCidade.HabilitarTimer(true);
                    }                    
                }
                if (StatusOperacao == "ALTERAR")
                {
                //    frmcadcidade.txtCidadeID.Text = dataGridPesquisar.CurrentRow.Cells["CidadeID"].Value.ToString();
                //    frmcadcidade.txtNomeCidade.Text = dataGridPesquisar.CurrentRow.Cells["NomeCidade"].Value.ToString();
                //    frmcadcidade.txtEstadoID.Text = dataGridPesquisar.CurrentRow.Cells["CodigoUf"].Value.ToString();

                //    frmcadcidade.Text = "Alterar Cidade";
                //    frmcadcidade.ForeColor = Color.Orange;
                //    StatusOperacao = "ALTERAR";
                //    frmcadcidade.btnSalvar.Text = "Alterar";
                //    frmcadcidade.btnNovo.Enabled = false;
                //    frmcadcidade.ShowDialog();
                    //var frmManutCidade = Application.OpenForms["FrmManutCidade"] as FrmManutCidade;
                    //if (frmManutCidade != null)
                    //{
                    //    frmManutCidade.HabilitarTimer(true);
                    //}
                }
                if (StatusOperacao == "EXCLUSÃO")
                {
                    //frmcadcidade.txtCidadeID.Text = dataGridPesquisar.CurrentRow.Cells["CidadeID"].Value.ToString();
                    //frmcadcidade.txtNomeCidade.Text = dataGridPesquisar.CurrentRow.Cells["NomeCidade"].Value.ToString();
                    //frmcadcidade.txtEstadoID.Text = dataGridPesquisar.CurrentRow.Cells["CodigoUf"].Value.ToString();

                    //frmcadcidade.Text = "Exclusão de Registro";
                    //frmcadcidade.ForeColor = Color.Red;
                    //StatusOperacao = "EXCLUSÃO";

                    //frmcadcidade.btnSalvar.Text = "Excluir";
                    //frmcadcidade.btnNovo.Enabled = false;


                    //frmcadcidade.txtCidadeID.Enabled = false;
                    //frmcadcidade.txtNomeCidade.Enabled = false;
                    //frmcadcidade.txtNomeCidade.Enabled = false;
                    //frmcadcidade.txtEstadoID.Enabled = false;

                    //frmcadcidade.ShowDialog();
                    //var frmManutCidade = Application.OpenForms["FrmManutCidade"] as FrmManutCidade;
                    //if (frmManutCidade != null)
                    //{
                    //    frmManutCidade.HabilitarTimer(true);
                    //}
                }
                Listar();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso("Erro..." + ex.Message);
            }
        }
        public void PersonalizarDataGridView(KryptonDataGridView dgv)
        {
            // Verifica se há colunas no DataGridView antes de tentar personalizá-las
            if (dgv.Columns.Count > 0)
            {
                // Redimensionar as colunas manualmente
                dgv.Columns["CidadeID"].Width = 100;
                dgv.Columns["Nome"].Width = 800;
                dgv.Columns["EstadoID"].Width = 100;

                // Centralizar cabeçalhos das colunas
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    // Centralizar o conteúdo das células nas colunas especificadas
                    if (column.Name == "CidadeID" || column.Name == "EstadoID")
                    {
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    else if (column.Name == "Nome")
                    {
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Alinhar à esquerda
                    }
                }
            }
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void Listar()
        {
            CidadeBLL cidadeBll = new CidadeBLL();
            dataGridPesquisar.DataSource = cidadeBll.Listar();
            PersonalizarDataGridView(dataGridPesquisar);
            Utilitario.AtualizarTotalKrypton(LabelTotalRegistros, dataGridPesquisar);
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

        private void FrmManutCidade_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

            Listar();
        }

        private void btnNov_Click(object sender, EventArgs e)
        {
            //StatusOperacao = "NOVO";
            //CarregaDados();
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            //StatusOperacao = "ALTERAR";
            //CarregaDados();
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            //StatusOperacao = "EXCLUSÃO";
            //CarregaDados();
        }

        private void btnSai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLocaliza_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtLocaliza.Text + "%";
            CidadeDal dao = new CidadeDal();

            dataGridPesquisar.DataSource = dao.PesquisarPorNome(nome);
            Utilitario.AtualizarTotal(lblTotalRegistros, dataGridPesquisar);
        }

        private void rbtCodig_CheckedChanged(object sender, EventArgs e)
        {
            txtLocaliza.Text = "";
            txtLocaliza.Focus();
        }

        private void rbtDescrica_CheckedChanged(object sender, EventArgs e)
        {
            txtLocaliza.Text = "";
            txtLocaliza.Focus();
        }
    }
}
