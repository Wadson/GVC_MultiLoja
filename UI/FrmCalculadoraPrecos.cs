using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace GVC.UTIL
{
    public partial class FrmCalculadoraPrecos : KryptonForm
    {
        private decimal _precoCusto;
        private decimal _precoVendaAtual;
        private string _nomeProduto;
        private TextBox txtPercentualLucro;
        private TextBox txtPrecoVendaCalculado;
        private Label lblResultadoLucro;
        private Label lblResultadoMargem;
        private bool _ignorarEventos = false;

        public FrmCalculadoraPrecos(string nomeProduto, decimal precoCusto, decimal precoVendaAtual)
        {
            _nomeProduto = nomeProduto;
            _precoCusto = precoCusto;
            _precoVendaAtual = precoVendaAtual;

            InitializeComponent();
            ConfigurarInterface();
        }

        private void ConfigurarInterface()
        {
            this.Text = "Calculadora de Preço";
            this.Size = new Size(500, 550);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Cálculos atuais
            decimal lucroAtual = _precoVendaAtual - _precoCusto;
            decimal margemAtual = _precoCusto > 0 ? (lucroAtual / _precoCusto) * 100 : 0;

            // Fonte padrão
            Font fontePadrao = new Font("Segoe UI", 11, FontStyle.Regular);
            Font fonteNegrito = new Font("Segoe UI", 11, FontStyle.Bold);
            Font fonteTitulo = new Font("Segoe UI", 12, FontStyle.Bold);
            Font fonteValor = new Font("Segoe UI", 14, FontStyle.Bold);

            // Cores
            Color corCusto = Color.FromArgb(220, 53, 69);      // Vermelho
            Color corVenda = Color.FromArgb(40, 167, 69);     // Verde
            Color corLucro = Color.FromArgb(0, 123, 255);     // Azul

            // ========== PAINEL PRINCIPAL ==========
            TableLayoutPanel mainPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 9,
                Padding = new Padding(20),
                BackColor = Color.White
            };

            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));

            // Linha 0 - Título
            mainPanel.Controls.Add(CriarLabel("PRODUTO:", fonteNegrito, ContentAlignment.MiddleRight), 0, 0);
            mainPanel.Controls.Add(CriarLabel(_nomeProduto, fontePadrao, ContentAlignment.MiddleLeft), 1, 0);

            // Linha 1 - Preço de Custo
            mainPanel.Controls.Add(CriarLabel("PREÇO DE CUSTO:", fonteNegrito, ContentAlignment.MiddleRight), 0, 1);
            var lblCusto = CriarLabel(_precoCusto.ToString("C2"), fonteValor, ContentAlignment.MiddleLeft);
            lblCusto.ForeColor = corCusto;
            mainPanel.Controls.Add(lblCusto, 1, 1);

            // Linha 2 - Preço de Venda Atual
            mainPanel.Controls.Add(CriarLabel("PREÇO DE VENDA ATUAL:", fonteNegrito, ContentAlignment.MiddleRight), 0, 2);
            var lblPrecoVenda = CriarLabel(_precoVendaAtual.ToString("C2"), fonteValor, ContentAlignment.MiddleLeft);
            lblPrecoVenda.ForeColor = corVenda;
            mainPanel.Controls.Add(lblPrecoVenda, 1, 2);

            // Linha 3 - Lucro Atual
            mainPanel.Controls.Add(CriarLabel("LUCRO ATUAL:", fonteNegrito, ContentAlignment.MiddleRight), 0, 3);
            var lblLucroAtual = CriarLabel(lucroAtual.ToString("C2"), fontePadrao, ContentAlignment.MiddleLeft);
            lblLucroAtual.ForeColor = corLucro;
            mainPanel.Controls.Add(lblLucroAtual, 1, 3);

            // Linha 4 - Margem Atual
            mainPanel.Controls.Add(CriarLabel("MARGEM ATUAL:", fonteNegrito, ContentAlignment.MiddleRight), 0, 4);
            mainPanel.Controls.Add(CriarLabel(margemAtual.ToString("N2") + "%", fontePadrao, ContentAlignment.MiddleLeft), 1, 4);

            // ========== LINHA SEPARADORA ==========
            var separador = CriarSeparador();
            mainPanel.Controls.Add(separador, 0, 5);
            mainPanel.SetColumnSpan(separador, 2);

            // ========== CALCULADORA ==========
            // Linha 6 - Título da Calculadora
            mainPanel.Controls.Add(CriarLabel("CALCULAR NOVO PREÇO:", fonteTitulo, ContentAlignment.MiddleLeft), 0, 6);
            mainPanel.SetColumnSpan(mainPanel.GetControlFromPosition(0, 6), 2);

            // Criar painel para a calculadora
            TableLayoutPanel calcPanel = new TableLayoutPanel
            {
                ColumnCount = 2,
                RowCount = 4,
                Dock = DockStyle.Fill,
                Padding = new Padding(10)
            };

            calcPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            calcPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));

            // Linha 0 - Percentual de Lucro
            calcPanel.Controls.Add(CriarLabel("% Lucro Desejado:", fontePadrao, ContentAlignment.MiddleRight), 0, 0);

            txtPercentualLucro = new TextBox
            {
                Dock = DockStyle.Fill,
                Font = fontePadrao,
                Text = margemAtual.ToString("N2")
            };
            txtPercentualLucro.TextChanged += TxtPercentualLucro_TextChanged;
            txtPercentualLucro.Leave += TxtPercentualLucro_Leave;
            txtPercentualLucro.Enter += (s, e) => txtPercentualLucro.SelectAll();
            calcPanel.Controls.Add(txtPercentualLucro, 1, 0);

            // Linha 1 - Preço de Venda Calculado
            calcPanel.Controls.Add(CriarLabel("Preço de Venda:", fontePadrao, ContentAlignment.MiddleRight), 0, 1);

            txtPrecoVendaCalculado = new TextBox
            {
                Dock = DockStyle.Fill,
                Font = fontePadrao,
                Text = _precoVendaAtual.ToString("C2")
            };
            txtPrecoVendaCalculado.TextChanged += TxtPrecoVendaCalculado_TextChanged;
            txtPrecoVendaCalculado.Leave += TxtPrecoVendaCalculado_Leave;
            txtPrecoVendaCalculado.Enter += (s, e) => txtPrecoVendaCalculado.SelectAll();
            calcPanel.Controls.Add(txtPrecoVendaCalculado, 1, 1);

            // Linha 2 - Lucro Calculado
            calcPanel.Controls.Add(CriarLabel("Lucro:", fontePadrao, ContentAlignment.MiddleRight), 0, 2);

            lblResultadoLucro = CriarLabel(lucroAtual.ToString("C2"), fonteNegrito, ContentAlignment.MiddleLeft);
            lblResultadoLucro.ForeColor = corLucro;
            calcPanel.Controls.Add(lblResultadoLucro, 1, 2);

            // Linha 3 - Margem Calculada
            calcPanel.Controls.Add(CriarLabel("Margem:", fontePadrao, ContentAlignment.MiddleRight), 0, 3);

            lblResultadoMargem = CriarLabel(margemAtual.ToString("N2") + "%", fonteNegrito, ContentAlignment.MiddleLeft);
            calcPanel.Controls.Add(lblResultadoMargem, 1, 3);

            // Adicionar painel da calculadora ao painel principal
            mainPanel.Controls.Add(calcPanel, 0, 7);
            mainPanel.SetColumnSpan(calcPanel, 2);

            // Linha 8 - Espaço para os botões
            mainPanel.Controls.Add(new Panel(), 0, 8);
            mainPanel.SetColumnSpan(mainPanel.GetControlFromPosition(0, 8), 2);

            // ========== BOTÕES ==========
            FlowLayoutPanel flowBotoes = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                Height = 60,
                FlowDirection = FlowDirection.RightToLeft,
                Padding = new Padding(10),
                BackColor = Color.FromArgb(240, 240, 240)
            };

            Button btnFechar = new Button
            {
                Text = "Fechar",
                Size = new Size(100, 35),
                Font = fontePadrao,
                BackColor = Color.FromArgb(108, 117, 125),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnFechar.Click += (s, e) => this.Close();

            Button btnAplicar = new Button
            {
                Text = "Aplicar Novo Preço",
                Size = new Size(150, 35),
                Font = fontePadrao,
                BackColor = Color.FromArgb(40, 167, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnAplicar.Click += BtnAplicar_Click;

            flowBotoes.Controls.Add(btnFechar);
            flowBotoes.Controls.Add(btnAplicar);

            // Adicionar controles ao formulário
            this.Controls.Add(mainPanel);
            this.Controls.Add(flowBotoes);
        }

        private Label CriarLabel(string texto, Font fonte, ContentAlignment alinhamento)
        {
            return new Label
            {
                Text = texto,
                Font = fonte,
                TextAlign = alinhamento,
                Dock = DockStyle.Fill,
                AutoSize = false,
                Padding = new Padding(5)
            };
        }

        private Panel CriarSeparador()
        {
            return new Panel
            {
                Height = 2,
                BackColor = Color.FromArgb(200, 200, 200),
                Dock = DockStyle.Fill,
                Margin = new Padding(10, 5, 10, 5)
            };
        }

        private void TxtPercentualLucro_TextChanged(object sender, EventArgs e)
        {
            if (_ignorarEventos) return;

            try
            {
                string texto = txtPercentualLucro.Text.Replace("%", "").Replace(",", ".");
                if (decimal.TryParse(texto, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal percentual))
                {
                    _ignorarEventos = true;

                    // Calcular preço de venda: Custo + (Custo * percentual/100)
                    decimal precoVenda = _precoCusto + (_precoCusto * percentual / 100);
                    txtPrecoVendaCalculado.Text = precoVenda.ToString("C2");

                    decimal lucro = precoVenda - _precoCusto;
                    decimal margem = _precoCusto > 0 ? (lucro / _precoCusto) * 100 : 0;

                    lblResultadoLucro.Text = lucro.ToString("C2");
                    lblResultadoMargem.Text = margem.ToString("N2") + "%";

                    _ignorarEventos = false;
                }
            }
            catch { }
        }

        private void TxtPrecoVendaCalculado_TextChanged(object sender, EventArgs e)
        {
            if (_ignorarEventos) return;

            try
            {
                string texto = txtPrecoVendaCalculado.Text
                    .Replace("R$", "")
                    .Replace("$", "")
                    .Replace(".", "")
                    .Replace(",", ".")
                    .Trim();

                if (decimal.TryParse(texto, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal precoVenda))
                {
                    _ignorarEventos = true;

                    decimal lucro = precoVenda - _precoCusto;
                    decimal percentual = _precoCusto > 0 ? (lucro / _precoCusto) * 100 : 0;

                    txtPercentualLucro.Text = percentual.ToString("N2");
                    lblResultadoLucro.Text = lucro.ToString("C2");
                    lblResultadoMargem.Text = percentual.ToString("N2") + "%";

                    _ignorarEventos = false;
                }
            }
            catch { }
        }

        private void TxtPercentualLucro_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPercentualLucro.Text.Replace("%", ""), out decimal valor))
            {
                txtPercentualLucro.Text = valor.ToString("N2") + "%";
            }
        }

        private void TxtPrecoVendaCalculado_Leave(object sender, EventArgs e)
        {
            try
            {
                string texto = txtPrecoVendaCalculado.Text
                    .Replace("R$", "")
                    .Replace("$", "")
                    .Trim();

                if (decimal.TryParse(texto, out decimal valor))
                {
                    txtPrecoVendaCalculado.Text = valor.ToString("C2");
                }
            }
            catch { }
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txtPrecoVendaCalculado.Text
                    .Replace("R$", "")
                    .Replace("$", "")
                    .Trim();

                if (!decimal.TryParse(texto, out decimal novoPreco))
                {
                    MessageBox.Show("Preço inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show(
                    $"Deseja aplicar o novo preço de venda?\n\n" +
                    $"Produto: {_nomeProduto}\n" +
                    $"Preço de custo: {_precoCusto:C2}\n" +
                    $"Preço atual: {_precoVendaAtual:C2}\n" +
                    $"Novo preço: {novoPreco:C2}\n" +
                    $"Lucro: {lblResultadoLucro.Text}\n" +
                    $"Margem: {lblResultadoMargem.Text}",
                    "Confirmar Alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // Retorna o novo preço como DialogResult
                    this.Tag = novoPreco;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao aplicar novo preço: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCalculadoraPreco_Load(object sender, EventArgs e)
        {

        }
    }
}