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
            kryptonPalette2 = new Krypton.Toolkit.KryptonPalette(components);
            lblVendaNumero = new Label();
            lblVendaResumo = new Label();
            lblTotal = new Label();
            lblTotalResumo = new Label();
            lblFormaPgto = new Label();
            cmbFormaPagamento = new Krypton.Toolkit.KryptonComboBox();
            txtTroco = new Krypton.Toolkit.KryptonTextBox();
            lblTroco = new Label();
            lblValorRecebido = new Label();
            txtValorRecebido = new Krypton.Toolkit.KryptonTextBox();
            dgvParcelas = new Krypton.Toolkit.KryptonDataGridView();
            label7 = new Label();
            txtObservacao = new Krypton.Toolkit.KryptonTextBox();
            btnGerarParcelas = new Krypton.Toolkit.KryptonButton();
            numIntervalo = new Krypton.Toolkit.KryptonNumericUpDown();
            lblIntervalo = new Label();
            dtpPrimeiraParcela = new Krypton.Toolkit.KryptonDateTimePicker();
            numParcelas = new Krypton.Toolkit.KryptonNumericUpDown();
            lblNumParcelas = new Label();
            lblPrimeiraParcela = new Label();
            btnCancelar = new Krypton.Toolkit.KryptonButton();
            btnVoltar = new Krypton.Toolkit.KryptonButton();
            btnConfirmar = new Krypton.Toolkit.KryptonButton();
            dtInicio = new Krypton.Toolkit.KryptonDateTimePicker();
            cmbTipoUsuario = new Krypton.Toolkit.KryptonComboBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            pnlHeader = new Krypton.Toolkit.KryptonPanel();
            tlpTitulo = new Krypton.Toolkit.KryptonTableLayoutPanel();
            lblSubTitulo = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            iconAcao = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)cmbFormaPagamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvParcelas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbTipoUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).BeginInit();
            pnlHeader.SuspendLayout();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconAcao).BeginInit();
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
            // lblVendaNumero
            // 
            lblVendaNumero.AutoSize = true;
            lblVendaNumero.BackColor = Color.Transparent;
            lblVendaNumero.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblVendaNumero.ForeColor = Color.FromArgb(44, 62, 80);
            lblVendaNumero.Location = new Point(310, 83);
            lblVendaNumero.Name = "lblVendaNumero";
            lblVendaNumero.Size = new Size(40, 15);
            lblVendaNumero.TabIndex = 1055;
            lblVendaNumero.Text = "00218";
            lblVendaNumero.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVendaResumo
            // 
            lblVendaResumo.AutoSize = true;
            lblVendaResumo.BackColor = Color.Transparent;
            lblVendaResumo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblVendaResumo.ForeColor = Color.FromArgb(44, 62, 80);
            lblVendaResumo.Location = new Point(248, 83);
            lblVendaResumo.Name = "lblVendaResumo";
            lblVendaResumo.Size = new Size(60, 15);
            lblVendaResumo.TabIndex = 1054;
            lblVendaResumo.Text = "Venda Nº:";
            lblVendaResumo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(44, 62, 80);
            lblTotal.Location = new Point(230, 83);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(60, 15);
            lblTotal.TabIndex = 1051;
            lblTotal.Text = "R$ 918,00";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalResumo
            // 
            lblTotalResumo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalResumo.AutoSize = true;
            lblTotalResumo.BackColor = Color.Transparent;
            lblTotalResumo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTotalResumo.ForeColor = Color.FromArgb(44, 62, 80);
            lblTotalResumo.Location = new Point(169, 83);
            lblTotalResumo.Name = "lblTotalResumo";
            lblTotalResumo.Size = new Size(45, 15);
            lblTotalResumo.TabIndex = 1050;
            lblTotalResumo.Text = "TOTAL:";
            lblTotalResumo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFormaPgto
            // 
            lblFormaPgto.AutoSize = true;
            lblFormaPgto.BackColor = Color.Transparent;
            lblFormaPgto.Font = new Font("Segoe UI", 9.75F);
            lblFormaPgto.ForeColor = Color.FromArgb(44, 62, 80);
            lblFormaPgto.Location = new Point(4, 83);
            lblFormaPgto.Name = "lblFormaPgto";
            lblFormaPgto.Size = new Size(138, 17);
            lblFormaPgto.TabIndex = 1036;
            lblFormaPgto.Text = "Forma de pagamento:";
            // 
            // cmbFormaPagamento
            // 
            cmbFormaPagamento.CornerRoundingRadius = 10F;
            cmbFormaPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormaPagamento.DropDownWidth = 171;
            cmbFormaPagamento.IntegralHeight = false;
            cmbFormaPagamento.Location = new Point(3, 103);
            cmbFormaPagamento.Name = "cmbFormaPagamento";
            cmbFormaPagamento.Size = new Size(330, 29);
            cmbFormaPagamento.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(8, 142, 250);
            cmbFormaPagamento.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(8, 142, 250);
            cmbFormaPagamento.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbFormaPagamento.StateCommon.ComboBox.Border.Rounding = 10F;
            cmbFormaPagamento.StateCommon.ComboBox.Border.Width = 1;
            cmbFormaPagamento.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFormaPagamento.StateCommon.ComboBox.Content.Padding = new Padding(2, 3, 2, 3);
            cmbFormaPagamento.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbFormaPagamento.TabIndex = 1035;
            cmbFormaPagamento.TabStop = false;
            cmbFormaPagamento.SelectedIndexChanged += cmbFormaPagamento_SelectedIndexChanged;
            // 
            // txtTroco
            // 
            txtTroco.CharacterCasing = CharacterCasing.Upper;
            txtTroco.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtTroco.Location = new Point(173, 156);
            txtTroco.Name = "txtTroco";
            txtTroco.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtTroco.ReadOnly = true;
            txtTroco.Size = new Size(160, 30);
            txtTroco.StateCommon.Back.Color1 = Color.White;
            txtTroco.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtTroco.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtTroco.StateCommon.Border.ColorAngle = 1F;
            txtTroco.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTroco.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtTroco.StateCommon.Border.Rounding = 10F;
            txtTroco.StateCommon.Border.Width = 1;
            txtTroco.StateCommon.Content.Color1 = Color.Gray;
            txtTroco.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtTroco.StateCommon.Content.Padding = new Padding(2);
            txtTroco.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtTroco.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
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
            lblTroco.Location = new Point(175, 136);
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
            lblValorRecebido.Location = new Point(13, 136);
            lblValorRecebido.Name = "lblValorRecebido";
            lblValorRecebido.Size = new Size(100, 17);
            lblValorRecebido.TabIndex = 1037;
            lblValorRecebido.Text = "Valor Recebido:";
            lblValorRecebido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtValorRecebido
            // 
            txtValorRecebido.CharacterCasing = CharacterCasing.Upper;
            txtValorRecebido.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtValorRecebido.Location = new Point(3, 156);
            txtValorRecebido.Name = "txtValorRecebido";
            txtValorRecebido.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtValorRecebido.Size = new Size(160, 30);
            txtValorRecebido.StateCommon.Back.Color1 = Color.White;
            txtValorRecebido.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtValorRecebido.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtValorRecebido.StateCommon.Border.ColorAngle = 1F;
            txtValorRecebido.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtValorRecebido.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtValorRecebido.StateCommon.Border.Rounding = 10F;
            txtValorRecebido.StateCommon.Border.Width = 1;
            txtValorRecebido.StateCommon.Content.Color1 = Color.Gray;
            txtValorRecebido.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorRecebido.StateCommon.Content.Padding = new Padding(2);
            txtValorRecebido.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorRecebido.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtValorRecebido.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtValorRecebido.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorRecebido.TabIndex = 1059;
            // 
            // dgvParcelas
            // 
            dgvParcelas.AllowUserToAddRows = false;
            dgvParcelas.Location = new Point(3, 247);
            dgvParcelas.Name = "dgvParcelas";
            dgvParcelas.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueDarkMode;
            dgvParcelas.RowHeadersWidth = 23;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvParcelas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvParcelas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParcelas.Size = new Size(330, 110);
            dgvParcelas.TabIndex = 1037;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.ForeColor = Color.FromArgb(44, 62, 80);
            label7.Location = new Point(13, 362);
            label7.Name = "label7";
            label7.Size = new Size(81, 17);
            label7.TabIndex = 1037;
            label7.Text = "Observação:";
            // 
            // txtObservacao
            // 
            txtObservacao.CharacterCasing = CharacterCasing.Upper;
            txtObservacao.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtObservacao.Location = new Point(3, 379);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtObservacao.Size = new Size(337, 46);
            txtObservacao.StateCommon.Back.Color1 = Color.White;
            txtObservacao.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtObservacao.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtObservacao.StateCommon.Border.ColorAngle = 1F;
            txtObservacao.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtObservacao.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtObservacao.StateCommon.Border.Rounding = 10F;
            txtObservacao.StateCommon.Border.Width = 1;
            txtObservacao.StateCommon.Content.Color1 = Color.Gray;
            txtObservacao.StateCommon.Content.Font = new Font("Segoe UI", 12.75F);
            txtObservacao.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtObservacao.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtObservacao.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtObservacao.TabIndex = 1036;
            txtObservacao.TabStop = false;
            // 
            // btnGerarParcelas
            // 
            btnGerarParcelas.CornerRoundingRadius = 10F;
            btnGerarParcelas.Location = new Point(240, 213);
            btnGerarParcelas.Name = "btnGerarParcelas";
            btnGerarParcelas.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnGerarParcelas.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnGerarParcelas.OverrideDefault.Back.ColorAngle = 45F;
            btnGerarParcelas.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnGerarParcelas.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnGerarParcelas.OverrideDefault.Border.ColorAngle = 45F;
            btnGerarParcelas.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerarParcelas.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerarParcelas.OverrideDefault.Border.Rounding = 20F;
            btnGerarParcelas.OverrideDefault.Border.Width = 1;
            btnGerarParcelas.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnGerarParcelas.Size = new Size(93, 27);
            btnGerarParcelas.StateCommon.Back.Color1 = Color.FromArgb(0, 192, 0);
            btnGerarParcelas.StateCommon.Back.Color2 = Color.MediumSeaGreen;
            btnGerarParcelas.StateCommon.Back.ColorAngle = 45F;
            btnGerarParcelas.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnGerarParcelas.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnGerarParcelas.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerarParcelas.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerarParcelas.StateCommon.Border.Rounding = 10F;
            btnGerarParcelas.StateCommon.Border.Width = 1;
            btnGerarParcelas.StateCommon.Content.Padding = new Padding(2, 3, 2, 3);
            btnGerarParcelas.StateCommon.Content.ShortText.Color1 = Color.White;
            btnGerarParcelas.StateCommon.Content.ShortText.Color2 = Color.White;
            btnGerarParcelas.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnGerarParcelas.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnGerarParcelas.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnGerarParcelas.StatePressed.Back.ColorAngle = 135F;
            btnGerarParcelas.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnGerarParcelas.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnGerarParcelas.StatePressed.Border.ColorAngle = 135F;
            btnGerarParcelas.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerarParcelas.StatePressed.Border.Rounding = 20F;
            btnGerarParcelas.StatePressed.Border.Width = 1;
            btnGerarParcelas.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnGerarParcelas.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnGerarParcelas.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnGerarParcelas.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnGerarParcelas.StateTracking.Back.ColorAngle = 45F;
            btnGerarParcelas.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnGerarParcelas.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnGerarParcelas.StateTracking.Border.ColorAngle = 45F;
            btnGerarParcelas.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerarParcelas.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerarParcelas.StateTracking.Border.Rounding = 20F;
            btnGerarParcelas.StateTracking.Border.Width = 1;
            btnGerarParcelas.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnGerarParcelas.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnGerarParcelas.TabIndex = 1055;
            btnGerarParcelas.Values.Text = "Gerar";
            btnGerarParcelas.Click += btnGerarParcelas_Click;
            // 
            // numIntervalo
            // 
            numIntervalo.Location = new Point(70, 216);
            numIntervalo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numIntervalo.Name = "numIntervalo";
            numIntervalo.Size = new Size(60, 24);
            numIntervalo.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            numIntervalo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            numIntervalo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numIntervalo.StateCommon.Border.Rounding = 1F;
            numIntervalo.StateCommon.Border.Width = 1;
            numIntervalo.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            numIntervalo.StateCommon.Content.Padding = new Padding(2, 3, 2, 3);
            numIntervalo.TabIndex = 1054;
            numIntervalo.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // lblIntervalo
            // 
            lblIntervalo.AutoSize = true;
            lblIntervalo.BackColor = Color.Transparent;
            lblIntervalo.Font = new Font("Segoe UI", 9.75F);
            lblIntervalo.ForeColor = Color.FromArgb(44, 62, 80);
            lblIntervalo.Location = new Point(73, 195);
            lblIntervalo.Name = "lblIntervalo";
            lblIntervalo.Size = new Size(61, 17);
            lblIntervalo.TabIndex = 1053;
            lblIntervalo.Text = "Intervalo:";
            // 
            // dtpPrimeiraParcela
            // 
            dtpPrimeiraParcela.CalendarTodayDate = new DateTime(2025, 12, 24, 0, 0, 0, 0);
            dtpPrimeiraParcela.CornerRoundingRadius = 1F;
            dtpPrimeiraParcela.Format = DateTimePickerFormat.Short;
            dtpPrimeiraParcela.Location = new Point(137, 217);
            dtpPrimeiraParcela.Name = "dtpPrimeiraParcela";
            dtpPrimeiraParcela.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            dtpPrimeiraParcela.Size = new Size(97, 21);
            dtpPrimeiraParcela.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpPrimeiraParcela.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtpPrimeiraParcela.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpPrimeiraParcela.StateCommon.Border.Rounding = 1F;
            dtpPrimeiraParcela.StateCommon.Border.Width = 1;
            dtpPrimeiraParcela.StateCommon.Content.Padding = new Padding(3);
            dtpPrimeiraParcela.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dtpPrimeiraParcela.TabIndex = 1051;
            // 
            // numParcelas
            // 
            numParcelas.Location = new Point(5, 216);
            numParcelas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numParcelas.Name = "numParcelas";
            numParcelas.Size = new Size(60, 24);
            numParcelas.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            numParcelas.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            numParcelas.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numParcelas.StateCommon.Border.Rounding = 1F;
            numParcelas.StateCommon.Border.Width = 1;
            numParcelas.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            numParcelas.StateCommon.Content.Padding = new Padding(3);
            numParcelas.TabIndex = 1050;
            numParcelas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNumParcelas
            // 
            lblNumParcelas.AutoSize = true;
            lblNumParcelas.BackColor = Color.Transparent;
            lblNumParcelas.Font = new Font("Segoe UI", 9.75F);
            lblNumParcelas.ForeColor = Color.FromArgb(44, 62, 80);
            lblNumParcelas.Location = new Point(3, 195);
            lblNumParcelas.Name = "lblNumParcelas";
            lblNumParcelas.Size = new Size(59, 17);
            lblNumParcelas.TabIndex = 1049;
            lblNumParcelas.Text = "Nº Parc.:";
            // 
            // lblPrimeiraParcela
            // 
            lblPrimeiraParcela.AutoSize = true;
            lblPrimeiraParcela.BackColor = Color.Transparent;
            lblPrimeiraParcela.Font = new Font("Segoe UI", 9.75F);
            lblPrimeiraParcela.ForeColor = Color.FromArgb(44, 62, 80);
            lblPrimeiraParcela.Location = new Point(137, 195);
            lblPrimeiraParcela.Name = "lblPrimeiraParcela";
            lblPrimeiraParcela.Size = new Size(70, 17);
            lblPrimeiraParcela.TabIndex = 1052;
            lblPrimeiraParcela.Text = "1º Parcela:";
            // 
            // btnCancelar
            // 
            btnCancelar.CornerRoundingRadius = 10F;
            btnCancelar.Location = new Point(124, 433);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.OverrideDefault.Back.ColorAngle = 45F;
            btnCancelar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.OverrideDefault.Border.ColorAngle = 45F;
            btnCancelar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.OverrideDefault.Border.Rounding = 20F;
            btnCancelar.OverrideDefault.Border.Width = 1;
            btnCancelar.Size = new Size(95, 27);
            btnCancelar.StateCommon.Back.Color1 = Color.Red;
            btnCancelar.StateCommon.Back.Color2 = Color.Red;
            btnCancelar.StateCommon.Back.ColorAngle = 45F;
            btnCancelar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.StateCommon.Border.Rounding = 10F;
            btnCancelar.StateCommon.Border.Width = 1;
            btnCancelar.StateCommon.Content.Padding = new Padding(2, 3, 2, 3);
            btnCancelar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnCancelar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCancelar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 8.25F);
            btnCancelar.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnCancelar.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnCancelar.StatePressed.Back.ColorAngle = 135F;
            btnCancelar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnCancelar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnCancelar.StatePressed.Border.ColorAngle = 135F;
            btnCancelar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StatePressed.Border.Rounding = 20F;
            btnCancelar.StatePressed.Border.Width = 1;
            btnCancelar.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnCancelar.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnCancelar.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnCancelar.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnCancelar.StateTracking.Back.ColorAngle = 45F;
            btnCancelar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.StateTracking.Border.ColorAngle = 45F;
            btnCancelar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.StateTracking.Border.Rounding = 20F;
            btnCancelar.StateTracking.Border.Width = 1;
            btnCancelar.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnCancelar.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnCancelar.TabIndex = 1022;
            btnCancelar.TabStop = false;
            btnCancelar.Values.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.CornerRoundingRadius = 10F;
            btnVoltar.Location = new Point(240, 431);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnVoltar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnVoltar.OverrideDefault.Back.ColorAngle = 45F;
            btnVoltar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnVoltar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnVoltar.OverrideDefault.Border.ColorAngle = 45F;
            btnVoltar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnVoltar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnVoltar.OverrideDefault.Border.Rounding = 20F;
            btnVoltar.OverrideDefault.Border.Width = 1;
            btnVoltar.Size = new Size(95, 27);
            btnVoltar.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnVoltar.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnVoltar.StateCommon.Back.ColorAngle = 45F;
            btnVoltar.StateCommon.Border.Color1 = Color.FromArgb(8, 148, 252);
            btnVoltar.StateCommon.Border.Color2 = Color.FromArgb(8, 148, 252);
            btnVoltar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnVoltar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnVoltar.StateCommon.Border.Rounding = 10F;
            btnVoltar.StateCommon.Border.Width = 1;
            btnVoltar.StateCommon.Content.Padding = new Padding(2, 3, 2, 3);
            btnVoltar.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnVoltar.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnVoltar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 8.25F);
            btnVoltar.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnVoltar.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnVoltar.StatePressed.Back.ColorAngle = 135F;
            btnVoltar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnVoltar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnVoltar.StatePressed.Border.ColorAngle = 135F;
            btnVoltar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnVoltar.StatePressed.Border.Rounding = 20F;
            btnVoltar.StatePressed.Border.Width = 1;
            btnVoltar.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnVoltar.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnVoltar.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnVoltar.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnVoltar.StateTracking.Back.ColorAngle = 45F;
            btnVoltar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnVoltar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnVoltar.StateTracking.Border.ColorAngle = 45F;
            btnVoltar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnVoltar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnVoltar.StateTracking.Border.Rounding = 20F;
            btnVoltar.StateTracking.Border.Width = 1;
            btnVoltar.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnVoltar.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnVoltar.TabIndex = 1021;
            btnVoltar.TabStop = false;
            btnVoltar.Values.Text = "Voltar";
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.CornerRoundingRadius = 10F;
            btnConfirmar.Location = new Point(8, 433);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmar.OverrideDefault.Back.ColorAngle = 45F;
            btnConfirmar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmar.OverrideDefault.Border.ColorAngle = 45F;
            btnConfirmar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmar.OverrideDefault.Border.Rounding = 20F;
            btnConfirmar.OverrideDefault.Border.Width = 1;
            btnConfirmar.Size = new Size(95, 27);
            btnConfirmar.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnConfirmar.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmar.StateCommon.Back.ColorAngle = 45F;
            btnConfirmar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmar.StateCommon.Border.Rounding = 10F;
            btnConfirmar.StateCommon.Border.Width = 1;
            btnConfirmar.StateCommon.Content.Padding = new Padding(2, 3, 2, 3);
            btnConfirmar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnConfirmar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnConfirmar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 8.25F);
            btnConfirmar.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnConfirmar.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnConfirmar.StatePressed.Back.ColorAngle = 135F;
            btnConfirmar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnConfirmar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnConfirmar.StatePressed.Border.ColorAngle = 135F;
            btnConfirmar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmar.StatePressed.Border.Rounding = 20F;
            btnConfirmar.StatePressed.Border.Width = 1;
            btnConfirmar.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnConfirmar.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnConfirmar.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnConfirmar.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnConfirmar.StateTracking.Back.ColorAngle = 45F;
            btnConfirmar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmar.StateTracking.Border.ColorAngle = 45F;
            btnConfirmar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmar.StateTracking.Border.Rounding = 20F;
            btnConfirmar.StateTracking.Border.Width = 1;
            btnConfirmar.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnConfirmar.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnConfirmar.TabIndex = 1017;
            btnConfirmar.TabStop = false;
            btnConfirmar.Values.Text = "Confirmar";
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // dtInicio
            // 
            dtInicio.CornerRoundingRadius = 3F;
            dtInicio.Format = DateTimePickerFormat.Short;
            dtInicio.Location = new Point(227, 503);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(172, 29);
            dtInicio.StateActive.Back.Color1 = Color.FromArgb(6, 174, 244);
            dtInicio.StateActive.Border.Color1 = Color.FromArgb(6, 174, 244);
            dtInicio.StateActive.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtInicio.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtInicio.StateActive.Border.Rounding = 3F;
            dtInicio.StateActive.Content.Color1 = Color.White;
            dtInicio.StateActive.Content.Font = new Font("Poppins", 9F);
            dtInicio.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtInicio.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtInicio.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtInicio.StateCommon.Border.ColorAngle = 45F;
            dtInicio.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtInicio.StateCommon.Border.Rounding = 3F;
            dtInicio.StateCommon.Border.Width = 1;
            dtInicio.StateCommon.Content.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtInicio.StateCommon.Content.Padding = new Padding(1);
            dtInicio.StateDisabled.Border.ColorAngle = 45F;
            dtInicio.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtInicio.StateDisabled.Border.Rounding = 3F;
            dtInicio.StateDisabled.Border.Width = 1;
            dtInicio.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtInicio.StateNormal.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtInicio.StateNormal.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtInicio.StateNormal.Border.ColorAngle = 45F;
            dtInicio.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtInicio.StateNormal.Border.Rounding = 3F;
            dtInicio.StateNormal.Border.Width = 1;
            dtInicio.StateNormal.Content.Color1 = Color.White;
            dtInicio.TabIndex = 1100;
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.CornerRoundingRadius = 6F;
            cmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoUsuario.DropDownWidth = 115;
            cmbTipoUsuario.IntegralHeight = false;
            cmbTipoUsuario.Items.AddRange(new object[] { "Administrador", "Operador", "Visitante" });
            cmbTipoUsuario.Location = new Point(227, 472);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbTipoUsuario.Size = new Size(172, 25);
            cmbTipoUsuario.StateActive.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoUsuario.StateActive.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoUsuario.StateActive.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbTipoUsuario.StateActive.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoUsuario.StateActive.ComboBox.Content.Color1 = Color.White;
            cmbTipoUsuario.StateActive.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbTipoUsuario.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoUsuario.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoUsuario.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbTipoUsuario.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoUsuario.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbTipoUsuario.StateCommon.ComboBox.Content.Color1 = Color.White;
            cmbTipoUsuario.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbTipoUsuario.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbTipoUsuario.StateNormal.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoUsuario.StateNormal.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoUsuario.StateNormal.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbTipoUsuario.StateNormal.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoUsuario.StateNormal.ComboBox.Content.Color1 = Color.White;
            cmbTipoUsuario.StateNormal.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbTipoUsuario.StateTracking.Item.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoUsuario.StateTracking.Item.Back.Color2 = Color.FromArgb(30, 136, 229);
            cmbTipoUsuario.StateTracking.Item.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoUsuario.StateTracking.Item.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbTipoUsuario.StateTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoUsuario.StateTracking.Item.Content.ShortText.Color1 = Color.White;
            cmbTipoUsuario.StateTracking.Item.Content.ShortText.Color2 = Color.White;
            cmbTipoUsuario.StateTracking.Item.Content.ShortText.Font = new Font("Segoe UI", 9F);
            cmbTipoUsuario.TabIndex = 1099;
            cmbTipoUsuario.TabStop = false;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            iconButton1.BackColor = Color.FromArgb(255, 152, 0);
            iconButton1.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 28;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(98, 494);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(120, 38);
            iconButton1.TabIndex = 1111;
            iconButton1.Text = "Cancelar";
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(tlpTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(411, 62);
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
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 67.7419357F));
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 32.2580643F));
            tlpTitulo.Size = new Size(411, 62);
            tlpTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            tlpTitulo.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            tlpTitulo.TabIndex = 0;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.Dock = DockStyle.Fill;
            lblSubTitulo.Location = new Point(3, 45);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(405, 14);
            lblSubTitulo.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Color2 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblSubTitulo.TabIndex = 0;
            lblSubTitulo.Values.Text = "Controle, consulta e acompanhamento de vendas";
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(lblTitulo);
            kryptonPanel3.Controls.Add(iconAcao);
            kryptonPanel3.Dock = DockStyle.Fill;
            kryptonPanel3.Location = new Point(3, 3);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(405, 36);
            kryptonPanel3.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            kryptonPanel3.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(120, 2);
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
            iconAcao.IconChar = FontAwesome.Sharp.IconChar.Upload;
            iconAcao.IconColor = Color.White;
            iconAcao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAcao.IconSize = 28;
            iconAcao.Location = new Point(86, 2);
            iconAcao.Name = "iconAcao";
            iconAcao.Size = new Size(28, 28);
            iconAcao.TabIndex = 1110;
            iconAcao.TabStop = false;
            // 
            // FrmSelecionarPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(411, 620);
            Controls.Add(pnlHeader);
            Controls.Add(iconButton1);
            Controls.Add(dtInicio);
            Controls.Add(cmbTipoUsuario);
            Controls.Add(lblVendaNumero);
            Controls.Add(lblFormaPgto);
            Controls.Add(lblVendaResumo);
            Controls.Add(txtTroco);
            Controls.Add(cmbFormaPagamento);
            Controls.Add(lblTotal);
            Controls.Add(btnGerarParcelas);
            Controls.Add(lblTotalResumo);
            Controls.Add(lblTroco);
            Controls.Add(numIntervalo);
            Controls.Add(lblValorRecebido);
            Controls.Add(btnCancelar);
            Controls.Add(txtValorRecebido);
            Controls.Add(lblIntervalo);
            Controls.Add(btnVoltar);
            Controls.Add(dtpPrimeiraParcela);
            Controls.Add(dgvParcelas);
            Controls.Add(numParcelas);
            Controls.Add(btnConfirmar);
            Controls.Add(lblNumParcelas);
            Controls.Add(label7);
            Controls.Add(lblPrimeiraParcela);
            Controls.Add(txtObservacao);
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
            ((System.ComponentModel.ISupportInitialize)cmbFormaPagamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvParcelas).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbTipoUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).EndInit();
            pnlHeader.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconAcao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonPalette kryptonPalette2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private Label lblTotal;
        private Label lblTotalResumo;
        private Label lblFormaPgto;
        private Krypton.Toolkit.KryptonComboBox cmbFormaPagamento;
        private Label lblValorRecebido;
        public Krypton.Toolkit.KryptonTextBox txtValorRecebido;
        public Krypton.Toolkit.KryptonTextBox txtTroco;
        private Label lblTroco;
        private Krypton.Toolkit.KryptonNumericUpDown numIntervalo;
        private Label lblIntervalo;
        private Krypton.Toolkit.KryptonDateTimePicker dtpPrimeiraParcela;
        private Krypton.Toolkit.KryptonNumericUpDown numParcelas;
        private Label lblNumParcelas;
        private Label lblPrimeiraParcela;
        public Krypton.Toolkit.KryptonButton btnGerarParcelas;
        public Krypton.Toolkit.KryptonDataGridView dgvParcelas;
        private Label label7;
        public Krypton.Toolkit.KryptonTextBox txtObservacao;
        public Krypton.Toolkit.KryptonButton btnConfirmar;
        public Krypton.Toolkit.KryptonButton btnVoltar;
        public Krypton.Toolkit.KryptonButton btnCancelar;
        private Label lblVendaNumero;
        private Label lblVendaResumo;
        public Krypton.Toolkit.KryptonDateTimePicker dtInicio;
        public Krypton.Toolkit.KryptonComboBox cmbTipoUsuario;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Krypton.Toolkit.KryptonPanel pnlHeader;
        private Krypton.Toolkit.KryptonTableLayoutPanel tlpTitulo;
        private Krypton.Toolkit.KryptonLabel lblSubTitulo;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private FontAwesome.Sharp.IconPictureBox iconAcao;
    }
}