using GVC.BLL;
using GVC.UTIL;
using Krypton.Toolkit;
using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace GVC.View
{
    public partial class FrmPagamentosParcela : KryptonForm
    {
        private readonly ParcelaBLL _parcelaBll = new ParcelaBLL();
        private readonly PagamentoBLL _pagamentoBll = new PagamentoBLL();
        private readonly ItensVendaBLL _itensVendaBll = new ItensVendaBLL();

        private readonly int _parcelaId;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public long VendaId { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SubTitulo { get; set; }

        public FrmPagamentosParcela(int parcelaId)
        {
            InitializeComponent();

            _parcelaId = parcelaId;
        }
        private void ConfigurarCabecalho()
        {
            panelHeader.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);

            lblTitulo.Text = "ITENS DA VENDA";
            lblTitulo.ForeColor = System.Drawing.Color.White;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.AutoSize = true;

        }
        private void CarregarParcela()
        {
            var parcela = _parcelaBll.ObterDetalheParcela(_parcelaId);

            if (parcela == null)
            {
                Utilitario.Mensagens.Erro("Parcela não encontrada.");
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            lblVendaId.Text = parcela.VendaID.ToString();
            lblNomeCliente.Text = parcela.NomeCliente;
            lblNumeroParcela.Text = parcela.NumeroParcela.ToString();
            lblDataVenda.Text = parcela.DataVenda.ToString("dd/MM/yyyy");
            lblVencimento.Text = parcela.DataVencimento.ToString("dd/MM/yyyy");

            lblValorParcela.Text = parcela.ValorParcela.ToString("C2");
            lblTotalRecebido.Text = parcela.ValorRecebido.ToString("C2");
            lblSaldo.Text = parcela.Saldo.ToString("C2");

            lblStatusParcela.Text = parcela.Status;

            AplicarCorStatus(parcela.Status);
        }

        private void AplicarCorStatus(string? status)
        {
            if (string.IsNullOrWhiteSpace(status))
            {
                lblStatusParcela.ForeColor = Color.Black;
                lblStatusParcela.Text = "—";
                return;
            }

            switch (status.Trim())
            {
                case "Pago":
                    lblStatusParcela.StateCommon.ShortText.Color1 = Color.ForestGreen;
                    break;

                case "ParcialmentePago":
                    lblStatusParcela.StateCommon.ShortText.Color1 = Color.RoyalBlue;
                    break;

                case "Atrasada":
                    lblStatusParcela.StateCommon.ShortText.Color1 = Color.DarkRed;
                    break;

                case "Cancelada":
                    lblStatusParcela.StateCommon.ShortText.Color1 = Color.Gray;
                    break;

                default:
                    lblStatusParcela.StateCommon.ShortText.Color1 = Color.Black;
                    break;
            }
        }

        private void ConfigurarGridPagamentos()
        {
            dgvPagamentos.AutoGenerateColumns = false;
            dgvPagamentos.Columns.Clear();

            dgvPagamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataPagamento",
                HeaderText = "Data",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvPagamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NomeFormaPagamento",
                HeaderText = "Forma",
                Width = 120
            });

            dgvPagamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorPago",
                HeaderText = "Valor Pago",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgvPagamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Observacao",
                HeaderText = "Observação",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPagamentos.ReadOnly = true;
            dgvPagamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPagamentos.MultiSelect = false;
            dgvPagamentos.AllowUserToAddRows = false;

            // 🔹 Configurações visuais do cabeçalho
            dgvPagamentos.ColumnHeadersVisible = true;
            dgvPagamentos.EnableHeadersVisualStyles = false;
            dgvPagamentos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgvPagamentos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPagamentos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            dgvPagamentos.ColumnHeadersHeight = 32;
            dgvPagamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        private void CarregarPagamentos()
        {
            var pagamentos = _pagamentoBll.ListarPagamentosPorParcela(_parcelaId);
            dgvPagamentos.DataSource = pagamentos;
        }       

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ConfigurarGridItensVenda()
        {
            dgvPagamentos.AutoGenerateColumns = false;
            dgvPagamentos.Columns.Clear();

            // 🔹 Coluna ProdutoID (Cód. Prod.) - Centralizada
            var colProdutoID = new DataGridViewTextBoxColumn
            {
                Name = "ProdutoID",
                DataPropertyName = "ProdutoID",
                HeaderText = "Cód. Prod.",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };
            dgvPagamentos.Columns.Add(colProdutoID);

            // 🔹 Coluna NomeProduto
            var colNomeProduto = new DataGridViewTextBoxColumn
            {
                Name = "ProdutoDescricao",
                DataPropertyName = "ProdutoDescricao",
                HeaderText = "Produto",
                Width = 450,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dgvPagamentos.Columns.Add(colNomeProduto);

            // 🔹 Coluna Quantidade - Centralizada
            var colQuantidade = new DataGridViewTextBoxColumn
            {
                Name = "Quantidade",
                DataPropertyName = "Quantidade",
                HeaderText = "Qtd",
                Width = 60,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };
            dgvPagamentos.Columns.Add(colQuantidade);

            // 🔹 Coluna PrecoUnitario (Preço Unitário) - Formato moeda
            var colPrecoUnitario = new DataGridViewTextBoxColumn
            {
                Name = "PrecoUnitario",
                DataPropertyName = "PrecoUnitario",
                HeaderText = "Preço Unitário",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            };
            dgvPagamentos.Columns.Add(colPrecoUnitario);

            // 🔹 Coluna DescontoItem (Desconto) - Formato moeda
            var colDescontoItem = new DataGridViewTextBoxColumn
            {
                Name = "DescontoItem",
                DataPropertyName = "DescontoItem",
                HeaderText = "Desconto",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            };
            dgvPagamentos.Columns.Add(colDescontoItem);

            // 🔹 Coluna Subtotal - Formato moeda
            var colSubtotal = new DataGridViewTextBoxColumn
            {
                Name = "Subtotal",
                DataPropertyName = "Subtotal",
                HeaderText = "Subtotal",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            };
            dgvPagamentos.Columns.Add(colSubtotal);

            // 🔹 Configurações gerais do grid
            dgvPagamentos.AllowUserToAddRows = false;
            dgvPagamentos.AllowUserToDeleteRows = false;
            dgvPagamentos.ReadOnly = true;
            dgvPagamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPagamentos.MultiSelect = false;
            dgvPagamentos.RowHeadersVisible = false;
        }

        private void AplicarFormatacaoItensVenda()
        {
            // Garante que os valores monetários sejam formatados corretamente
            foreach (DataGridViewRow row in dgvPagamentos.Rows)
            {
                // Formata PrecoUnitario
                if (row.Cells["PrecoUnitario"].Value != null &&
                    decimal.TryParse(row.Cells["PrecoUnitario"].Value.ToString(), out decimal preco))
                {
                    row.Cells["PrecoUnitario"].Value = preco;
                }

                // Formata Subtotal
                if (row.Cells["Subtotal"].Value != null &&
                    decimal.TryParse(row.Cells["Subtotal"].Value.ToString(), out decimal subtotal))
                {
                    row.Cells["Subtotal"].Value = subtotal;
                }

                // Formata DescontoItem
                if (row.Cells["DescontoItem"].Value != null &&
                    decimal.TryParse(row.Cells["DescontoItem"].Value.ToString(), out decimal desconto))
                {
                    row.Cells["DescontoItem"].Value = desconto;
                }
            }
        }
        private void CarregarItensVenda()
        {
            if (VendaId <= 0)
                return;

            var itens = _itensVendaBll.ListarItensPorVenda(VendaId);
            dgvPagamentos.DataSource = itens;

            //lblSubTitulo.Text = SubTitulo;
        }

        private void dgvItensVenda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void FrmItensVenda_Load(object sender, EventArgs e)
        {
            CarregarParcela();
            ConfigurarGridPagamentos();
            CarregarPagamentos();            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerarPdfParcela_Click(object sender, EventArgs e)
        {
            var parcela = _parcelaBll.ObterDetalheParcela(_parcelaId);
            var empresa = new EmpresaBll().ObterDadosParaPdf();

            using var sfd = new SaveFileDialog
            {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = $"Parcela_{parcela.ParcelaID}.pdf"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            PDFGenerator.GerarPdfParcela(parcela, empresa, sfd.FileName);
        }

    }
}
