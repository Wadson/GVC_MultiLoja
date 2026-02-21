using Dapper;
using GVC.BLL;
using GVC.DAL;
using GVC.Model;
using GVC.Model.Enums;
using GVC.Model.Extensions;
using GVC.UTIL;
using Krypton.Toolkit;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GVC.Model.Enums.FormaPagamentoExtensions;
using ParcelaExtratoModel = GVC.Model.ParcelaExtrato;
using GVC.Infra.Conexao;

namespace GVC.View
{
    public partial class FrmFinanceiro : KryptonForm
    {
        private bool _formCarregado = false;

        private bool bloqueiaPesquisa = false;
        private readonly PagamentoParcialDal _pagamentoDal = new PagamentoParcialDal();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ClienteID { get; set; }

        private readonly VendaBLL _vendaBll = new VendaBLL();
        private readonly ItensVendaBLL _itensVendaBll = new ItensVendaBLL();
        private long? _parcelaSelecionadaParaRecibo = null;
        private readonly Color _corSelecionado = Color.FromArgb(220, 240, 255);
        private bool _ignorarEventosBusca = false;
        private bool _ignorandoBuscar = false;

        private int _parcelaId; private int _vendaId; private int _clienteId; private string _nomeCliente; private int _numeroParcela; private string _statusParcela;

        public FrmFinanceiro()
        {
            InitializeComponent();
            cmbTipoPesquisa.SelectedIndexChanged += cmbTipoPesquisa_SelectedIndexChanged;

        }
        private void ResetarPanelsFiltro()
        {
            if (pnlPeriodo != null)
            {
                pnlPeriodo.Visible = false;
                pnlPeriodo.Enabled = false;
            }

            if (pnlCliente != null)
            {
                pnlCliente.Visible = false;
                pnlCliente.Enabled = false;
            }

            // ❌ panelStatus REMOVIDO
        }
        private void AtualizarEstadoPesquisa()
        {
            if (!_formCarregado)
                return;

            // 🔒 Esconde tudo
            pnlPeriodo.Visible = false;
            pnlCliente.Visible = false;

            btnFiltrar.Enabled = false;

            var tipo = ObterTipoPesquisaSelecionado();

            switch (tipo)
            {
                case TipoPesquisaContasReceber.PeriodoVenda:
                case TipoPesquisaContasReceber.DataVenda:
                case TipoPesquisaContasReceber.PeriodoVencimento:
                    pnlPeriodo.Visible = true;
                    btnFiltrar.Enabled = dtpInicial.Value.Date <= dtpFinal.Value.Date;
                    break;

                case TipoPesquisaContasReceber.NomeCliente:
                    pnlCliente.Visible = true;
                    btnFiltrar.Enabled = !string.IsNullOrWhiteSpace(txtNomeCliente.Text);
                    break;

                case TipoPesquisaContasReceber.StatusParcela:
                    btnFiltrar.Enabled = true;
                    break;
            }
        }


        private TipoPesquisaContasReceber ObterTipoPesquisaSelecionado()
        {
            if (cmbTipoPesquisa.SelectedValue is TipoPesquisaContasReceber tipo)
                return tipo;

            return TipoPesquisaContasReceber.PeriodoVenda;
        }


        private void TipoPesquisa_CheckedChanged(object sender, EventArgs e)
        {
            if (!_formCarregado)
                return;

            AtualizarEstadoPesquisa();

            BeginInvoke(new Action(() =>
            {
                var tipo = ObterTipoPesquisaSelecionado();

                if (tipo == TipoPesquisaContasReceber.NomeCliente)
                {
                    txtNomeCliente.Focus();
                    txtNomeCliente.SelectAll();
                }
                else if (tipo == TipoPesquisaContasReceber.PeriodoVenda ||
                         tipo == TipoPesquisaContasReceber.PeriodoVencimento)
                {
                    dtpInicial.Focus();
                }
            }));
        }
        private List<EnumStatusParcela> ObterStatusSelecionados()
        {
            var lista = chkStatusParcela.CheckedItems
                .Cast<object>()
                .Select(item => (EnumStatusParcela)Enum.Parse(
                    typeof(EnumStatusParcela),
                    item.ToString()!))
                .ToList();

            // Nenhum marcado = TODOS
            if (!lista.Any())
            {
                lista.AddRange(Enum.GetValues(typeof(EnumStatusParcela))
                    .Cast<EnumStatusParcela>());
            }

            return lista;
        }

        private void ConfigurarGridContasAReceber()
        {
            dgvContasAReceber.AutoGenerateColumns = false;
            dgvContasAReceber.Columns.Clear();

            var chk = new DataGridViewCheckBoxColumn
            {
                Name = "Selecionar",
                HeaderText = "",
                Width = 30,
            };
            dgvContasAReceber.Columns.Add(chk);

            var colParcelaID = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ParcelaID",
                HeaderText = "ID",
                Width = 60,
                Visible = false
            };
            dgvContasAReceber.Columns.Add(colParcelaID);

            var colVendaID = new DataGridViewTextBoxColumn
            {
                Name = "VendaID",
                DataPropertyName = "VendaID",
                HeaderText = "IDVenda",
                Width = 60,
                Visible = false
            };
            dgvContasAReceber.Columns.Add(colVendaID);

