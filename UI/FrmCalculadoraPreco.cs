using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace GVC.UTIL
{
    public partial class FrmCalculadoraPreco : KryptonForm
    {
        private decimal _precoCusto;
        private decimal _precoVendaAtual;
        private string _nomeProduto;
        private TextBox txtPercentualLucro;
        private Label lblResultadoLucro;
        private Label lblResultadoMargem;
        private bool _ignorarEventos = false;

        public FrmCalculadoraPreco(string nomeProduto, decimal precoCusto, decimal precoVendaAtual)
        {
            _nomeProduto = nomeProduto;
            _precoCusto = precoCusto;
            _precoVendaAtual = precoVendaAtual;

            InitializeComponent();

            // Carrega os dados iniciais
            CarregarDadosIniciais();

            // Conecta os eventos
            ConectarEventos();
        }
        private void CarregarDadosIniciais()
        {
            lblProdutoValor.Text = _nomeProduto;
            lblCusto.Text = _precoCusto.ToString("C2");
            lblPrecoVenda.Text = _precoVendaAtual.ToString("C2");

            decimal lucroAtual = _precoVendaAtual - _precoCusto;
            decimal margemAtual = _precoCusto > 0 ? (lucroAtual / _precoCusto) * 100 : 0;

            // Estes labels mostram os valores ATUAIS
            lblLucroAtual.Text = lucroAtual.ToString("C2");
            lblMargemAtual.Text = margemAtual.ToString("N2") + "%";

            // Inicializa os campos da calculadora
            txtLucroDesejado.Text = margemAtual.ToString("N2") + "%";
            txtPrecoVendaCalculado.Text = _precoVendaAtual.ToString("C2");
        }

        private void ConectarEventos()
        {
            // Remove eventos existentes para evitar duplicação
            txtLucroDesejado.TextChanged -= txtLucroDesejado_TextChanged;
            txtPrecoVendaCalculado.TextChanged -= txtPrecoVendaCalculado_TextChanged;
            txtLucroDesejado.Leave -= txtLucroDesejado_Leave;
            txtPrecoVendaCalculado.Leave -= txtPrecoVendaCalculado_Leave;

            // Adiciona os eventos
            txtLucroDesejado.TextChanged += txtLucroDesejado_TextChanged;
            txtPrecoVendaCalculado.TextChanged += txtPrecoVendaCalculado_TextChanged;
            txtLucroDesejado.Leave += txtLucroDesejado_Leave;
            txtPrecoVendaCalculado.Leave += txtPrecoVendaCalculado_Leave;
            // Evento do botão fechar (assumindo que já existe no designer)
            // btnFechar.Click += (s, e) => this.Close();
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

        // Se não tiver esse evento no designer, pode remover ou comentar
        private void FrmCalculadoraPreco_Load(object sender, EventArgs e)
        {
            // Pode deixar vazio ou remover se não for usado
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
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

        private void txtPrecoVendaCalculado_Leave(object sender, EventArgs e)
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

        private void txtPrecoVendaCalculado_TextChanged(object sender, EventArgs e)
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

                if (decimal.TryParse(texto, System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out decimal precoVenda))
                {
                    _ignorarEventos = true;

                    decimal lucro = precoVenda - _precoCusto;
                    decimal percentual = _precoCusto > 0 ? (lucro / _precoCusto) * 100 : 0;

                    txtLucroDesejado.Text = percentual.ToString("N2") + "%";

                    // Usando lblLucroAtual e lblMargemAtual
                    lblLucroCalculado.Text = lucro.ToString("C2");
                    lblMargemCalculada.Text = percentual.ToString("N2") + "%";

                    _ignorarEventos = false;
                }
            }
            catch { }
        }

        private void txtLucroDesejado_Leave(object sender, EventArgs e)
        {
            try
            {
                string texto = txtLucroDesejado.Text.Trim();

                // Verifica se é percentual
                if (texto.Contains("%"))
                {
                    texto = texto.Replace("%", "");
                    if (decimal.TryParse(texto, out decimal valor))
                    {
                        txtLucroDesejado.Text = valor.ToString("N2") + "%";
                    }
                }
                else
                {
                    // É valor monetário
                    texto = texto.Replace("R$", "").Replace("$", "").Trim();
                    if (decimal.TryParse(texto, out decimal valor))
                    {
                        txtLucroDesejado.Text = valor.ToString("C2");
                    }
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resultado = ListarControles(this);
            MessageBox.Show(resultado, "Lista de Controles", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private string ListarControles(Control parent)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            foreach (Control ctrl in parent.Controls)
            {
                sb.AppendLine($"Nome: {ctrl.Name}, Tipo: {ctrl.GetType().Name}");

                // Se o controle tiver filhos, percorre também
                if (ctrl.HasChildren)
                {
                    sb.AppendLine(ListarControles(ctrl));
                }
            }

            return sb.ToString();
        }

        private void txtLucroDesejado_TextChanged(object sender, EventArgs e)
        {
            if (_ignorarEventos) return;

            try
            {
                string texto = txtLucroDesejado.Text.Trim();

                // Verifica se é percentual (contém %)
                if (texto.Contains("%"))
                {
                    texto = texto.Replace("%", "").Replace(",", ".");
                    if (decimal.TryParse(texto, System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out decimal percentual))
                    {
                        _ignorarEventos = true;

                        decimal precoVenda = _precoCusto + (_precoCusto * percentual / 100);
                        txtPrecoVendaCalculado.Text = precoVenda.ToString("C2");

                        decimal lucro = precoVenda - _precoCusto;
                        decimal margem = _precoCusto > 0 ? (lucro / _precoCusto) * 100 : 0;

                        // Usando lblLucroAtual em vez de lblResultadoLucro
                        lblLucroCalculado.Text = lucro.ToString("C2");
                        lblMargemCalculada.Text = margem.ToString("N2") + "%";

                        _ignorarEventos = false;
                    }
                }
                else
                {
                    texto = texto.Replace("R$", "").Replace("$", "").Replace(",", ".").Trim();
                    if (decimal.TryParse(texto, System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out decimal lucroDesejado))
                    {
                        _ignorarEventos = true;

                        decimal precoVenda = _precoCusto + lucroDesejado;
                        txtPrecoVendaCalculado.Text = precoVenda.ToString("C2");

                        decimal percentual = _precoCusto > 0 ? (lucroDesejado / _precoCusto) * 100 : 0;

                        // Usando lblLucroAtual em vez de lblResultadoLucro
                        lblLucroCalculado.Text = lucroDesejado.ToString("C2");
                        lblMargemCalculada.Text = percentual.ToString("N2") + "%";

                        _ignorarEventos = false;
                    }
                }
            }
            catch { }
        }
    }
}