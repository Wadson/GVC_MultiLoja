using GVC.BLL;
using GVC.DOMAIN.Models;
using GVC.MUI;
using GVC.UTIL;
using Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using static GVC.UTIL.BrasilApiCepResponse;

namespace GVC.View
{
    public partial class FrmCadVendedor : KryptonForm
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool CarregandoDados { get; set; }

        private readonly VendedorBLL _vendedorBll = new VendedorBLL();
        private readonly string QueryVendedores = "SELECT MAX(VendedorID) FROM Vendedores";

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string StatusOperacao { get; set; }

        private bool bloqueiaPesquisa = false;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int VendedorID { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CidadeID { get; set; }

        public FrmCadVendedor()
        {
            InitializeComponent();
            ConfigurarEventosCep();
        }

        #region Eventos de CEP

        private void txtCep_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCep.Text))
            {
                CepService.ValidarEFormatarCEPnoTextbox(txtCep);
            }
        }

        private void ConfigurarEventosCep()
        {
            txtCep.AcceptsReturn = false;
            txtCep.Multiline = false;
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

            if (string.IsNullOrWhiteSpace(cepDigitado) ||
                cepDigitado == "-" ||
                cepDigitado.Replace("_", "").Replace("-", "").Length == 0)
            {
                return false;
            }

            string cepNumeros = CepService.LimparCep(cepDigitado);

            if (cepNumeros.Length < 5)
                return false;

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
                btnPesquisarCep.Enabled = false;
            }
            else
            {
                this.Cursor = Cursors.Default;
                btnPesquisarCep.Enabled = true;
            }
        }

        private async Task<BrasilApiResponse> ExecutarBuscaCep()
        {
            string cepNumeros = CepService.LimparCep(txtCep.Text);

            var endereco = await CepService.BuscarEnderecoPorCepAsync(cepNumeros);

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

        private void ProcessarSucessoBusca(BrasilApiResponse endereco)
        {
            // Feedback visual silencioso
            MostrarFeedbackSilencioso(endereco);

            // Navega para próximo campo
            AvancarParaProximoCampo();
        }

        private void TratarErroBusca(Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Erro ao buscar CEP: {ex.Message}");
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
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                txtNumero.Focus();
            }
            else
            {
                txtNomeCidade.Focus();
            }
        }

        #endregion

        #region Carregar Dados

        public void CarregarCampos(DataGridViewRow row)
        {
            if (row == null)
                return;

            CarregandoDados = true;

            try
            {
                // ========== 1. CARREGA IDENTIFICAÇÃO BÁSICA ==========
                txtVendedorID.Text = row.Cells["VendedorID"].Value?.ToString() ?? "";
                if (int.TryParse(txtVendedorID.Text, out int id))
                    this.VendedorID = id;
                else
                    this.VendedorID = 0;

                txtNomeVendedor.Text = row.Cells["Nome"].Value?.ToString() ?? "";

                // ========== 2. CARREGA DOCUMENTOS ==========
                string cpfValue = row.Cells["CPF"].Value?.ToString() ?? "";
                string rgValue = row.Cells["RG"].Value?.ToString() ?? "";

                // ========== 3. CONTATO E ENDEREÇO ==========
                txtTelefone.Text = row.Cells["Telefone"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtLogradouro.Text = row.Cells["Endereco"].Value?.ToString() ?? "";
                txtNumero.Text = row.Cells["Numero"]?.Value?.ToString() ?? "";
                txtBairro.Text = row.Cells["Bairro"].Value?.ToString() ?? "";
                txtCep.Text = row.Cells["CEP"].Value?.ToString() ?? "";

                // Cidade
                CidadeID = row.Cells["CidadeID"].Value != null && int.TryParse(row.Cells["CidadeID"].Value.ToString(), out int cidadeId) ? cidadeId : 0;
                txtNomeCidade.Text = row.Cells["NomeCidade"].Value?.ToString() ?? "";
                txtUF.Text = row.Cells["UF"].Value?.ToString() ?? "";

                // ========== 4. DADOS PROFISSIONAIS ==========
                string comissaoValue = row.Cells["Comissao"].Value?.ToString() ?? "";
                if (decimal.TryParse(comissaoValue, out decimal comissao))
                {
                    txtComissao.Text = comissao.ToString("N2");
                }

                if (row.Cells["DataContratacao"].Value != null &&
                    DateTime.TryParse(row.Cells["DataContratacao"].Value.ToString(), out DateTime dtContratacao))
                {
                    dtpDataContratacao.Value = dtContratacao;
                }

                // ========== 5. FORMATAR CPF ==========
                cpfValue = new string(cpfValue.Where(char.IsDigit).ToArray());
                if (!string.IsNullOrWhiteSpace(cpfValue))
                {
                    txtCpf.Text = cpfValue.Length == 11
                        ? Convert.ToUInt64(cpfValue).ToString(@"000\.000\.000\-00")
                        : cpfValue;
                }

                txtRg.Text = rgValue;

                // ========== 6. STATUS ==========
                string statusValue = row.Cells["Status"].Value?.ToString() ?? "";
                cmbStatus.SelectedItem = statusValue == "1" ? "Ativo" : "Inativo";

                txtObservacoes.Text = row.Cells["Observacoes"].Value?.ToString() ?? "";

                // ========== 7. DATAS ==========
                ToolStripLabelDataCriacao.Text = row.Cells["DataCriacao"].Value?.ToString() ?? "";
                toolStripStatusLabelDataAtualizacao.Text = row.Cells["DataAtualizacao"].Value?.ToString() ?? "";
                toolStripStatusLabelUsuarioCriacao.Text = row.Cells["UsuarioCriacao"].Value?.ToString() ?? "";
                toolStripStatusLabelUsuarioAtualizacao.Text = row.Cells["UsuarioAtualizacao"].Value?.ToString() ?? "";

                // ========== 8. TELEFONE ==========
                string telefone = new string((row.Cells["Telefone"].Value?.ToString() ?? "")
                    .Where(char.IsDigit).ToArray());

                if (telefone.Length == 10)
                    txtTelefone.Text = Convert.ToUInt64(telefone).ToString(@"(00) 0000\-0000");
                else if (telefone.Length == 11)
                    txtTelefone.Text = Convert.ToUInt64(telefone).ToString(@"(00) 00000\-0000");

                // ========== 9. CEP ==========
                string cep = new string((row.Cells["CEP"].Value?.ToString() ?? "")
                    .Where(char.IsDigit).ToArray());

                if (cep.Length == 8)
                    txtCep.Text = $"{cep.Substring(0, 5)}-{cep.Substring(5, 3)}";

                // ========== 10. DATA NASCIMENTO ==========
                if (row.Cells["DataNascimento"].Value != null &&
                    DateTime.TryParse(row.Cells["DataNascimento"].Value.ToString(), out DateTime dtN))
                    dtpDataNascimento.Value = dtN;
                else
                    dtpDataNascimento.Value = DateTime.Now;
            }
            finally
            {
                CarregandoDados = false;
            }
        }

        private void GerarNovoCodigo()
        {
            int novoId = Utilitario.ProximoId(QueryVendedores);
            VendedorID = novoId;
            txtVendedorID.Text = Utilitario.ZerosEsquerda(novoId, 6);
        }

        private void AtualizarManutencao()
        {
            var frmManutVendedor = Application.OpenForms
                .OfType<FrmManutVendedor>()
                .FirstOrDefault();

            if (frmManutVendedor != null)
            {
                frmManutVendedor.HabilitarTimer(true);
            }
        }

        #endregion

        #region CRUD Operations

        private VendedorModel MontarObjetoVendedor()
        {
            var vendedor = new VendedorModel();

            vendedor.Nome = txtNomeVendedor.Text.Trim();

            string StringParaNull(string valor)
            {
                return string.IsNullOrWhiteSpace(valor) ? null : valor.Trim();
            }

            // CPF
            string cpfRaw = Utilitario.ApenasNumeros(txtCpf.Text);
            vendedor.CPF = StringParaNull(cpfRaw);
            if (!string.IsNullOrEmpty(vendedor.CPF) && vendedor.CPF.Length != 11)
            {
                if (vendedor.CPF.Length > 11)
                    vendedor.CPF = vendedor.CPF.Substring(0, 11);
            }

            vendedor.RG = StringParaNull(txtRg.Text);

            // Telefone
            string telefoneRaw = Utilitario.ApenasNumeros(txtTelefone.Text);
            vendedor.Telefone = StringParaNull(telefoneRaw);

            vendedor.Email = StringParaNull(txtEmail.Text);

            if (int.TryParse(txtVendedorID.Text, out int id))
                vendedor.VendedorID = id;

            // Comissão
            if (decimal.TryParse(txtComissao.Text, out decimal comissao))
                vendedor.Comissao = comissao;
            else
                vendedor.Comissao = null;

            // Endereço
            vendedor.Endereco = StringParaNull(txtLogradouro.Text);
            vendedor.Numero = StringParaNull(txtNumero.Text);
            vendedor.Bairro = StringParaNull(txtBairro.Text);
            vendedor.CidadeID = CidadeID;
            vendedor.UF = StringParaNull(txtUF.Text);

            string cepRaw = Utilitario.ApenasNumeros(txtCep.Text);
            vendedor.CEP = StringParaNull(cepRaw);

            // Datas
            vendedor.DataNascimento = dtpDataNascimento.Checked ? dtpDataNascimento.Value.Date : (DateTime?)null;
            vendedor.DataContratacao = dtpDataContratacao.Checked ? dtpDataContratacao.Value.Date : (DateTime?)null;

            vendedor.Status = cmbStatus.Text == "Ativo" ? 1 : 0;
            vendedor.Observacoes = StringParaNull(txtObservacoes.Text);

            vendedor.EmpresaID = Sessao.EmpresaID;

            if (StatusOperacao == "NOVO")
            {
                vendedor.DataCriacao = DateTime.Now;
                vendedor.UsuarioCriacao = FrmLogin.UsuarioConectado;
            }

            vendedor.DataAtualizacao = DateTime.Now;
            vendedor.UsuarioAtualizacao = FrmLogin.UsuarioConectado;


            return vendedor;
        }

        public void SalvarRegistro()
        {
            try
            {
                var vendedor = MontarObjetoVendedor();
                _vendedorBll.Inserir(vendedor);

                Utilitario.Mensagens.Info("Vendedor cadastrado com sucesso!");

                AtualizarManutencao();
                LimparCampos();
                GerarNovoCodigo();
                txtNomeVendedor.Focus();
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
                var vendedor = MontarObjetoVendedor();
                vendedor.UsuarioAtualizacao = FrmLogin.UsuarioConectado;
                vendedor.DataAtualizacao = DateTime.Now;

                _vendedorBll.Atualizar(vendedor);

                Utilitario.Mensagens.Info("Vendedor alterado com sucesso!");
                toolStripStatusLabelUsuarioAtualizacao.Text = FrmLogin.UsuarioConectado;
                toolStripStatusLabelDataAtualizacao.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                this.Close();

                AtualizarManutencao();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso("Erro ao alterar: " + ex.Message);
            }
        }

        public void ExcluirRegistro()
        {
            if (MessageBox.Show($"Deseja realmente excluir o vendedor:\n\n{txtNomeVendedor.Text}?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _vendedorBll.Excluir(VendedorID);
                    Utilitario.Mensagens.Aviso("Vendedor excluído com sucesso!");

                    AtualizarManutencao();
                    this.Close();
                }
                catch (Exception ex)
                {
                    Utilitario.Mensagens.Erro("Erro ao excluir: " + ex.Message);
                }
            }
        }

        #endregion

        #region Eventos do Formulário

        private void FrmCadVendedor_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

            txtNomeVendedor.Focus();

            if (CarregandoDados)
            {
                txtCpf.Tag = "CPF";
                txtCpf.KeyPress -= Utilitario.MascaraCPF;
                txtCpf.KeyPress += Utilitario.MascaraCPF;
                return;
            }

            if (StatusOperacao == "NOVO")
            {
                GerarNovoCodigo();

                var frmManutVendedor = Application.OpenForms["FrmManutVendedor"] as FrmManutVendedor;
                frmManutVendedor?.HabilitarTimer(true);

                toolStripStatusLabelUsuarioCriacao.Text = FrmLogin.UsuarioConectado;
                ToolStripLabelDataCriacao.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                toolStripStatusLabelUsuarioAtualizacao.Text = "-";
                dtpDataContratacao.Value = DateTime.Now;

                if (cmbStatus.SelectedValue == null || !cmbStatus.SelectedValue.Equals(1))
                    cmbStatus.SelectedIndex = 0;
            }

            CarregandoDados = false;
        }

        private void FrmCadVendedor_Shown(object sender, EventArgs e)
        {
            Utilitario.AplicarCorFocoNosTextBox(this);
        }

        private void FrmCadVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        #endregion

        #region Botões

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (StatusOperacao == "NOVO")
                SalvarRegistro();
            else if (StatusOperacao == "ALTERAR")
                AlterarRegistro();
            else if (StatusOperacao == "EXCLUSAO")
                ExcluirRegistro();

            btnSalvar.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            GerarNovoCodigo();
            txtNomeVendedor.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            await BuscarEnderecoPorCep();
        }

        private void btnLocalizarCidade_Click(object sender, EventArgs e)
        {
            AbrirFrmLocalizarCidadeDinamico();
        }

        #endregion

        #region Métodos Auxiliares

        private void LimparCampos()
        {
            Utilitario.LimparCampos(this);
            dtpDataNascimento.Value = DateTime.Now;
            dtpDataContratacao.Value = DateTime.Now;
        }

        private void AbrirFrmLocalizarCidadeDinamico()
        {
            txtNomeCidade.TextChanged -= txtNomeCidade_TextChanged;

            using (FrmLocalizarCidade frmLocalizarCidade = new FrmLocalizarCidade(this, txtNomeCidade.Text))
            {
                frmLocalizarCidade.Owner = this;
                frmLocalizarCidade.ShowDialog();

                if (!string.IsNullOrEmpty(frmLocalizarCidade.CidadeSelecionado))
                {
                    txtNomeCidade.Text = frmLocalizarCidade.CidadeSelecionado;
                    CidadeID = frmLocalizarCidade.CidadeID;
                    txtUF.Text = frmLocalizarCidade.Uf;
                }
            }

            txtNomeCidade.TextChanged += txtNomeCidade_TextChanged;
        }

        private void txtComissao_TextChanged(object sender, EventArgs e)
        {
            KryptonTextBox txt = (KryptonTextBox)sender;

            string apenasNumeros = Utilitario.ApenasNumeros(txt.Text);

            if (string.IsNullOrEmpty(apenasNumeros))
            {
                txt.Text = "0,00";
                txt.SelectionStart = txt.Text.Length;
                return;
            }

            if (apenasNumeros.Length < 3)
                apenasNumeros = apenasNumeros.PadLeft(3, '0');

            decimal valor = decimal.Parse(apenasNumeros) / 100m;

            txt.Text = valor.ToString("N2");
            txt.SelectionStart = txt.Text.Length;
        }

        private void txtComissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        #endregion

        #region Eventos de Formatação

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario.AplicarMascaraCEP(e, txtCep);
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario.MascaraTelefone(sender, e);
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            string numero = Utilitario.ApenasNumeros(txtCpf.Text);

            if (string.IsNullOrEmpty(numero))
            {
                txtCpf.StateCommon.Border.Color1 = Color.Gray;
                return;
            }
            txtCpf.StateCommon.Border.Color1 = Color.MediumSeaGreen;
        }

        private void txtNomeCidade_TextChanged(object sender, EventArgs e)
        {
            if (bloqueiaPesquisa || string.IsNullOrWhiteSpace(txtNomeCidade.Text) || txtNomeCidade.Text.Length < 2)
                return;

            if (this.IsDisposed || !this.IsHandleCreated || this.Disposing)
                return;

            string textoDigitado = txtNomeCidade.Text.Trim();

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

                        if (!this.IsDisposed && this.Visible)
                        {
                            pesquisaCidade.Owner = this;
                        }

                        if (pesquisaCidade.ShowDialog() == DialogResult.OK)
                        {
                            if (!txtNomeCidade.IsDisposed)
                            {
                                txtNomeCidade.Text = pesquisaCidade.CidadeSelecionado;
                                CidadeID = pesquisaCidade.CidadeID;
                                txtUF.Text = pesquisaCidade.Uf;
                                txtNomeCidade.SelectionStart = txtNomeCidade.Text.Length;
                            }
                        }
                    }
                }
                catch (ObjectDisposedException)
                {
                    // Ignorar
                }
                catch (Exception ex)
                {
                    Utilitario.Mensagens.Aviso($"Erro ao buscar cidade: {ex.Message}");
                }
                finally
                {
                    bloqueiaPesquisa = false;
                }
            }));
        }

        #endregion
    }
}