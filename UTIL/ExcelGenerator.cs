using GVC.Model;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data;

namespace GVC.UTIL
{
    public static class ExcelGenerator
    {
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

        public static void Exportar(DataTable tabela, string caminhoArquivo)
        {
            using var workbook = new XLWorkbook();
            var ws = workbook.Worksheets.Add("Relatório");

            ws.Cell(1, 1).InsertTable(tabela, "Dados", true);

            ws.Columns().AdjustToContents();

            workbook.SaveAs(caminhoArquivo);
        }
    }
}
