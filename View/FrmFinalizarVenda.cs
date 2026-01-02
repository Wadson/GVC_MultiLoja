using GVC.DTO;
using GVC.DTO;
using GVC.MODEL;
using GVC.MODEL.Enums;
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
        }
        public enum EnumFormaPagamento
        {
            Dinheiro,
            Pix,
            Credito,
            Debito
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

            _financeiroService.ProcessarFinanceiroVenda(_dto.Venda, parcelas);

            _parcelasBinding = new BindingList<ParcelaModel>(parcelas);
            dgvParcelas.DataSource = _parcelasBinding;
        }
        private void CarregarGridParcelas(List<ParcelaModel> parcelas)
        {
            dgvParcelas.DataSource = null;
            dgvParcelas.DataSource = parcelas;
        }

        private void ConfigurarGridParcelas()
        {
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

        private void btnConfirmarVenda_Click(object sender, EventArgs e)
        {
            var forma = cmbFormaPagamento.SelectedItem as FormaPagamentoItem;

            if (forma == null || forma.Id == 0)
            {
                Utilitario.Mensagens.Aviso("Selecione a forma de pagamento.");
                return;
            }

            // 🔥 Define forma de pagamento corretamente
            _dto.Venda.FormaPgtoID = forma.Id;

            // 🔒 Se for crediário, exige parcelas
            bool ehCrediario = forma.Descricao.Contains("Crediário");

            if (ehCrediario)
            {
                if (_parcelasGeradas == null || !_parcelasGeradas.Any())
                {
                    Utilitario.Mensagens.Aviso("Gere as parcelas para o crediário.");
                    return;
                }

                _dto.Venda.StatusVenda = EnumStatusVenda.AguardandoPagamento;
            }
            else
            {
                _dto.Venda.StatusVenda = EnumStatusVenda.Concluida;
            }

            // 🔥 Expõe dados para o formulário chamador
            VendaFinal = _dto.Venda;
            Itens = _dto.Itens;
            Parcelas = ehCrediario ? _parcelasGeradas : null;

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

            dgvParcelas.DataSource = null;
            dgvParcelas.DataSource = _parcelasGeradas;
        }

        private void FrmFinalizarVenda_Load(object sender, EventArgs e)
        {
            lblCliente.Text = _dto.Venda.NomeCliente ?? "CLIENTE NÃO INFORMADO";

            lblVendaNumero.Text =
                _dto.Venda.VendaID > 0
                    ? $"VENDA Nº {_dto.Venda.VendaID}"
                    : "NOVA VENDA";

            lblTotal.Text = _dto.Total.ToString("C2");

            Utilitario.CarregarFormasPagamento(cmbFormaPagamento);
            ConfigurarGridParcelas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void numParcelas_ValueChanged(object sender, EventArgs e)
        {
            AtualizarParcelas();
        }

        private void numIntervalo_ValueChanged(object sender, EventArgs e)
        {
            AtualizarParcelas();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
