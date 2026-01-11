using GVC.BLL;
using GVC.Model;
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
    public partial class FrmReport : KryptonForm
    {
        private readonly List<ContaAReceberDTO> _dadosGrid;
        private readonly ContaAReceberDTO _linhaSelecionada;

        public FrmReport(List<ContaAReceberDTO> dadosGrid, ContaAReceberDTO linhaSelecionada)
        {
            InitializeComponent();

            _dadosGrid = dadosGrid ?? new();
            _linhaSelecionada = linhaSelecionada;
            AtualizarHabilitacao();

            WireEvents();
        }
        // =========================
        // INICIALIZAÇÃO
        // =========================
        private void InicializarEstadoPadrao()
        {
            rbExtratoCliente.Checked = true;
            rbExtratoSimples.Checked = true;

            rbPDF.Checked = true;

            AtualizarHabilitacao();
        }

        private void WireEvents()
        {
            rbExtratoCliente.CheckedChanged += (_, __) => AtualizarHabilitacao();
            rbContasReceber.CheckedChanged += (_, __) => AtualizarHabilitacao();

            btnGerar.Click += btnGerar_Click;
            btnCancelar.Click += (_, __) => Close();
        }

        private void AtualizarHabilitacao()
        {
            grpExtratoCliente.Visible = rbExtratoCliente.Checked;
            grpContasReceber.Visible = rbContasReceber.Checked;
        }

        // =========================
        // EXTRATO CLIENTE
        // =========================
        private void GerarExtratoCliente()
        {
            if (_linhaSelecionada == null)
                throw new Exception("Selecione uma linha para gerar extrato do cliente.");

            var extratoBLL = new ExtratoBLL();

            bool detalhado = rbExtratoDetalhado.Checked;

            ExtratoCliente extrato =
                extratoBLL.ObterExtratoClientePorVenda(
                    _linhaSelecionada.VendaID,
                    detalhado);

            if (rbPDF.Checked)
            {
                SalvarArquivo("PDF (*.pdf)|*.pdf", ".pdf", caminho =>
                {
                    var empresa = new EmpresaBll().ObterDadosParaPdf();
                    PDFGenerator.GerarExtratoPDF(extrato, empresa, caminho);
                });
            }
            else
            {
                throw new Exception("Extrato de cliente em Excel ainda não habilitado.");
            }
        }

        // =========================
        // CONTAS A RECEBER
        // =========================
        private void GerarContasReceber()
        {
            if (!rbAgrupadoCliente.Checked)
                throw new Exception("Selecione o tipo de relatório.");

            if (_dadosGrid == null || !_dadosGrid.Any())
                throw new Exception("Não há dados no grid.");

            var extratoBLL = new ExtratoBLL();
            var extratos =
                extratoBLL.ObterContasPendentesAgrupadasPorCliente(_dadosGrid);

            if (!extratos.Any())
                throw new Exception("Não há contas pendentes.");

            if (rbPDF.Checked)
            {
                SalvarArquivo("PDF (*.pdf)|*.pdf", ".pdf", caminho =>
                {
                    var empresa = new EmpresaBll().ObterDadosParaPdf();
                    PDFGenerator.GerarContasReceberAgrupadoPorCliente(
                        extratos, empresa, caminho);
                });
            }
            else
            {
                SalvarArquivo("Excel (*.xlsx)|*.xlsx", ".xlsx", caminho =>
                {
                    ExcelGenerator.GerarContasReceberAgrupadoPorClienteExcel(
                        extratos, caminho);
                });
            }
        }

        // =========================
        // HELPERS
        // =========================
        private void SalvarArquivo(
            string filtro,
            string extensao,
            Action<string> gerar)
        {
            using var sfd = new SaveFileDialog
            {
                Filter = filtro,
                FileName = $"Relatorio_{DateTime.Now:yyyyMMdd_HHmmss}{extensao}"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            gerar(sfd.FileName);

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = sfd.FileName,
                UseShellExecute = true
            });

            Close();
        }
        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbExtratoCliente.Checked)
                {
                    GerarExtratoCliente();
                    return;
                }

                if (rbContasReceber.Checked)
                {
                    GerarContasReceber();
                    return;
                }

                Utilitario.Mensagens.Aviso("Selecione um tipo de relatório.");
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRelatoriosFinanceiros_Shown(object sender, EventArgs e)
        {
            rbExtratoCliente.Checked = true;
            rbExtratoSimples.Checked = true;
            rbPDF.Checked = true;

            AtualizarHabilitacao();
        }

        // =========================
        // GERAR RELATÓRIO
        // =========================


    }
}
