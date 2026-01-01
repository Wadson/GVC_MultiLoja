using GVC.MODEL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Image = iTextSharp.text.Image;
using Rectangle = iTextSharp.text.Rectangle;

namespace GVC.UTIL
{
    public static class PDFGenerator
    {
        // =========================
        // CONFIGURAÇÕES GERAIS
        // =========================
        private static readonly BaseFont BaseFonte =
            BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

        private static readonly iTextSharp.text.Font FonteNormal = new(BaseFonte, 10);
        private static readonly iTextSharp.text.Font FonteNegrito = new(BaseFonte, 10, iTextSharp.text.Font.BOLD);
        private static readonly iTextSharp.text.Font FonteTitulo = new(BaseFonte, 15, iTextSharp.text.Font.BOLD);
        private static readonly iTextSharp.text.Font FonteRodape = new(BaseFonte, 8);

        private static readonly BaseColor CorCabecalho = new(230, 230, 230);

        // =========================
        // EXTRATO FINANCEIRO
        // =========================
        public static void GerarExtratoPDF(ExtratoCliente extrato, DadosEmpresaPdf empresa, string caminhoArquivo)
        {
            Validar(extrato, empresa);

            using var fs = new FileStream(caminhoArquivo, FileMode.Create);
            var doc = CriarDocumento(fs);

            AdicionarCabecalho(doc, empresa, "EXTRATO FINANCEIRO");
            AdicionarDadosCliente(doc, extrato);
            AdicionarTabelaExtrato(doc, extrato);
            AdicionarResumoExtrato(doc, extrato);
            AdicionarRodape(doc);

            doc.Close();
        }

        // =========================
        // RECIBO COM HISTÓRICO
        // =========================
        public static void GerarReciboPagamentos( ExtratoCliente extrato, List<PagamentoExtratoModel> pagamentos,
            DadosEmpresaPdf empresa, string caminhoArquivo)
        {
            Validar(extrato, empresa);

            if (pagamentos == null || pagamentos.Count == 0)
                throw new Exception("Nenhum pagamento encontrado.");

            using var fs = new FileStream(caminhoArquivo, FileMode.Create);
            var doc = CriarDocumento(fs);

            AdicionarCabecalho(doc, empresa, "RECIBO DE PAGAMENTO");
            AdicionarDadosCliente(doc, extrato);
            AdicionarTabelaPagamentos(doc, pagamentos);
            AdicionarTotalPagamentos(doc, pagamentos);
            AdicionarAssinatura(doc);
            AdicionarRodape(doc);

            doc.Close();
        }

        // =========================
        // MÉTODOS PRIVADOS
        // =========================

        private static Document CriarDocumento(FileStream fs)
        {
            var doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 40);
            PdfWriter.GetInstance(doc, fs);
            doc.Open();
            return doc;
        }

        private static void Validar(ExtratoCliente extrato, DadosEmpresaPdf empresa)
        {
            if (extrato == null)
                throw new ArgumentNullException(nameof(extrato));

            if (empresa == null)
                throw new ArgumentNullException(nameof(empresa));
        }

