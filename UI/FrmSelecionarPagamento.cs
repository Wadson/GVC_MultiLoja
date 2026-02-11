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
            panelRecebimento.Enabled = true; // 🔑 IMPORTANTE
            txtValorRecebido.Enabled = false;
            txtTroco.Enabled = false;

            // PARCELAMENTO
            panelParcelamento.Visible = false;
            panelParcelamento.Enabled = true; // 🔑 IMPORTANTE
            numParcelas.Enabled = false;
            numIntervalo.Enabled = false;
            dtpPrimeiraParcela.Enabled = false;
            btnGerar.Enabled = false;
        }

        private void AtivarRecebimentoDinheiro()
        {
            panelRecebimento.Visible = true;
            panelRecebimento.Enabled = true;

            txtValorRecebido.Enabled = true;
            txtTroco.Enabled = false;

            txtValorRecebido.Text = string.Empty;
            txtTroco.Text = "0,00";

            txtValorRecebido.Focus();
        }

        private void AtivarParcelamento()
        {
            panelParcelamento.Visible = true;
            panelParcelamento.Enabled = true;

            numParcelas.Enabled = true;
            numIntervalo.Enabled = true;
            dtpPrimeiraParcela.Enabled = true;

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
            dgvParcelas.DefaultCellStyle.Font = new Font("Segoe UI", 10f);
            dgvParcelas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
            dgvParcelas.BorderStyle = BorderStyle.None;
            // Geralmente no Load do Form ou no InitializeComponent customizado
            dgvParcelas.DataError += (s, e) =>
            {
                // Ignora o erro de índice fora do intervalo
                e.ThrowException = false;
            };

            dgvParcelas.AutoGenerateColumns = false;
            dgvParcelas.Columns.Clear();

            dgvParcelas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumeroParcela",
                HeaderText = "Parc",
                Width = 130
            });

            dgvParcelas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataVencimento",
                HeaderText = "Vencimento",
                Width = 140,
                DefaultCellStyle = { Format = "dd/MM/yyyy" }
            });

            dgvParcelas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorParcela",
                HeaderText = "Valor",
                Width = 140,
                DefaultCellStyle = { Format = "C2" }
            });
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
         
            ResetarPaines();

            var forma = item.FormaEnum;

            // =========================
            // DINHEIRO (recebimento)
            // =========================
            if (forma == EnumFormaPagamento.Dinheiro)
            {
                AtivarRecebimentoDinheiro();

                _parcelasGeradas = new List<ParcelaModel>
                {
                    new ParcelaModel
                    {
                        NumeroParcela = 1,
                        DataVencimento = DateTime.Now,
                        ValorParcela = _dto.Total,
                        Status = EnumStatusParcela.Pendente
                    }
                };

                CarregarGridParcelas(_parcelasGeradas);
                return;
            }

            // =========================
            // À VISTA (PIX / DÉBITO / TRANSFERÊNCIA)
            // =========================
            if (forma == EnumFormaPagamento.Pix ||
                forma == EnumFormaPagamento.Transferencia ||
                forma == EnumFormaPagamento.CartaoDebito)
            {
                _parcelasGeradas = new List<ParcelaModel>
                {
                    new ParcelaModel
                    {
                        NumeroParcela = 1,
                        DataVencimento = DateTime.Now,
                        ValorParcela = _dto.Total,
                        ValorRecebido = _dto.Total,
                        DataPagamento = DateTime.Now,
                        Status = EnumStatusParcela.Pago
                    }
                };

                CarregarGridParcelas(_parcelasGeradas);
                return;
            }

            // =========================
            // PARCELADO (Crédito / Crediário / Cheque)
            // =========================
            if (forma == EnumFormaPagamento.CartaoCredito ||
                forma == EnumFormaPagamento.Crediario ||
                forma == EnumFormaPagamento.Cheque)
            {
                AtivarParcelamento();

                CarregarGridParcelas(new List<ParcelaModel>
                {
                        new ParcelaModel
                        {
                            NumeroParcela = 1,
                            DataVencimento = DateTime.Now.AddDays(30),
                            ValorParcela = _dto.Total,
                            Status = EnumStatusParcela.Pendente}});
                        }
                }

        

        private void btnGerar_Click(object sender, EventArgs e)
        {
            _parcelasGeradas = _financeiroService.GerarParcelas(
            _dto.Total,
            (int)numParcelas.Value,
            (int)numIntervalo.Value,
            dtpPrimeiraParcela.Value.Date);

            // 🔧 CORREÇÃO AQUI: Força status correto para crediário/cheque
            foreach (var p in _parcelasGeradas)
            {
                p.ValorParcela = Math.Round(p.ValorParcela, 2);

                // Garante que não venha pago por engano
                p.ValorRecebido = 0m;           // ou null, se preferir
                p.Status = EnumStatusParcela.Pendente;
                p.DataPagamento = null;
                p.Juros = 0;
                p.Multa = 0;
            }

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

            // 🔒 Dinheiro exige valor recebido válido
            if (txtValorRecebido.Enabled)
            {
                if (!decimal.TryParse(
                        txtValorRecebido.Text.Replace("R$", "").Trim(),
                        out decimal recebido) ||
                    recebido < _dto.Total)
                {
                    Utilitario.Mensagens.Aviso("Valor recebido insuficiente.");
                    txtValorRecebido.Focus();
                    return;
                }

                var parcela = _parcelasGeradas[0];
                parcela.ValorRecebido = recebido;
                parcela.DataPagamento = DateTime.Now;
                parcela.Status = EnumStatusParcela.Pago;
            }

            // 🔹 Apenas define dados (NÃO salva aqui)
            _dto.Venda.FormaPgtoID = formaItem.FormaPgtoID;

            VendaFinal = _dto.Venda;
            Itens = _dto.Itens;
            Parcelas = _parcelasGeradas;

            // 🔒 Limpa o grid APÓS tudo pronto
            dgvParcelas.DataSource = null;

            DialogResult = DialogResult.OK;
            Close();
        }
        private void txtValorRecebido_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(
        txtValorRecebido.Text.Replace("R$", "").Trim(),
        out decimal recebido))
            {
                txtTroco.Text = "0,00";
                DestacarTroco(0);
                return;
            }

            decimal troco = recebido - _dto.Total;

            if (troco < 0)
                troco = 0;

            txtTroco.Text = troco.ToString("C2");
            DestacarTroco(troco);
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
            if (decimal.TryParse(
        txtValorRecebido.Text.Replace("R$", "").Trim(),
        out decimal valor))
            {
                txtValorRecebido.Text = valor.ToString("0.##");
            }
        }

        private void txtValorRecebido_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtValorRecebido.Text, out decimal valor))
            {
                txtValorRecebido.Text = valor.ToString("C2");
            }
            else
            {
                txtValorRecebido.Text = 0m.ToString("C2");
            }
        }
    }
}
