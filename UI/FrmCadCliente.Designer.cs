namespace GVC.View
{
    partial class FrmCadCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadCliente));
            txtLogradouro = new Krypton.Toolkit.KryptonTextBox();
            txtTelefone = new Krypton.Toolkit.KryptonTextBox();
            txtNomeCliente = new Krypton.Toolkit.KryptonTextBox();
            txtClienteID = new Krypton.Toolkit.KryptonTextBox();
            txtNomeCidade = new Krypton.Toolkit.KryptonTextBox();
            txtEmail = new Krypton.Toolkit.KryptonTextBox();
            txtBairro = new Krypton.Toolkit.KryptonTextBox();
            txtNumero = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloCodigo = new Label();
            lblRotuloNome = new Label();
            lblCpf = new Label();
            lblRotuloTelefone = new Label();
            lblBairro = new Label();
            lblNumero = new Label();
            lblRotEndereco = new Label();
            lblRotuloEmail = new Label();
            txtUF = new Krypton.Toolkit.KryptonTextBox();
            lblUf = new Label();
            lblCep = new Label();
            txtCep = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloDtNascDtCriacao = new Label();
            lblRotuloTipoPessoa = new Label();
            txtObservacoes = new Krypton.Toolkit.KryptonTextBox();
            label7 = new Label();
            txtLimiteCredito = new Krypton.Toolkit.KryptonTextBox();
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            toolStripStatusLabelUsuarioCriacao = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel6 = new ToolStripStatusLabel();
            toolStripStatusLabel5 = new ToolStripStatusLabel();
            ToolStripLabelDataCriacao = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            ToolStripLabelDataUtimaCompra = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabelUsuarioAtualizacao = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabelDataAtualizacao = new ToolStripStatusLabel();
            lblStatus = new ToolStripStatusLabel();
            txtCpf = new Krypton.Toolkit.KryptonTextBox();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            txtRg = new Krypton.Toolkit.KryptonTextBox();
            lblRG = new Label();
            txtOrgaoExpedidorRG = new Krypton.Toolkit.KryptonTextBox();
            lblOrgaoExpedidorRG = new Label();
            lblRotCidade = new Label();
            cmbStatus = new Krypton.Toolkit.KryptonComboBox();
            lblRotuloStatus = new Label();
            toolTip = new ToolTip(components);
            Timer1 = new System.Windows.Forms.Timer(components);
            txtCnpj = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloCnpj = new Label();
            txtIE = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloIE = new Label();
            chkIsVendedor = new CheckBox();
            btnSalvar = new Krypton.Toolkit.KryptonButton();
            btnNovo = new Krypton.Toolkit.KryptonButton();
            btnSair = new Krypton.Toolkit.KryptonButton();
            pnlHeader = new Krypton.Toolkit.KryptonPanel();
            tlpTitulo = new Krypton.Toolkit.KryptonTableLayoutPanel();
            lblSubTitulo = new Krypton.Toolkit.KryptonLabel();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            pnlDadosCadastrais = new Krypton.Toolkit.KryptonPanel();
            cmbTipoPessoa = new Krypton.Toolkit.KryptonComboBox();
            lblRotuloDadosCadastrais = new Krypton.Toolkit.KryptonLabel();
            lblEVendedor = new Label();
            pnlDadosAdicionais = new Krypton.Toolkit.KryptonPanel();
            dtpDataNascimento = new Krypton.Toolkit.KryptonDateTimePicker();
            lblRotuloDadosAdicionais = new Krypton.Toolkit.KryptonLabel();
            pnlEndereco = new Krypton.Toolkit.KryptonPanel();
            btnLocalizarCidade = new FontAwesome.Sharp.IconButton();
            btnPesquisarCep = new FontAwesome.Sharp.IconButton();
            lblEndereco = new Krypton.Toolkit.KryptonLabel();
            pnlObservacao = new Krypton.Toolkit.KryptonPanel();
            lblObservacao = new Krypton.Toolkit.KryptonLabel();
            kryptonStatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).BeginInit();
            pnlHeader.SuspendLayout();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlDadosCadastrais).BeginInit();
            pnlDadosCadastrais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbTipoPessoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlDadosAdicionais).BeginInit();
            pnlDadosAdicionais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlEndereco).BeginInit();
            pnlEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlObservacao).BeginInit();
            pnlObservacao.SuspendLayout();
            SuspendLayout();
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLogradouro.CharacterCasing = CharacterCasing.Upper;
            txtLogradouro.Location = new Point(261, 46);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(750, 27);
            txtLogradouro.StateCommon.Back.Color1 = Color.White;
            txtLogradouro.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtLogradouro.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtLogradouro.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtLogradouro.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtLogradouro.StateCommon.Border.Rounding = 8F;
            txtLogradouro.StateCommon.Border.Width = 1;
            txtLogradouro.StateCommon.Content.Color1 = Color.Gray;
            txtLogradouro.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtLogradouro.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtLogradouro.TabIndex = 111;
            txtLogradouro.TabStop = false;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(147, 45);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(268, 27);
            txtTelefone.StateCommon.Back.Color1 = Color.White;
            txtTelefone.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtTelefone.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtTelefone.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTelefone.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtTelefone.StateCommon.Border.Rounding = 8F;
            txtTelefone.StateCommon.Border.Width = 1;
            txtTelefone.StateCommon.Content.Color1 = Color.Gray;
            txtTelefone.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtTelefone.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtTelefone.TabIndex = 5;
            txtTelefone.KeyPress += txtTelefone_KeyPress;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomeCliente.CharacterCasing = CharacterCasing.Upper;
            txtNomeCliente.Location = new Point(165, 38);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(632, 27);
            txtNomeCliente.StateCommon.Back.Color1 = Color.White;
            txtNomeCliente.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNomeCliente.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNomeCliente.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNomeCliente.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNomeCliente.StateCommon.Border.Rounding = 8F;
            txtNomeCliente.StateCommon.Border.Width = 1;
            txtNomeCliente.StateCommon.Content.Color1 = Color.Gray;
            txtNomeCliente.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtNomeCliente.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNomeCliente.TabIndex = 0;
            // 
            // txtClienteID
            // 
            txtClienteID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtClienteID.Location = new Point(803, 38);
            txtClienteID.Name = "txtClienteID";
            txtClienteID.ReadOnly = true;
            txtClienteID.Size = new Size(118, 27);
            txtClienteID.StateCommon.Back.Color1 = Color.White;
            txtClienteID.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtClienteID.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtClienteID.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtClienteID.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtClienteID.StateCommon.Border.Rounding = 8F;
            txtClienteID.StateCommon.Border.Width = 1;
            txtClienteID.StateCommon.Content.Color1 = Color.Gray;
            txtClienteID.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtClienteID.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtClienteID.TabIndex = 192;
            txtClienteID.TabStop = false;
            // 
            // txtNomeCidade
            // 
            txtNomeCidade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomeCidade.CharacterCasing = CharacterCasing.Upper;
            txtNomeCidade.Location = new Point(13, 145);
            txtNomeCidade.Name = "txtNomeCidade";
            txtNomeCidade.Size = new Size(827, 27);
            txtNomeCidade.StateCommon.Back.Color1 = Color.White;
            txtNomeCidade.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNomeCidade.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNomeCidade.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNomeCidade.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNomeCidade.StateCommon.Border.Rounding = 8F;
            txtNomeCidade.StateCommon.Border.Width = 1;
            txtNomeCidade.StateCommon.Content.Color1 = Color.Gray;
            txtNomeCidade.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtNomeCidade.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNomeCidade.TabIndex = 140;
            txtNomeCidade.TabStop = false;
            txtNomeCidade.TextChanged += txtNomeCidade_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.CharacterCasing = CharacterCasing.Lower;
            txtEmail.Location = new Point(13, 92);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(997, 27);
            txtEmail.StateCommon.Back.Color1 = Color.White;
            txtEmail.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtEmail.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtEmail.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtEmail.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtEmail.StateCommon.Border.Rounding = 8F;
            txtEmail.StateCommon.Border.Width = 1;
            txtEmail.StateCommon.Content.Color1 = Color.Gray;
            txtEmail.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtEmail.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtEmail.TabIndex = 7;
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtBairro.Location = new Point(261, 95);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(749, 27);
            txtBairro.StateCommon.Back.Color1 = Color.White;
            txtBairro.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtBairro.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtBairro.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtBairro.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtBairro.StateCommon.Border.Rounding = 8F;
            txtBairro.StateCommon.Border.Width = 1;
            txtBairro.StateCommon.Content.Color1 = Color.Gray;
            txtBairro.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtBairro.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtBairro.TabIndex = 130;
            txtBairro.TabStop = false;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(13, 95);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(241, 27);
            txtNumero.StateCommon.Back.Color1 = Color.White;
            txtNumero.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNumero.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNumero.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNumero.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNumero.StateCommon.Border.Rounding = 8F;
            txtNumero.StateCommon.Border.Width = 1;
            txtNumero.StateCommon.Content.Color1 = Color.Gray;
            txtNumero.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtNumero.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNumero.TabIndex = 10;
            // 
            // lblRotuloCodigo
            // 
            lblRotuloCodigo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRotuloCodigo.AutoSize = true;
            lblRotuloCodigo.BackColor = Color.Transparent;
            lblRotuloCodigo.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloCodigo.Location = new Point(807, 20);
            lblRotuloCodigo.Name = "lblRotuloCodigo";
            lblRotuloCodigo.Size = new Size(49, 15);
            lblRotuloCodigo.TabIndex = 184;
            lblRotuloCodigo.Text = "Código:";
            // 
            // lblRotuloNome
            // 
            lblRotuloNome.AutoSize = true;
            lblRotuloNome.BackColor = Color.Transparent;
            lblRotuloNome.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloNome.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloNome.Location = new Point(166, 19);
            lblRotuloNome.Name = "lblRotuloNome";
            lblRotuloNome.Size = new Size(44, 16);
            lblRotuloNome.TabIndex = 183;
            lblRotuloNome.Text = "Nome";
            // 
            // lblCpf
            // 
            lblCpf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCpf.AutoSize = true;
            lblCpf.BackColor = Color.Transparent;
            lblCpf.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblCpf.ForeColor = Color.FromArgb(0, 76, 172);
            lblCpf.Location = new Point(471, 70);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(33, 16);
            lblCpf.TabIndex = 186;
            lblCpf.Text = "CPF";
            // 
            // lblRotuloTelefone
            // 
            lblRotuloTelefone.AutoSize = true;
            lblRotuloTelefone.BackColor = Color.Transparent;
            lblRotuloTelefone.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloTelefone.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloTelefone.Location = new Point(148, 27);
            lblRotuloTelefone.Name = "lblRotuloTelefone";
            lblRotuloTelefone.Size = new Size(61, 16);
            lblRotuloTelefone.TabIndex = 185;
            lblRotuloTelefone.Text = "Telefone";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.BackColor = Color.Transparent;
            lblBairro.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblBairro.ForeColor = Color.FromArgb(0, 76, 172);
            lblBairro.Location = new Point(264, 75);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(43, 16);
            lblBairro.TabIndex = 185;
            lblBairro.Text = "Bairro";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = Color.Transparent;
            lblNumero.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblNumero.ForeColor = Color.FromArgb(0, 76, 172);
            lblNumero.Location = new Point(13, 75);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(55, 16);
            lblNumero.TabIndex = 184;
            lblNumero.Text = "Número";
            // 
            // lblRotEndereco
            // 
            lblRotEndereco.AutoSize = true;
            lblRotEndereco.BackColor = Color.Transparent;
            lblRotEndereco.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotEndereco.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotEndereco.Location = new Point(262, 26);
            lblRotEndereco.Name = "lblRotEndereco";
            lblRotEndereco.Size = new Size(66, 16);
            lblRotEndereco.TabIndex = 183;
            lblRotEndereco.Text = "Endereço";
            // 
            // lblRotuloEmail
            // 
            lblRotuloEmail.AutoSize = true;
            lblRotuloEmail.BackColor = Color.Transparent;
            lblRotuloEmail.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloEmail.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloEmail.Location = new Point(13, 74);
            lblRotuloEmail.Name = "lblRotuloEmail";
            lblRotuloEmail.Size = new Size(45, 16);
            lblRotuloEmail.TabIndex = 183;
            lblRotuloEmail.Text = "E-Mail";
            // 
            // txtUF
            // 
            txtUF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtUF.CharacterCasing = CharacterCasing.Upper;
            txtUF.Location = new Point(878, 144);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(133, 27);
            txtUF.StateCommon.Back.Color1 = Color.White;
            txtUF.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtUF.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtUF.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtUF.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtUF.StateCommon.Border.Rounding = 8F;
            txtUF.StateCommon.Border.Width = 1;
            txtUF.StateCommon.Content.Color1 = Color.Gray;
            txtUF.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtUF.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtUF.TabIndex = 150;
            txtUF.TabStop = false;
            // 
            // lblUf
            // 
            lblUf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUf.AutoSize = true;
            lblUf.BackColor = Color.Transparent;
            lblUf.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblUf.ForeColor = Color.FromArgb(0, 76, 172);
            lblUf.Location = new Point(879, 125);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(20, 16);
            lblUf.TabIndex = 183;
            lblUf.Text = "Uf";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.BackColor = Color.Transparent;
            lblCep.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblCep.ForeColor = Color.FromArgb(0, 76, 172);
            lblCep.Location = new Point(13, 26);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(32, 16);
            lblCep.TabIndex = 250;
            lblCep.Text = "Cep";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(13, 46);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(207, 27);
            txtCep.StateCommon.Back.Color1 = Color.White;
            txtCep.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtCep.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtCep.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtCep.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtCep.StateCommon.Border.Rounding = 8F;
            txtCep.StateCommon.Border.Width = 1;
            txtCep.StateCommon.Content.Color1 = Color.Gray;
            txtCep.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtCep.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtCep.TabIndex = 8;
            txtCep.KeyPress += txtCep_KeyPress;
            txtCep.Leave += txtCep_Leave;
            // 
            // lblRotuloDtNascDtCriacao
            // 
            lblRotuloDtNascDtCriacao.AutoSize = true;
            lblRotuloDtNascDtCriacao.BackColor = Color.Transparent;
            lblRotuloDtNascDtCriacao.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloDtNascDtCriacao.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloDtNascDtCriacao.Location = new Point(13, 27);
            lblRotuloDtNascDtCriacao.Name = "lblRotuloDtNascDtCriacao";
            lblRotuloDtNascDtCriacao.Size = new Size(112, 16);
            lblRotuloDtNascDtCriacao.TabIndex = 252;
            lblRotuloDtNascDtCriacao.Text = "Dt. Nasc./Criação";
            // 
            // lblRotuloTipoPessoa
            // 
            lblRotuloTipoPessoa.AutoSize = true;
            lblRotuloTipoPessoa.BackColor = Color.Transparent;
            lblRotuloTipoPessoa.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloTipoPessoa.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloTipoPessoa.Location = new Point(7, 19);
            lblRotuloTipoPessoa.Name = "lblRotuloTipoPessoa";
            lblRotuloTipoPessoa.Size = new Size(104, 16);
            lblRotuloTipoPessoa.TabIndex = 1016;
            lblRotuloTipoPessoa.Text = "Tipo da Pessoa";
            // 
            // txtObservacoes
            // 
            txtObservacoes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtObservacoes.CharacterCasing = CharacterCasing.Upper;
            txtObservacoes.Location = new Point(13, 23);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(997, 49);
            txtObservacoes.StateCommon.Back.Color1 = Color.White;
            txtObservacoes.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtObservacoes.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtObservacoes.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtObservacoes.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtObservacoes.StateCommon.Border.Rounding = 8F;
            txtObservacoes.StateCommon.Border.Width = 1;
            txtObservacoes.StateCommon.Content.Color1 = Color.Gray;
            txtObservacoes.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtObservacoes.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtObservacoes.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 9.25F);
            label7.ForeColor = Color.FromArgb(0, 76, 172);
            label7.Location = new Point(423, 26);
            label7.Name = "label7";
            label7.Size = new Size(112, 16);
            label7.TabIndex = 1021;
            label7.Text = "Limite de Crédido";
            // 
            // txtLimiteCredito
            // 
            txtLimiteCredito.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLimiteCredito.CharacterCasing = CharacterCasing.Upper;
            txtLimiteCredito.Location = new Point(421, 45);
            txtLimiteCredito.Name = "txtLimiteCredito";
            txtLimiteCredito.Size = new Size(590, 27);
            txtLimiteCredito.StateCommon.Back.Color1 = Color.White;
            txtLimiteCredito.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtLimiteCredito.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtLimiteCredito.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtLimiteCredito.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtLimiteCredito.StateCommon.Border.Rounding = 8F;
            txtLimiteCredito.StateCommon.Border.Width = 1;
            txtLimiteCredito.StateCommon.Content.Color1 = Color.Gray;
            txtLimiteCredito.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtLimiteCredito.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtLimiteCredito.TabIndex = 6;
            txtLimiteCredito.TextChanged += txtLimiteCredito_TextChanged;
            txtLimiteCredito.KeyPress += txtLimiteCredito_KeyPress;
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelUsuarioCriacao, toolStripStatusLabel2, toolStripStatusLabel6, toolStripStatusLabel5, ToolStripLabelDataCriacao, toolStripStatusLabel4, ToolStripLabelDataUtimaCompra, toolStripStatusLabel1, toolStripStatusLabelUsuarioAtualizacao, toolStripStatusLabel3, toolStripStatusLabelDataAtualizacao, lblStatus });
            kryptonStatusStrip1.Location = new Point(0, 639);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.Professional;
            kryptonStatusStrip1.Size = new Size(1026, 22);
            kryptonStatusStrip1.TabIndex = 1027;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // toolStripStatusLabelUsuarioCriacao
            // 
            toolStripStatusLabelUsuarioCriacao.ForeColor = Color.FromArgb(0, 76, 172);
            toolStripStatusLabelUsuarioCriacao.Name = "toolStripStatusLabelUsuarioCriacao";
            toolStripStatusLabelUsuarioCriacao.Size = new Size(99, 17);
            toolStripStatusLabelUsuarioCriacao.Text = "Usuario Criação...";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(16, 17);
            toolStripStatusLabel2.Text = " | ";
            // 
            // toolStripStatusLabel6
            // 
            toolStripStatusLabel6.ForeColor = Color.FromArgb(0, 76, 172);
            toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            toolStripStatusLabel6.Size = new Size(99, 17);
            toolStripStatusLabel6.Text = "Data da Criação...";
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.ForeColor = Color.FromArgb(0, 76, 172);
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new Size(131, 17);
            toolStripStatusLabel5.Text = "Data da Ultima Compra";
            // 
            // ToolStripLabelDataCriacao
            // 
            ToolStripLabelDataCriacao.ForeColor = Color.FromArgb(0, 76, 172);
            ToolStripLabelDataCriacao.Name = "ToolStripLabelDataCriacao";
            ToolStripLabelDataCriacao.Size = new Size(99, 17);
            ToolStripLabelDataCriacao.Text = "Data da Criação...";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(16, 17);
            toolStripStatusLabel4.Text = " | ";
            // 
            // ToolStripLabelDataUtimaCompra
            // 
            ToolStripLabelDataUtimaCompra.ForeColor = Color.FromArgb(0, 76, 172);
            ToolStripLabelDataUtimaCompra.Name = "ToolStripLabelDataUtimaCompra";
            ToolStripLabelDataUtimaCompra.Size = new Size(131, 17);
            ToolStripLabelDataUtimaCompra.Text = "Data da Ultima Compra";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(16, 17);
            toolStripStatusLabel1.Text = " | ";
            // 
            // toolStripStatusLabelUsuarioAtualizacao
            // 
            toolStripStatusLabelUsuarioAtualizacao.ForeColor = Color.FromArgb(0, 76, 172);
            toolStripStatusLabelUsuarioAtualizacao.Name = "toolStripStatusLabelUsuarioAtualizacao";
            toolStripStatusLabelUsuarioAtualizacao.Size = new Size(100, 17);
            toolStripStatusLabelUsuarioAtualizacao.Text = "Usuário Alteração";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(16, 17);
            toolStripStatusLabel3.Text = " | ";
            // 
            // toolStripStatusLabelDataAtualizacao
            // 
            toolStripStatusLabelDataAtualizacao.ForeColor = Color.FromArgb(0, 76, 172);
            toolStripStatusLabelDataAtualizacao.Name = "toolStripStatusLabelDataAtualizacao";
            toolStripStatusLabelDataAtualizacao.Size = new Size(95, 17);
            toolStripStatusLabelDataAtualizacao.Text = "Data Atualização";
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.FromArgb(0, 76, 172);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 17);
            lblStatus.Text = "Status";
            // 
            // txtCpf
            // 
            txtCpf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCpf.CharacterCasing = CharacterCasing.Upper;
            txtCpf.Location = new Point(467, 90);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(180, 27);
            txtCpf.StateCommon.Back.Color1 = Color.White;
            txtCpf.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtCpf.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtCpf.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtCpf.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtCpf.StateCommon.Border.Rounding = 8F;
            txtCpf.StateCommon.Border.Width = 1;
            txtCpf.StateCommon.Content.Color1 = Color.Gray;
            txtCpf.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtCpf.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtCpf.TabIndex = 1;
            // 
            // kryptonPalette1
            // 
            kryptonPalette1.ButtonSpecs.FormClose.Image = Properties.Resources.Exit;
            kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = Properties.Resources.Sairr;
            kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = Properties.Resources.Sairr;
            kryptonPalette1.ButtonSpecs.FormMax.Image = Properties.Resources.Maximize;
            kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed = Properties.Resources.Minimiza24;
            kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = Properties.Resources.Minimiza24;
            kryptonPalette1.ButtonSpecs.FormMin.Image = Properties.Resources.Minimize;
            kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed = Properties.Resources.Minimizar24;
            kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = Properties.Resources.Minimizar24;
            kryptonPalette1.ButtonSpecs.FormRestore.Image = Properties.Resources.Maximize;
            kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImagePressed = Properties.Resources.Minimiza24;
            kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImageTracking = Properties.Resources.Maximize;
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12F;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(10, -1, -1, -1);
            // 
            // txtRg
            // 
            txtRg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtRg.Location = new Point(651, 90);
            txtRg.Name = "txtRg";
            txtRg.Size = new Size(180, 27);
            txtRg.StateCommon.Back.Color1 = Color.White;
            txtRg.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtRg.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtRg.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtRg.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtRg.StateCommon.Border.Rounding = 8F;
            txtRg.StateCommon.Border.Width = 1;
            txtRg.StateCommon.Content.Color1 = Color.Gray;
            txtRg.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtRg.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtRg.TabIndex = 2;
            // 
            // lblRG
            // 
            lblRG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRG.AutoSize = true;
            lblRG.BackColor = Color.Transparent;
            lblRG.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRG.ForeColor = Color.FromArgb(0, 76, 172);
            lblRG.Location = new Point(654, 71);
            lblRG.Name = "lblRG";
            lblRG.Size = new Size(124, 16);
            lblRG.TabIndex = 1031;
            lblRG.Text = "RG - Registro Geral";
            // 
            // txtOrgaoExpedidorRG
            // 
            txtOrgaoExpedidorRG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtOrgaoExpedidorRG.Location = new Point(836, 89);
            txtOrgaoExpedidorRG.Name = "txtOrgaoExpedidorRG";
            txtOrgaoExpedidorRG.Size = new Size(180, 27);
            txtOrgaoExpedidorRG.StateCommon.Back.Color1 = Color.White;
            txtOrgaoExpedidorRG.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtOrgaoExpedidorRG.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtOrgaoExpedidorRG.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtOrgaoExpedidorRG.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtOrgaoExpedidorRG.StateCommon.Border.Rounding = 8F;
            txtOrgaoExpedidorRG.StateCommon.Border.Width = 1;
            txtOrgaoExpedidorRG.StateCommon.Content.Color1 = Color.Gray;
            txtOrgaoExpedidorRG.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtOrgaoExpedidorRG.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtOrgaoExpedidorRG.TabIndex = 3;
            // 
            // lblOrgaoExpedidorRG
            // 
            lblOrgaoExpedidorRG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOrgaoExpedidorRG.AutoSize = true;
            lblOrgaoExpedidorRG.BackColor = Color.Transparent;
            lblOrgaoExpedidorRG.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblOrgaoExpedidorRG.ForeColor = Color.FromArgb(0, 76, 172);
            lblOrgaoExpedidorRG.Location = new Point(838, 70);
            lblOrgaoExpedidorRG.Name = "lblOrgaoExpedidorRG";
            lblOrgaoExpedidorRG.Size = new Size(133, 16);
            lblOrgaoExpedidorRG.TabIndex = 1033;
            lblOrgaoExpedidorRG.Text = "Orgão Expedidor RG";
            // 
            // lblRotCidade
            // 
            lblRotCidade.AutoSize = true;
            lblRotCidade.BackColor = Color.Transparent;
            lblRotCidade.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotCidade.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotCidade.Location = new Point(13, 125);
            lblRotCidade.Name = "lblRotCidade";
            lblRotCidade.Size = new Size(51, 16);
            lblRotCidade.TabIndex = 1034;
            lblRotCidade.Text = "Cidade";
            // 
            // cmbStatus
            // 
            cmbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbStatus.CornerRoundingRadius = 10F;
            cmbStatus.DropDownWidth = 171;
            cmbStatus.IntegralHeight = false;
            cmbStatus.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cmbStatus.Location = new Point(7, 89);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(454, 27);
            cmbStatus.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(8, 142, 254);
            cmbStatus.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(8, 142, 254);
            cmbStatus.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbStatus.StateCommon.ComboBox.Border.Rounding = 10F;
            cmbStatus.StateCommon.ComboBox.Border.Width = 1;
            cmbStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbStatus.TabIndex = 1035;
            cmbStatus.TabStop = false;
            // 
            // lblRotuloStatus
            // 
            lblRotuloStatus.AutoSize = true;
            lblRotuloStatus.BackColor = Color.Transparent;
            lblRotuloStatus.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloStatus.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloStatus.Location = new Point(7, 70);
            lblRotuloStatus.Name = "lblRotuloStatus";
            lblRotuloStatus.Size = new Size(44, 16);
            lblRotuloStatus.TabIndex = 1036;
            lblRotuloStatus.Text = "Status";
            // 
            // Timer1
            // 
            Timer1.Interval = 500;
            // 
            // txtCnpj
            // 
            txtCnpj.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCnpj.Location = new Point(467, 90);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(180, 27);
            txtCnpj.StateCommon.Back.Color1 = Color.White;
            txtCnpj.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtCnpj.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtCnpj.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtCnpj.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtCnpj.StateCommon.Border.Rounding = 8F;
            txtCnpj.StateCommon.Border.Width = 1;
            txtCnpj.StateCommon.Content.Color1 = Color.Gray;
            txtCnpj.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtCnpj.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtCnpj.TabIndex = 1;
            txtCnpj.Visible = false;
            // 
            // lblRotuloCnpj
            // 
            lblRotuloCnpj.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRotuloCnpj.AutoSize = true;
            lblRotuloCnpj.BackColor = Color.Transparent;
            lblRotuloCnpj.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloCnpj.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloCnpj.Location = new Point(471, 71);
            lblRotuloCnpj.Name = "lblRotuloCnpj";
            lblRotuloCnpj.Size = new Size(42, 16);
            lblRotuloCnpj.TabIndex = 1039;
            lblRotuloCnpj.Text = "CNPJ";
            lblRotuloCnpj.Visible = false;
            // 
            // txtIE
            // 
            txtIE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtIE.Location = new Point(651, 90);
            txtIE.Name = "txtIE";
            txtIE.Size = new Size(180, 27);
            txtIE.StateCommon.Back.Color1 = Color.White;
            txtIE.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtIE.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtIE.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtIE.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtIE.StateCommon.Border.Rounding = 8F;
            txtIE.StateCommon.Border.Width = 1;
            txtIE.StateCommon.Content.Color1 = Color.Gray;
            txtIE.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtIE.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtIE.TabIndex = 1040;
            txtIE.Visible = false;
            // 
            // lblRotuloIE
            // 
            lblRotuloIE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRotuloIE.AutoSize = true;
            lblRotuloIE.BackColor = Color.Transparent;
            lblRotuloIE.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloIE.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloIE.Location = new Point(654, 71);
            lblRotuloIE.Name = "lblRotuloIE";
            lblRotuloIE.Size = new Size(140, 16);
            lblRotuloIE.TabIndex = 1041;
            lblRotuloIE.Text = "IE (Inscrição Estadual)";
            lblRotuloIE.Visible = false;
            // 
            // chkIsVendedor
            // 
            chkIsVendedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkIsVendedor.AutoSize = true;
            chkIsVendedor.BackColor = Color.Transparent;
            chkIsVendedor.Font = new Font("Segoe UI", 10F);
            chkIsVendedor.Location = new Point(938, 43);
            chkIsVendedor.Name = "chkIsVendedor";
            chkIsVendedor.Size = new Size(50, 23);
            chkIsVendedor.TabIndex = 200;
            chkIsVendedor.TabStop = false;
            chkIsVendedor.Text = "Sim";
            chkIsVendedor.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.CornerRoundingRadius = 20F;
            btnSalvar.Location = new Point(702, 603);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvar.OverrideDefault.Back.ColorAngle = 45F;
            btnSalvar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvar.OverrideDefault.Border.ColorAngle = 45F;
            btnSalvar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvar.OverrideDefault.Border.Rounding = 20F;
            btnSalvar.OverrideDefault.Border.Width = 1;
            btnSalvar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSalvar.Size = new Size(100, 30);
            btnSalvar.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvar.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvar.StateCommon.Back.ColorAngle = 45F;
            btnSalvar.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvar.StateCommon.Border.ColorAngle = 45F;
            btnSalvar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvar.StateCommon.Border.Rounding = 20F;
            btnSalvar.StateCommon.Border.Width = 1;
            btnSalvar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSalvar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSalvar.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            btnSalvar.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSalvar.StateNormal.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnSalvar.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvar.StateNormal.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSalvar.StateNormal.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSalvar.StateNormal.Border.ColorAngle = 45F;
            btnSalvar.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvar.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvar.StateNormal.Border.Rounding = 20F;
            btnSalvar.StateNormal.Border.Width = 1;
            btnSalvar.StatePressed.Back.Color1 = Color.White;
            btnSalvar.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnSalvar.StatePressed.Back.ColorAngle = 135F;
            btnSalvar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSalvar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSalvar.StatePressed.Border.ColorAngle = 135F;
            btnSalvar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvar.StatePressed.Border.Rounding = 20F;
            btnSalvar.StatePressed.Border.Width = 1;
            btnSalvar.StatePressed.Content.ShortText.Color1 = Color.FromArgb(22, 121, 206);
            btnSalvar.StateTracking.Back.Color1 = Color.White;
            btnSalvar.StateTracking.Back.Color2 = Color.White;
            btnSalvar.StateTracking.Back.ColorAngle = 45F;
            btnSalvar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvar.StateTracking.Border.ColorAngle = 45F;
            btnSalvar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvar.StateTracking.Border.Rounding = 20F;
            btnSalvar.StateTracking.Border.Width = 1;
            btnSalvar.StateTracking.Content.ShortText.Color1 = Color.FromArgb(22, 121, 206);
            btnSalvar.TabIndex = 13;
            btnSalvar.Values.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNovo.CornerRoundingRadius = 20F;
            btnNovo.Location = new Point(808, 603);
            btnNovo.Name = "btnNovo";
            btnNovo.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnNovo.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnNovo.OverrideDefault.Back.ColorAngle = 45F;
            btnNovo.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnNovo.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNovo.OverrideDefault.Border.ColorAngle = 45F;
            btnNovo.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.OverrideDefault.Border.Rounding = 20F;
            btnNovo.OverrideDefault.Border.Width = 1;
            btnNovo.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnNovo.Size = new Size(100, 30);
            btnNovo.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnNovo.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 250);
            btnNovo.StateCommon.Back.ColorAngle = 45F;
            btnNovo.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNovo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNovo.StateCommon.Border.ColorAngle = 45F;
            btnNovo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.StateCommon.Border.Rounding = 20F;
            btnNovo.StateCommon.Border.Width = 1;
            btnNovo.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnNovo.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            btnNovo.StateNormal.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnNovo.StateNormal.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnNovo.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.StateNormal.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnNovo.StateNormal.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnNovo.StateNormal.Border.ColorAngle = 45F;
            btnNovo.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.StateNormal.Border.Rounding = 20F;
            btnNovo.StateNormal.Border.Width = 1;
            btnNovo.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnNovo.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnNovo.StatePressed.Back.ColorAngle = 135F;
            btnNovo.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnNovo.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnNovo.StatePressed.Border.ColorAngle = 135F;
            btnNovo.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.StatePressed.Border.Rounding = 20F;
            btnNovo.StatePressed.Border.Width = 1;
            btnNovo.StatePressed.Content.ShortText.Color1 = Color.White;
            btnNovo.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnNovo.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnNovo.StateTracking.Back.ColorAngle = 45F;
            btnNovo.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNovo.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNovo.StateTracking.Border.ColorAngle = 45F;
            btnNovo.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.StateTracking.Border.Rounding = 20F;
            btnNovo.StateTracking.Border.Width = 1;
            btnNovo.StateTracking.Content.ShortText.Color1 = Color.White;
            btnNovo.TabIndex = 1043;
            btnNovo.Values.Text = "Novo";
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSair.CornerRoundingRadius = 20F;
            btnSair.Location = new Point(914, 603);
            btnSair.Name = "btnSair";
            btnSair.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnSair.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnSair.OverrideDefault.Back.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Border.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.OverrideDefault.Border.Rounding = 20F;
            btnSair.OverrideDefault.Border.Width = 1;
            btnSair.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSair.Size = new Size(100, 30);
            btnSair.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnSair.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 250);
            btnSair.StateCommon.Back.ColorAngle = 45F;
            btnSair.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Border.ColorAngle = 45F;
            btnSair.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateCommon.Border.Rounding = 20F;
            btnSair.StateCommon.Border.Width = 1;
            btnSair.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            btnSair.StateNormal.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnSair.StateNormal.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnSair.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateNormal.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StateNormal.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StateNormal.Border.ColorAngle = 45F;
            btnSair.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateNormal.Border.Rounding = 20F;
            btnSair.StateNormal.Border.Width = 1;
            btnSair.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StatePressed.Back.ColorAngle = 135F;
            btnSair.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StatePressed.Border.ColorAngle = 135F;
            btnSair.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StatePressed.Border.Rounding = 20F;
            btnSair.StatePressed.Border.Width = 1;
            btnSair.StatePressed.Content.ShortText.Color1 = Color.White;
            btnSair.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnSair.StateTracking.Back.ColorAngle = 45F;
            btnSair.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateTracking.Border.ColorAngle = 45F;
            btnSair.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateTracking.Border.Rounding = 20F;
            btnSair.StateTracking.Border.Width = 1;
            btnSair.StateTracking.Content.ShortText.Color1 = Color.White;
            btnSair.TabIndex = 1045;
            btnSair.Values.Text = "Sair";
            btnSair.Click += btnSair_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(tlpTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1026, 47);
            pnlHeader.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            pnlHeader.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            pnlHeader.TabIndex = 1091;
            // 
            // tlpTitulo
            // 
            tlpTitulo.BackgroundImage = (Image)resources.GetObject("tlpTitulo.BackgroundImage");
            tlpTitulo.BackgroundImageLayout = ImageLayout.None;
            tlpTitulo.ColumnCount = 1;
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTitulo.Controls.Add(lblSubTitulo, 0, 1);
            tlpTitulo.Controls.Add(lblTitulo, 0, 0);
            tlpTitulo.Dock = DockStyle.Fill;
            tlpTitulo.Location = new Point(0, 0);
            tlpTitulo.Name = "tlpTitulo";
            tlpTitulo.RowCount = 2;
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 48.57143F));
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 51.42857F));
            tlpTitulo.Size = new Size(1026, 47);
            tlpTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            tlpTitulo.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            tlpTitulo.TabIndex = 0;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.Dock = DockStyle.Fill;
            lblSubTitulo.Location = new Point(3, 25);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(1020, 19);
            lblSubTitulo.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Color2 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblSubTitulo.TabIndex = 0;
            lblSubTitulo.Values.Text = "Inclusão e manutenção de clientes";
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Location = new Point(3, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1020, 16);
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Color2 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 1091;
            lblTitulo.Values.Text = "Cadastro de Clientes";
            // 
            // pnlDadosCadastrais
            // 
            pnlDadosCadastrais.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlDadosCadastrais.Controls.Add(cmbTipoPessoa);
            pnlDadosCadastrais.Controls.Add(txtOrgaoExpedidorRG);
            pnlDadosCadastrais.Controls.Add(lblCpf);
            pnlDadosCadastrais.Controls.Add(lblRotuloDadosCadastrais);
            pnlDadosCadastrais.Controls.Add(txtCpf);
            pnlDadosCadastrais.Controls.Add(lblEVendedor);
            pnlDadosCadastrais.Controls.Add(lblRG);
            pnlDadosCadastrais.Controls.Add(chkIsVendedor);
            pnlDadosCadastrais.Controls.Add(txtRg);
            pnlDadosCadastrais.Controls.Add(txtClienteID);
            pnlDadosCadastrais.Controls.Add(lblOrgaoExpedidorRG);
            pnlDadosCadastrais.Controls.Add(lblRotuloCodigo);
            pnlDadosCadastrais.Controls.Add(lblRotuloCnpj);
            pnlDadosCadastrais.Controls.Add(txtIE);
            pnlDadosCadastrais.Controls.Add(lblRotuloTipoPessoa);
            pnlDadosCadastrais.Controls.Add(txtCnpj);
            pnlDadosCadastrais.Controls.Add(cmbStatus);
            pnlDadosCadastrais.Controls.Add(lblRotuloIE);
            pnlDadosCadastrais.Controls.Add(lblRotuloStatus);
            pnlDadosCadastrais.Controls.Add(txtNomeCliente);
            pnlDadosCadastrais.Controls.Add(lblRotuloNome);
            pnlDadosCadastrais.Location = new Point(3, 56);
            pnlDadosCadastrais.Name = "pnlDadosCadastrais";
            pnlDadosCadastrais.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            pnlDadosCadastrais.Size = new Size(1023, 128);
            pnlDadosCadastrais.TabIndex = 1094;
            // 
            // cmbTipoPessoa
            // 
            cmbTipoPessoa.CornerRoundingRadius = 6F;
            cmbTipoPessoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPessoa.DropDownWidth = 115;
            cmbTipoPessoa.IntegralHeight = false;
            cmbTipoPessoa.Items.AddRange(new object[] { "Física", "Jurídica", "Operador", "Administrador", "Consumidor Final" });
            cmbTipoPessoa.Location = new Point(10, 38);
            cmbTipoPessoa.Name = "cmbTipoPessoa";
            cmbTipoPessoa.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbTipoPessoa.Size = new Size(151, 25);
            cmbTipoPessoa.StateActive.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoPessoa.StateActive.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoPessoa.StateActive.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbTipoPessoa.StateActive.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoPessoa.StateActive.ComboBox.Content.Color1 = Color.White;
            cmbTipoPessoa.StateActive.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbTipoPessoa.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoPessoa.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoPessoa.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbTipoPessoa.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoPessoa.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbTipoPessoa.StateCommon.ComboBox.Content.Color1 = Color.White;
            cmbTipoPessoa.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbTipoPessoa.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbTipoPessoa.StateNormal.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoPessoa.StateNormal.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoPessoa.StateNormal.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbTipoPessoa.StateNormal.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoPessoa.StateNormal.ComboBox.Content.Color1 = Color.White;
            cmbTipoPessoa.StateNormal.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbTipoPessoa.StateTracking.Item.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoPessoa.StateTracking.Item.Back.Color2 = Color.FromArgb(30, 136, 229);
            cmbTipoPessoa.StateTracking.Item.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoPessoa.StateTracking.Item.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbTipoPessoa.StateTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoPessoa.StateTracking.Item.Content.ShortText.Color1 = Color.White;
            cmbTipoPessoa.StateTracking.Item.Content.ShortText.Color2 = Color.White;
            cmbTipoPessoa.StateTracking.Item.Content.ShortText.Font = new Font("Segoe UI", 9F);
            cmbTipoPessoa.TabIndex = 1067;
            cmbTipoPessoa.TabStop = false;
            cmbTipoPessoa.SelectedIndexChanged += cmbTipoPessoa_SelectedIndexChanged;
            // 
            // lblRotuloDadosCadastrais
            // 
            lblRotuloDadosCadastrais.Dock = DockStyle.Top;
            lblRotuloDadosCadastrais.Location = new Point(0, 0);
            lblRotuloDadosCadastrais.Name = "lblRotuloDadosCadastrais";
            lblRotuloDadosCadastrais.Size = new Size(1023, 20);
            lblRotuloDadosCadastrais.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRotuloDadosCadastrais.TabIndex = 1038;
            lblRotuloDadosCadastrais.Values.Text = "Dados cadastrais";
            // 
            // lblEVendedor
            // 
            lblEVendedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEVendedor.AutoSize = true;
            lblEVendedor.BackColor = Color.Transparent;
            lblEVendedor.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblEVendedor.ForeColor = Color.FromArgb(0, 76, 172);
            lblEVendedor.Location = new Point(924, 19);
            lblEVendedor.Name = "lblEVendedor";
            lblEVendedor.Size = new Size(86, 16);
            lblEVendedor.TabIndex = 1037;
            lblEVendedor.Text = "É Vendedor?";
            // 
            // pnlDadosAdicionais
            // 
            pnlDadosAdicionais.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlDadosAdicionais.Controls.Add(dtpDataNascimento);
            pnlDadosAdicionais.Controls.Add(lblRotuloDadosAdicionais);
            pnlDadosAdicionais.Controls.Add(txtEmail);
            pnlDadosAdicionais.Controls.Add(lblRotuloEmail);
            pnlDadosAdicionais.Controls.Add(lblRotuloDtNascDtCriacao);
            pnlDadosAdicionais.Controls.Add(lblRotuloTelefone);
            pnlDadosAdicionais.Controls.Add(txtTelefone);
            pnlDadosAdicionais.Controls.Add(txtLimiteCredito);
            pnlDadosAdicionais.Controls.Add(label7);
            pnlDadosAdicionais.Location = new Point(3, 188);
            pnlDadosAdicionais.Name = "pnlDadosAdicionais";
            pnlDadosAdicionais.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            pnlDadosAdicionais.Size = new Size(1023, 123);
            pnlDadosAdicionais.TabIndex = 1096;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.CornerRoundingRadius = 3F;
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(11, 43);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(132, 29);
            dtpDataNascimento.StateActive.Back.Color1 = Color.FromArgb(6, 174, 244);
            dtpDataNascimento.StateActive.Border.Color1 = Color.FromArgb(6, 174, 244);
            dtpDataNascimento.StateActive.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtpDataNascimento.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataNascimento.StateActive.Border.Rounding = 3F;
            dtpDataNascimento.StateActive.Content.Color1 = Color.White;
            dtpDataNascimento.StateActive.Content.Font = new Font("Poppins", 9F);
            dtpDataNascimento.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataNascimento.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataNascimento.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtpDataNascimento.StateCommon.Border.ColorAngle = 45F;
            dtpDataNascimento.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataNascimento.StateCommon.Border.Rounding = 3F;
            dtpDataNascimento.StateCommon.Border.Width = 1;
            dtpDataNascimento.StateCommon.Content.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDataNascimento.StateCommon.Content.Padding = new Padding(1);
            dtpDataNascimento.StateDisabled.Border.ColorAngle = 45F;
            dtpDataNascimento.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataNascimento.StateDisabled.Border.Rounding = 3F;
            dtpDataNascimento.StateDisabled.Border.Width = 1;
            dtpDataNascimento.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataNascimento.StateNormal.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataNascimento.StateNormal.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtpDataNascimento.StateNormal.Border.ColorAngle = 45F;
            dtpDataNascimento.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataNascimento.StateNormal.Border.Rounding = 3F;
            dtpDataNascimento.StateNormal.Border.Width = 1;
            dtpDataNascimento.StateNormal.Content.Color1 = Color.White;
            dtpDataNascimento.TabIndex = 4;
            // 
            // lblRotuloDadosAdicionais
            // 
            lblRotuloDadosAdicionais.Dock = DockStyle.Top;
            lblRotuloDadosAdicionais.Location = new Point(0, 0);
            lblRotuloDadosAdicionais.Name = "lblRotuloDadosAdicionais";
            lblRotuloDadosAdicionais.Size = new Size(1023, 20);
            lblRotuloDadosAdicionais.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRotuloDadosAdicionais.TabIndex = 1039;
            lblRotuloDadosAdicionais.Values.Text = "Dados adicionais";
            // 
            // pnlEndereco
            // 
            pnlEndereco.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlEndereco.Controls.Add(btnLocalizarCidade);
            pnlEndereco.Controls.Add(btnPesquisarCep);
            pnlEndereco.Controls.Add(lblEndereco);
            pnlEndereco.Controls.Add(txtNomeCidade);
            pnlEndereco.Controls.Add(lblCep);
            pnlEndereco.Controls.Add(lblUf);
            pnlEndereco.Controls.Add(lblBairro);
            pnlEndereco.Controls.Add(lblNumero);
            pnlEndereco.Controls.Add(lblRotEndereco);
            pnlEndereco.Controls.Add(txtBairro);
            pnlEndereco.Controls.Add(txtNumero);
            pnlEndereco.Controls.Add(txtCep);
            pnlEndereco.Controls.Add(lblRotCidade);
            pnlEndereco.Controls.Add(txtLogradouro);
            pnlEndereco.Controls.Add(txtUF);
            pnlEndereco.Location = new Point(3, 328);
            pnlEndereco.Name = "pnlEndereco";
            pnlEndereco.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            pnlEndereco.Size = new Size(1023, 180);
            pnlEndereco.TabIndex = 1097;
            // 
            // btnLocalizarCidade
            // 
            btnLocalizarCidade.BackColor = Color.Transparent;
            btnLocalizarCidade.FlatAppearance.BorderSize = 0;
            btnLocalizarCidade.FlatStyle = FlatStyle.Flat;
            btnLocalizarCidade.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnLocalizarCidade.IconColor = Color.FromArgb(30, 136, 229);
            btnLocalizarCidade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLocalizarCidade.IconSize = 30;
            btnLocalizarCidade.Location = new Point(846, 144);
            btnLocalizarCidade.Name = "btnLocalizarCidade";
            btnLocalizarCidade.Size = new Size(25, 25);
            btnLocalizarCidade.TabIndex = 1040;
            btnLocalizarCidade.UseVisualStyleBackColor = false;
            btnLocalizarCidade.Click += btnLocalizarCidade_Click;
            // 
            // btnPesquisarCep
            // 
            btnPesquisarCep.BackColor = Color.Transparent;
            btnPesquisarCep.FlatAppearance.BorderSize = 0;
            btnPesquisarCep.FlatStyle = FlatStyle.Flat;
            btnPesquisarCep.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnPesquisarCep.IconColor = Color.FromArgb(30, 136, 229);
            btnPesquisarCep.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPesquisarCep.IconSize = 30;
            btnPesquisarCep.Location = new Point(225, 46);
            btnPesquisarCep.Name = "btnPesquisarCep";
            btnPesquisarCep.Size = new Size(25, 25);
            btnPesquisarCep.TabIndex = 9;
            btnPesquisarCep.UseVisualStyleBackColor = false;
            btnPesquisarCep.Click += btnPesquisarCep_Click;
            // 
            // lblEndereco
            // 
            lblEndereco.Dock = DockStyle.Top;
            lblEndereco.Location = new Point(0, 0);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(1023, 20);
            lblEndereco.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereco.TabIndex = 1039;
            lblEndereco.Values.Text = "Endereço";
            // 
            // pnlObservacao
            // 
            pnlObservacao.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlObservacao.Controls.Add(lblObservacao);
            pnlObservacao.Controls.Add(txtObservacoes);
            pnlObservacao.Location = new Point(3, 513);
            pnlObservacao.Name = "pnlObservacao";
            pnlObservacao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            pnlObservacao.Size = new Size(1023, 78);
            pnlObservacao.TabIndex = 1098;
            // 
            // lblObservacao
            // 
            lblObservacao.Dock = DockStyle.Top;
            lblObservacao.Location = new Point(0, 0);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(1023, 20);
            lblObservacao.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObservacao.TabIndex = 1040;
            lblObservacao.Values.Text = "Observação";
            // 
            // FrmCadCliente
            // 
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1026, 661);
            Controls.Add(pnlObservacao);
            Controls.Add(pnlEndereco);
            Controls.Add(pnlDadosAdicionais);
            Controls.Add(pnlDadosCadastrais);
            Controls.Add(pnlHeader);
            Controls.Add(btnSair);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(kryptonStatusStrip1);
            KeyPreview = true;
            MinimizeBox = false;
            Name = "FrmCadCliente";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterParent;
            StateCommon.Back.Color1 = Color.White;
            StateCommon.Back.Color2 = Color.White;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "Cadastro de Clientes";
            Load += FrmCadCliente_Load;
            Shown += FrmCadCliente_Shown;
            KeyDown += FrmCadCliente_KeyDown;
            kryptonStatusStrip1.ResumeLayout(false);
            kryptonStatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).EndInit();
            pnlHeader.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlDadosCadastrais).EndInit();
            pnlDadosCadastrais.ResumeLayout(false);
            pnlDadosCadastrais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbTipoPessoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlDadosAdicionais).EndInit();
            pnlDadosAdicionais.ResumeLayout(false);
            pnlDadosAdicionais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlEndereco).EndInit();
            pnlEndereco.ResumeLayout(false);
            pnlEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlObservacao).EndInit();
            pnlObservacao.ResumeLayout(false);
            pnlObservacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        public Krypton.Toolkit.KryptonTextBox txtLogradouro;
        public Krypton.Toolkit.KryptonTextBox txtTelefone;
        public Krypton.Toolkit.KryptonTextBox txtNomeCliente;
        public Krypton.Toolkit.KryptonTextBox txtClienteID;
        public Krypton.Toolkit.KryptonTextBox txtNomeCidade;
        public Krypton.Toolkit.KryptonTextBox txtEmail;
        public Krypton.Toolkit.KryptonTextBox txtBairro;
        public Krypton.Toolkit.KryptonTextBox txtNumero;
        private System.Windows.Forms.Label lblRotuloCodigo;
        private System.Windows.Forms.Label lblRotuloNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblRotuloTelefone;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblRotEndereco;
        private System.Windows.Forms.Label lblRotuloEmail;
        public Krypton.Toolkit.KryptonTextBox txtUF;
        private System.Windows.Forms.Label lblUf;
        public Krypton.Toolkit.KryptonButton btnSair;
        private Label lblCep;
        public Krypton.Toolkit.KryptonTextBox txtCep;
        private Label lblRotuloDtNascDtCriacao;
        public Krypton.Toolkit.KryptonTextBox txtDataNascimento;
        private Label lblRotuloTipoPessoa;
        public Krypton.Toolkit.KryptonTextBox txtObservacoes;
        private Label label7;
        public Krypton.Toolkit.KryptonTextBox txtLimiteCredito;       
       
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        public ToolStripStatusLabel toolStripStatusLabelUsuarioCriacao;
        private ToolStripStatusLabel toolStripStatusLabel2;
        public ToolStripStatusLabel ToolStripLabelDataCriacao;
        private ToolStripStatusLabel toolStripStatusLabel4;
        public ToolStripStatusLabel ToolStripLabelDataUtimaCompra;
        public Krypton.Toolkit.KryptonTextBox txtCpf;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabelUsuarioAtualizacao;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabelDataAtualizacao;
        public Krypton.Toolkit.KryptonTextBox txtRg;
        private Label lblRG;
        public Krypton.Toolkit.KryptonTextBox txtOrgaoExpedidorRG;
        private Label lblOrgaoExpedidorRG;
        private Label lblRotCidade;
        public Krypton.Toolkit.KryptonComboBox cmbStatus;
        private Label lblRotuloStatus;
        private ToolTip toolTip;
        private System.Windows.Forms.Timer Timer1;
        private ToolStripStatusLabel lblStatus;
        public Krypton.Toolkit.KryptonTextBox txtCnpj;
        private Label lblRotuloCnpj;
        public Krypton.Toolkit.KryptonTextBox txtIE;
        private Label lblRotuloIE;
        private CheckBox chkIsVendedor;
        private Krypton.Toolkit.KryptonButton kryptonButton13;
        public Krypton.Toolkit.KryptonButton btnSalvar;
        public Krypton.Toolkit.KryptonButton btnNovo;
        public ToolStripStatusLabel toolStripStatusLabel6;
        public ToolStripStatusLabel toolStripStatusLabel5;
        private Krypton.Toolkit.KryptonPanel pnlHeader;
        private Krypton.Toolkit.KryptonTableLayoutPanel tlpTitulo;
        private Krypton.Toolkit.KryptonLabel lblSubTitulo;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private Krypton.Toolkit.KryptonPanel pnlDadosCadastrais;
        private Label lblEVendedor;
        private Krypton.Toolkit.KryptonPanel pnlDadosAdicionais;
        private Krypton.Toolkit.KryptonPanel pnlEndereco;
        private Krypton.Toolkit.KryptonPanel pnlObservacao;
        private Krypton.Toolkit.KryptonLabel lblRotuloDadosCadastrais;
        private Krypton.Toolkit.KryptonLabel lblRotuloDadosAdicionais;
        private Krypton.Toolkit.KryptonLabel lblEndereco;
        private Krypton.Toolkit.KryptonLabel lblObservacao;
        public Krypton.Toolkit.KryptonDateTimePicker dtpDataNascimento;
        public Krypton.Toolkit.KryptonComboBox cmbTipoPessoa;
        private FontAwesome.Sharp.IconButton btnPesquisarCep;
        private FontAwesome.Sharp.IconButton btnLocalizarCidade;
    }
}
