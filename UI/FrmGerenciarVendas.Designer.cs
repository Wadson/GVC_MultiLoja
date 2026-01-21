namespace GVC.View
{
    partial class FrmGerenciarVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerenciarVendas));
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            toolStripStatusLabelUsuarioCriacao = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            ToolStripLabelDataCriacao = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            ToolStripLabelDataUtimaCompra = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabelUsuarioAtualizacao = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabelDataAtualizacao = new ToolStripStatusLabel();
            lblStatus = new ToolStripStatusLabel();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            toolTip = new ToolTip(components);
            Timer1 = new System.Windows.Forms.Timer(components);
            txtCliente = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloNome = new Label();
            lblRotuloVendaID = new Label();
            txtVendaID = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloDataInicio = new Label();
            lblRotuloDataFim = new Label();
            dgvVendas = new Krypton.Toolkit.KryptonDataGridView();
            pnlHeader = new Krypton.Toolkit.KryptonPanel();
            tlpTitulo = new Krypton.Toolkit.KryptonTableLayoutPanel();
            lblSubTitulo = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            iconAcao = new FontAwesome.Sharp.IconPictureBox();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel5 = new Krypton.Toolkit.KryptonPanel();
            btnFiltrar = new FontAwesome.Sharp.IconButton();
            dtpDataFim = new Krypton.Toolkit.KryptonDateTimePicker();
            dtpDataInicio = new Krypton.Toolkit.KryptonDateTimePicker();
            btnLocalizar = new FontAwesome.Sharp.IconButton();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            btnVisualizar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnExcluir = new FontAwesome.Sharp.IconButton();
            btnSair = new FontAwesome.Sharp.IconButton();
            btnAlterar = new FontAwesome.Sharp.IconButton();
            kryptonStatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).BeginInit();
            pnlHeader.SuspendLayout();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconAcao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).BeginInit();
            kryptonPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelUsuarioCriacao, toolStripStatusLabel2, ToolStripLabelDataCriacao, toolStripStatusLabel4, ToolStripLabelDataUtimaCompra, toolStripStatusLabel1, toolStripStatusLabelUsuarioAtualizacao, toolStripStatusLabel3, toolStripStatusLabelDataAtualizacao, lblStatus });
            kryptonStatusStrip1.Location = new Point(0, 539);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.Professional;
            kryptonStatusStrip1.Size = new Size(884, 22);
            kryptonStatusStrip1.TabIndex = 1028;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // toolStripStatusLabelUsuarioCriacao
            // 
            toolStripStatusLabelUsuarioCriacao.BackColor = Color.FromArgb(30, 136, 229);
            toolStripStatusLabelUsuarioCriacao.ForeColor = Color.FromArgb(30, 136, 229);
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
            // ToolStripLabelDataCriacao
            // 
            ToolStripLabelDataCriacao.BackColor = Color.FromArgb(30, 136, 229);
            ToolStripLabelDataCriacao.ForeColor = Color.FromArgb(30, 136, 229);
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
            ToolStripLabelDataUtimaCompra.BackColor = Color.FromArgb(30, 136, 229);
            ToolStripLabelDataUtimaCompra.ForeColor = Color.FromArgb(30, 136, 229);
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
            toolStripStatusLabelUsuarioAtualizacao.BackColor = Color.FromArgb(30, 136, 229);
            toolStripStatusLabelUsuarioAtualizacao.ForeColor = Color.FromArgb(30, 136, 229);
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
            toolStripStatusLabelDataAtualizacao.BackColor = Color.FromArgb(30, 136, 229);
            toolStripStatusLabelDataAtualizacao.ForeColor = Color.FromArgb(30, 136, 229);
            toolStripStatusLabelDataAtualizacao.Name = "toolStripStatusLabelDataAtualizacao";
            toolStripStatusLabelDataAtualizacao.Size = new Size(95, 17);
            toolStripStatusLabelDataAtualizacao.Text = "Data Atualização";
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.FromArgb(30, 136, 229);
            lblStatus.ForeColor = Color.FromArgb(30, 136, 229);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 17);
            lblStatus.Text = "Status";
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
            // Timer1
            // 
            Timer1.Enabled = true;
            Timer1.Interval = 1000;
            // 
            // txtCliente
            // 
            txtCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCliente.CharacterCasing = CharacterCasing.Upper;
            txtCliente.Location = new Point(110, 42);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(420, 27);
            txtCliente.StateCommon.Back.Color1 = Color.White;
            txtCliente.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtCliente.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtCliente.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtCliente.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtCliente.StateCommon.Border.Rounding = 8F;
            txtCliente.StateCommon.Border.Width = 1;
            txtCliente.StateCommon.Content.Color1 = Color.Gray;
            txtCliente.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtCliente.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtCliente.TabIndex = 1029;
            // 
            // lblRotuloNome
            // 
            lblRotuloNome.AutoSize = true;
            lblRotuloNome.BackColor = Color.Transparent;
            lblRotuloNome.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloNome.ForeColor = Color.Navy;
            lblRotuloNome.Location = new Point(116, 21);
            lblRotuloNome.Name = "lblRotuloNome";
            lblRotuloNome.Size = new Size(112, 16);
            lblRotuloNome.TabIndex = 1030;
            lblRotuloNome.Text = "Nome do cliente?";
            // 
            // lblRotuloVendaID
            // 
            lblRotuloVendaID.AutoSize = true;
            lblRotuloVendaID.BackColor = Color.Transparent;
            lblRotuloVendaID.ForeColor = Color.Navy;
            lblRotuloVendaID.Location = new Point(3, 22);
            lblRotuloVendaID.Name = "lblRotuloVendaID";
            lblRotuloVendaID.Size = new Size(102, 15);
            lblRotuloVendaID.TabIndex = 1031;
            lblRotuloVendaID.Text = "Código da Venda?";
            // 
            // txtVendaID
            // 
            txtVendaID.Location = new Point(3, 42);
            txtVendaID.Name = "txtVendaID";
            txtVendaID.Size = new Size(102, 27);
            txtVendaID.StateCommon.Back.Color1 = Color.White;
            txtVendaID.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtVendaID.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtVendaID.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtVendaID.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtVendaID.StateCommon.Border.Rounding = 8F;
            txtVendaID.StateCommon.Border.Width = 1;
            txtVendaID.StateCommon.Content.Color1 = Color.Gray;
            txtVendaID.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtVendaID.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtVendaID.TabIndex = 1032;
            txtVendaID.TabStop = false;
            txtVendaID.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRotuloDataInicio
            // 
            lblRotuloDataInicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRotuloDataInicio.AutoSize = true;
            lblRotuloDataInicio.BackColor = Color.Transparent;
            lblRotuloDataInicio.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloDataInicio.ForeColor = Color.Navy;
            lblRotuloDataInicio.Location = new Point(573, 23);
            lblRotuloDataInicio.Name = "lblRotuloDataInicio";
            lblRotuloDataInicio.Size = new Size(70, 16);
            lblRotuloDataInicio.TabIndex = 1039;
            lblRotuloDataInicio.Text = "Data Inicio";
            // 
            // lblRotuloDataFim
            // 
            lblRotuloDataFim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRotuloDataFim.AutoSize = true;
            lblRotuloDataFim.BackColor = Color.Transparent;
            lblRotuloDataFim.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloDataFim.ForeColor = Color.Navy;
            lblRotuloDataFim.Location = new Point(675, 20);
            lblRotuloDataFim.Name = "lblRotuloDataFim";
            lblRotuloDataFim.Size = new Size(61, 16);
            lblRotuloDataFim.TabIndex = 1040;
            lblRotuloDataFim.Text = "Data Fim";
            // 
            // dgvVendas
            // 
            dgvVendas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvVendas.Location = new Point(3, 153);
            dgvVendas.Name = "dgvVendas";
            dgvVendas.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            dgvVendas.RowHeadersWidth = 23;
            dgvVendas.Size = new Size(878, 260);
            dgvVendas.TabIndex = 1042;
            dgvVendas.TabStop = false;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(tlpTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(884, 62);
            pnlHeader.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            pnlHeader.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            pnlHeader.TabIndex = 1095;
            // 
            // tlpTitulo
            // 
            tlpTitulo.BackgroundImage = (Image)resources.GetObject("tlpTitulo.BackgroundImage");
            tlpTitulo.BackgroundImageLayout = ImageLayout.None;
            tlpTitulo.ColumnCount = 1;
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTitulo.Controls.Add(lblSubTitulo, 0, 1);
            tlpTitulo.Controls.Add(kryptonPanel3, 0, 0);
            tlpTitulo.Dock = DockStyle.Fill;
            tlpTitulo.Location = new Point(0, 0);
            tlpTitulo.Name = "tlpTitulo";
            tlpTitulo.RowCount = 2;
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 67.7419357F));
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 32.2580643F));
            tlpTitulo.Size = new Size(884, 62);
            tlpTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            tlpTitulo.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            tlpTitulo.TabIndex = 0;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.Dock = DockStyle.Fill;
            lblSubTitulo.Location = new Point(3, 45);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(878, 14);
            lblSubTitulo.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Color2 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblSubTitulo.TabIndex = 0;
            lblSubTitulo.Values.Text = "Controle, consulta e acompanhamento de vendas";
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(iconAcao);
            kryptonPanel3.Controls.Add(lblTitulo);
            kryptonPanel3.Dock = DockStyle.Fill;
            kryptonPanel3.Location = new Point(3, 3);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(878, 36);
            kryptonPanel3.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            kryptonPanel3.TabIndex = 1;
            // 
            // iconAcao
            // 
            iconAcao.Anchor = AnchorStyles.Top;
            iconAcao.BackColor = Color.Transparent;
            iconAcao.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            iconAcao.IconColor = Color.White;
            iconAcao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAcao.IconSize = 28;
            iconAcao.Location = new Point(305, 5);
            iconAcao.Name = "iconAcao";
            iconAcao.Size = new Size(28, 28);
            iconAcao.TabIndex = 1111;
            iconAcao.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.Location = new Point(330, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(227, 27);
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Color2 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 1091;
            lblTitulo.Values.Text = "Gerenciamento de Vendas";
            // 
            // kryptonPanel5
            // 
            kryptonPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel5.Controls.Add(btnFiltrar);
            kryptonPanel5.Controls.Add(dtpDataFim);
            kryptonPanel5.Controls.Add(dtpDataInicio);
            kryptonPanel5.Controls.Add(lblRotuloDataFim);
            kryptonPanel5.Controls.Add(lblRotuloDataInicio);
            kryptonPanel5.Controls.Add(btnLocalizar);
            kryptonPanel5.Controls.Add(kryptonLabel1);
            kryptonPanel5.Controls.Add(txtCliente);
            kryptonPanel5.Controls.Add(txtVendaID);
            kryptonPanel5.Controls.Add(lblRotuloNome);
            kryptonPanel5.Controls.Add(lblRotuloVendaID);
            kryptonPanel5.Location = new Point(3, 68);
            kryptonPanel5.Name = "kryptonPanel5";
            kryptonPanel5.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            kryptonPanel5.Size = new Size(881, 79);
            kryptonPanel5.TabIndex = 1098;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFiltrar.BackColor = Color.FromArgb(76, 175, 80);
            btnFiltrar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            btnFiltrar.IconColor = Color.White;
            btnFiltrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFiltrar.IconSize = 28;
            btnFiltrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFiltrar.Location = new Point(774, 35);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(98, 35);
            btnFiltrar.TabIndex = 1115;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dtpDataFim
            // 
            dtpDataFim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDataFim.CornerRoundingRadius = 3F;
            dtpDataFim.Format = DateTimePickerFormat.Short;
            dtpDataFim.Location = new Point(675, 39);
            dtpDataFim.Name = "dtpDataFim";
            dtpDataFim.Size = new Size(96, 29);
            dtpDataFim.StateActive.Back.Color1 = Color.FromArgb(6, 174, 244);
            dtpDataFim.StateActive.Border.Color1 = Color.FromArgb(6, 174, 244);
            dtpDataFim.StateActive.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtpDataFim.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataFim.StateActive.Border.Rounding = 3F;
            dtpDataFim.StateActive.Content.Color1 = Color.White;
            dtpDataFim.StateActive.Content.Font = new Font("Poppins", 9F);
            dtpDataFim.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataFim.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataFim.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtpDataFim.StateCommon.Border.ColorAngle = 45F;
            dtpDataFim.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataFim.StateCommon.Border.Rounding = 3F;
            dtpDataFim.StateCommon.Border.Width = 1;
            dtpDataFim.StateCommon.Content.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDataFim.StateCommon.Content.Padding = new Padding(1);
            dtpDataFim.StateDisabled.Border.ColorAngle = 45F;
            dtpDataFim.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataFim.StateDisabled.Border.Rounding = 3F;
            dtpDataFim.StateDisabled.Border.Width = 1;
            dtpDataFim.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataFim.StateNormal.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataFim.StateNormal.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtpDataFim.StateNormal.Border.ColorAngle = 45F;
            dtpDataFim.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataFim.StateNormal.Border.Rounding = 3F;
            dtpDataFim.StateNormal.Border.Width = 1;
            dtpDataFim.StateNormal.Content.Color1 = Color.White;
            dtpDataFim.TabIndex = 1114;
            // 
            // dtpDataInicio
            // 
            dtpDataInicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDataInicio.CornerRoundingRadius = 3F;
            dtpDataInicio.Format = DateTimePickerFormat.Short;
            dtpDataInicio.Location = new Point(573, 40);
            dtpDataInicio.Name = "dtpDataInicio";
            dtpDataInicio.Size = new Size(96, 29);
            dtpDataInicio.StateActive.Back.Color1 = Color.FromArgb(6, 174, 244);
            dtpDataInicio.StateActive.Border.Color1 = Color.FromArgb(6, 174, 244);
            dtpDataInicio.StateActive.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtpDataInicio.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataInicio.StateActive.Border.Rounding = 3F;
            dtpDataInicio.StateActive.Content.Color1 = Color.White;
            dtpDataInicio.StateActive.Content.Font = new Font("Poppins", 9F);
            dtpDataInicio.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataInicio.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataInicio.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtpDataInicio.StateCommon.Border.ColorAngle = 45F;
            dtpDataInicio.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataInicio.StateCommon.Border.Rounding = 3F;
            dtpDataInicio.StateCommon.Border.Width = 1;
            dtpDataInicio.StateCommon.Content.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDataInicio.StateCommon.Content.Padding = new Padding(1);
            dtpDataInicio.StateDisabled.Border.ColorAngle = 45F;
            dtpDataInicio.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataInicio.StateDisabled.Border.Rounding = 3F;
            dtpDataInicio.StateDisabled.Border.Width = 1;
            dtpDataInicio.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataInicio.StateNormal.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataInicio.StateNormal.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtpDataInicio.StateNormal.Border.ColorAngle = 45F;
            dtpDataInicio.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataInicio.StateNormal.Border.Rounding = 3F;
            dtpDataInicio.StateNormal.Border.Width = 1;
            dtpDataInicio.StateNormal.Content.Color1 = Color.White;
            dtpDataInicio.TabIndex = 1113;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLocalizar.BackColor = Color.Transparent;
            btnLocalizar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassDollar;
            btnLocalizar.IconColor = Color.FromArgb(30, 136, 229);
            btnLocalizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLocalizar.IconSize = 28;
            btnLocalizar.Location = new Point(534, 39);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(34, 32);
            btnLocalizar.TabIndex = 1112;
            btnLocalizar.UseVisualStyleBackColor = false;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Dock = DockStyle.Top;
            kryptonLabel1.Location = new Point(0, 0);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(881, 20);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 1038;
            kryptonLabel1.Values.Text = "Filtros";
            // 
            // btnVisualizar
            // 
            btnVisualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVisualizar.BackColor = Color.FromArgb(30, 136, 229);
            btnVisualizar.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnVisualizar.ForeColor = Color.White;
            btnVisualizar.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnVisualizar.IconColor = Color.White;
            btnVisualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVisualizar.IconSize = 28;
            btnVisualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVisualizar.Location = new Point(284, 498);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Padding = new Padding(10, 0, 10, 0);
            btnVisualizar.Size = new Size(120, 38);
            btnVisualizar.TabIndex = 1111;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.TextAlign = ContentAlignment.MiddleRight;
            btnVisualizar.UseVisualStyleBackColor = false;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(255, 152, 0);
            btnCancelar.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnCancelar.IconColor = Color.White;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 28;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(524, 498);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 38);
            btnCancelar.TabIndex = 1110;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExcluir.BackColor = Color.FromArgb(229, 57, 53);
            btnExcluir.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnExcluir.IconColor = Color.White;
            btnExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExcluir.IconSize = 18;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(644, 498);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(10, 0, 10, 0);
            btnExcluir.Size = new Size(120, 38);
            btnExcluir.TabIndex = 1113;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSair.BackColor = Color.Gray;
            btnSair.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnSair.ForeColor = Color.White;
            btnSair.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnSair.IconColor = Color.White;
            btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSair.IconSize = 28;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(764, 498);
            btnSair.Name = "btnSair";
            btnSair.Padding = new Padding(10, 0, 10, 0);
            btnSair.Size = new Size(120, 38);
            btnSair.TabIndex = 1114;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAlterar.BackColor = Color.FromArgb(30, 136, 229);
            btnAlterar.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnAlterar.ForeColor = Color.White;
            btnAlterar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnAlterar.IconColor = Color.White;
            btnAlterar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAlterar.IconSize = 28;
            btnAlterar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlterar.Location = new Point(404, 498);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Padding = new Padding(10, 0, 10, 0);
            btnAlterar.Size = new Size(120, 38);
            btnAlterar.TabIndex = 1115;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // FrmGerenciarVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(884, 561);
            Controls.Add(btnAlterar);
            Controls.Add(btnSair);
            Controls.Add(btnExcluir);
            Controls.Add(btnVisualizar);
            Controls.Add(btnCancelar);
            Controls.Add(kryptonPanel5);
            Controls.Add(pnlHeader);
            Controls.Add(dgvVendas);
            Controls.Add(kryptonStatusStrip1);
            Name = "FrmGerenciarVendas";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            Text = "Gerenciar Vendas";
            WindowState = FormWindowState.Maximized;
            Load += FrmGerenciarVendas_Load;
            kryptonStatusStrip1.ResumeLayout(false);
            kryptonStatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).EndInit();
            pnlHeader.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconAcao).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).EndInit();
            kryptonPanel5.ResumeLayout(false);
            kryptonPanel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        public ToolStripStatusLabel toolStripStatusLabelUsuarioCriacao;
        private ToolStripStatusLabel toolStripStatusLabel2;
        public ToolStripStatusLabel ToolStripLabelDataCriacao;
        private ToolStripStatusLabel toolStripStatusLabel4;
        public ToolStripStatusLabel ToolStripLabelDataUtimaCompra;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabelUsuarioAtualizacao;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabelDataAtualizacao;
        private ToolStripStatusLabel lblStatus;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ToolTip toolTip;
        private System.Windows.Forms.Timer Timer1;
        public Krypton.Toolkit.KryptonTextBox txtCliente;
        private Label lblRotuloNome;
        private Label lblRotuloVendaID;
        public Krypton.Toolkit.KryptonTextBox txtVendaID;        
        public Krypton.Toolkit.KryptonButton btnAlterarVenda;
        private Label lblRotuloDataInicio;
        private Label lblRotuloDataFim;
        private Krypton.Toolkit.KryptonDataGridView dgvVendas;
        public Krypton.Toolkit.KryptonButton btnCancelarVenda;
        private Krypton.Toolkit.KryptonPanel pnlHeader;
        private Krypton.Toolkit.KryptonTableLayoutPanel tlpTitulo;
        private Krypton.Toolkit.KryptonLabel lblSubTitulo;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private FontAwesome.Sharp.IconPictureBox iconAcao;
        private Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private FontAwesome.Sharp.IconButton btnLocalizar;
        public Krypton.Toolkit.KryptonDateTimePicker dtpDataFim;
        public Krypton.Toolkit.KryptonDateTimePicker dtpDataInicio;
        private FontAwesome.Sharp.IconButton btnFiltrar;
        private FontAwesome.Sharp.IconButton btnVisualizar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnExcluir;
        private FontAwesome.Sharp.IconButton btnSair;
        private FontAwesome.Sharp.IconButton btnAlterar;
    }
}