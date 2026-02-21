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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPDV));
            txtClienteBuscar = new Krypton.Toolkit.KryptonTextBox();
            lblDesconto = new Label();
            lblTotalLiquido = new Label();
            lblCliente = new Label();
            txtProdutoBuscar = new Krypton.Toolkit.KryptonTextBox();
            txtPrecoUnitario = new Krypton.Toolkit.KryptonTextBox();
            lblPreco = new Label();
            lblQuantidade = new Label();
            lblVendedor = new Label();
            lblProduto = new Label();
            txtQuantidade = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloSubTotal = new Label();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            txtVendedorBuscar = new Krypton.Toolkit.KryptonTextBox();
            dgvItensVenda = new Krypton.Toolkit.KryptonDataGridView();
            tlpMain = new TableLayoutPanel();
            pnlHeader = new Krypton.Toolkit.KryptonPanel();
            tlpTitulo = new Krypton.Toolkit.KryptonTableLayoutPanel();
            panelTitulo = new Krypton.Toolkit.KryptonPanel();
            kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            lblDataVenda = new Label();
            lblVendaID = new Label();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            iconAcao = new FontAwesome.Sharp.IconPictureBox();
            pnlDadosVenda_pnlProdutosEntrada = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            pnlResumo = new Krypton.Toolkit.KryptonPanel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblTotal = new Label();
            txtTotalItens = new Label();
            lblTotalItens = new Label();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            lblDescont = new Label();
            txtDesconto = new Krypton.Toolkit.KryptonTextBox();
            lblSubtotal = new Label();
            txtSubTotal = new Krypton.Toolkit.KryptonTextBox();
            btnAdicionarItem = new FontAwesome.Sharp.IconButton();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            picLogoMarca = new PictureBox();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnSair = new FontAwesome.Sharp.IconButton();
            btnFinalizarVenda = new FontAwesome.Sharp.IconButton();
            btnNovaVenda = new FontAwesome.Sharp.IconButton();
            txtObservacoes = new Krypton.Toolkit.KryptonTextBox();
            lblObservacoes = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).BeginInit();
            tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).BeginInit();
            pnlHeader.SuspendLayout();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelTitulo).BeginInit();
            panelTitulo.SuspendLayout();
            kryptonTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconAcao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlDadosVenda_pnlProdutosEntrada).BeginInit();
            pnlDadosVenda_pnlProdutosEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlResumo).BeginInit();
            pnlResumo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoMarca).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtClienteBuscar
            // 
            txtClienteBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClienteBuscar.CharacterCasing = CharacterCasing.Upper;
            txtClienteBuscar.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtClienteBuscar.Location = new Point(87, 5);
            txtClienteBuscar.Name = "txtClienteBuscar";
            txtClienteBuscar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtClienteBuscar.Size = new Size(484, 24);
            txtClienteBuscar.StateCommon.Back.Color1 = Color.White;
            txtClienteBuscar.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtClienteBuscar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtClienteBuscar.StateCommon.Border.ColorAngle = 1F;
            txtClienteBuscar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtClienteBuscar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtClienteBuscar.StateCommon.Border.Rounding = 1F;
            txtClienteBuscar.StateCommon.Border.Width = 1;
            txtClienteBuscar.StateCommon.Content.Color1 = Color.Gray;
            txtClienteBuscar.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtClienteBuscar.StateCommon.Content.Padding = new Padding(2);
            txtClienteBuscar.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtClienteBuscar.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtClienteBuscar.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtClienteBuscar.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtClienteBuscar.TabIndex = 0;
            txtClienteBuscar.TextChanged += txtClienteBuscar_TextChanged;
            // 
            // lblDesconto
            // 
            lblDesconto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDesconto.AutoSize = true;
            lblDesconto.BackColor = Color.Transparent;
            lblDesconto.Font = new Font("Segoe UI", 9.75F);
            lblDesconto.ForeColor = Color.FromArgb(44, 62, 80);
            lblDesconto.Location = new Point(-205, 674);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(90, 17);
            lblDesconto.TabIndex = 638;
            lblDesconto.Text = "Desconto (R$)";
            lblDesconto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalLiquido
            // 
            lblTotalLiquido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalLiquido.AutoSize = true;
            lblTotalLiquido.BackColor = Color.Transparent;
            lblTotalLiquido.Font = new Font("Segoe UI", 10.75F);
            lblTotalLiquido.ForeColor = Color.FromArgb(44, 62, 80);
            lblTotalLiquido.Location = new Point(-206, 692);
            lblTotalLiquido.Name = "lblTotalLiquido";
            lblTotalLiquido.Size = new Size(99, 20);
            lblTotalLiquido.TabIndex = 640;
            lblTotalLiquido.Text = "Total Líquido:";
            lblTotalLiquido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9.75F);
            lblCliente.ForeColor = Color.FromArgb(44, 62, 80);
            lblCliente.Location = new Point(31, 9);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(50, 17);
            lblCliente.TabIndex = 1025;
            lblCliente.Text = "Cliente:";
            // 
            // txtProdutoBuscar
            // 
            txtProdutoBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProdutoBuscar.CharacterCasing = CharacterCasing.Upper;
            txtProdutoBuscar.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtProdutoBuscar.Location = new Point(87, 64);
            txtProdutoBuscar.Name = "txtProdutoBuscar";
            txtProdutoBuscar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtProdutoBuscar.Size = new Size(484, 24);
            txtProdutoBuscar.StateCommon.Back.Color1 = Color.White;
            txtProdutoBuscar.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtProdutoBuscar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtProdutoBuscar.StateCommon.Border.ColorAngle = 1F;
            txtProdutoBuscar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtProdutoBuscar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtProdutoBuscar.StateCommon.Border.Rounding = 1F;
            txtProdutoBuscar.StateCommon.Border.Width = 1;
            txtProdutoBuscar.StateCommon.Content.Color1 = Color.Gray;
            txtProdutoBuscar.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtProdutoBuscar.StateCommon.Content.Padding = new Padding(2);
            txtProdutoBuscar.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtProdutoBuscar.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtProdutoBuscar.TabIndex = 2;
            txtProdutoBuscar.TextChanged += txtProdutoBuscar_TextChanged;
            // 
            // txtPrecoUnitario
            // 
            txtPrecoUnitario.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtPrecoUnitario.Location = new Point(3, 76);
            txtPrecoUnitario.Name = "txtPrecoUnitario";
            txtPrecoUnitario.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtPrecoUnitario.Size = new Size(172, 33);
            txtPrecoUnitario.StateCommon.Back.Color1 = Color.White;
            txtPrecoUnitario.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtPrecoUnitario.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtPrecoUnitario.StateCommon.Border.ColorAngle = 1F;
            txtPrecoUnitario.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPrecoUnitario.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPrecoUnitario.StateCommon.Border.Rounding = 1F;
            txtPrecoUnitario.StateCommon.Border.Width = 1;
            txtPrecoUnitario.StateCommon.Content.Color1 = Color.Gray;
            txtPrecoUnitario.StateCommon.Content.Font = new Font("Segoe UI", 14.75F);
            txtPrecoUnitario.StateCommon.Content.Padding = new Padding(2);
            txtPrecoUnitario.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtPrecoUnitario.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtPrecoUnitario.TabIndex = 4;
            txtPrecoUnitario.TextChanged += txtPrecoUnitario_TextChanged;
            txtPrecoUnitario.KeyDown += txtPrecoUnitario_KeyDown;
            txtPrecoUnitario.KeyPress += txtPrecoUnitario_KeyPress;
            txtPrecoUnitario.Leave += txtPrecoUnitario_Leave;
            txtPrecoUnitario.Validating += txtPrecoUnitario_Validating;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.BackColor = Color.Transparent;
            lblPreco.Font = new Font("Segoe UI", 9.75F);
            lblPreco.ForeColor = Color.FromArgb(44, 62, 80);
            lblPreco.Location = new Point(3, 56);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(94, 17);
            lblPreco.TabIndex = 646;
            lblPreco.Text = "Preço Unitario:";
            // 
            // lblQuantidade
            // 
            lblQuantidade.Anchor = AnchorStyles.Top;
            lblQuantidade.AutoSize = true;
            lblQuantidade.BackColor = Color.Transparent;
            lblQuantidade.Font = new Font("Segoe UI", 9.75F);
            lblQuantidade.ForeColor = Color.FromArgb(44, 62, 80);
            lblQuantidade.Location = new Point(3, 0);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(79, 17);
            lblQuantidade.TabIndex = 644;
            lblQuantidade.Text = "Quantidade:";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Font = new Font("Segoe UI", 9.75F);
            lblVendedor.ForeColor = Color.FromArgb(44, 62, 80);
            lblVendedor.Location = new Point(13, 39);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(68, 17);
            lblVendedor.TabIndex = 1045;
            lblVendedor.Text = "Vendedor:";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.BackColor = Color.Transparent;
            lblProduto.Font = new Font("Segoe UI", 9.75F);
            lblProduto.ForeColor = Color.FromArgb(44, 62, 80);
            lblProduto.Location = new Point(23, 67);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(58, 17);
            lblProduto.TabIndex = 1026;
            lblProduto.Text = "Produto:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtQuantidade.Location = new Point(3, 20);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtQuantidade.Size = new Size(172, 33);
            txtQuantidade.StateCommon.Back.Color1 = Color.White;
            txtQuantidade.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtQuantidade.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtQuantidade.StateCommon.Border.ColorAngle = 1F;
            txtQuantidade.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtQuantidade.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtQuantidade.StateCommon.Border.Rounding = 1F;
            txtQuantidade.StateCommon.Border.Width = 1;
            txtQuantidade.StateCommon.Content.Color1 = Color.Gray;
            txtQuantidade.StateCommon.Content.Font = new Font("Segoe UI", 14.75F);
            txtQuantidade.StateCommon.Content.Padding = new Padding(2);
            txtQuantidade.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtQuantidade.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtQuantidade.TabIndex = 3;
            txtQuantidade.TextAlign = HorizontalAlignment.Center;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged;
            txtQuantidade.KeyDown += txtQuantidade_KeyDown;
            txtQuantidade.Leave += txtQuantidade_Leave;
            // 
            // lblRotuloSubTotal
            // 
            lblRotuloSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRotuloSubTotal.AutoSize = true;
            lblRotuloSubTotal.BackColor = Color.Transparent;
            lblRotuloSubTotal.Font = new Font("Segoe UI", 12F);
            lblRotuloSubTotal.ForeColor = Color.FromArgb(44, 62, 80);
            lblRotuloSubTotal.Location = new Point(479, 4);
            lblRotuloSubTotal.Name = "lblRotuloSubTotal";
            lblRotuloSubTotal.Size = new Size(45, 21);
            lblRotuloSubTotal.TabIndex = 1030;
            lblRotuloSubTotal.Text = "Total:";
            lblRotuloSubTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Anchor = AnchorStyles.Top;
            kryptonLabel5.Location = new Point(379, 3);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(93, 22);
            kryptonLabel5.StateCommon.ShortText.Color1 = Color.FromArgb(44, 62, 80);
            kryptonLabel5.StateCommon.ShortText.Color2 = Color.FromArgb(44, 62, 80);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Segoe UI", 10F);
            kryptonLabel5.TabIndex = 1048;
            kryptonLabel5.Values.Text = "F12 Finalizar |";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Anchor = AnchorStyles.Top;
            kryptonLabel6.Location = new Point(280, 3);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(93, 22);
            kryptonLabel6.StateCommon.ShortText.Color1 = Color.FromArgb(44, 62, 80);
            kryptonLabel6.StateCommon.ShortText.Color2 = Color.FromArgb(44, 62, 80);
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Segoe UI", 10F);
            kryptonLabel6.TabIndex = 1047;
            kryptonLabel6.Values.Text = "F6 Adicionar |";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Anchor = AnchorStyles.Top;
            kryptonLabel3.Location = new Point(189, 3);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(85, 22);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(44, 62, 80);
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.FromArgb(44, 62, 80);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Segoe UI", 10F);
            kryptonLabel3.TabIndex = 1046;
            kryptonLabel3.Values.Text = "F4 Produto |";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.Top;
            kryptonLabel2.Location = new Point(87, 3);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(96, 22);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(44, 62, 80);
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.FromArgb(44, 62, 80);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Segoe UI", 10F);
            kryptonLabel2.TabIndex = 1045;
            kryptonLabel2.Values.Text = "F3 Vendedor |";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Anchor = AnchorStyles.Top;
            kryptonLabel1.Location = new Point(3, 3);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(78, 22);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(44, 62, 80);
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.FromArgb(44, 62, 80);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 10F);
            kryptonLabel1.TabIndex = 1044;
            kryptonLabel1.Values.Text = "F2 Cliente |";
            // 
            // txtVendedorBuscar
            // 
            txtVendedorBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtVendedorBuscar.CharacterCasing = CharacterCasing.Upper;
            txtVendedorBuscar.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtVendedorBuscar.Location = new Point(87, 35);
            txtVendedorBuscar.Name = "txtVendedorBuscar";
            txtVendedorBuscar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtVendedorBuscar.Size = new Size(484, 24);
            txtVendedorBuscar.StateCommon.Back.Color1 = Color.White;
            txtVendedorBuscar.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtVendedorBuscar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtVendedorBuscar.StateCommon.Border.ColorAngle = 1F;
            txtVendedorBuscar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtVendedorBuscar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtVendedorBuscar.StateCommon.Border.Rounding = 1F;
            txtVendedorBuscar.StateCommon.Border.Width = 1;
            txtVendedorBuscar.StateCommon.Content.Color1 = Color.Gray;
            txtVendedorBuscar.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtVendedorBuscar.StateCommon.Content.Padding = new Padding(2);
            txtVendedorBuscar.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtVendedorBuscar.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtVendedorBuscar.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtVendedorBuscar.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtVendedorBuscar.TabIndex = 1;
            txtVendedorBuscar.TextChanged += txtVendedorBuscar_TextChanged;
            // 
            // dgvItensVenda
            // 
            dgvItensVenda.Dock = DockStyle.Fill;
            dgvItensVenda.HideOuterBorders = true;
            dgvItensVenda.Location = new Point(4, 180);
            dgvItensVenda.Name = "dgvItensVenda";
            dgvItensVenda.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            dgvItensVenda.RowHeadersWidth = 23;
            dgvItensVenda.Size = new Size(616, 249);
            dgvItensVenda.TabIndex = 1051;
            dgvItensVenda.TabStop = false;
            dgvItensVenda.CellContentClick += dgvItensVenda_CellContentClick;
            dgvItensVenda.CellDoubleClick += dgvItensVenda_CellDoubleClick;
            dgvItensVenda.CellEndEdit += dgvItensVenda_CellEndEdit;
            // 
            // tlpMain
            // 
            tlpMain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpMain.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 187F));
            tlpMain.Controls.Add(pnlHeader, 0, 0);
            tlpMain.Controls.Add(pnlDadosVenda_pnlProdutosEntrada, 0, 1);
            tlpMain.Controls.Add(dgvItensVenda, 0, 2);
            tlpMain.Controls.Add(pnlResumo, 0, 3);
            tlpMain.Controls.Add(kryptonPanel1, 1, 2);
            tlpMain.Controls.Add(kryptonPanel2, 1, 1);
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 4;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 138F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tlpMain.Size = new Size(812, 469);
            tlpMain.TabIndex = 1044;
            // 
            // pnlHeader
            // 
            tlpMain.SetColumnSpan(pnlHeader, 2);
            pnlHeader.Controls.Add(tlpTitulo);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(4, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(804, 30);
            pnlHeader.StateCommon.Color1 = Color.FromArgb(201, 214, 221);
            pnlHeader.StateCommon.Color2 = Color.FromArgb(201, 214, 221);
            pnlHeader.TabIndex = 1113;
            // 
            // tlpTitulo
            // 
            tlpTitulo.BackgroundImage = (Image)resources.GetObject("tlpTitulo.BackgroundImage");
            tlpTitulo.BackgroundImageLayout = ImageLayout.None;
            tlpTitulo.ColumnCount = 2;
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tlpTitulo.Controls.Add(panelTitulo, 0, 0);
            tlpTitulo.Dock = DockStyle.Fill;
            tlpTitulo.Location = new Point(0, 0);
            tlpTitulo.Name = "tlpTitulo";
            tlpTitulo.RowCount = 1;
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 57.35294F));
            tlpTitulo.Size = new Size(804, 30);
            tlpTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            tlpTitulo.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            tlpTitulo.TabIndex = 0;
            // 
            // panelTitulo
            // 
            tlpTitulo.SetColumnSpan(panelTitulo, 2);
            panelTitulo.Controls.Add(kryptonTableLayoutPanel1);
            panelTitulo.Dock = DockStyle.Fill;
            panelTitulo.Location = new Point(3, 3);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(798, 24);
            panelTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            panelTitulo.TabIndex = 2;
            // 
            // kryptonTableLayoutPanel1
            // 
            kryptonTableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("kryptonTableLayoutPanel1.BackgroundImage");
            kryptonTableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            kryptonTableLayoutPanel1.ColumnCount = 4;
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.19266F));
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.80734F));
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            kryptonTableLayoutPanel1.Controls.Add(lblDataVenda, 3, 0);
            kryptonTableLayoutPanel1.Controls.Add(lblVendaID, 0, 0);
            kryptonTableLayoutPanel1.Controls.Add(lblTitulo, 2, 0);
            kryptonTableLayoutPanel1.Controls.Add(iconAcao, 1, 0);
            kryptonTableLayoutPanel1.Dock = DockStyle.Fill;
            kryptonTableLayoutPanel1.Location = new Point(0, 0);
            kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            kryptonTableLayoutPanel1.RowCount = 1;
            kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            kryptonTableLayoutPanel1.Size = new Size(798, 24);
            kryptonTableLayoutPanel1.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            kryptonTableLayoutPanel1.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            kryptonTableLayoutPanel1.TabIndex = 0;
            // 
            // lblDataVenda
            // 
            lblDataVenda.AutoSize = true;
            lblDataVenda.BackColor = Color.Transparent;
            lblDataVenda.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblDataVenda.ForeColor = Color.White;
            lblDataVenda.Location = new Point(700, 0);
            lblDataVenda.Name = "lblDataVenda";
            lblDataVenda.Size = new Size(79, 20);
            lblDataVenda.TabIndex = 1037;
            lblDataVenda.Text = "01/01/1999";
            // 
            // lblVendaID
            // 
            lblVendaID.AutoSize = true;
            lblVendaID.BackColor = Color.Transparent;
            lblVendaID.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblVendaID.ForeColor = Color.White;
            lblVendaID.Location = new Point(3, 0);
            lblVendaID.Name = "lblVendaID";
            lblVendaID.Size = new Size(91, 20);
            lblVendaID.TabIndex = 1036;
            lblVendaID.Text = "Nº Venda: 0";
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Location = new Point(323, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(212, 18);
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Color2 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 1091;
            lblTitulo.Values.Text = "PDV - FRENTE DE CAIXA";
            // 
            // iconAcao
            // 
            iconAcao.BackColor = Color.Transparent;
            iconAcao.Dock = DockStyle.Right;
            iconAcao.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            iconAcao.IconColor = Color.White;
            iconAcao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAcao.IconSize = 18;
            iconAcao.Location = new Point(295, 3);
            iconAcao.Name = "iconAcao";
            iconAcao.Size = new Size(22, 18);
            iconAcao.TabIndex = 1110;
            iconAcao.TabStop = false;
            // 
            // pnlDadosVenda_pnlProdutosEntrada
            // 
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(kryptonLabel8);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(kryptonLabel7);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(kryptonLabel4);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(lblProduto);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(txtVendedorBuscar);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(lblVendedor);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(txtClienteBuscar);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(lblCliente);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(txtProdutoBuscar);
            pnlDadosVenda_pnlProdutosEntrada.Dock = DockStyle.Fill;
            pnlDadosVenda_pnlProdutosEntrada.Location = new Point(4, 41);
            pnlDadosVenda_pnlProdutosEntrada.Name = "pnlDadosVenda_pnlProdutosEntrada";
            pnlDadosVenda_pnlProdutosEntrada.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            pnlDadosVenda_pnlProdutosEntrada.Size = new Size(616, 132);
            pnlDadosVenda_pnlProdutosEntrada.TabIndex = 1043;
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonLabel8.Location = new Point(578, 61);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Size = new Size(31, 27);
            kryptonLabel8.StateCommon.ShortText.Color1 = Color.FromArgb(30, 136, 229);
            kryptonLabel8.StateCommon.ShortText.Color2 = Color.FromArgb(30, 136, 229);
            kryptonLabel8.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel8.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel8.TabIndex = 1094;
            kryptonLabel8.Values.Text = "F4";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonLabel7.Location = new Point(578, 33);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(31, 27);
            kryptonLabel7.StateCommon.ShortText.Color1 = Color.FromArgb(30, 136, 229);
            kryptonLabel7.StateCommon.ShortText.Color2 = Color.FromArgb(30, 136, 229);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel7.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel7.TabIndex = 1093;
            kryptonLabel7.Values.Text = "F3";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonLabel4.Location = new Point(578, 3);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(31, 27);
            kryptonLabel4.StateCommon.ShortText.Color1 = Color.FromArgb(30, 136, 229);
            kryptonLabel4.StateCommon.ShortText.Color2 = Color.FromArgb(30, 136, 229);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel4.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel4.TabIndex = 1092;
            kryptonLabel4.Values.Text = "F2";
            // 
            // pnlResumo
            // 
            pnlResumo.Controls.Add(iconPictureBox1);
            pnlResumo.Controls.Add(lblTotal);
            pnlResumo.Controls.Add(txtTotalItens);
            pnlResumo.Controls.Add(lblRotuloSubTotal);
            pnlResumo.Controls.Add(lblTotalItens);
            pnlResumo.Dock = DockStyle.Fill;
            pnlResumo.Location = new Point(4, 436);
            pnlResumo.Name = "pnlResumo";
            pnlResumo.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            pnlResumo.Size = new Size(616, 29);
            pnlResumo.TabIndex = 1052;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = Color.FromArgb(30, 136, 229);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            iconPictureBox1.IconColor = Color.FromArgb(30, 136, 229);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 30;
            iconPictureBox1.Location = new Point(446, -1);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 30);
            iconPictureBox1.TabIndex = 1111;
            iconPictureBox1.TabStop = false;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(44, 62, 80);
            lblTotal.Location = new Point(523, 4);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(22, 21);
            lblTotal.TabIndex = 1049;
            lblTotal.Text = "--";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTotalItens
            // 
            txtTotalItens.AutoSize = true;
            txtTotalItens.BackColor = Color.Transparent;
            txtTotalItens.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtTotalItens.ForeColor = Color.FromArgb(44, 62, 80);
            txtTotalItens.Location = new Point(89, 4);
            txtTotalItens.Name = "txtTotalItens";
            txtTotalItens.Size = new Size(22, 21);
            txtTotalItens.TabIndex = 1036;
            txtTotalItens.Text = "--";
            txtTotalItens.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalItens
            // 
            lblTotalItens.AutoSize = true;
            lblTotalItens.BackColor = Color.Transparent;
            lblTotalItens.Font = new Font("Segoe UI", 12F);
            lblTotalItens.ForeColor = Color.FromArgb(44, 62, 80);
            lblTotalItens.Location = new Point(3, 4);
            lblTotalItens.Name = "lblTotalItens";
            lblTotalItens.Size = new Size(82, 21);
            lblTotalItens.TabIndex = 1035;
            lblTotalItens.Text = "Total Itens:";
            lblTotalItens.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(flowLayoutPanel3);
            kryptonPanel1.Location = new Point(627, 180);
            kryptonPanel1.Name = "kryptonPanel1";
            tlpMain.SetRowSpan(kryptonPanel1, 2);
            kryptonPanel1.Size = new Size(181, 272);
            kryptonPanel1.TabIndex = 1114;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(lblQuantidade);
            flowLayoutPanel3.Controls.Add(txtQuantidade);
            flowLayoutPanel3.Controls.Add(lblPreco);
            flowLayoutPanel3.Controls.Add(txtPrecoUnitario);
            flowLayoutPanel3.Controls.Add(lblDescont);
            flowLayoutPanel3.Controls.Add(txtDesconto);
            flowLayoutPanel3.Controls.Add(lblSubtotal);
            flowLayoutPanel3.Controls.Add(txtSubTotal);
            flowLayoutPanel3.Controls.Add(btnAdicionarItem);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(0, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(181, 272);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // lblDescont
            // 
            lblDescont.AutoSize = true;
            lblDescont.BackColor = Color.Transparent;
            lblDescont.Font = new Font("Segoe UI", 9.75F);
            lblDescont.ForeColor = Color.Red;
            lblDescont.Location = new Point(3, 112);
            lblDescont.Name = "lblDescont";
            lblDescont.Size = new Size(88, 17);
            lblDescont.TabIndex = 648;
            lblDescont.Text = "Desconto ( - )";
            // 
            // txtDesconto
            // 
            txtDesconto.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtDesconto.Location = new Point(3, 132);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtDesconto.Size = new Size(172, 33);
            txtDesconto.StateCommon.Back.Color1 = Color.White;
            txtDesconto.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtDesconto.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtDesconto.StateCommon.Border.ColorAngle = 1F;
            txtDesconto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDesconto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtDesconto.StateCommon.Border.Rounding = 1F;
            txtDesconto.StateCommon.Border.Width = 1;
            txtDesconto.StateCommon.Content.Color1 = Color.Red;
            txtDesconto.StateCommon.Content.Font = new Font("Segoe UI", 14.75F);
            txtDesconto.StateCommon.Content.Padding = new Padding(2);
            txtDesconto.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtDesconto.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtDesconto.TabIndex = 5;
            txtDesconto.TextChanged += txtDesconto_TextChanged_1;
            txtDesconto.KeyPress += txtDesconto_KeyPress;
            txtDesconto.Leave += txtDesconto_Leave;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.BackColor = Color.Transparent;
            lblSubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal.ForeColor = Color.FromArgb(44, 62, 80);
            lblSubtotal.Location = new Point(3, 168);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(77, 21);
            lblSubtotal.TabIndex = 650;
            lblSubtotal.Text = "SubTotal";
            // 
            // txtSubTotal
            // 
            txtSubTotal.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtSubTotal.Location = new Point(3, 192);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtSubTotal.Size = new Size(172, 36);
            txtSubTotal.StateCommon.Back.Color1 = Color.White;
            txtSubTotal.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtSubTotal.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtSubTotal.StateCommon.Border.ColorAngle = 1F;
            txtSubTotal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSubTotal.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSubTotal.StateCommon.Border.Rounding = 1F;
            txtSubTotal.StateCommon.Border.Width = 1;
            txtSubTotal.StateCommon.Content.Color1 = Color.Blue;
            txtSubTotal.StateCommon.Content.Font = new Font("Segoe UI", 16.75F);
            txtSubTotal.StateCommon.Content.Padding = new Padding(2);
            txtSubTotal.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtSubTotal.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtSubTotal.TabIndex = 649;
            txtSubTotal.TabStop = false;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.BackColor = Color.FromArgb(76, 175, 80);
            btnAdicionarItem.ForeColor = Color.WhiteSmoke;
            btnAdicionarItem.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            btnAdicionarItem.IconColor = Color.White;
            btnAdicionarItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdicionarItem.IconSize = 28;
            btnAdicionarItem.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionarItem.Location = new Point(3, 234);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(175, 39);
            btnAdicionarItem.TabIndex = 6;
            btnAdicionarItem.Text = "       Adicionar Ítem";
            btnAdicionarItem.UseVisualStyleBackColor = false;
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(picLogoMarca);
            kryptonPanel2.Dock = DockStyle.Fill;
            kryptonPanel2.Location = new Point(627, 41);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            kryptonPanel2.Size = new Size(181, 132);
            kryptonPanel2.TabIndex = 1115;
            // 
            // picLogoMarca
            // 
            picLogoMarca.BackColor = Color.Transparent;
            picLogoMarca.Dock = DockStyle.Fill;
            picLogoMarca.Location = new Point(0, 0);
            picLogoMarca.Name = "picLogoMarca";
            picLogoMarca.Size = new Size(181, 132);
            picLogoMarca.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogoMarca.TabIndex = 1115;
            picLogoMarca.TabStop = false;
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(kryptonLabel1);
            flowLayoutPanel1.Controls.Add(kryptonLabel2);
            flowLayoutPanel1.Controls.Add(kryptonLabel3);
            flowLayoutPanel1.Controls.Add(kryptonLabel6);
            flowLayoutPanel1.Controls.Add(kryptonLabel5);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 594);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(812, 32);
            flowLayoutPanel1.TabIndex = 1050;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnSair);
            flowLayoutPanel2.Controls.Add(btnFinalizarVenda);
            flowLayoutPanel2.Controls.Add(btnNovaVenda);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(0, 551);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(812, 43);
            flowLayoutPanel2.TabIndex = 1051;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Gray;
            btnSair.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnSair.ForeColor = Color.White;
            btnSair.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnSair.IconColor = Color.White;
            btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSair.IconSize = 28;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(639, 3);
            btnSair.Name = "btnSair";
            btnSair.Padding = new Padding(10, 0, 10, 0);
            btnSair.Size = new Size(170, 38);
            btnSair.TabIndex = 1121;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnFinalizarVenda
            // 
            btnFinalizarVenda.BackColor = Color.FromArgb(30, 136, 229);
            btnFinalizarVenda.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnFinalizarVenda.ForeColor = Color.White;
            btnFinalizarVenda.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnFinalizarVenda.IconColor = Color.White;
            btnFinalizarVenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFinalizarVenda.IconSize = 28;
            btnFinalizarVenda.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizarVenda.Location = new Point(463, 3);
            btnFinalizarVenda.Name = "btnFinalizarVenda";
            btnFinalizarVenda.Padding = new Padding(10, 0, 10, 0);
            btnFinalizarVenda.Size = new Size(170, 38);
            btnFinalizarVenda.TabIndex = 1124;
            btnFinalizarVenda.Text = " Confirmar Venda";
            btnFinalizarVenda.TextAlign = ContentAlignment.MiddleRight;
            btnFinalizarVenda.UseVisualStyleBackColor = false;
            btnFinalizarVenda.Click += btnFinalizarVenda_Click;
            // 
            // btnNovaVenda
            // 
            btnNovaVenda.BackColor = Color.White;
            btnNovaVenda.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnNovaVenda.ForeColor = Color.FromArgb(30, 136, 229);
            btnNovaVenda.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            btnNovaVenda.IconColor = Color.FromArgb(30, 136, 229);
            btnNovaVenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNovaVenda.IconSize = 28;
            btnNovaVenda.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovaVenda.Location = new Point(287, 3);
            btnNovaVenda.Name = "btnNovaVenda";
            btnNovaVenda.Padding = new Padding(10, 0, 10, 0);
            btnNovaVenda.Size = new Size(170, 38);
            btnNovaVenda.TabIndex = 1125;
            btnNovaVenda.Text = "     Nova Venda";
            btnNovaVenda.UseVisualStyleBackColor = false;
            btnNovaVenda.Click += btnNovaVenda_Click;
            // 
            // txtObservacoes
            // 
            txtObservacoes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtObservacoes.CharacterCasing = CharacterCasing.Upper;
            txtObservacoes.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtObservacoes.Location = new Point(10, 499);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtObservacoes.Size = new Size(610, 44);
            txtObservacoes.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtObservacoes.StateActive.Border.Rounding = 2F;
            txtObservacoes.StateActive.Border.Width = 1;
            txtObservacoes.StateCommon.Back.Color1 = Color.White;
            txtObservacoes.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtObservacoes.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtObservacoes.StateCommon.Border.ColorAngle = 1F;
            txtObservacoes.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtObservacoes.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtObservacoes.StateCommon.Border.Rounding = 2F;
            txtObservacoes.StateCommon.Border.Width = 1;
            txtObservacoes.StateCommon.Content.Color1 = Color.Gray;
            txtObservacoes.StateCommon.Content.Font = new Font("Segoe UI", 12.75F);
            txtObservacoes.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtObservacoes.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtObservacoes.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtObservacoes.StateNormal.Border.Rounding = 2F;
            txtObservacoes.StateNormal.Border.Width = 1;
            txtObservacoes.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtObservacoes.TabIndex = 1052;
            txtObservacoes.TabStop = false;
            // 
            // lblObservacoes
            // 
            lblObservacoes.Location = new Point(-3, 475);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(84, 20);
            lblObservacoes.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObservacoes.TabIndex = 1053;
            lblObservacoes.Values.Text = "Observações";
            // 
            // FrmPDV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(812, 626);
            Controls.Add(txtObservacoes);
            Controls.Add(lblObservacoes);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblDesconto);
            Controls.Add(lblTotalLiquido);
            Controls.Add(tlpMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
            Load += FrmPDVendas_Load;
            Shown += FrmPDV_Shown;
            KeyDown += FrmPDVendas_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).EndInit();
            tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnlHeader).EndInit();
            pnlHeader.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelTitulo).EndInit();
            panelTitulo.ResumeLayout(false);
            kryptonTableLayoutPanel1.ResumeLayout(false);
            kryptonTableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconAcao).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlDadosVenda_pnlProdutosEntrada).EndInit();
            pnlDadosVenda_pnlProdutosEntrada.ResumeLayout(false);
            pnlDadosVenda_pnlProdutosEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlResumo).EndInit();
            pnlResumo.ResumeLayout(false);
            pnlResumo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogoMarca).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Krypton.Toolkit.KryptonTextBox txtClienteBuscar;
        private Label lblDesconto;
        private Label lblTotalLiquido;
        private Label lblQuantidade;
        public Krypton.Toolkit.KryptonTextBox txtProdutoBuscar;
        public Krypton.Toolkit.KryptonTextBox txtPrecoUnitario;
        private Label lblPreco;
        private Label lblCliente;
        public Krypton.Toolkit.KryptonTextBox txtQuantidade;
        private Label lblRotuloSubTotal;
        private Label lblProduto;
        private Label lblVendedor;
        private Krypton.Toolkit.KryptonDataGridView dgvItensVenda;
        private TableLayoutPanel tlpMain;
        private Label lblTotalItens;
        public Krypton.Toolkit.KryptonTextBox txtVendedorBuscar;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonPanel pnlDadosVenda_pnlProdutosEntrada;
        private Krypton.Toolkit.KryptonPanel pnlResumo;
        private Label lblTotal;
        private Label txtTotalItens;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        public FontAwesome.Sharp.IconButton btnSair;
        public FontAwesome.Sharp.IconButton btnFinalizarVenda;
        public FontAwesome.Sharp.IconButton btnNovaVenda;
        private Krypton.Toolkit.KryptonPanel pnlHeader;
        private Krypton.Toolkit.KryptonTableLayoutPanel tlpTitulo;
        private FontAwesome.Sharp.IconPictureBox iconAcao;
        private Label lblDataVenda;
        private Label lblVendaID;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnAdicionarItem;
        private Krypton.Toolkit.KryptonPanel panelTitulo;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        public Krypton.Toolkit.KryptonTextBox txtObservacoes;
        private Krypton.Toolkit.KryptonLabel lblObservacoes;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label lblDescont;
        public Krypton.Toolkit.KryptonTextBox txtDesconto;
        private Label lblSubtotal;
        public Krypton.Toolkit.KryptonTextBox txtSubTotal;
        private PictureBox picLogoMarca;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
    }
}