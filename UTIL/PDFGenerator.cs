using GVC.Model;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GVC.UTIL
{
    public static class PDFGenerator
    {
        public static void GerarRelatorioContasPorCliente(
    List<ExtratoCliente> extratos,
    DadosEmpresaPdf empresa,
    string caminhoArquivo)
        {

        }

        // =========================
        // EXTRATO FINANCEIRO
        // =========================
        public static void GerarExtratoPDF(
            ExtratoCliente extrato,
            DadosEmpresaPdf empresa,
            string caminhoArquivo)
        {
            Validar(extrato, empresa);

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    ConfigurarPagina(page);

                    page.Content().Column(col =>
                    {
                        AdicionarCabecalho(col, empresa, "EXTRATO FINANCEIRO");
                        AdicionarDadosCliente(col, extrato);
                        AdicionarTabelaExtrato(col, extrato);
                        AdicionarResumoExtrato(col, extrato);
                        AdicionarRodape(col);
                    });
                });
            })
            .GeneratePdf(caminhoArquivo);
        }

        // =========================
        // RECIBO COM HISTÓRICO
        // =========================
        public static void GerarReciboPagamentos(
            ExtratoCliente extrato,
            List<PagamentoExtratoModel> pagamentos,
            DadosEmpresaPdf empresa,
            string caminhoArquivo)
        {
            Validar(extrato, empresa);

            if (pagamentos == null || pagamentos.Count == 0)
                throw new Exception("Nenhum pagamento encontrado.");

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    ConfigurarPagina(page);

                    page.Content().Column(col =>
                    {
                        AdicionarCabecalho(col, empresa, "RECIBO DE PAGAMENTO");
                        AdicionarDadosCliente(col, extrato);
                        AdicionarTabelaPagamentos(col, pagamentos);
                        AdicionarTotalPagamentos(col, pagamentos);
                        AdicionarAssinatura(col);
                        AdicionarRodape(col);
                    });
                });
            })
            .GeneratePdf(caminhoArquivo);
        }

        // =========================
        // NOVO: CONTAS A RECEBER AGRUPADO POR CLIENTE
        // =========================
        public static void GerarContasReceberAgrupadoPorCliente(
            List<ExtratoCliente> extratos,
            DadosEmpresaPdf empresa,
            string caminhoArquivo)
        {
            if (extratos == null || extratos.Count == 0)
                throw new Exception("Nenhum dado para gerar o relatório.");

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    ConfigurarPagina(page);

                    page.Content().Column(col =>
                    {
                        AdicionarCabecalho(
                            col,
                            empresa,
                            "Relatório de Contas a Receber Agrupado por Cliente");

                        decimal totalGeral = 0m;

                        foreach (var extrato in extratos)
                        {
                            col.Item().PaddingTop(10)
                                .Text(extrato.NomeCliente)
                                .Bold();

                            col.Item().Table(table =>
                            {
                                table.ColumnsDefinition(c =>
                                {
                                    c.RelativeColumn(); // Venda
                                    c.RelativeColumn(); // Documento
                                    c.RelativeColumn(); // Vencimento
                                    c.RelativeColumn(); // Situação
                                    c.RelativeColumn(); // Saldo
                                });

                                Header(table,
                                    "Venda",
                                    "Documento",
                                    "Vencimento",
                                    "Situação",
                                    "Saldo");

                                foreach (var item in extrato.ItensExtrato)
                                {
                                    Row(table,
                                        item.VendaID,
                                        item.ParcelaID,
                                        item.DataVencimento.ToString("dd/MM/yyyy"),
                                        item.Status,
                                        item.Saldo.ToString("C2"));
                                }
                            });

                            col.Item()
                                .AlignRight()
                                .PaddingTop(5)
                                .Text($"Total do cliente: {extrato.SaldoAtual:C2}")
                                .Bold();

                            totalGeral += extrato.SaldoAtual;
                        }

                        col.Item()
                            .PaddingTop(20)
                            .AlignRight()
                            .Text($"TOTAL GERAL: {totalGeral:C2}")
                            .FontSize(12)
                            .Bold();

                        AdicionarRodape(col);
                    });
                });
            })
            .GeneratePdf(caminhoArquivo);
        }

        // =========================
        // CONFIGURAÇÃO BASE
        // =========================
        private static void ConfigurarPagina(PageDescriptor page)
        {
            page.Size(PageSizes.A4);
            page.Margin(40);
            page.DefaultTextStyle(x => x.FontFamily("Helvetica").FontSize(10));
        }

        private static void Validar(ExtratoCliente extrato, DadosEmpresaPdf empresa)
        {
            if (extrato == null)
                throw new ArgumentNullException(nameof(extrato));
            if (empresa == null)
                throw new ArgumentNullException(nameof(empresa));
        }

        // =========================
        // COMPONENTES
        // =========================
        private static void AdicionarCabecalho(
            ColumnDescriptor col,
            DadosEmpresaPdf empresa,
            string titulo)
        {
            col.Item().Row(row =>
            {
                if (empresa.Logo != null && empresa.Logo.Length > 0)
                {
                    row.ConstantItem(90)
                       .Image(empresa.Logo)
                       .FitArea();
                }

                row.RelativeItem().AlignMiddle().Text(empresa.NomeEmpresa)
                    .FontSize(15)
                    .Bold();
            });

            col.Item().PaddingTop(10).AlignCenter().Text(titulo)
                .FontSize(15)
                .Bold();

            col.Item().PaddingBottom(15).LineHorizontal(1);
        }

        private static void AdicionarDadosCliente(
            ColumnDescriptor col,
            ExtratoCliente extrato)
        {
            col.Item().Text($"Cliente: {extrato.NomeCliente}").Bold();
            col.Item().Text($"Data de emissão: {extrato.DataEmissao:dd/MM/yyyy HH:mm}");
            col.Item().PaddingBottom(10);
        }

        private static void AdicionarTabelaExtrato(
            ColumnDescriptor col,
            ExtratoCliente extrato)
        {
            col.Item().Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                });

                Header(table,
                    "Venda", "Parcela", "Vencimento",
                    "Valor", "Recebido", "Saldo");

                foreach (var item in extrato.ItensExtrato)
                {
                    Row(table,
                        item.VendaID,
                        item.NumeroParcela,
                        item.DataVencimento.ToString("dd/MM/yyyy"),
                        item.ValorParcela.ToString("C2"),
                        item.ValorRecebido.ToString("C2"),
                        item.Saldo.ToString("C2"));
                }
            });
        }

        private static void AdicionarResumoExtrato(
            ColumnDescriptor col,
            ExtratoCliente extrato)
        {
            col.Item().PaddingTop(10)
                .Text($"Total pago: {extrato.TotalPago:C2}")
                .Bold();

            col.Item()
                .Text($"Total em aberto: {extrato.TotalDevendo:C2}")
                .Bold();
        }

        private static void AdicionarTabelaPagamentos(
            ColumnDescriptor col,
            List<PagamentoExtratoModel> pagamentos)
        {
            col.Item().Table(table =>
            {
                table.ColumnsDefinition(c =>
                {
                    c.RelativeColumn();
                    c.RelativeColumn();
                    c.RelativeColumn();
                    c.RelativeColumn(2);
                });

                Header(table, "Data", "Valor", "Forma", "Observação");

                foreach (var p in pagamentos)
                {
                    Row(table,
                        p.DataPagamento.ToString("dd/MM/yyyy"),
                        p.ValorPago.ToString("C2"),
                        p.FormaPagamento ?? "-",
                        p.Observacao ?? "-");
                }
            });
        }

        private static void AdicionarTotalPagamentos(
            ColumnDescriptor col,
            List<PagamentoExtratoModel> pagamentos)
        {
            decimal total = pagamentos.Sum(p => p.ValorPago);

            col.Item().PaddingTop(15)
                .AlignRight()
                .Text($"TOTAL RECEBIDO: {total:C2}")
                .Bold();
        }

        private static void AdicionarAssinatura(ColumnDescriptor col)
        {
            col.Item().PaddingTop(30).AlignCenter()
                .Text("________________________________________");

            col.Item().AlignCenter()
                .Text("Assinatura do Cliente");
        }

        private static void AdicionarRodape(ColumnDescriptor col)
        {
            col.Item().PaddingTop(20)
                .AlignCenter()
                .Text("Documento gerado automaticamente pelo sistema GVC")
                .FontSize(8);
        }

        // =========================
        // HELPERS TABELA
        // =========================
        private static void Header(TableDescriptor table, params string[] headers)
        {
            table.Header(header =>
            {
                foreach (var h in headers)
                {
                    header.Cell()
                        .Background(Colors.Grey.Lighten3)
                        .Padding(5)
                        .AlignCenter()
                        .Text(h)
                        .Bold();
                }
            });
        }

        private static void Row(TableDescriptor table, params object[] values)
        {
            foreach (var v in values)
            {
                table.Cell().Padding(5).Text(v?.ToString());
            }
        }
    }
}
