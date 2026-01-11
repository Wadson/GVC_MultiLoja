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
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            btnGerar = new Krypton.Toolkit.KryptonButton();
            btnSair = new Krypton.Toolkit.KryptonButton();
            grbTipoRelatorio = new GroupBox();
            chkAgruparCliente = new CheckBox();
            rbContasReceber = new Krypton.Toolkit.KryptonRadioButton();
            rbContasPorCliente = new Krypton.Toolkit.KryptonRadioButton();
            grpFormato = new GroupBox();
            rbExcel = new Krypton.Toolkit.KryptonRadioButton();
            rbPDF = new Krypton.Toolkit.KryptonRadioButton();
            lblCliente = new Label();
            btnPesquisarCliente = new Krypton.Toolkit.KryptonButton();
            grpFiltros = new GroupBox();
            txtCliente = new Krypton.Toolkit.KryptonTextBox();
            chkPagas = new CheckBox();
            chkAtrasadas = new CheckBox();
            chkPendentes = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            dtpFim = new Krypton.Toolkit.KryptonDateTimePicker();
            dtpInicio = new Krypton.Toolkit.KryptonDateTimePicker();
            lblPeriodo = new Label();
            btnLimpar = new Krypton.Toolkit.KryptonButton();
            grbTipoRelatorio.SuspendLayout();
            grpFormato.SuspendLayout();
            grpFiltros.SuspendLayout();
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
            // btnGerar
            // 
            btnGerar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGerar.CornerRoundingRadius = 20F;
            btnGerar.Location = new Point(335, 481);
            btnGerar.Name = "btnGerar";
            btnGerar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnGerar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnGerar.OverrideDefault.Back.ColorAngle = 45F;
            btnGerar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnGerar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnGerar.OverrideDefault.Border.ColorAngle = 45F;
            btnGerar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerar.OverrideDefault.Border.Rounding = 20F;
            btnGerar.OverrideDefault.Border.Width = 1;
            btnGerar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnGerar.Size = new Size(100, 30);
            btnGerar.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnGerar.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnGerar.StateCommon.Back.ColorAngle = 45F;
            btnGerar.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnGerar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnGerar.StateCommon.Border.ColorAngle = 45F;
            btnGerar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerar.StateCommon.Border.Rounding = 20F;
            btnGerar.StateCommon.Border.Width = 1;
            btnGerar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnGerar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnGerar.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            btnGerar.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnGerar.StateNormal.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnGerar.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerar.StateNormal.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnGerar.StateNormal.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnGerar.StateNormal.Border.ColorAngle = 45F;
            btnGerar.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerar.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerar.StateNormal.Border.Rounding = 20F;
            btnGerar.StateNormal.Border.Width = 1;
            btnGerar.StatePressed.Back.Color1 = Color.White;
            btnGerar.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnGerar.StatePressed.Back.ColorAngle = 135F;
            btnGerar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnGerar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnGerar.StatePressed.Border.ColorAngle = 135F;
            btnGerar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerar.StatePressed.Border.Rounding = 20F;
            btnGerar.StatePressed.Border.Width = 1;
            btnGerar.StatePressed.Content.ShortText.Color1 = Color.FromArgb(22, 121, 206);
            btnGerar.StateTracking.Back.Color1 = Color.White;
            btnGerar.StateTracking.Back.Color2 = Color.White;
            btnGerar.StateTracking.Back.ColorAngle = 45F;
            btnGerar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnGerar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnGerar.StateTracking.Border.ColorAngle = 45F;
            btnGerar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerar.StateTracking.Border.Rounding = 20F;
            btnGerar.StateTracking.Border.Width = 1;
            btnGerar.StateTracking.Content.ShortText.Color1 = Color.FromArgb(22, 121, 206);
            btnGerar.TabIndex = 14;
            btnGerar.Values.Text = "Gerar Relatório";
            btnGerar.Click += btnGerar_Click;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSair.CornerRoundingRadius = 20F;
            btnSair.Location = new Point(535, 481);
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
            btnSair.TabIndex = 13;
            btnSair.Values.Text = "Sair";
            btnSair.Click += btnSair_Click;
            // 
            // grbTipoRelatorio
            // 
            grbTipoRelatorio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grbTipoRelatorio.Controls.Add(chkAgruparCliente);
            grbTipoRelatorio.Controls.Add(rbContasReceber);
            grbTipoRelatorio.Controls.Add(rbContasPorCliente);
            grbTipoRelatorio.Location = new Point(3, 237);
            grbTipoRelatorio.Name = "grbTipoRelatorio";
            grbTipoRelatorio.Size = new Size(636, 110);
            grbTipoRelatorio.TabIndex = 15;
            grbTipoRelatorio.TabStop = false;
            grbTipoRelatorio.Text = "Tipo de Relatório";
            // 
            // chkAgruparCliente
            // 
            chkAgruparCliente.AutoSize = true;
            chkAgruparCliente.ForeColor = Color.FromArgb(0, 76, 172);
            chkAgruparCliente.Location = new Point(92, 48);
            chkAgruparCliente.Name = "chkAgruparCliente";
            chkAgruparCliente.Size = new Size(144, 19);
            chkAgruparCliente.TabIndex = 1097;
            chkAgruparCliente.Text = "Agrupado por Clientte";
            chkAgruparCliente.UseVisualStyleBackColor = true;
            // 
            // rbContasReceber
            // 
            rbContasReceber.Location = new Point(72, 22);
            rbContasReceber.Name = "rbContasReceber";
            rbContasReceber.Size = new Size(117, 20);
            rbContasReceber.StateCommon.ShortText.Color1 = Color.FromArgb(0, 76, 172);
            rbContasReceber.StateCommon.ShortText.Color2 = Color.FromArgb(0, 76, 172);
            rbContasReceber.TabIndex = 1;
            rbContasReceber.Values.Text = "Contas a Receber";
            // 
            // rbContasPorCliente
            // 
            rbContasPorCliente.Location = new Point(72, 73);
            rbContasPorCliente.Name = "rbContasPorCliente";
            rbContasPorCliente.Size = new Size(123, 20);
            rbContasPorCliente.StateCommon.ShortText.Color1 = Color.FromArgb(0, 76, 172);
            rbContasPorCliente.StateCommon.ShortText.Color2 = Color.FromArgb(0, 76, 172);
            rbContasPorCliente.TabIndex = 0;
            rbContasPorCliente.Values.Text = "Contas por Cliente";
            // 
            // grpFormato
            // 
            grpFormato.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpFormato.Controls.Add(rbExcel);
            grpFormato.Controls.Add(rbPDF);
            grpFormato.Location = new Point(2, 353);
            grpFormato.Name = "grpFormato";
            grpFormato.Size = new Size(637, 62);
            grpFormato.TabIndex = 17;
            grpFormato.TabStop = false;
            grpFormato.Text = "Formato de Saída";
            // 
            // rbExcel
            // 
            rbExcel.Location = new Point(76, 37);
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
            rbPDF.Location = new Point(76, 18);
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
            lblCliente.Location = new Point(16, 34);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(51, 16);
            lblCliente.TabIndex = 1084;
            lblCliente.Text = "Cliente:";
            // 
            // btnPesquisarCliente
            // 
            btnPesquisarCliente.CornerRoundingRadius = 10F;
            btnPesquisarCliente.Location = new Point(603, 31);
            btnPesquisarCliente.Name = "btnPesquisarCliente";
            btnPesquisarCliente.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnPesquisarCliente.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnPesquisarCliente.OverrideDefault.Back.ColorAngle = 45F;
            btnPesquisarCliente.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnPesquisarCliente.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnPesquisarCliente.OverrideDefault.Border.ColorAngle = 45F;
            btnPesquisarCliente.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnPesquisarCliente.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnPesquisarCliente.OverrideDefault.Border.Rounding = 20F;
            btnPesquisarCliente.OverrideDefault.Border.Width = 1;
            btnPesquisarCliente.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnPesquisarCliente.Size = new Size(30, 29);
            btnPesquisarCliente.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnPesquisarCliente.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnPesquisarCliente.StateCommon.Back.ColorAngle = 45F;
            btnPesquisarCliente.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnPesquisarCliente.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnPesquisarCliente.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnPesquisarCliente.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnPesquisarCliente.StateCommon.Border.Rounding = 10F;
            btnPesquisarCliente.StateCommon.Border.Width = 1;
            btnPesquisarCliente.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnPesquisarCliente.StateCommon.Content.ShortText.Color2 = Color.White;
            btnPesquisarCliente.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisarCliente.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnPesquisarCliente.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnPesquisarCliente.StatePressed.Back.ColorAngle = 135F;
            btnPesquisarCliente.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnPesquisarCliente.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnPesquisarCliente.StatePressed.Border.ColorAngle = 135F;
            btnPesquisarCliente.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnPesquisarCliente.StatePressed.Border.Rounding = 20F;
            btnPesquisarCliente.StatePressed.Border.Width = 1;
            btnPesquisarCliente.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnPesquisarCliente.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnPesquisarCliente.StateTracking.Back.ColorAngle = 45F;
            btnPesquisarCliente.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnPesquisarCliente.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnPesquisarCliente.StateTracking.Border.ColorAngle = 45F;
            btnPesquisarCliente.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnPesquisarCliente.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnPesquisarCliente.StateTracking.Border.Rounding = 20F;
            btnPesquisarCliente.StateTracking.Border.Width = 1;
            btnPesquisarCliente.StateTracking.Content.ShortText.Color1 = Color.White;
            btnPesquisarCliente.TabIndex = 1086;
            btnPesquisarCliente.TabStop = false;
            btnPesquisarCliente.Values.Image = Properties.Resources.Pesquisar;
            btnPesquisarCliente.Values.Text = "";
            // 
            // grpFiltros
            // 
            grpFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpFiltros.Controls.Add(txtCliente);
            grpFiltros.Controls.Add(chkPagas);
            grpFiltros.Controls.Add(chkAtrasadas);
            grpFiltros.Controls.Add(chkPendentes);
            grpFiltros.Controls.Add(label3);
            grpFiltros.Controls.Add(label2);
            grpFiltros.Controls.Add(dtpFim);
            grpFiltros.Controls.Add(dtpInicio);
            grpFiltros.Controls.Add(lblPeriodo);
            grpFiltros.Controls.Add(lblCliente);
            grpFiltros.Controls.Add(btnPesquisarCliente);
            grpFiltros.Location = new Point(2, 12);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(637, 193);
            grpFiltros.TabIndex = 1087;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros do Relatório";
            // 
            // txtCliente
            // 
            txtCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCliente.CharacterCasing = CharacterCasing.Upper;
            txtCliente.Location = new Point(77, 31);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(520, 27);
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
            chkPagas.Location = new Point(76, 138);
            chkPagas.Name = "chkPagas";
            chkPagas.Size = new Size(57, 19);
            chkPagas.TabIndex = 1098;
            chkPagas.Text = "Pagas";
            chkPagas.UseVisualStyleBackColor = true;
            // 
            // chkAtrasadas
            // 
            chkAtrasadas.AutoSize = true;
            chkAtrasadas.ForeColor = Color.FromArgb(0, 76, 172);
            chkAtrasadas.Location = new Point(76, 164);
            chkAtrasadas.Name = "chkAtrasadas";
            chkAtrasadas.Size = new Size(77, 19);
            chkAtrasadas.TabIndex = 1097;
            chkAtrasadas.Text = "Atrasadas";
            chkAtrasadas.UseVisualStyleBackColor = true;
            // 
            // chkPendentes
            // 
            chkPendentes.AutoSize = true;
            chkPendentes.ForeColor = Color.FromArgb(0, 76, 172);
            chkPendentes.Location = new Point(76, 112);
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
            label3.Location = new Point(20, 110);
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
            label2.Location = new Point(199, 71);
            label2.Name = "label2";
            label2.Size = new Size(27, 16);
            label2.TabIndex = 1090;
            label2.Text = "Até";
            // 
            // dtpFim
            // 
            dtpFim.CornerRoundingRadius = 6F;
            dtpFim.Format = DateTimePickerFormat.Short;
            dtpFim.Location = new Point(234, 63);
            dtpFim.Name = "dtpFim";
            dtpFim.Size = new Size(115, 31);
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
            dtpInicio.Location = new Point(76, 63);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(115, 31);
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
            lblPeriodo.Location = new Point(9, 71);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(58, 16);
            lblPeriodo.TabIndex = 1087;
            lblPeriodo.Text = "Período:";
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLimpar.CornerRoundingRadius = 20F;
            btnLimpar.Location = new Point(435, 481);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnLimpar.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnLimpar.OverrideDefault.Back.ColorAngle = 45F;
            btnLimpar.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnLimpar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLimpar.OverrideDefault.Border.ColorAngle = 45F;
            btnLimpar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLimpar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLimpar.OverrideDefault.Border.Rounding = 20F;
            btnLimpar.OverrideDefault.Border.Width = 1;
            btnLimpar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnLimpar.Size = new Size(100, 30);
            btnLimpar.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnLimpar.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 250);
            btnLimpar.StateCommon.Back.ColorAngle = 45F;
            btnLimpar.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLimpar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLimpar.StateCommon.Border.ColorAngle = 45F;
            btnLimpar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLimpar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLimpar.StateCommon.Border.Rounding = 20F;
            btnLimpar.StateCommon.Border.Width = 1;
            btnLimpar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnLimpar.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            btnLimpar.StateNormal.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnLimpar.StateNormal.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnLimpar.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLimpar.StateNormal.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnLimpar.StateNormal.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnLimpar.StateNormal.Border.ColorAngle = 45F;
            btnLimpar.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLimpar.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLimpar.StateNormal.Border.Rounding = 20F;
            btnLimpar.StateNormal.Border.Width = 1;
            btnLimpar.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnLimpar.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnLimpar.StatePressed.Back.ColorAngle = 135F;
            btnLimpar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnLimpar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnLimpar.StatePressed.Border.ColorAngle = 135F;
            btnLimpar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLimpar.StatePressed.Border.Rounding = 20F;
            btnLimpar.StatePressed.Border.Width = 1;
            btnLimpar.StatePressed.Content.ShortText.Color1 = Color.White;
            btnLimpar.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLimpar.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnLimpar.StateTracking.Back.ColorAngle = 45F;
            btnLimpar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLimpar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLimpar.StateTracking.Border.ColorAngle = 45F;
            btnLimpar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLimpar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLimpar.StateTracking.Border.Rounding = 20F;
            btnLimpar.StateTracking.Border.Width = 1;
            btnLimpar.StateTracking.Content.ShortText.Color1 = Color.White;
            btnLimpar.TabIndex = 1088;
            btnLimpar.Values.Text = "Limpar";
            btnLimpar.Click += btnLimpar_Click;
            // 
            // FrmRelatoriosFinanceiros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(639, 537);
            Controls.Add(btnLimpar);
            Controls.Add(grpFiltros);
            Controls.Add(grpFormato);
            Controls.Add(grbTipoRelatorio);
            Controls.Add(btnGerar);
            Controls.Add(btnSair);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRelatoriosFinanceiros";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatórios Financeiros";
            grbTipoRelatorio.ResumeLayout(false);
            grbTipoRelatorio.PerformLayout();
            grpFormato.ResumeLayout(false);
            grpFormato.PerformLayout();
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public Krypton.Toolkit.KryptonButton btnGerar;
        public Krypton.Toolkit.KryptonButton btnSair;
        private GroupBox grbTipoRelatorio;
        private Krypton.Toolkit.KryptonRadioButton rbContasReceber;
        private Krypton.Toolkit.KryptonRadioButton rbContasPorCliente;
        private GroupBox grpFormato;
        private Krypton.Toolkit.KryptonRadioButton rbExcel;
        private Krypton.Toolkit.KryptonRadioButton rbPDF;
        private Label lblCliente;
        public Krypton.Toolkit.KryptonButton btnPesquisarCliente;
        private GroupBox grpFiltros;
        private Label lblPeriodo;
        private Label label3;
        private Label label2;
        public Krypton.Toolkit.KryptonDateTimePicker dtpFim;
        public Krypton.Toolkit.KryptonDateTimePicker dtpInicio;
        public Krypton.Toolkit.KryptonButton btnLimpar;
        private CheckBox chkPagas;
        private CheckBox chkAtrasadas;
        private CheckBox chkPendentes;
        public Krypton.Toolkit.KryptonTextBox txtCliente;
        private CheckBox chkAgruparCliente;
    }
}