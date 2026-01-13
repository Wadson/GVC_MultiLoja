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
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            trocarEmpresaToolStripMenuItem = new ToolStripMenuItem();
            backupToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            formaDePagamentoToolStripMenuItem = new ToolStripMenuItem();
            empresasToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem1 = new ToolStripMenuItem();
            entradaDeEstoqueNFeOuManualToolStripMenuItem = new ToolStripMenuItem();
            correçãoDeEstoqueToolStripMenuItem = new ToolStripMenuItem();
            vendasToolStripMenuItem = new ToolStripMenuItem();
            pDVToolStripMenuItem = new ToolStripMenuItem();
            orçamentosToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            financeiroToolStripMenuItem = new ToolStripMenuItem();
            contasAReceberToolStripMenuItem = new ToolStripMenuItem();
            contasAPagarToolStripMenuItem = new ToolStripMenuItem();
            caixaToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            vendasToolStripMenuItem1 = new ToolStripMenuItem();
            financeiroToolStripMenuItem1 = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem1 = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem1 = new ToolStripMenuItem();
            parâmetrosToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnUsuarios = new ToolStripButton();
            btnClientes = new ToolStripButton();
            btnFornecedor = new ToolStripButton();
            btnProdutos = new ToolStripButton();
            btnPDV = new ToolStripButton();
            btnContasAReceber = new ToolStripButton();
            btnCaixa = new ToolStripButton();
            btnEstoque = new ToolStripButton();
            btnRelatorios = new ToolStripButton();
            btnBackup = new ToolStripButton();
            btnSair = new ToolStripButton();
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            lblEstacao = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            lblData = new ToolStripStatusLabel();
            lblHoraAtual = new ToolStripStatusLabel();
            toolStripStatusLabel5 = new ToolStripStatusLabel();
            lblUsuarioLogadoo = new ToolStripStatusLabel();
            toolStripStatusLabel6 = new ToolStripStatusLabel();
            lblTipoUsuarioo = new ToolStripStatusLabel();
            toolStripStatusLabel8 = new ToolStripStatusLabel();
            lblAmbienteStatus = new ToolStripStatusLabel();
            picBackground = new PictureBox();
            panelBackground = new Panel();
            kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            timerBackupAtomatico = new System.Windows.Forms.Timer(components);
            btnFerramentas = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            kryptonStatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBackground).BeginInit();
            panelBackground.SuspendLayout();
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
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(8, 142, 254);
            menuStrip1.Font = new Font("Segoe UI", 9F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, cadastrosToolStripMenuItem, estoqueToolStripMenuItem1, vendasToolStripMenuItem, financeiroToolStripMenuItem, relatóriosToolStripMenuItem, configuraçõesToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(829, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { trocarEmpresaToolStripMenuItem, backupToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // trocarEmpresaToolStripMenuItem
            // 
            trocarEmpresaToolStripMenuItem.Name = "trocarEmpresaToolStripMenuItem";
            trocarEmpresaToolStripMenuItem.Size = new Size(155, 22);
            trocarEmpresaToolStripMenuItem.Text = "Trocar Empresa";
            trocarEmpresaToolStripMenuItem.Click += trocarEmpresaToolStripMenuItem_Click;
            // 
            // backupToolStripMenuItem
            // 
            backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            backupToolStripMenuItem.Size = new Size(155, 22);
            backupToolStripMenuItem.Text = "Backup";
            backupToolStripMenuItem.Click += backupToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(155, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, produtosToolStripMenuItem, fornecedoresToolStripMenuItem, formaDePagamentoToolStripMenuItem, empresasToolStripMenuItem, usuáriosToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(188, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(188, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(188, 22);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            fornecedoresToolStripMenuItem.Click += fornecedoresToolStripMenuItem_Click;
            // 
            // formaDePagamentoToolStripMenuItem
            // 
            formaDePagamentoToolStripMenuItem.Name = "formaDePagamentoToolStripMenuItem";
            formaDePagamentoToolStripMenuItem.Size = new Size(188, 22);
            formaDePagamentoToolStripMenuItem.Text = "Forma de Pagamento";
            formaDePagamentoToolStripMenuItem.Click += formaDePagamentoToolStripMenuItem_Click;
            // 
            // empresasToolStripMenuItem
            // 
            empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            empresasToolStripMenuItem.Size = new Size(188, 22);
            empresasToolStripMenuItem.Text = "Empresas";
            empresasToolStripMenuItem.Click += empresasToolStripMenuItem_Click;
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(188, 22);
            usuáriosToolStripMenuItem.Text = "Usuários";
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // estoqueToolStripMenuItem1
            // 
            estoqueToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { entradaDeEstoqueNFeOuManualToolStripMenuItem, correçãoDeEstoqueToolStripMenuItem });
            estoqueToolStripMenuItem1.Name = "estoqueToolStripMenuItem1";
            estoqueToolStripMenuItem1.Size = new Size(61, 20);
            estoqueToolStripMenuItem1.Text = "Estoque";
            // 
            // entradaDeEstoqueNFeOuManualToolStripMenuItem
            // 
            entradaDeEstoqueNFeOuManualToolStripMenuItem.Name = "entradaDeEstoqueNFeOuManualToolStripMenuItem";
            entradaDeEstoqueNFeOuManualToolStripMenuItem.Size = new Size(264, 22);
            entradaDeEstoqueNFeOuManualToolStripMenuItem.Text = "Entrada de Estoque(NFe ou Manual)";
            // 
            // correçãoDeEstoqueToolStripMenuItem
            // 
            correçãoDeEstoqueToolStripMenuItem.Name = "correçãoDeEstoqueToolStripMenuItem";
            correçãoDeEstoqueToolStripMenuItem.Size = new Size(264, 22);
            correçãoDeEstoqueToolStripMenuItem.Text = "Entrada de Estoque";
            correçãoDeEstoqueToolStripMenuItem.Click += correçãoDeEstoqueToolStripMenuItem_Click_1;
            // 
            // vendasToolStripMenuItem
            // 
            vendasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pDVToolStripMenuItem, orçamentosToolStripMenuItem, pedidosToolStripMenuItem });
            vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            vendasToolStripMenuItem.Size = new Size(56, 20);
            vendasToolStripMenuItem.Text = "Vendas";
            // 
            // pDVToolStripMenuItem
            // 
            pDVToolStripMenuItem.Name = "pDVToolStripMenuItem";
            pDVToolStripMenuItem.Size = new Size(139, 22);
            pDVToolStripMenuItem.Text = "PDV";
            pDVToolStripMenuItem.Click += pDVToolStripMenuItem_Click;
            // 
            // orçamentosToolStripMenuItem
            // 
            orçamentosToolStripMenuItem.Name = "orçamentosToolStripMenuItem";
            orçamentosToolStripMenuItem.Size = new Size(139, 22);
            orçamentosToolStripMenuItem.Text = "Orçamentos";
            orçamentosToolStripMenuItem.Click += orçamentosToolStripMenuItem_Click;
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(139, 22);
            pedidosToolStripMenuItem.Text = "Pedidos";
            pedidosToolStripMenuItem.Click += pedidosToolStripMenuItem_Click;
            // 
            // financeiroToolStripMenuItem
            // 
            financeiroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contasAReceberToolStripMenuItem, contasAPagarToolStripMenuItem, caixaToolStripMenuItem });
            financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            financeiroToolStripMenuItem.Size = new Size(74, 20);
            financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // contasAReceberToolStripMenuItem
            // 
            contasAReceberToolStripMenuItem.Name = "contasAReceberToolStripMenuItem";
            contasAReceberToolStripMenuItem.Size = new Size(165, 22);
            contasAReceberToolStripMenuItem.Text = "Contas a Receber";
            contasAReceberToolStripMenuItem.Click += contasAReceberToolStripMenuItem_Click;
            // 
            // contasAPagarToolStripMenuItem
            // 
            contasAPagarToolStripMenuItem.Name = "contasAPagarToolStripMenuItem";
            contasAPagarToolStripMenuItem.Size = new Size(165, 22);
            contasAPagarToolStripMenuItem.Text = "Contas a Pagar";
            contasAPagarToolStripMenuItem.Click += contasAPagarToolStripMenuItem_Click;
            // 
            // caixaToolStripMenuItem
            // 
            caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            caixaToolStripMenuItem.Size = new Size(165, 22);
            caixaToolStripMenuItem.Text = "Caixa";
            caixaToolStripMenuItem.Click += caixaToolStripMenuItem_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vendasToolStripMenuItem1, financeiroToolStripMenuItem1, estoqueToolStripMenuItem, produtosToolStripMenuItem1 });
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // vendasToolStripMenuItem1
            // 
            vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            vendasToolStripMenuItem1.Size = new Size(129, 22);
            vendasToolStripMenuItem1.Text = "Vendas";
            vendasToolStripMenuItem1.Click += vendasToolStripMenuItem1_Click;
            // 
            // financeiroToolStripMenuItem1
            // 
            financeiroToolStripMenuItem1.Name = "financeiroToolStripMenuItem1";
            financeiroToolStripMenuItem1.Size = new Size(129, 22);
            financeiroToolStripMenuItem1.Text = "Financeiro";
            financeiroToolStripMenuItem1.Click += financeiroToolStripMenuItem1_Click;
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(129, 22);
            estoqueToolStripMenuItem.Text = "Estoque";
            estoqueToolStripMenuItem.Click += estoqueToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem1
            // 
            produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            produtosToolStripMenuItem1.Size = new Size(129, 22);
            produtosToolStripMenuItem1.Text = "Produtos";
            produtosToolStripMenuItem1.Click += produtosToolStripMenuItem1_Click;
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuáriosToolStripMenuItem1, parâmetrosToolStripMenuItem });
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(96, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // usuáriosToolStripMenuItem1
            // 
            usuáriosToolStripMenuItem1.Name = "usuáriosToolStripMenuItem1";
            usuáriosToolStripMenuItem1.Size = new Size(134, 22);
            usuáriosToolStripMenuItem1.Text = "Usuários";
            usuáriosToolStripMenuItem1.Click += usuáriosToolStripMenuItem1_Click;
            // 
            // parâmetrosToolStripMenuItem
            // 
            parâmetrosToolStripMenuItem.Name = "parâmetrosToolStripMenuItem";
            parâmetrosToolStripMenuItem.Size = new Size(134, 22);
            parâmetrosToolStripMenuItem.Text = "Parâmetros";
            parâmetrosToolStripMenuItem.Click += parâmetrosToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(104, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(6, 174, 244);
            toolStrip1.Font = new Font("Segoe UI", 9F);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnUsuarios, btnClientes, btnFornecedor, btnProdutos, btnPDV, btnContasAReceber, btnCaixa, btnEstoque, btnRelatorios, btnFerramentas, btnBackup, btnSair });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(829, 54);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnUsuarios
            // 
            btnUsuarios.AutoSize = false;
            btnUsuarios.BackgroundImageLayout = ImageLayout.None;
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = ContentAlignment.TopCenter;
            btnUsuarios.ImageTransparentColor = Color.Magenta;
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(63, 51);
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.BottomCenter;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnClientes
            // 
            btnClientes.AutoSize = false;
            btnClientes.BackgroundImageLayout = ImageLayout.None;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.TopCenter;
            btnClientes.ImageTransparentColor = Color.Magenta;
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(63, 51);
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.BottomCenter;
            btnClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnFornecedor
            // 
            btnFornecedor.AutoSize = false;
            btnFornecedor.BackgroundImageLayout = ImageLayout.Center;
            btnFornecedor.Image = (Image)resources.GetObject("btnFornecedor.Image");
            btnFornecedor.ImageAlign = ContentAlignment.TopCenter;
            btnFornecedor.ImageTransparentColor = Color.Magenta;
            btnFornecedor.Name = "btnFornecedor";
            btnFornecedor.Size = new Size(63, 51);
            btnFornecedor.Text = "Fornecedor";
            btnFornecedor.TextAlign = ContentAlignment.BottomCenter;
            btnFornecedor.TextImageRelation = TextImageRelation.ImageAboveText;
            btnFornecedor.Click += btnFornecedor_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.AutoSize = false;
            btnProdutos.BackgroundImageLayout = ImageLayout.Center;
            btnProdutos.Image = (Image)resources.GetObject("btnProdutos.Image");
            btnProdutos.ImageAlign = ContentAlignment.TopCenter;
            btnProdutos.ImageTransparentColor = Color.Magenta;
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(63, 51);
            btnProdutos.Text = "Produtos";
            btnProdutos.TextAlign = ContentAlignment.BottomCenter;
            btnProdutos.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnPDV
            // 
            btnPDV.AutoSize = false;
            btnPDV.BackgroundImageLayout = ImageLayout.Center;
            btnPDV.Image = (Image)resources.GetObject("btnPDV.Image");
            btnPDV.ImageAlign = ContentAlignment.TopCenter;
            btnPDV.ImageTransparentColor = Color.Magenta;
            btnPDV.Name = "btnPDV";
            btnPDV.Size = new Size(63, 51);
            btnPDV.Text = "PDV";
            btnPDV.TextAlign = ContentAlignment.BottomCenter;
            btnPDV.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPDV.Click += btnPDV_Click;
            // 
            // btnContasAReceber
            // 
            btnContasAReceber.AutoSize = false;
            btnContasAReceber.BackgroundImageLayout = ImageLayout.Center;
            btnContasAReceber.Image = (Image)resources.GetObject("btnContasAReceber.Image");
            btnContasAReceber.ImageAlign = ContentAlignment.TopCenter;
            btnContasAReceber.ImageTransparentColor = Color.Magenta;
            btnContasAReceber.Name = "btnContasAReceber";
            btnContasAReceber.Size = new Size(63, 51);
            btnContasAReceber.Text = "Receber";
            btnContasAReceber.TextAlign = ContentAlignment.BottomCenter;
            btnContasAReceber.TextImageRelation = TextImageRelation.ImageAboveText;
            btnContasAReceber.Click += btnContasAReceber_Click;
            // 
            // btnCaixa
            // 
            btnCaixa.AutoSize = false;
            btnCaixa.BackgroundImageLayout = ImageLayout.Center;
            btnCaixa.Image = (Image)resources.GetObject("btnCaixa.Image");
            btnCaixa.ImageAlign = ContentAlignment.TopCenter;
            btnCaixa.ImageTransparentColor = Color.Magenta;
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Size = new Size(63, 51);
            btnCaixa.Text = "Caixa";
            btnCaixa.TextAlign = ContentAlignment.BottomCenter;
            btnCaixa.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCaixa.Click += btnCaixa_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.AutoSize = false;
            btnEstoque.BackgroundImageLayout = ImageLayout.Center;
            btnEstoque.Image = (Image)resources.GetObject("btnEstoque.Image");
            btnEstoque.ImageAlign = ContentAlignment.TopCenter;
            btnEstoque.ImageTransparentColor = Color.Magenta;
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(63, 51);
            btnEstoque.Text = "Estoque";
            btnEstoque.TextAlign = ContentAlignment.BottomCenter;
            btnEstoque.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // btnRelatorios
            // 
            btnRelatorios.AutoSize = false;
            btnRelatorios.Image = (Image)resources.GetObject("btnRelatorios.Image");
            btnRelatorios.ImageAlign = ContentAlignment.TopCenter;
            btnRelatorios.ImageTransparentColor = Color.Magenta;
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(63, 51);
            btnRelatorios.Text = "Relatórios";
            btnRelatorios.TextAlign = ContentAlignment.BottomCenter;
            btnRelatorios.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRelatorios.Click += btnRelatorios_Click;
            // 
            // btnBackup
            // 
            btnBackup.AutoSize = false;
            btnBackup.Image = (Image)resources.GetObject("btnBackup.Image");
            btnBackup.ImageAlign = ContentAlignment.TopCenter;
            btnBackup.ImageTransparentColor = Color.Magenta;
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(63, 51);
            btnBackup.Text = "Backup";
            btnBackup.TextAlign = ContentAlignment.BottomCenter;
            btnBackup.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnSair
            // 
            btnSair.Alignment = ToolStripItemAlignment.Right;
            btnSair.AutoSize = false;
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageAlign = ContentAlignment.TopCenter;
            btnSair.ImageTransparentColor = Color.Magenta;
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(63, 51);
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.BottomCenter;
            btnSair.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSair.Click += btnSair_Click;
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.BackColor = Color.FromArgb(6, 174, 244);
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Items.AddRange(new ToolStripItem[] { lblEstacao, toolStripStatusLabel4, lblData, lblHoraAtual, toolStripStatusLabel5, lblUsuarioLogadoo, toolStripStatusLabel6, lblTipoUsuarioo, toolStripStatusLabel8, lblAmbienteStatus });
            kryptonStatusStrip1.Location = new Point(0, 408);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.Professional;
            kryptonStatusStrip1.Size = new Size(829, 22);
            kryptonStatusStrip1.TabIndex = 609;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // lblEstacao
            // 
            lblEstacao.Name = "lblEstacao";
            lblEstacao.Size = new Size(12, 17);
            lblEstacao.Text = "-";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(10, 17);
            toolStripStatusLabel4.Text = "|";
            // 
            // lblData
            // 
            lblData.Name = "lblData";
            lblData.Size = new Size(31, 17);
            lblData.Text = "Data";
            // 
            // lblHoraAtual
            // 
            lblHoraAtual.Name = "lblHoraAtual";
            lblHoraAtual.Size = new Size(33, 17);
            lblHoraAtual.Text = "Hora";
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new Size(10, 17);
            toolStripStatusLabel5.Text = "|";
            // 
            // lblUsuarioLogadoo
            // 
            lblUsuarioLogadoo.Name = "lblUsuarioLogadoo";
            lblUsuarioLogadoo.Size = new Size(100, 17);
            lblUsuarioLogadoo.Text = "lblUsuarioLogado";
            // 
            // toolStripStatusLabel6
            // 
            toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            toolStripStatusLabel6.Size = new Size(10, 17);
            toolStripStatusLabel6.Text = "|";
            // 
            // lblTipoUsuarioo
            // 
            lblTipoUsuarioo.Name = "lblTipoUsuarioo";
            lblTipoUsuarioo.Size = new Size(84, 17);
            lblTipoUsuarioo.Text = "lblTipoUsuario";
            // 
            // toolStripStatusLabel8
            // 
            toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            toolStripStatusLabel8.Size = new Size(16, 17);
            toolStripStatusLabel8.Text = " | ";
            // 
            // lblAmbienteStatus
            // 
            lblAmbienteStatus.Name = "lblAmbienteStatus";
            lblAmbienteStatus.Size = new Size(59, 17);
            lblAmbienteStatus.Text = "Ambiente";
            // 
            // picBackground
            // 
            picBackground.Dock = DockStyle.Fill;
            picBackground.Enabled = false;
            picBackground.Image = (Image)resources.GetObject("picBackground.Image");
            picBackground.Location = new Point(0, 0);
            picBackground.Name = "picBackground";
            picBackground.Size = new Size(829, 330);
            picBackground.SizeMode = PictureBoxSizeMode.Zoom;
            picBackground.TabIndex = 610;
            picBackground.TabStop = false;
            // 
            // panelBackground
            // 
            panelBackground.Controls.Add(picBackground);
            panelBackground.Dock = DockStyle.Fill;
            panelBackground.Location = new Point(0, 78);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(829, 330);
            panelBackground.TabIndex = 611;
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // timerBackupAtomatico
            // 
            timerBackupAtomatico.Interval = 1000;
            timerBackupAtomatico.Tick += timerBackupAtomatico_Tick;
            // 
            // btnFerramentas
            // 
            btnFerramentas.AutoSize = false;
            btnFerramentas.Image = (Image)resources.GetObject("btnFerramentas.Image");
            btnFerramentas.ImageAlign = ContentAlignment.TopCenter;
            btnFerramentas.ImageTransparentColor = Color.Magenta;
            btnFerramentas.Name = "btnFerramentas";
            btnFerramentas.Size = new Size(63, 51);
            btnFerramentas.Text = "Ferram.";
            btnFerramentas.TextAlign = ContentAlignment.BottomCenter;
            btnFerramentas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnFerramentas.Click += btnFerramentas_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(250, 252, 252);
            ClientSize = new Size(829, 430);
            Controls.Add(panelBackground);
            Controls.Add(kryptonStatusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmPrincipal";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "SGVendas - Sistema de Gestão Comercial ";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            kryptonStatusStrip1.ResumeLayout(false);
            kryptonStatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBackground).EndInit();
            panelBackground.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem trocarEmpresaToolStripMenuItem;
        private ToolStripMenuItem backupToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem empresasToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem pDVToolStripMenuItem;
        private ToolStripMenuItem orçamentosToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem financeiroToolStripMenuItem;
        private ToolStripMenuItem contasAReceberToolStripMenuItem;
        private ToolStripMenuItem contasAPagarToolStripMenuItem;
        private ToolStripMenuItem caixaToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem1;
        private ToolStripMenuItem financeiroToolStripMenuItem1;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem1;
        private ToolStripMenuItem parâmetrosToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnClientes;
        private ToolStripButton btnProdutos;
        private ToolStripButton btnPDV;
        private ToolStripButton btnCaixa;
        private ToolStripButton btnEstoque;
        private ToolStripButton btnRelatorios;
        private ToolStripButton btnBackup;
        private ToolStripButton btnSair;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        private ToolStripStatusLabel lblEstacao;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel lblData;
        private ToolStripStatusLabel lblHoraAtual;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel lblUsuarioLogadoo;
        private ToolStripStatusLabel toolStripStatusLabel6;
        private ToolStripStatusLabel lblTipoUsuarioo;
        private ToolStripStatusLabel toolStripStatusLabel8;
        private ToolStripStatusLabel lblAmbienteStatus;
        private PictureBox picBackground;
        private Panel panelBackground;
        private ToolStripButton btnUsuarios;
        private ToolStripButton btnFornecedor;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private ToolStripButton btnContasAReceber;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.Timer timerBackupAtomatico;
        private ToolStripMenuItem estoqueToolStripMenuItem1;
        private ToolStripMenuItem entradaDeEstoqueNFeOuManualToolStripMenuItem;
        private ToolStripMenuItem correçãoDeEstoqueToolStripMenuItem;
        private ToolStripMenuItem formaDePagamentoToolStripMenuItem;
        private ToolStripButton btnFerramentas;
    }
}