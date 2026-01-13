namespace GVC.View
{
    partial class FrmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackup));
            lblRotulo = new Label();
            txtCaminhoBackup = new Krypton.Toolkit.KryptonTextBox();
            rbtGerarBackup = new Krypton.Toolkit.KryptonRadioButton();
            rbtRestaurarBackup = new Krypton.Toolkit.KryptonRadioButton();
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            lblStatus = new ToolStripStatusLabel();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            pnlHeader = new Krypton.Toolkit.KryptonPanel();
            tlpTitulo = new Krypton.Toolkit.KryptonTableLayoutPanel();
            lblSubTitulo = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            iconAcao = new FontAwesome.Sharp.IconPictureBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            btnLocalBackup = new FontAwesome.Sharp.IconButton();
            iconCaminho = new FontAwesome.Sharp.IconPictureBox();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            btnSair = new FontAwesome.Sharp.IconButton();
            btnExecutar = new FontAwesome.Sharp.IconButton();
            kryptonStatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).BeginInit();
            pnlHeader.SuspendLayout();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconAcao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCaminho).BeginInit();
            SuspendLayout();
            // 
            // lblRotulo
            // 
            lblRotulo.AutoSize = true;
            lblRotulo.BackColor = Color.Transparent;
            lblRotulo.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotulo.Location = new Point(9, 34);
            lblRotulo.Name = "lblRotulo";
            lblRotulo.Size = new Size(56, 15);
            lblRotulo.TabIndex = 1013;
            lblRotulo.Text = "Caminho";
            // 
            // txtCaminhoBackup
            // 
            txtCaminhoBackup.Location = new Point(6, 52);
            txtCaminhoBackup.Name = "txtCaminhoBackup";
            txtCaminhoBackup.Size = new Size(536, 22);
            txtCaminhoBackup.StateCommon.Back.Color1 = Color.White;
            txtCaminhoBackup.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtCaminhoBackup.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtCaminhoBackup.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtCaminhoBackup.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtCaminhoBackup.StateCommon.Border.Rounding = 6F;
            txtCaminhoBackup.StateCommon.Border.Width = 1;
            txtCaminhoBackup.StateCommon.Content.Color1 = Color.Gray;
            txtCaminhoBackup.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtCaminhoBackup.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtCaminhoBackup.TabIndex = 1012;
            // 
            // rbtGerarBackup
            // 
            rbtGerarBackup.Location = new Point(82, 25);
            rbtGerarBackup.Name = "rbtGerarBackup";
            rbtGerarBackup.Size = new Size(154, 21);
            rbtGerarBackup.StateCommon.ShortText.Font = new Font("Segoe UI", 9.75F);
            rbtGerarBackup.TabIndex = 1028;
            rbtGerarBackup.Values.Text = "Criar backp dos dados";
            rbtGerarBackup.CheckedChanged += rbtGerarBackup_CheckedChanged;
            // 
            // rbtRestaurarBackup
            // 
            rbtRestaurarBackup.Location = new Point(82, 53);
            rbtRestaurarBackup.Name = "rbtRestaurarBackup";
            rbtRestaurarBackup.Size = new Size(193, 21);
            rbtRestaurarBackup.StateCommon.ShortText.Font = new Font("Segoe UI", 9.75F);
            rbtRestaurarBackup.TabIndex = 1029;
            rbtRestaurarBackup.Values.Text = "Restaurar backups existentes";
            rbtRestaurarBackup.CheckedChanged += rbtRestaurarBackup_CheckedChanged;
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            kryptonStatusStrip1.Location = new Point(0, 369);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.Professional;
            kryptonStatusStrip1.Size = new Size(597, 22);
            kryptonStatusStrip1.TabIndex = 1030;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 17);
            lblStatus.Text = "Status";
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
            // pnlHeader
            // 
            pnlHeader.Controls.Add(tlpTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(597, 59);
            pnlHeader.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            pnlHeader.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            pnlHeader.TabIndex = 1098;
            // 
            // tlpTitulo
            // 
            tlpTitulo.BackgroundImage = (Image)resources.GetObject("tlpTitulo.BackgroundImage");
            tlpTitulo.BackgroundImageLayout = ImageLayout.None;
            tlpTitulo.ColumnCount = 1;
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTitulo.Controls.Add(lblSubTitulo, 0, 1);
            tlpTitulo.Controls.Add(kryptonPanel3, 0, 0);
            tlpTitulo.Dock = DockStyle.Fill;
            tlpTitulo.Location = new Point(0, 0);
            tlpTitulo.Name = "tlpTitulo";
            tlpTitulo.RowCount = 2;
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 57.6271172F));
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 42.3728828F));
            tlpTitulo.Size = new Size(597, 59);
            tlpTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            tlpTitulo.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            tlpTitulo.TabIndex = 0;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.Dock = DockStyle.Fill;
            lblSubTitulo.Location = new Point(3, 37);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(591, 19);
            lblSubTitulo.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Color2 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblSubTitulo.TabIndex = 0;
            lblSubTitulo.Values.Text = "Ferramenta para salvar e recuperar dados essenciais";
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(iconPictureBox1);
            kryptonPanel3.Controls.Add(lblTitulo);
            kryptonPanel3.Dock = DockStyle.Fill;
            kryptonPanel3.Location = new Point(3, 3);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(591, 28);
            kryptonPanel3.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            kryptonPanel3.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top;
            iconPictureBox1.BackColor = Color.FromArgb(30, 136, 229);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Database;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(206, -1);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 1102;
            iconPictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.Location = new Point(244, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(154, 27);
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Color2 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 1091;
            lblTitulo.Values.Text = "Backup e Restore";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel1.Controls.Add(iconAcao);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Controls.Add(rbtRestaurarBackup);
            kryptonPanel1.Controls.Add(rbtGerarBackup);
            kryptonPanel1.Location = new Point(3, 93);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueLightMode;
            kryptonPanel1.Size = new Size(594, 81);
            kryptonPanel1.TabIndex = 1100;
            // 
            // iconAcao
            // 
            iconAcao.BackColor = Color.Transparent;
            iconAcao.ForeColor = Color.FromArgb(30, 136, 229);
            iconAcao.IconChar = FontAwesome.Sharp.IconChar.Upload;
            iconAcao.IconColor = Color.FromArgb(30, 136, 229);
            iconAcao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAcao.IconSize = 28;
            iconAcao.Location = new Point(0, 0);
            iconAcao.Name = "iconAcao";
            iconAcao.Size = new Size(28, 28);
            iconAcao.TabIndex = 1105;
            iconAcao.TabStop = false;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(39, 4);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(39, 20);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 1038;
            kryptonLabel1.Values.Text = "Ação";
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel2.Controls.Add(btnLocalBackup);
            kryptonPanel2.Controls.Add(iconCaminho);
            kryptonPanel2.Controls.Add(kryptonLabel2);
            kryptonPanel2.Controls.Add(txtCaminhoBackup);
            kryptonPanel2.Controls.Add(lblRotulo);
            kryptonPanel2.Location = new Point(3, 198);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueLightMode;
            kryptonPanel2.Size = new Size(591, 83);
            kryptonPanel2.TabIndex = 1101;
            // 
            // btnLocalBackup
            // 
            btnLocalBackup.BackColor = Color.Transparent;
            btnLocalBackup.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            btnLocalBackup.IconColor = Color.FromArgb(30, 136, 229);
            btnLocalBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLocalBackup.IconSize = 32;
            btnLocalBackup.Location = new Point(548, 45);
            btnLocalBackup.Name = "btnLocalBackup";
            btnLocalBackup.Size = new Size(34, 32);
            btnLocalBackup.TabIndex = 1107;
            btnLocalBackup.UseVisualStyleBackColor = false;
            btnLocalBackup.Click += btnLocalBackup_Click;
            // 
            // iconCaminho
            // 
            iconCaminho.BackColor = Color.Transparent;
            iconCaminho.ForeColor = Color.FromArgb(30, 136, 229);
            iconCaminho.IconChar = FontAwesome.Sharp.IconChar.Upload;
            iconCaminho.IconColor = Color.FromArgb(30, 136, 229);
            iconCaminho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCaminho.IconSize = 28;
            iconCaminho.Location = new Point(5, 0);
            iconCaminho.Name = "iconCaminho";
            iconCaminho.Size = new Size(28, 28);
            iconCaminho.TabIndex = 1106;
            iconCaminho.TabStop = false;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(39, 4);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(167, 20);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 1038;
            kryptonLabel2.Values.Text = "Local de destino dos dados";
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Orange;
            btnSair.Font = new Font("Poppins Medium", 9F, FontStyle.Bold);
            btnSair.ForeColor = Color.White;
            btnSair.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSair.IconColor = Color.Black;
            btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSair.Location = new Point(252, 328);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(170, 38);
            btnSair.TabIndex = 1103;
            btnSair.Text = "Cancelar";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnExecutar
            // 
            btnExecutar.BackColor = Color.FromArgb(30, 136, 229);
            btnExecutar.Font = new Font("Poppins Medium", 9F, FontStyle.Bold);
            btnExecutar.ForeColor = Color.White;
            btnExecutar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnExecutar.IconColor = Color.Black;
            btnExecutar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExecutar.IconSize = 18;
            btnExecutar.ImageAlign = ContentAlignment.MiddleLeft;
            btnExecutar.Location = new Point(425, 328);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Padding = new Padding(10, 0, 10, 0);
            btnExecutar.Size = new Size(170, 38);
            btnExecutar.TabIndex = 1104;
            btnExecutar.Text = "Gerar";
            btnExecutar.UseVisualStyleBackColor = false;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // FrmBackup
            // 
            BackColor = Color.FromArgb(250, 252, 252);
            ClientSize = new Size(597, 391);
            Controls.Add(btnExecutar);
            Controls.Add(btnSair);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonPanel1);
            Controls.Add(pnlHeader);
            Controls.Add(kryptonStatusStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmBackup";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "Backup e Restauração";
            Load += FrmBackup_Load;
            kryptonStatusStrip1.ResumeLayout(false);
            kryptonStatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).EndInit();
            pnlHeader.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconAcao).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCaminho).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRotulo;
        public Krypton.Toolkit.KryptonTextBox txtCaminhoBackup;
        private Krypton.Toolkit.KryptonRadioButton rbtGerarBackup;
        private Krypton.Toolkit.KryptonRadioButton rbtRestaurarBackup;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        private ToolStripStatusLabel lblStatus;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonPanel pnlHeader;
        private Krypton.Toolkit.KryptonTableLayoutPanel tlpTitulo;
        private Krypton.Toolkit.KryptonLabel lblSubTitulo;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnSair;
        private FontAwesome.Sharp.IconButton btnExecutar;
        private FontAwesome.Sharp.IconPictureBox iconAcao;
        private FontAwesome.Sharp.IconPictureBox iconCaminho;
        private FontAwesome.Sharp.IconButton btnLocalBackup;
    }
}
