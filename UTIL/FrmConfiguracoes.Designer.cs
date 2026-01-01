namespace GVC.View
{
    partial class FrmConfiguracoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            txtCertificado = new Krypton.Toolkit.KryptonTextBox();
            lblCliente = new Label();
            btnSair = new Krypton.Toolkit.KryptonButton();
            btnSalvar = new Krypton.Toolkit.KryptonButton();
            cbEmpresa = new Krypton.Toolkit.KryptonComboBox();
            label5 = new Label();
            picLogo = new PictureBox();
            btnAlterarLogo = new Krypton.Toolkit.KryptonButton();
            txtSelecionarCertificado = new Krypton.Toolkit.KryptonButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)cbEmpresa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
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
            // txtCertificado
            // 
            txtCertificado.CharacterCasing = CharacterCasing.Upper;
            txtCertificado.Location = new Point(4, 283);
            txtCertificado.Name = "txtCertificado";
            txtCertificado.Size = new Size(509, 27);
            txtCertificado.StateCommon.Back.Color1 = Color.White;
            txtCertificado.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtCertificado.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtCertificado.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtCertificado.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtCertificado.StateCommon.Border.Rounding = 8F;
            txtCertificado.StateCommon.Border.Width = 1;
            txtCertificado.StateCommon.Content.Color1 = Color.Gray;
            txtCertificado.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtCertificado.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtCertificado.TabIndex = 251;
            txtCertificado.TabStop = false;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblCliente.ForeColor = Color.FromArgb(0, 76, 172);
            lblCliente.Location = new Point(12, 264);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(71, 16);
            lblCliente.TabIndex = 254;
            lblCliente.Text = "Certificado";
            // 
            // btnSair
            // 
            btnSair.CornerRoundingRadius = 6F;
            btnSair.Location = new Point(520, 325);
            btnSair.Margin = new Padding(4, 3, 4, 3);
            btnSair.Name = "btnSair";
            btnSair.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnSair.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnSair.OverrideDefault.Back.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Border.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.OverrideDefault.Border.Rounding = 20F;
            btnSair.OverrideDefault.Border.Width = 1;
            btnSair.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSair.Size = new Size(90, 27);
            btnSair.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnSair.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnSair.StateCommon.Back.ColorAngle = 45F;
            btnSair.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateCommon.Border.Rounding = 6F;
            btnSair.StateCommon.Border.Width = 1;
            btnSair.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSair.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            btnSair.StateTracking.Content.ShortText.Color1 = Color.White;
            btnSair.TabIndex = 1044;
            btnSair.TabStop = false;
            btnSair.Values.Text = "Sair";
            btnSair.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.CornerRoundingRadius = 6F;
            btnSalvar.Location = new Point(4, 326);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvar.OverrideDefault.Back.ColorAngle = 45F;
            btnSalvar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvar.OverrideDefault.Border.ColorAngle = 45F;
            btnSalvar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvar.OverrideDefault.Border.Rounding = 20F;
            btnSalvar.OverrideDefault.Border.Width = 1;
            btnSalvar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSalvar.Size = new Size(90, 27);
            btnSalvar.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSalvar.StateCommon.Back.Color2 = Color.FromArgb(6, 180, 240);
            btnSalvar.StateCommon.Back.ColorAngle = 45F;
            btnSalvar.StateCommon.Border.Color1 = Color.FromArgb(0, 76, 172);
            btnSalvar.StateCommon.Border.Color2 = Color.FromArgb(0, 76, 172);
            btnSalvar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvar.StateCommon.Border.Rounding = 6F;
            btnSalvar.StateCommon.Border.Width = 1;
            btnSalvar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSalvar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSalvar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnSalvar.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnSalvar.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnSalvar.StatePressed.Back.ColorAngle = 135F;
            btnSalvar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSalvar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSalvar.StatePressed.Border.ColorAngle = 135F;
            btnSalvar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvar.StatePressed.Border.Rounding = 20F;
            btnSalvar.StatePressed.Border.Width = 1;
            btnSalvar.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnSalvar.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnSalvar.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnSalvar.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnSalvar.StateTracking.Back.ColorAngle = 45F;
            btnSalvar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvar.StateTracking.Border.ColorAngle = 45F;
            btnSalvar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvar.StateTracking.Border.Rounding = 20F;
            btnSalvar.StateTracking.Border.Width = 1;
            btnSalvar.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnSalvar.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnSalvar.TabIndex = 2;
            btnSalvar.Values.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // cbEmpresa
            // 
            cbEmpresa.CornerRoundingRadius = 10F;
            cbEmpresa.DropDownWidth = 171;
            cbEmpresa.IntegralHeight = false;
            cbEmpresa.Location = new Point(4, 39);
            cbEmpresa.Name = "cbEmpresa";
            cbEmpresa.Size = new Size(440, 27);
            cbEmpresa.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(8, 142, 254);
            cbEmpresa.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(8, 142, 254);
            cbEmpresa.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cbEmpresa.StateCommon.ComboBox.Border.Rounding = 10F;
            cbEmpresa.StateCommon.ComboBox.Border.Width = 1;
            cbEmpresa.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbEmpresa.TabIndex = 1045;
            cbEmpresa.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.25F);
            label5.ForeColor = Color.FromArgb(0, 76, 172);
            label5.Location = new Point(4, 20);
            label5.Name = "label5";
            label5.Size = new Size(104, 16);
            label5.TabIndex = 1046;
            label5.Text = "Tipo da Pessoa";
            // 
            // picLogo
            // 
            picLogo.Location = new Point(8, 101);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(158, 161);
            picLogo.TabIndex = 1047;
            picLogo.TabStop = false;
            // 
            // btnAlterarLogo
            // 
            btnAlterarLogo.CornerRoundingRadius = 6F;
            btnAlterarLogo.Location = new Point(173, 101);
            btnAlterarLogo.Margin = new Padding(4, 3, 4, 3);
            btnAlterarLogo.Name = "btnAlterarLogo";
            btnAlterarLogo.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnAlterarLogo.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnAlterarLogo.OverrideDefault.Back.ColorAngle = 45F;
            btnAlterarLogo.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnAlterarLogo.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAlterarLogo.OverrideDefault.Border.ColorAngle = 45F;
            btnAlterarLogo.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAlterarLogo.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAlterarLogo.OverrideDefault.Border.Rounding = 20F;
            btnAlterarLogo.OverrideDefault.Border.Width = 1;
            btnAlterarLogo.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnAlterarLogo.Size = new Size(90, 27);
            btnAlterarLogo.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnAlterarLogo.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnAlterarLogo.StateCommon.Back.ColorAngle = 45F;
            btnAlterarLogo.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAlterarLogo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAlterarLogo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAlterarLogo.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAlterarLogo.StateCommon.Border.Rounding = 6F;
            btnAlterarLogo.StateCommon.Border.Width = 1;
            btnAlterarLogo.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnAlterarLogo.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAlterarLogo.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlterarLogo.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnAlterarLogo.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnAlterarLogo.StatePressed.Back.ColorAngle = 135F;
            btnAlterarLogo.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnAlterarLogo.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnAlterarLogo.StatePressed.Border.ColorAngle = 135F;
            btnAlterarLogo.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAlterarLogo.StatePressed.Border.Rounding = 20F;
            btnAlterarLogo.StatePressed.Border.Width = 1;
            btnAlterarLogo.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnAlterarLogo.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnAlterarLogo.StateTracking.Back.ColorAngle = 45F;
            btnAlterarLogo.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAlterarLogo.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAlterarLogo.StateTracking.Border.ColorAngle = 45F;
            btnAlterarLogo.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAlterarLogo.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAlterarLogo.StateTracking.Border.Rounding = 20F;
            btnAlterarLogo.StateTracking.Border.Width = 1;
            btnAlterarLogo.StateTracking.Content.ShortText.Color1 = Color.White;
            btnAlterarLogo.TabIndex = 1048;
            btnAlterarLogo.TabStop = false;
            btnAlterarLogo.Values.Text = "Alterar Logo";
            btnAlterarLogo.Click += btnAlterarLogo_Click;
            // 
            // txtSelecionarCertificado
            // 
            txtSelecionarCertificado.CornerRoundingRadius = 6F;
            txtSelecionarCertificado.Location = new Point(520, 283);
            txtSelecionarCertificado.Margin = new Padding(4, 3, 4, 3);
            txtSelecionarCertificado.Name = "txtSelecionarCertificado";
            txtSelecionarCertificado.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            txtSelecionarCertificado.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            txtSelecionarCertificado.OverrideDefault.Back.ColorAngle = 45F;
            txtSelecionarCertificado.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtSelecionarCertificado.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtSelecionarCertificado.OverrideDefault.Border.ColorAngle = 45F;
            txtSelecionarCertificado.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSelecionarCertificado.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSelecionarCertificado.OverrideDefault.Border.Rounding = 20F;
            txtSelecionarCertificado.OverrideDefault.Border.Width = 1;
            txtSelecionarCertificado.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            txtSelecionarCertificado.Size = new Size(90, 27);
            txtSelecionarCertificado.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            txtSelecionarCertificado.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            txtSelecionarCertificado.StateCommon.Back.ColorAngle = 45F;
            txtSelecionarCertificado.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            txtSelecionarCertificado.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtSelecionarCertificado.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSelecionarCertificado.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSelecionarCertificado.StateCommon.Border.Rounding = 6F;
            txtSelecionarCertificado.StateCommon.Border.Width = 1;
            txtSelecionarCertificado.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            txtSelecionarCertificado.StateCommon.Content.ShortText.Color2 = Color.White;
            txtSelecionarCertificado.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSelecionarCertificado.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            txtSelecionarCertificado.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            txtSelecionarCertificado.StatePressed.Back.ColorAngle = 135F;
            txtSelecionarCertificado.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            txtSelecionarCertificado.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            txtSelecionarCertificado.StatePressed.Border.ColorAngle = 135F;
            txtSelecionarCertificado.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSelecionarCertificado.StatePressed.Border.Rounding = 20F;
            txtSelecionarCertificado.StatePressed.Border.Width = 1;
            txtSelecionarCertificado.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            txtSelecionarCertificado.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            txtSelecionarCertificado.StateTracking.Back.ColorAngle = 45F;
            txtSelecionarCertificado.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            txtSelecionarCertificado.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtSelecionarCertificado.StateTracking.Border.ColorAngle = 45F;
            txtSelecionarCertificado.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSelecionarCertificado.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSelecionarCertificado.StateTracking.Border.Rounding = 20F;
            txtSelecionarCertificado.StateTracking.Border.Width = 1;
            txtSelecionarCertificado.StateTracking.Content.ShortText.Color1 = Color.White;
            txtSelecionarCertificado.TabIndex = 1049;
            txtSelecionarCertificado.TabStop = false;
            txtSelecionarCertificado.Values.Text = "Localizar";
            txtSelecionarCertificado.Click += txtSelecionarCertificado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.25F);
            label1.ForeColor = Color.FromArgb(0, 76, 172);
            label1.Location = new Point(10, 82);
            label1.Name = "label1";
            label1.Size = new Size(76, 16);
            label1.TabIndex = 1050;
            label1.Text = "Logomarca";
            // 
            // FrmConfiguracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(618, 364);
            Controls.Add(label1);
            Controls.Add(txtSelecionarCertificado);
            Controls.Add(btnAlterarLogo);
            Controls.Add(picLogo);
            Controls.Add(cbEmpresa);
            Controls.Add(label5);
            Controls.Add(btnSair);
            Controls.Add(btnSalvar);
            Controls.Add(txtCertificado);
            Controls.Add(lblCliente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConfiguracoes";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estornar Pagamento";
            Load += FrmConfiguracoes_Load;
            Shown += FrmConfiguracoes_Shown;
            KeyDown += FrmConfiguracoes_KeyDown;
            ((System.ComponentModel.ISupportInitialize)cbEmpresa).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public Krypton.Toolkit.KryptonTextBox txtCertificado;
        private Label lblCliente;
        private Krypton.Toolkit.KryptonButton btnSair;
        public Krypton.Toolkit.KryptonButton btnSalvar;
        public Krypton.Toolkit.KryptonComboBox cbEmpresa;
        private Label label5;
        private PictureBox picLogo;
        private Krypton.Toolkit.KryptonButton btnAlterarLogo;
        private Krypton.Toolkit.KryptonButton txtSelecionarCertificado;
        private Label label1;
    }
}