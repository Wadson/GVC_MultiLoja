using GVC.Model;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;

public static class ExtratoDetalhadoHierarquicoPdf
{
    public static void Gerar(
        ExtratoCliente extrato,
        List<ParcelaExtratoDetalhado> parcelas,
        DadosEmpresaPdf empresa,
        string caminho)
    {
        QuestPDF.Settings.License = LicenseType.Community;

        Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(40);
                page.DefaultTextStyle(x => x.FontFamily("Helvetica").FontSize(10));

                page.Content().Column(col =>
                {
                    // ======================================================
                    // CABEÇALHO (IGUAL AO EXTRATO FINANCEIRO)
                    // ======================================================
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

                    col.Item().PaddingTop(10).AlignCenter()
                        .Text("EXTRATO FINANCEIRO")
                        .FontSize(15)
                        .Bold();

                    col.Item().PaddingBottom(10).LineHorizontal(1);

                    // ======================================================
                    // DADOS DO CLIENTE
                    // ======================================================
                    col.Item().Text($"Cliente: {extrato.NomeCliente}").Bold();
                    col.Item().Text($"Data de emissão: {extrato.DataEmissao:dd/MM/yyyy HH:mm}");
                    col.Item().PaddingBottom(12);

                    // ======================================================
                    // PARCELAS + HISTÓRICO
                    // ======================================================
                    foreach (var parcela in parcelas)
                    {
                        col.Item().Text(
                            $"Venda {parcela.VendaID} | " +
                            $"Parcela {parcela.NumeroParcela} | " +
                            $"Venc: {parcela.DataVencimento:dd/MM/yyyy} | " +
                            $"Valor: {parcela.ValorParcela:C2} | " +
                            $"Recebido: {parcela.ValorRecebido:C2} | " +
                            $"Saldo: {parcela.Saldo:C2} | " +
                            $"Status: {parcela.Status}"
                        ).Bold();

                        foreach (var pg in parcela.Pagamentos)
                        {
                            col.Item()
                               .PaddingLeft(20)
                               .Text(
                                   $"↳ {pg.DataPagamento:dd/MM/yyyy}  " +
                                   $"{pg.ValorPago:C2}  {pg.Observacao}"
                               );
                        }

                        col.Item().PaddingBottom(10);
                    }

                    // ======================================================
                    // RODAPÉ
                    // ======================================================
                    col.Item().PaddingTop(20).AlignCenter()
                        .Text("Documento gerado automaticamente pelo sistema GVC")
                        .FontSize(8);
                });
            });
        }).GeneratePdf(caminho);

        // 🔥 ABRIR AUTOMATICAMENTE
        Process.Start(new ProcessStartInfo
        {
            FileName = caminho,
            UseShellExecute = true
        });
    }
}
