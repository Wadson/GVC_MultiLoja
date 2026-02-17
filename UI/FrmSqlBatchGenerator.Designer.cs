namespace GVC.UTIL
{
    partial class FrmSqlBatchGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSqlBatchGenerator));
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            iconAcao = new FontAwesome.Sharp.IconPictureBox();
            pnlHeader = new Krypton.Toolkit.KryptonPanel();
            tlpTitulo = new Krypton.Toolkit.KryptonTableLayoutPanel();
            lblSubTitulo = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            btnGerar = new FontAwesome.Sharp.IconButton();
            btnSelecionarOrigem = new FontAwesome.Sharp.IconButton();
            txtScriptOrigem = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloOrigem = new Label();
            label1 = new Label();
            txtScriptDestino = new Krypton.Toolkit.KryptonTextBox();
            btnSelecionarDestino = new FontAwesome.Sharp.IconButton();
            nudLote = new Krypton.Toolkit.KryptonNumericUpDown();
            lblNumLote = new Label();
            ProgressBar = new Krypton.Toolkit.KryptonProgressBar();
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblNomeTabela = new Label();
            txtNomeTabela = new Krypton.Toolkit.KryptonTextBox();
            lblColunas = new Label();
            txtColunas = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)iconAcao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).BeginInit();
            pnlHeader.SuspendLayout();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            kryptonStatusStrip1.SuspendLayout();
            SuspendLayout();
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
            // iconAcao
            // 
            iconAcao.BackColor = Color.Transparent;
            iconAcao.IconChar = FontAwesome.Sharp.IconChar.Database;
            iconAcao.IconColor = Color.White;
            iconAcao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAcao.IconSize = 28;
            iconAcao.Location = new Point(116, 3);
            iconAcao.Name = "iconAcao";
            iconAcao.Size = new Size(28, 28);
            iconAcao.TabIndex = 1110;
            iconAcao.TabStop = false;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(tlpTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(516, 51);
            pnlHeader.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            pnlHeader.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            pnlHeader.TabIndex = 1112;
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
            tlpTitulo.Size = new Size(516, 51);
            tlpTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            tlpTitulo.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            tlpTitulo.TabIndex = 0;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.Dock = DockStyle.Fill;
            lblSubTitulo.Location = new Point(3, 37);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(510, 11);
            lblSubTitulo.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Color2 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblSubTitulo.TabIndex = 0;
            lblSubTitulo.Values.Text = "Gera script sql de forma que fique em lote";
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(lblTitulo);
            kryptonPanel3.Controls.Add(iconAcao);
            kryptonPanel3.Dock = DockStyle.Fill;
            kryptonPanel3.Location = new Point(3, 3);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(510, 28);
            kryptonPanel3.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            kryptonPanel3.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(150, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(275, 27);
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Color2 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 1091;
            lblTitulo.Values.Text = "Conversor de Script Sql em Lote";
            // 
            // iconButton4
            // 
            iconButton4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            iconButton4.BackColor = Color.Gray;
            iconButton4.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 28;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(368, 385);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(10, 0, 10, 0);
            iconButton4.Size = new Size(100, 38);
            iconButton4.TabIndex = 1120;
            iconButton4.Text = "Sair";
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += iconButton4_Click;
            // 
            // btnGerar
            // 
            btnGerar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGerar.BackColor = Color.FromArgb(76, 175, 80);
            btnGerar.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnGerar.ForeColor = Color.White;
            btnGerar.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            btnGerar.IconColor = Color.White;
            btnGerar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGerar.IconSize = 28;
            btnGerar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGerar.Location = new Point(262, 385);
            btnGerar.Name = "btnGerar";
            btnGerar.Padding = new Padding(10, 0, 10, 0);
            btnGerar.Size = new Size(100, 38);
            btnGerar.TabIndex = 1139;
            btnGerar.Text = "      Gerar";
            btnGerar.UseVisualStyleBackColor = false;
            btnGerar.Click += btnGerar_Click;
            // 
            // btnSelecionarOrigem
            // 
            btnSelecionarOrigem.BackColor = Color.Transparent;
            btnSelecionarOrigem.FlatAppearance.BorderSize = 0;
            btnSelecionarOrigem.FlatStyle = FlatStyle.Flat;
            btnSelecionarOrigem.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            btnSelecionarOrigem.IconColor = Color.FromArgb(30, 136, 229);
            btnSelecionarOrigem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSelecionarOrigem.IconSize = 32;
            btnSelecionarOrigem.Location = new Point(472, 89);
            btnSelecionarOrigem.Name = "btnSelecionarOrigem";
            btnSelecionarOrigem.Size = new Size(25, 25);
            btnSelecionarOrigem.TabIndex = 1140;
            btnSelecionarOrigem.UseVisualStyleBackColor = false;
            btnSelecionarOrigem.Click += btnSelecionarOrigem_Click;
            // 
            // txtScriptOrigem
            // 
            txtScriptOrigem.Location = new Point(13, 87);
            txtScriptOrigem.Margin = new Padding(4, 3, 4, 3);
            txtScriptOrigem.Name = "txtScriptOrigem";
            txtScriptOrigem.ReadOnly = true;
            txtScriptOrigem.Size = new Size(452, 30);
            txtScriptOrigem.StateCommon.Back.Color1 = Color.White;
            txtScriptOrigem.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtScriptOrigem.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtScriptOrigem.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtScriptOrigem.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtScriptOrigem.StateCommon.Border.Rounding = 20F;
            txtScriptOrigem.StateCommon.Border.Width = 1;
            txtScriptOrigem.StateCommon.Content.Color1 = Color.Gray;
            txtScriptOrigem.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtScriptOrigem.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtScriptOrigem.TabIndex = 1141;
            // 
            // lblRotuloOrigem
            // 
            lblRotuloOrigem.AutoSize = true;
            lblRotuloOrigem.BackColor = Color.Transparent;
            lblRotuloOrigem.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloOrigem.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloOrigem.Location = new Point(13, 68);
            lblRotuloOrigem.Name = "lblRotuloOrigem";
            lblRotuloOrigem.Size = new Size(51, 16);
            lblRotuloOrigem.TabIndex = 1142;
            lblRotuloOrigem.Text = "Origem";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 9.25F);
            label1.ForeColor = Color.FromArgb(0, 76, 172);
            label1.Location = new Point(13, 125);
            label1.Name = "label1";
            label1.Size = new Size(53, 16);
            label1.TabIndex = 1145;
            label1.Text = "Destino";
            // 
            // txtScriptDestino
            // 
            txtScriptDestino.Location = new Point(13, 144);
            txtScriptDestino.Margin = new Padding(4, 3, 4, 3);
            txtScriptDestino.Name = "txtScriptDestino";
            txtScriptDestino.ReadOnly = true;
            txtScriptDestino.Size = new Size(452, 30);
            txtScriptDestino.StateCommon.Back.Color1 = Color.White;
            txtScriptDestino.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtScriptDestino.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtScriptDestino.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtScriptDestino.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtScriptDestino.StateCommon.Border.Rounding = 20F;
            txtScriptDestino.StateCommon.Border.Width = 1;
            txtScriptDestino.StateCommon.Content.Color1 = Color.Gray;
            txtScriptDestino.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtScriptDestino.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtScriptDestino.TabIndex = 1144;
            // 
            // btnSelecionarDestino
            // 
            btnSelecionarDestino.BackColor = Color.Transparent;
            btnSelecionarDestino.FlatAppearance.BorderSize = 0;
            btnSelecionarDestino.FlatStyle = FlatStyle.Flat;
            btnSelecionarDestino.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            btnSelecionarDestino.IconColor = Color.FromArgb(30, 136, 229);
            btnSelecionarDestino.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSelecionarDestino.IconSize = 32;
            btnSelecionarDestino.Location = new Point(472, 146);
            btnSelecionarDestino.Name = "btnSelecionarDestino";
            btnSelecionarDestino.Size = new Size(25, 25);
            btnSelecionarDestino.TabIndex = 1143;
            btnSelecionarDestino.UseVisualStyleBackColor = false;
            btnSelecionarDestino.Click += btnSelecionarDestino_Click;
            // 
            // nudLote
            // 
            nudLote.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudLote.Location = new Point(15, 319);
            nudLote.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            nudLote.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudLote.Name = "nudLote";
            nudLote.Size = new Size(449, 26);
            nudLote.StateActive.Back.Color1 = Color.FromArgb(30, 136, 229);
            nudLote.StateActive.Border.ColorAngle = 45F;
            nudLote.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            nudLote.StateActive.Border.Rounding = 2F;
            nudLote.StateActive.Border.Width = 1;
            nudLote.StateActive.Content.Color1 = Color.White;
            nudLote.StateCommon.Back.Color1 = Color.FromArgb(30, 136, 229);
            nudLote.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            nudLote.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            nudLote.StateCommon.Border.ColorAngle = 45F;
            nudLote.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            nudLote.StateCommon.Border.Rounding = 2F;
            nudLote.StateCommon.Border.Width = 1;
            nudLote.StateCommon.Content.Color1 = Color.White;
            nudLote.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            nudLote.StateCommon.Content.Padding = new Padding(3);
            nudLote.StateNormal.Back.Color1 = Color.FromArgb(30, 136, 229);
            nudLote.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            nudLote.StateNormal.Border.Rounding = 2F;
            nudLote.StateNormal.Border.Width = 1;
            nudLote.StateNormal.Content.Color1 = Color.White;
            nudLote.TabIndex = 1146;
            nudLote.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNumLote
            // 
            lblNumLote.AutoSize = true;
            lblNumLote.BackColor = Color.Transparent;
            lblNumLote.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblNumLote.ForeColor = Color.FromArgb(0, 76, 172);
            lblNumLote.Location = new Point(15, 300);
            lblNumLote.Name = "lblNumLote";
            lblNumLote.Size = new Size(70, 16);
            lblNumLote.TabIndex = 1147;
            lblNumLote.Text = "Nº de Lote";
            // 
            // ProgressBar
            // 
            ProgressBar.Location = new Point(16, 351);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(449, 23);
            ProgressBar.TabIndex = 1148;
            ProgressBar.UseKrypton = true;
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            kryptonStatusStrip1.Location = new Point(0, 424);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.Professional;
            kryptonStatusStrip1.Size = new Size(516, 22);
            kryptonStatusStrip1.TabIndex = 1149;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 17);
            lblStatus.Text = "Status";
            // 
            // lblNomeTabela
            // 
            lblNomeTabela.AutoSize = true;
            lblNomeTabela.BackColor = Color.Transparent;
            lblNomeTabela.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblNomeTabela.ForeColor = Color.FromArgb(0, 76, 172);
            lblNomeTabela.Location = new Point(12, 181);
            lblNomeTabela.Name = "lblNomeTabela";
            lblNomeTabela.Size = new Size(110, 16);
            lblNomeTabela.TabIndex = 1151;
            lblNomeTabela.Text = "Nome da Tabela";
            // 
            // txtNomeTabela
            // 
            txtNomeTabela.Location = new Point(12, 200);
            txtNomeTabela.Margin = new Padding(4, 3, 4, 3);
            txtNomeTabela.Name = "txtNomeTabela";
            txtNomeTabela.Size = new Size(452, 30);
            txtNomeTabela.StateCommon.Back.Color1 = Color.White;
            txtNomeTabela.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNomeTabela.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNomeTabela.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNomeTabela.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNomeTabela.StateCommon.Border.Rounding = 20F;
            txtNomeTabela.StateCommon.Border.Width = 1;
            txtNomeTabela.StateCommon.Content.Color1 = Color.Gray;
            txtNomeTabela.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtNomeTabela.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNomeTabela.TabIndex = 1150;
            // 
            // lblColunas
            // 
            lblColunas.AutoSize = true;
            lblColunas.BackColor = Color.Transparent;
            lblColunas.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblColunas.ForeColor = Color.FromArgb(0, 76, 172);
            lblColunas.Location = new Point(13, 232);
            lblColunas.Name = "lblColunas";
            lblColunas.Size = new Size(56, 16);
            lblColunas.TabIndex = 1153;
            lblColunas.Text = "Colunas";
            // 
            // txtColunas
            // 
            txtColunas.AcceptsReturn = true;
            txtColunas.Location = new Point(13, 251);
            txtColunas.Margin = new Padding(4, 3, 4, 3);
            txtColunas.Name = "txtColunas";
            txtColunas.Size = new Size(452, 30);
            txtColunas.StateCommon.Back.Color1 = Color.White;
            txtColunas.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtColunas.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtColunas.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtColunas.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtColunas.StateCommon.Border.Rounding = 20F;
            txtColunas.StateCommon.Border.Width = 1;
            txtColunas.StateCommon.Content.Color1 = Color.Gray;
            txtColunas.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtColunas.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtColunas.TabIndex = 1152;
            // 
            // FrmSqlBatchGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(516, 446);
            Controls.Add(lblColunas);
            Controls.Add(txtColunas);
            Controls.Add(lblNomeTabela);
            Controls.Add(txtNomeTabela);
            Controls.Add(kryptonStatusStrip1);
            Controls.Add(ProgressBar);
            Controls.Add(lblNumLote);
            Controls.Add(nudLote);
            Controls.Add(label1);
            Controls.Add(txtScriptDestino);
            Controls.Add(btnSelecionarDestino);
            Controls.Add(lblRotuloOrigem);
            Controls.Add(txtScriptOrigem);
            Controls.Add(btnSelecionarOrigem);
            Controls.Add(btnGerar);
            Controls.Add(iconButton4);
            Controls.Add(pnlHeader);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSqlBatchGenerator";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StateActive.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateActive.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "Converter Script";
            Load += FrmSqlBatchGenerator_Load;
            ((System.ComponentModel.ISupportInitialize)iconAcao).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).EndInit();
            pnlHeader.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            kryptonStatusStrip1.ResumeLayout(false);
            kryptonStatusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private FontAwesome.Sharp.IconPictureBox iconAcao;
        private Krypton.Toolkit.KryptonPanel pnlHeader;
        private Krypton.Toolkit.KryptonTableLayoutPanel tlpTitulo;
        private Krypton.Toolkit.KryptonLabel lblSubTitulo;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btnGerar;
        private FontAwesome.Sharp.IconButton btnSelecionarOrigem;
        public Krypton.Toolkit.KryptonTextBox txtScriptOrigem;
        private Label lblRotuloOrigem;
        private Label label1;
        public Krypton.Toolkit.KryptonTextBox txtScriptDestino;
        private FontAwesome.Sharp.IconButton btnSelecionarDestino;
        private Krypton.Toolkit.KryptonNumericUpDown nudLote;
        private Label lblNumLote;
        private Krypton.Toolkit.KryptonProgressBar ProgressBar;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        private ToolStripStatusLabel lblStatus;
        private Label lblNomeTabela;
        public Krypton.Toolkit.KryptonTextBox txtNomeTabela;
        private Label lblColunas;
        public Krypton.Toolkit.KryptonTextBox txtColunas;
    }
}