namespace GVC.View
{
    partial class FrmFinanceiro
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
            btnExtratoRecibo = new Krypton.Toolkit.KryptonButton();
            btnBaixarParcela = new Krypton.Toolkit.KryptonButton();
            btnEstornarPagamento = new Krypton.Toolkit.KryptonButton();
            txtTotalVencido = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel18 = new Krypton.Toolkit.KryptonLabel();
            lblTotalSelecionado = new Krypton.Toolkit.KryptonLabel();
            lblQtdeContasReceber = new Krypton.Toolkit.KryptonLabel();
            lblRotuloQtdContasAReceber = new Krypton.Toolkit.KryptonLabel();
            lblTotalContasReceber = new Krypton.Toolkit.KryptonLabel();
            lblQtdContasPagas = new Krypton.Toolkit.KryptonLabel();
            lblRotuloQtdContasPagas = new Krypton.Toolkit.KryptonLabel();
            lblTotalContasPagas = new Krypton.Toolkit.KryptonLabel();
            dgvItensVenda = new Krypton.Toolkit.KryptonDataGridView();
            lblCliente = new Krypton.Toolkit.KryptonLabel();
            lblRotuloCliente = new Krypton.Toolkit.KryptonLabel();
            lblTotalVenda = new Krypton.Toolkit.KryptonLabel();
            lblRotuloTotal = new Krypton.Toolkit.KryptonLabel();
            lblDataVenda = new Krypton.Toolkit.KryptonLabel();
            lblRotuloData = new Krypton.Toolkit.KryptonLabel();
            lblVendaID = new Krypton.Toolkit.KryptonLabel();
            lblRotuloVenda = new Krypton.Toolkit.KryptonLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            kryptonPanel10 = new Krypton.Toolkit.KryptonPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            kryptonPanel9 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)cmbStatusParcela).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbTipoPesquisa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvContasAReceber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel10).BeginInit();
            kryptonPanel10.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel9).BeginInit();
            kryptonPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            kryptonPanel4.SuspendLayout();
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
            txtNomeCliente.Location = new Point(175, 22);
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
            lblNomeCliente.ForeColor = Color.FromArgb(0, 76, 172);
            lblNomeCliente.Location = new Point(181, 5);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(87, 17);
            lblNomeCliente.TabIndex = 1027;
            lblNomeCliente.Text = "Nome Cliente";
            // 
            // txtNumeroVenda
            // 
            txtNumeroVenda.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtNumeroVenda.Location = new Point(175, 22);
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
            lblNumeroVenda.ForeColor = Color.White;
            lblNumeroVenda.Location = new Point(178, 5);
            lblNumeroVenda.Name = "lblNumeroVenda";
            lblNumeroVenda.Size = new Size(64, 17);
            lblNumeroVenda.TabIndex = 1029;
            lblNumeroVenda.Text = "Nº Venda";
            // 
            // dtpVencInicial
            // 
            dtpVencInicial.CornerRoundingRadius = 6F;
            dtpVencInicial.Format = DateTimePickerFormat.Short;
            dtpVencInicial.Location = new Point(175, 22);
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
            lblVenctoInicial.ForeColor = Color.FromArgb(0, 76, 172);
            lblVenctoInicial.Location = new Point(181, 5);
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
            lblVenctoFinal.ForeColor = Color.White;
            lblVenctoFinal.Location = new Point(287, 5);
            lblVenctoFinal.Name = "lblVenctoFinal";
            lblVenctoFinal.Size = new Size(77, 17);
            lblVenctoFinal.TabIndex = 1033;
            lblVenctoFinal.Text = "Vencto Final";
            // 
            // dtpVencFinal
            // 
            dtpVencFinal.CornerRoundingRadius = 6F;
            dtpVencFinal.Format = DateTimePickerFormat.Short;
            dtpVencFinal.Location = new Point(279, 22);
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
            cmbStatusParcela.Items.AddRange(new object[] { "Atrasada", "Cancelada", "Em Cobrança, Isenta", "Pendente", "Paga", "Parcialmente Paga", "Renegociada", "Todas", "Vencidas" });
            cmbStatusParcela.Location = new Point(175, 22);
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
            lblStatusParcela.ForeColor = Color.White;
            lblStatusParcela.Location = new Point(185, 5);
            lblStatusParcela.Name = "lblStatusParcela";
            lblStatusParcela.Size = new Size(89, 17);
            lblStatusParcela.TabIndex = 1035;
            lblStatusParcela.Text = "Status Parcela";
            // 
            // kryptonPanel1
            // 
            tableLayoutPanel1.SetColumnSpan(kryptonPanel1, 3);
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
            kryptonPanel1.Location = new Point(3, 34);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            kryptonPanel1.Size = new Size(907, 54);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(44, 62, 80);
            kryptonPanel1.StateCommon.Color2 = Color.FromArgb(44, 62, 80);
            kryptonPanel1.TabIndex = 1038;
            // 
            // btnLimparFiltro
            // 
            btnLimparFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimparFiltro.CornerRoundingRadius = 10F;
            btnLimparFiltro.Location = new Point(804, 15);
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
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 2);
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
            cmbTipoPesquisa.Location = new Point(8, 22);
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
            btnPesquisar.Location = new Point(704, 15);
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
            tableLayoutPanel1.SetColumnSpan(dgvContasAReceber, 2);
            dgvContasAReceber.Dock = DockStyle.Fill;
            dgvContasAReceber.Location = new Point(3, 94);
            dgvContasAReceber.Name = "dgvContasAReceber";
            dgvContasAReceber.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueDarkMode;
            dgvContasAReceber.Size = new Size(689, 183);
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
            btnSair.Location = new Point(793, 2);
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
            btnSair.Size = new Size(111, 27);
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
            btnSair.Values.Text = "Sair";
            btnSair.Click += btnSair_Click;
            // 
            // btnExtratoRecibo
            // 
            btnExtratoRecibo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExtratoRecibo.CornerRoundingRadius = 10F;
            btnExtratoRecibo.Location = new Point(8, 74);
            btnExtratoRecibo.Margin = new Padding(5, 3, 5, 3);
            btnExtratoRecibo.Name = "btnExtratoRecibo";
            btnExtratoRecibo.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnExtratoRecibo.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnExtratoRecibo.OverrideDefault.Back.ColorAngle = 45F;
            btnExtratoRecibo.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnExtratoRecibo.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExtratoRecibo.OverrideDefault.Border.ColorAngle = 45F;
            btnExtratoRecibo.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExtratoRecibo.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExtratoRecibo.OverrideDefault.Border.Rounding = 20F;
            btnExtratoRecibo.OverrideDefault.Border.Width = 1;
            btnExtratoRecibo.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnExtratoRecibo.Size = new Size(200, 27);
            btnExtratoRecibo.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnExtratoRecibo.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnExtratoRecibo.StateCommon.Back.ColorAngle = 45F;
            btnExtratoRecibo.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExtratoRecibo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExtratoRecibo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExtratoRecibo.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExtratoRecibo.StateCommon.Border.Rounding = 10F;
            btnExtratoRecibo.StateCommon.Border.Width = 1;
            btnExtratoRecibo.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnExtratoRecibo.StateCommon.Content.ShortText.Color2 = Color.White;
            btnExtratoRecibo.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnExtratoRecibo.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnExtratoRecibo.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnExtratoRecibo.StatePressed.Back.ColorAngle = 135F;
            btnExtratoRecibo.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnExtratoRecibo.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnExtratoRecibo.StatePressed.Border.ColorAngle = 135F;
            btnExtratoRecibo.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExtratoRecibo.StatePressed.Border.Rounding = 20F;
            btnExtratoRecibo.StatePressed.Border.Width = 1;
            btnExtratoRecibo.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnExtratoRecibo.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnExtratoRecibo.StateTracking.Back.ColorAngle = 45F;
            btnExtratoRecibo.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExtratoRecibo.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExtratoRecibo.StateTracking.Border.ColorAngle = 45F;
            btnExtratoRecibo.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExtratoRecibo.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExtratoRecibo.StateTracking.Border.Rounding = 20F;
            btnExtratoRecibo.StateTracking.Border.Width = 1;
            btnExtratoRecibo.StateTracking.Content.ShortText.Color1 = Color.White;
            btnExtratoRecibo.TabIndex = 1069;
            btnExtratoRecibo.Values.Text = "Extrato / Recibo";
            btnExtratoRecibo.Click += btnExtratoRecibo_Click;
            // 
            // btnBaixarParcela
            // 
            btnBaixarParcela.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBaixarParcela.CornerRoundingRadius = 10F;
            btnBaixarParcela.Location = new Point(9, 5);
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
            btnBaixarParcela.Size = new Size(199, 27);
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
            btnBaixarParcela.Values.Text = "Baixar Parcela";
            btnBaixarParcela.Click += btnBaixarParcela_Click;
            // 
            // btnEstornarPagamento
            // 
            btnEstornarPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEstornarPagamento.CornerRoundingRadius = 10F;
            btnEstornarPagamento.Location = new Point(9, 41);
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
            btnEstornarPagamento.Size = new Size(199, 27);
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
            btnEstornarPagamento.Values.Text = "Estornar Pagamento";
            btnEstornarPagamento.Click += btnEstornarPagamento_Click;
            // 
            // txtTotalVencido
            // 
            txtTotalVencido.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtTotalVencido.Location = new Point(3, 128);
            txtTotalVencido.Name = "txtTotalVencido";
            txtTotalVencido.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            txtTotalVencido.Size = new Size(15, 19);
            txtTotalVencido.StateCommon.ShortText.Color1 = Color.White;
            txtTotalVencido.StateCommon.ShortText.Color2 = Color.White;
            txtTotalVencido.StateCommon.ShortText.Font = new Font("Segoe UI", 8.25F);
            txtTotalVencido.TabIndex = 1057;
            txtTotalVencido.Values.Text = "-";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            kryptonLabel4.Location = new Point(3, 128);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            kryptonLabel4.Size = new Size(107, 19);
            kryptonLabel4.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel4.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Segoe UI", 8.25F);
            kryptonLabel4.TabIndex = 1054;
            kryptonLabel4.Values.Text = "Valor total vencido:";
            // 
            // kryptonLabel18
            // 
            kryptonLabel18.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            kryptonLabel18.Location = new Point(6, 103);
            kryptonLabel18.Name = "kryptonLabel18";
            kryptonLabel18.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            kryptonLabel18.Size = new Size(104, 19);
            kryptonLabel18.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel18.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel18.StateCommon.ShortText.Font = new Font("Segoe UI", 8.25F);
            kryptonLabel18.TabIndex = 1052;
            kryptonLabel18.Values.Text = "Valor  selecionado:";
            // 
            // lblTotalSelecionado
            // 
            lblTotalSelecionado.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalSelecionado.Location = new Point(3, 103);
            lblTotalSelecionado.Name = "lblTotalSelecionado";
            lblTotalSelecionado.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            lblTotalSelecionado.Size = new Size(15, 19);
            lblTotalSelecionado.StateCommon.ShortText.Color1 = Color.White;
            lblTotalSelecionado.StateCommon.ShortText.Color2 = Color.White;
            lblTotalSelecionado.StateCommon.ShortText.Font = new Font("Segoe UI", 8.25F);
            lblTotalSelecionado.TabIndex = 1053;
            lblTotalSelecionado.Values.Text = "-";
            // 
            // lblQtdeContasReceber
            // 
            lblQtdeContasReceber.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblQtdeContasReceber.Location = new Point(3, 53);
            lblQtdeContasReceber.Name = "lblQtdeContasReceber";
            lblQtdeContasReceber.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            lblQtdeContasReceber.Size = new Size(15, 19);
            lblQtdeContasReceber.StateCommon.ShortText.Color1 = Color.White;
            lblQtdeContasReceber.StateCommon.ShortText.Color2 = Color.White;
            lblQtdeContasReceber.StateCommon.ShortText.Font = new Font("Segoe UI", 8.25F);
            lblQtdeContasReceber.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblQtdeContasReceber.TabIndex = 1054;
            lblQtdeContasReceber.Values.Text = "-";
            // 
            // lblRotuloQtdContasAReceber
            // 
            lblRotuloQtdContasAReceber.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRotuloQtdContasAReceber.Location = new Point(10, 53);
            lblRotuloQtdContasAReceber.Name = "lblRotuloQtdContasAReceber";
            lblRotuloQtdContasAReceber.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            lblRotuloQtdContasAReceber.Size = new Size(100, 19);
            lblRotuloQtdContasAReceber.StateCommon.ShortText.Color1 = Color.White;
            lblRotuloQtdContasAReceber.StateCommon.ShortText.Color2 = Color.White;
            lblRotuloQtdContasAReceber.StateCommon.ShortText.Font = new Font("Segoe UI", 8.25F);
            lblRotuloQtdContasAReceber.TabIndex = 1050;
            lblRotuloQtdContasAReceber.Values.Text = "Qtd Ctas Receber:";
            // 
            // lblTotalContasReceber
            // 
            lblTotalContasReceber.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalContasReceber.Location = new Point(3, 78);
            lblTotalContasReceber.Name = "lblTotalContasReceber";
            lblTotalContasReceber.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            lblTotalContasReceber.Size = new Size(15, 19);
            lblTotalContasReceber.StateCommon.ShortText.Color1 = Color.White;
            lblTotalContasReceber.StateCommon.ShortText.Color2 = Color.White;
            lblTotalContasReceber.StateCommon.ShortText.Font = new Font("Segoe UI", 8.25F);
            lblTotalContasReceber.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTotalContasReceber.TabIndex = 1051;
            lblTotalContasReceber.Values.Text = "-";
            // 
            // lblQtdContasPagas
            // 
            lblQtdContasPagas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblQtdContasPagas.Location = new Point(3, 3);
            lblQtdContasPagas.Name = "lblQtdContasPagas";
            lblQtdContasPagas.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            lblQtdContasPagas.Size = new Size(15, 19);
            lblQtdContasPagas.StateCommon.ShortText.Color1 = Color.White;
            lblQtdContasPagas.StateCommon.ShortText.Color2 = Color.White;
            lblQtdContasPagas.StateCommon.ShortText.Font = new Font("Segoe UI", 8.25F);
            lblQtdContasPagas.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblQtdContasPagas.TabIndex = 1052;
            lblQtdContasPagas.Values.Text = "-";
            // 
            // lblRotuloQtdContasPagas
            // 
            lblRotuloQtdContasPagas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRotuloQtdContasPagas.Location = new Point(13, 3);
            lblRotuloQtdContasPagas.Name = "lblRotuloQtdContasPagas";
            lblRotuloQtdContasPagas.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            lblRotuloQtdContasPagas.Size = new Size(97, 19);
            lblRotuloQtdContasPagas.StateCommon.ShortText.Color1 = Color.White;
            lblRotuloQtdContasPagas.StateCommon.ShortText.Color2 = Color.White;
            lblRotuloQtdContasPagas.StateCommon.ShortText.Font = new Font("Segoe UI", 8.25F);
            lblRotuloQtdContasPagas.TabIndex = 1052;
            lblRotuloQtdContasPagas.Values.Text = "Qtde Ctas. Pagas:";
            // 
            // lblTotalContasPagas
            // 
            lblTotalContasPagas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalContasPagas.Location = new Point(3, 28);
            lblTotalContasPagas.Name = "lblTotalContasPagas";
            lblTotalContasPagas.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            lblTotalContasPagas.Size = new Size(15, 19);
            lblTotalContasPagas.StateCommon.ShortText.Color1 = Color.White;
            lblTotalContasPagas.StateCommon.ShortText.Color2 = Color.White;
            lblTotalContasPagas.StateCommon.ShortText.Font = new Font("Segoe UI", 8.25F);
            lblTotalContasPagas.TabIndex = 1053;
            lblTotalContasPagas.Values.Text = "-";
            // 
            // dgvItensVenda
            // 
            tableLayoutPanel1.SetColumnSpan(dgvItensVenda, 2);
            dgvItensVenda.Dock = DockStyle.Fill;
            dgvItensVenda.Location = new Point(3, 360);
            dgvItensVenda.Name = "dgvItensVenda";
            dgvItensVenda.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            tableLayoutPanel1.SetRowSpan(dgvItensVenda, 2);
            dgvItensVenda.Size = new Size(689, 220);
            dgvItensVenda.TabIndex = 1045;
            dgvItensVenda.CellFormatting += dgvItensVenda_CellFormatting;
            // 
            // lblCliente
            // 
            lblCliente.Location = new Point(225, 3);
            lblCliente.Name = "lblCliente";
            lblCliente.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlackDarkMode;
            lblCliente.Size = new Size(85, 20);
            lblCliente.StateCommon.ShortText.Color1 = Color.White;
            lblCliente.StateCommon.ShortText.Color2 = Color.White;
            lblCliente.TabIndex = 7;
            lblCliente.Values.Text = "Nome Cliente";
            // 
            // lblRotuloCliente
            // 
            lblRotuloCliente.Location = new Point(168, 3);
            lblRotuloCliente.Name = "lblRotuloCliente";
            lblRotuloCliente.Size = new Size(51, 20);
            lblRotuloCliente.StateCommon.ShortText.Color1 = Color.White;
            lblRotuloCliente.StateCommon.ShortText.Color2 = Color.White;
            lblRotuloCliente.TabIndex = 6;
            lblRotuloCliente.Values.Text = "Cliente:";
            // 
            // lblTotalVenda
            // 
            lblTotalVenda.Location = new Point(487, 3);
            lblTotalVenda.Name = "lblTotalVenda";
            lblTotalVenda.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlackDarkMode;
            lblTotalVenda.Size = new Size(70, 20);
            lblTotalVenda.StateCommon.ShortText.Color1 = Color.White;
            lblTotalVenda.StateCommon.ShortText.Color2 = Color.White;
            lblTotalVenda.TabIndex = 5;
            lblTotalVenda.Values.Text = "Valor Total";
            // 
            // lblRotuloTotal
            // 
            lblRotuloTotal.Location = new Point(441, 3);
            lblRotuloTotal.Name = "lblRotuloTotal";
            lblRotuloTotal.Size = new Size(40, 20);
            lblRotuloTotal.StateCommon.ShortText.Color1 = Color.White;
            lblRotuloTotal.StateCommon.ShortText.Color2 = Color.White;
            lblRotuloTotal.TabIndex = 4;
            lblRotuloTotal.Values.Text = "Total:";
            // 
            // lblDataVenda
            // 
            lblDataVenda.Location = new Point(361, 3);
            lblDataVenda.Name = "lblDataVenda";
            lblDataVenda.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlackDarkMode;
            lblDataVenda.Size = new Size(74, 20);
            lblDataVenda.StateCommon.ShortText.Color1 = Color.White;
            lblDataVenda.StateCommon.ShortText.Color2 = Color.White;
            lblDataVenda.TabIndex = 3;
            lblDataVenda.Values.Text = "Data Venda";
            // 
            // lblRotuloData
            // 
            lblRotuloData.Location = new Point(316, 3);
            lblRotuloData.Name = "lblRotuloData";
            lblRotuloData.Size = new Size(39, 20);
            lblRotuloData.StateCommon.ShortText.Color1 = Color.White;
            lblRotuloData.StateCommon.ShortText.Color2 = Color.White;
            lblRotuloData.TabIndex = 2;
            lblRotuloData.Values.Text = "Data:";
            // 
            // lblVendaID
            // 
            lblVendaID.Location = new Point(57, 3);
            lblVendaID.Name = "lblVendaID";
            lblVendaID.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlackDarkMode;
            lblVendaID.Size = new Size(105, 20);
            lblVendaID.StateCommon.ShortText.Color1 = Color.White;
            lblVendaID.StateCommon.ShortText.Color2 = Color.White;
            lblVendaID.TabIndex = 1;
            lblVendaID.Values.Text = "Codigo da Venda";
            // 
            // lblRotuloVenda
            // 
            lblRotuloVenda.Location = new Point(3, 3);
            lblRotuloVenda.Name = "lblRotuloVenda";
            lblRotuloVenda.Size = new Size(48, 20);
            lblRotuloVenda.StateCommon.ShortText.Color1 = Color.White;
            lblRotuloVenda.StateCommon.ShortText.Color2 = Color.White;
            lblRotuloVenda.TabIndex = 0;
            lblRotuloVenda.Values.Text = "Venda:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.4070072F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.5929947F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 217F));
            tableLayoutPanel1.Controls.Add(kryptonPanel3, 0, 6);
            tableLayoutPanel1.Controls.Add(dgvItensVenda, 0, 5);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 0, 4);
            tableLayoutPanel1.Controls.Add(kryptonPanel10, 2, 4);
            tableLayoutPanel1.Controls.Add(kryptonPanel9, 0, 3);
            tableLayoutPanel1.Controls.Add(kryptonPanel2, 2, 2);
            tableLayoutPanel1.Controls.Add(dgvContasAReceber, 0, 2);
            tableLayoutPanel1.Controls.Add(kryptonPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(kryptonPanel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.4545441F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.27273F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.27273F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.Size = new Size(913, 621);
            tableLayoutPanel1.TabIndex = 1069;
            // 
            // kryptonPanel3
            // 
            tableLayoutPanel1.SetColumnSpan(kryptonPanel3, 3);
            kryptonPanel3.Controls.Add(btnSair);
            kryptonPanel3.Dock = DockStyle.Fill;
            kryptonPanel3.Location = new Point(3, 586);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(907, 32);
            kryptonPanel3.StateCommon.Color1 = Color.FromArgb(44, 62, 80);
            kryptonPanel3.StateCommon.Color2 = Color.FromArgb(44, 62, 80);
            kryptonPanel3.TabIndex = 1049;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.FromArgb(44, 62, 80);
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel3, 2);
            flowLayoutPanel3.Controls.Add(lblRotuloVenda);
            flowLayoutPanel3.Controls.Add(lblVendaID);
            flowLayoutPanel3.Controls.Add(lblRotuloCliente);
            flowLayoutPanel3.Controls.Add(lblCliente);
            flowLayoutPanel3.Controls.Add(lblRotuloData);
            flowLayoutPanel3.Controls.Add(lblDataVenda);
            flowLayoutPanel3.Controls.Add(lblRotuloTotal);
            flowLayoutPanel3.Controls.Add(lblTotalVenda);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 313);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(689, 41);
            flowLayoutPanel3.TabIndex = 1050;
            // 
            // kryptonPanel10
            // 
            kryptonPanel10.Controls.Add(flowLayoutPanel1);
            kryptonPanel10.Controls.Add(flowLayoutPanel2);
            kryptonPanel10.Dock = DockStyle.Fill;
            kryptonPanel10.Location = new Point(698, 313);
            kryptonPanel10.Name = "kryptonPanel10";
            tableLayoutPanel1.SetRowSpan(kryptonPanel10, 3);
            kryptonPanel10.Size = new Size(212, 267);
            kryptonPanel10.TabIndex = 1046;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(44, 62, 80);
            flowLayoutPanel1.Controls.Add(lblRotuloQtdContasPagas);
            flowLayoutPanel1.Controls.Add(kryptonLabel1);
            flowLayoutPanel1.Controls.Add(lblRotuloQtdContasAReceber);
            flowLayoutPanel1.Controls.Add(kryptonLabel2);
            flowLayoutPanel1.Controls.Add(kryptonLabel18);
            flowLayoutPanel1.Controls.Add(kryptonLabel4);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(109, 267);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            kryptonLabel1.Location = new Point(13, 28);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            kryptonLabel1.Size = new Size(97, 19);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 8.25F);
            kryptonLabel1.TabIndex = 1053;
            kryptonLabel1.Values.Text = "Total Ctas. Pagas:";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            kryptonLabel2.Location = new Point(8, 78);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            kryptonLabel2.Size = new Size(102, 19);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Segoe UI", 8.25F);
            kryptonLabel2.TabIndex = 1054;
            kryptonLabel2.Values.Text = "Total Ctas Recebe:";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(44, 62, 80);
            flowLayoutPanel2.Controls.Add(lblQtdContasPagas);
            flowLayoutPanel2.Controls.Add(lblTotalContasPagas);
            flowLayoutPanel2.Controls.Add(lblQtdeContasReceber);
            flowLayoutPanel2.Controls.Add(lblTotalContasReceber);
            flowLayoutPanel2.Controls.Add(lblTotalSelecionado);
            flowLayoutPanel2.Controls.Add(txtTotalVencido);
            flowLayoutPanel2.Dock = DockStyle.Right;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(109, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(103, 267);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // kryptonPanel9
            // 
            tableLayoutPanel1.SetColumnSpan(kryptonPanel9, 3);
            kryptonPanel9.Controls.Add(kryptonLabel3);
            kryptonPanel9.Dock = DockStyle.Fill;
            kryptonPanel9.Location = new Point(3, 283);
            kryptonPanel9.Name = "kryptonPanel9";
            kryptonPanel9.Size = new Size(907, 24);
            kryptonPanel9.StateCommon.Color1 = Color.FromArgb(44, 62, 80);
            kryptonPanel9.StateCommon.Color2 = Color.FromArgb(44, 62, 80);
            kryptonPanel9.TabIndex = 1040;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Dock = DockStyle.Fill;
            kryptonLabel3.Location = new Point(0, 0);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(907, 24);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel3.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel3.TabIndex = 0;
            kryptonLabel3.Values.Text = "ITENS DA VENDA";
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(btnExtratoRecibo);
            kryptonPanel2.Controls.Add(btnBaixarParcela);
            kryptonPanel2.Controls.Add(btnEstornarPagamento);
            kryptonPanel2.Dock = DockStyle.Fill;
            kryptonPanel2.Location = new Point(698, 94);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(212, 183);
            kryptonPanel2.StateCommon.Color1 = Color.FromArgb(44, 62, 80);
            kryptonPanel2.StateCommon.Color2 = Color.FromArgb(44, 62, 80);
            kryptonPanel2.TabIndex = 1039;
            // 
            // kryptonPanel4
            // 
            tableLayoutPanel1.SetColumnSpan(kryptonPanel4, 3);
            kryptonPanel4.Controls.Add(kryptonLabel5);
            kryptonPanel4.Dock = DockStyle.Fill;
            kryptonPanel4.Location = new Point(3, 3);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.Size = new Size(907, 25);
            kryptonPanel4.StateCommon.Color1 = Color.FromArgb(44, 62, 80);
            kryptonPanel4.StateCommon.Color2 = Color.FromArgb(44, 62, 80);
            kryptonPanel4.TabIndex = 1051;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Dock = DockStyle.Fill;
            kryptonLabel5.Location = new Point(0, 0);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(907, 25);
            kryptonLabel5.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel5.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel5.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel5.TabIndex = 1;
            kryptonLabel5.Values.Text = "FINANCEIRO";
            // 
            // FrmFinanceiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(913, 621);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFinanceiro";
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
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel10).EndInit();
            kryptonPanel10.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel9).EndInit();
            kryptonPanel9.ResumeLayout(false);
            kryptonPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            kryptonPanel4.ResumeLayout(false);
            kryptonPanel4.PerformLayout();
            ResumeLayout(false);
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
        private Krypton.Toolkit.KryptonLabel lblTotalContasReceber;
        private Krypton.Toolkit.KryptonLabel lblRotuloQtdContasAReceber;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel txtTotalVencido;
        private Krypton.Toolkit.KryptonLabel lblRotuloQtdContasPagas;
        private Krypton.Toolkit.KryptonLabel lblTotalContasPagas;
        private Krypton.Toolkit.KryptonLabel kryptonLabel18;
        private Krypton.Toolkit.KryptonLabel lblTotalSelecionado;
        private Krypton.Toolkit.KryptonLabel lblQtdeContasReceber;
        private Krypton.Toolkit.KryptonLabel lblQtdContasPagas;
        private Krypton.Toolkit.KryptonDataGridView dgvItensVenda;
        private Krypton.Toolkit.KryptonLabel lblCliente;
        private Krypton.Toolkit.KryptonLabel lblRotuloCliente;
        private Krypton.Toolkit.KryptonLabel lblTotalVenda;
        private Krypton.Toolkit.KryptonLabel lblRotuloTotal;
        private Krypton.Toolkit.KryptonLabel lblDataVenda;
        private Krypton.Toolkit.KryptonLabel lblRotuloData;
        private Krypton.Toolkit.KryptonLabel lblVendaID;
        private Krypton.Toolkit.KryptonLabel lblRotuloVenda;
        
        public Krypton.Toolkit.KryptonButton btnExcluir;
        public Krypton.Toolkit.KryptonButton btnAlterar;
       
        public Krypton.Toolkit.KryptonButton btnPesquisar;
        public Krypton.Toolkit.KryptonButton btnSair;
        public Krypton.Toolkit.KryptonButton btnBaixarParcela;
        public Krypton.Toolkit.KryptonButton btnExtratoRecibo;
        public Krypton.Toolkit.KryptonButton btnLimparFiltro;
        private TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel9;
        private Krypton.Toolkit.KryptonPanel kryptonPanel10;
        private FlowLayoutPanel flowLayoutPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private FlowLayoutPanel flowLayoutPanel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
    }
}