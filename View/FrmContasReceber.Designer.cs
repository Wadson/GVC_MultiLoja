namespace GVC.View
{
    partial class FrmContasReceber
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
            txtNomeCliente = new Krypton.Toolkit.KryptonTextBox();
            lblNomeCliente = new Label();
            txtNumeroVenda = new Krypton.Toolkit.KryptonTextBox();
            lblNumeroVenda = new Label();
            dtpVencInicial = new Krypton.Toolkit.KryptonDateTimePicker();
            lblVenctoInicial = new Label();
            lblVenctoFinal = new Label();
            dtpVencFinal = new Krypton.Toolkit.KryptonDateTimePicker();
            cmbStatusParcela = new Krypton.Toolkit.KryptonComboBox();
            lblStatusParcela = new Label();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            btnLimparFiltro = new Krypton.Toolkit.KryptonButton();
            label1 = new Label();
            cmbTipoPesquisa = new Krypton.Toolkit.KryptonComboBox();
            btnPesquisar = new Krypton.Toolkit.KryptonButton();
            dgvContasAReceber = new Krypton.Toolkit.KryptonDataGridView();
            btnSair = new Krypton.Toolkit.KryptonButton();
            btnExtrato = new Krypton.Toolkit.KryptonButton();
            btnBaixarParcela = new Krypton.Toolkit.KryptonButton();
            btnEstornarPagamento = new Krypton.Toolkit.KryptonButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            dgvPagamentos = new Krypton.Toolkit.KryptonDataGridView();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            lblTotalSelect = new Label();
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblQtdContasPagas = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            lblTotalContasPagas = new ToolStripStatusLabel();
            toolStripStatusLabel6 = new ToolStripStatusLabel();
            toolStripStatusLabel7 = new ToolStripStatusLabel();
            lblQtdeContasReceber = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel5 = new ToolStripStatusLabel();
            lblTotalContasReceber = new ToolStripStatusLabel();
            toolStripStatusLabel8 = new ToolStripStatusLabel();
            lblTotalSelecionado = new ToolStripStatusLabel();
            toolStripStatusLabel10 = new ToolStripStatusLabel();
            toolStripStatusLabel9 = new ToolStripStatusLabel();
            txtTotalVencido = new ToolStripStatusLabel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            btnRecibo = new Krypton.Toolkit.KryptonButton();
            btnVerItensVenda = new Krypton.Toolkit.KryptonButton();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)cmbStatusParcela).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbTipoPesquisa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvContasAReceber).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPagamentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            kryptonStatusStrip1.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
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
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(236, 240, 241);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(236, 240, 241);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(10, -1, -1, -1);
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtNomeCliente.Location = new Point(175, 20);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtNomeCliente.Size = new Size(319, 24);
            txtNomeCliente.StateCommon.Back.Color1 = Color.White;
            txtNomeCliente.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNomeCliente.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNomeCliente.StateCommon.Border.ColorAngle = 1F;
            txtNomeCliente.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNomeCliente.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNomeCliente.StateCommon.Border.Rounding = 6F;
            txtNomeCliente.StateCommon.Border.Width = 1;
            txtNomeCliente.StateCommon.Content.Color1 = Color.Gray;
            txtNomeCliente.StateCommon.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeCliente.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNomeCliente.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtNomeCliente.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtNomeCliente.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtNomeCliente.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtNomeCliente.TabIndex = 0;
            txtNomeCliente.TextChanged += txtNomeCliente_TextChanged;
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.BackColor = Color.Transparent;
            lblNomeCliente.Font = new Font("Segoe UI", 9.75F);
            lblNomeCliente.ForeColor = Color.FromArgb(44, 62, 80);
            lblNomeCliente.Location = new Point(181, 1);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(87, 17);
            lblNomeCliente.TabIndex = 1027;
            lblNomeCliente.Text = "Nome Cliente";
            // 
            // txtNumeroVenda
            // 
            txtNumeroVenda.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtNumeroVenda.Location = new Point(175, 20);
            txtNumeroVenda.Name = "txtNumeroVenda";
            txtNumeroVenda.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtNumeroVenda.Size = new Size(68, 24);
            txtNumeroVenda.StateCommon.Back.Color1 = Color.White;
            txtNumeroVenda.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNumeroVenda.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNumeroVenda.StateCommon.Border.ColorAngle = 1F;
            txtNumeroVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNumeroVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNumeroVenda.StateCommon.Border.Rounding = 6F;
            txtNumeroVenda.StateCommon.Border.Width = 1;
            txtNumeroVenda.StateCommon.Content.Color1 = Color.Gray;
            txtNumeroVenda.StateCommon.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumeroVenda.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNumeroVenda.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtNumeroVenda.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtNumeroVenda.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtNumeroVenda.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtNumeroVenda.TabIndex = 1;
            txtNumeroVenda.TextAlign = HorizontalAlignment.Center;
            // 
            // lblNumeroVenda
            // 
            lblNumeroVenda.AutoSize = true;
            lblNumeroVenda.BackColor = Color.Transparent;
            lblNumeroVenda.Font = new Font("Segoe UI", 9.75F);
            lblNumeroVenda.ForeColor = Color.FromArgb(44, 62, 80);
            lblNumeroVenda.Location = new Point(178, 1);
            lblNumeroVenda.Name = "lblNumeroVenda";
            lblNumeroVenda.Size = new Size(64, 17);
            lblNumeroVenda.TabIndex = 1029;
            lblNumeroVenda.Text = "Nº Venda";
            // 
            // dtpVencInicial
            // 
            dtpVencInicial.CornerRoundingRadius = 6F;
            dtpVencInicial.Format = DateTimePickerFormat.Short;
            dtpVencInicial.Location = new Point(175, 19);
            dtpVencInicial.Name = "dtpVencInicial";
            dtpVencInicial.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            dtpVencInicial.Size = new Size(104, 25);
            dtpVencInicial.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpVencInicial.StateCommon.Border.Rounding = 6F;
            dtpVencInicial.StateCommon.Border.Width = 1;
            dtpVencInicial.TabIndex = 2;
            // 
            // lblVenctoInicial
            // 
            lblVenctoInicial.AutoSize = true;
            lblVenctoInicial.BackColor = Color.Transparent;
            lblVenctoInicial.Font = new Font("Segoe UI", 9.75F);
            lblVenctoInicial.ForeColor = Color.FromArgb(44, 62, 80);
            lblVenctoInicial.Location = new Point(181, 1);
            lblVenctoInicial.Name = "lblVenctoInicial";
            lblVenctoInicial.Size = new Size(83, 17);
            lblVenctoInicial.TabIndex = 1031;
            lblVenctoInicial.Text = "Vencto Inicial";
            // 
            // lblVenctoFinal
            // 
            lblVenctoFinal.AutoSize = true;
            lblVenctoFinal.BackColor = Color.Transparent;
            lblVenctoFinal.Font = new Font("Segoe UI", 9.75F);
            lblVenctoFinal.ForeColor = Color.FromArgb(44, 62, 80);
            lblVenctoFinal.Location = new Point(287, 1);
            lblVenctoFinal.Name = "lblVenctoFinal";
            lblVenctoFinal.Size = new Size(77, 17);
            lblVenctoFinal.TabIndex = 1033;
            lblVenctoFinal.Text = "Vencto Final";
            // 
            // dtpVencFinal
            // 
            dtpVencFinal.CornerRoundingRadius = 6F;
            dtpVencFinal.Format = DateTimePickerFormat.Short;
            dtpVencFinal.Location = new Point(279, 19);
            dtpVencFinal.Name = "dtpVencFinal";
            dtpVencFinal.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            dtpVencFinal.Size = new Size(104, 25);
            dtpVencFinal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpVencFinal.StateCommon.Border.Rounding = 6F;
            dtpVencFinal.StateCommon.Border.Width = 1;
            dtpVencFinal.TabIndex = 3;
            // 
            // cmbStatusParcela
            // 
            cmbStatusParcela.CornerRoundingRadius = 6F;
            cmbStatusParcela.DropDownWidth = 171;
            cmbStatusParcela.IntegralHeight = false;
            cmbStatusParcela.Items.AddRange(new object[] { " Aberta              ", " Atrasada            ", " AguardandoPagamento", " Pago                ", " Cancelada           ", " Devolvida           ", " ParcialmentePago   " });
            cmbStatusParcela.Location = new Point(175, 19);
            cmbStatusParcela.Name = "cmbStatusParcela";
            cmbStatusParcela.Size = new Size(116, 25);
            cmbStatusParcela.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbStatusParcela.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbStatusParcela.StateCommon.ComboBox.Border.Width = 1;
            cmbStatusParcela.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbStatusParcela.TabIndex = 1034;
            // 
            // lblStatusParcela
            // 
            lblStatusParcela.AutoSize = true;
            lblStatusParcela.BackColor = Color.Transparent;
            lblStatusParcela.Font = new Font("Segoe UI", 9.75F);
            lblStatusParcela.ForeColor = Color.FromArgb(44, 62, 80);
            lblStatusParcela.Location = new Point(185, 1);
            lblStatusParcela.Name = "lblStatusParcela";
            lblStatusParcela.Size = new Size(89, 17);
            lblStatusParcela.TabIndex = 1035;
            lblStatusParcela.Text = "Status Parcela";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(btnLimparFiltro);
            kryptonPanel1.Controls.Add(label1);
            kryptonPanel1.Controls.Add(cmbTipoPesquisa);
            kryptonPanel1.Controls.Add(lblNumeroVenda);
            kryptonPanel1.Controls.Add(lblStatusParcela);
            kryptonPanel1.Controls.Add(lblNomeCliente);
            kryptonPanel1.Controls.Add(btnPesquisar);
            kryptonPanel1.Controls.Add(txtNumeroVenda);
            kryptonPanel1.Controls.Add(txtNomeCliente);
            kryptonPanel1.Controls.Add(cmbStatusParcela);
            kryptonPanel1.Controls.Add(lblVenctoFinal);
            kryptonPanel1.Controls.Add(dtpVencInicial);
            kryptonPanel1.Controls.Add(lblVenctoInicial);
            kryptonPanel1.Controls.Add(dtpVencFinal);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(3, 28);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            kryptonPanel1.Size = new Size(911, 54);
            kryptonPanel1.TabIndex = 1038;
            // 
            // btnLimparFiltro
            // 
            btnLimparFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimparFiltro.CornerRoundingRadius = 10F;
            btnLimparFiltro.Location = new Point(808, 18);
            btnLimparFiltro.Margin = new Padding(5, 3, 5, 3);
            btnLimparFiltro.Name = "btnLimparFiltro";
            btnLimparFiltro.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnLimparFiltro.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnLimparFiltro.OverrideDefault.Back.ColorAngle = 45F;
            btnLimparFiltro.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnLimparFiltro.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLimparFiltro.OverrideDefault.Border.ColorAngle = 45F;
            btnLimparFiltro.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLimparFiltro.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLimparFiltro.OverrideDefault.Border.Rounding = 20F;
            btnLimparFiltro.OverrideDefault.Border.Width = 1;
            btnLimparFiltro.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnLimparFiltro.Size = new Size(95, 27);
            btnLimparFiltro.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnLimparFiltro.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnLimparFiltro.StateCommon.Back.ColorAngle = 45F;
            btnLimparFiltro.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLimparFiltro.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLimparFiltro.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLimparFiltro.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLimparFiltro.StateCommon.Border.Rounding = 10F;
            btnLimparFiltro.StateCommon.Border.Width = 1;
            btnLimparFiltro.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnLimparFiltro.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLimparFiltro.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 8.25F);
            btnLimparFiltro.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnLimparFiltro.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnLimparFiltro.StatePressed.Back.ColorAngle = 135F;
            btnLimparFiltro.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnLimparFiltro.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnLimparFiltro.StatePressed.Border.ColorAngle = 135F;
            btnLimparFiltro.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLimparFiltro.StatePressed.Border.Rounding = 20F;
            btnLimparFiltro.StatePressed.Border.Width = 1;
            btnLimparFiltro.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLimparFiltro.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnLimparFiltro.StateTracking.Back.ColorAngle = 45F;
            btnLimparFiltro.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLimparFiltro.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLimparFiltro.StateTracking.Border.ColorAngle = 45F;
            btnLimparFiltro.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLimparFiltro.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLimparFiltro.StateTracking.Border.Rounding = 20F;
            btnLimparFiltro.StateTracking.Border.Width = 1;
            btnLimparFiltro.StateTracking.Content.ShortText.Color1 = Color.White;
            btnLimparFiltro.TabIndex = 1070;
            btnLimparFiltro.Values.Text = "Limpar Filtro";
            btnLimparFiltro.Click += btnLimparFiltro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(8, -2);
            label1.Name = "label1";
            label1.Size = new Size(111, 17);
            label1.TabIndex = 1039;
            label1.Text = "Filtro de Pesquisa";
            // 
            // cmbTipoPesquisa
            // 
            cmbTipoPesquisa.CornerRoundingRadius = 6F;
            cmbTipoPesquisa.DropDownWidth = 171;
            cmbTipoPesquisa.IntegralHeight = false;
            cmbTipoPesquisa.Items.AddRange(new object[] { "Todos", "Nome do Cliente", "Número da Venda", "Data da Venda", "Período da Venda", "Vencimento", "Período de Vencimento", "Status da Parcela" });
            cmbTipoPesquisa.Location = new Point(8, 19);
            cmbTipoPesquisa.Name = "cmbTipoPesquisa";
            cmbTipoPesquisa.Size = new Size(161, 25);
            cmbTipoPesquisa.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoPesquisa.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbTipoPesquisa.StateCommon.ComboBox.Border.Width = 1;
            cmbTipoPesquisa.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbTipoPesquisa.TabIndex = 1038;
            cmbTipoPesquisa.TabStop = false;
            cmbTipoPesquisa.SelectedIndexChanged += cmbTipoPesquisa_SelectedIndexChanged;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.CornerRoundingRadius = 10F;
            btnPesquisar.Location = new Point(708, 18);
            btnPesquisar.Margin = new Padding(5, 3, 5, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnPesquisar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnPesquisar.OverrideDefault.Back.ColorAngle = 45F;
            btnPesquisar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnPesquisar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnPesquisar.OverrideDefault.Border.ColorAngle = 45F;
            btnPesquisar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnPesquisar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnPesquisar.OverrideDefault.Border.Rounding = 20F;
            btnPesquisar.OverrideDefault.Border.Width = 1;
            btnPesquisar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnPesquisar.Size = new Size(95, 27);
            btnPesquisar.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnPesquisar.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnPesquisar.StateCommon.Back.ColorAngle = 45F;
            btnPesquisar.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnPesquisar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnPesquisar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnPesquisar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnPesquisar.StateCommon.Border.Rounding = 10F;
            btnPesquisar.StateCommon.Border.Width = 1;
            btnPesquisar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnPesquisar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnPesquisar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 8.25F);
            btnPesquisar.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnPesquisar.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnPesquisar.StatePressed.Back.ColorAngle = 135F;
            btnPesquisar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnPesquisar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnPesquisar.StatePressed.Border.ColorAngle = 135F;
            btnPesquisar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnPesquisar.StatePressed.Border.Rounding = 20F;
            btnPesquisar.StatePressed.Border.Width = 1;
            btnPesquisar.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnPesquisar.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnPesquisar.StateTracking.Back.ColorAngle = 45F;
            btnPesquisar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnPesquisar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnPesquisar.StateTracking.Border.ColorAngle = 45F;
            btnPesquisar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnPesquisar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnPesquisar.StateTracking.Border.Rounding = 20F;
            btnPesquisar.StateTracking.Border.Width = 1;
            btnPesquisar.TabIndex = 1066;
            btnPesquisar.Values.Text = "Pesquisar";
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // dgvContasAReceber
            // 
            dgvContasAReceber.Dock = DockStyle.Fill;
            dgvContasAReceber.Location = new Point(3, 88);
            dgvContasAReceber.Name = "dgvContasAReceber";
            dgvContasAReceber.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            dgvContasAReceber.Size = new Size(911, 165);
            dgvContasAReceber.TabIndex = 1039;
            dgvContasAReceber.TabStop = false;
            dgvContasAReceber.CellFormatting += dgvContasAReceber_CellFormatting;
            dgvContasAReceber.CellValueChanged += dgvContasAReceber_CellValueChanged;
            dgvContasAReceber.CurrentCellDirtyStateChanged += dgvContasAReceber_CurrentCellDirtyStateChanged;
            dgvContasAReceber.SelectionChanged += dgvContasAReceber_SelectionChanged;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSair.CornerRoundingRadius = 10F;
            btnSair.Location = new Point(818, 3);
            btnSair.Margin = new Padding(5, 3, 5, 3);
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
            btnSair.Size = new Size(90, 27);
            btnSair.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnSair.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnSair.StateCommon.Back.ColorAngle = 45F;
            btnSair.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateCommon.Border.Rounding = 10F;
            btnSair.StateCommon.Border.Width = 1;
            btnSair.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
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
            btnSair.StateTracking.Content.ShortText.Color1 = Color.White;
            btnSair.TabIndex = 1068;
            toolTip1.SetToolTip(btnSair, "Fechar tela");
            btnSair.Values.Text = "Sair";
            btnSair.Click += btnSair_Click;
            // 
            // btnExtrato
            // 
            btnExtrato.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExtrato.CornerRoundingRadius = 10F;
            btnExtrato.Location = new Point(518, 3);
            btnExtrato.Margin = new Padding(5, 3, 5, 3);
            btnExtrato.Name = "btnExtrato";
            btnExtrato.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnExtrato.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnExtrato.OverrideDefault.Back.ColorAngle = 45F;
            btnExtrato.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnExtrato.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExtrato.OverrideDefault.Border.ColorAngle = 45F;
            btnExtrato.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExtrato.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExtrato.OverrideDefault.Border.Rounding = 20F;
            btnExtrato.OverrideDefault.Border.Width = 1;
            btnExtrato.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnExtrato.Size = new Size(90, 27);
            btnExtrato.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnExtrato.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnExtrato.StateCommon.Back.ColorAngle = 45F;
            btnExtrato.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExtrato.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExtrato.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExtrato.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExtrato.StateCommon.Border.Rounding = 10F;
            btnExtrato.StateCommon.Border.Width = 1;
            btnExtrato.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 148, 252);
            btnExtrato.StateCommon.Content.ShortText.Color2 = Color.FromArgb(8, 148, 252);
            btnExtrato.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnExtrato.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnExtrato.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnExtrato.StatePressed.Back.ColorAngle = 135F;
            btnExtrato.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnExtrato.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnExtrato.StatePressed.Border.ColorAngle = 135F;
            btnExtrato.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExtrato.StatePressed.Border.Rounding = 20F;
            btnExtrato.StatePressed.Border.Width = 1;
            btnExtrato.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnExtrato.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnExtrato.StateTracking.Back.ColorAngle = 45F;
            btnExtrato.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExtrato.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExtrato.StateTracking.Border.ColorAngle = 45F;
            btnExtrato.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExtrato.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExtrato.StateTracking.Border.Rounding = 20F;
            btnExtrato.StateTracking.Border.Width = 1;
            btnExtrato.StateTracking.Content.ShortText.Color1 = Color.White;
            btnExtrato.TabIndex = 1069;
            toolTip1.SetToolTip(btnExtrato, "Emitir extrato da venda");
            btnExtrato.Values.Text = "Extrato";
            btnExtrato.Click += btnExtratoRecibo_Click;
            // 
            // btnBaixarParcela
            // 
            btnBaixarParcela.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBaixarParcela.CornerRoundingRadius = 10F;
            btnBaixarParcela.Location = new Point(418, 3);
            btnBaixarParcela.Margin = new Padding(5, 3, 5, 3);
            btnBaixarParcela.Name = "btnBaixarParcela";
            btnBaixarParcela.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnBaixarParcela.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnBaixarParcela.OverrideDefault.Back.ColorAngle = 45F;
            btnBaixarParcela.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnBaixarParcela.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBaixarParcela.OverrideDefault.Border.ColorAngle = 45F;
            btnBaixarParcela.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBaixarParcela.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBaixarParcela.OverrideDefault.Border.Rounding = 20F;
            btnBaixarParcela.OverrideDefault.Border.Width = 1;
            btnBaixarParcela.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnBaixarParcela.Size = new Size(90, 27);
            btnBaixarParcela.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnBaixarParcela.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnBaixarParcela.StateCommon.Back.ColorAngle = 45F;
            btnBaixarParcela.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnBaixarParcela.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBaixarParcela.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBaixarParcela.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBaixarParcela.StateCommon.Border.Rounding = 10F;
            btnBaixarParcela.StateCommon.Border.Width = 1;
            btnBaixarParcela.StateCommon.Content.ShortText.Color1 = Color.White;
            btnBaixarParcela.StateCommon.Content.ShortText.Color2 = Color.White;
            btnBaixarParcela.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnBaixarParcela.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnBaixarParcela.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnBaixarParcela.StatePressed.Back.ColorAngle = 135F;
            btnBaixarParcela.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnBaixarParcela.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnBaixarParcela.StatePressed.Border.ColorAngle = 135F;
            btnBaixarParcela.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBaixarParcela.StatePressed.Border.Rounding = 20F;
            btnBaixarParcela.StatePressed.Border.Width = 1;
            btnBaixarParcela.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnBaixarParcela.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnBaixarParcela.StateTracking.Back.ColorAngle = 45F;
            btnBaixarParcela.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnBaixarParcela.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBaixarParcela.StateTracking.Border.ColorAngle = 45F;
            btnBaixarParcela.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBaixarParcela.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBaixarParcela.StateTracking.Border.Rounding = 20F;
            btnBaixarParcela.StateTracking.Border.Width = 1;
            btnBaixarParcela.TabIndex = 1067;
            toolTip1.SetToolTip(btnBaixarParcela, "Baixar Parcela");
            btnBaixarParcela.Values.Text = "Baixar";
            btnBaixarParcela.Click += btnBaixarParcela_Click;
            // 
            // btnEstornarPagamento
            // 
            btnEstornarPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEstornarPagamento.CornerRoundingRadius = 10F;
            btnEstornarPagamento.Location = new Point(718, 3);
            btnEstornarPagamento.Margin = new Padding(5, 3, 5, 3);
            btnEstornarPagamento.Name = "btnEstornarPagamento";
            btnEstornarPagamento.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnEstornarPagamento.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnEstornarPagamento.OverrideDefault.Back.ColorAngle = 45F;
            btnEstornarPagamento.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnEstornarPagamento.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnEstornarPagamento.OverrideDefault.Border.ColorAngle = 45F;
            btnEstornarPagamento.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEstornarPagamento.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnEstornarPagamento.OverrideDefault.Border.Rounding = 20F;
            btnEstornarPagamento.OverrideDefault.Border.Width = 1;
            btnEstornarPagamento.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnEstornarPagamento.Size = new Size(90, 27);
            btnEstornarPagamento.StateCommon.Back.Color1 = Color.Red;
            btnEstornarPagamento.StateCommon.Back.Color2 = Color.Red;
            btnEstornarPagamento.StateCommon.Back.ColorAngle = 45F;
            btnEstornarPagamento.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnEstornarPagamento.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnEstornarPagamento.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEstornarPagamento.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnEstornarPagamento.StateCommon.Border.Rounding = 10F;
            btnEstornarPagamento.StateCommon.Border.Width = 1;
            btnEstornarPagamento.StateCommon.Content.ShortText.Color1 = Color.White;
            btnEstornarPagamento.StateCommon.Content.ShortText.Color2 = Color.White;
            btnEstornarPagamento.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnEstornarPagamento.StateNormal.Back.Color1 = Color.Red;
            btnEstornarPagamento.StateNormal.Back.Color2 = Color.Red;
            btnEstornarPagamento.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnEstornarPagamento.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnEstornarPagamento.StatePressed.Back.ColorAngle = 135F;
            btnEstornarPagamento.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnEstornarPagamento.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnEstornarPagamento.StatePressed.Border.ColorAngle = 135F;
            btnEstornarPagamento.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEstornarPagamento.StatePressed.Border.Rounding = 20F;
            btnEstornarPagamento.StatePressed.Border.Width = 1;
            btnEstornarPagamento.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnEstornarPagamento.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnEstornarPagamento.StateTracking.Back.ColorAngle = 45F;
            btnEstornarPagamento.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnEstornarPagamento.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnEstornarPagamento.StateTracking.Border.ColorAngle = 45F;
            btnEstornarPagamento.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEstornarPagamento.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnEstornarPagamento.StateTracking.Border.Rounding = 20F;
            btnEstornarPagamento.StateTracking.Border.Width = 1;
            btnEstornarPagamento.TabIndex = 1063;
            toolTip1.SetToolTip(btnEstornarPagamento, "Estornar pagamento");
            btnEstornarPagamento.Values.Text = "Estornar";
            btnEstornarPagamento.Click += btnEstornarPagamento_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(kryptonPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(kryptonPanel4, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvContasAReceber, 0, 2);
            tableLayoutPanel1.Controls.Add(kryptonLabel2, 0, 3);
            tableLayoutPanel1.Controls.Add(dgvPagamentos, 0, 4);
            tableLayoutPanel1.Controls.Add(kryptonPanel2, 0, 5);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.Size = new Size(917, 484);
            tableLayoutPanel1.TabIndex = 1069;
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Controls.Add(kryptonLabel5);
            kryptonPanel4.Dock = DockStyle.Fill;
            kryptonPanel4.Location = new Point(3, 3);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            kryptonPanel4.Size = new Size(911, 19);
            kryptonPanel4.TabIndex = 1051;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Dock = DockStyle.Fill;
            kryptonLabel5.Location = new Point(0, 0);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(911, 19);
            kryptonLabel5.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel5.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel5.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel5.TabIndex = 1;
            kryptonLabel5.Values.Text = "CONTAS A RECEBER";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Dock = DockStyle.Fill;
            kryptonLabel2.Location = new Point(3, 259);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            kryptonLabel2.Size = new Size(911, 19);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel2.TabIndex = 1052;
            kryptonLabel2.Values.Text = "PAGAMENTOS DA PARCELA SELECIONADA";
            // 
            // dgvPagamentos
            // 
            dgvPagamentos.Location = new Point(3, 284);
            dgvPagamentos.Name = "dgvPagamentos";
            dgvPagamentos.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            dgvPagamentos.Size = new Size(911, 111);
            dgvPagamentos.TabIndex = 1053;
            dgvPagamentos.CellContentClick += dgvPagamentos_CellContentClick;
            dgvPagamentos.CurrentCellDirtyStateChanged += dgvPagamentos_CurrentCellDirtyStateChanged;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(lblTotalSelect);
            kryptonPanel2.Dock = DockStyle.Fill;
            kryptonPanel2.Location = new Point(3, 455);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            kryptonPanel2.Size = new Size(911, 26);
            kryptonPanel2.TabIndex = 1054;
            // 
            // lblTotalSelect
            // 
            lblTotalSelect.AutoSize = true;
            lblTotalSelect.BackColor = Color.Transparent;
            lblTotalSelect.Font = new Font("Segoe UI", 9.75F);
            lblTotalSelect.ForeColor = Color.FromArgb(44, 62, 80);
            lblTotalSelect.Location = new Point(3, 3);
            lblTotalSelect.Name = "lblTotalSelect";
            lblTotalSelect.Size = new Size(111, 17);
            lblTotalSelect.TabIndex = 1073;
            lblTotalSelect.Text = "Total Selecionado";
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblQtdContasPagas, toolStripStatusLabel3, toolStripStatusLabel4, lblTotalContasPagas, toolStripStatusLabel6, toolStripStatusLabel7, lblQtdeContasReceber, toolStripStatusLabel2, toolStripStatusLabel5, lblTotalContasReceber, toolStripStatusLabel8, lblTotalSelecionado, toolStripStatusLabel10, toolStripStatusLabel9, txtTotalVencido });
            kryptonStatusStrip1.Location = new Point(0, 599);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            kryptonStatusStrip1.Size = new Size(913, 22);
            kryptonStatusStrip1.TabIndex = 1071;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(99, 17);
            toolStripStatusLabel1.Text = "Qtde Ctas. Pagas:";
            // 
            // lblQtdContasPagas
            // 
            lblQtdContasPagas.Name = "lblQtdContasPagas";
            lblQtdContasPagas.Size = new Size(12, 17);
            lblQtdContasPagas.Text = "-";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(16, 17);
            toolStripStatusLabel3.Text = " | ";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(99, 17);
            toolStripStatusLabel4.Text = "Total Ctas. Pagas:";
            // 
            // lblTotalContasPagas
            // 
            lblTotalContasPagas.Name = "lblTotalContasPagas";
            lblTotalContasPagas.Size = new Size(12, 17);
            lblTotalContasPagas.Text = "-";
            // 
            // toolStripStatusLabel6
            // 
            toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            toolStripStatusLabel6.Size = new Size(16, 17);
            toolStripStatusLabel6.Text = " | ";
            // 
            // toolStripStatusLabel7
            // 
            toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            toolStripStatusLabel7.Size = new Size(101, 17);
            toolStripStatusLabel7.Text = "Qtd Ctas Receber:";
            // 
            // lblQtdeContasReceber
            // 
            lblQtdeContasReceber.Name = "lblQtdeContasReceber";
            lblQtdeContasReceber.Size = new Size(12, 17);
            lblQtdeContasReceber.Text = "-";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(16, 17);
            toolStripStatusLabel2.Text = " | ";
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new Size(107, 17);
            toolStripStatusLabel5.Text = "Total Ctas Receber:";
            // 
            // lblTotalContasReceber
            // 
            lblTotalContasReceber.Name = "lblTotalContasReceber";
            lblTotalContasReceber.Size = new Size(12, 17);
            lblTotalContasReceber.Text = "-";
            // 
            // toolStripStatusLabel8
            // 
            toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            toolStripStatusLabel8.Size = new Size(102, 17);
            toolStripStatusLabel8.Text = "Valor selecionado:";
            // 
            // lblTotalSelecionado
            // 
            lblTotalSelecionado.Name = "lblTotalSelecionado";
            lblTotalSelecionado.Size = new Size(12, 17);
            lblTotalSelecionado.Text = "-";
            // 
            // toolStripStatusLabel10
            // 
            toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            toolStripStatusLabel10.Size = new Size(16, 17);
            toolStripStatusLabel10.Text = " | ";
            // 
            // toolStripStatusLabel9
            // 
            toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            toolStripStatusLabel9.Size = new Size(108, 17);
            toolStripStatusLabel9.Text = "Valor total vencido:";
            // 
            // txtTotalVencido
            // 
            txtTotalVencido.Name = "txtTotalVencido";
            txtTotalVencido.Size = new Size(12, 17);
            txtTotalVencido.Text = "-";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(btnSair);
            flowLayoutPanel4.Controls.Add(btnEstornarPagamento);
            flowLayoutPanel4.Controls.Add(btnRecibo);
            flowLayoutPanel4.Controls.Add(btnExtrato);
            flowLayoutPanel4.Controls.Add(btnBaixarParcela);
            flowLayoutPanel4.Controls.Add(btnVerItensVenda);
            flowLayoutPanel4.Dock = DockStyle.Bottom;
            flowLayoutPanel4.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel4.Location = new Point(0, 566);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(913, 33);
            flowLayoutPanel4.TabIndex = 1072;
            // 
            // btnRecibo
            // 
            btnRecibo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRecibo.CornerRoundingRadius = 10F;
            btnRecibo.Location = new Point(618, 3);
            btnRecibo.Margin = new Padding(5, 3, 5, 3);
            btnRecibo.Name = "btnRecibo";
            btnRecibo.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnRecibo.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnRecibo.OverrideDefault.Back.ColorAngle = 45F;
            btnRecibo.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnRecibo.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnRecibo.OverrideDefault.Border.ColorAngle = 45F;
            btnRecibo.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnRecibo.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnRecibo.OverrideDefault.Border.Rounding = 20F;
            btnRecibo.OverrideDefault.Border.Width = 1;
            btnRecibo.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnRecibo.Size = new Size(90, 27);
            btnRecibo.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnRecibo.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnRecibo.StateCommon.Back.ColorAngle = 45F;
            btnRecibo.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnRecibo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnRecibo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnRecibo.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnRecibo.StateCommon.Border.Rounding = 10F;
            btnRecibo.StateCommon.Border.Width = 1;
            btnRecibo.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 148, 252);
            btnRecibo.StateCommon.Content.ShortText.Color2 = Color.FromArgb(8, 148, 252);
            btnRecibo.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnRecibo.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnRecibo.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnRecibo.StatePressed.Back.ColorAngle = 135F;
            btnRecibo.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnRecibo.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnRecibo.StatePressed.Border.ColorAngle = 135F;
            btnRecibo.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnRecibo.StatePressed.Border.Rounding = 20F;
            btnRecibo.StatePressed.Border.Width = 1;
            btnRecibo.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnRecibo.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnRecibo.StateTracking.Back.ColorAngle = 45F;
            btnRecibo.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnRecibo.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnRecibo.StateTracking.Border.ColorAngle = 45F;
            btnRecibo.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnRecibo.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnRecibo.StateTracking.Border.Rounding = 20F;
            btnRecibo.StateTracking.Border.Width = 1;
            btnRecibo.StateTracking.Content.ShortText.Color1 = Color.White;
            btnRecibo.TabIndex = 1071;
            toolTip1.SetToolTip(btnRecibo, "Emitir recibo de pagamento");
            btnRecibo.Values.Text = "Recibo";
            btnRecibo.Click += btnRecibo_Click;
            // 
            // btnVerItensVenda
            // 
            btnVerItensVenda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVerItensVenda.CornerRoundingRadius = 10F;
            btnVerItensVenda.Location = new Point(318, 3);
            btnVerItensVenda.Margin = new Padding(5, 3, 5, 3);
            btnVerItensVenda.Name = "btnVerItensVenda";
            btnVerItensVenda.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnVerItensVenda.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnVerItensVenda.OverrideDefault.Back.ColorAngle = 45F;
            btnVerItensVenda.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnVerItensVenda.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnVerItensVenda.OverrideDefault.Border.ColorAngle = 45F;
            btnVerItensVenda.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnVerItensVenda.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnVerItensVenda.OverrideDefault.Border.Rounding = 20F;
            btnVerItensVenda.OverrideDefault.Border.Width = 1;
            btnVerItensVenda.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnVerItensVenda.Size = new Size(90, 27);
            btnVerItensVenda.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnVerItensVenda.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnVerItensVenda.StateCommon.Back.ColorAngle = 45F;
            btnVerItensVenda.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnVerItensVenda.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnVerItensVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnVerItensVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnVerItensVenda.StateCommon.Border.Rounding = 10F;
            btnVerItensVenda.StateCommon.Border.Width = 1;
            btnVerItensVenda.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnVerItensVenda.StateCommon.Content.ShortText.Color2 = Color.White;
            btnVerItensVenda.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnVerItensVenda.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnVerItensVenda.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnVerItensVenda.StatePressed.Back.ColorAngle = 135F;
            btnVerItensVenda.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnVerItensVenda.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnVerItensVenda.StatePressed.Border.ColorAngle = 135F;
            btnVerItensVenda.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnVerItensVenda.StatePressed.Border.Rounding = 20F;
            btnVerItensVenda.StatePressed.Border.Width = 1;
            btnVerItensVenda.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnVerItensVenda.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnVerItensVenda.StateTracking.Back.ColorAngle = 45F;
            btnVerItensVenda.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnVerItensVenda.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnVerItensVenda.StateTracking.Border.ColorAngle = 45F;
            btnVerItensVenda.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnVerItensVenda.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnVerItensVenda.StateTracking.Border.Rounding = 20F;
            btnVerItensVenda.StateTracking.Border.Width = 1;
            btnVerItensVenda.StateTracking.Content.ShortText.Color1 = Color.White;
            btnVerItensVenda.TabIndex = 1070;
            toolTip1.SetToolTip(btnVerItensVenda, "Visualizar Itens da Venda");
            btnVerItensVenda.Values.Text = "Ver Itens";
            btnVerItensVenda.Click += btnVerItensVenda_Click;
            // 
            // FrmContasReceber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(913, 621);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(kryptonStatusStrip1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmContasReceber";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            Text = "Contas a Receber";
            Load += FrmContasAReceber_Load;
            Shown += FrmContasAReceber_Shown;
            KeyDown += FrmContasAReceber_KeyDown;
            ((System.ComponentModel.ISupportInitialize)cmbStatusParcela).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbTipoPesquisa).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvContasAReceber).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            kryptonPanel4.ResumeLayout(false);
            kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPagamentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            kryptonStatusStrip1.ResumeLayout(false);
            kryptonStatusStrip1.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public Krypton.Toolkit.KryptonTextBox txtNomeCliente;
        private Label lblNomeCliente;
        public Krypton.Toolkit.KryptonTextBox txtNumeroVenda;
        private Label lblNumeroVenda;
        private Krypton.Toolkit.KryptonDateTimePicker dtpVencInicial;
        private Label lblVenctoInicial;
        private Label lblVenctoFinal;
        private Krypton.Toolkit.KryptonDateTimePicker dtpVencFinal;
        private Krypton.Toolkit.KryptonComboBox cmbStatusParcela;
        private Label lblStatusParcela;                
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonDataGridView dgvContasAReceber;
        private Krypton.Toolkit.KryptonButton btnEstornarPagamento;
        private Label label1;
        private Krypton.Toolkit.KryptonComboBox cmbTipoPesquisa;
        
        public Krypton.Toolkit.KryptonButton btnExcluir;
        public Krypton.Toolkit.KryptonButton btnAlterar;
       
        public Krypton.Toolkit.KryptonButton btnPesquisar;
        public Krypton.Toolkit.KryptonButton btnSair;
        public Krypton.Toolkit.KryptonButton btnBaixarParcela;
        public Krypton.Toolkit.KryptonButton btnExtrato;
        public Krypton.Toolkit.KryptonButton btnLimparFiltro;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Krypton.Toolkit.KryptonLabel lblRotuloQtdContasPagas;
        private Krypton.Toolkit.KryptonLabel lblRotuloQtdContasAReceber;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel18;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblQtdContasPagas;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel lblTotalContasPagas;
        private ToolStripStatusLabel toolStripStatusLabel6;
        private ToolStripStatusLabel toolStripStatusLabel7;
        private ToolStripStatusLabel lblQtdeContasReceber;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel lblTotalContasReceber;
        private ToolStripStatusLabel toolStripStatusLabel8;
        private ToolStripStatusLabel lblTotalSelecionado;
        private ToolStripStatusLabel toolStripStatusLabel10;
        private ToolStripStatusLabel toolStripStatusLabel9;
        private ToolStripStatusLabel txtTotalVencido;
        private Krypton.Toolkit.KryptonDataGridView dgvPagamentos;
        private FlowLayoutPanel flowLayoutPanel4;
        public Krypton.Toolkit.KryptonButton btnVerItensVenda;
        private ToolTip toolTip1;
        public Krypton.Toolkit.KryptonButton btnRecibo;
        private Label lblTotalSelect;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
    }
}