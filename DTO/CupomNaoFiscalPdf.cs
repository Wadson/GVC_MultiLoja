using GVC.DALL;
using GVC.Model;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

public static class CupomNaoFiscalPdf
{
    public static void Gerar(
        VendaModel venda,
        List<ItemVendaModel> itens,
        string nomeEmpresa,
        string cnpj,
        string endereco,
        string telefone
    )
    {
        string pasta = System.IO.Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "CuponsPDV"
        );

        if (!Directory.Exists(pasta))
            Directory.CreateDirectory(pasta);

        string arquivo = System.IO.Path.Combine(
            pasta,
            $"CUPOM_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
        );

        // Criar documento com iText 7
        using (var writer = new PdfWriter(arquivo))
        using (var pdf = new PdfDocument(writer))
        using (var doc = new Document(pdf, PageSize.A4))
        {
            doc.SetMargins(20, 20, 20, 20);

            // Configurar fonte Courier para cupom fiscal
            PdfFont fonteCourier = PdfFontFactory.CreateFont(StandardFonts.COURIER);

            void AdicionarLinha(string texto = "")
            {
                doc.Add(new Paragraph(texto)
                    .SetFont(fonteCourier)
                    .SetFontSize(9)
                    .SetMargin(0)
                    .SetPadding(0));
            }

            void AdicionarLinhaCentro(string texto)
            {
                doc.Add(new Paragraph(texto)
                    .SetFont(fonteCourier)
                    .SetFontSize(9)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetMargin(0)
                    .SetPadding(0));
            }

            // Cabeçalho do cupom
            AdicionarLinha("========================================");
            AdicionarLinhaCentro(nomeEmpresa.ToUpper());
            AdicionarLinha($"Cnpj: {cnpj}");
            AdicionarLinha(endereco);
            AdicionarLinha($"Tel: {telefone}");
            AdicionarLinha("========================================");

            // Informações da venda
            AdicionarLinha($"DATA: {venda.DataVenda:dd/MM/yyyy}    HORA: {venda.DataVenda:HH:mm:ss}");
            AdicionarLinha($"VENDA Nº: {venda.VendaID}");
            AdicionarLinha("========================================");

            // Cabeçalho dos itens
            AdicionarLinha("ITEM  DESCRIÇÃO            QTD   VL UNIT   TOTAL");
            AdicionarLinha("========================================");

            // Itens da venda
            int i = 1;
            foreach (var item in itens)
            {
                string desc = item.ProdutoDescricao.Length > 18
                    ? item.ProdutoDescricao.Substring(0, 18)
                    : item.ProdutoDescricao;

                // Usando formatação com espaçamento fixo (similar ao antigo)
                string linhaItem = string.Format("{0,-4} {1,-18} {2,3} {3,8:N2} {4,8:N2}",
                    i,
                    desc,
                    item.Quantidade,
                    item.PrecoUnitario,
                    item.Subtotal);

                AdicionarLinha(linhaItem);
                i++;
            }

            // Rodapé/Resumo
            AdicionarLinha("========================================");
            AdicionarLinha($"TOTAL DE ITENS: {itens.Count}");
            AdicionarLinha($"VALOR TOTAL: R$ {venda.ValorTotal:N2}");
            AdicionarLinha("========================================");
            AdicionarLinhaCentro("Agradecemos a preferência!");
            AdicionarLinhaCentro("Volte sempre!");
            AdicionarLinha("========================================");
        }

        // Abrir o arquivo gerado
        Process.Start(new ProcessStartInfo
        {
            FileName = arquivo,
            UseShellExecute = true
        });
    }

    // 🔹 NOVA SOBRECARGA (ERP)
    public static void Gerar(
        VendaModel venda,
        List<ItemVendaModel> itens
    )
    {
        var empresaDal = new EmpresaDal();
        var empresa = empresaDal.BuscarEmpresaPrincipal();

        if (empresa == null)
            throw new Exception("Empresa não cadastrada.");

        string nomeEmpresa =
            string.IsNullOrWhiteSpace(empresa.NomeFantasia)
                ? empresa.RazaoSocial
                : empresa.NomeFantasia;

        string endereco =
            $"{empresa.Logradouro}, Nº {empresa.Numero} - {empresa.Bairro} - {empresa.Cidade}/{empresa.UF}";

        // 🔁 Reaproveita o método antigo
        Gerar(
            venda,
            itens,
            nomeEmpresa,
            empresa.CNPJ,
            endereco,
            empresa.Telefone
        );
    }
}