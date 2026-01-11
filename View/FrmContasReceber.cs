using Dapper;
using GVC.BLL;
using GVC.DAL;
using GVC.DAL;
using GVC.Model;
using GVC.Model.Enums.GVC.Model.Enums;
using GVC.Model.Extensions;
using GVC.MODEL.Extensions;
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

namespace GVC.View
{
    public partial class FrmContasReceber : KryptonForm
    {
        private bool bloqueiaPesquisa = false;
        private readonly PagamentoParcialDal _pagamentoDal = new PagamentoParcialDal();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ClienteID { get; set; }

        private readonly VendaBLL _vendaBll = new VendaBLL();
        private readonly ItensVendaBLL _itensVendaBll = new ItensVendaBLL();
        private long? _parcelaSelecionadaParaRecibo = null;
        private readonly Color _corSelecionado = Color.FromArgb(220, 240, 255);



        public FrmContasReceber()
        {
            InitializeComponent();
            dgvPagamentos.CurrentCellDirtyStateChanged += dgvPagamentos_CurrentCellDirtyStateChanged;
            WireTipoPesquisa();
        }
        private void WireTipoPesquisa()
        {
            foreach (Control ctrl in grpTipoPesquisa.Controls)
            {
                if (ctrl is RadioButton rb)
                {
                    rb.CheckedChanged += TipoPesquisa_CheckedChanged;
                }
            }
        }

        private void TipoPesquisa_CheckedChanged(object sender, EventArgs e)
        {
            // sender = o RadioButton que mudou
            if (sender is not RadioButton rb || !rb.Checked)
                return;

            AtualizarEstadoPesquisa();
        }




        private TipoPesquisaContasReceber ObterTipoPesquisaSelecionado()
        {
            if (rbTodos.Checked) return TipoPesquisaContasReceber.Todos;
            if (rbNomeCliente.Checked) return TipoPesquisaContasReceber.NomeCliente;
            if (rbNumeroVenda.Checked) return TipoPesquisaContasReceber.NumeroVenda;
            if (rbDataVenda.Checked) return TipoPesquisaContasReceber.DataVenda;
            if (rbPeriodoVenda.Checked) return TipoPesquisaContasReceber.PeriodoVenda;
            if (rbVencimento.Checked) return TipoPesquisaContasReceber.Vencimento;
            if (rbPeriodoVencimento.Checked) return TipoPesquisaContasReceber.PeriodoVencimento;
            if (rbStatusParcela.Checked) return TipoPesquisaContasReceber.StatusParcela;

            return TipoPesquisaContasReceber.Todos;
        }


        private void AtualizarEstadoPesquisa()
        {
            // Desliga tudo
            txtNomeCliente.Enabled = false;
            txtNumeroVenda.Enabled = false;
            dtpInicial.Enabled = false;
            dtpFinal.Enabled = false;
            lblAte.Enabled = false;

            var tipo = ObterTipoPesquisaSelecionado();

            switch (tipo)
            {
                case TipoPesquisaContasReceber.NomeCliente:
                    txtNomeCliente.Enabled = true;
                    txtNomeCliente.Focus();
                    break;

                case TipoPesquisaContasReceber.NumeroVenda:
                    txtNumeroVenda.Enabled = true;
                    txtNumeroVenda.Focus();
                    break;

                case TipoPesquisaContasReceber.DataVenda:
                    dtpInicial.Enabled = true;
                    break;

                case TipoPesquisaContasReceber.PeriodoVenda:
                    lblPeriodoVenda.Text = "Período da Venda:";
                    lblAte.Enabled = true;
                    dtpInicial.Enabled = true;
                    dtpFinal.Enabled = true;
                    break;

                case TipoPesquisaContasReceber.Vencimento:
                    lblPeriodoVenda.Text = "Data de Vencimento:";
                    dtpInicial.Enabled = true;
                    break;

                case TipoPesquisaContasReceber.PeriodoVencimento:
                    lblPeriodoVenda.Text = "Período de Vencimento:";
                    lblAte.Enabled = true;
                    dtpInicial.Enabled = true;
                    dtpFinal.Enabled = true;
                    break;
            }
        }


