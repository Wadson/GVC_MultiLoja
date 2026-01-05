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
            btnFinalizarVenda = new Krypton.Toolkit.KryptonButton();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            btnNovaVenda = new Krypton.Toolkit.KryptonButton();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            pnlHeader = new Krypton.Toolkit.KryptonPanel();
            lblTituloPDV = new Krypton.Toolkit.KryptonLabel();
            txtVendedorBuscar = new Krypton.Toolkit.KryptonTextBox();
            dgvItensVenda = new Krypton.Toolkit.KryptonDataGridView();
            tlpMain = new TableLayoutPanel();
            pnlDadosVenda_pnlProdutosEntrada = new Krypton.Toolkit.KryptonPanel();
            txtDataVenda = new Krypton.Toolkit.KryptonTextBox();
            txtVendaID = new Krypton.Toolkit.KryptonTextBox();
            pnlResumo = new Krypton.Toolkit.KryptonPanel();
            lblSubTotal = new Label();
            txtTotalItens = new Label();
            lblTotalItens = new Label();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSair = new Krypton.Toolkit.KryptonButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).BeginInit();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).BeginInit();
            tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlDadosVenda_pnlProdutosEntrada).BeginInit();
            pnlDadosVenda_pnlProdutosEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlResumo).BeginInit();
            pnlResumo.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtClienteBuscar
            // 
            txtClienteBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClienteBuscar.CharacterCasing = CharacterCasing.Upper;
            txtClienteBuscar.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtClienteBuscar.Location = new Point(87, 31);
            txtClienteBuscar.Name = "txtClienteBuscar";
            txtClienteBuscar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtClienteBuscar.Size = new Size(707, 24);
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
            btnAdicionarItem.Location = new Point(462, 132);
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
            lblCliente.Location = new Point(31, 35);
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
            txtProdutoBuscar.Location = new Point(87, 103);
            txtProdutoBuscar.Name = "txtProdutoBuscar";
            txtProdutoBuscar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtProdutoBuscar.Size = new Size(707, 24);
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
            txtPrecoUnitario.Location = new Point(326, 132);
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
            lblPreco.Location = new Point(229, 136);
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
            lblQuantidade.Location = new Point(2, 136);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(79, 17);
            lblQuantidade.TabIndex = 644;
            lblQuantidade.Text = "Quantidade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(14, 7);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 1033;
            label1.Text = "Nº Venda:";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Font = new Font("Segoe UI", 9.75F);
            lblVendedor.ForeColor = Color.FromArgb(44, 62, 80);
            lblVendedor.Location = new Point(13, 65);
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
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(597, 7);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 1035;
            label3.Text = "Data Venda:";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.BackColor = Color.Transparent;
            lblProduto.Font = new Font("Segoe UI", 9.75F);
            lblProduto.ForeColor = Color.FromArgb(44, 62, 80);
            lblProduto.Location = new Point(23, 106);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(58, 17);
            lblProduto.TabIndex = 1026;
            lblProduto.Text = "Produto:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtQuantidade.Location = new Point(87, 132);
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
            // btnFinalizarVenda
            // 
            btnFinalizarVenda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFinalizarVenda.CornerRoundingRadius = 1F;
            btnFinalizarVenda.Enabled = false;
            btnFinalizarVenda.Location = new Point(99, 3);
            btnFinalizarVenda.Name = "btnFinalizarVenda";
            btnFinalizarVenda.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnFinalizarVenda.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnFinalizarVenda.OverrideDefault.Back.ColorAngle = 45F;
            btnFinalizarVenda.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnFinalizarVenda.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnFinalizarVenda.OverrideDefault.Border.ColorAngle = 45F;
            btnFinalizarVenda.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnFinalizarVenda.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnFinalizarVenda.OverrideDefault.Border.Rounding = 20F;
            btnFinalizarVenda.OverrideDefault.Border.Width = 1;
            btnFinalizarVenda.Size = new Size(90, 27);
            btnFinalizarVenda.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnFinalizarVenda.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnFinalizarVenda.StateCommon.Back.ColorAngle = 45F;
            btnFinalizarVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnFinalizarVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnFinalizarVenda.StateCommon.Border.Rounding = 1F;
            btnFinalizarVenda.StateCommon.Border.Width = 1;
            btnFinalizarVenda.StateCommon.Content.Padding = new Padding(2, 3, 2, 3);
            btnFinalizarVenda.StateCommon.Content.ShortText.Color1 = Color.White;
            btnFinalizarVenda.StateCommon.Content.ShortText.Color2 = Color.White;
            btnFinalizarVenda.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 8.25F);
            btnFinalizarVenda.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnFinalizarVenda.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnFinalizarVenda.StatePressed.Back.ColorAngle = 135F;
            btnFinalizarVenda.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnFinalizarVenda.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnFinalizarVenda.StatePressed.Border.ColorAngle = 135F;
            btnFinalizarVenda.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnFinalizarVenda.StatePressed.Border.Rounding = 20F;
            btnFinalizarVenda.StatePressed.Border.Width = 1;
            btnFinalizarVenda.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnFinalizarVenda.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnFinalizarVenda.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnFinalizarVenda.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnFinalizarVenda.StateTracking.Back.ColorAngle = 45F;
            btnFinalizarVenda.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnFinalizarVenda.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnFinalizarVenda.StateTracking.Border.ColorAngle = 45F;
            btnFinalizarVenda.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnFinalizarVenda.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnFinalizarVenda.StateTracking.Border.Rounding = 20F;
            btnFinalizarVenda.StateTracking.Border.Width = 1;
            btnFinalizarVenda.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnFinalizarVenda.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnFinalizarVenda.TabIndex = 1041;
            btnFinalizarVenda.TabStop = false;
            btnFinalizarVenda.Values.Text = "Finalizar Venda";
            btnFinalizarVenda.Click += btnFinalizarVenda_Click;
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
            // btnNovaVenda
            // 
            btnNovaVenda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNovaVenda.CornerRoundingRadius = 1F;
            btnNovaVenda.Location = new Point(3, 3);
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
            btnNovaVenda.Size = new Size(90, 27);
            btnNovaVenda.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnNovaVenda.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnNovaVenda.StateCommon.Back.ColorAngle = 45F;
            btnNovaVenda.StateCommon.Border.Color1 = Color.FromArgb(8, 148, 252);
            btnNovaVenda.StateCommon.Border.Color2 = Color.FromArgb(8, 148, 252);
            btnNovaVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovaVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovaVenda.StateCommon.Border.Rounding = 1F;
            btnNovaVenda.StateCommon.Border.Width = 1;
            btnNovaVenda.StateCommon.Content.Padding = new Padding(2, 3, 2, 3);
            btnNovaVenda.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnNovaVenda.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnNovaVenda.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 8.25F);
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
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblTituloPDV);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(4, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Blue;
            pnlHeader.Size = new Size(804, 24);
            pnlHeader.TabIndex = 1042;
            // 
            // lblTituloPDV
            // 
            lblTituloPDV.Dock = DockStyle.Fill;
            lblTituloPDV.Location = new Point(0, 0);
            lblTituloPDV.Name = "lblTituloPDV";
            lblTituloPDV.Size = new Size(804, 24);
            lblTituloPDV.StateCommon.Padding = new Padding(2, 1, 2, 1);
            lblTituloPDV.StateCommon.ShortText.Color1 = Color.FromArgb(44, 62, 80);
            lblTituloPDV.StateCommon.ShortText.Color2 = Color.FromArgb(44, 62, 80);
            lblTituloPDV.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTituloPDV.TabIndex = 0;
            lblTituloPDV.Values.Text = "PDV - FRENTE DE CAIXA";
            // 
            // txtVendedorBuscar
            // 
            txtVendedorBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtVendedorBuscar.CharacterCasing = CharacterCasing.Upper;
            txtVendedorBuscar.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtVendedorBuscar.Location = new Point(87, 61);
            txtVendedorBuscar.Name = "txtVendedorBuscar";
            txtVendedorBuscar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtVendedorBuscar.Size = new Size(707, 24);
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
            dgvItensVenda.Location = new Point(4, 202);
            dgvItensVenda.Name = "dgvItensVenda";
            dgvItensVenda.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueLightMode;
            dgvItensVenda.RowHeadersWidth = 23;
            dgvItensVenda.Size = new Size(804, 271);
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
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 166F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpMain.Size = new Size(812, 508);
            tlpMain.TabIndex = 1044;
            // 
            // pnlDadosVenda_pnlProdutosEntrada
            // 
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(txtDataVenda);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(lblProduto);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(txtQuantidade);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(btnAdicionarItem);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(txtPrecoUnitario);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(txtVendedorBuscar);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(lblPreco);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(lblVendedor);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(lblQuantidade);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(label3);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(txtClienteBuscar);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(txtVendaID);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(lblCliente);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(label1);
            pnlDadosVenda_pnlProdutosEntrada.Controls.Add(txtProdutoBuscar);
            pnlDadosVenda_pnlProdutosEntrada.Dock = DockStyle.Fill;
            pnlDadosVenda_pnlProdutosEntrada.Location = new Point(4, 35);
            pnlDadosVenda_pnlProdutosEntrada.Name = "pnlDadosVenda_pnlProdutosEntrada";
            pnlDadosVenda_pnlProdutosEntrada.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            pnlDadosVenda_pnlProdutosEntrada.Size = new Size(804, 160);
            pnlDadosVenda_pnlProdutosEntrada.TabIndex = 1043;
            // 
            // txtDataVenda
            // 
            txtDataVenda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDataVenda.CharacterCasing = CharacterCasing.Upper;
            txtDataVenda.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtDataVenda.Location = new Point(678, 3);
            txtDataVenda.Name = "txtDataVenda";
            txtDataVenda.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtDataVenda.ReadOnly = true;
            txtDataVenda.Size = new Size(117, 24);
            txtDataVenda.StateCommon.Back.Color1 = Color.White;
            txtDataVenda.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtDataVenda.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtDataVenda.StateCommon.Border.ColorAngle = 1F;
            txtDataVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDataVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtDataVenda.StateCommon.Border.Rounding = 1F;
            txtDataVenda.StateCommon.Border.Width = 1;
            txtDataVenda.StateCommon.Content.Color1 = Color.Gray;
            txtDataVenda.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtDataVenda.StateCommon.Content.Padding = new Padding(2);
            txtDataVenda.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtDataVenda.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtDataVenda.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtDataVenda.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtDataVenda.TabIndex = 1058;
            // 
            // txtVendaID
            // 
            txtVendaID.CharacterCasing = CharacterCasing.Upper;
            txtVendaID.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtVendaID.Location = new Point(87, 3);
            txtVendaID.Name = "txtVendaID";
            txtVendaID.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtVendaID.ReadOnly = true;
            txtVendaID.Size = new Size(100, 24);
            txtVendaID.StateCommon.Back.Color1 = Color.White;
            txtVendaID.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtVendaID.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtVendaID.StateCommon.Border.ColorAngle = 1F;
            txtVendaID.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtVendaID.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtVendaID.StateCommon.Border.Rounding = 1F;
            txtVendaID.StateCommon.Border.Width = 1;
            txtVendaID.StateCommon.Content.Color1 = Color.Gray;
            txtVendaID.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtVendaID.StateCommon.Content.Padding = new Padding(2);
            txtVendaID.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtVendaID.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtVendaID.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtVendaID.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtVendaID.TabIndex = 1057;
            // 
            // pnlResumo
            // 
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
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel1.Controls.Add(kryptonLabel1);
            flowLayoutPanel1.Controls.Add(kryptonLabel2);
            flowLayoutPanel1.Controls.Add(kryptonLabel3);
            flowLayoutPanel1.Controls.Add(kryptonLabel6);
            flowLayoutPanel1.Controls.Add(kryptonLabel5);
            flowLayoutPanel1.Location = new Point(0, 594);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(484, 32);
            flowLayoutPanel1.TabIndex = 1050;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSair.CornerRoundingRadius = 1F;
            btnSair.Location = new Point(195, 3);
            btnSair.Name = "btnSair";
            btnSair.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Back.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Border.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.OverrideDefault.Border.Rounding = 20F;
            btnSair.OverrideDefault.Border.Width = 1;
            btnSair.Size = new Size(100, 27);
            btnSair.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnSair.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnSair.StateCommon.Back.ColorAngle = 45F;
            btnSair.StateCommon.Border.Color1 = Color.FromArgb(8, 148, 252);
            btnSair.StateCommon.Border.Color2 = Color.FromArgb(8, 148, 252);
            btnSair.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateCommon.Border.Rounding = 1F;
            btnSair.StateCommon.Border.Width = 1;
            btnSair.StateCommon.Content.Padding = new Padding(2, 3, 2, 3);
            btnSair.StateCommon.Content.ShortText.Color1 = Color.FromArgb(44, 62, 80);
            btnSair.StateCommon.Content.ShortText.Color2 = Color.FromArgb(44, 62, 80);
            btnSair.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 8.25F);
            btnSair.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnSair.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnSair.StatePressed.Back.ColorAngle = 135F;
            btnSair.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StatePressed.Border.ColorAngle = 135F;
            btnSair.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StatePressed.Border.Rounding = 20F;
            btnSair.StatePressed.Border.Width = 1;
            btnSair.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnSair.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnSair.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnSair.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnSair.StateTracking.Back.ColorAngle = 45F;
            btnSair.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateTracking.Border.ColorAngle = 45F;
            btnSair.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateTracking.Border.Rounding = 20F;
            btnSair.StateTracking.Border.Width = 1;
            btnSair.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnSair.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnSair.TabIndex = 1045;
            btnSair.TabStop = false;
            btnSair.Values.Text = "Sair";
            btnSair.Click += btnSair_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(btnNovaVenda);
            flowLayoutPanel2.Controls.Add(btnFinalizarVenda);
            flowLayoutPanel2.Controls.Add(btnSair);
            flowLayoutPanel2.Location = new Point(506, 594);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(303, 32);
            flowLayoutPanel2.TabIndex = 1051;
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
            ((System.ComponentModel.ISupportInitialize)pnlHeader).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).EndInit();
            tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnlDadosVenda_pnlProdutosEntrada).EndInit();
            pnlDadosVenda_pnlProdutosEntrada.ResumeLayout(false);
            pnlDadosVenda_pnlProdutosEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlResumo).EndInit();
            pnlResumo.ResumeLayout(false);
            pnlResumo.PerformLayout();
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
        public Krypton.Toolkit.KryptonButton btnFinalizarVenda;
        private Label lblVendedor;
        private Krypton.Toolkit.KryptonPanel pnlHeader;
        private Krypton.Toolkit.KryptonLabel lblTituloPDV;
        private Krypton.Toolkit.KryptonDataGridView dgvItensVenda;
        public Krypton.Toolkit.KryptonButton btnNovaVenda;
        private TableLayoutPanel tlpMain;
        private Label lblTotalItens;
        public Krypton.Toolkit.KryptonTextBox txtVendedorBuscar;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public Krypton.Toolkit.KryptonTextBox txtVendaID;
        public Krypton.Toolkit.KryptonTextBox txtDataVenda;
        private Krypton.Toolkit.KryptonPanel pnlDadosVenda_pnlProdutosEntrada;
        private Krypton.Toolkit.KryptonPanel pnlResumo;
        private Label lblSubTotal;
        private Label txtTotalItens;
        private FlowLayoutPanel flowLayoutPanel1;
        public Krypton.Toolkit.KryptonButton btnSair;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}