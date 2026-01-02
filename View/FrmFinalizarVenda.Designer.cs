namespace GVC.View
{
    partial class FrmFinalizarVenda
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
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPalette2 = new Krypton.Toolkit.KryptonPalette(components);
            tlpFinalizacao = new TableLayoutPanel();
            dgvParcelas = new Krypton.Toolkit.KryptonDataGridView();
            pnCabecalho = new Krypton.Toolkit.KryptonPanel();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            pnResumoVenda = new Krypton.Toolkit.KryptonPanel();
            lblCliente = new Label();
            lblClienteResumo = new Label();
            lblTotal = new Label();
            lblTotalResumo = new Label();
            pnlFormaPgto = new Krypton.Toolkit.KryptonPanel();
            lblFormaPgto = new Label();
            cmbFormaPagamento = new Krypton.Toolkit.KryptonComboBox();
            pnlPagamentoVista = new Krypton.Toolkit.KryptonPanel();
            txtTroco = new Krypton.Toolkit.KryptonTextBox();
            lblTroco = new Label();
            lblValorRecebido = new Label();
            txtValorRecebido = new Krypton.Toolkit.KryptonTextBox();
            pnlObervacao = new Krypton.Toolkit.KryptonPanel();
            label7 = new Label();
            txtObservacao = new Krypton.Toolkit.KryptonTextBox();
            gbParcelamento = new GroupBox();
            btnGerarParcelas = new Krypton.Toolkit.KryptonButton();
            numIntervalo = new Krypton.Toolkit.KryptonNumericUpDown();
            lblIntervalo = new Label();
            dtpPrimeiraParcela = new Krypton.Toolkit.KryptonDateTimePicker();
            numParcelas = new Krypton.Toolkit.KryptonNumericUpDown();
            lblNumParcelas = new Label();
            lblPrimeiraParcela = new Label();
            pnlAcoes = new Krypton.Toolkit.KryptonPanel();
            btnCancelar = new Krypton.Toolkit.KryptonButton();
            btnVoltar = new Krypton.Toolkit.KryptonButton();
            btnConfirmarVenda = new Krypton.Toolkit.KryptonButton();
            lblVendaNumero = new Label();
            lblVendaResumo = new Label();
            tlpFinalizacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParcelas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnCabecalho).BeginInit();
            pnCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnResumoVenda).BeginInit();
            pnResumoVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlFormaPgto).BeginInit();
            pnlFormaPgto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbFormaPagamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlPagamentoVista).BeginInit();
            pnlPagamentoVista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlObervacao).BeginInit();
            pnlObervacao.SuspendLayout();
            gbParcelamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlAcoes).BeginInit();
            pnlAcoes.SuspendLayout();
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
            // tlpFinalizacao
            // 
            tlpFinalizacao.ColumnCount = 1;
            tlpFinalizacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFinalizacao.Controls.Add(dgvParcelas, 0, 5);
            tlpFinalizacao.Controls.Add(pnCabecalho, 0, 0);
            tlpFinalizacao.Controls.Add(pnResumoVenda, 0, 1);
            tlpFinalizacao.Controls.Add(pnlFormaPgto, 0, 2);
            tlpFinalizacao.Controls.Add(pnlPagamentoVista, 0, 3);
            tlpFinalizacao.Controls.Add(pnlObervacao, 0, 6);
            tlpFinalizacao.Controls.Add(gbParcelamento, 0, 4);
            tlpFinalizacao.Controls.Add(pnlAcoes, 0, 7);
            tlpFinalizacao.Dock = DockStyle.Fill;
            tlpFinalizacao.Location = new Point(0, 0);
            tlpFinalizacao.Name = "tlpFinalizacao";
            tlpFinalizacao.RowCount = 8;
            tlpFinalizacao.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpFinalizacao.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpFinalizacao.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tlpFinalizacao.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tlpFinalizacao.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tlpFinalizacao.RowStyles.Add(new RowStyle(SizeType.Absolute, 116F));
            tlpFinalizacao.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpFinalizacao.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tlpFinalizacao.Size = new Size(353, 461);
            tlpFinalizacao.TabIndex = 0;
            // 
            // dgvParcelas
            // 
            dgvParcelas.AllowUserToAddRows = false;
            dgvParcelas.Dock = DockStyle.Fill;
            dgvParcelas.Location = new Point(3, 255);
            dgvParcelas.Name = "dgvParcelas";
            dgvParcelas.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueDarkMode;
            dgvParcelas.RowHeadersWidth = 23;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvParcelas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvParcelas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParcelas.Size = new Size(347, 110);
            dgvParcelas.TabIndex = 1037;
            // 
            // pnCabecalho
            // 
            pnCabecalho.Controls.Add(lblTitulo);
            pnCabecalho.Dock = DockStyle.Fill;
            pnCabecalho.Location = new Point(3, 3);
            pnCabecalho.Name = "pnCabecalho";
            pnCabecalho.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            pnCabecalho.Size = new Size(347, 19);
            pnCabecalho.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(347, 19);
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 0;
            lblTitulo.Values.Text = "FINALIZAR VENDA";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // pnResumoVenda
            // 
            pnResumoVenda.Controls.Add(lblVendaNumero);
            pnResumoVenda.Controls.Add(lblVendaResumo);
            pnResumoVenda.Controls.Add(lblCliente);
            pnResumoVenda.Controls.Add(lblClienteResumo);
            pnResumoVenda.Controls.Add(lblTotal);
            pnResumoVenda.Controls.Add(lblTotalResumo);
            pnResumoVenda.Dock = DockStyle.Fill;
            pnResumoVenda.Location = new Point(3, 28);
            pnResumoVenda.Name = "pnResumoVenda";
            pnResumoVenda.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            pnResumoVenda.Size = new Size(347, 36);
            pnResumoVenda.TabIndex = 1;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.Transparent;
            lblCliente.Font = new Font("Segoe UI", 9F);
            lblCliente.ForeColor = Color.FromArgb(44, 62, 80);
            lblCliente.Location = new Point(62, 1);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(192, 15);
            lblCliente.TabIndex = 1053;
            lblCliente.Text = "MANOEL DA SILVA CUNHA LEMOS";
            lblCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblClienteResumo
            // 
            lblClienteResumo.AutoSize = true;
            lblClienteResumo.BackColor = Color.Transparent;
            lblClienteResumo.Font = new Font("Segoe UI", 9F);
            lblClienteResumo.ForeColor = Color.FromArgb(44, 62, 80);
            lblClienteResumo.Location = new Point(11, 1);
            lblClienteResumo.Name = "lblClienteResumo";
            lblClienteResumo.Size = new Size(47, 15);
            lblClienteResumo.TabIndex = 1052;
            lblClienteResumo.Text = "Cliente:";
            lblClienteResumo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI", 9F);
            lblTotal.ForeColor = Color.FromArgb(44, 62, 80);
            lblTotal.Location = new Point(248, 18);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(56, 15);
            lblTotal.TabIndex = 1051;
            lblTotal.Text = "R$ 918,00";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalResumo
            // 
            lblTotalResumo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalResumo.AutoSize = true;
            lblTotalResumo.BackColor = Color.Transparent;
            lblTotalResumo.Font = new Font("Segoe UI", 9F);
            lblTotalResumo.ForeColor = Color.FromArgb(44, 62, 80);
            lblTotalResumo.Location = new Point(187, 18);
            lblTotalResumo.Name = "lblTotalResumo";
            lblTotalResumo.Size = new Size(44, 15);
            lblTotalResumo.TabIndex = 1050;
            lblTotalResumo.Text = "TOTAL:";
            lblTotalResumo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlFormaPgto
            // 
            pnlFormaPgto.Controls.Add(lblFormaPgto);
            pnlFormaPgto.Controls.Add(cmbFormaPagamento);
            pnlFormaPgto.Dock = DockStyle.Fill;
            pnlFormaPgto.Location = new Point(3, 70);
            pnlFormaPgto.Name = "pnlFormaPgto";
            pnlFormaPgto.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            pnlFormaPgto.Size = new Size(347, 33);
            pnlFormaPgto.TabIndex = 2;
            // 
            // lblFormaPgto
            // 
            lblFormaPgto.AutoSize = true;
            lblFormaPgto.BackColor = Color.Transparent;
            lblFormaPgto.Font = new Font("Segoe UI", 9.75F);
            lblFormaPgto.ForeColor = Color.FromArgb(44, 62, 80);
            lblFormaPgto.Location = new Point(3, 6);
            lblFormaPgto.Name = "lblFormaPgto";
            lblFormaPgto.Size = new Size(138, 17);
            lblFormaPgto.TabIndex = 1036;
            lblFormaPgto.Text = "Forma de pagamento:";
            // 
            // cmbFormaPagamento
            // 
            cmbFormaPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbFormaPagamento.CornerRoundingRadius = 1F;
            cmbFormaPagamento.DropDownWidth = 171;
            cmbFormaPagamento.IntegralHeight = false;
            cmbFormaPagamento.Location = new Point(146, 4);
            cmbFormaPagamento.Name = "cmbFormaPagamento";
            cmbFormaPagamento.Size = new Size(194, 23);
            cmbFormaPagamento.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(8, 142, 250);
            cmbFormaPagamento.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(8, 142, 250);
            cmbFormaPagamento.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbFormaPagamento.StateCommon.ComboBox.Border.Rounding = 1F;
            cmbFormaPagamento.StateCommon.ComboBox.Border.Width = 1;
            cmbFormaPagamento.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFormaPagamento.StateCommon.ComboBox.Content.Padding = new Padding(2, 3, 2, 3);
            cmbFormaPagamento.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbFormaPagamento.TabIndex = 1035;
            cmbFormaPagamento.TabStop = false;
            // 
            // pnlPagamentoVista
            // 
            pnlPagamentoVista.Controls.Add(txtTroco);
            pnlPagamentoVista.Controls.Add(lblTroco);
            pnlPagamentoVista.Controls.Add(lblValorRecebido);
            pnlPagamentoVista.Controls.Add(txtValorRecebido);
            pnlPagamentoVista.Dock = DockStyle.Fill;
            pnlPagamentoVista.Location = new Point(3, 109);
            pnlPagamentoVista.Name = "pnlPagamentoVista";
            pnlPagamentoVista.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            pnlPagamentoVista.Size = new Size(347, 52);
            pnlPagamentoVista.TabIndex = 3;
            // 
            // txtTroco
            // 
            txtTroco.CharacterCasing = CharacterCasing.Upper;
            txtTroco.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtTroco.Location = new Point(146, 28);
            txtTroco.Name = "txtTroco";
            txtTroco.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtTroco.Size = new Size(194, 24);
            txtTroco.StateCommon.Back.Color1 = Color.White;
            txtTroco.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtTroco.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtTroco.StateCommon.Border.ColorAngle = 1F;
            txtTroco.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTroco.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtTroco.StateCommon.Border.Rounding = 1F;
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
            lblTroco.Location = new Point(99, 28);
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
            lblValorRecebido.Location = new Point(43, 1);
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
            txtValorRecebido.Location = new Point(146, 1);
            txtValorRecebido.Name = "txtValorRecebido";
            txtValorRecebido.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtValorRecebido.Size = new Size(194, 24);
            txtValorRecebido.StateCommon.Back.Color1 = Color.White;
            txtValorRecebido.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtValorRecebido.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtValorRecebido.StateCommon.Border.ColorAngle = 1F;
            txtValorRecebido.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtValorRecebido.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtValorRecebido.StateCommon.Border.Rounding = 1F;
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
            // pnlObervacao
            // 
            pnlObervacao.Controls.Add(label7);
            pnlObervacao.Controls.Add(txtObservacao);
            pnlObervacao.Dock = DockStyle.Fill;
            pnlObervacao.Location = new Point(3, 371);
            pnlObervacao.Name = "pnlObervacao";
            pnlObervacao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            pnlObervacao.Size = new Size(347, 46);
            pnlObervacao.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.ForeColor = Color.FromArgb(44, 62, 80);
            label7.Location = new Point(0, 14);
            label7.Name = "label7";
            label7.Size = new Size(81, 17);
            label7.TabIndex = 1037;
            label7.Text = "Observação:";
            // 
            // txtObservacao
            // 
            txtObservacao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtObservacao.CharacterCasing = CharacterCasing.Upper;
            txtObservacao.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtObservacao.Location = new Point(84, 0);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtObservacao.Size = new Size(259, 46);
            txtObservacao.StateCommon.Back.Color1 = Color.White;
            txtObservacao.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtObservacao.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtObservacao.StateCommon.Border.ColorAngle = 1F;
            txtObservacao.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtObservacao.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtObservacao.StateCommon.Border.Rounding = 1F;
            txtObservacao.StateCommon.Border.Width = 1;
            txtObservacao.StateCommon.Content.Color1 = Color.Gray;
            txtObservacao.StateCommon.Content.Font = new Font("Segoe UI", 12.75F);
            txtObservacao.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtObservacao.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtObservacao.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtObservacao.TabIndex = 1036;
            txtObservacao.TabStop = false;
            // 
            // gbParcelamento
            // 
            gbParcelamento.Controls.Add(btnGerarParcelas);
            gbParcelamento.Controls.Add(numIntervalo);
            gbParcelamento.Controls.Add(lblIntervalo);
            gbParcelamento.Controls.Add(dtpPrimeiraParcela);
            gbParcelamento.Controls.Add(numParcelas);
            gbParcelamento.Controls.Add(lblNumParcelas);
            gbParcelamento.Controls.Add(lblPrimeiraParcela);
            gbParcelamento.Dock = DockStyle.Fill;
            gbParcelamento.Location = new Point(3, 167);
            gbParcelamento.Name = "gbParcelamento";
            gbParcelamento.Size = new Size(347, 82);
            gbParcelamento.TabIndex = 7;
            gbParcelamento.TabStop = false;
            // 
            // btnGerarParcelas
            // 
            btnGerarParcelas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGerarParcelas.CornerRoundingRadius = 1F;
            btnGerarParcelas.Location = new Point(232, 48);
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
            btnGerarParcelas.Size = new Size(108, 27);
            btnGerarParcelas.StateCommon.Back.Color1 = Color.FromArgb(0, 192, 0);
            btnGerarParcelas.StateCommon.Back.Color2 = Color.MediumSeaGreen;
            btnGerarParcelas.StateCommon.Back.ColorAngle = 45F;
            btnGerarParcelas.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnGerarParcelas.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnGerarParcelas.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerarParcelas.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerarParcelas.StateCommon.Border.Rounding = 1F;
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
            numIntervalo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numIntervalo.Location = new Point(80, 44);
            numIntervalo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numIntervalo.Name = "numIntervalo";
            numIntervalo.Size = new Size(77, 26);
            numIntervalo.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            numIntervalo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            numIntervalo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numIntervalo.StateCommon.Border.Rounding = 1F;
            numIntervalo.StateCommon.Border.Width = 1;
            numIntervalo.StateCommon.Content.Font = new Font("Segoe UI", 11.25F);
            numIntervalo.StateCommon.Content.Padding = new Padding(2, 3, 2, 3);
            numIntervalo.TabIndex = 1054;
            numIntervalo.Value = new decimal(new int[] { 30, 0, 0, 0 });
            numIntervalo.ValueChanged += numIntervalo_ValueChanged;
            // 
            // lblIntervalo
            // 
            lblIntervalo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblIntervalo.AutoSize = true;
            lblIntervalo.BackColor = Color.Transparent;
            lblIntervalo.Font = new Font("Segoe UI", 9.75F);
            lblIntervalo.ForeColor = Color.FromArgb(44, 62, 80);
            lblIntervalo.Location = new Point(11, 44);
            lblIntervalo.Name = "lblIntervalo";
            lblIntervalo.Size = new Size(61, 17);
            lblIntervalo.TabIndex = 1053;
            lblIntervalo.Text = "Intervalo:";
            // 
            // dtpPrimeiraParcela
            // 
            dtpPrimeiraParcela.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dtpPrimeiraParcela.CalendarTodayDate = new DateTime(2025, 12, 24, 0, 0, 0, 0);
            dtpPrimeiraParcela.CornerRoundingRadius = 1F;
            dtpPrimeiraParcela.Format = DateTimePickerFormat.Short;
            dtpPrimeiraParcela.Location = new Point(232, 17);
            dtpPrimeiraParcela.Name = "dtpPrimeiraParcela";
            dtpPrimeiraParcela.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            dtpPrimeiraParcela.Size = new Size(111, 25);
            dtpPrimeiraParcela.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpPrimeiraParcela.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtpPrimeiraParcela.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpPrimeiraParcela.StateCommon.Border.Rounding = 1F;
            dtpPrimeiraParcela.StateCommon.Border.Width = 1;
            dtpPrimeiraParcela.StateCommon.Content.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpPrimeiraParcela.StateCommon.Content.Padding = new Padding(3);
            dtpPrimeiraParcela.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dtpPrimeiraParcela.TabIndex = 1051;
            // 
            // numParcelas
            // 
            numParcelas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numParcelas.Location = new Point(80, 16);
            numParcelas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numParcelas.Name = "numParcelas";
            numParcelas.Size = new Size(77, 26);
            numParcelas.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            numParcelas.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            numParcelas.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numParcelas.StateCommon.Border.Rounding = 1F;
            numParcelas.StateCommon.Border.Width = 1;
            numParcelas.StateCommon.Content.Font = new Font("Segoe UI", 11.25F);
            numParcelas.StateCommon.Content.Padding = new Padding(3);
            numParcelas.TabIndex = 1050;
            numParcelas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numParcelas.ValueChanged += numParcelas_ValueChanged;
            // 
            // lblNumParcelas
            // 
            lblNumParcelas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblNumParcelas.AutoSize = true;
            lblNumParcelas.BackColor = Color.Transparent;
            lblNumParcelas.Font = new Font("Segoe UI", 9.75F);
            lblNumParcelas.ForeColor = Color.FromArgb(44, 62, 80);
            lblNumParcelas.Location = new Point(0, 16);
            lblNumParcelas.Name = "lblNumParcelas";
            lblNumParcelas.Size = new Size(79, 17);
            lblNumParcelas.TabIndex = 1049;
            lblNumParcelas.Text = "Nº Parcelas:";
            // 
            // lblPrimeiraParcela
            // 
            lblPrimeiraParcela.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPrimeiraParcela.AutoSize = true;
            lblPrimeiraParcela.BackColor = Color.Transparent;
            lblPrimeiraParcela.Font = new Font("Segoe UI", 9.75F);
            lblPrimeiraParcela.ForeColor = Color.FromArgb(44, 62, 80);
            lblPrimeiraParcela.Location = new Point(159, 19);
            lblPrimeiraParcela.Name = "lblPrimeiraParcela";
            lblPrimeiraParcela.Size = new Size(70, 17);
            lblPrimeiraParcela.TabIndex = 1052;
            lblPrimeiraParcela.Text = "1º Parcela:";
            // 
            // pnlAcoes
            // 
            pnlAcoes.Controls.Add(btnCancelar);
            pnlAcoes.Controls.Add(btnVoltar);
            pnlAcoes.Controls.Add(btnConfirmarVenda);
            pnlAcoes.Dock = DockStyle.Fill;
            pnlAcoes.Location = new Point(3, 423);
            pnlAcoes.Name = "pnlAcoes";
            pnlAcoes.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            pnlAcoes.Size = new Size(347, 35);
            pnlAcoes.TabIndex = 1038;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.CornerRoundingRadius = 1F;
            btnCancelar.Location = new Point(132, 4);
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
            btnCancelar.StateCommon.Border.Rounding = 1F;
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
            btnVoltar.Anchor = AnchorStyles.Bottom;
            btnVoltar.CornerRoundingRadius = 1F;
            btnVoltar.Location = new Point(250, 3);
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
            btnVoltar.StateCommon.Border.Rounding = 1F;
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
            // btnConfirmarVenda
            // 
            btnConfirmarVenda.Anchor = AnchorStyles.Bottom;
            btnConfirmarVenda.CornerRoundingRadius = 1F;
            btnConfirmarVenda.Location = new Point(3, 5);
            btnConfirmarVenda.Name = "btnConfirmarVenda";
            btnConfirmarVenda.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmarVenda.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmarVenda.OverrideDefault.Back.ColorAngle = 45F;
            btnConfirmarVenda.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmarVenda.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmarVenda.OverrideDefault.Border.ColorAngle = 45F;
            btnConfirmarVenda.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmarVenda.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmarVenda.OverrideDefault.Border.Rounding = 20F;
            btnConfirmarVenda.OverrideDefault.Border.Width = 1;
            btnConfirmarVenda.Size = new Size(95, 27);
            btnConfirmarVenda.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnConfirmarVenda.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmarVenda.StateCommon.Back.ColorAngle = 45F;
            btnConfirmarVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmarVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmarVenda.StateCommon.Border.Rounding = 1F;
            btnConfirmarVenda.StateCommon.Border.Width = 1;
            btnConfirmarVenda.StateCommon.Content.Padding = new Padding(2, 3, 2, 3);
            btnConfirmarVenda.StateCommon.Content.ShortText.Color1 = Color.White;
            btnConfirmarVenda.StateCommon.Content.ShortText.Color2 = Color.White;
            btnConfirmarVenda.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 8.25F);
            btnConfirmarVenda.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnConfirmarVenda.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnConfirmarVenda.StatePressed.Back.ColorAngle = 135F;
            btnConfirmarVenda.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnConfirmarVenda.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnConfirmarVenda.StatePressed.Border.ColorAngle = 135F;
            btnConfirmarVenda.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmarVenda.StatePressed.Border.Rounding = 20F;
            btnConfirmarVenda.StatePressed.Border.Width = 1;
            btnConfirmarVenda.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnConfirmarVenda.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnConfirmarVenda.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnConfirmarVenda.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnConfirmarVenda.StateTracking.Back.ColorAngle = 45F;
            btnConfirmarVenda.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmarVenda.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmarVenda.StateTracking.Border.ColorAngle = 45F;
            btnConfirmarVenda.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmarVenda.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmarVenda.StateTracking.Border.Rounding = 20F;
            btnConfirmarVenda.StateTracking.Border.Width = 1;
            btnConfirmarVenda.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnConfirmarVenda.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnConfirmarVenda.TabIndex = 1017;
            btnConfirmarVenda.TabStop = false;
            btnConfirmarVenda.Values.Text = "Confirmar Venda";
            btnConfirmarVenda.Click += btnConfirmarVenda_Click;
            // 
            // lblVendaNumero
            // 
            lblVendaNumero.AutoSize = true;
            lblVendaNumero.BackColor = Color.Transparent;
            lblVendaNumero.Font = new Font("Segoe UI", 9F);
            lblVendaNumero.ForeColor = Color.FromArgb(44, 62, 80);
            lblVendaNumero.Location = new Point(61, 18);
            lblVendaNumero.Name = "lblVendaNumero";
            lblVendaNumero.Size = new Size(37, 15);
            lblVendaNumero.TabIndex = 1055;
            lblVendaNumero.Text = "00218";
            lblVendaNumero.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVendaResumo
            // 
            lblVendaResumo.AutoSize = true;
            lblVendaResumo.BackColor = Color.Transparent;
            lblVendaResumo.Font = new Font("Segoe UI", 9F);
            lblVendaResumo.ForeColor = Color.FromArgb(44, 62, 80);
            lblVendaResumo.Location = new Point(-1, 18);
            lblVendaResumo.Name = "lblVendaResumo";
            lblVendaResumo.Size = new Size(59, 15);
            lblVendaResumo.TabIndex = 1054;
            lblVendaResumo.Text = "Venda Nº:";
            lblVendaResumo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmFinalizarVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(353, 461);
            Controls.Add(tlpFinalizacao);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFinalizarVenda";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.Color1 = Color.FromArgb(8, 148, 252);
            StateCommon.Border.Color2 = Color.FromArgb(8, 148, 252);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Load += FrmFinalizarVenda_Load;
            tlpFinalizacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvParcelas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnCabecalho).EndInit();
            pnCabecalho.ResumeLayout(false);
            pnCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnResumoVenda).EndInit();
            pnResumoVenda.ResumeLayout(false);
            pnResumoVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlFormaPgto).EndInit();
            pnlFormaPgto.ResumeLayout(false);
            pnlFormaPgto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbFormaPagamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlPagamentoVista).EndInit();
            pnlPagamentoVista.ResumeLayout(false);
            pnlPagamentoVista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlObervacao).EndInit();
            pnlObervacao.ResumeLayout(false);
            pnlObervacao.PerformLayout();
            gbParcelamento.ResumeLayout(false);
            gbParcelamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlAcoes).EndInit();
            pnlAcoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonPalette kryptonPalette2;
        private TableLayoutPanel tlpFinalizacao;
        private Krypton.Toolkit.KryptonPanel pnCabecalho;
        private Krypton.Toolkit.KryptonPanel pnResumoVenda;
        private Krypton.Toolkit.KryptonPanel pnlFormaPgto;
        private Krypton.Toolkit.KryptonPanel pnlPagamentoVista;
        private Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private Krypton.Toolkit.KryptonPanel pnlObervacao;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private Label lblTotal;
        private Label lblTotalResumo;
        private Label lblCliente;
        private Label lblClienteResumo;
        private Label lblFormaPgto;
        private Krypton.Toolkit.KryptonComboBox cmbFormaPagamento;
        private Label lblValorRecebido;
        public Krypton.Toolkit.KryptonTextBox txtValorRecebido;
        public Krypton.Toolkit.KryptonTextBox txtTroco;
        private Label lblTroco;
        private GroupBox gbParcelamento;
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
        private Krypton.Toolkit.KryptonPanel pnlAcoes;
        public Krypton.Toolkit.KryptonButton btnConfirmarVenda;
        public Krypton.Toolkit.KryptonButton btnVoltar;
        public Krypton.Toolkit.KryptonButton btnCancelar;
        private Label lblVendaNumero;
        private Label lblVendaResumo;
    }
}