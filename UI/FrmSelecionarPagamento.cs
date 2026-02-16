using GVC.DTO;
using GVC.DTO;
using GVC.Model;
using GVC.Model.Enums;
using GVC.Model.Enums.GVC.Model.Enums;
using GVC.UTIL;
using Krypton.Toolkit;
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
    public partial class FrmSelecionarPagamento : KryptonForm
    {
        private readonly VendaFinalizacaoDTO _dto;
        private readonly FinanceiroService _financeiroService;
        private BindingList<ParcelaModel> _parcelasBinding;
        private EnumFormaPagamento? _formaSelecionada;
        private bool _isFormatting = false; // Flag para evitar loop de formatação
        // FrmFinalizarVenda
        public List<ParcelaModel> Parcelas { get; private set; }

        private List<ParcelaModel> _parcelasGeradas;
        public VendaModel VendaFinal { get; private set; }
        public List<ItemVendaModel> Itens { get; private set; }

        public FrmSelecionarPagamento(VendaFinalizacaoDTO dto)
        {
            InitializeComponent();
            _dto = dto;
            _financeiroService = new FinanceiroService();

            Itens = dto.Itens;
            VendaFinal = dto.Venda;

            cmbFormaPagamento.SelectedIndexChanged += cmbFormaPagamento_SelectedIndexChanged;

        }
        private void ResetarPaines()
        {
            // RECEBIMENTO
            panelRecebimento.Visible = false;
            panelRecebimento.Enabled = false;
            txtValorRecebido.Enabled = false;
            txtTroco.Enabled = false;
            txtValorRecebido.Text = string.Empty;
            txtTroco.Text = "0,00";

            // PARCELAMENTO
            panelParcelamento.Visible = false;
            panelParcelamento.Enabled = false;
            numParcelas.Enabled = false;
            numIntervalo.Enabled = false;
            dtpPrimeiraParcela.Enabled = false;
            btnGerar.Enabled = false;
        }
        private void AtivarRecebimento(bool permitirTroco)
        {
            ResetarPaines();

            panelRecebimento.Visible = true;
            panelRecebimento.Enabled = true;

            txtValorRecebido.Enabled = true;
            txtTroco.Enabled = permitirTroco;

            txtValorRecebido.Text = string.Empty;
            txtTroco.Text = "0,00";

            txtValorRecebido.Focus();
        }

        private void AtivarParcelamentoModo()
        {
            ResetarPaines();

            panelParcelamento.Visible = true;
            panelParcelamento.Enabled = true;

            numParcelas.Enabled = true;
            numIntervalo.Enabled = true;
            dtpPrimeiraParcela.Enabled = true;

            // se quiser permitir "Gerar" também com 1 parcela, coloque true
            btnGerar.Enabled = numParcelas.Value > 1;
        }
        private void DestacarTroco(decimal troco)
        {
            if (troco > 0)
            {
                txtTroco.StateCommon.Back.Color1 = Color.FromArgb(232, 245, 233); // verde claro
                txtTroco.StateCommon.Content.Color1 = ThemeERP.VerdeAcao;
                txtTroco.StateCommon.Content.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            }
            else
            {
                txtTroco.StateCommon.Back.Color1 = Color.White;
                txtTroco.StateCommon.Content.Color1 = ThemeERP.TextoEscuro;
                txtTroco.StateCommon.Content.Font = new Font("Segoe UI", 10f);
            }
        }
        public void ValidarFormaPagamento(EnumFormaPagamento forma, int qtdParcelas)
        {
            if (forma == EnumFormaPagamento.Pix && qtdParcelas > 1)
                throw new Exception($"{forma.ToDb()} não permite parcelamento.");

            if (forma == EnumFormaPagamento.Dinheiro && qtdParcelas > 1)
                throw new Exception($"{forma.ToDb()} não permite parcelamento.");

            if (forma == EnumFormaPagamento.CartaoCredito && qtdParcelas < 1)
                throw new Exception("Informe o número de parcelas para " + forma.ToDb());

            if (forma == EnumFormaPagamento.Crediario && qtdParcelas < 1)
                throw new Exception("Informe o número de parcelas para " + forma.ToDb());
        }

        private async void DestacarParcelasGeradas()
        {
            dgvParcelas.ClearSelection();

            dgvParcelas.DefaultCellStyle.BackColor =
                Color.FromArgb(232, 245, 233); // verde claro

            await Task.Delay(600);

            dgvParcelas.DefaultCellStyle.BackColor = Color.White;
        }

        private void InicializarControles()
        {
            ResetarPaines();

            numParcelas.Value = 1;
            numIntervalo.Value = 30;
        }


        // Atualiza o estado do botão Confirmar
        private void AtualizarBotaoConfirmar()
        {
            // Habilita somente se houver linhas no DataGridView
            btnConfirmar.Enabled = dgvParcelas.Rows.Count > 0;
        }

        private void AtualizarParcelas()
        {
            int qtd = (int)numParcelas.Value;
            DateTime venc = dtpPrimeiraParcela.Value;

            var parcelas = _financeiroService.GerarParcelas(
                _dto.Total,
                qtd,
                30,
                venc
            );

            // 🔒 GARANTIA: parcelamento nasce pendente
            foreach (var p in parcelas)
            {
                p.Status = EnumStatusParcela.Pendente;
                p.ValorRecebido = null;
                p.DataPagamento = null;
            }

            _parcelasBinding = new BindingList<ParcelaModel>(parcelas);
            dgvParcelas.DataSource = _parcelasBinding;
        }

        private void CarregarGridParcelas(List<ParcelaModel> parcelas)
        {
            dgvParcelas.DataSource = null;
            dgvParcelas.DataSource = parcelas;
            // Atualiza o botão Confirmar
            AtualizarBotaoConfirmar();
        }

        private void ConfigurarGridParcelas()
        {
            dgvParcelas.EnableHeadersVisualStyles = false;
            dgvParcelas.ColumnHeadersDefaultCellStyle.BackColor = ThemeERP.AzulPrimario;
            dgvParcelas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvParcelas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            dgvParcelas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvParcelas.DefaultCellStyle.Font = new Font("Segoe UI", 10f);
            dgvParcelas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
            dgvParcelas.BorderStyle = BorderStyle.None;

            dgvParcelas.DataError += (s, e) => e.ThrowException = false;
            dgvParcelas.AutoGenerateColumns = false;
            dgvParcelas.Columns.Clear();

            // Coluna Parcela (Centralizada)
            DataGridViewTextBoxColumn colParcela = new DataGridViewTextBoxColumn();
            colParcela.DataPropertyName = "NumeroParcela";
            colParcela.HeaderText = "Parc";
            colParcela.Width = 80
                ;
            colParcela.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvParcelas.Columns.Add(colParcela);

            // Coluna Vencimento (Centralizada)
            DataGridViewTextBoxColumn colVencimento = new DataGridViewTextBoxColumn();
            colVencimento.DataPropertyName = "DataVencimento";
            colVencimento.HeaderText = "Vencimento";
            colVencimento.Width = 120;
            colVencimento.DefaultCellStyle.Format = "dd/MM/yyyy";
            colVencimento.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvParcelas.Columns.Add(colVencimento);

            // Coluna Valor (Alinhada à direita)
            DataGridViewTextBoxColumn colValor = new DataGridViewTextBoxColumn();
            colValor.DataPropertyName = "ValorParcela";
            colValor.HeaderText = "Valor";
            colValor.Width = 130;
            colValor.DefaultCellStyle.Format = "C2";
            colValor.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvParcelas.Columns.Add(colValor);
        }

        private void FrmFinalizarVenda_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

            lblVendaNumero.Text =
          _dto.Venda.VendaID > 0
              ? _dto.Venda.VendaID.ToString()
              : "PRÉ-VENDA";

            kryptonPalette1.BasePaletteMode = PaletteMode.Office2010Blue;
            this.BackColor = ThemeERP.CinzaFundo;
            this.Text = _dto.Venda.NomeCliente ?? "CLIENTE NÃO INFORMADO";
            lblTotal.Text = _dto.Total.ToString("C2");

            ConfigurarGridParcelas();

            // 🔹 Carrega combo PRIMEIRO
            Utilitario.CarregarFormasPagamento(cmbFormaPagamento);

            // 🔹 Só depois reseta estado visual
            InicializarControles();

            // 🔹 Agora sim deixa sem seleção
            cmbFormaPagamento.SelectedIndex = -1;

            AtualizarBotaoConfirmar();
        }


















        private void cmbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormaPagamento.SelectedIndex < 0)
                return;

            if (cmbFormaPagamento.SelectedItem is not FormaPagamentoItem item)
                return;

            _formaSelecionada = item.FormaEnum;

            ResetarPaines();
            _parcelasGeradas = null;
            dgvParcelas.DataSource = null;

            var forma = item.FormaEnum;

            // ==========================================================
            // À VISTA (Dinheiro, Pix, Transferência, Débito) => panelRecebimento
            // ==========================================================
            // À VISTA (usa panelRecebimento)
            bool aVista =
                forma == EnumFormaPagamento.Dinheiro ||
                forma == EnumFormaPagamento.Pix ||
                forma == EnumFormaPagamento.Transferencia ||
                forma == EnumFormaPagamento.CartaoDebito;

            if (aVista)
            {
                // Dinheiro: digita recebido e calcula troco
                if (forma == EnumFormaPagamento.Dinheiro)
                {
                    txtValorRecebido.Enabled = true;
                    txtTroco.Enabled = false;
                    txtValorRecebido.Text = "";
                    txtTroco.Text = "0,00";
                    txtValorRecebido.Focus();

                    panelRecebimento.Visible = true;
                    panelRecebimento.Enabled = true;
                    panelRecebimento.BringToFront();   // ✅ ESSENCIAL
                    panelRecebimento.Location = panelParcelamento.Location; // ✅ garante sobreposição correta
                }
                else
                {
                    // Pix/Débito/Transferência: não digita recebido
                    txtValorRecebido.Enabled = false;
                    txtTroco.Enabled = false;
                    txtValorRecebido.Text = _dto.Total.ToString("C2");
                    txtTroco.Text = "0,00";

                    panelParcelamento.Visible = true;
                    panelParcelamento.Enabled = true;
                    panelParcelamento.BringToFront();  // ✅ ESSENCIAL
                    panelParcelamento.Location = panelRecebimento.Location; // ✅ garante sobreposição correta

                }

                // parcela do dia
                var parcela = new ParcelaModel
                {
                    NumeroParcela = 1,
                    DataVencimento = DateTime.Today,
                    ValorParcela = _dto.Total,
                    Status = EnumStatusParcela.Pendente
                };

                // não dinheiro: já quitado
                if (forma != EnumFormaPagamento.Dinheiro)
                {
                    parcela.ValorRecebido = _dto.Total;
                    parcela.DataPagamento = DateTime.Now;
                    parcela.Status = EnumStatusParcela.Pago;
                }

                _parcelasGeradas = new List<ParcelaModel> { parcela };
                CarregarGridParcelas(_parcelasGeradas);
                return;
            }


            // ==========================================================
            // PARCELADO (Boleto, Crédito, Cheque, Crediário) => panelParcelamento
            // ==========================================================
            bool parcelado =
                    forma == EnumFormaPagamento.Boleto ||
                    forma == EnumFormaPagamento.CartaoCredito ||
                    forma == EnumFormaPagamento.Cheque ||
                    forma == EnumFormaPagamento.Crediario;

            if (parcelado)
            {
                AtivarParcelamentoModo();

                _parcelasGeradas = new List<ParcelaModel>
                {
                    new ParcelaModel
                    {
                        NumeroParcela = 1,
                        DataVencimento = DateTime.Today.AddDays(30),
                        ValorParcela = _dto.Total,
                        Status = EnumStatusParcela.Pendente,
                        ValorRecebido = 0m,
                        DataPagamento = null,
                        Juros = 0m,
                        Multa = 0m
                    }
                };

                CarregarGridParcelas(_parcelasGeradas);
                return;
            }

            Utilitario.Mensagens.Aviso("Forma de pagamento não tratada no sistema.");
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            _parcelasGeradas = _financeiroService.GerarParcelas(
            _dto.Total,
            (int)numParcelas.Value,
            (int)numIntervalo.Value,
            dtpPrimeiraParcela.Value.Date);

            // Não precisa mais do Math.Round aqui, pois já vem ajustado do serviço
            CarregarGridParcelas(_parcelasGeradas);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // 🔹 Forma de pagamento (fonte única)
            var formaItem = cmbFormaPagamento.SelectedItem as Model.Enums.FormaPagamentoItem;
            if (formaItem == null || formaItem.FormaPgtoID == 0)
            {
                Utilitario.Mensagens.Aviso("Selecione a forma de pagamento.");
                return;
            }

            if (_parcelasGeradas == null || _parcelasGeradas.Count == 0)
            {
                Utilitario.Mensagens.Aviso("Não há parcelas geradas para confirmar.");
                return;
            }

            // 🔒 Dinheiro exige valor recebido válido (decisão pela forma, não pelo Enabled)
            if (_formaSelecionada == EnumFormaPagamento.Dinheiro)
            {
                string texto = txtValorRecebido.Text.Replace("R$", "").Trim();

                if (!decimal.TryParse(texto, out decimal recebido))
                {
                    Utilitario.Mensagens.Aviso("Informe o valor recebido.");
                    txtValorRecebido.Focus();
                    return;
                }

                if (recebido < _dto.Total)
                {
                    Utilitario.Mensagens.Aviso("Valor recebido insuficiente.");
                    txtValorRecebido.Focus();
                    return;
                }

                var parcela = _parcelasGeradas[0];
                parcela.ValorRecebido = recebido;
                parcela.DataPagamento = DateTime.Now;
                parcela.Status = EnumStatusParcela.Pago;
                parcela.Observacao = txtObservacao.Text;

                // Troco é só visual (não precisa salvar)
            }
            // 🔹 Apenas define dados (NÃO salva aqui)
            _dto.Venda.FormaPgtoID = formaItem.FormaPgtoID;

            string obs = txtObservacao.Text?.Trim();

            if (!string.IsNullOrWhiteSpace(obs) && _parcelasGeradas != null)
            {
                foreach (var p in _parcelasGeradas)
                    p.Observacao = obs;
            }

            VendaFinal = _dto.Venda;
            Itens = _dto.Itens;
            Parcelas = _parcelasGeradas;

            // 🔒 Limpa o grid APÓS tudo pronto
            dgvParcelas.DataSource = null;

            DialogResult = DialogResult.OK;
            Close();
        }
        // Evento KeyPress - Para controlar o que é digitado
        private void txtValorRecebido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números, vírgula e backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Permite apenas uma vírgula
            if (e.KeyChar == ',' && txtValorRecebido.Text.Contains(','))
            {
                e.Handled = true;
            }
        }

        // Evento TextChanged alternativo com formatação em tempo real
        // Evento TextChanged - Seu código original, mas com pequena melhoria
        private void txtValorRecebido_TextChanged(object sender, EventArgs e)
        {
            // Evita processamento durante formatação automática
            if (_isFormatting) return;

            // Se estiver vazio, limpa o troco
            if (string.IsNullOrWhiteSpace(txtValorRecebido.Text))
            {
                txtTroco.Text = "R$ 0,00";
                DestacarTroco(0);
                return;
            }

            // Tenta fazer o parse do valor (removendo formatação se houver)
            string textoLimpo = txtValorRecebido.Text
                .Replace("R$", "")
                .Replace(".", "") // Remove separador de milhar se existir
                .Replace(" ", "")
                .Trim();

            // Substitui vírgula por ponto para parse correto
            textoLimpo = textoLimpo.Replace(",", ".");

            if (!decimal.TryParse(textoLimpo,
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out decimal recebido))
            {
                txtTroco.Text = "R$ 0,00";
                DestacarTroco(0);
                return;
            }

            decimal troco = recebido - _dto.Total;

            if (troco < 0)
                troco = 0;

            txtTroco.Text = troco.ToString("C2");
            DestacarTroco(troco);
        }


        // Método auxiliar para calcular o troco
        private void CalcularTroco()
        {
            if (decimal.TryParse(txtValorRecebido.Text, out decimal recebido))
            {
                decimal troco = recebido - _dto.Total;
                if (troco < 0) troco = 0;

                txtTroco.Text = troco.ToString("C2");
                DestacarTroco(troco);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void numParcelas_ValueChanged(object sender, EventArgs e)
        {
            btnGerar.Enabled =
        panelParcelamento.Enabled &&
        numParcelas.Value > 1;
        }

        private void txtValorRecebido_Enter(object sender, EventArgs e)
        {
            if (!_isFormatting)
            {
                _isFormatting = true;

                // Verifica se o texto está vazio ou é "R$ 0,00" ou "0,00"
                if (string.IsNullOrWhiteSpace(txtValorRecebido.Text) ||
                    txtValorRecebido.Text == "R$ 0,00" ||
                    txtValorRecebido.Text == "0,00")
                {
                    txtValorRecebido.Text = ""; // Deixa vazio
                }
                else
                {
                    // Remove a formatação quando entrar no campo
                    if (decimal.TryParse(txtValorRecebido.Text.Replace("R$", "").Trim(), out decimal valor))
                    {
                        txtValorRecebido.Text = valor.ToString("N2"); // Formato sem símbolo de moeda
                    }
                }

                // Seleciona todo o texto (se houver) ou posiciona o cursor no início
                if (!string.IsNullOrEmpty(txtValorRecebido.Text))
                    txtValorRecebido.SelectAll();
                else
                    txtValorRecebido.SelectionStart = 0;

                _isFormatting = false;
            }
        }

        private void txtValorRecebido_Leave(object sender, EventArgs e)
        {
            if (!_isFormatting)
            {
                _isFormatting = true;

                // Se estiver vazio, mantém vazio (ou coloca R$ 0,00 se preferir)
                if (string.IsNullOrWhiteSpace(txtValorRecebido.Text))
                {
                    txtValorRecebido.Text = ""; // Deixa vazio
                                                // Se quiser mostrar R$ 0,00 quando sair, use a linha abaixo:
                                                // txtValorRecebido.Text = "R$ 0,00";
                }
                else
                {
                    if (decimal.TryParse(txtValorRecebido.Text, out decimal valor))
                    {
                        txtValorRecebido.Text = valor.ToString("C2"); // Formata como moeda ao sair
                    }
                }

                _isFormatting = false;
            }
        }

        private void FrmSelecionarPagamento_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }

        private void FrmSelecionarPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void lblObservacoes_Click(object sender, EventArgs e)
        {

        }
    }
}
