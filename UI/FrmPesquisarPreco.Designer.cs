namespace GVC.View
{
    partial class FrmPesquisarPreco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisarPreco));
            dataGridPesquisar = new Krypton.Toolkit.KryptonDataGridView();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            txtPesquisar = new Krypton.Toolkit.KryptonTextBox();
            tlpTitulo = new Krypton.Toolkit.KryptonTableLayoutPanel();
            lblSubTitulo = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            iconAcao = new FontAwesome.Sharp.IconPictureBox();
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            lblMensagem = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridPesquisar).BeginInit();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconAcao).BeginInit();
            kryptonStatusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridPesquisar
            // 
            dataGridPesquisar.AllowUserToAddRows = false;
            dataGridPesquisar.AllowUserToDeleteRows = false;
            dataGridPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPesquisar.Location = new Point(5, 98);
            dataGridPesquisar.Margin = new Padding(4, 3, 4, 3);
            dataGridPesquisar.MultiSelect = false;
            dataGridPesquisar.Name = "dataGridPesquisar";
            dataGridPesquisar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            dataGridPesquisar.ReadOnly = true;
            dataGridPesquisar.RowHeadersWidth = 25;
            dataGridPesquisar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPesquisar.Size = new Size(940, 336);
            dataGridPesquisar.TabIndex = 599;
            dataGridPesquisar.TabStop = false;
            dataGridPesquisar.CellDoubleClick += dataGridPesquisar_CellDoubleClick;
            dataGridPesquisar.SelectionChanged += dataGridPesquisar_SelectionChanged;
            dataGridPesquisar.KeyDown += dataGridPesquisar_KeyDown;
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
            // txtPesquisar
            // 
            txtPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisar.CharacterCasing = CharacterCasing.Upper;
            txtPesquisar.Location = new Point(5, 71);
            txtPesquisar.Margin = new Padding(5, 6, 5, 6);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            txtPesquisar.Size = new Size(933, 24);
            txtPesquisar.StateCommon.Back.Color1 = Color.LightGreen;
            txtPesquisar.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtPesquisar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtPesquisar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPesquisar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPesquisar.StateCommon.Border.Rounding = 1F;
            txtPesquisar.StateCommon.Border.Width = 1;
            txtPesquisar.StateCommon.Content.Color1 = Color.Gray;
            txtPesquisar.StateCommon.Content.Font = new Font("Segoe UI", 12.25F);
            txtPesquisar.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtPesquisar.TabIndex = 0;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            txtPesquisar.KeyDown += txtPesquisar_KeyDown;
            // 
            // tlpTitulo
            // 
            tlpTitulo.BackgroundImage = (Image)resources.GetObject("tlpTitulo.BackgroundImage");
            tlpTitulo.BackgroundImageLayout = ImageLayout.None;
            tlpTitulo.ColumnCount = 1;
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTitulo.Controls.Add(lblSubTitulo, 0, 1);
            tlpTitulo.Controls.Add(kryptonPanel3, 0, 0);
            tlpTitulo.Dock = DockStyle.Top;
            tlpTitulo.Location = new Point(0, 0);
            tlpTitulo.Name = "tlpTitulo";
            tlpTitulo.RowCount = 2;
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 66.15385F));
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 33.8461533F));
            tlpTitulo.Size = new Size(941, 65);
            tlpTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            tlpTitulo.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            tlpTitulo.TabIndex = 601;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.Dock = DockStyle.Fill;
            lblSubTitulo.Location = new Point(3, 46);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(935, 16);
            lblSubTitulo.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Color2 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblSubTitulo.StateNormal.ShortText.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTitulo.TabIndex = 0;
            lblSubTitulo.Values.Text = "Pesquisa rápida de preços e estoque";
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(lblTitulo);
            kryptonPanel3.Controls.Add(iconAcao);
            kryptonPanel3.Dock = DockStyle.Fill;
            kryptonPanel3.Location = new Point(3, 3);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(935, 37);
            kryptonPanel3.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            kryptonPanel3.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.Location = new Point(414, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(172, 31);
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Color2 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 14.75F, FontStyle.Bold);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 1091;
            lblTitulo.Values.Text = "Pesquisar Preços";
            // 
            // iconAcao
            // 
            iconAcao.Anchor = AnchorStyles.Top;
            iconAcao.BackColor = Color.Transparent;
            iconAcao.IconChar = FontAwesome.Sharp.IconChar.Tags;
            iconAcao.IconColor = Color.White;
            iconAcao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAcao.IconSize = 42;
            iconAcao.Location = new Point(366, 2);
            iconAcao.Name = "iconAcao";
            iconAcao.Size = new Size(48, 42);
            iconAcao.TabIndex = 1110;
            iconAcao.TabStop = false;
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Items.AddRange(new ToolStripItem[] { lblMensagem });
            kryptonStatusStrip1.Location = new Point(0, 439);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.Professional;
            kryptonStatusStrip1.Size = new Size(941, 22);
            kryptonStatusStrip1.TabIndex = 602;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // lblMensagem
            // 
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(39, 17);
            lblMensagem.Text = "Status";
            // 
            // FrmPesquisarPreco
            // 
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(941, 461);
            Controls.Add(kryptonStatusStrip1);
            Controls.Add(tlpTitulo);
            Controls.Add(txtPesquisar);
            Controls.Add(dataGridPesquisar);
            KeyPreview = true;
            Margin = new Padding(5, 3, 5, 3);
            Name = "FrmPesquisarPreco";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "Pesquisar Preços";
            Load += FrmLocalizarProduto_Load;
            Shown += FrmLocalizarProduto_Shown;
            KeyDown += FrmPesquisarPreco_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dataGridPesquisar).EndInit();
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconAcao).EndInit();
            kryptonStatusStrip1.ResumeLayout(false);
            kryptonStatusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dataGridPesquisar;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public Krypton.Toolkit.KryptonTextBox txtPesquisar;
        private Krypton.Toolkit.KryptonTableLayoutPanel tlpTitulo;
        private Krypton.Toolkit.KryptonLabel lblSubTitulo;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private FontAwesome.Sharp.IconPictureBox iconAcao;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        private ToolStripStatusLabel lblMensagem;
    }
}
