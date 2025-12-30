using Dapper;
using GVC.BLL;
using GVC.DAL;
using GVC.DALL;
using GVC.MODEL;
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
using ParcelaExtratoModel = GVC.MODEL.ParcelaExtrato;

namespace GVC.View
{
    public partial class FrmContasReceber : KryptonForm
    {
       

        private bool bloqueiaPesquisa = false;
        private readonly PagamentoParcialDal _pagamentoDal = new PagamentoParcialDal();
        public int ClienteID { get; set; }

        private readonly VendaBLL _vendaBll = new VendaBLL();
        private readonly ItensVendaBLL _itensVendaBll = new ItensVendaBLL();

        public FrmContasReceber()
        {
            InitializeComponent();
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
                ValueType = typeof(long),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorRecebido",
                HeaderText = "Recebido",
                Width = 100,
                ValueType = typeof(long),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvContasAReceber.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Saldo",
                HeaderText = "Saldo",
                Width = 100,
                ValueType = typeof(long),
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
                DataPropertyName = "FormaPgto",
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

            var lista = dal.ListarContasAReceber(
                cmbTipoPesquisa.Text,
                txtNomeCliente.Text,
                txtNumeroVenda.Text,
                dtpVencInicial.Value,
                dtpVencFinal.Value,
                cmbStatusParcela.Text
            );

            dgvContasAReceber.DataSource = lista;

            ConfigurarGridContasAReceber();
            AtualizarResumo(lista);
            AtualizarResumoGeral(lista);
            AtualizarTotalSelecionado();
            AtualizarParcelasAtrasadasNoBanco();
        }

        private void AtualizarResumo(IEnumerable<ContaAReceberDTO> dados)
        {
            decimal totalAberto = 0m;
            decimal totalVencido = 0m;
            decimal totalRecebido = 0m;

            foreach (var p in dados)
            {
                totalRecebido += p.ValorRecebido;
                if (p.StatusParcela == "Pendente" || p.StatusParcela == "Parcialmente Paga")
                    totalAberto += p.Saldo;
                if (p.StatusParcela == "Atrasada")
                    totalVencido += p.Saldo;
            }

            txtTotalVencido.Text = totalVencido.ToString("C2");
        }
        private void AtualizarCamposPorTipoPesquisa()
        {
            dgvContasAReceber.DataSource = null;
            lblNomeCliente.Visible = false;
            txtNomeCliente.Visible = false;
            lblNumeroVenda.Visible = false;
            txtNumeroVenda.Visible = false;
            lblVenctoInicial.Visible = false;
            dtpVencInicial.Visible = false;
            lblVenctoFinal.Visible = false;
            dtpVencFinal.Visible = false;
            lblStatusParcela.Visible = false;
            cmbStatusParcela.Visible = false;

            // Limpa valores opcionais
            txtNomeCliente.Clear();
            txtNumeroVenda.Clear();

            switch (cmbTipoPesquisa.Text)
            {
                case "Todos":
                    break;

                case "Nome do Cliente":
                    txtNomeCliente.Visible = true;
                    lblNomeCliente.Visible = true;
                    txtNomeCliente.Enabled = true;
                    txtNomeCliente.Focus();
                    btnPesquisar.Location = new Point(498, 21);
                    btnLimparFiltro.Location = new Point(595, 21);
                    break;

                case "Número da Venda":
                    txtNomeCliente.Visible = false;
                    lblNomeCliente.Visible = false;
                    txtNomeCliente.Enabled = false;
                    txtNumeroVenda.Visible = true;
                    lblNumeroVenda.Visible = true;
                    txtNumeroVenda.Focus();
                    btnPesquisar.Location = new Point(248, 21);
                    btnLimparFiltro.Location = new Point(345, 21);
                    break;

                case "Data da Venda":
                    txtNomeCliente.Visible = false;
                    lblNomeCliente.Visible = false;
                    txtNomeCliente.Enabled = false;
                    dtpVencInicial.Visible = true;
                    lblVenctoInicial.Visible = true;
                    btnPesquisar.Location = new Point(302, 21);
                    btnLimparFiltro.Location = new Point(399, 21);
                    break;

                case "Período da Venda":
                    txtNomeCliente.Visible = false;
                    lblNomeCliente.Visible = false;
                    txtNomeCliente.Enabled = false;
                    lblVenctoInicial.Visible = true;
                    dtpVencInicial.Visible = true;
                    lblVenctoFinal.Visible = true;
                    dtpVencFinal.Visible = true;
                    btnPesquisar.Location = new Point(399, 21);
                    btnLimparFiltro.Location = new Point(496, 21);
                    break;

                case "Vencimento":
                    txtNomeCliente.Visible = false;
                    lblNomeCliente.Visible = false;
                    txtNomeCliente.Enabled = false;
                    lblVenctoInicial.Visible = true;
                    dtpVencInicial.Visible = true;
                    btnPesquisar.Location = new Point(302, 21);
                    btnLimparFiltro.Location = new Point(399, 21);
                    break;

                case "Período de Vencimento":
                    txtNomeCliente.Visible = false;
                    lblNomeCliente.Visible = false;
                    txtNomeCliente.Enabled = false;
                    lblVenctoInicial.Visible = true;
                    dtpVencInicial.Visible = true;
                    lblVenctoFinal.Visible = true;
                    dtpVencFinal.Visible = true;
                    btnPesquisar.Location = new Point(399, 21);
                    btnLimparFiltro.Location = new Point(496, 21);
                    break;

                case "Status da Parcela":
                    txtNomeCliente.Visible = false;
                    lblNomeCliente.Visible = false;
                    txtNomeCliente.Enabled = false;
                    lblStatusParcela.Visible = true;
                    cmbStatusParcela.Visible = true;
                    btnPesquisar.Location = new Point(302, 21);
                    btnLimparFiltro.Location = new Point(399, 21);
                    break;
            }
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
            
            cmbTipoPesquisa.SelectedIndex = 0;
            
            
            ConfigurarGridContasAReceber();
            ConfigurarGridPagamentos(); // 🔴 ESSENCIAL
            AtualizarParcelasAtrasadasNoBanco(); // ← Atualiza ao abrir  
            txtNomeCliente.Visible = false;
            lblNomeCliente.Visible = false;
            txtNomeCliente.Enabled = false;
        }

