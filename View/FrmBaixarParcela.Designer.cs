namespace GVC.View
{
    partial class FrmBaixarParcela
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
            lblRotuloValorParcela = new Label();
            btnCancelar = new Krypton.Toolkit.KryptonButton();
            btnConfirmarBaixa = new Krypton.Toolkit.KryptonButton();
            lblRotuloFormaPgto = new Label();
            cmbFormaPagamento = new Krypton.Toolkit.KryptonComboBox();
            txtSaldo = new Krypton.Toolkit.KryptonTextBox();
            txtValorRecebido = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloValorRecebido = new Label();
            dgvParcelasBaixa = new Krypton.Toolkit.KryptonDataGridView();
            txtValorParcela = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloCliente = new Label();
            txtClienteNome = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloSaldo = new Label();
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            lblInfo = new ToolStripStatusLabel();
            txtObservacao = new Krypton.Toolkit.KryptonTextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)cmbFormaPagamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvParcelasBaixa).BeginInit();
            kryptonStatusStrip1.SuspendLayout();
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
            // lblRotuloValorParcela
            // 
            lblRotuloValorParcela.AutoSize = true;
            lblRotuloValorParcela.BackColor = Color.Transparent;
            lblRotuloValorParcela.Font = new Font("Segoe UI", 9.75F);
            lblRotuloValorParcela.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloValorParcela.Location = new Point(0, 211);
            lblRotuloValorParcela.Name = "lblRotuloValorParcela";
            lblRotuloValorParcela.Size = new Size(87, 17);
            lblRotuloValorParcela.TabIndex = 1032;
            lblRotuloValorParcela.Text = "Valor Parcela:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.CornerRoundingRadius = 6F;
            btnCancelar.Location = new Point(406, 346);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
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
            btnCancelar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnCancelar.Size = new Size(80, 27);
            btnCancelar.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnCancelar.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnCancelar.StateCommon.Back.ColorAngle = 45F;
            btnCancelar.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.StateCommon.Border.Rounding = 6F;
            btnCancelar.StateCommon.Border.Width = 1;
            btnCancelar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnCancelar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCancelar.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.StatePressed.Back.Color1 = Color.Red;
            btnCancelar.StatePressed.Back.Color2 = Color.Red;
            btnCancelar.StatePressed.Back.ColorAngle = 135F;
            btnCancelar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnCancelar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnCancelar.StatePressed.Border.ColorAngle = 135F;
            btnCancelar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StatePressed.Border.Rounding = 20F;
            btnCancelar.StatePressed.Border.Width = 1;
            btnCancelar.StateTracking.Back.Color1 = Color.Red;
            btnCancelar.StateTracking.Back.Color2 = Color.Red;
            btnCancelar.StateTracking.Back.ColorAngle = 45F;
            btnCancelar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.StateTracking.Border.ColorAngle = 45F;
            btnCancelar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.StateTracking.Border.Rounding = 20F;
            btnCancelar.StateTracking.Border.Width = 1;
            btnCancelar.StateTracking.Content.ShortText.Color1 = Color.White;
            btnCancelar.TabIndex = 1046;
            btnCancelar.TabStop = false;
            btnCancelar.Values.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmarBaixa
            // 
            btnConfirmarBaixa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmarBaixa.CornerRoundingRadius = 6F;
            btnConfirmarBaixa.Location = new Point(319, 346);
            btnConfirmarBaixa.Name = "btnConfirmarBaixa";
            btnConfirmarBaixa.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmarBaixa.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmarBaixa.OverrideDefault.Back.ColorAngle = 45F;
            btnConfirmarBaixa.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmarBaixa.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmarBaixa.OverrideDefault.Border.ColorAngle = 45F;
            btnConfirmarBaixa.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmarBaixa.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmarBaixa.OverrideDefault.Border.Rounding = 20F;
            btnConfirmarBaixa.OverrideDefault.Border.Width = 1;
            btnConfirmarBaixa.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnConfirmarBaixa.Size = new Size(80, 27);
            btnConfirmarBaixa.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnConfirmarBaixa.StateCommon.Back.Color2 = Color.FromArgb(6, 180, 240);
            btnConfirmarBaixa.StateCommon.Back.ColorAngle = 45F;
            btnConfirmarBaixa.StateCommon.Border.Color1 = Color.FromArgb(0, 76, 172);
            btnConfirmarBaixa.StateCommon.Border.Color2 = Color.FromArgb(0, 76, 172);
            btnConfirmarBaixa.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmarBaixa.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmarBaixa.StateCommon.Border.Rounding = 6F;
            btnConfirmarBaixa.StateCommon.Border.Width = 1;
            btnConfirmarBaixa.StateCommon.Content.ShortText.Color1 = Color.White;
            btnConfirmarBaixa.StateCommon.Content.ShortText.Color2 = Color.White;
            btnConfirmarBaixa.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnConfirmarBaixa.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnConfirmarBaixa.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnConfirmarBaixa.StatePressed.Back.ColorAngle = 135F;
            btnConfirmarBaixa.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnConfirmarBaixa.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnConfirmarBaixa.StatePressed.Border.ColorAngle = 135F;
            btnConfirmarBaixa.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmarBaixa.StatePressed.Border.Rounding = 20F;
            btnConfirmarBaixa.StatePressed.Border.Width = 1;
            btnConfirmarBaixa.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnConfirmarBaixa.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnConfirmarBaixa.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnConfirmarBaixa.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnConfirmarBaixa.StateTracking.Back.ColorAngle = 45F;
            btnConfirmarBaixa.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmarBaixa.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmarBaixa.StateTracking.Border.ColorAngle = 45F;
            btnConfirmarBaixa.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmarBaixa.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmarBaixa.StateTracking.Border.Rounding = 20F;
            btnConfirmarBaixa.StateTracking.Border.Width = 1;
            btnConfirmarBaixa.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnConfirmarBaixa.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnConfirmarBaixa.TabIndex = 3;
            btnConfirmarBaixa.Values.Text = "Confirmar";
            btnConfirmarBaixa.Click += btnConfirmarBaixa_Click;
            // 
            // lblRotuloFormaPgto
            // 
            lblRotuloFormaPgto.AutoSize = true;
            lblRotuloFormaPgto.BackColor = Color.Transparent;
            lblRotuloFormaPgto.Font = new Font("Segoe UI", 9.75F);
            lblRotuloFormaPgto.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloFormaPgto.Location = new Point(9, 161);
            lblRotuloFormaPgto.Name = "lblRotuloFormaPgto";
            lblRotuloFormaPgto.Size = new Size(79, 17);
            lblRotuloFormaPgto.TabIndex = 1050;
            lblRotuloFormaPgto.Text = "Forma Pgto:";
            // 
            // cmbFormaPagamento
            // 
            cmbFormaPagamento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbFormaPagamento.CornerRoundingRadius = 6F;
            cmbFormaPagamento.DropDownWidth = 171;
            cmbFormaPagamento.IntegralHeight = false;
            cmbFormaPagamento.Location = new Point(0, 181);
            cmbFormaPagamento.Name = "cmbFormaPagamento";
            cmbFormaPagamento.Size = new Size(491, 25);
            cmbFormaPagamento.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbFormaPagamento.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbFormaPagamento.StateCommon.ComboBox.Border.Width = 1;
            cmbFormaPagamento.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbFormaPagamento.TabIndex = 0;
            // 
            // txtSaldo
            // 
            txtSaldo.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtSaldo.Location = new Point(328, 231);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtSaldo.ReadOnly = true;
            txtSaldo.Size = new Size(160, 24);
            txtSaldo.StateCommon.Back.Color1 = Color.White;
            txtSaldo.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtSaldo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtSaldo.StateCommon.Border.ColorAngle = 1F;
            txtSaldo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSaldo.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSaldo.StateCommon.Border.Rounding = 6F;
            txtSaldo.StateCommon.Border.Width = 1;
            txtSaldo.StateCommon.Content.Color1 = Color.Gray;
            txtSaldo.StateCommon.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSaldo.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSaldo.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtSaldo.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtSaldo.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtSaldo.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtSaldo.TabIndex = 1054;
            txtSaldo.TabStop = false;
            // 
            // txtValorRecebido
            // 
            txtValorRecebido.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtValorRecebido.Location = new Point(165, 231);
            txtValorRecebido.Name = "txtValorRecebido";
            txtValorRecebido.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtValorRecebido.Size = new Size(160, 24);
            txtValorRecebido.StateCommon.Back.Color1 = Color.White;
            txtValorRecebido.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtValorRecebido.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtValorRecebido.StateCommon.Border.ColorAngle = 1F;
            txtValorRecebido.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtValorRecebido.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtValorRecebido.StateCommon.Border.Rounding = 6F;
            txtValorRecebido.StateCommon.Border.Width = 1;
            txtValorRecebido.StateCommon.Content.Color1 = Color.Gray;
            txtValorRecebido.StateCommon.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorRecebido.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtValorRecebido.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorRecebido.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtValorRecebido.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtValorRecebido.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorRecebido.TabIndex = 1;
            txtValorRecebido.TextChanged += txtValorRecebido_TextChanged;
            txtValorRecebido.Leave += txtValorRecebido_Leave;
            // 
            // lblRotuloValorRecebido
            // 
            lblRotuloValorRecebido.AutoSize = true;
            lblRotuloValorRecebido.Font = new Font("Segoe UI", 9.75F);
            lblRotuloValorRecebido.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloValorRecebido.Location = new Point(165, 211);
            lblRotuloValorRecebido.Name = "lblRotuloValorRecebido";
            lblRotuloValorRecebido.Size = new Size(75, 17);
            lblRotuloValorRecebido.TabIndex = 1055;
            lblRotuloValorRecebido.Text = "Valor Baixa:";
            // 
            // dgvParcelasBaixa
            // 
            dgvParcelasBaixa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvParcelasBaixa.Location = new Point(0, 35);
            dgvParcelasBaixa.Name = "dgvParcelasBaixa";
            dgvParcelasBaixa.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            dgvParcelasBaixa.RowHeadersWidth = 25;
            dgvParcelasBaixa.Size = new Size(492, 114);
            dgvParcelasBaixa.TabIndex = 1059;
            dgvParcelasBaixa.TabStop = false;
            dgvParcelasBaixa.CellFormatting += dgvParcelasBaixa_CellFormatting;
            // 
            // txtValorParcela
            // 
            txtValorParcela.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtValorParcela.Location = new Point(0, 231);
            txtValorParcela.Name = "txtValorParcela";
            txtValorParcela.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtValorParcela.ReadOnly = true;
            txtValorParcela.Size = new Size(160, 24);
            txtValorParcela.StateCommon.Back.Color1 = Color.White;
            txtValorParcela.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtValorParcela.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtValorParcela.StateCommon.Border.ColorAngle = 1F;
            txtValorParcela.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtValorParcela.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtValorParcela.StateCommon.Border.Rounding = 6F;
            txtValorParcela.StateCommon.Border.Width = 1;
            txtValorParcela.StateCommon.Content.Color1 = Color.Gray;
            txtValorParcela.StateCommon.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorParcela.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtValorParcela.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorParcela.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtValorParcela.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtValorParcela.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorParcela.TabIndex = 1039;
            txtValorParcela.TabStop = false;
            // 
            // lblRotuloCliente
            // 
            lblRotuloCliente.AutoSize = true;
            lblRotuloCliente.BackColor = Color.Transparent;
            lblRotuloCliente.Font = new Font("Segoe UI", 9.75F);
            lblRotuloCliente.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloCliente.Location = new Point(3, 7);
            lblRotuloCliente.Name = "lblRotuloCliente";
            lblRotuloCliente.Size = new Size(50, 17);
            lblRotuloCliente.TabIndex = 1053;
            lblRotuloCliente.Text = "Cliente:";
            // 
            // txtClienteNome
            // 
            txtClienteNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClienteNome.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtClienteNome.Location = new Point(55, 5);
            txtClienteNome.Name = "txtClienteNome";
            txtClienteNome.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtClienteNome.ReadOnly = true;
            txtClienteNome.Size = new Size(437, 24);
            txtClienteNome.StateCommon.Back.Color1 = Color.White;
            txtClienteNome.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtClienteNome.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtClienteNome.StateCommon.Border.ColorAngle = 1F;
            txtClienteNome.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtClienteNome.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtClienteNome.StateCommon.Border.Rounding = 6F;
            txtClienteNome.StateCommon.Border.Width = 1;
            txtClienteNome.StateCommon.Content.Color1 = Color.Gray;
            txtClienteNome.StateCommon.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClienteNome.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtClienteNome.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtClienteNome.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtClienteNome.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtClienteNome.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtClienteNome.TabIndex = 1028;
            txtClienteNome.TabStop = false;
            // 
            // lblRotuloSaldo
            // 
            lblRotuloSaldo.AutoSize = true;
            lblRotuloSaldo.BackColor = Color.Transparent;
            lblRotuloSaldo.Font = new Font("Segoe UI", 9.75F);
            lblRotuloSaldo.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloSaldo.Location = new Point(328, 211);
            lblRotuloSaldo.Name = "lblRotuloSaldo";
            lblRotuloSaldo.Size = new Size(44, 17);
            lblRotuloSaldo.TabIndex = 1060;
            lblRotuloSaldo.Text = "Saldo:";
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Items.AddRange(new ToolStripItem[] { lblInfo });
            kryptonStatusStrip1.Location = new Point(0, 376);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.Professional;
            kryptonStatusStrip1.Size = new Size(492, 22);
            kryptonStatusStrip1.TabIndex = 1061;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // lblInfo
            // 
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(28, 17);
            lblInfo.Text = "Info";
            // 
            // txtObservacao
            // 
            txtObservacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtObservacao.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtObservacao.Location = new Point(0, 283);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtObservacao.Size = new Size(486, 47);
            txtObservacao.StateCommon.Back.Color1 = Color.White;
            txtObservacao.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtObservacao.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtObservacao.StateCommon.Border.ColorAngle = 1F;
            txtObservacao.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtObservacao.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtObservacao.StateCommon.Border.Rounding = 6F;
            txtObservacao.StateCommon.Border.Width = 1;
            txtObservacao.StateCommon.Content.Color1 = Color.Gray;
            txtObservacao.StateCommon.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObservacao.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtObservacao.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtObservacao.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtObservacao.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtObservacao.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtObservacao.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = Color.FromArgb(0, 76, 172);
            label1.Location = new Point(0, 262);
            label1.Name = "label1";
            label1.Size = new Size(78, 17);
            label1.TabIndex = 1063;
            label1.Text = "Observação";
            // 
            // FrmBaixarParcela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(492, 398);
            Controls.Add(label1);
            Controls.Add(txtObservacao);
            Controls.Add(kryptonStatusStrip1);
            Controls.Add(lblRotuloSaldo);
            Controls.Add(dgvParcelasBaixa);
            Controls.Add(txtValorRecebido);
            Controls.Add(lblRotuloValorRecebido);
            Controls.Add(txtSaldo);
            Controls.Add(lblRotuloCliente);
            Controls.Add(lblRotuloFormaPgto);
            Controls.Add(cmbFormaPagamento);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmarBaixa);
            Controls.Add(txtValorParcela);
            Controls.Add(lblRotuloValorParcela);
            Controls.Add(txtClienteNome);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBaixarParcela";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Baixar Parcela";
            Load += FrmBaixarParcela_Load;
            Shown += FrmBaixarParcela_Shown;
            KeyDown += FrmBaixarParcela_KeyDown;
            ((System.ComponentModel.ISupportInitialize)cmbFormaPagamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvParcelasBaixa).EndInit();
            kryptonStatusStrip1.ResumeLayout(false);
            kryptonStatusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Label lblRotuloValorParcela;
        private Krypton.Toolkit.KryptonButton btnCancelar;
        public Krypton.Toolkit.KryptonButton btnConfirmarBaixa;
        private Label lblRotuloFormaPgto;
        private Krypton.Toolkit.KryptonComboBox cmbFormaPagamento;
        public Krypton.Toolkit.KryptonTextBox txtSaldo;
        public Krypton.Toolkit.KryptonTextBox txtValorRecebido;
        private Label lblRotuloValorRecebido;
        private Krypton.Toolkit.KryptonDataGridView dgvParcelasBaixa;
        public Krypton.Toolkit.KryptonTextBox txtValorParcela;
        private Label lblRotuloCliente;
        public Krypton.Toolkit.KryptonTextBox txtClienteNome;
        private Label lblRotuloSaldo;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        public ToolStripStatusLabel lblInfo;
        public Krypton.Toolkit.KryptonTextBox txtObservacao;
        private Label label1;
    }
}