        private void WirePesquisaEvents()
        {
            rbTodos.CheckedChanged += (_, __) => AtualizarEstadoPesquisa();
            rbNomeCliente.CheckedChanged += (_, __) => AtualizarEstadoPesquisa();
            rbNumeroVenda.CheckedChanged += (_, __) => AtualizarEstadoPesquisa();
            rbDataVenda.CheckedChanged += (_, __) => AtualizarEstadoPesquisa();
            rbDataVenda.CheckedChanged += (_, __) => AtualizarEstadoPesquisa();
            rbVencimento.CheckedChanged += (_, __) => AtualizarEstadoPesquisa();
            rbPeriodoVencimento.CheckedChanged += (_, __) => AtualizarEstadoPesquisa();
            rbStatusParcela.CheckedChanged += (_, __) => AtualizarEstadoPesquisa();
        }
        private List<EnumStatusParcela> ObterStatusSelecionados()
        {
            var lista = new List<EnumStatusParcela>();

            if (chkPendente.Checked) lista.Add(EnumStatusParcela.Pendente);
            if (chkParcial.Checked) lista.Add(EnumStatusParcela.ParcialmentePago);
            if (chkPago.Checked) lista.Add(EnumStatusParcela.Pago);
            if (chkAtrasada.Checked) lista.Add(EnumStatusParcela.Atrasada);
            if (chkCancelada.Checked) lista.Add(EnumStatusParcela.Cancelada);

            // Se nenhum marcado, assume todos
            if (!lista.Any())
                lista.AddRange(Enum.GetValues(typeof(EnumStatusParcela))
                    .Cast<EnumStatusParcela>());

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
            dgvContasAReceber.Columns.Add(colParcelaID); // Coluna ID (oculta)

            var colVendaID = new DataGridViewTextBoxColumn
            {
                Name = "VendaID",               // OBRIGATÓRIO
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

            // Datas: assegure o tipo DateTime e o formato
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

            // Valores: tipo decimal e formato moeda
            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorParcela",
                HeaderText = "Valor Parcela",
                Width = 100,
                ValueType = typeof(decimal
                ),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorRecebido",
                HeaderText = "Recebido",
                Width = 100,
                ValueType = typeof(decimal),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Saldo",
                HeaderText = "Saldo",
                Width = 100,
                ValueType = typeof(decimal),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
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
                Width = 500, // ← AUMENTE a largura (200 é muito pouco para seu texto)
                ValueType = typeof(string),
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    WrapMode = DataGridViewTriState.False,
                    Alignment = DataGridViewContentAlignment.MiddleLeft // ← ESSENCIAL
                }
            });

            // Opcional: estilo geral
            dgvContasAReceber.AllowUserToAddRows = false;
            dgvContasAReceber.AllowUserToDeleteRows = false;
            dgvContasAReceber.ReadOnly = true;
            dgvContasAReceber.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContasAReceber.MultiSelect = false;
            dgvContasAReceber.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dgvContasAReceber.ReadOnly = false; // libera edição no grid inteiro

