namespace GVC.View
{
    partial class FrmPDVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPDVendas));
            txtClienteBuscar = new Krypton.Toolkit.KryptonTextBox();
            lblDesconto = new Label();
            lblTotalLiquido = new Label();
            btnAdicionarItem = new Krypton.Toolkit.KryptonButton();
            lblCliente = new Label();
            txtProdutoBuscar = new Krypton.Toolkit.KryptonTextBox();
            txtPrecoUnitario = new Krypton.Toolkit.KryptonTextBox();
            lblPreco = new Label();
            lblQuantidade = new Label();
            label1 = new Label();
            lblVendedor = new Label();
            label3 = new Label();
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
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            iconAcao = new FontAwesome.Sharp.IconPictureBox();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            lblDataVenda = new Label();
            lblVendaID = new Label();
            pnlDadosVenda_pnlProdutosEntrada = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            pnlResumo = new Krypton.Toolkit.KryptonPanel();
            lblSubTotal = new Label();
            txtTotalItens = new Label();
            lblTotalItens = new Label();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnSair = new FontAwesome.Sharp.IconButton();
            btnFinalizarVenda = new FontAwesome.Sharp.IconButton();
            btnNovaVenda = new FontAwesome.Sharp.IconButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).BeginInit();
            tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).BeginInit();
            pnlHeader.SuspendLayout();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconAcao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlDadosVenda_pnlProdutosEntrada).BeginInit();
            pnlDadosVenda_pnlProdutosEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlResumo).BeginInit();
            pnlResumo.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtClienteBuscar
            // 
            txtClienteBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClienteBuscar.CharacterCasing = CharacterCasing.Upper;
            txtClienteBuscar.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtClienteBuscar.Location = new Point(87, 0);
            txtClienteBuscar.Name = "txtClienteBuscar";
            txtClienteBuscar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtClienteBuscar.Size = new Size(672, 24);
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
            // btnAdicionarItem
            // 
            btnAdicionarItem.CornerRoundingRadius = 1F;
            btnAdicionarItem.Location = new Point(462, 101);
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
            btnAdicionarItem.Size = new Size(130, 25);
            btnAdicionarItem.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnAdicionarItem.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnAdicionarItem.StateCommon.Back.ColorAngle = 45F;
            btnAdicionarItem.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 255);
            btnAdicionarItem.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 255);
            btnAdicionarItem.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdicionarItem.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdicionarItem.StateCommon.Border.Rounding = 1F;
            btnAdicionarItem.StateCommon.Border.Width = 1;
            btnAdicionarItem.StateCommon.Content.Padding = new Padding(2);
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
            btnAdicionarItem.TabIndex = 5;
            btnAdicionarItem.Values.Text = "F6 - Adicionar";
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            btnAdicionarItem.KeyDown += btnAdicionarItem_KeyDown;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9.75F);
            lblCliente.ForeColor = Color.FromArgb(44, 62, 80);
            lblCliente.Location = new Point(31, 4);
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
            txtProdutoBuscar.Location = new Point(87, 72);
            txtProdutoBuscar.Name = "txtProdutoBuscar";
            txtProdutoBuscar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtProdutoBuscar.Size = new Size(672, 24);
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
            txtPrecoUnitario.Location = new Point(326, 101);
            txtPrecoUnitario.Name = "txtPrecoUnitario";
            txtPrecoUnitario.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtPrecoUnitario.Size = new Size(130, 24);
            txtPrecoUnitario.StateCommon.Back.Color1 = Color.White;
            txtPrecoUnitario.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtPrecoUnitario.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtPrecoUnitario.StateCommon.Border.ColorAngle = 1F;
            txtPrecoUnitario.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPrecoUnitario.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPrecoUnitario.StateCommon.Border.Rounding = 1F;
            txtPrecoUnitario.StateCommon.Border.Width = 1;
            txtPrecoUnitario.StateCommon.Content.Color1 = Color.Gray;
            txtPrecoUnitario.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtPrecoUnitario.StateCommon.Content.Padding = new Padding(2);
            txtPrecoUnitario.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtPrecoUnitario.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtPrecoUnitario.TabIndex = 4;
            txtPrecoUnitario.KeyDown += txtPrecoUnitario_KeyDown;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.BackColor = Color.Transparent;
            lblPreco.Font = new Font("Segoe UI", 9.75F);
            lblPreco.ForeColor = Color.FromArgb(44, 62, 80);
            lblPreco.Location = new Point(229, 105);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(94, 17);
            lblPreco.TabIndex = 646;
            lblPreco.Text = "Preço Unitario:";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.BackColor = Color.Transparent;
            lblQuantidade.Font = new Font("Segoe UI", 9.75F);
            lblQuantidade.ForeColor = Color.FromArgb(44, 62, 80);
            lblQuantidade.Location = new Point(2, 105);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(79, 17);
            lblQuantidade.TabIndex = 644;
            lblQuantidade.Text = "Quantidade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 1);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 1033;
            label1.Text = "Nº Venda:";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Font = new Font("Segoe UI", 9.75F);
            lblVendedor.ForeColor = Color.FromArgb(44, 62, 80);
            lblVendedor.Location = new Point(13, 34);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(68, 17);
            lblVendedor.TabIndex = 1045;
            lblVendedor.Text = "Vendedor:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(603, 1);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 1035;
            label3.Text = "Data Venda:";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.BackColor = Color.Transparent;
            lblProduto.Font = new Font("Segoe UI", 9.75F);
            lblProduto.ForeColor = Color.FromArgb(44, 62, 80);
            lblProduto.Location = new Point(23, 75);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(58, 17);
            lblProduto.TabIndex = 1026;
            lblProduto.Text = "Produto:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtQuantidade.Location = new Point(87, 101);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtQuantidade.Size = new Size(130, 24);
            txtQuantidade.StateCommon.Back.Color1 = Color.White;
            txtQuantidade.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtQuantidade.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtQuantidade.StateCommon.Border.ColorAngle = 1F;
            txtQuantidade.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtQuantidade.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtQuantidade.StateCommon.Border.Rounding = 1F;
            txtQuantidade.StateCommon.Border.Width = 1;
            txtQuantidade.StateCommon.Content.Color1 = Color.Gray;
            txtQuantidade.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtQuantidade.StateCommon.Content.Padding = new Padding(2);
            txtQuantidade.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtQuantidade.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtQuantidade.TabIndex = 3;
            txtQuantidade.TextAlign = HorizontalAlignment.Center;
            txtQuantidade.KeyDown += txtQuantidade_KeyDown;
            // 
            // lblRotuloSubTotal
            // 
            lblRotuloSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRotuloSubTotal.AutoSize = true;
            lblRotuloSubTotal.BackColor = Color.Transparent;
            lblRotuloSubTotal.Font = new Font("Segoe UI", 12F);
            lblRotuloSubTotal.ForeColor = Color.FromArgb(44, 62, 80);
            lblRotuloSubTotal.Location = new Point(606, 1);
            lblRotuloSubTotal.Name = "lblRotuloSubTotal";
            lblRotuloSubTotal.Size = new Size(72, 21);
            lblRotuloSubTotal.TabIndex = 1030;
            lblRotuloSubTotal.Text = "SubTotal:";
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
            txtVendedorBuscar.Location = new Point(87, 30);
            txtVendedorBuscar.Name = "txtVendedorBuscar";
            txtVendedorBuscar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtVendedorBuscar.Size = new Size(672, 24);
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
            dgvItensVenda.Location = new Point(4, 215);
            dgvItensVenda.Name = "dgvItensVenda";
            dgvItensVenda.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            dgvItensVenda.RowHeadersWidth = 23;
            dgvItensVenda.Size = new Size(804, 258);
            dgvItensVenda.TabIndex = 1051;
            dgvItensVenda.TabStop = false;
            dgvItensVenda.CellContentClick += dgvItensVenda_CellContentClick;
            dgvItensVenda.CellEndEdit += dgvItensVenda_CellEndEdit;
            // 
            // tlpMain
            // 
            tlpMain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpMain.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(pnlHeader, 0, 0);
            tlpMain.Controls.Add(pnlDadosVenda_pnlProdutosEntrada, 0, 1);
            tlpMain.Controls.Add(dgvItensVenda, 0, 2);
            tlpMain.Controls.Add(pnlResumo, 0, 3);
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 4;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 135F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpMain.Size = new Size(812, 508);
            tlpMain.TabIndex = 1044;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(tlpTitulo);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(4, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(804, 68);
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
            tlpTitulo.Controls.Add(kryptonPanel3, 0, 0);
            tlpTitulo.Controls.Add(kryptonPanel1, 0, 1);
            tlpTitulo.Dock = DockStyle.Fill;
            tlpTitulo.Location = new Point(0, 0);
            tlpTitulo.Name = "tlpTitulo";
            tlpTitulo.RowCount = 2;
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 57.35294F));
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 42.64706F));
            tlpTitulo.Size = new Size(804, 68);
            tlpTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            tlpTitulo.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            tlpTitulo.TabIndex = 0;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(lblTitulo);
            kryptonPanel3.Controls.Add(iconAcao);
            kryptonPanel3.Location = new Point(3, 3);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(568, 33);
            kryptonPanel3.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            kryptonPanel3.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.Location = new Point(315, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(212, 27);
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Color2 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 1091;
            lblTitulo.Values.Text = "PDV - FRENTE DE CAIXA";
            // 
            // iconAcao
            // 
            iconAcao.Anchor = AnchorStyles.Top;
            iconAcao.BackColor = Color.Transparent;
            iconAcao.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            iconAcao.IconColor = Color.White;
            iconAcao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAcao.IconSize = 40;
            iconAcao.Location = new Point(280, 0);
            iconAcao.Name = "iconAcao";
            iconAcao.Size = new Size(40, 40);
            iconAcao.TabIndex = 1110;
            iconAcao.TabStop = false;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(lblDataVenda);
            kryptonPanel1.Controls.Add(lblVendaID);
            kryptonPanel1.Controls.Add(label1);
            kryptonPanel1.Controls.Add(label3);
            kryptonPanel1.Location = new Point(3, 42);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(798, 23);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            kryptonPanel1.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            kryptonPanel1.TabIndex = 2;
            // 
            // lblDataVenda
            // 
            lblDataVenda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDataVenda.AutoSize = true;
            lblDataVenda.BackColor = Color.Transparent;
            lblDataVenda.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblDataVenda.ForeColor = Color.White;
            lblDataVenda.Location = new Point(700, 1);
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
            lblVendaID.Location = new Point(86, 1);
            lblVendaID.Name = "lblVendaID";
            lblVendaID.Size = new Size(17, 20);
            lblVendaID.TabIndex = 1036;
            lblVendaID.Text = "0";
            // 
            // pnlDadosVenda_pnlProdutosEntrada
            // 
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(kryptonLabel8);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(kryptonLabel7);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(kryptonLabel4);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(lblProduto);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(txtQuantidade);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(btnAdicionarItem);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(txtPrecoUnitario);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(txtVendedorBuscar);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(lblPreco);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(lblVendedor);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(lblQuantidade);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(txtClienteBuscar);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(lblCliente);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(txtProdutoBuscar);
            pnlDadosVenda_pnlProdutosEntrada.Dock = DockStyle.Fill;
            pnlDadosVenda_pnlProdutosEntrada.Location = new Point(4, 79);
            pnlDadosVenda_pnlProdutosEntrada.Name = "pnlDadosVenda_pnlProdutosEntrada";
            pnlDadosVenda_pnlProdutosEntrada.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            pnlDadosVenda_pnlProdutosEntrada.Size = new Size(804, 129);
            pnlDadosVenda_pnlProdutosEntrada.TabIndex = 1043;
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonLabel8.Location = new Point(766, 69);
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
            kryptonLabel7.Location = new Point(766, 28);
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
            kryptonLabel4.Location = new Point(766, -2);
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
            pnlResumo.Controls.Add(lblSubTotal);
            pnlResumo.Controls.Add(txtTotalItens);
            pnlResumo.Controls.Add(lblRotuloSubTotal);
            pnlResumo.Controls.Add(lblTotalItens);
            pnlResumo.Dock = DockStyle.Fill;
            pnlResumo.Location = new Point(4, 480);
            pnlResumo.Name = "pnlResumo";
            pnlResumo.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            pnlResumo.Size = new Size(804, 24);
            pnlResumo.TabIndex = 1052;
            // 
            // lblSubTotal
            // 
            lblSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSubTotal.AutoSize = true;
            lblSubTotal.BackColor = Color.Transparent;
            lblSubTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSubTotal.ForeColor = Color.FromArgb(44, 62, 80);
            lblSubTotal.Location = new Point(678, 1);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(22, 21);
            lblSubTotal.TabIndex = 1049;
            lblSubTotal.Text = "--";
            lblSubTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTotalItens
            // 
            txtTotalItens.AutoSize = true;
            txtTotalItens.BackColor = Color.Transparent;
            txtTotalItens.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtTotalItens.ForeColor = Color.FromArgb(44, 62, 80);
            txtTotalItens.Location = new Point(89, 1);
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
            lblTotalItens.Location = new Point(3, 1);
            lblTotalItens.Name = "lblTotalItens";
            lblTotalItens.Size = new Size(82, 21);
            lblTotalItens.TabIndex = 1035;
            lblTotalItens.Text = "Total Itens:";
            lblTotalItens.TextAlign = ContentAlignment.MiddleCenter;
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
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = Color.FromArgb(30, 136, 229);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            iconPictureBox1.IconColor = Color.FromArgb(30, 136, 229);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(568, -1);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 40);
            iconPictureBox1.TabIndex = 1111;
            iconPictureBox1.TabStop = false;
            // 
            // FrmPDVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(812, 626);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblDesconto);
            Controls.Add(lblTotalLiquido);
            Controls.Add(tlpMain);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPDVendas";
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
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconAcao).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlDadosVenda_pnlProdutosEntrada).EndInit();
            pnlDadosVenda_pnlProdutosEntrada.ResumeLayout(false);
            pnlDadosVenda_pnlProdutosEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlResumo).EndInit();
            pnlResumo.ResumeLayout(false);
            pnlResumo.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Krypton.Toolkit.KryptonTextBox txtClienteBuscar;
        private Label lblDesconto;
        private Label lblTotalLiquido;
        public Krypton.Toolkit.KryptonButton btnAdicionarItem;
        private Label lblQuantidade;
        public Krypton.Toolkit.KryptonTextBox txtProdutoBuscar;
        public Krypton.Toolkit.KryptonTextBox txtPrecoUnitario;
        private Label lblPreco;
        private Label lblCliente;
        private Label label1;
        private Label label3;
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
        private Label lblSubTotal;
        private Label txtTotalItens;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        public FontAwesome.Sharp.IconButton btnSair;
        public FontAwesome.Sharp.IconButton btnFinalizarVenda;
        public FontAwesome.Sharp.IconButton btnNovaVenda;
        private Krypton.Toolkit.KryptonPanel pnlHeader;
        private Krypton.Toolkit.KryptonTableLayoutPanel tlpTitulo;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private FontAwesome.Sharp.IconPictureBox iconAcao;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Label lblDataVenda;
        private Label lblVendaID;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}