        private void cmbTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarCamposPorTipoPesquisa();
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
            decimal totalSelecionado = selecionadas.Sum(p => p.Saldo);
            lblTotalSelecionado.Text = totalSelecionado.ToString("C2");
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
            var aReceber = dados.Where(p =>
                p.StatusParcela == "Pendente" ||
                p.StatusParcela == "Parcialmente Paga" ||
                p.StatusParcela == "Atrasada" ||
                p.StatusParcela == "Em Cobrança" ||
                p.StatusParcela == "Renegociada");

            int qtdAReceber = aReceber.Count();
            decimal totalAReceber = aReceber.Sum(p => p.Saldo);

            var pagas = dados.Where(p =>
                p.StatusParcela == "Paga" ||
                p.StatusParcela == "Parcialmente Paga");

            int qtdPagas = pagas.Count();
            decimal totalPagas = pagas.Sum(p => p.ValorRecebido);

            lblQtdContasPagas.Text = qtdPagas.ToString();
            lblTotalContasPagas.Text = totalPagas.ToString("C2");
            lblQtdeContasReceber.Text = qtdAReceber.ToString();
            lblTotalContasReceber.Text = totalAReceber.ToString("C2");

            lblTotalContasReceber.ForeColor = totalAReceber > 0m ? Color.Red : Color.Gray;
            lblTotalContasPagas.ForeColor = Color.ForestGreen;
        }

