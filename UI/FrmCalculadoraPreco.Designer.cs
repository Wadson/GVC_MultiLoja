namespace GVC.UTIL
{
    partial class FrmCalculadoraPreco
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
            btnAplicar = new Button();
            btnFechar = new Button();
            lblProdutoTitulo = new Label();
            lblProdutoValor = new Label();
            lblCusto = new Label();
            lblCustoTitulo = new Label();
            lblPrecoVenda = new Label();
            lblVendaTitulo = new Label();
            lblLucroAtual = new Label();
            lblLucroAtualTitulo = new Label();
            lblMargemAtual = new Label();
            lblMargemAtualTitulo = new Label();
            lblLucroDesejadoTitulo = new Label();
            label1 = new Label();
            lblPrecoDeVenda = new Label();
            kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            txtLucroDesejado = new Krypton.Toolkit.KryptonTextBox();
            txtPrecoVendaCalculado = new Krypton.Toolkit.KryptonTextBox();
            button1 = new Button();
            lblMargemCalculada = new Label();
            label3 = new Label();
            lblLucroCalculado = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1.Panel).BeginInit();
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
            // btnAplicar
            // 
            btnAplicar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAplicar.BackColor = Color.FromArgb(40, 167, 69);
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.ForeColor = Color.White;
            btnAplicar.Location = new Point(180, 385);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(123, 29);
            btnAplicar.TabIndex = 24;
            btnAplicar.Text = "Aplicar Novo Preço";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFechar.BackColor = Color.FromArgb(108, 117, 125);
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(309, 385);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(82, 29);
            btnFechar.TabIndex = 25;
            btnFechar.Text = "Sair";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblProdutoTitulo
            // 
            lblProdutoTitulo.AutoSize = true;
            lblProdutoTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProdutoTitulo.Location = new Point(88, -2);
            lblProdutoTitulo.Name = "lblProdutoTitulo";
            lblProdutoTitulo.Size = new Size(68, 19);
            lblProdutoTitulo.TabIndex = 26;
            lblProdutoTitulo.Text = "Produto:";
            // 
            // lblProdutoValor
            // 
            lblProdutoValor.AutoSize = true;
            lblProdutoValor.Font = new Font("Segoe UI", 10F);
            lblProdutoValor.Location = new Point(159, -2);
            lblProdutoValor.Name = "lblProdutoValor";
            lblProdutoValor.Size = new Size(100, 19);
            lblProdutoValor.TabIndex = 31;
            lblProdutoValor.Text = "_nomeProduto";
            // 
            // lblCusto
            // 
            lblCusto.AutoSize = true;
            lblCusto.Font = new Font("Segoe UI", 10F);
            lblCusto.ForeColor = Color.Red;
            lblCusto.Location = new Point(159, 33);
            lblCusto.Name = "lblCusto";
            lblCusto.Size = new Size(45, 19);
            lblCusto.TabIndex = 33;
            lblCusto.Text = "Custo";
            // 
            // lblCustoTitulo
            // 
            lblCustoTitulo.AutoSize = true;
            lblCustoTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCustoTitulo.Location = new Point(42, 33);
            lblCustoTitulo.Name = "lblCustoTitulo";
            lblCustoTitulo.Size = new Size(114, 19);
            lblCustoTitulo.TabIndex = 32;
            lblCustoTitulo.Text = "Preço de Custo:";
            // 
            // lblPrecoVenda
            // 
            lblPrecoVenda.AutoSize = true;
            lblPrecoVenda.Font = new Font("Segoe UI", 10F);
            lblPrecoVenda.ForeColor = Color.Blue;
            lblPrecoVenda.Location = new Point(159, 64);
            lblPrecoVenda.Name = "lblPrecoVenda";
            lblPrecoVenda.Size = new Size(47, 19);
            lblPrecoVenda.TabIndex = 35;
            lblPrecoVenda.Text = "Venda";
            // 
            // lblVendaTitulo
            // 
            lblVendaTitulo.AutoSize = true;
            lblVendaTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVendaTitulo.Location = new Point(-1, 64);
            lblVendaTitulo.Name = "lblVendaTitulo";
            lblVendaTitulo.Size = new Size(157, 19);
            lblVendaTitulo.TabIndex = 34;
            lblVendaTitulo.Text = "Preço de Venda Atual:";
            // 
            // lblLucroAtual
            // 
            lblLucroAtual.AutoSize = true;
            lblLucroAtual.Font = new Font("Segoe UI", 10F);
            lblLucroAtual.ForeColor = Color.Green;
            lblLucroAtual.Location = new Point(159, 95);
            lblLucroAtual.Name = "lblLucroAtual";
            lblLucroAtual.Size = new Size(43, 19);
            lblLucroAtual.TabIndex = 37;
            lblLucroAtual.Text = "Lucro";
            // 
            // lblLucroAtualTitulo
            // 
            lblLucroAtualTitulo.AutoSize = true;
            lblLucroAtualTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLucroAtualTitulo.Location = new Point(67, 95);
            lblLucroAtualTitulo.Name = "lblLucroAtualTitulo";
            lblLucroAtualTitulo.Size = new Size(89, 19);
            lblLucroAtualTitulo.TabIndex = 36;
            lblLucroAtualTitulo.Text = "Lucro Atual:";
            // 
            // lblMargemAtual
            // 
            lblMargemAtual.AutoSize = true;
            lblMargemAtual.Font = new Font("Segoe UI", 10F);
            lblMargemAtual.Location = new Point(159, 126);
            lblMargemAtual.Name = "lblMargemAtual";
            lblMargemAtual.Size = new Size(61, 19);
            lblMargemAtual.TabIndex = 39;
            lblMargemAtual.Text = "Margem";
            // 
            // lblMargemAtualTitulo
            // 
            lblMargemAtualTitulo.AutoSize = true;
            lblMargemAtualTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMargemAtualTitulo.Location = new Point(47, 126);
            lblMargemAtualTitulo.Name = "lblMargemAtualTitulo";
            lblMargemAtualTitulo.Size = new Size(109, 19);
            lblMargemAtualTitulo.TabIndex = 38;
            lblMargemAtualTitulo.Text = "Margem Atual:";
            // 
            // lblLucroDesejadoTitulo
            // 
            lblLucroDesejadoTitulo.AutoSize = true;
            lblLucroDesejadoTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLucroDesejadoTitulo.Location = new Point(24, 208);
            lblLucroDesejadoTitulo.Name = "lblLucroDesejadoTitulo";
            lblLucroDesejadoTitulo.Size = new Size(132, 19);
            lblLucroDesejadoTitulo.TabIndex = 40;
            lblLucroDesejadoTitulo.Text = "% Lucro Desejado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(12, 174);
            label1.Name = "label1";
            label1.Size = new Size(175, 19);
            label1.TabIndex = 46;
            label1.Text = "CALCULAR NOVO PREÇO";
            // 
            // lblPrecoDeVenda
            // 
            lblPrecoDeVenda.AutoSize = true;
            lblPrecoDeVenda.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrecoDeVenda.Location = new Point(38, 247);
            lblPrecoDeVenda.Name = "lblPrecoDeVenda";
            lblPrecoDeVenda.Size = new Size(118, 19);
            lblPrecoDeVenda.TabIndex = 47;
            lblPrecoDeVenda.Text = "Preço de Venda:";
            // 
            // kryptonGroupBox1
            // 
            kryptonGroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kryptonGroupBox1.Location = new Point(-1, 151);
            kryptonGroupBox1.Name = "kryptonGroupBox1";
            kryptonGroupBox1.Size = new Size(401, 5);
            kryptonGroupBox1.TabIndex = 50;
            kryptonGroupBox1.Values.Heading = "";
            // 
            // txtLucroDesejado
            // 
            txtLucroDesejado.Location = new Point(158, 208);
            txtLucroDesejado.Margin = new Padding(4, 3, 4, 3);
            txtLucroDesejado.Name = "txtLucroDesejado";
            txtLucroDesejado.Size = new Size(232, 30);
            txtLucroDesejado.StateCommon.Back.Color1 = Color.White;
            txtLucroDesejado.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtLucroDesejado.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtLucroDesejado.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtLucroDesejado.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtLucroDesejado.StateCommon.Border.Rounding = 20F;
            txtLucroDesejado.StateCommon.Border.Width = 1;
            txtLucroDesejado.StateCommon.Content.Color1 = Color.Gray;
            txtLucroDesejado.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtLucroDesejado.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtLucroDesejado.TabIndex = 1015;
            txtLucroDesejado.TextChanged += txtLucroDesejado_TextChanged;
            txtLucroDesejado.Leave += txtLucroDesejado_Leave;
            // 
            // txtPrecoVendaCalculado
            // 
            txtPrecoVendaCalculado.Location = new Point(158, 244);
            txtPrecoVendaCalculado.Margin = new Padding(4, 3, 4, 3);
            txtPrecoVendaCalculado.Name = "txtPrecoVendaCalculado";
            txtPrecoVendaCalculado.Size = new Size(232, 30);
            txtPrecoVendaCalculado.StateCommon.Back.Color1 = Color.White;
            txtPrecoVendaCalculado.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtPrecoVendaCalculado.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtPrecoVendaCalculado.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPrecoVendaCalculado.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPrecoVendaCalculado.StateCommon.Border.Rounding = 20F;
            txtPrecoVendaCalculado.StateCommon.Border.Width = 1;
            txtPrecoVendaCalculado.StateCommon.Content.Color1 = Color.Gray;
            txtPrecoVendaCalculado.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtPrecoVendaCalculado.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtPrecoVendaCalculado.TabIndex = 1016;
            txtPrecoVendaCalculado.TextChanged += txtPrecoVendaCalculado_TextChanged;
            txtPrecoVendaCalculado.Leave += txtPrecoVendaCalculado_Leave;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(40, 167, 69);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 385);
            button1.Name = "button1";
            button1.Size = new Size(123, 29);
            button1.TabIndex = 1018;
            button1.Text = "Aplicar Novo Preço";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblMargemCalculada
            // 
            lblMargemCalculada.AutoSize = true;
            lblMargemCalculada.Font = new Font("Segoe UI", 10F);
            lblMargemCalculada.ForeColor = Color.FromArgb(0, 64, 64);
            lblMargemCalculada.Location = new Point(159, 315);
            lblMargemCalculada.Name = "lblMargemCalculada";
            lblMargemCalculada.Size = new Size(61, 19);
            lblMargemCalculada.TabIndex = 1022;
            lblMargemCalculada.Text = "Margem";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(17, 315);
            label3.Name = "label3";
            label3.Size = new Size(139, 19);
            label3.TabIndex = 1021;
            label3.Text = "Margem Calculada:";
            // 
            // lblLucroCalculado
            // 
            lblLucroCalculado.AutoSize = true;
            lblLucroCalculado.Font = new Font("Segoe UI", 10F);
            lblLucroCalculado.ForeColor = Color.FromArgb(0, 64, 64);
            lblLucroCalculado.Location = new Point(159, 284);
            lblLucroCalculado.Name = "lblLucroCalculado";
            lblLucroCalculado.Size = new Size(102, 19);
            lblLucroCalculado.TabIndex = 1020;
            lblLucroCalculado.Text = "LucroCalculado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(36, 284);
            label5.Name = "label5";
            label5.Size = new Size(120, 19);
            label5.TabIndex = 1019;
            label5.Text = "Lucro Calculado:";
            // 
            // FrmCalculadoraPreco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(403, 426);
            Controls.Add(lblMargemCalculada);
            Controls.Add(label3);
            Controls.Add(lblLucroCalculado);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(txtPrecoVendaCalculado);
            Controls.Add(txtLucroDesejado);
            Controls.Add(kryptonGroupBox1);
            Controls.Add(lblPrecoDeVenda);
            Controls.Add(label1);
            Controls.Add(lblLucroDesejadoTitulo);
            Controls.Add(lblMargemAtual);
            Controls.Add(lblMargemAtualTitulo);
            Controls.Add(lblLucroAtual);
            Controls.Add(lblLucroAtualTitulo);
            Controls.Add(lblPrecoVenda);
            Controls.Add(lblVendaTitulo);
            Controls.Add(lblCusto);
            Controls.Add(lblCustoTitulo);
            Controls.Add(lblProdutoValor);
            Controls.Add(lblProdutoTitulo);
            Controls.Add(btnFechar);
            Controls.Add(btnAplicar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadoraPreco";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            StateActive.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateActive.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "Preço de Venda:";
            Load += FrmCalculadoraPreco_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1.Panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Button btnAplicar;
        private Button btnFechar;
        private Label lblProdutoTitulo;
        private Label lblProdutoValor;
        private Label lblCusto;
        private Label lblCustoTitulo;
        private Label lblPrecoVenda;
        private Label lblVendaTitulo;
        private Label lblLucroAtual;
        private Label lblLucroTitulo;
        private Label lblMargemAtual;
        private Label lblMargemTitulol;
        private Label lblPercentualTitulo;
        private Label lblPercentualTitul;
        private TextBox textBox3;
        private Label lblLucroAtualTitulo;
        private Label lblMargemAtualTitulo;
        private Label lblLucroDesejadoTitulo;
        private Label label1;
        private Label lblPrecoDeVenda;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        public Krypton.Toolkit.KryptonTextBox txtLucroDesejado;
        public Krypton.Toolkit.KryptonTextBox txtPrecoVendaCalculado;
        private Button button1;
        private Label lblMargemCalculada;
        private Label label3;
        private Label lblLucroCalculado;
        private Label label5;
    }
}