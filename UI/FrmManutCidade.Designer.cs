namespace GVC
{
    partial class FrmManutCidade
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
            dataGridPesquisar = new Krypton.Toolkit.KryptonDataGridView();
            btnSai = new Krypton.Toolkit.KryptonButton();
            btnExclui = new Krypton.Toolkit.KryptonButton();
            btnNov = new Krypton.Toolkit.KryptonButton();
            btnAltera = new Krypton.Toolkit.KryptonButton();
            txtLocaliza = new Krypton.Toolkit.KryptonTextBox();
            kryptonStatusStrip2 = new Krypton.Toolkit.KryptonStatusStrip();
            LabelTotalRegistros = new ToolStripStatusLabel();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            pictureBox1 = new PictureBox();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridPesquisar).BeginInit();
            kryptonStatusStrip2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
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
            // dataGridPesquisar
            // 
            dataGridPesquisar.AllowUserToAddRows = false;
            dataGridPesquisar.AllowUserToDeleteRows = false;
            dataGridPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPesquisar.Dock = DockStyle.Fill;
            dataGridPesquisar.Location = new Point(4, 73);
            dataGridPesquisar.Margin = new Padding(4, 3, 4, 3);
            dataGridPesquisar.MultiSelect = false;
            dataGridPesquisar.Name = "dataGridPesquisar";
            dataGridPesquisar.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            dataGridPesquisar.ReadOnly = true;
            dataGridPesquisar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPesquisar.Size = new Size(1000, 423);
            dataGridPesquisar.TabIndex = 597;
            // 
            // btnSai
            // 
            btnSai.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSai.CornerRoundingRadius = 10F;
            btnSai.Location = new Point(919, 3);
            btnSai.Margin = new Padding(5, 3, 5, 3);
            btnSai.Name = "btnSai";
            btnSai.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSai.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSai.OverrideDefault.Back.ColorAngle = 45F;
            btnSai.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSai.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSai.OverrideDefault.Border.ColorAngle = 45F;
            btnSai.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSai.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSai.OverrideDefault.Border.Rounding = 20F;
            btnSai.OverrideDefault.Border.Width = 1;
            btnSai.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSai.Size = new Size(80, 27);
            btnSai.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSai.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSai.StateCommon.Back.ColorAngle = 45F;
            btnSai.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSai.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSai.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSai.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSai.StateCommon.Border.Rounding = 10F;
            btnSai.StateCommon.Border.Width = 1;
            btnSai.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSai.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSai.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnSai.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnSai.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnSai.StatePressed.Back.ColorAngle = 135F;
            btnSai.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSai.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSai.StatePressed.Border.ColorAngle = 135F;
            btnSai.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSai.StatePressed.Border.Rounding = 20F;
            btnSai.StatePressed.Border.Width = 1;
            btnSai.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSai.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnSai.StateTracking.Back.ColorAngle = 45F;
            btnSai.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSai.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSai.StateTracking.Border.ColorAngle = 45F;
            btnSai.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSai.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSai.StateTracking.Border.Rounding = 20F;
            btnSai.StateTracking.Border.Width = 1;
            btnSai.TabIndex = 618;
            btnSai.Values.Text = "&Sair";
            btnSai.Click += btnSai_Click;
            // 
            // btnExclui
            // 
            btnExclui.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExclui.CornerRoundingRadius = 10F;
            btnExclui.Location = new Point(829, 3);
            btnExclui.Margin = new Padding(5, 3, 5, 3);
            btnExclui.Name = "btnExclui";
            btnExclui.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnExclui.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnExclui.OverrideDefault.Back.ColorAngle = 45F;
            btnExclui.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExclui.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExclui.OverrideDefault.Border.ColorAngle = 45F;
            btnExclui.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExclui.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExclui.OverrideDefault.Border.Rounding = 20F;
            btnExclui.OverrideDefault.Border.Width = 1;
            btnExclui.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnExclui.Size = new Size(80, 27);
            btnExclui.StateCommon.Back.Color1 = Color.Red;
            btnExclui.StateCommon.Back.Color2 = Color.Red;
            btnExclui.StateCommon.Back.ColorAngle = 45F;
            btnExclui.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExclui.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExclui.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExclui.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExclui.StateCommon.Border.Rounding = 10F;
            btnExclui.StateCommon.Border.Width = 1;
            btnExclui.StateCommon.Content.ShortText.Color1 = Color.White;
            btnExclui.StateCommon.Content.ShortText.Color2 = Color.White;
            btnExclui.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnExclui.StateNormal.Back.Color1 = Color.Red;
            btnExclui.StateNormal.Back.Color2 = Color.Red;
            btnExclui.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnExclui.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnExclui.StatePressed.Back.ColorAngle = 135F;
            btnExclui.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnExclui.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnExclui.StatePressed.Border.ColorAngle = 135F;
            btnExclui.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExclui.StatePressed.Border.Rounding = 20F;
            btnExclui.StatePressed.Border.Width = 1;
            btnExclui.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnExclui.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnExclui.StateTracking.Back.ColorAngle = 45F;
            btnExclui.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExclui.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExclui.StateTracking.Border.ColorAngle = 45F;
            btnExclui.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExclui.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExclui.StateTracking.Border.Rounding = 20F;
            btnExclui.StateTracking.Border.Width = 1;
            btnExclui.TabIndex = 616;
            btnExclui.Values.Text = "&Excluir";
            btnExclui.Click += btnExclui_Click;
            // 
            // btnNov
            // 
            btnNov.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNov.CornerRoundingRadius = 10F;
            btnNov.Location = new Point(635, 3);
            btnNov.Margin = new Padding(5, 3, 5, 3);
            btnNov.Name = "btnNov";
            btnNov.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnNov.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnNov.OverrideDefault.Back.ColorAngle = 45F;
            btnNov.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNov.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNov.OverrideDefault.Border.ColorAngle = 45F;
            btnNov.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNov.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNov.OverrideDefault.Border.Rounding = 20F;
            btnNov.OverrideDefault.Border.Width = 1;
            btnNov.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnNov.Size = new Size(80, 27);
            btnNov.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnNov.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnNov.StateCommon.Back.ColorAngle = 45F;
            btnNov.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNov.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNov.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNov.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNov.StateCommon.Border.Rounding = 10F;
            btnNov.StateCommon.Border.Width = 1;
            btnNov.StateCommon.Content.ShortText.Color1 = Color.White;
            btnNov.StateCommon.Content.ShortText.Color2 = Color.White;
            btnNov.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnNov.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnNov.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnNov.StatePressed.Back.ColorAngle = 135F;
            btnNov.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnNov.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnNov.StatePressed.Border.ColorAngle = 135F;
            btnNov.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNov.StatePressed.Border.Rounding = 20F;
            btnNov.StatePressed.Border.Width = 1;
            btnNov.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnNov.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnNov.StateTracking.Back.ColorAngle = 45F;
            btnNov.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNov.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNov.StateTracking.Border.ColorAngle = 45F;
            btnNov.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNov.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNov.StateTracking.Border.Rounding = 20F;
            btnNov.StateTracking.Border.Width = 1;
            btnNov.TabIndex = 619;
            btnNov.Values.Text = "&Novo";
            btnNov.Click += btnNov_Click;
            // 
            // btnAltera
            // 
            btnAltera.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAltera.CornerRoundingRadius = 10F;
            btnAltera.Location = new Point(732, 3);
            btnAltera.Margin = new Padding(5, 3, 5, 3);
            btnAltera.Name = "btnAltera";
            btnAltera.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnAltera.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnAltera.OverrideDefault.Back.ColorAngle = 45F;
            btnAltera.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnAltera.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAltera.OverrideDefault.Border.ColorAngle = 45F;
            btnAltera.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAltera.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAltera.OverrideDefault.Border.Rounding = 20F;
            btnAltera.OverrideDefault.Border.Width = 1;
            btnAltera.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnAltera.Size = new Size(80, 27);
            btnAltera.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnAltera.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnAltera.StateCommon.Back.ColorAngle = 45F;
            btnAltera.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAltera.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAltera.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAltera.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAltera.StateCommon.Border.Rounding = 10F;
            btnAltera.StateCommon.Border.Width = 1;
            btnAltera.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnAltera.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAltera.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnAltera.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnAltera.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnAltera.StatePressed.Back.ColorAngle = 135F;
            btnAltera.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnAltera.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnAltera.StatePressed.Border.ColorAngle = 135F;
            btnAltera.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAltera.StatePressed.Border.Rounding = 20F;
            btnAltera.StatePressed.Border.Width = 1;
            btnAltera.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnAltera.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnAltera.StateTracking.Back.ColorAngle = 45F;
            btnAltera.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAltera.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAltera.StateTracking.Border.ColorAngle = 45F;
            btnAltera.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAltera.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAltera.StateTracking.Border.Rounding = 20F;
            btnAltera.StateTracking.Border.Width = 1;
            btnAltera.StateTracking.Content.ShortText.Color1 = Color.White;
            btnAltera.TabIndex = 617;
            btnAltera.Values.Text = "&Alterar";
            btnAltera.Click += btnAltera_Click;
            // 
            // txtLocaliza
            // 
            txtLocaliza.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLocaliza.CharacterCasing = CharacterCasing.Upper;
            txtLocaliza.Location = new Point(93, 1);
            txtLocaliza.Margin = new Padding(5, 6, 5, 6);
            txtLocaliza.Name = "txtLocaliza";
            txtLocaliza.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            txtLocaliza.Size = new Size(904, 27);
            txtLocaliza.StateCommon.Back.Color1 = Color.White;
            txtLocaliza.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtLocaliza.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtLocaliza.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtLocaliza.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtLocaliza.StateCommon.Border.Rounding = 8F;
            txtLocaliza.StateCommon.Border.Width = 1;
            txtLocaliza.StateCommon.Content.Color1 = Color.Gray;
            txtLocaliza.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtLocaliza.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtLocaliza.TabIndex = 615;
            txtLocaliza.TextChanged += txtLocaliza_TextChanged;
            // 
            // kryptonStatusStrip2
            // 
            kryptonStatusStrip2.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip2.Items.AddRange(new ToolStripItem[] { LabelTotalRegistros });
            kryptonStatusStrip2.Location = new Point(0, 539);
            kryptonStatusStrip2.Name = "kryptonStatusStrip2";
            kryptonStatusStrip2.ProgressBars = null;
            kryptonStatusStrip2.RenderMode = ToolStripRenderMode.Professional;
            kryptonStatusStrip2.Size = new Size(1008, 22);
            kryptonStatusStrip2.TabIndex = 621;
            kryptonStatusStrip2.Text = "kryptonStatusStrip2";
            // 
            // LabelTotalRegistros
            // 
            LabelTotalRegistros.Name = "LabelTotalRegistros";
            LabelTotalRegistros.Size = new Size(79, 17);
            LabelTotalRegistros.Text = "Total Registro";
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
            tableLayoutPanel1.Controls.Add(dataGridPesquisar, 0, 2);
            tableLayoutPanel1.Controls.Add(kryptonPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(kryptonPanel4, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(1008, 539);
            tableLayoutPanel1.TabIndex = 624;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(3, 3);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            kryptonPanel1.Size = new Size(1002, 29);
            kryptonPanel1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Dock = DockStyle.Fill;
            kryptonLabel1.Location = new Point(0, 0);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(1002, 29);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "MANUTENÇÃO DE CIDADES";
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(pictureBox1);
            kryptonPanel2.Controls.Add(kryptonLabel2);
            kryptonPanel2.Controls.Add(txtLocaliza);
            kryptonPanel2.Dock = DockStyle.Fill;
            kryptonPanel2.Location = new Point(3, 38);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            kryptonPanel2.Size = new Size(1002, 29);
            kryptonPanel2.StateCommon.Color1 = Color.FromArgb(252, 252, 250);
            kryptonPanel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pesquisar;
            pictureBox1.Location = new Point(67, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 617;
            pictureBox1.TabStop = false;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(4, 4);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(62, 20);
            kryptonLabel2.TabIndex = 616;
            kryptonLabel2.Values.Text = "Pesquisar";
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Controls.Add(btnSai);
            kryptonPanel4.Controls.Add(btnAltera);
            kryptonPanel4.Controls.Add(btnExclui);
            kryptonPanel4.Controls.Add(btnNov);
            kryptonPanel4.Dock = DockStyle.Fill;
            kryptonPanel4.Location = new Point(3, 502);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            kryptonPanel4.Size = new Size(1002, 34);
            kryptonPanel4.StateCommon.Color1 = Color.White;
            kryptonPanel4.StateCommon.Color2 = Color.White;
            kryptonPanel4.TabIndex = 2;
            // 
            // FrmManutCidade
            // 
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(1008, 561);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(kryptonStatusStrip2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 3, 5, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmManutCidade";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StateCommon.Back.Color1 = Color.White;
            StateCommon.Back.Color2 = Color.White;
            Text = "Manutenção de Cidade";
            Load += FrmManutCidade_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPesquisar).EndInit();
            kryptonStatusStrip2.ResumeLayout(false);
            kryptonStatusStrip2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            kryptonPanel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Krypton.Toolkit.KryptonDataGridView dataGridPesquisar;
        public Krypton.Toolkit.KryptonButton btnSai;
        public Krypton.Toolkit.KryptonButton btnExclui;
        public Krypton.Toolkit.KryptonButton btnNov;
        public Krypton.Toolkit.KryptonButton btnAltera;
        public Krypton.Toolkit.KryptonTextBox txtLocaliza;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        private Label lblTotalRegistros;        
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Label lblTotalRegistro;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip2;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ToolStripStatusLabel LabelTotalRegistros;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}
