namespace GVC.MUI
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            lblEsqueciSenha = new Label();
            btnCancelar = new Krypton.Toolkit.KryptonButton();
            panel3 = new Panel();
            panel1 = new Panel();
            btnLogin = new Krypton.Toolkit.KryptonButton();
            label18 = new Label();
            txtUsuario = new Krypton.Toolkit.KryptonTextBox();
            txtSenha = new Krypton.Toolkit.KryptonTextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            iconPictureBoxUser = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBoxPassword = new FontAwesome.Sharp.IconPictureBox();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            lblVersao = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBoxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBoxPassword).BeginInit();
            SuspendLayout();
            // 
            // lblEsqueciSenha
            // 
            lblEsqueciSenha.AutoSize = true;
            lblEsqueciSenha.ForeColor = Color.FromArgb(8, 142, 254);
            lblEsqueciSenha.Location = new Point(164, 307);
            lblEsqueciSenha.Name = "lblEsqueciSenha";
            lblEsqueciSenha.Size = new Size(91, 15);
            lblEsqueciSenha.TabIndex = 10;
            lblEsqueciSenha.Text = "Esqueci a Senha";
            lblEsqueciSenha.Click += lblEsqueciSenha_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.CornerRoundingRadius = 20F;
            btnCancelar.Location = new Point(152, 268);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnCancelar.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnCancelar.OverrideDefault.Back.ColorAngle = 45F;
            btnCancelar.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnCancelar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.OverrideDefault.Border.ColorAngle = 45F;
            btnCancelar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.OverrideDefault.Border.Rounding = 20F;
            btnCancelar.OverrideDefault.Border.Width = 1;
            btnCancelar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            btnCancelar.Size = new Size(120, 30);
            btnCancelar.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnCancelar.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnCancelar.StateCommon.Back.ColorAngle = 45F;
            btnCancelar.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.StateCommon.Border.Rounding = 20F;
            btnCancelar.StateCommon.Border.Width = 1;
            btnCancelar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnCancelar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCancelar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnCancelar.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnCancelar.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnCancelar.StatePressed.Back.ColorAngle = 135F;
            btnCancelar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnCancelar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnCancelar.StatePressed.Border.ColorAngle = 135F;
            btnCancelar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StatePressed.Border.Rounding = 20F;
            btnCancelar.StatePressed.Border.Width = 1;
            btnCancelar.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnCancelar.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnCancelar.StateTracking.Back.ColorAngle = 45F;
            btnCancelar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.StateTracking.Border.ColorAngle = 45F;
            btnCancelar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.StateTracking.Border.Rounding = 20F;
            btnCancelar.StateTracking.Border.Width = 1;
            btnCancelar.StateTracking.Content.ShortText.Color1 = Color.White;
            btnCancelar.TabIndex = 4;
            btnCancelar.TabStop = false;
            btnCancelar.Values.Text = "&Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(37, 227);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 2);
            panel3.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(37, 162);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 2);
            panel1.TabIndex = 17;
            // 
            // btnLogin
            // 
            btnLogin.CornerRoundingRadius = 20F;
            btnLogin.Location = new Point(26, 268);
            btnLogin.Name = "btnLogin";
            btnLogin.OverrideDefault.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.OverrideDefault.Back.ColorAngle = 45F;
            btnLogin.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.OverrideDefault.Border.ColorAngle = 45F;
            btnLogin.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogin.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLogin.OverrideDefault.Border.Rounding = 20F;
            btnLogin.OverrideDefault.Border.Width = 1;
            btnLogin.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            btnLogin.Size = new Size(120, 30);
            btnLogin.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnLogin.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnLogin.StateCommon.Back.ColorAngle = 45F;
            btnLogin.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLogin.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogin.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLogin.StateCommon.Border.Rounding = 20F;
            btnLogin.StateCommon.Border.Width = 1;
            btnLogin.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLogin.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLogin.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnLogin.StateDisabled.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.StateDisabled.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.StateDisabled.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogin.StateDisabled.Content.ShortText.Color1 = Color.White;
            btnLogin.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.StateNormal.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.StateNormal.Content.LongText.Color1 = Color.White;
            btnLogin.StateNormal.Content.LongText.Color2 = Color.White;
            btnLogin.StateNormal.Content.ShortText.Color1 = Color.White;
            btnLogin.StateNormal.Content.ShortText.Color2 = Color.White;
            btnLogin.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnLogin.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnLogin.StatePressed.Back.ColorAngle = 135F;
            btnLogin.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnLogin.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnLogin.StatePressed.Border.ColorAngle = 135F;
            btnLogin.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogin.StatePressed.Border.Rounding = 20F;
            btnLogin.StatePressed.Border.Width = 1;
            btnLogin.StatePressed.Content.LongText.Color1 = Color.White;
            btnLogin.StatePressed.Content.LongText.Color2 = Color.White;
            btnLogin.StatePressed.Content.ShortText.Color1 = Color.White;
            btnLogin.StatePressed.Content.ShortText.Color2 = Color.White;
            btnLogin.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnLogin.StateTracking.Back.ColorAngle = 45F;
            btnLogin.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLogin.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.StateTracking.Border.ColorAngle = 45F;
            btnLogin.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogin.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLogin.StateTracking.Border.Rounding = 20F;
            btnLogin.StateTracking.Border.Width = 1;
            btnLogin.StateTracking.Content.ShortText.Color1 = Color.White;
            btnLogin.TabIndex = 2;
            btnLogin.Values.Text = "&Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 9.25F);
            label18.ForeColor = Color.FromArgb(8, 142, 254);
            label18.Location = new Point(30, 107);
            label18.Name = "label18";
            label18.Size = new Size(54, 16);
            label18.TabIndex = 185;
            label18.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(28, 125);
            txtUsuario.MaxLength = 14;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(249, 33);
            txtUsuario.StateCommon.Back.Color1 = Color.White;
            txtUsuario.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtUsuario.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtUsuario.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtUsuario.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtUsuario.StateCommon.Border.Rounding = 20F;
            txtUsuario.StateCommon.Border.Width = 1;
            txtUsuario.StateCommon.Content.Color1 = Color.Gray;
            txtUsuario.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtUsuario.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtUsuario.TabIndex = 0;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.KeyDown += txtUsuario_KeyDown;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtSenha
            // 
            txtSenha.CharacterCasing = CharacterCasing.Lower;
            txtSenha.Location = new Point(28, 190);
            txtSenha.MaxLength = 100;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(249, 33);
            txtSenha.StateCommon.Back.Color1 = Color.White;
            txtSenha.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtSenha.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtSenha.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSenha.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSenha.StateCommon.Border.Rounding = 20F;
            txtSenha.StateCommon.Border.Width = 1;
            txtSenha.StateCommon.Content.Color1 = Color.Gray;
            txtSenha.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtSenha.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSenha.TabIndex = 1;
            txtSenha.Enter += txtSenha_Enter;
            txtSenha.KeyDown += txtSenha_KeyDown;
            txtSenha.Leave += txtSenha_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.25F);
            label1.ForeColor = Color.FromArgb(8, 142, 254);
            label1.Location = new Point(30, 173);
            label1.Name = "label1";
            label1.Size = new Size(46, 16);
            label1.TabIndex = 186;
            label1.Text = "Senha";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(96, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 187;
            pictureBox1.TabStop = false;
            // 
            // iconPictureBoxUser
            // 
            iconPictureBoxUser.BackColor = Color.Transparent;
            iconPictureBoxUser.ForeColor = Color.FromArgb(30, 136, 229);
            iconPictureBoxUser.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBoxUser.IconColor = Color.FromArgb(30, 136, 229);
            iconPictureBoxUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBoxUser.IconSize = 28;
            iconPictureBoxUser.Location = new Point(0, 127);
            iconPictureBoxUser.Name = "iconPictureBoxUser";
            iconPictureBoxUser.Size = new Size(28, 28);
            iconPictureBoxUser.TabIndex = 1125;
            iconPictureBoxUser.TabStop = false;
            iconPictureBoxUser.Visible = false;
            // 
            // iconPictureBoxPassword
            // 
            iconPictureBoxPassword.BackColor = Color.Transparent;
            iconPictureBoxPassword.ForeColor = Color.FromArgb(30, 136, 229);
            iconPictureBoxPassword.IconChar = FontAwesome.Sharp.IconChar.UnlockKeyhole;
            iconPictureBoxPassword.IconColor = Color.FromArgb(30, 136, 229);
            iconPictureBoxPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBoxPassword.IconSize = 28;
            iconPictureBoxPassword.Location = new Point(-1, 192);
            iconPictureBoxPassword.Name = "iconPictureBoxPassword";
            iconPictureBoxPassword.Size = new Size(28, 28);
            iconPictureBoxPassword.TabIndex = 1126;
            iconPictureBoxPassword.TabStop = false;
            iconPictureBoxPassword.Visible = false;
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
            // lblVersao
            // 
            lblVersao.Location = new Point(33, 235);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(48, 20);
            lblVersao.TabIndex = 1127;
            lblVersao.Values.Text = "Versao";
            // 
            // FrmLogin
            // 
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(284, 334);
            Controls.Add(lblVersao);
            Controls.Add(iconPictureBoxPassword);
            Controls.Add(iconPictureBoxUser);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(label18);
            Controls.Add(txtUsuario);
            Controls.Add(btnLogin);
            Controls.Add(btnCancelar);
            Controls.Add(panel1);
            Controls.Add(lblEsqueciSenha);
            Controls.Add(panel3);
            ForeColor = Color.FromArgb(252, 252, 250);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Header.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Header.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Header.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateInactive.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateInactive.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateInactive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = " ";
            Load += FrmLogin_Load;
            Shown += FrmLogin_Shown;
            KeyDown += FrmLogin_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBoxUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBoxPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEsqueciSenha;
        private Krypton.Toolkit.KryptonButton btnCancelar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonButton btnLogin;
        private Label label18;
        public Krypton.Toolkit.KryptonTextBox txtUsuario;
        public Krypton.Toolkit.KryptonTextBox txtSenha;
        private Label label1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxUser;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxPassword;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonLabel lblVersao;
    }
}