            foreach (DataGridViewColumn col in dgvContasAReceber.Columns)
            {
                if (col.Name != "Selecionar")
                    col.ReadOnly = true; // bloqueia todas as outras colunas
            }
        }
        private void AtualizarCoresGridPagamentos()
        {
            foreach (DataGridViewRow row in dgvPagamentos.Rows)
            {
                bool marcado = Convert.ToBoolean(row.Cells["Selecionar"].Value);
                row.DefaultCellStyle.BackColor =
                    marcado ? _corSelecionado : Color.White;
            }
        }
        private void ConfigurarGridPagamentos()
        {
            dgvPagamentos.AutoGenerateColumns = false;
            dgvPagamentos.Columns.Clear();

            // 🔹 MUITO IMPORTANTE
            dgvPagamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // ======================================================
            // 🔹 COLUNA CHECKBOX (SELEÇÃO)
            // ======================================================
            var chk = new DataGridViewCheckBoxColumn
            {
                Name = "Selecionar",
                HeaderText = "",
                Width = 30
            };
            dgvPagamentos.Columns.Add(chk);

            // ======================================================
            // 🔹 COLUNAS FIXAS
            // ======================================================
            dgvPagamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PagamentoID",
                HeaderText = "ID",
                Visible = false
            });

            dgvPagamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataPagamento",
                HeaderText = "Data",
                Width = 90,
                ValueType = typeof(DateTime),
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy"
                }
            });

            dgvPagamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FormaPagamento",
                HeaderText = "Forma",
                Width = 120
            });

            dgvPagamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorPago",
                HeaderText = "Valor Pago",
                Width = 100,
                ValueType = typeof(decimal),
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            // ======================================================
            // 🔥 COLUNA DINÂMICA (FILL)
            // ======================================================
            dgvPagamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Observacao",
                HeaderText = "Observação",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, // 🔥 ocupa o resto
                MinimumWidth = 200,                                 // segurança
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleLeft,
                    WrapMode = DataGridViewTriState.False
                }
            });

            // ======================================================
            // 🔹 CONFIGURAÇÕES GERAIS
            // ======================================================
            dgvPagamentos.AllowUserToAddRows = false;
            dgvPagamentos.AllowUserToDeleteRows = false;
            dgvPagamentos.MultiSelect = false;
            dgvPagamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvPagamentos.ReadOnly = false; // libera checkbox

            // 🔒 Bloqueia todas as colunas exceto o checkbox
            foreach (DataGridViewColumn col in dgvPagamentos.Columns)
            {
                if (col.Name != "Selecionar")
                    col.ReadOnly = true;
            }
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

            // 🔑 1️⃣ Tipo de pesquisa (RadioButton)
            var tipoPesquisa = ObterTipoPesquisaSelecionado();

            // 🔑 2️⃣ Status selecionados (CheckBox)
            var statusSelecionados = ObterStatusSelecionados();

            // 🔑 3️⃣ Filtros opcionais (somente se habilitados)
            string nomeCliente = txtNomeCliente.Enabled
                ? txtNomeCliente.Text.Trim()
                : null;

            string numeroVenda = txtNumeroVenda.Enabled
                ? txtNumeroVenda.Text.Trim()
                : null;

            DateTime? dataInicial = null;
            DateTime? dataFinal = null;

            if (dtpInicial.Enabled)
                dataInicial = dtpInicial.Value.Date;

            if (dtpFinal.Enabled)
                dataFinal = dtpFinal.Value.Date;

            // 🔑 4️⃣ Chamada única ao DAL
            var lista = dal.ListarContasAReceber(
                tipoPesquisa,
                nomeCliente,
                numeroVenda,
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
            AtualizarParcelasAtrasadasNoBanco();
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
               
        private List<PagamentoExtratoModel> ObterPagamentosDoGrid()
        {
            var lista = new List<PagamentoExtratoModel>();

            foreach (DataGridViewRow row in dgvPagamentos.Rows)
            {
                if (row.DataBoundItem is PagamentoExtratoModel pagamento)
                    lista.Add(pagamento);
            }

            return lista;
        }

        private void FrmContasAReceber_Load(object sender, EventArgs e)
        {
            lblTotalSelecionado.Text = "Total selecionado: R$ 0,00";
            ConfigurarGridContasAReceber();
            ConfigurarGridPagamentos(); // 🔴 ESSENCIAL
            AtualizarParcelasAtrasadasNoBanco(); // ← Atualiza ao abrir              
        }
        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {
            if (bloqueiaPesquisa || string.IsNullOrWhiteSpace(txtNomeCliente.Text))
                return;

            // SALVA O TEXTO ATUAL ANTES DE PERDER O FOCO
            string textoDigitado = txtNomeCliente.Text;

            // Usa BeginInvoke para "adiar" a abertura da pesquisa até o Windows terminar de processar a digitação
            this.BeginInvoke(new Action(() =>
            {
                if (bloqueiaPesquisa) return; // pode ter sido bloqueado enquanto esperava

                bloqueiaPesquisa = true;
                try
                {
                    using (var pesquisaCliente = new FrmLocalizarCliente(this, textoDigitado))
                    {
                        pesquisaCliente.Owner = this;

                        if (pesquisaCliente.ShowDialog() == DialogResult.OK)
                        {
                            bloqueiaPesquisa = true;
                            txtNomeCliente.Text = pesquisaCliente.ClienteSelecionado;
                            ClienteID = pesquisaCliente.ClienteID;
                        }
                    }
                }
                finally
                {
                    bloqueiaPesquisa = false;
                }
            }));
        }

        private void dgvContasAReceber_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
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

            // 2) Colunas monetárias: formatar como moeda e alinhar à direita
            else if (coluna == "ValorParcela" ||
                     coluna == "ValorRecebido" ||
                     coluna == "Saldo" ||
                     coluna == "Juros" ||
                     coluna == "Multa")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), NumberStyles.Any, CultureInfo.CurrentCulture, out decimal valor))
                {
                    e.Value = valor.ToString("C2"); // Ex: R$ 1.000,00
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    e.CellStyle.Font = new Font(dgvContasAReceber.Font, FontStyle.Regular); // padrão
                    e.FormattingApplied = true;

                    // Cores específicas apenas para a coluna Saldo
                    if (coluna == "Saldo")
                    {
                        if (valor < 0m)
                        {
                            e.CellStyle.ForeColor = Color.Red;
                            e.CellStyle.Font = new Font(dgvContasAReceber.Font, FontStyle.Bold);
                        }
                        else if (valor == 0m)
                        {
                            e.CellStyle.ForeColor = Color.Gray;
                        }
                        else
                        {
                            e.CellStyle.ForeColor = Color.Black; // ou ForestGreen se preferir positivo destacado
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

                    // Adicione outros status se necessário (Renegociada, Em Cobrança, etc.)
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

            lblTotalSelecionado.Text =
                $"Total selecionado: {totalSaldo:C2}";
        }
        private decimal CalcularTotalRecebidoSelecionado()
        {
            return ObterParcelasSelecionadas()
                .Where(p => p.StatusParcela.ToEnumStatusParcela() == EnumStatusParcela.Pago)
                .Sum(p => p.ValorRecebido);
        }

        private void dgvContasAReceber_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvContasAReceber.IsCurrentCellDirty) { dgvContasAReceber.CommitEdit(DataGridViewDataErrorContexts.Commit); }
        }

        private void dgvContasAReceber_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvContasAReceber.Columns[e.ColumnIndex].Name == "Selecionar") { AtualizarTotalSelecionado(); }
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
                // ✅ Query ajustada para SQL Server
                const string sql = @" UPDATE Parcela SET Status = 'Atrasada' WHERE DataVencimento < CAST(GETDATE() AS DATE)
                                      AND Status NOT IN ('Paga', 'ParcialmentePaga', 'Cancelada', 'Atrasada')";

                using (var conn = Conexao.Conex(Sessao.AmbienteSelecionado))
                using (var cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    // Opcional: logar quantas linhas foram atualizadas
                    System.Diagnostics.Debug.WriteLine($"Parcelas atrasadas atualizadas: {linhasAfetadas}");
                }
            }
            catch (Exception ex)
            {
                // Log silencioso ou opcional
                System.Diagnostics.Debug.WriteLine("Erro ao atualizar parcelas atrasadas: " + ex.Message);
            }
        }

        private void CarregarVenda(int vendaId)
        {
            var venda = _vendaBll.ObterVendaPorId((int)vendaId);

            if (venda == null)
            {
                LimparAreaVenda();
                return;
            }
            if (venda.Cliente == null && venda.ClienteID > 0)
            {
                string query = "SELECT Nome FROM Clientes WHERE ClienteID = @id";
                string nomeCliente = Utilitario.PesquisarPorCodigoRetornarNome(query, "id", venda.ClienteID);

                venda.Cliente = new ClienteModel
                {
                    ClienteID = venda.ClienteID,
                    Nome = nomeCliente
                };
            }

        }
        private void BuscarNomeCliente(long clienteId)
        {
            string query = "SELECT Nome FROM Clientes WHERE ClienteID = @parametro";
        }
        private void dgvContasAReceber_SelectionChanged(object sender, EventArgs e)
        {

            dgvPagamentos.DataSource = null;

            if (dgvContasAReceber.CurrentRow?.DataBoundItem is not ContaAReceberDTO parcela)
                return;

            var pagamentos = _pagamentoDal
                .ListarPagamentosPorParcelaCompleto(parcela.ParcelaID);

            dgvPagamentos.DataSource = pagamentos;
        }
        private void LimparAreaVenda()
        {
            lblNumeroVenda.Text = "-";

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
        private List<PagamentoExtratoModel> ObterPagamentosSelecionados()
        {
            var parcelas = ObterParcelasSelecionadas();
            if (!parcelas.Any()) return new List<PagamentoExtratoModel>();

            using var conn = Conexao.Conex();

            var ids = parcelas.Select(p => p.ParcelaID).ToArray();

            string sql = @"
        SELECT
            pp.PagamentoID,
            pp.ParcelaID,
            pp.DataPagamento,
            pp.ValorPago,
            fp.NomeFormaPagamento AS NomeFormaPagamento,
            pp.Observacao
        FROM PagamentosParciais pp
        LEFT JOIN FormaPagamento fp ON fp.FormaPgtoID = pp.FormaPgtoID
        WHERE pp.ParcelaID IN @ids";

            return conn.Query<PagamentoExtratoModel>(sql, new { ids }).ToList();
        }

        private void FrmContasAReceber_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }

        private void FrmContasAReceber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void LimparFiltro_Click(object sender, EventArgs e)
        {
            // =========================
            // 1️⃣ TIPO DE PESQUISA
            // =========================
            rbTodos.Checked = true;

            // =========================
            // 2️⃣ STATUS DA PARCELA
            // (nenhum marcado = todos)
            // =========================
            chkPendente.Checked = false;
            chkParcial.Checked = false;
            chkPago.Checked = false;
            chkAtrasada.Checked = false;
            chkCancelada.Checked = false;

            // =========================
            // 3️⃣ CAMPOS DE TEXTO
            // =========================
            txtNomeCliente.Clear();
            txtNumeroVenda.Clear();

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

        private void dgvPagamentos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPagamentos.IsCurrentCellDirty)
                dgvPagamentos.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvPagamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvPagamentos.Columns[e.ColumnIndex].Name != "Selecionar")
                return;

            dgvPagamentos.CommitEdit(DataGridViewDataErrorContexts.Commit);

            var row = dgvPagamentos.Rows[e.RowIndex];
            bool marcado = Convert.ToBoolean(row.Cells["Selecionar"].Value);

            var pagamento = row.DataBoundItem as PagamentoExtratoModel;
            if (pagamento == null)
                return;

            // 🔹 Se está marcando
            if (marcado)
            {
                if (_parcelaSelecionadaParaRecibo == null)
                {
                    _parcelaSelecionadaParaRecibo = pagamento.ParcelaID;
                }
                else if (_parcelaSelecionadaParaRecibo != pagamento.ParcelaID)
                {
                    Utilitario.Mensagens.Aviso(
                        "Você só pode selecionar pagamentos da mesma parcela.");

                    row.Cells["Selecionar"].Value = false;
                    return;
                }
            }
            else
            {
                // 🔹 Se desmarcou tudo, libera novamente
                bool aindaTemMarcado = dgvPagamentos.Rows
                    .Cast<DataGridViewRow>()
                    .Any(r => Convert.ToBoolean(r.Cells["Selecionar"].Value));

                if (!aindaTemMarcado)
                    _parcelaSelecionadaParaRecibo = null;
            }
            AtualizarCoresGridPagamentos();

            AtualizarTotalSelecionado();
        }














        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarContasAReceber();
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {           
           
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

            foreach (DataGridViewRow row in dgvPagamentos.Rows)
            {
                bool marcado = row.Cells["Selecionar"]?.Value is bool b && b;

                if (!marcado)
                    continue;

                if (row.DataBoundItem is PagamentoExtratoModel pagamento)
                    pagamentosSelecionados.Add(pagamento);
            }

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

            long vendaId = dto.VendaID;

            using (var frm = new FrmItensVenda())
            {
                frm.CarregarItensVenda(vendaId);
                frm.ShowDialog(this);
            }
        }

        private void btnBaixarParcela_Click_1(object sender, EventArgs e)
        {
            var selecionadas = ObterParcelasSelecionadas();
            if (!selecionadas.Any())
            {
                Utilitario.Mensagens.Aviso("Por favor, marque a caixa de seleção ao lado para escolher ao menos uma parcela");

                return;
            }

            // Converte para List<dynamic> apenas para compatibilidade
            var selecionadasDto = selecionadas.ToList();

            decimal totalParcelas = selecionadas.Sum(p => p.ValorParcela);
            decimal totalRecebido = selecionadas.Sum(p => p.ValorRecebido);
            decimal saldoTotal = selecionadas.Sum(p => p.Saldo);
            string nomeCliente = selecionadas[0].NomeCliente ?? string.Empty;

            using var frm = new FrmBaixarParcela();
            frm.Text = nomeCliente;
            frm.lblInfo.Text = selecionadas.Count == 1
                ? nomeCliente : "Múltiplas parcelas selecionadas";

            // Passa a versão dynamic
            frm.CarregarDados(selecionadasDto, nomeCliente, totalParcelas, totalRecebido, saldoTotal);

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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEstornarPagamento_Click(object sender, EventArgs e)
        {
            var selecionadas = ObterParcelasSelecionadas();

            // 🔴 CORREÇÃO: Verifica se há exatamente UMA parcela selecionada
            if (selecionadas.Count == 0)
            {
                Utilitario.Mensagens.Aviso("Selecione uma parcela para estornar.");
                return;
            }

            // 🔴 NOVA VERIFICAÇÃO: Bloqueia se mais de uma parcela estiver selecionada
            if (selecionadas.Count > 1)
            {
                Utilitario.Mensagens.Aviso("Selecione apenas UMA parcela para estornar.");
                return;
            }

            // Agora temos certeza que é apenas uma parcela
            var parcela = selecionadas.First();

            // Verifica se a parcela tem valor recebido > 0
            if ((decimal)parcela.ValorRecebido <= 0)
            {
                Utilitario.Mensagens.Aviso("Esta parcela não possui pagamentos para estornar.");
                return;
            }

            // Form para informar o valor e motivo
            using (var frm = new FrmEstornarPagamento())
            {
                // 🔴 AJUSTE: Passa apenas o ID da única parcela
                frm.CarregarDados(new List<long> { (long)parcela.ParcelaID },
                    parcela.NomeCliente ?? "Cliente"
                );

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var bll = new ParcelaBLL();

                        // 🔴 AGORA ESTORNA APENAS A PARCELA ÚNICA
                        bll.EstornarPagamento(
                            (long)parcela.ParcelaID,
                            frm.ValorEstorno,
                            frm.Motivo
                        );

                        Utilitario.Mensagens.Info("Estorno realizado com sucesso!");
                        CarregarContasAReceber(); // atualiza o grid
                    }
                    catch (Exception ex)
                    {
                        Utilitario.Mensagens.Erro("Erro ao estornar: " + ex.Message);
                    }
                }
            }
        }
    }
}
