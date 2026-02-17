using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace GVC.UTIL
{
    public partial class FrmCalculadoraDePreco : KryptonForm
    {
        private decimal _precoCusto;
        private decimal _precoVendaAtual;
        private string _nomeProduto;

        private KryptonTextBox txtPercentualLucro;
        private KryptonTextBox txtPrecoVendaCalculado;
        private Label lblResultadoLucro;
        private Label lblResultadoMargem;

        private bool _ignorarEventos = false;

        public FrmCalculadoraDePreco(string nomeProduto, decimal precoCusto, decimal precoVendaAtual)
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
            this.Size = new Size(520, 580);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Cálculos iniciais
            decimal lucroAtual = _precoVendaAtual - _precoCusto;
            decimal margemAtual = _precoCusto > 0 ? (lucroAtual / _precoCusto) * 100 : 0;

            // Fontes
            Font fontePadrao = new Font("Segoe UI", 11);
            Font fonteNegrito = new Font("Segoe UI", 11, FontStyle.Bold);
            Font fonteTitulo = new Font("Segoe UI", 12, FontStyle.Bold);
            Font fonteValor = new Font("Segoe UI", 14, FontStyle.Bold);

            // =============================================
            //           PAINEL PRINCIPAL
            // =============================================
            var mainPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 10,
                Padding = new Padding(20),
                BackColor = Color.White
            };

            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));

            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 180));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15));

            // Produto
            mainPanel.Controls.Add(CriarLabel("Produto:", fonteNegrito, ContentAlignment.MiddleRight), 0, 0);
            mainPanel.Controls.Add(CriarLabel(_nomeProduto, fontePadrao, ContentAlignment.MiddleLeft), 1, 0);

            // Preço de custo
            mainPanel.Controls.Add(CriarLabel("Preço de custo:", fonteNegrito, ContentAlignment.MiddleRight), 0, 1);
            var lblCusto = CriarLabel(_precoCusto.ToString("C2"), fonteValor, ContentAlignment.MiddleLeft);
            mainPanel.Controls.Add(lblCusto, 1, 1);

            // Preço de venda atual
            mainPanel.Controls.Add(CriarLabel("Preço de venda atual:", fonteNegrito, ContentAlignment.MiddleRight), 0, 2);
            var lblVenda = CriarLabel(_precoVendaAtual.ToString("C2"), fonteValor, ContentAlignment.MiddleLeft);
            mainPanel.Controls.Add(lblVenda, 1, 2);

            // Lucro atual
            mainPanel.Controls.Add(CriarLabel("Lucro atual:", fonteNegrito, ContentAlignment.MiddleRight), 0, 3);
            mainPanel.Controls.Add(CriarLabel(lucroAtual.ToString("C2"), fontePadrao, ContentAlignment.MiddleLeft), 1, 3);

            // Margem atual
            mainPanel.Controls.Add(CriarLabel("Margem atual:", fonteNegrito, ContentAlignment.MiddleRight), 0, 4);
            mainPanel.Controls.Add(CriarLabel(margemAtual.ToString("N2") + "%", fontePadrao, ContentAlignment.MiddleLeft), 1, 4);

            // Separador
            var separador = new Panel
            {
                Height = 2,
                BackColor = Color.LightGray,
                Margin = new Padding(0, 8, 0, 8),
                Dock = DockStyle.Fill
            };
            mainPanel.Controls.Add(separador, 0, 5);
            mainPanel.SetColumnSpan(separador, 2);

            // Título calcular novo preço
            mainPanel.Controls.Add(CriarLabel("CALCULAR NOVO PREÇO", fonteTitulo, ContentAlignment.MiddleLeft), 0, 6);
            mainPanel.SetColumnSpan(mainPanel.GetControlFromPosition(0, 6), 2);

            // =============================================
            //        PAINEL DOS CAMPOS DE CÁLCULO
            // =============================================
            var calcPanel = new TableLayoutPanel
            {
                ColumnCount = 2,
                RowCount = 4,
                Dock = DockStyle.Fill,
                Padding = new Padding(0, 5, 0, 5)
            };

            calcPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            calcPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));

            calcPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45));
            calcPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45));
            calcPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45));
            calcPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45));

            calcPanel.Controls.Add(CriarLabel("% Lucro desejado:", fontePadrao, ContentAlignment.MiddleRight), 0, 0);
            txtPercentualLucro = new KryptonTextBox { Dock = DockStyle.Fill, Text = margemAtual.ToString("N2") };
            txtPercentualLucro.TextChanged += TxtPercentualLucro_TextChanged;
            calcPanel.Controls.Add(txtPercentualLucro, 1, 0);

            calcPanel.Controls.Add(CriarLabel("Preço de venda:", fontePadrao, ContentAlignment.MiddleRight), 0, 1);
            txtPrecoVendaCalculado = new KryptonTextBox { Dock = DockStyle.Fill, Text = _precoVendaAtual.ToString("C2") };
            txtPrecoVendaCalculado.TextChanged += TxtPrecoVendaCalculado_TextChanged;
            calcPanel.Controls.Add(txtPrecoVendaCalculado, 1, 1);

            calcPanel.Controls.Add(CriarLabel("Lucro:", fontePadrao, ContentAlignment.MiddleRight), 0, 2);
            lblResultadoLucro = CriarLabel(lucroAtual.ToString("C2"), fonteNegrito, ContentAlignment.MiddleLeft);
            calcPanel.Controls.Add(lblResultadoLucro, 1, 2);

            calcPanel.Controls.Add(CriarLabel("Margem:", fontePadrao, ContentAlignment.MiddleRight), 0, 3);
            lblResultadoMargem = CriarLabel(margemAtual.ToString("N2") + "%", fonteNegrito, ContentAlignment.MiddleLeft);
            calcPanel.Controls.Add(lblResultadoMargem, 1, 3);

            mainPanel.Controls.Add(calcPanel, 0, 7);
            mainPanel.SetColumnSpan(calcPanel, 2);

            // =============================================
            //           BOTÕES
            // =============================================
            var flowBotoes = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                Height = 65,
                FlowDirection = FlowDirection.RightToLeft,
                Padding = new Padding(15)
            };

            var btnFechar = new KryptonButton { Text = "Fechar", Size = new Size(100, 36) };
            btnFechar.Click += (s, e) => this.Close();

            var btnAplicar = new KryptonButton { Text = "Aplicar Novo Preço", Size = new Size(160, 36) };
            btnAplicar.Click += BtnAplicar_Click;

            flowBotoes.Controls.Add(btnFechar);
            flowBotoes.Controls.Add(btnAplicar);

            this.Controls.Add(flowBotoes);
            this.Controls.Add(mainPanel);

            // Vincula o evento Load
            this.Load += FrmCalculadoraDePreco_Load;
        }

        private void FrmCalculadoraDePreco_Load(object sender, EventArgs e)
        {
            // Aqui você pode colocar inicializações que precisam rodar após o form ser carregado
            // Exemplo comum: colocar foco no campo principal
            if (txtPercentualLucro != null)
            {
                txtPercentualLucro.Focus();
                txtPercentualLucro.SelectAll();
            }
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
                Padding = new Padding(6, 0, 6, 0)
            };
        }

        private void TxtPercentualLucro_TextChanged(object sender, EventArgs e)
        {
            if (_ignorarEventos) return;

            try
            {
                var texto = txtPercentualLucro.Text.Replace("%", "").Replace(",", ".").Trim();
                if (decimal.TryParse(texto, out decimal percentual))
                {
                    _ignorarEventos = true;
                    decimal precoVenda = _precoCusto * (1 + percentual / 100m);
                    txtPrecoVendaCalculado.Text = precoVenda.ToString("C2");

                    decimal lucro = precoVenda - _precoCusto;
                    lblResultadoLucro.Text = lucro.ToString("C2");
                    lblResultadoMargem.Text = percentual.ToString("N2") + "%";

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
                var texto = txtPrecoVendaCalculado.Text
                    .Replace("R$", "").Replace(" ", "")
                    .Replace(".", "").Replace(",", ".").Trim();

                if (decimal.TryParse(texto, out decimal precoVenda))
                {
                    _ignorarEventos = true;

                    decimal lucro = precoVenda - _precoCusto;
                    decimal percentual = _precoCusto > 0 ? (lucro / _precoCusto) * 100m : 0m;

                    txtPercentualLucro.Text = percentual.ToString("N2");
                    lblResultadoLucro.Text = lucro.ToString("C2");
                    lblResultadoMargem.Text = percentual.ToString("N2") + "%";

                    _ignorarEventos = false;
                }
            }
            catch { }
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                var texto = txtPrecoVendaCalculado.Text
                    .Replace("R$", "").Replace(" ", "").Trim();

                if (!decimal.TryParse(texto.Replace(",", "."), out decimal novoPreco))
                {
                    MessageBox.Show("Informe um preço válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var resposta = MessageBox.Show(
                    $"Confirmar aplicação do novo preço?\n\n" +
                    $"Produto:        {_nomeProduto}\n" +
                    $"Custo:          {_precoCusto:C2}\n" +
                    $"Atual:          {_precoVendaAtual:C2}\n" +
                    $"Novo:           {novoPreco:C2}\n" +
                    $"Lucro:          {lblResultadoLucro.Text}\n" +
                    $"Margem:         {lblResultadoMargem.Text}",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    this.Tag = novoPreco;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aplicar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}