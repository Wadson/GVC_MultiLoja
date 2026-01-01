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
            btnSair = new Krypton.Toolkit.KryptonButton();
            btnNovo = new Krypton.Toolkit.KryptonButton();
            btnSalvar = new Krypton.Toolkit.KryptonButton();
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
            kryptonStatusStrip1.SuspendLayout();
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
            txtTelefone.TabIndex = 6;
            txtTelefone.Leave += txtTelefone_Leave;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.CharacterCasing = CharacterCasing.Upper;
            txtRazaoSocial.Location = new Point(100, 30);
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
            txtEmpresaID.Location = new Point(6, 30);
            txtEmpresaID.Name = "txtEmpresaID";
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
            txtEmail.Location = new Point(6, 241);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(315, 27);
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
            label10.Location = new Point(6, 10);
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
            label11.Location = new Point(100, 9);
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
            label13.Location = new Point(803, 65);
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
            label18.Location = new Point(6, 222);
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
            txtInscricaoMunicipal.Location = new Point(403, 83);
            txtInscricaoMunicipal.Name = "txtInscricaoMunicipal";
            txtInscricaoMunicipal.Size = new Size(195, 27);
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
            lblOrgaoExpedidorRG.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblOrgaoExpedidorRG.ForeColor = Color.FromArgb(0, 76, 172);
            lblOrgaoExpedidorRG.Location = new Point(403, 64);
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
            txtCnpj.Location = new Point(6, 84);
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
            txtCnpj.TabIndex = 2;
            txtCnpj.Leave += txtCnpj_Leave;
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
            txtInscricaoEstadual.TabIndex = 3;
            // 
            // lblRotuloIE
            // 
            lblRotuloIE.AutoSize = true;
            lblRotuloIE.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloIE.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloIE.Location = new Point(211, 65);
            lblRotuloIE.Name = "lblRotuloIE";
            lblRotuloIE.Size = new Size(140, 16);
            lblRotuloIE.TabIndex = 1041;
            lblRotuloIE.Text = "IE (Inscrição Estadual)";
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
            txtNomeFantasia.TabIndex = 1;
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
            txtCnae.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.25F);
            label2.ForeColor = Color.FromArgb(0, 76, 172);
            label2.Location = new Point(606, 65);
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
            label3.Location = new Point(327, 222);
            label3.Name = "label3";
            label3.Size = new Size(30, 16);
            label3.TabIndex = 1048;
            label3.Text = "Site";
            // 
            // txtSite
            // 
            txtSite.CharacterCasing = CharacterCasing.Lower;
            txtSite.Location = new Point(327, 241);
            txtSite.Name = "txtSite";
            txtSite.Size = new Size(673, 27);
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
            txtResponsavel.CharacterCasing = CharacterCasing.Upper;
            txtResponsavel.Location = new Point(6, 298);
            txtResponsavel.Name = "txtResponsavel";
            txtResponsavel.Size = new Size(992, 27);
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
            label4.Font = new Font("Microsoft Sans Serif", 9.25F);
            label4.ForeColor = Color.FromArgb(0, 76, 172);
            label4.Location = new Point(6, 277);
            label4.Name = "label4";
            label4.Size = new Size(88, 16);
            label4.TabIndex = 1050;
            label4.Text = "Responsável";
            // 
            // txtCertificadoDigital
            // 
            txtCertificadoDigital.CharacterCasing = CharacterCasing.Upper;
            txtCertificadoDigital.Location = new Point(6, 353);
            txtCertificadoDigital.Name = "txtCertificadoDigital";
            txtCertificadoDigital.Size = new Size(812, 27);
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
            label6.Font = new Font("Microsoft Sans Serif", 9.25F);
            label6.ForeColor = Color.FromArgb(0, 76, 172);
            label6.Location = new Point(6, 332);
            label6.Name = "label6";
            label6.Size = new Size(112, 16);
            label6.TabIndex = 1052;
            label6.Text = "Certificado Digital";
            // 
            // btnBuscarEnderecoPorCep
            // 
            btnBuscarEnderecoPorCep.CornerRoundingRadius = 10F;
            btnBuscarEnderecoPorCep.Location = new Point(143, 139);
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
            btnBuscarEnderecoPorCep.TabIndex = 8;
            btnBuscarEnderecoPorCep.Values.Image = Properties.Resources.Pesquisar;
            btnBuscarEnderecoPorCep.Values.Text = "";
            btnBuscarEnderecoPorCep.Click += btnBuscarEnderecoPorCep_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.25F);
            label5.ForeColor = Color.FromArgb(0, 76, 172);
            label5.Location = new Point(557, 176);
            label5.Name = "label5";
            label5.Size = new Size(51, 16);
            label5.TabIndex = 1070;
            label5.Text = "Cidade";
            // 
            // txtUF
            // 
            txtUF.CharacterCasing = CharacterCasing.Upper;
            txtUF.Location = new Point(898, 195);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(100, 27);
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
            txtLogradouro.Location = new Point(181, 140);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(817, 27);
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
            txtCep.Location = new Point(6, 140);
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
            txtCep.TabIndex = 7;
            txtCep.Leave += txtCep_Leave;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(6, 195);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(132, 27);
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
            txtNumero.TabIndex = 9;
            // 
            // txtBairro
            // 
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtBairro.Location = new Point(143, 195);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(405, 27);
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
            txtNomeCidade.CharacterCasing = CharacterCasing.Upper;
            txtNomeCidade.Location = new Point(553, 195);
            txtNomeCidade.Name = "txtNomeCidade";
            txtNomeCidade.Size = new Size(339, 27);
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
            label17.Location = new Point(182, 119);
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
            label15.Location = new Point(6, 175);
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
            label14.Location = new Point(147, 175);
            label14.Name = "label14";
            label14.Size = new Size(43, 16);
            label14.TabIndex = 1068;
            label14.Text = "Bairro";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 9.25F);
            label20.ForeColor = Color.FromArgb(0, 76, 172);
            label20.Location = new Point(899, 180);
            label20.Name = "label20";
            label20.Size = new Size(25, 16);
            label20.TabIndex = 1066;
            label20.Text = "UF";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.25F);
            label9.ForeColor = Color.FromArgb(0, 76, 172);
            label9.Location = new Point(6, 119);
            label9.Name = "label9";
            label9.Size = new Size(32, 16);
            label9.TabIndex = 1069;
            label9.Text = "Cep";
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSair.CornerRoundingRadius = 10F;
            btnSair.Location = new Point(918, 418);
            btnSair.Margin = new Padding(5, 3, 5, 3);
            btnSair.Name = "btnSair";
            btnSair.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Back.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Border.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.OverrideDefault.Border.Rounding = 20F;
            btnSair.OverrideDefault.Border.Width = 1;
            btnSair.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSair.Size = new Size(80, 27);
            btnSair.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Back.ColorAngle = 45F;
            btnSair.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateCommon.Border.Rounding = 10F;
            btnSair.StateCommon.Border.Width = 1;
            btnSair.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSair.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSair.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnSair.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StatePressed.Back.ColorAngle = 135F;
            btnSair.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StatePressed.Border.ColorAngle = 135F;
            btnSair.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StatePressed.Border.Rounding = 20F;
            btnSair.StatePressed.Border.Width = 1;
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
            btnSair.TabIndex = 1073;
            btnSair.TabStop = false;
            btnSair.Values.Text = "&Sair";
            btnSair.Click += btnSair_Click;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNovo.CornerRoundingRadius = 10F;
            btnNovo.Location = new Point(828, 418);
            btnNovo.Margin = new Padding(5, 3, 5, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnNovo.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnNovo.OverrideDefault.Back.ColorAngle = 45F;
            btnNovo.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNovo.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNovo.OverrideDefault.Border.ColorAngle = 45F;
            btnNovo.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.OverrideDefault.Border.Rounding = 20F;
            btnNovo.OverrideDefault.Border.Width = 1;
            btnNovo.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnNovo.Size = new Size(80, 27);
            btnNovo.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnNovo.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnNovo.StateCommon.Back.ColorAngle = 45F;
            btnNovo.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNovo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNovo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.StateCommon.Border.Rounding = 10F;
            btnNovo.StateCommon.Border.Width = 1;
            btnNovo.StateCommon.Content.ShortText.Color1 = Color.White;
            btnNovo.StateCommon.Content.ShortText.Color2 = Color.White;
            btnNovo.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnNovo.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnNovo.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnNovo.StatePressed.Back.ColorAngle = 135F;
            btnNovo.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnNovo.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnNovo.StatePressed.Border.ColorAngle = 135F;
            btnNovo.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.StatePressed.Border.Rounding = 20F;
            btnNovo.StatePressed.Border.Width = 1;
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
            btnNovo.TabIndex = 1074;
            btnNovo.TabStop = false;
            btnNovo.Values.Text = "&Novo";
            btnNovo.Click += btnNovo_Click_1;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.CornerRoundingRadius = 10F;
            btnSalvar.Location = new Point(738, 418);
            btnSalvar.Margin = new Padding(5, 3, 5, 3);
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
            btnSalvar.Size = new Size(80, 27);
            btnSalvar.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvar.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvar.StateCommon.Back.ColorAngle = 45F;
            btnSalvar.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvar.StateCommon.Border.Rounding = 10F;
            btnSalvar.StateCommon.Border.Width = 1;
            btnSalvar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSalvar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSalvar.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnSalvar.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnSalvar.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnSalvar.StatePressed.Back.ColorAngle = 135F;
            btnSalvar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSalvar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSalvar.StatePressed.Border.ColorAngle = 135F;
            btnSalvar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvar.StatePressed.Border.Rounding = 20F;
            btnSalvar.StatePressed.Border.Width = 1;
            btnSalvar.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSalvar.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnSalvar.StateTracking.Back.ColorAngle = 45F;
            btnSalvar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvar.StateTracking.Border.ColorAngle = 45F;
            btnSalvar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvar.StateTracking.Border.Rounding = 20F;
            btnSalvar.StateTracking.Border.Width = 1;
            btnSalvar.TabIndex = 13;
            btnSalvar.Values.Text = "&Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Items.AddRange(new ToolStripItem[] { lblUsuarioCriacao, toolStripStatusLabel2, lblDataCriacao, toolStripStatusLabel4, lblDataUtimaCompra, toolStripStatusLabel1, lblUsuarioAtualizacao, toolStripStatusLabel3, lblDataAtualizacao, lblStatus, toolStripStatusLabel5 });
            kryptonStatusStrip1.Location = new Point(0, 480);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            kryptonStatusStrip1.Size = new Size(1020, 22);
            kryptonStatusStrip1.TabIndex = 1079;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // lblUsuarioCriacao
            // 
            lblUsuarioCriacao.ForeColor = Color.White;
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
            lblDataCriacao.ForeColor = Color.White;
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
            lblDataUtimaCompra.ForeColor = Color.White;
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
            lblDataAtualizacao.Name = "lblDataAtualizacao";
            lblDataAtualizacao.Size = new Size(95, 17);
            lblDataAtualizacao.Text = "Data Atualização";
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.FromArgb(0, 192, 0);
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
            btnLocalizarCertificado.Location = new Point(819, 353);
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
            btnLocalizarCertificado.Size = new Size(179, 27);
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
            btnLocalizarCertificado.Values.Text = "Localizar certificado";
            btnLocalizarCertificado.Click += btnLocalizarCertificado_Click;
            // 
            // FrmCadEmpresa
            // 
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1020, 502);
            ControlBox = false;
            Controls.Add(btnLocalizarCertificado);
            Controls.Add(kryptonStatusStrip1);
            Controls.Add(btnSalvar);
            Controls.Add(btnSair);
            Controls.Add(btnNovo);
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
            Controls.Add(label20);
            Controls.Add(label9);
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
            Controls.Add(txtInscricaoMunicipal);
            Controls.Add(lblOrgaoExpedidorRG);
            Controls.Add(txtRazaoSocial);
            Controls.Add(txtTelefone);
            Controls.Add(label13);
            Controls.Add(label11);
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
            FormClosing += FrmCadEmpresa_FormClosing;
            Load += FrmCadEmpresa_Load;
            Shown += FrmCadEmpresa_Shown;
            KeyDown += FrmCadEmpresa_KeyDown;
            kryptonStatusStrip1.ResumeLayout(false);
            kryptonStatusStrip1.PerformLayout();
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
        private Label label7;
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
        public Krypton.Toolkit.KryptonButton btnSair;
        public Krypton.Toolkit.KryptonButton btnNovo;
        private PictureBox pictureBox1;
        public Krypton.Toolkit.KryptonButton btnSalvar;
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
    }
}
