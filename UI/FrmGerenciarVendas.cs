using GVC.BLL;
using GVC.DAL;
using GVC.DTO;
using GVC.Infra.Conexao;
using GVC.UTIL;
using Krypton.Toolkit;
using Microsoft.Data.SqlClient;
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
    public partial class FrmGerenciarVendas : KryptonForm
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ClienteID { get; set; }
        public FrmGerenciarVendas()
        {
            InitializeComponent();
        }

        private int ObterVendaSelecionada()
        {
            if (dgvVendas.CurrentRow == null)
                return 0;

            // nome EXATO da coluna do grid/datasource
            var cell = dgvVendas.CurrentRow.Cells["VendaID"]?.Value;

            if (cell == null || cell == DBNull.Value)
                return 0;

            return Convert.ToInt32(cell);
        }

        private void CarregarVendas()
        {
            long? vendaId = null;

            if (!string.IsNullOrWhiteSpace(txtVendaID.Text))
            {
                if (long.TryParse(txtVendaID.Text, out var id))
                    vendaId = id;
                else
                {
                    KryptonMessageBox.Show("VendaID inválido.", "Aviso",
                        MessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                    return;
                }
            }

            var bll = new VendaBLL();

            var dt = bll.ListarVendasParaGrid(
                vendaId,
                txtCliente.Text,
                dtpDataInicio.Value.Date,
                dtpDataFim.Value.Date.AddDays(1)
            );

            dgvVendas.DataSource = dt;
            FormatarGridVendas();
        }

        private void FormatarGridVendas()
        {
            if (dgvVendas.Columns.Count == 0) return;

            // ===============================
            // Cabeçalhos
            // ===============================
            dgvVendas.Columns["VendaID"].HeaderText = "Venda";
            dgvVendas.Columns["Cliente"].HeaderText = "Cliente";
            dgvVendas.Columns["DataVenda"].HeaderText = "Data";
            dgvVendas.Columns["ValorTotal"].HeaderText = "Total";
            dgvVendas.Columns["Desconto"].HeaderText = "Desconto";
            dgvVendas.Columns["StatusVenda"].HeaderText = "Status";

            // ===============================
            // Colunas FIXAS
            // ===============================
            dgvVendas.Columns["VendaID"].Width = 60;
            dgvVendas.Columns["DataVenda"].Width = 100;
            dgvVendas.Columns["ValorTotal"].Width = 110;
            dgvVendas.Columns["Desconto"].Width = 110;
            dgvVendas.Columns["StatusVenda"].Width = 140;

            // ===============================
            // Coluna Cliente FLEXÍVEL
            // ===============================
            dgvVendas.Columns["Cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvVendas.Columns["Cliente"].MinimumWidth = 200;

            // ===============================
            // Formatação
            // ===============================
            dgvVendas.Columns["DataVenda"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvVendas.Columns["ValorTotal"].DefaultCellStyle.Format = "C2";
            dgvVendas.Columns["Desconto"].DefaultCellStyle.Format = "C2";

            dgvVendas.Columns["VendaID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVendas.Columns["ValorTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVendas.Columns["Desconto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVendas.Columns["StatusVenda"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // ===============================
            // Grid
            // ===============================
            dgvVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVendas.MultiSelect = false;
            dgvVendas.ReadOnly = true;
            dgvVendas.AllowUserToResizeColumns = false;
            dgvVendas.AllowUserToResizeRows = false;
            dgvVendas.RowHeadersVisible = false;
            dgvVendas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            // ===============================
            // Evento Status (remove duplicação)
            // ===============================
            dgvVendas.CellFormatting -= dgvVendas_CellFormatting;
            dgvVendas.CellFormatting += dgvVendas_CellFormatting;
        }

     
        private void FrmGerenciarVendas_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

            dtpDataInicio.Value = DateTime.Today.AddMonths(-1);
            dtpDataFim.Value = DateTime.Today;
            CarregarVendas();
            dgvVendas.CellDoubleClick -= dgvVendas_CellDoubleClick;
            dgvVendas.CellDoubleClick += dgvVendas_CellDoubleClick;

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            // SALVA O TEXTO ATUAL ANTES DE PERDER O FOCO
            string textoDigitado = txtCliente.Text;

            try
            {
                using (var pesquisaCliente = new FrmLocalizarCliente(this, textoDigitado))
                {
                    pesquisaCliente.Owner = this;

                    if (pesquisaCliente.ShowDialog() == DialogResult.OK)
                    {
                        txtCliente.Text = pesquisaCliente.ClienteSelecionado;
                        ClienteID = pesquisaCliente.ClienteID;
                        txtCliente.SelectionStart = txtCliente.Text.Length;

                    }
                }
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso(ex.Message);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregarVendas();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                int vendaId = ObterVendaSelecionada();

                if (vendaId <= 0)
                {
                    KryptonMessageBox.Show(
                        "Selecione uma venda válida no grid.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        KryptonMessageBoxIcon.Warning);
                    return;
                }

                // ✅ valida existência antes de montar tela bonita
                var bll = new VendaBLL();
                var venda = bll.ObterVendaPorId(vendaId);

                if (venda == null)
                {
                    KryptonMessageBox.Show(
                        $"A venda #{vendaId} não existe (ou não é desta empresa). Recarregue a lista.",
                        "Venda não encontrada",
                        MessageBoxButtons.OK,
                        KryptonMessageBoxIcon.Warning);
                    CarregarVendas();
                    return;
                }

                // =============================================
                // PASSO 1: Buscar dados da venda
                // =============================================                
                var dados = bll.ObterDadosParaExclusao(vendaId);

                // =============================================
                // PASSO 2: Verificar se pode excluir
                // =============================================
                if (!dados.PodeExcluir)
                {
                    string msgBloqueio = $@"
╔══════════════════════════════════════════════╗
║        EXCLUSÃO BLOQUEADA                    ║
╚══════════════════════════════════════════════╝

❌ NÃO É POSSÍVEL EXCLUIR ESTA VENDA!

Motivo: A venda possui parcelas com pagamentos registrados.
Total já recebido: {dados.TotalPago:C2}

Alternativas:
1️⃣ CANCELE a venda (devolve estoque e cancela parcelas)
2️⃣ ESTORNE os pagamentos primeiro
3️⃣ Use a opção de CANCELAMENTO (não exclui, só cancela)

A exclusão definitiva só é permitida para vendas:
• SEM parcelas pagas
• Com todas as parcelas pendentes ou canceladas";

                    KryptonMessageBox.Show(
                        msgBloqueio,
                        "Exclusão Bloqueada",
                        MessageBoxButtons.OK,
                        KryptonMessageBoxIcon.Warning);
                    return;
                }

                // =============================================
                // PASSO 3: Construir mensagem detalhada
                // =============================================
                StringBuilder mensagem = new StringBuilder();
                mensagem.AppendLine("╔══════════════════════════════════════════════╗");
                mensagem.AppendLine("║        CONFIRMAÇÃO DE EXCLUSÃO DE VENDA     ║");
                mensagem.AppendLine("╚══════════════════════════════════════════════╝");
                mensagem.AppendLine();
                mensagem.AppendLine($"📋 DADOS DA VENDA #{dados.VendaID}:");
                mensagem.AppendLine($"   Cliente: {dados.ClienteNome} (ID: {dados.ClienteID})");
                mensagem.AppendLine($"   Data: {dados.DataVenda:dd/MM/yyyy HH:mm}");
                mensagem.AppendLine($"   Valor Total: {dados.ValorTotal:C2}");
                mensagem.AppendLine();
                mensagem.AppendLine($"📊 ITENS DA VENDA ({dados.QuantidadeItens}):");

                foreach (var produto in dados.Produtos.Take(5))
                    mensagem.AppendLine($"   • {produto}");

                if (dados.Produtos.Count > 5)
                    mensagem.AppendLine($"   ... e mais {dados.Produtos.Count - 5} produto(s)");

                mensagem.AppendLine();
                mensagem.AppendLine($"💰 PARCELAS ({dados.QuantidadeParcelas}):");
                mensagem.AppendLine($"   → Todas estão pendentes/canceladas");
                mensagem.AppendLine();
                mensagem.AppendLine("📌 ITENS QUE SERÃO EXCLUÍDOS:");
                mensagem.AppendLine("   • A venda");
                mensagem.AppendLine("   • Todos os itens da venda");
                mensagem.AppendLine("   • Todas as parcelas");
                mensagem.AppendLine("   • Todos os pagamentos (se houver)");
                mensagem.AppendLine();
                mensagem.AppendLine("⚠️  O CLIENTE NÃO SERÁ EXCLUÍDO!");
                mensagem.AppendLine("   Apenas a venda e seus relacionados.");
                mensagem.AppendLine();
                mensagem.AppendLine("⚠️  ESTA AÇÃO É IRREVERSÍVEL!");
                mensagem.AppendLine();
                mensagem.AppendLine("Para confirmar, digite o número da venda abaixo:");
                mensagem.Append($"{dados.VendaID}");

                // =============================================
                // PASSO 4: Formulário de confirmação
                // =============================================
                Form confirmForm = new Form
                {
                    Text = "🔴 EXCLUSÃO DE VENDA",
                    Size = new Size(650, 700),
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    MinimizeBox = false,
                    BackColor = Color.White
                };

                TableLayoutPanel layout = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    Padding = new Padding(20),
                    RowCount = 5,
                    ColumnCount = 1,
                    BackColor = Color.White
                };

                RichTextBox txtMensagem = new RichTextBox
                {
                    Text = mensagem.ToString(),
                    ReadOnly = true,
                    BorderStyle = BorderStyle.None,
                    BackColor = Color.FromArgb(245, 245, 245),
                    Font = new Font("Consolas", 10),
                    Height = 500,
                    Dock = DockStyle.Fill
                };

                Label lblInstrucao = new Label
                {
                    Text = "Digite o número da venda para confirmar:",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold)
                };

                KryptonTextBox txtConfirmacao = new KryptonTextBox
                {
                    Width = 200,
                    Font = new Font("Segoe UI", 10),
                    TextAlign = HorizontalAlignment.Center
                };

                FlowLayoutPanel btnPanel = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.RightToLeft,
                    Dock = DockStyle.Fill,
                    Height = 50,
                    BackColor = Color.White
                };

                KryptonButton btnConfirmar = new KryptonButton
                {
                    Text = "🗑️  CONFIRMAR EXCLUSÃO",
                    Enabled = false,
                    Width = 200,
                    Height = 40,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold)
                };
                btnConfirmar.StateCommon.Back.Color1 = Color.FromArgb(192, 0, 0);
                btnConfirmar.StateCommon.Back.ColorStyle = PaletteColorStyle.Solid;
                btnConfirmar.StateCommon.Content.ShortText.Color1 = Color.White;

                KryptonButton btnCancelar = new KryptonButton
                {
                    Text = "❌  CANCELAR",
                    Width = 150,
                    Height = 40,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    DialogResult = DialogResult.Cancel
                };
                btnCancelar.StateCommon.Back.Color1 = Color.FromArgb(64, 64, 64);
                btnCancelar.StateCommon.Content.ShortText.Color1 = Color.White;

                txtConfirmacao.TextChanged += (s, ev) =>
                {
                    btnConfirmar.Enabled = txtConfirmacao.Text.Trim() == dados.VendaID.ToString();
                };

                btnConfirmar.Click += (s, ev) =>
                {
                    confirmForm.DialogResult = DialogResult.Yes;
                    confirmForm.Close();
                };

                btnPanel.Controls.Add(btnConfirmar);
                btnPanel.Controls.Add(btnCancelar);

                layout.Controls.Add(txtMensagem, 0, 0);
                layout.Controls.Add(lblInstrucao, 0, 1);
                layout.Controls.Add(txtConfirmacao, 0, 2);
                layout.Controls.Add(new Panel { Height = 10 }, 0, 3);
                layout.Controls.Add(btnPanel, 0, 4);

                confirmForm.Controls.Add(layout);

                if (confirmForm.ShowDialog(this) == DialogResult.Yes)
                {
                    btnExcluir.Enabled = false;
                    Cursor = Cursors.WaitCursor;

                    try
                    {
                        bll.ExcluirVendaCompleta(vendaId);

                        string resumo = $@"
✅ VENDA EXCLUÍDA COM SUCESSO!

📊 Resumo da exclusão:
• Venda #{dados.VendaID}
• Cliente: {dados.ClienteNome} (mantido no cadastro)
• Data: {dados.DataVenda:dd/MM/yyyy}
• {dados.QuantidadeItens} itens excluídos
• {dados.QuantidadeParcelas} parcelas excluídas
• Valor total: {dados.ValorTotal:C2}";

                        KryptonMessageBox.Show(
                            resumo,
                            "Exclusão Concluída",
                            MessageBoxButtons.OK,
                            KryptonMessageBoxIcon.Information);

                        CarregarVendas(); // Seu método para recarregar o grid
                    }
                    catch (Exception ex)
                    {
                        KryptonMessageBox.Show(
                            $"❌ Erro ao excluir venda: {ex.Message}",
                            "Erro",
                            MessageBoxButtons.OK,
                            KryptonMessageBoxIcon.Error);
                    }
                    finally
                    {
                        Cursor = Cursors.Default;
                        btnExcluir.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro($"Erro ao preparar exclusão: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            int vendaId = ObterVendaSelecionada();

            using (var frmMotivo = new FrmMotivoOperacao("Cancelamento de Venda"))
            {
                if (frmMotivo.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    new VendaBLL().CancelarVenda(vendaId, frmMotivo.Motivo);
                    Utilitario.Mensagens.Aviso("Venda cancelada com sucesso.");
                    CarregarVendas();
                }
                catch (Exception ex)
                {
                    Utilitario.Mensagens.Aviso(ex.Message);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            int vendaId = ObterVendaSelecionada();
            if (vendaId <= 0)
            {
                Utilitario.Mensagens.Aviso("Selecione uma venda para visualizar.");
                return;
            }

            try
            {
                var dto = new VendaBLL().ObterVendaParaVisualizacao(vendaId);
                AbrirFormVisualizacaoVenda(dto);
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro(ex.Message);
            }
        }
        private void VisualizarVendaSelecionada()
        {
            int vendaId = ObterVendaSelecionada();

            if (vendaId <= 0)
            {
                Utilitario.Mensagens.Aviso("Selecione uma venda válida.");
                return;
            }

            var bll = new VendaBLL();

            // ✅ CORRETO: DTO próprio para visualização
            var venda = bll.ObterVendaParaVisualizacao(vendaId);

            if (venda == null)
            {
                Utilitario.Mensagens.Aviso("Venda não encontrada.");
                CarregarVendas();
                return;
            }

            AbrirFormVisualizacaoVenda(venda);
        }
        private void AbrirFormVisualizacaoVenda(VendaVisualizacaoDTO venda)
        {
            var form = new KryptonForm
            {
                Text = $"Venda #{venda.VendaID} - Visualização",
                StartPosition = FormStartPosition.CenterParent,
                Size = new Size(950, 680),
                MinimumSize = new Size(850, 580)
            };

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(15),
                ColumnCount = 1,
                RowCount = 7
            };

            var lblTitulo = new Label
            {
                Text = $"VENDA #{venda.VendaID}",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                AutoSize = true
            };

            var lblCab = new Label
            {
                Text =
                    $"Cliente: {venda.ClienteNome} (ID {venda.ClienteID})\n" +
                    $"Data: {venda.DataVenda:dd/MM/yyyy HH:mm}\n" +
                    $"Status: {venda.StatusVenda}\n" +
                    $"Total: {venda.ValorTotal:C2}   |   Desconto: {venda.Desconto:C2}",
                Font = new Font("Segoe UI", 10),
                AutoSize = true
            };

            var lblItens = new Label
            {
                Text = $"Itens ({venda.Itens.Count})",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                AutoSize = true
            };

            var lstItens = new ListBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Consolas", 10),
                IntegralHeight = false,
                Height = 220
            };

            if (venda.Itens.Count == 0)
                lstItens.Items.Add("Sem itens.");
            else
            {
                foreach (var it in venda.Itens)
                {
                    lstItens.Items.Add(
                        $"{it.NomeProduto} (ID {it.ProdutoID}) | Qtd {it.Quantidade} | Unit {it.PrecoUnitario:C2} | Desc {it.DescontoItem:C2} | Sub {it.Subtotal:C2}");
                }
            }

            var lblParcelas = new Label
            {
                Text = $"Parcelas ({venda.Parcelas.Count})",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                AutoSize = true
            };

            var lstParcelas = new ListBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Consolas", 10),
                IntegralHeight = false,
                Height = 220
            };

            if (venda.Parcelas.Count == 0)
                lstParcelas.Items.Add("Sem parcelas.");
            else
            {
                foreach (var p in venda.Parcelas)
                {
                    var total = p.ValorParcela + p.Juros + p.Multa;
                    var saldo = total - p.ValorRecebido;

                    lstParcelas.Items.Add(
                        $"Parc {p.NumeroParcela} | Venc {p.DataVencimento:dd/MM/yyyy} | Total {total:C2} | Rec {p.ValorRecebido:C2} | Saldo {saldo:C2} | {p.Status}");
                }
            }

            var btnFechar = new KryptonButton { Text = "Fechar", Width = 120, Height = 35 };
            btnFechar.Click += (_, __) => form.Close();

            var pnlBtn = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.RightToLeft,
                Height = 45
            };
            pnlBtn.Controls.Add(btnFechar);

            layout.Controls.Add(lblTitulo, 0, 0);
            layout.Controls.Add(lblCab, 0, 1);
            layout.Controls.Add(lblItens, 0, 2);
            layout.Controls.Add(lstItens, 0, 3);
            layout.Controls.Add(lblParcelas, 0, 4);
            layout.Controls.Add(lstParcelas, 0, 5);
            layout.Controls.Add(pnlBtn, 0, 6);

            layout.RowStyles.Clear();
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            form.Controls.Add(layout);
            form.ShowDialog(this);
        }

        private void dgvVendas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                VisualizarVendaSelecionada();
        }

        private void dgvVendas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvVendas.Columns[e.ColumnIndex].Name == "StatusVenda" && e.Value != null)
            {
                string status = e.Value.ToString();

                if (status.Equals("Cancelada", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = Color.DarkRed;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (status.Equals("Aberta", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = Color.Orange;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else if (status.Equals("AguardandoPagamento", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = Color.Goldenrod;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else if (status.Equals("Concluida", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (status.Equals("Suspensa", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = Color.SlateGray;
                    e.CellStyle.ForeColor = Color.White;
                }
            }

        }
    }
}
