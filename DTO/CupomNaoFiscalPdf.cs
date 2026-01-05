using GVC.DAL;
using GVC.Model;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

public static class CupomNaoFiscalPdf
{
    private static void Linha(ColumnDescriptor col, string texto = "")
    {
        col.Item().Text(texto);
    }
    private static string Centralizar(string texto, int largura = 32)
    {
        if (texto.Length >= largura)
            return texto.Substring(0, largura);

        int espacos = (largura - texto.Length) / 2;
        return new string(' ', espacos) + texto;
    }
    private static void LinhaQuebrada(ColumnDescriptor col, string texto, int largura = 40)
    {
        if (string.IsNullOrWhiteSpace(texto))
        {
            Linha(col);
            return;
        }

        for (int i = 0; i < texto.Length; i += largura)
        {
            var parte = texto.Substring(i, Math.Min(largura, texto.Length - i));
            Linha(col, parte);
        }
    }





    public static void Gerar(VendaModel venda, List<ItemVendaModel> itens,
        string nomeEmpresa,
        string cnpj,
        string endereco,
        string telefone
    )
    {
        QuestPDF.Settings.License = LicenseType.Community;

        string pasta = Path.Combine( Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "CuponsPDV");

        if (!Directory.Exists(pasta))
            Directory.CreateDirectory(pasta);

        string arquivo = Path.Combine( pasta, $"CUPOM_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");

        Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(20);
                page.DefaultTextStyle(x =>
                    x.FontFamily("Courier New").FontSize(9));

                page.Content().Column(col =>
                {
                    void Linha(string texto = "") =>
                        col.Item().Text(texto);

                    Linha("========================================");
                    Linha(Centralizar(nomeEmpresa.ToUpper()));
                    Linha($"CNPJ: {cnpj}");
                    LinhaQuebrada(col, endereco, 40);
                    Linha($"Tel: {telefone}");
                    Linha("========================================");
                    Linha($"DATA: {venda.DataVenda:dd/MM/yyyy}    HORA: {venda.DataVenda:HH:mm:ss}");
                    Linha($"VENDA Nº: {venda.VendaID}");
                    Linha("========================================");

                    Linha("ITEM  DESCRIÇÃO     QTD   VL UNIT   TOTAL");
                    Linha("========================================");

                    int i = 1;
                    foreach (var item in itens)
                    {
                        string desc = item.ProdutoDescricao.Length > 18? item.ProdutoDescricao[..18]: item.ProdutoDescricao;

                        LinhaQuebrada(col, string.Format("{0,-4} {1,-18} {2,3} {3,8:N2} {4,8:N2}",
                            i,
                            desc,
                            item.Quantidade,
                            item.PrecoUnitario,
                            item.Subtotal,
                        40));
                        i++;
                    }

                    Linha("========================================");
                    Linha($"TOTAL DE ITENS: {itens.Count}");
                    Linha($"VALOR TOTAL: R$ {venda.ValorTotal:N2}");
                    Linha("========================================");
                    Linha(Centralizar("Agradecemos a preferência!"));
                    Linha(Centralizar("Volte sempre!"));
                    Linha("========================================");
                });
            });
        })
        .GeneratePdf(arquivo);

        Process.Start(new ProcessStartInfo
        {
            FileName = arquivo,
            UseShellExecute = true
        });
    }

    // 🔹 SOBRECARGA (ERP)
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
