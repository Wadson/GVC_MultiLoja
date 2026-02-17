namespace GVC.View
{
    partial class FrmConfiguracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracoes));
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            label1 = new Label();
            pnlHeader = new Krypton.Toolkit.KryptonPanel();
            tlpTitulo = new Krypton.Toolkit.KryptonTableLayoutPanel();
            lblSubTitulo = new Krypton.Toolkit.KryptonLabel();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            icbtnBackup = new FontAwesome.Sharp.IconButton();
            icbConvertScript = new FontAwesome.Sharp.IconButton();
            icbtnModeloUi = new FontAwesome.Sharp.IconButton();
            icbtnLogo = new FontAwesome.Sharp.IconButton();
            icbtnCertificadoDigital = new FontAwesome.Sharp.IconButton();
            icbtnDadosFiscais = new FontAwesome.Sharp.IconButton();
            icbtnSair = new FontAwesome.Sharp.IconButton();
            btnListarMetodosGeral = new FontAwesome.Sharp.IconButton();
            btnListarEstruturaPastasProjeto = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).BeginInit();
            pnlHeader.SuspendLayout();
            tlpTitulo.SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = Color.FromArgb(0, 76, 172);
            label1.Location = new Point(0, 59);
            label1.Name = "label1";
            label1.Size = new Size(319, 17);
            label1.TabIndex = 1097;
            label1.Text = "Aqui ficam as ferramentas administrativas do sistema";
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(tlpTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(577, 47);
            pnlHeader.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            pnlHeader.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            pnlHeader.TabIndex = 1096;
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
            tlpTitulo.Size = new Size(577, 47);
            tlpTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            tlpTitulo.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            tlpTitulo.TabIndex = 0;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.Dock = DockStyle.Fill;
            lblSubTitulo.Location = new Point(3, 25);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(571, 19);
            lblSubTitulo.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Color2 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblSubTitulo.TabIndex = 0;
            lblSubTitulo.Values.Text = "Configurações e utilitários do sistema";
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Location = new Point(3, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(571, 16);
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Color2 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 1091;
            lblTitulo.Values.Text = "Ferramentas Administrativas do Sistema";
            // 
            // icbtnBackup
            // 
            icbtnBackup.Cursor = Cursors.Hand;
            icbtnBackup.FlatStyle = FlatStyle.Flat;
            icbtnBackup.ForeColor = Color.FromArgb(55, 71, 79);
            icbtnBackup.IconChar = FontAwesome.Sharp.IconChar.Database;
            icbtnBackup.IconColor = Color.FromArgb(30, 136, 229);
            icbtnBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbtnBackup.IconSize = 38;
            icbtnBackup.ImageAlign = ContentAlignment.MiddleLeft;
            icbtnBackup.Location = new Point(89, 118);
            icbtnBackup.Name = "icbtnBackup";
            icbtnBackup.Size = new Size(200, 46);
            icbtnBackup.TabIndex = 1098;
            icbtnBackup.Text = "Backup";
            icbtnBackup.TextAlign = ContentAlignment.MiddleRight;
            icbtnBackup.TextImageRelation = TextImageRelation.TextBeforeImage;
            icbtnBackup.UseVisualStyleBackColor = true;
            icbtnBackup.Click += icbtnBackup_Click;
            // 
            // icbConvertScript
            // 
            icbConvertScript.Cursor = Cursors.Hand;
            icbConvertScript.FlatStyle = FlatStyle.Flat;
            icbConvertScript.ForeColor = Color.FromArgb(55, 71, 79);
            icbConvertScript.IconChar = FontAwesome.Sharp.IconChar.Server;
            icbConvertScript.IconColor = Color.FromArgb(30, 136, 229);
            icbConvertScript.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbConvertScript.IconSize = 38;
            icbConvertScript.ImageAlign = ContentAlignment.MiddleLeft;
            icbConvertScript.Location = new Point(295, 118);
            icbConvertScript.Name = "icbConvertScript";
            icbConvertScript.Size = new Size(200, 46);
            icbConvertScript.TabIndex = 1099;
            icbConvertScript.Text = "Converter Script";
            icbConvertScript.TextAlign = ContentAlignment.MiddleRight;
            icbConvertScript.TextImageRelation = TextImageRelation.TextBeforeImage;
            icbConvertScript.UseVisualStyleBackColor = true;
            icbConvertScript.Click += icbConvertScript_Click;
            // 
            // icbtnModeloUi
            // 
            icbtnModeloUi.Cursor = Cursors.Hand;
            icbtnModeloUi.FlatStyle = FlatStyle.Flat;
            icbtnModeloUi.ForeColor = Color.FromArgb(55, 71, 79);
            icbtnModeloUi.IconChar = FontAwesome.Sharp.IconChar.Paintbrush;
            icbtnModeloUi.IconColor = Color.FromArgb(30, 136, 229);
            icbtnModeloUi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbtnModeloUi.IconSize = 38;
            icbtnModeloUi.ImageAlign = ContentAlignment.MiddleLeft;
            icbtnModeloUi.Location = new Point(89, 170);
            icbtnModeloUi.Name = "icbtnModeloUi";
            icbtnModeloUi.Size = new Size(200, 46);
            icbtnModeloUi.TabIndex = 1100;
            icbtnModeloUi.Text = "Modelo UI";
            icbtnModeloUi.TextAlign = ContentAlignment.MiddleRight;
            icbtnModeloUi.TextImageRelation = TextImageRelation.TextBeforeImage;
            icbtnModeloUi.UseVisualStyleBackColor = true;
            // 
            // icbtnLogo
            // 
            icbtnLogo.Cursor = Cursors.Hand;
            icbtnLogo.FlatStyle = FlatStyle.Flat;
            icbtnLogo.ForeColor = Color.FromArgb(55, 71, 79);
            icbtnLogo.IconChar = FontAwesome.Sharp.IconChar.Image;
            icbtnLogo.IconColor = Color.FromArgb(30, 136, 229);
            icbtnLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbtnLogo.IconSize = 38;
            icbtnLogo.ImageAlign = ContentAlignment.MiddleLeft;
            icbtnLogo.Location = new Point(295, 170);
            icbtnLogo.Name = "icbtnLogo";
            icbtnLogo.Size = new Size(200, 46);
            icbtnLogo.TabIndex = 1101;
            icbtnLogo.Text = "Logo";
            icbtnLogo.TextAlign = ContentAlignment.MiddleRight;
            icbtnLogo.TextImageRelation = TextImageRelation.TextBeforeImage;
            icbtnLogo.UseVisualStyleBackColor = true;
            icbtnLogo.Click += icbtnLogo_Click;
            // 
            // icbtnCertificadoDigital
            // 
            icbtnCertificadoDigital.Cursor = Cursors.Hand;
            icbtnCertificadoDigital.FlatStyle = FlatStyle.Flat;
            icbtnCertificadoDigital.ForeColor = Color.FromArgb(55, 71, 79);
            icbtnCertificadoDigital.IconChar = FontAwesome.Sharp.IconChar.Key;
            icbtnCertificadoDigital.IconColor = Color.FromArgb(30, 136, 229);
            icbtnCertificadoDigital.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbtnCertificadoDigital.IconSize = 38;
            icbtnCertificadoDigital.ImageAlign = ContentAlignment.MiddleLeft;
            icbtnCertificadoDigital.Location = new Point(89, 222);
            icbtnCertificadoDigital.Name = "icbtnCertificadoDigital";
            icbtnCertificadoDigital.Size = new Size(200, 46);
            icbtnCertificadoDigital.TabIndex = 1102;
            icbtnCertificadoDigital.Text = "Certificado Digital";
            icbtnCertificadoDigital.TextAlign = ContentAlignment.MiddleRight;
            icbtnCertificadoDigital.TextImageRelation = TextImageRelation.TextBeforeImage;
            icbtnCertificadoDigital.UseVisualStyleBackColor = true;
            icbtnCertificadoDigital.Click += icbtnCertificadoDigital_Click;
            // 
            // icbtnDadosFiscais
            // 
            icbtnDadosFiscais.Cursor = Cursors.Hand;
            icbtnDadosFiscais.FlatStyle = FlatStyle.Flat;
            icbtnDadosFiscais.ForeColor = Color.FromArgb(55, 71, 79);
            icbtnDadosFiscais.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            icbtnDadosFiscais.IconColor = Color.FromArgb(30, 136, 229);
            icbtnDadosFiscais.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbtnDadosFiscais.IconSize = 38;
            icbtnDadosFiscais.ImageAlign = ContentAlignment.MiddleLeft;
            icbtnDadosFiscais.Location = new Point(295, 222);
            icbtnDadosFiscais.Name = "icbtnDadosFiscais";
            icbtnDadosFiscais.Size = new Size(200, 46);
            icbtnDadosFiscais.TabIndex = 1103;
            icbtnDadosFiscais.Text = "Dados Fiscais";
            icbtnDadosFiscais.TextAlign = ContentAlignment.MiddleRight;
            icbtnDadosFiscais.TextImageRelation = TextImageRelation.TextBeforeImage;
            icbtnDadosFiscais.UseVisualStyleBackColor = true;
            icbtnDadosFiscais.Click += icbtnDadosFiscais_Click;
            // 
            // icbtnSair
            // 
            icbtnSair.BackColor = Color.Firebrick;
            icbtnSair.Cursor = Cursors.Hand;
            icbtnSair.FlatAppearance.BorderSize = 0;
            icbtnSair.FlatStyle = FlatStyle.Flat;
            icbtnSair.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icbtnSair.ForeColor = Color.White;
            icbtnSair.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            icbtnSair.IconColor = Color.White;
            icbtnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbtnSair.IconSize = 22;
            icbtnSair.ImageAlign = ContentAlignment.MiddleLeft;
            icbtnSair.Location = new Point(295, 356);
            icbtnSair.Name = "icbtnSair";
            icbtnSair.Size = new Size(200, 46);
            icbtnSair.TabIndex = 1104;
            icbtnSair.Text = "Sair";
            icbtnSair.TextAlign = ContentAlignment.MiddleRight;
            icbtnSair.TextImageRelation = TextImageRelation.TextBeforeImage;
            icbtnSair.UseVisualStyleBackColor = false;
            icbtnSair.Click += icbtnSair_Click;
            // 
            // btnListarMetodosGeral
            // 
            btnListarMetodosGeral.Cursor = Cursors.Hand;
            btnListarMetodosGeral.FlatStyle = FlatStyle.Flat;
            btnListarMetodosGeral.ForeColor = Color.FromArgb(55, 71, 79);
            btnListarMetodosGeral.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            btnListarMetodosGeral.IconColor = Color.FromArgb(30, 136, 229);
            btnListarMetodosGeral.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListarMetodosGeral.IconSize = 38;
            btnListarMetodosGeral.ImageAlign = ContentAlignment.MiddleLeft;
            btnListarMetodosGeral.Location = new Point(295, 274);
            btnListarMetodosGeral.Name = "btnListarMetodosGeral";
            btnListarMetodosGeral.Size = new Size(200, 46);
            btnListarMetodosGeral.TabIndex = 1105;
            btnListarMetodosGeral.Text = "Listar Todos os Métodos";
            btnListarMetodosGeral.TextAlign = ContentAlignment.MiddleRight;
            btnListarMetodosGeral.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnListarMetodosGeral.UseVisualStyleBackColor = true;
            btnListarMetodosGeral.Click += btnListarMetodosGeral_Click;
            // 
            // btnListarEstruturaPastasProjeto
            // 
            btnListarEstruturaPastasProjeto.Cursor = Cursors.Hand;
            btnListarEstruturaPastasProjeto.FlatStyle = FlatStyle.Flat;
            btnListarEstruturaPastasProjeto.ForeColor = Color.FromArgb(55, 71, 79);
            btnListarEstruturaPastasProjeto.IconChar = FontAwesome.Sharp.IconChar.FolderTree;
            btnListarEstruturaPastasProjeto.IconColor = Color.FromArgb(30, 136, 229);
            btnListarEstruturaPastasProjeto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListarEstruturaPastasProjeto.IconSize = 38;
            btnListarEstruturaPastasProjeto.ImageAlign = ContentAlignment.MiddleLeft;
            btnListarEstruturaPastasProjeto.Location = new Point(89, 274);
            btnListarEstruturaPastasProjeto.Name = "btnListarEstruturaPastasProjeto";
            btnListarEstruturaPastasProjeto.Size = new Size(200, 46);
            btnListarEstruturaPastasProjeto.TabIndex = 1106;
            btnListarEstruturaPastasProjeto.Text = "Listar Estrutura de  Pastas";
            btnListarEstruturaPastasProjeto.TextAlign = ContentAlignment.MiddleRight;
            btnListarEstruturaPastasProjeto.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnListarEstruturaPastasProjeto.UseVisualStyleBackColor = true;
            btnListarEstruturaPastasProjeto.Click += btnListarEstruturaPastasProjeto_Click;
            // 
            // FrmConfiguracoes
            // 
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(577, 414);
            ControlBox = false;
            Controls.Add(btnListarEstruturaPastasProjeto);
            Controls.Add(btnListarMetodosGeral);
            Controls.Add(icbtnSair);
            Controls.Add(icbtnDadosFiscais);
            Controls.Add(icbtnCertificadoDigital);
            Controls.Add(icbtnLogo);
            Controls.Add(icbtnModeloUi);
            Controls.Add(icbConvertScript);
            Controls.Add(icbtnBackup);
            Controls.Add(label1);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConfiguracoes";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "Ferramentas administrativas";
            Load += FrmConfiguracoes_Load;
            ((System.ComponentModel.ISupportInitialize)pnlHeader).EndInit();
            pnlHeader.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonButton txtBackup;
        private Krypton.Toolkit.KryptonButton btnSair;
        private Krypton.Toolkit.KryptonButton InsertBanco;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Label label1;
        private Krypton.Toolkit.KryptonPanel pnlHeader;
        private Krypton.Toolkit.KryptonTableLayoutPanel tlpTitulo;
        private Krypton.Toolkit.KryptonLabel lblSubTitulo;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private FontAwesome.Sharp.IconButton icbtnBackup;
        private FontAwesome.Sharp.IconButton icbConvertScript;
        private FontAwesome.Sharp.IconButton icbtnModeloUi;
        private FontAwesome.Sharp.IconButton icbtnLogo;
        private FontAwesome.Sharp.IconButton icbtnCertificadoDigital;
        private FontAwesome.Sharp.IconButton icbtnDadosFiscais;
        private FontAwesome.Sharp.IconButton icbtnSair;
        private FontAwesome.Sharp.IconButton btnListarMetodosGeral;
        private FontAwesome.Sharp.IconButton btnListarEstruturaPastasProjeto;
    }
}
