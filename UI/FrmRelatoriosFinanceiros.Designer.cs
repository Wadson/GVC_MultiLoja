namespace GVC.View
{
    partial class FrmRelatoriosFinanceiros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatoriosFinanceiros));
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            chkAgruparCliente = new CheckBox();
            rbContasReceber = new Krypton.Toolkit.KryptonRadioButton();
            rbContasPorCliente = new Krypton.Toolkit.KryptonRadioButton();
            rbExcel = new Krypton.Toolkit.KryptonRadioButton();
            rbPDF = new Krypton.Toolkit.KryptonRadioButton();
            lblCliente = new Label();
            chkAtrasadas = new CheckBox();
            chkParcialmentePago = new CheckBox();
            txtCliente = new Krypton.Toolkit.KryptonTextBox();
            chkPagas = new CheckBox();
            chkPendentes = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            dtpFim = new Krypton.Toolkit.KryptonDateTimePicker();
            dtpInicio = new Krypton.Toolkit.KryptonDateTimePicker();
            lblPeriodo = new Label();
            pnlHeader = new Krypton.Toolkit.KryptonPanel();
            tlpTitulo = new Krypton.Toolkit.KryptonTableLayoutPanel();
            lblSubTitulo = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            iconAcao = new FontAwesome.Sharp.IconPictureBox();
            panelFiltros = new Krypton.Toolkit.KryptonPanel();
            btnPesquisar = new FontAwesome.Sharp.IconButton();
            lblFiltrosDeRelatorio = new Krypton.Toolkit.KryptonLabel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panelTipoRelatorio = new Krypton.Toolkit.KryptonPanel();
            lblTipoRelatorio = new Krypton.Toolkit.KryptonLabel();
            panelFormato = new Krypton.Toolkit.KryptonPanel();
            lblFonteSaida = new Krypton.Toolkit.KryptonLabel();
            btnGerar = new FontAwesome.Sharp.IconButton();
            btnLimpar = new FontAwesome.Sharp.IconButton();
            btnSair = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).BeginInit();
            pnlHeader.SuspendLayout();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconAcao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelFiltros).BeginInit();
            panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelTipoRelatorio).BeginInit();
            panelTipoRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelFormato).BeginInit();
            panelFormato.SuspendLayout();
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
            // chkAgruparCliente
            // 
            chkAgruparCliente.AutoSize = true;
            chkAgruparCliente.ForeColor = Color.FromArgb(0, 76, 172);
            chkAgruparCliente.Location = new Point(94, 59);
            chkAgruparCliente.Name = "chkAgruparCliente";
            chkAgruparCliente.Size = new Size(144, 19);
            chkAgruparCliente.TabIndex = 1097;
            chkAgruparCliente.Text = "Agrupado por Clientte";
            chkAgruparCliente.UseVisualStyleBackColor = true;
            // 
            // rbContasReceber
            // 
            rbContasReceber.Location = new Point(74, 33);
            rbContasReceber.Name = "rbContasReceber";
            rbContasReceber.Size = new Size(117, 20);
            rbContasReceber.StateCommon.ShortText.Color1 = Color.FromArgb(0, 76, 172);
            rbContasReceber.StateCommon.ShortText.Color2 = Color.FromArgb(0, 76, 172);
            rbContasReceber.TabIndex = 1;
            rbContasReceber.Values.Text = "Contas a Receber";
            // 
            // rbContasPorCliente
            // 
            rbContasPorCliente.Location = new Point(74, 84);
            rbContasPorCliente.Name = "rbContasPorCliente";
            rbContasPorCliente.Size = new Size(123, 20);
            rbContasPorCliente.StateCommon.ShortText.Color1 = Color.FromArgb(0, 76, 172);
            rbContasPorCliente.StateCommon.ShortText.Color2 = Color.FromArgb(0, 76, 172);
            rbContasPorCliente.TabIndex = 0;
            rbContasPorCliente.Values.Text = "Contas por Cliente";
            // 
            // rbExcel
            // 
            rbExcel.Location = new Point(105, 57);
            rbExcel.Name = "rbExcel";
            rbExcel.Size = new Size(56, 20);
            rbExcel.StateCommon.ShortText.Color1 = Color.FromArgb(0, 76, 172);
            rbExcel.StateCommon.ShortText.Color2 = Color.FromArgb(0, 76, 172);
            rbExcel.TabIndex = 2;
            rbExcel.Values.Text = "EXCEL";
            // 
            // rbPDF
            // 
            rbPDF.Checked = true;
            rbPDF.Location = new Point(105, 30);
            rbPDF.Name = "rbPDF";
            rbPDF.Size = new Size(44, 20);
            rbPDF.StateCommon.ShortText.Color1 = Color.FromArgb(0, 76, 172);
            rbPDF.StateCommon.ShortText.Color2 = Color.FromArgb(0, 76, 172);
            rbPDF.TabIndex = 1;
            rbPDF.Values.Text = "PDF";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblCliente.ForeColor = Color.FromArgb(0, 76, 172);
            lblCliente.Location = new Point(14, 42);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(51, 16);
            lblCliente.TabIndex = 1084;
            lblCliente.Text = "Cliente:";
            // 
            // chkAtrasadas
            // 
            chkAtrasadas.AutoSize = true;
            chkAtrasadas.ForeColor = Color.FromArgb(0, 76, 172);
            chkAtrasadas.Location = new Point(71, 169);
            chkAtrasadas.Name = "chkAtrasadas";
            chkAtrasadas.Size = new Size(77, 19);
            chkAtrasadas.TabIndex = 1097;
            chkAtrasadas.Text = "Atrasadas";
            chkAtrasadas.UseVisualStyleBackColor = true;
            // 
            // chkParcialmentePago
            // 
            chkParcialmentePago.AutoSize = true;
            chkParcialmentePago.ForeColor = Color.FromArgb(0, 76, 172);
            chkParcialmentePago.Location = new Point(71, 152);
            chkParcialmentePago.Name = "chkParcialmentePago";
            chkParcialmentePago.Size = new Size(125, 19);
            chkParcialmentePago.TabIndex = 1100;
            chkParcialmentePago.Text = "Parcialmente Pago";
            chkParcialmentePago.UseVisualStyleBackColor = true;
            // 
            // txtCliente
            // 
            txtCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCliente.CharacterCasing = CharacterCasing.Upper;
            txtCliente.Location = new Point(75, 39);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(525, 27);
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
            txtCliente.TabIndex = 1099;
            txtCliente.TextChanged += txtCliente_TextChanged;
            // 
            // chkPagas
            // 
            chkPagas.AutoSize = true;
            chkPagas.ForeColor = Color.FromArgb(0, 76, 172);
            chkPagas.Location = new Point(71, 130);
            chkPagas.Name = "chkPagas";
            chkPagas.Size = new Size(57, 19);
            chkPagas.TabIndex = 1098;
            chkPagas.Text = "Pagas";
            chkPagas.UseVisualStyleBackColor = true;
            // 
            // chkPendentes
            // 
            chkPendentes.AutoSize = true;
            chkPendentes.ForeColor = Color.FromArgb(0, 76, 172);
            chkPendentes.Location = new Point(71, 108);
            chkPendentes.Name = "chkPendentes";
            chkPendentes.Size = new Size(81, 19);
            chkPendentes.TabIndex = 1096;
            chkPendentes.Text = "Pendentes";
            chkPendentes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.25F);
            label3.ForeColor = Color.FromArgb(0, 76, 172);
            label3.Location = new Point(18, 106);
            label3.Name = "label3";
            label3.Size = new Size(47, 16);
            label3.TabIndex = 1094;
            label3.Text = "Status:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.25F);
            label2.ForeColor = Color.FromArgb(0, 76, 172);
            label2.Location = new Point(239, 79);
            label2.Name = "label2";
            label2.Size = new Size(27, 16);
            label2.TabIndex = 1090;
            label2.Text = "Até";
            // 
            // dtpFim
            // 
            dtpFim.CornerRoundingRadius = 6F;
            dtpFim.Format = DateTimePickerFormat.Short;
            dtpFim.Location = new Point(271, 71);
            dtpFim.Name = "dtpFim";
            dtpFim.Size = new Size(160, 31);
            dtpFim.StateActive.Back.Color1 = Color.FromArgb(6, 174, 244);
            dtpFim.StateActive.Border.Color1 = Color.FromArgb(6, 174, 244);
            dtpFim.StateActive.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtpFim.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpFim.StateActive.Border.Rounding = 6F;
            dtpFim.StateActive.Content.Color1 = Color.White;
            dtpFim.StateActive.Content.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFim.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtpFim.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpFim.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtpFim.StateCommon.Border.ColorAngle = 45F;
            dtpFim.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpFim.StateCommon.Border.Rounding = 6F;
            dtpFim.StateCommon.Border.Width = 1;
            dtpFim.StateCommon.Content.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFim.StateCommon.Content.Padding = new Padding(1);
            dtpFim.StateDisabled.Border.ColorAngle = 45F;
            dtpFim.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpFim.StateDisabled.Border.Rounding = 6F;
            dtpFim.StateDisabled.Border.Width = 1;
            dtpFim.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtpFim.StateNormal.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpFim.StateNormal.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtpFim.StateNormal.Border.ColorAngle = 45F;
            dtpFim.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpFim.StateNormal.Border.Rounding = 6F;
            dtpFim.StateNormal.Border.Width = 1;
            dtpFim.StateNormal.Content.Color1 = Color.White;
            dtpFim.TabIndex = 1089;
            // 
            // dtpInicio
            // 
            dtpInicio.CornerRoundingRadius = 6F;
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(74, 71);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(160, 31);
            dtpInicio.StateActive.Back.Color1 = Color.FromArgb(6, 174, 244);
            dtpInicio.StateActive.Border.Color1 = Color.FromArgb(6, 174, 244);
            dtpInicio.StateActive.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtpInicio.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpInicio.StateActive.Border.Rounding = 6F;
            dtpInicio.StateActive.Content.Color1 = Color.White;
            dtpInicio.StateActive.Content.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpInicio.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtpInicio.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpInicio.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtpInicio.StateCommon.Border.ColorAngle = 45F;
            dtpInicio.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpInicio.StateCommon.Border.Rounding = 6F;
            dtpInicio.StateCommon.Border.Width = 1;
            dtpInicio.StateCommon.Content.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpInicio.StateCommon.Content.Padding = new Padding(1);
            dtpInicio.StateDisabled.Border.ColorAngle = 45F;
            dtpInicio.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpInicio.StateDisabled.Border.Rounding = 6F;
            dtpInicio.StateDisabled.Border.Width = 1;
            dtpInicio.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtpInicio.StateNormal.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpInicio.StateNormal.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtpInicio.StateNormal.Border.ColorAngle = 45F;
            dtpInicio.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpInicio.StateNormal.Border.Rounding = 6F;
            dtpInicio.StateNormal.Border.Width = 1;
            dtpInicio.StateNormal.Content.Color1 = Color.White;
            dtpInicio.TabIndex = 1088;
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblPeriodo.ForeColor = Color.FromArgb(0, 76, 172);
            lblPeriodo.Location = new Point(7, 79);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(58, 16);
            lblPeriodo.TabIndex = 1087;
            lblPeriodo.Text = "Período:";
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(tlpTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(672, 62);
            pnlHeader.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            pnlHeader.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            pnlHeader.TabIndex = 1114;
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
            tlpTitulo.Size = new Size(672, 62);
            tlpTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            tlpTitulo.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            tlpTitulo.TabIndex = 0;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.Dock = DockStyle.Fill;
            lblSubTitulo.Location = new Point(3, 45);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(666, 14);
            lblSubTitulo.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Color2 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblSubTitulo.TabIndex = 0;
            lblSubTitulo.Values.Text = "Relatorio financeiro de contas a receber";
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(lblTitulo);
            kryptonPanel3.Controls.Add(iconAcao);
            kryptonPanel3.Dock = DockStyle.Fill;
            kryptonPanel3.Location = new Point(3, 3);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(666, 36);
            kryptonPanel3.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            kryptonPanel3.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(246, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(178, 27);
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Color2 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 1091;
            lblTitulo.Values.Text = "Relatório Financeiro";
            // 
            // iconAcao
            // 
            iconAcao.BackColor = Color.Transparent;
            iconAcao.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            iconAcao.IconColor = Color.White;
            iconAcao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAcao.IconSize = 28;
            iconAcao.Location = new Point(216, 5);
            iconAcao.Name = "iconAcao";
            iconAcao.Size = new Size(28, 28);
            iconAcao.TabIndex = 1110;
            iconAcao.TabStop = false;
            // 
            // panelFiltros
            // 
            panelFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFiltros.Controls.Add(chkAtrasadas);
            panelFiltros.Controls.Add(btnPesquisar);
            panelFiltros.Controls.Add(chkParcialmentePago);
            panelFiltros.Controls.Add(txtCliente);
            panelFiltros.Controls.Add(chkPagas);
            panelFiltros.Controls.Add(lblFiltrosDeRelatorio);
            panelFiltros.Controls.Add(chkPendentes);
            panelFiltros.Controls.Add(label3);
            panelFiltros.Controls.Add(lblCliente);
            panelFiltros.Controls.Add(label2);
            panelFiltros.Controls.Add(lblPeriodo);
            panelFiltros.Controls.Add(dtpFim);
            panelFiltros.Controls.Add(dtpInicio);
            panelFiltros.Location = new Point(8, 84);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            panelFiltros.Size = new Size(652, 195);
            panelFiltros.TabIndex = 1134;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Transparent;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnPesquisar.IconColor = Color.FromArgb(30, 136, 229);
            btnPesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPesquisar.IconSize = 32;
            btnPesquisar.Location = new Point(605, 40);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(25, 25);
            btnPesquisar.TabIndex = 1117;
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // lblFiltrosDeRelatorio
            // 
            lblFiltrosDeRelatorio.Dock = DockStyle.Top;
            lblFiltrosDeRelatorio.Location = new Point(0, 0);
            lblFiltrosDeRelatorio.Name = "lblFiltrosDeRelatorio";
            lblFiltrosDeRelatorio.Size = new Size(652, 20);
            lblFiltrosDeRelatorio.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltrosDeRelatorio.TabIndex = 1038;
            lblFiltrosDeRelatorio.Values.Text = "Filtros de Relatório";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Transparent;
            iconPictureBox2.ForeColor = Color.Green;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            iconPictureBox2.IconColor = Color.Green;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 28;
            iconPictureBox2.Location = new Point(67, 53);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(28, 28);
            iconPictureBox2.TabIndex = 1112;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = Color.FromArgb(30, 136, 229);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            iconPictureBox1.IconColor = Color.FromArgb(30, 136, 229);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 28;
            iconPictureBox1.Location = new Point(67, 26);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(28, 28);
            iconPictureBox1.TabIndex = 1111;
            iconPictureBox1.TabStop = false;
            // 
            // panelTipoRelatorio
            // 
            panelTipoRelatorio.Controls.Add(chkAgruparCliente);
            panelTipoRelatorio.Controls.Add(rbContasReceber);
            panelTipoRelatorio.Controls.Add(rbContasPorCliente);
            panelTipoRelatorio.Controls.Add(lblTipoRelatorio);
            panelTipoRelatorio.Location = new Point(8, 285);
            panelTipoRelatorio.Name = "panelTipoRelatorio";
            panelTipoRelatorio.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            panelTipoRelatorio.Size = new Size(652, 117);
            panelTipoRelatorio.TabIndex = 1135;
            // 
            // lblTipoRelatorio
            // 
            lblTipoRelatorio.Dock = DockStyle.Top;
            lblTipoRelatorio.Location = new Point(0, 0);
            lblTipoRelatorio.Name = "lblTipoRelatorio";
            lblTipoRelatorio.Size = new Size(652, 20);
            lblTipoRelatorio.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoRelatorio.TabIndex = 1038;
            lblTipoRelatorio.Values.Text = "Tipo de Relatório";
            // 
            // panelFormato
            // 
            panelFormato.Controls.Add(rbExcel);
            panelFormato.Controls.Add(rbPDF);
            panelFormato.Controls.Add(iconPictureBox2);
            panelFormato.Controls.Add(lblFonteSaida);
            panelFormato.Controls.Add(iconPictureBox1);
            panelFormato.Location = new Point(12, 408);
            panelFormato.Name = "panelFormato";
            panelFormato.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            panelFormato.Size = new Size(648, 89);
            panelFormato.TabIndex = 1136;
            // 
            // lblFonteSaida
            // 
            lblFonteSaida.Dock = DockStyle.Top;
            lblFonteSaida.Location = new Point(0, 0);
            lblFonteSaida.Name = "lblFonteSaida";
            lblFonteSaida.Size = new Size(648, 20);
            lblFonteSaida.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFonteSaida.TabIndex = 1038;
            lblFonteSaida.Values.Text = "Fonte de Saída";
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
            btnGerar.Location = new Point(294, 511);
            btnGerar.Name = "btnGerar";
            btnGerar.Padding = new Padding(10, 0, 10, 0);
            btnGerar.Size = new Size(120, 38);
            btnGerar.TabIndex = 1138;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = false;
            btnGerar.Click += btnGerar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLimpar.BackColor = Color.White;
            btnLimpar.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.FromArgb(30, 136, 229);
            btnLimpar.IconChar = FontAwesome.Sharp.IconChar.FilterCircleXmark;
            btnLimpar.IconColor = Color.FromArgb(30, 136, 229);
            btnLimpar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpar.IconSize = 28;
            btnLimpar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpar.Location = new Point(420, 511);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Padding = new Padding(10, 0, 10, 0);
            btnLimpar.Size = new Size(120, 38);
            btnLimpar.TabIndex = 1139;
            btnLimpar.Text = " Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
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
            btnSair.Location = new Point(540, 511);
            btnSair.Name = "btnSair";
            btnSair.Padding = new Padding(10, 0, 10, 0);
            btnSair.Size = new Size(120, 38);
            btnSair.TabIndex = 1140;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // FrmRelatoriosFinanceiros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(672, 561);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(btnGerar);
            Controls.Add(panelFormato);
            Controls.Add(panelTipoRelatorio);
            Controls.Add(panelFiltros);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRelatoriosFinanceiros";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatórios Financeiros";
            Load += FrmRelatoriosFinanceiros_Load;
            ((System.ComponentModel.ISupportInitialize)pnlHeader).EndInit();
            pnlHeader.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconAcao).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelFiltros).EndInit();
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelTipoRelatorio).EndInit();
            panelTipoRelatorio.ResumeLayout(false);
            panelTipoRelatorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelFormato).EndInit();
            panelFormato.ResumeLayout(false);
            panelFormato.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonRadioButton rbContasReceber;
        private Krypton.Toolkit.KryptonRadioButton rbContasPorCliente;
        private Krypton.Toolkit.KryptonRadioButton rbExcel;
        private Krypton.Toolkit.KryptonRadioButton rbPDF;
        private Label lblCliente;
        private Label lblPeriodo;
        private Label label3;
        private Label label2;
        public Krypton.Toolkit.KryptonDateTimePicker dtpFim;
        public Krypton.Toolkit.KryptonDateTimePicker dtpInicio;
        private CheckBox chkPagas;
        private CheckBox chkAtrasadas;
        private CheckBox chkPendentes;
        public Krypton.Toolkit.KryptonTextBox txtCliente;
        private CheckBox chkAgruparCliente;
        private CheckBox chkParcialmentePago;
        private Krypton.Toolkit.KryptonPanel pnlHeader;
        private Krypton.Toolkit.KryptonTableLayoutPanel tlpTitulo;
        private Krypton.Toolkit.KryptonLabel lblSubTitulo;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private FontAwesome.Sharp.IconPictureBox iconAcao;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Krypton.Toolkit.KryptonPanel panelFiltros;
        private Krypton.Toolkit.KryptonLabel lblFiltrosDeRelatorio;
        private FontAwesome.Sharp.IconButton btnPesquisar;
        private Krypton.Toolkit.KryptonPanel panelTipoRelatorio;
        private Krypton.Toolkit.KryptonLabel lblTipoRelatorio;
        private Krypton.Toolkit.KryptonPanel panelFormato;
        private Krypton.Toolkit.KryptonLabel lblFonteSaida;
        private FontAwesome.Sharp.IconButton btnGerar;
        private FontAwesome.Sharp.IconButton btnLimpar;
        private FontAwesome.Sharp.IconButton btnSair;
    }
}