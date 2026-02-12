namespace GVC.View
{
    partial class FrmManutProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManutProduto));
            timer1 = new System.Windows.Forms.Timer(components);
            dgvProdutos = new Krypton.Toolkit.KryptonDataGridView();
            btnEstoque = new Krypton.Toolkit.KryptonButton();
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            lblMensagemStatus = new ToolStripStatusLabel();
            btnSair = new Krypton.Toolkit.KryptonButton();
            btnExcluir = new Krypton.Toolkit.KryptonButton();
            btnNovo = new Krypton.Toolkit.KryptonButton();
            btnAlterar = new Krypton.Toolkit.KryptonButton();
            txtPesquisa = new Krypton.Toolkit.KryptonTextBox();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            tableLayoutPanel2 = new TableLayoutPanel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            pnlHeader = new Krypton.Toolkit.KryptonPanel();
            tlpTitulo = new Krypton.Toolkit.KryptonTableLayoutPanel();
            lblSubTitulo = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            iconAcao = new FontAwesome.Sharp.IconPictureBox();
            kryptonPanel5 = new Krypton.Toolkit.KryptonPanel();
            pictureBox1 = new PictureBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel6 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            kryptonStatusStrip1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).BeginInit();
            pnlHeader.SuspendLayout();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconAcao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).BeginInit();
            kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel6).BeginInit();
            kryptonPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersHeight = 20;
            dgvProdutos.Dock = DockStyle.Fill;
            dgvProdutos.Location = new Point(4, 111);
            dgvProdutos.Margin = new Padding(4, 3, 4, 3);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.PaletteMode = Krypton.Toolkit.PaletteMode.Office365White;
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersWidth = 20;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(1000, 385);
            dgvProdutos.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvProdutos.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dgvProdutos.TabIndex = 597;
            dgvProdutos.TabStop = false;
            // 
            // btnEstoque
            // 
            btnEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEstoque.CornerRoundingRadius = 10F;
            btnEstoque.Location = new Point(536, 3);
            btnEstoque.Margin = new Padding(4, 3, 4, 3);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnEstoque.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnEstoque.OverrideDefault.Back.ColorAngle = 45F;
            btnEstoque.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnEstoque.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnEstoque.OverrideDefault.Border.ColorAngle = 45F;
            btnEstoque.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEstoque.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnEstoque.OverrideDefault.Border.Rounding = 20F;
            btnEstoque.OverrideDefault.Border.Width = 1;
            btnEstoque.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnEstoque.Size = new Size(88, 27);
            btnEstoque.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnEstoque.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnEstoque.StateCommon.Back.ColorAngle = 45F;
            btnEstoque.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnEstoque.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnEstoque.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEstoque.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnEstoque.StateCommon.Border.Rounding = 10F;
            btnEstoque.StateCommon.Border.Width = 1;
            btnEstoque.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnEstoque.StateCommon.Content.ShortText.Color2 = Color.White;
            btnEstoque.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F);
            btnEstoque.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnEstoque.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnEstoque.StatePressed.Back.ColorAngle = 135F;
            btnEstoque.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnEstoque.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnEstoque.StatePressed.Border.ColorAngle = 135F;
            btnEstoque.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEstoque.StatePressed.Border.Rounding = 20F;
            btnEstoque.StatePressed.Border.Width = 1;
            btnEstoque.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnEstoque.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnEstoque.StateTracking.Back.ColorAngle = 45F;
            btnEstoque.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnEstoque.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnEstoque.StateTracking.Border.ColorAngle = 45F;
            btnEstoque.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEstoque.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnEstoque.StateTracking.Border.Rounding = 20F;
            btnEstoque.StateTracking.Border.Width = 1;
            btnEstoque.StateTracking.Content.ShortText.Color1 = Color.White;
            btnEstoque.TabIndex = 601;
            btnEstoque.TabStop = false;
            btnEstoque.Values.Text = "Es&toque";
            btnEstoque.Click += btnEstoque_Click;
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Items.AddRange(new ToolStripItem[] { lblMensagemStatus });
            kryptonStatusStrip1.Location = new Point(0, 539);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.Professional;
            kryptonStatusStrip1.Size = new Size(1008, 22);
            kryptonStatusStrip1.TabIndex = 604;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // lblMensagemStatus
            // 
            lblMensagemStatus.Name = "lblMensagemStatus";
            lblMensagemStatus.Size = new Size(100, 17);
            lblMensagemStatus.Text = "Total de Registros";
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSair.CornerRoundingRadius = 10F;
            btnSair.Location = new Point(905, 3);
            btnSair.Margin = new Padding(5, 3, 5, 3);
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
            btnSair.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSair.Size = new Size(88, 27);
            btnSair.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Back.ColorAngle = 45F;
            btnSair.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateCommon.Border.Rounding = 10F;
            btnSair.StateCommon.Border.Width = 1;
            btnSair.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSair.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSair.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnSair.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StatePressed.Back.ColorAngle = 135F;
            btnSair.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StatePressed.Border.ColorAngle = 135F;
            btnSair.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StatePressed.Border.Rounding = 20F;
            btnSair.StatePressed.Border.Width = 1;
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
            btnSair.TabIndex = 618;
            btnSair.TabStop = false;
            btnSair.Values.Text = "&Sair";
            btnSair.Click += btnSair_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.CornerRoundingRadius = 10F;
            btnExcluir.Location = new Point(813, 3);
            btnExcluir.Margin = new Padding(5, 3, 5, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnExcluir.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnExcluir.OverrideDefault.Back.ColorAngle = 45F;
            btnExcluir.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExcluir.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExcluir.OverrideDefault.Border.ColorAngle = 45F;
            btnExcluir.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluir.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExcluir.OverrideDefault.Border.Rounding = 20F;
            btnExcluir.OverrideDefault.Border.Width = 1;
            btnExcluir.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnExcluir.Size = new Size(88, 27);
            btnExcluir.StateCommon.Back.Color1 = Color.Red;
            btnExcluir.StateCommon.Back.Color2 = Color.Red;
            btnExcluir.StateCommon.Back.ColorAngle = 45F;
            btnExcluir.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExcluir.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExcluir.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluir.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExcluir.StateCommon.Border.Rounding = 10F;
            btnExcluir.StateCommon.Border.Width = 1;
            btnExcluir.StateCommon.Content.ShortText.Color1 = Color.White;
            btnExcluir.StateCommon.Content.ShortText.Color2 = Color.White;
            btnExcluir.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnExcluir.StateNormal.Back.Color1 = Color.Red;
            btnExcluir.StateNormal.Back.Color2 = Color.Red;
            btnExcluir.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnExcluir.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnExcluir.StatePressed.Back.ColorAngle = 135F;
            btnExcluir.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnExcluir.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnExcluir.StatePressed.Border.ColorAngle = 135F;
            btnExcluir.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluir.StatePressed.Border.Rounding = 20F;
            btnExcluir.StatePressed.Border.Width = 1;
            btnExcluir.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnExcluir.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnExcluir.StateTracking.Back.ColorAngle = 45F;
            btnExcluir.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExcluir.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExcluir.StateTracking.Border.ColorAngle = 45F;
            btnExcluir.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluir.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExcluir.StateTracking.Border.Rounding = 20F;
            btnExcluir.StateTracking.Border.Width = 1;
            btnExcluir.TabIndex = 616;
            btnExcluir.TabStop = false;
            btnExcluir.Values.Text = "&Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNovo.CornerRoundingRadius = 10F;
            btnNovo.Location = new Point(629, 3);
            btnNovo.Margin = new Padding(5, 3, 5, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnNovo.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnNovo.OverrideDefault.Back.ColorAngle = 45F;
            btnNovo.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNovo.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNovo.OverrideDefault.Border.ColorAngle = 45F;
            btnNovo.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.OverrideDefault.Border.Rounding = 20F;
            btnNovo.OverrideDefault.Border.Width = 1;
            btnNovo.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnNovo.Size = new Size(88, 27);
            btnNovo.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnNovo.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnNovo.StateCommon.Back.ColorAngle = 45F;
            btnNovo.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNovo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNovo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.StateCommon.Border.Rounding = 10F;
            btnNovo.StateCommon.Border.Width = 1;
            btnNovo.StateCommon.Content.ShortText.Color1 = Color.White;
            btnNovo.StateCommon.Content.ShortText.Color2 = Color.White;
            btnNovo.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnNovo.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnNovo.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnNovo.StatePressed.Back.ColorAngle = 135F;
            btnNovo.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnNovo.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnNovo.StatePressed.Border.ColorAngle = 135F;
            btnNovo.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.StatePressed.Border.Rounding = 20F;
            btnNovo.StatePressed.Border.Width = 1;
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
            btnNovo.TabIndex = 619;
            btnNovo.TabStop = false;
            btnNovo.Values.Text = "&Novo";
            btnNovo.Click += btnNovo_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAlterar.CornerRoundingRadius = 10F;
            btnAlterar.Location = new Point(721, 3);
            btnAlterar.Margin = new Padding(5, 3, 5, 3);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnAlterar.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnAlterar.OverrideDefault.Back.ColorAngle = 45F;
            btnAlterar.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnAlterar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAlterar.OverrideDefault.Border.ColorAngle = 45F;
            btnAlterar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAlterar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAlterar.OverrideDefault.Border.Rounding = 20F;
            btnAlterar.OverrideDefault.Border.Width = 1;
            btnAlterar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnAlterar.Size = new Size(88, 27);
            btnAlterar.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnAlterar.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnAlterar.StateCommon.Back.ColorAngle = 45F;
            btnAlterar.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAlterar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAlterar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAlterar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAlterar.StateCommon.Border.Rounding = 10F;
            btnAlterar.StateCommon.Border.Width = 1;
            btnAlterar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnAlterar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAlterar.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnAlterar.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnAlterar.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnAlterar.StatePressed.Back.ColorAngle = 135F;
            btnAlterar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnAlterar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnAlterar.StatePressed.Border.ColorAngle = 135F;
            btnAlterar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAlterar.StatePressed.Border.Rounding = 20F;
            btnAlterar.StatePressed.Border.Width = 1;
            btnAlterar.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnAlterar.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnAlterar.StateTracking.Back.ColorAngle = 45F;
            btnAlterar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAlterar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAlterar.StateTracking.Border.ColorAngle = 45F;
            btnAlterar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAlterar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAlterar.StateTracking.Border.Rounding = 20F;
            btnAlterar.StateTracking.Border.Width = 1;
            btnAlterar.StateTracking.Content.ShortText.Color1 = Color.White;
            btnAlterar.TabIndex = 617;
            btnAlterar.TabStop = false;
            btnAlterar.Values.Text = "&Alterar";
            btnAlterar.Click += btnAlterar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.CharacterCasing = CharacterCasing.Upper;
            txtPesquisa.Location = new Point(89, 1);
            txtPesquisa.Margin = new Padding(5, 6, 5, 6);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            txtPesquisa.Size = new Size(904, 27);
            txtPesquisa.StateCommon.Back.Color1 = Color.White;
            txtPesquisa.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtPesquisa.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtPesquisa.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPesquisa.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPesquisa.StateCommon.Border.Rounding = 8F;
            txtPesquisa.StateCommon.Border.Width = 1;
            txtPesquisa.StateCommon.Content.Color1 = Color.Gray;
            txtPesquisa.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtPesquisa.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtPesquisa.TabIndex = 0;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(kryptonPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(kryptonPanel5, 0, 1);
            tableLayoutPanel2.Controls.Add(kryptonPanel6, 0, 3);
            tableLayoutPanel2.Controls.Add(dgvProdutos, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(1008, 539);
            tableLayoutPanel2.TabIndex = 625;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(pnlHeader);
            kryptonPanel3.Dock = DockStyle.Fill;
            kryptonPanel3.Location = new Point(3, 3);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            kryptonPanel3.Size = new Size(1002, 63);
            kryptonPanel3.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonPanel3.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(tlpTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1002, 62);
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
            tlpTitulo.Controls.Add(lblSubTitulo, 0, 1);
            tlpTitulo.Controls.Add(kryptonPanel1, 0, 0);
            tlpTitulo.Dock = DockStyle.Fill;
            tlpTitulo.Location = new Point(0, 0);
            tlpTitulo.Name = "tlpTitulo";
            tlpTitulo.RowCount = 2;
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 67.7419357F));
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 32.2580643F));
            tlpTitulo.Size = new Size(1002, 62);
            tlpTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            tlpTitulo.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            tlpTitulo.TabIndex = 0;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.Dock = DockStyle.Fill;
            lblSubTitulo.Location = new Point(3, 45);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(996, 14);
            lblSubTitulo.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Color2 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 12F);
            lblSubTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblSubTitulo.TabIndex = 0;
            lblSubTitulo.Values.Text = "Gerencie facilmente sua lista de produtos — adicione, edite, exclua";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(lblTitulo);
            kryptonPanel1.Controls.Add(iconAcao);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(3, 3);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(996, 36);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            kryptonPanel1.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.Location = new Point(416, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(220, 27);
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Color2 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 1091;
            lblTitulo.Values.Text = "Manutenção de Produtos";
            // 
            // iconAcao
            // 
            iconAcao.Anchor = AnchorStyles.Top;
            iconAcao.BackColor = Color.Transparent;
            iconAcao.IconChar = FontAwesome.Sharp.IconChar.Box;
            iconAcao.IconColor = Color.White;
            iconAcao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAcao.IconSize = 48;
            iconAcao.Location = new Point(369, -1);
            iconAcao.Name = "iconAcao";
            iconAcao.Size = new Size(48, 48);
            iconAcao.TabIndex = 1110;
            iconAcao.TabStop = false;
            // 
            // kryptonPanel5
            // 
            kryptonPanel5.Controls.Add(pictureBox1);
            kryptonPanel5.Controls.Add(kryptonLabel1);
            kryptonPanel5.Controls.Add(txtPesquisa);
            kryptonPanel5.Dock = DockStyle.Fill;
            kryptonPanel5.Location = new Point(3, 72);
            kryptonPanel5.Name = "kryptonPanel5";
            kryptonPanel5.PaletteMode = Krypton.Toolkit.PaletteMode.Office365White;
            kryptonPanel5.Size = new Size(1002, 33);
            kryptonPanel5.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pesquisar;
            pictureBox1.Location = new Point(64, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 627;
            pictureBox1.TabStop = false;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(3, 3);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(62, 20);
            kryptonLabel1.TabIndex = 626;
            kryptonLabel1.Values.Text = "Pesquisar";
            // 
            // kryptonPanel6
            // 
            kryptonPanel6.Controls.Add(btnExcluir);
            kryptonPanel6.Controls.Add(btnSair);
            kryptonPanel6.Controls.Add(btnEstoque);
            kryptonPanel6.Controls.Add(btnAlterar);
            kryptonPanel6.Controls.Add(btnNovo);
            kryptonPanel6.Dock = DockStyle.Fill;
            kryptonPanel6.Location = new Point(3, 502);
            kryptonPanel6.Name = "kryptonPanel6";
            kryptonPanel6.PaletteMode = Krypton.Toolkit.PaletteMode.Office365White;
            kryptonPanel6.Size = new Size(1002, 34);
            kryptonPanel6.TabIndex = 2;
            // 
            // FrmManutProduto
            // 
            AutoScroll = true;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(1008, 561);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(kryptonStatusStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 3, 5, 3);
            MinimizeBox = false;
            Name = "FrmManutProduto";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Back.Color1 = Color.White;
            StateCommon.Back.Color2 = Color.White;
            Text = "Manutenção de Produtos";
            WindowState = FormWindowState.Maximized;
            Load += FrmManutProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            kryptonStatusStrip1.ResumeLayout(false);
            kryptonStatusStrip1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnlHeader).EndInit();
            pnlHeader.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconAcao).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).EndInit();
            kryptonPanel5.ResumeLayout(false);
            kryptonPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel6).EndInit();
            kryptonPanel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Krypton.Toolkit.KryptonDataGridView dgvProdutos;
        private Krypton.Toolkit.KryptonButton btnEstoque;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        private ToolStripStatusLabel lblMensagemStatus;
        public Krypton.Toolkit.KryptonButton btnSair;
        public Krypton.Toolkit.KryptonButton btnExcluir;
        public Krypton.Toolkit.KryptonButton btnNovo;
        public Krypton.Toolkit.KryptonButton btnAlterar;
        public Krypton.Toolkit.KryptonTextBox txtPesquisa;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPanel pnlHeader;
        private Krypton.Toolkit.KryptonTableLayoutPanel tlpTitulo;
        private Krypton.Toolkit.KryptonLabel lblSubTitulo;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private FontAwesome.Sharp.IconPictureBox iconAcao;
    }
}
