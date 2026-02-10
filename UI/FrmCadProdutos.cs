    using GVC.BLL;
    using GVC.Model;
    using GVC.UTIL;
    using Krypton.Toolkit;
    using Microsoft.Data.SqlClient;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
using System.Diagnostics;
using System.Drawing;
    using System.Drawing.Imaging;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
    namespace GVC.View
    {
    public partial class FrmCadProdutos : KryptonForm
    {
        private string QueryProdutos = "SELECT MAX(ProdutoID) FROM Produtos";
        private string StatusOperacao;
        private int produtoID;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ClienteID { get; set; }
        private bool bloqueiaPesquisa = false;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FornecedorSelecionado { get; set; } // não serve para nada só para preencher o parametro do construtor
        public FrmCadProdutos(string statusOperacao)
        {
            InitializeComponent();
            // Utiliza a classe Utilitario para adicionar os efeitos de foco a todos os TextBoxes no formulário
            //Utilitario.AdicionarEfeitoFocoEmTodos(this);
            Utilitario.ConfigurarEnterComoTab(this);
            this.txtPrecoCusto.Enter += new System.EventHandler(this.txtPrecoCusto_Enter);
            this.txtPrecoCusto.Leave += new System.EventHandler(this.txtPrecoCusto_Leave);
            this.txtLucro.Enter += new System.EventHandler(this.txtLucro_Enter);
            this.txtLucro.Leave += new System.EventHandler(this.txtLucro_Leave);
            this.StatusOperacao = statusOperacao;
        }
        public void SelecionarMarcaPorId(int marcaId)
        {
            if (cmbMarca == null || cmbMarca.IsDisposed)
                return;

            try
            {
                // Aguarda até que o combobox tenha itens
                int tentativas = 0;
                while (cmbMarca.Items.Count == 0 && tentativas < 10)
                {
                    System.Threading.Thread.Sleep(50);
                    Application.DoEvents();
                    tentativas++;
                }

                // Se ainda não tem itens, carrega agora
                if (cmbMarca.Items.Count == 0)
                {
                    Utilitario.CarregarMarca(cmbMarca, true);
                    Application.DoEvents();
                }

                // Agora tenta selecionar
                if (cmbMarca.Items.Count > 0)
                {
                    if (marcaId > 0)
                    {
                        // Tenta usar SelectedValue primeiro
                        cmbMarca.SelectedValue = marcaId;

                        // Verifica se selecionou corretamente
                        if (cmbMarca.SelectedValue == null ||
                           Convert.ToInt32(cmbMarca.SelectedValue) != marcaId)
                        {
                            // Fallback: procura manualmente
                            for (int i = 0; i < cmbMarca.Items.Count; i++)
                            {
                                if (cmbMarca.Items[i] is MarcaModel item &&
                                    item.MarcaID == marcaId)
                                {
                                    cmbMarca.SelectedIndex = i;
                                    return;
                                }
                            }

                            // Se não encontrou, seleciona o primeiro
                            cmbMarca.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        cmbMarca.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log silencioso ou mostra mensagem
                Debug.WriteLine($"Erro ao selecionar marca: {ex.Message}");
            }
        }
        // No FrmCadProdutos.cs
        //public void SelecionarMarcaPorId(int marcaId)
        //{
        //    try
        //    {
        //        if (marcaId <= 0)
        //        {
        //            cmbMarca.SelectedIndex = 0; // Seleciona "Selecione a marca"
        //            return;
        //        }

        //        // Procura o MarcaID nos itens do combobox
        //        foreach (MarcaModel item in cmbMarca.Items)
        //        {
        //            if (item.MarcaID == marcaId)
        //            {
        //                cmbMarca.SelectedItem = item;
        //                return;
        //            }
        //        }

        //        // Se não encontrou, seleciona o primeiro item
        //        cmbMarca.SelectedIndex = 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        Utilitario.Mensagens.Erro($"Erro ao selecionar marca: {ex.Message}");
        //        cmbMarca.SelectedIndex = 0;
        //    }
        //}

        private void FrmCadProdutos_Load(object sender, EventArgs e)
        {         

            try
            {
                if (cmbMarca.Items.Count == 0)
                {
                    Utilitario.CarregarMarca(cmbMarca, true);
                }
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro($"Erro ao carregar marcas: {ex.Message}");
            }




            if (!ValidadorSessao.Validar(this))
                return;

            txtNomeProduto.Select();
            Utilitario.FormatarMoeda(txtPrecoCusto);
            Utilitario.FormatarMoeda(txtLucro);
            Utilitario.FormatarMoeda(txtPrecoDeVenda);
            if (StatusOperacao == "ALTERAR")
            {
                return;
            }
            if (StatusOperacao == "NOVO")
            {
                int NovoCodigo = Utilitario.ProximoId(QueryProdutos);//RetornaCodigoContaMaisUm(QueryUsuario).ToString();
                string numeroComZeros = Utilitario.ZerosEsquerda(NovoCodigo, 4);
                txtProdutoID.Text = numeroComZeros;

                cmbStatus.SelectedIndex = 1;
                cmbSituacao.SelectedIndex = 0;
                txtNomeProduto.Focus();
            }
        }
        private void CalcularPrecoVenda()
        {
            if (decimal.TryParse(txtPrecoCusto.Text, out decimal precoCusto) &&
            !string.IsNullOrWhiteSpace(txtLucro.Text))
            {
                decimal precoVenda = 0;
                if (txtLucro.Text.EndsWith("%"))
                {
                    string lucroPercentualStr = txtLucro.Text.TrimEnd('%');
                    if (decimal.TryParse(lucroPercentualStr, out decimal lucroPercentual))
                    {
                        precoVenda = precoCusto + (precoCusto * lucroPercentual / 100);
                    }
                }
                else if (decimal.TryParse(txtLucro.Text, out decimal lucro))
                {
                    precoVenda = precoCusto + lucro;
                }
                txtPrecoDeVenda.Text = precoVenda.ToString(CultureInfo.CurrentCulture);
            }
            else
            {
                txtPrecoDeVenda.Text = string.Empty;
            }
        }
        private void CalcularLucro()
        {
            if (decimal.TryParse(txtPrecoCusto.Text, out decimal precoCusto) &&
            decimal.TryParse(txtPrecoDeVenda.Text, out decimal precoVenda))
            {
                decimal lucroCalculado = precoVenda - precoCusto;
                txtLucro.Text = lucroCalculado.ToString(CultureInfo.CurrentCulture);
            }
            else
            {
                txtLucro.Text = string.Empty;
            }
        }
        private void Salvar()
        {
            // Validação segura dos campos numéricos
            int produtoId;
            int.TryParse(txtProdutoID.Text, out produtoId);

            decimal precoCusto;
            decimal.TryParse(txtPrecoCusto.Text, out precoCusto);

            decimal lucro;
            decimal.TryParse(txtLucro.Text, out lucro);

            decimal precoDeVenda;
            decimal.TryParse(txtPrecoDeVenda.Text, out precoDeVenda);

            int estoque;
            int.TryParse(txtEstoque.Text, out estoque);
            ProdutoModel produto = new ProdutoModel
            {
                ProdutoID = produtoId,
                NomeProduto = txtNomeProduto.Text,
                Referencia = txtReferencia.Text,
                PrecoCusto = precoCusto,
                Lucro = lucro,
                PrecoDeVenda = precoDeVenda,
                Estoque = estoque,
                DataDeEntrada = dtpDataDeEntrada?.Value.Date ?? DateTime.Today,
                Status = cmbStatus.Text,
                Situacao = cmbSituacao.Text,
                Unidade = cmbUnidade.Text,
                MarcaID = Convert.ToInt32(lblMarcaId.Text),
                DataValidade = DateTime.TryParseExact(txtDataValidade.Text, "dd/MM/yyyy",
               CultureInfo.GetCultureInfo("pt-BR"), DateTimeStyles.None, out DateTime dataValida)
               ? (DateTime?)dataValida : null,
                GtinEan = txtGtinEan.Text,
                Imagem = txtEnderecoImagem.Text,
                FornecedorID = txtFornecedorID.Text != "" ? int.Parse(txtFornecedorID.Text) : 0,
            };
            try
            {
                ProdutosBLL produtosbll = new ProdutosBLL();

                produtosbll.Inserir(produto);
                Utilitario.Mensagens.Info("Produto salvo com sucesso!");

                Utilitario.LimparCampos(this);

                cmbStatus.SelectedIndex = 1;
                cmbSituacao.SelectedIndex = 0;
                txtNomeProduto.Focus();

                int novoCodigo = Utilitario.ProximoId(QueryProdutos);
                txtProdutoID.Text = Utilitario.ZerosEsquerda(novoCodigo, 4);

                var frmManutProduto = Application.OpenForms["FrmManutProduto"] as FrmManutProduto;
                if (frmManutProduto != null)
                {
                    frmManutProduto.HabilitarTimer(true);
                }
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso(ex.Message);
            }
        }
        public void Excluir()
        {
            try
            {
                if (MessageBox.Show($"Deseja realmente excluir o produto:\n\n{txtNomeProduto.Text}?",
                    "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    long produtoId = long.Parse(txtProdutoID.Text);
                    ProdutosBLL produtoBll = new ProdutosBLL();

                    bool sucesso = produtoBll.Excluir(produtoId); // ← Agora passa só o ID (long)

                    if (sucesso)
                    {
                        Utilitario.Mensagens.Info("Registro excluído com sucesso!");

                        var frmManutProduto = Application.OpenForms["FrmManutProduto"] as FrmManutProduto;
                        frmManutProduto?.HabilitarTimer(true);

                        Utilitario.LimparCampos(this);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso("Erro ao excluir: " + ex.Message);
            }
        }
        private void Alterar()
        {
            try
            {
                // Criar uma nova instância de ProdutoModel e preencher com os dados do formulário
                ProdutoModel produto = new ProdutoModel
                {
                    ProdutoID = int.Parse(txtProdutoID.Text),
                    NomeProduto = txtNomeProduto.Text,
                    PrecoCusto = decimal.Parse(txtPrecoCusto.Text),
                    Lucro = decimal.Parse(txtLucro.Text),
                    PrecoDeVenda = decimal.Parse(txtPrecoDeVenda.Text),
                    Estoque = int.Parse(txtEstoque.Text),
                    Status = cmbStatus.Text,
                    Referencia = txtReferencia.Text,

                    // 🔹 Novos campos
                    Situacao = cmbSituacao.Text, // se for ComboBox
                    Unidade = cmbUnidade.Text,   // TextBox ou ComboBox
                    MarcaID = Convert.ToInt32(lblMarcaId.Text),
                    DataValidade = DateTime.TryParseExact(
                        txtDataValidade.Text,
                        "dd/MM/yyyy",
                        CultureInfo.GetCultureInfo("pt-BR"),
                        DateTimeStyles.None,
                        out DateTime dataValida
                    ) ? (DateTime?)dataValida : null,
                    GtinEan = txtGtinEan.Text,
                    Imagem = txtEnderecoImagem.Text,

                    // 🔹 Preenche o objeto Fornecedor
                    Fornecedor = new FornecedorModel
                    {
                        FornecedorID = string.IsNullOrWhiteSpace(txtFornecedorID.Text) ? 0 : Convert.ToInt32(txtFornecedorID.Text),
                        Nome = txtFornecedor.Text
                    },

                    // 🔹 Preenche também o FornecedorID direto (se precisar salvar no banco)
                    FornecedorID = string.IsNullOrWhiteSpace(txtFornecedorID.Text) ? 0 : int.Parse(txtFornecedorID.Text)
                }; // ✅ FECHA o inicializador aqui

                // Chamar o método AlterarProduto da BLL
                ProdutosBLL produtosbll = new ProdutosBLL();
                produtosbll.Alterar(produto);

                Utilitario.Mensagens.Info("Produto alterado com sucesso!");
                Utilitario.LimparCampos(this);
                this.Close();

                var frmManutProduto = Application.OpenForms["FrmManutProduto"] as FrmManutProduto;
                if (frmManutProduto != null)
                {
                    frmManutProduto.HabilitarTimer(true);
                }
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso("Erro ao Alterar o registro: " + ex.Message);
            }
        }


        private void txtPrecoCusto_Leave(object sender, EventArgs e)
        {
            txtPrecoCusto.BackColor = Color.White;
            // Formata apenas se não estiver vazio
            if (!string.IsNullOrWhiteSpace(txtPrecoCusto.Text))
            {
                CalcularPrecoVenda();
            }
            if (!string.IsNullOrWhiteSpace(txtPrecoDeVenda.Text))
            {
                Utilitario.FormatarMoeda(txtPrecoDeVenda);
            }
            Utilitario.FormatarMoeda(txtPrecoCusto);
        }
        private void txtLucro_Leave(object sender, EventArgs e)
        {
            /*Utilitario.FormatTextBoxToCurrency(txtLucro)*/
            ;
            txtLucro.BackColor = Color.White;
            // Formata apenas se não estiver vazio
            if (!string.IsNullOrWhiteSpace(txtLucro.Text))
            {
                CalcularPrecoVenda();
            }
            if (!string.IsNullOrWhiteSpace(txtPrecoDeVenda.Text))
            {
                Utilitario.FormatarMoeda(txtPrecoDeVenda);
            }
            Utilitario.FormatarMoeda(txtLucro);
        }
        private void txtPrecoCusto_Enter(object sender, EventArgs e)
        {
            KryptonTextBox textBox = sender as KryptonTextBox;
            if (textBox != null && textBox.Text == "0,00")
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    textBox.Text = string.Empty;
                });
            }
        }
        private void txtLucro_Enter(object sender, EventArgs e)
        {
            KryptonTextBox textBox = sender as KryptonTextBox;
            if (textBox != null && textBox.Text == "0,00")
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    textBox.Text = string.Empty;
                });
            }
        }
        private void txtPrecoDeVenda_Leave(object sender, EventArgs e)
        {
            CalcularLucro();
        }
        private void FrmCadProdutos_Shown(object sender, EventArgs e)
        {
            Utilitario.AplicarCorFocoNosTextBox(this);
        }
        private void btnLocalizarImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecione uma imagem";
                ofd.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 🔹 Base do sistema (onde o EXE está rodando)
                        string baseDir = AppDomain.CurrentDomain.BaseDirectory; // ou Application.StartupPath
                                                                                // Ex.: C:\GVC\bin\Debug\net8.0-windows7.0\
                                                                                //      D:\GVC\ (se estiver publicado)

                        // 🔹 Pasta "Imagem" dentro do sistema
                        string pastaDestino = Path.Combine(baseDir, "Imagem");

                        // Cria a pasta se não existir
                        if (!Directory.Exists(pastaDestino))
                            Directory.CreateDirectory(pastaDestino);

                        // 🔹 Gera nome único para evitar sobrescrever
                        string nomeOriginal = Path.GetFileName(ofd.FileName);
                        string extensao = Path.GetExtension(nomeOriginal);
                        string nomeBase = Path.GetFileNameWithoutExtension(nomeOriginal);
                        string nomeUnico = $"{nomeBase}_{DateTime.Now:yyyyMMdd_HHmmss}{extensao}";

                        // 🔹 Caminho completo de destino
                        string caminhoDestino = Path.Combine(pastaDestino, nomeUnico);

                        // Copia o arquivo para a pasta de destino
                        File.Copy(ofd.FileName, caminhoDestino, true);

                        // Atualiza o TextBox com o caminho de destino
                        txtEnderecoImagem.Text = caminhoDestino;

                        // Limpa imagem anterior
                        if (pbImagem.Image != null)
                        {
                            pbImagem.Image.Dispose();
                            pbImagem.Image = null;
                        }

                        // Carrega a imagem do destino
                        using (var fs = new FileStream(caminhoDestino, FileMode.Open, FileAccess.Read))
                        {
                            pbImagem.Image = Image.FromStream(fs);
                        }

                        pbImagem.SizeMode = PictureBoxSizeMode.Zoom;
                        pbImagem.Visible = true;
                        pbImagem.Refresh();
                    }
                    catch (Exception ex)
                    {
                        Utilitario.Mensagens.Aviso($"Não foi possível carregar/copiar a imagem.\n\nDetalhes: {ex.Message}");
                    }
                }
            }
        }
        private void AbrirFrmLocalizarFornecedorDinamico()
        {
            // Desliga temporariamente o evento para evitar loop
            txtFornecedor.TextChanged -= txtFornecedor_TextChanged;

            using (FrmLocalizarFornecedor frmLocalizarFornecedor = new FrmLocalizarFornecedor(this, FornecedorSelecionado))
            {
                frmLocalizarFornecedor.Owner = this;
                frmLocalizarFornecedor.ShowDialog();
                txtFornecedor.Text = frmLocalizarFornecedor.FornecedorSelecionado; // Define o nome do cliente retornado
                ClienteID = frmLocalizarFornecedor.FornecedorID; // Define o ID do cliente retornado
                txtFornecedorID.Text = frmLocalizarFornecedor.FornecedorID.ToString(); // Define o ID no TextBox correspondente
            }

            // Religa o evento após modificar o texto
            txtFornecedor.TextChanged += txtFornecedor_TextChanged;
        }
        private void btnLocalizarFornecedor_Click(object sender, EventArgs e)
        {
        }

        private void txtDataValidade_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDataValidade.Text) && txtDataValidade.Text.Length == 10)
            {
                if (!DateTime.TryParseExact(txtDataValidade.Text, "dd/MM/yyyy",
                    CultureInfo.GetCultureInfo("pt-BR"), DateTimeStyles.None, out _))
                {
                    Utilitario.Mensagens.Aviso("Data de validade inválida!");
                    txtDataValidade.Focus();
                    txtDataValidade.SelectAll();
                }
            }
        }

        private void txtDataValidade_TextChanged(object sender, EventArgs e)
        {
            string apenasNums = Utilitario.ApenasNumeros(txtDataValidade.Text);

            if (apenasNums.Length > 8)
                apenasNums = apenasNums.Substring(0, 8);

            string formatado = apenasNums;

            if (apenasNums.Length >= 3)
                formatado = apenasNums.Insert(2, "/");

            if (apenasNums.Length >= 5)
                formatado = formatado.Insert(5, "/");

            int pos = txtDataValidade.SelectionStart;
            txtDataValidade.Text = formatado;
            txtDataValidade.SelectionStart = Math.Min(pos + 1, txtDataValidade.Text.Length);
        }

        private void txtFornecedor_TextChanged(object sender, EventArgs e)
        {
            if (bloqueiaPesquisa || string.IsNullOrWhiteSpace(txtFornecedor.Text))
                return;

            string textoDigitado = txtFornecedor.Text;

            // VERIFICA SE O CONTROLE JÁ TEM UM HANDLE VÁLIDO
            if (!this.IsHandleCreated || txtFornecedor.IsDisposed)
                return;

            // Usa BeginInvoke para "adiar" a abertura da pesquisa até o Windows terminar de processar a digitação
            this.BeginInvoke(new Action(() =>
            {
                if (bloqueiaPesquisa || txtFornecedor.IsDisposed)
                    return;

                // pode ter sido bloqueado enquanto esperava
                bloqueiaPesquisa = true;
                try
                {
                    using (var pesquisarFornecedor = new FrmLocalizarFornecedor(this, textoDigitado))
                    {
                        pesquisarFornecedor.Owner = this;
                        if (pesquisarFornecedor.ShowDialog() == DialogResult.OK)
                        {
                            bloqueiaPesquisa = true;
                            txtFornecedor.Text = pesquisarFornecedor.FornecedorSelecionado;
                            txtFornecedorID.Text = pesquisarFornecedor.FornecedorID.ToString();
                            ClienteID = pesquisarFornecedor.FornecedorID;
                            txtFornecedor.SelectionStart = txtFornecedor.Text.Length;
                        }
                    }
                }
                finally
                {
                    bloqueiaPesquisa = false;
                }
            }));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                Alterar();
            }
            if (StatusOperacao == "NOVO")
            {
                Salvar();
                var frmManutProduto = Application.OpenForms["FrmManutProduto"] as FrmManutProduto;
                if (frmManutProduto != null)
                {
                    frmManutProduto.HabilitarTimer(true);
                }
            }
            if (StatusOperacao == "EXCLUSÃO")
            {
                if (MessageBox.Show("Deseja Excluir? \n\n O Usuário: " + txtNomeProduto.Text + " ??? ", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Excluir();
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Utilitario.LimparCampos(this);
            produtoID = Utilitario.ProximoId("SELECT MAX(ProdutoID) FROM Produto");
            cmbStatus.SelectedIndex = 1;
            cmbSituacao.SelectedIndex = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    e.SuppressKeyPress = true; // Evita o som padrão do Windows
            //    SendKeys.Send("{TAB}"); // Simula a tecla TAB
            //}
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarca.SelectedIndex == 0) return;

            var marcaSelecionada = cmbMarca.SelectedItem as MarcaModel;

            if (marcaSelecionada != null)
            {
                int marcaId = marcaSelecionada.MarcaID;
                string nomeMarca = marcaSelecionada.NomeMarca;

                // Exemplo de uso
                lblMarcaId.Text = marcaId.ToString();               
            }
        }
    }
}