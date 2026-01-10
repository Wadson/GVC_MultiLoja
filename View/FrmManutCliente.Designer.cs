namespace GVC.View
{
    partial class FrmManutCliente
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
            dgvCliente = new Krypton.Toolkit.KryptonDataGridView();
            lblTotalRegistros = new Label();
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
            pictureBox1 = new PictureBox();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            kryptonPanel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCliente.Dock = DockStyle.Fill;
            dgvCliente.Location = new Point(4, 73);
            dgvCliente.Margin = new Padding(4, 3, 4, 3);
            dgvCliente.MultiSelect = false;
            dgvCliente.Name = "dgvCliente";
            dgvCliente.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            dgvCliente.ReadOnly = true;
            dgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCliente.Size = new Size(706, 295);
            dgvCliente.TabIndex = 597;
            dgvCliente.CellFormatting += dataGridPesquisar_CellFormatting;
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.ForeColor = Color.FromArgb(10, 128, 255);
            lblTotalRegistros.Location = new Point(0, 390);
            lblTotalRegistros.Margin = new Padding(4, 0, 4, 0);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(100, 15);
            lblTotalRegistros.TabIndex = 606;
            lblTotalRegistros.Text = "Total de Registros";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.CharacterCasing = CharacterCasing.Upper;
            txtPesquisa.Location = new Point(92, 1);
            txtPesquisa.Margin = new Padding(5, 6, 5, 6);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            txtPesquisa.Size = new Size(611, 27);
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
            btnSair.Location = new Point(624, 4);
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
            btnAlterar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAlterar.CornerRoundingRadius = 10F;
            btnAlterar.Location = new Point(444, 4);
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
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.CornerRoundingRadius = 10F;
            btnExcluir.Location = new Point(534, 4);
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
            btnNovo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNovo.CornerRoundingRadius = 10F;
            btnNovo.Location = new Point(354, 4);
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
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(kryptonPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(kryptonPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(kryptonPanel4, 0, 3);
            tableLayoutPanel1.Controls.Add(dgvCliente, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(714, 411);
            tableLayoutPanel1.TabIndex = 625;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(kryptonLabel1);
            kryptonPanel2.Dock = DockStyle.Fill;
            kryptonPanel2.Location = new Point(3, 3);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            kryptonPanel2.Size = new Size(708, 29);
            kryptonPanel2.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonPanel2.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Dock = DockStyle.Fill;
            kryptonLabel1.Location = new Point(0, 0);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(708, 29);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "MANUTENÇÃO DE CLIENTES";
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(pictureBox1);
            kryptonPanel3.Controls.Add(kryptonLabel2);
            kryptonPanel3.Controls.Add(txtPesquisa);
            kryptonPanel3.Dock = DockStyle.Fill;
            kryptonPanel3.Location = new Point(3, 38);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.PaletteMode = Krypton.Toolkit.PaletteMode.Office365BlueDarkMode;
            kryptonPanel3.Size = new Size(708, 29);
            kryptonPanel3.StateCommon.Color1 = Color.White;
            kryptonPanel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pesquisar;
            pictureBox1.Location = new Point(66, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 619;
            pictureBox1.TabStop = false;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(3, 3);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(62, 20);
            kryptonLabel2.TabIndex = 618;
            kryptonLabel2.Values.Text = "Pesquisar";
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Controls.Add(btnExcluir);
            kryptonPanel4.Controls.Add(btnAlterar);
            kryptonPanel4.Controls.Add(btnSair);
            kryptonPanel4.Controls.Add(btnNovo);
            kryptonPanel4.Dock = DockStyle.Fill;
            kryptonPanel4.Location = new Point(3, 374);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            kryptonPanel4.Size = new Size(708, 34);
            kryptonPanel4.StateCommon.Color1 = Color.White;
            kryptonPanel4.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 411);
            panel1.TabIndex = 626;
            // 
            // FrmManutCliente
            // 
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(714, 411);
            Controls.Add(panel1);
            Controls.Add(lblTotalRegistros);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new Padding(5, 3, 5, 3);
            Name = "FrmManutCliente";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StateCommon.Back.Color1 = Color.White;
            StateCommon.Back.Color2 = Color.White;
            Text = "Manutenção e Clientes";
            Load += FrmManutCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            kryptonPanel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Krypton.Toolkit.KryptonDataGridView dgvCliente;
        private System.Windows.Forms.Label lblTotalRegistros;
        public Krypton.Toolkit.KryptonTextBox txtPesquisa;
        public Krypton.Toolkit.KryptonButton btnSair;
        public Krypton.Toolkit.KryptonButton btnAlterar;
        public Krypton.Toolkit.KryptonButton btnExcluir;
        public Krypton.Toolkit.KryptonButton btnNovo;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}
