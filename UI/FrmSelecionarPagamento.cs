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


        private void InicializarControles()
        {
            // Bloquear todos os controles de pagamento
            txtValorRecebido.Enabled = false;
            numParcelas.Enabled = false;
            dtpPrimeiraParcela.Enabled = false;
            numIntervalo.Enabled = false;
            btnGerar.Enabled = false;

            // Apenas forma de pagamento liberada
            cmbFormaPagamento.Enabled = true;

            // Limpar valores
            txtValorRecebido.Text = string.Empty;
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
                Width = 60
            });

            dgvParcelas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataVencimento",
                HeaderText = "Vencimento",
                Width = 110,
                DefaultCellStyle = { Format = "dd/MM/yyyy" }
            });

            dgvParcelas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorParcela",
                HeaderText = "Valor",
                Width = 120,
                DefaultCellStyle = { Format = "C2" }
            });
        }





        private void FrmFinalizarVenda_Load(object sender, EventArgs e)
        {

            this.Text = _dto.Venda.NomeCliente ?? "CLIENTE NÃO INFORMADO";
            lblVendaNumero.Text = _dto.Venda.VendaID > 0 ? $"VENDA Nº {_dto.Venda.VendaID}" : "NOVA VENDA";
            lblTotal.Text = _dto.Total.ToString("C2");

            Utilitario.CarregarFormasPagamento(cmbFormaPagamento);
            ConfigurarGridParcelas();
            // 🔹 Inicializa controles bloqueados
            InicializarControles();
            // Garantir que o botão Confirmar comece desabilitado
            AtualizarBotaoConfirmar();
        }

        private void cmbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            var forma = cmbFormaPagamento.SelectedItem as FormaPagamentoItem;
            if (forma == null) return;

            InicializarControles(); // resetar antes

            // ===============================
            // PAGAMENTO À VISTA
            // ===============================
            var formasAVista = new[]
                            {
                        "Dinheiro",
                        "PIX",
                        "Transferência",
                        "Cartão de Débito",
                        "À Vista" };

            if (formasAVista.Contains(forma.NomeFormaPagamento, StringComparer.OrdinalIgnoreCase))
            {
                _parcelasGeradas = new List<ParcelaModel>
                {
                    new ParcelaModel
                    {
                        NumeroParcela = 1,
                        DataVencimento = DateTime.Now,
                        DataPagamento = DateTime.Now,
                        ValorParcela = _dto.Total,
                        ValorRecebido = _dto.Total,
                        Status = EnumStatusParcela.Pago
                    }
                };

                foreach (var p in _parcelasGeradas)
                {
                    p.ValorParcela = Math.Round(p.ValorParcela, 2);
                    p.ValorRecebido = Math.Round(p.ValorRecebido.Value, 2);
                }

                CarregarGridParcelas(_parcelasGeradas);
                return;
            }

            // ===============================
            // PAGAMENTO NÃO IMEDIATO
            // ===============================
            if (forma.NomeFormaPagamento.Equals("Crediário", StringComparison.OrdinalIgnoreCase) ||
                forma.NomeFormaPagamento.Equals("Cheque", StringComparison.OrdinalIgnoreCase) ||
                forma.NomeFormaPagamento.Equals("Boleto", StringComparison.OrdinalIgnoreCase) ||
                forma.NomeFormaPagamento.Equals("Cartão de Crédito", StringComparison.OrdinalIgnoreCase))
            {
                // 🔒 Controles habilitados
                txtValorRecebido.Enabled = false;
                numParcelas.Enabled = true;
                dtpPrimeiraParcela.Enabled = true;
                numIntervalo.Enabled = true;
                btnGerar.Enabled = true;

                // ✅ PARCELA PADRÃO PENDENTE (garantia)
                _parcelasGeradas = new List<ParcelaModel>
                {
                    new ParcelaModel
                    {
                        NumeroParcela = 1,
                        DataVencimento = DateTime.Now.AddDays(30),
                        ValorParcela = _dto.Total,
                        ValorRecebido = null,
                        DataPagamento = null,
                        Status = EnumStatusParcela.Pendente
                    } };

                CarregarGridParcelas(_parcelasGeradas);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var forma = cmbFormaPagamento.SelectedItem as FormaPagamentoItem;

            if (forma == null || forma.FormaPgtoID == 0)
            {
                Utilitario.Mensagens.Aviso("Selecione a forma de pagamento.");
                return;
            }

            // Apenas define dados, NÃO salva
            _dto.Venda.FormaPgtoID = forma.FormaPgtoID;

            VendaFinal = _dto.Venda;
            Itens = _dto.Itens;
            Parcelas = _parcelasGeradas;

            // 🔴 EVITA IndexOutOfRange no fechamento
            dgvParcelas.DataSource = null;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
