namespace GVC.View
{
    partial class FrmManutEmpresa
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
            timer1 = new System.Windows.Forms.Timer(components);
            dgvEmpresa = new Krypton.Toolkit.KryptonDataGridView();
            txtPesquisa = new Krypton.Toolkit.KryptonTextBox();
            btnSair = new Krypton.Toolkit.KryptonButton();
            btnAlterar = new Krypton.Toolkit.KryptonButton();
            btnExcluir = new Krypton.Toolkit.KryptonButton();
            btnNovo = new Krypton.Toolkit.KryptonButton();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            timer2 = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            lblTotalBanco = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            lblStatus = new ToolStripStatusLabel();
            btnPesquisar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvEmpresa).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            kryptonPanel4.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // dgvEmpresa
            // 
            dgvEmpresa.AllowUserToAddRows = false;
            dgvEmpresa.AllowUserToDeleteRows = false;
            dgvEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEmpresa.Dock = DockStyle.Fill;
            dgvEmpresa.Location = new Point(4, 73);
            dgvEmpresa.Margin = new Padding(4, 3, 4, 3);
            dgvEmpresa.MultiSelect = false;
            dgvEmpresa.Name = "dgvEmpresa";
            dgvEmpresa.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            dgvEmpresa.ReadOnly = true;
            dgvEmpresa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpresa.Size = new Size(1000, 420);
            dgvEmpresa.TabIndex = 597;
            dgvEmpresa.CellFormatting += dgvEmpresa_CellFormatting;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.CharacterCasing = CharacterCasing.Upper;
            txtPesquisa.Location = new Point(99, 1);
            txtPesquisa.Margin = new Padding(5, 6, 5, 6);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            txtPesquisa.Size = new Size(898, 27);
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
            txtPesquisa.TabIndex = 607;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSair.CornerRoundingRadius = 10F;
            btnSair.Location = new Point(918, -20);
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
            btnSair.Size = new Size(80, 27);
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
            btnSair.TabIndex = 610;
            btnSair.Values.Text = "&Sair";
            btnSair.Click += btnSair_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAlterar.CornerRoundingRadius = 10F;
            btnAlterar.Location = new Point(738, 2);
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
            btnAlterar.Size = new Size(80, 27);
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
            btnAlterar.TabIndex = 609;
            btnAlterar.Values.Text = "&Alterar";
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExcluir.CornerRoundingRadius = 10F;
            btnExcluir.Location = new Point(828, 2);
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
            btnExcluir.Size = new Size(80, 27);
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
            btnExcluir.TabIndex = 608;
            btnExcluir.Values.Text = "&Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNovo.CornerRoundingRadius = 10F;
            btnNovo.Location = new Point(648, 2);
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
            btnNovo.Size = new Size(80, 27);
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
            btnNovo.TabIndex = 611;
            btnNovo.Values.Text = "&Novo";
            btnNovo.Click += btnNovo_Click;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(kryptonPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(kryptonPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(kryptonPanel4, 0, 3);
            tableLayoutPanel1.Controls.Add(dgvEmpresa, 0, 2);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1008, 536);
            tableLayoutPanel1.TabIndex = 625;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(kryptonLabel1);
            kryptonPanel2.Dock = DockStyle.Fill;
            kryptonPanel2.Location = new Point(3, 3);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            kryptonPanel2.Size = new Size(1002, 29);
            kryptonPanel2.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonPanel2.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Dock = DockStyle.Fill;
            kryptonLabel1.Location = new Point(0, 0);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(1002, 29);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "MANUTENÇÃO DE EMPRESA";
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(btnPesquisar);
            kryptonPanel3.Controls.Add(kryptonLabel2);
            kryptonPanel3.Controls.Add(txtPesquisa);
            kryptonPanel3.Dock = DockStyle.Fill;
            kryptonPanel3.Location = new Point(3, 38);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.PaletteMode = Krypton.Toolkit.PaletteMode.Office365White;
            kryptonPanel3.Size = new Size(1002, 29);
            kryptonPanel3.TabIndex = 1;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(3, 6);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(62, 20);
            kryptonLabel2.TabIndex = 620;
            kryptonLabel2.Values.Text = "Pesquisar";
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Controls.Add(btnExcluir);
            kryptonPanel4.Controls.Add(btnAlterar);
            kryptonPanel4.Controls.Add(btnSair);
            kryptonPanel4.Controls.Add(btnNovo);
            kryptonPanel4.Dock = DockStyle.Fill;
            kryptonPanel4.Location = new Point(3, 499);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office365White;
            kryptonPanel4.Size = new Size(1002, 34);
            kryptonPanel4.TabIndex = 2;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTotalBanco, toolStripStatusLabel2, lblStatus });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1008, 22);
            statusStrip1.TabIndex = 627;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTotalBanco
            // 
            lblTotalBanco.Name = "lblTotalBanco";
            lblTotalBanco.Size = new Size(79, 17);
            lblTotalBanco.Text = "lblTotalBanco";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(16, 17);
            toolStripStatusLabel2.Text = " | ";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 17);
            lblStatus.Text = "Status";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Transparent;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnPesquisar.IconColor = Color.FromArgb(30, 136, 229);
            btnPesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPesquisar.IconSize = 30;
            btnPesquisar.Location = new Point(68, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(25, 25);
            btnPesquisar.TabIndex = 1141;
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // FrmManutEmpresa
            // 
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(1008, 561);
            Controls.Add(statusStrip1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(5, 3, 5, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmManutEmpresa";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StateCommon.Back.Color1 = Color.White;
            StateCommon.Back.Color2 = Color.White;
            Text = "Manutenção e Empresa";
            WindowState = FormWindowState.Maximized;
            Load += FrmManutEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpresa).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            kryptonPanel4.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Krypton.Toolkit.KryptonDataGridView dgvEmpresa;
        public Krypton.Toolkit.KryptonTextBox txtPesquisa;
        public Krypton.Toolkit.KryptonButton btnSair;
        public Krypton.Toolkit.KryptonButton btnAlterar;
        public Krypton.Toolkit.KryptonButton btnExcluir;
        public Krypton.Toolkit.KryptonButton btnNovo;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private System.Windows.Forms.Timer timer2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTotalBanco;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lblStatus;
        private FontAwesome.Sharp.IconButton btnPesquisar;
    }
}
