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
            panelFiltroPesquisa = new Krypton.Toolkit.KryptonPanel();
            btnLimparFiltro = new Krypton.Toolkit.KryptonButton();
            btnPesquisar = new Krypton.Toolkit.KryptonButton();
            label1 = new Label();
            cmbTipoPesquisa = new Krypton.Toolkit.KryptonComboBox();
            dgvContasAReceber = new Krypton.Toolkit.KryptonDataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            dgvPagamentos = new Krypton.Toolkit.KryptonDataGridView();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            lblTotalSelecionado = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblTotalContasReceber = new Krypton.Toolkit.KryptonLabel();
            lblTotalVencido = new Krypton.Toolkit.KryptonLabel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            btnSair = new Krypton.Toolkit.KryptonButton();
            btnEstornarPagamento = new Krypton.Toolkit.KryptonButton();
            btnRecibo = new Krypton.Toolkit.KryptonButton();
            btnExtrato = new Krypton.Toolkit.KryptonButton();
            btnBaixarParcela = new Krypton.Toolkit.KryptonButton();
            btnVerItensVenda = new Krypton.Toolkit.KryptonButton();
            toolTip1 = new ToolTip(components);
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            ((System.ComponentModel.ISupportInitialize)cmbStatusParcela).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelFiltroPesquisa).BeginInit();
            panelFiltroPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbTipoPesquisa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvContasAReceber).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagamentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
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
            lblNomeCliente.ForeColor = Color.Black;
            lblNomeCliente.Location = new Point(181, -1);
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
            lblNumeroVenda.ForeColor = Color.Black;
            lblNumeroVenda.Location = new Point(178, -1);
            lblNumeroVenda.Name = "lblNumeroVenda";
            lblNumeroVenda.Size = new Size(64, 17);
            lblNumeroVenda.TabIndex = 1029;
            lblNumeroVenda.Text = "Nº Venda";
            // 
            // dtpVencInicial
            // 
            dtpVencInicial.CornerRoundingRadius = 6F;
            dtpVencInicial.Format = DateTimePickerFormat.Short;
            dtpVencInicial.Location = new Point(175, 20);
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
            lblVenctoInicial.ForeColor = Color.Black;
            lblVenctoInicial.Location = new Point(181, -1);
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
            lblVenctoFinal.ForeColor = Color.Black;
            lblVenctoFinal.Location = new Point(287, -1);
            lblVenctoFinal.Name = "lblVenctoFinal";
            lblVenctoFinal.Size = new Size(77, 17);
            lblVenctoFinal.TabIndex = 1033;
            lblVenctoFinal.Text = "Vencto Final";
            // 
            // dtpVencFinal
            // 
            dtpVencFinal.CornerRoundingRadius = 6F;
            dtpVencFinal.Format = DateTimePickerFormat.Short;
            dtpVencFinal.Location = new Point(279, 20);
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
            cmbStatusParcela.Items.AddRange(new object[] { "Pendente", "ParcialmentePago", "Pago", "Atrasada", "Cancelada" });
            cmbStatusParcela.Location = new Point(177, 20);
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
            lblStatusParcela.ForeColor = Color.Black;
            lblStatusParcela.Location = new Point(185, -1);
            lblStatusParcela.Name = "lblStatusParcela";
            lblStatusParcela.Size = new Size(89, 17);
            lblStatusParcela.TabIndex = 1035;
            lblStatusParcela.Text = "Status Parcela";
            // 
            // panelFiltroPesquisa
            // 
            tableLayoutPanel1.SetColumnSpan(panelFiltroPesquisa, 2);
            panelFiltroPesquisa.Controls.Add(btnLimparFiltro);
            panelFiltroPesquisa.Controls.Add(btnPesquisar);
            panelFiltroPesquisa.Controls.Add(label1);
            panelFiltroPesquisa.Controls.Add(cmbTipoPesquisa);
            panelFiltroPesquisa.Controls.Add(lblNumeroVenda);
            panelFiltroPesquisa.Controls.Add(lblStatusParcela);
            panelFiltroPesquisa.Controls.Add(lblNomeCliente);
            panelFiltroPesquisa.Controls.Add(txtNumeroVenda);
            panelFiltroPesquisa.Controls.Add(txtNomeCliente);
            panelFiltroPesquisa.Controls.Add(cmbStatusParcela);
            panelFiltroPesquisa.Controls.Add(lblVenctoFinal);
            panelFiltroPesquisa.Controls.Add(dtpVencInicial);
            panelFiltroPesquisa.Controls.Add(lblVenctoInicial);
            panelFiltroPesquisa.Controls.Add(dtpVencFinal);
            panelFiltroPesquisa.Dock = DockStyle.Fill;
            panelFiltroPesquisa.Location = new Point(3, 28);
            panelFiltroPesquisa.Name = "panelFiltroPesquisa";
            panelFiltroPesquisa.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            panelFiltroPesquisa.Size = new Size(821, 54);
            panelFiltroPesquisa.StateCommon.Color1 = Color.White;
            panelFiltroPesquisa.StateCommon.Color2 = Color.White;
            panelFiltroPesquisa.TabIndex = 1038;
            // 
            // btnLimparFiltro
            // 
            btnLimparFiltro.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLimparFiltro.CornerRoundingRadius = 20F;
            btnLimparFiltro.Location = new Point(708, 14);
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
            btnLimparFiltro.Size = new Size(100, 30);
            btnLimparFiltro.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnLimparFiltro.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 250);
            btnLimparFiltro.StateCommon.Back.ColorAngle = 45F;
            btnLimparFiltro.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLimparFiltro.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLimparFiltro.StateCommon.Border.ColorAngle = 45F;
            btnLimparFiltro.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLimparFiltro.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLimparFiltro.StateCommon.Border.Rounding = 20F;
            btnLimparFiltro.StateCommon.Border.Width = 1;
            btnLimparFiltro.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnLimparFiltro.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 8.75F, FontStyle.Bold);
            btnLimparFiltro.StateNormal.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnLimparFiltro.StateNormal.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnLimparFiltro.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLimparFiltro.StateNormal.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnLimparFiltro.StateNormal.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnLimparFiltro.StateNormal.Border.ColorAngle = 45F;
            btnLimparFiltro.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLimparFiltro.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLimparFiltro.StateNormal.Border.Rounding = 20F;
            btnLimparFiltro.StateNormal.Border.Width = 1;
            btnLimparFiltro.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnLimparFiltro.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnLimparFiltro.StatePressed.Back.ColorAngle = 135F;
            btnLimparFiltro.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnLimparFiltro.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnLimparFiltro.StatePressed.Border.ColorAngle = 135F;
            btnLimparFiltro.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLimparFiltro.StatePressed.Border.Rounding = 20F;
            btnLimparFiltro.StatePressed.Border.Width = 1;
            btnLimparFiltro.StatePressed.Content.ShortText.Color1 = Color.White;
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
            btnLimparFiltro.TabIndex = 1041;
            btnLimparFiltro.Values.Text = "Limpar Filtro";
            btnLimparFiltro.Click += btnLimparFiltro_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPesquisar.CornerRoundingRadius = 20F;
            btnPesquisar.Location = new Point(606, 14);
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
            btnPesquisar.Size = new Size(100, 30);
            btnPesquisar.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnPesquisar.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnPesquisar.StateCommon.Back.ColorAngle = 45F;
            btnPesquisar.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnPesquisar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnPesquisar.StateCommon.Border.ColorAngle = 45F;
            btnPesquisar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnPesquisar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnPesquisar.StateCommon.Border.Rounding = 20F;
            btnPesquisar.StateCommon.Border.Width = 1;
            btnPesquisar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnPesquisar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnPesquisar.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            btnPesquisar.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnPesquisar.StateNormal.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnPesquisar.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnPesquisar.StateNormal.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnPesquisar.StateNormal.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnPesquisar.StateNormal.Border.ColorAngle = 45F;
            btnPesquisar.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnPesquisar.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnPesquisar.StateNormal.Border.Rounding = 20F;
            btnPesquisar.StateNormal.Border.Width = 1;
            btnPesquisar.StatePressed.Back.Color1 = Color.White;
            btnPesquisar.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnPesquisar.StatePressed.Back.ColorAngle = 135F;
            btnPesquisar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnPesquisar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnPesquisar.StatePressed.Border.ColorAngle = 135F;
            btnPesquisar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnPesquisar.StatePressed.Border.Rounding = 20F;
            btnPesquisar.StatePressed.Border.Width = 1;
            btnPesquisar.StatePressed.Content.ShortText.Color1 = Color.FromArgb(22, 121, 206);
            btnPesquisar.StateTracking.Back.Color1 = Color.White;
            btnPesquisar.StateTracking.Back.Color2 = Color.White;
            btnPesquisar.StateTracking.Back.ColorAngle = 45F;
            btnPesquisar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnPesquisar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnPesquisar.StateTracking.Border.ColorAngle = 45F;
            btnPesquisar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnPesquisar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnPesquisar.StateTracking.Border.Rounding = 20F;
            btnPesquisar.StateTracking.Border.Width = 1;
            btnPesquisar.StateTracking.Content.ShortText.Color1 = Color.FromArgb(22, 121, 206);
            btnPesquisar.TabIndex = 1040;
            btnPesquisar.Values.Text = "Pesquisar";
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(8, -1);
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
            // dgvContasAReceber
            // 
            tableLayoutPanel1.SetColumnSpan(dgvContasAReceber, 2);
            dgvContasAReceber.Dock = DockStyle.Fill;
            dgvContasAReceber.Location = new Point(3, 88);
            dgvContasAReceber.Name = "dgvContasAReceber";
            dgvContasAReceber.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            dgvContasAReceber.Size = new Size(821, 187);
            dgvContasAReceber.TabIndex = 1039;
            dgvContasAReceber.TabStop = false;
            dgvContasAReceber.CellFormatting += dgvContasAReceber_CellFormatting;
            dgvContasAReceber.CellValueChanged += dgvContasAReceber_CellValueChanged;
            dgvContasAReceber.CurrentCellDirtyStateChanged += dgvContasAReceber_CurrentCellDirtyStateChanged;
            dgvContasAReceber.SelectionChanged += dgvContasAReceber_SelectionChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 358F));
            tableLayoutPanel1.Controls.Add(panelFiltroPesquisa, 0, 1);
            tableLayoutPanel1.Controls.Add(kryptonPanel4, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvContasAReceber, 0, 2);
            tableLayoutPanel1.Controls.Add(kryptonLabel2, 0, 3);
            tableLayoutPanel1.Controls.Add(dgvPagamentos, 0, 4);
            tableLayoutPanel1.Controls.Add(kryptonPanel2, 0, 5);
            tableLayoutPanel1.Controls.Add(kryptonPanel3, 1, 4);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(827, 531);
            tableLayoutPanel1.TabIndex = 1069;
            // 
            // kryptonPanel4
            // 
            tableLayoutPanel1.SetColumnSpan(kryptonPanel4, 2);
            kryptonPanel4.Dock = DockStyle.Fill;
            kryptonPanel4.Location = new Point(3, 3);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.Size = new Size(821, 19);
            kryptonPanel4.StateCommon.Color1 = Color.FromArgb(41, 129, 229);
            kryptonPanel4.StateCommon.Color2 = Color.FromArgb(41, 129, 229);
            kryptonPanel4.TabIndex = 1051;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(3, 281);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Black;
            kryptonLabel2.Size = new Size(227, 18);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.Black;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel2.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel2.TabIndex = 1052;
            kryptonLabel2.Values.Text = "Pagamentos da parcela selecionada";
            // 
            // dgvPagamentos
            // 
            dgvPagamentos.Dock = DockStyle.Fill;
            dgvPagamentos.Location = new Point(3, 305);
            dgvPagamentos.Name = "dgvPagamentos";
            dgvPagamentos.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            dgvPagamentos.Size = new Size(463, 187);
            dgvPagamentos.TabIndex = 1053;
            dgvPagamentos.CellContentClick += dgvPagamentos_CellContentClick;
            dgvPagamentos.CurrentCellDirtyStateChanged += dgvPagamentos_CurrentCellDirtyStateChanged;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(lblTotalSelecionado);
            kryptonPanel2.Location = new Point(3, 498);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(463, 30);
            kryptonPanel2.StateCommon.Color1 = Color.White;
            kryptonPanel2.StateCommon.Color2 = Color.White;
            kryptonPanel2.TabIndex = 1054;
            // 
            // lblTotalSelecionado
            // 
            lblTotalSelecionado.Anchor = AnchorStyles.Left;
            lblTotalSelecionado.Location = new Point(2, 4);
            lblTotalSelecionado.Name = "lblTotalSelecionado";
            lblTotalSelecionado.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Black;
            lblTotalSelecionado.Size = new Size(33, 20);
            lblTotalSelecionado.StateCommon.ShortText.Color1 = Color.Black;
            lblTotalSelecionado.StateCommon.ShortText.Color2 = Color.Black;
            lblTotalSelecionado.TabIndex = 4;
            lblTotalSelecionado.Values.Text = "0,00";
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(flowLayoutPanel1);
            kryptonPanel3.Controls.Add(flowLayoutPanel3);
            kryptonPanel3.Dock = DockStyle.Fill;
            kryptonPanel3.Location = new Point(472, 305);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(352, 187);
            kryptonPanel3.TabIndex = 1055;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(lblTotalContasReceber);
            flowLayoutPanel1.Controls.Add(lblTotalVencido);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(189, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(163, 187);
            flowLayoutPanel1.TabIndex = 1055;
            // 
            // lblTotalContasReceber
            // 
            lblTotalContasReceber.Location = new Point(3, 3);
            lblTotalContasReceber.Name = "lblTotalContasReceber";
            lblTotalContasReceber.PaletteMode = Krypton.Toolkit.PaletteMode.Office365SilverLightMode;
            lblTotalContasReceber.Size = new Size(33, 20);
            lblTotalContasReceber.StateCommon.ShortText.Color1 = Color.Black;
            lblTotalContasReceber.StateCommon.ShortText.Color2 = Color.Black;
            lblTotalContasReceber.TabIndex = 3;
            lblTotalContasReceber.Values.Text = "0,00";
            // 
            // lblTotalVencido
            // 
            lblTotalVencido.Location = new Point(3, 29);
            lblTotalVencido.Name = "lblTotalVencido";
            lblTotalVencido.Size = new Size(33, 20);
            lblTotalVencido.StateCommon.ShortText.Color1 = Color.Black;
            lblTotalVencido.StateCommon.ShortText.Color2 = Color.Black;
            lblTotalVencido.TabIndex = 5;
            lblTotalVencido.Values.Text = "0,00";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.White;
            flowLayoutPanel3.Controls.Add(kryptonLabel1);
            flowLayoutPanel3.Controls.Add(kryptonLabel6);
            flowLayoutPanel3.Dock = DockStyle.Left;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(0, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(218, 187);
            flowLayoutPanel3.TabIndex = 1056;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(3, 3);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Black;
            kryptonLabel1.Size = new Size(180, 20);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.Black;
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.Black;
            kryptonLabel1.TabIndex = 3;
            kryptonLabel1.Values.Text = "Quantidae de contas a receber:";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(3, 29);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Black;
            kryptonLabel6.Size = new Size(86, 20);
            kryptonLabel6.StateCommon.ShortText.Color1 = Color.Black;
            kryptonLabel6.StateCommon.ShortText.Color2 = Color.Black;
            kryptonLabel6.TabIndex = 5;
            kryptonLabel6.Values.Text = "Total vencido:";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.White;
            flowLayoutPanel4.Controls.Add(btnSair);
            flowLayoutPanel4.Controls.Add(btnEstornarPagamento);
            flowLayoutPanel4.Controls.Add(btnRecibo);
            flowLayoutPanel4.Controls.Add(btnExtrato);
            flowLayoutPanel4.Controls.Add(btnBaixarParcela);
            flowLayoutPanel4.Controls.Add(btnVerItensVenda);
            flowLayoutPanel4.Dock = DockStyle.Bottom;
            flowLayoutPanel4.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel4.Location = new Point(0, 559);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(823, 33);
            flowLayoutPanel4.TabIndex = 1072;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSair.CornerRoundingRadius = 20F;
            btnSair.Location = new Point(720, 3);
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
            btnSair.TabIndex = 29;
            btnSair.Values.Text = "Sair";
            btnSair.Click += btnSair_Click;
            // 
            // btnEstornarPagamento
            // 
            btnEstornarPagamento.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEstornarPagamento.CornerRoundingRadius = 20F;
            btnEstornarPagamento.Location = new Point(614, 3);
            btnEstornarPagamento.Name = "btnEstornarPagamento";
            btnEstornarPagamento.OverrideDefault.Back.Color1 = Color.Red;
            btnEstornarPagamento.OverrideDefault.Back.Color2 = Color.Red;
            btnEstornarPagamento.OverrideDefault.Back.ColorAngle = 45F;
            btnEstornarPagamento.OverrideDefault.Border.Color1 = Color.Red;
            btnEstornarPagamento.OverrideDefault.Border.Color2 = Color.Red;
            btnEstornarPagamento.OverrideDefault.Border.ColorAngle = 45F;
            btnEstornarPagamento.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEstornarPagamento.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnEstornarPagamento.OverrideDefault.Border.Rounding = 20F;
            btnEstornarPagamento.OverrideDefault.Border.Width = 1;
            btnEstornarPagamento.OverrideDefault.Content.ShortText.Color1 = Color.White;
            btnEstornarPagamento.OverrideDefault.Content.ShortText.Color2 = Color.White;
            btnEstornarPagamento.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnEstornarPagamento.Size = new Size(100, 30);
            btnEstornarPagamento.StateCommon.Back.Color1 = Color.Red;
            btnEstornarPagamento.StateCommon.Back.Color2 = Color.Red;
            btnEstornarPagamento.StateCommon.Back.ColorAngle = 45F;
            btnEstornarPagamento.StateCommon.Border.Color1 = Color.Red;
            btnEstornarPagamento.StateCommon.Border.Color2 = Color.Red;
            btnEstornarPagamento.StateCommon.Border.ColorAngle = 45F;
            btnEstornarPagamento.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEstornarPagamento.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnEstornarPagamento.StateCommon.Border.Rounding = 20F;
            btnEstornarPagamento.StateCommon.Border.Width = 1;
            btnEstornarPagamento.StateCommon.Content.ShortText.Color1 = Color.White;
            btnEstornarPagamento.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            btnEstornarPagamento.StateNormal.Back.Color1 = Color.Red;
            btnEstornarPagamento.StateNormal.Back.Color2 = Color.Red;
            btnEstornarPagamento.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnEstornarPagamento.StateNormal.Border.Color1 = Color.Red;
            btnEstornarPagamento.StateNormal.Border.Color2 = Color.Red;
            btnEstornarPagamento.StateNormal.Border.ColorAngle = 45F;
            btnEstornarPagamento.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEstornarPagamento.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnEstornarPagamento.StateNormal.Border.Rounding = 20F;
            btnEstornarPagamento.StateNormal.Border.Width = 1;
            btnEstornarPagamento.StateNormal.Content.ShortText.Color1 = Color.White;
            btnEstornarPagamento.StateNormal.Content.ShortText.Color2 = Color.White;
            btnEstornarPagamento.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnEstornarPagamento.StatePressed.Back.ColorAngle = 135F;
            btnEstornarPagamento.StatePressed.Border.Color1 = Color.Red;
            btnEstornarPagamento.StatePressed.Border.Color2 = Color.Red;
            btnEstornarPagamento.StatePressed.Border.ColorAngle = 135F;
            btnEstornarPagamento.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEstornarPagamento.StatePressed.Border.Rounding = 20F;
            btnEstornarPagamento.StatePressed.Border.Width = 1;
            btnEstornarPagamento.StatePressed.Content.ShortText.Color1 = Color.White;
            btnEstornarPagamento.StateTracking.Back.Color1 = Color.Salmon;
            btnEstornarPagamento.StateTracking.Back.ColorAngle = 45F;
            btnEstornarPagamento.StateTracking.Border.Color1 = Color.Red;
            btnEstornarPagamento.StateTracking.Border.Color2 = Color.Red;
            btnEstornarPagamento.StateTracking.Border.ColorAngle = 45F;
            btnEstornarPagamento.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEstornarPagamento.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnEstornarPagamento.StateTracking.Border.Rounding = 20F;
            btnEstornarPagamento.StateTracking.Border.Width = 1;
            btnEstornarPagamento.StateTracking.Content.ShortText.Color1 = Color.White;
            btnEstornarPagamento.TabIndex = 34;
            btnEstornarPagamento.Values.Text = "Estornar";
            btnEstornarPagamento.Click += btnEstornarPagamento_Click;
            // 
            // btnRecibo
            // 
            btnRecibo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRecibo.CornerRoundingRadius = 20F;
            btnRecibo.Location = new Point(508, 3);
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
            btnRecibo.Size = new Size(100, 30);
            btnRecibo.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnRecibo.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 250);
            btnRecibo.StateCommon.Back.ColorAngle = 45F;
            btnRecibo.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnRecibo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnRecibo.StateCommon.Border.ColorAngle = 45F;
            btnRecibo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnRecibo.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnRecibo.StateCommon.Border.Rounding = 20F;
            btnRecibo.StateCommon.Border.Width = 1;
            btnRecibo.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnRecibo.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            btnRecibo.StateNormal.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnRecibo.StateNormal.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnRecibo.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnRecibo.StateNormal.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnRecibo.StateNormal.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnRecibo.StateNormal.Border.ColorAngle = 45F;
            btnRecibo.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnRecibo.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnRecibo.StateNormal.Border.Rounding = 20F;
            btnRecibo.StateNormal.Border.Width = 1;
            btnRecibo.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnRecibo.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnRecibo.StatePressed.Back.ColorAngle = 135F;
            btnRecibo.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnRecibo.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnRecibo.StatePressed.Border.ColorAngle = 135F;
            btnRecibo.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnRecibo.StatePressed.Border.Rounding = 20F;
            btnRecibo.StatePressed.Border.Width = 1;
            btnRecibo.StatePressed.Content.ShortText.Color1 = Color.White;
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
            btnRecibo.TabIndex = 33;
            btnRecibo.Values.Text = "Recibo";
            btnRecibo.Click += btnRecibo_Click;
            // 
            // btnExtrato
            // 
            btnExtrato.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExtrato.CornerRoundingRadius = 20F;
            btnExtrato.Location = new Point(402, 3);
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
            btnExtrato.Size = new Size(100, 30);
            btnExtrato.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnExtrato.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 250);
            btnExtrato.StateCommon.Back.ColorAngle = 45F;
            btnExtrato.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExtrato.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExtrato.StateCommon.Border.ColorAngle = 45F;
            btnExtrato.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExtrato.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExtrato.StateCommon.Border.Rounding = 20F;
            btnExtrato.StateCommon.Border.Width = 1;
            btnExtrato.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnExtrato.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            btnExtrato.StateNormal.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnExtrato.StateNormal.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnExtrato.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExtrato.StateNormal.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnExtrato.StateNormal.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnExtrato.StateNormal.Border.ColorAngle = 45F;
            btnExtrato.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExtrato.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExtrato.StateNormal.Border.Rounding = 20F;
            btnExtrato.StateNormal.Border.Width = 1;
            btnExtrato.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnExtrato.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnExtrato.StatePressed.Back.ColorAngle = 135F;
            btnExtrato.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnExtrato.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnExtrato.StatePressed.Border.ColorAngle = 135F;
            btnExtrato.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExtrato.StatePressed.Border.Rounding = 20F;
            btnExtrato.StatePressed.Border.Width = 1;
            btnExtrato.StatePressed.Content.ShortText.Color1 = Color.White;
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
            btnExtrato.TabIndex = 32;
            btnExtrato.Values.Text = "Extrato";
            btnExtrato.Click += btnExtrato_Click;
            // 
            // btnBaixarParcela
            // 
            btnBaixarParcela.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBaixarParcela.CornerRoundingRadius = 20F;
            btnBaixarParcela.Location = new Point(296, 3);
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
            btnBaixarParcela.Size = new Size(100, 30);
            btnBaixarParcela.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnBaixarParcela.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnBaixarParcela.StateCommon.Back.ColorAngle = 45F;
            btnBaixarParcela.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnBaixarParcela.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBaixarParcela.StateCommon.Border.ColorAngle = 45F;
            btnBaixarParcela.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBaixarParcela.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBaixarParcela.StateCommon.Border.Rounding = 20F;
            btnBaixarParcela.StateCommon.Border.Width = 1;
            btnBaixarParcela.StateCommon.Content.ShortText.Color1 = Color.White;
            btnBaixarParcela.StateCommon.Content.ShortText.Color2 = Color.White;
            btnBaixarParcela.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            btnBaixarParcela.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnBaixarParcela.StateNormal.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnBaixarParcela.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBaixarParcela.StateNormal.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnBaixarParcela.StateNormal.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnBaixarParcela.StateNormal.Border.ColorAngle = 45F;
            btnBaixarParcela.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBaixarParcela.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBaixarParcela.StateNormal.Border.Rounding = 20F;
            btnBaixarParcela.StateNormal.Border.Width = 1;
            btnBaixarParcela.StatePressed.Back.Color1 = Color.White;
            btnBaixarParcela.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnBaixarParcela.StatePressed.Back.ColorAngle = 135F;
            btnBaixarParcela.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnBaixarParcela.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnBaixarParcela.StatePressed.Border.ColorAngle = 135F;
            btnBaixarParcela.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBaixarParcela.StatePressed.Border.Rounding = 20F;
            btnBaixarParcela.StatePressed.Border.Width = 1;
            btnBaixarParcela.StatePressed.Content.ShortText.Color1 = Color.FromArgb(22, 121, 206);
            btnBaixarParcela.StateTracking.Back.Color1 = Color.White;
            btnBaixarParcela.StateTracking.Back.Color2 = Color.White;
            btnBaixarParcela.StateTracking.Back.ColorAngle = 45F;
            btnBaixarParcela.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnBaixarParcela.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBaixarParcela.StateTracking.Border.ColorAngle = 45F;
            btnBaixarParcela.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBaixarParcela.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBaixarParcela.StateTracking.Border.Rounding = 20F;
            btnBaixarParcela.StateTracking.Border.Width = 1;
            btnBaixarParcela.StateTracking.Content.ShortText.Color1 = Color.FromArgb(22, 121, 206);
            btnBaixarParcela.TabIndex = 31;
            btnBaixarParcela.Values.Text = "Baixar";
            btnBaixarParcela.Click += btnBaixarParcela_Click_1;
            // 
            // btnVerItensVenda
            // 
            btnVerItensVenda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVerItensVenda.CornerRoundingRadius = 20F;
            btnVerItensVenda.Location = new Point(190, 3);
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
            btnVerItensVenda.Size = new Size(100, 30);
            btnVerItensVenda.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnVerItensVenda.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 250);
            btnVerItensVenda.StateCommon.Back.ColorAngle = 45F;
            btnVerItensVenda.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnVerItensVenda.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnVerItensVenda.StateCommon.Border.ColorAngle = 45F;
            btnVerItensVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnVerItensVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnVerItensVenda.StateCommon.Border.Rounding = 20F;
            btnVerItensVenda.StateCommon.Border.Width = 1;
            btnVerItensVenda.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnVerItensVenda.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            btnVerItensVenda.StateNormal.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnVerItensVenda.StateNormal.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnVerItensVenda.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnVerItensVenda.StateNormal.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnVerItensVenda.StateNormal.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnVerItensVenda.StateNormal.Border.ColorAngle = 45F;
            btnVerItensVenda.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnVerItensVenda.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnVerItensVenda.StateNormal.Border.Rounding = 20F;
            btnVerItensVenda.StateNormal.Border.Width = 1;
            btnVerItensVenda.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnVerItensVenda.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnVerItensVenda.StatePressed.Back.ColorAngle = 135F;
            btnVerItensVenda.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnVerItensVenda.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnVerItensVenda.StatePressed.Border.ColorAngle = 135F;
            btnVerItensVenda.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnVerItensVenda.StatePressed.Border.Rounding = 20F;
            btnVerItensVenda.StatePressed.Border.Width = 1;
            btnVerItensVenda.StatePressed.Content.ShortText.Color1 = Color.White;
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
            btnVerItensVenda.TabIndex = 30;
            btnVerItensVenda.Values.Text = "Ver Itens";
            btnVerItensVenda.Click += btnVerItensVenda_Click;
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
            // FrmContasReceber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(823, 592);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            MinimizeBox = false;
            Name = "FrmContasReceber";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contas a Receber";
            Load += FrmContasAReceber_Load;
            Shown += FrmContasAReceber_Shown;
            KeyDown += FrmContasAReceber_KeyDown;
            ((System.ComponentModel.ISupportInitialize)cmbStatusParcela).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelFiltroPesquisa).EndInit();
            panelFiltroPesquisa.ResumeLayout(false);
            panelFiltroPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbTipoPesquisa).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvContasAReceber).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagamentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
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
        private Krypton.Toolkit.KryptonPanel panelFiltroPesquisa;
        private Krypton.Toolkit.KryptonDataGridView dgvContasAReceber;
        private Label label1;
        private Krypton.Toolkit.KryptonComboBox cmbTipoPesquisa;
        
        public Krypton.Toolkit.KryptonButton btnExcluir;
        public Krypton.Toolkit.KryptonButton btnAlterar;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Krypton.Toolkit.KryptonLabel lblRotuloQtdContasPagas;
        private Krypton.Toolkit.KryptonLabel lblRotuloQtdContasAReceber;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel18;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonDataGridView dgvPagamentos;
        private FlowLayoutPanel flowLayoutPanel4;
        private ToolTip toolTip1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel lblTotalContasReceber;
        private Krypton.Toolkit.KryptonLabel lblTotalVencido;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private FlowLayoutPanel flowLayoutPanel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel lblTotalSelecionado;
        public Krypton.Toolkit.KryptonButton btnEstornarPagamento;
        public Krypton.Toolkit.KryptonButton btnRecibo;
        public Krypton.Toolkit.KryptonButton btnExtrato;
        public Krypton.Toolkit.KryptonButton btnBaixarParcela;
        public Krypton.Toolkit.KryptonButton btnVerItensVenda;
        public Krypton.Toolkit.KryptonButton btnSair;
        public Krypton.Toolkit.KryptonButton btnLimparFiltro;
        public Krypton.Toolkit.KryptonButton btnPesquisar;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}