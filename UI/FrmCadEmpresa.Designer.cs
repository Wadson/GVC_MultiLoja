namespace GVC.View
{
    partial class FrmCadEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadEmpresa));
            txtTelefone = new Krypton.Toolkit.KryptonTextBox();
            txtRazaoSocial = new Krypton.Toolkit.KryptonTextBox();
            txtEmpresaID = new Krypton.Toolkit.KryptonTextBox();
            txtEmail = new Krypton.Toolkit.KryptonTextBox();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            label18 = new Label();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            txtInscricaoMunicipal = new Krypton.Toolkit.KryptonTextBox();
            lblOrgaoExpedidorRG = new Label();
            toolTip = new ToolTip(components);
            Timer1 = new System.Windows.Forms.Timer(components);
            txtCnpj = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloCnpj = new Label();
            txtInscricaoEstadual = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloIE = new Label();
            txtNomeFantasia = new Krypton.Toolkit.KryptonTextBox();
            label1 = new Label();
            txtCnae = new Krypton.Toolkit.KryptonTextBox();
            label2 = new Label();
            label3 = new Label();
            txtSite = new Krypton.Toolkit.KryptonTextBox();
            txtResponsavel = new Krypton.Toolkit.KryptonTextBox();
            label4 = new Label();
            txtCertificadoDigital = new Krypton.Toolkit.KryptonTextBox();
            label6 = new Label();
            btnBuscarEnderecoPorCep = new Krypton.Toolkit.KryptonButton();
            label5 = new Label();
            txtUF = new Krypton.Toolkit.KryptonTextBox();
            txtLogradouro = new Krypton.Toolkit.KryptonTextBox();
            txtCep = new Krypton.Toolkit.KryptonTextBox();
            txtNumero = new Krypton.Toolkit.KryptonTextBox();
            txtBairro = new Krypton.Toolkit.KryptonTextBox();
            txtNomeCidade = new Krypton.Toolkit.KryptonTextBox();
            label17 = new Label();
            label15 = new Label();
            label14 = new Label();
            label20 = new Label();
            label9 = new Label();
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            lblUsuarioCriacao = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            lblDataCriacao = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            lblDataUtimaCompra = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblUsuarioAtualizacao = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            lblDataAtualizacao = new ToolStripStatusLabel();
            lblStatus = new ToolStripStatusLabel();
            toolStripStatusLabel5 = new ToolStripStatusLabel();
            btnLocalizarCertificado = new Krypton.Toolkit.KryptonButton();
            btnSair = new Krypton.Toolkit.KryptonButton();
            btnSalvar = new Krypton.Toolkit.KryptonButton();
            btnNovo = new Krypton.Toolkit.KryptonButton();
            pnlHeader = new Krypton.Toolkit.KryptonPanel();
            tlpTitulo = new Krypton.Toolkit.KryptonTableLayoutPanel();
            lblSubTitulo = new Krypton.Toolkit.KryptonLabel();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            picFundoPadrao = new PictureBox();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            txtEnderecoImagem = new Krypton.Toolkit.KryptonTextBox();
            btnBuscarImagem = new FontAwesome.Sharp.IconButton();
            kryptonStatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).BeginInit();
            pnlHeader.SuspendLayout();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFundoPadrao).BeginInit();
            SuspendLayout();
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(11, 338);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(132, 27);
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
            txtTelefone.TabIndex = 9;
            txtTelefone.Leave += txtTelefone_Leave;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRazaoSocial.CharacterCasing = CharacterCasing.Upper;
            txtRazaoSocial.Location = new Point(92, 94);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(423, 27);
            txtRazaoSocial.StateCommon.Back.Color1 = Color.White;
            txtRazaoSocial.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtRazaoSocial.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtRazaoSocial.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtRazaoSocial.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtRazaoSocial.StateCommon.Border.Rounding = 8F;
            txtRazaoSocial.StateCommon.Border.Width = 1;
            txtRazaoSocial.StateCommon.Content.Color1 = Color.Gray;
            txtRazaoSocial.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtRazaoSocial.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtRazaoSocial.TabIndex = 0;
            // 
            // txtEmpresaID
            // 
            txtEmpresaID.Location = new Point(11, 94);
            txtEmpresaID.Name = "txtEmpresaID";
            txtEmpresaID.Size = new Size(76, 27);
            txtEmpresaID.StateCommon.Back.Color1 = Color.White;
            txtEmpresaID.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtEmpresaID.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtEmpresaID.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtEmpresaID.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtEmpresaID.StateCommon.Border.Rounding = 8F;
            txtEmpresaID.StateCommon.Border.Width = 1;
            txtEmpresaID.StateCommon.Content.Color1 = Color.Gray;
            txtEmpresaID.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtEmpresaID.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtEmpresaID.TabIndex = 192;
            txtEmpresaID.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.CharacterCasing = CharacterCasing.Lower;
            txtEmail.Location = new Point(147, 338);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(466, 27);
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
            txtEmail.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.ForeColor = Color.FromArgb(0, 76, 172);
            label10.Location = new Point(11, 74);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 184;
            label10.Text = "Código:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 9.25F);
            label11.ForeColor = Color.FromArgb(0, 76, 172);
            label11.Location = new Point(92, 73);
            label11.Name = "label11";
            label11.Size = new Size(88, 16);
            label11.TabIndex = 183;
            label11.Text = "Razão Social";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Microsoft Sans Serif", 9.25F);
            label13.ForeColor = Color.FromArgb(0, 76, 172);
            label13.Location = new Point(11, 318);
            label13.Name = "label13";
            label13.Size = new Size(61, 16);
            label13.TabIndex = 185;
            label13.Text = "Telefone";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Microsoft Sans Serif", 9.25F);
            label18.ForeColor = Color.FromArgb(0, 76, 172);
            label18.Location = new Point(147, 319);
            label18.Name = "label18";
            label18.Size = new Size(45, 16);
            label18.TabIndex = 183;
            label18.Text = "E-Mail";
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
            // txtInscricaoMunicipal
            // 
            txtInscricaoMunicipal.Location = new Point(320, 145);
            txtInscricaoMunicipal.Name = "txtInscricaoMunicipal";
            txtInscricaoMunicipal.Size = new Size(150, 27);
            txtInscricaoMunicipal.StateCommon.Back.Color1 = Color.White;
            txtInscricaoMunicipal.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtInscricaoMunicipal.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtInscricaoMunicipal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtInscricaoMunicipal.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtInscricaoMunicipal.StateCommon.Border.Rounding = 8F;
            txtInscricaoMunicipal.StateCommon.Border.Width = 1;
            txtInscricaoMunicipal.StateCommon.Content.Color1 = Color.Gray;
            txtInscricaoMunicipal.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtInscricaoMunicipal.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtInscricaoMunicipal.TabIndex = 4;
            // 
            // lblOrgaoExpedidorRG
            // 
            lblOrgaoExpedidorRG.AutoSize = true;
            lblOrgaoExpedidorRG.BackColor = Color.Transparent;
            lblOrgaoExpedidorRG.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblOrgaoExpedidorRG.ForeColor = Color.FromArgb(0, 76, 172);
            lblOrgaoExpedidorRG.Location = new Point(319, 126);
            lblOrgaoExpedidorRG.Name = "lblOrgaoExpedidorRG";
            lblOrgaoExpedidorRG.Size = new Size(121, 16);
            lblOrgaoExpedidorRG.TabIndex = 1033;
            lblOrgaoExpedidorRG.Text = "Inscrição Municipal";
            // 
            // Timer1
            // 
            Timer1.Interval = 500;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(11, 145);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(150, 27);
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
            txtCnpj.TabIndex = 2;
            txtCnpj.Leave += txtCnpj_Leave;
            // 
            // lblRotuloCnpj
            // 
            lblRotuloCnpj.AutoSize = true;
            lblRotuloCnpj.BackColor = Color.Transparent;
            lblRotuloCnpj.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloCnpj.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloCnpj.Location = new Point(14, 126);
            lblRotuloCnpj.Name = "lblRotuloCnpj";
            lblRotuloCnpj.Size = new Size(34, 16);
            lblRotuloCnpj.TabIndex = 1039;
            lblRotuloCnpj.Text = "Cnpj";
            // 
            // txtInscricaoEstadual
            // 
            txtInscricaoEstadual.Location = new Point(164, 145);
            txtInscricaoEstadual.Name = "txtInscricaoEstadual";
            txtInscricaoEstadual.Size = new Size(150, 27);
            txtInscricaoEstadual.StateCommon.Back.Color1 = Color.White;
            txtInscricaoEstadual.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtInscricaoEstadual.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtInscricaoEstadual.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtInscricaoEstadual.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtInscricaoEstadual.StateCommon.Border.Rounding = 8F;
            txtInscricaoEstadual.StateCommon.Border.Width = 1;
            txtInscricaoEstadual.StateCommon.Content.Color1 = Color.Gray;
            txtInscricaoEstadual.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtInscricaoEstadual.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtInscricaoEstadual.TabIndex = 3;
            // 
            // lblRotuloIE
            // 
            lblRotuloIE.AutoSize = true;
            lblRotuloIE.BackColor = Color.Transparent;
            lblRotuloIE.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloIE.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloIE.Location = new Point(173, 126);
            lblRotuloIE.Name = "lblRotuloIE";
            lblRotuloIE.Size = new Size(140, 16);
            lblRotuloIE.TabIndex = 1041;
            lblRotuloIE.Text = "IE (Inscrição Estadual)";
            // 
            // txtNomeFantasia
            // 
            txtNomeFantasia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNomeFantasia.CharacterCasing = CharacterCasing.Upper;
            txtNomeFantasia.Location = new Point(521, 94);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.Size = new Size(313, 27);
            txtNomeFantasia.StateCommon.Back.Color1 = Color.White;
            txtNomeFantasia.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNomeFantasia.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNomeFantasia.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNomeFantasia.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNomeFantasia.StateCommon.Border.Rounding = 8F;
            txtNomeFantasia.StateCommon.Border.Width = 1;
            txtNomeFantasia.StateCommon.Content.Color1 = Color.Gray;
            txtNomeFantasia.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtNomeFantasia.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNomeFantasia.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 9.25F);
            label1.ForeColor = Color.FromArgb(0, 76, 172);
            label1.Location = new Point(550, 73);
            label1.Name = "label1";
            label1.Size = new Size(99, 16);
            label1.TabIndex = 1044;
            label1.Text = "Nome Fantasia";
            // 
            // txtCnae
            // 
            txtCnae.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCnae.Location = new Point(474, 145);
            txtCnae.Name = "txtCnae";
            txtCnae.Size = new Size(360, 27);
            txtCnae.StateCommon.Back.Color1 = Color.White;
            txtCnae.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtCnae.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtCnae.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtCnae.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtCnae.StateCommon.Border.Rounding = 8F;
            txtCnae.StateCommon.Border.Width = 1;
            txtCnae.StateCommon.Content.Color1 = Color.Gray;
            txtCnae.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtCnae.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtCnae.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 9.25F);
            label2.ForeColor = Color.FromArgb(0, 76, 172);
            label2.Location = new Point(480, 126);
            label2.Name = "label2";
            label2.Size = new Size(39, 16);
            label2.TabIndex = 1046;
            label2.Text = "Cnae";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 9.25F);
            label3.ForeColor = Color.FromArgb(0, 76, 172);
            label3.Location = new Point(623, 319);
            label3.Name = "label3";
            label3.Size = new Size(30, 16);
            label3.TabIndex = 1048;
            label3.Text = "Site";
            // 
            // txtSite
            // 
            txtSite.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSite.CharacterCasing = CharacterCasing.Lower;
            txtSite.Location = new Point(619, 338);
            txtSite.Name = "txtSite";
            txtSite.Size = new Size(217, 27);
            txtSite.StateCommon.Back.Color1 = Color.White;
            txtSite.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtSite.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtSite.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSite.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSite.StateCommon.Border.Rounding = 8F;
            txtSite.StateCommon.Border.Width = 1;
            txtSite.StateCommon.Content.Color1 = Color.Gray;
            txtSite.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtSite.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSite.TabIndex = 11;
            // 
            // txtResponsavel
            // 
            txtResponsavel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtResponsavel.CharacterCasing = CharacterCasing.Upper;
            txtResponsavel.Location = new Point(14, 396);
            txtResponsavel.Name = "txtResponsavel";
            txtResponsavel.Size = new Size(491, 27);
            txtResponsavel.StateCommon.Back.Color1 = Color.White;
            txtResponsavel.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtResponsavel.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtResponsavel.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtResponsavel.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtResponsavel.StateCommon.Border.Rounding = 8F;
            txtResponsavel.StateCommon.Border.Width = 1;
            txtResponsavel.StateCommon.Content.Color1 = Color.Gray;
            txtResponsavel.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtResponsavel.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtResponsavel.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 9.25F);
            label4.ForeColor = Color.FromArgb(0, 76, 172);
            label4.Location = new Point(14, 378);
            label4.Name = "label4";
            label4.Size = new Size(147, 16);
            label4.TabIndex = 1050;
            label4.Text = "Nome do Responsável";
            // 
            // txtCertificadoDigital
            // 
            txtCertificadoDigital.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCertificadoDigital.CharacterCasing = CharacterCasing.Upper;
            txtCertificadoDigital.Location = new Point(14, 473);
            txtCertificadoDigital.Name = "txtCertificadoDigital";
            txtCertificadoDigital.Size = new Size(341, 27);
            txtCertificadoDigital.StateCommon.Back.Color1 = Color.White;
            txtCertificadoDigital.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtCertificadoDigital.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtCertificadoDigital.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtCertificadoDigital.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtCertificadoDigital.StateCommon.Border.Rounding = 8F;
            txtCertificadoDigital.StateCommon.Border.Width = 1;
            txtCertificadoDigital.StateCommon.Content.Color1 = Color.Gray;
            txtCertificadoDigital.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtCertificadoDigital.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtCertificadoDigital.TabIndex = 1051;
            txtCertificadoDigital.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 9.25F);
            label6.ForeColor = Color.FromArgb(0, 76, 172);
            label6.Location = new Point(14, 455);
            label6.Name = "label6";
            label6.Size = new Size(147, 16);
            label6.TabIndex = 1052;
            label6.Text = "Caminho do certificado ";
            // 
            // btnBuscarEnderecoPorCep
            // 
            btnBuscarEnderecoPorCep.CornerRoundingRadius = 10F;
            btnBuscarEnderecoPorCep.Location = new Point(147, 217);
            btnBuscarEnderecoPorCep.Name = "btnBuscarEnderecoPorCep";
            btnBuscarEnderecoPorCep.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnBuscarEnderecoPorCep.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnBuscarEnderecoPorCep.OverrideDefault.Back.ColorAngle = 45F;
            btnBuscarEnderecoPorCep.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnBuscarEnderecoPorCep.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBuscarEnderecoPorCep.OverrideDefault.Border.ColorAngle = 45F;
            btnBuscarEnderecoPorCep.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscarEnderecoPorCep.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBuscarEnderecoPorCep.OverrideDefault.Border.Rounding = 20F;
            btnBuscarEnderecoPorCep.OverrideDefault.Border.Width = 1;
            btnBuscarEnderecoPorCep.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnBuscarEnderecoPorCep.Size = new Size(30, 29);
            btnBuscarEnderecoPorCep.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnBuscarEnderecoPorCep.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnBuscarEnderecoPorCep.StateCommon.Back.ColorAngle = 45F;
            btnBuscarEnderecoPorCep.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            btnBuscarEnderecoPorCep.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnBuscarEnderecoPorCep.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBuscarEnderecoPorCep.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscarEnderecoPorCep.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBuscarEnderecoPorCep.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopLeft;
            btnBuscarEnderecoPorCep.StateCommon.Border.Rounding = 10F;
            btnBuscarEnderecoPorCep.StateCommon.Border.Width = 1;
            btnBuscarEnderecoPorCep.StateCommon.Content.ShortText.Color1 = Color.White;
            btnBuscarEnderecoPorCep.StateCommon.Content.ShortText.Color2 = Color.White;
            btnBuscarEnderecoPorCep.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarEnderecoPorCep.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnBuscarEnderecoPorCep.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnBuscarEnderecoPorCep.StatePressed.Back.ColorAngle = 135F;
            btnBuscarEnderecoPorCep.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnBuscarEnderecoPorCep.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnBuscarEnderecoPorCep.StatePressed.Border.ColorAngle = 135F;
            btnBuscarEnderecoPorCep.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscarEnderecoPorCep.StatePressed.Border.Rounding = 20F;
            btnBuscarEnderecoPorCep.StatePressed.Border.Width = 1;
            btnBuscarEnderecoPorCep.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnBuscarEnderecoPorCep.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnBuscarEnderecoPorCep.StateTracking.Back.ColorAngle = 45F;
            btnBuscarEnderecoPorCep.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnBuscarEnderecoPorCep.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBuscarEnderecoPorCep.StateTracking.Border.ColorAngle = 45F;
            btnBuscarEnderecoPorCep.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscarEnderecoPorCep.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBuscarEnderecoPorCep.StateTracking.Border.Rounding = 20F;
            btnBuscarEnderecoPorCep.StateTracking.Border.Width = 1;
            btnBuscarEnderecoPorCep.TabIndex = 7;
            btnBuscarEnderecoPorCep.Values.Image = Properties.Resources.Pesquisar;
            btnBuscarEnderecoPorCep.Values.Text = "";
            btnBuscarEnderecoPorCep.Click += btnBuscarEnderecoPorCep_Click_1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 9.25F);
            label5.ForeColor = Color.FromArgb(0, 76, 172);
            label5.Location = new Point(463, 247);
            label5.Name = "label5";
            label5.Size = new Size(51, 16);
            label5.TabIndex = 1070;
            label5.Text = "Cidade";
            // 
            // txtUF
            // 
            txtUF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtUF.CharacterCasing = CharacterCasing.Upper;
            txtUF.Location = new Point(734, 266);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(102, 27);
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
            txtUF.TabIndex = 1064;
            txtUF.TabStop = false;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLogradouro.CharacterCasing = CharacterCasing.Upper;
            txtLogradouro.Location = new Point(185, 218);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(543, 27);
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
            txtLogradouro.TabIndex = 1059;
            txtLogradouro.TabStop = false;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(11, 218);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(132, 27);
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
            txtCep.TabIndex = 6;
            txtCep.Leave += txtCep_Leave;
            // 
            // txtNumero
            // 
            txtNumero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNumero.Location = new Point(734, 219);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 27);
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
            txtNumero.TabIndex = 8;
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtBairro.Location = new Point(11, 266);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(446, 27);
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
            txtBairro.TabIndex = 1061;
            txtBairro.TabStop = false;
            // 
            // txtNomeCidade
            // 
            txtNomeCidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNomeCidade.CharacterCasing = CharacterCasing.Upper;
            txtNomeCidade.Location = new Point(463, 266);
            txtNomeCidade.Name = "txtNomeCidade";
            txtNomeCidade.Size = new Size(265, 27);
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
            txtNomeCidade.TabIndex = 1062;
            txtNomeCidade.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Microsoft Sans Serif", 9.25F);
            label17.ForeColor = Color.FromArgb(0, 76, 172);
            label17.Location = new Point(186, 197);
            label17.Name = "label17";
            label17.Size = new Size(77, 16);
            label17.TabIndex = 1065;
            label17.Text = "Logradouro";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Microsoft Sans Serif", 9.25F);
            label15.ForeColor = Color.FromArgb(0, 76, 172);
            label15.Location = new Point(735, 195);
            label15.Name = "label15";
            label15.Size = new Size(55, 16);
            label15.TabIndex = 1067;
            label15.Text = "Número";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft Sans Serif", 9.25F);
            label14.ForeColor = Color.FromArgb(0, 76, 172);
            label14.Location = new Point(11, 246);
            label14.Name = "label14";
            label14.Size = new Size(43, 16);
            label14.TabIndex = 1068;
            label14.Text = "Bairro";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Microsoft Sans Serif", 9.25F);
            label20.ForeColor = Color.FromArgb(0, 76, 172);
            label20.Location = new Point(735, 251);
            label20.Name = "label20";
            label20.Size = new Size(20, 16);
            label20.TabIndex = 1066;
            label20.Text = "Uf";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 9.25F);
            label9.ForeColor = Color.FromArgb(0, 76, 172);
            label9.Location = new Point(11, 197);
            label9.Name = "label9";
            label9.Size = new Size(32, 16);
            label9.TabIndex = 1069;
            label9.Text = "Cep";
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Items.AddRange(new ToolStripItem[] { lblUsuarioCriacao, toolStripStatusLabel2, lblDataCriacao, toolStripStatusLabel4, lblDataUtimaCompra, toolStripStatusLabel1, lblUsuarioAtualizacao, toolStripStatusLabel3, lblDataAtualizacao, lblStatus, toolStripStatusLabel5 });
            kryptonStatusStrip1.Location = new Point(0, 633);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.Professional;
            kryptonStatusStrip1.Size = new Size(838, 22);
            kryptonStatusStrip1.TabIndex = 1079;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // lblUsuarioCriacao
            // 
            lblUsuarioCriacao.ForeColor = Color.FromArgb(0, 76, 172);
            lblUsuarioCriacao.Name = "lblUsuarioCriacao";
            lblUsuarioCriacao.Size = new Size(99, 17);
            lblUsuarioCriacao.Text = "Usuario Criação...";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(16, 17);
            toolStripStatusLabel2.Text = " | ";
            // 
            // lblDataCriacao
            // 
            lblDataCriacao.ForeColor = Color.FromArgb(0, 76, 172);
            lblDataCriacao.Name = "lblDataCriacao";
            lblDataCriacao.Size = new Size(99, 17);
            lblDataCriacao.Text = "Data da Criação...";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(16, 17);
            toolStripStatusLabel4.Text = " | ";
            // 
            // lblDataUtimaCompra
            // 
            lblDataUtimaCompra.ForeColor = Color.FromArgb(0, 76, 172);
            lblDataUtimaCompra.Name = "lblDataUtimaCompra";
            lblDataUtimaCompra.Size = new Size(131, 17);
            lblDataUtimaCompra.Text = "Data da Ultima Compra";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(16, 17);
            toolStripStatusLabel1.Text = " | ";
            // 
            // lblUsuarioAtualizacao
            // 
            lblUsuarioAtualizacao.ForeColor = Color.FromArgb(0, 76, 172);
            lblUsuarioAtualizacao.Name = "lblUsuarioAtualizacao";
            lblUsuarioAtualizacao.Size = new Size(100, 17);
            lblUsuarioAtualizacao.Text = "Usuário Alteração";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(16, 17);
            toolStripStatusLabel3.Text = " | ";
            // 
            // lblDataAtualizacao
            // 
            lblDataAtualizacao.ForeColor = Color.FromArgb(0, 76, 172);
            lblDataAtualizacao.Name = "lblDataAtualizacao";
            lblDataAtualizacao.Size = new Size(95, 17);
            lblDataAtualizacao.Text = "Data Atualização";
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.FromArgb(0, 76, 172);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 17);
            lblStatus.Text = "Status";
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new Size(16, 17);
            toolStripStatusLabel5.Text = " | ";
            // 
            // btnLocalizarCertificado
            // 
            btnLocalizarCertificado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLocalizarCertificado.CornerRoundingRadius = 10F;
            btnLocalizarCertificado.Location = new Point(363, 473);
            btnLocalizarCertificado.Margin = new Padding(5, 3, 5, 3);
            btnLocalizarCertificado.Name = "btnLocalizarCertificado";
            btnLocalizarCertificado.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnLocalizarCertificado.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnLocalizarCertificado.OverrideDefault.Back.ColorAngle = 45F;
            btnLocalizarCertificado.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarCertificado.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarCertificado.OverrideDefault.Border.ColorAngle = 45F;
            btnLocalizarCertificado.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarCertificado.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarCertificado.OverrideDefault.Border.Rounding = 20F;
            btnLocalizarCertificado.OverrideDefault.Border.Width = 1;
            btnLocalizarCertificado.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnLocalizarCertificado.Size = new Size(142, 27);
            btnLocalizarCertificado.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnLocalizarCertificado.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnLocalizarCertificado.StateCommon.Back.ColorAngle = 45F;
            btnLocalizarCertificado.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarCertificado.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarCertificado.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarCertificado.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarCertificado.StateCommon.Border.Rounding = 10F;
            btnLocalizarCertificado.StateCommon.Border.Width = 1;
            btnLocalizarCertificado.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarCertificado.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLocalizarCertificado.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnLocalizarCertificado.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalizarCertificado.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalizarCertificado.StatePressed.Back.ColorAngle = 135F;
            btnLocalizarCertificado.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalizarCertificado.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalizarCertificado.StatePressed.Border.ColorAngle = 135F;
            btnLocalizarCertificado.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarCertificado.StatePressed.Border.Rounding = 20F;
            btnLocalizarCertificado.StatePressed.Border.Width = 1;
            btnLocalizarCertificado.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarCertificado.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnLocalizarCertificado.StateTracking.Back.ColorAngle = 45F;
            btnLocalizarCertificado.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarCertificado.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarCertificado.StateTracking.Border.ColorAngle = 45F;
            btnLocalizarCertificado.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarCertificado.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarCertificado.StateTracking.Border.Rounding = 20F;
            btnLocalizarCertificado.StateTracking.Border.Width = 1;
            btnLocalizarCertificado.StateTracking.Content.ShortText.Color1 = Color.White;
            btnLocalizarCertificado.TabIndex = 1080;
            btnLocalizarCertificado.TabStop = false;
            btnLocalizarCertificado.Values.Text = "Localizar certificado";
            btnLocalizarCertificado.Click += btnLocalizarCertificado_Click;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSair.CornerRoundingRadius = 20F;
            btnSair.Location = new Point(721, 594);
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
            btnSair.TabIndex = 1083;
            btnSair.TabStop = false;
            btnSair.Values.Text = "Sair";
            btnSair.Click += btnSair_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.CornerRoundingRadius = 20F;
            btnSalvar.Location = new Point(513, 594);
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
            btnNovo.Location = new Point(615, 594);
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
            btnNovo.TabIndex = 14;
            btnNovo.Values.Text = "Novo";
            btnNovo.Click += btnNovo_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(tlpTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(838, 47);
            pnlHeader.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            pnlHeader.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            pnlHeader.TabIndex = 1094;
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
            tlpTitulo.Size = new Size(838, 47);
            tlpTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            tlpTitulo.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            tlpTitulo.TabIndex = 0;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.Dock = DockStyle.Fill;
            lblSubTitulo.Location = new Point(3, 25);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(832, 19);
            lblSubTitulo.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Color2 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblSubTitulo.TabIndex = 0;
            lblSubTitulo.Values.Text = "Inclusão e manutenção de empresas";
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Location = new Point(3, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(832, 16);
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Color2 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 1091;
            lblTitulo.Values.Text = "Cadastro de Empresas";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(10, 52);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(86, 20);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 1038;
            kryptonLabel1.Values.Text = "Identificação";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(7, 175);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(64, 20);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 1038;
            kryptonLabel2.Values.Text = "Endereço";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(9, 295);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(57, 20);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 1038;
            kryptonLabel3.Values.Text = "Contato";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(13, 433);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(116, 20);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel5.TabIndex = 1038;
            kryptonLabel5.Values.Text = "Certificado Digital";
            // 
            // picFundoPadrao
            // 
            picFundoPadrao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picFundoPadrao.Location = new Point(513, 429);
            picFundoPadrao.Name = "picFundoPadrao";
            picFundoPadrao.Size = new Size(321, 147);
            picFundoPadrao.TabIndex = 1102;
            picFundoPadrao.TabStop = false;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonLabel4.Location = new Point(511, 376);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(128, 20);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel4.TabIndex = 1106;
            kryptonLabel4.TabStop = false;
            kryptonLabel4.Values.Text = "Imagem do Produto";
            // 
            // txtEnderecoImagem
            // 
            txtEnderecoImagem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEnderecoImagem.Location = new Point(513, 397);
            txtEnderecoImagem.Name = "txtEnderecoImagem";
            txtEnderecoImagem.Size = new Size(290, 24);
            txtEnderecoImagem.StateCommon.Back.Color1 = Color.White;
            txtEnderecoImagem.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtEnderecoImagem.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtEnderecoImagem.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtEnderecoImagem.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtEnderecoImagem.StateCommon.Border.Rounding = 8F;
            txtEnderecoImagem.StateCommon.Border.Width = 1;
            txtEnderecoImagem.StateCommon.Content.Color1 = Color.Gray;
            txtEnderecoImagem.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtEnderecoImagem.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtEnderecoImagem.TabIndex = 1104;
            txtEnderecoImagem.TabStop = false;
            // 
            // btnBuscarImagem
            // 
            btnBuscarImagem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscarImagem.BackColor = Color.Transparent;
            btnBuscarImagem.FlatAppearance.BorderSize = 0;
            btnBuscarImagem.FlatStyle = FlatStyle.Flat;
            btnBuscarImagem.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarImagem.IconColor = Color.FromArgb(30, 136, 229);
            btnBuscarImagem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarImagem.IconSize = 32;
            btnBuscarImagem.Location = new Point(809, 394);
            btnBuscarImagem.Name = "btnBuscarImagem";
            btnBuscarImagem.Size = new Size(25, 30);
            btnBuscarImagem.TabIndex = 1141;
            btnBuscarImagem.UseVisualStyleBackColor = false;
            btnBuscarImagem.Click += btnBuscarImagem_Click;
            // 
            // FrmCadEmpresa
            // 
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(838, 655);
            ControlBox = false;
            Controls.Add(btnBuscarImagem);
            Controls.Add(kryptonLabel4);
            Controls.Add(txtEnderecoImagem);
            Controls.Add(kryptonLabel1);
            Controls.Add(kryptonLabel2);
            Controls.Add(txtRazaoSocial);
            Controls.Add(kryptonLabel3);
            Controls.Add(txtEmpresaID);
            Controls.Add(txtUF);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label11);
            Controls.Add(txtLogradouro);
            Controls.Add(txtNomeFantasia);
            Controls.Add(txtResponsavel);
            Controls.Add(label1);
            Controls.Add(label20);
            Controls.Add(txtInscricaoMunicipal);
            Controls.Add(kryptonLabel5);
            Controls.Add(lblOrgaoExpedidorRG);
            Controls.Add(label9);
            Controls.Add(lblRotuloCnpj);
            Controls.Add(label4);
            Controls.Add(txtCnpj);
            Controls.Add(txtNomeCidade);
            Controls.Add(lblRotuloIE);
            Controls.Add(txtCertificadoDigital);
            Controls.Add(txtInscricaoEstadual);
            Controls.Add(label2);
            Controls.Add(label17);
            Controls.Add(txtCnae);
            Controls.Add(txtTelefone);
            Controls.Add(label5);
            Controls.Add(btnLocalizarCertificado);
            Controls.Add(txtCep);
            Controls.Add(label13);
            Controls.Add(btnBuscarEnderecoPorCep);
            Controls.Add(picFundoPadrao);
            Controls.Add(txtBairro);
            Controls.Add(label14);
            Controls.Add(txtEmail);
            Controls.Add(label15);
            Controls.Add(label18);
            Controls.Add(txtNumero);
            Controls.Add(txtSite);
            Controls.Add(label3);
            Controls.Add(pnlHeader);
            Controls.Add(btnSair);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(kryptonStatusStrip1);
            ForeColor = Color.FromArgb(0, 76, 172);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadEmpresa";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Back.Color1 = Color.White;
            StateCommon.Back.Color2 = Color.White;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "Cadastro da Empresa";
            WindowState = FormWindowState.Maximized;
            FormClosing += FrmCadEmpresa_FormClosing;
            Load += FrmCadEmpresa_Load;
            Shown += FrmCadEmpresa_Shown;
            KeyDown += FrmCadEmpresa_KeyDown;
            kryptonStatusStrip1.ResumeLayout(false);
            kryptonStatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).EndInit();
            pnlHeader.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFundoPadrao).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        public Krypton.Toolkit.KryptonTextBox txtInscricaoMunicipal;
        public Krypton.Toolkit.KryptonTextBox txtInscricaoEstadual; // ← ADICIONE ESTA LINHA
        public Krypton.Toolkit.KryptonTextBox txtTelefone;
        public Krypton.Toolkit.KryptonTextBox txtRazaoSocial;
        public Krypton.Toolkit.KryptonTextBox txtEmpresaID;
        public Krypton.Toolkit.KryptonTextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        public Krypton.Toolkit.KryptonTextBox txtDataNascimento;
        public Krypton.Toolkit.KryptonTextBox txtUsuarioCriacao;
        public Krypton.Toolkit.KryptonTextBox txtCpf;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public Krypton.Toolkit.KryptonTextBox txtRg;
        private Label lblRG;
        public Krypton.Toolkit.KryptonTextBox txtOrgaoExpedidorRG;
        private Label lblOrgaoExpedidorRG;
        private ToolTip toolTip;
        private System.Windows.Forms.Timer Timer1;
        public Krypton.Toolkit.KryptonTextBox txtCnpj;
        private Label lblRotuloCnpj;       
        private Label lblRotuloIE;
        public Krypton.Toolkit.KryptonTextBox txtNomeFantasia;
        private Label label1;
        public Krypton.Toolkit.KryptonTextBox txtCnae;
        private Label label2;
        private Label label3;
        public Krypton.Toolkit.KryptonTextBox txtSite;
        public Krypton.Toolkit.KryptonTextBox txtResponsavel;
        private Label label4;
        public Krypton.Toolkit.KryptonTextBox txtCertificadoDigital;
        private Label label6;
        public Krypton.Toolkit.KryptonButton btnBuscarEnderecoPorCep;
        private Label label5;
        public Krypton.Toolkit.KryptonTextBox txtUF;
        public Krypton.Toolkit.KryptonTextBox txtLogradouro;
        public Krypton.Toolkit.KryptonTextBox txtCep;
        public Krypton.Toolkit.KryptonTextBox txtNumero;
        public Krypton.Toolkit.KryptonTextBox txtBairro;
        public Krypton.Toolkit.KryptonTextBox txtNomeCidade;
        private Label label17;
        private Label label15;
        private Label label14;
        private Label label20;
        private Label label9;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        public ToolStripStatusLabel lblUsuarioCriacao;
        private ToolStripStatusLabel toolStripStatusLabel2;
        public ToolStripStatusLabel lblDataCriacao;
        private ToolStripStatusLabel toolStripStatusLabel4;
        public ToolStripStatusLabel lblDataUtimaCompra;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblUsuarioAtualizacao;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel lblDataAtualizacao;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel toolStripStatusLabel5;
        public Krypton.Toolkit.KryptonButton btnLocalizarCertificado;
        public Krypton.Toolkit.KryptonButton btnSair;
        public Krypton.Toolkit.KryptonButton btnSalvar;
        public Krypton.Toolkit.KryptonButton btnNovo;
        private Krypton.Toolkit.KryptonPanel pnlHeader;
        private Krypton.Toolkit.KryptonTableLayoutPanel tlpTitulo;
        private Krypton.Toolkit.KryptonLabel lblSubTitulo;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private PictureBox picFundoPadrao;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        public Krypton.Toolkit.KryptonTextBox txtEnderecoImagem;
        private FontAwesome.Sharp.IconButton btnBuscarImagem;
    }
}
