using GVC.BLL;
using GVC.DAL;
using GVC.Model;
using GVC.MUI;
using GVC.UTIL;
using Krypton.Toolkit;
using System;
using System.ComponentModel;
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
    public partial class FrmCadEmpresa : KryptonForm
    {
        private byte[] _imagemAtual;     // imagem vinda do banco
        private byte[] _imagemNova;      // imagem selecionada pelo usuário

        private bool _formatandoCNPJ = false;
        private bool _formatandoTelefone = false;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool CarregandoDados { get; set; }
        private readonly EmpresaBll _empresaBll = new EmpresaBll();
        private EmpresaDal _empresaDal = new EmpresaDal();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int EmpresaID { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string StatusOperacao { get; set; } // "NOVO", "ALTERAR", "EXCLUSAO"
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CidadeID { get; set; } // usado internamente na busca de cidade
        private bool bloqueiaPesquisa = false;
        private readonly string QueryMaxId = "SELECT MAX(EmpresaID) FROM Empresa";
        public bool HouveAlteracao { get; private set; } // indica se houve alteração nos dados atualiza o datagrid do FrmManutEmpresa


        public FrmCadEmpresa()
        {
            InitializeComponent();

            ConfigurarCNPJ();
            ConfigurarTelefone();   // ← ISTO É OBRIGATÓRIO
            ConfigurarEventosCep();
        }
        private void AplicarModoFormulario()
        {
            switch (StatusOperacao)
            {
                case "NOVO":
                    Text = "Nova Empresa";
                    btnSalvar.Text = "Salvar";
                    AplicarHeader(Color.Green);
                    HabilitarCampos(true);
                    break;

                case "ALTERAR":
                    Text = "Alterar Empresa";
                    btnSalvar.Text = "Alterar";
                    AplicarHeader(Color.Orange);
                    HabilitarCampos(true);
                    btnSair.Enabled = true;
                    break;

                case "EXCLUSAO":
                    Text = "Excluir Empresa";
                    btnSalvar.Text = "Excluir";
                    AplicarHeader(Color.Red);
                    HabilitarCampos(false);
                    btnSair.Enabled = true;
                    break;
            }
        }

        private void BloquearTextBoxRecursivo(Control ctrl, bool habilitar)
        {
            // TextBox
            if (ctrl is KryptonTextBox txt)
                txt.ReadOnly = !habilitar;

            // MaskedTextBox
            else if (ctrl is MaskedTextBox mtxt)
                mtxt.ReadOnly = !habilitar;

            // ComboBox
            else if (ctrl is KryptonComboBox cbo)
                cbo.Enabled = habilitar;

            // DateTimePicker
            else if (ctrl is DateTimePicker dtp)
                dtp.Enabled = habilitar;

            // CheckBox
            else if (ctrl is CheckBox chk)
                chk.Enabled = habilitar;

            // Botões — exceção para Salvar/Cancelar
            else if (ctrl is KryptonButton btn)
            {
                if (btn.Name != "btnSalvar" && btn.Name != "btnCancelar")
                    btn.Enabled = habilitar;
            }

            // Recursão para controles filhos (Panel, GroupBox, etc.)
            foreach (Control filho in ctrl.Controls)
                BloquearTextBoxRecursivo(filho, habilitar);
        }

        private void AplicarHeader(Color cor)
        {
            StateCommon.Header.Content.ShortText.Color1 = cor;
            StateCommon.Header.Content.ShortText.Color2 = Color.White;
            StateCommon.Header.Content.ShortText.Font =
                new Font("Segoe UI", 12, FontStyle.Bold);
        }

        private void HabilitarCampos(bool habilitar)
        {
            foreach (Control ctrl in Controls)
                BloquearTextBoxRecursivo(ctrl, habilitar);
        }

        private void CarregarEmpresa(int empresaId)
        {
            var empresa = _empresaBll.BuscarPorId(empresaId);
            if (empresa == null)
                return;

            txtEmpresaID.Text = Utilitario.ZerosEsquerda(empresa.EmpresaID, 4);
            txtRazaoSocial.Text = empresa.RazaoSocial;
            txtNomeFantasia.Text = empresa.NomeFantasia;
            txtCnpj.Text = empresa.CNPJ;
            txtTelefone.Text = empresa.Telefone;
            txtEmail.Text = empresa.Email;
            txtCep.Text = empresa.Cep;
            txtLogradouro.Text = empresa.Logradouro;
            txtNumero.Text = empresa.Numero;
            txtBairro.Text = empresa.Bairro;
            txtNomeCidade.Text = empresa.Cidade;
            txtUF.Text = empresa.UF;
            txtResponsavel.Text = empresa.Responsavel;
            txtSite.Text = empresa.Site;
            lblDataAtualizacao.Text = empresa.DataAtualizacao?.ToString("g") ?? "N/A";
            lblDataCriacao.Text = empresa.DataCriacao.ToString("g");
            lblUsuarioCriacao.Text = empresa.UsuarioCriacao ?? "N/A";
            lblUsuarioAtualizacao.Text = empresa.UsuarioAtualizacao ?? "N/A";
            txtInscricaoEstadual.Text = empresa.InscricaoEstadual;
            txtInscricaoMunicipal.Text = empresa.InscricaoMunicipal;
            txtCnae.Text = empresa.CNAE;
            txtCertificadoDigital.Text = empresa.CertificadoDigital;
        }
        private void ConfigurarEventosCep()
        {
            txtCep.AcceptsReturn = false;
            txtCep.Multiline = false;
            toolTip.SetToolTip(txtCep, "Digite o CEP e pressione ENTER para buscar");
        }

        // =============================================
        // BUSCA POR CEP (igual ao cliente, adaptado)
        // =============================================
        private async void btnBuscarEnderecoPorCep_Click(object sender, EventArgs e)
        {
            await BuscarEnderecoPorCep();
        }

        private async Task BuscarEnderecoPorCep()
        {
            if (!ValidarCepParaBusca())
                return;

            ConfigurarInterfaceBusca(true);
            try
            {
                //txtNomeCidade.TextChanged -= txtNomeCidade_TextChanged;

                var endereco = await ExecutarBuscaCep();
                if (endereco == null) return;

                PreencherCamposEndereco(endereco);
                ProcessarSucessoBusca();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso($"Erro ao buscar CEP: {ex.Message}");
            }
            finally
            {
                ConfigurarInterfaceBusca(false);
                //txtNomeCidade.TextChanged += txtNomeCidade_TextChanged;
            }
        }

        private bool ValidarCepParaBusca()
        {
            string cepDigitado = txtCep.Text?.Trim() ?? "";
            if (string.IsNullOrWhiteSpace(cepDigitado) || cepDigitado.Replace("_", "").Replace("-", "").Length == 0)
                return false;

            string cepLimpo = new string(cepDigitado.Where(char.IsDigit).ToArray());
            if (cepLimpo.Length != 8)
            {
                Utilitario.Mensagens.Aviso("CEP inválido. Digite 8 dígitos numéricos.");
                txtCep.Focus();
                txtCep.SelectAll();
                return false;
            }
            return true;
        }

        private void ConfigurarInterfaceBusca(bool emAndamento)
        {
            this.Cursor = emAndamento ? Cursors.WaitCursor : Cursors.Default;
            btnBuscarEnderecoPorCep.Enabled = !emAndamento;
        }

        private async Task<BrasilApiResponse> ExecutarBuscaCep()
        {
            string cepLimpo = new string(txtCep.Text.Where(char.IsDigit).ToArray());
            var endereco = await CepService.BuscarEnderecoPorCepAsync(cepLimpo);
            if (endereco == null || !endereco.EhValido)
            {
                Utilitario.Mensagens.Aviso($"CEP {txtCep.Text} não encontrado.");
                return null;
            }
            return endereco;
        }

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

            // Preenche Uf com garantia de atualização visual
            txtUF.Text = endereco.SiglaEstado ?? "";
            txtUF.Refresh();
            Application.DoEvents();

            Debug.WriteLine($"✅ Uf definido: '{txtUF.Text}'");

            // Formata o CEP para exibição
            txtCep.Text = CepService.FormatarCep(endereco.Cep);
        }

        private void MostrarFeedbackSilencioso()
        {
            Color corOriginal = txtCep.ForeColor;
            txtCep.ForeColor = Color.Green;
            var timer = new System.Windows.Forms.Timer { Interval = 1000 };
            timer.Tick += (s, e) =>
            {
                txtCep.ForeColor = corOriginal;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        private void ProcessarSucessoBusca()
        {
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
                txtNumero.Focus();
            else
                txtRazaoSocial.Focus();
        }

        // =============================================
        // CARREGAR DADOS (de uma linha do grid)
        // =============================================
        public void CarregarCampos(DataGridViewRow row)
        {
            if (row == null) return;

            CarregandoDados = true;

            try
            {
                /* =========================
                 * IDENTIFICAÇÃO
                 * ========================= */
                EmpresaID = Convert.ToInt32(row.Cells["EmpresaID"].Value ?? 0);
                txtEmpresaID.Text = EmpresaID.ToString();


                /* =========================
                 * DADOS PRINCIPAIS
                 * ========================= */
                txtRazaoSocial.Text = row.Cells["RazaoSocial"].Value?.ToString() ?? "";
                txtNomeFantasia.Text = row.Cells["NomeFantasia"].Value?.ToString() ?? "";

                string cnpj = row.Cells["Cnpj"].Value?.ToString() ?? "";
                txtCnpj.Text = !string.IsNullOrWhiteSpace(cnpj)
                    ? new string(cnpj.Where(char.IsDigit).Take(14).ToArray())
                    : "";


                /* =========================
                 * INSCRIÇÕES / Cnae
                 * ========================= */
                txtInscricaoEstadual.Text = row.Cells["InscricaoEstadual"].Value?.ToString() ?? "";
                txtInscricaoMunicipal.Text = row.Cells["InscricaoMunicipal"].Value?.ToString() ?? "";
                txtCnae.Text = row.Cells["Cnae"].Value?.ToString() ?? "";


                /* =========================
                 * ENDEREÇO
                 * ========================= */
                txtLogradouro.Text = row.Cells["Logradouro"].Value?.ToString() ?? "";
                txtNumero.Text = row.Cells["Numero"].Value?.ToString() ?? "";
                txtBairro.Text = row.Cells["Bairro"].Value?.ToString() ?? "";

                string cep = row.Cells["Cep"].Value?.ToString() ?? "";
                txtCep.Text = !string.IsNullOrWhiteSpace(cep)
                    ? $"{new string(cep.Where(char.IsDigit).Take(8).ToArray()).Insert(5, "-")}"
                    : "";

                txtNomeCidade.Text = row.Cells["Cidade"].Value?.ToString() ?? "";
                txtUF.Text = row.Cells["Uf"].Value?.ToString() ?? "";


                /* =========================
                 * CONTATO
                 * ========================= */
                string telefone = row.Cells["Telefone"].Value?.ToString() ?? "";
                txtTelefone.Text = !string.IsNullOrWhiteSpace(telefone)
                    ? FormatTelefone(telefone)
                    : "";

                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtSite.Text = row.Cells["Site"].Value?.ToString() ?? "";


                /* =========================
                 * RESPONSÁVEL / CERTIFICADO
                 * ========================= */
                txtResponsavel.Text = row.Cells["Responsavel"].Value?.ToString() ?? "";
                txtCertificadoDigital.Text = row.Cells["CertificadoDigital"].Value?.ToString() ?? "";
            }
            finally
            {
                CarregandoDados = false;
            }
        }


        private string FormatTelefone(string telefone)
        {
            string apenasNumeros = new string(telefone.Where(char.IsDigit).ToArray());
            if (apenasNumeros.Length == 10)
                return $"({apenasNumeros.Substring(0, 2)}) {apenasNumeros.Substring(2, 4)}-{apenasNumeros.Substring(6, 4)}";
            else if (apenasNumeros.Length == 11)
                return $"({apenasNumeros.Substring(0, 2)}) {apenasNumeros.Substring(2, 5)}-{apenasNumeros.Substring(7, 4)}";
            return telefone;
        }

        // =============================================
        // EVENTOS DOS BOTÕES
        // =============================================

        private void GerarNovoCodigo()
        {
            try
            {
                int novoId = Utilitario.ProximoId(QueryMaxId);

                EmpresaID = novoId;
                txtEmpresaID.Text = Utilitario.ZerosEsquerda(novoId, 4);
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro($"Erro ao gerar código: {ex.Message}");

                EmpresaID = 0;
                txtEmpresaID.Text = "00000";
            }
        }


        private void LimparCampos()
        {
            Utilitario.LimparCampos(this);

            GerarNovoCodigo();
        }

        private void SalvarRegistro()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtRazaoSocial.Text))
                {
                    Utilitario.Mensagens.Aviso("Razão Social é obrigatória!");
                    txtRazaoSocial.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCnpj.Text))
                {
                    Utilitario.Mensagens.Aviso("Cnpj é obrigatório!");
                    txtCnpj.Focus();
                    return;
                }


                var empresa = MontarObjetoEmpresa();
                _empresaBll.Inserir(empresa);
                Utilitario.Mensagens.Info("Empresa cadastrada com sucesso!");
                HouveAlteracao = true;

                LimparCampos();
                txtRazaoSocial.Focus();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro(ex.Message);
            }
        }

        private void AlterarRegistro()
        {
            try
            {
                if (EmpresaID <= 0)
                {
                    Utilitario.Mensagens.Aviso("ID da empresa inválido!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtRazaoSocial.Text))
                {
                    Utilitario.Mensagens.Aviso("Razão Social é obrigatória!");
                    txtRazaoSocial.Focus();
                    return;
                }

                var empresa = MontarObjetoEmpresa();
                empresa.DataAtualizacao = DateTime.Now;
                empresa.UsuarioAtualizacao = FrmLogin.UsuarioConectado;
                _empresaBll.Atualizar(empresa);
                Utilitario.Mensagens.Info("Empresa alterada com sucesso!");
                HouveAlteracao = true;
                this.Close();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro(ex.Message);
            }
        }

        private void ExcluirRegistro()
        {
            if (EmpresaID <= 0)
            {
                Utilitario.Mensagens.Aviso("Nenhuma empresa selecionada para exclusão!");
                return;
            }

            if (MessageBox.Show($"Deseja realmente excluir a empresa:\n\n{txtRazaoSocial.Text}?\n\nEsta ação não pode ser desfeita!",
                "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    _empresaBll.Excluir(EmpresaID);
                    Utilitario.Mensagens.Aviso("Empresa excluída com sucesso!");
                    HouveAlteracao = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    Utilitario.Mensagens.Erro($"Erro ao excluir empresa: {ex.Message}");
                }
            }
        }

        private EmpresaModel MontarObjetoEmpresa()
        {
            var empresa = new EmpresaModel
            {
                EmpresaID = EmpresaID,
                RazaoSocial = txtRazaoSocial.Text?.Trim(),
                NomeFantasia = txtNomeFantasia.Text?.Trim(),
                CNPJ = new string(txtCnpj.Text.Where(char.IsDigit).ToArray()), // Apenas números
                InscricaoEstadual = txtInscricaoEstadual.Text?.Trim(),
                InscricaoMunicipal = txtInscricaoMunicipal.Text?.Trim(),
                CNAE = txtCnae.Text?.Trim(),
                Logradouro = txtLogradouro.Text?.Trim(),
                Numero = txtNumero.Text?.Trim(),
                Bairro = txtBairro.Text?.Trim(),
                Cep = new string(txtCep.Text.Where(char.IsDigit).ToArray()), // Apenas números
                Cidade = txtNomeCidade.Text?.Trim(),
                UF = txtUF.Text?.Trim().ToUpper(),
                Telefone = new string(txtTelefone.Text.Where(char.IsDigit).ToArray()), // Apenas números
                Email = txtEmail.Text?.Trim(),
                Site = txtSite.Text?.Trim(),
                Responsavel = txtResponsavel.Text?.Trim(),
                CertificadoDigital = txtCertificadoDigital.Text?.Trim(),

                DataCriacao = DateTime.Now,
                DataAtualizacao = null,
                UsuarioCriacao = FrmLogin.UsuarioConectado ?? "Sistema",
                UsuarioAtualizacao = null,
            };

            if (StatusOperacao == "NOVO")
            {
                empresa.DataCriacao = DateTime.Now;
                empresa.UsuarioCriacao = FrmLogin.UsuarioConectado ?? "Sistema";
                if (!string.IsNullOrWhiteSpace(txtCertificadoDigital.Text))
                {
                    empresa.CertificadoDigital = Utilitario.SalvarCertificado(txtCertificadoDigital.Text, empresa.EmpresaID);
                }
            }
            if (StatusOperacao == "ALTERAR")
            {
                empresa.DataCriacao = DateTime.Now;
                empresa.UsuarioCriacao = FrmLogin.UsuarioConectado ?? "Sistema";
                if (File.Exists(txtCertificadoDigital.Text))
                {
                    empresa.CertificadoDigital = Utilitario.SalvarCertificado(txtCertificadoDigital.Text, empresa.EmpresaID);
                }

            }

            return empresa;
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            // Auto-formata ao sair do campo
            if (!string.IsNullOrWhiteSpace(txtCep.Text))
            {
                string cepLimpo = new string(txtCep.Text.Where(char.IsDigit).ToArray());
                if (cepLimpo.Length == 8)
                {
                    txtCep.Text = $"{cepLimpo.Substring(0, 5)}-{cepLimpo.Substring(5, 3)}";
                }
            }
        }

        private async void btnBuscarEnderecoPorCep_Click_1(object sender, EventArgs e)
        {
            await BuscarEnderecoPorCep();
        }
     
        private void FrmCadEmpresa_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void FrmCadEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Control && !e.Alt && !e.Shift)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                btnSalvar_Click(null, null);
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                btnNovo_Click(null, null);
                e.Handled = true;
            }
        }
        private void FrmCadEmpresa_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }

        private void txtCnpj_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCnpj.Text) && !Utilitario.ValidarCNPJ(txtCnpj.Text))
            {
                txtCnpj.StateCommon.Border.Color1 = Color.Crimson;
                MessageBox.Show("Cnpj inválido.");
                txtCnpj.Focus();
            }
        }

        private void ConfigurarTelefone()
        {
            txtTelefone.TextChanged += (s, e) =>
            {
                if (_formatandoTelefone) return;

                try
                {
                    _formatandoTelefone = true;

                    var txt = (KryptonTextBox)s;

                    int cursorOriginal = txt.SelectionStart;

                    int numerosAntesCursor =
                        txt.Text.Take(cursorOriginal).Count(char.IsDigit);

                    string numeros = Utilitario.ApenasNumeros(txt.Text);
                    if (numeros.Length > 11)
                        numeros = numeros.Substring(0, 11);

                    string formatado = Utilitario.FormatarTelefoneTexto(numeros);

                    if (txt.Text != formatado)
                    {
                        txt.Text = formatado;
                        txt.SelectionStart =
                            CalcularPosicaoCursor(formatado, numerosAntesCursor);
                    }
                }
                finally
                {
                    _formatandoTelefone = false;
                }
            };
        }


        private void ConfigurarCNPJ()
        {
            txtCnpj.TextChanged += (s, e) =>
            {
                if (_formatandoCNPJ || CarregandoDados) return;

                try
                {
                    _formatandoCNPJ = true;

                    var txt = (KryptonTextBox)s;

                    int cursorOriginal = txt.SelectionStart;

                    // Quantos números existem antes do cursor
                    int numerosAntesCursor =
                        txt.Text.Take(cursorOriginal).Count(char.IsDigit);

                    string numeros = Utilitario.ApenasNumeros(txt.Text);
                    if (numeros.Length > 14)
                        numeros = numeros.Substring(0, 14);

                    string formatado = Utilitario.FormatarCNPJ(numeros);

                    if (txt.Text != formatado)
                    {
                        txt.Text = formatado;

                        txt.SelectionStart =
                            CalcularPosicaoCursor(formatado, numerosAntesCursor);
                    }
                }
                finally
                {
                    _formatandoCNPJ = false;
                }
            };
        }

        private int CalcularPosicaoCursor(string textoFormatado, int quantidadeNumeros)
        {
            int contador = 0;

            for (int i = 0; i < textoFormatado.Length; i++)
            {
                if (char.IsDigit(textoFormatado[i]))
                    contador++;

                if (contador == quantidadeNumeros)
                    return i + 1;
            }

            return textoFormatado.Length;
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            string numeros = Utilitario.ApenasNumeros(txtTelefone.Text);

            if (string.IsNullOrWhiteSpace(numeros))
                return;

            if (numeros.Length != 10 && numeros.Length != 11)
            {
                txtTelefone.StateCommon.Border.Color1 = Color.Crimson;
                MessageBox.Show("Telefone deve conter 10 ou 11 dígitos.", "Telefone inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefone.Focus();
                return;
            }

            txtTelefone.StateCommon.Border.Color1 = Color.MediumSeaGreen;
        }
        public void ConfigurarMascaras()
        {
            txtCnpj.Text = Utilitario.FormatarCNPJ(txtCnpj.Text);
            txtCep.Text = Utilitario.FormatarCEP(txtCep.Text);
            txtTelefone.Text = Utilitario.FormatarTelefoneTexto(txtTelefone.Text);
        }
        private void FrmCadEmpresa_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StatusOperacao))
                throw new InvalidOperationException("StatusOperacao não definido.");
            if (StatusOperacao == "NOVO")
            {
                GerarNovoCodigo();
                BloquearTextBoxRecursivo(this, true);
            }

            // 🔹 Sempre configurar máscaras e padrões
            ConfigurarMascaras();

            // 🔹 Se for ALTERAR ou EXCLUIR, carrega os dados
            if (CarregandoDados)
            {
                CarregarEmpresa(EmpresaID);
            }

            // 🔹 Aplica o estado visual conforme operação
            AplicarModoFormulario();

            CarregandoDados = false;
        }
        public static string SalvarCertificado(string caminhoOrigem, int empresaId)
        {
            if (!File.Exists(caminhoOrigem))
                throw new FileNotFoundException("Certificado não encontrado");

            string pasta = @"C:\GVCSqlExpress\Certificados";
            Directory.CreateDirectory(pasta);

            string destino = Path.Combine(pasta, $"empresa_{empresaId}.pfx");
            File.Copy(caminhoOrigem, destino, true);

            return destino;
        }

        private void btnLocalizarCertificado_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Certificado Digital (*.pfx)|*.pfx",
                Title = "Selecionar Certificado Digital"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtCertificadoDigital.Text = ofd.FileName;
            }
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
            txtRazaoSocial.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}