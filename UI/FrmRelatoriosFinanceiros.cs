using GVC.BLL;
using GVC.DAL;
using GVC.Model;
using GVC.Model.Enums.GVC.Model.Enums;
using GVC.UTIL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GVC.View
{
    public partial class FrmRelatoriosFinanceiros : KryptonForm
    {
        private bool _ignorandoBuscar = false;
        private bool _ignorarEventosBusca = false;
        private int ClienteID { get; set; }
        private string NomeCliente { get; set; }
        public FrmRelatoriosFinanceiros()
        {
            InitializeComponent();
            WireEvents();
        }
        // =========================
        // EVENTOS
        // =========================
        private void WireEvents()
        {
            rbContasReceber.CheckedChanged += (_, __) => AtualizarEstadoTela();
            rbContasPorCliente.CheckedChanged += (_, __) => AtualizarEstadoTela();

            btnLimpar.Click += (_, __) => LimparFiltros();
            btnSair.Click += (_, __) => Close();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            // Estado inicial seguro
            rbContasReceber.Checked = true;
            chkAgruparCliente.Checked = true;

            chkPendentes.Checked = true;

            rbPDF.Checked = true;

            AtualizarEstadoTela();
        }

        // =========================
        // LÓGICA DE HABILITAÇÃO
        // =========================
        private void AtualizarEstadoTela()
        {
            // Agrupamento só faz sentido em Contas a Receber
            chkAgruparCliente.Enabled = rbContasReceber.Checked;

            if (!rbContasReceber.Checked)
                chkAgruparCliente.Checked = false;

            // STATUS NUNCA são desabilitados
            chkPendentes.Enabled = true;
            chkPagas.Enabled = true;
            chkAtrasadas.Enabled = true;
            chkAgruparCliente.Enabled = true;
        }


        // =========================
        // LIMPAR
        // =========================
        private void LimparFiltros()
        {
            txtCliente.Clear();

            chkPendentes.Checked = false;
            chkPagas.Checked = false;
            chkAtrasadas.Checked = false;

            rbContasReceber.Checked = true;
            chkAgruparCliente.Checked = true;

            rbPDF.Checked = true;
        }
        private List<EnumStatusParcela> ObterStatusSelecionados()
        {
            var lista = new List<EnumStatusParcela>();

            if (chkPendentes.Checked)
                lista.Add(EnumStatusParcela.Pendente);

            if (chkParcialmentePago.Checked)
                lista.Add(EnumStatusParcela.ParcialmentePago); // 🔴 ESSENCIAL

            if (chkPagas.Checked)
                lista.Add(EnumStatusParcela.Pago);

            if (chkAtrasadas.Checked)
                lista.Add(EnumStatusParcela.Atrasada);

            return lista;
        }



        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                // ===============================
                // 1️⃣ CLIENTE (OPCIONAL)
                // ===============================
                int? clienteId = null;

                if (txtCliente.Tag != null &&
                    int.TryParse(txtCliente.Tag.ToString(), out int id))
                {
                    clienteId = id;
                }

                // ===============================
                // 2️⃣ PERÍODO
                // ===============================
                DateTime dataInicio = dtpInicio.Value.Date;
                DateTime dataFim = dtpFim.Value.Date;

                if (dataInicio > dataFim)
                {
                    Utilitario.Mensagens.Aviso(
                        "A data inicial não pode ser maior que a data final.");
                    return;
                }

                // ===============================
                // 3️⃣ STATUS
                // ===============================
                var statusSelecionados = ObterStatusSelecionados();

                if (!statusSelecionados.Any())
                {
                    Utilitario.Mensagens.Aviso(
                        "Selecione ao menos um status.");
                    return;
                }

                // ===============================
                // 4️⃣ TÍTULO DO RELATÓRIO
                // ===============================
                bool somentePagos = statusSelecionados
                    .All(s => s == EnumStatusParcela.Pago);

                string titulo;

                if (somentePagos)
                {
                    titulo = chkAgruparCliente.Checked
                        ? "Relatório de Contas Pagas Agrupado por Cliente"
                        : "Relatório de Contas Pagas por Cliente";
                }
                else
                {
                    titulo = chkAgruparCliente.Checked
                        ? "Relatório de Contas a Receber Agrupado por Cliente"
                        : "Relatório de Contas por Cliente";
                }

                // ===============================
                // 5️⃣ BUSCA DOS DADOS (BLL)
                // ===============================
                var extratoBLL = new ExtratoBLL();

                var resultado = extratoBLL.ObterRelatorioContasReceber(
                    clienteId,
                    dataInicio,
                    dataFim,
                    statusSelecionados);

                if (resultado == null || resultado.Count == 0)
                {
                    Utilitario.Mensagens.Info(
                        "Nenhum dado encontrado para os filtros selecionados.");
                    return;
                }

                // ===============================
                // 6️⃣ SAÍDA (PDF / EXCEL)
                // ===============================
                using var sfd = new SaveFileDialog
                {
                    Filter = rbPDF.Checked
                        ? "PDF (*.pdf)|*.pdf"
                        : "Excel (*.xlsx)|*.xlsx",
                    FileName = $"Relatorio_{DateTime.Now:yyyyMMdd_HHmmss}"
                };

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                if (rbPDF.Checked)
                {
                    var empresa = new EmpresaBll().ObterDadosParaPdf();

                    PDFGenerator.GerarRelatorioPorCliente(
                        resultado,
                        empresa,
                        titulo,
                        sfd.FileName);
                }
                else
                {
                    ExcelGenerator.GerarContasReceberAgrupadoPorClienteExcel(
                        resultado,
                        sfd.FileName);
                }

                Utilitario.Mensagens.Info("Relatório gerado com sucesso!");

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = sfd.FileName,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro(
                    $"Erro ao gerar relatório: {ex.Message}");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (_ignorarEventosBusca || _ignorandoBuscar)
                return;

            var texto = txtCliente.Text.Trim();
            if (string.IsNullOrEmpty(texto))
                return;

            using (var pesquisaCliente = new FrmLocalizarCliente(this, texto))
            {
                // Calcula posição logo abaixo do TextBox
                var textBoxLocation = txtCliente.PointToScreen(Point.Empty);

                pesquisaCliente.StartPosition = FormStartPosition.Manual;
                pesquisaCliente.Location = new Point(
                    textBoxLocation.X,
                    textBoxLocation.Y + txtCliente.Height
                );

                // 🔑 Ajusta largura do formulário para acompanhar o TextBox
                pesquisaCliente.Width = txtCliente.Width;

                if (pesquisaCliente.ShowDialog() == DialogResult.OK)
                {
                    _ignorandoBuscar = true;
                    try
                    {
                        ClienteID = pesquisaCliente.ClienteID;
                        txtCliente.Text = pesquisaCliente.ClienteSelecionado;
                        txtCliente.Tag = ClienteID; // 🔴 ESSENCIAL
                        NomeCliente = pesquisaCliente.ClienteSelecionado;


                    }
                    finally
                    {
                        _ignorandoBuscar = false;
                    }
                }
            }           
        }
    }
}
