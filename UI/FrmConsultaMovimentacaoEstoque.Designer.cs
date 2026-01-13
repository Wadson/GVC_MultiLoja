namespace GVC.View
{
    partial class FrmConsultaMovimentacaoEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaMovimentacaoEstoque));
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            txtNomeProduto = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloDescricaoProduto = new Label();
            btnBuscarProduto = new Krypton.Toolkit.KryptonButton();
            lblRotuloProdutoID = new Label();
            txtProdutoID = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloDataFim = new Label();
            lblRotuloDataInicio = new Label();
            lblRotuloOrigem = new Label();
            lblRotuloTipoMovimentacao = new Label();
            btnCancelar = new Krypton.Toolkit.KryptonButton();
            btnPesquisar = new Krypton.Toolkit.KryptonButton();
            dgvMovimentacoes = new Krypton.Toolkit.KryptonDataGridView();
            pnlHeader = new Krypton.Toolkit.KryptonPanel();
            tlpTitulo = new Krypton.Toolkit.KryptonTableLayoutPanel();
            lblSubTitulo = new Krypton.Toolkit.KryptonLabel();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            panelDadosDoProduto = new Krypton.Toolkit.KryptonPanel();
            lblDadosProduto = new Krypton.Toolkit.KryptonLabel();
            cmbTipoMovimentacao = new Krypton.Toolkit.KryptonComboBox();
            panelMovimentacao = new Krypton.Toolkit.KryptonPanel();
            cmbOrigem = new Krypton.Toolkit.KryptonComboBox();
            dtFim = new Krypton.Toolkit.KryptonDateTimePicker();
            dtInicio = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)dgvMovimentacoes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).BeginInit();
            pnlHeader.SuspendLayout();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelDadosDoProduto).BeginInit();
            panelDadosDoProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbTipoMovimentacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelMovimentacao).BeginInit();
            panelMovimentacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbOrigem).BeginInit();
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
            // txtNomeProduto
            // 
            txtNomeProduto.CharacterCasing = CharacterCasing.Upper;
            txtNomeProduto.Location = new Point(83, 46);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.ReadOnly = true;
            txtNomeProduto.Size = new Size(749, 24);
            txtNomeProduto.StateCommon.Back.Color1 = Color.White;
            txtNomeProduto.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNomeProduto.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNomeProduto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNomeProduto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNomeProduto.StateCommon.Border.Rounding = 8F;
            txtNomeProduto.StateCommon.Border.Width = 1;
            txtNomeProduto.StateCommon.Content.Color1 = Color.Gray;
            txtNomeProduto.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtNomeProduto.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNomeProduto.TabIndex = 1079;
            // 
            // lblRotuloDescricaoProduto
            // 
            lblRotuloDescricaoProduto.AutoSize = true;
            lblRotuloDescricaoProduto.BackColor = Color.Transparent;
            lblRotuloDescricaoProduto.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloDescricaoProduto.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloDescricaoProduto.Location = new Point(83, 27);
            lblRotuloDescricaoProduto.Name = "lblRotuloDescricaoProduto";
            lblRotuloDescricaoProduto.Size = new Size(137, 16);
            lblRotuloDescricaoProduto.TabIndex = 1080;
            lblRotuloDescricaoProduto.Text = "Descrição do produto";
            // 
            // btnBuscarProduto
            // 
            btnBuscarProduto.CornerRoundingRadius = 10F;
            btnBuscarProduto.Location = new Point(838, 41);
            btnBuscarProduto.Name = "btnBuscarProduto";
            btnBuscarProduto.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnBuscarProduto.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnBuscarProduto.OverrideDefault.Back.ColorAngle = 45F;
            btnBuscarProduto.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnBuscarProduto.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBuscarProduto.OverrideDefault.Border.ColorAngle = 45F;
            btnBuscarProduto.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscarProduto.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBuscarProduto.OverrideDefault.Border.Rounding = 20F;
            btnBuscarProduto.OverrideDefault.Border.Width = 1;
            btnBuscarProduto.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnBuscarProduto.Size = new Size(30, 29);
            btnBuscarProduto.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnBuscarProduto.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnBuscarProduto.StateCommon.Back.ColorAngle = 45F;
            btnBuscarProduto.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnBuscarProduto.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBuscarProduto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscarProduto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBuscarProduto.StateCommon.Border.Rounding = 10F;
            btnBuscarProduto.StateCommon.Border.Width = 1;
            btnBuscarProduto.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnBuscarProduto.StateCommon.Content.ShortText.Color2 = Color.White;
            btnBuscarProduto.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarProduto.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnBuscarProduto.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnBuscarProduto.StatePressed.Back.ColorAngle = 135F;
            btnBuscarProduto.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnBuscarProduto.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnBuscarProduto.StatePressed.Border.ColorAngle = 135F;
            btnBuscarProduto.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscarProduto.StatePressed.Border.Rounding = 20F;
            btnBuscarProduto.StatePressed.Border.Width = 1;
            btnBuscarProduto.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnBuscarProduto.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnBuscarProduto.StateTracking.Back.ColorAngle = 45F;
            btnBuscarProduto.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnBuscarProduto.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBuscarProduto.StateTracking.Border.ColorAngle = 45F;
            btnBuscarProduto.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscarProduto.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBuscarProduto.StateTracking.Border.Rounding = 20F;
            btnBuscarProduto.StateTracking.Border.Width = 1;
            btnBuscarProduto.StateTracking.Content.ShortText.Color1 = Color.White;
            btnBuscarProduto.TabIndex = 1083;
            btnBuscarProduto.TabStop = false;
            btnBuscarProduto.Values.Image = Properties.Resources.Pesquisar;
            btnBuscarProduto.Values.Text = "";
            btnBuscarProduto.Click += btnBuscarProduto_Click;
            // 
            // lblRotuloProdutoID
            // 
            lblRotuloProdutoID.AutoSize = true;
            lblRotuloProdutoID.BackColor = Color.Transparent;
            lblRotuloProdutoID.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRotuloProdutoID.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloProdutoID.Location = new Point(3, 27);
            lblRotuloProdutoID.Name = "lblRotuloProdutoID";
            lblRotuloProdutoID.Size = new Size(57, 16);
            lblRotuloProdutoID.TabIndex = 1081;
            lblRotuloProdutoID.Text = "Código";
            // 
            // txtProdutoID
            // 
            txtProdutoID.Location = new Point(3, 46);
            txtProdutoID.Name = "txtProdutoID";
            txtProdutoID.ReadOnly = true;
            txtProdutoID.Size = new Size(73, 24);
            txtProdutoID.StateCommon.Back.Color1 = Color.White;
            txtProdutoID.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtProdutoID.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtProdutoID.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtProdutoID.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtProdutoID.StateCommon.Border.Rounding = 8F;
            txtProdutoID.StateCommon.Border.Width = 1;
            txtProdutoID.StateCommon.Content.Color1 = Color.Gray;
            txtProdutoID.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtProdutoID.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtProdutoID.TabIndex = 1082;
            txtProdutoID.TabStop = false;
            txtProdutoID.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRotuloDataFim
            // 
            lblRotuloDataFim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRotuloDataFim.AutoSize = true;
            lblRotuloDataFim.BackColor = Color.Transparent;
            lblRotuloDataFim.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloDataFim.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloDataFim.Location = new Point(710, 21);
            lblRotuloDataFim.Name = "lblRotuloDataFim";
            lblRotuloDataFim.Size = new Size(61, 16);
            lblRotuloDataFim.TabIndex = 1072;
            lblRotuloDataFim.Text = "Data Fim";
            // 
            // lblRotuloDataInicio
            // 
            lblRotuloDataInicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRotuloDataInicio.AutoSize = true;
            lblRotuloDataInicio.BackColor = Color.Transparent;
            lblRotuloDataInicio.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloDataInicio.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloDataInicio.Location = new Point(541, 21);
            lblRotuloDataInicio.Name = "lblRotuloDataInicio";
            lblRotuloDataInicio.Size = new Size(70, 16);
            lblRotuloDataInicio.TabIndex = 1071;
            lblRotuloDataInicio.Text = "Data Inicio";
            // 
            // lblRotuloOrigem
            // 
            lblRotuloOrigem.AutoSize = true;
            lblRotuloOrigem.BackColor = Color.Transparent;
            lblRotuloOrigem.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloOrigem.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloOrigem.Location = new Point(273, 21);
            lblRotuloOrigem.Name = "lblRotuloOrigem";
            lblRotuloOrigem.Size = new Size(51, 16);
            lblRotuloOrigem.TabIndex = 1067;
            lblRotuloOrigem.Text = "Origem";
            // 
            // lblRotuloTipoMovimentacao
            // 
            lblRotuloTipoMovimentacao.AutoSize = true;
            lblRotuloTipoMovimentacao.BackColor = Color.Transparent;
            lblRotuloTipoMovimentacao.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloTipoMovimentacao.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloTipoMovimentacao.Location = new Point(3, 21);
            lblRotuloTipoMovimentacao.Name = "lblRotuloTipoMovimentacao";
            lblRotuloTipoMovimentacao.Size = new Size(127, 16);
            lblRotuloTipoMovimentacao.TabIndex = 1065;
            lblRotuloTipoMovimentacao.Text = "Tipo movimentação";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.CornerRoundingRadius = 20F;
            btnCancelar.Location = new Point(767, 515);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.OverrideDefault.Back.Color1 = Color.Red;
            btnCancelar.OverrideDefault.Back.Color2 = Color.Red;
            btnCancelar.OverrideDefault.Back.ColorAngle = 45F;
            btnCancelar.OverrideDefault.Border.Color1 = Color.Red;
            btnCancelar.OverrideDefault.Border.Color2 = Color.Red;
            btnCancelar.OverrideDefault.Border.ColorAngle = 45F;
            btnCancelar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.OverrideDefault.Border.Rounding = 20F;
            btnCancelar.OverrideDefault.Border.Width = 1;
            btnCancelar.OverrideDefault.Content.ShortText.Color1 = Color.White;
            btnCancelar.OverrideDefault.Content.ShortText.Color2 = Color.White;
            btnCancelar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.StateCommon.Back.Color1 = Color.Red;
            btnCancelar.StateCommon.Back.Color2 = Color.Red;
            btnCancelar.StateCommon.Back.ColorAngle = 45F;
            btnCancelar.StateCommon.Border.Color1 = Color.Red;
            btnCancelar.StateCommon.Border.Color2 = Color.Red;
            btnCancelar.StateCommon.Border.ColorAngle = 45F;
            btnCancelar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.StateCommon.Border.Rounding = 20F;
            btnCancelar.StateCommon.Border.Width = 1;
            btnCancelar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnCancelar.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            btnCancelar.StateNormal.Back.Color1 = Color.Red;
            btnCancelar.StateNormal.Back.Color2 = Color.Red;
            btnCancelar.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.StateNormal.Border.Color1 = Color.Red;
            btnCancelar.StateNormal.Border.Color2 = Color.Red;
            btnCancelar.StateNormal.Border.ColorAngle = 45F;
            btnCancelar.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.StateNormal.Border.Rounding = 20F;
            btnCancelar.StateNormal.Border.Width = 1;
            btnCancelar.StateNormal.Content.ShortText.Color1 = Color.White;
            btnCancelar.StateNormal.Content.ShortText.Color2 = Color.White;
            btnCancelar.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnCancelar.StatePressed.Back.ColorAngle = 135F;
            btnCancelar.StatePressed.Border.Color1 = Color.Red;
            btnCancelar.StatePressed.Border.Color2 = Color.Red;
            btnCancelar.StatePressed.Border.ColorAngle = 135F;
            btnCancelar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StatePressed.Border.Rounding = 20F;
            btnCancelar.StatePressed.Border.Width = 1;
            btnCancelar.StatePressed.Content.ShortText.Color1 = Color.White;
            btnCancelar.StateTracking.Back.Color1 = Color.Salmon;
            btnCancelar.StateTracking.Back.ColorAngle = 45F;
            btnCancelar.StateTracking.Border.Color1 = Color.Red;
            btnCancelar.StateTracking.Border.Color2 = Color.Red;
            btnCancelar.StateTracking.Border.ColorAngle = 45F;
            btnCancelar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.StateTracking.Border.Rounding = 20F;
            btnCancelar.StateTracking.Border.Width = 1;
            btnCancelar.StateTracking.Content.ShortText.Color1 = Color.White;
            btnCancelar.TabIndex = 1094;
            btnCancelar.Values.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPesquisar.CornerRoundingRadius = 20F;
            btnPesquisar.Location = new Point(661, 515);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnPesquisar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnPesquisar.OverrideDefault.Back.ColorAngle = 45F;
            btnPesquisar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnPesquisar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnPesquisar.OverrideDefault.Border.ColorAngle = 45F;
            btnPesquisar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnPesquisar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnPesquisar.OverrideDefault.Border.Rounding = 20F;
            btnPesquisar.OverrideDefault.Border.Width = 1;
            btnPesquisar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnPesquisar.Size = new Size(100, 30);
            btnPesquisar.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnPesquisar.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnPesquisar.StateCommon.Back.ColorAngle = 45F;
            btnPesquisar.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnPesquisar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnPesquisar.StateCommon.Border.ColorAngle = 45F;
            btnPesquisar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnPesquisar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnPesquisar.StateCommon.Border.Rounding = 20F;
            btnPesquisar.StateCommon.Border.Width = 1;
            btnPesquisar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnPesquisar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnPesquisar.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            btnPesquisar.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnPesquisar.StateNormal.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnPesquisar.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnPesquisar.StateNormal.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnPesquisar.StateNormal.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnPesquisar.StateNormal.Border.ColorAngle = 45F;
            btnPesquisar.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnPesquisar.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnPesquisar.StateNormal.Border.Rounding = 20F;
            btnPesquisar.StateNormal.Border.Width = 1;
            btnPesquisar.StatePressed.Back.Color1 = Color.White;
            btnPesquisar.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnPesquisar.StatePressed.Back.ColorAngle = 135F;
            btnPesquisar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnPesquisar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnPesquisar.StatePressed.Border.ColorAngle = 135F;
            btnPesquisar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnPesquisar.StatePressed.Border.Rounding = 20F;
            btnPesquisar.StatePressed.Border.Width = 1;
            btnPesquisar.StatePressed.Content.ShortText.Color1 = Color.FromArgb(22, 121, 206);
            btnPesquisar.StateTracking.Back.Color1 = Color.White;
            btnPesquisar.StateTracking.Back.Color2 = Color.White;
            btnPesquisar.StateTracking.Back.ColorAngle = 45F;
            btnPesquisar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnPesquisar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnPesquisar.StateTracking.Border.ColorAngle = 45F;
            btnPesquisar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnPesquisar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnPesquisar.StateTracking.Border.Rounding = 20F;
            btnPesquisar.StateTracking.Border.Width = 1;
            btnPesquisar.StateTracking.Content.ShortText.Color1 = Color.FromArgb(22, 121, 206);
            btnPesquisar.TabIndex = 1093;
            btnPesquisar.Values.Text = "Pesquisar";
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // dgvMovimentacoes
            // 
            dgvMovimentacoes.Location = new Point(0, 265);
            dgvMovimentacoes.Name = "dgvMovimentacoes";
            dgvMovimentacoes.Size = new Size(877, 219);
            dgvMovimentacoes.TabIndex = 1094;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(tlpTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(880, 47);
            pnlHeader.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            pnlHeader.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            pnlHeader.TabIndex = 1095;
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
            tlpTitulo.Size = new Size(880, 47);
            tlpTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            tlpTitulo.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            tlpTitulo.TabIndex = 0;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.Dock = DockStyle.Fill;
            lblSubTitulo.Location = new Point(3, 25);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(874, 19);
            lblSubTitulo.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Color2 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblSubTitulo.TabIndex = 0;
            lblSubTitulo.Values.Text = "Histórico de movimentações e saldo de estoque";
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Location = new Point(3, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(874, 16);
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Color2 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 1091;
            lblTitulo.Values.Text = "Movimentação de Estoque";
            // 
            // panelDadosDoProduto
            // 
            panelDadosDoProduto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelDadosDoProduto.Controls.Add(lblDadosProduto);
            panelDadosDoProduto.Controls.Add(txtNomeProduto);
            panelDadosDoProduto.Controls.Add(lblRotuloDescricaoProduto);
            panelDadosDoProduto.Controls.Add(btnBuscarProduto);
            panelDadosDoProduto.Controls.Add(lblRotuloProdutoID);
            panelDadosDoProduto.Controls.Add(txtProdutoID);
            panelDadosDoProduto.Location = new Point(0, 68);
            panelDadosDoProduto.Name = "panelDadosDoProduto";
            panelDadosDoProduto.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueLightMode;
            panelDadosDoProduto.Size = new Size(880, 86);
            panelDadosDoProduto.TabIndex = 1096;
            // 
            // lblDadosProduto
            // 
            lblDadosProduto.Dock = DockStyle.Top;
            lblDadosProduto.Location = new Point(0, 0);
            lblDadosProduto.Name = "lblDadosProduto";
            lblDadosProduto.Size = new Size(880, 20);
            lblDadosProduto.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDadosProduto.TabIndex = 1038;
            lblDadosProduto.Values.Text = "Dados do produto";
            // 
            // cmbTipoMovimentacao
            // 
            cmbTipoMovimentacao.CornerRoundingRadius = 6F;
            cmbTipoMovimentacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMovimentacao.DropDownWidth = 115;
            cmbTipoMovimentacao.IntegralHeight = false;
            cmbTipoMovimentacao.Items.AddRange(new object[] { "Entrada", "Saída", "Ajuste" });
            cmbTipoMovimentacao.Location = new Point(3, 42);
            cmbTipoMovimentacao.Name = "cmbTipoMovimentacao";
            cmbTipoMovimentacao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbTipoMovimentacao.Size = new Size(260, 25);
            cmbTipoMovimentacao.StateActive.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateActive.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateActive.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateActive.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoMovimentacao.StateActive.ComboBox.Content.Color1 = Color.White;
            cmbTipoMovimentacao.StateActive.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbTipoMovimentacao.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoMovimentacao.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbTipoMovimentacao.StateCommon.ComboBox.Content.Color1 = Color.White;
            cmbTipoMovimentacao.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbTipoMovimentacao.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbTipoMovimentacao.StateNormal.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateNormal.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateNormal.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateNormal.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoMovimentacao.StateNormal.ComboBox.Content.Color1 = Color.White;
            cmbTipoMovimentacao.StateNormal.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbTipoMovimentacao.StateTracking.Item.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateTracking.Item.Back.Color2 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateTracking.Item.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateTracking.Item.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbTipoMovimentacao.StateTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoMovimentacao.StateTracking.Item.Content.ShortText.Color1 = Color.White;
            cmbTipoMovimentacao.StateTracking.Item.Content.ShortText.Color2 = Color.White;
            cmbTipoMovimentacao.StateTracking.Item.Content.ShortText.Font = new Font("Segoe UI", 9F);
            cmbTipoMovimentacao.TabIndex = 1067;
            cmbTipoMovimentacao.TabStop = false;
            // 
            // panelMovimentacao
            // 
            panelMovimentacao.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelMovimentacao.Controls.Add(cmbOrigem);
            panelMovimentacao.Controls.Add(dtFim);
            panelMovimentacao.Controls.Add(cmbTipoMovimentacao);
            panelMovimentacao.Controls.Add(dtInicio);
            panelMovimentacao.Controls.Add(lblRotuloDataFim);
            panelMovimentacao.Controls.Add(lblRotuloDataInicio);
            panelMovimentacao.Controls.Add(kryptonLabel2);
            panelMovimentacao.Controls.Add(lblRotuloOrigem);
            panelMovimentacao.Controls.Add(lblRotuloTipoMovimentacao);
            panelMovimentacao.Location = new Point(3, 160);
            panelMovimentacao.Name = "panelMovimentacao";
            panelMovimentacao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueLightMode;
            panelMovimentacao.Size = new Size(880, 86);
            panelMovimentacao.TabIndex = 1097;
            // 
            // cmbOrigem
            // 
            cmbOrigem.CornerRoundingRadius = 6F;
            cmbOrigem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigem.DropDownWidth = 115;
            cmbOrigem.IntegralHeight = false;
            cmbOrigem.Items.AddRange(new object[] { "Ajuste Manual", "Inventário", "Perda", "Devolução" });
            cmbOrigem.Location = new Point(273, 42);
            cmbOrigem.Name = "cmbOrigem";
            cmbOrigem.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbOrigem.Size = new Size(260, 25);
            cmbOrigem.StateActive.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateActive.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateActive.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateActive.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbOrigem.StateActive.ComboBox.Content.Color1 = Color.White;
            cmbOrigem.StateActive.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbOrigem.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbOrigem.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbOrigem.StateCommon.ComboBox.Content.Color1 = Color.White;
            cmbOrigem.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbOrigem.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbOrigem.StateNormal.ComboBox.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateNormal.ComboBox.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateNormal.ComboBox.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateNormal.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbOrigem.StateNormal.ComboBox.Content.Color1 = Color.White;
            cmbOrigem.StateNormal.ComboBox.Content.Font = new Font("Segoe UI", 9F);
            cmbOrigem.StateTracking.Item.Back.Color1 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateTracking.Item.Back.Color2 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateTracking.Item.Border.Color1 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateTracking.Item.Border.Color2 = Color.FromArgb(30, 136, 229);
            cmbOrigem.StateTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbOrigem.StateTracking.Item.Content.ShortText.Color1 = Color.White;
            cmbOrigem.StateTracking.Item.Content.ShortText.Color2 = Color.White;
            cmbOrigem.StateTracking.Item.Content.ShortText.Font = new Font("Segoe UI", 9F);
            cmbOrigem.TabIndex = 1075;
            cmbOrigem.TabStop = false;
            // 
            // dtFim
            // 
            dtFim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtFim.CornerRoundingRadius = 3F;
            dtFim.Format = DateTimePickerFormat.Short;
            dtFim.Location = new Point(706, 40);
            dtFim.Name = "dtFim";
            dtFim.Size = new Size(158, 29);
            dtFim.StateActive.Back.Color1 = Color.FromArgb(6, 174, 244);
            dtFim.StateActive.Border.Color1 = Color.FromArgb(6, 174, 244);
            dtFim.StateActive.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtFim.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtFim.StateActive.Border.Rounding = 3F;
            dtFim.StateActive.Content.Color1 = Color.White;
            dtFim.StateActive.Content.Font = new Font("Poppins", 9F);
            dtFim.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtFim.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtFim.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtFim.StateCommon.Border.ColorAngle = 45F;
            dtFim.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtFim.StateCommon.Border.Rounding = 3F;
            dtFim.StateCommon.Border.Width = 1;
            dtFim.StateCommon.Content.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtFim.StateCommon.Content.Padding = new Padding(1);
            dtFim.StateDisabled.Border.ColorAngle = 45F;
            dtFim.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtFim.StateDisabled.Border.Rounding = 3F;
            dtFim.StateDisabled.Border.Width = 1;
            dtFim.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtFim.StateNormal.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtFim.StateNormal.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtFim.StateNormal.Border.ColorAngle = 45F;
            dtFim.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtFim.StateNormal.Border.Rounding = 3F;
            dtFim.StateNormal.Border.Width = 1;
            dtFim.StateNormal.Content.Color1 = Color.White;
            dtFim.TabIndex = 1074;
            // 
            // dtInicio
            // 
            dtInicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtInicio.CornerRoundingRadius = 3F;
            dtInicio.Format = DateTimePickerFormat.Short;
            dtInicio.Location = new Point(541, 40);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(158, 29);
            dtInicio.StateActive.Back.Color1 = Color.FromArgb(6, 174, 244);
            dtInicio.StateActive.Border.Color1 = Color.FromArgb(6, 174, 244);
            dtInicio.StateActive.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtInicio.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtInicio.StateActive.Border.Rounding = 3F;
            dtInicio.StateActive.Content.Color1 = Color.White;
            dtInicio.StateActive.Content.Font = new Font("Poppins", 9F);
            dtInicio.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtInicio.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtInicio.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtInicio.StateCommon.Border.ColorAngle = 45F;
            dtInicio.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtInicio.StateCommon.Border.Rounding = 3F;
            dtInicio.StateCommon.Border.Width = 1;
            dtInicio.StateCommon.Content.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtInicio.StateCommon.Content.Padding = new Padding(1);
            dtInicio.StateDisabled.Border.ColorAngle = 45F;
            dtInicio.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtInicio.StateDisabled.Border.Rounding = 3F;
            dtInicio.StateDisabled.Border.Width = 1;
            dtInicio.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtInicio.StateNormal.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtInicio.StateNormal.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtInicio.StateNormal.Border.ColorAngle = 45F;
            dtInicio.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtInicio.StateNormal.Border.Rounding = 3F;
            dtInicio.StateNormal.Border.Width = 1;
            dtInicio.StateNormal.Content.Color1 = Color.White;
            dtInicio.TabIndex = 1073;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Dock = DockStyle.Top;
            kryptonLabel2.Location = new Point(0, 0);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(880, 20);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 1038;
            kryptonLabel2.Values.Text = "Movimentações";
            // 
            // FrmConsultaMovimentacaoEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(880, 557);
            Controls.Add(btnCancelar);
            Controls.Add(btnPesquisar);
            Controls.Add(panelMovimentacao);
            Controls.Add(panelDadosDoProduto);
            Controls.Add(pnlHeader);
            Controls.Add(dgvMovimentacoes);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConsultaMovimentacaoEstoque";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta Movimentacao deEstoque";
            ((System.ComponentModel.ISupportInitialize)dgvMovimentacoes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).EndInit();
            pnlHeader.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelDadosDoProduto).EndInit();
            panelDadosDoProduto.ResumeLayout(false);
            panelDadosDoProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbTipoMovimentacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelMovimentacao).EndInit();
            panelMovimentacao.ResumeLayout(false);
            panelMovimentacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbOrigem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public Krypton.Toolkit.KryptonTextBox txtNomeProduto;
        private Label lblRotuloDescricaoProduto;
        public Krypton.Toolkit.KryptonButton btnBuscarProduto;
        private Label lblRotuloProdutoID;
        public Krypton.Toolkit.KryptonTextBox txtProdutoID;
        private GroupBox grpMovimentacao;        
        private Label lblRotuloTipoMovimentacao;
        private Krypton.Toolkit.KryptonButton btnListarControlesDoForm;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Label lblRotuloDataFim;
        private Label lblRotuloDataInicio;
        private Label lblRotuloOrigem;
        private Krypton.Toolkit.KryptonDataGridView dgvMovimentacoes;
        public Krypton.Toolkit.KryptonButton btnCancelar;
        public Krypton.Toolkit.KryptonButton btnPesquisar;
        private Krypton.Toolkit.KryptonPanel pnlHeader;
        private Krypton.Toolkit.KryptonTableLayoutPanel tlpTitulo;
        private Krypton.Toolkit.KryptonLabel lblSubTitulo;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private Krypton.Toolkit.KryptonPanel panelDadosDoProduto;
        public Krypton.Toolkit.KryptonComboBox cmbTipoMovimentacao;
        private Krypton.Toolkit.KryptonLabel lblDadosProduto;
        private Krypton.Toolkit.KryptonPanel panelMovimentacao;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        public Krypton.Toolkit.KryptonComboBox cmbOrigem;
        public Krypton.Toolkit.KryptonDateTimePicker dtFim;
        public Krypton.Toolkit.KryptonDateTimePicker dtInicio;
    }
}