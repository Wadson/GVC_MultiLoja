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
            btnMenu = new Button();
            btnMinimizar = new Button();
            btnMaximizar = new Button();
            btnFechar = new Button();
            panelConteiner = new Krypton.Toolkit.KryptonPanel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelTitulo).BeginInit();
            panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelConteiner).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Backup.png");
            imageList1.Images.SetKeyName(1, "Cidade.png");
            imageList1.Images.SetKeyName(2, "Clientes.png");
            imageList1.Images.SetKeyName(3, "CloseL.png");
            imageList1.Images.SetKeyName(4, "Dashbord.png");
            imageList1.Images.SetKeyName(5, "Empresa.png");
            imageList1.Images.SetKeyName(6, "Estados.png");
            imageList1.Images.SetKeyName(7, "Estoque.png");
            imageList1.Images.SetKeyName(8, "Ferramentas.png");
            imageList1.Images.SetKeyName(9, "Fornecedor.png");
            imageList1.Images.SetKeyName(10, "LogoSGVendas.png");
            imageList1.Images.SetKeyName(11, "Menu.png");
            imageList1.Images.SetKeyName(12, "Produto.png");
            imageList1.Images.SetKeyName(13, "Receber.png");
            imageList1.Images.SetKeyName(14, "Relatorio.png");
            imageList1.Images.SetKeyName(15, "SGVendas.png");
            imageList1.Images.SetKeyName(16, "SGVendas256.png");
            imageList1.Images.SetKeyName(17, "Usuario.png");
            imageList1.Images.SetKeyName(18, "Venda.png");
            imageList1.Images.SetKeyName(19, "Fechar.png");
            imageList1.Images.SetKeyName(20, "Maximizar.png");
            imageList1.Images.SetKeyName(21, "Minimizar.png");
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(252, 252, 250);
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
            btnRelatorio.Font = new Font("Noto Sans", 9.75F, FontStyle.Italic);
            btnRelatorio.ForeColor = Color.FromArgb(245, 85, 0);
            btnRelatorio.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelatorio.ImageKey = "Relatorio.png";
            btnRelatorio.ImageList = imageList1;
            btnRelatorio.Location = new Point(0, 388);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Padding = new Padding(11, 0, 0, 0);
            btnRelatorio.Size = new Size(168, 50);
            btnRelatorio.TabIndex = 10;
            btnRelatorio.Text = "                  Relatórios";
            btnRelatorio.TextAlign = ContentAlignment.MiddleLeft;
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btnContasReceber
            // 
            btnContasReceber.Dock = DockStyle.Top;
            btnContasReceber.FlatAppearance.BorderSize = 0;
            btnContasReceber.FlatStyle = FlatStyle.Flat;
            btnContasReceber.Font = new Font("Noto Sans", 9.75F, FontStyle.Italic);
            btnContasReceber.ForeColor = Color.FromArgb(245, 85, 0);
            btnContasReceber.ImageAlign = ContentAlignment.MiddleLeft;
            btnContasReceber.ImageKey = "Receber.png";
            btnContasReceber.ImageList = imageList1;
            btnContasReceber.Location = new Point(0, 338);
            btnContasReceber.Name = "btnContasReceber";
            btnContasReceber.Padding = new Padding(11, 0, 0, 0);
            btnContasReceber.Size = new Size(168, 50);
            btnContasReceber.TabIndex = 9;
            btnContasReceber.Text = "   Receber";
            btnContasReceber.UseVisualStyleBackColor = true;
            btnContasReceber.Click += btnContasReceber_Click;
            // 
            // btnFerramentas
            // 
            btnFerramentas.Dock = DockStyle.Top;
            btnFerramentas.FlatAppearance.BorderSize = 0;
            btnFerramentas.FlatStyle = FlatStyle.Flat;
            btnFerramentas.Font = new Font("Noto Sans", 9.75F, FontStyle.Italic);
            btnFerramentas.ForeColor = Color.FromArgb(245, 85, 0);
            btnFerramentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnFerramentas.ImageKey = "Ferramentas.png";
            btnFerramentas.ImageList = imageList1;
            btnFerramentas.Location = new Point(0, 288);
            btnFerramentas.Name = "btnFerramentas";
            btnFerramentas.Padding = new Padding(11, 0, 0, 0);
            btnFerramentas.Size = new Size(168, 50);
            btnFerramentas.TabIndex = 8;
            btnFerramentas.Text = "                  Ferramentas";
            btnFerramentas.TextAlign = ContentAlignment.MiddleLeft;
            btnFerramentas.UseVisualStyleBackColor = true;
            btnFerramentas.Click += btnFerramentas_Click;
            // 
            // btnVenda
            // 
            btnVenda.Dock = DockStyle.Top;
            btnVenda.FlatAppearance.BorderSize = 0;
            btnVenda.FlatStyle = FlatStyle.Flat;
            btnVenda.Font = new Font("Noto Sans", 9.75F, FontStyle.Italic);
            btnVenda.ForeColor = Color.FromArgb(245, 85, 0);
            btnVenda.ImageAlign = ContentAlignment.MiddleLeft;
            btnVenda.ImageKey = "Venda.png";
            btnVenda.ImageList = imageList1;
            btnVenda.Location = new Point(0, 238);
            btnVenda.Name = "btnVenda";
            btnVenda.Padding = new Padding(11, 0, 0, 0);
            btnVenda.Size = new Size(168, 50);
            btnVenda.TabIndex = 7;
            btnVenda.Text = "                  PDV";
            btnVenda.TextAlign = ContentAlignment.MiddleLeft;
            btnVenda.UseVisualStyleBackColor = true;
            btnVenda.Click += btnVenda_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.Dock = DockStyle.Top;
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Noto Sans", 9.75F, FontStyle.Italic);
            btnProdutos.ForeColor = Color.FromArgb(245, 85, 0);
            btnProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdutos.ImageKey = "Produto.png";
            btnProdutos.ImageList = imageList1;
            btnProdutos.Location = new Point(0, 188);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Padding = new Padding(11, 0, 0, 0);
            btnProdutos.Size = new Size(168, 50);
            btnProdutos.TabIndex = 6;
            btnProdutos.Text = "    Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnFornecedor
            // 
            btnFornecedor.Dock = DockStyle.Top;
            btnFornecedor.FlatAppearance.BorderSize = 0;
            btnFornecedor.FlatStyle = FlatStyle.Flat;
            btnFornecedor.Font = new Font("Noto Sans", 9.75F, FontStyle.Italic);
            btnFornecedor.ForeColor = Color.FromArgb(245, 85, 0);
            btnFornecedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnFornecedor.ImageKey = "Fornecedor.png";
            btnFornecedor.ImageList = imageList1;
            btnFornecedor.Location = new Point(0, 138);
            btnFornecedor.Name = "btnFornecedor";
            btnFornecedor.Padding = new Padding(11, 0, 0, 0);
            btnFornecedor.Size = new Size(168, 50);
            btnFornecedor.TabIndex = 5;
            btnFornecedor.Text = "            Fornecedores";
            btnFornecedor.UseVisualStyleBackColor = true;
            btnFornecedor.Click += btnFornecedor_Click;
            // 
            // btnCliente
            // 
            btnCliente.Dock = DockStyle.Top;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Noto Sans", 9.75F, FontStyle.Italic);
            btnCliente.ForeColor = Color.FromArgb(245, 85, 0);
            btnCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnCliente.ImageKey = "Clientes.png";
            btnCliente.ImageList = imageList1;
            btnCliente.Location = new Point(0, 88);
            btnCliente.Name = "btnCliente";
            btnCliente.Padding = new Padding(11, 0, 0, 0);
            btnCliente.Size = new Size(168, 50);
            btnCliente.TabIndex = 4;
            btnCliente.Text = "  Clientes";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnUsuario
            // 
            btnUsuario.Dock = DockStyle.Top;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Noto Sans", 9.75F, FontStyle.Italic);
            btnUsuario.ForeColor = Color.FromArgb(245, 85, 0);
            btnUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuario.ImageKey = "Usuario.png";
            btnUsuario.ImageList = imageList1;
            btnUsuario.Location = new Point(0, 38);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Padding = new Padding(11, 0, 0, 0);
            btnUsuario.Size = new Size(168, 50);
            btnUsuario.TabIndex = 3;
            btnUsuario.Text = "   Usuários";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(252, 252, 250);
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
            pictureBox2.BackColor = Color.FromArgb(252, 252, 250);
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
            pictureBox1.BackColor = Color.FromArgb(252, 252, 250);
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
            // panelTitulo
            // 
            panelTitulo.Controls.Add(btnMenu);
            panelTitulo.Controls.Add(btnMinimizar);
            panelTitulo.Controls.Add(btnMaximizar);
            panelTitulo.Controls.Add(btnFechar);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(168, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            panelTitulo.Size = new Size(632, 38);
            panelTitulo.StateCommon.Color1 = Color.FromArgb(252, 252, 250);
            panelTitulo.StateCommon.Color2 = Color.FromArgb(252, 252, 250);
            panelTitulo.TabIndex = 0;
            panelTitulo.MouseDown += panelTitulo_MouseDown;
            // 
            // btnMenu
            // 
            btnMenu.BackgroundImage = (Image)resources.GetObject("btnMenu.BackgroundImage");
            btnMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Location = new Point(10, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(30, 30);
            btnMenu.TabIndex = 1103;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.FromArgb(252, 252, 250);
            btnMinimizar.BackgroundImage = (Image)resources.GetObject("btnMinimizar.BackgroundImage");
            btnMinimizar.BackgroundImageLayout = ImageLayout.Stretch;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Location = new Point(546, 7);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(20, 20);
            btnMinimizar.TabIndex = 1102;
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.BackColor = Color.FromArgb(252, 252, 250);
            btnMaximizar.BackgroundImage = (Image)resources.GetObject("btnMaximizar.BackgroundImage");
            btnMaximizar.BackgroundImageLayout = ImageLayout.Stretch;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Location = new Point(576, 7);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(20, 20);
            btnMaximizar.TabIndex = 1101;
            btnMaximizar.UseVisualStyleBackColor = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.BackColor = Color.FromArgb(252, 252, 250);
            btnFechar.BackgroundImage = (Image)resources.GetObject("btnFechar.BackgroundImage");
            btnFechar.BackgroundImageLayout = ImageLayout.Stretch;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(606, 7);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(20, 20);
            btnFechar.TabIndex = 0;
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
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
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(800, 580);
            Controls.Add(panelConteiner);
            Controls.Add(panelTitulo);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button btnMinimizar;
        private Button btnMaximizar;
        private Button btnFechar;
    }
}