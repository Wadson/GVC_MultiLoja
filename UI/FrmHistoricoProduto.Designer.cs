namespace GVC.UTIL
{
    partial class FrmHistoricoProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistoricoProduto));
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            dtInicial = new Krypton.Toolkit.KryptonDateTimePicker();
            iconAcao = new FontAwesome.Sharp.IconPictureBox();
            pnlHeader = new Krypton.Toolkit.KryptonPanel();
            tlpTitulo = new Krypton.Toolkit.KryptonTableLayoutPanel();
            lblSubTitulo = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            btnPesquisar = new FontAwesome.Sharp.IconButton();
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            dgvHistorico = new Krypton.Toolkit.KryptonDataGridView();
            dtFinal = new Krypton.Toolkit.KryptonDateTimePicker();
            txtProduto = new Krypton.Toolkit.KryptonTextBox();
            lblProduto = new Label();
            lblTipoEntrada = new Label();
            cmbTipoMovimentacao = new Krypton.Toolkit.KryptonComboBox();
            label1 = new Label();
            label2 = new Label();
            btnSair = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconAcao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).BeginInit();
            pnlHeader.SuspendLayout();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbTipoMovimentacao).BeginInit();
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
            // dtInicial
            // 
            dtInicial.CornerRoundingRadius = 3F;
            dtInicial.Format = DateTimePickerFormat.Short;
            dtInicial.Location = new Point(9, 141);
            dtInicial.Name = "dtInicial";
            dtInicial.Size = new Size(113, 29);
            dtInicial.StateActive.Back.Color1 = Color.FromArgb(6, 174, 244);
            dtInicial.StateActive.Border.Color1 = Color.FromArgb(6, 174, 244);
            dtInicial.StateActive.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtInicial.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtInicial.StateActive.Border.Rounding = 3F;
            dtInicial.StateActive.Content.Color1 = Color.White;
            dtInicial.StateActive.Content.Font = new Font("Poppins", 9F);
            dtInicial.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtInicial.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtInicial.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtInicial.StateCommon.Border.ColorAngle = 45F;
            dtInicial.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtInicial.StateCommon.Border.Rounding = 3F;
            dtInicial.StateCommon.Border.Width = 1;
            dtInicial.StateCommon.Content.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtInicial.StateCommon.Content.Padding = new Padding(1);
            dtInicial.StateDisabled.Border.ColorAngle = 45F;
            dtInicial.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtInicial.StateDisabled.Border.Rounding = 3F;
            dtInicial.StateDisabled.Border.Width = 1;
            dtInicial.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtInicial.StateNormal.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtInicial.StateNormal.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtInicial.StateNormal.Border.ColorAngle = 45F;
            dtInicial.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtInicial.StateNormal.Border.Rounding = 3F;
            dtInicial.StateNormal.Border.Width = 1;
            dtInicial.StateNormal.Content.Color1 = Color.White;
            dtInicial.TabIndex = 1098;
            // 
            // iconAcao
            // 
            iconAcao.Anchor = AnchorStyles.Top;
            iconAcao.BackColor = Color.Transparent;
            iconAcao.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            iconAcao.IconColor = Color.White;
            iconAcao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAcao.IconSize = 48;
            iconAcao.Location = new Point(422, -2);
            iconAcao.Name = "iconAcao";
            iconAcao.Size = new Size(48, 48);
            iconAcao.TabIndex = 1110;
            iconAcao.TabStop = false;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(tlpTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1093, 62);
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
            tlpTitulo.Size = new Size(1093, 62);
            tlpTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            tlpTitulo.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            tlpTitulo.TabIndex = 0;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.Dock = DockStyle.Fill;
            lblSubTitulo.Location = new Point(3, 45);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(1087, 14);
            lblSubTitulo.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Color2 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 12F);
            lblSubTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblSubTitulo.TabIndex = 0;
            lblSubTitulo.Values.Text = "Visualize compras anteriores, preços praticados e evolução do produto ao longo do tempo.";
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(lblTitulo);
            kryptonPanel3.Controls.Add(iconAcao);
            kryptonPanel3.Dock = DockStyle.Fill;
            kryptonPanel3.Location = new Point(3, 3);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(1087, 36);
            kryptonPanel3.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            kryptonPanel3.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.Location = new Point(474, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(185, 27);
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Color2 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 1091;
            lblTitulo.Values.Text = "Histórico do Produto";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.White;
            btnPesquisar.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnPesquisar.ForeColor = Color.FromArgb(30, 136, 229);
            btnPesquisar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnPesquisar.IconColor = Color.FromArgb(30, 136, 229);
            btnPesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPesquisar.IconSize = 26;
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.Location = new Point(397, 141);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Padding = new Padding(10, 0, 10, 0);
            btnPesquisar.Size = new Size(132, 30);
            btnPesquisar.TabIndex = 1122;
            btnPesquisar.Text = "     Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Location = new Point(0, 478);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            kryptonStatusStrip1.Size = new Size(1093, 22);
            kryptonStatusStrip1.TabIndex = 1142;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // dgvHistorico
            // 
            dgvHistorico.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvHistorico.Location = new Point(3, 192);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.Size = new Size(1077, 232);
            dgvHistorico.TabIndex = 1143;
            // 
            // dtFinal
            // 
            dtFinal.CornerRoundingRadius = 3F;
            dtFinal.Format = DateTimePickerFormat.Short;
            dtFinal.Location = new Point(128, 141);
            dtFinal.Name = "dtFinal";
            dtFinal.Size = new Size(113, 29);
            dtFinal.StateActive.Back.Color1 = Color.FromArgb(6, 174, 244);
            dtFinal.StateActive.Border.Color1 = Color.FromArgb(6, 174, 244);
            dtFinal.StateActive.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtFinal.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtFinal.StateActive.Border.Rounding = 3F;
            dtFinal.StateActive.Content.Color1 = Color.White;
            dtFinal.StateActive.Content.Font = new Font("Poppins", 9F);
            dtFinal.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtFinal.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtFinal.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtFinal.StateCommon.Border.ColorAngle = 45F;
            dtFinal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtFinal.StateCommon.Border.Rounding = 3F;
            dtFinal.StateCommon.Border.Width = 1;
            dtFinal.StateCommon.Content.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtFinal.StateCommon.Content.Padding = new Padding(1);
            dtFinal.StateDisabled.Border.ColorAngle = 45F;
            dtFinal.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtFinal.StateDisabled.Border.Rounding = 3F;
            dtFinal.StateDisabled.Border.Width = 1;
            dtFinal.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtFinal.StateNormal.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtFinal.StateNormal.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtFinal.StateNormal.Border.ColorAngle = 45F;
            dtFinal.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtFinal.StateNormal.Border.Rounding = 3F;
            dtFinal.StateNormal.Border.Width = 1;
            dtFinal.StateNormal.Content.Color1 = Color.White;
            dtFinal.TabIndex = 1144;
            // 
            // txtProduto
            // 
            txtProduto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProduto.CharacterCasing = CharacterCasing.Upper;
            txtProduto.Location = new Point(10, 92);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(1063, 24);
            txtProduto.StateCommon.Back.Color1 = Color.White;
            txtProduto.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtProduto.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtProduto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtProduto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtProduto.StateCommon.Border.Rounding = 8F;
            txtProduto.StateCommon.Border.Width = 1;
            txtProduto.StateCommon.Content.Color1 = Color.Gray;
            txtProduto.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtProduto.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtProduto.TabIndex = 1145;
            txtProduto.TextChanged += txtProduto_TextChanged;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.BackColor = Color.Transparent;
            lblProduto.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblProduto.ForeColor = Color.FromArgb(0, 76, 172);
            lblProduto.Location = new Point(10, 74);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(54, 16);
            lblProduto.TabIndex = 1146;
            lblProduto.Text = "Produto";
            // 
            // lblTipoEntrada
            // 
            lblTipoEntrada.AutoSize = true;
            lblTipoEntrada.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblTipoEntrada.ForeColor = Color.FromArgb(0, 76, 172);
            lblTipoEntrada.Location = new Point(251, 122);
            lblTipoEntrada.Name = "lblTipoEntrada";
            lblTipoEntrada.Size = new Size(104, 16);
            lblTipoEntrada.TabIndex = 1150;
            lblTipoEntrada.Text = "Tipo de Entrada";
            // 
            // cmbTipoMovimentacao
            // 
            cmbTipoMovimentacao.CornerRoundingRadius = 6F;
            cmbTipoMovimentacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMovimentacao.DropDownWidth = 115;
            cmbTipoMovimentacao.IntegralHeight = false;
            cmbTipoMovimentacao.Items.AddRange(new object[] { "Entrada", "Transferência", "Devolução" });
            cmbTipoMovimentacao.Location = new Point(251, 144);
            cmbTipoMovimentacao.Name = "cmbTipoMovimentacao";
            cmbTipoMovimentacao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbTipoMovimentacao.Size = new Size(140, 25);
            cmbTipoMovimentacao.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoMovimentacao.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbTipoMovimentacao.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbTipoMovimentacao.TabIndex = 1148;
            cmbTipoMovimentacao.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.25F);
            label1.ForeColor = Color.FromArgb(0, 76, 172);
            label1.Location = new Point(22, 122);
            label1.Name = "label1";
            label1.Size = new Size(73, 16);
            label1.TabIndex = 1151;
            label1.Text = "Data Inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.25F);
            label2.ForeColor = Color.FromArgb(0, 76, 172);
            label2.Location = new Point(144, 122);
            label2.Name = "label2";
            label2.Size = new Size(68, 16);
            label2.TabIndex = 1152;
            label2.Text = "Data Final";
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSair.BackColor = Color.Gray;
            btnSair.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnSair.ForeColor = Color.White;
            btnSair.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnSair.IconColor = Color.White;
            btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSair.IconSize = 26;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(948, 430);
            btnSair.Name = "btnSair";
            btnSair.Padding = new Padding(10, 0, 10, 0);
            btnSair.Size = new Size(132, 36);
            btnSair.TabIndex = 1153;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // FrmHistoricoProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(1093, 500);
            Controls.Add(btnSair);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTipoEntrada);
            Controls.Add(cmbTipoMovimentacao);
            Controls.Add(txtProduto);
            Controls.Add(lblProduto);
            Controls.Add(dtFinal);
            Controls.Add(dgvHistorico);
            Controls.Add(kryptonStatusStrip1);
            Controls.Add(btnPesquisar);
            Controls.Add(pnlHeader);
            Controls.Add(dtInicial);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmHistoricoProduto";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StateActive.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateActive.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "Histórico do Produto";
            WindowState = FormWindowState.Maximized;
            Load += FrmHistoricoProduto_Load;
            Shown += FrmHistoricoProduto_Shown;
            KeyDown += FrmHistoricoProduto_KeyDown;
            ((System.ComponentModel.ISupportInitialize)iconAcao).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).EndInit();
            pnlHeader.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbTipoMovimentacao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public Krypton.Toolkit.KryptonDateTimePicker dtInicial;
       
        private FontAwesome.Sharp.IconPictureBox iconAcao;
        private Krypton.Toolkit.KryptonPanel pnlHeader;
        private Krypton.Toolkit.KryptonTableLayoutPanel tlpTitulo;
        private Krypton.Toolkit.KryptonLabel lblSubTitulo;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton7;      
        private FontAwesome.Sharp.IconButton btnConfirmar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton iconButton9;
        private FontAwesome.Sharp.IconButton btnPesquisar;
       
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        private Krypton.Toolkit.KryptonDataGridView dgvHistorico;
        public Krypton.Toolkit.KryptonDateTimePicker dtFinal;
        public Krypton.Toolkit.KryptonTextBox txtProduto;
        private Label lblProduto;
        private Label lblTipoEntrada;
        public Krypton.Toolkit.KryptonComboBox cmbTipoMovimentacao;
        private Label lblTipoDocumento;
        
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnSair;
    }
}