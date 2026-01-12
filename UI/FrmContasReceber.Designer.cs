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
            panelFiltroPesquisa = new Krypton.Toolkit.KryptonPanel();
            lblAte = new Label();
            dtpFinal = new Krypton.Toolkit.KryptonDateTimePicker();
            dtpInicial = new Krypton.Toolkit.KryptonDateTimePicker();
            lblPeriodoVenda = new Label();
            grpStatusParcela = new GroupBox();
            chkCancelada = new Krypton.Toolkit.KryptonCheckBox();
            chkAtrasada = new Krypton.Toolkit.KryptonCheckBox();
            chkPago = new Krypton.Toolkit.KryptonCheckBox();
            chkParcial = new Krypton.Toolkit.KryptonCheckBox();
            chkPendente = new Krypton.Toolkit.KryptonCheckBox();
            grpTipoPesquisa = new GroupBox();
            rbPeriodoVenda = new Krypton.Toolkit.KryptonRadioButton();
            rbTodos = new Krypton.Toolkit.KryptonRadioButton();
            rbStatusParcela = new Krypton.Toolkit.KryptonRadioButton();
            rbPeriodoVencimento = new Krypton.Toolkit.KryptonRadioButton();
            rbVencimento = new Krypton.Toolkit.KryptonRadioButton();
            rbDataVenda = new Krypton.Toolkit.KryptonRadioButton();
            rbNumeroVenda = new Krypton.Toolkit.KryptonRadioButton();
            rbNomeCliente = new Krypton.Toolkit.KryptonRadioButton();
            btnLimparFiltro = new Krypton.Toolkit.KryptonButton();
            btnPesquisar = new Krypton.Toolkit.KryptonButton();
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
            ((System.ComponentModel.ISupportInitialize)panelFiltroPesquisa).BeginInit();
            panelFiltroPesquisa.SuspendLayout();
            grpStatusParcela.SuspendLayout();
            grpTipoPesquisa.SuspendLayout();
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
            txtNomeCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNomeCliente.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtNomeCliente.Location = new Point(493, 32);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtNomeCliente.Size = new Size(341, 24);
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
            lblNomeCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.BackColor = Color.Transparent;
            lblNomeCliente.Font = new Font("Segoe UI", 9.75F);
            lblNomeCliente.ForeColor = Color.FromArgb(0, 76, 172);
            lblNomeCliente.Location = new Point(493, 12);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(87, 17);
            lblNomeCliente.TabIndex = 1027;
            lblNomeCliente.Text = "Nome Cliente";
            // 
            // txtNumeroVenda
            // 
            txtNumeroVenda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNumeroVenda.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtNumeroVenda.Location = new Point(840, 33);
            txtNumeroVenda.Name = "txtNumeroVenda";
            txtNumeroVenda.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtNumeroVenda.Size = new Size(84, 24);
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
            lblNumeroVenda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNumeroVenda.AutoSize = true;
            lblNumeroVenda.BackColor = Color.Transparent;
            lblNumeroVenda.Font = new Font("Segoe UI", 9.75F);
            lblNumeroVenda.ForeColor = Color.FromArgb(0, 76, 172);
            lblNumeroVenda.Location = new Point(840, 13);
            lblNumeroVenda.Name = "lblNumeroVenda";
            lblNumeroVenda.Size = new Size(67, 17);
            lblNumeroVenda.TabIndex = 1029;
            lblNumeroVenda.Text = "Nº Venda:";
            // 
            // panelFiltroPesquisa
            // 
            tableLayoutPanel1.SetColumnSpan(panelFiltroPesquisa, 2);
            panelFiltroPesquisa.Controls.Add(lblAte);
            panelFiltroPesquisa.Controls.Add(dtpFinal);
            panelFiltroPesquisa.Controls.Add(dtpInicial);
            panelFiltroPesquisa.Controls.Add(lblPeriodoVenda);
            panelFiltroPesquisa.Controls.Add(grpStatusParcela);
            panelFiltroPesquisa.Controls.Add(grpTipoPesquisa);
            panelFiltroPesquisa.Controls.Add(btnLimparFiltro);
            panelFiltroPesquisa.Controls.Add(btnPesquisar);
            panelFiltroPesquisa.Controls.Add(lblNumeroVenda);
            panelFiltroPesquisa.Controls.Add(lblNomeCliente);
            panelFiltroPesquisa.Controls.Add(txtNumeroVenda);
            panelFiltroPesquisa.Controls.Add(txtNomeCliente);
            panelFiltroPesquisa.Dock = DockStyle.Fill;
            panelFiltroPesquisa.Location = new Point(3, 28);
            panelFiltroPesquisa.Name = "panelFiltroPesquisa";
            panelFiltroPesquisa.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            panelFiltroPesquisa.Size = new Size(931, 109);
            panelFiltroPesquisa.StateCommon.Color1 = Color.White;
            panelFiltroPesquisa.StateCommon.Color2 = Color.White;
            panelFiltroPesquisa.TabIndex = 1038;
            // 
            // lblAte
            // 
            lblAte.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAte.AutoSize = true;
            lblAte.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblAte.ForeColor = Color.FromArgb(0, 76, 172);
            lblAte.Location = new Point(591, 85);
            lblAte.Name = "lblAte";
            lblAte.Size = new Size(27, 16);
            lblAte.TabIndex = 1094;
            lblAte.Text = "Até";
            // 
            // dtpFinal
            // 
            dtpFinal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpFinal.CornerRoundingRadius = 6F;
            dtpFinal.Format = DateTimePickerFormat.Short;
            dtpFinal.Location = new Point(619, 76);
            dtpFinal.Name = "dtpFinal";
            dtpFinal.Size = new Size(96, 31);
            dtpFinal.StateActive.Back.Color1 = Color.FromArgb(6, 174, 244);
            dtpFinal.StateActive.Border.Color1 = Color.FromArgb(6, 174, 244);
            dtpFinal.StateActive.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtpFinal.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpFinal.StateActive.Border.Rounding = 6F;
            dtpFinal.StateActive.Content.Color1 = Color.White;
            dtpFinal.StateActive.Content.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFinal.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtpFinal.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpFinal.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtpFinal.StateCommon.Border.ColorAngle = 45F;
            dtpFinal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpFinal.StateCommon.Border.Rounding = 6F;
            dtpFinal.StateCommon.Border.Width = 1;
            dtpFinal.StateCommon.Content.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFinal.StateCommon.Content.Padding = new Padding(1);
            dtpFinal.StateDisabled.Border.ColorAngle = 45F;
            dtpFinal.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpFinal.StateDisabled.Border.Rounding = 6F;
            dtpFinal.StateDisabled.Border.Width = 1;
            dtpFinal.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtpFinal.StateNormal.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpFinal.StateNormal.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtpFinal.StateNormal.Border.ColorAngle = 45F;
            dtpFinal.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpFinal.StateNormal.Border.Rounding = 6F;
            dtpFinal.StateNormal.Border.Width = 1;
            dtpFinal.StateNormal.Content.Color1 = Color.White;
            dtpFinal.TabIndex = 1093;
            // 
            // dtpInicial
            // 
            dtpInicial.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpInicial.CornerRoundingRadius = 6F;
            dtpInicial.Format = DateTimePickerFormat.Short;
            dtpInicial.Location = new Point(493, 78);
            dtpInicial.Name = "dtpInicial";
            dtpInicial.Size = new Size(97, 31);
            dtpInicial.StateActive.Back.Color1 = Color.FromArgb(6, 174, 244);
            dtpInicial.StateActive.Border.Color1 = Color.FromArgb(6, 174, 244);
            dtpInicial.StateActive.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtpInicial.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpInicial.StateActive.Border.Rounding = 6F;
            dtpInicial.StateActive.Content.Color1 = Color.White;
            dtpInicial.StateActive.Content.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpInicial.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtpInicial.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpInicial.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtpInicial.StateCommon.Border.ColorAngle = 45F;
            dtpInicial.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpInicial.StateCommon.Border.Rounding = 6F;
            dtpInicial.StateCommon.Border.Width = 1;
            dtpInicial.StateCommon.Content.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpInicial.StateCommon.Content.Padding = new Padding(1);
            dtpInicial.StateDisabled.Border.ColorAngle = 45F;
            dtpInicial.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpInicial.StateDisabled.Border.Rounding = 6F;
            dtpInicial.StateDisabled.Border.Width = 1;
            dtpInicial.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtpInicial.StateNormal.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpInicial.StateNormal.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtpInicial.StateNormal.Border.ColorAngle = 45F;
            dtpInicial.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpInicial.StateNormal.Border.Rounding = 6F;
            dtpInicial.StateNormal.Border.Width = 1;
            dtpInicial.StateNormal.Content.Color1 = Color.White;
            dtpInicial.TabIndex = 1092;
            // 
            // lblPeriodoVenda
            // 
            lblPeriodoVenda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPeriodoVenda.AutoSize = true;
            lblPeriodoVenda.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblPeriodoVenda.ForeColor = Color.FromArgb(0, 76, 172);
            lblPeriodoVenda.Location = new Point(493, 60);
            lblPeriodoVenda.Name = "lblPeriodoVenda";
            lblPeriodoVenda.Size = new Size(58, 16);
            lblPeriodoVenda.TabIndex = 1091;
            lblPeriodoVenda.Text = "Período:";
            // 
            // grpStatusParcela
            // 
            grpStatusParcela.Controls.Add(chkCancelada);
            grpStatusParcela.Controls.Add(chkAtrasada);
            grpStatusParcela.Controls.Add(chkPago);
            grpStatusParcela.Controls.Add(chkParcial);
            grpStatusParcela.Controls.Add(chkPendente);
            grpStatusParcela.Location = new Point(282, 3);
            grpStatusParcela.Name = "grpStatusParcela";
            grpStatusParcela.Size = new Size(205, 106);
            grpStatusParcela.TabIndex = 1043;
            grpStatusParcela.TabStop = false;
            grpStatusParcela.Text = "Status";
            // 
            // chkCancelada
            // 
            chkCancelada.Location = new Point(126, 38);
            chkCancelada.Name = "chkCancelada";
            chkCancelada.Size = new Size(79, 20);
            chkCancelada.TabIndex = 4;
            chkCancelada.Values.Text = "Cancelada";
            // 
            // chkAtrasada
            // 
            chkAtrasada.Location = new Point(126, 17);
            chkAtrasada.Name = "chkAtrasada";
            chkAtrasada.Size = new Size(71, 20);
            chkAtrasada.TabIndex = 3;
            chkAtrasada.Values.Text = "Atrasada";
            // 
            // chkPago
            // 
            chkPago.Location = new Point(9, 37);
            chkPago.Name = "chkPago";
            chkPago.Size = new Size(51, 20);
            chkPago.TabIndex = 2;
            chkPago.Values.Text = "Pago";
            // 
            // chkParcial
            // 
            chkParcial.Location = new Point(9, 59);
            chkParcial.Name = "chkParcial";
            chkParcial.Size = new Size(125, 20);
            chkParcial.TabIndex = 1;
            chkParcial.Values.Text = "Parcialmente Pago";
            // 
            // chkPendente
            // 
            chkPendente.Location = new Point(9, 17);
            chkPendente.Name = "chkPendente";
            chkPendente.Size = new Size(75, 20);
            chkPendente.TabIndex = 0;
            chkPendente.Values.Text = "Pendente";
            // 
            // grpTipoPesquisa
            // 
            grpTipoPesquisa.Controls.Add(rbPeriodoVenda);
            grpTipoPesquisa.Controls.Add(rbTodos);
            grpTipoPesquisa.Controls.Add(rbStatusParcela);
            grpTipoPesquisa.Controls.Add(rbPeriodoVencimento);
            grpTipoPesquisa.Controls.Add(rbVencimento);
            grpTipoPesquisa.Controls.Add(rbDataVenda);
            grpTipoPesquisa.Controls.Add(rbNumeroVenda);
            grpTipoPesquisa.Controls.Add(rbNomeCliente);
            grpTipoPesquisa.Location = new Point(9, 3);
            grpTipoPesquisa.Name = "grpTipoPesquisa";
            grpTipoPesquisa.Size = new Size(269, 106);
            grpTipoPesquisa.TabIndex = 1042;
            grpTipoPesquisa.TabStop = false;
            grpTipoPesquisa.Text = "Tipo Pesquisa";
            // 
            // rbPeriodoVenda
            // 
            rbPeriodoVenda.Location = new Point(121, 54);
            rbPeriodoVenda.Name = "rbPeriodoVenda";
            rbPeriodoVenda.Size = new Size(120, 20);
            rbPeriodoVenda.TabIndex = 8;
            rbPeriodoVenda.Values.Text = "Período da Venda";
            // 
            // rbTodos
            // 
            rbTodos.Location = new Point(6, 13);
            rbTodos.Name = "rbTodos";
            rbTodos.Size = new Size(56, 20);
            rbTodos.TabIndex = 7;
            rbTodos.Values.Text = "Todos";
            // 
            // rbStatusParcela
            // 
            rbStatusParcela.Location = new Point(6, 54);
            rbStatusParcela.Name = "rbStatusParcela";
            rbStatusParcela.Size = new Size(98, 20);
            rbStatusParcela.TabIndex = 6;
            rbStatusParcela.Values.Text = "Status Parcela";
            // 
            // rbPeriodoVencimento
            // 
            rbPeriodoVencimento.Location = new Point(121, 74);
            rbPeriodoVencimento.Name = "rbPeriodoVencimento";
            rbPeriodoVencimento.Size = new Size(151, 20);
            rbPeriodoVencimento.TabIndex = 5;
            rbPeriodoVencimento.Values.Text = "Período de Vencimento";
            // 
            // rbVencimento
            // 
            rbVencimento.Location = new Point(121, 34);
            rbVencimento.Name = "rbVencimento";
            rbVencimento.Size = new Size(88, 20);
            rbVencimento.TabIndex = 4;
            rbVencimento.Values.Text = "Vencimento";
            // 
            // rbDataVenda
            // 
            rbDataVenda.Location = new Point(121, 13);
            rbDataVenda.Name = "rbDataVenda";
            rbDataVenda.Size = new Size(103, 20);
            rbDataVenda.TabIndex = 3;
            rbDataVenda.Values.Text = "Data da Venda";
            // 
            // rbNumeroVenda
            // 
            rbNumeroVenda.Location = new Point(6, 34);
            rbNumeroVenda.Name = "rbNumeroVenda";
            rbNumeroVenda.Size = new Size(122, 20);
            rbNumeroVenda.TabIndex = 2;
            rbNumeroVenda.Values.Text = "Número da Venda";
            // 
            // rbNomeCliente
            // 
            rbNomeCliente.Location = new Point(6, 74);
            rbNomeCliente.Name = "rbNomeCliente";
            rbNomeCliente.Size = new Size(115, 20);
            rbNomeCliente.TabIndex = 1;
            rbNomeCliente.Values.Text = "Nome do Cliente";
            // 
            // btnLimparFiltro
            // 
            btnLimparFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimparFiltro.CornerRoundingRadius = 20F;
            btnLimparFiltro.Location = new Point(829, 76);
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
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.CornerRoundingRadius = 20F;
            btnPesquisar.Location = new Point(725, 76);
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
            // dgvContasAReceber
            // 
            tableLayoutPanel1.SetColumnSpan(dgvContasAReceber, 2);
            dgvContasAReceber.Dock = DockStyle.Fill;
            dgvContasAReceber.Location = new Point(3, 143);
            dgvContasAReceber.Name = "dgvContasAReceber";
            dgvContasAReceber.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            dgvContasAReceber.Size = new Size(931, 153);
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 115F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(937, 531);
            tableLayoutPanel1.TabIndex = 1069;
            // 
            // kryptonPanel4
            // 
            tableLayoutPanel1.SetColumnSpan(kryptonPanel4, 2);
            kryptonPanel4.Dock = DockStyle.Fill;
            kryptonPanel4.Location = new Point(3, 3);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.Size = new Size(931, 19);
            kryptonPanel4.StateCommon.Color1 = Color.FromArgb(41, 129, 229);
            kryptonPanel4.StateCommon.Color2 = Color.FromArgb(41, 129, 229);
            kryptonPanel4.TabIndex = 1051;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(3, 302);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Black;
            kryptonLabel2.Size = new Size(227, 19);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.Black;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel2.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel2.TabIndex = 1052;
            kryptonLabel2.Values.Text = "Pagamentos da parcela selecionada";
            // 
            // dgvPagamentos
            // 
            dgvPagamentos.Dock = DockStyle.Fill;
            dgvPagamentos.Location = new Point(3, 339);
            dgvPagamentos.Name = "dgvPagamentos";
            dgvPagamentos.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            dgvPagamentos.Size = new Size(573, 153);
            dgvPagamentos.TabIndex = 1053;
            dgvPagamentos.CellContentClick += dgvPagamentos_CellContentClick;
            dgvPagamentos.CurrentCellDirtyStateChanged += dgvPagamentos_CurrentCellDirtyStateChanged;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(lblTotalSelecionado);
            kryptonPanel2.Location = new Point(3, 498);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(463, 29);
            kryptonPanel2.StateCommon.Color1 = Color.White;
            kryptonPanel2.StateCommon.Color2 = Color.White;
            kryptonPanel2.TabIndex = 1054;
            // 
            // lblTotalSelecionado
            // 
            lblTotalSelecionado.Anchor = AnchorStyles.Left;
            lblTotalSelecionado.Location = new Point(2, 3);
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
            kryptonPanel3.Location = new Point(582, 339);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(352, 153);
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
            flowLayoutPanel1.Size = new Size(163, 153);
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
            flowLayoutPanel3.Size = new Size(218, 153);
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
            flowLayoutPanel4.Size = new Size(933, 33);
            flowLayoutPanel4.TabIndex = 1072;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSair.CornerRoundingRadius = 20F;
            btnSair.Location = new Point(830, 3);
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
            btnEstornarPagamento.Location = new Point(724, 3);
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
            btnRecibo.Location = new Point(618, 3);
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
            btnExtrato.Location = new Point(512, 3);
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
            btnBaixarParcela.Location = new Point(406, 3);
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
            btnVerItensVenda.Location = new Point(300, 3);
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
            ClientSize = new Size(933, 592);
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
            WindowState = FormWindowState.Maximized;
            Load += FrmContasAReceber_Load;
            Shown += FrmContasAReceber_Shown;
            KeyDown += FrmContasAReceber_KeyDown;
            ((System.ComponentModel.ISupportInitialize)panelFiltroPesquisa).EndInit();
            panelFiltroPesquisa.ResumeLayout(false);
            panelFiltroPesquisa.PerformLayout();
            grpStatusParcela.ResumeLayout(false);
            grpStatusParcela.PerformLayout();
            grpTipoPesquisa.ResumeLayout(false);
            grpTipoPesquisa.PerformLayout();
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
        private Krypton.Toolkit.KryptonPanel panelFiltroPesquisa;
        private Krypton.Toolkit.KryptonDataGridView dgvContasAReceber;
        
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
        private GroupBox grpTipoPesquisa;
        private Krypton.Toolkit.KryptonRadioButton rbStatusParcela;
        private Krypton.Toolkit.KryptonRadioButton rbPeriodoVencimento;
        private Krypton.Toolkit.KryptonRadioButton rbVencimento;
        private Krypton.Toolkit.KryptonRadioButton rbDataVenda;
        private Krypton.Toolkit.KryptonRadioButton rbNumeroVenda;
        private Krypton.Toolkit.KryptonRadioButton rbNomeCliente;
        private GroupBox grpStatusParcela;
        private Krypton.Toolkit.KryptonCheckBox chkCancelada;
        private Krypton.Toolkit.KryptonCheckBox chkAtrasada;
        private Krypton.Toolkit.KryptonCheckBox chkPago;
        private Krypton.Toolkit.KryptonCheckBox chkParcial;
        private Krypton.Toolkit.KryptonCheckBox chkPendente;
        private Krypton.Toolkit.KryptonRadioButton rbTodos;
        private Label lblAte;
        public Krypton.Toolkit.KryptonDateTimePicker dtpFinal;
        public Krypton.Toolkit.KryptonDateTimePicker dtpInicial;
        private Label lblPeriodoVenda;
        private Krypton.Toolkit.KryptonRadioButton rbPeriodoVenda;
    }
}