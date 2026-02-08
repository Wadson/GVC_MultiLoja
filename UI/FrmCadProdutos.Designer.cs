namespace GVC.View
{
    partial class FrmCadProdutos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadProdutos));
            label21 = new Label();
            label23 = new Label();
            label25 = new Label();
            label27 = new Label();
            txtProdutoID = new Krypton.Toolkit.KryptonTextBox();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            txtEstoque = new Krypton.Toolkit.KryptonTextBox();
            txtPrecoDeVenda = new Krypton.Toolkit.KryptonTextBox();
            txtLucro = new Krypton.Toolkit.KryptonTextBox();
            txtPrecoCusto = new Krypton.Toolkit.KryptonTextBox();
            txtReferencia = new Krypton.Toolkit.KryptonTextBox();
            txtNomeProduto = new Krypton.Toolkit.KryptonTextBox();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            pbImagem = new PictureBox();
            txtGtinEan = new Krypton.Toolkit.KryptonTextBox();
            label2 = new Label();
            txtFornecedor = new Krypton.Toolkit.KryptonTextBox();
            label3 = new Label();
            label6 = new Label();
            txtMarca = new Krypton.Toolkit.KryptonTextBox();
            label7 = new Label();
            label12 = new Label();
            btnLocalizarImagem = new Krypton.Toolkit.KryptonButton();
            txtEnderecoImagem = new Krypton.Toolkit.KryptonTextBox();
            label10 = new Label();
            txtDataValidade = new Krypton.Toolkit.KryptonTextBox();
            txtFornecedorID = new Krypton.Toolkit.KryptonTextBox();
            label5 = new Label();
            btnSair = new Krypton.Toolkit.KryptonButton();
            btnSalvar = new Krypton.Toolkit.KryptonButton();
            btnNovo = new Krypton.Toolkit.KryptonButton();
            pnlHeader = new Krypton.Toolkit.KryptonPanel();
            tlpTitulo = new Krypton.Toolkit.KryptonTableLayoutPanel();
            lblSubTitulo = new Krypton.Toolkit.KryptonLabel();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            cmbSituacao = new Krypton.Toolkit.KryptonComboBox();
            cmbStatus = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            cmbUnidade = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)pbImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).BeginInit();
            pnlHeader.SuspendLayout();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbSituacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbUnidade).BeginInit();
            SuspendLayout();
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top;
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Microsoft Sans Serif", 9.25F);
            label21.ForeColor = Color.FromArgb(0, 76, 172);
            label21.Location = new Point(20, 133);
            label21.Name = "label21";
            label21.Size = new Size(73, 16);
            label21.TabIndex = 236;
            label21.Text = "Referência";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.FromArgb(0, 76, 172);
            label23.Location = new Point(19, 86);
            label23.Name = "label23";
            label23.Size = new Size(57, 16);
            label23.TabIndex = 239;
            label23.Text = "Código";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Microsoft Sans Serif", 9.25F);
            label25.ForeColor = Color.FromArgb(0, 76, 172);
            label25.Location = new Point(98, 86);
            label25.Name = "label25";
            label25.Size = new Size(44, 16);
            label25.TabIndex = 234;
            label25.Text = "Nome";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = Color.Transparent;
            label27.Font = new Font("Microsoft Sans Serif", 9.25F);
            label27.ForeColor = Color.FromArgb(0, 76, 172);
            label27.Location = new Point(21, 306);
            label27.Name = "label27";
            label27.Size = new Size(99, 16);
            label27.TabIndex = 240;
            label27.Text = "Preço de Custo";
            // 
            // txtProdutoID
            // 
            txtProdutoID.Location = new Point(19, 105);
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
            txtProdutoID.TabIndex = 243;
            txtProdutoID.TabStop = false;
            txtProdutoID.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 9.25F);
            label1.ForeColor = Color.FromArgb(0, 76, 172);
            label1.Location = new Point(21, 353);
            label1.Name = "label1";
            label1.Size = new Size(57, 16);
            label1.TabIndex = 590;
            label1.Text = "Estoque";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 9.25F);
            label8.ForeColor = Color.FromArgb(0, 76, 172);
            label8.Location = new Point(345, 306);
            label8.Name = "label8";
            label8.Size = new Size(40, 16);
            label8.TabIndex = 596;
            label8.Text = "Lucro";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 9.25F);
            label9.ForeColor = Color.FromArgb(0, 76, 172);
            label9.Location = new Point(676, 306);
            label9.Name = "label9";
            label9.Size = new Size(105, 16);
            label9.TabIndex = 598;
            label9.Text = "Preço de Venda";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 9.25F);
            label11.ForeColor = Color.FromArgb(0, 76, 172);
            label11.Location = new Point(22, 436);
            label11.Name = "label11";
            label11.Size = new Size(44, 16);
            label11.TabIndex = 600;
            label11.Text = "Status";
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(21, 374);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(320, 24);
            txtEstoque.StateCommon.Back.Color1 = Color.White;
            txtEstoque.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtEstoque.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtEstoque.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtEstoque.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtEstoque.StateCommon.Border.Rounding = 8F;
            txtEstoque.StateCommon.Border.Width = 1;
            txtEstoque.StateCommon.Content.Color1 = Color.Gray;
            txtEstoque.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtEstoque.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtEstoque.TabIndex = 8;
            // 
            // txtPrecoDeVenda
            // 
            txtPrecoDeVenda.Location = new Point(670, 325);
            txtPrecoDeVenda.Name = "txtPrecoDeVenda";
            txtPrecoDeVenda.Size = new Size(320, 24);
            txtPrecoDeVenda.StateCommon.Back.Color1 = Color.White;
            txtPrecoDeVenda.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtPrecoDeVenda.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtPrecoDeVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPrecoDeVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPrecoDeVenda.StateCommon.Border.Rounding = 8F;
            txtPrecoDeVenda.StateCommon.Border.Width = 1;
            txtPrecoDeVenda.StateCommon.Content.Color1 = Color.Gray;
            txtPrecoDeVenda.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtPrecoDeVenda.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtPrecoDeVenda.TabIndex = 7;
            txtPrecoDeVenda.Leave += txtPrecoDeVenda_Leave;
            // 
            // txtLucro
            // 
            txtLucro.Location = new Point(345, 325);
            txtLucro.Name = "txtLucro";
            txtLucro.Size = new Size(320, 24);
            txtLucro.StateCommon.Back.Color1 = Color.White;
            txtLucro.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtLucro.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtLucro.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtLucro.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtLucro.StateCommon.Border.Rounding = 8F;
            txtLucro.StateCommon.Border.Width = 1;
            txtLucro.StateCommon.Content.Color1 = Color.Gray;
            txtLucro.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtLucro.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtLucro.TabIndex = 6;
            txtLucro.Enter += txtLucro_Enter;
            txtLucro.Leave += txtLucro_Leave;
            // 
            // txtPrecoCusto
            // 
            txtPrecoCusto.Location = new Point(21, 325);
            txtPrecoCusto.Name = "txtPrecoCusto";
            txtPrecoCusto.Size = new Size(320, 24);
            txtPrecoCusto.StateCommon.Back.Color1 = Color.White;
            txtPrecoCusto.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtPrecoCusto.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtPrecoCusto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPrecoCusto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPrecoCusto.StateCommon.Border.Rounding = 8F;
            txtPrecoCusto.StateCommon.Border.Width = 1;
            txtPrecoCusto.StateCommon.Content.Color1 = Color.Gray;
            txtPrecoCusto.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtPrecoCusto.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtPrecoCusto.TabIndex = 5;
            txtPrecoCusto.Enter += txtPrecoCusto_Enter;
            txtPrecoCusto.Leave += txtPrecoCusto_Leave;
            // 
            // txtReferencia
            // 
            txtReferencia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtReferencia.CharacterCasing = CharacterCasing.Upper;
            txtReferencia.Location = new Point(20, 154);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(320, 24);
            txtReferencia.StateCommon.Back.Color1 = Color.White;
            txtReferencia.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtReferencia.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtReferencia.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtReferencia.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtReferencia.StateCommon.Border.Rounding = 8F;
            txtReferencia.StateCommon.Border.Width = 1;
            txtReferencia.StateCommon.Content.Color1 = Color.Gray;
            txtReferencia.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtReferencia.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtReferencia.TabIndex = 1;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomeProduto.CharacterCasing = CharacterCasing.Upper;
            txtNomeProduto.Location = new Point(98, 105);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(895, 24);
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
            txtNomeProduto.TabIndex = 0;
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
            // pbImagem
            // 
            pbImagem.Location = new Point(878, 484);
            pbImagem.Name = "pbImagem";
            pbImagem.Size = new Size(118, 87);
            pbImagem.TabIndex = 610;
            pbImagem.TabStop = false;
            // 
            // txtGtinEan
            // 
            txtGtinEan.Location = new Point(345, 374);
            txtGtinEan.Name = "txtGtinEan";
            txtGtinEan.Size = new Size(320, 24);
            txtGtinEan.StateCommon.Back.Color1 = Color.White;
            txtGtinEan.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtGtinEan.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtGtinEan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtGtinEan.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtGtinEan.StateCommon.Border.Rounding = 8F;
            txtGtinEan.StateCommon.Border.Width = 1;
            txtGtinEan.StateCommon.Content.Color1 = Color.Gray;
            txtGtinEan.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtGtinEan.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtGtinEan.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 9.25F);
            label2.ForeColor = Color.FromArgb(0, 76, 172);
            label2.Location = new Point(345, 355);
            label2.Name = "label2";
            label2.Size = new Size(71, 16);
            label2.TabIndex = 612;
            label2.Text = "GTIN/EAN";
            // 
            // txtFornecedor
            // 
            txtFornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFornecedor.CharacterCasing = CharacterCasing.Upper;
            txtFornecedor.Location = new Point(115, 243);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(878, 24);
            txtFornecedor.StateCommon.Back.Color1 = Color.White;
            txtFornecedor.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtFornecedor.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtFornecedor.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtFornecedor.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtFornecedor.StateCommon.Border.Rounding = 8F;
            txtFornecedor.StateCommon.Border.Width = 1;
            txtFornecedor.StateCommon.Content.Color1 = Color.Gray;
            txtFornecedor.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtFornecedor.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtFornecedor.TabIndex = 4;
            txtFornecedor.TextChanged += txtFornecedor_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 9.25F);
            label3.ForeColor = Color.FromArgb(0, 76, 172);
            label3.Location = new Point(117, 224);
            label3.Name = "label3";
            label3.Size = new Size(77, 16);
            label3.TabIndex = 614;
            label3.Text = "Fornecedor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 9.25F);
            label6.ForeColor = Color.FromArgb(0, 76, 172);
            label6.Location = new Point(674, 353);
            label6.Name = "label6";
            label6.Size = new Size(91, 16);
            label6.TabIndex = 626;
            label6.Text = "DataValidade";
            // 
            // txtMarca
            // 
            txtMarca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMarca.CharacterCasing = CharacterCasing.Upper;
            txtMarca.Location = new Point(345, 154);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(320, 24);
            txtMarca.StateCommon.Back.Color1 = Color.White;
            txtMarca.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtMarca.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtMarca.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtMarca.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtMarca.StateCommon.Border.Rounding = 8F;
            txtMarca.StateCommon.Border.Width = 1;
            txtMarca.StateCommon.Content.Color1 = Color.Gray;
            txtMarca.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtMarca.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtMarca.TabIndex = 2;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 9.25F);
            label7.ForeColor = Color.FromArgb(0, 76, 172);
            label7.Location = new Point(345, 135);
            label7.Name = "label7";
            label7.Size = new Size(45, 16);
            label7.TabIndex = 624;
            label7.Text = "Marca";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft Sans Serif", 9.25F);
            label12.ForeColor = Color.FromArgb(0, 76, 172);
            label12.Location = new Point(670, 135);
            label12.Name = "label12";
            label12.Size = new Size(59, 16);
            label12.TabIndex = 620;
            label12.Text = "Unidade";
            // 
            // btnLocalizarImagem
            // 
            btnLocalizarImagem.CornerRoundingRadius = 10F;
            btnLocalizarImagem.Location = new Point(840, 536);
            btnLocalizarImagem.Name = "btnLocalizarImagem";
            btnLocalizarImagem.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnLocalizarImagem.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnLocalizarImagem.OverrideDefault.Back.ColorAngle = 45F;
            btnLocalizarImagem.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarImagem.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarImagem.OverrideDefault.Border.ColorAngle = 45F;
            btnLocalizarImagem.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarImagem.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarImagem.OverrideDefault.Border.Rounding = 20F;
            btnLocalizarImagem.OverrideDefault.Border.Width = 1;
            btnLocalizarImagem.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnLocalizarImagem.Size = new Size(30, 29);
            btnLocalizarImagem.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnLocalizarImagem.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnLocalizarImagem.StateCommon.Back.ColorAngle = 45F;
            btnLocalizarImagem.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarImagem.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarImagem.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarImagem.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarImagem.StateCommon.Border.Rounding = 10F;
            btnLocalizarImagem.StateCommon.Border.Width = 1;
            btnLocalizarImagem.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarImagem.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLocalizarImagem.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalizarImagem.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalizarImagem.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalizarImagem.StatePressed.Back.ColorAngle = 135F;
            btnLocalizarImagem.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalizarImagem.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalizarImagem.StatePressed.Border.ColorAngle = 135F;
            btnLocalizarImagem.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarImagem.StatePressed.Border.Rounding = 20F;
            btnLocalizarImagem.StatePressed.Border.Width = 1;
            btnLocalizarImagem.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarImagem.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnLocalizarImagem.StateTracking.Back.ColorAngle = 45F;
            btnLocalizarImagem.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarImagem.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarImagem.StateTracking.Border.ColorAngle = 45F;
            btnLocalizarImagem.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarImagem.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarImagem.StateTracking.Border.Rounding = 20F;
            btnLocalizarImagem.StateTracking.Border.Width = 1;
            btnLocalizarImagem.StateTracking.Content.ShortText.Color1 = Color.White;
            btnLocalizarImagem.TabIndex = 133;
            btnLocalizarImagem.TabStop = false;
            btnLocalizarImagem.Values.Image = Properties.Resources.Pesquisar;
            btnLocalizarImagem.Values.Text = "";
            btnLocalizarImagem.Click += btnLocalizarImagem_Click;
            // 
            // txtEnderecoImagem
            // 
            txtEnderecoImagem.CharacterCasing = CharacterCasing.Upper;
            txtEnderecoImagem.Location = new Point(18, 539);
            txtEnderecoImagem.Name = "txtEnderecoImagem";
            txtEnderecoImagem.Size = new Size(817, 24);
            txtEnderecoImagem.StateCommon.Back.Color1 = Color.White;
            txtEnderecoImagem.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtEnderecoImagem.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtEnderecoImagem.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtEnderecoImagem.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtEnderecoImagem.StateCommon.Border.Rounding = 8F;
            txtEnderecoImagem.StateCommon.Border.Width = 1;
            txtEnderecoImagem.StateCommon.Content.Color1 = Color.Gray;
            txtEnderecoImagem.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtEnderecoImagem.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtEnderecoImagem.TabIndex = 203;
            txtEnderecoImagem.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Sans Serif", 9.25F);
            label10.ForeColor = Color.FromArgb(0, 76, 172);
            label10.Location = new Point(509, 434);
            label10.Name = "label10";
            label10.Size = new Size(60, 16);
            label10.TabIndex = 1025;
            label10.Text = "Situação";
            // 
            // txtDataValidade
            // 
            txtDataValidade.Location = new Point(670, 374);
            txtDataValidade.Name = "txtDataValidade";
            txtDataValidade.Size = new Size(323, 24);
            txtDataValidade.StateCommon.Back.Color1 = Color.White;
            txtDataValidade.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtDataValidade.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtDataValidade.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDataValidade.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtDataValidade.StateCommon.Border.Rounding = 8F;
            txtDataValidade.StateCommon.Border.Width = 1;
            txtDataValidade.StateCommon.Content.Color1 = Color.Gray;
            txtDataValidade.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtDataValidade.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtDataValidade.TabIndex = 10;
            txtDataValidade.TextChanged += txtDataValidade_TextChanged;
            txtDataValidade.Leave += txtDataValidade_Leave;
            // 
            // txtFornecedorID
            // 
            txtFornecedorID.Location = new Point(21, 241);
            txtFornecedorID.Name = "txtFornecedorID";
            txtFornecedorID.ReadOnly = true;
            txtFornecedorID.Size = new Size(88, 24);
            txtFornecedorID.StateCommon.Back.Color1 = Color.White;
            txtFornecedorID.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtFornecedorID.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtFornecedorID.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtFornecedorID.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtFornecedorID.StateCommon.Border.Rounding = 8F;
            txtFornecedorID.StateCommon.Border.Width = 1;
            txtFornecedorID.StateCommon.Content.Color1 = Color.Gray;
            txtFornecedorID.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtFornecedorID.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtFornecedorID.TabIndex = 1028;
            txtFornecedorID.TabStop = false;
            txtFornecedorID.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 76, 172);
            label5.Location = new Point(21, 222);
            label5.Name = "label5";
            label5.Size = new Size(57, 16);
            label5.TabIndex = 1027;
            label5.Text = "Código";
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSair.CornerRoundingRadius = 20F;
            btnSair.Location = new Point(893, 626);
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
            btnSair.TabIndex = 1031;
            btnSair.TabStop = false;
            btnSair.Values.Text = "Sair";
            btnSair.Click += btnSair_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.CornerRoundingRadius = 20F;
            btnSalvar.Location = new Point(681, 626);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvar.OverrideDefault.Back.ColorAngle = 45F;
            btnSalvar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvar.OverrideDefault.Border.ColorAngle = 45F;
            btnSalvar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvar.OverrideDefault.Border.Rounding = 20F;
            btnSalvar.OverrideDefault.Border.Width = 1;
            btnSalvar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSalvar.Size = new Size(100, 30);
            btnSalvar.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvar.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvar.StateCommon.Back.ColorAngle = 45F;
            btnSalvar.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvar.StateCommon.Border.ColorAngle = 45F;
            btnSalvar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvar.StateCommon.Border.Rounding = 20F;
            btnSalvar.StateCommon.Border.Width = 1;
            btnSalvar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSalvar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSalvar.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            btnSalvar.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSalvar.StateNormal.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnSalvar.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvar.StateNormal.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSalvar.StateNormal.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSalvar.StateNormal.Border.ColorAngle = 45F;
            btnSalvar.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvar.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvar.StateNormal.Border.Rounding = 20F;
            btnSalvar.StateNormal.Border.Width = 1;
            btnSalvar.StatePressed.Back.Color1 = Color.White;
            btnSalvar.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnSalvar.StatePressed.Back.ColorAngle = 135F;
            btnSalvar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSalvar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSalvar.StatePressed.Border.ColorAngle = 135F;
            btnSalvar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvar.StatePressed.Border.Rounding = 20F;
            btnSalvar.StatePressed.Border.Width = 1;
            btnSalvar.StatePressed.Content.ShortText.Color1 = Color.FromArgb(22, 121, 206);
            btnSalvar.StateTracking.Back.Color1 = Color.White;
            btnSalvar.StateTracking.Back.Color2 = Color.White;
            btnSalvar.StateTracking.Back.ColorAngle = 45F;
            btnSalvar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvar.StateTracking.Border.ColorAngle = 45F;
            btnSalvar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvar.StateTracking.Border.Rounding = 20F;
            btnSalvar.StateTracking.Border.Width = 1;
            btnSalvar.StateTracking.Content.ShortText.Color1 = Color.FromArgb(22, 121, 206);
            btnSalvar.TabIndex = 11;
            btnSalvar.Values.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNovo.CornerRoundingRadius = 20F;
            btnNovo.Location = new Point(787, 626);
            btnNovo.Name = "btnNovo";
            btnNovo.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnNovo.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnNovo.OverrideDefault.Back.ColorAngle = 45F;
            btnNovo.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnNovo.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNovo.OverrideDefault.Border.ColorAngle = 45F;
            btnNovo.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.OverrideDefault.Border.Rounding = 20F;
            btnNovo.OverrideDefault.Border.Width = 1;
            btnNovo.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnNovo.Size = new Size(100, 30);
            btnNovo.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnNovo.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 250);
            btnNovo.StateCommon.Back.ColorAngle = 45F;
            btnNovo.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNovo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNovo.StateCommon.Border.ColorAngle = 45F;
            btnNovo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.StateCommon.Border.Rounding = 20F;
            btnNovo.StateCommon.Border.Width = 1;
            btnNovo.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnNovo.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            btnNovo.StateNormal.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnNovo.StateNormal.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnNovo.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.StateNormal.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnNovo.StateNormal.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnNovo.StateNormal.Border.ColorAngle = 45F;
            btnNovo.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.StateNormal.Border.Rounding = 20F;
            btnNovo.StateNormal.Border.Width = 1;
            btnNovo.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnNovo.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnNovo.StatePressed.Back.ColorAngle = 135F;
            btnNovo.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnNovo.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnNovo.StatePressed.Border.ColorAngle = 135F;
            btnNovo.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.StatePressed.Border.Rounding = 20F;
            btnNovo.StatePressed.Border.Width = 1;
            btnNovo.StatePressed.Content.ShortText.Color1 = Color.White;
            btnNovo.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnNovo.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnNovo.StateTracking.Back.ColorAngle = 45F;
            btnNovo.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNovo.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNovo.StateTracking.Border.ColorAngle = 45F;
            btnNovo.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.StateTracking.Border.Rounding = 20F;
            btnNovo.StateTracking.Border.Width = 1;
            btnNovo.StateTracking.Content.ShortText.Color1 = Color.White;
            btnNovo.TabIndex = 12;
            btnNovo.Values.Text = "Novo";
            btnNovo.Click += btnNovo_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(tlpTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1008, 47);
            pnlHeader.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            pnlHeader.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            pnlHeader.TabIndex = 1092;
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
            tlpTitulo.Size = new Size(1008, 47);
            tlpTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            tlpTitulo.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            tlpTitulo.TabIndex = 0;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.Dock = DockStyle.Fill;
            lblSubTitulo.Location = new Point(3, 25);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(1002, 19);
            lblSubTitulo.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Color2 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblSubTitulo.TabIndex = 0;
            lblSubTitulo.Values.Text = "Inclusão e manutenção de produtos";
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Location = new Point(3, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1002, 16);
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Color2 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 1091;
            lblTitulo.Values.Text = "Cadastro de Produtos";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(2, 58);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(155, 20);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 1038;
            kryptonLabel1.Values.Text = "Identificação do produto";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(2, 198);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(76, 20);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 1038;
            kryptonLabel2.TabStop = false;
            kryptonLabel2.Values.Text = "Fornecedor";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(2, 282);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(103, 20);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 1038;
            kryptonLabel3.TabStop = false;
            kryptonLabel3.Values.Text = "Preço e Estoque";
            // 
            // cmbSituacao
            // 
            cmbSituacao.CornerRoundingRadius = 6F;
            cmbSituacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSituacao.DropDownWidth = 115;
            cmbSituacao.IntegralHeight = false;
            cmbSituacao.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cmbSituacao.Location = new Point(509, 453);
            cmbSituacao.Name = "cmbSituacao";
            cmbSituacao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbSituacao.Size = new Size(487, 25);
            cmbSituacao.StateActive.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbSituacao.StateActive.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbSituacao.StateActive.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbSituacao.StateActive.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbSituacao.StateActive.ComboBox.Content.Color1 = Color.White;
            cmbSituacao.StateActive.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbSituacao.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbSituacao.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbSituacao.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbSituacao.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbSituacao.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbSituacao.StateCommon.ComboBox.Content.Color1 = Color.White;
            cmbSituacao.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbSituacao.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbSituacao.StateNormal.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbSituacao.StateNormal.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbSituacao.StateNormal.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbSituacao.StateNormal.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbSituacao.StateNormal.ComboBox.Content.Color1 = Color.White;
            cmbSituacao.StateNormal.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbSituacao.StateTracking.Item.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbSituacao.StateTracking.Item.Back.Color2 = Color.FromArgb(30, 136, 229);
            cmbSituacao.StateTracking.Item.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbSituacao.StateTracking.Item.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbSituacao.StateTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbSituacao.StateTracking.Item.Content.ShortText.Color1 = Color.White;
            cmbSituacao.StateTracking.Item.Content.ShortText.Color2 = Color.White;
            cmbSituacao.StateTracking.Item.Content.ShortText.Font = new Font("Segoe UI", 9F);
            cmbSituacao.TabIndex = 1068;
            cmbSituacao.TabStop = false;
            // 
            // cmbStatus
            // 
            cmbStatus.CornerRoundingRadius = 6F;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.DropDownWidth = 115;
            cmbStatus.IntegralHeight = false;
            cmbStatus.Items.AddRange(new object[] { "Descontinuado", "Disponível", "Em Espera", "Em Produção", "Indisponível" });
            cmbStatus.Location = new Point(18, 454);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbStatus.Size = new Size(487, 25);
            cmbStatus.StateActive.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbStatus.StateActive.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbStatus.StateActive.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbStatus.StateActive.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbStatus.StateActive.ComboBox.Content.Color1 = Color.White;
            cmbStatus.StateActive.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbStatus.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbStatus.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbStatus.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbStatus.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbStatus.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbStatus.StateCommon.ComboBox.Content.Color1 = Color.White;
            cmbStatus.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbStatus.StateNormal.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbStatus.StateNormal.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbStatus.StateNormal.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbStatus.StateNormal.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbStatus.StateNormal.ComboBox.Content.Color1 = Color.White;
            cmbStatus.StateNormal.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbStatus.StateTracking.Item.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbStatus.StateTracking.Item.Back.Color2 = Color.FromArgb(30, 136, 229);
            cmbStatus.StateTracking.Item.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbStatus.StateTracking.Item.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbStatus.StateTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbStatus.StateTracking.Item.Content.ShortText.Color1 = Color.White;
            cmbStatus.StateTracking.Item.Content.ShortText.Color2 = Color.White;
            cmbStatus.StateTracking.Item.Content.ShortText.Font = new Font("Segoe UI", 9F);
            cmbStatus.TabIndex = 1067;
            cmbStatus.TabStop = false;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(2, 410);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(110, 20);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel4.TabIndex = 1038;
            kryptonLabel4.TabStop = false;
            kryptonLabel4.Values.Text = "Status e Situação";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(6, 511);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(128, 20);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel5.TabIndex = 1038;
            kryptonLabel5.TabStop = false;
            kryptonLabel5.Values.Text = "Imagem do Produto";
            // 
            // cmbUnidade
            // 
            cmbUnidade.CornerRoundingRadius = 6F;
            cmbUnidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnidade.DropDownWidth = 115;
            cmbUnidade.IntegralHeight = false;
            cmbUnidade.Items.AddRange(new object[] { "UN", "CX", "PC", "KG", "GR", "MT", "" });
            cmbUnidade.Location = new Point(671, 153);
            cmbUnidade.Name = "cmbUnidade";
            cmbUnidade.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbUnidade.Size = new Size(322, 25);
            cmbUnidade.StateActive.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbUnidade.StateActive.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbUnidade.StateActive.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbUnidade.StateActive.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbUnidade.StateActive.ComboBox.Content.Color1 = Color.White;
            cmbUnidade.StateActive.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbUnidade.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbUnidade.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbUnidade.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbUnidade.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbUnidade.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbUnidade.StateCommon.ComboBox.Content.Color1 = Color.White;
            cmbUnidade.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbUnidade.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbUnidade.StateNormal.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbUnidade.StateNormal.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbUnidade.StateNormal.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbUnidade.StateNormal.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbUnidade.StateNormal.ComboBox.Content.Color1 = Color.White;
            cmbUnidade.StateNormal.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbUnidade.StateTracking.Item.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbUnidade.StateTracking.Item.Back.Color2 = Color.FromArgb(30, 136, 229);
            cmbUnidade.StateTracking.Item.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbUnidade.StateTracking.Item.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbUnidade.StateTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbUnidade.StateTracking.Item.Content.ShortText.Color1 = Color.White;
            cmbUnidade.StateTracking.Item.Content.ShortText.Color2 = Color.White;
            cmbUnidade.StateTracking.Item.Content.ShortText.Font = new Font("Segoe UI", 9F);
            cmbUnidade.TabIndex = 3;
            cmbUnidade.Text = "UN";
            // 
            // FrmCadProdutos
            // 
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(1008, 661);
            Controls.Add(cmbUnidade);
            Controls.Add(cmbSituacao);
            Controls.Add(cmbStatus);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel5);
            Controls.Add(kryptonLabel4);
            Controls.Add(txtFornecedorID);
            Controls.Add(txtDataValidade);
            Controls.Add(label5);
            Controls.Add(pnlHeader);
            Controls.Add(btnSair);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(btnLocalizarImagem);
            Controls.Add(txtMarca);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(pbImagem);
            Controls.Add(txtNomeProduto);
            Controls.Add(txtEnderecoImagem);
            Controls.Add(label25);
            Controls.Add(txtFornecedor);
            Controls.Add(label12);
            Controls.Add(label3);
            Controls.Add(label23);
            Controls.Add(txtGtinEan);
            Controls.Add(txtProdutoID);
            Controls.Add(label11);
            Controls.Add(txtReferencia);
            Controls.Add(label21);
            Controls.Add(txtPrecoCusto);
            Controls.Add(label2);
            Controls.Add(txtLucro);
            Controls.Add(label1);
            Controls.Add(label27);
            Controls.Add(txtPrecoDeVenda);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txtEstoque);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadProdutos";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produtos";
            Load += FrmCadProdutos_Load;
            Shown += FrmCadProdutos_Shown;
            KeyDown += FrmCadProdutos_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pbImagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).EndInit();
            pnlHeader.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbSituacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbUnidade).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        public Krypton.Toolkit.KryptonTextBox txtProdutoID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        public Krypton.Toolkit.KryptonDateTimePicker dtpDataDeEntrada;
        public Krypton.Toolkit.KryptonTextBox txtEstoque;
        public Krypton.Toolkit.KryptonTextBox txtPrecoDeVenda;
        public Krypton.Toolkit.KryptonTextBox txtLucro;
        public Krypton.Toolkit.KryptonTextBox txtPrecoCusto;
        public Krypton.Toolkit.KryptonTextBox txtReferencia;
        public Krypton.Toolkit.KryptonTextBox txtNomeProduto;
        public Krypton.Toolkit.KryptonTextBox txtGtinEan;
        public Krypton.Toolkit.KryptonTextBox txtMarca;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Label label2;
        public Krypton.Toolkit.KryptonTextBox txtFornecedor;
        private Label label3;
        private Label label6;        
        private Label label7;
        private Label label12;
        public Krypton.Toolkit.KryptonButton btnLocalizarImagem;
        public Krypton.Toolkit.KryptonTextBox txtEnderecoImagem;
        private Label label10;
        public Krypton.Toolkit.KryptonTextBox txtDataValidade;        
        public Krypton.Toolkit.KryptonComboBox cmbSituacao;
        public PictureBox pbImagem;
        public Krypton.Toolkit.KryptonTextBox txtFornecedorID;
        private Label label5;
        public Krypton.Toolkit.KryptonButton btnSair;
        public Krypton.Toolkit.KryptonButton btnSalvar;
        public Krypton.Toolkit.KryptonButton btnNovo;
        private Krypton.Toolkit.KryptonPanel pnlHeader;
        private Krypton.Toolkit.KryptonTableLayoutPanel tlpTitulo;
        private Krypton.Toolkit.KryptonLabel lblSubTitulo;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        public Krypton.Toolkit.KryptonComboBox cmbStatus;
        public Krypton.Toolkit.KryptonComboBox cmbUnidade;
        //private System.Windows.Forms.DateTimePicker dtpDataDeEntrada;
    }
}
