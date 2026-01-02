using GVC.DALL;
using GVC.MODEL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
        string pasta = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "CuponsPDV"
        );

        if (!Directory.Exists(pasta))
            Directory.CreateDirectory(pasta);

        string arquivo = Path.Combine(
            pasta,
            $"CUPOM_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
        );

        var fonte = FontFactory.GetFont(FontFactory.COURIER, 9);

        using (FileStream fs = new FileStream(arquivo, FileMode.Create))
        {
            var doc = new Document(PageSize.A4, 20, 20, 20, 20);
            PdfWriter.GetInstance(doc, fs);
            doc.Open();

            void Linha(string texto = "")
            {
                doc.Add(new Paragraph(texto, fonte));
            }

            Linha("========================================");
            Linha(nomeEmpresa.ToUpper());
            Linha($"CNPJ: {cnpj}");
            Linha(endereco);
            Linha($"Tel: {telefone}");
            Linha("========================================");

            Linha($"DATA: {venda.DataVenda:dd/MM/yyyy}    HORA: {venda.DataVenda:HH:mm:ss}");
            Linha($"VENDA Nº: {venda.VendaID}");
            Linha("========================================");

            Linha("ITEM  DESCRIÇÃO            QTD   VL UNIT   TOTAL");
            Linha("========================================");

            int i = 1;
            foreach (var item in itens)
            {
                string desc = item.ProdutoDescricao.Length > 18
                    ? item.ProdutoDescricao.Substring(0, 18)
                    : item.ProdutoDescricao;

                Linha(
                    $"{i,-4} {desc,-18} {item.Quantidade,3} " +
                    $"{item.PrecoUnitario,8:N2} {item.Subtotal,8:N2}"
                );

                i++;
            }

            Linha("========================================");
            Linha($"TOTAL DE ITENS: {itens.Count}");
            Linha($"VALOR TOTAL: R$ {venda.ValorTotal:N2}");
            Linha("========================================");
            Linha("   Agradecemos a preferência!");
            Linha("        Volte sempre!");
            Linha("========================================");

            doc.Close();
        }

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
