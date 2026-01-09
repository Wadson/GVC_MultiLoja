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
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            txtNomeProduto = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloDescricaoProduto = new Label();
            btnBuscarProduto = new Krypton.Toolkit.KryptonButton();
            lblRotuloProdutoID = new Label();
            txtProdutoID = new Krypton.Toolkit.KryptonTextBox();
            grpMovimentacao = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            dtFim = new Krypton.Toolkit.KryptonDateTimePicker();
            dtInicio = new Krypton.Toolkit.KryptonDateTimePicker();
            cmbOrigem = new Krypton.Toolkit.KryptonComboBox();
            label1 = new Label();
            cmbTipoMovimentacao = new Krypton.Toolkit.KryptonComboBox();
            lblRotuloTipoMovimentacao = new Label();
            btnListarControlesDoForm = new Krypton.Toolkit.KryptonButton();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            btnCancelar = new Krypton.Toolkit.KryptonButton();
            btnPesquisar = new Krypton.Toolkit.KryptonButton();
            dgvMovimentacoes = new Krypton.Toolkit.KryptonDataGridView();
            grpMovimentacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbOrigem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbTipoMovimentacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimentacoes).BeginInit();
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
            txtNomeProduto.Location = new Point(86, 29);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.ReadOnly = true;
            txtNomeProduto.Size = new Size(666, 24);
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
            lblRotuloDescricaoProduto.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloDescricaoProduto.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloDescricaoProduto.Location = new Point(86, 10);
            lblRotuloDescricaoProduto.Name = "lblRotuloDescricaoProduto";
            lblRotuloDescricaoProduto.Size = new Size(137, 16);
            lblRotuloDescricaoProduto.TabIndex = 1080;
            lblRotuloDescricaoProduto.Text = "Descrição do produto";
            // 
            // btnBuscarProduto
            // 
            btnBuscarProduto.CornerRoundingRadius = 10F;
            btnBuscarProduto.Location = new Point(758, 25);
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
            lblRotuloProdutoID.Location = new Point(6, 10);
            lblRotuloProdutoID.Name = "lblRotuloProdutoID";
            lblRotuloProdutoID.Size = new Size(57, 16);
            lblRotuloProdutoID.TabIndex = 1081;
            lblRotuloProdutoID.Text = "Código";
            // 
            // txtProdutoID
            // 
            txtProdutoID.Location = new Point(6, 29);
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
            // grpMovimentacao
            // 
            grpMovimentacao.Controls.Add(label3);
            grpMovimentacao.Controls.Add(label2);
            grpMovimentacao.Controls.Add(dtFim);
            grpMovimentacao.Controls.Add(dtInicio);
            grpMovimentacao.Controls.Add(cmbOrigem);
            grpMovimentacao.Controls.Add(label1);
            grpMovimentacao.Controls.Add(cmbTipoMovimentacao);
            grpMovimentacao.Controls.Add(lblRotuloTipoMovimentacao);
            grpMovimentacao.Location = new Point(6, 62);
            grpMovimentacao.Name = "grpMovimentacao";
            grpMovimentacao.Size = new Size(794, 81);
            grpMovimentacao.TabIndex = 1088;
            grpMovimentacao.TabStop = false;
            grpMovimentacao.Text = "Movimentações";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.25F);
            label3.ForeColor = Color.FromArgb(0, 76, 172);
            label3.Location = new Point(627, 24);
            label3.Name = "label3";
            label3.Size = new Size(61, 16);
            label3.TabIndex = 1072;
            label3.Text = "Data Fim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.25F);
            label2.ForeColor = Color.FromArgb(0, 76, 172);
            label2.Location = new Point(442, 21);
            label2.Name = "label2";
            label2.Size = new Size(70, 16);
            label2.TabIndex = 1071;
            label2.Text = "Data Inicio";
            // 
            // dtFim
            // 
            dtFim.CornerRoundingRadius = 6F;
            dtFim.Format = DateTimePickerFormat.Short;
            dtFim.Location = new Point(622, 43);
            dtFim.Name = "dtFim";
            dtFim.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            dtFim.Size = new Size(160, 25);
            dtFim.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtFim.StateCommon.Border.Rounding = 6F;
            dtFim.TabIndex = 1070;
            // 
            // dtInicio
            // 
            dtInicio.CornerRoundingRadius = 6F;
            dtInicio.Format = DateTimePickerFormat.Short;
            dtInicio.Location = new Point(442, 43);
            dtInicio.Name = "dtInicio";
            dtInicio.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            dtInicio.Size = new Size(160, 25);
            dtInicio.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtInicio.StateCommon.Border.Rounding = 6F;
            dtInicio.TabIndex = 1069;
            // 
            // cmbOrigem
            // 
            cmbOrigem.CornerRoundingRadius = 6F;
            cmbOrigem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigem.DropDownWidth = 115;
            cmbOrigem.IntegralHeight = false;
            cmbOrigem.Items.AddRange(new object[] { "Ajuste Manual", "Inventário", "Perda", "Devolução" });
            cmbOrigem.Location = new Point(224, 43);
            cmbOrigem.Name = "cmbOrigem";
            cmbOrigem.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbOrigem.Size = new Size(200, 25);
            cmbOrigem.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbOrigem.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbOrigem.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbOrigem.TabIndex = 1068;
            cmbOrigem.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.25F);
            label1.ForeColor = Color.FromArgb(0, 76, 172);
            label1.Location = new Point(227, 21);
            label1.Name = "label1";
            label1.Size = new Size(51, 16);
            label1.TabIndex = 1067;
            label1.Text = "Origem";
            // 
            // cmbTipoMovimentacao
            // 
            cmbTipoMovimentacao.CornerRoundingRadius = 6F;
            cmbTipoMovimentacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMovimentacao.DropDownWidth = 115;
            cmbTipoMovimentacao.IntegralHeight = false;
            cmbTipoMovimentacao.Items.AddRange(new object[] { "Entrada", "Saída", "Ajuste" });
            cmbTipoMovimentacao.Location = new Point(6, 43);
            cmbTipoMovimentacao.Name = "cmbTipoMovimentacao";
            cmbTipoMovimentacao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbTipoMovimentacao.Size = new Size(200, 25);
            cmbTipoMovimentacao.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoMovimentacao.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbTipoMovimentacao.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbTipoMovimentacao.TabIndex = 1066;
            cmbTipoMovimentacao.TabStop = false;
            // 
            // lblRotuloTipoMovimentacao
            // 
            lblRotuloTipoMovimentacao.AutoSize = true;
            lblRotuloTipoMovimentacao.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloTipoMovimentacao.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloTipoMovimentacao.Location = new Point(9, 21);
            lblRotuloTipoMovimentacao.Name = "lblRotuloTipoMovimentacao";
            lblRotuloTipoMovimentacao.Size = new Size(127, 16);
            lblRotuloTipoMovimentacao.TabIndex = 1065;
            lblRotuloTipoMovimentacao.Text = "Tipo movimentação";
            // 
            // btnListarControlesDoForm
            // 
            btnListarControlesDoForm.CornerRoundingRadius = 6F;
            btnListarControlesDoForm.Location = new Point(12, 3);
            btnListarControlesDoForm.Margin = new Padding(4, 3, 4, 3);
            btnListarControlesDoForm.Name = "btnListarControlesDoForm";
            btnListarControlesDoForm.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnListarControlesDoForm.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnListarControlesDoForm.OverrideDefault.Back.ColorAngle = 45F;
            btnListarControlesDoForm.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnListarControlesDoForm.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnListarControlesDoForm.OverrideDefault.Border.ColorAngle = 45F;
            btnListarControlesDoForm.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnListarControlesDoForm.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnListarControlesDoForm.OverrideDefault.Border.Rounding = 20F;
            btnListarControlesDoForm.OverrideDefault.Border.Width = 1;
            btnListarControlesDoForm.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnListarControlesDoForm.Size = new Size(120, 30);
            btnListarControlesDoForm.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnListarControlesDoForm.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnListarControlesDoForm.StateCommon.Back.ColorAngle = 45F;
            btnListarControlesDoForm.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnListarControlesDoForm.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnListarControlesDoForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnListarControlesDoForm.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnListarControlesDoForm.StateCommon.Border.Rounding = 6F;
            btnListarControlesDoForm.StateCommon.Border.Width = 1;
            btnListarControlesDoForm.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnListarControlesDoForm.StateCommon.Content.ShortText.Color2 = Color.White;
            btnListarControlesDoForm.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListarControlesDoForm.StatePressed.Back.Color1 = Color.Red;
            btnListarControlesDoForm.StatePressed.Back.Color2 = Color.Red;
            btnListarControlesDoForm.StatePressed.Back.ColorAngle = 135F;
            btnListarControlesDoForm.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnListarControlesDoForm.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnListarControlesDoForm.StatePressed.Border.ColorAngle = 135F;
            btnListarControlesDoForm.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnListarControlesDoForm.StatePressed.Border.Rounding = 20F;
            btnListarControlesDoForm.StatePressed.Border.Width = 1;
            btnListarControlesDoForm.StateTracking.Back.Color1 = Color.Red;
            btnListarControlesDoForm.StateTracking.Back.Color2 = Color.Red;
            btnListarControlesDoForm.StateTracking.Back.ColorAngle = 45F;
            btnListarControlesDoForm.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnListarControlesDoForm.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnListarControlesDoForm.StateTracking.Border.ColorAngle = 45F;
            btnListarControlesDoForm.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnListarControlesDoForm.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnListarControlesDoForm.StateTracking.Border.Rounding = 20F;
            btnListarControlesDoForm.StateTracking.Border.Width = 1;
            btnListarControlesDoForm.StateTracking.Content.ShortText.Color1 = Color.White;
            btnListarControlesDoForm.TabIndex = 1092;
            btnListarControlesDoForm.TabStop = false;
            btnListarControlesDoForm.Values.Text = "Listar Controles";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(btnCancelar);
            kryptonPanel1.Controls.Add(btnPesquisar);
            kryptonPanel1.Controls.Add(btnListarControlesDoForm);
            kryptonPanel1.Dock = DockStyle.Bottom;
            kryptonPanel1.Location = new Point(0, 409);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(800, 41);
            kryptonPanel1.TabIndex = 1093;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.CornerRoundingRadius = 20F;
            btnCancelar.Location = new Point(697, 8);
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
            btnPesquisar.Location = new Point(591, 8);
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
            dgvMovimentacoes.Location = new Point(6, 149);
            dgvMovimentacoes.Name = "dgvMovimentacoes";
            dgvMovimentacoes.Size = new Size(794, 254);
            dgvMovimentacoes.TabIndex = 1094;
            // 
            // FrmConsultaMovimentacaoEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMovimentacoes);
            Controls.Add(kryptonPanel1);
            Controls.Add(grpMovimentacao);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblRotuloDescricaoProduto);
            Controls.Add(btnBuscarProduto);
            Controls.Add(lblRotuloProdutoID);
            Controls.Add(txtProdutoID);
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
            grpMovimentacao.ResumeLayout(false);
            grpMovimentacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbOrigem).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbTipoMovimentacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMovimentacoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public Krypton.Toolkit.KryptonTextBox txtNomeProduto;
        private Label lblRotuloDescricaoProduto;
        public Krypton.Toolkit.KryptonButton btnBuscarProduto;
        private Label lblRotuloProdutoID;
        public Krypton.Toolkit.KryptonTextBox txtProdutoID;
        private GroupBox grpMovimentacao;
        public Krypton.Toolkit.KryptonComboBox cmbTipoMovimentacao;
        private Label lblRotuloTipoMovimentacao;
        private Krypton.Toolkit.KryptonButton btnListarControlesDoForm;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Label label3;
        private Label label2;
        private Krypton.Toolkit.KryptonDateTimePicker dtFim;
        private Krypton.Toolkit.KryptonDateTimePicker dtInicio;
        public Krypton.Toolkit.KryptonComboBox cmbOrigem;
        private Label label1;
        private Krypton.Toolkit.KryptonDataGridView dgvMovimentacoes;
        public Krypton.Toolkit.KryptonButton btnCancelar;
        public Krypton.Toolkit.KryptonButton btnPesquisar;
    }
}