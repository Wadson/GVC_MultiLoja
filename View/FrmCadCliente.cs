using GVC.BLL;
using GVC.MODEL;
using GVC.MUI;
using GVC.UTIL;
using iText.StyledXmlParser.Jsoup.Nodes;
using Krypton.Toolkit;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GVC.UTIL.BrasilApiCepResponse;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GVC.View
{
    public partial class FrmCadCliente : KryptonForm
    {
        public bool CarregandoDados { get; set; }

        private readonly ClienteBLL _clienteBll = new ClienteBLL();
        private readonly string QueryClientes = "SELECT MAX(ClienteID) FROM Clientes";
        public string StatusOperacao { get; set; }
        public string cidadeSelecionado { get; set; } // não serve para nada só para preencher o parametro do construtor
        private bool bloqueiaPesquisa = false;
        public int ClienteID { get; set; }
        public int CidadeID { get; set; }
        private bool isVendedor { get; set; }

        public FrmCadCliente()
        {
            InitializeComponent();
            ConfigurarEventosCep();

            cmbTipoCliente.Items.Clear();
            cmbTipoCliente.Items.AddRange(new[] { "Física", "Jurídica", "Operador", "Administrador", "Consumidor Final" });
            // Adicione esta linha para garantir um valor padrão
            cmbTipoCliente.SelectedIndex = 0;
        }
        private void txtCep_Leave(object sender, EventArgs e)
        {
            // Auto-formata ao sair do campo
            if (!string.IsNullOrWhiteSpace(txtCep.Text))
            {
                CepService.ValidarEFormatarCEPnoTextbox(txtCep);
            }
        }
        // Por isto:

        private void ConfigurarEventosCep()
        {
            // 3. Verifica se foi registrado
            var events = txtCep.GetType().GetEvent("KeyDown");
            Console.WriteLine($"Evento KeyDown registrado: {events != null}");

            // 4. Configura propriedades importantes do TextBox
            txtCep.AcceptsReturn = false; // IMPORTANTE: TextBox não deve aceitar Enter como nova linha
            txtCep.Multiline = false;     // Garante que é single-line

            // 5. Tooltip
            toolTip.SetToolTip(txtCep, "Digite o CEP e pressione ENTER para buscar");
        }

        // =============================================
        // MÉTODO PRINCIPAL DE BUSCA
        // =============================================
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
                // Desliga temporariamente o evento para evitar loop
                txtNomeCidade.TextChanged -= txtNomeCidade_TextChanged;
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
            // Religa o evento após modificar o texto
            txtNomeCidade.TextChanged += txtNomeCidade_TextChanged;
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
                return false; // Silêncio total para CEPs muito curtos
            }

            // Validação completa
            if (cepNumeros.Length != 8 || !CepService.ValidarCep(cepNumeros))
            {
                MessageBox.Show($"CEP '{txtCep.Text}' é inválido.\nDigite 8 dígitos.",
                               "CEP Inválido",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                txtCep.SelectAll();
                txtCep.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Configura estado da interface durante a busca
        /// </summary>
        private void ConfigurarInterfaceBusca(bool emAndamento)
        {
            if (emAndamento)
            {
                this.Cursor = Cursors.WaitCursor;
                // Opcional: desabilitar botão durante a busca
                btnBuscarEnderecoPorCep.Enabled = false;
            }
            else
            {
                this.Cursor = Cursors.Default;
                btnBuscarEnderecoPorCep.Enabled = true;
            }
        }

        /// <summary>
        /// Executa a busca na API de CEP
        /// </summary>
        private async Task<BrasilApiResponse> ExecutarBuscaCep()
        {
            string cepNumeros = CepService.LimparCep(txtCep.Text);

            var endereco = await CepService.BuscarEnderecoPorCepAsync(cepNumeros);

            if (endereco == null || !endereco.EhValido)
            {
                MessageBox.Show($"CEP {txtCep.Text} não encontrado.",
                               "CEP não encontrado",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                return null;
            }

            return endereco;
        }

        /// <summary>
        /// Preenche todos os campos de endereço com os dados retornados
        /// </summary>
        private void PreencherCamposEndereco(BrasilApiResponse endereco)
        {
            // Preenche campos básicos
            txtLogradouro.Text = endereco.Logradouro ?? "";
            txtBairro.Text = endereco.Bairro ?? "";
            txtNomeCidade.Text = endereco.Cidade ?? "";

            string nomeCidade = endereco.Cidade ?? "";
            string query = $"SELECT CidadeID FROM Cidade WHERE Nome = @NomeCidade";
            //string query, string nomeParametro, object parametro
            string cidadeIdStr = Utilitario.PesquisarPorCodigoRetornarNome(query, "NomeCidade", nomeCidade);

            if (int.TryParse(cidadeIdStr, out int cidadeId))
            {
                CidadeID = cidadeId;
            }
            else
            {
                CidadeID = 0; // ou outro valor padrão apropriado
            }

            // Preenche UF com garantia de atualização visual
            txtUF.Text = endereco.SiglaEstado ?? "";
            txtUF.Refresh();
            Application.DoEvents();

            Debug.WriteLine($"✅ UF definido: '{txtUF.Text}'");

            // Formata o CEP para exibição
            txtCep.Text = CepService.FormatarCep(endereco.Cep);
        }

        /// <summary>
        /// Processa ações após busca bem-sucedida
        /// </summary>
        private void ProcessarSucessoBusca(BrasilApiResponse endereco)
        {
            // Feedback visual silencioso
            MostrarFeedbackSilencioso(endereco);

            // Navega para próximo campo
            AvancarParaProximoCampo();
        }

        /// <summary>
        /// Trata erros durante a busca
        /// </summary>
        private void TratarErroBusca(Exception ex)
        {
            Debug.WriteLine($"Erro ao buscar CEP: {ex.Message}");
            MessageBox.Show($"Erro ao buscar CEP: {ex.Message}",
                           "Erro na Busca",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
        }

        /// <summary>
        /// Mostra feedback visual sem interromper o usuário
        /// </summary>
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

        /// <summary>
        /// Avança para o próximo campo lógico após preenchimento
        /// </summary>
        private void AvancarParaProximoCampo()
        {
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                txtNumero.Focus();
            }
            else
            {
                txtNomeCidade.Focus();
            }
        }

        // Destaque visual
        private void DestacarCamposPreenchidos()
        {
            Color corDestaque = Color.FromArgb(240, 255, 240); // Verde claro

            txtLogradouro.BackColor = corDestaque;
            txtBairro.BackColor = corDestaque;
            txtNomeCidade.BackColor = corDestaque;
            txtUF.BackColor = corDestaque;

            // Remove após 1.5 segundos
            var timer = new System.Windows.Forms.Timer { Interval = 1500 };
            timer.Tick += (s, e) =>
            {
                Color corPadrao = SystemColors.Window;
                txtLogradouro.BackColor = corPadrao;
                txtBairro.BackColor = corPadrao;
                txtNomeCidade.BackColor = corPadrao;
                txtUF.BackColor = corPadrao;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }
        // =============================================
        // MÉTODOS AUXILIARES
        // =============================================

        private void SetControlesEnderecoEstado(bool habilitado)
        {
            if (txtCep.InvokeRequired)
            {
                txtCep.Invoke(new Action(() => SetControlesEnderecoEstado(habilitado)));
                return;
            }

            txtCep.Enabled = habilitado;
            txtLogradouro.Enabled = habilitado;
            txtNumero.Enabled = habilitado;
            txtBairro.Enabled = habilitado;
            txtNomeCidade.Enabled = habilitado;
            txtUF.Enabled = habilitado;
        }

        private void MostrarStatusBusca(string mensagem, Color cor)
        {
            // Se tiver um label para status
            if (lblStatus != null && !lblStatus.IsDisposed)
            {
                lblStatus.Text = mensagem;
                lblStatus.ForeColor = cor;
                lblStatus.Visible = true;
            }
        }


        private void AplicarConfiguracaoTipoCliente(string tipoCliente, bool preenchendoCampos = false)
        {
            // Define se o cliente é pessoa física (usa CPF) ou jurídica (usa CNPJ)
            bool isCpf = tipoCliente == "Física" ||
                         tipoCliente == "Operador" ||
                         tipoCliente == "Administrador" ||
                         tipoCliente == "Consumidor Final";

            // Remove máscaras antigas (se necessário)
            if (!preenchendoCampos)
            {
                txtCpf.KeyPress -= Utilitario.MascaraCPF;
                txtCnpj.KeyPress -= Utilitario.MascaraCNPJ;
            }

            // PESSOA FÍSICA ou tipos que usam CPF
            if (isCpf)
            {
                if (!preenchendoCampos)
                    txtCpf.KeyPress += Utilitario.MascaraCPF;

                // Mostrar campos PF
                txtCpf.Visible = true;
                lblCpf.Visible = true;
                txtRg.Visible = true;
                lblRG.Visible = true;
                txtOrgaoExpedidorRG.Visible = true;
                lblOrgaoExpedidorRG.Visible = true;

                // Esconder campos PJ
                lblRotuloCnpj.Visible = false;
                lblRotuloIE.Visible = false;
                txtCnpj.Visible = false;
                txtIE.Visible = false;

                // Rótulo da data
                lblRotuloDtNascDtCriacao.Text = "Data Nascimento:";
            }
            // PESSOA JURÍDICA
            else if (tipoCliente == "Jurídica")
            {
                if (!preenchendoCampos)
                    txtCnpj.KeyPress += Utilitario.MascaraCNPJ;

                // Esconder campos PF
                txtCpf.Visible = false;
                lblCpf.Visible = false;
                txtOrgaoExpedidorRG.Visible = false;
                lblOrgaoExpedidorRG.Visible = false;
                lblRG.Visible = false;
                txtRg.Visible = false;

                // Mostrar campos PJ
                lblRotuloCnpj.Visible = true;
                lblRotuloIE.Visible = true;
                txtCnpj.Visible = true;
                txtIE.Visible = true;

                // Rótulo da data
                lblRotuloDtNascDtCriacao.Text = "Data Criação:";
            }
            else
            {
                // Tipo não reconhecido, usa padrão (PF)
                if (!preenchendoCampos)
                    txtCpf.KeyPress += Utilitario.MascaraCPF;

                txtCpf.Visible = true;
                lblCpf.Visible = true;
                txtRg.Visible = true;
                lblRG.Visible = true;
                txtOrgaoExpedidorRG.Visible = true;
                lblOrgaoExpedidorRG.Visible = true;

                lblRotuloCnpj.Visible = false;
                lblRotuloIE.Visible = false;
                txtCnpj.Visible = false;
                txtIE.Visible = false;
            }

            // Força atualização imediata
            this.Update();
            Application.DoEvents();

            // DEBUG
            Debug.WriteLine($"AplicarConfiguracaoTipoCliente: {tipoCliente}, isCpf: {isCpf}");
        }
        // método público chamado pelo formulário pai
        public void CarregarCampos(DataGridViewRow row)
        {
            if (row == null)
                return;

            CarregandoDados = true; // evita eventos indevidos

            try
            {
                // ========== 1. CARREGA IDENTIFICAÇÃO BÁSICA ==========
                txtClienteID.Text = row.Cells["ClienteID"].Value?.ToString() ?? "";
                if (int.TryParse(txtClienteID.Text, out int id))
                    this.ClienteID = id;
                else
                    this.ClienteID = 0;

                txtNomeCliente.Text = row.Cells["Nome"].Value?.ToString() ?? "";

                // ========== 2. CARREGA DOCUMENTOS (SEM MASCARAR) ==========
                string cpfValue = row.Cells["Cpf"].Value?.ToString() ?? "";
                string cnpjValue = row.Cells["Cnpj"].Value?.ToString() ?? "";

                // Salva valores brutos para usar depois
                string rgValue = row.Cells["RG"].Value?.ToString() ?? "";
                string ieValue = row.Cells["IE"].Value?.ToString() ?? "";
                string orgaoValue = row.Cells["OrgaoExpedidorRG"].Value?.ToString() ?? "";

                // ========== 3. CARREGA CONTATO E ENDEREÇO ==========
                txtTelefone.Text = row.Cells["Telefone"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtLogradouro.Text = row.Cells["Logradouro"].Value?.ToString() ?? "";
                txtNumero.Text = row.Cells["Numero"].Value?.ToString() ?? "";
                txtBairro.Text = row.Cells["Bairro"].Value?.ToString() ?? "";
                txtCep.Text = row.Cells["Cep"].Value?.ToString() ?? "";

                this.CidadeID = int.TryParse(row.Cells["CidadeID"].Value?.ToString(), out int cid) ? cid : 0;
                txtNomeCidade.Text = row.Cells["NomeCidade"].Value?.ToString() ?? "";
                txtUF.Text = row.Cells["Estado"].Value?.ToString() ?? "";
                chkIsVendedor.Checked = row.Cells["IsVendedor"].Value is bool b && b;


                // ========== 4. DETERMINA E APLICA O TIPO DE CLIENTE ==========
                string tipoCliente = row.Cells["TipoCliente"].Value?.ToString() ?? "";

                // Se não tem tipo definido OU se tem mas queremos garantir, tenta determinar pelos documentos
                if (string.IsNullOrEmpty(tipoCliente) || tipoCliente == "Jurídica")
                {
                    // Pega o tipo do banco para passar como parâmetro
                    string tipoBanco = row.Cells["TipoCliente"].Value?.ToString() ?? "";

                    // Chama o método melhorado
                    tipoCliente = DetermineTipoPorDocumento(cpfValue, cnpjValue, tipoBanco);
                }
                else if (tipoCliente == "Física" ||
                        tipoCliente == "Operador" ||
                        tipoCliente == "Administrador" ||
                        tipoCliente == "Consumidor Final")
                {
                    // Já é um tipo que usa CPF, mantém
                    // Não precisa fazer nada
                }

                // PRIMEIRO: Aplica a configuração visual dos campos
                AplicarConfiguracaoTipoCliente(tipoCliente, true);

                // SEGUNDO: Seleciona no ComboBox (isso é apenas visual)
                // IMPORTANTE: Para tipos como "Operador", "Administrador", etc., 
                // precisamos selecionar o item correto
                SelecionarTipoNoComboBox(tipoCliente);

                // ========== 5. PREENCHE OS CAMPOS DE DOCUMENTO ==========
                if (tipoCliente == "Jurídica")
                {
                    // PESSOA JURÍDICA: Preenche CNPJ e IE
                    cnpjValue = new string(cnpjValue.Where(char.IsDigit).ToArray());
                    if (!string.IsNullOrWhiteSpace(cnpjValue))
                    {
                        if (cnpjValue.Length == 14)
                            txtCnpj.Text = Utilitario.FormatarCNPJ(cnpjValue);
                        else
                            txtCnpj.Text = cnpjValue;
                    }

                    txtIE.Text = ieValue;
                }
                else
                {
                    // PESSOA FÍSICA: Preenche CPF, RG e Órgão
                    cpfValue = new string(cpfValue.Where(char.IsDigit).ToArray());
                    if (!string.IsNullOrWhiteSpace(cpfValue))
                    {
                        if (cpfValue.Length == 11)
                            txtCpf.Text = Convert.ToUInt64(cpfValue).ToString(@"000\.000\.000\-00");
                        else
                            txtCpf.Text = cpfValue;
                    }

                    txtRg.Text = rgValue;
                    txtOrgaoExpedidorRG.Text = orgaoValue;
                }

                // ========== 6. CARREGA DEMAIS CAMPOS ==========
                // Status
                string statusValue = row.Cells["Status"].Value?.ToString() ?? "";
                string statusText = statusValue == "1" ? "Ativo" : "Inativo";
                if (!string.IsNullOrWhiteSpace(statusText))
                    cmbStatus.SelectedItem = statusText;

                txtObservacoes.Text = row.Cells["Observacoes"].Value?.ToString() ?? "";

                // Datas
                ToolStripLabelDataUtimaCompra.Text = row.Cells["DataUltimaCompra"].Value?.ToString() ?? "";
                ToolStripLabelDataCriacao.Text = row.Cells["DataCriacao"].Value?.ToString() ?? "";
                toolStripStatusLabelDataAtualizacao.Text = row.Cells["DataAtualizacao"].Value?.ToString() ?? "";
                toolStripStatusLabelUsuarioCriacao.Text = row.Cells["UsuarioCriacao"].Value?.ToString() ?? "";
                toolStripStatusLabelUsuarioAtualizacao.Text = row.Cells["UsuarioAtualizacao"].Value?.ToString() ?? "";

                // Formata telefone
                string telefone = row.Cells["Telefone"].Value?.ToString() ?? "";
                telefone = new string(telefone.Where(char.IsDigit).ToArray());
                if (telefone.Length == 10)
                    txtTelefone.Text = Convert.ToUInt64(telefone).ToString(@"(00) 0000\-0000");
                else if (telefone.Length == 11)
                    txtTelefone.Text = Convert.ToUInt64(telefone).ToString(@"(00) 00000\-0000");

                // Formata CEP
                string cep = row.Cells["Cep"].Value?.ToString() ?? "";
                cep = new string(cep.Where(char.IsDigit).ToArray());
                if (cep.Length == 8)
                    txtCep.Text = $"{cep.Substring(0, 5)}-{cep.Substring(5, 3)}";

                // Limite de crédito
                decimal limite = 0;
                decimal.TryParse(row.Cells["LimiteCredito"].Value?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out limite);
                txtLimiteCredito.Text = limite.ToString("#,##0.00");

                // Data de nascimento
                if (DateTime.TryParse(row.Cells["DataNascimento"].Value?.ToString(), out DateTime dtN))
                    dtpDataNascimento.Value = dtN;
                else
                    dtpDataNascimento.Value = DateTime.Now;
            }
            finally
            {
                CarregandoDados = false;

                // DEBUG: Verificar se está configurado corretamente
                Debug.WriteLine($"=== PÓS-CARREGAMENTO ===");
                Debug.WriteLine($"Tipo: {cmbTipoCliente.Text}");
                Debug.WriteLine($"CPF Visível: {txtCpf.Visible}");
                Debug.WriteLine($"CNPJ Visível: {txtCnpj.Visible}");
                Debug.WriteLine($"RG Visível: {txtRg.Visible}");
                Debug.WriteLine($"IE Visível: {txtIE.Visible}");
            }
        }
        private void SelecionarTipoNoComboBox(string tipoCliente)
        {
            if (string.IsNullOrWhiteSpace(tipoCliente))
                return;

            // Verifica se é um tipo que usa CPF
            bool isTipoComCpf = tipoCliente == "Física" ||
                               tipoCliente == "Operador" ||
                               tipoCliente == "Administrador" ||
                               tipoCliente == "Consumidor Final";

            // Se for um tipo que usa CPF, mas não está na lista, mapeia para "Física"
            string tipoParaBuscar = tipoCliente;
            if (isTipoComCpf && !cmbTipoCliente.Items.Cast<string>().Any(x => x.Equals(tipoCliente, StringComparison.OrdinalIgnoreCase)))
            {
                tipoParaBuscar = "Física";
            }

            // Procura o item correspondente
            for (int i = 0; i < cmbTipoCliente.Items.Count; i++)
            {
                if (cmbTipoCliente.Items[i].ToString().Equals(tipoParaBuscar, StringComparison.OrdinalIgnoreCase))
                {
                    cmbTipoCliente.SelectedIndex = i;
                    return;
                }
            }

            // Se não encontrou, usa o primeiro item
            cmbTipoCliente.SelectedIndex = 0;
        }
        private void VerificarConfiguracaoCampos()
        {
            Debug.WriteLine($"=== CONFIGURAÇÃO DE CAMPOS ===");
            Debug.WriteLine($"Tipo Cliente: {cmbTipoCliente.Text}");
            Debug.WriteLine($"CPF Visible: {txtCpf.Visible}");
            Debug.WriteLine($"CNPJ Visible: {txtCnpj.Visible}");
            Debug.WriteLine($"RG Visible: {txtRg.Visible}");
            Debug.WriteLine($"IE Visible: {txtIE.Visible}");
            Debug.WriteLine($"OrgaoExpedidorRG Visible: {txtOrgaoExpedidorRG.Visible}");
            Debug.WriteLine($"==============================");
        }
        private string DetermineTipoPorDocumento(string cpf, string cnpj, string tipoClienteBanco)
        {
            // Se o tipo já está definido no banco, use-o
            if (!string.IsNullOrWhiteSpace(tipoClienteBanco))
            {
                return tipoClienteBanco;
            }

            // Limpa os documentos
            string cpfLimpo = new string(cpf.Where(char.IsDigit).ToArray());
            string cnpjLimpo = new string(cnpj.Where(char.IsDigit).ToArray());

            // Se tem CNPJ válido (14 dígitos)
            if (cnpjLimpo.Length == 14)
            {
                return "Jurídica";
            }
            // Se tem CPF válido (11 dígitos) e NÃO tem CNPJ válido
            else if (cpfLimpo.Length == 11 && cnpjLimpo.Length != 14)
            {
                return "Física";
            }

            // Padrão (se não conseguiu determinar)
            return "Física";
        }
        // método público chamado pelo formulário pai
        //public void CarregarCampos(DataGridViewRow row)
        //{
        //    if (row == null)
        //        return;

        //    CarregandoDados = true; // evita eventos indevidos (especialmente SelectedIndexChanged)

        //    try
        //    {
        //        // Identificação
        //        txtClienteID.Text = row.Cells["ClienteID"].Value?.ToString() ?? "";
        //        if (int.TryParse(txtClienteID.Text, out int id))
        //            this.ClienteID = id;
        //        else
        //            this.ClienteID = 0;

        //        txtNomeCliente.Text = row.Cells["Nome"].Value?.ToString() ?? "";

        //        // Documentos
        //        txtCpf.Text = row.Cells["Cpf"].Value?.ToString() ?? "";
        //        txtRg.Text = row.Cells["RG"].Value?.ToString() ?? "";
        //        txtOrgaoExpedidorRG.Text = row.Cells["OrgaoExpedidorRG"].Value?.ToString() ?? "";

        //        // Contato
        //        txtTelefone.Text = row.Cells["Telefone"].Value?.ToString() ?? "";
        //        txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";

        //        // Endereço
        //        txtLogradouro.Text = row.Cells["Logradouro"].Value?.ToString() ?? "";
        //        txtNumero.Text = row.Cells["Numero"].Value?.ToString() ?? "";
        //        txtBairro.Text = row.Cells["Bairro"].Value?.ToString() ?? "";
        //        txtCep.Text = row.Cells["Cep"].Value?.ToString() ?? "";
        //        this.CidadeID = int.TryParse(row.Cells["CidadeID"].Value?.ToString(), out int cid) ? cid : 0;
        //        txtNomeCidade.Text = row.Cells["NomeCidade"].Value?.ToString() ?? "";
        //        txtUF.Text = row.Cells["Estado"].Value?.ToString() ?? "";

        //        // Cliente
        //        string tipoCliente = row.Cells["TipoCliente"].Value?.ToString() ?? "";
        //        if (!string.IsNullOrWhiteSpace(tipoCliente))
        //            cmbTipoCliente.SelectedItem = tipoCliente;


        //        // Recupera o valor literal do BD (0 ou 1)
        //        string statusValue = row.Cells["Status"].Value?.ToString() ?? "";

        //        string statusText = "";

        //        if (statusValue == "1")
        //        {
        //            statusText = "Ativo";
        //        }
        //        else if (statusValue == "0")
        //        {
        //            statusText = "Inativo";
        //        }
        //        // Note: Se o valor for null/vazio, statusText permanece vazio.

        //        // Tenta selecionar o texto correspondente no ComboBox
        //        if (!string.IsNullOrWhiteSpace(statusText))
        //        {
        //            // Use SelectedItem para selecionar o item cujo texto é "Ativo" ou "Inativo"
        //            cmbStatus.SelectedItem = statusText;
        //        }

        //        txtObservacoes.Text = row.Cells["Observacoes"].Value?.ToString() ?? "";

        //        // Datas
        //        ToolStripLabelDataUtimaCompra.Text = row.Cells["DataUltimaCompra"].Value?.ToString() ?? "";
        //        ToolStripLabelDataCriacao.Text = row.Cells["DataCriacao"].Value?.ToString() ?? "";
        //        toolStripStatusLabelDataAtualizacao.Text = row.Cells["DataAtualizacao"].Value?.ToString() ?? "";
        //        toolStripStatusLabelUsuarioCriacao.Text = row.Cells["UsuarioCriacao"].Value?.ToString() ?? "";
        //        toolStripStatusLabelUsuarioAtualizacao.Text = row.Cells["UsuarioAtualizacao"].Value?.ToString() ?? "";

        //        // CPF — formatação
        //        string cpf = row.Cells["Cpf"].Value?.ToString() ?? "";
        //        cpf = new string(cpf.Where(char.IsDigit).ToArray());
        //        if (!string.IsNullOrWhiteSpace(cpf))
        //        {
        //            if (cpf.Length == 11)
        //                txtCpf.Text = Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        //            else
        //                txtCpf.Text = cpf;
        //        }

        //        // Telefone — formatação
        //        string telefone = row.Cells["Telefone"].Value?.ToString() ?? "";
        //        telefone = new string(telefone.Where(char.IsDigit).ToArray());
        //        if (telefone.Length == 10)
        //            txtTelefone.Text = Convert.ToUInt64(telefone).ToString(@"(00) 0000\-0000");
        //        else if (telefone.Length == 11)
        //            txtTelefone.Text = Convert.ToUInt64(telefone).ToString(@"(00) 00000\-0000");
        //        else
        //            txtTelefone.Text = telefone;

        //        // CEP — formatação
        //        string cep = row.Cells["Cep"].Value?.ToString() ?? "";
        //        cep = new string(cep.Where(char.IsDigit).ToArray());
        //        if (cep.Length == 8)
        //            txtCep.Text = $"{cep.Substring(0, 5)}-{cep.Substring(5, 3)}";
        //        else
        //            txtCep.Text = cep;

        //        // Limite de crédito — formatação
        //        decimal limite = 0;
        //        decimal.TryParse(row.Cells["LimiteCredito"].Value?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out limite);
        //        txtLimiteCredito.Text = limite.ToString("#,##0.00");

        //        // Data de nascimento
        //        if (DateTime.TryParse(row.Cells["DataNascimento"].Value?.ToString(), out DateTime dtN))
        //            dtpDataNascimento.Value = dtN;
        //        else
        //            dtpDataNascimento.Value = DateTime.Now;
        //    }
        //    finally
        //    {
        //        CarregandoDados = false;
        //    }
        //}

        // Colocar dentro do FrmCadCliente
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
                    c is System.Windows.Forms.ComboBox)
                {
                    c.Enabled = enabled;
                }
                // Continua recursão
                if (c.HasChildren)
                    SetControlsEnabled(c, enabled);
            }
        }
        // 👉 aqui entra o seu método
        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            {
                if (CarregandoDados)
                {
                    // apenas garante máscara/Tag sem limpar o campo
                    bool isCpf = cmbTipoCliente.Text == "Física" ||
                                 cmbTipoCliente.Text == "Operador" ||
                                 cmbTipoCliente.Text == "Administrador" ||
                                 cmbTipoCliente.Text == "Consumidor Final";

                    // CPF sempre usa máscara de CPF
                    txtCpf.Tag = "CPF";
                    //txtCpf.KeyPress -= Utilitario.MascaraCPF;
                    //txtCpf.KeyPress += Utilitario.MascaraCPF;

                    return;
                }

                // ================================
                // 👍 SE MODO NOVO → Gerar código
                // ================================
                if (StatusOperacao == "NOVO")
                {

                    GerarNovoCodigo();   // <-- AQUI FUNCIONA!

                    var frmManutCliente = Application.OpenForms["FrmManutCliente"] as FrmManutCliente;
                    frmManutCliente?.HabilitarTimer(true);

                    toolStripStatusLabelUsuarioCriacao.Text = FrmLogin.UsuarioConectado;
                    ToolStripLabelDataCriacao.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                    // Como é novo, não existe atualização ainda:
                    toolStripStatusLabelUsuarioAtualizacao.Text = "-";
                    ToolStripLabelDataUtimaCompra.Text = "-";

                    cmbTipoCliente.SelectedValue = 1;
                    // Fallback caso ainda não esteja selecionado (ex.: DataSource não preparado)
                    if (cmbStatus.SelectedValue == null || !cmbStatus.SelectedValue.Equals(1))
                        cmbStatus.SelectedIndex = 0; // índice do item "Ativo" na sua lista


                    // Fallback caso ainda não esteja selecionado (ex.: DataSource não preparado)
                    if (cmbTipoCliente.SelectedValue == null || !cmbTipoCliente.SelectedValue.Equals(1))
                        cmbTipoCliente.SelectedIndex = 0; // índice do item "Ativo" na sua lista

                }

                // Ajusta rótulo e máscara normalmente
                bool isCpf2 = cmbTipoCliente.Text == "Física" ||
                              cmbTipoCliente.Text == "Operador" ||
                              cmbTipoCliente.Text == "Administrador" ||
                              cmbTipoCliente.Text == "Consumidor Final";

                CarregandoDados = false;
            }
        }

        private void GerarNovoCodigo()
        {
            int novoId = Utilitario.ProximoId(QueryClientes);
            ClienteID = novoId;
            txtClienteID.Text = Utilitario.ZerosEsquerda(novoId, 6);
        }

        public void SalvarRegistro()
        {
            try
            {
                var cliente = MontarObjetoCliente();
                _clienteBll.Salvar(cliente);

                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                var frmManutCliente = Application.OpenForms["FrmManutCliente"] as FrmManutCliente;
                if (frmManutCliente != null)
                {
                    frmManutCliente.HabilitarTimer(true);
                }
                LimparCampos();
                GerarNovoCodigo();
                txtNomeCliente.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void AlterarRegistro()
        {
            try
            {
                var cliente = MontarObjetoCliente();
                cliente.UsuarioAtualizacao = FrmLogin.UsuarioConectado;
                cliente.DataAtualizacao = DateTime.Now;

                _clienteBll.Alterar(cliente);

                MessageBox.Show("Cliente alterado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                toolStripStatusLabelUsuarioAtualizacao.Text = FrmLogin.UsuarioConectado;
                ToolStripLabelDataUtimaCompra.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                this.Close();

                var frmManutCliente = Application.OpenForms["FrmManutCliente"] as FrmManutCliente;
                if (frmManutCliente != null)
                {
                    frmManutCliente.HabilitarTimer(true);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Outro cliente já está cadastrado"))
                    MessageBox.Show(ex.Message, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void ExcluirRegistro()
        {
            if (MessageBox.Show($"Deseja realmente excluir o cliente:\n\n{txtNomeCliente.Text}?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _clienteBll.Excluir(ClienteID);
                    MessageBox.Show("Cliente excluído com sucesso!", "Excluído",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    var frmManutCliente = Application.OpenForms["FrmManutCliente"] as FrmManutCliente;
                    if (frmManutCliente != null)
                    {
                        frmManutCliente.HabilitarTimer(true);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private ClienteMODEL MontarObjetoCliente()
        {
            var cliente = new ClienteMODEL();

            cliente.Nome = txtNomeCliente.Text.Trim();

            // ========== TRATAMENTO CORRETO DO CPF/CNPJ ==========
            string tipoCliente = cmbTipoCliente.Text;
            bool isPessoaFisica = tipoCliente == "Física" ||
                                 tipoCliente == "Operador" ||
                                 tipoCliente == "Administrador" ||
                                 tipoCliente == "Consumidor Final";

            // Função auxiliar local para converter string vazia para null
            string StringParaNull(string valor)
            {
                return string.IsNullOrWhiteSpace(valor) ? null : valor.Trim();
            }

            if (isPessoaFisica)
            {
                // Pessoa Física: CPF deve ter 11 dígitos
                string cpfRaw = Utilitario.ApenasNumeros(txtCpf.Text);
                cliente.Cpf = StringParaNull(cpfRaw);

                // Valida se tem 11 dígitos (apenas se não for null)
                if (!string.IsNullOrEmpty(cliente.Cpf) && cliente.Cpf.Length != 11)
                {
                    // Ajusta para 11 dígitos se possível
                    if (cliente.Cpf.Length > 11)
                        cliente.Cpf = cliente.Cpf.Substring(0, 11);
                    // Se for menor que 11, mantém (será validado depois)
                }

                cliente.RG = StringParaNull(txtRg.Text);
                cliente.OrgaoExpedidorRG = StringParaNull(txtOrgaoExpedidorRG.Text);

                // Para PF, CNPJ deve ser NULL/vazio
                cliente.Cnpj = null;
                cliente.IE = null;
            }
            else // Pessoa Jurídica
            {
                // Pessoa Jurídica: CPF deve ser NULL
                cliente.Cpf = null;
                cliente.RG = null;
                cliente.OrgaoExpedidorRG = null;

                // CNPJ deve ter 14 dígitos
                string cnpjRaw = Utilitario.ApenasNumeros(txtCnpj.Text);
                cliente.Cnpj = StringParaNull(cnpjRaw);
                cliente.IE = StringParaNull(txtIE.Text);

                // Valida se tem 14 dígitos (apenas se não for null)
                if (!string.IsNullOrEmpty(cliente.Cnpj) && cliente.Cnpj.Length != 14)
                {
                    if (cliente.Cnpj.Length > 14)
                        cliente.Cnpj = cliente.Cnpj.Substring(0, 14);
                }
            }

            // ========== TRATAMENTO DOS DEMAIS CAMPOS ==========
            string telefoneRaw = Utilitario.ApenasNumeros(txtTelefone.Text);
            cliente.Telefone = StringParaNull(telefoneRaw);

            cliente.Email = StringParaNull(txtEmail.Text);

            if (int.TryParse(txtClienteID.Text, out int id))
                cliente.ClienteID = id;

            cliente.CidadeID = CidadeID;
            cliente.Logradouro = StringParaNull(txtLogradouro.Text);
            cliente.Numero = StringParaNull(txtNumero.Text);
            cliente.Bairro = StringParaNull(txtBairro.Text);

            string cepRaw = Utilitario.ApenasNumeros(txtCep.Text);
            cliente.Cep = StringParaNull(cepRaw);

            cliente.DataNascimento = dtpDataNascimento.Checked ? dtpDataNascimento.Value.Date : (DateTime?)null;
            cliente.TipoCliente = tipoCliente;
            cliente.Status = cmbStatus.Text == "Ativo" ? 1 : 0;
            cliente.Observacoes = StringParaNull(txtObservacoes.Text);

            if (decimal.TryParse(txtLimiteCredito.Text, out decimal limite))
                cliente.LimiteCredito = limite;
            else
                cliente.LimiteCredito = 0;

            // Se for novo registro
            if (StatusOperacao == "NOVO")
            {
                cliente.DataCriacao = DateTime.Now;
                cliente.UsuarioCriacao = FrmLogin.UsuarioConectado;
            }

            // Para alteração (será sobrescrito no AlterarRegistro, mas mantemos aqui para consistência)
            cliente.DataAtualizacao = DateTime.Now;
            cliente.UsuarioAtualizacao = FrmLogin.UsuarioConectado;            
            cliente.IsVendedor = chkIsVendedor.Checked;

            return cliente;
        }
       
        private void AbrirFrmLocalizarCidadeDinamico()
        {
            // Desliga temporariamente o evento para evitar loop
            txtNomeCidade.TextChanged -= txtNomeCidade_TextChanged;

            using (FrmLocalizarCidade frmLocalizarCidade = new FrmLocalizarCidade(this, cidadeSelecionado))
            {
                frmLocalizarCidade.Owner = this;
                frmLocalizarCidade.ShowDialog();
                txtNomeCidade.Text = frmLocalizarCidade.cidadeSelecionado; // Define o nome do cliente retornado
            }

            // Religa o evento após modificar o texto
            txtNomeCidade.TextChanged += txtNomeCidade_TextChanged;
        }

        public void PreencherCampos(ClienteMODEL cliente)
        {
            ClienteID = cliente.ClienteID;
            txtClienteID.Text = Utilitario.ZerosEsquerda(cliente.ClienteID, 6);
            txtNomeCliente.Text = cliente.Nome;

            // Detectar se é CPF ou CNPJ pelo tamanho
            string doc = cliente.Cpf?.Trim();
            if (!string.IsNullOrEmpty(doc))
            {
                if (doc.Length == 11)
                {
                    cmbTipoCliente.Text = "Física";
                    txtCpf.Text = Utilitario.FormatarCPF(doc);
                }
                else if (doc.Length == 14)
                {
                    cmbTipoCliente.Text = "Jurídica";
                    txtCpf.Text = Utilitario.FormatarCNPJ(doc);
                }
                else
                {
                    txtCpf.Text = doc; // fallback
                }
            }

            txtTelefone.Text = cliente.Telefone;
            txtEmail.Text = cliente.Email;
            txtNomeCidade.Text = cliente.Nome ?? ""; // ← aqui tem um erro no seu código! deveria ser NomeCidade ou algo assim
            txtLogradouro.Text = cliente.Logradouro;
            txtNumero.Text = cliente.Numero;
            txtBairro.Text = cliente.Bairro;
            txtCep.Text = cliente.Cep;

            if (cliente.DataNascimento.HasValue)
                txtDataNascimento.Text = cliente.DataNascimento.Value.ToString("dd/MM/yyyy");

            txtRg.Text = cliente.RG;
            cmbTipoCliente.Text = cliente.TipoCliente ?? "Física";
            cmbStatus.Text = cliente.Status == 1 ? "Ativo" : "Inativo";

            txtObservacoes.Text = cliente.Observacoes;

            var culture = CultureInfo.GetCultureInfo("pt-BR");

            txtLimiteCredito.Text = cliente.LimiteCredito.HasValue && cliente.LimiteCredito.Value > 0 ? cliente.LimiteCredito.Value.ToString("C", culture) : "";

            // Auditoria
            if (cliente.DataCriacao > DateTime.MinValue)
                ToolStripLabelDataCriacao.Text = $"Criado em: {cliente.DataCriacao:dd/MM/yyyy HH:mm}";
            if (!string.IsNullOrEmpty(cliente.UsuarioCriacao))
                toolStripStatusLabelUsuarioCriacao.Text = $"Por: {cliente.UsuarioCriacao}";

            toolStripStatusLabelUsuarioCriacao.Text = cliente.UsuarioCriacao;
            ToolStripLabelDataCriacao.Text = cliente.DataCriacao.ToString("dd/MM/yyyy HH:mm:ss");

            toolStripStatusLabelUsuarioAtualizacao.Text = cliente.UsuarioAtualizacao;
            ToolStripLabelDataUtimaCompra.Text = cliente.DataUltimaCompra?.ToString("dd/MM/yyyy") ?? "-";

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
            txtNomeCliente.Focus();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            AbrirFrmLocalizarCidadeDinamico();
        }

        private void btnSair_Click(object sender, EventArgs e) => this.Close();

        private void LimparCampos() => Utilitario.LimparCampos(this);


        private void cmbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CarregandoDados) return;

            string tipoSelecionado = cmbTipoCliente.Text;
            AplicarConfiguracaoTipoCliente(tipoSelecionado);
            //if (CarregandoDados) return; // impede apagar o campo durante carregamento

            //// Define se o cliente é pessoa física (usa CPF) ou jurídica (usa CNPJ)
            //bool isCpf = cmbTipoCliente.Text == "Física" ||
            //             cmbTipoCliente.Text == "Operador" ||
            //             cmbTipoCliente.Text == "Administrador" ||
            //             cmbTipoCliente.Text == "Consumidor Final";

            //// Remove máscaras antigas
            //txtCpf.KeyPress -= Utilitario.MascaraCPF;
            //txtCnpj.KeyPress -= Utilitario.MascaraCNPJ;

            //// Aplica máscara correta
            //if (isCpf)
            //{
            //    txtCpf.KeyPress += Utilitario.MascaraCPF;

            //    txtCpf.Visible = true;
            //    lblCpf.Visible = true;
            //    txtRg.Visible = true;
            //    lblRG.Visible = true;
            //    txtOrgaoExpedidorRG.Visible = true;
            //    lblOrgaoExpedidorRG.Visible = true;

            //    lblRotuloCnpj.Visible = false;
            //    lblRotuloIE.Visible = false;
            //    txtCnpj.Visible = false;
            //    txtIE.Visible = false;
            //}
            //else
            //{
            //    txtCnpj.KeyPress += Utilitario.MascaraCNPJ;
            //    // Pessoa Jurídica → mostra CNPJ e IE               
            //    txtCpf.Visible = false;
            //    lblCpf.Visible = false;
            //    txtOrgaoExpedidorRG.Visible = false;
            //    lblRotuloDtNascDtCriacao.Text = "Data Criação:";
            //    lblOrgaoExpedidorRG.Visible = false;
            //    lblRG.Visible = false;
            //    txtRg.Visible = false;

            //    lblRotuloCnpj.Visible = true;
            //    lblRotuloIE.Visible = true;
            //    txtCnpj.Visible = true;
            //    txtIE.Visible = true;
            //}
        }
        private void ConfigurarCamposPorTipoCliente(string tipoCliente)
        {
            if (CarregandoDados) return;

            // Define se o cliente é pessoa física (usa CPF) ou jurídica (usa CNPJ)
            bool isCpf = tipoCliente == "Física" ||
                         tipoCliente == "Operador" ||
                         tipoCliente == "Administrador" ||
                         tipoCliente == "Consumidor Final";

            // Remove máscaras antigas
            txtCpf.KeyPress -= Utilitario.MascaraCPF;
            txtCnpj.KeyPress -= Utilitario.MascaraCNPJ;

            // Aplica máscara correta
            if (isCpf)
            {
                txtCpf.KeyPress += Utilitario.MascaraCPF;

                txtCpf.Visible = true;
                lblCpf.Visible = true;
                txtRg.Visible = true;
                lblRG.Visible = true;
                txtOrgaoExpedidorRG.Visible = true;
                lblOrgaoExpedidorRG.Visible = true;

                lblRotuloCnpj.Visible = false;
                lblRotuloIE.Visible = false;
                txtCnpj.Visible = false;
                txtIE.Visible = false;

                // Atualiza rótulo da data para Pessoa Física
                lblRotuloDtNascDtCriacao.Text = "Data Nascimento:";
                dtpDataNascimento.Enabled = true;
                dtpDataNascimento.Visible = true;
            }
            else // Pessoa Jurídica
            {
                txtCnpj.KeyPress += Utilitario.MascaraCNPJ;

                txtCpf.Visible = false;
                lblCpf.Visible = false;
                txtOrgaoExpedidorRG.Visible = false;
                lblOrgaoExpedidorRG.Visible = false;
                lblRG.Visible = false;
                txtRg.Visible = false;

                lblRotuloCnpj.Visible = true;
                lblRotuloIE.Visible = true;
                txtCnpj.Visible = true;
                txtIE.Visible = true;

                // Atualiza rótulo da data para Pessoa Jurídica
                lblRotuloDtNascDtCriacao.Text = "Data Criação:";
                // Para pessoa jurídica, você pode querer tratar diferente
                // dtpDataNascimento pode ser usado como data de criação da empresa
            }
        }
        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario.AplicarMascaraCEP(e, txtCep);
        }
        private void txtLimiteCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtLimiteCredito_TextChanged(object sender, EventArgs e)
        {
            KryptonTextBox txt = (KryptonTextBox)sender;

            // Captura posição do cursor
            int pos = txt.SelectionStart;

            // Remove tudo que não é número
            string apenasNumeros = Utilitario.ApenasNumeros(txt.Text);

            if (string.IsNullOrEmpty(apenasNumeros))
            {
                txt.Text = "0,00";
                txt.SelectionStart = txt.Text.Length;
                return;
            }

            // Garante que sempre tenha pelo menos 3 dígitos (0,00)
            if (apenasNumeros.Length < 3)
                apenasNumeros = apenasNumeros.PadLeft(3, '0');

            // Converte para decimal formatado
            decimal valor = decimal.Parse(apenasNumeros) / 100m;

            txt.Text = valor.ToString("#,##0.00");

            // Reposiciona o cursor sempre no final
            txt.SelectionStart = txt.Text.Length;
        }
        private void txtCpfCnpjJ_Leave(object sender, EventArgs e)
        {
            // Preferência: leia o modo do Tag (mais confiável)
            string modo = (txtCpf.Tag as string) ?? cmbTipoCliente.Text;
            bool isCpf = modo.Equals("CPF", StringComparison.OrdinalIgnoreCase)
                         || modo.Equals("Física", StringComparison.OrdinalIgnoreCase);

            string numero = Utilitario.ApenasNumeros(txtCpf.Text);

            if (string.IsNullOrEmpty(numero))
            {
                txtCpf.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
                return;
            }

            if (isCpf)
            {
                if (numero.Length != 11 || !Utilitario.ValidarCPF(numero))
                {
                    MessageBox.Show("CPF inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCpf.Focus();
                    txtCpf.StateCommon.Border.Color1 = System.Drawing.Color.Crimson;
                    return;
                }

                txtCpf.Text = Utilitario.FormatarCPF(numero);
            }
            else // CNPJ
            {
                if (numero.Length != 14 || !Utilitario.ValidarCNPJ(numero))
                {
                    MessageBox.Show("CNPJ inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCpf.Focus();
                    txtCpf.StateCommon.Border.Color1 = System.Drawing.Color.Crimson;
                    return;
                }

                txtCpf.Text = Utilitario.FormatarCNPJ(numero);
            }

            txtCpf.StateCommon.Border.Color1 = System.Drawing.Color.MediumSeaGreen;
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario.MascaraTelefone(sender, e);
        }

        private void FrmCadCliente_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }

        private void FrmCadCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtNomeCidade_TextChanged(object sender, EventArgs e)
        {
            // Verificação mais robusta
            if (bloqueiaPesquisa || string.IsNullOrWhiteSpace(txtNomeCidade.Text) || txtNomeCidade.Text.Length < 2)
                return;

            // Verifica se o formulário está válido
            if (this.IsDisposed || !this.IsHandleCreated || this.Disposing)
                return;

            string textoDigitado = txtNomeCidade.Text.Trim();

            // Usa Invoke em vez de BeginInvoke para garantir sincronização
            this.Invoke(new Action(() =>
            {
                try
                {
                    if (bloqueiaPesquisa || this.IsDisposed || txtNomeCidade.IsDisposed)
                        return;

                    bloqueiaPesquisa = true;

                    using (var pesquisaCidade = new FrmLocalizarCidade(this, textoDigitado))
                    {
                        pesquisaCidade.StartPosition = FormStartPosition.CenterParent;

                        // Define o Owner de forma segura
                        if (!this.IsDisposed && this.Visible)
                        {
                            pesquisaCidade.Owner = this;
                        }

                        if (pesquisaCidade.ShowDialog() == DialogResult.OK)
                        {
                            if (!txtNomeCidade.IsDisposed)
                            {
                                txtNomeCidade.Text = pesquisaCidade.cidadeSelecionado;
                                CidadeID = pesquisaCidade.CidadeID;
                                txtUF.Text = pesquisaCidade.Uf;
                                txtNomeCidade.SelectionStart = txtNomeCidade.Text.Length;

                            }
                        }
                    }
                }
                catch (ObjectDisposedException)
                {
                    // Formulário foi descartado, ignore
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao buscar cidade: {ex.Message}", "Erro",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bloqueiaPesquisa = false;
                }
            }));
        }

        private async void btnBuscarEnderecoPorCep_Click(object sender, EventArgs e)
        {
            await BuscarEnderecoPorCep();
        }       
    }
}