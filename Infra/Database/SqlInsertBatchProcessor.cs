using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class SqlInsertBatchProcessor
{
    public static void Processar(
        string arquivoOrigem,
        string arquivoDestino,
        int tamanhoLote,
        Action<int>? progresso = null)
    {
        var linhas = File.ReadAllLines(arquivoOrigem);
        var buffer = new List<string>();
        var sb = new StringBuilder();

        sb.AppendLine("IF NOT EXISTS (SELECT 1 FROM dbo.Cidade)");
        sb.AppendLine("BEGIN");
        sb.AppendLine("    SET IDENTITY_INSERT dbo.Cidade ON");
        sb.AppendLine();

        int total = 0;

        foreach (var linha in linhas)
        {
            if (!linha.TrimStart().StartsWith("INSERT", StringComparison.OrdinalIgnoreCase))
                continue;

            var idx = linha.IndexOf("VALUES", StringComparison.OrdinalIgnoreCase);
            if (idx < 0)
                continue;

            var valores = linha.Substring(idx + 6).Trim().TrimEnd(';');
            buffer.Add(valores);

            if (buffer.Count == tamanhoLote)
            {
                GerarLote(sb, buffer);
                total += buffer.Count;
                progresso?.Invoke(total);
                buffer.Clear();
            }
        }

        if (buffer.Count > 0)
        {
            GerarLote(sb, buffer);
            total += buffer.Count;
            progresso?.Invoke(total);
        }

        sb.AppendLine();
        sb.AppendLine("    SET IDENTITY_INSERT dbo.Cidade OFF");
        sb.AppendLine("END");

        File.WriteAllText(arquivoDestino, sb.ToString(), Encoding.UTF8);
    }

    private static void GerarLote(StringBuilder sb, List<string> valores)
    {
        sb.AppendLine("    INSERT dbo.Cidade (CidadeID, Nome, EstadoID, codigoIbge) VALUES");

        for (int i = 0; i < valores.Count; i++)
        {
            var sufixo = i == valores.Count - 1 ? ";" : ",";
            sb.AppendLine("    " + valores[i] + sufixo);
        }

        sb.AppendLine();
    }
}
