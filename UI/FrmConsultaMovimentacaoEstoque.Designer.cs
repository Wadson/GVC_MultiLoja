namespace GVC.View
{
    partial class FrmConsultaMovimentacaoEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaMovimentacaoEstoque));
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            txtNomeProduto = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloDescricaoProduto = new Label();
            lblRotuloProdutoID = new Label();
            txtProdutoID = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloDataFim = new Label();
            lblRotuloDataInicio = new Label();
            lblRotuloOrigem = new Label();
            lblRotuloTipoMovimentacao = new Label();
            dgvMovimentacoes = new Krypton.Toolkit.KryptonDataGridView();
            pnlHeader = new Krypton.Toolkit.KryptonPanel();
            tlpTitulo = new Krypton.Toolkit.KryptonTableLayoutPanel();
            lblSubTitulo = new Krypton.Toolkit.KryptonLabel();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            panelDadosDoProduto = new Krypton.Toolkit.KryptonPanel();
            btnBuscarProduto = new FontAwesome.Sharp.IconButton();
            lblDadosProduto = new Krypton.Toolkit.KryptonLabel();
            cmbTipoMovimentacao = new Krypton.Toolkit.KryptonComboBox();
            panelMovimentacao = new Krypton.Toolkit.KryptonPanel();
            cmbOrigem = new Krypton.Toolkit.KryptonComboBox();
            dtFim = new Krypton.Toolkit.KryptonDateTimePicker();
            dtInicio = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnFiltrar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvMovimentacoes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).BeginInit();
            pnlHeader.SuspendLayout();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelDadosDoProduto).BeginInit();
            panelDadosDoProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbTipoMovimentacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelMovimentacao).BeginInit();
            panelMovimentacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbOrigem).BeginInit();
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
            // txtNomeProduto
            // 
            txtNomeProduto.CharacterCasing = CharacterCasing.Upper;
            txtNomeProduto.Location = new Point(83, 46);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.ReadOnly = true;
            txtNomeProduto.Size = new Size(749, 24);
            txtNomeProduto.StateCommon.Back.Color1 = Color.White;
            txtNomeProduto.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNomeProduto.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNomeProduto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNomeProduto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNomeProduto.StateCommon.Border.Rounding = 8F;
            txtNomeProduto.StateCommon.Border.Width = 1;
            txtNomeProduto.StateCommon.Content.Color1 = Color.Gray;
            txtNomeProduto.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtNomeProduto.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNomeProduto.TabIndex = 1079;
            // 
            // lblRotuloDescricaoProduto
            // 
            lblRotuloDescricaoProduto.AutoSize = true;
            lblRotuloDescricaoProduto.BackColor = Color.Transparent;
            lblRotuloDescricaoProduto.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloDescricaoProduto.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloDescricaoProduto.Location = new Point(83, 27);
            lblRotuloDescricaoProduto.Name = "lblRotuloDescricaoProduto";
            lblRotuloDescricaoProduto.Size = new Size(137, 16);
            lblRotuloDescricaoProduto.TabIndex = 1080;
            lblRotuloDescricaoProduto.Text = "Descrição do produto";
            // 
            // lblRotuloProdutoID
            // 
            lblRotuloProdutoID.AutoSize = true;
            lblRotuloProdutoID.BackColor = Color.Transparent;
            lblRotuloProdutoID.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRotuloProdutoID.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloProdutoID.Location = new Point(3, 27);
            lblRotuloProdutoID.Name = "lblRotuloProdutoID";
            lblRotuloProdutoID.Size = new Size(57, 16);
            lblRotuloProdutoID.TabIndex = 1081;
            lblRotuloProdutoID.Text = "Código";
            // 
            // txtProdutoID
            // 
            txtProdutoID.Location = new Point(3, 46);
            txtProdutoID.Name = "txtProdutoID";
            txtProdutoID.ReadOnly = true;
            txtProdutoID.Size = new Size(73, 24);
            txtProdutoID.StateCommon.Back.Color1 = Color.White;
            txtProdutoID.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtProdutoID.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtProdutoID.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtProdutoID.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtProdutoID.StateCommon.Border.Rounding = 8F;
            txtProdutoID.StateCommon.Border.Width = 1;
            txtProdutoID.StateCommon.Content.Color1 = Color.Gray;
            txtProdutoID.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtProdutoID.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtProdutoID.TabIndex = 1082;
            txtProdutoID.TabStop = false;
            txtProdutoID.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRotuloDataFim
            // 
            lblRotuloDataFim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRotuloDataFim.AutoSize = true;
            lblRotuloDataFim.BackColor = Color.Transparent;
            lblRotuloDataFim.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloDataFim.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloDataFim.Location = new Point(710, 21);
            lblRotuloDataFim.Name = "lblRotuloDataFim";
            lblRotuloDataFim.Size = new Size(61, 16);
            lblRotuloDataFim.TabIndex = 1072;
            lblRotuloDataFim.Text = "Data Fim";
            // 
            // lblRotuloDataInicio
            // 
            lblRotuloDataInicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRotuloDataInicio.AutoSize = true;
            lblRotuloDataInicio.BackColor = Color.Transparent;
            lblRotuloDataInicio.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloDataInicio.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloDataInicio.Location = new Point(541, 21);
            lblRotuloDataInicio.Name = "lblRotuloDataInicio";
            lblRotuloDataInicio.Size = new Size(70, 16);
            lblRotuloDataInicio.TabIndex = 1071;
            lblRotuloDataInicio.Text = "Data Inicio";
            // 
            // lblRotuloOrigem
            // 
            lblRotuloOrigem.AutoSize = true;
            lblRotuloOrigem.BackColor = Color.Transparent;
            lblRotuloOrigem.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloOrigem.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloOrigem.Location = new Point(273, 21);
            lblRotuloOrigem.Name = "lblRotuloOrigem";
            lblRotuloOrigem.Size = new Size(51, 16);
            lblRotuloOrigem.TabIndex = 1067;
            lblRotuloOrigem.Text = "Origem";
            // 
            // lblRotuloTipoMovimentacao
            // 
            lblRotuloTipoMovimentacao.AutoSize = true;
            lblRotuloTipoMovimentacao.BackColor = Color.Transparent;
            lblRotuloTipoMovimentacao.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloTipoMovimentacao.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloTipoMovimentacao.Location = new Point(3, 21);
            lblRotuloTipoMovimentacao.Name = "lblRotuloTipoMovimentacao";
            lblRotuloTipoMovimentacao.Size = new Size(127, 16);
            lblRotuloTipoMovimentacao.TabIndex = 1065;
            lblRotuloTipoMovimentacao.Text = "Tipo movimentação";
            // 
            // dgvMovimentacoes
            // 
            dgvMovimentacoes.Location = new Point(0, 265);
            dgvMovimentacoes.Name = "dgvMovimentacoes";
            dgvMovimentacoes.Size = new Size(877, 219);
            dgvMovimentacoes.TabIndex = 1094;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(tlpTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(880, 47);
            pnlHeader.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            pnlHeader.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            pnlHeader.TabIndex = 1095;
            // 
            // tlpTitulo
            // 
            tlpTitulo.BackgroundImage = (Image)resources.GetObject("tlpTitulo.BackgroundImage");
            tlpTitulo.BackgroundImageLayout = ImageLayout.None;
            tlpTitulo.ColumnCount = 1;
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTitulo.Controls.Add(lblSubTitulo, 0, 1);
            tlpTitulo.Controls.Add(lblTitulo, 0, 0);
            tlpTitulo.Dock = DockStyle.Fill;
            tlpTitulo.Location = new Point(0, 0);
            tlpTitulo.Name = "tlpTitulo";
            tlpTitulo.RowCount = 2;
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 48.57143F));
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 51.42857F));
            tlpTitulo.Size = new Size(880, 47);
            tlpTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            tlpTitulo.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            tlpTitulo.TabIndex = 0;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.Dock = DockStyle.Fill;
            lblSubTitulo.Location = new Point(3, 25);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(874, 19);
            lblSubTitulo.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Color2 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblSubTitulo.TabIndex = 0;
            lblSubTitulo.Values.Text = "Histórico de movimentações e saldo de estoque";
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Location = new Point(3, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(874, 16);
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Color2 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 1091;
            lblTitulo.Values.Text = "Movimentação de Estoque";
            // 
            // panelDadosDoProduto
            // 
            panelDadosDoProduto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelDadosDoProduto.Controls.Add(btnBuscarProduto);
            panelDadosDoProduto.Controls.Add(lblDadosProduto);
            panelDadosDoProduto.Controls.Add(txtNomeProduto);
            panelDadosDoProduto.Controls.Add(lblRotuloDescricaoProduto);
            panelDadosDoProduto.Controls.Add(lblRotuloProdutoID);
            panelDadosDoProduto.Controls.Add(txtProdutoID);
            panelDadosDoProduto.Location = new Point(0, 68);
            panelDadosDoProduto.Name = "panelDadosDoProduto";
            panelDadosDoProduto.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            panelDadosDoProduto.Size = new Size(880, 86);
            panelDadosDoProduto.TabIndex = 1096;
            // 
            // btnBuscarProduto
            // 
            btnBuscarProduto.BackColor = Color.Transparent;
            btnBuscarProduto.FlatAppearance.BorderColor = Color.FromArgb(30, 136, 229);
            btnBuscarProduto.FlatAppearance.BorderSize = 0;
            btnBuscarProduto.FlatStyle = FlatStyle.Flat;
            btnBuscarProduto.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarProduto.IconColor = Color.FromArgb(30, 136, 229);
            btnBuscarProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarProduto.IconSize = 28;
            btnBuscarProduto.Location = new Point(835, 44);
            btnBuscarProduto.Name = "btnBuscarProduto";
            btnBuscarProduto.Size = new Size(28, 28);
            btnBuscarProduto.TabIndex = 1118;
            btnBuscarProduto.UseVisualStyleBackColor = false;
            btnBuscarProduto.Click += btnBuscarProduto_Click;
            // 
            // lblDadosProduto
            // 
            lblDadosProduto.Dock = DockStyle.Top;
            lblDadosProduto.Location = new Point(0, 0);
            lblDadosProduto.Name = "lblDadosProduto";
            lblDadosProduto.Size = new Size(880, 20);
            lblDadosProduto.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDadosProduto.TabIndex = 1038;
            lblDadosProduto.Values.Text = "Dados do produto";
            // 
            // cmbTipoMovimentacao
            // 
            cmbTipoMovimentacao.CornerRoundingRadius = 6F;
            cmbTipoMovimentacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMovimentacao.DropDownWidth = 115;
            cmbTipoMovimentacao.IntegralHeight = false;
            cmbTipoMovimentacao.Items.AddRange(new object[] { "Entrada", "Saída", "Ajuste" });
            cmbTipoMovimentacao.Location = new Point(3, 42);
            cmbTipoMovimentacao.Name = "cmbTipoMovimentacao";
            cmbTipoMovimentacao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbTipoMovimentacao.Size = new Size(260, 25);
            cmbTipoMovimentacao.StateActive.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateActive.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateActive.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateActive.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoMovimentacao.StateActive.ComboBox.Content.Color1 = Color.White;
            cmbTipoMovimentacao.StateActive.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbTipoMovimentacao.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoMovimentacao.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbTipoMovimentacao.StateCommon.ComboBox.Content.Color1 = Color.White;
            cmbTipoMovimentacao.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbTipoMovimentacao.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbTipoMovimentacao.StateNormal.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateNormal.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateNormal.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateNormal.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoMovimentacao.StateNormal.ComboBox.Content.Color1 = Color.White;
            cmbTipoMovimentacao.StateNormal.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbTipoMovimentacao.StateTracking.Item.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateTracking.Item.Back.Color2 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateTracking.Item.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateTracking.Item.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoMovimentacao.StateTracking.Item.Content.ShortText.Color1 = Color.White;
            cmbTipoMovimentacao.StateTracking.Item.Content.ShortText.Color2 = Color.White;
            cmbTipoMovimentacao.StateTracking.Item.Content.ShortText.Font = new Font("Segoe UI", 9F);
            cmbTipoMovimentacao.TabIndex = 1067;
            cmbTipoMovimentacao.TabStop = false;
            // 
            // panelMovimentacao
            // 
            panelMovimentacao.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelMovimentacao.Controls.Add(cmbOrigem);
            panelMovimentacao.Controls.Add(dtFim);
            panelMovimentacao.Controls.Add(cmbTipoMovimentacao);
            panelMovimentacao.Controls.Add(dtInicio);
            panelMovimentacao.Controls.Add(lblRotuloDataFim);
            panelMovimentacao.Controls.Add(lblRotuloDataInicio);
            panelMovimentacao.Controls.Add(kryptonLabel2);
            panelMovimentacao.Controls.Add(lblRotuloOrigem);
            panelMovimentacao.Controls.Add(lblRotuloTipoMovimentacao);
            panelMovimentacao.Location = new Point(3, 160);
            panelMovimentacao.Name = "panelMovimentacao";
            panelMovimentacao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            panelMovimentacao.Size = new Size(880, 86);
            panelMovimentacao.TabIndex = 1097;
            // 
            // cmbOrigem
            // 
            cmbOrigem.CornerRoundingRadius = 6F;
            cmbOrigem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigem.DropDownWidth = 115;
            cmbOrigem.IntegralHeight = false;
            cmbOrigem.Items.AddRange(new object[] { "Ajuste Manual", "Inventário", "Perda", "Devolução" });
            cmbOrigem.Location = new Point(273, 42);
            cmbOrigem.Name = "cmbOrigem";
            cmbOrigem.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbOrigem.Size = new Size(260, 25);
            cmbOrigem.StateActive.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateActive.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateActive.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateActive.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbOrigem.StateActive.ComboBox.Content.Color1 = Color.White;
            cmbOrigem.StateActive.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbOrigem.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbOrigem.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbOrigem.StateCommon.ComboBox.Content.Color1 = Color.White;
            cmbOrigem.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbOrigem.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbOrigem.StateNormal.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateNormal.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateNormal.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateNormal.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbOrigem.StateNormal.ComboBox.Content.Color1 = Color.White;
            cmbOrigem.StateNormal.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbOrigem.StateTracking.Item.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateTracking.Item.Back.Color2 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateTracking.Item.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateTracking.Item.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbOrigem.StateTracking.Item.Content.ShortText.Color1 = Color.White;
            cmbOrigem.StateTracking.Item.Content.ShortText.Color2 = Color.White;
            cmbOrigem.StateTracking.Item.Content.ShortText.Font = new Font("Segoe UI", 9F);
            cmbOrigem.TabIndex = 1075;
            cmbOrigem.TabStop = false;
            // 
            // dtFim
            // 
            dtFim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtFim.CornerRoundingRadius = 3F;
            dtFim.Format = DateTimePickerFormat.Short;
            dtFim.Location = new Point(706, 40);
            dtFim.Name = "dtFim";
            dtFim.Size = new Size(158, 29);
            dtFim.StateActive.Back.Color1 = Color.FromArgb(6, 174, 244);
            dtFim.StateActive.Border.Color1 = Color.FromArgb(6, 174, 244);
            dtFim.StateActive.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtFim.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtFim.StateActive.Border.Rounding = 3F;
            dtFim.StateActive.Content.Color1 = Color.White;
            dtFim.StateActive.Content.Font = new Font("Poppins", 9F);
            dtFim.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtFim.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtFim.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtFim.StateCommon.Border.ColorAngle = 45F;
            dtFim.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtFim.StateCommon.Border.Rounding = 3F;
            dtFim.StateCommon.Border.Width = 1;
            dtFim.StateCommon.Content.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtFim.StateCommon.Content.Padding = new Padding(1);
            dtFim.StateDisabled.Border.ColorAngle = 45F;
            dtFim.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtFim.StateDisabled.Border.Rounding = 3F;
            dtFim.StateDisabled.Border.Width = 1;
            dtFim.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtFim.StateNormal.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtFim.StateNormal.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtFim.StateNormal.Border.ColorAngle = 45F;
            dtFim.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtFim.StateNormal.Border.Rounding = 3F;
            dtFim.StateNormal.Border.Width = 1;
            dtFim.StateNormal.Content.Color1 = Color.White;
            dtFim.TabIndex = 1074;
            // 
            // dtInicio
            // 
            dtInicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtInicio.CornerRoundingRadius = 3F;
            dtInicio.Format = DateTimePickerFormat.Short;
            dtInicio.Location = new Point(541, 40);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(158, 29);
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
            dtInicio.TabIndex = 1073;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Dock = DockStyle.Top;
            kryptonLabel2.Location = new Point(0, 0);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(880, 20);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 1038;
            kryptonLabel2.Values.Text = "Movimentações";
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
            btnCancelar.IconSize = 28;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(757, 507);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 38);
            btnCancelar.TabIndex = 1122;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFiltrar.BackColor = Color.FromArgb(76, 175, 80);
            btnFiltrar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            btnFiltrar.IconColor = Color.White;
            btnFiltrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFiltrar.IconSize = 28;
            btnFiltrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFiltrar.Location = new Point(631, 510);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(120, 35);
            btnFiltrar.TabIndex = 1123;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // FrmConsultaMovimentacaoEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(880, 557);
            Controls.Add(btnFiltrar);
            Controls.Add(btnCancelar);
            Controls.Add(panelMovimentacao);
            Controls.Add(panelDadosDoProduto);
            Controls.Add(pnlHeader);
            Controls.Add(dgvMovimentacoes);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConsultaMovimentacaoEstoque";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta Movimentacao deEstoque";
            ((System.ComponentModel.ISupportInitialize)dgvMovimentacoes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).EndInit();
            pnlHeader.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelDadosDoProduto).EndInit();
            panelDadosDoProduto.ResumeLayout(false);
            panelDadosDoProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbTipoMovimentacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelMovimentacao).EndInit();
            panelMovimentacao.ResumeLayout(false);
            panelMovimentacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbOrigem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public Krypton.Toolkit.KryptonTextBox txtNomeProduto;
        private Label lblRotuloDescricaoProduto;
        private Label lblRotuloProdutoID;
        public Krypton.Toolkit.KryptonTextBox txtProdutoID;
        private GroupBox grpMovimentacao;        
        private Label lblRotuloTipoMovimentacao;
        private Krypton.Toolkit.KryptonButton btnListarControlesDoForm;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Label lblRotuloDataFim;
        private Label lblRotuloDataInicio;
        private Label lblRotuloOrigem;
        private Krypton.Toolkit.KryptonDataGridView dgvMovimentacoes;        
        private Krypton.Toolkit.KryptonPanel pnlHeader;
        private Krypton.Toolkit.KryptonTableLayoutPanel tlpTitulo;
        private Krypton.Toolkit.KryptonLabel lblSubTitulo;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private Krypton.Toolkit.KryptonPanel panelDadosDoProduto;
        public Krypton.Toolkit.KryptonComboBox cmbTipoMovimentacao;
        private Krypton.Toolkit.KryptonLabel lblDadosProduto;
        private Krypton.Toolkit.KryptonPanel panelMovimentacao;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        public Krypton.Toolkit.KryptonComboBox cmbOrigem;
        public Krypton.Toolkit.KryptonDateTimePicker dtFim;
        public Krypton.Toolkit.KryptonDateTimePicker dtInicio;
        private FontAwesome.Sharp.IconButton btnBuscarProduto;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnFiltrar;
    }
}