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
            txtTelefone = new Krypton.Toolkit.KryptonTextBox();
            txtRazaoSocial = new Krypton.Toolkit.KryptonTextBox();
            txtEmpresaID = new Krypton.Toolkit.KryptonTextBox();
            txtEmail = new Krypton.Toolkit.KryptonTextBox();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            label18 = new Label();
            lblRotuloDtNascDtCriacao = new Label();
            label7 = new Label();
            txtUsuarioCriacao = new Krypton.Toolkit.KryptonTextBox();
            dtpDataCriacao = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            this.txtInscricaoMunicipal = new Krypton.Toolkit.KryptonTextBox();
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
            txtDataAtualizacao = new Krypton.Toolkit.KryptonDateTimePicker();
            label8 = new Label();
            label12 = new Label();
            txtUsuarioAtualizacao = new Krypton.Toolkit.KryptonTextBox();
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
            btnLocalizar = new Krypton.Toolkit.KryptonButton();
            label20 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(803, 83);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(195, 27);
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
            txtTelefone.TabIndex = 7;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.CharacterCasing = CharacterCasing.Upper;
            txtRazaoSocial.Location = new Point(95, 30);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(448, 27);
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
            txtEmpresaID.Location = new Point(3, 30);
            txtEmpresaID.Name = "txtEmpresaID";
            txtEmpresaID.ReadOnly = true;
            txtEmpresaID.Size = new Size(90, 27);
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
            txtEmail.CharacterCasing = CharacterCasing.Lower;
            txtEmail.Location = new Point(0, 283);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(493, 27);
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
            txtEmail.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.ForeColor = Color.FromArgb(0, 76, 172);
            label10.Location = new Point(3, 10);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 184;
            label10.Text = "Código:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.25F);
            label11.ForeColor = Color.FromArgb(0, 76, 172);
            label11.Location = new Point(95, 9);
            label11.Name = "label11";
            label11.Size = new Size(88, 16);
            label11.TabIndex = 183;
            label11.Text = "Razão Social";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9.25F);
            label13.ForeColor = Color.FromArgb(0, 76, 172);
            label13.Location = new Point(700, 65);
            label13.Name = "label13";
            label13.Size = new Size(61, 16);
            label13.TabIndex = 185;
            label13.Text = "Telefone";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 9.25F);
            label18.ForeColor = Color.FromArgb(0, 76, 172);
            label18.Location = new Point(-1, 265);
            label18.Name = "label18";
            label18.Size = new Size(45, 16);
            label18.TabIndex = 183;
            label18.Text = "E-Mail";
            // 
            // lblRotuloDtNascDtCriacao
            // 
            lblRotuloDtNascDtCriacao.AutoSize = true;
            lblRotuloDtNascDtCriacao.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloDtNascDtCriacao.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloDtNascDtCriacao.Location = new Point(0, 372);
            lblRotuloDtNascDtCriacao.Name = "lblRotuloDtNascDtCriacao";
            lblRotuloDtNascDtCriacao.Size = new Size(105, 16);
            lblRotuloDtNascDtCriacao.TabIndex = 252;
            lblRotuloDtNascDtCriacao.Text = "Data da Criação";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.25F);
            label7.ForeColor = Color.FromArgb(0, 76, 172);
            label7.Location = new Point(278, 371);
            label7.Name = "label7";
            label7.Size = new Size(104, 16);
            label7.TabIndex = 1021;
            label7.Text = "Usuario Criação";
            // 
            // txtUsuarioCriacao
            // 
            txtUsuarioCriacao.CharacterCasing = CharacterCasing.Upper;
            txtUsuarioCriacao.Location = new Point(276, 390);
            txtUsuarioCriacao.Name = "txtUsuarioCriacao";
            txtUsuarioCriacao.Size = new Size(355, 27);
            txtUsuarioCriacao.StateCommon.Back.Color1 = Color.White;
            txtUsuarioCriacao.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtUsuarioCriacao.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtUsuarioCriacao.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtUsuarioCriacao.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtUsuarioCriacao.StateCommon.Border.Rounding = 8F;
            txtUsuarioCriacao.StateCommon.Border.Width = 1;
            txtUsuarioCriacao.StateCommon.Content.Color1 = Color.Gray;
            txtUsuarioCriacao.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtUsuarioCriacao.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtUsuarioCriacao.TabIndex = 9;
            // 
            // dtpDataCriacao
            // 
            dtpDataCriacao.CornerRoundingRadius = 8F;
            dtpDataCriacao.Format = DateTimePickerFormat.Short;
            dtpDataCriacao.Location = new Point(0, 390);
            dtpDataCriacao.Name = "dtpDataCriacao";
            dtpDataCriacao.Size = new Size(132, 27);
            dtpDataCriacao.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataCriacao.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtpDataCriacao.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataCriacao.StateCommon.Border.Rounding = 8F;
            dtpDataCriacao.StateCommon.Border.Width = 1;
            dtpDataCriacao.TabIndex = 6;
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
            this.txtInscricaoMunicipal.Location = new Point(403, 83);
            this.txtInscricaoMunicipal.Name = "txtInscricaoMunicipal";
            this.txtInscricaoMunicipal.Size = new Size(195, 27);
            this.txtInscricaoMunicipal.StateCommon.Back.Color1 = Color.White;
            this.txtInscricaoMunicipal.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            this.txtInscricaoMunicipal.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            this.txtInscricaoMunicipal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            this.txtInscricaoMunicipal.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtInscricaoMunicipal.StateCommon.Border.Rounding = 8F;
            this.txtInscricaoMunicipal.StateCommon.Border.Width = 1;
            this.txtInscricaoMunicipal.StateCommon.Content.Color1 = Color.Gray;
            this.txtInscricaoMunicipal.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            this.txtInscricaoMunicipal.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            this.txtInscricaoMunicipal.TabIndex = 3;
            // 
            // lblOrgaoExpedidorRG
            // 
            lblOrgaoExpedidorRG.AutoSize = true;
            lblOrgaoExpedidorRG.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblOrgaoExpedidorRG.ForeColor = Color.FromArgb(0, 76, 172);
            lblOrgaoExpedidorRG.Location = new Point(353, 64);
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
            txtCnpj.Location = new Point(3, 84);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(195, 27);
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
            txtCnpj.TabIndex = 1038;
            txtCnpj.Visible = false;
            // 
            // lblRotuloCnpj
            // 
            lblRotuloCnpj.AutoSize = true;
            lblRotuloCnpj.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloCnpj.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloCnpj.Location = new Point(6, 65);
            lblRotuloCnpj.Name = "lblRotuloCnpj";
            lblRotuloCnpj.Size = new Size(42, 16);
            lblRotuloCnpj.TabIndex = 1039;
            lblRotuloCnpj.Text = "CNPJ";
            lblRotuloCnpj.Visible = false;
            // 
            // txtInscricaoEstadual
            // 
            txtInscricaoEstadual.Location = new Point(203, 84);
            txtInscricaoEstadual.Name = "txtInscricaoEstadual";
            txtInscricaoEstadual.Size = new Size(195, 27);
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
            txtInscricaoEstadual.TabIndex = 1040;
            txtInscricaoEstadual.Visible = false;
            // 
            // lblRotuloIE
            // 
            lblRotuloIE.AutoSize = true;
            lblRotuloIE.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloIE.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloIE.Location = new Point(179, 65);
            lblRotuloIE.Name = "lblRotuloIE";
            lblRotuloIE.Size = new Size(140, 16);
            lblRotuloIE.TabIndex = 1041;
            lblRotuloIE.Text = "IE (Inscrição Estadual)";
            lblRotuloIE.Visible = false;
            // 
            // txtNomeFantasia
            // 
            txtNomeFantasia.CharacterCasing = CharacterCasing.Upper;
            txtNomeFantasia.Location = new Point(550, 30);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.Size = new Size(448, 27);
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
            txtNomeFantasia.TabIndex = 1043;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.25F);
            label1.ForeColor = Color.FromArgb(0, 76, 172);
            label1.Location = new Point(550, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 16);
            label1.TabIndex = 1044;
            label1.Text = "Nome Fantasia";
            // 
            // txtCnae
            // 
            txtCnae.Location = new Point(603, 83);
            txtCnae.Name = "txtCnae";
            txtCnae.Size = new Size(195, 27);
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
            txtCnae.TabIndex = 1045;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.25F);
            label2.ForeColor = Color.FromArgb(0, 76, 172);
            label2.Location = new Point(529, 64);
            label2.Name = "label2";
            label2.Size = new Size(44, 16);
            label2.TabIndex = 1046;
            label2.Text = "CNAE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.25F);
            label3.ForeColor = Color.FromArgb(0, 76, 172);
            label3.Location = new Point(496, 264);
            label3.Name = "label3";
            label3.Size = new Size(30, 16);
            label3.TabIndex = 1048;
            label3.Text = "Site";
            // 
            // txtSite
            // 
            txtSite.CharacterCasing = CharacterCasing.Lower;
            txtSite.Location = new Point(496, 283);
            txtSite.Name = "txtSite";
            txtSite.Size = new Size(493, 27);
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
            txtSite.TabIndex = 1047;
            // 
            // txtResponsavel
            // 
            txtResponsavel.CharacterCasing = CharacterCasing.Upper;
            txtResponsavel.Location = new Point(0, 340);
            txtResponsavel.Name = "txtResponsavel";
            txtResponsavel.Size = new Size(493, 27);
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
            txtResponsavel.TabIndex = 1049;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.25F);
            label4.ForeColor = Color.FromArgb(0, 76, 172);
            label4.Location = new Point(0, 319);
            label4.Name = "label4";
            label4.Size = new Size(88, 16);
            label4.TabIndex = 1050;
            label4.Text = "Responsável";
            // 
            // txtCertificadoDigital
            // 
            txtCertificadoDigital.CharacterCasing = CharacterCasing.Upper;
            txtCertificadoDigital.Location = new Point(497, 340);
            txtCertificadoDigital.Name = "txtCertificadoDigital";
            txtCertificadoDigital.Size = new Size(493, 27);
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
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.25F);
            label6.ForeColor = Color.FromArgb(0, 76, 172);
            label6.Location = new Point(497, 319);
            label6.Name = "label6";
            label6.Size = new Size(112, 16);
            label6.TabIndex = 1052;
            label6.Text = "Certificado Digital";
            // 
            // txtDataAtualizacao
            // 
            txtDataAtualizacao.CornerRoundingRadius = 8F;
            txtDataAtualizacao.Format = DateTimePickerFormat.Short;
            txtDataAtualizacao.Location = new Point(138, 390);
            txtDataAtualizacao.Name = "txtDataAtualizacao";
            txtDataAtualizacao.Size = new Size(132, 27);
            txtDataAtualizacao.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtDataAtualizacao.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtDataAtualizacao.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDataAtualizacao.StateCommon.Border.Rounding = 8F;
            txtDataAtualizacao.StateCommon.Border.Width = 1;
            txtDataAtualizacao.TabIndex = 1053;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.25F);
            label8.ForeColor = Color.FromArgb(0, 76, 172);
            label8.Location = new Point(138, 372);
            label8.Name = "label8";
            label8.Size = new Size(109, 16);
            label8.TabIndex = 1054;
            label8.Text = "Data Atualização";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9.25F);
            label12.ForeColor = Color.FromArgb(0, 76, 172);
            label12.Location = new Point(637, 371);
            label12.Name = "label12";
            label12.Size = new Size(127, 16);
            label12.TabIndex = 1056;
            label12.Text = "Usuario Atualização";
            // 
            // txtUsuarioAtualizacao
            // 
            txtUsuarioAtualizacao.CharacterCasing = CharacterCasing.Upper;
            txtUsuarioAtualizacao.Location = new Point(635, 390);
            txtUsuarioAtualizacao.Name = "txtUsuarioAtualizacao";
            txtUsuarioAtualizacao.Size = new Size(355, 27);
            txtUsuarioAtualizacao.StateCommon.Back.Color1 = Color.White;
            txtUsuarioAtualizacao.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtUsuarioAtualizacao.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtUsuarioAtualizacao.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtUsuarioAtualizacao.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtUsuarioAtualizacao.StateCommon.Border.Rounding = 8F;
            txtUsuarioAtualizacao.StateCommon.Border.Width = 1;
            txtUsuarioAtualizacao.StateCommon.Content.Color1 = Color.Gray;
            txtUsuarioAtualizacao.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtUsuarioAtualizacao.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtUsuarioAtualizacao.TabIndex = 1055;
            // 
            // btnBuscarEnderecoPorCep
            // 
            btnBuscarEnderecoPorCep.CornerRoundingRadius = 10F;
            btnBuscarEnderecoPorCep.Location = new Point(141, 161);
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
            btnBuscarEnderecoPorCep.TabIndex = 1058;
            btnBuscarEnderecoPorCep.Values.Image = Properties.Resources.Pesquisar;
            btnBuscarEnderecoPorCep.Values.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.25F);
            label5.ForeColor = Color.FromArgb(0, 76, 172);
            label5.Location = new Point(328, 194);
            label5.Name = "label5";
            label5.Size = new Size(51, 16);
            label5.TabIndex = 1070;
            label5.Text = "Cidade";
            // 
            // txtUF
            // 
            txtUF.CharacterCasing = CharacterCasing.Upper;
            txtUF.Location = new Point(901, 214);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(97, 27);
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
            txtLogradouro.CharacterCasing = CharacterCasing.Upper;
            txtLogradouro.Location = new Point(179, 162);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(723, 27);
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
            // 
            // txtCep
            // 
            txtCep.Location = new Point(4, 162);
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
            txtCep.TabIndex = 1057;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(908, 162);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(90, 27);
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
            txtNumero.TabIndex = 1060;
            // 
            // txtBairro
            // 
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtBairro.Location = new Point(4, 214);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(318, 27);
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
            // 
            // txtNomeCidade
            // 
            txtNomeCidade.CharacterCasing = CharacterCasing.Upper;
            txtNomeCidade.Location = new Point(328, 214);
            txtNomeCidade.Name = "txtNomeCidade";
            txtNomeCidade.Size = new Size(527, 27);
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
            label17.Font = new Font("Microsoft Sans Serif", 9.25F);
            label17.ForeColor = Color.FromArgb(0, 76, 172);
            label17.Location = new Point(180, 141);
            label17.Name = "label17";
            label17.Size = new Size(77, 16);
            label17.TabIndex = 1065;
            label17.Text = "Logradouro";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9.25F);
            label15.ForeColor = Color.FromArgb(0, 76, 172);
            label15.Location = new Point(908, 141);
            label15.Name = "label15";
            label15.Size = new Size(55, 16);
            label15.TabIndex = 1067;
            label15.Text = "Número";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 9.25F);
            label14.ForeColor = Color.FromArgb(0, 76, 172);
            label14.Location = new Point(6, 194);
            label14.Name = "label14";
            label14.Size = new Size(43, 16);
            label14.TabIndex = 1068;
            label14.Text = "Bairro";
            // 
            // btnLocalizar
            // 
            btnLocalizar.CornerRoundingRadius = 10F;
            btnLocalizar.Location = new Point(861, 213);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizar.OverrideDefault.Back.ColorAngle = 45F;
            btnLocalizar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizar.OverrideDefault.Border.ColorAngle = 45F;
            btnLocalizar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizar.OverrideDefault.Border.Rounding = 20F;
            btnLocalizar.OverrideDefault.Border.Width = 1;
            btnLocalizar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnLocalizar.Size = new Size(30, 29);
            btnLocalizar.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnLocalizar.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnLocalizar.StateCommon.Back.ColorAngle = 45F;
            btnLocalizar.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            btnLocalizar.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizar.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopLeft;
            btnLocalizar.StateCommon.Border.Rounding = 10F;
            btnLocalizar.StateCommon.Border.Width = 1;
            btnLocalizar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLocalizar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLocalizar.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalizar.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalizar.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalizar.StatePressed.Back.ColorAngle = 135F;
            btnLocalizar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalizar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalizar.StatePressed.Border.ColorAngle = 135F;
            btnLocalizar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizar.StatePressed.Border.Rounding = 20F;
            btnLocalizar.StatePressed.Border.Width = 1;
            btnLocalizar.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizar.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnLocalizar.StateTracking.Back.ColorAngle = 45F;
            btnLocalizar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizar.StateTracking.Border.ColorAngle = 45F;
            btnLocalizar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizar.StateTracking.Border.Rounding = 20F;
            btnLocalizar.StateTracking.Border.Width = 1;
            btnLocalizar.TabIndex = 1063;
            btnLocalizar.TabStop = false;
            btnLocalizar.Values.Image = Properties.Resources.Pesquisar;
            btnLocalizar.Values.Text = "";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 9.25F);
            label20.ForeColor = Color.FromArgb(0, 76, 172);
            label20.Location = new Point(902, 194);
            label20.Name = "label20";
            label20.Size = new Size(20, 16);
            label20.TabIndex = 1066;
            label20.Text = "Uf";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.25F);
            label9.ForeColor = Color.FromArgb(0, 76, 172);
            label9.Location = new Point(4, 141);
            label9.Name = "label9";
            label9.Size = new Size(32, 16);
            label9.TabIndex = 1069;
            label9.Text = "Cep";
            // 
            // FrmCadEmpresa
            // 
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1020, 502);
            ControlBox = false;
            Controls.Add(btnBuscarEnderecoPorCep);
            Controls.Add(label5);
            Controls.Add(txtUF);
            Controls.Add(txtLogradouro);
            Controls.Add(txtCep);
            Controls.Add(txtNumero);
            Controls.Add(txtBairro);
            Controls.Add(txtNomeCidade);
            Controls.Add(label17);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(btnLocalizar);
            Controls.Add(label20);
            Controls.Add(label9);
            Controls.Add(label12);
            Controls.Add(txtUsuarioAtualizacao);
            Controls.Add(txtDataAtualizacao);
            Controls.Add(label8);
            Controls.Add(txtCertificadoDigital);
            Controls.Add(label6);
            Controls.Add(txtResponsavel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSite);
            Controls.Add(txtCnae);
            Controls.Add(label2);
            Controls.Add(txtNomeFantasia);
            Controls.Add(label1);
            Controls.Add(txtInscricaoEstadual);
            Controls.Add(lblRotuloIE);
            Controls.Add(txtCnpj);
            Controls.Add(lblRotuloCnpj);
            Controls.Add(this.txtInscricaoMunicipal);
            Controls.Add(lblOrgaoExpedidorRG);
            Controls.Add(dtpDataCriacao);
            Controls.Add(label7);
            Controls.Add(txtRazaoSocial);
            Controls.Add(txtUsuarioCriacao);
            Controls.Add(txtTelefone);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(lblRotuloDtNascDtCriacao);
            Controls.Add(label18);
            Controls.Add(label10);
            Controls.Add(txtEmail);
            Controls.Add(txtEmpresaID);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadEmpresa";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterParent;
            StateCommon.Back.Color1 = Color.White;
            StateCommon.Back.Color2 = Color.White;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "Cadastro da Empresa";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        public Krypton.Toolkit.KryptonTextBox txtInscricaoMunicipal;
        public Krypton.Toolkit.KryptonTextBox txtTelefone;
        public Krypton.Toolkit.KryptonTextBox txtRazaoSocial;
        public Krypton.Toolkit.KryptonTextBox txtEmpresaID;
        public Krypton.Toolkit.KryptonTextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private Label lblRotuloDtNascDtCriacao;
        public Krypton.Toolkit.KryptonTextBox txtDataNascimento;
        private Label label7;
        public Krypton.Toolkit.KryptonTextBox txtUsuarioCriacao;
        public Krypton.Toolkit.KryptonDateTimePicker dtpDataCriacao;
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
        public Krypton.Toolkit.KryptonTextBox txtInscricaoEstadual;
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
        public Krypton.Toolkit.KryptonDateTimePicker txtDataAtualizacao;
        private Label label8;
        private Label label12;
        public Krypton.Toolkit.KryptonTextBox txtUsuarioAtualizacao;
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
        public Krypton.Toolkit.KryptonButton btnLocalizar;
        private Label label20;
        private Label label9;
    }
}
