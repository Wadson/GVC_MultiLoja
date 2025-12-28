namespace GVC.View
{
    partial class FrmPDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPDV));
            txtClienteBuscar = new Krypton.Toolkit.KryptonTextBox();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            lblDesconto = new Label();
            txtDesconto = new Krypton.Toolkit.KryptonTextBox();
            lblTotalLiquido = new Label();
            txtTotalGeral = new Krypton.Toolkit.KryptonTextBox();
            cmbFormaPagamento = new Krypton.Toolkit.KryptonComboBox();
            btnAdicionarItem = new Krypton.Toolkit.KryptonButton();
            btnSalvarVenda = new Krypton.Toolkit.KryptonButton();
            btnCancelarVenda = new Krypton.Toolkit.KryptonButton();
            btnImprimir = new Krypton.Toolkit.KryptonButton();
            label10 = new Label();
            txtProdutoBuscar = new Krypton.Toolkit.KryptonTextBox();
            txtPrecoUnitario = new Krypton.Toolkit.KryptonTextBox();
            label13 = new Label();
            label12 = new Label();
            txtValorRecebido = new Krypton.Toolkit.KryptonTextBox();
            lblValorRecebido = new Label();
            label1 = new Label();
            lblVendaID = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblData = new Label();
            txtQuantidade = new Krypton.Toolkit.KryptonTextBox();
            txtSubTotal = new Krypton.Toolkit.KryptonTextBox();
            lblTotalBruto = new Label();
            txtTroco = new Krypton.Toolkit.KryptonTextBox();
            lblTroco = new Label();
            btnGerarParcelas = new Krypton.Toolkit.KryptonButton();
            btnCancelarParcelas = new Krypton.Toolkit.KryptonButton();
            numIntervalo = new Krypton.Toolkit.KryptonNumericUpDown();
            lblIntervalo = new Label();
            dgvParcelas = new Krypton.Toolkit.KryptonDataGridView();
            numParcelas = new Krypton.Toolkit.KryptonNumericUpDown();
            lblQtdParcelas = new Label();
            lblPrimeiroVenc = new Label();
            dtPrimeira = new Krypton.Toolkit.KryptonDateTimePicker();
            lblFormaPgto = new Label();
            txtObservacao = new Krypton.Toolkit.KryptonTextBox();
            txtFechar = new Krypton.Toolkit.KryptonButton();
            kryptonPanelBotoesControle = new Krypton.Toolkit.KryptonPanel();
            btnNovaVenda = new Krypton.Toolkit.KryptonButton();
            btnListarControles = new Krypton.Toolkit.KryptonButton();
            pnlTitulo = new Krypton.Toolkit.KryptonPanel();
            lblTituloPDV = new Krypton.Toolkit.KryptonLabel();
            pnlCabecalhoVenda = new Krypton.Toolkit.KryptonPanel();
            lstProdutos = new Krypton.Toolkit.KryptonListBox();
            lstVendedores = new Krypton.Toolkit.KryptonListBox();
            lstClientes = new Krypton.Toolkit.KryptonListBox();
            txtVendedorBuscar = new Krypton.Toolkit.KryptonTextBox();
            pnlFormaPgto = new Krypton.Toolkit.KryptonPanel();
            label9 = new Label();
            dgvItensVenda = new Krypton.Toolkit.KryptonDataGridView();
            pnlObservacoes = new Krypton.Toolkit.KryptonPanel();
            label7 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanelTotais = new FlowLayoutPanel();
            label4 = new Label();
            txtTotalItens = new Krypton.Toolkit.KryptonTextBox();
            pnlDgvItens = new Krypton.Toolkit.KryptonPanel();
            TableLayoutPanelFormaPgto = new Krypton.Toolkit.KryptonTableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)cmbFormaPagamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvParcelas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanelBotoesControle).BeginInit();
            kryptonPanelBotoesControle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlTitulo).BeginInit();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlCabecalhoVenda).BeginInit();
            pnlCabecalhoVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlFormaPgto).BeginInit();
            pnlFormaPgto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlObservacoes).BeginInit();
            pnlObservacoes.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanelTotais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlDgvItens).BeginInit();
            pnlDgvItens.SuspendLayout();
            TableLayoutPanelFormaPgto.SuspendLayout();
            SuspendLayout();
            // 
            // txtClienteBuscar
            // 
            txtClienteBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClienteBuscar.CharacterCasing = CharacterCasing.Upper;
            txtClienteBuscar.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtClienteBuscar.Location = new Point(10, 18);
            txtClienteBuscar.Name = "txtClienteBuscar";
            txtClienteBuscar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtClienteBuscar.Size = new Size(630, 24);
            txtClienteBuscar.StateCommon.Back.Color1 = Color.White;
            txtClienteBuscar.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtClienteBuscar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtClienteBuscar.StateCommon.Border.ColorAngle = 1F;
            txtClienteBuscar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtClienteBuscar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtClienteBuscar.StateCommon.Border.Rounding = 6F;
            txtClienteBuscar.StateCommon.Border.Width = 1;
            txtClienteBuscar.StateCommon.Content.Color1 = Color.Gray;
            txtClienteBuscar.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtClienteBuscar.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtClienteBuscar.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtClienteBuscar.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtClienteBuscar.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtClienteBuscar.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtClienteBuscar.TabIndex = 0;
            txtClienteBuscar.TextChanged += txtClienteBuscar_TextChanged;
            txtClienteBuscar.KeyDown += txtClienteBuscar_KeyDown;
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
            // lblDesconto
            // 
            lblDesconto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDesconto.AutoSize = true;
            lblDesconto.BackColor = Color.Transparent;
            lblDesconto.Font = new Font("Segoe UI", 9.75F);
            lblDesconto.ForeColor = Color.White;
            lblDesconto.Location = new Point(103, 57);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(90, 17);
            lblDesconto.TabIndex = 638;
            lblDesconto.Text = "Desconto (R$)";
            lblDesconto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDesconto
            // 
            txtDesconto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDesconto.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtDesconto.Location = new Point(3, 77);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtDesconto.Size = new Size(190, 34);
            txtDesconto.StateCommon.Back.Color1 = Color.White;
            txtDesconto.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtDesconto.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtDesconto.StateCommon.Border.ColorAngle = 1F;
            txtDesconto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDesconto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtDesconto.StateCommon.Border.Rounding = 6F;
            txtDesconto.StateCommon.Border.Width = 1;
            txtDesconto.StateCommon.Content.Color1 = Color.Gray;
            txtDesconto.StateCommon.Content.Font = new Font("Segoe UI", 15.75F);
            txtDesconto.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtDesconto.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtDesconto.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtDesconto.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtDesconto.TabIndex = 30;
            txtDesconto.TabStop = false;
            txtDesconto.Leave += txtDesconto_Leave;
            // 
            // lblTotalLiquido
            // 
            lblTotalLiquido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalLiquido.AutoSize = true;
            lblTotalLiquido.BackColor = Color.Transparent;
            lblTotalLiquido.Font = new Font("Segoe UI", 10.75F);
            lblTotalLiquido.ForeColor = Color.White;
            lblTotalLiquido.Location = new Point(94, 114);
            lblTotalLiquido.Name = "lblTotalLiquido";
            lblTotalLiquido.Size = new Size(99, 20);
            lblTotalLiquido.TabIndex = 640;
            lblTotalLiquido.Text = "Total Líquido:";
            lblTotalLiquido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTotalGeral
            // 
            txtTotalGeral.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotalGeral.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtTotalGeral.Location = new Point(3, 137);
            txtTotalGeral.Name = "txtTotalGeral";
            txtTotalGeral.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtTotalGeral.ReadOnly = true;
            txtTotalGeral.Size = new Size(190, 34);
            txtTotalGeral.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 192);
            txtTotalGeral.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtTotalGeral.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtTotalGeral.StateCommon.Border.ColorAngle = 1F;
            txtTotalGeral.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTotalGeral.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtTotalGeral.StateCommon.Border.Rounding = 6F;
            txtTotalGeral.StateCommon.Border.Width = 1;
            txtTotalGeral.StateCommon.Content.Color1 = Color.Gray;
            txtTotalGeral.StateCommon.Content.Font = new Font("Segoe UI", 15.75F);
            txtTotalGeral.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtTotalGeral.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtTotalGeral.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtTotalGeral.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtTotalGeral.TabIndex = 641;
            txtTotalGeral.TabStop = false;
            // 
            // cmbFormaPagamento
            // 
            cmbFormaPagamento.CornerRoundingRadius = 6F;
            cmbFormaPagamento.DropDownWidth = 171;
            cmbFormaPagamento.IntegralHeight = false;
            cmbFormaPagamento.Items.AddRange(new object[] { "Á Vista", "Crediário Parcelado", "Cartão de Crédito", "Cartão de Débito", "Pix", "Transferência" });
            cmbFormaPagamento.Location = new Point(11, 22);
            cmbFormaPagamento.Name = "cmbFormaPagamento";
            cmbFormaPagamento.Size = new Size(426, 27);
            cmbFormaPagamento.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbFormaPagamento.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbFormaPagamento.StateCommon.ComboBox.Border.Width = 1;
            cmbFormaPagamento.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFormaPagamento.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbFormaPagamento.TabIndex = 1014;
            cmbFormaPagamento.TabStop = false;
            cmbFormaPagamento.SelectedIndexChanged += cmbFormaPgto_SelectedIndexChanged;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdicionarItem.CornerRoundingRadius = 6F;
            btnAdicionarItem.Location = new Point(908, 61);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnAdicionarItem.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnAdicionarItem.OverrideDefault.Back.ColorAngle = 45F;
            btnAdicionarItem.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAdicionarItem.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAdicionarItem.OverrideDefault.Border.ColorAngle = 45F;
            btnAdicionarItem.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdicionarItem.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdicionarItem.OverrideDefault.Border.Rounding = 20F;
            btnAdicionarItem.OverrideDefault.Border.Width = 1;
            btnAdicionarItem.Size = new Size(105, 25);
            btnAdicionarItem.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnAdicionarItem.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnAdicionarItem.StateCommon.Back.ColorAngle = 45F;
            btnAdicionarItem.StateCommon.Border.Color1 = Color.FromArgb(252, 252, 250);
            btnAdicionarItem.StateCommon.Border.Color2 = Color.FromArgb(252, 252, 250);
            btnAdicionarItem.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdicionarItem.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdicionarItem.StateCommon.Border.Rounding = 6F;
            btnAdicionarItem.StateCommon.Border.Width = 1;
            btnAdicionarItem.StateCommon.Content.ShortText.Color1 = Color.FromArgb(50, 50, 50);
            btnAdicionarItem.StateCommon.Content.ShortText.Color2 = Color.FromArgb(50, 50, 50);
            btnAdicionarItem.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnAdicionarItem.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnAdicionarItem.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnAdicionarItem.StatePressed.Back.ColorAngle = 135F;
            btnAdicionarItem.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnAdicionarItem.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnAdicionarItem.StatePressed.Border.ColorAngle = 135F;
            btnAdicionarItem.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdicionarItem.StatePressed.Border.Rounding = 20F;
            btnAdicionarItem.StatePressed.Border.Width = 1;
            btnAdicionarItem.StatePressed.Content.ShortText.Color1 = Color.FromArgb(50, 50, 50);
            btnAdicionarItem.StatePressed.Content.ShortText.Color2 = Color.FromArgb(50, 50, 50);
            btnAdicionarItem.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnAdicionarItem.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnAdicionarItem.StateTracking.Back.ColorAngle = 45F;
            btnAdicionarItem.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAdicionarItem.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAdicionarItem.StateTracking.Border.ColorAngle = 45F;
            btnAdicionarItem.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdicionarItem.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdicionarItem.StateTracking.Border.Rounding = 20F;
            btnAdicionarItem.StateTracking.Border.Width = 1;
            btnAdicionarItem.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnAdicionarItem.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnAdicionarItem.TabIndex = 4;
            btnAdicionarItem.Values.Text = "Adicionar item";
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // btnSalvarVenda
            // 
            btnSalvarVenda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvarVenda.CornerRoundingRadius = 6F;
            btnSalvarVenda.Location = new Point(616, 5);
            btnSalvarVenda.Name = "btnSalvarVenda";
            btnSalvarVenda.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvarVenda.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvarVenda.OverrideDefault.Back.ColorAngle = 45F;
            btnSalvarVenda.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvarVenda.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvarVenda.OverrideDefault.Border.ColorAngle = 45F;
            btnSalvarVenda.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvarVenda.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvarVenda.OverrideDefault.Border.Rounding = 20F;
            btnSalvarVenda.OverrideDefault.Border.Width = 1;
            btnSalvarVenda.Size = new Size(130, 27);
            btnSalvarVenda.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSalvarVenda.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvarVenda.StateCommon.Back.ColorAngle = 45F;
            btnSalvarVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvarVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvarVenda.StateCommon.Border.Rounding = 6F;
            btnSalvarVenda.StateCommon.Border.Width = 1;
            btnSalvarVenda.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSalvarVenda.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSalvarVenda.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnSalvarVenda.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnSalvarVenda.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnSalvarVenda.StatePressed.Back.ColorAngle = 135F;
            btnSalvarVenda.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSalvarVenda.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSalvarVenda.StatePressed.Border.ColorAngle = 135F;
            btnSalvarVenda.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvarVenda.StatePressed.Border.Rounding = 20F;
            btnSalvarVenda.StatePressed.Border.Width = 1;
            btnSalvarVenda.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnSalvarVenda.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnSalvarVenda.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnSalvarVenda.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnSalvarVenda.StateTracking.Back.ColorAngle = 45F;
            btnSalvarVenda.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvarVenda.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvarVenda.StateTracking.Border.ColorAngle = 45F;
            btnSalvarVenda.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvarVenda.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvarVenda.StateTracking.Border.Rounding = 20F;
            btnSalvarVenda.StateTracking.Border.Width = 1;
            btnSalvarVenda.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnSalvarVenda.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnSalvarVenda.TabIndex = 1016;
            btnSalvarVenda.TabStop = false;
            btnSalvarVenda.Values.Text = "Salvar Venda";
            btnSalvarVenda.Click += btnSalvarVenda_Click;
            // 
            // btnCancelarVenda
            // 
            btnCancelarVenda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelarVenda.CornerRoundingRadius = 6F;
            btnCancelarVenda.Location = new Point(753, 5);
            btnCancelarVenda.Name = "btnCancelarVenda";
            btnCancelarVenda.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelarVenda.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelarVenda.OverrideDefault.Back.ColorAngle = 45F;
            btnCancelarVenda.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelarVenda.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelarVenda.OverrideDefault.Border.ColorAngle = 45F;
            btnCancelarVenda.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelarVenda.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelarVenda.OverrideDefault.Border.Rounding = 20F;
            btnCancelarVenda.OverrideDefault.Border.Width = 1;
            btnCancelarVenda.Size = new Size(130, 27);
            btnCancelarVenda.StateCommon.Back.Color1 = Color.Red;
            btnCancelarVenda.StateCommon.Back.Color2 = Color.Red;
            btnCancelarVenda.StateCommon.Back.ColorAngle = 45F;
            btnCancelarVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelarVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelarVenda.StateCommon.Border.Rounding = 6F;
            btnCancelarVenda.StateCommon.Border.Width = 1;
            btnCancelarVenda.StateCommon.Content.ShortText.Color1 = Color.White;
            btnCancelarVenda.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCancelarVenda.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnCancelarVenda.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnCancelarVenda.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnCancelarVenda.StatePressed.Back.ColorAngle = 135F;
            btnCancelarVenda.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnCancelarVenda.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnCancelarVenda.StatePressed.Border.ColorAngle = 135F;
            btnCancelarVenda.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelarVenda.StatePressed.Border.Rounding = 20F;
            btnCancelarVenda.StatePressed.Border.Width = 1;
            btnCancelarVenda.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnCancelarVenda.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnCancelarVenda.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnCancelarVenda.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnCancelarVenda.StateTracking.Back.ColorAngle = 45F;
            btnCancelarVenda.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelarVenda.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelarVenda.StateTracking.Border.ColorAngle = 45F;
            btnCancelarVenda.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelarVenda.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelarVenda.StateTracking.Border.Rounding = 20F;
            btnCancelarVenda.StateTracking.Border.Width = 1;
            btnCancelarVenda.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnCancelarVenda.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnCancelarVenda.TabIndex = 1019;
            btnCancelarVenda.TabStop = false;
            btnCancelarVenda.Values.Text = "Cancelar";
            btnCancelarVenda.Click += btnCancelar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnImprimir.CornerRoundingRadius = 6F;
            btnImprimir.Location = new Point(344, 6);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnImprimir.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnImprimir.OverrideDefault.Back.ColorAngle = 45F;
            btnImprimir.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnImprimir.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnImprimir.OverrideDefault.Border.ColorAngle = 45F;
            btnImprimir.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnImprimir.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnImprimir.OverrideDefault.Border.Rounding = 20F;
            btnImprimir.OverrideDefault.Border.Width = 1;
            btnImprimir.Size = new Size(130, 27);
            btnImprimir.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnImprimir.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnImprimir.StateCommon.Back.ColorAngle = 45F;
            btnImprimir.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnImprimir.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnImprimir.StateCommon.Border.Rounding = 6F;
            btnImprimir.StateCommon.Border.Width = 1;
            btnImprimir.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnImprimir.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnImprimir.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnImprimir.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnImprimir.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnImprimir.StatePressed.Back.ColorAngle = 135F;
            btnImprimir.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnImprimir.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnImprimir.StatePressed.Border.ColorAngle = 135F;
            btnImprimir.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnImprimir.StatePressed.Border.Rounding = 20F;
            btnImprimir.StatePressed.Border.Width = 1;
            btnImprimir.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnImprimir.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnImprimir.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnImprimir.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnImprimir.StateTracking.Back.ColorAngle = 45F;
            btnImprimir.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnImprimir.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnImprimir.StateTracking.Border.ColorAngle = 45F;
            btnImprimir.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnImprimir.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnImprimir.StateTracking.Border.Rounding = 20F;
            btnImprimir.StateTracking.Border.Width = 1;
            btnImprimir.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnImprimir.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnImprimir.TabIndex = 1020;
            btnImprimir.TabStop = false;
            btnImprimir.Values.Text = "Imprimir Cupom";
            btnImprimir.Click += btnImprimir_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9.75F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(10, 1);
            label10.Name = "label10";
            label10.Size = new Size(50, 17);
            label10.TabIndex = 1025;
            label10.Text = "Cliente:";
            // 
            // txtProdutoBuscar
            // 
            txtProdutoBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProdutoBuscar.CharacterCasing = CharacterCasing.Upper;
            txtProdutoBuscar.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtProdutoBuscar.Location = new Point(10, 62);
            txtProdutoBuscar.Name = "txtProdutoBuscar";
            txtProdutoBuscar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtProdutoBuscar.Size = new Size(630, 24);
            txtProdutoBuscar.StateCommon.Back.Color1 = Color.White;
            txtProdutoBuscar.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtProdutoBuscar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtProdutoBuscar.StateCommon.Border.ColorAngle = 1F;
            txtProdutoBuscar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtProdutoBuscar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtProdutoBuscar.StateCommon.Border.Rounding = 6F;
            txtProdutoBuscar.StateCommon.Border.Width = 1;
            txtProdutoBuscar.StateCommon.Content.Color1 = Color.Gray;
            txtProdutoBuscar.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtProdutoBuscar.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtProdutoBuscar.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtProdutoBuscar.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtProdutoBuscar.TabIndex = 2;
            txtProdutoBuscar.TextChanged += txtProdutoBuscar_TextChanged;
            // 
            // txtPrecoUnitario
            // 
            txtPrecoUnitario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPrecoUnitario.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtPrecoUnitario.Location = new Point(773, 61);
            txtPrecoUnitario.Name = "txtPrecoUnitario";
            txtPrecoUnitario.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtPrecoUnitario.Size = new Size(131, 24);
            txtPrecoUnitario.StateCommon.Back.Color1 = Color.White;
            txtPrecoUnitario.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtPrecoUnitario.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtPrecoUnitario.StateCommon.Border.ColorAngle = 1F;
            txtPrecoUnitario.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPrecoUnitario.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPrecoUnitario.StateCommon.Border.Rounding = 6F;
            txtPrecoUnitario.StateCommon.Border.Width = 1;
            txtPrecoUnitario.StateCommon.Content.Color1 = Color.Gray;
            txtPrecoUnitario.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtPrecoUnitario.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtPrecoUnitario.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtPrecoUnitario.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtPrecoUnitario.TabIndex = 3;
            txtPrecoUnitario.TextChanged += txtPrecoUnitario_TextChanged;
            txtPrecoUnitario.KeyPress += txtPrecoUnitario_KeyPress;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 9.75F);
            label13.ForeColor = Color.White;
            label13.Location = new Point(778, 42);
            label13.Name = "label13";
            label13.Size = new Size(91, 17);
            label13.TabIndex = 646;
            label13.Text = "Preço Unitario";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9.75F);
            label12.ForeColor = Color.White;
            label12.Location = new Point(650, 42);
            label12.Name = "label12";
            label12.Size = new Size(76, 17);
            label12.TabIndex = 644;
            label12.Text = "Quantidade";
            // 
            // txtValorRecebido
            // 
            txtValorRecebido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtValorRecebido.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtValorRecebido.Location = new Point(3, 251);
            txtValorRecebido.Name = "txtValorRecebido";
            txtValorRecebido.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtValorRecebido.Size = new Size(190, 34);
            txtValorRecebido.StateCommon.Back.Color1 = Color.White;
            txtValorRecebido.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtValorRecebido.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtValorRecebido.StateCommon.Border.ColorAngle = 1F;
            txtValorRecebido.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtValorRecebido.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtValorRecebido.StateCommon.Border.Rounding = 6F;
            txtValorRecebido.StateCommon.Border.Width = 1;
            txtValorRecebido.StateCommon.Content.Color1 = Color.Gray;
            txtValorRecebido.StateCommon.Content.Font = new Font("Segoe UI", 15.75F);
            txtValorRecebido.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtValorRecebido.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtValorRecebido.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorRecebido.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorRecebido.TabIndex = 40;
            txtValorRecebido.TabStop = false;
            txtValorRecebido.Leave += txtValorRecebido_Leave;
            // 
            // lblValorRecebido
            // 
            lblValorRecebido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblValorRecebido.AutoSize = true;
            lblValorRecebido.BackColor = Color.Transparent;
            lblValorRecebido.Font = new Font("Segoe UI", 9.75F);
            lblValorRecebido.ForeColor = Color.White;
            lblValorRecebido.Location = new Point(104, 231);
            lblValorRecebido.Name = "lblValorRecebido";
            lblValorRecebido.Size = new Size(89, 17);
            lblValorRecebido.TabIndex = 642;
            lblValorRecebido.Text = "Vlr. Recebido:";
            lblValorRecebido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 7);
            label1.Name = "label1";
            label1.Size = new Size(92, 17);
            label1.TabIndex = 1033;
            label1.Text = "CÓD. VENDA:";
            // 
            // lblVendaID
            // 
            lblVendaID.AutoSize = true;
            lblVendaID.BackColor = Color.Transparent;
            lblVendaID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblVendaID.ForeColor = Color.White;
            lblVendaID.Location = new Point(99, 7);
            lblVendaID.Name = "lblVendaID";
            lblVendaID.Size = new Size(64, 17);
            lblVendaID.TabIndex = 1034;
            lblVendaID.Text = "Venda ID";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(650, 1);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 1045;
            label5.Text = "Vendedor";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(837, 7);
            label3.Name = "label3";
            label3.Size = new Size(95, 17);
            label3.TabIndex = 1035;
            label3.Text = "DATA VENDA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 43);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 1026;
            label2.Text = "Produto:";
            // 
            // lblData
            // 
            lblData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblData.AutoSize = true;
            lblData.BackColor = Color.Transparent;
            lblData.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblData.ForeColor = Color.White;
            lblData.Location = new Point(935, 7);
            lblData.Name = "lblData";
            lblData.Size = new Size(79, 17);
            lblData.TabIndex = 1036;
            lblData.Text = "Data Venda";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtQuantidade.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtQuantidade.Location = new Point(650, 61);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtQuantidade.Size = new Size(114, 24);
            txtQuantidade.StateCommon.Back.Color1 = Color.White;
            txtQuantidade.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtQuantidade.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtQuantidade.StateCommon.Border.ColorAngle = 1F;
            txtQuantidade.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtQuantidade.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtQuantidade.StateCommon.Border.Rounding = 6F;
            txtQuantidade.StateCommon.Border.Width = 1;
            txtQuantidade.StateCommon.Content.Color1 = Color.Gray;
            txtQuantidade.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtQuantidade.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtQuantidade.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtQuantidade.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtQuantidade.TabIndex = 2;
            txtQuantidade.TextAlign = HorizontalAlignment.Center;
            txtQuantidade.KeyPress += txtQuantidade_KeyPress;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSubTotal.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtSubTotal.Location = new Point(3, 20);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(190, 34);
            txtSubTotal.StateCommon.Back.Color1 = Color.White;
            txtSubTotal.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtSubTotal.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtSubTotal.StateCommon.Border.ColorAngle = 1F;
            txtSubTotal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSubTotal.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSubTotal.StateCommon.Border.Rounding = 6F;
            txtSubTotal.StateCommon.Border.Width = 1;
            txtSubTotal.StateCommon.Content.Color1 = Color.Gray;
            txtSubTotal.StateCommon.Content.Font = new Font("Segoe UI", 15.75F);
            txtSubTotal.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSubTotal.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtSubTotal.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtSubTotal.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtSubTotal.TabIndex = 1031;
            txtSubTotal.TabStop = false;
            // 
            // lblTotalBruto
            // 
            lblTotalBruto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalBruto.AutoSize = true;
            lblTotalBruto.BackColor = Color.Transparent;
            lblTotalBruto.Font = new Font("Segoe UI", 9.75F);
            lblTotalBruto.ForeColor = Color.White;
            lblTotalBruto.Location = new Point(119, 0);
            lblTotalBruto.Name = "lblTotalBruto";
            lblTotalBruto.Size = new Size(74, 17);
            lblTotalBruto.TabIndex = 1030;
            lblTotalBruto.Text = "Total Bruto:";
            lblTotalBruto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTroco
            // 
            txtTroco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTroco.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtTroco.Location = new Point(3, 308);
            txtTroco.Name = "txtTroco";
            txtTroco.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtTroco.Size = new Size(190, 34);
            txtTroco.StateCommon.Back.Color1 = Color.White;
            txtTroco.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtTroco.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtTroco.StateCommon.Border.ColorAngle = 1F;
            txtTroco.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTroco.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtTroco.StateCommon.Border.Rounding = 6F;
            txtTroco.StateCommon.Border.Width = 1;
            txtTroco.StateCommon.Content.Color1 = Color.Gray;
            txtTroco.StateCommon.Content.Font = new Font("Segoe UI", 15.75F);
            txtTroco.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtTroco.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtTroco.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtTroco.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtTroco.TabIndex = 1032;
            txtTroco.TabStop = false;
            // 
            // lblTroco
            // 
            lblTroco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTroco.AutoSize = true;
            lblTroco.BackColor = Color.Transparent;
            lblTroco.Font = new Font("Segoe UI", 9.75F);
            lblTroco.ForeColor = Color.White;
            lblTroco.Location = new Point(149, 288);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(44, 17);
            lblTroco.TabIndex = 1033;
            lblTroco.Text = "Troco:";
            lblTroco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGerarParcelas
            // 
            btnGerarParcelas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGerarParcelas.CornerRoundingRadius = 10F;
            btnGerarParcelas.Location = new Point(295, 70);
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
            btnGerarParcelas.Size = new Size(70, 25);
            btnGerarParcelas.StateCommon.Back.Color1 = Color.FromArgb(0, 192, 0);
            btnGerarParcelas.StateCommon.Back.Color2 = Color.MediumSeaGreen;
            btnGerarParcelas.StateCommon.Back.ColorAngle = 45F;
            btnGerarParcelas.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnGerarParcelas.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnGerarParcelas.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerarParcelas.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerarParcelas.StateCommon.Border.Rounding = 10F;
            btnGerarParcelas.StateCommon.Border.Width = 1;
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
            btnGerarParcelas.TabIndex = 1040;
            btnGerarParcelas.Values.Text = "Gerar";
            btnGerarParcelas.Click += btnGerar_Click;
            // 
            // btnCancelarParcelas
            // 
            btnCancelarParcelas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelarParcelas.CornerRoundingRadius = 10F;
            btnCancelarParcelas.Location = new Point(367, 69);
            btnCancelarParcelas.Name = "btnCancelarParcelas";
            btnCancelarParcelas.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelarParcelas.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelarParcelas.OverrideDefault.Back.ColorAngle = 45F;
            btnCancelarParcelas.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelarParcelas.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelarParcelas.OverrideDefault.Border.ColorAngle = 45F;
            btnCancelarParcelas.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelarParcelas.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelarParcelas.OverrideDefault.Border.Rounding = 20F;
            btnCancelarParcelas.OverrideDefault.Border.Width = 1;
            btnCancelarParcelas.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnCancelarParcelas.Size = new Size(70, 25);
            btnCancelarParcelas.StateCommon.Back.Color1 = Color.FromArgb(200, 10, 39);
            btnCancelarParcelas.StateCommon.Back.Color2 = Color.Red;
            btnCancelarParcelas.StateCommon.Back.ColorAngle = 45F;
            btnCancelarParcelas.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelarParcelas.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelarParcelas.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelarParcelas.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelarParcelas.StateCommon.Border.Rounding = 10F;
            btnCancelarParcelas.StateCommon.Border.Width = 1;
            btnCancelarParcelas.StateCommon.Content.ShortText.Color1 = Color.White;
            btnCancelarParcelas.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCancelarParcelas.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnCancelarParcelas.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnCancelarParcelas.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnCancelarParcelas.StatePressed.Back.ColorAngle = 135F;
            btnCancelarParcelas.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnCancelarParcelas.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnCancelarParcelas.StatePressed.Border.ColorAngle = 135F;
            btnCancelarParcelas.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelarParcelas.StatePressed.Border.Rounding = 20F;
            btnCancelarParcelas.StatePressed.Border.Width = 1;
            btnCancelarParcelas.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnCancelarParcelas.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnCancelarParcelas.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnCancelarParcelas.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnCancelarParcelas.StateTracking.Back.ColorAngle = 45F;
            btnCancelarParcelas.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelarParcelas.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelarParcelas.StateTracking.Border.ColorAngle = 45F;
            btnCancelarParcelas.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelarParcelas.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelarParcelas.StateTracking.Border.Rounding = 20F;
            btnCancelarParcelas.StateTracking.Border.Width = 1;
            btnCancelarParcelas.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnCancelarParcelas.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnCancelarParcelas.TabIndex = 1041;
            btnCancelarParcelas.Values.Text = "Cancelar";
            btnCancelarParcelas.Click += btnCancelarParcelas_Click;
            // 
            // numIntervalo
            // 
            numIntervalo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numIntervalo.Location = new Point(194, 70);
            numIntervalo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numIntervalo.Name = "numIntervalo";
            numIntervalo.Size = new Size(97, 26);
            numIntervalo.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            numIntervalo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            numIntervalo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numIntervalo.StateCommon.Border.Rounding = 6F;
            numIntervalo.StateCommon.Border.Width = 1;
            numIntervalo.TabIndex = 1048;
            numIntervalo.Value = new decimal(new int[] { 30, 0, 0, 0 });
            numIntervalo.ValueChanged += numIntervalo_ValueChanged;
            // 
            // lblIntervalo
            // 
            lblIntervalo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblIntervalo.AutoSize = true;
            lblIntervalo.BackColor = Color.Transparent;
            lblIntervalo.Font = new Font("Segoe UI", 9.75F);
            lblIntervalo.ForeColor = Color.White;
            lblIntervalo.Location = new Point(199, 50);
            lblIntervalo.Name = "lblIntervalo";
            lblIntervalo.Size = new Size(41, 17);
            lblIntervalo.TabIndex = 1047;
            lblIntervalo.Text = "Prazo";
            // 
            // dgvParcelas
            // 
            dgvParcelas.AllowUserToAddRows = false;
            dgvParcelas.Dock = DockStyle.Fill;
            dgvParcelas.Location = new Point(445, 3);
            dgvParcelas.Name = "dgvParcelas";
            dgvParcelas.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            dgvParcelas.RowHeadersWidth = 23;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvParcelas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            TableLayoutPanelFormaPgto.SetRowSpan(dgvParcelas, 2);
            dgvParcelas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParcelas.Size = new Size(376, 204);
            dgvParcelas.TabIndex = 1036;
            // 
            // numParcelas
            // 
            numParcelas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numParcelas.Location = new Point(11, 69);
            numParcelas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numParcelas.Name = "numParcelas";
            numParcelas.Size = new Size(79, 26);
            numParcelas.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            numParcelas.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            numParcelas.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numParcelas.StateCommon.Border.Rounding = 6F;
            numParcelas.StateCommon.Border.Width = 1;
            numParcelas.TabIndex = 1043;
            numParcelas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numParcelas.ValueChanged += numParcelas_ValueChanged;
            // 
            // lblQtdParcelas
            // 
            lblQtdParcelas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblQtdParcelas.AutoSize = true;
            lblQtdParcelas.BackColor = Color.Transparent;
            lblQtdParcelas.Font = new Font("Segoe UI", 9.75F);
            lblQtdParcelas.ForeColor = Color.White;
            lblQtdParcelas.Location = new Point(11, 49);
            lblQtdParcelas.Name = "lblQtdParcelas";
            lblQtdParcelas.Size = new Size(79, 17);
            lblQtdParcelas.TabIndex = 1042;
            lblQtdParcelas.Text = "Nº Parcelas:";
            // 
            // lblPrimeiroVenc
            // 
            lblPrimeiroVenc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPrimeiroVenc.AutoSize = true;
            lblPrimeiroVenc.BackColor = Color.Transparent;
            lblPrimeiroVenc.Font = new Font("Segoe UI", 9.75F);
            lblPrimeiroVenc.ForeColor = Color.White;
            lblPrimeiroVenc.Location = new Point(94, 50);
            lblPrimeiroVenc.Name = "lblPrimeiroVenc";
            lblPrimeiroVenc.Size = new Size(98, 17);
            lblPrimeiroVenc.TabIndex = 1045;
            lblPrimeiroVenc.Text = "Data 1º Parcela";
            // 
            // dtPrimeira
            // 
            dtPrimeira.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dtPrimeira.CalendarTodayDate = new DateTime(2025, 12, 24, 0, 0, 0, 0);
            dtPrimeira.CornerRoundingRadius = 6F;
            dtPrimeira.Format = DateTimePickerFormat.Short;
            dtPrimeira.Location = new Point(91, 70);
            dtPrimeira.Name = "dtPrimeira";
            dtPrimeira.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            dtPrimeira.Size = new Size(101, 25);
            dtPrimeira.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtPrimeira.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtPrimeira.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtPrimeira.StateCommon.Border.Rounding = 6F;
            dtPrimeira.StateCommon.Border.Width = 1;
            dtPrimeira.TabIndex = 1044;
            // 
            // lblFormaPgto
            // 
            lblFormaPgto.AutoSize = true;
            lblFormaPgto.BackColor = Color.Transparent;
            lblFormaPgto.Font = new Font("Segoe UI", 9.75F);
            lblFormaPgto.ForeColor = Color.White;
            lblFormaPgto.Location = new Point(11, 2);
            lblFormaPgto.Name = "lblFormaPgto";
            lblFormaPgto.Size = new Size(76, 17);
            lblFormaPgto.TabIndex = 1034;
            lblFormaPgto.Text = "Forma Pgto";
            // 
            // txtObservacao
            // 
            txtObservacao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtObservacao.CharacterCasing = CharacterCasing.Upper;
            txtObservacao.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtObservacao.Location = new Point(8, 27);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtObservacao.Size = new Size(425, 64);
            txtObservacao.StateCommon.Back.Color1 = Color.White;
            txtObservacao.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtObservacao.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtObservacao.StateCommon.Border.ColorAngle = 1F;
            txtObservacao.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtObservacao.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtObservacao.StateCommon.Border.Rounding = 8F;
            txtObservacao.StateCommon.Border.Width = 1;
            txtObservacao.StateCommon.Content.Color1 = Color.Gray;
            txtObservacao.StateCommon.Content.Font = new Font("Segoe UI", 12.75F);
            txtObservacao.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtObservacao.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtObservacao.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtObservacao.TabIndex = 1027;
            txtObservacao.TabStop = false;
            txtObservacao.TextChanged += txtObservacao_TextChanged;
            // 
            // txtFechar
            // 
            txtFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtFechar.CornerRoundingRadius = 6F;
            txtFechar.Location = new Point(888, 5);
            txtFechar.Name = "txtFechar";
            txtFechar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            txtFechar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            txtFechar.OverrideDefault.Back.ColorAngle = 45F;
            txtFechar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            txtFechar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtFechar.OverrideDefault.Border.ColorAngle = 45F;
            txtFechar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtFechar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtFechar.OverrideDefault.Border.Rounding = 20F;
            txtFechar.OverrideDefault.Border.Width = 1;
            txtFechar.Size = new Size(130, 27);
            txtFechar.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            txtFechar.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            txtFechar.StateCommon.Back.ColorAngle = 45F;
            txtFechar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtFechar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtFechar.StateCommon.Border.Rounding = 6F;
            txtFechar.StateCommon.Border.Width = 1;
            txtFechar.StateCommon.Content.ShortText.Color1 = Color.White;
            txtFechar.StateCommon.Content.ShortText.Color2 = Color.White;
            txtFechar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            txtFechar.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            txtFechar.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            txtFechar.StatePressed.Back.ColorAngle = 135F;
            txtFechar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            txtFechar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            txtFechar.StatePressed.Border.ColorAngle = 135F;
            txtFechar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtFechar.StatePressed.Border.Rounding = 20F;
            txtFechar.StatePressed.Border.Width = 1;
            txtFechar.StatePressed.Content.ShortText.Color1 = Color.Black;
            txtFechar.StatePressed.Content.ShortText.Color2 = Color.Black;
            txtFechar.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            txtFechar.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            txtFechar.StateTracking.Back.ColorAngle = 45F;
            txtFechar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            txtFechar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtFechar.StateTracking.Border.ColorAngle = 45F;
            txtFechar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtFechar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtFechar.StateTracking.Border.Rounding = 20F;
            txtFechar.StateTracking.Border.Width = 1;
            txtFechar.StateTracking.Content.ShortText.Color1 = Color.Black;
            txtFechar.StateTracking.Content.ShortText.Color2 = Color.Black;
            txtFechar.TabIndex = 1041;
            txtFechar.TabStop = false;
            txtFechar.Values.Text = "Fechar";
            txtFechar.Click += txtFechar_Click;
            // 
            // kryptonPanelBotoesControle
            // 
            kryptonPanelBotoesControle.Controls.Add(btnNovaVenda);
            kryptonPanelBotoesControle.Controls.Add(btnListarControles);
            kryptonPanelBotoesControle.Controls.Add(txtFechar);
            kryptonPanelBotoesControle.Controls.Add(btnCancelarVenda);
            kryptonPanelBotoesControle.Controls.Add(btnImprimir);
            kryptonPanelBotoesControle.Controls.Add(btnSalvarVenda);
            kryptonPanelBotoesControle.Dock = DockStyle.Bottom;
            kryptonPanelBotoesControle.Location = new Point(0, 712);
            kryptonPanelBotoesControle.Name = "kryptonPanelBotoesControle";
            kryptonPanelBotoesControle.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007SilverDarkMode;
            kryptonPanelBotoesControle.Size = new Size(1024, 37);
            kryptonPanelBotoesControle.StateCommon.Color1 = Color.FromArgb(44, 62, 80);
            kryptonPanelBotoesControle.StateCommon.Color2 = Color.FromArgb(44, 62, 80);
            kryptonPanelBotoesControle.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonPanelBotoesControle.TabIndex = 1042;
            // 
            // btnNovaVenda
            // 
            btnNovaVenda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNovaVenda.CornerRoundingRadius = 6F;
            btnNovaVenda.Location = new Point(480, 6);
            btnNovaVenda.Name = "btnNovaVenda";
            btnNovaVenda.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnNovaVenda.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnNovaVenda.OverrideDefault.Back.ColorAngle = 45F;
            btnNovaVenda.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNovaVenda.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNovaVenda.OverrideDefault.Border.ColorAngle = 45F;
            btnNovaVenda.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovaVenda.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovaVenda.OverrideDefault.Border.Rounding = 20F;
            btnNovaVenda.OverrideDefault.Border.Width = 1;
            btnNovaVenda.Size = new Size(130, 27);
            btnNovaVenda.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnNovaVenda.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnNovaVenda.StateCommon.Back.ColorAngle = 45F;
            btnNovaVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovaVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovaVenda.StateCommon.Border.Rounding = 6F;
            btnNovaVenda.StateCommon.Border.Width = 1;
            btnNovaVenda.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnNovaVenda.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnNovaVenda.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnNovaVenda.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnNovaVenda.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnNovaVenda.StatePressed.Back.ColorAngle = 135F;
            btnNovaVenda.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnNovaVenda.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnNovaVenda.StatePressed.Border.ColorAngle = 135F;
            btnNovaVenda.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovaVenda.StatePressed.Border.Rounding = 20F;
            btnNovaVenda.StatePressed.Border.Width = 1;
            btnNovaVenda.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnNovaVenda.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnNovaVenda.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnNovaVenda.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnNovaVenda.StateTracking.Back.ColorAngle = 45F;
            btnNovaVenda.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNovaVenda.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNovaVenda.StateTracking.Border.ColorAngle = 45F;
            btnNovaVenda.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovaVenda.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovaVenda.StateTracking.Border.Rounding = 20F;
            btnNovaVenda.StateTracking.Border.Width = 1;
            btnNovaVenda.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnNovaVenda.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnNovaVenda.TabIndex = 1043;
            btnNovaVenda.TabStop = false;
            btnNovaVenda.Values.Text = "Nova Venda";
            btnNovaVenda.Click += btnNovaVenda_Click;
            // 
            // btnListarControles
            // 
            btnListarControles.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnListarControles.CornerRoundingRadius = 6F;
            btnListarControles.Location = new Point(8, 5);
            btnListarControles.Name = "btnListarControles";
            btnListarControles.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnListarControles.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnListarControles.OverrideDefault.Back.ColorAngle = 45F;
            btnListarControles.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnListarControles.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnListarControles.OverrideDefault.Border.ColorAngle = 45F;
            btnListarControles.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnListarControles.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnListarControles.OverrideDefault.Border.Rounding = 20F;
            btnListarControles.OverrideDefault.Border.Width = 1;
            btnListarControles.Size = new Size(130, 27);
            btnListarControles.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnListarControles.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnListarControles.StateCommon.Back.ColorAngle = 45F;
            btnListarControles.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnListarControles.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnListarControles.StateCommon.Border.Rounding = 6F;
            btnListarControles.StateCommon.Border.Width = 1;
            btnListarControles.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnListarControles.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnListarControles.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnListarControles.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnListarControles.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnListarControles.StatePressed.Back.ColorAngle = 135F;
            btnListarControles.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnListarControles.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnListarControles.StatePressed.Border.ColorAngle = 135F;
            btnListarControles.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnListarControles.StatePressed.Border.Rounding = 20F;
            btnListarControles.StatePressed.Border.Width = 1;
            btnListarControles.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnListarControles.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnListarControles.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnListarControles.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnListarControles.StateTracking.Back.ColorAngle = 45F;
            btnListarControles.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnListarControles.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnListarControles.StateTracking.Border.ColorAngle = 45F;
            btnListarControles.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnListarControles.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnListarControles.StateTracking.Border.Rounding = 20F;
            btnListarControles.StateTracking.Border.Width = 1;
            btnListarControles.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnListarControles.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnListarControles.TabIndex = 1042;
            btnListarControles.TabStop = false;
            btnListarControles.Values.Text = "Listar Controles";
            btnListarControles.Click += btnListarControles_Click;
            // 
            // pnlTitulo
            // 
            pnlTitulo.Controls.Add(label3);
            pnlTitulo.Controls.Add(label1);
            pnlTitulo.Controls.Add(lblData);
            pnlTitulo.Controls.Add(lblVendaID);
            pnlTitulo.Controls.Add(lblTituloPDV);
            pnlTitulo.Dock = DockStyle.Fill;
            pnlTitulo.Location = new Point(3, 3);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010SilverDarkMode;
            pnlTitulo.Size = new Size(1018, 29);
            pnlTitulo.StateCommon.Color1 = Color.FromArgb(44, 62, 80);
            pnlTitulo.StateCommon.Color2 = Color.FromArgb(44, 62, 80);
            pnlTitulo.TabIndex = 1042;
            // 
            // lblTituloPDV
            // 
            lblTituloPDV.Dock = DockStyle.Fill;
            lblTituloPDV.Location = new Point(0, 0);
            lblTituloPDV.Name = "lblTituloPDV";
            lblTituloPDV.Size = new Size(1018, 29);
            lblTituloPDV.StateCommon.ShortText.Color1 = Color.FromArgb(252, 252, 250);
            lblTituloPDV.StateCommon.ShortText.Color2 = Color.FromArgb(252, 252, 250);
            lblTituloPDV.StateCommon.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloPDV.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTituloPDV.TabIndex = 0;
            lblTituloPDV.Values.Text = "FRENTE DE CAIXA - PDV";
            // 
            // pnlCabecalhoVenda
            // 
            pnlCabecalhoVenda.Controls.Add(lstProdutos);
            pnlCabecalhoVenda.Controls.Add(lstVendedores);
            pnlCabecalhoVenda.Controls.Add(lstClientes);
            pnlCabecalhoVenda.Controls.Add(txtVendedorBuscar);
            pnlCabecalhoVenda.Controls.Add(label5);
            pnlCabecalhoVenda.Controls.Add(label2);
            pnlCabecalhoVenda.Controls.Add(txtQuantidade);
            pnlCabecalhoVenda.Controls.Add(txtPrecoUnitario);
            pnlCabecalhoVenda.Controls.Add(label12);
            pnlCabecalhoVenda.Controls.Add(btnAdicionarItem);
            pnlCabecalhoVenda.Controls.Add(label13);
            pnlCabecalhoVenda.Controls.Add(label10);
            pnlCabecalhoVenda.Controls.Add(txtClienteBuscar);
            pnlCabecalhoVenda.Controls.Add(txtProdutoBuscar);
            pnlCabecalhoVenda.Dock = DockStyle.Top;
            pnlCabecalhoVenda.Location = new Point(3, 38);
            pnlCabecalhoVenda.Name = "pnlCabecalhoVenda";
            pnlCabecalhoVenda.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007SilverDarkMode;
            pnlCabecalhoVenda.Size = new Size(1018, 141);
            pnlCabecalhoVenda.StateCommon.Color1 = Color.FromArgb(0, 90, 180);
            pnlCabecalhoVenda.StateCommon.Color2 = Color.FromArgb(102, 178, 255);
            pnlCabecalhoVenda.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            pnlCabecalhoVenda.TabIndex = 1048;
            // 
            // lstProdutos
            // 
            lstProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstProdutos.Location = new Point(10, 87);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(629, 70);
            lstProdutos.TabIndex = 1049;
            lstProdutos.TabStop = false;
            lstProdutos.Visible = false;
            lstProdutos.DoubleClick += lstProdutos_DoubleClick;
            lstProdutos.KeyDown += lstProdutos_KeyDown;
            lstProdutos.PreviewKeyDown += lstProdutos_PreviewKeyDown;
            // 
            // lstVendedores
            // 
            lstVendedores.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstVendedores.Location = new Point(650, 42);
            lstVendedores.Name = "lstVendedores";
            lstVendedores.Size = new Size(365, 78);
            lstVendedores.TabIndex = 1047;
            lstVendedores.Visible = false;
            lstVendedores.DoubleClick += lstVendedores_DoubleClick;
            lstVendedores.KeyDown += lstVendedores_KeyDown;
            lstVendedores.PreviewKeyDown += lstVendedores_PreviewKeyDown;
            // 
            // lstClientes
            // 
            lstClientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstClientes.Location = new Point(12, 42);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(630, 63);
            lstClientes.TabIndex = 1048;
            lstClientes.TabStop = false;
            lstClientes.Visible = false;
            lstClientes.DoubleClick += lstClientes_DoubleClick;
            lstClientes.KeyDown += lstClientes_KeyDown;
            lstClientes.PreviewKeyDown += lstClientes_PreviewKeyDown;
            // 
            // txtVendedorBuscar
            // 
            txtVendedorBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtVendedorBuscar.CharacterCasing = CharacterCasing.Upper;
            txtVendedorBuscar.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtVendedorBuscar.Location = new Point(650, 18);
            txtVendedorBuscar.Name = "txtVendedorBuscar";
            txtVendedorBuscar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtVendedorBuscar.Size = new Size(365, 24);
            txtVendedorBuscar.StateCommon.Back.Color1 = Color.White;
            txtVendedorBuscar.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtVendedorBuscar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtVendedorBuscar.StateCommon.Border.ColorAngle = 1F;
            txtVendedorBuscar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtVendedorBuscar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtVendedorBuscar.StateCommon.Border.Rounding = 6F;
            txtVendedorBuscar.StateCommon.Border.Width = 1;
            txtVendedorBuscar.StateCommon.Content.Color1 = Color.Gray;
            txtVendedorBuscar.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtVendedorBuscar.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtVendedorBuscar.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtVendedorBuscar.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtVendedorBuscar.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtVendedorBuscar.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtVendedorBuscar.TabIndex = 1;
            txtVendedorBuscar.TextChanged += txtVendedorBuscar_TextChanged;
            txtVendedorBuscar.KeyDown += txtVendedorBuscar_KeyDown;
            // 
            // pnlFormaPgto
            // 
            pnlFormaPgto.Controls.Add(lblFormaPgto);
            pnlFormaPgto.Controls.Add(btnCancelarParcelas);
            pnlFormaPgto.Controls.Add(cmbFormaPagamento);
            pnlFormaPgto.Controls.Add(btnGerarParcelas);
            pnlFormaPgto.Controls.Add(numIntervalo);
            pnlFormaPgto.Controls.Add(lblIntervalo);
            pnlFormaPgto.Controls.Add(label9);
            pnlFormaPgto.Controls.Add(numParcelas);
            pnlFormaPgto.Controls.Add(lblPrimeiroVenc);
            pnlFormaPgto.Controls.Add(lblQtdParcelas);
            pnlFormaPgto.Controls.Add(dtPrimeira);
            pnlFormaPgto.Dock = DockStyle.Fill;
            pnlFormaPgto.Location = new Point(3, 3);
            pnlFormaPgto.Name = "pnlFormaPgto";
            pnlFormaPgto.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            pnlFormaPgto.Size = new Size(436, 99);
            pnlFormaPgto.StateCommon.Color1 = Color.FromArgb(0, 90, 180);
            pnlFormaPgto.StateCommon.Color2 = Color.FromArgb(102, 178, 255);
            pnlFormaPgto.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            pnlFormaPgto.TabIndex = 1054;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(1134, 0);
            label9.Name = "label9";
            label9.Size = new Size(76, 17);
            label9.TabIndex = 1034;
            label9.Text = "Forma Pgto";
            // 
            // dgvItensVenda
            // 
            dgvItensVenda.Dock = DockStyle.Fill;
            dgvItensVenda.Location = new Point(0, 0);
            dgvItensVenda.Name = "dgvItensVenda";
            dgvItensVenda.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            dgvItensVenda.RowHeadersWidth = 23;
            dgvItensVenda.Size = new Size(824, 342);
            dgvItensVenda.TabIndex = 1051;
            dgvItensVenda.TabStop = false;
            dgvItensVenda.CellContentClick += dgvItensVenda_CellContentClick;
            // 
            // pnlObservacoes
            // 
            pnlObservacoes.Controls.Add(label7);
            pnlObservacoes.Controls.Add(txtObservacao);
            pnlObservacoes.Dock = DockStyle.Fill;
            pnlObservacoes.Location = new Point(3, 108);
            pnlObservacoes.Name = "pnlObservacoes";
            pnlObservacoes.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            pnlObservacoes.Size = new Size(436, 99);
            pnlObservacoes.StateCommon.Color1 = Color.FromArgb(0, 90, 180);
            pnlObservacoes.StateCommon.Color2 = Color.FromArgb(102, 178, 255);
            pnlObservacoes.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            pnlObservacoes.TabIndex = 1053;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(8, 4);
            label7.Name = "label7";
            label7.Size = new Size(78, 17);
            label7.TabIndex = 1035;
            label7.Text = "Observação";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(pnlTitulo, 0, 0);
            tableLayoutPanel2.Controls.Add(pnlCabecalhoVenda, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 145F));
            tableLayoutPanel2.Size = new Size(1024, 182);
            tableLayoutPanel2.TabIndex = 1044;
            // 
            // flowLayoutPanelTotais
            // 
            flowLayoutPanelTotais.BackColor = Color.FromArgb(44, 62, 80);
            flowLayoutPanelTotais.Controls.Add(lblTotalBruto);
            flowLayoutPanelTotais.Controls.Add(txtSubTotal);
            flowLayoutPanelTotais.Controls.Add(lblDesconto);
            flowLayoutPanelTotais.Controls.Add(txtDesconto);
            flowLayoutPanelTotais.Controls.Add(lblTotalLiquido);
            flowLayoutPanelTotais.Controls.Add(txtTotalGeral);
            flowLayoutPanelTotais.Controls.Add(label4);
            flowLayoutPanelTotais.Controls.Add(txtTotalItens);
            flowLayoutPanelTotais.Controls.Add(lblValorRecebido);
            flowLayoutPanelTotais.Controls.Add(txtValorRecebido);
            flowLayoutPanelTotais.Controls.Add(lblTroco);
            flowLayoutPanelTotais.Controls.Add(txtTroco);
            flowLayoutPanelTotais.Dock = DockStyle.Right;
            flowLayoutPanelTotais.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelTotais.ForeColor = Color.White;
            flowLayoutPanelTotais.Location = new Point(824, 182);
            flowLayoutPanelTotais.Name = "flowLayoutPanelTotais";
            flowLayoutPanelTotais.Size = new Size(200, 530);
            flowLayoutPanelTotais.TabIndex = 1055;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(104, 174);
            label4.Name = "label4";
            label4.Size = new Size(89, 17);
            label4.TabIndex = 1035;
            label4.Text = "Total de Ìtens:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTotalItens
            // 
            txtTotalItens.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotalItens.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtTotalItens.Location = new Point(3, 194);
            txtTotalItens.Name = "txtTotalItens";
            txtTotalItens.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtTotalItens.Size = new Size(190, 34);
            txtTotalItens.StateCommon.Back.Color1 = Color.White;
            txtTotalItens.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtTotalItens.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtTotalItens.StateCommon.Border.ColorAngle = 1F;
            txtTotalItens.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTotalItens.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtTotalItens.StateCommon.Border.Rounding = 6F;
            txtTotalItens.StateCommon.Border.Width = 1;
            txtTotalItens.StateCommon.Content.Color1 = Color.Gray;
            txtTotalItens.StateCommon.Content.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalItens.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtTotalItens.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtTotalItens.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtTotalItens.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtTotalItens.TabIndex = 1034;
            txtTotalItens.TabStop = false;
            // 
            // pnlDgvItens
            // 
            pnlDgvItens.Controls.Add(dgvItensVenda);
            pnlDgvItens.Dock = DockStyle.Top;
            pnlDgvItens.Location = new Point(0, 182);
            pnlDgvItens.Name = "pnlDgvItens";
            pnlDgvItens.Size = new Size(824, 342);
            pnlDgvItens.TabIndex = 1056;
            // 
            // TableLayoutPanelFormaPgto
            // 
            TableLayoutPanelFormaPgto.BackgroundImage = (Image)resources.GetObject("TableLayoutPanelFormaPgto.BackgroundImage");
            TableLayoutPanelFormaPgto.BackgroundImageLayout = ImageLayout.None;
            TableLayoutPanelFormaPgto.ColumnCount = 2;
            TableLayoutPanelFormaPgto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 442F));
            TableLayoutPanelFormaPgto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanelFormaPgto.Controls.Add(dgvParcelas, 1, 0);
            TableLayoutPanelFormaPgto.Controls.Add(pnlFormaPgto, 0, 0);
            TableLayoutPanelFormaPgto.Controls.Add(pnlObservacoes, 0, 1);
            TableLayoutPanelFormaPgto.Dock = DockStyle.Bottom;
            TableLayoutPanelFormaPgto.Location = new Point(0, 504);
            TableLayoutPanelFormaPgto.Name = "TableLayoutPanelFormaPgto";
            TableLayoutPanelFormaPgto.RowCount = 2;
            TableLayoutPanelFormaPgto.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            TableLayoutPanelFormaPgto.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            TableLayoutPanelFormaPgto.Size = new Size(824, 208);
            TableLayoutPanelFormaPgto.TabIndex = 1057;
            // 
            // FrmPDV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(1024, 749);
            Controls.Add(TableLayoutPanelFormaPgto);
            Controls.Add(pnlDgvItens);
            Controls.Add(flowLayoutPanelTotais);
            Controls.Add(kryptonPanelBotoesControle);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPDV";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PDV-Ponto de Vendas";
            WindowState = FormWindowState.Maximized;
            FormClosed += FrmPDV_FormClosed;
            Load += FrmPDV_Load;
            Shown += FrmPDV_Shown;
            KeyDown += FrmPDV_KeyDown;
            ((System.ComponentModel.ISupportInitialize)cmbFormaPagamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvParcelas).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanelBotoesControle).EndInit();
            kryptonPanelBotoesControle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnlTitulo).EndInit();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlCabecalhoVenda).EndInit();
            pnlCabecalhoVenda.ResumeLayout(false);
            pnlCabecalhoVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlFormaPgto).EndInit();
            pnlFormaPgto.ResumeLayout(false);
            pnlFormaPgto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlObservacoes).EndInit();
            pnlObservacoes.ResumeLayout(false);
            pnlObservacoes.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanelTotais.ResumeLayout(false);
            flowLayoutPanelTotais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlDgvItens).EndInit();
            pnlDgvItens.ResumeLayout(false);
            TableLayoutPanelFormaPgto.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public Krypton.Toolkit.KryptonTextBox txtClienteBuscar;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Label lblDesconto;
        public Krypton.Toolkit.KryptonTextBox txtDesconto;
        private Label lblTotalLiquido;
        public Krypton.Toolkit.KryptonTextBox txtTotalGeral;
        private Krypton.Toolkit.KryptonComboBox cmbFormaPagamento;
        public Krypton.Toolkit.KryptonButton btnAdicionarItem;
        public Krypton.Toolkit.KryptonButton btnSalvarVenda;
        public Krypton.Toolkit.KryptonButton btnCancelarVenda;
        public Krypton.Toolkit.KryptonButton btnImprimir;
        public Krypton.Toolkit.KryptonTextBox txtValorRecebido;
        private Label lblValorRecebido;
        private Label label12;
        public Krypton.Toolkit.KryptonTextBox txtProdutoBuscar;
        public Krypton.Toolkit.KryptonTextBox txtPrecoUnitario;
        private Label label13;
        private Label label10;
        private Label label1;
        private Label lblVendaID;
        private Label label3;
        private Label lblData;
        public Krypton.Toolkit.KryptonTextBox txtQuantidade;
        public Krypton.Toolkit.KryptonTextBox txtSubTotal;
        private Label lblTotalBruto;
        public Krypton.Toolkit.KryptonTextBox txtTroco;
        private Label lblTroco;
        private Label lblFormaPgto;
        private Label lblIntervalo;
        private Label lblPrimeiroVenc;
        private Krypton.Toolkit.KryptonDateTimePicker dtPrimeira;
        private Krypton.Toolkit.KryptonNumericUpDown numParcelas;
        private Label lblQtdParcelas;
        public Krypton.Toolkit.KryptonButton btnGerarParcelas;
        public Krypton.Toolkit.KryptonButton btnCancelarParcelas;
        private Krypton.Toolkit.KryptonNumericUpDown numIntervalo;
        private Label label2;
        public Krypton.Toolkit.KryptonTextBox txtObservacao;
        public Krypton.Toolkit.KryptonButton txtFechar;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Label label5;
        private Krypton.Toolkit.KryptonPanel pnlTitulo;
        private Krypton.Toolkit.KryptonLabel lblTituloPDV;
        private Krypton.Toolkit.KryptonDataGridView dgvItensVenda;
        private Label label7;
        private Label label9;
        public Krypton.Toolkit.KryptonButton btnListarControles;
        public Krypton.Toolkit.KryptonButton btnNovaVenda;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Krypton.Toolkit.KryptonPanel pnlDgvItens;
        private Krypton.Toolkit.KryptonTableLayoutPanel TableLayoutPanelFormaPgto;
        private Label label4;
        public Krypton.Toolkit.KryptonTextBox txtTotalItens;
        public Krypton.Toolkit.KryptonPanel pnlCabecalhoVenda;
        public Krypton.Toolkit.KryptonDataGridView dgvParcelas;
        public Krypton.Toolkit.KryptonPanel kryptonPanelBotoesControle;
        public Krypton.Toolkit.KryptonPanel pnlObservacoes;
        public Krypton.Toolkit.KryptonPanel pnlFormaPgto;
        public FlowLayoutPanel flowLayoutPanelTotais;
        private Krypton.Toolkit.KryptonListBox lstVendedores;
        public Krypton.Toolkit.KryptonTextBox txtVendedorBuscar;
        private Krypton.Toolkit.KryptonListBox lstClientes;
        private Krypton.Toolkit.KryptonListBox lstProdutos;
    }
}