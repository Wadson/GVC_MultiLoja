namespace GVC.View
{
    partial class FrmMovimentacaoEstoque
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
            btnListarControlesDoForm = new Krypton.Toolkit.KryptonButton();
            bnCancelar = new Krypton.Toolkit.KryptonButton();
            btnConfirmar = new Krypton.Toolkit.KryptonButton();
            cmbTipoMovimentacao = new Krypton.Toolkit.KryptonComboBox();
            lblRotuloProdutoID = new Label();
            txtProdutoBuscar = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloTipoMovimentacao = new Label();
            lblRotuloDescricaoProduto = new Label();
            lblEstoqueAtual = new Label();
            lblRotuloQuantidade = new Label();
            txtObservacao = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloObservacoes = new Label();
            cmbOrigem = new Krypton.Toolkit.KryptonComboBox();
            grpProduto = new GroupBox();
            lblIdProduto = new Label();
            lblRotuloEstoque = new Label();
            grpMovimentacao = new GroupBox();
            lblRotuloOrigem = new Label();
            numQuantidade = new Krypton.Toolkit.KryptonNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)cmbTipoMovimentacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbOrigem).BeginInit();
            grpProduto.SuspendLayout();
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
            // btnListarControlesDoForm
            // 
            btnListarControlesDoForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnListarControlesDoForm.CornerRoundingRadius = 6F;
            btnListarControlesDoForm.Location = new Point(10, 262);
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
            btnListarControlesDoForm.TabIndex = 1089;
            btnListarControlesDoForm.TabStop = false;
            btnListarControlesDoForm.Values.Text = "Listar Controles";
            btnListarControlesDoForm.Click += btnListarControlesDoForm_Click;
            // 
            // bnCancelar
            // 
            bnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bnCancelar.CornerRoundingRadius = 6F;
            bnCancelar.Location = new Point(775, 263);
            bnCancelar.Name = "bnCancelar";
            bnCancelar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            bnCancelar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            bnCancelar.OverrideDefault.Back.ColorAngle = 45F;
            bnCancelar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            bnCancelar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            bnCancelar.OverrideDefault.Border.ColorAngle = 45F;
            bnCancelar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            bnCancelar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            bnCancelar.OverrideDefault.Border.Rounding = 20F;
            bnCancelar.OverrideDefault.Border.Width = 1;
            bnCancelar.Size = new Size(150, 30);
            bnCancelar.StateCommon.Back.Color1 = Color.Red;
            bnCancelar.StateCommon.Back.Color2 = Color.Red;
            bnCancelar.StateCommon.Back.ColorAngle = 45F;
            bnCancelar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            bnCancelar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            bnCancelar.StateCommon.Border.Rounding = 6F;
            bnCancelar.StateCommon.Border.Width = 1;
            bnCancelar.StateCommon.Content.ShortText.Color1 = Color.White;
            bnCancelar.StateCommon.Content.ShortText.Color2 = Color.White;
            bnCancelar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            bnCancelar.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            bnCancelar.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            bnCancelar.StatePressed.Back.ColorAngle = 135F;
            bnCancelar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            bnCancelar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            bnCancelar.StatePressed.Border.ColorAngle = 135F;
            bnCancelar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            bnCancelar.StatePressed.Border.Rounding = 20F;
            bnCancelar.StatePressed.Border.Width = 1;
            bnCancelar.StatePressed.Content.ShortText.Color1 = Color.Black;
            bnCancelar.StatePressed.Content.ShortText.Color2 = Color.Black;
            bnCancelar.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            bnCancelar.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            bnCancelar.StateTracking.Back.ColorAngle = 45F;
            bnCancelar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            bnCancelar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            bnCancelar.StateTracking.Border.ColorAngle = 45F;
            bnCancelar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            bnCancelar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            bnCancelar.StateTracking.Border.Rounding = 20F;
            bnCancelar.StateTracking.Border.Width = 1;
            bnCancelar.StateTracking.Content.ShortText.Color1 = Color.Black;
            bnCancelar.StateTracking.Content.ShortText.Color2 = Color.Black;
            bnCancelar.TabIndex = 1085;
            bnCancelar.TabStop = false;
            bnCancelar.Values.Text = "Cancelar";
            bnCancelar.Click += bnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmar.CornerRoundingRadius = 6F;
            btnConfirmar.Location = new Point(619, 263);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmar.OverrideDefault.Back.ColorAngle = 45F;
            btnConfirmar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmar.OverrideDefault.Border.ColorAngle = 45F;
            btnConfirmar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmar.OverrideDefault.Border.Rounding = 20F;
            btnConfirmar.OverrideDefault.Border.Width = 1;
            btnConfirmar.Size = new Size(150, 30);
            btnConfirmar.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnConfirmar.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmar.StateCommon.Back.ColorAngle = 45F;
            btnConfirmar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmar.StateCommon.Border.Rounding = 6F;
            btnConfirmar.StateCommon.Border.Width = 1;
            btnConfirmar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnConfirmar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnConfirmar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnConfirmar.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnConfirmar.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnConfirmar.StatePressed.Back.ColorAngle = 135F;
            btnConfirmar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnConfirmar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnConfirmar.StatePressed.Border.ColorAngle = 135F;
            btnConfirmar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmar.StatePressed.Border.Rounding = 20F;
            btnConfirmar.StatePressed.Border.Width = 1;
            btnConfirmar.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnConfirmar.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnConfirmar.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnConfirmar.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnConfirmar.StateTracking.Back.ColorAngle = 45F;
            btnConfirmar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmar.StateTracking.Border.ColorAngle = 45F;
            btnConfirmar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmar.StateTracking.Border.Rounding = 20F;
            btnConfirmar.StateTracking.Border.Width = 1;
            btnConfirmar.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnConfirmar.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnConfirmar.TabIndex = 1044;
            btnConfirmar.TabStop = false;
            btnConfirmar.Values.Text = "Confirmar";
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // cmbTipoMovimentacao
            // 
            cmbTipoMovimentacao.CornerRoundingRadius = 6F;
            cmbTipoMovimentacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMovimentacao.DropDownWidth = 115;
            cmbTipoMovimentacao.IntegralHeight = false;
            cmbTipoMovimentacao.Items.AddRange(new object[] { "Entrada", "Saída", "Ajuste" });
            cmbTipoMovimentacao.Location = new Point(142, 123);
            cmbTipoMovimentacao.Name = "cmbTipoMovimentacao";
            cmbTipoMovimentacao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbTipoMovimentacao.Size = new Size(164, 25);
            cmbTipoMovimentacao.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoMovimentacao.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbTipoMovimentacao.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbTipoMovimentacao.TabIndex = 1066;
            cmbTipoMovimentacao.TabStop = false;
            // 
            // lblRotuloProdutoID
            // 
            lblRotuloProdutoID.AutoSize = true;
            lblRotuloProdutoID.BackColor = Color.Transparent;
            lblRotuloProdutoID.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloProdutoID.Location = new Point(4, 19);
            lblRotuloProdutoID.Name = "lblRotuloProdutoID";
            lblRotuloProdutoID.Size = new Size(46, 15);
            lblRotuloProdutoID.TabIndex = 1059;
            lblRotuloProdutoID.Text = "Código";
            // 
            // txtProdutoBuscar
            // 
            txtProdutoBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProdutoBuscar.CharacterCasing = CharacterCasing.Upper;
            txtProdutoBuscar.Location = new Point(55, 40);
            txtProdutoBuscar.Name = "txtProdutoBuscar";
            txtProdutoBuscar.Size = new Size(797, 24);
            txtProdutoBuscar.StateCommon.Back.Color1 = Color.White;
            txtProdutoBuscar.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtProdutoBuscar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtProdutoBuscar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtProdutoBuscar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtProdutoBuscar.StateCommon.Border.Rounding = 8F;
            txtProdutoBuscar.StateCommon.Border.Width = 1;
            txtProdutoBuscar.StateCommon.Content.Color1 = Color.Gray;
            txtProdutoBuscar.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtProdutoBuscar.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtProdutoBuscar.TabIndex = 1044;
            txtProdutoBuscar.TextChanged += txtProdutoBuscar_TextChanged;
            // 
            // lblRotuloTipoMovimentacao
            // 
            lblRotuloTipoMovimentacao.AutoSize = true;
            lblRotuloTipoMovimentacao.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloTipoMovimentacao.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloTipoMovimentacao.Location = new Point(6, 127);
            lblRotuloTipoMovimentacao.Name = "lblRotuloTipoMovimentacao";
            lblRotuloTipoMovimentacao.Size = new Size(130, 16);
            lblRotuloTipoMovimentacao.TabIndex = 1065;
            lblRotuloTipoMovimentacao.Text = "Tipo movimentação:";
            // 
            // lblRotuloDescricaoProduto
            // 
            lblRotuloDescricaoProduto.AutoSize = true;
            lblRotuloDescricaoProduto.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloDescricaoProduto.Location = new Point(55, 19);
            lblRotuloDescricaoProduto.Name = "lblRotuloDescricaoProduto";
            lblRotuloDescricaoProduto.Size = new Size(121, 15);
            lblRotuloDescricaoProduto.TabIndex = 1057;
            lblRotuloDescricaoProduto.Text = "Descrição do produto";
            // 
            // lblEstoqueAtual
            // 
            lblEstoqueAtual.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEstoqueAtual.AutoSize = true;
            lblEstoqueAtual.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblEstoqueAtual.ForeColor = Color.FromArgb(0, 76, 172);
            lblEstoqueAtual.Location = new Point(866, 40);
            lblEstoqueAtual.Name = "lblEstoqueAtual";
            lblEstoqueAtual.Size = new Size(15, 17);
            lblEstoqueAtual.TabIndex = 1080;
            lblEstoqueAtual.Text = "0";
            // 
            // lblRotuloQuantidade
            // 
            lblRotuloQuantidade.Anchor = AnchorStyles.Top;
            lblRotuloQuantidade.AutoSize = true;
            lblRotuloQuantidade.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloQuantidade.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloQuantidade.Location = new Point(56, 159);
            lblRotuloQuantidade.Name = "lblRotuloQuantidade";
            lblRotuloQuantidade.Size = new Size(80, 16);
            lblRotuloQuantidade.TabIndex = 1082;
            lblRotuloQuantidade.Text = "Quantidade:";
            // 
            // txtObservacao
            // 
            txtObservacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtObservacao.CharacterCasing = CharacterCasing.Upper;
            txtObservacao.Location = new Point(142, 217);
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(771, 24);
            txtObservacao.StateCommon.Back.Color1 = Color.White;
            txtObservacao.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtObservacao.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtObservacao.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtObservacao.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtObservacao.StateCommon.Border.Rounding = 8F;
            txtObservacao.StateCommon.Border.Width = 1;
            txtObservacao.StateCommon.Content.Color1 = Color.Gray;
            txtObservacao.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtObservacao.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtObservacao.TabIndex = 1083;
            // 
            // lblRotuloObservacoes
            // 
            lblRotuloObservacoes.AutoSize = true;
            lblRotuloObservacoes.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloObservacoes.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloObservacoes.Location = new Point(54, 218);
            lblRotuloObservacoes.Name = "lblRotuloObservacoes";
            lblRotuloObservacoes.Size = new Size(85, 16);
            lblRotuloObservacoes.TabIndex = 1084;
            lblRotuloObservacoes.Text = "Observaçao:";
            // 
            // cmbOrigem
            // 
            cmbOrigem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbOrigem.CornerRoundingRadius = 6F;
            cmbOrigem.DropDownWidth = 115;
            cmbOrigem.IntegralHeight = false;
            cmbOrigem.Items.AddRange(new object[] { "Ajuste Manual", "Inventário", "Perda", "Devolução" });
            cmbOrigem.Location = new Point(142, 186);
            cmbOrigem.Name = "cmbOrigem";
            cmbOrigem.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbOrigem.Size = new Size(164, 25);
            cmbOrigem.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbOrigem.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbOrigem.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbOrigem.TabIndex = 1085;
            cmbOrigem.TabStop = false;
            // 
            // grpProduto
            // 
            grpProduto.Controls.Add(lblIdProduto);
            grpProduto.Controls.Add(lblRotuloEstoque);
            grpProduto.Controls.Add(txtProdutoBuscar);
            grpProduto.Controls.Add(lblRotuloDescricaoProduto);
            grpProduto.Controls.Add(lblRotuloProdutoID);
            grpProduto.Controls.Add(lblEstoqueAtual);
            grpProduto.Dock = DockStyle.Top;
            grpProduto.Location = new Point(0, 0);
            grpProduto.Name = "grpProduto";
            grpProduto.Size = new Size(925, 71);
            grpProduto.TabIndex = 1086;
            grpProduto.TabStop = false;
            grpProduto.Text = "Produto";
            // 
            // lblIdProduto
            // 
            lblIdProduto.AutoSize = true;
            lblIdProduto.BackColor = Color.Transparent;
            lblIdProduto.ForeColor = Color.FromArgb(0, 76, 172);
            lblIdProduto.Location = new Point(9, 40);
            lblIdProduto.Name = "lblIdProduto";
            lblIdProduto.Size = new Size(13, 15);
            lblIdProduto.TabIndex = 1084;
            lblIdProduto.Text = "0";
            // 
            // lblRotuloEstoque
            // 
            lblRotuloEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRotuloEstoque.AutoSize = true;
            lblRotuloEstoque.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblRotuloEstoque.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloEstoque.Location = new Point(862, 19);
            lblRotuloEstoque.Name = "lblRotuloEstoque";
            lblRotuloEstoque.Size = new Size(61, 17);
            lblRotuloEstoque.TabIndex = 1083;
            lblRotuloEstoque.Text = "Estoque ";
            // 
            // grpMovimentacao
            // 
            grpMovimentacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpMovimentacao.Location = new Point(0, 101);
            grpMovimentacao.Name = "grpMovimentacao";
            grpMovimentacao.Size = new Size(925, 15);
            grpMovimentacao.TabIndex = 1087;
            grpMovimentacao.TabStop = false;
            grpMovimentacao.Text = "Movimentações";
            // 
            // lblRotuloOrigem
            // 
            lblRotuloOrigem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRotuloOrigem.AutoSize = true;
            lblRotuloOrigem.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloOrigem.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloOrigem.Location = new Point(82, 187);
            lblRotuloOrigem.Name = "lblRotuloOrigem";
            lblRotuloOrigem.Size = new Size(54, 16);
            lblRotuloOrigem.TabIndex = 1087;
            lblRotuloOrigem.Text = "Origem:";
            // 
            // numQuantidade
            // 
            numQuantidade.Anchor = AnchorStyles.Top;
            numQuantidade.Location = new Point(142, 154);
            numQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantidade.Name = "numQuantidade";
            numQuantidade.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            numQuantidade.Size = new Size(164, 26);
            numQuantidade.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numQuantidade.StateCommon.Border.Rounding = 6F;
            numQuantidade.TabIndex = 1086;
            numQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FrmMovimentacaoEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(925, 305);
            Controls.Add(txtObservacao);
            Controls.Add(btnListarControlesDoForm);
            Controls.Add(lblRotuloObservacoes);
            Controls.Add(grpMovimentacao);
            Controls.Add(lblRotuloOrigem);
            Controls.Add(bnCancelar);
            Controls.Add(numQuantidade);
            Controls.Add(grpProduto);
            Controls.Add(cmbTipoMovimentacao);
            Controls.Add(btnConfirmar);
            Controls.Add(lblRotuloTipoMovimentacao);
            Controls.Add(cmbOrigem);
            Controls.Add(lblRotuloQuantidade);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMovimentacaoEstoque";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movimentacao Estoque";
            Load += FrmMovimentacaoEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)cmbTipoMovimentacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbOrigem).EndInit();
            grpProduto.ResumeLayout(false);
            grpProduto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        public ToolStripStatusLabel toolStripStatusLabelUsuarioCriacao;
        private ToolStripStatusLabel toolStripStatusLabel2;
        public ToolStripStatusLabel ToolStripLabelDataCriacao;
        private ToolStripStatusLabel toolStripStatusLabel4;
        public ToolStripStatusLabel ToolStripLabelDataUtimaCompra;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabelUsuarioAtualizacao;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabelDataAtualizacao;
        private ToolStripStatusLabel lblStatus;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public Krypton.Toolkit.KryptonButton btnSair;
        public Krypton.Toolkit.KryptonButton btnConfirmar;
        public Krypton.Toolkit.KryptonButton kryptonButton4;
        public Krypton.Toolkit.KryptonTextBox txtDataValidade;
        public Krypton.Toolkit.KryptonComboBox cmbSituacao;
        private Label label10;
        public PictureBox pbImagem;
        public Krypton.Toolkit.KryptonComboBox cmbTipoMovimentacao;
        public Krypton.Toolkit.KryptonTextBox txtEstoque;
        private Label lblRotuloProdutoID;
        private Label lblRotuloOrigem;
        public Krypton.Toolkit.KryptonTextBox txtProdutoBuscar;
        private Label lblRotuloTipoMovimentacao;
        private Label lblRotuloDescricaoProduto;
        public Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonNumericUpDown numQuantidade;
        private Label lblRotuloQuantidade;
        public Krypton.Toolkit.KryptonTextBox txtObservacao;
        private Label lblRotuloObservacoes;
        public Krypton.Toolkit.KryptonButton bnCancelar;
        public Krypton.Toolkit.KryptonComboBox cmbOrigem;
        private GroupBox grpProduto;
        private GroupBox grpMovimentacao;
        private Label lblRotuloEstoque;
        private Krypton.Toolkit.KryptonButton btnListarControlesDoForm;
        public Label lblEstoqueAtual;
        private Label lblIdProduto;
    }
}