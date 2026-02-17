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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntradaFiscal));
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            lblDataEmissao = new Label();
            dtpDataEmissao = new Krypton.Toolkit.KryptonDateTimePicker();
            txtSerie = new Krypton.Toolkit.KryptonTextBox();
            lblSerie = new Label();
            cmbTipoDocumento = new Krypton.Toolkit.KryptonComboBox();
            lblTipoDocumento = new Label();
            txtNumeroDocumento = new Krypton.Toolkit.KryptonTextBox();
            lblNumDocumento = new Label();
            grpItens = new GroupBox();
            dgvItensDocumento = new Krypton.Toolkit.KryptonDataGridView();
            grpTotais = new GroupBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            lblTotalItens = new Krypton.Toolkit.KryptonLabel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            lblTotal = new Krypton.Toolkit.KryptonLabel();
            btnConfirmar = new FontAwesome.Sharp.IconButton();
            btnSair = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnAdicionarItem = new FontAwesome.Sharp.IconButton();
            btnRemoverItem = new FontAwesome.Sharp.IconButton();
            btnVerControlesDoForm = new FontAwesome.Sharp.IconButton();
            lblRotuloDadosCadastrais = new Krypton.Toolkit.KryptonLabel();
            pnlHeader = new Krypton.Toolkit.KryptonPanel();
            tlpTitulo = new Krypton.Toolkit.KryptonTableLayoutPanel();
            lblSubTitulo = new Krypton.Toolkit.KryptonLabel();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            txtFornecedor = new Krypton.Toolkit.KryptonTextBox();
            lblFornecedor = new Label();
            lblTipoEntrada = new Label();
            cmbTipoEntrada = new Krypton.Toolkit.KryptonComboBox();
            txtProduto = new Krypton.Toolkit.KryptonTextBox();
            lblProduto = new Label();
            txtPrecoCompra = new Krypton.Toolkit.KryptonTextBox();
            lblPrecoCompra = new Label();
            txtQuantidade = new Krypton.Toolkit.KryptonTextBox();
            lblQuantidade = new Label();
            txtPrecoCusto = new Krypton.Toolkit.KryptonTextBox();
            lblPrecoCusto = new Label();
            ((System.ComponentModel.ISupportInitialize)cmbTipoDocumento).BeginInit();
            grpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensDocumento).BeginInit();
            grpTotais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).BeginInit();
            pnlHeader.SuspendLayout();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbTipoEntrada).BeginInit();
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
            // lblDataEmissao
            // 
            lblDataEmissao.AutoSize = true;
            lblDataEmissao.BackColor = Color.Transparent;
            lblDataEmissao.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblDataEmissao.ForeColor = Color.FromArgb(0, 76, 172);
            lblDataEmissao.Location = new Point(14, 92);
            lblDataEmissao.Name = "lblDataEmissao";
            lblDataEmissao.Size = new Size(91, 16);
            lblDataEmissao.TabIndex = 1096;
            lblDataEmissao.Text = "Data emissão";
            // 
            // dtpDataEmissao
            // 
            dtpDataEmissao.CornerRoundingRadius = 6F;
            dtpDataEmissao.Format = DateTimePickerFormat.Short;
            dtpDataEmissao.Location = new Point(14, 110);
            dtpDataEmissao.Name = "dtpDataEmissao";
            dtpDataEmissao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            dtpDataEmissao.Size = new Size(106, 25);
            dtpDataEmissao.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataEmissao.StateCommon.Border.Rounding = 6F;
            dtpDataEmissao.TabIndex = 1095;
            dtpDataEmissao.TabStop = false;
            // 
            // txtSerie
            // 
            txtSerie.Location = new Point(637, 112);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(348, 24);
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
            txtSerie.TabIndex = 1;
            txtSerie.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSerie
            // 
            lblSerie.AutoSize = true;
            lblSerie.BackColor = Color.Transparent;
            lblSerie.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblSerie.ForeColor = Color.FromArgb(0, 76, 172);
            lblSerie.Location = new Point(643, 93);
            lblSerie.Name = "lblSerie";
            lblSerie.Size = new Size(39, 16);
            lblSerie.TabIndex = 1093;
            lblSerie.Text = "Série";
            // 
            // cmbTipoDocumento
            // 
            cmbTipoDocumento.CornerRoundingRadius = 6F;
            cmbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDocumento.DropDownWidth = 115;
            cmbTipoDocumento.IntegralHeight = false;
            cmbTipoDocumento.Items.AddRange(new object[] { "NF-e", "NFC-e", "Cupom Fiscal", "Cupom Não Fiscal" });
            cmbTipoDocumento.Location = new Point(126, 111);
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbTipoDocumento.Size = new Size(140, 25);
            cmbTipoDocumento.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoDocumento.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbTipoDocumento.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbTipoDocumento.TabIndex = 30;
            cmbTipoDocumento.TabStop = false;
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblTipoDocumento.ForeColor = Color.FromArgb(0, 76, 172);
            lblTipoDocumento.Location = new Point(126, 89);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(126, 16);
            lblTipoDocumento.TabIndex = 1091;
            lblTipoDocumento.Text = "Tipo de Documento";
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(418, 112);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(215, 24);
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
            txtNumeroDocumento.TabIndex = 0;
            txtNumeroDocumento.TextAlign = HorizontalAlignment.Center;
            // 
            // lblNumDocumento
            // 
            lblNumDocumento.AutoSize = true;
            lblNumDocumento.BackColor = Color.Transparent;
            lblNumDocumento.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblNumDocumento.ForeColor = Color.FromArgb(0, 76, 172);
            lblNumDocumento.Location = new Point(422, 92);
            lblNumDocumento.Name = "lblNumDocumento";
            lblNumDocumento.Size = new Size(93, 16);
            lblNumDocumento.TabIndex = 1089;
            lblNumDocumento.Text = "Nº Nota Fiscal";
            // 
            // grpItens
            // 
            grpItens.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpItens.Controls.Add(dgvItensDocumento);
            grpItens.Location = new Point(14, 293);
            grpItens.Name = "grpItens";
            grpItens.Size = new Size(982, 177);
            grpItens.TabIndex = 1200;
            grpItens.TabStop = false;
            grpItens.Text = "Itens do documento";
            // 
            // dgvItensDocumento
            // 
            dgvItensDocumento.Dock = DockStyle.Fill;
            dgvItensDocumento.Location = new Point(3, 19);
            dgvItensDocumento.Name = "dgvItensDocumento";
            dgvItensDocumento.Size = new Size(976, 155);
            dgvItensDocumento.TabIndex = 500;
            dgvItensDocumento.TabStop = false;
            dgvItensDocumento.CellContentClick += dgvItensDocumento_CellContentClick;
            // 
            // grpTotais
            // 
            grpTotais.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpTotais.Controls.Add(iconPictureBox1);
            grpTotais.Controls.Add(iconPictureBox2);
            grpTotais.Controls.Add(kryptonLabel1);
            grpTotais.Controls.Add(lblTotalItens);
            grpTotais.Controls.Add(kryptonLabel7);
            grpTotais.Controls.Add(lblTotal);
            grpTotais.Controls.Add(btnConfirmar);
            grpTotais.Controls.Add(btnSair);
            grpTotais.Controls.Add(btnCancelar);
            grpTotais.Location = new Point(14, 472);
            grpTotais.Name = "grpTotais";
            grpTotais.Size = new Size(982, 93);
            grpTotais.TabIndex = 2;
            grpTotais.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.IndianRed;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            iconPictureBox1.IconColor = Color.IndianRed;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 36;
            iconPictureBox1.Location = new Point(6, 22);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(36, 36);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(45, 22);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Black;
            kryptonLabel1.Size = new Size(50, 26);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.IndianRed;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 12F);
            kryptonLabel1.TabIndex = 3;
            kryptonLabel1.Values.Text = "Itens:";
            // 
            // lblTotalItens
            // 
            lblTotalItens.Location = new Point(99, 22);
            lblTotalItens.Name = "lblTotalItens";
            lblTotalItens.PaletteMode = Krypton.Toolkit.PaletteMode.Office365SilverLightMode;
            lblTotalItens.Size = new Size(21, 26);
            lblTotalItens.StateCommon.ShortText.Color1 = Color.IndianRed;
            lblTotalItens.StateCommon.ShortText.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            lblTotalItens.TabIndex = 3;
            lblTotalItens.Values.Text = "0";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.ForeColor = Color.ForestGreen;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            iconPictureBox2.IconColor = Color.ForestGreen;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 36;
            iconPictureBox2.Location = new Point(6, 60);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(36, 36);
            iconPictureBox2.TabIndex = 0;
            iconPictureBox2.TabStop = false;
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(46, 60);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Black;
            kryptonLabel7.Size = new Size(52, 26);
            kryptonLabel7.StateCommon.ShortText.Color1 = Color.ForestGreen;
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Segoe UI", 12F);
            kryptonLabel7.TabIndex = 3;
            kryptonLabel7.Values.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(97, 60);
            lblTotal.Name = "lblTotal";
            lblTotal.PaletteMode = Krypton.Toolkit.PaletteMode.Office365SilverLightMode;
            lblTotal.Size = new Size(68, 26);
            lblTotal.StateCommon.ShortText.Color1 = Color.ForestGreen;
            lblTotal.StateCommon.ShortText.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            lblTotal.TabIndex = 3;
            lblTotal.Values.Text = "R$ 0,00";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfirmar.BackColor = Color.FromArgb(30, 136, 229);
            btnConfirmar.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnConfirmar.IconColor = Color.White;
            btnConfirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfirmar.IconSize = 28;
            btnConfirmar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmar.Location = new Point(480, 44);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Padding = new Padding(10, 0, 10, 0);
            btnConfirmar.Size = new Size(160, 38);
            btnConfirmar.TabIndex = 1143;
            btnConfirmar.TabStop = false;
            btnConfirmar.Text = "    Confirmar";
            btnConfirmar.TextAlign = ContentAlignment.MiddleRight;
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSair.BackColor = Color.Gray;
            btnSair.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnSair.ForeColor = Color.White;
            btnSair.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnSair.IconColor = Color.White;
            btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSair.IconSize = 28;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(811, 44);
            btnSair.Name = "btnSair";
            btnSair.Padding = new Padding(10, 0, 10, 0);
            btnSair.Size = new Size(160, 38);
            btnSair.TabIndex = 1142;
            btnSair.TabStop = false;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(255, 152, 0);
            btnCancelar.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnCancelar.IconColor = Color.White;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 28;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(646, 44);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 38);
            btnCancelar.TabIndex = 1140;
            btnCancelar.TabStop = false;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdicionarItem.BackColor = Color.FromArgb(76, 175, 80);
            btnAdicionarItem.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnAdicionarItem.ForeColor = Color.White;
            btnAdicionarItem.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAdicionarItem.IconColor = Color.White;
            btnAdicionarItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdicionarItem.IconSize = 28;
            btnAdicionarItem.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionarItem.Location = new Point(666, 253);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Padding = new Padding(10, 0, 10, 0);
            btnAdicionarItem.Size = new Size(160, 38);
            btnAdicionarItem.TabIndex = 7;
            btnAdicionarItem.Text = "       Adicionar Ìtem";
            btnAdicionarItem.UseVisualStyleBackColor = false;
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // btnRemoverItem
            // 
            btnRemoverItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemoverItem.BackColor = Color.FromArgb(229, 57, 53);
            btnRemoverItem.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnRemoverItem.ForeColor = Color.White;
            btnRemoverItem.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            btnRemoverItem.IconColor = Color.White;
            btnRemoverItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRemoverItem.IconSize = 18;
            btnRemoverItem.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemoverItem.Location = new Point(832, 253);
            btnRemoverItem.Name = "btnRemoverItem";
            btnRemoverItem.Padding = new Padding(10, 0, 10, 0);
            btnRemoverItem.Size = new Size(160, 38);
            btnRemoverItem.TabIndex = 1141;
            btnRemoverItem.TabStop = false;
            btnRemoverItem.Text = "Excluir Ìtem";
            btnRemoverItem.UseVisualStyleBackColor = false;
            // 
            // btnVerControlesDoForm
            // 
            btnVerControlesDoForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVerControlesDoForm.BackColor = Color.Green;
            btnVerControlesDoForm.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnVerControlesDoForm.ForeColor = Color.White;
            btnVerControlesDoForm.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnVerControlesDoForm.IconColor = Color.White;
            btnVerControlesDoForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerControlesDoForm.IconSize = 28;
            btnVerControlesDoForm.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerControlesDoForm.Location = new Point(12, 571);
            btnVerControlesDoForm.Name = "btnVerControlesDoForm";
            btnVerControlesDoForm.Padding = new Padding(10, 0, 10, 0);
            btnVerControlesDoForm.Size = new Size(54, 38);
            btnVerControlesDoForm.TabIndex = 1128;
            btnVerControlesDoForm.TextAlign = ContentAlignment.MiddleRight;
            btnVerControlesDoForm.UseVisualStyleBackColor = false;
            btnVerControlesDoForm.Click += btnVerControlesDoForm_Click;
            // 
            // lblRotuloDadosCadastrais
            // 
            lblRotuloDadosCadastrais.Location = new Point(1, 59);
            lblRotuloDadosCadastrais.Name = "lblRotuloDadosCadastrais";
            lblRotuloDadosCadastrais.Size = new Size(132, 20);
            lblRotuloDadosCadastrais.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRotuloDadosCadastrais.TabIndex = 1129;
            lblRotuloDadosCadastrais.TabStop = false;
            lblRotuloDadosCadastrais.Values.Text = "Dados da Nota Fiscal";
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(tlpTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1008, 47);
            pnlHeader.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            pnlHeader.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            pnlHeader.TabIndex = 1130;
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
            tlpTitulo.Size = new Size(1008, 47);
            tlpTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            tlpTitulo.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            tlpTitulo.TabIndex = 0;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.Dock = DockStyle.Fill;
            lblSubTitulo.Location = new Point(3, 25);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(1002, 19);
            lblSubTitulo.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Color2 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblSubTitulo.TabIndex = 0;
            lblSubTitulo.Values.Text = "Inclusão e manutenção de produtos";
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Location = new Point(3, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1002, 16);
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Color2 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 1091;
            lblTitulo.Values.Text = "Cadastro de Produtos";
            // 
            // txtFornecedor
            // 
            txtFornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFornecedor.CharacterCasing = CharacterCasing.Upper;
            txtFornecedor.Location = new Point(14, 161);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(971, 24);
            txtFornecedor.StateCommon.Back.Color1 = Color.White;
            txtFornecedor.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtFornecedor.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtFornecedor.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtFornecedor.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtFornecedor.StateCommon.Border.Rounding = 8F;
            txtFornecedor.StateCommon.Border.Width = 1;
            txtFornecedor.StateCommon.Content.Color1 = Color.Gray;
            txtFornecedor.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtFornecedor.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtFornecedor.TabIndex = 2;
            txtFornecedor.TextChanged += txtFornecedor_TextChanged;
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.BackColor = Color.Transparent;
            lblFornecedor.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblFornecedor.ForeColor = Color.FromArgb(0, 76, 172);
            lblFornecedor.Location = new Point(14, 142);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(77, 16);
            lblFornecedor.TabIndex = 1133;
            lblFornecedor.Text = "Fornecedor";
            // 
            // lblTipoEntrada
            // 
            lblTipoEntrada.AutoSize = true;
            lblTipoEntrada.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblTipoEntrada.ForeColor = Color.FromArgb(0, 76, 172);
            lblTipoEntrada.Location = new Point(272, 89);
            lblTipoEntrada.Name = "lblTipoEntrada";
            lblTipoEntrada.Size = new Size(104, 16);
            lblTipoEntrada.TabIndex = 1136;
            lblTipoEntrada.Text = "Tipo de Entrada";
            // 
            // cmbTipoEntrada
            // 
            cmbTipoEntrada.CornerRoundingRadius = 6F;
            cmbTipoEntrada.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoEntrada.DropDownWidth = 115;
            cmbTipoEntrada.IntegralHeight = false;
            cmbTipoEntrada.Items.AddRange(new object[] { "Entrada", "Transferência", "Devolução" });
            cmbTipoEntrada.Location = new Point(272, 111);
            cmbTipoEntrada.Name = "cmbTipoEntrada";
            cmbTipoEntrada.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbTipoEntrada.Size = new Size(140, 25);
            cmbTipoEntrada.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoEntrada.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbTipoEntrada.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbTipoEntrada.TabIndex = 40;
            cmbTipoEntrada.TabStop = false;
            // 
            // txtProduto
            // 
            txtProduto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProduto.CharacterCasing = CharacterCasing.Upper;
            txtProduto.Location = new Point(17, 223);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(616, 24);
            txtProduto.StateCommon.Back.Color1 = Color.White;
            txtProduto.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtProduto.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtProduto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtProduto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtProduto.StateCommon.Border.Rounding = 8F;
            txtProduto.StateCommon.Border.Width = 1;
            txtProduto.StateCommon.Content.Color1 = Color.Gray;
            txtProduto.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtProduto.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtProduto.TabIndex = 3;
            txtProduto.TextChanged += txtProduto_TextChanged;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.BackColor = Color.Transparent;
            lblProduto.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblProduto.ForeColor = Color.FromArgb(0, 76, 172);
            lblProduto.Location = new Point(17, 204);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(54, 16);
            lblProduto.TabIndex = 1144;
            lblProduto.Text = "Produto";
            // 
            // txtPrecoCompra
            // 
            txtPrecoCompra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPrecoCompra.Location = new Point(741, 223);
            txtPrecoCompra.Name = "txtPrecoCompra";
            txtPrecoCompra.Size = new Size(119, 24);
            txtPrecoCompra.StateCommon.Back.Color1 = Color.White;
            txtPrecoCompra.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtPrecoCompra.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtPrecoCompra.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPrecoCompra.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPrecoCompra.StateCommon.Border.Rounding = 8F;
            txtPrecoCompra.StateCommon.Border.Width = 1;
            txtPrecoCompra.StateCommon.Content.Color1 = Color.Gray;
            txtPrecoCompra.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtPrecoCompra.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtPrecoCompra.TabIndex = 5;
            txtPrecoCompra.TextAlign = HorizontalAlignment.Center;
            txtPrecoCompra.Enter += txtPrecoCompra_Enter;
            txtPrecoCompra.Leave += txtPrecoCompra_Leave;
            // 
            // lblPrecoCompra
            // 
            lblPrecoCompra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPrecoCompra.AutoSize = true;
            lblPrecoCompra.BackColor = Color.Transparent;
            lblPrecoCompra.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblPrecoCompra.ForeColor = Color.FromArgb(0, 76, 172);
            lblPrecoCompra.Location = new Point(741, 204);
            lblPrecoCompra.Name = "lblPrecoCompra";
            lblPrecoCompra.Size = new Size(113, 16);
            lblPrecoCompra.TabIndex = 1147;
            lblPrecoCompra.Text = "Preço de Compra";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtQuantidade.Location = new Point(637, 223);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(98, 24);
            txtQuantidade.StateCommon.Back.Color1 = Color.White;
            txtQuantidade.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtQuantidade.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtQuantidade.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtQuantidade.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtQuantidade.StateCommon.Border.Rounding = 8F;
            txtQuantidade.StateCommon.Border.Width = 1;
            txtQuantidade.StateCommon.Content.Color1 = Color.Gray;
            txtQuantidade.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtQuantidade.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtQuantidade.TabIndex = 4;
            txtQuantidade.TextAlign = HorizontalAlignment.Center;
            // 
            // lblQuantidade
            // 
            lblQuantidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblQuantidade.AutoSize = true;
            lblQuantidade.BackColor = Color.Transparent;
            lblQuantidade.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblQuantidade.ForeColor = Color.FromArgb(0, 76, 172);
            lblQuantidade.Location = new Point(648, 204);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(77, 16);
            lblQuantidade.TabIndex = 1149;
            lblQuantidade.Text = "Quantidade";
            // 
            // txtPrecoCusto
            // 
            txtPrecoCusto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPrecoCusto.Location = new Point(866, 223);
            txtPrecoCusto.Name = "txtPrecoCusto";
            txtPrecoCusto.Size = new Size(119, 24);
            txtPrecoCusto.StateCommon.Back.Color1 = Color.White;
            txtPrecoCusto.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtPrecoCusto.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtPrecoCusto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPrecoCusto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPrecoCusto.StateCommon.Border.Rounding = 8F;
            txtPrecoCusto.StateCommon.Border.Width = 1;
            txtPrecoCusto.StateCommon.Content.Color1 = Color.Gray;
            txtPrecoCusto.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtPrecoCusto.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtPrecoCusto.TabIndex = 6;
            txtPrecoCusto.TextAlign = HorizontalAlignment.Center;
            txtPrecoCusto.Enter += txtPrecoCusto_Enter;
            txtPrecoCusto.Leave += txtPrecoCusto_Leave;
            // 
            // lblPrecoCusto
            // 
            lblPrecoCusto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPrecoCusto.AutoSize = true;
            lblPrecoCusto.BackColor = Color.Transparent;
            lblPrecoCusto.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblPrecoCusto.ForeColor = Color.FromArgb(0, 76, 172);
            lblPrecoCusto.Location = new Point(873, 204);
            lblPrecoCusto.Name = "lblPrecoCusto";
            lblPrecoCusto.Size = new Size(99, 16);
            lblPrecoCusto.TabIndex = 1151;
            lblPrecoCusto.Text = "Preço de Custo";
            // 
            // FrmEntradaFiscal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(1008, 615);
            Controls.Add(txtPrecoCusto);
            Controls.Add(lblPrecoCusto);
            Controls.Add(txtQuantidade);
            Controls.Add(lblQuantidade);
            Controls.Add(btnAdicionarItem);
            Controls.Add(txtPrecoCompra);
            Controls.Add(lblPrecoCompra);
            Controls.Add(btnRemoverItem);
            Controls.Add(txtProduto);
            Controls.Add(lblProduto);
            Controls.Add(lblTipoEntrada);
            Controls.Add(cmbTipoEntrada);
            Controls.Add(txtFornecedor);
            Controls.Add(lblFornecedor);
            Controls.Add(pnlHeader);
            Controls.Add(lblRotuloDadosCadastrais);
            Controls.Add(btnVerControlesDoForm);
            Controls.Add(grpTotais);
            Controls.Add(grpItens);
            Controls.Add(lblDataEmissao);
            Controls.Add(dtpDataEmissao);
            Controls.Add(lblNumDocumento);
            Controls.Add(txtSerie);
            Controls.Add(txtNumeroDocumento);
            Controls.Add(lblSerie);
            Controls.Add(lblTipoDocumento);
            Controls.Add(cmbTipoDocumento);
            KeyPreview = true;
            Name = "FrmEntradaFiscal";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrada de Estoque - Nota Fiscal";
            WindowState = FormWindowState.Maximized;
            Load += FrmEntradaFiscal_Load;
            Shown += FrmEntradaFiscal_Shown;
            KeyDown += FrmEntradaFiscal_KeyDown;
            ((System.ComponentModel.ISupportInitialize)cmbTipoDocumento).EndInit();
            grpItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItensDocumento).EndInit();
            grpTotais.ResumeLayout(false);
            grpTotais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).EndInit();
            pnlHeader.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbTipoEntrada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private GroupBox grpItens;
        private Label lblDataEmissao;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDataEmissao;
        public Krypton.Toolkit.KryptonTextBox txtSerie;
        private Label lblSerie;
        public Krypton.Toolkit.KryptonComboBox cmbTipoDocumento;
        private Label lblTipoDocumento;
        public Krypton.Toolkit.KryptonTextBox txtNumeroDocumento;
        private Label lblNumDocumento;
        private Krypton.Toolkit.KryptonDataGridView dgvItensDocumento;
        private GroupBox grpTotais;
        private FontAwesome.Sharp.IconButton btnVerControlesDoForm;
        private FontAwesome.Sharp.IconButton btnAdicionarItem;
        private FontAwesome.Sharp.IconButton btnConfirmar;
        private FontAwesome.Sharp.IconButton btnSair;
        private FontAwesome.Sharp.IconButton btnRemoverItem;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private Krypton.Toolkit.KryptonLabel lblRotuloDadosCadastrais;
        private Krypton.Toolkit.KryptonPanel pnlHeader;
        private Krypton.Toolkit.KryptonTableLayoutPanel tlpTitulo;
        private Krypton.Toolkit.KryptonLabel lblSubTitulo;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        public Krypton.Toolkit.KryptonTextBox txtFornecedor;
        private Label lblFornecedor;
        private Label lblTipoEntrada;
        public Krypton.Toolkit.KryptonComboBox cmbTipoEntrada;
        public Krypton.Toolkit.KryptonTextBox txtProduto;
        private Label lblProduto;
        public Krypton.Toolkit.KryptonTextBox txtPrecoCompra;
        private Label lblPrecoCompra;
        public Krypton.Toolkit.KryptonTextBox txtQuantidade;
        private Label lblQuantidade;
        public Krypton.Toolkit.KryptonTextBox txtPrecoCusto;
        private Label lblPrecoCusto;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel lblTotal;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel lblTotalItens;
    }
}