
using GVC.UTIL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace GVC.View
{
    public partial class FrmConfiguracoes : KryptonForm
    {
        private readonly int _empresaId;
        public FrmConfiguracoes(int empresaId)
        {
            InitializeComponent();
            _empresaId = empresaId;
        }

        private void icbtnBackup_Click(object sender, EventArgs e)
        {
            FrmBackup frmBackup = new FrmBackup();
            frmBackup.ShowDialog();
        }

        private void icbtnCertificadoDigital_Click(object sender, EventArgs e)
        {
            new FrmConfigCertificado(_empresaId).ShowDialog();
        }
        private void icbtnDadosFiscais_Click(object sender, EventArgs e)
        {

        }

        private void icbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void icbtnLogo_Click(object sender, EventArgs e)
        {
            int empresaId = 1; // ou pegar a empresa selecionada do sistema
            FrmConfigLogo frm = new FrmConfigLogo();
            frm.ShowDialog();
        }

        private void icbConvertScript_Click(object sender, EventArgs e)
        {
            FrmSqlBatchGenerator frmConverterScriptBancoSql = new FrmSqlBatchGenerator();
            frmConverterScriptBancoSql.ShowDialog();
        }

        private void FrmConfiguracoes_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

        }

        private void btnListarMetodosGeral_Click(object sender, EventArgs e)
        {
            ListarMetodosPublicosPrivados();

            MessageBox.Show("Arquivo de métodos gerado com sucesso!");
        }

        private void ListarMetodosPublicosPrivados()
        {
            // Assembly atual (seu executável WinForms)
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Caminho do arquivo de saída (Área de Trabalho)
            string outputFile = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "MetodosWinForms.txt");

            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                foreach (Type type in assembly.GetTypes())
                {
                    // Ignora tipos anônimos e classes de formulário
                    if (!type.IsClass
                        || type.Name.Contains("AnonymousType")
                        || type.Name.StartsWith("<>")
                        || type.IsSubclassOf(typeof(Form)))
                        continue;

                    writer.WriteLine($"Classe: {type.FullName}");

                    var methods = type.GetMethods(
                        BindingFlags.Public |
                        BindingFlags.NonPublic |
                        BindingFlags.Instance |
                        BindingFlags.Static |
                        BindingFlags.DeclaredOnly);

                    foreach (var method in methods)
                    {
                        string visibilidade = method.IsPublic ? "Public" : "Private";
                        writer.WriteLine($"   [{visibilidade}] {method.Name}");
                    }

                    writer.WriteLine();
                }
            }
        }

        private void btnListarEstruturaPastasProjeto_Click(object sender, EventArgs e)
        {
            string diretorioRaiz = @"C:\GVC";
            string arquivoSaida = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "EstruturaPastas.txt"
            );

            StringBuilder sb = new StringBuilder();
            ListarArvore(diretorioRaiz, sb, "", true);

            File.WriteAllText(arquivoSaida, sb.ToString(), Encoding.UTF8);

            MessageBox.Show("Estrutura de pastas salva em " + arquivoSaida);
        }
        private void ListarArvore(string caminho, StringBuilder sb, string prefixo, bool ultimo)
        {
            string nome = Path.GetFileName(caminho);
            if (string.IsNullOrEmpty(nome)) nome = caminho;

            sb.AppendLine(prefixo + (ultimo ? "└── " : "├── ") + nome);

            string novoPrefixo = prefixo + (ultimo ? "    " : "│   ");

            // Listar subpastas
            string[] subpastas;
            try
            {
                subpastas = Directory.GetDirectories(caminho);
            }
            catch
            {
                return; // sem permissão
            }

            for (int i = 0; i < subpastas.Length; i++)
            {
                ListarArvore(subpastas[i], sb, novoPrefixo, i == subpastas.Length - 1);
            }

            // Listar arquivos
            string[] arquivos;
            try
            {
                arquivos = Directory.GetFiles(caminho);
            }
            catch
            {
                return;
            }

            for (int i = 0; i < arquivos.Length; i++)
            {
                string nomeArquivo = Path.GetFileName(arquivos[i]);
                sb.AppendLine(novoPrefixo + (i == arquivos.Length - 1 ? "└── " : "├── ") + nomeArquivo);
            }
        }
    }
}