        private void AtualizarParcelasAtrasadasNoBanco()
        {
            try
            {
                // ✅ Query ajustada para SQL Server
                const string sql = @" UPDATE Parcela SET Status = 'Atrasada' WHERE DataVencimento < CAST(GETDATE() AS DATE)
                                      AND Status NOT IN ('Paga', 'Parcialmente Paga', 'Cancelada', 'Atrasada')";

                using (var conn = Helpers.Conexao.Conex())
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

        private void CarregarVenda(long vendaId)
        {
            var venda = _vendaBll.ObterVendaPorId((int)vendaId);

            if (venda == null)
            {
                LimparAreaVenda();
                return;
            }
            // Busca nome do cliente se necessário
            if (string.IsNullOrEmpty(venda.NomeCliente) && venda.ClienteID > 0)
            {
                string query = "SELECT Nome FROM Clientes WHERE ClienteID = @id";
                venda.NomeCliente = Utilitario.PesquisarPorCodigoRetornarNome(query, "id", venda.ClienteID);
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
                        // Gerar o PDF
                        GVC.UTIL.PDFGenerator.GerarExtratoPDF(extrato, saveDialog.FileName);

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
            var extrato = ObterExtratoCliente(true);
            if (extrato == null) return;

            // Converte para dynamic apenas para compatibilidade com PDFGenerator
            var parcelasDynamic = parcelasSelecionadas.Cast<dynamic>().ToList();

            using var saveDialog = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Salvar Recibo",
                FileName = $"Recibo_{RemoveCaracteresInvalidos(extrato.NomeCliente)}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                GVC.UTIL.PDFGenerator.GerarReciboPDF(extrato, parcelasDynamic, saveDialog.FileName);

                var resultado = MessageBox.Show(
                    $"Recibo gerado com sucesso!\nArquivo: {Path.GetFileName(saveDialog.FileName)}\nPasta: {Path.GetDirectoryName(saveDialog.FileName)}\nDeseja abrir o arquivo agora?",
                    "Sucesso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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

            using var conn = Helpers.Conexao.Conex();

            var ids = parcelas.Select(p => p.ParcelaID).ToArray();

            string sql = @"
        SELECT
            pp.PagamentoID,
            pp.ParcelaID,
            pp.DataPagamento,
            pp.ValorPago,
            fp.FormaPgto AS FormaPagamento,
            pp.Observacao
        FROM PagamentosParciais pp
        LEFT JOIN FormaPgto fp ON fp.FormaPgtoID = pp.FormaPgtoID
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarContasAReceber();
        }

        private void LimparFiltro_Click(object sender, EventArgs e)
        {
            cmbTipoPesquisa.SelectedIndex = 0;
            cmbStatusParcela.SelectedIndex = 0;
            AtualizarCamposPorTipoPesquisa();
            CarregarContasAReceber(); // vai chamar AtualizarResumoGeral automaticamente
            AtualizarCamposPorTipoPesquisa();
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaixarParcela_Click(object sender, EventArgs e)
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
            frm.txtClienteNome.Text = nomeCliente;
            frm.lblInfo.Text = selecionadas.Count == 1
                ? nomeCliente
                : "Múltiplas parcelas selecionadas";

            // Passa a versão dynamic
            frm.CarregarDados(selecionadasDto, nomeCliente, totalParcelas, totalRecebido, saldoTotal);

            if (frm.ShowDialog() == DialogResult.OK)
                CarregarContasAReceber();
        }
        private void ConfigurarGridPagamentos()
        {
            dgvPagamentos.AutoGenerateColumns = false;
            dgvPagamentos.Columns.Clear();

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
                Width = 250
            });

            dgvPagamentos.ReadOnly = true;
            dgvPagamentos.AllowUserToAddRows = false;
            dgvPagamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnExtratoRecibo_Click(object sender, EventArgs e)
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
                        // Pergunta se será detalhado
                        var opcao = MessageBox.Show(
                            "Deseja o extrato DETALHADO (com pagamentos)?\n\n" +
                            "SIM = Detalhado\nNÃO = Resumido",
                            "Tipo de Extrato",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        bool detalhado = opcao == DialogResult.Yes;
                        GerarExtratoCompleto(detalhado);
                    }

                    else if (resultado == DialogResult.No && temCheckboxMarcado)
                    {
                        GerarReciboPagamentos();
                    }
                    else if ((resultado == DialogResult.Yes && !temLinhaSelecionada) ||
                             (resultado == DialogResult.No && !temCheckboxMarcado))
                    {
                        Utilitario.Mensagens.Aviso("Esta opção não está disponível no momento.");
                    }
                    // Se for DialogResult.Cancel, não faz nada
                }
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro($"Erro: {ex.Message}");
            }
        }
      
        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            cmbTipoPesquisa.SelectedIndex = 0;
            cmbStatusParcela.SelectedIndex = 0;
            AtualizarCamposPorTipoPesquisa();
            CarregarContasAReceber(); // vai chamar AtualizarResumoGeral automaticamente
            AtualizarCamposPorTipoPesquisa();
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

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            var pagamentos = ObterPagamentosDoGrid();

            if (!pagamentos.Any())
            {
                Utilitario.Mensagens.Aviso("Nenhum pagamento encontrado para gerar recibo.");
                return;
            }

            var extrato = ObterExtratoCliente(true);
            if (extrato == null)
                return;

            using var saveDialog = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Salvar Recibo",
                FileName = $"Recibo_{RemoveCaracteresInvalidos(extrato.NomeCliente)}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
            };

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            // 🔹 Gera o PDF
            PDFGenerator.GerarReciboPagamentos(extrato, pagamentos, saveDialog.FileName);

            // 🔹 CONFIRMAÇÃO PARA ABRIR
            var resultado = MessageBox.Show(
                $"Recibo gerado com sucesso!\n\n" +
                $"Arquivo: {Path.GetFileName(saveDialog.FileName)}\n" +
                $"Pasta: {Path.GetDirectoryName(saveDialog.FileName)}\n\n" +
                $"Deseja abrir o arquivo agora?",
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
}
