namespace GVC.View
{
    partial class FrmPagamentosParcela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagamentosParcela));
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            dgvPagamentos = new Krypton.Toolkit.KryptonDataGridView();
            panelHeader = new Krypton.Toolkit.KryptonPanel();
            tlpTitulo = new Krypton.Toolkit.KryptonTableLayoutPanel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            lblSubTitulo = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            iconAcao = new FontAwesome.Sharp.IconPictureBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            btnFechar = new FontAwesome.Sharp.IconButton();
            btnEstornar = new FontAwesome.Sharp.IconButton();
            btnRecibo = new FontAwesome.Sharp.IconButton();
            btnGerarPdf = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvPagamentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelHeader).BeginInit();
            panelHeader.SuspendLayout();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconAcao).BeginInit();
            flowLayoutPanel4.SuspendLayout();
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
            // dgvPagamentos
            // 
            dgvPagamentos.Location = new Point(3, 68);
            dgvPagamentos.Name = "dgvPagamentos";
            dgvPagamentos.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            dgvPagamentos.Size = new Size(746, 236);
            dgvPagamentos.TabIndex = 1071;
            dgvPagamentos.CellFormatting += dgvItensVenda_CellFormatting;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(tlpTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(752, 62);
            panelHeader.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            panelHeader.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            panelHeader.TabIndex = 1113;
            // 
            // tlpTitulo
            // 
            tlpTitulo.BackgroundImage = (Image)resources.GetObject("tlpTitulo.BackgroundImage");
            tlpTitulo.BackgroundImageLayout = ImageLayout.None;
            tlpTitulo.ColumnCount = 1;
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTitulo.Controls.Add(kryptonPanel1, 0, 1);
            tlpTitulo.Controls.Add(kryptonPanel3, 0, 0);
            tlpTitulo.Dock = DockStyle.Fill;
            tlpTitulo.Location = new Point(0, 0);
            tlpTitulo.Name = "tlpTitulo";
            tlpTitulo.RowCount = 2;
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 53.2258072F));
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 46.7741928F));
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpTitulo.Size = new Size(752, 62);
            tlpTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            tlpTitulo.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            tlpTitulo.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(lblSubTitulo);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(3, 36);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(746, 23);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            kryptonPanel1.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            kryptonPanel1.TabIndex = 1114;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.Location = new Point(3, 0);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(75, 20);
            lblSubTitulo.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Color2 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblSubTitulo.TabIndex = 0;
            lblSubTitulo.Values.Text = "lblSubTitulo";
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(lblTitulo);
            kryptonPanel3.Controls.Add(iconAcao);
            kryptonPanel3.Dock = DockStyle.Fill;
            kryptonPanel3.Location = new Point(3, 3);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(746, 27);
            kryptonPanel3.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            kryptonPanel3.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(308, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(203, 27);
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Color2 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 1091;
            lblTitulo.Values.Text = "Pagamentos da Parcela";
            // 
            // iconAcao
            // 
            iconAcao.BackColor = Color.Transparent;
            iconAcao.IconChar = FontAwesome.Sharp.IconChar.Coins;
            iconAcao.IconColor = Color.White;
            iconAcao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAcao.IconSize = 28;
            iconAcao.Location = new Point(274, 5);
            iconAcao.Name = "iconAcao";
            iconAcao.Size = new Size(28, 28);
            iconAcao.TabIndex = 1110;
            iconAcao.TabStop = false;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(btnFechar);
            flowLayoutPanel4.Controls.Add(btnEstornar);
            flowLayoutPanel4.Controls.Add(btnRecibo);
            flowLayoutPanel4.Controls.Add(btnGerarPdf);
            flowLayoutPanel4.Dock = DockStyle.Bottom;
            flowLayoutPanel4.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel4.Location = new Point(0, 331);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(752, 41);
            flowLayoutPanel4.TabIndex = 1073;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Gray;
            btnFechar.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnFechar.ForeColor = Color.White;
            btnFechar.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnFechar.IconColor = Color.White;
            btnFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFechar.IconSize = 28;
            btnFechar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFechar.Location = new Point(629, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.Padding = new Padding(10, 0, 10, 0);
            btnFechar.Size = new Size(120, 38);
            btnFechar.TabIndex = 1121;
            btnFechar.Text = "Sair";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnEstornar
            // 
            btnEstornar.BackColor = Color.FromArgb(229, 57, 53);
            btnEstornar.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnEstornar.ForeColor = Color.White;
            btnEstornar.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            btnEstornar.IconColor = Color.White;
            btnEstornar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEstornar.IconSize = 18;
            btnEstornar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstornar.Location = new Point(503, 3);
            btnEstornar.Name = "btnEstornar";
            btnEstornar.Padding = new Padding(10, 0, 10, 0);
            btnEstornar.Size = new Size(120, 38);
            btnEstornar.TabIndex = 1129;
            btnEstornar.TabStop = false;
            btnEstornar.Text = "Estornar";
            btnEstornar.UseVisualStyleBackColor = false;
            // 
            // btnRecibo
            // 
            btnRecibo.BackColor = Color.FromArgb(76, 175, 80);
            btnRecibo.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnRecibo.ForeColor = Color.White;
            btnRecibo.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            btnRecibo.IconColor = Color.White;
            btnRecibo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRecibo.IconSize = 28;
            btnRecibo.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecibo.Location = new Point(377, 3);
            btnRecibo.Name = "btnRecibo";
            btnRecibo.Padding = new Padding(10, 0, 10, 0);
            btnRecibo.Size = new Size(120, 38);
            btnRecibo.TabIndex = 1130;
            btnRecibo.TabStop = false;
            btnRecibo.Text = "    Recibo";
            btnRecibo.UseVisualStyleBackColor = false;
            // 
            // btnGerarPdf
            // 
            btnGerarPdf.BackColor = Color.White;
            btnGerarPdf.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnGerarPdf.ForeColor = Color.FromArgb(30, 136, 229);
            btnGerarPdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnGerarPdf.IconColor = Color.Red;
            btnGerarPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGerarPdf.IconSize = 28;
            btnGerarPdf.ImageAlign = ContentAlignment.MiddleLeft;
            btnGerarPdf.Location = new Point(251, 3);
            btnGerarPdf.Name = "btnGerarPdf";
            btnGerarPdf.Padding = new Padding(10, 0, 10, 0);
            btnGerarPdf.Size = new Size(120, 38);
            btnGerarPdf.TabIndex = 1131;
            btnGerarPdf.Text = "PDF";
            btnGerarPdf.UseVisualStyleBackColor = false;
            // 
            // FrmPagamentosParcela
            // 
            BackColor = Color.FromArgb(250, 252, 252);
            ClientSize = new Size(752, 372);
            Controls.Add(dgvPagamentos);
            Controls.Add(panelHeader);
            Controls.Add(flowLayoutPanel4);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmPagamentosParcela";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "Pagamentos da Parcela";
            Load += FrmItensVenda_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPagamentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelHeader).EndInit();
            panelHeader.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconAcao).EndInit();
            flowLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblRotulo;
        public Krypton.Toolkit.KryptonTextBox txtCaminhoBackup;
        private Krypton.Toolkit.KryptonButton btnLocalBackup;
        private Krypton.Toolkit.KryptonButton btnExecutar;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonRadioButton rbtGerarBackup;
        private Krypton.Toolkit.KryptonRadioButton rbtRestaurarBackup;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        private ToolStripStatusLabel lblMensagem;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonDataGridView dgvPagamentos;
        private Krypton.Toolkit.KryptonPanel panelHeader;
        private Krypton.Toolkit.KryptonTableLayoutPanel tlpTitulo;
        private Krypton.Toolkit.KryptonLabel lblSubTitulo;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private FontAwesome.Sharp.IconPictureBox iconAcao;
        private FlowLayoutPanel flowLayoutPanel4;
        private Krypton.Toolkit.KryptonButton btnSair;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private FontAwesome.Sharp.IconButton btnFechar;
        private FontAwesome.Sharp.IconButton btnEstornar;
        private FontAwesome.Sharp.IconButton btnRecibo;
        private FontAwesome.Sharp.IconButton btnGerarPdf;
    }
}
