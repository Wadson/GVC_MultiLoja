using ClosedXML.Excel;
using GVC.Model;
using GVC.MODEL.Relatorios;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace GVC.UTIL
{
    public static class ExcelGenerator
    {
        // ============================
        // 📦 ESTOQUE
        // ============================
        public static void ExportarProdutosEstoque(
            List<RelatorioProdutoEstoqueDTO> dados,
            string caminho)
        {
            using var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Produtos");

            ws.Cell(1, 1).Value = "Produto";
            ws.Cell(1, 2).Value = "Estoque";
            ws.Cell(1, 3).Value = "Preço Custo";
            ws.Cell(1, 4).Value = "Preço Venda";
            ws.Cell(1, 5).Value = "Lucro Estoque";

            int row = 2;
            foreach (var p in dados)
            {
                ws.Cell(row, 1).Value = p.Produto;
                ws.Cell(row, 2).Value = p.Estoque;
                ws.Cell(row, 3).Value = p.PrecoCusto;
                ws.Cell(row, 4).Value = p.PrecoVenda;
                ws.Cell(row, 5).Value = p.LucroEstoque;
                row++;
            }

            ws.Columns().AdjustToContents();
            wb.SaveAs(caminho);
        }

        // ============================
        // 💰 LUCRO
        // ============================
        public static void ExportarLucroProduto(
            List<RelatorioLucroProdutoDTO> dados,
            string caminho)
        {
            using var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Lucro por Produto");

            ws.Cell(1, 1).Value = "Produto";
            ws.Cell(1, 2).Value = "Quantidade Vendida";
            ws.Cell(1, 3).Value = "Custo Total";
            ws.Cell(1, 4).Value = "Venda Total";
            ws.Cell(1, 5).Value = "Lucro Total";

            int row = 2;
            foreach (var p in dados)
            {
                ws.Cell(row, 1).Value = p.Produto;
                ws.Cell(row, 2).Value = p.QuantidadeVendida;
                ws.Cell(row, 3).Value = p.CustoTotal;
                ws.Cell(row, 4).Value = p.VendaTotal;
                ws.Cell(row, 5).Value = p.LucroTotal;
                row++;
            }

            ws.Columns().AdjustToContents();
            wb.SaveAs(caminho);
        }
        public static void Exportar(DataTable tabela, string caminhoArquivo)
        {
            using var workbook = new XLWorkbook();
            var ws = workbook.Worksheets.Add("Relatório");

            ws.Cell(1, 1).InsertTable(tabela, "Dados", true);

            ws.Columns().AdjustToContents();

            workbook.SaveAs(caminhoArquivo);
        }
        public static void GerarContasReceberAgrupadoPorClienteExcel(
           List<ExtratoCliente> extratos,
           string caminhoArquivo)
        {
            if (extratos == null || extratos.Count == 0)
                throw new Exception("Nenhum dado para gerar o relatório.");

            using var workbook = new XLWorkbook();
            var ws = workbook.Worksheets.Add("Contas a Receber");

            int linha = 1;

            // =========================
            // TÍTULO
            // =========================
            ws.Cell(linha, 1).Value =
                "Relatório de Contas a Receber Agrupado por Cliente";
            ws.Range(linha, 1, linha, 5).Merge()
                .Style.Font.SetBold()
                .Font.SetFontSize(14);
            linha += 2;

            decimal totalGeral = 0m;

            foreach (var extrato in extratos)
            {
                // =========================
                // CLIENTE
                // =========================
                ws.Cell(linha, 1).Value = $"Cliente: {extrato.NomeCliente}";
                ws.Range(linha, 1, linha, 5)
                    .Merge()
                    .Style.Font.SetBold();
                linha++;

                // =========================
                // CABEÇALHO TABELA
                // =========================
                ws.Cell(linha, 1).Value = "Venda";
                ws.Cell(linha, 2).Value = "Documento";
                ws.Cell(linha, 3).Value = "Vencimento";
                ws.Cell(linha, 4).Value = "Situação";
                ws.Cell(linha, 5).Value = "Saldo";

                ws.Range(linha, 1, linha, 5)
                    .Style.Font.SetBold()
                    .Fill.SetBackgroundColor(XLColor.LightGray);

                linha++;

                // =========================
                // LINHAS
                // =========================
                foreach (var item in extrato.ItensExtrato)
                {
                    ws.Cell(linha, 1).Value = item.VendaID;
                    ws.Cell(linha, 2).Value = item.ParcelaID;
                    ws.Cell(linha, 3).Value = item.DataVencimento;
                    ws.Cell(linha, 3).Style.DateFormat.Format = "dd/MM/yyyy";
                    ws.Cell(linha, 4).Value = item.Status;
                    ws.Cell(linha, 5).Value = item.Saldo;
                    ws.Cell(linha, 5).Style.NumberFormat.Format = "R$ #,##0.00";

                    linha++;
                }

                // =========================
                // TOTAL CLIENTE
                // =========================
                ws.Cell(linha, 4).Value = "Total do cliente:";
                ws.Cell(linha, 4).Style.Font.SetBold();

                ws.Cell(linha, 5).Value = extrato.SaldoAtual;
                ws.Cell(linha, 5)
                    .Style.Font.SetBold()
                    .NumberFormat.Format = "R$ #,##0.00";

                linha += 2;

                totalGeral += extrato.SaldoAtual;
            }

            // =========================
            // TOTAL GERAL
            // =========================
            ws.Cell(linha, 4).Value = "TOTAL GERAL:";
            ws.Cell(linha, 4).Style.Font.SetBold();

            ws.Cell(linha, 5).Value = totalGeral;
            ws.Cell(linha, 5)
                .Style.Font.SetBold()
                .NumberFormat.Format = "R$ #,##0.00";

            // =========================
            // AJUSTES FINAIS
            // =========================
            ws.Columns().AdjustToContents();

            workbook.SaveAs(caminhoArquivo);
        }
    }
}
