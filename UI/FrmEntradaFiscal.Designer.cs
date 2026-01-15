namespace GVC.View
{
    partial class FrmEntradaFiscal
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
            grpDocumento = new GroupBox();
            cmbFornecedor = new Krypton.Toolkit.KryptonComboBox();
            lblRotuloFornecedor = new Label();
            btnBuscarFornecedor = new Krypton.Toolkit.KryptonButton();
            lblRotuloDataEmissao = new Label();
            dtpDataEmissao = new Krypton.Toolkit.KryptonDateTimePicker();
            txtSerie = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloSerie = new Label();
            cmbTipoDocumento = new Krypton.Toolkit.KryptonComboBox();
            lblRotuloTipoDocumento = new Label();
            txtNumeroDocumento = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloNumDocumento = new Label();
            grpItens = new GroupBox();
            dgvItensDocumento = new Krypton.Toolkit.KryptonDataGridView();
            grpTotais = new GroupBox();
            btnConfirmarEntrada = new Krypton.Toolkit.KryptonButton();
            btnCancelar = new Krypton.Toolkit.KryptonButton();
            bnRemoverItem = new Krypton.Toolkit.KryptonButton();
            btnAdicionarItem = new Krypton.Toolkit.KryptonButton();
            txtTotalItens = new Krypton.Toolkit.KryptonTextBox();
            label1 = new Label();
            grpDocumento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbFornecedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbTipoDocumento).BeginInit();
            grpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensDocumento).BeginInit();
            grpTotais.SuspendLayout();
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
            // grpDocumento
            // 
            grpDocumento.Controls.Add(cmbFornecedor);
            grpDocumento.Controls.Add(lblRotuloFornecedor);
            grpDocumento.Controls.Add(btnBuscarFornecedor);
            grpDocumento.Controls.Add(lblRotuloDataEmissao);
            grpDocumento.Controls.Add(dtpDataEmissao);
            grpDocumento.Controls.Add(txtSerie);
            grpDocumento.Controls.Add(lblRotuloSerie);
            grpDocumento.Controls.Add(cmbTipoDocumento);
            grpDocumento.Controls.Add(lblRotuloTipoDocumento);
            grpDocumento.Controls.Add(txtNumeroDocumento);
            grpDocumento.Controls.Add(lblRotuloNumDocumento);
            grpDocumento.Location = new Point(0, -1);
            grpDocumento.Name = "grpDocumento";
            grpDocumento.Size = new Size(884, 148);
            grpDocumento.TabIndex = 0;
            grpDocumento.TabStop = false;
            grpDocumento.Text = "Documento Fiscal";
            // 
            // cmbFornecedor
            // 
            cmbFornecedor.CornerRoundingRadius = 6F;
            cmbFornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFornecedor.DropDownWidth = 115;
            cmbFornecedor.IntegralHeight = false;
            cmbFornecedor.Items.AddRange(new object[] { "NF-e", "NFC-e", "Cupom Fiscal", "Cupom Não Fiscal" });
            cmbFornecedor.Location = new Point(12, 107);
            cmbFornecedor.Name = "cmbFornecedor";
            cmbFornecedor.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbFornecedor.Size = new Size(824, 25);
            cmbFornecedor.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbFornecedor.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbFornecedor.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbFornecedor.TabIndex = 1098;
            cmbFornecedor.TabStop = false;
            // 
            // lblRotuloFornecedor
            // 
            lblRotuloFornecedor.AutoSize = true;
            lblRotuloFornecedor.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloFornecedor.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloFornecedor.Location = new Point(15, 85);
            lblRotuloFornecedor.Name = "lblRotuloFornecedor";
            lblRotuloFornecedor.Size = new Size(77, 16);
            lblRotuloFornecedor.TabIndex = 1097;
            lblRotuloFornecedor.Text = "Fornecedor";
            // 
            // btnBuscarFornecedor
            // 
            btnBuscarFornecedor.CornerRoundingRadius = 10F;
            btnBuscarFornecedor.Location = new Point(842, 105);
            btnBuscarFornecedor.Name = "btnBuscarFornecedor";
            btnBuscarFornecedor.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnBuscarFornecedor.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnBuscarFornecedor.OverrideDefault.Back.ColorAngle = 45F;
            btnBuscarFornecedor.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnBuscarFornecedor.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBuscarFornecedor.OverrideDefault.Border.ColorAngle = 45F;
            btnBuscarFornecedor.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscarFornecedor.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBuscarFornecedor.OverrideDefault.Border.Rounding = 20F;
            btnBuscarFornecedor.OverrideDefault.Border.Width = 1;
            btnBuscarFornecedor.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnBuscarFornecedor.Size = new Size(30, 29);
            btnBuscarFornecedor.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnBuscarFornecedor.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnBuscarFornecedor.StateCommon.Back.ColorAngle = 45F;
            btnBuscarFornecedor.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnBuscarFornecedor.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBuscarFornecedor.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscarFornecedor.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBuscarFornecedor.StateCommon.Border.Rounding = 10F;
            btnBuscarFornecedor.StateCommon.Border.Width = 1;
            btnBuscarFornecedor.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnBuscarFornecedor.StateCommon.Content.ShortText.Color2 = Color.White;
            btnBuscarFornecedor.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarFornecedor.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnBuscarFornecedor.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnBuscarFornecedor.StatePressed.Back.ColorAngle = 135F;
            btnBuscarFornecedor.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnBuscarFornecedor.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnBuscarFornecedor.StatePressed.Border.ColorAngle = 135F;
            btnBuscarFornecedor.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscarFornecedor.StatePressed.Border.Rounding = 20F;
            btnBuscarFornecedor.StatePressed.Border.Width = 1;
            btnBuscarFornecedor.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnBuscarFornecedor.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnBuscarFornecedor.StateTracking.Back.ColorAngle = 45F;
            btnBuscarFornecedor.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnBuscarFornecedor.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBuscarFornecedor.StateTracking.Border.ColorAngle = 45F;
            btnBuscarFornecedor.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscarFornecedor.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBuscarFornecedor.StateTracking.Border.Rounding = 20F;
            btnBuscarFornecedor.StateTracking.Border.Width = 1;
            btnBuscarFornecedor.StateTracking.Content.ShortText.Color1 = Color.White;
            btnBuscarFornecedor.TabIndex = 1093;
            btnBuscarFornecedor.TabStop = false;
            btnBuscarFornecedor.Values.Image = Properties.Resources.Pesquisar;
            btnBuscarFornecedor.Values.Text = "";
            // 
            // lblRotuloDataEmissao
            // 
            lblRotuloDataEmissao.AutoSize = true;
            lblRotuloDataEmissao.BackColor = Color.Transparent;
            lblRotuloDataEmissao.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRotuloDataEmissao.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloDataEmissao.Location = new Point(653, 35);
            lblRotuloDataEmissao.Name = "lblRotuloDataEmissao";
            lblRotuloDataEmissao.Size = new Size(103, 16);
            lblRotuloDataEmissao.TabIndex = 1096;
            lblRotuloDataEmissao.Text = "Data emissão";
            // 
            // dtpDataEmissao
            // 
            dtpDataEmissao.CornerRoundingRadius = 6F;
            dtpDataEmissao.Format = DateTimePickerFormat.Short;
            dtpDataEmissao.Location = new Point(652, 54);
            dtpDataEmissao.Name = "dtpDataEmissao";
            dtpDataEmissao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            dtpDataEmissao.Size = new Size(183, 25);
            dtpDataEmissao.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataEmissao.StateCommon.Border.Rounding = 6F;
            dtpDataEmissao.TabIndex = 1095;
            // 
            // txtSerie
            // 
            txtSerie.Location = new Point(449, 54);
            txtSerie.Name = "txtSerie";
            txtSerie.ReadOnly = true;
            txtSerie.Size = new Size(200, 24);
            txtSerie.StateCommon.Back.Color1 = Color.White;
            txtSerie.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtSerie.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtSerie.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSerie.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSerie.StateCommon.Border.Rounding = 8F;
            txtSerie.StateCommon.Border.Width = 1;
            txtSerie.StateCommon.Content.Color1 = Color.Gray;
            txtSerie.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtSerie.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSerie.TabIndex = 1094;
            txtSerie.TabStop = false;
            txtSerie.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRotuloSerie
            // 
            lblRotuloSerie.AutoSize = true;
            lblRotuloSerie.BackColor = Color.Transparent;
            lblRotuloSerie.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRotuloSerie.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloSerie.Location = new Point(455, 36);
            lblRotuloSerie.Name = "lblRotuloSerie";
            lblRotuloSerie.Size = new Size(44, 16);
            lblRotuloSerie.TabIndex = 1093;
            lblRotuloSerie.Text = "Série";
            // 
            // cmbTipoDocumento
            // 
            cmbTipoDocumento.CornerRoundingRadius = 6F;
            cmbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDocumento.DropDownWidth = 115;
            cmbTipoDocumento.IntegralHeight = false;
            cmbTipoDocumento.Items.AddRange(new object[] { "NF-e", "NFC-e", "Cupom Fiscal", "Cupom Não Fiscal" });
            cmbTipoDocumento.Location = new Point(12, 54);
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbTipoDocumento.Size = new Size(223, 25);
            cmbTipoDocumento.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoDocumento.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbTipoDocumento.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbTipoDocumento.TabIndex = 1092;
            cmbTipoDocumento.TabStop = false;
            // 
            // lblRotuloTipoDocumento
            // 
            lblRotuloTipoDocumento.AutoSize = true;
            lblRotuloTipoDocumento.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloTipoDocumento.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloTipoDocumento.Location = new Point(15, 32);
            lblRotuloTipoDocumento.Name = "lblRotuloTipoDocumento";
            lblRotuloTipoDocumento.Size = new Size(104, 16);
            lblRotuloTipoDocumento.TabIndex = 1091;
            lblRotuloTipoDocumento.Text = "Tipo movimento";
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(238, 54);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.ReadOnly = true;
            txtNumeroDocumento.Size = new Size(208, 24);
            txtNumeroDocumento.StateCommon.Back.Color1 = Color.White;
            txtNumeroDocumento.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNumeroDocumento.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNumeroDocumento.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNumeroDocumento.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNumeroDocumento.StateCommon.Border.Rounding = 8F;
            txtNumeroDocumento.StateCommon.Border.Width = 1;
            txtNumeroDocumento.StateCommon.Content.Color1 = Color.Gray;
            txtNumeroDocumento.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtNumeroDocumento.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNumeroDocumento.TabIndex = 1090;
            txtNumeroDocumento.TabStop = false;
            txtNumeroDocumento.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRotuloNumDocumento
            // 
            lblRotuloNumDocumento.AutoSize = true;
            lblRotuloNumDocumento.BackColor = Color.Transparent;
            lblRotuloNumDocumento.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRotuloNumDocumento.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloNumDocumento.Location = new Point(242, 35);
            lblRotuloNumDocumento.Name = "lblRotuloNumDocumento";
            lblRotuloNumDocumento.Size = new Size(106, 16);
            lblRotuloNumDocumento.TabIndex = 1089;
            lblRotuloNumDocumento.Text = "Nº Documento";
            // 
            // grpItens
            // 
            grpItens.Controls.Add(dgvItensDocumento);
            grpItens.Location = new Point(0, 153);
            grpItens.Name = "grpItens";
            grpItens.Size = new Size(884, 226);
            grpItens.TabIndex = 1;
            grpItens.TabStop = false;
            grpItens.Text = "Itens do documento";
            // 
            // dgvItensDocumento
            // 
            dgvItensDocumento.Location = new Point(12, 31);
            dgvItensDocumento.Name = "dgvItensDocumento";
            dgvItensDocumento.Size = new Size(866, 183);
            dgvItensDocumento.TabIndex = 0;
            // 
            // grpTotais
            // 
            grpTotais.Controls.Add(btnConfirmarEntrada);
            grpTotais.Controls.Add(btnCancelar);
            grpTotais.Controls.Add(bnRemoverItem);
            grpTotais.Controls.Add(btnAdicionarItem);
            grpTotais.Controls.Add(txtTotalItens);
            grpTotais.Controls.Add(label1);
            grpTotais.Location = new Point(0, 385);
            grpTotais.Name = "grpTotais";
            grpTotais.Size = new Size(884, 70);
            grpTotais.TabIndex = 2;
            grpTotais.TabStop = false;
            grpTotais.Text = "Totais";
            // 
            // btnConfirmarEntrada
            // 
            btnConfirmarEntrada.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmarEntrada.CornerRoundingRadius = 6F;
            btnConfirmarEntrada.Location = new Point(559, 34);
            btnConfirmarEntrada.Name = "btnConfirmarEntrada";
            btnConfirmarEntrada.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmarEntrada.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmarEntrada.OverrideDefault.Back.ColorAngle = 45F;
            btnConfirmarEntrada.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmarEntrada.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmarEntrada.OverrideDefault.Border.ColorAngle = 45F;
            btnConfirmarEntrada.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmarEntrada.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmarEntrada.OverrideDefault.Border.Rounding = 20F;
            btnConfirmarEntrada.OverrideDefault.Border.Width = 1;
            btnConfirmarEntrada.Size = new Size(150, 30);
            btnConfirmarEntrada.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnConfirmarEntrada.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmarEntrada.StateCommon.Back.ColorAngle = 45F;
            btnConfirmarEntrada.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmarEntrada.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmarEntrada.StateCommon.Border.Rounding = 6F;
            btnConfirmarEntrada.StateCommon.Border.Width = 1;
            btnConfirmarEntrada.StateCommon.Content.ShortText.Color1 = Color.White;
            btnConfirmarEntrada.StateCommon.Content.ShortText.Color2 = Color.White;
            btnConfirmarEntrada.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnConfirmarEntrada.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnConfirmarEntrada.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnConfirmarEntrada.StatePressed.Back.ColorAngle = 135F;
            btnConfirmarEntrada.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnConfirmarEntrada.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnConfirmarEntrada.StatePressed.Border.ColorAngle = 135F;
            btnConfirmarEntrada.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmarEntrada.StatePressed.Border.Rounding = 20F;
            btnConfirmarEntrada.StatePressed.Border.Width = 1;
            btnConfirmarEntrada.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnConfirmarEntrada.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnConfirmarEntrada.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnConfirmarEntrada.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnConfirmarEntrada.StateTracking.Back.ColorAngle = 45F;
            btnConfirmarEntrada.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmarEntrada.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmarEntrada.StateTracking.Border.ColorAngle = 45F;
            btnConfirmarEntrada.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmarEntrada.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmarEntrada.StateTracking.Border.Rounding = 20F;
            btnConfirmarEntrada.StateTracking.Border.Width = 1;
            btnConfirmarEntrada.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnConfirmarEntrada.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnConfirmarEntrada.TabIndex = 1094;
            btnConfirmarEntrada.TabStop = false;
            btnConfirmarEntrada.Values.Text = "Confirmar entrada";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.CornerRoundingRadius = 6F;
            btnCancelar.Location = new Point(728, 34);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.OverrideDefault.Back.ColorAngle = 45F;
            btnCancelar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.OverrideDefault.Border.ColorAngle = 45F;
            btnCancelar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.OverrideDefault.Border.Rounding = 20F;
            btnCancelar.OverrideDefault.Border.Width = 1;
            btnCancelar.Size = new Size(150, 30);
            btnCancelar.StateCommon.Back.Color1 = Color.Red;
            btnCancelar.StateCommon.Back.Color2 = Color.Red;
            btnCancelar.StateCommon.Back.ColorAngle = 45F;
            btnCancelar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.StateCommon.Border.Rounding = 6F;
            btnCancelar.StateCommon.Border.Width = 1;
            btnCancelar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnCancelar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCancelar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnCancelar.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnCancelar.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnCancelar.StatePressed.Back.ColorAngle = 135F;
            btnCancelar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnCancelar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnCancelar.StatePressed.Border.ColorAngle = 135F;
            btnCancelar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StatePressed.Border.Rounding = 20F;
            btnCancelar.StatePressed.Border.Width = 1;
            btnCancelar.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnCancelar.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnCancelar.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnCancelar.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnCancelar.StateTracking.Back.ColorAngle = 45F;
            btnCancelar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.StateTracking.Border.ColorAngle = 45F;
            btnCancelar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.StateTracking.Border.Rounding = 20F;
            btnCancelar.StateTracking.Border.Width = 1;
            btnCancelar.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnCancelar.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnCancelar.TabIndex = 1093;
            btnCancelar.TabStop = false;
            btnCancelar.Values.Text = "Cancelar";
            // 
            // bnRemoverItem
            // 
            bnRemoverItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bnRemoverItem.CornerRoundingRadius = 6F;
            bnRemoverItem.Location = new Point(403, 34);
            bnRemoverItem.Name = "bnRemoverItem";
            bnRemoverItem.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            bnRemoverItem.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            bnRemoverItem.OverrideDefault.Back.ColorAngle = 45F;
            bnRemoverItem.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            bnRemoverItem.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            bnRemoverItem.OverrideDefault.Border.ColorAngle = 45F;
            bnRemoverItem.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            bnRemoverItem.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            bnRemoverItem.OverrideDefault.Border.Rounding = 20F;
            bnRemoverItem.OverrideDefault.Border.Width = 1;
            bnRemoverItem.Size = new Size(150, 30);
            bnRemoverItem.StateCommon.Back.Color1 = Color.Red;
            bnRemoverItem.StateCommon.Back.Color2 = Color.Red;
            bnRemoverItem.StateCommon.Back.ColorAngle = 45F;
            bnRemoverItem.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            bnRemoverItem.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            bnRemoverItem.StateCommon.Border.Rounding = 6F;
            bnRemoverItem.StateCommon.Border.Width = 1;
            bnRemoverItem.StateCommon.Content.ShortText.Color1 = Color.White;
            bnRemoverItem.StateCommon.Content.ShortText.Color2 = Color.White;
            bnRemoverItem.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            bnRemoverItem.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            bnRemoverItem.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            bnRemoverItem.StatePressed.Back.ColorAngle = 135F;
            bnRemoverItem.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            bnRemoverItem.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            bnRemoverItem.StatePressed.Border.ColorAngle = 135F;
            bnRemoverItem.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            bnRemoverItem.StatePressed.Border.Rounding = 20F;
            bnRemoverItem.StatePressed.Border.Width = 1;
            bnRemoverItem.StatePressed.Content.ShortText.Color1 = Color.Black;
            bnRemoverItem.StatePressed.Content.ShortText.Color2 = Color.Black;
            bnRemoverItem.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            bnRemoverItem.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            bnRemoverItem.StateTracking.Back.ColorAngle = 45F;
            bnRemoverItem.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            bnRemoverItem.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            bnRemoverItem.StateTracking.Border.ColorAngle = 45F;
            bnRemoverItem.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            bnRemoverItem.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            bnRemoverItem.StateTracking.Border.Rounding = 20F;
            bnRemoverItem.StateTracking.Border.Width = 1;
            bnRemoverItem.StateTracking.Content.ShortText.Color1 = Color.Black;
            bnRemoverItem.StateTracking.Content.ShortText.Color2 = Color.Black;
            bnRemoverItem.TabIndex = 1087;
            bnRemoverItem.TabStop = false;
            bnRemoverItem.Values.Text = "Remover item -";
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdicionarItem.CornerRoundingRadius = 6F;
            btnAdicionarItem.Location = new Point(247, 34);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnAdicionarItem.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnAdicionarItem.OverrideDefault.Back.ColorAngle = 45F;
            btnAdicionarItem.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAdicionarItem.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAdicionarItem.OverrideDefault.Border.ColorAngle = 45F;
            btnAdicionarItem.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdicionarItem.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdicionarItem.OverrideDefault.Border.Rounding = 20F;
            btnAdicionarItem.OverrideDefault.Border.Width = 1;
            btnAdicionarItem.Size = new Size(150, 30);
            btnAdicionarItem.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnAdicionarItem.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnAdicionarItem.StateCommon.Back.ColorAngle = 45F;
            btnAdicionarItem.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdicionarItem.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdicionarItem.StateCommon.Border.Rounding = 6F;
            btnAdicionarItem.StateCommon.Border.Width = 1;
            btnAdicionarItem.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAdicionarItem.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAdicionarItem.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnAdicionarItem.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnAdicionarItem.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnAdicionarItem.StatePressed.Back.ColorAngle = 135F;
            btnAdicionarItem.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnAdicionarItem.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnAdicionarItem.StatePressed.Border.ColorAngle = 135F;
            btnAdicionarItem.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdicionarItem.StatePressed.Border.Rounding = 20F;
            btnAdicionarItem.StatePressed.Border.Width = 1;
            btnAdicionarItem.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnAdicionarItem.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnAdicionarItem.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnAdicionarItem.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnAdicionarItem.StateTracking.Back.ColorAngle = 45F;
            btnAdicionarItem.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAdicionarItem.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAdicionarItem.StateTracking.Border.ColorAngle = 45F;
            btnAdicionarItem.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdicionarItem.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdicionarItem.StateTracking.Border.Rounding = 20F;
            btnAdicionarItem.StateTracking.Border.Width = 1;
            btnAdicionarItem.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnAdicionarItem.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnAdicionarItem.TabIndex = 1086;
            btnAdicionarItem.TabStop = false;
            btnAdicionarItem.Values.Text = "Adicionar item +";
            // 
            // txtTotalItens
            // 
            txtTotalItens.Location = new Point(12, 40);
            txtTotalItens.Name = "txtTotalItens";
            txtTotalItens.ReadOnly = true;
            txtTotalItens.Size = new Size(208, 24);
            txtTotalItens.StateCommon.Back.Color1 = Color.White;
            txtTotalItens.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtTotalItens.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtTotalItens.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTotalItens.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtTotalItens.StateCommon.Border.Rounding = 8F;
            txtTotalItens.StateCommon.Border.Width = 1;
            txtTotalItens.StateCommon.Content.Color1 = Color.Gray;
            txtTotalItens.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtTotalItens.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtTotalItens.TabIndex = 1092;
            txtTotalItens.TabStop = false;
            txtTotalItens.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 76, 172);
            label1.Location = new Point(16, 21);
            label1.Name = "label1";
            label1.Size = new Size(84, 16);
            label1.TabIndex = 1091;
            label1.Text = "Totail itens";
            // 
            // FrmEntradaFiscal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(884, 530);
            Controls.Add(grpTotais);
            Controls.Add(grpItens);
            Controls.Add(grpDocumento);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEntradaFiscal";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrada Fiscal";
            grpDocumento.ResumeLayout(false);
            grpDocumento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbFornecedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbTipoDocumento).EndInit();
            grpItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItensDocumento).EndInit();
            grpTotais.ResumeLayout(false);
            grpTotais.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private GroupBox grpDocumento;
        private GroupBox grpItens;
        private Label lblRotuloDataEmissao;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDataEmissao;
        public Krypton.Toolkit.KryptonTextBox txtSerie;
        private Label lblRotuloSerie;
        public Krypton.Toolkit.KryptonComboBox cmbTipoDocumento;
        private Label lblRotuloTipoDocumento;
        public Krypton.Toolkit.KryptonTextBox txtNumeroDocumento;
        private Label lblRotuloNumDocumento;
        public Krypton.Toolkit.KryptonButton btnBuscarFornecedor;
        public Krypton.Toolkit.KryptonComboBox cmbFornecedor;
        private Label lblRotuloFornecedor;
        private Krypton.Toolkit.KryptonDataGridView dgvItensDocumento;
        private GroupBox grpTotais;
        public Krypton.Toolkit.KryptonTextBox txtTotalItens;
        private Label label1;
        public Krypton.Toolkit.KryptonButton btnConfirmarEntrada;
        public Krypton.Toolkit.KryptonButton btnCancelar;
        public Krypton.Toolkit.KryptonButton bnRemoverItem;
        public Krypton.Toolkit.KryptonButton btnAdicionarItem;
    }
}