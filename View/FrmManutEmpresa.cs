using GVC.BLL;
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
    public partial class FrmManutEmpresa : KryptonForm
    {
        private bool _gridConfigurado = false; //Faz parte da configuração do grid
        private readonly EmpresaBll _empresaBll = new EmpresaBll();
        public FrmManutEmpresa(string statusOperacao)
        {           
            InitializeComponent();
            dgvEmpresa.CellFormatting += dgvEmpresa_CellFormatting;

            // Personalização do título
            this.Text = "Manutenção de Empresas";
            this.StateCommon.Header.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            this.StateCommon.Header.Content.ShortText.Color2 = Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI", 12);
        }
        public void ListarEmpresa()
        {
            EmpresaBll bll = new EmpresaBll();

            dgvEmpresa.SuspendLayout();
            dgvEmpresa.DataSource = bll.Listar();
            dgvEmpresa.ResumeLayout();

            if (!_gridConfigurado)
            {
                PersonalizarDataGridView();
                _gridConfigurado = true;
            }

            Utilitario.AtualizarTotal(lblTotalRegistros, dgvEmpresa);
        }
        private void ConfigurarColunaFill(string coluna, int larguraMinima, int peso)
        {
            var col = dgvEmpresa.Columns[coluna];
            if (col == null) return;

            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col.MinimumWidth = larguraMinima;
            col.FillWeight = peso;
        }

        private void PersonalizarDataGridView()
        {
            // Campos que EXPANDEM
            ConfigurarColunaFill("RazaoSocial", 250, 3);
            ConfigurarColunaFill("NomeFantasia", 220, 2);

            // Cabeçalhos
            dgvEmpresa.Columns["EmpresaID"].HeaderText = "Código";
            dgvEmpresa.Columns["RazaoSocial"].HeaderText = "Razão Social";
            dgvEmpresa.Columns["NomeFantasia"].HeaderText = "Nome Fantasia";
            dgvEmpresa.Columns["Cnpj"].HeaderText = "Cnpj";
            dgvEmpresa.Columns["InscricaoEstadual"].HeaderText = "Inscrição Estadual";
            dgvEmpresa.Columns["InscricaoMunicipal"].HeaderText = "Inscrição Municipal";
            dgvEmpresa.Columns["Cnae"].HeaderText = "Cnae";
            dgvEmpresa.Columns["Logradouro"].HeaderText = "Endereço";
            dgvEmpresa.Columns["Numero"].HeaderText = "Número";
            dgvEmpresa.Columns["Bairro"].HeaderText = "Bairro";
            dgvEmpresa.Columns["Cep"].HeaderText = "CEP";
            dgvEmpresa.Columns["Cidade"].HeaderText = "Cidade";
            dgvEmpresa.Columns["Uf"].HeaderText = "Uf";
            dgvEmpresa.Columns["Telefone"].HeaderText = "Telefone";
            dgvEmpresa.Columns["Email"].HeaderText = "E-mail";
            dgvEmpresa.Columns["Site"].HeaderText = "Site";
            dgvEmpresa.Columns["Responsavel"].HeaderText = "Responsável";
            dgvEmpresa.Columns["CertificadoDigital"].HeaderText = "Certificado Digital";
            dgvEmpresa.Columns["DataCriacao"].HeaderText = "Criação";
            dgvEmpresa.Columns["DataAtualizacao"].HeaderText = "Atualização";
            dgvEmpresa.Columns["UsuarioCriacao"].HeaderText = "Usuário Criação";
            dgvEmpresa.Columns["UsuarioAtualizacao"].HeaderText = "Usuário Atualização";

            // Larguras FIXAS
            dgvEmpresa.Columns["EmpresaID"].Width = 70;
            dgvEmpresa.Columns["Cnpj"].Width = 160;
            dgvEmpresa.Columns["InscricaoEstadual"].Width = 140;
            dgvEmpresa.Columns["InscricaoMunicipal"].Width = 140;
            dgvEmpresa.Columns["Cnae"].Width = 120;
            dgvEmpresa.Columns["Numero"].Width = 80;
            dgvEmpresa.Columns["Cep"].Width = 90;
            dgvEmpresa.Columns["Uf"].Width = 60;
            dgvEmpresa.Columns["Telefone"].Width = 140;
            dgvEmpresa.Columns["Email"].Width = 240;
            dgvEmpresa.Columns["Site"].Width = 200;
            dgvEmpresa.Columns["Responsavel"].Width = 200;
            dgvEmpresa.Columns["CertificadoDigital"].Width = 200;
            dgvEmpresa.Columns["DataCriacao"].Width = 130;
            dgvEmpresa.Columns["DataAtualizacao"].Width = 130;
            dgvEmpresa.Columns["UsuarioCriacao"].Width = 150;
            dgvEmpresa.Columns["UsuarioAtualizacao"].Width = 150;

            // Campos que EXPANDEM
            dgvEmpresa.Columns["RazaoSocial"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEmpresa.Columns["NomeFantasia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEmpresa.Columns["Logradouro"].Width = 250;
            dgvEmpresa.Columns["Bairro"].Width = 180;
            dgvEmpresa.Columns["Cidade"].Width = 200;

            // Estilo
            dgvEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEmpresa.ColumnHeadersHeight = 35;
            dgvEmpresa.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvEmpresa.RowHeadersWidth = 28;
        }
        private void CarregarEmpresas()
        {
            dgvEmpresa.DataSource = _empresaBll.Listar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            
            FrmCadEmpresa cad = new FrmCadEmpresa
            {
                StatusOperacao = "NOVO",
                CarregandoDados = false
            };

            cad.ShowDialog();
            if (cad.HouveAlteracao)
                CarregarEmpresas(); // método que preenche o DataGrid
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvEmpresa.CurrentRow == null)
            {
                Utilitario.Mensagens.Aviso("Selecione uma empresa!");
                return;
            }

            FrmCadEmpresa cad = new FrmCadEmpresa
            {
                StatusOperacao = "ALTERAR",
                EmpresaID = Convert.ToInt32(dgvEmpresa.CurrentRow.Cells["EmpresaID"].Value),
                CarregandoDados = true
            };

            cad.ShowDialog();
            if (cad.HouveAlteracao)
                CarregarEmpresas(); // método que preenche o DataGrid

        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvEmpresa.CurrentRow == null)
            {
                Utilitario.Mensagens.Aviso("Selecione uma empresa!");
                return;
            }

            FrmCadEmpresa cad = new FrmCadEmpresa
            {
                StatusOperacao = "EXCLUSAO",
                EmpresaID = Convert.ToInt32(dgvEmpresa.CurrentRow.Cells["EmpresaID"].Value),
                CarregandoDados = true
            };

            cad.ShowDialog();
            if (cad.HouveAlteracao)
                CarregarEmpresas(); // método que preenche o DataGrid
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

            EmpresaDal dao = new EmpresaDal();
            DataTable dt;

            if (string.IsNullOrEmpty(texto))
            {
                dt = dao.ListarEmpresas();
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

            dgvEmpresa.DataSource = dt;
            Utilitario.AtualizarTotal(lblTotalRegistros, dgvEmpresa);
        }

        private void FrmManutEmpresa_Load(object sender, EventArgs e)
        {
            ListarEmpresa();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ListarEmpresa();
            timer1.Enabled = false;
        }

        private void dgvEmpresa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) return;

            string coluna = dgvEmpresa.Columns[e.ColumnIndex].Name;
            string valor = new string(e.Value.ToString().Where(char.IsDigit).ToArray());

            // Cnpj → 00.000.000/0001-00
            if (coluna == "Cnpj" && valor.Length == 14)
            {
                e.Value = Convert.ToUInt64(valor).ToString(@"00\.000\.000\/0000\-00");
                e.FormattingApplied = true;
            }

            // CEP → 68.000-560
            else if (coluna == "Cep" && valor.Length == 8)
            {
                e.Value = Convert.ToUInt64(valor).ToString(@"00\.000\-000");
                e.FormattingApplied = true;
            }

            // Telefone → (00) 0 0000-0000
            else if (coluna == "Telefone" && valor.Length == 11)
            {
                e.Value = $"({valor.Substring(0, 2)}) {valor.Substring(2, 1)} {valor.Substring(3, 4)}-{valor.Substring(7, 4)}";
                e.FormattingApplied = true;
            }
        }
    }
}
