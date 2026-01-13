namespace GVC.View
{
    partial class FrmSelecionarPagamento
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionarPagamento));
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPalette2 = new Krypton.Toolkit.KryptonPalette(components);
            txtTroco = new Krypton.Toolkit.KryptonTextBox();
            lblTroco = new Label();
            lblValorRecebido = new Label();
            txtValorRecebido = new Krypton.Toolkit.KryptonTextBox();
            dgvParcelas = new Krypton.Toolkit.KryptonDataGridView();
            txtObservacao = new Krypton.Toolkit.KryptonTextBox();
            numIntervalo = new Krypton.Toolkit.KryptonNumericUpDown();
            lblIntervalo = new Label();
            numParcelas = new Krypton.Toolkit.KryptonNumericUpDown();
            lblNumParcelas = new Label();
            lblPrimeiraParcela = new Label();
            dtpPrimeiraParcela = new Krypton.Toolkit.KryptonDateTimePicker();
            cmbFormaPagamento = new Krypton.Toolkit.KryptonComboBox();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            pnlHeader = new Krypton.Toolkit.KryptonPanel();
            tlpTitulo = new Krypton.Toolkit.KryptonTableLayoutPanel();
            lblSubTitulo = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            lblVendaNumero = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            iconAcao = new FontAwesome.Sharp.IconPictureBox();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            lbliConChar = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            lblTotal = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            btnGerar = new FontAwesome.Sharp.IconButton();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            btnConfirmar = new FontAwesome.Sharp.IconButton();
            btnVoltar = new FontAwesome.Sharp.IconButton();
            kryptonPanel5 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel6 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)dgvParcelas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbFormaPagamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).BeginInit();
            pnlHeader.SuspendLayout();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconAcao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            kryptonTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lbliConChar).BeginInit();
            lbliConChar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).BeginInit();
            kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel6).BeginInit();
            kryptonPanel6.SuspendLayout();
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
            // txtTroco
            // 
            txtTroco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTroco.CharacterCasing = CharacterCasing.Upper;
            txtTroco.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtTroco.Location = new Point(108, 56);
            txtTroco.Name = "txtTroco";
            txtTroco.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtTroco.ReadOnly = true;
            txtTroco.Size = new Size(126, 26);
            txtTroco.StateCommon.Back.Color1 = Color.White;
            txtTroco.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtTroco.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtTroco.StateCommon.Border.ColorAngle = 1F;
            txtTroco.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTroco.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtTroco.StateCommon.Border.Rounding = 3F;
            txtTroco.StateCommon.Border.Width = 1;
            txtTroco.StateCommon.Content.Color1 = Color.Gray;
            txtTroco.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtTroco.StateCommon.Content.Padding = new Padding(2);
            txtTroco.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtTroco.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtTroco.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTroco.StateNormal.Border.Rounding = 3F;
            txtTroco.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtTroco.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtTroco.TabIndex = 1061;
            // 
            // lblTroco
            // 
            lblTroco.AutoSize = true;
            lblTroco.BackColor = Color.Transparent;
            lblTroco.Font = new Font("Segoe UI", 9.75F);
            lblTroco.ForeColor = Color.FromArgb(44, 62, 80);
            lblTroco.Location = new Point(64, 62);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(44, 17);
            lblTroco.TabIndex = 1060;
            lblTroco.Text = "Troco:";
            lblTroco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorRecebido
            // 
            lblValorRecebido.AutoSize = true;
            lblValorRecebido.BackColor = Color.Transparent;
            lblValorRecebido.Font = new Font("Segoe UI", 9.75F);
            lblValorRecebido.ForeColor = Color.FromArgb(44, 62, 80);
            lblValorRecebido.Location = new Point(8, 29);
            lblValorRecebido.Name = "lblValorRecebido";
            lblValorRecebido.Size = new Size(100, 17);
            lblValorRecebido.TabIndex = 1037;
            lblValorRecebido.Text = "Valor Recebido:";
            lblValorRecebido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtValorRecebido
            // 
            txtValorRecebido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtValorRecebido.CharacterCasing = CharacterCasing.Upper;
            txtValorRecebido.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtValorRecebido.Location = new Point(108, 23);
            txtValorRecebido.Name = "txtValorRecebido";
            txtValorRecebido.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtValorRecebido.Size = new Size(126, 26);
            txtValorRecebido.StateCommon.Back.Color1 = Color.White;
            txtValorRecebido.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtValorRecebido.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtValorRecebido.StateCommon.Border.ColorAngle = 1F;
            txtValorRecebido.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtValorRecebido.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtValorRecebido.StateCommon.Border.Rounding = 3F;
            txtValorRecebido.StateCommon.Border.Width = 1;
            txtValorRecebido.StateCommon.Content.Color1 = Color.Gray;
            txtValorRecebido.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorRecebido.StateCommon.Content.Padding = new Padding(2);
            txtValorRecebido.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorRecebido.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtValorRecebido.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtValorRecebido.StateNormal.Border.Rounding = 3F;
            txtValorRecebido.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtValorRecebido.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorRecebido.TabIndex = 1059;
            // 
            // dgvParcelas
            // 
            dgvParcelas.AllowUserToAddRows = false;
            dgvParcelas.Location = new Point(3, 26);
            dgvParcelas.Name = "dgvParcelas";
            dgvParcelas.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueDarkMode;
            dgvParcelas.RowHeadersWidth = 23;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvParcelas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvParcelas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParcelas.Size = new Size(311, 92);
            dgvParcelas.TabIndex = 1037;
            // 
            // txtObservacao
            // 
            txtObservacao.CharacterCasing = CharacterCasing.Upper;
            txtObservacao.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtObservacao.Location = new Point(11, 20);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtObservacao.Size = new Size(405, 44);
            txtObservacao.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtObservacao.StateActive.Border.Rounding = 2F;
            txtObservacao.StateActive.Border.Width = 1;
            txtObservacao.StateCommon.Back.Color1 = Color.White;
            txtObservacao.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtObservacao.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtObservacao.StateCommon.Border.ColorAngle = 1F;
            txtObservacao.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtObservacao.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtObservacao.StateCommon.Border.Rounding = 2F;
            txtObservacao.StateCommon.Border.Width = 1;
            txtObservacao.StateCommon.Content.Color1 = Color.Gray;
            txtObservacao.StateCommon.Content.Font = new Font("Segoe UI", 12.75F);
            txtObservacao.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtObservacao.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtObservacao.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtObservacao.StateNormal.Border.Rounding = 2F;
            txtObservacao.StateNormal.Border.Width = 1;
            txtObservacao.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtObservacao.TabIndex = 1036;
            txtObservacao.TabStop = false;
            // 
            // numIntervalo
            // 
            numIntervalo.Location = new Point(85, 46);
            numIntervalo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numIntervalo.Name = "numIntervalo";
            numIntervalo.Size = new Size(106, 26);
            numIntervalo.StateActive.Back.Color1 = Color.FromArgb(30, 136, 229);
            numIntervalo.StateActive.Border.ColorAngle = 45F;
            numIntervalo.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numIntervalo.StateActive.Border.Rounding = 2F;
            numIntervalo.StateActive.Border.Width = 1;
            numIntervalo.StateActive.Content.Color1 = Color.White;
            numIntervalo.StateCommon.Back.Color1 = Color.FromArgb(30, 136, 229);
            numIntervalo.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            numIntervalo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            numIntervalo.StateCommon.Border.ColorAngle = 45F;
            numIntervalo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numIntervalo.StateCommon.Border.Rounding = 2F;
            numIntervalo.StateCommon.Border.Width = 1;
            numIntervalo.StateCommon.Content.Color1 = Color.White;
            numIntervalo.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            numIntervalo.StateCommon.Content.Padding = new Padding(2, 3, 2, 3);
            numIntervalo.StateNormal.Back.Color1 = Color.FromArgb(30, 136, 229);
            numIntervalo.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numIntervalo.StateNormal.Border.Rounding = 2F;
            numIntervalo.StateNormal.Border.Width = 1;
            numIntervalo.StateNormal.Content.Color1 = Color.White;
            numIntervalo.TabIndex = 1054;
            numIntervalo.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // lblIntervalo
            // 
            lblIntervalo.AutoSize = true;
            lblIntervalo.BackColor = Color.Transparent;
            lblIntervalo.Font = new Font("Segoe UI", 9.75F);
            lblIntervalo.ForeColor = Color.FromArgb(44, 62, 80);
            lblIntervalo.Location = new Point(18, 51);
            lblIntervalo.Name = "lblIntervalo";
            lblIntervalo.Size = new Size(61, 17);
            lblIntervalo.TabIndex = 1053;
            lblIntervalo.Text = "Intervalo:";
            // 
            // numParcelas
            // 
            numParcelas.Location = new Point(85, 18);
            numParcelas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numParcelas.Name = "numParcelas";
            numParcelas.Size = new Size(105, 26);
            numParcelas.StateActive.Back.Color1 = Color.FromArgb(30, 136, 229);
            numParcelas.StateActive.Border.ColorAngle = 45F;
            numParcelas.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numParcelas.StateActive.Border.Rounding = 2F;
            numParcelas.StateActive.Border.Width = 1;
            numParcelas.StateActive.Content.Color1 = Color.White;
            numParcelas.StateCommon.Back.Color1 = Color.FromArgb(30, 136, 229);
            numParcelas.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            numParcelas.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            numParcelas.StateCommon.Border.ColorAngle = 45F;
            numParcelas.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numParcelas.StateCommon.Border.Rounding = 2F;
            numParcelas.StateCommon.Border.Width = 1;
            numParcelas.StateCommon.Content.Color1 = Color.White;
            numParcelas.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            numParcelas.StateCommon.Content.Padding = new Padding(3);
            numParcelas.StateNormal.Back.Color1 = Color.FromArgb(30, 136, 229);
            numParcelas.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numParcelas.StateNormal.Border.Rounding = 2F;
            numParcelas.StateNormal.Border.Width = 1;
            numParcelas.StateNormal.Content.Color1 = Color.White;
            numParcelas.TabIndex = 1050;
            numParcelas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNumParcelas
            // 
            lblNumParcelas.AutoSize = true;
            lblNumParcelas.BackColor = Color.Transparent;
            lblNumParcelas.Font = new Font("Segoe UI", 9.75F);
            lblNumParcelas.ForeColor = Color.FromArgb(44, 62, 80);
            lblNumParcelas.Location = new Point(0, 20);
            lblNumParcelas.Name = "lblNumParcelas";
            lblNumParcelas.Size = new Size(79, 17);
            lblNumParcelas.TabIndex = 1049;
            lblNumParcelas.Text = "Nº Parcelas:";
            // 
            // lblPrimeiraParcela
            // 
            lblPrimeiraParcela.AutoSize = true;
            lblPrimeiraParcela.BackColor = Color.Transparent;
            lblPrimeiraParcela.Font = new Font("Segoe UI", 9.75F);
            lblPrimeiraParcela.ForeColor = Color.FromArgb(44, 62, 80);
            lblPrimeiraParcela.Location = new Point(9, 80);
            lblPrimeiraParcela.Name = "lblPrimeiraParcela";
            lblPrimeiraParcela.Size = new Size(70, 17);
            lblPrimeiraParcela.TabIndex = 1052;
            lblPrimeiraParcela.Text = "1º Parcela:";
            // 
            // dtpPrimeiraParcela
            // 
            dtpPrimeiraParcela.CornerRoundingRadius = 2F;
            dtpPrimeiraParcela.Format = DateTimePickerFormat.Short;
            dtpPrimeiraParcela.Location = new Point(85, 76);
            dtpPrimeiraParcela.Name = "dtpPrimeiraParcela";
            dtpPrimeiraParcela.Size = new Size(106, 29);
            dtpPrimeiraParcela.StateActive.Back.Color1 = Color.FromArgb(6, 174, 244);
            dtpPrimeiraParcela.StateActive.Border.Color1 = Color.FromArgb(6, 174, 244);
            dtpPrimeiraParcela.StateActive.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtpPrimeiraParcela.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpPrimeiraParcela.StateActive.Border.Rounding = 2F;
            dtpPrimeiraParcela.StateActive.Border.Width = 1;
            dtpPrimeiraParcela.StateActive.Content.Color1 = Color.White;
            dtpPrimeiraParcela.StateActive.Content.Font = new Font("Poppins", 9F);
            dtpPrimeiraParcela.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtpPrimeiraParcela.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpPrimeiraParcela.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtpPrimeiraParcela.StateCommon.Border.ColorAngle = 45F;
            dtpPrimeiraParcela.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpPrimeiraParcela.StateCommon.Border.Rounding = 2F;
            dtpPrimeiraParcela.StateCommon.Border.Width = 1;
            dtpPrimeiraParcela.StateCommon.Content.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpPrimeiraParcela.StateCommon.Content.Padding = new Padding(1);
            dtpPrimeiraParcela.StateDisabled.Border.ColorAngle = 45F;
            dtpPrimeiraParcela.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpPrimeiraParcela.StateDisabled.Border.Rounding = 3F;
            dtpPrimeiraParcela.StateDisabled.Border.Width = 1;
            dtpPrimeiraParcela.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtpPrimeiraParcela.StateNormal.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpPrimeiraParcela.StateNormal.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtpPrimeiraParcela.StateNormal.Border.ColorAngle = 45F;
            dtpPrimeiraParcela.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpPrimeiraParcela.StateNormal.Border.Rounding = 2F;
            dtpPrimeiraParcela.StateNormal.Border.Width = 1;
            dtpPrimeiraParcela.StateNormal.Content.Color1 = Color.White;
            dtpPrimeiraParcela.TabIndex = 1100;
            // 
            // cmbFormaPagamento
            // 
            cmbFormaPagamento.CornerRoundingRadius = 6F;
            cmbFormaPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormaPagamento.DropDownWidth = 115;
            cmbFormaPagamento.IntegralHeight = false;
            cmbFormaPagamento.Items.AddRange(new object[] { "Administrador", "Operador", "Visitante" });
            cmbFormaPagamento.Location = new Point(137, 3);
            cmbFormaPagamento.Name = "cmbFormaPagamento";
            cmbFormaPagamento.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbFormaPagamento.Size = new Size(161, 25);
            cmbFormaPagamento.StateActive.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbFormaPagamento.StateActive.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbFormaPagamento.StateActive.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbFormaPagamento.StateActive.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbFormaPagamento.StateActive.ComboBox.Content.Color1 = Color.White;
            cmbFormaPagamento.StateActive.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbFormaPagamento.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbFormaPagamento.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbFormaPagamento.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbFormaPagamento.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbFormaPagamento.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbFormaPagamento.StateCommon.ComboBox.Content.Color1 = Color.White;
            cmbFormaPagamento.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbFormaPagamento.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbFormaPagamento.StateNormal.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbFormaPagamento.StateNormal.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbFormaPagamento.StateNormal.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbFormaPagamento.StateNormal.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbFormaPagamento.StateNormal.ComboBox.Content.Color1 = Color.White;
            cmbFormaPagamento.StateNormal.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbFormaPagamento.StateTracking.Item.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbFormaPagamento.StateTracking.Item.Back.Color2 = Color.FromArgb(30, 136, 229);
            cmbFormaPagamento.StateTracking.Item.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbFormaPagamento.StateTracking.Item.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbFormaPagamento.StateTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbFormaPagamento.StateTracking.Item.Content.ShortText.Color1 = Color.White;
            cmbFormaPagamento.StateTracking.Item.Content.ShortText.Color2 = Color.White;
            cmbFormaPagamento.StateTracking.Item.Content.ShortText.Font = new Font("Segoe UI", 9F);
            cmbFormaPagamento.TabIndex = 1099;
            cmbFormaPagamento.TabStop = false;
            cmbFormaPagamento.SelectedIndexChanged += cmbFormaPagamento_SelectedIndexChanged;
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
            btnCancelar.IconSize = 22;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(194, 426);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 32);
            btnCancelar.TabIndex = 1111;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(tlpTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(444, 45);
            pnlHeader.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            pnlHeader.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            pnlHeader.TabIndex = 1113;
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
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 62.22222F));
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 37.77778F));
            tlpTitulo.Size = new Size(444, 45);
            tlpTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            tlpTitulo.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            tlpTitulo.TabIndex = 0;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.Dock = DockStyle.Fill;
            lblSubTitulo.Location = new Point(3, 31);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(438, 11);
            lblSubTitulo.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Color2 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblSubTitulo.TabIndex = 0;
            lblSubTitulo.Values.Text = "Definição da forma de pagamento e geração de parcelas";
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(lblVendaNumero);
            kryptonPanel3.Controls.Add(kryptonLabel6);
            kryptonPanel3.Controls.Add(lblTitulo);
            kryptonPanel3.Controls.Add(iconAcao);
            kryptonPanel3.Dock = DockStyle.Fill;
            kryptonPanel3.Location = new Point(3, 3);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(438, 22);
            kryptonPanel3.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            kryptonPanel3.TabIndex = 1;
            // 
            // lblVendaNumero
            // 
            lblVendaNumero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblVendaNumero.Location = new Point(348, 0);
            lblVendaNumero.Name = "lblVendaNumero";
            lblVendaNumero.Size = new Size(42, 27);
            lblVendaNumero.StateCommon.ShortText.Color1 = Color.White;
            lblVendaNumero.StateCommon.ShortText.Color2 = Color.White;
            lblVendaNumero.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVendaNumero.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblVendaNumero.TabIndex = 1112;
            lblVendaNumero.Values.Text = "000";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonLabel6.Location = new Point(251, 0);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(91, 27);
            kryptonLabel6.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel6.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel6.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel6.TabIndex = 1111;
            kryptonLabel6.Values.Text = "Venda Nº";
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(30, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(209, 27);
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Color2 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 1091;
            lblTitulo.Values.Text = "Detalhes do Pagamento";
            // 
            // iconAcao
            // 
            iconAcao.BackColor = Color.Transparent;
            iconAcao.Dock = DockStyle.Left;
            iconAcao.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            iconAcao.IconColor = Color.White;
            iconAcao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAcao.IconSize = 22;
            iconAcao.Location = new Point(0, 0);
            iconAcao.Name = "iconAcao";
            iconAcao.Size = new Size(28, 22);
            iconAcao.TabIndex = 1110;
            iconAcao.TabStop = false;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonTableLayoutPanel1);
            kryptonPanel1.Location = new Point(0, 61);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueLightMode;
            kryptonPanel1.Size = new Size(489, 35);
            kryptonPanel1.TabIndex = 1114;
            // 
            // kryptonTableLayoutPanel1
            // 
            kryptonTableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("kryptonTableLayoutPanel1.BackgroundImage");
            kryptonTableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            kryptonTableLayoutPanel1.ColumnCount = 4;
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 134F));
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 82F));
            kryptonTableLayoutPanel1.Controls.Add(lbliConChar, 0, 0);
            kryptonTableLayoutPanel1.Controls.Add(cmbFormaPagamento, 1, 0);
            kryptonTableLayoutPanel1.Controls.Add(kryptonLabel1, 2, 0);
            kryptonTableLayoutPanel1.Controls.Add(lblTotal, 3, 0);
            kryptonTableLayoutPanel1.Dock = DockStyle.Fill;
            kryptonTableLayoutPanel1.Location = new Point(0, 0);
            kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            kryptonTableLayoutPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2013White;
            kryptonTableLayoutPanel1.RowCount = 1;
            kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.3333321F));
            kryptonTableLayoutPanel1.Size = new Size(489, 35);
            kryptonTableLayoutPanel1.TabIndex = 0;
            // 
            // lbliConChar
            // 
            lbliConChar.Controls.Add(kryptonLabel2);
            lbliConChar.Controls.Add(iconPictureBox1);
            lbliConChar.Dock = DockStyle.Fill;
            lbliConChar.Location = new Point(3, 3);
            lbliConChar.Name = "lbliConChar";
            lbliConChar.Size = new Size(128, 29);
            lbliConChar.StateCommon.Color1 = Color.White;
            lbliConChar.StateCommon.Color2 = Color.White;
            lbliConChar.TabIndex = 1120;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(35, 3);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(94, 20);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(30, 136, 229);
            kryptonLabel2.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel2.TabIndex = 1112;
            kryptonLabel2.Values.Text = "Forma de pgto.";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = Color.FromArgb(30, 136, 229);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            iconPictureBox1.IconColor = Color.FromArgb(30, 136, 229);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 25;
            iconPictureBox1.Location = new Point(7, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(42, 25);
            iconPictureBox1.TabIndex = 1111;
            iconPictureBox1.TabStop = false;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(307, 3);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(40, 20);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(30, 136, 229);
            kryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.TabIndex = 1114;
            kryptonLabel1.Values.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(355, 3);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(51, 20);
            lblTotal.StateCommon.ShortText.Color1 = Color.FromArgb(30, 136, 229);
            lblTotal.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTotal.TabIndex = 1115;
            lblTotal.Values.Text = "R$ 0,00";
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(kryptonLabel3);
            kryptonPanel2.Controls.Add(txtValorRecebido);
            kryptonPanel2.Controls.Add(lblValorRecebido);
            kryptonPanel2.Controls.Add(txtTroco);
            kryptonPanel2.Controls.Add(lblTroco);
            kryptonPanel2.Location = new Point(0, 109);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            kryptonPanel2.Size = new Size(237, 115);
            kryptonPanel2.TabIndex = 1115;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Dock = DockStyle.Top;
            kryptonLabel3.Location = new Point(0, 0);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(237, 20);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 1038;
            kryptonLabel3.Values.Text = "Recebimento";
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel4.Controls.Add(btnGerar);
            kryptonPanel4.Controls.Add(kryptonLabel4);
            kryptonPanel4.Controls.Add(dgvParcelas);
            kryptonPanel4.Location = new Point(0, 220);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            kryptonPanel4.Size = new Size(439, 126);
            kryptonPanel4.TabIndex = 1116;
            // 
            // btnGerar
            // 
            btnGerar.BackColor = Color.FromArgb(76, 175, 80);
            btnGerar.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnGerar.ForeColor = Color.White;
            btnGerar.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            btnGerar.IconColor = Color.White;
            btnGerar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGerar.IconSize = 22;
            btnGerar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGerar.Location = new Point(316, 86);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(120, 32);
            btnGerar.TabIndex = 1119;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = false;
            btnGerar.Click += btnGerar_Click;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Dock = DockStyle.Top;
            kryptonLabel4.Location = new Point(0, 0);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(439, 20);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel4.TabIndex = 1038;
            kryptonLabel4.Values.Text = "Parcelas geradas";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmar.BackColor = Color.FromArgb(30, 136, 229);
            btnConfirmar.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnConfirmar.IconColor = Color.White;
            btnConfirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfirmar.IconSize = 22;
            btnConfirmar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmar.Location = new Point(314, 426);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Padding = new Padding(10, 0, 10, 0);
            btnConfirmar.Size = new Size(120, 32);
            btnConfirmar.TabIndex = 1124;
            btnConfirmar.Text = "    Confirmar";
            btnConfirmar.TextAlign = ContentAlignment.MiddleRight;
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVoltar.BackColor = Color.Gray;
            btnVoltar.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            btnVoltar.IconColor = Color.White;
            btnVoltar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVoltar.IconSize = 22;
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(74, 426);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Padding = new Padding(10, 0, 10, 0);
            btnVoltar.Size = new Size(120, 32);
            btnVoltar.TabIndex = 1125;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // kryptonPanel5
            // 
            kryptonPanel5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel5.Controls.Add(kryptonLabel5);
            kryptonPanel5.Controls.Add(txtObservacao);
            kryptonPanel5.Location = new Point(3, 350);
            kryptonPanel5.Name = "kryptonPanel5";
            kryptonPanel5.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueLightMode;
            kryptonPanel5.Size = new Size(429, 69);
            kryptonPanel5.TabIndex = 1126;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Dock = DockStyle.Top;
            kryptonLabel5.Location = new Point(0, 0);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(429, 20);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel5.TabIndex = 1038;
            kryptonLabel5.Values.Text = "Observações";
            // 
            // kryptonPanel6
            // 
            kryptonPanel6.Controls.Add(kryptonLabel7);
            kryptonPanel6.Controls.Add(lblNumParcelas);
            kryptonPanel6.Controls.Add(dtpPrimeiraParcela);
            kryptonPanel6.Controls.Add(lblPrimeiraParcela);
            kryptonPanel6.Controls.Add(numIntervalo);
            kryptonPanel6.Controls.Add(numParcelas);
            kryptonPanel6.Controls.Add(lblIntervalo);
            kryptonPanel6.Location = new Point(243, 109);
            kryptonPanel6.Name = "kryptonPanel6";
            kryptonPanel6.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            kryptonPanel6.Size = new Size(200, 115);
            kryptonPanel6.TabIndex = 1127;
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Dock = DockStyle.Top;
            kryptonLabel7.Location = new Point(0, 0);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(200, 20);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel7.TabIndex = 1038;
            kryptonLabel7.Values.Text = "Parcelamento";
            // 
            // FrmSelecionarPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(444, 473);
            Controls.Add(kryptonPanel6);
            Controls.Add(kryptonPanel5);
            Controls.Add(btnVoltar);
            Controls.Add(btnConfirmar);
            Controls.Add(kryptonPanel4);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonPanel1);
            Controls.Add(pnlHeader);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSelecionarPagamento";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.Color1 = Color.FromArgb(8, 148, 252);
            StateCommon.Border.Color2 = Color.FromArgb(8, 148, 252);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Load += FrmFinalizarVenda_Load;
            ((System.ComponentModel.ISupportInitialize)dgvParcelas).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbFormaPagamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).EndInit();
            pnlHeader.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconAcao).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonTableLayoutPanel1.ResumeLayout(false);
            kryptonTableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lbliConChar).EndInit();
            lbliConChar.ResumeLayout(false);
            lbliConChar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            kryptonPanel4.ResumeLayout(false);
            kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).EndInit();
            kryptonPanel5.ResumeLayout(false);
            kryptonPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel6).EndInit();
            kryptonPanel6.ResumeLayout(false);
            kryptonPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonPalette kryptonPalette2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel6;       
        private Krypton.Toolkit.KryptonComboBox cmbFormaPagamento;
        private Label lblValorRecebido;
        public Krypton.Toolkit.KryptonTextBox txtValorRecebido;
        public Krypton.Toolkit.KryptonTextBox txtTroco;
        private Label lblTroco;
        private Krypton.Toolkit.KryptonNumericUpDown numIntervalo;
        private Label lblIntervalo;        
        private Krypton.Toolkit.KryptonNumericUpDown numParcelas;
        private Label lblNumParcelas;
        private Label lblPrimeiraParcela;
             
        public Krypton.Toolkit.KryptonDataGridView dgvParcelas;
        public Krypton.Toolkit.KryptonTextBox txtObservacao;       
        public Krypton.Toolkit.KryptonDateTimePicker dtpPrimeiraParcela;
       
        private FontAwesome.Sharp.IconButton btnCancelar;
        private Krypton.Toolkit.KryptonPanel pnlHeader;
        private Krypton.Toolkit.KryptonTableLayoutPanel tlpTitulo;
        private Krypton.Toolkit.KryptonLabel lblSubTitulo;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private FontAwesome.Sharp.IconPictureBox iconAcao;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel lblTotal;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private FontAwesome.Sharp.IconButton btnGerar;
        private FontAwesome.Sharp.IconButton btnConfirmar;
        private FontAwesome.Sharp.IconButton btnVoltar;
        private Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel lblVendaNumero;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonPanel lbliConChar;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
    }
}