        private static void AdicionarCabecalho( Document doc,DadosEmpresaPdf empresa, string titulo)
        {
            PdfPTable tabela = new PdfPTable(2);
            tabela.WidthPercentage = 100;
            tabela.SetWidths(new float[] { 20, 80 });

            if (empresa.Logo != null && empresa.Logo.Length > 0)
            {
                Image logo = Image.GetInstance(empresa.Logo);
                logo.ScaleToFit(80, 80);
                tabela.AddCell(new PdfPCell(logo)
                {
                    Border = Rectangle.NO_BORDER
                });
            }
            else
            {
                tabela.AddCell(new PdfPCell { Border = Rectangle.NO_BORDER });
            }

            tabela.AddCell(new PdfPCell(new Phrase(empresa.NomeEmpresa, FonteTitulo))
            {
                Border = iTextSharp.text.Rectangle.NO_BORDER,
                VerticalAlignment = Element.ALIGN_MIDDLE
            });

            doc.Add(tabela);

            doc.Add(new Paragraph(titulo, FonteTitulo)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingBefore = 10,
                SpacingAfter = 15
            });
        }

        private static void AdicionarDadosCliente(Document doc, ExtratoCliente extrato)
        {
            doc.Add(new Paragraph($"Cliente: {extrato.NomeCliente}", FonteNegrito));
            doc.Add(new Paragraph($"Data de emissão: {DateTime.Now:dd/MM/yyyy HH:mm}", FonteNormal));
            doc.Add(new Paragraph(" "));
        }

        private static void AdicionarTabelaExtrato(Document doc, ExtratoCliente extrato)
        {
            PdfPTable tabela = new PdfPTable(6);
            tabela.WidthPercentage = 100;
            tabela.SetWidths(new float[] { 10, 10, 15, 15, 15, 15 });

            AddHeader(tabela, "Venda");
            AddHeader(tabela, "Parcela");
            AddHeader(tabela, "Vencimento");
            AddHeader(tabela, "Valor");
            AddHeader(tabela, "Recebido");
            AddHeader(tabela, "Saldo");

            foreach (var item in extrato.ItensExtrato)
            {
                tabela.AddCell(item.VendaID.ToString());
                tabela.AddCell(item.NumeroParcela.ToString());
                tabela.AddCell(item.DataVencimento.ToString("dd/MM/yyyy"));
                tabela.AddCell(item.ValorParcela.ToString("C2"));
                tabela.AddCell(item.ValorRecebido.ToString("C2"));
                tabela.AddCell(item.Saldo.ToString("C2"));
            }

            doc.Add(tabela);
        }

        private static void AdicionarResumoExtrato(Document doc, ExtratoCliente extrato)
        {
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph($"Total pago: {extrato.TotalPago:C2}", FonteNegrito));
            doc.Add(new Paragraph($"Total em aberto: {extrato.TotalDevendo:C2}", FonteNegrito));
        }

        private static void AdicionarTabelaPagamentos(
            Document doc,
            List<PagamentoExtratoModel> pagamentos)
        {
            PdfPTable tabela = new PdfPTable(4);
            tabela.WidthPercentage = 100;
            tabela.SetWidths(new float[] { 20, 20, 25, 35 });

            AddHeader(tabela, "Data");
            AddHeader(tabela, "Valor");
            AddHeader(tabela, "Forma");
            AddHeader(tabela, "Observação");

            foreach (var p in pagamentos)
            {
                tabela.AddCell(p.DataPagamento.ToString("dd/MM/yyyy"));
                tabela.AddCell(p.ValorPago.ToString("C2"));
                tabela.AddCell(p.FormaPagamento ?? "-");
                tabela.AddCell(p.Observacao ?? "-");
            }

            doc.Add(tabela);
        }

        private static void AdicionarTotalPagamentos(
            Document doc,
            List<PagamentoExtratoModel> pagamentos)
        {
            decimal total = pagamentos.Sum(p => p.ValorPago);

            doc.Add(new Paragraph($"TOTAL RECEBIDO: {total:C2}", FonteNegrito)
            {
                Alignment = Element.ALIGN_RIGHT,
                SpacingBefore = 15
            });
        }

        private static void AdicionarAssinatura(Document doc)
        {
            doc.Add(new Paragraph("\n\n"));
            doc.Add(new Paragraph("________________________________________")
            {
                Alignment = Element.ALIGN_CENTER
            });
            doc.Add(new Paragraph("Assinatura do Cliente")
            {
                Alignment = Element.ALIGN_CENTER
            });
        }

        private static void AdicionarRodape(Document doc)
        {
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph(
                "Documento gerado automaticamente pelo sistema GVC",
                FonteRodape)
            {
                Alignment = Element.ALIGN_CENTER
            });
        }

        private static void AddHeader(PdfPTable tabela, string texto)
        {
            tabela.AddCell(new PdfPCell(new Phrase(texto, FonteNegrito))
            {
                BackgroundColor = CorCabecalho,
                HorizontalAlignment = Element.ALIGN_CENTER
            });
        }
    }
}
