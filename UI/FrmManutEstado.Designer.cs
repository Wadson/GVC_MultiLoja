namespace GVC
{
    partial class FrmManutEstado
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
            dgvPesquisar = new Krypton.Toolkit.KryptonDataGridView();
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            toolStripStatusLabelTotalRegistros = new ToolStripStatusLabel();
            txtPesquisar = new Krypton.Toolkit.KryptonTextBox();
            btnSair = new Krypton.Toolkit.KryptonButton();
            btnExcluir = new Krypton.Toolkit.KryptonButton();
            btnNovo = new Krypton.Toolkit.KryptonButton();
            btnAlterar = new Krypton.Toolkit.KryptonButton();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            pictureBox1 = new PictureBox();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)dgvPesquisar).BeginInit();
            kryptonStatusStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            kryptonPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // dgvPesquisar
            // 
            dgvPesquisar.AllowUserToAddRows = false;
            dgvPesquisar.AllowUserToDeleteRows = false;
            dgvPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPesquisar.Dock = DockStyle.Fill;
            dgvPesquisar.Location = new Point(4, 73);
            dgvPesquisar.Margin = new Padding(4, 3, 4, 3);
            dgvPesquisar.MultiSelect = false;
            dgvPesquisar.Name = "dgvPesquisar";
            dgvPesquisar.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            dgvPesquisar.ReadOnly = true;
            dgvPesquisar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPesquisar.Size = new Size(702, 269);
            dgvPesquisar.TabIndex = 597;
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelTotalRegistros });
            kryptonStatusStrip1.Location = new Point(0, 385);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.Professional;
            kryptonStatusStrip1.Size = new Size(710, 22);
            kryptonStatusStrip1.TabIndex = 606;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // toolStripStatusLabelTotalRegistros
            // 
            toolStripStatusLabelTotalRegistros.ForeColor = Color.FromArgb(10, 128, 255);
            toolStripStatusLabelTotalRegistros.Name = "toolStripStatusLabelTotalRegistros";
            toolStripStatusLabelTotalRegistros.Size = new Size(103, 17);
            toolStripStatusLabelTotalRegistros.Text = "Total de Registros:";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisar.CharacterCasing = CharacterCasing.Upper;
            txtPesquisar.Location = new Point(86, 1);
            txtPesquisar.Margin = new Padding(5, 6, 5, 6);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            txtPesquisar.Size = new Size(618, 27);
            txtPesquisar.StateCommon.Back.Color1 = Color.White;
            txtPesquisar.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtPesquisar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtPesquisar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPesquisar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPesquisar.StateCommon.Border.Rounding = 8F;
            txtPesquisar.StateCommon.Border.Width = 1;
            txtPesquisar.StateCommon.Content.Color1 = Color.Gray;
            txtPesquisar.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtPesquisar.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtPesquisar.TabIndex = 615;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSair.CornerRoundingRadius = 10F;
            btnSair.Location = new Point(617, 3);
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
            btnSair.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
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
            btnSair.TabIndex = 619;
            btnSair.Values.Text = "&Sair";
            btnSair.Click += btnSair_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.CornerRoundingRadius = 10F;
            btnExcluir.Location = new Point(524, 3);
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
            btnExcluir.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
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
            btnExcluir.TabIndex = 617;
            btnExcluir.Values.Text = "&Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNovo.CornerRoundingRadius = 10F;
            btnNovo.Location = new Point(338, 3);
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
            btnNovo.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
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
            btnNovo.TabIndex = 620;
            btnNovo.Values.Text = "&Novo";
            btnNovo.Click += btnNovo_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAlterar.CornerRoundingRadius = 10F;
            btnAlterar.Location = new Point(431, 3);
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
            btnAlterar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
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
            btnAlterar.TabIndex = 618;
            btnAlterar.Values.Text = "&Alterar";
            btnAlterar.Click += btnAlterar_Click;
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
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(kryptonPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(kryptonPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(kryptonPanel4, 0, 3);
            tableLayoutPanel1.Controls.Add(dgvPesquisar, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(710, 385);
            tableLayoutPanel1.TabIndex = 625;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(3, 3);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueDarkMode;
            kryptonPanel1.Size = new Size(704, 29);
            kryptonPanel1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Dock = DockStyle.Fill;
            kryptonLabel1.Location = new Point(0, 0);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(704, 29);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "MANUTENÇÃO DE ESTADOS";
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(pictureBox1);
            kryptonPanel3.Controls.Add(kryptonLabel2);
            kryptonPanel3.Controls.Add(txtPesquisar);
            kryptonPanel3.Dock = DockStyle.Fill;
            kryptonPanel3.Location = new Point(3, 38);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.PaletteMode = Krypton.Toolkit.PaletteMode.Office365White;
            kryptonPanel3.Size = new Size(704, 29);
            kryptonPanel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pesquisar;
            pictureBox1.Location = new Point(61, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 623;
            pictureBox1.TabStop = false;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(0, 4);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(62, 20);
            kryptonLabel2.TabIndex = 622;
            kryptonLabel2.Values.Text = "Pesquisar";
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Controls.Add(btnExcluir);
            kryptonPanel4.Controls.Add(btnSair);
            kryptonPanel4.Controls.Add(btnAlterar);
            kryptonPanel4.Controls.Add(btnNovo);
            kryptonPanel4.Dock = DockStyle.Fill;
            kryptonPanel4.Location = new Point(3, 348);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueLightMode;
            kryptonPanel4.Size = new Size(704, 34);
            kryptonPanel4.TabIndex = 2;
            // 
            // FrmManutEstado
            // 
            BackColor = Color.FromArgb(252, 250, 250);
            ClientSize = new Size(710, 407);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(kryptonStatusStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 3, 5, 3);
            Name = "FrmManutEstado";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StateCommon.Back.Color1 = Color.White;
            StateCommon.Back.Color2 = Color.White;
            Text = "Manutenção de Estados";
            Load += FrmManutUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPesquisar).EndInit();
            kryptonStatusStrip1.ResumeLayout(false);
            kryptonStatusStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            kryptonPanel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Krypton.Toolkit.KryptonDataGridView dgvPesquisar;
        private System.Windows.Forms.Label lblTotalRegistros;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelTotalRegistros;
        public Krypton.Toolkit.KryptonTextBox txtPesquisar;
        public Krypton.Toolkit.KryptonButton btnSair;
        public Krypton.Toolkit.KryptonButton btnExcluir;
        public Krypton.Toolkit.KryptonButton btnNovo;
        public Krypton.Toolkit.KryptonButton btnAlterar;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}
