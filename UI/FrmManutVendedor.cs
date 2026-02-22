using GVC.BLL;
using GVC.Helpers;
using GVC.Infra.Repository;
using GVC.UTIL;
using Krypton.Toolkit;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace GVC.View
{
    public partial class FrmManutVendedor : KryptonForm
    {
        private string StatusOperacao;
        private readonly VendedorBLL _bll;       
        private int _totalRegistrosBanco;
        public FrmManutVendedor(string statusOperacao)
        {
            this.StatusOperacao = statusOperacao;
            InitializeComponent();
            _bll = new VendedorBLL();
        }

        public void ListarVendedores()
        {
            dgvVendedores.DataSource = _bll.ListarTodos();
            PersonalizarDataGridView();
            Utilitario.AtualizarTotalToolStatusStrip(lblTotalBanco, dgvVendedores);
        }

        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }

        public void PersonalizarDataGridView()
        {
            dgvVendedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Cabeçalhos bonitos
            if (dgvVendedores.Columns["VendedorID"] != null)
                dgvVendedores.Columns["VendedorID"].HeaderText = "Código";

            if (dgvVendedores.Columns["Nome"] != null)
            {
                dgvVendedores.Columns["Nome"].HeaderText = "Vendedor";
                dgvVendedores.Columns["Nome"].DefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
            }

            if (dgvVendedores.Columns["CPF"] != null)
                dgvVendedores.Columns["CPF"].HeaderText = "CPF";

            if (dgvVendedores.Columns["RG"] != null)
                dgvVendedores.Columns["RG"].HeaderText = "RG";

            if (dgvVendedores.Columns["Telefone"] != null)
                dgvVendedores.Columns["Telefone"].HeaderText = "Telefone";

            if (dgvVendedores.Columns["Email"] != null)
                dgvVendedores.Columns["Email"].HeaderText = "E-mail";

            if (dgvVendedores.Columns["DataNascimento"] != null)
                dgvVendedores.Columns["DataNascimento"].HeaderText = "Dt. Nasc.";

            if (dgvVendedores.Columns["DataContratacao"] != null)
                dgvVendedores.Columns["DataContratacao"].HeaderText = "Dt. Contratação";

            if (dgvVendedores.Columns["Comissao"] != null)
                dgvVendedores.Columns["Comissao"].HeaderText = "Comissão %";

            if (dgvVendedores.Columns["Endereco"] != null)
                dgvVendedores.Columns["Endereco"].HeaderText = "Endereço";

            if (dgvVendedores.Columns["Numero"] != null)
                dgvVendedores.Columns["Numero"].HeaderText = "Numero";

            if (dgvVendedores.Columns["Bairro"] != null)
                dgvVendedores.Columns["Bairro"].HeaderText = "Bairro";

            if (dgvVendedores.Columns["CidadeID"] != null)
                dgvVendedores.Columns["CidadeID"].HeaderText = "CidadeID";

            if (dgvVendedores.Columns["NomeCidade"] != null)
                dgvVendedores.Columns["NomeCidade"].HeaderText = "Cidade";

            if (dgvVendedores.Columns["UF"] != null)
                dgvVendedores.Columns["UF"].HeaderText = "UF";

            if (dgvVendedores.Columns["CEP"] != null)
                dgvVendedores.Columns["CEP"].HeaderText = "CEP";

            if (dgvVendedores.Columns["Observacoes"] != null)
                dgvVendedores.Columns["Observacoes"].HeaderText = "Observações";

            if (dgvVendedores.Columns["Status"] != null)
            {
                dgvVendedores.Columns["Status"].HeaderText = "Status";
                // Formatação do Status será feita no CellFormatting
            }

            // Larguras fixas
            var largurasFixas = new (string nome, int largura)[]
            {
                    ("VendedorID",      70),
                    ("Nome",           250),
                    ("CPF",            120),
                    ("RG",             100),
                    ("Telefone",       130),
                    ("Email",          200),
                    ("DataNascimento", 100),
                    ("DataContratacao",110),
                    ("Comissao",        80),
                    ("Endereco",       250),
                    ("Numero",          60),
                    ("Bairro",         150),
                    ("NomeCidade",         150),
                    ("UF",              50),
                    ("CEP",             90),
                    ("Observacoes",    200),
                    ("Status",          70)
            };

            dgvVendedores.AllowUserToResizeColumns = true;

            foreach (var (nome, largura) in largurasFixas)
            {
                if (dgvVendedores.Columns[nome] != null)
                {
                    dgvVendedores.Columns[nome].Width = largura;

                    // Colunas que podem ser redimensionadas
                    if (nome == "Nome" || nome == "Endereco" || nome == "Observacoes" || nome == "Email")
                        dgvVendedores.Columns[nome].Resizable = DataGridViewTriState.True;
                    else
                        dgvVendedores.Columns[nome].Resizable = DataGridViewTriState.False;
                }
            }

            // Estilo do cabeçalho
            dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVendedores.ColumnHeadersHeight = 25;
            dgvVendedores.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Regular);
            dgvVendedores.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvVendedores.RowHeadersWidth = 28;

            dgvVendedores.PerformLayout();
        }

        private void CarregaDados(FrmCadVendedor frmCadVendedor)
        {
            // Blindagem de estado
            if (string.IsNullOrWhiteSpace(StatusOperacao))
                throw new InvalidOperationException("StatusOperacao não definido.");

            frmCadVendedor.StatusOperacao = StatusOperacao;

            // MODO NOVO
            if (StatusOperacao == "NOVO")
            {
                frmCadVendedor.Text = "Novo Vendedor";
                frmCadVendedor.StateCommon.Header.Content.ShortText.Color1 = Color.Green;
                frmCadVendedor.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                frmCadVendedor.StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI", 8);

                frmCadVendedor.ShowDialog();
                return;
            }

            DataGridViewRow row = dgvVendedores.CurrentRow;

            if (row == null)
            {
                Utilitario.Mensagens.Aviso("Selecione um vendedor na lista!");
                return;
            }

            frmCadVendedor.CarregandoDados = true;
            frmCadVendedor.CarregarCampos(row);
            frmCadVendedor.CarregandoDados = false;

            if (StatusOperacao == "ALTERAR")
            {
                frmCadVendedor.Text = "Alterar Vendedor";
                frmCadVendedor.StateCommon.Header.Content.ShortText.Color1 = Color.Orange;
                frmCadVendedor.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                frmCadVendedor.StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI", 8);
                frmCadVendedor.btnSalvar.Text = "Alterar";
                frmCadVendedor.btnNovo.Enabled = false;
            }
            else if (StatusOperacao == "EXCLUSAO")
            {
                frmCadVendedor.Text = "Excluir Vendedor";
                frmCadVendedor.StateCommon.Header.Content.ShortText.Color1 = Color.Red;
                frmCadVendedor.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                frmCadVendedor.StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI", 8);
                frmCadVendedor.btnSalvar.Text = "Excluir";
                frmCadVendedor.btnNovo.Enabled = false;

                // 🔒 BLOQUEIO ESPECÍFICO DOS TEXTBOX
                foreach (Control ctrl in frmCadVendedor.Controls)
                {
                    BloquearTextBoxRecursivo(ctrl);
                }
            }

            frmCadVendedor.ShowDialog();
        }

        private void BloquearTextBoxRecursivo(Control controle)
        {
            if (controle is TextBox txt)
            {
                txt.ReadOnly = true;
                txt.BackColor = SystemColors.Control;
                return;
            }

            if (controle is Krypton.Toolkit.KryptonTextBox ktxt)
            {
                ktxt.ReadOnly = true;
                ktxt.StateCommon.Back.Color1 = SystemColors.Control;
                return;
            }

            foreach (Control filho in controle.Controls)
            {
                BloquearTextBoxRecursivo(filho);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            StatusOperacao = "NOVO";

            FrmCadVendedor cad = new FrmCadVendedor();
            cad.StatusOperacao = StatusOperacao;
            cad.CarregandoDados = false;
            cad.Text = "Novo Vendedor";
            cad.ForeColor = Color.FromArgb(8, 142, 254);

            cad.ShowDialog();

            // Atualiza a lista após fechar o cadastro
            ListarVendedores();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvVendedores.CurrentRow == null)
            {
                Utilitario.Mensagens.Aviso("Selecione um vendedor na lista!");
                return;
            }

            StatusOperacao = "ALTERAR";

            FrmCadVendedor cadVendedor = new FrmCadVendedor();
            cadVendedor.VendedorID = Convert.ToInt32(
                dgvVendedores.CurrentRow.Cells["VendedorID"].Value);

            cadVendedor.StatusOperacao = StatusOperacao;
            CarregaDados(cadVendedor);

            // Atualiza a lista após fechar o cadastro
            ListarVendedores();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvVendedores.CurrentRow == null)
            {
                Utilitario.Mensagens.Aviso("Selecione um vendedor na lista!");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir este vendedor?",
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (resposta != DialogResult.Yes)
                return;

            StatusOperacao = "EXCLUSAO";

            FrmCadVendedor cadVendedor = new FrmCadVendedor();
            cadVendedor.VendedorID = Convert.ToInt32(
                dgvVendedores.CurrentRow.Cells["VendedorID"].Value);

            cadVendedor.StatusOperacao = StatusOperacao;

            CarregaDados(cadVendedor);

            // Atualiza a lista após fechar o cadastro
            ListarVendedores();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ListarVendedores();
            timer1.Enabled = false;
        }

        private void AtualizarMensagemStatus(string textoPesquisa)
        {
            int totalRegistros = dgvVendedores.Rows.Count;

            if (string.IsNullOrEmpty(textoPesquisa))
            {
                lblStatus.Text = "Exibindo todos os registros";
                lblStatus.ForeColor = Color.Black;
            }
            else if (totalRegistros > 0)
            {
                lblStatus.Text = $"Encontrados {totalRegistros} vendedor(es) com '{textoPesquisa}'";
                lblStatus.ForeColor = Color.Green;
            }
            else
            {
                lblStatus.Text = $"Nenhum vendedor encontrado com '{textoPesquisa}'";
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void LimparPesquisa()
        {
            txtPesquisa.Text = string.Empty;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string texto = txtPesquisa.Text.Trim();

            try
            {
                if (string.IsNullOrWhiteSpace(texto))
                {
                    // ✅ quando limpa, volta a listar tudo
                    ListarVendedores();
                    PersonalizarDataGridView();

                    StatusBarPadrao.AtualizarTotalBanco(lblTotalBanco, _totalRegistrosBanco);
                    StatusBarPadrao.MensagemPesquisa(lblStatus, dgvVendedores, "vendedor", "");
                    return;
                }

                dgvVendedores.DataSource = _bll.PesquisarVendedor(texto);
                PersonalizarDataGridView();

                StatusBarPadrao.AtualizarTotalBanco(lblTotalBanco, _totalRegistrosBanco);
                StatusBarPadrao.MensagemPesquisa(lblStatus, dgvVendedores, "vendedor", texto);
            }
            catch (Exception ex)
            {
                StatusBarPadrao.AtualizarTotalBanco(lblTotalBanco, _totalRegistrosBanco);
                StatusBarPadrao.Mensagem(lblStatus, $"Erro na pesquisa: {ex.Message}", StatusTipo.Erro);
            }
        }

        private void FrmManutVendedor_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

            timer1.Enabled = false;

            ListarVendedores();
            PersonalizarDataGridView();

            dgvVendedores.CellFormatting += dgvVendedores_CellFormatting;
            var bll = new VendedorBLL();

            // Total do banco (uma vez)
            _totalRegistrosBanco = bll.ContarTotal(); // criar se não existir

            // ✅ StatusStrip (2 labels)
            StatusBarPadrao.AtualizarTotalBanco(lblTotalBanco, _totalRegistrosBanco);
            StatusBarPadrao.MensagemPesquisa(lblStatus, dgvVendedores, "vendedor", txtPesquisa.Text);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmManutVendedor_Shown(object sender, EventArgs e)
        {
            Utilitario.AplicarCorFocoNosTextBox(this);
        }

        private void dgvVendedores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) return;

            string columnName = dgvVendedores.Columns[e.ColumnIndex].Name;
            string raw = e.Value.ToString();

            // Função auxiliar: extrai apenas dígitos
            string Digitos(string s) => new string(s.Where(char.IsDigit).ToArray());

            // Formatar CPF
            if (columnName == "CPF")
            {
                string cpf = Digitos(raw);
                if (cpf.Length == 11 && ulong.TryParse(cpf, out ulong n11))
                {
                    e.Value = n11.ToString(@"000\.000\.000\-00");
                    e.FormattingApplied = true;
                    return;
                }
                if (!string.IsNullOrEmpty(cpf))
                {
                    e.Value = cpf;
                    e.FormattingApplied = true;
                    return;
                }
            }

            // Formatar Telefone
            if (columnName == "Telefone")
            {
                string tel = Digitos(raw);
                if (tel.Length == 11 && ulong.TryParse(tel, out ulong t11))
                {
                    string s = t11.ToString("00000000000");
                    e.Value = $"({s.Substring(0, 2)}) {s.Substring(2, 5)}-{s.Substring(7, 4)}";
                    e.FormattingApplied = true;
                    return;
                }
                if (tel.Length == 10 && ulong.TryParse(tel, out ulong t10))
                {
                    string s = t10.ToString("0000000000");
                    e.Value = $"({s.Substring(0, 2)}) {s.Substring(2, 4)}-{s.Substring(6, 4)}";
                    e.FormattingApplied = true;
                    return;
                }
                if (!string.IsNullOrEmpty(tel))
                {
                    e.Value = tel;
                    e.FormattingApplied = true;
                    return;
                }
            }

            // Formatar CEP
            if (columnName == "CEP")
            {
                string cep = Digitos(raw);
                if (cep.Length == 8 && ulong.TryParse(cep, out ulong c))
                {
                    e.Value = c.ToString(@"00000\-000");
                    e.FormattingApplied = true;
                    return;
                }
                if (!string.IsNullOrEmpty(cep))
                {
                    e.Value = cep;
                    e.FormattingApplied = true;
                    return;
                }
            }

            // Formatar Datas
            if ((columnName == "DataNascimento" || columnName == "DataContratacao") && !string.IsNullOrWhiteSpace(raw))
            {
                if (DateTime.TryParse(raw, out DateTime dt))
                {
                    e.Value = dt.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                    return;
                }
            }

            // Formatar Comissão (percentual)
            if (columnName == "Comissao" && !string.IsNullOrWhiteSpace(raw))
            {
                if (e.Value is decimal dec)
                {
                    e.Value = dec.ToString("N2") + "%";
                    e.FormattingApplied = true;
                    return;
                }
                if (decimal.TryParse(raw, out decimal valor))
                {
                    e.Value = valor.ToString("N2") + "%";
                    e.FormattingApplied = true;
                    return;
                }
            }

            // Formatar Status
            if (columnName == "Status" && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int valor))
                {
                    if (valor == 1)
                    {
                        e.Value = "Ativo";
                        e.CellStyle.ForeColor = Color.Green;
                        e.FormattingApplied = true;
                    }
                    else if (valor == 0)
                    {
                        e.Value = "Inativo";
                        e.CellStyle.ForeColor = Color.Red;
                        e.FormattingApplied = true;
                    }
                }
            }
        }
    }
}