            var colParcela = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumeroParcela",
                HeaderText = "Nº Parc.",
                Width = 60,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };
            dgvContasAReceber.Columns.Add(colParcela);

            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NomeCliente",
                HeaderText = "Cliente",
                Width = 200,
                ValueType = typeof(string)
            });

            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataVenda",
                HeaderText = "Data Venda",
                Width = 100,
                ValueType = typeof(DateTime),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataVencimento",
                HeaderText = "Vencimento",
                Width = 100,
                ValueType = typeof(DateTime),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorParcela",
                HeaderText = "Valor Parcela",
                Width = 100,
                ValueType = typeof(decimal),
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorRecebido",
                HeaderText = "Recebido",
                Width = 100,
                ValueType = typeof(decimal),
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            // Coluna SALDO - será destacada
            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Saldo",
                HeaderText = "Saldo",
                Width = 100,
                ValueType = typeof(decimal),
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StatusParcela",
                HeaderText = "Status",
                Width = 90,
                ValueType = typeof(string)
            });

            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NomeFormaPagamento",
                HeaderText = "Forma Pgto",
                Width = 120,
                ValueType = typeof(string)
            });

            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Observacoes",
                HeaderText = "Observações da Venda",
                Width = 500,
                ValueType = typeof(string),
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    WrapMode = DataGridViewTriState.False,
                    Alignment = DataGridViewContentAlignment.MiddleLeft
                }
            });

            // Estilo geral
            dgvContasAReceber.AllowUserToAddRows = false;
            dgvContasAReceber.AllowUserToDeleteRows = false;
            dgvContasAReceber.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContasAReceber.MultiSelect = false;
            dgvContasAReceber.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvContasAReceber.ReadOnly = false; // libera edição no grid inteiro

            foreach (DataGridViewColumn col in dgvContasAReceber.Columns)
            {
                if (col.Name != "Selecionar")
                    col.ReadOnly = true;
            }

            // Configurações visuais
            dgvContasAReceber.EnableHeadersVisualStyles = false;
            dgvContasAReceber.ColumnHeadersDefaultCellStyle.BackColor = ThemeERP.AzulPrimario;
            dgvContasAReceber.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvContasAReceber.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            dgvContasAReceber.DefaultCellStyle.Font = new Font("Segoe UI", 10f);
            dgvContasAReceber.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
            dgvContasAReceber.BorderStyle = BorderStyle.None;

            // ========== DESTAQUE DA COLUNA SALDO ==========

            // Destacar cabeçalho da coluna Saldo
            if (dgvContasAReceber.Columns["Saldo"] != null)
            {
                var colunaSaldo = dgvContasAReceber.Columns["Saldo"];

                // Personalizar cabeçalho
                colunaSaldo.HeaderCell.Style.BackColor = Color.FromArgb(255, 193, 7); // Amarelo ouro
                colunaSaldo.HeaderCell.Style.ForeColor = Color.Black;
                colunaSaldo.HeaderCell.Style.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
                colunaSaldo.HeaderText = "💰 SALDO A PAGAR";
            }


        }

        // Classe estática com cores padrão de mercado (adicione fora da sua classe, 
        // em um arquivo separado ou no final do arquivo)
        public static class CoresMercado
        {
            public static Color SaldoDevedor => Color.FromArgb(198, 40, 40); // Vermelho vibrante
            public static Color SaldoDevedorFundo => Color.FromArgb(255, 235, 238); // Rosa muito claro

            public static Color SaldoCredor => Color.FromArgb(46, 125, 50); // Verde
            public static Color SaldoCredorFundo => Color.FromArgb(232, 245, 233); // Verde claro

            public static Color SaldoZero => Color.FromArgb(97, 97, 97); // Cinza
        }

        private List<ContaAReceberDTO> ObterParcelasSelecionadas()
        {
            var lista = new List<ContaAReceberDTO>();
            foreach (DataGridViewRow row in dgvContasAReceber.Rows)
            {
                if (row.Cells["Selecionar"].Value is bool marcado && marcado)
                {
                    if (row.DataBoundItem is ContaAReceberDTO dto)
                    {
                        lista.Add(dto);
                    }
                }
            }
            return lista;
        }
        private void CarregarContasAReceber()
        {
            var dal = new ContasAReceberDAL();

            // 🔑 1️⃣ Tipo de pesquisa
            var tipoPesquisa = ObterTipoPesquisaSelecionado();

            // 🔑 2️⃣ Status selecionados (CheckedListBox → Enum)
            var statusSelecionados = ObterStatusSelecionados();

            // 🔑 3️⃣ Filtros opcionais
            string nomeCliente = txtNomeCliente.Enabled
                ? txtNomeCliente.Text.Trim()
                : null;

            DateTime? dataInicial = null;
            DateTime? dataFinal = null;

            if (dtpInicial.Enabled)
                dataInicial = dtpInicial.Value.Date;

            if (dtpFinal.Enabled)
                dataFinal = dtpFinal.Value.Date;

            AtualizarParcelasAtrasadasNoBanco();
            // 🔑 4️⃣ Chamada ao DAL
            var lista = dal.ListarContasAReceber(
                tipoPesquisa,
                nomeCliente,
                dataInicial,
                dataFinal,
                statusSelecionados
            );

            // 🔑 5️⃣ Bind no grid
            ConfigurarGridContasAReceber();
            dgvContasAReceber.DataSource = lista;

            // 🔑 6️⃣ Atualizações auxiliares
            AtualizarResumo(lista);
            AtualizarResumoGeral(lista);
            AtualizarTotalSelecionado();
        }

        private void AtualizarResumo(IEnumerable<ContaAReceberDTO> dados)
        {
            decimal totalVencido = 0m;

            foreach (var p in dados)
            {
                var status = p.StatusParcela.ToEnumStatusParcela();

                if (status == EnumStatusParcela.Atrasada)
                    totalVencido += p.Saldo;
            }

            lblTotalVencido.Text = totalVencido.ToString("C2");
        }

        private void FrmContasAReceber_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

            cmbTipoPesquisa.DisplayMember = "Texto";
            cmbTipoPesquisa.ValueMember = "Valor";

            cmbTipoPesquisa.DataSource = new List<TipoPesquisaItem>
            {
                new() { Valor = TipoPesquisaContasReceber.PeriodoVenda, Texto = "Período da Venda" },
                new() { Valor = TipoPesquisaContasReceber.DataVenda, Texto = "Data da Venda" },
                new() { Valor = TipoPesquisaContasReceber.PeriodoVencimento, Texto = "Período de Vencimento" },
                new() { Valor = TipoPesquisaContasReceber.NomeCliente, Texto = "Nome do Cliente" },
                new() { Valor = TipoPesquisaContasReceber.StatusParcela, Texto = "Status da Parcela" }
            };

            ConfigurarGridContasAReceber();
            AtualizarParcelasAtrasadasNoBanco();

            _formCarregado = true;

            cmbTipoPesquisa.SelectedValue = TipoPesquisaContasReceber.PeriodoVenda;
            AtualizarEstadoPesquisa();
        }
        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {
            AtualizarEstadoPesquisa();
            if (_ignorarEventosBusca || _ignorandoBuscar)
                return;

            var texto = txtNomeCliente.Text.Trim();
            if (string.IsNullOrEmpty(texto))
                return;

            using (var pesquisaCliente = new FrmLocalizarCliente(this, texto))
            {
                // Calcula posição logo abaixo do TextBox
                var textBoxLocation = txtNomeCliente.PointToScreen(Point.Empty);

                pesquisaCliente.StartPosition = FormStartPosition.Manual;
                pesquisaCliente.Location = new Point(
                    textBoxLocation.X,
                    textBoxLocation.Y + txtNomeCliente.Height
                );

                // 🔑 Ajusta largura do formulário para acompanhar o TextBox
                pesquisaCliente.Width = txtNomeCliente.Width;

                if (pesquisaCliente.ShowDialog() == DialogResult.OK)
                {
                    _ignorandoBuscar = true;
                    try
                    {
                        ClienteID = pesquisaCliente.ClienteID;
                        txtNomeCliente.Text = pesquisaCliente.ClienteSelecionado;
                    }
                    finally
                    {
                        _ignorandoBuscar = false;
                    }
                }
            }
        }

        private void dgvContasAReceber_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvContasAReceber.Columns[e.ColumnIndex].Name == "Selecionar")
            {
                AtualizarTotalSelecionado();
                AtualizarEstadoBotoesFinanceiros();
            }

            // Proteger índices inválidos
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var coluna = dgvContasAReceber.Columns[e.ColumnIndex].DataPropertyName;

            // 1) Datas: formatar dd/MM/yyyy
            if ((coluna == "DataVenda" || coluna == "DataVencimento") && e.Value != null)
            {
                if (e.Value is DateTime dt)
                {
                    e.Value = dt.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
                else if (DateTime.TryParse(e.Value.ToString(), out var parsed))
                {
                    e.Value = parsed.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }

            // 2) Colunas monetárias: formatar como moeda
            else if (coluna == "ValorParcela" ||
                     coluna == "ValorRecebido" ||
                     coluna == "Saldo" ||
                     coluna == "Juros" ||
                     coluna == "Multa")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), NumberStyles.Any, CultureInfo.CurrentCulture, out decimal valor))
                {
                    e.Value = valor.ToString("C2");
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    e.CellStyle.Font = new Font(dgvContasAReceber.Font, FontStyle.Regular);
                    e.FormattingApplied = true;

                    // ========== DESTAQUE ESPECIAL PARA COLUNA SALDO ==========
                    if (coluna == "Saldo")
                    {
                        // Aplica cores conforme o valor usando CoresMercado
                        if (valor > 0)
                        {
                            e.CellStyle.ForeColor = CoresMercado.SaldoDevedor;
                            e.CellStyle.Font = new Font(dgvContasAReceber.Font, FontStyle.Bold);
                            e.CellStyle.BackColor = CoresMercado.SaldoDevedorFundo;

                            // ToolTip via CellToolTipTextNeeded (precisa de evento separado)
                        }
                        else if (valor < 0)
                        {
                            e.CellStyle.ForeColor = CoresMercado.SaldoCredor;
                            e.CellStyle.Font = new Font(dgvContasAReceber.Font, FontStyle.Bold);
                            e.CellStyle.BackColor = CoresMercado.SaldoCredorFundo;
                        }
                        else // valor == 0
                        {
                            e.CellStyle.ForeColor = CoresMercado.SaldoZero;
                            e.CellStyle.Font = new Font(dgvContasAReceber.Font, FontStyle.Regular);
                            e.CellStyle.BackColor = Color.White;
                        }
                    }
                }
            }

            // 3) Status da Parcela: cores
            else if (coluna == "StatusParcela" && e.Value != null)
            {
                var status = e.Value.ToString().Trim();

                switch (status.ToUpperInvariant())
                {
                    case "PAGA":
                        e.CellStyle.ForeColor = Color.ForestGreen;
                        e.CellStyle.Font = new Font(dgvContasAReceber.Font, FontStyle.Bold);
                        break;

                    case "ATRASADA":
                        e.CellStyle.ForeColor = Color.DarkOrange;
                        e.CellStyle.Font = new Font(dgvContasAReceber.Font, FontStyle.Bold);
                        break;

                    case "PARCIALMENTE PAGA":
                        e.CellStyle.ForeColor = Color.Blue;
                        e.CellStyle.Font = new Font(dgvContasAReceber.Font, FontStyle.Italic);
                        break;

                    case "PENDENTE":
                        e.CellStyle.ForeColor = Color.Black;
                        break;

                    case "CANCELADA":
                        e.CellStyle.ForeColor = Color.DarkRed;
                        e.CellStyle.Font = new Font(dgvContasAReceber.Font, FontStyle.Strikeout);
                        break;

                    default:
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                }
            }
        }

        private void AtualizarTotalSelecionado()
        {
            var selecionadas = ObterParcelasSelecionadas();

            decimal totalSaldo = selecionadas.Sum(p => p.Saldo);

            lblTotalSelecionado.Text = totalSaldo.ToString("C2");
        }
        private decimal CalcularTotalRecebidoSelecionado()
        {
            return ObterParcelasSelecionadas()
                .Where(p => p.StatusParcela.ToEnumStatusParcela() == EnumStatusParcela.Pago)
                .Sum(p => p.ValorRecebido);
        }

        private void dgvContasAReceber_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvContasAReceber.IsCurrentCellDirty)
            {
                dgvContasAReceber.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvContasAReceber_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvContasAReceber.Columns[e.ColumnIndex].Name == "Selecionar")
            {
                AtualizarTotalSelecionado();
                AtualizarEstadoBotoesFinanceiros(); // 🔥 AQUI É IMEDIATO
            }
        }
        private void AtualizarResumoGeral(IEnumerable<ContaAReceberDTO> dados)
        {
            decimal totalAReceber = 0m;
            decimal totalRecebido = 0m;

            foreach (var p in dados)
            {
                if (ParcelaContabilHelper.EntraEmAberto(p.StatusParcela))
                    totalAReceber += p.Saldo;

                if (ParcelaContabilHelper.EntraComoRecebido(p.StatusParcela))
                    totalRecebido += p.ValorRecebido;
            }

            lblTotalContasReceber.Text = totalAReceber.ToString("C2");
            lblTotalContasReceber.ForeColor =
                totalAReceber > 0m ? Color.Red : Color.Gray;

            // 👉 Se quiser exibir recebido futuramente, já está pronto
            // lblTotalRecebido.Text = totalRecebido.ToString("C2");
        }


        private void AtualizarParcelasAtrasadasNoBanco()
        {
            try
            {
                var bll = new ParcelaBLL();
                int qtd = bll.AtualizarParcelasAtrasadas();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erro ao atualizar parcelas atrasadas: " + ex.Message);
            }
        }


        private void CarregarVenda(int vendaId)
        {
            var venda = _vendaBll.ObterVendaPorId(vendaId);

            if (venda == null)
            {
                LimparAreaVenda();
                return;
            }

            if (venda.Cliente == null && venda.ClienteID > 0)
            {
                venda.Cliente = _vendaBll.BuscarClienteVenda(venda.ClienteID);
            }

            // continua preenchendo tela normalmente
        }

        private void BuscarNomeCliente(long clienteId)
        {
            string query = "SELECT Nome FROM Clientes WHERE ClienteID = @parametro";
        }
        private void dgvContasAReceber_SelectionChanged(object sender, EventArgs e)
        {

            AtualizarEstadoBotoesFinanceiros(); // 🔥 AQUI           

            if (dgvContasAReceber.CurrentRow?.DataBoundItem is not ContaAReceberDTO parcela)
                return;

        }
        private void LimparAreaVenda()
        {
            // Contas a receber
            if (dgvContasAReceber.DataSource != null)
            {
                dgvContasAReceber.DataSource = null;
            }
            else
            {
                dgvContasAReceber.Rows.Clear();
                dgvContasAReceber.Columns.Clear();
            }
        }

        private bool VerificarCheckboxesMarcados()
        {
            foreach (DataGridViewRow row in dgvContasAReceber.Rows)
            {
                var cell = row.Cells["Selecionar"];
                if (cell != null && cell.Value != null)
                {
                    if (cell.Value is bool boolValue && boolValue)
                        return true;

                    if (cell.Value.ToString() == "True")
                        return true;
                }
            }
            return false;
        }

        private ExtratoCliente ObterExtratoCliente(bool detalhado)
        {
            if (dgvContasAReceber.CurrentRow?.DataBoundItem is not ContaAReceberDTO dto)
                return null;

            var bll = new ExtratoBLL();

            return bll.ObterExtratoClientePorVenda(dto.VendaID, detalhado);
        }


        private void GerarExtratoCompleto(bool detalhado)
        {
            try
            {
                if (dgvContasAReceber.CurrentRow == null)
                {
                    Utilitario.Mensagens.Aviso("Selecione uma linha para gerar o extrato do cliente.");
                    return;
                }

                var extrato = ObterExtratoCliente(true);

                if (extrato == null)
                {
                    Utilitario.Mensagens.Erro("Não foi possível obter dados do cliente.");
                    return;
                }

                if (extrato.ItensExtrato.Count == 0)
                {
                    Utilitario.Mensagens.Info("Não há parcelas para este cliente.");
                    return;
                }

                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "PDF Files|*.pdf";
                    saveDialog.Title = "Salvar Extrato";

                    // Limpa caracteres inválidos do nome do arquivo
                    string nomeClienteLimpo = RemoveCaracteresInvalidos(extrato.NomeCliente);
                    saveDialog.FileName = $"Extrato_{nomeClienteLimpo}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        // 🔹 Buscar dados da empresa para PDF
                        var empresaBLL = new EmpresaBll();
                        var empresa = empresaBLL.ObterDadosParaPdf();

                        // 🔹 Gerar o PDF
                        UTIL.PDFGenerator.GerarExtratoPDF(
                            extrato,
                            empresa,
                            saveDialog.FileName
                        );


                        // Mensagem de sucesso
                        DialogResult resultado = MessageBox.Show(
                            $"Extrato gerado com sucesso!\n\n" +
                            $"Arquivo: {Path.GetFileName(saveDialog.FileName)}\n" +
                            $"Pasta: {Path.GetDirectoryName(saveDialog.FileName)}\n\n" +
                            $"Deseja abrir o arquivo agora?",
                            "Sucesso",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);

                        if (resultado == DialogResult.Yes)
                        {
                            // Tenta abrir o PDF
                            if (AbrirPDF(saveDialog.FileName))
                            {
                                // Sucesso ao abrir
                            }
                            else
                            {
                                // Se não conseguiu abrir, mostra a pasta
                                AbrirPastaContendoArquivo(saveDialog.FileName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro($"Erro ao gerar extrato: {ex.Message}");
            }
        }
        private void GerarExtratoDetalhadoHierarquico()
        {
            int clienteId = ObterClienteSelecionadoId(); // o mesmo que você já usa

            var extratoBLL = new ExtratoBLL();
            var parcelas = extratoBLL.ObterExtratoDetalhado(clienteId);

            if (parcelas == null || parcelas.Count == 0)
            {
                Utilitario.Mensagens.Info("Não há dados para este cliente.");
                return;
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PDF Files|*.pdf";
                saveDialog.Title = "Salvar Extrato Detalhado";

                saveDialog.FileName =
                    $"ExtratoDetalhado_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    var empresaBLL = new EmpresaBll();
                    var empresa = empresaBLL.ObterDadosParaPdf();

                    var extratoCliente = ObterExtratoCliente(false);

                    ExtratoDetalhadoHierarquicoPdf.Gerar(
                        extratoCliente,
                        parcelas,
                        empresa,
                        saveDialog.FileName
                    );

                }
            }
        }
        private int ObterClienteSelecionadoId()
        {
            if (dgvContasAReceber.CurrentRow == null)
                throw new Exception("Nenhuma linha selecionada.");

            if (dgvContasAReceber.CurrentRow.DataBoundItem is not ContaAReceberDTO dto)
                throw new Exception("Linha inválida.");

            int vendaId = dto.VendaID;

            using var conn = Conexao.Conex();

            int? clienteId = conn.ExecuteScalar<int?>(@"
        SELECT ClienteID      FROM Venda
        WHERE VendaID = @VendaID",
                new { VendaID = vendaId });

            if (clienteId == null)
                throw new Exception("Cliente não encontrado para a venda.");

            return clienteId.Value;
        }


        private string RemoveCaracteresInvalidos(string nomeArquivo)
        {
            if (string.IsNullOrEmpty(nomeArquivo))
                return "Clientes";

            // Remove caracteres inválidos para nome de arquivo
            char[] caracteresInvalidos = Path.GetInvalidFileNameChars();
            foreach (char c in caracteresInvalidos)
            {
                nomeArquivo = nomeArquivo.Replace(c.ToString(), "_");
            }

            // Remove espaços extras e limita o tamanho
            nomeArquivo = nomeArquivo.Trim();
            if (nomeArquivo.Length > 50)
                nomeArquivo = nomeArquivo.Substring(0, 50);

            return nomeArquivo;
        }

        private bool AbrirPDF(string caminhoArquivo)
        {
            try
            {
                // Método 1: Usar Process.Start com UseShellExecute
                Process.Start(new ProcessStartInfo
                {
                    FileName = caminhoArquivo,
                    UseShellExecute = true
                });
                return true;
            }
            catch
            {
                try
                {
                    // Método 2: Tentar com o programa padrão do Windows
                    Process.Start("rundll32.exe", "shell32.dll,OpenAs_RunDLL " + caminhoArquivo);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        private void AbrirPastaContendoArquivo(string caminhoArquivo)
        {
            try
            {
                string pasta = Path.GetDirectoryName(caminhoArquivo);

                if (Directory.Exists(pasta))
                {
                    // Abre a pasta no explorador
                    Process.Start("explorer.exe", pasta);
                }
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro($"Não foi possível abrir a pasta: {ex.Message}");
            }
        }
        private void GerarReciboPagamentos()
        {
            var parcelasSelecionadas = ObterParcelasSelecionadas();
            if (!parcelasSelecionadas.Any())
            {
                Utilitario.Mensagens.Aviso("Selecione pelo menos uma parcela marcando o checkbox para gerar o recibo.");
                return;
            }

            // Extrato do cliente (usa CurrentRow, não as selecionadas)
            var extratoCliente = ObterExtratoCliente(true);
            if (extratoCliente == null) return;

            // Converte para dynamic apenas para compatibilidade com PDFGenerator
            var parcelasDynamic = parcelasSelecionadas.Cast<dynamic>().ToList();

            using var saveDialog = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Salvar Recibo",
                FileName = $"Recibo_{RemoveCaracteresInvalidos(extratoCliente.NomeCliente)}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                // 🔹 Extrato
                var extratoBLL = new ExtratoBLL();
                var primeiraParcela = parcelasSelecionadas.First();
                var extrato = extratoBLL.ObterExtratoCliente(primeiraParcela.ClienteID, false);

                // 🔹 Pagamentos da(s) parcela(s)
                var pagamentoBLL = new PagamentoBLL();
                var pagamentos = pagamentoBLL.ListarPagamentosPorParcela(primeiraParcela.ParcelaID);

                if (pagamentos == null || pagamentos.Count == 0)
                {
                    MessageBox.Show("Nenhum pagamento encontrado para esta parcela.");
                    return;
                }

                // 🔹 Empresa (logo + nome)
                var empresaBLL = new EmpresaBll();
                var empresa = empresaBLL.ObterDadosParaPdf();

                // 🔹 Gerar PDF
                PDFGenerator.GerarReciboPagamentos(
                    extrato,
                    pagamentos,
                    empresa,
                    saveDialog.FileName
                );

                var resultado = MessageBox.Show(
                    $"Recibo gerado com sucesso!\nArquivo: {Path.GetFileName(saveDialog.FileName)}\n" +
                    $"Pasta: {Path.GetDirectoryName(saveDialog.FileName)}\nDeseja abrir o arquivo agora?",
                    "Sucesso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (resultado == DialogResult.Yes)
                {
                    if (!AbrirPDF(saveDialog.FileName))
                        AbrirPastaContendoArquivo(saveDialog.FileName);
                }
            }
        }

        private void FrmContasAReceber_Shown(object sender, EventArgs e)
        {
            Utilitario.AplicarCorFocoNosTextBox(this);
        }

        private void FrmContasAReceber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Escape && pnlStatusPopup.Visible)
            {
                pnlStatusPopup.Visible = false;
                txtStatusParcela.Focus();
            }
        }
        private void LimparFiltro_Click(object sender, EventArgs e)
        {

            // =========================
            // 3️⃣ CAMPOS DE TEXTO
            // =========================
            txtNomeCliente.Clear();
            // =========================
            // 4️⃣ DATAS (APENAS DOIS PICKERS)
            // =========================
            dtpInicial.Value = DateTime.Today;
            dtpFinal.Value = DateTime.Today;

            // =========================
            // 5️⃣ ESTADO DA TELA
            // =========================
            AtualizarEstadoPesquisa();

            // =========================
            // 6️⃣ RECARREGA O GRID
            // =========================
            CarregarContasAReceber();
        }
        private void AtualizarEstadoBotoesFinanceiros()
        {
            // Estado padrão
            btnBaixarParcela.Enabled = false;
            btnEstornar.Enabled = false;

            var selecionadas = ObterParcelasSelecionadas();

            // Nenhuma parcela selecionada
            if (!selecionadas.Any())
                return;

            // 🔒 Se houver MAIS DE UMA selecionada
            if (selecionadas.Count > 1)
            {
                // Baixa em lote só se nenhuma estiver paga
                bool existePaga = selecionadas.Any(p =>
                    p.StatusParcela.ToEnumStatusParcela() == EnumStatusParcela.Pago ||
                    p.StatusParcela.ToEnumStatusParcela() == EnumStatusParcela.Cancelada);

                btnBaixarParcela.Enabled = !existePaga;

                // Estorno nunca é em lote
                btnEstornar.Enabled = false;
                return;
            }

            // 🔑 Caso de UMA única parcela
            var parcela = selecionadas.First();
            var status = parcela.StatusParcela.ToEnumStatusParcela();

            // ❌ CANCELADA: nada permitido
            if (status == EnumStatusParcela.Cancelada)
                return;

            // 🔹 BAIXA
            btnBaixarParcela.Enabled =
                status != EnumStatusParcela.Pago;

            // 🔹 ESTORNO
            btnEstornar.Enabled =
                parcela.ValorRecebido > 0;
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregarContasAReceber();
        }

        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            // =========================
            // 1️⃣ LIMPA STATUS (CheckedListBox)
            // =========================
            for (int i = 0; i < chkStatusParcela.Items.Count; i++)
            {
                chkStatusParcela.SetItemChecked(i, false);
            }

            // Texto padrão do "combo" de status
            txtStatusParcela.Text = "Todos os status";

            // =========================
            // 2️⃣ LIMPA CAMPOS DE TEXTO
            // =========================
            txtNomeCliente.Clear();

            // =========================
            // 3️⃣ DATAS
            // =========================
            dtpInicial.Value = DateTime.Today;
            dtpFinal.Value = DateTime.Today;

            // =========================
            // 4️⃣ TIPO DE PESQUISA (VOLTA AO PADRÃO)
            // =========================
            cmbTipoPesquisa.SelectedItem = TipoPesquisaContasReceber.PeriodoVenda;

            // =========================
            // 5️⃣ FECHA POPUP DE STATUS (SE ABERTO)
            // =========================
            pnlStatusPopup.Visible = false;

            // =========================
            // 6️⃣ ATUALIZA ESTADO DA TELA
            // =========================
            AtualizarEstadoPesquisa();

            // =========================
            // 7️⃣ RECARREGA O GRID
            // =========================
            CarregarContasAReceber();
        }

        private void btnVerItensVenda_Click(object sender, EventArgs e)
        {
            if (dgvContasAReceber.CurrentRow == null)
            {
                Utilitario.Mensagens.Aviso("Selecione uma venda para visualizar os itens.");
                return;
            }

            if (!(dgvContasAReceber.CurrentRow.DataBoundItem is ContaAReceberDTO dto))
            {
                Utilitario.Mensagens.Aviso("Não foi possível identificar a venda.");
                return;
            }

            using (var frm = new FrmItensVenda())
            {
                frm.VendaId = dto.VendaID;

                frm.SubTitulo =
                    $"Venda nº {dto.VendaID} • Cliente: {dto.NomeCliente} • {dto.DataVenda:dd/MM/yyyy}";

                frm.ShowDialog(this);
            }

        }

        private void btnBaixarParcela_Click(object sender, EventArgs e)
        {
            var selecionadas = ObterParcelasSelecionadas();

            if (!selecionadas.Any())
            {
                Utilitario.Mensagens.Aviso("Por favor, selecione ao menos uma parcela.");
                return;
            }

            // 🔒 BLOQUEIO: nenhuma parcela pode estar PAGA
            var parcelaPaga = selecionadas.FirstOrDefault(p =>
            {
                var statusStr = (p.StatusParcela ?? "").Trim();
                if (string.IsNullOrWhiteSpace(statusStr)) return false;

                // força normalização
                var statusEnum = statusStr.ToEnumStatusParcela();
                return statusEnum == EnumStatusParcela.Pago;
            });


            if (parcelaPaga != null)
            {
                Utilitario.Mensagens.Aviso("Esta parcela já está quitada e não pode mais ser alterada.");
                return;
            }

            // =========================
            // SEGUE FLUXO NORMAL
            // =========================
            var selecionadasDto = selecionadas.ToList();

            decimal totalDevido = selecionadas.Sum(p => p.ValorParcela);
            decimal totalRecebido = selecionadas.Sum(p => p.ValorRecebido);
            decimal saldoTotal = selecionadas.Sum(p => p.Saldo);
            string nomeCliente = selecionadas[0].NomeCliente ?? string.Empty;

            using var frm = new FrmBaixarParcela();
            frm.Text = nomeCliente;

            frm.CarregarDados(
                selecionadasDto,
                nomeCliente,
                totalDevido,
                totalRecebido,
                saldoTotal
            );

            if (frm.ShowDialog() == DialogResult.OK)
                CarregarContasAReceber();
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se há checkbox marcado
                bool temCheckboxMarcado = false;

                foreach (DataGridViewRow row in dgvContasAReceber.Rows)
                {
                    if (row.Cells["Selecionar"].Value is bool marcado && marcado)
                    {
                        temCheckboxMarcado = true;
                        break;
                    }
                }

                // Verifica se há linha selecionada (CurrentRow)
                bool temLinhaSelecionada = (dgvContasAReceber.CurrentRow != null);

                // Se não tem nenhum dos dois, mostra mensagem
                if (!temCheckboxMarcado && !temLinhaSelecionada)
                {
                    Utilitario.Mensagens.Info("Para gerar extrato: selecione uma linha.\nPara gerar recibo: marque o checkbox das parcelas.");
                    return;
                }

                // SEMPRE abre o formulário de opções
                using (var frmOpcoes = new FrmOpcoesExtrato())
                {
                    // Desabilita os botões que não estão disponíveis
                    // Supondo que seus botões no FrmOpcoesExtrato são públicos ou você tem acesso a eles

                    // Se não tem linha selecionada, desabilita Extrato
                    if (!temLinhaSelecionada)
                    {
                        // Desabilita o botão de extrato
                        var controles = frmOpcoes.Controls.Find("btnExtrato", true);
                        if (controles.Length > 0 && controles[0] is Button btnExtrato)
                        {
                            btnExtrato.Enabled = false;
                            btnExtrato.Text = "Extrato (selecione uma linha primeiro)";
                        }
                    }

                    // Se não tem checkbox marcado, desabilita Recibo
                    if (!temCheckboxMarcado)
                    {
                        // Desabilita o botão de recibo
                        var controles = frmOpcoes.Controls.Find("btnRecibo", true);
                        if (controles.Length > 0 && controles[0] is Button btnRecibo)
                        {
                            btnRecibo.Enabled = false;
                            btnRecibo.Text = "Recibo (marque o checkbox primeiro)";
                        }
                    }

                    var resultado = frmOpcoes.ShowDialog();

                    if (resultado == DialogResult.Yes && temLinhaSelecionada)
                    {
                        var opcao = MessageBox.Show(
                            "Deseja o extrato DETALHADO (com pagamentos)?",
                            "Tipo de Extrato",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        bool detalhado = opcao == DialogResult.Yes;

                        if (detalhado)
                            GerarExtratoDetalhadoHierarquico(); // 🔹 NOVO
                        else
                            GerarExtratoCompleto(false);        // 🔹 JÁ EXISTE
                    }

                }
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro($"Erro: {ex.Message}");
            }
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {

            // ======================================================
            // 🔹 VALIDA PARCELA
            // ======================================================
            if (dgvContasAReceber.CurrentRow == null)
            {
                Utilitario.Mensagens.Aviso("Selecione uma parcela.");
                return;
            }

            var parcela = dgvContasAReceber.CurrentRow.DataBoundItem as ContaAReceberDTO;

            if (parcela == null)
            {
                Utilitario.Mensagens.Aviso("Parcela inválida.");
                return;
            }

            var extratoBLL = new ExtratoBLL();
            var pagamentoBLL = new PagamentoBLL();

            // 🔹 Extrato sempre vem da parcela
            var extrato = extratoBLL.ObterExtratoPorParcela(parcela.ParcelaID);

            // ======================================================
            // 🔥 BUSCA PAGAMENTOS SELECIONADOS NO GRID
            // ======================================================
            var pagamentosSelecionados = new List<PagamentoExtratoModel>();


            List<PagamentoExtratoModel> pagamentosParaRecibo;
            string nomeArquivo;

            // ======================================================
            // 🔥 DECISÃO AUTOMÁTICA
            // ======================================================
            if (pagamentosSelecionados.Count > 0)
            {
                // 👉 Recibo SOMENTE dos pagamentos marcados
                pagamentosParaRecibo = pagamentosSelecionados;

                nomeArquivo = pagamentosSelecionados.Count == 1
                    ? $"Recibo_Pagamento_{pagamentosSelecionados[0].PagamentoID}.pdf"
                    : $"Recibo_Pagamentos_{parcela.ParcelaID}.pdf";
            }
            else
            {
                // 👉 Recibo da PARCELA INTEIRA
                pagamentosParaRecibo =
                    pagamentoBLL.ListarPagamentosPorParcela(parcela.ParcelaID);

                if (pagamentosParaRecibo == null || pagamentosParaRecibo.Count == 0)
                {
                    Utilitario.Mensagens.Aviso("Nenhum pagamento encontrado para esta parcela.");
                    return;
                }

                nomeArquivo = $"Recibo_Parcela_{parcela.ParcelaID}.pdf";
            }

            // ======================================================
            // 🔹 EMPRESA
            // ======================================================
            var empresa = new EmpresaBll().ObterDadosParaPdf();

            using SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Arquivo PDF (*.pdf)|*.pdf",
                FileName = nomeArquivo
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            // ======================================================
            // 🔹 GERAR PDF
            // ======================================================
            PDFGenerator.GerarReciboPagamentos(
                extrato,
                pagamentosParaRecibo,
                empresa,
                sfd.FileName
            );

            // ======================================================
            // 🔹 CONFIRMAR ABERTURA
            // ======================================================
            if (Utilitario.Mensagens.Confirmacao("Recibo gerado com sucesso. Deseja abrir agora?"))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = sfd.FileName,
                    UseShellExecute = true
                });
            }
        }

        private void btnEstornar_Click(object sender, EventArgs e)
        {
            var selecionadas = ObterParcelasSelecionadas();

            if (selecionadas.Count == 0)
            {
                Utilitario.Mensagens.Aviso(
                    "Selecione uma parcela para estornar.");
                return;
            }

            // 🔒 REGRA: estorno é SEMPRE de UMA única parcela
            if (selecionadas.Count > 1)
            {
                Utilitario.Mensagens.Aviso(
                    "Selecione apenas UMA parcela para estornar.");
                return;
            }

            var parcela = selecionadas.First();

            var status = parcela.StatusParcela.ToEnumStatusParcela();

            // ❌ BLOQUEIO: parcela cancelada
            if (status == EnumStatusParcela.Cancelada)
            {
                Utilitario.Mensagens.Aviso(
                    "Parcela cancelada não pode ser estornada.");
                return;
            }

            // ❌ BLOQUEIO: não há valor recebido
            if (parcela.ValorRecebido <= 0)
            {
                Utilitario.Mensagens.Aviso(
                    "Esta parcela não possui valores para estorno.");
                return;
            }

            // =========================
            // SEGUE FLUXO NORMAL
            // =========================
            using (var frm = new FrmEstornarPagamento())
            {
                frm.CarregarDados(
                    new List<long> { parcela.ParcelaID },
                    parcela.NomeCliente ?? "Cliente"
                );

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var bll = new ParcelaBLL();

                        bll.EstornarPagamento(
                            parcela.ParcelaID,
                            frm.ValorEstorno,
                            frm.Motivo
                        );

                        Utilitario.Mensagens.Info(
                            "Estorno realizado com sucesso!");

                        CarregarContasAReceber();
                    }
                    catch (Exception ex)
                    {
                        Utilitario.Mensagens.Erro(
                            "Erro ao estornar: " + ex.Message);
                    }
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStatusParcela_Click(object sender, EventArgs e)
        {
            pnlStatusPopup.Visible = !pnlStatusPopup.Visible;
            pnlStatusPopup.BringToFront();
        }

        private void chkStatusParcela_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke(new Action(AtualizarTextoStatus));
        }

        private void FrmFinanceiro_Click(object sender, EventArgs e)
        {
            pnlStatusPopup.Visible = false;
        }
        private void AtualizarTextoStatus()
        {
            if (chkStatusParcela.CheckedItems.Count == 0)
            {
                txtStatusParcela.Text = "Todos os status";
                return;
            }

            var itens = chkStatusParcela.CheckedItems
                .Cast<object>()
                .Select(i => i.ToString());

            txtStatusParcela.Text = string.Join(", ", itens);
        }
        private void InicializarEstadoFiltros()
        {
            cmbTipoPesquisa.SelectedItem = TipoPesquisaContasReceber.PeriodoVenda;
            AtualizarEstadoPesquisa();
        }

        private void cmbTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_formCarregado)
                return;

            AtualizarEstadoPesquisa();

            BeginInvoke(new Action(() =>
            {
                var tipo = ObterTipoPesquisaSelecionado();

                if (tipo == TipoPesquisaContasReceber.NomeCliente)
                {
                    txtNomeCliente.Focus();
                    txtNomeCliente.SelectAll();
                }
                else if (tipo == TipoPesquisaContasReceber.PeriodoVenda ||
                         tipo == TipoPesquisaContasReceber.DataVenda ||
                    tipo == TipoPesquisaContasReceber.PeriodoVencimento)
                {
                    dtpInicial.Focus();
                }
            }));
        }
        private class TipoPesquisaItem
        {
            public TipoPesquisaContasReceber Valor { get; set; }
            public string Texto { get; set; }
        }

        private void chkStatusParcela_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDetalheParcela_Click(object sender, EventArgs e)
        {
            if (dgvContasAReceber.CurrentRow == null)
            {
                Utilitario.Mensagens.Aviso("Selecione uma parcela.");
                return;
            }

            if (dgvContasAReceber.CurrentRow.DataBoundItem is not ContaAReceberDTO parcela)
            {
                Utilitario.Mensagens.Aviso("Parcela inválida.");
                return;
            }

            using var frm = new FrmPagamentosParcela(parcela.ParcelaID);

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                CarregarContasAReceber();
            }
        }

        private void dgvContasAReceber_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                var coluna = dgvContasAReceber.Columns[e.ColumnIndex].DataPropertyName;

                if (coluna == "Saldo")
                {
                    var valor = dgvContasAReceber.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (valor != null && valor != DBNull.Value)
                    {
                        decimal saldo = Convert.ToDecimal(valor);

                        if (saldo > 0)
                            e.ToolTipText = "💰 Valor em aberto";
                        else if (saldo < 0)
                            e.ToolTipText = "💚 Crédito a favor do cliente";
                        else
                            e.ToolTipText = "✅ Quitado";
                    }
                }
            }
        }
    }

}
