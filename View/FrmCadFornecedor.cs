using GVC.BLL;
using GVC.Model;
using GVC.MUI;
using GVC.UTIL;
using Krypton.Toolkit;
using System;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static GVC.UTIL.BrasilApiCepResponse;

namespace GVC.View
{
    public partial class FrmCadFornecedor : KryptonForm
    {
       

        private readonly FornecedorBll _fornecedorBll = new FornecedorBll();
        private readonly string QueryFornecedor = "SELECT MAX(FornecedorID) FROM Fornecedor";
        public string StatusOperacao { get; set; }
        public bool CarregandoDados { get; set; }
        public int EmpresaID { get; set; }
        public string cidadeSelecionado { get; set; } // não serve para nada só para preencher o parametro do construtor
        private bool bloqueiaPesquisa = false;
        public int FornecedorID { get; set; }
        public int CidadeID { get; set; }

        public FrmCadFornecedor()
        {
            InitializeComponent();
            ConfigurarEventosCep(); // ← ADICIONE ESTA LINHA
        }

        public void DefinirModoEdicao(bool habilitar)
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBoxBase || ctrl is ComboBox || ctrl is DateTimePicker || ctrl is CheckBox)
                {
                    ctrl.Enabled = habilitar;
                }
            }
            txtFornecedorID.Enabled = false;// Sempre deixa o ID travado                       
        }

        // método público chamado pelo formulário pai
        public void CarregarCampos(DataGridViewRow row)
        {
            if (row == null)
                return;

            CarregandoDados = true; // evita eventos indevidos (especialmente SelectedIndexChanged)

            try
            {
                // Identificação
                txtFornecedorID.Text = row.Cells["FornecedorID"].Value?.ToString() ?? "";
                if (int.TryParse(txtFornecedorID.Text, out int id))
                    this.FornecedorID = id;
                else
                    this.FornecedorID = 0;

                txtNomeFornecedor.Text = row.Cells["Nome"].Value?.ToString() ?? "";
                txtCnpj.Text = row.Cells["Cnpj"].Value?.ToString() ?? "";
                txtIE.Text = row.Cells["IE"].Value?.ToString() ?? "";
                txtTelefone.Text = row.Cells["Telefone"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtLogradouro.Text = row.Cells["Logradouro"].Value?.ToString() ?? "";
                txtNumero.Text = row.Cells["Numero"].Value?.ToString() ?? "";
                txtBairro.Text = row.Cells["Bairro"].Value?.ToString() ?? "";
                txtCep.Text = row.Cells["Cep"].Value?.ToString() ?? "";
                this.CidadeID = int.TryParse(row.Cells["CidadeID"].Value?.ToString(), out int cid) ? cid : 0;
                txtCidade.Text = row.Cells["NomeCidade"].Value?.ToString() ?? "";
                txtUF.Text = row.Cells["Estado"].Value?.ToString() ?? "";
                txtObservacoes.Text = row.Cells["Observacoes"].Value?.ToString() ?? "";
                ToolStripLabelDataCriacao.Text = row.Cells["DataCriacao"].Value?.ToString() ?? "";

                // Cnpj — formatação
                string cnpj = row.Cells["Cnpj"].Value?.ToString() ?? "";
                cnpj = new string(cnpj.Where(char.IsDigit).ToArray());
                if (!string.IsNullOrWhiteSpace(cnpj))
                {
                    if (cnpj.Length == 14)
                        txtCnpj.Text = Convert.ToUInt64(cnpj).ToString(@"00\.000\.000\/0000\-00");
                    else
                        txtCnpj.Text = cnpj;
                }

                // Telefone — formatação
                string telefone = row.Cells["Telefone"].Value?.ToString() ?? "";
                telefone = new string(telefone.Where(char.IsDigit).ToArray());
                if (telefone.Length == 10)
                    txtTelefone.Text = Convert.ToUInt64(telefone).ToString(@"(00) 0000\-0000");
                else if (telefone.Length == 11)
                    txtTelefone.Text = Convert.ToUInt64(telefone).ToString(@"(00) 00000\-0000");
                else
                    txtTelefone.Text = telefone;

                // CEP — formatação
                string cep = row.Cells["Cep"].Value?.ToString() ?? "";
                cep = new string(cep.Where(char.IsDigit).ToArray());
                if (cep.Length == 8)
                    txtCep.Text = $"{cep.Substring(0, 5)}-{cep.Substring(5, 3)}";
                else
                    txtCep.Text = cep;

                // Data de nascimento
                if (DateTime.TryParse(row.Cells["DataCriacao"].Value?.ToString(), out DateTime dtN))
                    dtpDataCriacao.Value = dtN;
                else
                    dtpDataCriacao.Value = DateTime.Now;
            }
            finally
            {
                CarregandoDados = false;
            }
        }

        // Colocar dentro do FrmCadFornecedor
        private void HabilitarCampos(bool habilitar)
        {
            // iniciar a recursão a partir do próprio formulário (this)
            SetControlsEnabled(this, habilitar);
        }
        private void SetControlsEnabled(Control parent, bool enabled)
        {
            foreach (Control c in parent.Controls)
            {
                // Habilita/Desabilita TextBox COMUM e KryptonTextBox
                if (c is TextBoxBase ||
                    c is Krypton.Toolkit.KryptonTextBox ||
                    c is MaskedTextBox ||
                    c is ComboBox)
                {
                    c.Enabled = enabled;
                }
                // Continua recursão
                if (c.HasChildren)
                    SetControlsEnabled(c, enabled);
            }
        }
        // 👉 aqui entra o seu método
        private void FrmCadFornecedor_Load(object sender, EventArgs e)
        {
            // Sempre configura máscaras necessárias
            txtCnpj.Tag = "Cnpj";

            // Se está carregando dados (e.g., Alterar/Exclusão), não faz setup de "novo"
            if (CarregandoDados)
            {
                return; // Apenas garante máscaras e sai
            }

            if (StatusOperacao == "NOVO")
            {
                this.Text = "Novo Fornecedor";
                this.StateCommon.Header.Content.ShortText.Color1 = Color.Green;
                this.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12);

                GerarNovoCodigo();

                var frmManutFornecedor = Application.OpenForms["FrmManutFornecedor"] as FrmManutFornecedor;
                frmManutFornecedor?.HabilitarTimer(true);

                toolStripStatusLabelUsuarioCriacao.Text = FrmLogin.UsuarioConectado;
                ToolStripLabelDataCriacao.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                // Como é novo, não existe atualização ainda:
                toolStripStatusLabelUsuarioAtualizacao.Text = "-";
                ToolStripLabelDataUtimaCompra.Text = "-";
            }

            // Finaliza o estado de carregamento
            CarregandoDados = false;
        }

        private void GerarNovoCodigo()
        {
            int novoId = Utilitario.ProximoId(QueryFornecedor);
            FornecedorID = novoId;
            txtFornecedorID.Text = Utilitario.ZerosEsquerda(novoId, 6);
        }

        public void SalvarRegistro()
        {
            try
            {
                var fornecedor = MontarObjetoFornecedor();
                _fornecedorBll.Salvar(fornecedor);

                Utilitario.Mensagens.Aviso("Fornecedor cadastrado com sucesso!");

                var frmManutFornecedor = Application.OpenForms["FrmManutFornecedor"] as FrmManutFornecedor;
                if (frmManutFornecedor != null)
                {
                    frmManutFornecedor.HabilitarTimer(true);
                }
                LimparCampos();
                GerarNovoCodigo();
                txtNomeFornecedor.Focus();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso(ex.Message);
            }
        }
        public void AlterarRegistro()
        {
            try
            {
                var fornecedor = MontarObjetoFornecedor();
                _fornecedorBll.Alterar(fornecedor);

                Utilitario.Mensagens.Aviso("Fornecedor alterado com sucesso!");
                toolStripStatusLabelUsuarioAtualizacao.Text = FrmLogin.UsuarioConectado;
                ToolStripLabelDataUtimaCompra.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                this.Close();

                var frmManutFornecedor = Application.OpenForms["FrmManutFornecedor"] as FrmManutFornecedor;
                if (frmManutFornecedor != null)
                {
                    frmManutFornecedor.HabilitarTimer(true);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Outro fornecedor já está cadastrado"))
                    Utilitario.Mensagens.Aviso(ex.Message);
                else
                    Utilitario.Mensagens.Aviso("Erro inesperado: " + ex.Message);
            }

        }

        public void ExcluirRegistro()
        {
            if (MessageBox.Show($"Deseja realmente excluir o fornecedor:\n\n{txtNomeFornecedor.Text}?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _fornecedorBll.Excluir(FornecedorID);
                    Utilitario.Mensagens.Aviso("Fornecedor excluído com sucesso!");

                    var frmManutFornecedor = Application.OpenForms["FrmManutFornecedor"] as FrmManutFornecedor;
                    if (frmManutFornecedor != null)
                    {
                        frmManutFornecedor.HabilitarTimer(true);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    Utilitario.Mensagens.Aviso("Erro ao excluir: " + ex.Message);
                }
            }
        }

        private FornecedorModel MontarObjetoFornecedor()
        {
            var fornecedor = new FornecedorModel();

            fornecedor.Nome = txtNomeFornecedor.Text.Trim();
            fornecedor.Cnpj = Utilitario.ApenasNumeros(txtCnpj.Text);
            fornecedor.IE = txtIE.Text.Trim();
            fornecedor.Telefone = Utilitario.ApenasNumeros(txtTelefone.Text);
            fornecedor.Email = txtEmail.Text.Trim();
            if (int.TryParse(txtFornecedorID.Text, out int id)) fornecedor.FornecedorID = id;
            fornecedor.CidadeID = CidadeID;
            fornecedor.Logradouro = txtLogradouro.Text.Trim();
            fornecedor.Numero = txtNumero.Text.Trim();
            fornecedor.Bairro = txtBairro.Text.Trim();
            fornecedor.Cep = Utilitario.ApenasNumeros(txtCep.Text);
            fornecedor.Observacoes = txtObservacoes.Text.Trim();
            fornecedor.DataCriacao = DateTime.Now;
            return fornecedor;
        }

        private void AbrirFrmLocalizarCidadeDinamico()
        {
            // Desliga temporariamente o evento para evitar loop
            txtCidade.TextChanged -= txtCidade_TextChanged;

            using (FrmLocalizarCidade frmLocalizarCidade = new FrmLocalizarCidade(this, cidadeSelecionado))
            {
                frmLocalizarCidade.Owner = this;
                frmLocalizarCidade.ShowDialog();
                txtCidade.Text = frmLocalizarCidade.cidadeSelecionado; // Define o nome do fornecedor retornado
            }

            // Religa o evento após modificar o texto
            txtCidade.TextChanged += txtCidade_TextChanged;
        }

        public void PreencherCampos(FornecedorModel fornecedor)
        {
            FornecedorID = (int)fornecedor.FornecedorID;
            txtFornecedorID.Text = Utilitario.ZerosEsquerda((int)fornecedor.FornecedorID, 6);
            txtNomeFornecedor.Text = fornecedor.Nome;

            txtTelefone.Text = fornecedor.Telefone;
            txtEmail.Text = fornecedor.Email;
            txtCidade.Text = fornecedor.Nome ?? ""; // ← aqui tem um erro no seu código! deveria ser NomeCidade ou algo assim
            txtLogradouro.Text = fornecedor.Logradouro;
            txtNumero.Text = fornecedor.Numero;
            txtBairro.Text = fornecedor.Bairro;
            txtCep.Text = fornecedor.Cep;

            if (fornecedor.DataCriacao.HasValue)
                dtpDataCriacao.Text = fornecedor.DataCriacao.Value.ToString("dd/MM/yyyy");

            txtIE.Text = fornecedor.IE;
            txtObservacoes.Text = fornecedor.Observacoes;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (StatusOperacao == "NOVO")
                SalvarRegistro();
            else if (StatusOperacao == "ALTERAR")
                AlterarRegistro();
            else if (StatusOperacao == "EXCLUSAO")
                ExcluirRegistro(); btnSalvar.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            GerarNovoCodigo();
            txtNomeFornecedor.Focus();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            AbrirFrmLocalizarCidadeDinamico();
        }

        private void btnSair_Click(object sender, EventArgs e) => this.Close();

        private void LimparCampos() => Utilitario.LimparCampos(this);

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario.AplicarMascaraCEP(e, txtCep);
        }

        private void txtIE_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario.MascaraIE(e, txtIE);
        }

        private void txtLimiteCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario.MascaraTelefone(sender, e);
        }

        private void FrmCadFornecedor_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }

        private void FrmCadFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            if (bloqueiaPesquisa || string.IsNullOrWhiteSpace(txtCidade.Text))
                return;

            // SALVA O TEXTO ATUAL ANTES DE PERDER O FOCO
            string textoDigitado = txtCidade.Text;

            // VERIFICA SE O CONTROLE JÁ TEM UM HANDLE VÁLIDO
            if (!this.IsHandleCreated || txtCidade.IsDisposed)
                return;

            // Usa BeginInvoke para "adiar" a abertura da pesquisa até o Windows terminar de processar a digitação
            this.BeginInvoke(new Action(() =>
            {
                if (bloqueiaPesquisa || txtCidade.IsDisposed)
                    return;

                // pode ter sido bloqueado enquanto esperava
                bloqueiaPesquisa = true;
                try
                {
                    using (var pesquisaCidade = new FrmLocalizarCidade(this, textoDigitado))
                    {
                        pesquisaCidade.Owner = this;
                        if (pesquisaCidade.ShowDialog() == DialogResult.OK)
                        {
                            bloqueiaPesquisa = true;
                            txtCidade.Text = pesquisaCidade.cidadeSelecionado;
                            CidadeID = pesquisaCidade.CidadeID;
                            txtCidade.SelectionStart = txtCidade.Text.Length;
                        }
                    }
                }
                finally
                {
                    bloqueiaPesquisa = false;
                }
            }));
        }

        private void txtCnpj_Leave(object sender, EventArgs e)
        {
            string numero = Utilitario.ApenasNumeros(txtCnpj.Text);

            if (string.IsNullOrEmpty(numero))
            {
                txtCnpj.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
                return;
            }

            if (numero.Length != 14 || !Utilitario.ValidarCNPJ(numero))
            {
                Utilitario.Mensagens.Aviso("Cnpj inválido!");
                txtCnpj.Focus();
                txtCnpj.StateCommon.Border.Color1 = System.Drawing.Color.Crimson;
                return;
            }

            txtCnpj.Text = Utilitario.FormatarCNPJ(numero);
            txtCnpj.StateCommon.Border.Color1 = System.Drawing.Color.MediumSeaGreen;
        }

        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario.MascaraCNPJ(sender, e);
        }
        private void ConfigurarEventosCep()
        {
            // Substitua txtCep pelo nome do seu TextBox de CEP no FrmCadFornecedor
            txtCep.KeyDown -= txtCep_KeyDown;
            txtCep.KeyDown += txtCep_KeyDown;

            // Configura propriedades importantes do TextBox
            txtCep.AcceptsReturn = false;
            txtCep.Multiline = false;

            // Tooltip
            toolTip.SetToolTip(txtCep, "Digite o CEP e pressione ENTER para buscar");
        }
        private async Task BuscarEnderecoPorCep()
        {
            // ========== 1. VALIDAÇÃO DO CEP ==========
            if (!ValidarCepParaBusca())
                return;

            // ========== 2. PREPARAÇÃO DA INTERFACE ==========
            ConfigurarInterfaceBusca(true);

            try
            {
                // ========== 3. BUSCA NA API ==========
                var endereco = await ExecutarBuscaCep();
                if (endereco == null)
                    return;

                // Desliga temporariamente eventos se houver
                // txtNomeCidade.TextChanged -= txtNomeCidade_TextChanged; // Se tiver esse evento

                // Desliga temporariamente o evento para evitar loop
                txtCidade.TextChanged -= txtCidade_TextChanged;
                // ========== 4. PREENCHIMENTO DOS CAMPOS ==========
                PreencherCamposEndereco(endereco);

                // ========== 5. FEEDBACK E NAVEGAÇÃO ==========
                ProcessarSucessoBusca(endereco);
            }
            catch (Exception ex)
            {
                TratarErroBusca(ex);
            }
            finally
            {
                // ========== 6. LIMPEZA FINAL ==========
                ConfigurarInterfaceBusca(false);
            }

            // Religa eventos se necessário
             txtCidade.TextChanged += txtCidade_TextChanged;
        }
        private bool ValidarCepParaBusca()
        {
            string cepDigitado = txtCep.Text?.Trim() ?? "";

            // Ignora CEP vazio ou apenas máscara
            if (string.IsNullOrWhiteSpace(cepDigitado) ||
                cepDigitado == "-" ||
                cepDigitado.Replace("_", "").Replace("-", "").Length == 0)
            {
                Debug.WriteLine("CEP ignorado (vazio/máscara)");
                return false;
            }

            string cepNumeros = CepService.LimparCep(cepDigitado);

            // Valida quantidade mínima de dígitos
            if (cepNumeros.Length < 5)
            {
                return false;
            }

            // Validação completa
            if (cepNumeros.Length != 8 || !CepService.ValidarCep(cepNumeros))
            {
                Utilitario.Mensagens.Aviso($"CEP '{txtCep.Text}' é inválido.\nDigite 8 dígitos.");
                txtCep.SelectAll();
                txtCep.Focus();
                return false;
            }

            return true;
        }

        private void ConfigurarInterfaceBusca(bool emAndamento)
        {
            if (emAndamento)
            {
                this.Cursor = Cursors.WaitCursor;
                // Opcional: desabilitar botão durante a busca
                // btnBuscarEnderecoPorCep.Enabled = false; // Se tiver botão
            }
            else
            {
                this.Cursor = Cursors.Default;
                // btnBuscarEnderecoPorCep.Enabled = true;
            }
        }

        private async Task<BrasilApiResponse> ExecutarBuscaCep()
        {
            string cepNumeros = CepService.LimparCep(txtCep.Text);

            var endereco = await CepService.BuscarEnderecoPorCepAsync(cepNumeros);

            if (endereco == null || !endereco.EhValido)
            {
                Utilitario.Mensagens.Info($"CEP {txtCep.Text} não encontrado.");
                return null;
            }

            return endereco;
        }

        private void PreencherCamposEndereco(BrasilApiResponse endereco)
        {
            // Preenche campos básicos - AJUSTE OS NOMES DOS SEUS CONTROLES!
            txtLogradouro.Text = endereco.Logradouro ?? "";
            txtBairro.Text = endereco.Bairro ?? "";
            txtCidade.Text = endereco.Cidade ?? ""; // Ajuste o nome do seu campo de cidade

            // Busca CidadeID no banco (se necessário)
            string nomeCidade = endereco.Cidade ?? "";
            string query = $"SELECT CidadeID FROM Cidade WHERE Nome = @NomeCidade";
            string cidadeIdStr = Utilitario.PesquisarPorCodigoRetornarNome(query, "NomeCidade", nomeCidade);

            if (int.TryParse(cidadeIdStr, out int cidadeId))
            {
                // Armazene o CidadeID se seu formulário precisar
                this.CidadeID = cidadeId; // Descomente se tiver essa propriedade
            }

            // Preenche Uf
            txtUF.Text = endereco.SiglaEstado ?? "";
            txtUF.Refresh();
            Application.DoEvents();

            // Formata o CEP para exibição
            txtCep.Text = CepService.FormatarCep(endereco.Cep);
        }

        private void ProcessarSucessoBusca(BrasilApiResponse endereco)
        {
            // Feedback visual silencioso
            MostrarFeedbackSilencioso(endereco);

            // Navega para próximo campo
            AvancarParaProximoCampo();
        }

        private void TratarErroBusca(Exception ex)
        {
            Debug.WriteLine($"Erro ao buscar CEP: {ex.Message}");
            Utilitario.Mensagens.Aviso($"Erro ao buscar CEP: {ex.Message}");
        }

        private void MostrarFeedbackSilencioso(BrasilApiResponse endereco)
        {
            // Exemplo: alterar cor do campo CEP temporariamente
            Color corOriginal = txtCep.ForeColor;
            txtCep.ForeColor = Color.Green;

            // Timer para restaurar cor após 1 segundo
            System.Windows.Forms.Timer timerFeedback = new System.Windows.Forms.Timer { Interval = 1000 };
            timerFeedback.Tick += (s, e) =>
            {
                txtCep.ForeColor = corOriginal;
                timerFeedback.Stop();
                timerFeedback.Dispose();
            };
            timerFeedback.Start();

            // Opcional: Log no console
            Debug.WriteLine($"✅ Endereço encontrado: {endereco.Logradouro}, {endereco.Cidade}/{endereco.SiglaEstado}");
        }

        private void AvancarParaProximoCampo()
        {
            // Ajuste conforme os campos do seu formulário de fornecedor
            if (string.IsNullOrWhiteSpace(txtNumero.Text)) // Ajuste o nome do campo
            {
                txtNumero.Focus();
            }
            else
            {
                txtCidade.Focus(); // Ou outro campo apropriado
            }
        }

        private void DestacarCamposPreenchidos()
        {
            Color corDestaque = Color.FromArgb(240, 255, 240); // Verde claro

            // Ajuste os nomes dos controles
            txtLogradouro.BackColor = corDestaque;
            txtBairro.BackColor = corDestaque;
            txtCidade.BackColor = corDestaque;
            txtUF.BackColor = corDestaque;

            // Remove após 1.5 segundos
            var timer = new System.Windows.Forms.Timer { Interval = 1500 };
            timer.Tick += (s, e) =>
            {
                Color corPadrao = SystemColors.Window;
                txtLogradouro.BackColor = corPadrao;
                txtBairro.BackColor = corPadrao;
                txtCidade.BackColor = corPadrao;
                txtUF.BackColor = corPadrao;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }
        private async void txtCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                await BuscarEnderecoPorCep();
            }
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            // Auto-formata ao sair do campo
            if (!string.IsNullOrWhiteSpace(txtCep.Text))
            {
                CepService.ValidarEFormatarCEPnoTextbox(txtCep);
            }
        }

        private async void btnBuscarEnderecoPorCep_Click(object sender, EventArgs e)
        {
            await BuscarEnderecoPorCep();
        }
    }
}