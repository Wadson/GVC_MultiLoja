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
            txtBackup = new Krypton.Toolkit.KryptonButton();
            btnSair = new Krypton.Toolkit.KryptonButton();
            InsertBanco = new Krypton.Toolkit.KryptonButton();
            FrmModeloUI = new Krypton.Toolkit.KryptonButton();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            btnLogo = new Krypton.Toolkit.KryptonButton();
            btnCertificadoDigital = new Krypton.Toolkit.KryptonButton();
            btnDadosFiscais = new Krypton.Toolkit.KryptonButton();
            kryptonTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBackup
            // 
            txtBackup.CornerRoundingRadius = 10F;
            txtBackup.Location = new Point(18, 44);
            txtBackup.Name = "txtBackup";
            txtBackup.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            txtBackup.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            txtBackup.OverrideDefault.Back.ColorAngle = 45F;
            txtBackup.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtBackup.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtBackup.OverrideDefault.Border.ColorAngle = 45F;
            txtBackup.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtBackup.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtBackup.OverrideDefault.Border.Rounding = 20F;
            txtBackup.OverrideDefault.Border.Width = 1;
            txtBackup.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            txtBackup.Size = new Size(130, 27);
            txtBackup.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            txtBackup.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            txtBackup.StateCommon.Back.ColorAngle = 45F;
            txtBackup.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            txtBackup.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtBackup.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtBackup.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtBackup.StateCommon.Border.Rounding = 10F;
            txtBackup.StateCommon.Border.Width = 1;
            txtBackup.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            txtBackup.StateCommon.Content.ShortText.Color2 = Color.White;
            txtBackup.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F);
            txtBackup.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            txtBackup.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            txtBackup.StatePressed.Back.ColorAngle = 135F;
            txtBackup.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            txtBackup.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            txtBackup.StatePressed.Border.ColorAngle = 135F;
            txtBackup.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtBackup.StatePressed.Border.Rounding = 20F;
            txtBackup.StatePressed.Border.Width = 1;
            txtBackup.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            txtBackup.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            txtBackup.StateTracking.Back.ColorAngle = 45F;
            txtBackup.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            txtBackup.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtBackup.StateTracking.Border.ColorAngle = 45F;
            txtBackup.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtBackup.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtBackup.StateTracking.Border.Rounding = 20F;
            txtBackup.StateTracking.Border.Width = 1;
            txtBackup.StateTracking.Content.ShortText.Color1 = Color.White;
            txtBackup.TabIndex = 596;
            txtBackup.Values.Text = "&Backup";
            txtBackup.Click += txtBackup_Click;
            // 
            // btnSair
            // 
            btnSair.CornerRoundingRadius = 10F;
            btnSair.Location = new Point(148, 143);
            btnSair.Name = "btnSair";
            btnSair.OverrideDefault.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Back.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Border.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.OverrideDefault.Border.Rounding = 20F;
            btnSair.OverrideDefault.Border.Width = 1;
            btnSair.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSair.Size = new Size(130, 27);
            btnSair.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnSair.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnSair.StateCommon.Back.ColorAngle = 45F;
            btnSair.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateCommon.Border.Rounding = 10F;
            btnSair.StateCommon.Border.Width = 1;
            btnSair.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSair.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSair.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnSair.StateDisabled.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.StateDisabled.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateDisabled.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateDisabled.Content.ShortText.Color1 = Color.White;
            btnSair.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.StateNormal.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateNormal.Content.LongText.Color1 = Color.White;
            btnSair.StateNormal.Content.LongText.Color2 = Color.White;
            btnSair.StateNormal.Content.ShortText.Color1 = Color.White;
            btnSair.StateNormal.Content.ShortText.Color2 = Color.White;
            btnSair.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StatePressed.Back.ColorAngle = 135F;
            btnSair.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StatePressed.Border.ColorAngle = 135F;
            btnSair.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StatePressed.Border.Rounding = 20F;
            btnSair.StatePressed.Border.Width = 1;
            btnSair.StatePressed.Content.LongText.Color1 = Color.White;
            btnSair.StatePressed.Content.LongText.Color2 = Color.White;
            btnSair.StatePressed.Content.ShortText.Color1 = Color.White;
            btnSair.StatePressed.Content.ShortText.Color2 = Color.White;
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
            btnSair.StateTracking.Content.ShortText.Color1 = Color.White;
            btnSair.TabIndex = 1019;
            btnSair.Values.Text = "&Sair";
            btnSair.Click += btnSair_Click;
            // 
            // InsertBanco
            // 
            InsertBanco.CornerRoundingRadius = 10F;
            InsertBanco.Location = new Point(148, 44);
            InsertBanco.Name = "InsertBanco";
            InsertBanco.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            InsertBanco.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            InsertBanco.OverrideDefault.Back.ColorAngle = 45F;
            InsertBanco.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            InsertBanco.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            InsertBanco.OverrideDefault.Border.ColorAngle = 45F;
            InsertBanco.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            InsertBanco.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            InsertBanco.OverrideDefault.Border.Rounding = 20F;
            InsertBanco.OverrideDefault.Border.Width = 1;
            InsertBanco.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            InsertBanco.Size = new Size(130, 27);
            InsertBanco.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            InsertBanco.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            InsertBanco.StateCommon.Back.ColorAngle = 45F;
            InsertBanco.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            InsertBanco.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            InsertBanco.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            InsertBanco.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            InsertBanco.StateCommon.Border.Rounding = 10F;
            InsertBanco.StateCommon.Border.Width = 1;
            InsertBanco.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            InsertBanco.StateCommon.Content.ShortText.Color2 = Color.White;
            InsertBanco.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F);
            InsertBanco.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            InsertBanco.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            InsertBanco.StatePressed.Back.ColorAngle = 135F;
            InsertBanco.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            InsertBanco.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            InsertBanco.StatePressed.Border.ColorAngle = 135F;
            InsertBanco.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            InsertBanco.StatePressed.Border.Rounding = 20F;
            InsertBanco.StatePressed.Border.Width = 1;
            InsertBanco.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            InsertBanco.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            InsertBanco.StateTracking.Back.ColorAngle = 45F;
            InsertBanco.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            InsertBanco.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            InsertBanco.StateTracking.Border.ColorAngle = 45F;
            InsertBanco.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            InsertBanco.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            InsertBanco.StateTracking.Border.Rounding = 20F;
            InsertBanco.StateTracking.Border.Width = 1;
            InsertBanco.StateTracking.Content.ShortText.Color1 = Color.White;
            InsertBanco.TabIndex = 1021;
            InsertBanco.Values.Text = "Insert Banco";
            InsertBanco.Click += InsertBanco_Click;
            // 
            // FrmModeloUI
            // 
            FrmModeloUI.CornerRoundingRadius = 10F;
            FrmModeloUI.Location = new Point(18, 77);
            FrmModeloUI.Name = "FrmModeloUI";
            FrmModeloUI.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            FrmModeloUI.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            FrmModeloUI.OverrideDefault.Back.ColorAngle = 45F;
            FrmModeloUI.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            FrmModeloUI.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            FrmModeloUI.OverrideDefault.Border.ColorAngle = 45F;
            FrmModeloUI.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            FrmModeloUI.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            FrmModeloUI.OverrideDefault.Border.Rounding = 20F;
            FrmModeloUI.OverrideDefault.Border.Width = 1;
            FrmModeloUI.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            FrmModeloUI.Size = new Size(130, 27);
            FrmModeloUI.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            FrmModeloUI.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            FrmModeloUI.StateCommon.Back.ColorAngle = 45F;
            FrmModeloUI.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            FrmModeloUI.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            FrmModeloUI.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            FrmModeloUI.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            FrmModeloUI.StateCommon.Border.Rounding = 10F;
            FrmModeloUI.StateCommon.Border.Width = 1;
            FrmModeloUI.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            FrmModeloUI.StateCommon.Content.ShortText.Color2 = Color.White;
            FrmModeloUI.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F);
            FrmModeloUI.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            FrmModeloUI.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            FrmModeloUI.StatePressed.Back.ColorAngle = 135F;
            FrmModeloUI.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            FrmModeloUI.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            FrmModeloUI.StatePressed.Border.ColorAngle = 135F;
            FrmModeloUI.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            FrmModeloUI.StatePressed.Border.Rounding = 20F;
            FrmModeloUI.StatePressed.Border.Width = 1;
            FrmModeloUI.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            FrmModeloUI.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            FrmModeloUI.StateTracking.Back.ColorAngle = 45F;
            FrmModeloUI.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            FrmModeloUI.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            FrmModeloUI.StateTracking.Border.ColorAngle = 45F;
            FrmModeloUI.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            FrmModeloUI.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            FrmModeloUI.StateTracking.Border.Rounding = 20F;
            FrmModeloUI.StateTracking.Border.Width = 1;
            FrmModeloUI.StateTracking.Content.ShortText.Color1 = Color.White;
            FrmModeloUI.TabIndex = 1022;
            FrmModeloUI.Values.Text = "Form Modelo UI";
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
            // kryptonTableLayoutPanel1
            // 
            kryptonTableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("kryptonTableLayoutPanel1.BackgroundImage");
            kryptonTableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            kryptonTableLayoutPanel1.ColumnCount = 1;
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            kryptonTableLayoutPanel1.Controls.Add(kryptonLabel1, 0, 0);
            kryptonTableLayoutPanel1.Dock = DockStyle.Top;
            kryptonTableLayoutPanel1.Location = new Point(0, 0);
            kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            kryptonTableLayoutPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueLightMode;
            kryptonTableLayoutPanel1.RowCount = 1;
            kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            kryptonTableLayoutPanel1.Size = new Size(301, 26);
            kryptonTableLayoutPanel1.TabIndex = 1023;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Dock = DockStyle.Fill;
            kryptonLabel1.Location = new Point(3, 3);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(295, 20);
            kryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.TabIndex = 1026;
            kryptonLabel1.Values.Text = "Ferramentas";
            // 
            // btnLogo
            // 
            btnLogo.CornerRoundingRadius = 10F;
            btnLogo.Location = new Point(148, 77);
            btnLogo.Name = "btnLogo";
            btnLogo.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnLogo.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnLogo.OverrideDefault.Back.ColorAngle = 45F;
            btnLogo.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnLogo.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLogo.OverrideDefault.Border.ColorAngle = 45F;
            btnLogo.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogo.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLogo.OverrideDefault.Border.Rounding = 20F;
            btnLogo.OverrideDefault.Border.Width = 1;
            btnLogo.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnLogo.Size = new Size(130, 27);
            btnLogo.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnLogo.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnLogo.StateCommon.Back.ColorAngle = 45F;
            btnLogo.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLogo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLogo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogo.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLogo.StateCommon.Border.Rounding = 10F;
            btnLogo.StateCommon.Border.Width = 1;
            btnLogo.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnLogo.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLogo.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F);
            btnLogo.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnLogo.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnLogo.StatePressed.Back.ColorAngle = 135F;
            btnLogo.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnLogo.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnLogo.StatePressed.Border.ColorAngle = 135F;
            btnLogo.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogo.StatePressed.Border.Rounding = 20F;
            btnLogo.StatePressed.Border.Width = 1;
            btnLogo.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLogo.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnLogo.StateTracking.Back.ColorAngle = 45F;
            btnLogo.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLogo.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLogo.StateTracking.Border.ColorAngle = 45F;
            btnLogo.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogo.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLogo.StateTracking.Border.Rounding = 20F;
            btnLogo.StateTracking.Border.Width = 1;
            btnLogo.StateTracking.Content.ShortText.Color1 = Color.White;
            btnLogo.TabIndex = 1025;
            btnLogo.Values.Text = "Logo";
            btnLogo.Click += btnLogo_Click;
            // 
            // btnCertificadoDigital
            // 
            btnCertificadoDigital.CornerRoundingRadius = 10F;
            btnCertificadoDigital.Location = new Point(18, 110);
            btnCertificadoDigital.Name = "btnCertificadoDigital";
            btnCertificadoDigital.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnCertificadoDigital.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnCertificadoDigital.OverrideDefault.Back.ColorAngle = 45F;
            btnCertificadoDigital.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnCertificadoDigital.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCertificadoDigital.OverrideDefault.Border.ColorAngle = 45F;
            btnCertificadoDigital.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCertificadoDigital.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCertificadoDigital.OverrideDefault.Border.Rounding = 20F;
            btnCertificadoDigital.OverrideDefault.Border.Width = 1;
            btnCertificadoDigital.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnCertificadoDigital.Size = new Size(130, 27);
            btnCertificadoDigital.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnCertificadoDigital.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnCertificadoDigital.StateCommon.Back.ColorAngle = 45F;
            btnCertificadoDigital.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCertificadoDigital.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCertificadoDigital.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCertificadoDigital.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCertificadoDigital.StateCommon.Border.Rounding = 10F;
            btnCertificadoDigital.StateCommon.Border.Width = 1;
            btnCertificadoDigital.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnCertificadoDigital.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCertificadoDigital.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F);
            btnCertificadoDigital.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnCertificadoDigital.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnCertificadoDigital.StatePressed.Back.ColorAngle = 135F;
            btnCertificadoDigital.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnCertificadoDigital.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnCertificadoDigital.StatePressed.Border.ColorAngle = 135F;
            btnCertificadoDigital.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCertificadoDigital.StatePressed.Border.Rounding = 20F;
            btnCertificadoDigital.StatePressed.Border.Width = 1;
            btnCertificadoDigital.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnCertificadoDigital.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnCertificadoDigital.StateTracking.Back.ColorAngle = 45F;
            btnCertificadoDigital.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCertificadoDigital.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCertificadoDigital.StateTracking.Border.ColorAngle = 45F;
            btnCertificadoDigital.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCertificadoDigital.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCertificadoDigital.StateTracking.Border.Rounding = 20F;
            btnCertificadoDigital.StateTracking.Border.Width = 1;
            btnCertificadoDigital.StateTracking.Content.ShortText.Color1 = Color.White;
            btnCertificadoDigital.TabIndex = 1026;
            btnCertificadoDigital.Values.Text = "Certificado Digital";
            btnCertificadoDigital.Click += btnCertificadoDigital_Click;
            // 
            // btnDadosFiscais
            // 
            btnDadosFiscais.CornerRoundingRadius = 10F;
            btnDadosFiscais.Location = new Point(148, 110);
            btnDadosFiscais.Name = "btnDadosFiscais";
            btnDadosFiscais.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnDadosFiscais.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnDadosFiscais.OverrideDefault.Back.ColorAngle = 45F;
            btnDadosFiscais.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnDadosFiscais.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnDadosFiscais.OverrideDefault.Border.ColorAngle = 45F;
            btnDadosFiscais.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnDadosFiscais.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnDadosFiscais.OverrideDefault.Border.Rounding = 20F;
            btnDadosFiscais.OverrideDefault.Border.Width = 1;
            btnDadosFiscais.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnDadosFiscais.Size = new Size(130, 27);
            btnDadosFiscais.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnDadosFiscais.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnDadosFiscais.StateCommon.Back.ColorAngle = 45F;
            btnDadosFiscais.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnDadosFiscais.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnDadosFiscais.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnDadosFiscais.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnDadosFiscais.StateCommon.Border.Rounding = 10F;
            btnDadosFiscais.StateCommon.Border.Width = 1;
            btnDadosFiscais.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnDadosFiscais.StateCommon.Content.ShortText.Color2 = Color.White;
            btnDadosFiscais.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F);
            btnDadosFiscais.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnDadosFiscais.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnDadosFiscais.StatePressed.Back.ColorAngle = 135F;
            btnDadosFiscais.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnDadosFiscais.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnDadosFiscais.StatePressed.Border.ColorAngle = 135F;
            btnDadosFiscais.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnDadosFiscais.StatePressed.Border.Rounding = 20F;
            btnDadosFiscais.StatePressed.Border.Width = 1;
            btnDadosFiscais.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnDadosFiscais.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnDadosFiscais.StateTracking.Back.ColorAngle = 45F;
            btnDadosFiscais.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnDadosFiscais.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnDadosFiscais.StateTracking.Border.ColorAngle = 45F;
            btnDadosFiscais.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnDadosFiscais.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnDadosFiscais.StateTracking.Border.Rounding = 20F;
            btnDadosFiscais.StateTracking.Border.Width = 1;
            btnDadosFiscais.StateTracking.Content.ShortText.Color1 = Color.White;
            btnDadosFiscais.TabIndex = 1027;
            btnDadosFiscais.Values.Text = "Dados Fiscais";
            btnDadosFiscais.Click += btnDadosFiscais_Click;
            // 
            // FrmFerramentas
            // 
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(301, 196);
            ControlBox = false;
            Controls.Add(btnDadosFiscais);
            Controls.Add(btnCertificadoDigital);
            Controls.Add(btnLogo);
            Controls.Add(kryptonTableLayoutPanel1);
            Controls.Add(FrmModeloUI);
            Controls.Add(InsertBanco);
            Controls.Add(btnSair);
            Controls.Add(txtBackup);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFerramentas";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTableLayoutPanel1.ResumeLayout(false);
            kryptonTableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonButton txtBackup;
        private Krypton.Toolkit.KryptonButton btnSair;
        private Krypton.Toolkit.KryptonButton InsertBanco;
        private Krypton.Toolkit.KryptonButton FrmModeloUI;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton btnLogo;
        private Krypton.Toolkit.KryptonButton btnCertificadoDigital;
        private Krypton.Toolkit.KryptonButton btnDadosFiscais;
    }
}
