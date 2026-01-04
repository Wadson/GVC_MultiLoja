using GVC.DTO;
using GVC.DTO;
using GVC.Model;
using GVC.Model.Enums;
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
    public partial class FrmFinalizarVenda : KryptonForm
    {
        private readonly VendaFinalizacaoDTO _dto;
        private readonly FinanceiroService _financeiroService;
        private BindingList<ParcelaModel> _parcelasBinding;

        // FrmFinalizarVenda
        public List<ParcelaModel> Parcelas { get; private set; }

        private List<ParcelaModel> _parcelasGeradas;
        public VendaModel VendaFinal { get; private set; }
        public List<ItemVendaModel> Itens { get; private set; }

        public FrmFinalizarVenda(VendaFinalizacaoDTO dto)
        {
            InitializeComponent();
            _dto = dto;
            _financeiroService = new FinanceiroService();

            Itens = dto.Itens;
            VendaFinal = dto.Venda;

            cmbFormaPagamento.SelectedIndexChanged += cmbFormaPagamento_SelectedIndexChanged;

        }
        public enum EnumFormaPagamento
        {
            Dinheiro,
            Pix,
            Credito,
            Debito
        }
        private void InicializarControles()
        {
            // Bloquear todos os controles de pagamento
            txtValorRecebido.Enabled = false;
            numParcelas.Enabled = false;
            dtpPrimeiraParcela.Enabled = false;
            numIntervalo.Enabled = false;
            btnGerarParcelas.Enabled = false;

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
        public void ValidarFormaPagamento(EnumFormaPagamento forma, int qtdParcelas)
        {
            if (forma == EnumFormaPagamento.Pix && qtdParcelas > 1)
                throw new Exception("PIX não permite parcelamento.");

            if (forma == EnumFormaPagamento.Dinheiro && qtdParcelas > 1)
                throw new Exception("Dinheiro não permite parcelamento.");

            if (forma == EnumFormaPagamento.Credito && qtdParcelas < 1)
                throw new Exception("Informe o número de parcelas.");
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

        private void btnGerarParcelas_Click(object sender, EventArgs e)
        {
            _parcelasGeradas = _financeiroService.GerarParcelas(
         _dto.Total,
         (int)numParcelas.Value,
         (int)numIntervalo.Value,
         dtpPrimeiraParcela.Value.Date);

            CarregarGridParcelas(_parcelasGeradas);

            foreach (var p in _parcelasGeradas)
            {
                p.ValorParcela = Math.Round(p.ValorParcela, 2);

                if (p.ValorRecebido.HasValue)
                {
                    p.ValorRecebido = Math.Round(Math.Min(p.ValorRecebido.Value, p.ValorParcela), 2);
                }
            }
        }

        private void FrmFinalizarVenda_Load(object sender, EventArgs e)
        {

            lblCliente.Text = _dto.Venda.NomeCliente ?? "CLIENTE NÃO INFORMADO";
            lblVendaNumero.Text = _dto.Venda.VendaID > 0 ? $"VENDA Nº {_dto.Venda.VendaID}" : "NOVA VENDA";
            lblTotal.Text = _dto.Total.ToString("C2");

            Utilitario.CarregarFormasPagamento(cmbFormaPagamento);
            ConfigurarGridParcelas();
            // 🔹 Inicializa controles bloqueados
            InicializarControles();
            // Garantir que o botão Confirmar comece desabilitado
            AtualizarBotaoConfirmar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
      
        private void cmbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            var forma = cmbFormaPagamento.SelectedItem as FormaPagamentoItem;
            if (forma == null) return;

            InicializarControles(); // resetar antes

            // Formas de pagamento com parcela automática
            if (forma.NomeFormaPagamento.Equals("Dinheiro", StringComparison.OrdinalIgnoreCase) ||
                forma.NomeFormaPagamento.Equals("PIX", StringComparison.OrdinalIgnoreCase) ||
                forma.NomeFormaPagamento.Equals("Transferência", StringComparison.OrdinalIgnoreCase) ||
                forma.NomeFormaPagamento.Equals("Cartão de Débito", StringComparison.OrdinalIgnoreCase))
            {
                // Cria parcela única com DataPagamento atual
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

                // 🔹 Arredondamento seguro
                foreach (var p in _parcelasGeradas)
                {
                    p.ValorParcela = Math.Round(p.ValorParcela, 2);
                    p.ValorRecebido = Math.Round(Math.Min((decimal)p.ValorRecebido, p.ValorParcela), 2);
                }

                CarregarGridParcelas(_parcelasGeradas);

            }           
            else if (forma.NomeFormaPagamento.Equals("Crediário", StringComparison.OrdinalIgnoreCase))
            {
                txtValorRecebido.Enabled = false; // 🔒
                numParcelas.Enabled = true;
                dtpPrimeiraParcela.Enabled = true;
                numIntervalo.Enabled = true;
                btnGerarParcelas.Enabled = true;

                dgvParcelas.DataSource = null;
            }

        }
    }
}
