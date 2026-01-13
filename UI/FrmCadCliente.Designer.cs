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
            label10 = new Label();
            label11 = new Label();
            lblCpf = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label17 = new Label();
            label18 = new Label();
            txtUF = new Krypton.Toolkit.KryptonTextBox();
            label20 = new Label();
            btnLocalizar = new Krypton.Toolkit.KryptonButton();
            label1 = new Label();
            txtCep = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloDtNascDtCriacao = new Label();
            cmbTipoCliente = new Krypton.Toolkit.KryptonComboBox();
            label5 = new Label();
            txtObservacoes = new Krypton.Toolkit.KryptonTextBox();
            label7 = new Label();
            txtLimiteCredito = new Krypton.Toolkit.KryptonTextBox();
            dtpDataNascimento = new Krypton.Toolkit.KryptonDateTimePicker();
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
            label8 = new Label();
            cmbStatus = new Krypton.Toolkit.KryptonComboBox();
            label9 = new Label();
            toolTip = new ToolTip(components);
            Timer1 = new System.Windows.Forms.Timer(components);
            btnBuscarEnderecoPorCep = new Krypton.Toolkit.KryptonButton();
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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            label2 = new Label();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel5 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)cmbTipoCliente).BeginInit();
            kryptonStatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).BeginInit();
            pnlHeader.SuspendLayout();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).BeginInit();
            kryptonPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLogradouro.CharacterCasing = CharacterCasing.Upper;
            txtLogradouro.Location = new Point(261, 46);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(732, 27);
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
            txtNomeCliente.Size = new Size(614, 27);
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
            txtClienteID.Location = new Point(785, 38);
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
            txtNomeCidade.Size = new Size(809, 27);
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
            txtEmail.Size = new Size(979, 27);
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
            txtBairro.Size = new Size(731, 27);
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
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.ForeColor = Color.FromArgb(0, 76, 172);
            label10.Location = new Point(789, 20);
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
            label11.Location = new Point(166, 19);
            label11.Name = "label11";
            label11.Size = new Size(44, 16);
            label11.TabIndex = 183;
            label11.Text = "Nome";
            // 
            // lblCpf
            // 
            lblCpf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCpf.AutoSize = true;
            lblCpf.BackColor = Color.Transparent;
            lblCpf.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblCpf.ForeColor = Color.FromArgb(0, 76, 172);
            lblCpf.Location = new Point(449, 70);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(33, 16);
            lblCpf.TabIndex = 186;
            lblCpf.Text = "CPF";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Microsoft Sans Serif", 9.25F);
            label13.ForeColor = Color.FromArgb(0, 76, 172);
            label13.Location = new Point(148, 27);
            label13.Name = "label13";
            label13.Size = new Size(61, 16);
            label13.TabIndex = 185;
            label13.Text = "Telefone";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft Sans Serif", 9.25F);
            label14.ForeColor = Color.FromArgb(0, 76, 172);
            label14.Location = new Point(264, 75);
            label14.Name = "label14";
            label14.Size = new Size(43, 16);
            label14.TabIndex = 185;
            label14.Text = "Bairro";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Microsoft Sans Serif", 9.25F);
            label15.ForeColor = Color.FromArgb(0, 76, 172);
            label15.Location = new Point(13, 75);
            label15.Name = "label15";
            label15.Size = new Size(55, 16);
            label15.TabIndex = 184;
            label15.Text = "Número";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Microsoft Sans Serif", 9.25F);
            label17.ForeColor = Color.FromArgb(0, 76, 172);
            label17.Location = new Point(262, 26);
            label17.Name = "label17";
            label17.Size = new Size(66, 16);
            label17.TabIndex = 183;
            label17.Text = "Endereço";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Microsoft Sans Serif", 9.25F);
            label18.ForeColor = Color.FromArgb(0, 76, 172);
            label18.Location = new Point(13, 74);
            label18.Name = "label18";
            label18.Size = new Size(45, 16);
            label18.TabIndex = 183;
            label18.Text = "E-Mail";
            // 
            // txtUF
            // 
            txtUF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtUF.CharacterCasing = CharacterCasing.Upper;
            txtUF.Location = new Point(860, 144);
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
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Microsoft Sans Serif", 9.25F);
            label20.ForeColor = Color.FromArgb(0, 76, 172);
            label20.Location = new Point(861, 125);
            label20.Name = "label20";
            label20.Size = new Size(20, 16);
            label20.TabIndex = 183;
            label20.Text = "Uf";
            // 
            // btnLocalizar
            // 
            btnLocalizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLocalizar.CornerRoundingRadius = 10F;
            btnLocalizar.Location = new Point(826, 144);
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
            btnLocalizar.TabIndex = 120;
            btnLocalizar.TabStop = false;
            btnLocalizar.Values.Image = Properties.Resources.Pesquisar;
            btnLocalizar.Values.Text = "";
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 9.25F);
            label1.ForeColor = Color.FromArgb(0, 76, 172);
            label1.Location = new Point(13, 26);
            label1.Name = "label1";
            label1.Size = new Size(32, 16);
            label1.TabIndex = 250;
            label1.Text = "Cep";
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
            // cmbTipoCliente
            // 
            cmbTipoCliente.CornerRoundingRadius = 10F;
            cmbTipoCliente.DropDownWidth = 171;
            cmbTipoCliente.IntegralHeight = false;
            cmbTipoCliente.Location = new Point(7, 38);
            cmbTipoCliente.Name = "cmbTipoCliente";
            cmbTipoCliente.Size = new Size(151, 27);
            cmbTipoCliente.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(8, 142, 254);
            cmbTipoCliente.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(8, 142, 254);
            cmbTipoCliente.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoCliente.StateCommon.ComboBox.Border.Rounding = 10F;
            cmbTipoCliente.StateCommon.ComboBox.Border.Width = 1;
            cmbTipoCliente.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbTipoCliente.TabIndex = 150;
            cmbTipoCliente.TabStop = false;
            cmbTipoCliente.SelectedIndexChanged += cmbTipoCliente_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 9.25F);
            label5.ForeColor = Color.FromArgb(0, 76, 172);
            label5.Location = new Point(7, 19);
            label5.Name = "label5";
            label5.Size = new Size(104, 16);
            label5.TabIndex = 1016;
            label5.Text = "Tipo da Pessoa";
            // 
            // txtObservacoes
            // 
            txtObservacoes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtObservacoes.CharacterCasing = CharacterCasing.Upper;
            txtObservacoes.Location = new Point(13, 23);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(979, 49);
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
            txtLimiteCredito.Size = new Size(572, 27);
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
            // dtpDataNascimento
            // 
            dtpDataNascimento.CornerRoundingRadius = 8F;
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(13, 45);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(132, 27);
            dtpDataNascimento.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataNascimento.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtpDataNascimento.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataNascimento.StateCommon.Border.Rounding = 8F;
            dtpDataNascimento.StateCommon.Border.Width = 1;
            dtpDataNascimento.TabIndex = 4;
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelUsuarioCriacao, toolStripStatusLabel2, toolStripStatusLabel6, toolStripStatusLabel5, ToolStripLabelDataCriacao, toolStripStatusLabel4, ToolStripLabelDataUtimaCompra, toolStripStatusLabel1, toolStripStatusLabelUsuarioAtualizacao, toolStripStatusLabel3, toolStripStatusLabelDataAtualizacao, lblStatus });
            kryptonStatusStrip1.Location = new Point(0, 639);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.Professional;
            kryptonStatusStrip1.Size = new Size(1008, 22);
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
            txtCpf.Location = new Point(449, 90);
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
            txtRg.Location = new Point(633, 90);
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
            lblRG.Location = new Point(636, 71);
            lblRG.Name = "lblRG";
            lblRG.Size = new Size(124, 16);
            lblRG.TabIndex = 1031;
            lblRG.Text = "RG - Registro Geral";
            // 
            // txtOrgaoExpedidorRG
            // 
            txtOrgaoExpedidorRG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtOrgaoExpedidorRG.Location = new Point(818, 89);
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
            lblOrgaoExpedidorRG.Location = new Point(820, 70);
            lblOrgaoExpedidorRG.Name = "lblOrgaoExpedidorRG";
            lblOrgaoExpedidorRG.Size = new Size(133, 16);
            lblOrgaoExpedidorRG.TabIndex = 1033;
            lblOrgaoExpedidorRG.Text = "Orgão Expedidor RG";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 9.25F);
            label8.ForeColor = Color.FromArgb(0, 76, 172);
            label8.Location = new Point(13, 125);
            label8.Name = "label8";
            label8.Size = new Size(51, 16);
            label8.TabIndex = 1034;
            label8.Text = "Cidade";
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
            cmbStatus.Size = new Size(436, 27);
            cmbStatus.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(8, 142, 254);
            cmbStatus.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(8, 142, 254);
            cmbStatus.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbStatus.StateCommon.ComboBox.Border.Rounding = 10F;
            cmbStatus.StateCommon.ComboBox.Border.Width = 1;
            cmbStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbStatus.TabIndex = 1035;
            cmbStatus.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 9.25F);
            label9.ForeColor = Color.FromArgb(0, 76, 172);
            label9.Location = new Point(7, 70);
            label9.Name = "label9";
            label9.Size = new Size(44, 16);
            label9.TabIndex = 1036;
            label9.Text = "Status";
            // 
            // Timer1
            // 
            Timer1.Interval = 500;
            // 
            // btnBuscarEnderecoPorCep
            // 
            btnBuscarEnderecoPorCep.CornerRoundingRadius = 10F;
            btnBuscarEnderecoPorCep.Location = new Point(226, 45);
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
            btnBuscarEnderecoPorCep.TabIndex = 9;
            btnBuscarEnderecoPorCep.Values.Image = Properties.Resources.Pesquisar;
            btnBuscarEnderecoPorCep.Values.Text = "";
            btnBuscarEnderecoPorCep.Click += btnBuscarEnderecoPorCep_Click;
            // 
            // txtCnpj
            // 
            txtCnpj.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCnpj.Location = new Point(449, 90);
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
            lblRotuloCnpj.Location = new Point(457, 71);
            lblRotuloCnpj.Name = "lblRotuloCnpj";
            lblRotuloCnpj.Size = new Size(42, 16);
            lblRotuloCnpj.TabIndex = 1039;
            lblRotuloCnpj.Text = "CNPJ";
            lblRotuloCnpj.Visible = false;
            // 
            // txtIE
            // 
            txtIE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtIE.Location = new Point(633, 90);
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
            lblRotuloIE.Location = new Point(636, 71);
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
            chkIsVendedor.Location = new Point(920, 43);
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
            btnSalvar.Location = new Point(684, 603);
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
            btnNovo.Location = new Point(790, 603);
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
            btnSair.Location = new Point(896, 603);
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
            pnlHeader.Size = new Size(1008, 47);
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
            tlpTitulo.Size = new Size(1008, 47);
            tlpTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            tlpTitulo.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            tlpTitulo.TabIndex = 0;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.Dock = DockStyle.Fill;
            lblSubTitulo.Location = new Point(3, 25);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(1002, 19);
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
            lblTitulo.Size = new Size(1002, 16);
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Color2 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 1091;
            lblTitulo.Values.Text = "Cadastro de Clientes";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel1.Controls.Add(txtOrgaoExpedidorRG);
            kryptonPanel1.Controls.Add(lblCpf);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Controls.Add(txtCpf);
            kryptonPanel1.Controls.Add(label2);
            kryptonPanel1.Controls.Add(lblRG);
            kryptonPanel1.Controls.Add(chkIsVendedor);
            kryptonPanel1.Controls.Add(txtRg);
            kryptonPanel1.Controls.Add(txtClienteID);
            kryptonPanel1.Controls.Add(lblOrgaoExpedidorRG);
            kryptonPanel1.Controls.Add(label10);
            kryptonPanel1.Controls.Add(lblRotuloCnpj);
            kryptonPanel1.Controls.Add(cmbTipoCliente);
            kryptonPanel1.Controls.Add(txtIE);
            kryptonPanel1.Controls.Add(label5);
            kryptonPanel1.Controls.Add(txtCnpj);
            kryptonPanel1.Controls.Add(cmbStatus);
            kryptonPanel1.Controls.Add(lblRotuloIE);
            kryptonPanel1.Controls.Add(label9);
            kryptonPanel1.Controls.Add(txtNomeCliente);
            kryptonPanel1.Controls.Add(label11);
            kryptonPanel1.Location = new Point(3, 56);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueLightMode;
            kryptonPanel1.Size = new Size(1005, 128);
            kryptonPanel1.TabIndex = 1094;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Dock = DockStyle.Top;
            kryptonLabel1.Location = new Point(0, 0);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(1005, 20);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 1038;
            kryptonLabel1.Values.Text = "Dados cadastrais";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 9.25F);
            label2.ForeColor = Color.FromArgb(0, 76, 172);
            label2.Location = new Point(906, 19);
            label2.Name = "label2";
            label2.Size = new Size(86, 16);
            label2.TabIndex = 1037;
            label2.Text = "É Vendedor?";
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel3.Controls.Add(kryptonLabel2);
            kryptonPanel3.Controls.Add(txtEmail);
            kryptonPanel3.Controls.Add(label18);
            kryptonPanel3.Controls.Add(lblRotuloDtNascDtCriacao);
            kryptonPanel3.Controls.Add(label13);
            kryptonPanel3.Controls.Add(txtTelefone);
            kryptonPanel3.Controls.Add(txtLimiteCredito);
            kryptonPanel3.Controls.Add(label7);
            kryptonPanel3.Controls.Add(dtpDataNascimento);
            kryptonPanel3.Location = new Point(3, 188);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueLightMode;
            kryptonPanel3.Size = new Size(1005, 123);
            kryptonPanel3.TabIndex = 1096;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Dock = DockStyle.Top;
            kryptonLabel2.Location = new Point(0, 0);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(1005, 20);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 1039;
            kryptonLabel2.Values.Text = "Dados adicionais";
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel4.Controls.Add(kryptonLabel3);
            kryptonPanel4.Controls.Add(txtNomeCidade);
            kryptonPanel4.Controls.Add(label1);
            kryptonPanel4.Controls.Add(label20);
            kryptonPanel4.Controls.Add(btnLocalizar);
            kryptonPanel4.Controls.Add(label14);
            kryptonPanel4.Controls.Add(label15);
            kryptonPanel4.Controls.Add(label17);
            kryptonPanel4.Controls.Add(txtBairro);
            kryptonPanel4.Controls.Add(txtNumero);
            kryptonPanel4.Controls.Add(btnBuscarEnderecoPorCep);
            kryptonPanel4.Controls.Add(txtCep);
            kryptonPanel4.Controls.Add(label8);
            kryptonPanel4.Controls.Add(txtLogradouro);
            kryptonPanel4.Controls.Add(txtUF);
            kryptonPanel4.Location = new Point(3, 328);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueLightMode;
            kryptonPanel4.Size = new Size(1005, 180);
            kryptonPanel4.TabIndex = 1097;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Dock = DockStyle.Top;
            kryptonLabel3.Location = new Point(0, 0);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(1005, 20);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 1039;
            kryptonLabel3.Values.Text = "Endereço";
            // 
            // kryptonPanel5
            // 
            kryptonPanel5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel5.Controls.Add(kryptonLabel4);
            kryptonPanel5.Controls.Add(txtObservacoes);
            kryptonPanel5.Location = new Point(3, 513);
            kryptonPanel5.Name = "kryptonPanel5";
            kryptonPanel5.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueLightMode;
            kryptonPanel5.Size = new Size(1005, 78);
            kryptonPanel5.TabIndex = 1098;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Dock = DockStyle.Top;
            kryptonLabel4.Location = new Point(0, 0);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(1005, 20);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel4.TabIndex = 1040;
            kryptonLabel4.Values.Text = "Observação";
            // 
            // FrmCadCliente
            // 
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1008, 661);
            Controls.Add(kryptonPanel5);
            Controls.Add(kryptonPanel4);
            Controls.Add(kryptonPanel3);
            Controls.Add(kryptonPanel1);
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
            ((System.ComponentModel.ISupportInitialize)cmbTipoCliente).EndInit();
            kryptonStatusStrip1.ResumeLayout(false);
            kryptonStatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).EndInit();
            pnlHeader.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            kryptonPanel4.ResumeLayout(false);
            kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).EndInit();
            kryptonPanel5.ResumeLayout(false);
            kryptonPanel5.PerformLayout();
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        public Krypton.Toolkit.KryptonTextBox txtUF;
        private System.Windows.Forms.Label label20;
        public Krypton.Toolkit.KryptonButton btnSair;
        public Krypton.Toolkit.KryptonButton btnLocalizar;
        private Label label1;
        public Krypton.Toolkit.KryptonTextBox txtCep;
        private Label lblRotuloDtNascDtCriacao;
        public Krypton.Toolkit.KryptonTextBox txtDataNascimento;
        private Label label5;
        public Krypton.Toolkit.KryptonTextBox txtObservacoes;
        private Label label7;
        public Krypton.Toolkit.KryptonTextBox txtLimiteCredito;
        public Krypton.Toolkit.KryptonDateTimePicker dtpDataNascimento;
        public Krypton.Toolkit.KryptonComboBox cmbTipoCliente;
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
        private Label label8;
        public Krypton.Toolkit.KryptonComboBox cmbStatus;
        private Label label9;
        private ToolTip toolTip;
        private System.Windows.Forms.Timer Timer1;
        private ToolStripStatusLabel lblStatus;
        public Krypton.Toolkit.KryptonButton btnBuscarEnderecoPorCep;
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
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Label label2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
    }
}
