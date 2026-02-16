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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionarPagamento));
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
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
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            lblObservacoes = new Krypton.Toolkit.KryptonLabel();
            PanelDetalhes = new Krypton.Toolkit.KryptonPanel();
            panelRecebimento = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            txtValorRecebido = new Krypton.Toolkit.KryptonTextBox();
            lblValorRecebido = new Label();
            txtTroco = new Krypton.Toolkit.KryptonTextBox();
            lblTroco = new Label();
            panelParcelamento = new Krypton.Toolkit.KryptonPanel();
            lblParcelamento = new Krypton.Toolkit.KryptonLabel();
            btnGerar = new FontAwesome.Sharp.IconButton();
            panelSubTitulo = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            panelDatagrid = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            panelTitulo = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblTotal = new Krypton.Toolkit.KryptonLabel();
            lblVendaNumero = new Krypton.Toolkit.KryptonLabel();
            lblVendaN = new Krypton.Toolkit.KryptonLabel();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            btnConfirmar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvParcelas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbFormaPagamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).BeginInit();
            pnlHeader.SuspendLayout();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PanelDetalhes).BeginInit();
            PanelDetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelRecebimento).BeginInit();
            panelRecebimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelParcelamento).BeginInit();
            panelParcelamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelSubTitulo).BeginInit();
            panelSubTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelDatagrid).BeginInit();
            panelDatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelTitulo).BeginInit();
            panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
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
            // dgvParcelas
            // 
            dgvParcelas.AllowUserToAddRows = false;
            dgvParcelas.Dock = DockStyle.Fill;
            dgvParcelas.Location = new Point(0, 20);
            dgvParcelas.Name = "dgvParcelas";
            dgvParcelas.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            dgvParcelas.RowHeadersVisible = false;
            dgvParcelas.RowHeadersWidth = 23;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvParcelas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvParcelas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParcelas.Size = new Size(373, 126);
            dgvParcelas.TabIndex = 1037;
            // 
            // txtObservacao
            // 
            txtObservacao.CharacterCasing = CharacterCasing.Upper;
            txtObservacao.Dock = DockStyle.Fill;
            txtObservacao.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtObservacao.Location = new Point(0, 20);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtObservacao.ScrollBars = ScrollBars.Vertical;
            txtObservacao.Size = new Size(373, 68);
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
            numIntervalo.Location = new Point(64, 49);
            numIntervalo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numIntervalo.Name = "numIntervalo";
            numIntervalo.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            numIntervalo.Size = new Size(97, 26);
            numIntervalo.StateActive.Border.ColorAngle = 45F;
            numIntervalo.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numIntervalo.StateActive.Border.Rounding = 2F;
            numIntervalo.StateActive.Border.Width = 1;
            numIntervalo.StateActive.Content.Color1 = Color.Black;
            numIntervalo.StateCommon.Border.Color1 = Color.FromArgb(1, 148, 254);
            numIntervalo.StateCommon.Border.Color2 = Color.FromArgb(1, 148, 254);
            numIntervalo.StateCommon.Border.ColorAngle = 45F;
            numIntervalo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numIntervalo.StateCommon.Border.Rounding = 2F;
            numIntervalo.StateCommon.Border.Width = 1;
            numIntervalo.StateCommon.Content.Color1 = Color.Black;
            numIntervalo.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            numIntervalo.StateCommon.Content.Padding = new Padding(2, 3, 2, 3);
            numIntervalo.StateNormal.Border.Color1 = Color.FromArgb(1, 148, 254);
            numIntervalo.StateNormal.Border.Color2 = Color.FromArgb(1, 148, 254);
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
            lblIntervalo.Location = new Point(64, 28);
            lblIntervalo.Name = "lblIntervalo";
            lblIntervalo.Size = new Size(97, 17);
            lblIntervalo.TabIndex = 1053;
            lblIntervalo.Text = "Intervalo (dias):";
            // 
            // numParcelas
            // 
            numParcelas.Location = new Point(0, 49);
            numParcelas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numParcelas.Name = "numParcelas";
            numParcelas.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            numParcelas.Size = new Size(58, 26);
            numParcelas.StateActive.Border.Color1 = Color.FromArgb(1, 148, 254);
            numParcelas.StateActive.Border.Color2 = Color.FromArgb(1, 148, 254);
            numParcelas.StateActive.Border.ColorAngle = 45F;
            numParcelas.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numParcelas.StateActive.Border.Rounding = 2F;
            numParcelas.StateActive.Border.Width = 1;
            numParcelas.StateActive.Content.Color1 = Color.Black;
            numParcelas.StateCommon.Border.Color1 = Color.FromArgb(1, 148, 254);
            numParcelas.StateCommon.Border.Color2 = Color.FromArgb(1, 148, 254);
            numParcelas.StateCommon.Border.ColorAngle = 45F;
            numParcelas.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numParcelas.StateCommon.Border.Rounding = 2F;
            numParcelas.StateCommon.Border.Width = 1;
            numParcelas.StateCommon.Content.Color1 = Color.Black;
            numParcelas.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            numParcelas.StateCommon.Content.Padding = new Padding(3);
            numParcelas.StateDisabled.Border.Color1 = Color.FromArgb(224, 224, 224);
            numParcelas.StateDisabled.Border.Color2 = Color.Silver;
            numParcelas.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numParcelas.StateDisabled.Content.Color1 = Color.Black;
            numParcelas.StateNormal.Border.Color1 = Color.FromArgb(1, 148, 254);
            numParcelas.StateNormal.Border.Color2 = Color.FromArgb(1, 148, 254);
            numParcelas.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numParcelas.StateNormal.Border.Rounding = 2F;
            numParcelas.StateNormal.Border.Width = 1;
            numParcelas.TabIndex = 1050;
            numParcelas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numParcelas.ValueChanged += numParcelas_ValueChanged;
            // 
            // lblNumParcelas
            // 
            lblNumParcelas.AutoSize = true;
            lblNumParcelas.BackColor = Color.Transparent;
            lblNumParcelas.Font = new Font("Segoe UI", 9.75F);
            lblNumParcelas.ForeColor = Color.FromArgb(44, 62, 80);
            lblNumParcelas.Location = new Point(-1, 28);
            lblNumParcelas.Name = "lblNumParcelas";
            lblNumParcelas.Size = new Size(59, 17);
            lblNumParcelas.TabIndex = 1049;
            lblNumParcelas.Text = "Parcelas:";
            // 
            // lblPrimeiraParcela
            // 
            lblPrimeiraParcela.AutoSize = true;
            lblPrimeiraParcela.BackColor = Color.Transparent;
            lblPrimeiraParcela.Font = new Font("Segoe UI", 9.75F);
            lblPrimeiraParcela.ForeColor = Color.FromArgb(44, 62, 80);
            lblPrimeiraParcela.Location = new Point(167, 28);
            lblPrimeiraParcela.Name = "lblPrimeiraParcela";
            lblPrimeiraParcela.Size = new Size(95, 17);
            lblPrimeiraParcela.TabIndex = 1052;
            lblPrimeiraParcela.Text = "1º Vencimento:";
            // 
            // dtpPrimeiraParcela
            // 
            dtpPrimeiraParcela.CornerRoundingRadius = 2F;
            dtpPrimeiraParcela.Format = DateTimePickerFormat.Short;
            dtpPrimeiraParcela.Location = new Point(167, 47);
            dtpPrimeiraParcela.Name = "dtpPrimeiraParcela";
            dtpPrimeiraParcela.Size = new Size(111, 29);
            dtpPrimeiraParcela.StateActive.Border.Color1 = Color.FromArgb(1, 148, 254);
            dtpPrimeiraParcela.StateActive.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtpPrimeiraParcela.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpPrimeiraParcela.StateActive.Border.Rounding = 2F;
            dtpPrimeiraParcela.StateActive.Border.Width = 1;
            dtpPrimeiraParcela.StateActive.Content.Color1 = Color.Black;
            dtpPrimeiraParcela.StateActive.Content.Font = new Font("Poppins", 9F);
            dtpPrimeiraParcela.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpPrimeiraParcela.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtpPrimeiraParcela.StateCommon.Border.ColorAngle = 45F;
            dtpPrimeiraParcela.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpPrimeiraParcela.StateCommon.Border.Rounding = 2F;
            dtpPrimeiraParcela.StateCommon.Border.Width = 1;
            dtpPrimeiraParcela.StateCommon.Content.Color1 = Color.Black;
            dtpPrimeiraParcela.StateCommon.Content.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpPrimeiraParcela.StateCommon.Content.Padding = new Padding(1);
            dtpPrimeiraParcela.StateDisabled.Border.Color1 = Color.FromArgb(1, 148, 254);
            dtpPrimeiraParcela.StateDisabled.Border.Color2 = Color.FromArgb(1, 148, 254);
            dtpPrimeiraParcela.StateDisabled.Border.ColorAngle = 45F;
            dtpPrimeiraParcela.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpPrimeiraParcela.StateDisabled.Border.Rounding = 3F;
            dtpPrimeiraParcela.StateDisabled.Border.Width = 1;
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
            cmbFormaPagamento.CornerRoundingRadius = 4F;
            cmbFormaPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormaPagamento.DropDownWidth = 115;
            cmbFormaPagamento.IntegralHeight = false;
            cmbFormaPagamento.Items.AddRange(new object[] { "  Dinheiro", "  CartaoCredito", "  CartaoDebito", "  Pix", "  Boleto", "  Transferencia", "  Cheque", "  Crediario" });
            cmbFormaPagamento.Location = new Point(107, 8);
            cmbFormaPagamento.Name = "cmbFormaPagamento";
            cmbFormaPagamento.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbFormaPagamento.Size = new Size(256, 23);
            cmbFormaPagamento.StateActive.ComboBox.Back.Color1 = Color.FromArgb(183, 219, 255);
            cmbFormaPagamento.StateActive.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbFormaPagamento.StateActive.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbFormaPagamento.StateActive.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbFormaPagamento.StateActive.ComboBox.Content.Color1 = Color.Black;
            cmbFormaPagamento.StateActive.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbFormaPagamento.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(183, 219, 255);
            cmbFormaPagamento.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbFormaPagamento.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbFormaPagamento.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbFormaPagamento.StateCommon.ComboBox.Border.Rounding = 4F;
            cmbFormaPagamento.StateCommon.ComboBox.Border.Width = 1;
            cmbFormaPagamento.StateCommon.ComboBox.Content.Color1 = Color.Black;
            cmbFormaPagamento.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 11F);
            cmbFormaPagamento.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbFormaPagamento.StateNormal.ComboBox.Back.Color1 = Color.FromArgb(183, 219, 255);
            cmbFormaPagamento.StateNormal.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbFormaPagamento.StateNormal.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbFormaPagamento.StateNormal.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbFormaPagamento.StateNormal.ComboBox.Content.Color1 = Color.Black;
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
            btnCancelar.BackColor = Color.FromArgb(251, 140, 0);
            btnCancelar.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnCancelar.IconColor = Color.White;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 22;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(130, 443);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 32);
            btnCancelar.TabIndex = 1111;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.Controls.Add(tlpTitulo);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            pnlHeader.Size = new Size(379, 437);
            pnlHeader.TabIndex = 1113;
            // 
            // tlpTitulo
            // 
            tlpTitulo.BackgroundImage = (Image)resources.GetObject("tlpTitulo.BackgroundImage");
            tlpTitulo.BackgroundImageLayout = ImageLayout.None;
            tlpTitulo.ColumnCount = 1;
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTitulo.Controls.Add(kryptonPanel2, 0, 4);
            tlpTitulo.Controls.Add(PanelDetalhes, 0, 2);
            tlpTitulo.Controls.Add(panelSubTitulo, 0, 1);
            tlpTitulo.Controls.Add(panelDatagrid, 0, 3);
            tlpTitulo.Controls.Add(panelTitulo, 0, 0);
            tlpTitulo.Dock = DockStyle.Fill;
            tlpTitulo.Location = new Point(0, 0);
            tlpTitulo.Name = "tlpTitulo";
            tlpTitulo.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            tlpTitulo.RowCount = 5;
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Absolute, 152F));
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTitulo.Size = new Size(379, 437);
            tlpTitulo.TabIndex = 0;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(txtObservacao);
            kryptonPanel2.Controls.Add(lblObservacoes);
            kryptonPanel2.Dock = DockStyle.Fill;
            kryptonPanel2.Location = new Point(3, 346);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            kryptonPanel2.Size = new Size(373, 88);
            kryptonPanel2.TabIndex = 2;
            // 
            // lblObservacoes
            // 
            lblObservacoes.Dock = DockStyle.Top;
            lblObservacoes.Location = new Point(0, 0);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            lblObservacoes.Size = new Size(373, 20);
            lblObservacoes.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObservacoes.TabIndex = 1038;
            lblObservacoes.Values.Text = "Observações";
            lblObservacoes.Click += lblObservacoes_Click;
            // 
            // PanelDetalhes
            // 
            PanelDetalhes.Controls.Add(panelRecebimento);
            PanelDetalhes.Controls.Add(panelParcelamento);
            PanelDetalhes.Dock = DockStyle.Fill;
            PanelDetalhes.Location = new Point(3, 106);
            PanelDetalhes.Name = "PanelDetalhes";
            PanelDetalhes.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            PanelDetalhes.Size = new Size(373, 82);
            PanelDetalhes.TabIndex = 1135;
            // 
            // panelRecebimento
            // 
            panelRecebimento.Controls.Add(kryptonLabel3);
            panelRecebimento.Controls.Add(txtValorRecebido);
            panelRecebimento.Controls.Add(lblValorRecebido);
            panelRecebimento.Controls.Add(txtTroco);
            panelRecebimento.Controls.Add(lblTroco);
            panelRecebimento.Dock = DockStyle.Bottom;
            panelRecebimento.Location = new Point(0, 3);
            panelRecebimento.Name = "panelRecebimento";
            panelRecebimento.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            panelRecebimento.Size = new Size(373, 79);
            panelRecebimento.TabIndex = 1133;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Dock = DockStyle.Top;
            kryptonLabel3.Location = new Point(0, 0);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            kryptonLabel3.Size = new Size(373, 20);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 1038;
            kryptonLabel3.Values.Text = "Recebimento";
            // 
            // txtValorRecebido
            // 
            txtValorRecebido.CharacterCasing = CharacterCasing.Upper;
            txtValorRecebido.CueHint.CueHintText = "Digite o valor recebido…";
            txtValorRecebido.CueHint.Padding = new Padding(0);
            txtValorRecebido.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtValorRecebido.Location = new Point(6, 45);
            txtValorRecebido.Name = "txtValorRecebido";
            txtValorRecebido.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtValorRecebido.Size = new Size(165, 31);
            txtValorRecebido.StateCommon.Back.Color1 = Color.White;
            txtValorRecebido.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtValorRecebido.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtValorRecebido.StateCommon.Border.ColorAngle = 1F;
            txtValorRecebido.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtValorRecebido.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtValorRecebido.StateCommon.Border.Rounding = 3F;
            txtValorRecebido.StateCommon.Border.Width = 1;
            txtValorRecebido.StateCommon.Content.Color1 = Color.Gray;
            txtValorRecebido.StateCommon.Content.Font = new Font("Segoe UI", 12.75F);
            txtValorRecebido.StateCommon.Content.Padding = new Padding(2);
            txtValorRecebido.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorRecebido.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtValorRecebido.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtValorRecebido.StateNormal.Border.Rounding = 3F;
            txtValorRecebido.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtValorRecebido.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorRecebido.TabIndex = 1059;
            txtValorRecebido.TextChanged += txtValorRecebido_TextChanged;
            txtValorRecebido.Enter += txtValorRecebido_Enter;
            txtValorRecebido.Leave += txtValorRecebido_Leave;
            // 
            // lblValorRecebido
            // 
            lblValorRecebido.AutoSize = true;
            lblValorRecebido.BackColor = Color.Transparent;
            lblValorRecebido.Font = new Font("Segoe UI", 10.75F);
            lblValorRecebido.ForeColor = Color.FromArgb(44, 62, 80);
            lblValorRecebido.Location = new Point(4, 22);
            lblValorRecebido.Name = "lblValorRecebido";
            lblValorRecebido.Size = new Size(113, 20);
            lblValorRecebido.TabIndex = 1037;
            lblValorRecebido.Text = "Valor Recebido:";
            lblValorRecebido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTroco
            // 
            txtTroco.CharacterCasing = CharacterCasing.Upper;
            txtTroco.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtTroco.Location = new Point(185, 45);
            txtTroco.Name = "txtTroco";
            txtTroco.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtTroco.ReadOnly = true;
            txtTroco.Size = new Size(174, 31);
            txtTroco.StateCommon.Back.Color1 = Color.Gainsboro;
            txtTroco.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtTroco.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtTroco.StateCommon.Border.ColorAngle = 1F;
            txtTroco.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTroco.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtTroco.StateCommon.Border.Rounding = 3F;
            txtTroco.StateCommon.Border.Width = 1;
            txtTroco.StateCommon.Content.Color1 = Color.Gray;
            txtTroco.StateCommon.Content.Font = new Font("Segoe UI", 12.75F);
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
            lblTroco.Font = new Font("Segoe UI", 10.75F);
            lblTroco.ForeColor = Color.FromArgb(44, 62, 80);
            lblTroco.Location = new Point(186, 22);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(49, 20);
            lblTroco.TabIndex = 1060;
            lblTroco.Text = "Troco:";
            lblTroco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelParcelamento
            // 
            panelParcelamento.Controls.Add(lblParcelamento);
            panelParcelamento.Controls.Add(btnGerar);
            panelParcelamento.Controls.Add(lblNumParcelas);
            panelParcelamento.Controls.Add(dtpPrimeiraParcela);
            panelParcelamento.Controls.Add(lblPrimeiraParcela);
            panelParcelamento.Controls.Add(numIntervalo);
            panelParcelamento.Controls.Add(numParcelas);
            panelParcelamento.Controls.Add(lblIntervalo);
            panelParcelamento.Dock = DockStyle.Top;
            panelParcelamento.Location = new Point(0, 0);
            panelParcelamento.Name = "panelParcelamento";
            panelParcelamento.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            panelParcelamento.Size = new Size(373, 79);
            panelParcelamento.TabIndex = 1127;
            // 
            // lblParcelamento
            // 
            lblParcelamento.Dock = DockStyle.Top;
            lblParcelamento.Location = new Point(0, 0);
            lblParcelamento.Name = "lblParcelamento";
            lblParcelamento.Size = new Size(373, 20);
            lblParcelamento.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblParcelamento.TabIndex = 1038;
            lblParcelamento.Values.Text = "Parcelamento";
            // 
            // btnGerar
            // 
            btnGerar.BackColor = Color.FromArgb(67, 160, 71);
            btnGerar.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnGerar.ForeColor = Color.White;
            btnGerar.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            btnGerar.IconColor = Color.White;
            btnGerar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGerar.IconSize = 22;
            btnGerar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGerar.Location = new Point(284, 43);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(75, 36);
            btnGerar.TabIndex = 1119;
            btnGerar.Text = "   Gerar";
            btnGerar.UseVisualStyleBackColor = false;
            btnGerar.Click += btnGerar_Click;
            // 
            // panelSubTitulo
            // 
            panelSubTitulo.Controls.Add(kryptonLabel8);
            panelSubTitulo.Controls.Add(kryptonLabel9);
            panelSubTitulo.Controls.Add(kryptonPanel1);
            panelSubTitulo.Dock = DockStyle.Fill;
            panelSubTitulo.Location = new Point(3, 61);
            panelSubTitulo.Name = "panelSubTitulo";
            panelSubTitulo.Size = new Size(373, 39);
            panelSubTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            panelSubTitulo.TabIndex = 2;
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonLabel8.Location = new Point(1061, 0);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Size = new Size(42, 27);
            kryptonLabel8.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel8.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel8.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel8.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel8.TabIndex = 1112;
            kryptonLabel8.Values.Text = "000";
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonLabel9.Location = new Point(964, 0);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(91, 27);
            kryptonLabel9.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel9.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel9.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel9.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel9.TabIndex = 1111;
            kryptonLabel9.Values.Text = "Venda Nº";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonLabel2);
            kryptonPanel1.Controls.Add(cmbFormaPagamento);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            kryptonPanel1.Size = new Size(373, 39);
            kryptonPanel1.TabIndex = 1132;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(2, 8);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(99, 20);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 1038;
            kryptonLabel2.Values.Text = "Forma de Pgto:";
            // 
            // panelDatagrid
            // 
            panelDatagrid.Controls.Add(dgvParcelas);
            panelDatagrid.Controls.Add(kryptonLabel4);
            panelDatagrid.Dock = DockStyle.Fill;
            panelDatagrid.Location = new Point(3, 194);
            panelDatagrid.Name = "panelDatagrid";
            panelDatagrid.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            panelDatagrid.Size = new Size(373, 146);
            panelDatagrid.TabIndex = 1134;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Dock = DockStyle.Top;
            kryptonLabel4.Location = new Point(0, 0);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(373, 20);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel4.TabIndex = 1038;
            kryptonLabel4.Values.Text = "Parcelas geradas";
            // 
            // panelTitulo
            // 
            panelTitulo.Controls.Add(kryptonLabel5);
            panelTitulo.Controls.Add(iconPictureBox1);
            panelTitulo.Controls.Add(lblTotal);
            panelTitulo.Controls.Add(lblVendaNumero);
            panelTitulo.Controls.Add(lblVendaN);
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Dock = DockStyle.Fill;
            panelTitulo.Location = new Point(3, 3);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            panelTitulo.Size = new Size(373, 52);
            panelTitulo.TabIndex = 1;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(36, 33);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(46, 19);
            kryptonLabel5.StateCommon.ShortText.Color1 = SystemColors.ActiveCaptionText;
            kryptonLabel5.StateCommon.ShortText.Color2 = Color.FromArgb(44, 62, 80);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            kryptonLabel5.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel5.TabIndex = 1113;
            kryptonLabel5.Values.Text = "Total:";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = Color.Black;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            iconPictureBox1.IconColor = Color.Black;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 36;
            iconPictureBox1.Location = new Point(0, -2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(36, 36);
            iconPictureBox1.TabIndex = 1111;
            iconPictureBox1.TabStop = false;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(81, 33);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 19);
            lblTotal.StateCommon.ShortText.Color1 = Color.Red;
            lblTotal.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lblTotal.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTotal.TabIndex = 1115;
            lblTotal.Values.Text = "R$ 0,00";
            // 
            // lblVendaNumero
            // 
            lblVendaNumero.Location = new Point(272, 33);
            lblVendaNumero.Name = "lblVendaNumero";
            lblVendaNumero.Size = new Size(34, 19);
            lblVendaNumero.StateCommon.ShortText.Color1 = SystemColors.ActiveCaptionText;
            lblVendaNumero.StateCommon.ShortText.Color2 = Color.White;
            lblVendaNumero.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lblVendaNumero.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblVendaNumero.TabIndex = 1112;
            lblVendaNumero.Values.Text = "000";
            // 
            // lblVendaN
            // 
            lblVendaN.Location = new Point(218, 33);
            lblVendaN.Name = "lblVendaN";
            lblVendaN.Size = new Size(55, 19);
            lblVendaN.StateCommon.ShortText.Color1 = SystemColors.ActiveCaptionText;
            lblVendaN.StateCommon.ShortText.Color2 = Color.White;
            lblVendaN.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lblVendaN.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblVendaN.TabIndex = 1111;
            lblVendaN.Values.Text = "Venda:";
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(36, 7);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(158, 19);
            lblTitulo.StateCommon.ShortText.Color1 = SystemColors.ActiveCaptionText;
            lblTitulo.StateCommon.ShortText.Color2 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 1091;
            lblTitulo.Values.Text = "Detalhes do Pagamento";
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
            btnConfirmar.Location = new Point(254, 443);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Padding = new Padding(10, 0, 10, 0);
            btnConfirmar.Size = new Size(120, 32);
            btnConfirmar.TabIndex = 1124;
            btnConfirmar.Text = "    Confirmar";
            btnConfirmar.TextAlign = ContentAlignment.MiddleRight;
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FrmSelecionarPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(379, 475);
            Controls.Add(btnConfirmar);
            Controls.Add(pnlHeader);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
            Shown += FrmSelecionarPagamento_Shown;
            KeyDown += FrmSelecionarPagamento_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgvParcelas).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbFormaPagamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).EndInit();
            pnlHeader.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PanelDetalhes).EndInit();
            PanelDetalhes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelRecebimento).EndInit();
            panelRecebimento.ResumeLayout(false);
            panelRecebimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelParcelamento).EndInit();
            panelParcelamento.ResumeLayout(false);
            panelParcelamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelSubTitulo).EndInit();
            panelSubTitulo.ResumeLayout(false);
            panelSubTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelDatagrid).EndInit();
            panelDatagrid.ResumeLayout(false);
            panelDatagrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelTitulo).EndInit();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonPanel panelParcelamento;       
        private Krypton.Toolkit.KryptonComboBox cmbFormaPagamento;
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
        private Krypton.Toolkit.KryptonPanel panelTitulo;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Krypton.Toolkit.KryptonLabel lblRecebimento;
        private Krypton.Toolkit.KryptonLabel lblTotal;
               private Krypton.Toolkit.KryptonPanel panelParcelasDataGrid;
        private Krypton.Toolkit.KryptonLabel lblParcelasGeradas;
        private FontAwesome.Sharp.IconButton btnGerar;
        private FontAwesome.Sharp.IconButton btnConfirmar;
        private Krypton.Toolkit.KryptonPanel panelObservacao;
        private Krypton.Toolkit.KryptonLabel lblObservacao;
        private Krypton.Toolkit.KryptonLabel lblVendaNumero;
        private Krypton.Toolkit.KryptonLabel lblVendaN;
        private Krypton.Toolkit.KryptonLabel lblParcelamento;
        private Krypton.Toolkit.KryptonPanel panelSubTitulo;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonPanel panelDatagrid;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel lblObservacoes;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonPanel panelRecebimento;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        public Krypton.Toolkit.KryptonTextBox txtValorRecebido;
        private Label lblValorRecebido;
        public Krypton.Toolkit.KryptonTextBox txtTroco;
        private Label lblTroco;
        private Krypton.Toolkit.KryptonPanel PanelDetalhes;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
    }
}