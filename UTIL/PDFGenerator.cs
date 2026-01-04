using GVC.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace GVC.UTIL
{
    public static class PDFGenerator
    {
        // =========================
        // CONFIGURAÇÕES GERAIS
        // =========================
        private static readonly PdfFont FonteNormal =
            PdfFontFactory.CreateFont(StandardFonts.HELVETICA, PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED);

        private static readonly PdfFont FonteNegrito =
            PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD, PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED);

        private static readonly PdfFont FonteTitulo =
            PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD, PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED);

        private static readonly PdfFont FonteRodape =
            PdfFontFactory.CreateFont(StandardFonts.HELVETICA, PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED);

        private static readonly iText.Kernel.Colors.Color CorCabecalho = new DeviceRgb(230, 230, 230);

        // =========================
        // EXTRATO FINANCEIRO
        // =========================
        public static void GerarExtratoPDF(ExtratoCliente extrato, DadosEmpresaPdf empresa, string caminhoArquivo)
        {
            Validar(extrato, empresa);

            using var writer = new PdfWriter(caminhoArquivo);
            using var pdf = new PdfDocument(writer);
            using var doc = new Document(pdf, PageSize.A4);

            doc.SetMargins(40, 40, 40, 40);

            AdicionarCabecalho(doc, empresa, "EXTRATO FINANCEIRO");
            AdicionarDadosCliente(doc, extrato);
            AdicionarTabelaExtrato(doc, extrato);
            AdicionarResumoExtrato(doc, extrato);
            AdicionarRodape(doc);
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

            using var writer = new PdfWriter(caminhoArquivo);
            using var pdf = new PdfDocument(writer);
            using var doc = new Document(pdf, PageSize.A4);

            doc.SetMargins(40, 40, 40, 40);

            AdicionarCabecalho(doc, empresa, "RECIBO DE PAGAMENTO");
            AdicionarDadosCliente(doc, extrato);
            AdicionarTabelaPagamentos(doc, pagamentos);
            AdicionarTotalPagamentos(doc, pagamentos);
            AdicionarAssinatura(doc);
            AdicionarRodape(doc);
        }

        // =========================
        // MÉTODOS PRIVADOS
        // =========================

        private static void Validar(ExtratoCliente extrato, DadosEmpresaPdf empresa)
        {
            if (extrato == null)
                throw new ArgumentNullException(nameof(extrato));

            if (empresa == null)
                throw new ArgumentNullException(nameof(empresa));
        }

        private static void AdicionarCabecalho(Document doc, DadosEmpresaPdf empresa, string titulo)
        {
            // Tabela para logo e nome da empresa
            Table tabela = new Table(new float[] { 1, 4 });
            tabela.SetWidth(UnitValue.CreatePercentValue(100));

            if (empresa.Logo != null && empresa.Logo.Length > 0)
            {
                try
                {
                    ImageData imageData = ImageDataFactory.Create(empresa.Logo);
                    iText.Layout.Element.Image logo = new iText.Layout.Element.Image(imageData);
                    logo.SetMaxWidth(80);
                    logo.SetMaxHeight(80);

                    Cell logoCell = new Cell()
                        .Add(logo)
                        .SetBorder(Border.NO_BORDER);

                    tabela.AddCell(logoCell);
                }
                catch (Exception)
                {
                    tabela.AddCell(new Cell().SetBorder(Border.NO_BORDER));
                }
            }
            else
            {
                tabela.AddCell(new Cell().SetBorder(Border.NO_BORDER));
            }

            Cell nomeCell = new Cell()
                .Add(new Paragraph(empresa.NomeEmpresa)
                    .SetFont(FonteTitulo)
                    .SetFontSize(15))
                .SetBorder(Border.NO_BORDER)
                .SetVerticalAlignment(VerticalAlignment.MIDDLE);

            tabela.AddCell(nomeCell);

            doc.Add(tabela);

            // Título do documento
            doc.Add(new Paragraph(titulo)
                .SetFont(FonteTitulo)
                .SetFontSize(15)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetMarginTop(10)
                .SetMarginBottom(15));
        }

        private static void AdicionarDadosCliente(Document doc, ExtratoCliente extrato)
        {
            doc.Add(new Paragraph($"Cliente: {extrato.NomeCliente}")
                .SetFont(FonteNegrito)
                .SetFontSize(10));

            doc.Add(new Paragraph($"Data de emissão: {DateTime.Now:dd/MM/yyyy HH:mm}")
                .SetFont(FonteNormal)
                .SetFontSize(10));

            doc.Add(new Paragraph(" "));
        }

        private static void AdicionarTabelaExtrato(Document doc, ExtratoCliente extrato)
        {
            Table tabela = new Table(new float[] { 1, 1, 1.5f, 1.5f, 1.5f, 1.5f });
            tabela.SetWidth(UnitValue.CreatePercentValue(100));

            AddHeader(tabela, "Venda");
            AddHeader(tabela, "Parcela");
            AddHeader(tabela, "Vencimento");
            AddHeader(tabela, "Valor");
            AddHeader(tabela, "Recebido");
            AddHeader(tabela, "Saldo");

            foreach (var item in extrato.ItensExtrato)
            {
                tabela.AddCell(new Cell().Add(new Paragraph(item.VendaID.ToString()).SetFont(FonteNormal).SetFontSize(10)));
                tabela.AddCell(new Cell().Add(new Paragraph(item.NumeroParcela.ToString()).SetFont(FonteNormal).SetFontSize(10)));
                tabela.AddCell(new Cell().Add(new Paragraph(item.DataVencimento.ToString("dd/MM/yyyy")).SetFont(FonteNormal).SetFontSize(10)));
                tabela.AddCell(new Cell().Add(new Paragraph(item.ValorParcela.ToString("C2")).SetFont(FonteNormal).SetFontSize(10)));
                tabela.AddCell(new Cell().Add(new Paragraph(item.ValorRecebido.ToString("C2")).SetFont(FonteNormal).SetFontSize(10)));
                tabela.AddCell(new Cell().Add(new Paragraph(item.Saldo.ToString("C2")).SetFont(FonteNormal).SetFontSize(10)));
            }

            doc.Add(tabela);
        }

        private static void AdicionarResumoExtrato(Document doc, ExtratoCliente extrato)
        {
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph($"Total pago: {extrato.TotalPago:C2}")
                .SetFont(FonteNegrito)
                .SetFontSize(10));
            doc.Add(new Paragraph($"Total em aberto: {extrato.TotalDevendo:C2}")
                .SetFont(FonteNegrito)
                .SetFontSize(10));
        }

        private static void AdicionarTabelaPagamentos(
            Document doc,
            List<PagamentoExtratoModel> pagamentos)
        {
            Table tabela = new Table(new float[] { 2, 2, 2.5f, 3.5f });
            tabela.SetWidth(UnitValue.CreatePercentValue(100));

            AddHeader(tabela, "Data");
            AddHeader(tabela, "Valor");
            AddHeader(tabela, "Forma");
            AddHeader(tabela, "Observação");

            foreach (var p in pagamentos)
            {
                tabela.AddCell(new Cell().Add(new Paragraph(p.DataPagamento.ToString("dd/MM/yyyy")).SetFont(FonteNormal).SetFontSize(10)));
                tabela.AddCell(new Cell().Add(new Paragraph(p.ValorPago.ToString("C2")).SetFont(FonteNormal).SetFontSize(10)));
                tabela.AddCell(new Cell().Add(new Paragraph(p.FormaPagamento ?? "-")).SetFont(FonteNormal).SetFontSize(10));
                tabela.AddCell(new Cell().Add(new Paragraph(p.Observacao ?? "-")).SetFont(FonteNormal).SetFontSize(10));
            }

            doc.Add(tabela);
        }

        private static void AdicionarTotalPagamentos(
            Document doc,
            List<PagamentoExtratoModel> pagamentos)
        {
            decimal total = pagamentos.Sum(p => p.ValorPago);

            doc.Add(new Paragraph($"TOTAL RECEBIDO: {total:C2}")
                .SetFont(FonteNegrito)
                .SetFontSize(10)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetMarginTop(15));
        }

        private static void AdicionarAssinatura(Document doc)
        {
            doc.Add(new Paragraph("\n\n"));
            doc.Add(new Paragraph("________________________________________")
                .SetTextAlignment(TextAlignment.CENTER));
            doc.Add(new Paragraph("Assinatura do Cliente")
                .SetTextAlignment(TextAlignment.CENTER));
        }

        private static void AdicionarRodape(Document doc)
        {
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("Documento gerado automaticamente pelo sistema GVC")
                .SetFont(FonteRodape)
                .SetFontSize(8)
                .SetTextAlignment(TextAlignment.CENTER));
        }

        private static void AddHeader(Table tabela, string texto)
        {
            Cell cell = new Cell()
                .Add(new Paragraph(texto)
                    .SetFont(FonteNegrito)
                    .SetFontSize(10))
                .SetBackgroundColor(CorCabecalho)
                .SetTextAlignment(TextAlignment.CENTER);

            tabela.AddHeaderCell(cell);
        }
    }
}