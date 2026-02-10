using GVC.BLL;
using GVC.DAL;
using GVC.Model;
using GVC.UTIL;
using GVC.View;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace GVC
{
    public partial class FrmManutMarca : KryptonForm
    {
        private string StatusOperacao { get; set; }
        public FrmManutMarca(string statusOperacao)
        {
            InitializeComponent();
            this.StatusOperacao = statusOperacao;
        }


        // CONFIGURA GRID
        // ======================================================
        private void ConfigurarGrid()
        {
            dgvMarcas.AutoGenerateColumns = false;
            dgvMarcas.Columns.Clear();

            dgvMarcas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MarcaID",
                HeaderText = "Código",
                Width = 70,
                ReadOnly = true,
                DefaultCellStyle =
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvMarcas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NomeMarca",
                HeaderText = "Marca",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            });

            dgvMarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMarcas.MultiSelect = false;
            dgvMarcas.AllowUserToAddRows = false;
            dgvMarcas.RowHeadersVisible = false;
        }

        // ======================================================
        // CARREGAR MARCAS
        // ======================================================
        private void ListaMarcas(string filtro = "")
        {
            try
            {
                var lista = new MarcaBll().Listar(filtro);
                dgvMarcas.DataSource = lista;
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro("Erro ao carregar marcas: " + ex.Message);
            }
        }

        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
            ListaMarcas();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ListaUsuario();
            timer1.Enabled = false;
        }
        private void CarregaDadosMarcas()
        {
            if (StatusOperacao != "NOVO" && dgvMarcas.CurrentRow == null)
            {
                Utilitario.Mensagens.Aviso("Selecione uma marca primeiro!");
                return;
            }

            try
            {
                // Primeiro obtenha os dados
                MarcaModel marca = null;

                if (StatusOperacao == "ALTERAR" || StatusOperacao == "EXCLUSÃO")
                {
                    marca = dgvMarcas.CurrentRow.DataBoundItem as MarcaModel;
                    if (marca == null) return;
                }

                // Crie o formulário APÓS obter os dados
                FrmCadMarcas cadMarcas = new FrmCadMarcas(StatusOperacao);

                if (StatusOperacao == "NOVO")
                {
                    cadMarcas.ForeColor = Color.FromArgb(8, 142, 254);
                    cadMarcas.ShowDialog();
                }
                else if (StatusOperacao == "ALTERAR")
                {
                    // Passe os dados para o formulário
                    cadMarcas.CarregarDadosParaEdicao(marca.MarcaID, marca.NomeMarca);
                    cadMarcas.btnSalvar.Text = "Alterar";
                    cadMarcas.btnNovo.Enabled = false;
                    cadMarcas.ShowDialog();
                }
                else if (StatusOperacao == "EXCLUSÃO")
                {
                    cadMarcas.CarregarDadosParaEdicao(marca.MarcaID, marca.NomeMarca);
                    cadMarcas.btnSalvar.Text = "Excluir";
                    cadMarcas.btnNovo.Enabled = false;
                    cadMarcas.txtNomeMarca.Enabled = false;
                    cadMarcas.ShowDialog();
                }

                var frmManutMarcas = Application.OpenForms["FrmManutMarcas"] as FrmManutMarca;
                if (frmManutMarcas != null)
                {
                    frmManutMarcas.HabilitarTimer(true);
                }

                ListaMarcas();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso("Erro..." + ex.Message);
            }
        }


        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            ListaMarcas(txtPesquisa.Text.Trim());
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            StatusOperacao = "NOVO";

            using var frm = new FrmCadMarcas(StatusOperacao);
            frm.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow == null)
            {
                Utilitario.Mensagens.Aviso("Selecione um usuário para alterar!");
                return;
            }

            var marca = dgvMarcas.CurrentRow.DataBoundItem as MarcaModel;
            if (marca == null) return;

            StatusOperacao = "ALTERAR";

            // Crie o formulário passando os dados diretamente
            FrmCadMarcas cadMarcas = new FrmCadMarcas(StatusOperacao, marca.MarcaID, marca.NomeMarca);
            cadMarcas.btnSalvar.Text = "Alterar";
            cadMarcas.btnNovo.Enabled = false;
            cadMarcas.ShowDialog();

            // Atualiza a lista após fechar o formulário
            ListaMarcas();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow == null)
            {
                Utilitario.Mensagens.Aviso("Selecione uma marca para excluir!");
                return;
            }

            var marca = dgvMarcas.CurrentRow.DataBoundItem as MarcaModel;
            if (marca == null) return;

            StatusOperacao = "EXCLUSÃO";

            // USE O MESMO CONSTRUTOR DO BOTÃO ALTERAR
            FrmCadMarcas cadMarcas = new FrmCadMarcas(StatusOperacao, marca.MarcaID, marca.NomeMarca);
            cadMarcas.btnSalvar.Text = "Excluir";
            cadMarcas.btnNovo.Enabled = false;
            cadMarcas.txtNomeMarca.Enabled = false; // Desabilita edição no modo exclusão
            cadMarcas.ShowDialog();

            // Atualiza a lista após fechar o formulário
            ListaMarcas();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmManutMarca_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

            ConfigurarGrid();
            ListaMarcas();
        }

        private void FrmManutMarca_Shown(object sender, EventArgs e)
        {
            Utilitario.AplicarCorFocoNosTextBox(this);
        }
    }
}