namespace GVC
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            imageList1 = new ImageList(components);
            panelMenu = new Panel();
            btnRelatorio = new Button();
            btnContasReceber = new Button();
            btnFerramentas = new Button();
            btnVenda = new Button();
            btnProdutos = new Button();
            btnFornecedor = new Button();
            btnCliente = new Button();
            btnUsuario = new Button();
            panelLogo = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            panelTitulo = new Krypton.Toolkit.KryptonPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem1 = new ToolStripMenuItem();
            cidadeToolStripMenuItem1 = new ToolStripMenuItem();
            clientesToolStripMenuItem1 = new ToolStripMenuItem();
            estadoToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem1 = new ToolStripMenuItem();
            produtosToolStripMenuItem1 = new ToolStripMenuItem();
            usuáriosToolStripMenuItem1 = new ToolStripMenuItem();
            empresaToolStripMenuItem = new ToolStripMenuItem();
            formaDePagamentoToolStripMenuItem = new ToolStripMenuItem();
            ferramentasToolStripMenuItem = new ToolStripMenuItem();
            cancelarVendaToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            movimentaçãoDeEstoqueToolStripMenuItem = new ToolStripMenuItem();
            consultaMovimentaçãoDeEstoqueToolStripMenuItem = new ToolStripMenuItem();
            relatórioEstoqueToolStripMenuItem = new ToolStripMenuItem();
            dashbordToolStripMenuItem = new ToolStripMenuItem();
            configuraçãoDoSistemaToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItemConfiguracoes = new ToolStripMenuItem();
            btnMenu = new Button();
            panelConteiner = new Krypton.Toolkit.KryptonPanel();
            kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            buttonsToolStripMenuItem = new ToolStripMenuItem();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelTitulo).BeginInit();
            panelTitulo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelConteiner).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "BackupBranco.png");
            imageList1.Images.SetKeyName(1, "CarrinhoSGVendas64.png");
            imageList1.Images.SetKeyName(2, "CidadeBranco.png");
            imageList1.Images.SetKeyName(3, "ClienteBranco.png");
            imageList1.Images.SetKeyName(4, "ContasReceberBranco.png");
            imageList1.Images.SetKeyName(5, "DashBordBranco.png");
            imageList1.Images.SetKeyName(6, "EmpresaBranco.png");
            imageList1.Images.SetKeyName(7, "EstadoBranco.png");
            imageList1.Images.SetKeyName(8, "EstoqueBranco.png");
            imageList1.Images.SetKeyName(9, "FerramentasBranco.png");
            imageList1.Images.SetKeyName(10, "FornecedorBranco.png");
            imageList1.Images.SetKeyName(11, "ProdutoBranco.png");
            imageList1.Images.SetKeyName(12, "RelatorioBRanco.png");
            imageList1.Images.SetKeyName(13, "SGVendasBranco.png");
            imageList1.Images.SetKeyName(14, "UsuarioBranco.png");
            imageList1.Images.SetKeyName(15, "VendaBranco.png");
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(8, 142, 254);
            panelMenu.Controls.Add(btnRelatorio);
            panelMenu.Controls.Add(btnContasReceber);
            panelMenu.Controls.Add(btnFerramentas);
            panelMenu.Controls.Add(btnVenda);
            panelMenu.Controls.Add(btnProdutos);
            panelMenu.Controls.Add(btnFornecedor);
            panelMenu.Controls.Add(btnCliente);
            panelMenu.Controls.Add(btnUsuario);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(168, 580);
            panelMenu.TabIndex = 1;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Dock = DockStyle.Top;
            btnRelatorio.FlatAppearance.BorderSize = 0;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.Font = new Font("Poppins", 9.75F);
            btnRelatorio.ForeColor = Color.White;
            btnRelatorio.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelatorio.ImageKey = "RelatorioBRanco.png";
            btnRelatorio.ImageList = imageList1;
            btnRelatorio.Location = new Point(0, 388);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Padding = new Padding(11, 0, 0, 0);
            btnRelatorio.Size = new Size(168, 50);
            btnRelatorio.TabIndex = 10;
            btnRelatorio.Text = "Relatórios";
            btnRelatorio.TextAlign = ContentAlignment.MiddleRight;
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btnContasReceber
            // 
            btnContasReceber.Dock = DockStyle.Top;
            btnContasReceber.FlatAppearance.BorderSize = 0;
            btnContasReceber.FlatStyle = FlatStyle.Flat;
            btnContasReceber.Font = new Font("Poppins", 9.75F);
            btnContasReceber.ForeColor = Color.White;
            btnContasReceber.ImageAlign = ContentAlignment.MiddleLeft;
            btnContasReceber.ImageKey = "ContasReceberBranco.png";
            btnContasReceber.ImageList = imageList1;
            btnContasReceber.Location = new Point(0, 338);
            btnContasReceber.Name = "btnContasReceber";
            btnContasReceber.Padding = new Padding(11, 0, 0, 0);
            btnContasReceber.Size = new Size(168, 50);
            btnContasReceber.TabIndex = 9;
            btnContasReceber.Text = "Receber";
            btnContasReceber.TextAlign = ContentAlignment.MiddleRight;
            btnContasReceber.UseVisualStyleBackColor = true;
            btnContasReceber.Click += btnContasReceber_Click;
            // 
            // btnFerramentas
            // 
            btnFerramentas.Dock = DockStyle.Top;
            btnFerramentas.FlatAppearance.BorderSize = 0;
            btnFerramentas.FlatStyle = FlatStyle.Flat;
            btnFerramentas.Font = new Font("Poppins", 9.75F);
            btnFerramentas.ForeColor = Color.White;
            btnFerramentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnFerramentas.ImageKey = "FerramentasBranco.png";
            btnFerramentas.ImageList = imageList1;
            btnFerramentas.Location = new Point(0, 288);
            btnFerramentas.Name = "btnFerramentas";
            btnFerramentas.Padding = new Padding(11, 0, 0, 0);
            btnFerramentas.Size = new Size(168, 50);
            btnFerramentas.TabIndex = 8;
            btnFerramentas.Text = "Ferramentas";
            btnFerramentas.TextAlign = ContentAlignment.MiddleRight;
            btnFerramentas.UseVisualStyleBackColor = true;
            btnFerramentas.Click += btnFerramentas_Click;
            // 
            // btnVenda
            // 
            btnVenda.Dock = DockStyle.Top;
            btnVenda.FlatAppearance.BorderSize = 0;
            btnVenda.FlatStyle = FlatStyle.Flat;
            btnVenda.Font = new Font("Poppins", 9.75F);
            btnVenda.ForeColor = Color.White;
            btnVenda.ImageAlign = ContentAlignment.MiddleLeft;
            btnVenda.ImageKey = "VendaBranco.png";
            btnVenda.ImageList = imageList1;
            btnVenda.Location = new Point(0, 238);
            btnVenda.Name = "btnVenda";
            btnVenda.Padding = new Padding(11, 0, 0, 0);
            btnVenda.Size = new Size(168, 50);
            btnVenda.TabIndex = 7;
            btnVenda.Text = "PDV";
            btnVenda.TextAlign = ContentAlignment.MiddleRight;
            btnVenda.UseVisualStyleBackColor = true;
            btnVenda.Click += btnVenda_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.Dock = DockStyle.Top;
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Poppins", 9.75F);
            btnProdutos.ForeColor = Color.White;
            btnProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdutos.ImageKey = "ProdutoBranco.png";
            btnProdutos.ImageList = imageList1;
            btnProdutos.Location = new Point(0, 188);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Padding = new Padding(11, 0, 0, 0);
            btnProdutos.Size = new Size(168, 50);
            btnProdutos.TabIndex = 6;
            btnProdutos.Text = "Produtos";
            btnProdutos.TextAlign = ContentAlignment.MiddleRight;
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnFornecedor
            // 
            btnFornecedor.Dock = DockStyle.Top;
            btnFornecedor.FlatAppearance.BorderSize = 0;
            btnFornecedor.FlatStyle = FlatStyle.Flat;
            btnFornecedor.Font = new Font("Poppins", 9.75F);
            btnFornecedor.ForeColor = Color.White;
            btnFornecedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnFornecedor.ImageKey = "FornecedorBranco.png";
            btnFornecedor.ImageList = imageList1;
            btnFornecedor.Location = new Point(0, 138);
            btnFornecedor.Name = "btnFornecedor";
            btnFornecedor.Padding = new Padding(11, 0, 0, 0);
            btnFornecedor.Size = new Size(168, 50);
            btnFornecedor.TabIndex = 5;
            btnFornecedor.Text = "Fornecedores";
            btnFornecedor.TextAlign = ContentAlignment.MiddleRight;
            btnFornecedor.UseVisualStyleBackColor = true;
            btnFornecedor.Click += btnFornecedor_Click;
            // 
            // btnCliente
            // 
            btnCliente.Dock = DockStyle.Top;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Poppins", 9.75F);
            btnCliente.ForeColor = Color.White;
            btnCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnCliente.ImageKey = "ClienteBranco.png";
            btnCliente.ImageList = imageList1;
            btnCliente.Location = new Point(0, 88);
            btnCliente.Name = "btnCliente";
            btnCliente.Padding = new Padding(11, 0, 0, 0);
            btnCliente.Size = new Size(168, 50);
            btnCliente.TabIndex = 4;
            btnCliente.Text = "Clientes";
            btnCliente.TextAlign = ContentAlignment.MiddleRight;
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnUsuario
            // 
            btnUsuario.Dock = DockStyle.Top;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Poppins", 9.75F);
            btnUsuario.ForeColor = Color.White;
            btnUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuario.ImageKey = "UsuarioBranco.png";
            btnUsuario.ImageList = imageList1;
            btnUsuario.Location = new Point(0, 38);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Padding = new Padding(11, 0, 0, 0);
            btnUsuario.Size = new Size(168, 50);
            btnUsuario.TabIndex = 3;
            btnUsuario.Text = "Usuários";
            btnUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(8, 148, 254);
            panelLogo.Controls.Add(pictureBox2);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(168, 38);
            panelLogo.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(8, 142, 254);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(70, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(98, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(8, 148, 254);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
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
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Color1 = Color.FromArgb(244, 82, 0);
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Color2 = Color.FromArgb(244, 82, 0);
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = Color.FromArgb(8, 148, 250);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = Color.FromArgb(8, 148, 250);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12F;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(236, 240, 241);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(236, 240, 241);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(10, -1, -1, -1);
            kryptonPalette1.HeaderStyles.HeaderPrimary.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            // 
            // panelTitulo
            // 
            panelTitulo.Controls.Add(tableLayoutPanel1);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(168, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            panelTitulo.Size = new Size(632, 38);
            panelTitulo.StateCommon.Color1 = Color.FromArgb(8, 148, 254);
            panelTitulo.StateCommon.Color2 = Color.FromArgb(8, 148, 254);
            panelTitulo.TabIndex = 0;
            panelTitulo.MouseDown += panelTitulo_MouseDown;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(8, 148, 254);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(menuStrip1, 1, 0);
            tableLayoutPanel1.Controls.Add(btnMenu, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(629, 33);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(8, 148, 254);
            menuStrip1.Font = new Font("Segoe UI", 9F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem1, ferramentasToolStripMenuItem, estoqueToolStripMenuItem, configuraçãoDoSistemaToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(35, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(594, 24);
            menuStrip1.TabIndex = 1104;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem1
            // 
            cadastrosToolStripMenuItem1.BackColor = Color.FromArgb(8, 148, 254);
            cadastrosToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { cidadeToolStripMenuItem1, clientesToolStripMenuItem1, estadoToolStripMenuItem, fornecedoresToolStripMenuItem1, produtosToolStripMenuItem1, usuáriosToolStripMenuItem1, empresaToolStripMenuItem, formaDePagamentoToolStripMenuItem });
            cadastrosToolStripMenuItem1.ForeColor = Color.White;
            cadastrosToolStripMenuItem1.Name = "cadastrosToolStripMenuItem1";
            cadastrosToolStripMenuItem1.Size = new Size(71, 20);
            cadastrosToolStripMenuItem1.Text = "&Cadastros";
            // 
            // cidadeToolStripMenuItem1
            // 
            cidadeToolStripMenuItem1.BackColor = Color.FromArgb(8, 148, 254);
            cidadeToolStripMenuItem1.Name = "cidadeToolStripMenuItem1";
            cidadeToolStripMenuItem1.Size = new Size(188, 22);
            cidadeToolStripMenuItem1.Text = "&Cidade";
            // 
            // clientesToolStripMenuItem1
            // 
            clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            clientesToolStripMenuItem1.Size = new Size(188, 22);
            clientesToolStripMenuItem1.Text = "&Clientes";
            // 
            // estadoToolStripMenuItem
            // 
            estadoToolStripMenuItem.Name = "estadoToolStripMenuItem";
            estadoToolStripMenuItem.Size = new Size(188, 22);
            estadoToolStripMenuItem.Text = "&Estado";
            // 
            // fornecedoresToolStripMenuItem1
            // 
            fornecedoresToolStripMenuItem1.Name = "fornecedoresToolStripMenuItem1";
            fornecedoresToolStripMenuItem1.Size = new Size(188, 22);
            fornecedoresToolStripMenuItem1.Text = "&Fornecedores";
            // 
            // produtosToolStripMenuItem1
            // 
            produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            produtosToolStripMenuItem1.Size = new Size(188, 22);
            produtosToolStripMenuItem1.Text = "&Produtos";
            // 
            // usuáriosToolStripMenuItem1
            // 
            usuáriosToolStripMenuItem1.Name = "usuáriosToolStripMenuItem1";
            usuáriosToolStripMenuItem1.Size = new Size(188, 22);
            usuáriosToolStripMenuItem1.Text = "&Usuários";
            // 
            // empresaToolStripMenuItem
            // 
            empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            empresaToolStripMenuItem.Size = new Size(188, 22);
            empresaToolStripMenuItem.Text = "Empresa";
            // 
            // formaDePagamentoToolStripMenuItem
            // 
            formaDePagamentoToolStripMenuItem.Name = "formaDePagamentoToolStripMenuItem";
            formaDePagamentoToolStripMenuItem.Size = new Size(188, 22);
            formaDePagamentoToolStripMenuItem.Text = "Forma de Pagamento";
            // 
            // ferramentasToolStripMenuItem
            // 
            ferramentasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cancelarVendaToolStripMenuItem });
            ferramentasToolStripMenuItem.ForeColor = Color.White;
            ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            ferramentasToolStripMenuItem.Size = new Size(84, 20);
            ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // cancelarVendaToolStripMenuItem
            // 
            cancelarVendaToolStripMenuItem.Name = "cancelarVendaToolStripMenuItem";
            cancelarVendaToolStripMenuItem.Size = new Size(155, 22);
            cancelarVendaToolStripMenuItem.Text = "&Cancelar Venda";
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { movimentaçãoDeEstoqueToolStripMenuItem, consultaMovimentaçãoDeEstoqueToolStripMenuItem, relatórioEstoqueToolStripMenuItem, dashbordToolStripMenuItem });
            estoqueToolStripMenuItem.ForeColor = Color.White;
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(61, 20);
            estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // movimentaçãoDeEstoqueToolStripMenuItem
            // 
            movimentaçãoDeEstoqueToolStripMenuItem.Name = "movimentaçãoDeEstoqueToolStripMenuItem";
            movimentaçãoDeEstoqueToolStripMenuItem.Size = new Size(265, 22);
            movimentaçãoDeEstoqueToolStripMenuItem.Text = "Movimentação de Estoque";
            // 
            // consultaMovimentaçãoDeEstoqueToolStripMenuItem
            // 
            consultaMovimentaçãoDeEstoqueToolStripMenuItem.Name = "consultaMovimentaçãoDeEstoqueToolStripMenuItem";
            consultaMovimentaçãoDeEstoqueToolStripMenuItem.Size = new Size(265, 22);
            consultaMovimentaçãoDeEstoqueToolStripMenuItem.Text = "Consulta Movimentação de Estoque";
            // 
            // relatórioEstoqueToolStripMenuItem
            // 
            relatórioEstoqueToolStripMenuItem.Name = "relatórioEstoqueToolStripMenuItem";
            relatórioEstoqueToolStripMenuItem.Size = new Size(265, 22);
            relatórioEstoqueToolStripMenuItem.Text = "Relatório Estoque";
            // 
            // dashbordToolStripMenuItem
            // 
            dashbordToolStripMenuItem.Name = "dashbordToolStripMenuItem";
            dashbordToolStripMenuItem.Size = new Size(265, 22);
            dashbordToolStripMenuItem.Text = "Dashboard";
            // 
            // configuraçãoDoSistemaToolStripMenuItem
            // 
            configuraçãoDoSistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemConfiguracoes, buttonsToolStripMenuItem });
            configuraçãoDoSistemaToolStripMenuItem.ForeColor = Color.White;
            configuraçãoDoSistemaToolStripMenuItem.Name = "configuraçãoDoSistemaToolStripMenuItem";
            configuraçãoDoSistemaToolStripMenuItem.Size = new Size(60, 20);
            configuraçãoDoSistemaToolStripMenuItem.Text = "Sistema";
            // 
            // ToolStripMenuItemConfiguracoes
            // 
            ToolStripMenuItemConfiguracoes.Name = "ToolStripMenuItemConfiguracoes";
            ToolStripMenuItemConfiguracoes.Size = new Size(151, 22);
            ToolStripMenuItemConfiguracoes.Text = "Configurações";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(8, 148, 254);
            btnMenu.BackgroundImage = (Image)resources.GetObject("btnMenu.BackgroundImage");
            btnMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Location = new Point(3, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(29, 27);
            btnMenu.TabIndex = 1103;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelConteiner
            // 
            panelConteiner.Dock = DockStyle.Fill;
            panelConteiner.Location = new Point(168, 38);
            panelConteiner.Name = "panelConteiner";
            panelConteiner.Size = new Size(632, 542);
            panelConteiner.StateCommon.Color1 = Color.FromArgb(252, 252, 250);
            panelConteiner.StateCommon.Color2 = Color.FromArgb(252, 252, 250);
            panelConteiner.TabIndex = 2;
            // 
            // buttonsToolStripMenuItem
            // 
            buttonsToolStripMenuItem.Name = "buttonsToolStripMenuItem";
            buttonsToolStripMenuItem.Size = new Size(180, 22);
            buttonsToolStripMenuItem.Text = "Buttons";
            buttonsToolStripMenuItem.Click += buttonsToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(800, 580);
            Controls.Add(panelConteiner);
            Controls.Add(panelTitulo);
            Controls.Add(panelMenu);
            Name = "FrmPrincipal";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            Text = " ";
            WindowState = FormWindowState.Maximized;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelTitulo).EndInit();
            panelTitulo.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelConteiner).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnUsuario;
        private Button btnRelatorio;
        private Button btnContasReceber;
        private Button btnFerramentas;
        private Button btnVenda;
        private Button btnProdutos;
        private Button btnFornecedor;
        private Button btnCliente;
        private ImageList imageList1;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonPanel panelConteiner;
        private Krypton.Toolkit.KryptonPanel panelTitulo;
        private PictureBox pictureBox2;
        private Button btnMenu;
        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem1;
        private ToolStripMenuItem cidadeToolStripMenuItem1;
        private ToolStripMenuItem clientesToolStripMenuItem1;
        private ToolStripMenuItem estadoToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem1;
        private ToolStripMenuItem produtosToolStripMenuItem1;
        private ToolStripMenuItem usuáriosToolStripMenuItem1;
        private ToolStripMenuItem empresaToolStripMenuItem;
        private ToolStripMenuItem formaDePagamentoToolStripMenuItem;
        private ToolStripMenuItem ferramentasToolStripMenuItem;
        private ToolStripMenuItem cancelarVendaToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem movimentaçãoDeEstoqueToolStripMenuItem;
        private ToolStripMenuItem consultaMovimentaçãoDeEstoqueToolStripMenuItem;
        private ToolStripMenuItem relatórioEstoqueToolStripMenuItem;
        private ToolStripMenuItem dashbordToolStripMenuItem;
        private ToolStripMenuItem configuraçãoDoSistemaToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItemConfiguracoes;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private ToolStripMenuItem buttonsToolStripMenuItem;
    }
}