namespace GVC.View
{
    partial class FrmConfigLogo
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
            btnSair = new Krypton.Toolkit.KryptonButton();
            btnSalvar = new Krypton.Toolkit.KryptonButton();
            picLogo = new PictureBox();
            btnSelecionarLogo = new Krypton.Toolkit.KryptonButton();
            label1 = new Label();
            cmbEmpresas = new Krypton.Toolkit.KryptonComboBox();
            lblInstrucao = new Label();
            pgbSalvando = new Krypton.Toolkit.KryptonProgressBar();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbEmpresas).BeginInit();
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
            // btnSair
            // 
            btnSair.CornerRoundingRadius = 6F;
            btnSair.Location = new Point(250, 330);
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
            btnSair.Click += btnSair_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.CornerRoundingRadius = 6F;
            btnSalvar.Location = new Point(85, 330);
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
            btnSalvar.Values.Text = "Alterar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // picLogo
            // 
            picLogo.Location = new Point(85, 86);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(255, 238);
            picLogo.TabIndex = 1047;
            picLogo.TabStop = false;
            // 
            // btnSelecionarLogo
            // 
            btnSelecionarLogo.CornerRoundingRadius = 6F;
            btnSelecionarLogo.Location = new Point(250, 53);
            btnSelecionarLogo.Margin = new Padding(4, 3, 4, 3);
            btnSelecionarLogo.Name = "btnSelecionarLogo";
            btnSelecionarLogo.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnSelecionarLogo.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnSelecionarLogo.OverrideDefault.Back.ColorAngle = 45F;
            btnSelecionarLogo.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnSelecionarLogo.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSelecionarLogo.OverrideDefault.Border.ColorAngle = 45F;
            btnSelecionarLogo.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSelecionarLogo.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSelecionarLogo.OverrideDefault.Border.Rounding = 20F;
            btnSelecionarLogo.OverrideDefault.Border.Width = 1;
            btnSelecionarLogo.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSelecionarLogo.Size = new Size(90, 27);
            btnSelecionarLogo.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnSelecionarLogo.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnSelecionarLogo.StateCommon.Back.ColorAngle = 45F;
            btnSelecionarLogo.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSelecionarLogo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSelecionarLogo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSelecionarLogo.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSelecionarLogo.StateCommon.Border.Rounding = 6F;
            btnSelecionarLogo.StateCommon.Border.Width = 1;
            btnSelecionarLogo.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnSelecionarLogo.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSelecionarLogo.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelecionarLogo.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnSelecionarLogo.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnSelecionarLogo.StatePressed.Back.ColorAngle = 135F;
            btnSelecionarLogo.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSelecionarLogo.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSelecionarLogo.StatePressed.Border.ColorAngle = 135F;
            btnSelecionarLogo.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSelecionarLogo.StatePressed.Border.Rounding = 20F;
            btnSelecionarLogo.StatePressed.Border.Width = 1;
            btnSelecionarLogo.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSelecionarLogo.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnSelecionarLogo.StateTracking.Back.ColorAngle = 45F;
            btnSelecionarLogo.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSelecionarLogo.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSelecionarLogo.StateTracking.Border.ColorAngle = 45F;
            btnSelecionarLogo.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSelecionarLogo.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSelecionarLogo.StateTracking.Border.Rounding = 20F;
            btnSelecionarLogo.StateTracking.Border.Width = 1;
            btnSelecionarLogo.StateTracking.Content.ShortText.Color1 = Color.White;
            btnSelecionarLogo.TabIndex = 1048;
            btnSelecionarLogo.TabStop = false;
            btnSelecionarLogo.Values.Text = "Seleciona";
            btnSelecionarLogo.Click += btnSelecionarLogo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.25F);
            label1.ForeColor = Color.FromArgb(0, 76, 172);
            label1.Location = new Point(85, 64);
            label1.Name = "label1";
            label1.Size = new Size(76, 16);
            label1.TabIndex = 1050;
            label1.Text = "Logomarca";
            // 
            // cmbEmpresas
            // 
            cmbEmpresas.CornerRoundingRadius = 10F;
            cmbEmpresas.DropDownWidth = 171;
            cmbEmpresas.IntegralHeight = false;
            cmbEmpresas.Location = new Point(12, 26);
            cmbEmpresas.Name = "cmbEmpresas";
            cmbEmpresas.Size = new Size(417, 27);
            cmbEmpresas.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(8, 142, 254);
            cmbEmpresas.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(8, 142, 254);
            cmbEmpresas.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbEmpresas.StateCommon.ComboBox.Border.Rounding = 10F;
            cmbEmpresas.StateCommon.ComboBox.Border.Width = 1;
            cmbEmpresas.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbEmpresas.TabIndex = 1051;
            cmbEmpresas.TabStop = false;
            cmbEmpresas.SelectedIndexChanged += cmbEmpresas_SelectedIndexChanged;
            // 
            // lblInstrucao
            // 
            lblInstrucao.AutoSize = true;
            lblInstrucao.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblInstrucao.ForeColor = Color.FromArgb(0, 76, 172);
            lblInstrucao.Location = new Point(12, 6);
            lblInstrucao.Name = "lblInstrucao";
            lblInstrucao.Size = new Size(268, 16);
            lblInstrucao.TabIndex = 1052;
            lblInstrucao.Text = "Selecione uma Empresa para alterar o logo";
            // 
            // pgbSalvando
            // 
            pgbSalvando.Dock = DockStyle.Bottom;
            pgbSalvando.Location = new Point(0, 378);
            pgbSalvando.Name = "pgbSalvando";
            pgbSalvando.Size = new Size(441, 23);
            pgbSalvando.Style = ProgressBarStyle.Continuous;
            pgbSalvando.TabIndex = 1053;
            pgbSalvando.UseKrypton = true;
            pgbSalvando.Visible = false;
            // 
            // FrmConfigLogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(441, 401);
            Controls.Add(pgbSalvando);
            Controls.Add(cmbEmpresas);
            Controls.Add(lblInstrucao);
            Controls.Add(label1);
            Controls.Add(btnSelecionarLogo);
            Controls.Add(picLogo);
            Controls.Add(btnSair);
            Controls.Add(btnSalvar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConfigLogo";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configurar Logo da Empresa";
            Load += FrmConfigLogo_Load;
            Shown += FrmConfigLogo_Shown;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbEmpresas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonButton btnSair;
        public Krypton.Toolkit.KryptonButton btnSalvar;
        public Krypton.Toolkit.KryptonComboBox cbEmpresa;
        private Label lblInstrucao;
        private PictureBox picLogo;
        private Krypton.Toolkit.KryptonButton btnSelecionarLogo;
        private Label label1;
        public Krypton.Toolkit.KryptonComboBox cmbEmpresas;
        private Krypton.Toolkit.KryptonProgressBar pgbSalvando;
    }
}