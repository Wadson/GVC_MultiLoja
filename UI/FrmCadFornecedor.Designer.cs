namespace GVC.View
{
    partial class FrmCadFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadFornecedor));
            txtTelefone = new Krypton.Toolkit.KryptonTextBox();
            txtNomeFornecedor = new Krypton.Toolkit.KryptonTextBox();
            txtFornecedorID = new Krypton.Toolkit.KryptonTextBox();
            txtCidade = new Krypton.Toolkit.KryptonTextBox();
            txtEmail = new Krypton.Toolkit.KryptonTextBox();
            txtBairro = new Krypton.Toolkit.KryptonTextBox();
            txtNumero = new Krypton.Toolkit.KryptonTextBox();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label17 = new Label();
            label18 = new Label();
            txtUF = new Krypton.Toolkit.KryptonTextBox();
            label20 = new Label();
            label1 = new Label();
            txtCep = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloDtNascDtCriacao = new Label();
            lblIE = new Label();
            txtIE = new Krypton.Toolkit.KryptonTextBox();
            txtObservacoes = new Krypton.Toolkit.KryptonTextBox();
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            toolStripStatusLabelUsuarioCriacao = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            ToolStripLabelDataCriacao = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            ToolStripLabelDataUtimaCompra = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabelUsuarioAtualizacao = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabelDataAtualizacao = new ToolStripStatusLabel();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            txtCnpj = new Krypton.Toolkit.KryptonTextBox();
            lblCnpj = new Label();
            label8 = new Label();
            toolTip = new ToolTip(components);
            btnSair = new Krypton.Toolkit.KryptonButton();
            btnSalvar = new Krypton.Toolkit.KryptonButton();
            btnNovo = new Krypton.Toolkit.KryptonButton();
            txtLogradouro = new Krypton.Toolkit.KryptonTextBox();
            pnlHeader = new Krypton.Toolkit.KryptonPanel();
            tlpTitulo = new Krypton.Toolkit.KryptonTableLayoutPanel();
            lblSubTitulo = new Krypton.Toolkit.KryptonLabel();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            txtClienteID = new Krypton.Toolkit.KryptonTextBox();
            txtRg = new Krypton.Toolkit.KryptonTextBox();
            txtCpf = new Krypton.Toolkit.KryptonTextBox();
            txtOrgaoExpedidorRG = new Krypton.Toolkit.KryptonTextBox();
            dtpDataCriacao = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            btnBuscarEnderecoPorCep = new FontAwesome.Sharp.IconButton();
            btnLocalizarCidade = new FontAwesome.Sharp.IconButton();
            kryptonStatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).BeginInit();
            pnlHeader.SuspendLayout();
            tlpTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(148, 207);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(141, 27);
            txtTelefone.StateCommon.Back.Color1 = Color.White;
            txtTelefone.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtTelefone.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtTelefone.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTelefone.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtTelefone.StateCommon.Border.Rounding = 8F;
            txtTelefone.StateCommon.Border.Width = 1;
            txtTelefone.StateCommon.Content.Color1 = Color.Gray;
            txtTelefone.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtTelefone.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtTelefone.TabIndex = 7;
            txtTelefone.KeyPress += txtTelefone_KeyPress;
            // 
            // txtNomeFornecedor
            // 
            txtNomeFornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomeFornecedor.CharacterCasing = CharacterCasing.Upper;
            txtNomeFornecedor.Location = new Point(91, 116);
            txtNomeFornecedor.Name = "txtNomeFornecedor";
            txtNomeFornecedor.Size = new Size(272, 27);
            txtNomeFornecedor.StateCommon.Back.Color1 = Color.White;
            txtNomeFornecedor.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNomeFornecedor.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNomeFornecedor.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNomeFornecedor.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNomeFornecedor.StateCommon.Border.Rounding = 8F;
            txtNomeFornecedor.StateCommon.Border.Width = 1;
            txtNomeFornecedor.StateCommon.Content.Color1 = Color.Gray;
            txtNomeFornecedor.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtNomeFornecedor.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNomeFornecedor.TabIndex = 0;
            // 
            // txtFornecedorID
            // 
            txtFornecedorID.Location = new Point(12, 116);
            txtFornecedorID.Name = "txtFornecedorID";
            txtFornecedorID.ReadOnly = true;
            txtFornecedorID.Size = new Size(75, 27);
            txtFornecedorID.StateCommon.Back.Color1 = Color.White;
            txtFornecedorID.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtFornecedorID.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtFornecedorID.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtFornecedorID.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtFornecedorID.StateCommon.Border.Rounding = 8F;
            txtFornecedorID.StateCommon.Border.Width = 1;
            txtFornecedorID.StateCommon.Content.Color1 = Color.Gray;
            txtFornecedorID.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtFornecedorID.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtFornecedorID.TabIndex = 192;
            txtFornecedorID.TabStop = false;
            // 
            // txtCidade
            // 
            txtCidade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCidade.CharacterCasing = CharacterCasing.Upper;
            txtCidade.Location = new Point(12, 416);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(498, 27);
            txtCidade.StateCommon.Back.Color1 = Color.White;
            txtCidade.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtCidade.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtCidade.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtCidade.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtCidade.StateCommon.Border.Rounding = 8F;
            txtCidade.StateCommon.Border.Width = 1;
            txtCidade.StateCommon.Content.Color1 = Color.Gray;
            txtCidade.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtCidade.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtCidade.TabIndex = 140;
            txtCidade.TabStop = false;
            txtCidade.TextChanged += txtCidade_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.CharacterCasing = CharacterCasing.Lower;
            txtEmail.Location = new Point(293, 207);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(361, 27);
            txtEmail.StateCommon.Back.Color1 = Color.White;
            txtEmail.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtEmail.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtEmail.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtEmail.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtEmail.StateCommon.Border.Rounding = 8F;
            txtEmail.StateCommon.Border.Width = 1;
            txtEmail.StateCommon.Content.Color1 = Color.Gray;
            txtEmail.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtEmail.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtEmail.TabIndex = 8;
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtBairro.Location = new Point(12, 366);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(646, 27);
            txtBairro.StateCommon.Back.Color1 = Color.White;
            txtBairro.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtBairro.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtBairro.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtBairro.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtBairro.StateCommon.Border.Rounding = 8F;
            txtBairro.StateCommon.Border.Width = 1;
            txtBairro.StateCommon.Content.Color1 = Color.Gray;
            txtBairro.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtBairro.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtBairro.TabIndex = 14;
            // 
            // txtNumero
            // 
            txtNumero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNumero.Location = new Point(547, 315);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(108, 27);
            txtNumero.StateCommon.Back.Color1 = Color.White;
            txtNumero.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNumero.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNumero.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNumero.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNumero.StateCommon.Border.Rounding = 8F;
            txtNumero.StateCommon.Border.Width = 1;
            txtNumero.StateCommon.Content.Color1 = Color.Gray;
            txtNumero.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtNumero.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNumero.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.ForeColor = Color.FromArgb(0, 76, 172);
            label10.Location = new Point(12, 96);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 184;
            label10.Text = "Código:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 9.25F);
            label11.ForeColor = Color.FromArgb(0, 76, 172);
            label11.Location = new Point(91, 95);
            label11.Name = "label11";
            label11.Size = new Size(44, 16);
            label11.TabIndex = 183;
            label11.Text = "Nome";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Microsoft Sans Serif", 9.25F);
            label13.ForeColor = Color.FromArgb(0, 76, 172);
            label13.Location = new Point(151, 189);
            label13.Name = "label13";
            label13.Size = new Size(61, 16);
            label13.TabIndex = 185;
            label13.Text = "Telefone";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft Sans Serif", 9.25F);
            label14.ForeColor = Color.FromArgb(0, 76, 172);
            label14.Location = new Point(12, 346);
            label14.Name = "label14";
            label14.Size = new Size(43, 16);
            label14.TabIndex = 185;
            label14.Text = "Bairro";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Microsoft Sans Serif", 9.25F);
            label15.ForeColor = Color.FromArgb(0, 76, 172);
            label15.Location = new Point(547, 296);
            label15.Name = "label15";
            label15.Size = new Size(55, 16);
            label15.TabIndex = 184;
            label15.Text = "Número";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Microsoft Sans Serif", 9.25F);
            label17.ForeColor = Color.FromArgb(0, 76, 172);
            label17.Location = new Point(203, 296);
            label17.Name = "label17";
            label17.Size = new Size(66, 16);
            label17.TabIndex = 183;
            label17.Text = "Endereço";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Microsoft Sans Serif", 9.25F);
            label18.ForeColor = Color.FromArgb(0, 76, 172);
            label18.Location = new Point(293, 188);
            label18.Name = "label18";
            label18.Size = new Size(45, 16);
            label18.TabIndex = 183;
            label18.Text = "E-Mail";
            // 
            // txtUF
            // 
            txtUF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtUF.CharacterCasing = CharacterCasing.Upper;
            txtUF.Location = new Point(547, 416);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(108, 27);
            txtUF.StateCommon.Back.Color1 = Color.White;
            txtUF.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtUF.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtUF.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtUF.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtUF.StateCommon.Border.Rounding = 8F;
            txtUF.StateCommon.Border.Width = 1;
            txtUF.StateCommon.Content.Color1 = Color.Gray;
            txtUF.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtUF.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtUF.TabIndex = 150;
            txtUF.TabStop = false;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Microsoft Sans Serif", 9.25F);
            label20.ForeColor = Color.FromArgb(0, 76, 172);
            label20.Location = new Point(547, 397);
            label20.Name = "label20";
            label20.Size = new Size(20, 16);
            label20.TabIndex = 183;
            label20.Text = "Uf";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 9.25F);
            label1.ForeColor = Color.FromArgb(0, 76, 172);
            label1.Location = new Point(12, 296);
            label1.Name = "label1";
            label1.Size = new Size(32, 16);
            label1.TabIndex = 250;
            label1.Text = "Cep";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(12, 315);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(153, 27);
            txtCep.StateCommon.Back.Color1 = Color.White;
            txtCep.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtCep.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtCep.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtCep.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtCep.StateCommon.Border.Rounding = 8F;
            txtCep.StateCommon.Border.Width = 1;
            txtCep.StateCommon.Content.Color1 = Color.Gray;
            txtCep.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtCep.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtCep.TabIndex = 10;
            txtCep.KeyDown += txtCep_KeyDown;
            txtCep.KeyPress += txtCep_KeyPress;
            txtCep.Leave += txtCep_Leave;
            // 
            // lblRotuloDtNascDtCriacao
            // 
            lblRotuloDtNascDtCriacao.AutoSize = true;
            lblRotuloDtNascDtCriacao.BackColor = Color.Transparent;
            lblRotuloDtNascDtCriacao.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloDtNascDtCriacao.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloDtNascDtCriacao.Location = new Point(12, 187);
            lblRotuloDtNascDtCriacao.Name = "lblRotuloDtNascDtCriacao";
            lblRotuloDtNascDtCriacao.Size = new Size(86, 16);
            lblRotuloDtNascDtCriacao.TabIndex = 252;
            lblRotuloDtNascDtCriacao.Text = "Data Criação";
            // 
            // lblIE
            // 
            lblIE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIE.AutoSize = true;
            lblIE.BackColor = Color.Transparent;
            lblIE.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblIE.ForeColor = Color.FromArgb(0, 76, 172);
            lblIE.Location = new Point(515, 97);
            lblIE.Name = "lblIE";
            lblIE.Size = new Size(139, 16);
            lblIE.TabIndex = 254;
            lblIE.Text = "IE - Inscrição Estadual";
            // 
            // txtIE
            // 
            txtIE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtIE.Location = new Point(515, 116);
            txtIE.Name = "txtIE";
            txtIE.Size = new Size(140, 27);
            txtIE.StateCommon.Back.Color1 = Color.White;
            txtIE.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtIE.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtIE.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtIE.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtIE.StateCommon.Border.Rounding = 8F;
            txtIE.StateCommon.Border.Width = 1;
            txtIE.StateCommon.Content.Color1 = Color.Gray;
            txtIE.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtIE.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtIE.TabIndex = 5;
            txtIE.KeyPress += txtIE_KeyPress;
            // 
            // txtObservacoes
            // 
            txtObservacoes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtObservacoes.CharacterCasing = CharacterCasing.Upper;
            txtObservacoes.Location = new Point(12, 481);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(642, 53);
            txtObservacoes.StateCommon.Back.Color1 = Color.White;
            txtObservacoes.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtObservacoes.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtObservacoes.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtObservacoes.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtObservacoes.StateCommon.Border.Rounding = 8F;
            txtObservacoes.StateCommon.Border.Width = 1;
            txtObservacoes.StateCommon.Content.Color1 = Color.Gray;
            txtObservacoes.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtObservacoes.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtObservacoes.TabIndex = 16;
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelUsuarioCriacao, toolStripStatusLabel2, ToolStripLabelDataCriacao, toolStripStatusLabel4, ToolStripLabelDataUtimaCompra, toolStripStatusLabel1, toolStripStatusLabelUsuarioAtualizacao, toolStripStatusLabel3, toolStripStatusLabelDataAtualizacao });
            kryptonStatusStrip1.Location = new Point(0, 623);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.Professional;
            kryptonStatusStrip1.Size = new Size(664, 22);
            kryptonStatusStrip1.TabIndex = 1027;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // toolStripStatusLabelUsuarioCriacao
            // 
            toolStripStatusLabelUsuarioCriacao.ForeColor = Color.FromArgb(0, 76, 172);
            toolStripStatusLabelUsuarioCriacao.Name = "toolStripStatusLabelUsuarioCriacao";
            toolStripStatusLabelUsuarioCriacao.Size = new Size(99, 17);
            toolStripStatusLabelUsuarioCriacao.Text = "Usuario Criação...";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(16, 17);
            toolStripStatusLabel2.Text = " | ";
            // 
            // ToolStripLabelDataCriacao
            // 
            ToolStripLabelDataCriacao.ForeColor = Color.FromArgb(0, 76, 172);
            ToolStripLabelDataCriacao.Name = "ToolStripLabelDataCriacao";
            ToolStripLabelDataCriacao.Size = new Size(99, 17);
            ToolStripLabelDataCriacao.Text = "Data da Criação...";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(16, 17);
            toolStripStatusLabel4.Text = " | ";
            // 
            // ToolStripLabelDataUtimaCompra
            // 
            ToolStripLabelDataUtimaCompra.ForeColor = Color.FromArgb(0, 76, 172);
            ToolStripLabelDataUtimaCompra.Name = "ToolStripLabelDataUtimaCompra";
            ToolStripLabelDataUtimaCompra.Size = new Size(131, 17);
            ToolStripLabelDataUtimaCompra.Text = "Data da Ultima Compra";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(16, 17);
            toolStripStatusLabel1.Text = " | ";
            // 
            // toolStripStatusLabelUsuarioAtualizacao
            // 
            toolStripStatusLabelUsuarioAtualizacao.ForeColor = Color.FromArgb(0, 76, 172);
            toolStripStatusLabelUsuarioAtualizacao.Name = "toolStripStatusLabelUsuarioAtualizacao";
            toolStripStatusLabelUsuarioAtualizacao.Size = new Size(100, 17);
            toolStripStatusLabelUsuarioAtualizacao.Text = "Usuário Alteração";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(16, 17);
            toolStripStatusLabel3.Text = " | ";
            // 
            // toolStripStatusLabelDataAtualizacao
            // 
            toolStripStatusLabelDataAtualizacao.ForeColor = Color.FromArgb(0, 76, 172);
            toolStripStatusLabelDataAtualizacao.Name = "toolStripStatusLabelDataAtualizacao";
            toolStripStatusLabelDataAtualizacao.Size = new Size(95, 17);
            toolStripStatusLabelDataAtualizacao.Text = "Data Atualização";
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
            // txtCnpj
            // 
            txtCnpj.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCnpj.CharacterCasing = CharacterCasing.Upper;
            txtCnpj.Location = new Point(369, 116);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(140, 27);
            txtCnpj.StateCommon.Back.Color1 = Color.White;
            txtCnpj.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtCnpj.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtCnpj.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtCnpj.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtCnpj.StateCommon.Border.Rounding = 8F;
            txtCnpj.StateCommon.Border.Width = 1;
            txtCnpj.StateCommon.Content.Color1 = Color.Gray;
            txtCnpj.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtCnpj.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtCnpj.TabIndex = 4;
            txtCnpj.KeyPress += txtCnpj_KeyPress;
            txtCnpj.Leave += txtCnpj_Leave;
            // 
            // lblCnpj
            // 
            lblCnpj.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCnpj.AutoSize = true;
            lblCnpj.BackColor = Color.Transparent;
            lblCnpj.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblCnpj.ForeColor = Color.FromArgb(0, 76, 172);
            lblCnpj.Location = new Point(369, 97);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(34, 16);
            lblCnpj.TabIndex = 1029;
            lblCnpj.Text = "Cnpj";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 9.25F);
            label8.ForeColor = Color.FromArgb(0, 76, 172);
            label8.Location = new Point(12, 397);
            label8.Name = "label8";
            label8.Size = new Size(51, 16);
            label8.TabIndex = 1034;
            label8.Text = "Cidade";
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSair.CornerRoundingRadius = 20F;
            btnSair.Location = new Point(554, 581);
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
            btnSair.Size = new Size(100, 30);
            btnSair.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnSair.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 250);
            btnSair.StateCommon.Back.ColorAngle = 45F;
            btnSair.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Border.ColorAngle = 45F;
            btnSair.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateCommon.Border.Rounding = 20F;
            btnSair.StateCommon.Border.Width = 1;
            btnSair.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            btnSair.StateNormal.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnSair.StateNormal.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnSair.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateNormal.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StateNormal.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StateNormal.Border.ColorAngle = 45F;
            btnSair.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateNormal.Border.Rounding = 20F;
            btnSair.StateNormal.Border.Width = 1;
            btnSair.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StatePressed.Back.ColorAngle = 135F;
            btnSair.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StatePressed.Border.ColorAngle = 135F;
            btnSair.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StatePressed.Border.Rounding = 20F;
            btnSair.StatePressed.Border.Width = 1;
            btnSair.StatePressed.Content.ShortText.Color1 = Color.White;
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
            btnSair.TabIndex = 1037;
            btnSair.Values.Text = "Sair";
            btnSair.Click += btnSair_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.CornerRoundingRadius = 20F;
            btnSalvar.Location = new Point(342, 581);
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
            btnSalvar.Size = new Size(100, 30);
            btnSalvar.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvar.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvar.StateCommon.Back.ColorAngle = 45F;
            btnSalvar.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvar.StateCommon.Border.ColorAngle = 45F;
            btnSalvar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvar.StateCommon.Border.Rounding = 20F;
            btnSalvar.StateCommon.Border.Width = 1;
            btnSalvar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSalvar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSalvar.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            btnSalvar.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSalvar.StateNormal.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnSalvar.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvar.StateNormal.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSalvar.StateNormal.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSalvar.StateNormal.Border.ColorAngle = 45F;
            btnSalvar.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvar.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvar.StateNormal.Border.Rounding = 20F;
            btnSalvar.StateNormal.Border.Width = 1;
            btnSalvar.StatePressed.Back.Color1 = Color.White;
            btnSalvar.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnSalvar.StatePressed.Back.ColorAngle = 135F;
            btnSalvar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSalvar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSalvar.StatePressed.Border.ColorAngle = 135F;
            btnSalvar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvar.StatePressed.Border.Rounding = 20F;
            btnSalvar.StatePressed.Border.Width = 1;
            btnSalvar.StatePressed.Content.ShortText.Color1 = Color.FromArgb(22, 121, 206);
            btnSalvar.StateTracking.Back.Color1 = Color.White;
            btnSalvar.StateTracking.Back.Color2 = Color.White;
            btnSalvar.StateTracking.Back.ColorAngle = 45F;
            btnSalvar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvar.StateTracking.Border.ColorAngle = 45F;
            btnSalvar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvar.StateTracking.Border.Rounding = 20F;
            btnSalvar.StateTracking.Border.Width = 1;
            btnSalvar.StateTracking.Content.ShortText.Color1 = Color.FromArgb(22, 121, 206);
            btnSalvar.TabIndex = 1036;
            btnSalvar.Values.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNovo.CornerRoundingRadius = 20F;
            btnNovo.Location = new Point(448, 581);
            btnNovo.Name = "btnNovo";
            btnNovo.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnNovo.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnNovo.OverrideDefault.Back.ColorAngle = 45F;
            btnNovo.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnNovo.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNovo.OverrideDefault.Border.ColorAngle = 45F;
            btnNovo.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.OverrideDefault.Border.Rounding = 20F;
            btnNovo.OverrideDefault.Border.Width = 1;
            btnNovo.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnNovo.Size = new Size(100, 30);
            btnNovo.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnNovo.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 250);
            btnNovo.StateCommon.Back.ColorAngle = 45F;
            btnNovo.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNovo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNovo.StateCommon.Border.ColorAngle = 45F;
            btnNovo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.StateCommon.Border.Rounding = 20F;
            btnNovo.StateCommon.Border.Width = 1;
            btnNovo.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnNovo.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            btnNovo.StateNormal.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnNovo.StateNormal.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnNovo.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.StateNormal.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnNovo.StateNormal.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnNovo.StateNormal.Border.ColorAngle = 45F;
            btnNovo.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.StateNormal.Border.Rounding = 20F;
            btnNovo.StateNormal.Border.Width = 1;
            btnNovo.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnNovo.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnNovo.StatePressed.Back.ColorAngle = 135F;
            btnNovo.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnNovo.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnNovo.StatePressed.Border.ColorAngle = 135F;
            btnNovo.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.StatePressed.Border.Rounding = 20F;
            btnNovo.StatePressed.Border.Width = 1;
            btnNovo.StatePressed.Content.ShortText.Color1 = Color.White;
            btnNovo.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnNovo.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnNovo.StateTracking.Back.ColorAngle = 45F;
            btnNovo.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNovo.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNovo.StateTracking.Border.ColorAngle = 45F;
            btnNovo.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovo.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovo.StateTracking.Border.Rounding = 20F;
            btnNovo.StateTracking.Border.Width = 1;
            btnNovo.StateTracking.Content.ShortText.Color1 = Color.White;
            btnNovo.TabIndex = 1035;
            btnNovo.Values.Text = "Novo";
            btnNovo.Click += btnNovo_Click;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLogradouro.CharacterCasing = CharacterCasing.Upper;
            txtLogradouro.Location = new Point(203, 315);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(338, 27);
            txtLogradouro.StateCommon.Back.Color1 = Color.White;
            txtLogradouro.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtLogradouro.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtLogradouro.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtLogradouro.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtLogradouro.StateCommon.Border.Rounding = 8F;
            txtLogradouro.StateCommon.Border.Width = 1;
            txtLogradouro.StateCommon.Content.Color1 = Color.Gray;
            txtLogradouro.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtLogradouro.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtLogradouro.TabIndex = 12;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(tlpTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(664, 47);
            pnlHeader.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            pnlHeader.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            pnlHeader.TabIndex = 1092;
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
            tlpTitulo.Size = new Size(664, 47);
            tlpTitulo.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            tlpTitulo.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            tlpTitulo.TabIndex = 0;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.Dock = DockStyle.Fill;
            lblSubTitulo.Location = new Point(3, 25);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(658, 19);
            lblSubTitulo.StateCommon.ShortText.Color1 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Color2 = Color.WhiteSmoke;
            lblSubTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblSubTitulo.TabIndex = 0;
            lblSubTitulo.Values.Text = "Inclusão e manutenção de fornecedores";
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Location = new Point(3, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(658, 16);
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Color2 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 1091;
            lblTitulo.Values.Text = "Cadastro de Fornecedores";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(12, 73);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(108, 20);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 1038;
            kryptonLabel1.Values.Text = "Dados cadastrais";
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonTextBox2.Location = new Point(1350, 90);
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.Size = new Size(180, 27);
            kryptonTextBox2.StateCommon.Back.Color1 = Color.White;
            kryptonTextBox2.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            kryptonTextBox2.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonTextBox2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox2.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBox2.StateCommon.Border.Rounding = 8F;
            kryptonTextBox2.StateCommon.Border.Width = 1;
            kryptonTextBox2.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBox2.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            kryptonTextBox2.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBox2.TabIndex = 1;
            kryptonTextBox2.Visible = false;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonTextBox1.Location = new Point(1534, 90);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(180, 27);
            kryptonTextBox1.StateCommon.Back.Color1 = Color.White;
            kryptonTextBox1.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            kryptonTextBox1.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonTextBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBox1.StateCommon.Border.Rounding = 8F;
            kryptonTextBox1.StateCommon.Border.Width = 1;
            kryptonTextBox1.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBox1.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            kryptonTextBox1.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            kryptonTextBox1.TabIndex = 1040;
            kryptonTextBox1.Visible = false;
            // 
            // txtClienteID
            // 
            txtClienteID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtClienteID.Location = new Point(1686, 38);
            txtClienteID.Name = "txtClienteID";
            txtClienteID.ReadOnly = true;
            txtClienteID.Size = new Size(118, 27);
            txtClienteID.StateCommon.Back.Color1 = Color.White;
            txtClienteID.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtClienteID.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtClienteID.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtClienteID.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtClienteID.StateCommon.Border.Rounding = 8F;
            txtClienteID.StateCommon.Border.Width = 1;
            txtClienteID.StateCommon.Content.Color1 = Color.Gray;
            txtClienteID.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtClienteID.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtClienteID.TabIndex = 192;
            txtClienteID.TabStop = false;
            // 
            // txtRg
            // 
            txtRg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtRg.Location = new Point(1534, 90);
            txtRg.Name = "txtRg";
            txtRg.Size = new Size(180, 27);
            txtRg.StateCommon.Back.Color1 = Color.White;
            txtRg.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtRg.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtRg.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtRg.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtRg.StateCommon.Border.Rounding = 8F;
            txtRg.StateCommon.Border.Width = 1;
            txtRg.StateCommon.Content.Color1 = Color.Gray;
            txtRg.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtRg.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtRg.TabIndex = 2;
            // 
            // txtCpf
            // 
            txtCpf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCpf.CharacterCasing = CharacterCasing.Upper;
            txtCpf.Location = new Point(1350, 90);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(180, 27);
            txtCpf.StateCommon.Back.Color1 = Color.White;
            txtCpf.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtCpf.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtCpf.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtCpf.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtCpf.StateCommon.Border.Rounding = 8F;
            txtCpf.StateCommon.Border.Width = 1;
            txtCpf.StateCommon.Content.Color1 = Color.Gray;
            txtCpf.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtCpf.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtCpf.TabIndex = 1;
            // 
            // txtOrgaoExpedidorRG
            // 
            txtOrgaoExpedidorRG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtOrgaoExpedidorRG.Location = new Point(1719, 89);
            txtOrgaoExpedidorRG.Name = "txtOrgaoExpedidorRG";
            txtOrgaoExpedidorRG.Size = new Size(180, 27);
            txtOrgaoExpedidorRG.StateCommon.Back.Color1 = Color.White;
            txtOrgaoExpedidorRG.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtOrgaoExpedidorRG.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtOrgaoExpedidorRG.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtOrgaoExpedidorRG.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtOrgaoExpedidorRG.StateCommon.Border.Rounding = 8F;
            txtOrgaoExpedidorRG.StateCommon.Border.Width = 1;
            txtOrgaoExpedidorRG.StateCommon.Content.Color1 = Color.Gray;
            txtOrgaoExpedidorRG.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtOrgaoExpedidorRG.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtOrgaoExpedidorRG.TabIndex = 3;
            // 
            // dtpDataCriacao
            // 
            dtpDataCriacao.CornerRoundingRadius = 3F;
            dtpDataCriacao.Format = DateTimePickerFormat.Short;
            dtpDataCriacao.Location = new Point(12, 205);
            dtpDataCriacao.Name = "dtpDataCriacao";
            dtpDataCriacao.Size = new Size(132, 29);
            dtpDataCriacao.StateActive.Back.Color1 = Color.FromArgb(6, 174, 244);
            dtpDataCriacao.StateActive.Border.Color1 = Color.FromArgb(6, 174, 244);
            dtpDataCriacao.StateActive.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtpDataCriacao.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataCriacao.StateActive.Border.Rounding = 3F;
            dtpDataCriacao.StateActive.Content.Color1 = Color.White;
            dtpDataCriacao.StateActive.Content.Font = new Font("Poppins", 9F);
            dtpDataCriacao.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataCriacao.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataCriacao.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtpDataCriacao.StateCommon.Border.ColorAngle = 45F;
            dtpDataCriacao.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataCriacao.StateCommon.Border.Rounding = 3F;
            dtpDataCriacao.StateCommon.Border.Width = 1;
            dtpDataCriacao.StateCommon.Content.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDataCriacao.StateCommon.Content.Padding = new Padding(1);
            dtpDataCriacao.StateDisabled.Border.ColorAngle = 45F;
            dtpDataCriacao.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataCriacao.StateDisabled.Border.Rounding = 3F;
            dtpDataCriacao.StateDisabled.Border.Width = 1;
            dtpDataCriacao.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataCriacao.StateNormal.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtpDataCriacao.StateNormal.Border.Color2 = Color.FromArgb(6, 174, 244);
            dtpDataCriacao.StateNormal.Border.ColorAngle = 45F;
            dtpDataCriacao.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataCriacao.StateNormal.Border.Rounding = 3F;
            dtpDataCriacao.StateNormal.Border.Width = 1;
            dtpDataCriacao.StateNormal.Content.Color1 = Color.White;
            dtpDataCriacao.TabIndex = 1040;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(12, 163);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(108, 20);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 1039;
            kryptonLabel2.Values.Text = "Dados adicionais";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(12, 266);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(64, 20);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 1039;
            kryptonLabel3.Values.Text = "Endereço";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(12, 459);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            kryptonLabel4.Size = new Size(84, 20);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel4.TabIndex = 1040;
            kryptonLabel4.Values.Text = "Observações";
            // 
            // btnBuscarEnderecoPorCep
            // 
            btnBuscarEnderecoPorCep.BackColor = Color.Transparent;
            btnBuscarEnderecoPorCep.FlatAppearance.BorderSize = 0;
            btnBuscarEnderecoPorCep.FlatStyle = FlatStyle.Flat;
            btnBuscarEnderecoPorCep.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarEnderecoPorCep.IconColor = Color.FromArgb(30, 136, 229);
            btnBuscarEnderecoPorCep.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarEnderecoPorCep.IconSize = 30;
            btnBuscarEnderecoPorCep.Location = new Point(171, 316);
            btnBuscarEnderecoPorCep.Name = "btnBuscarEnderecoPorCep";
            btnBuscarEnderecoPorCep.Size = new Size(25, 25);
            btnBuscarEnderecoPorCep.TabIndex = 11;
            btnBuscarEnderecoPorCep.UseVisualStyleBackColor = false;
            btnBuscarEnderecoPorCep.Click += btnBuscarEnderecoPorCep_Click;
            // 
            // btnLocalizarCidade
            // 
            btnLocalizarCidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLocalizarCidade.BackColor = Color.Transparent;
            btnLocalizarCidade.FlatAppearance.BorderSize = 0;
            btnLocalizarCidade.FlatStyle = FlatStyle.Flat;
            btnLocalizarCidade.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnLocalizarCidade.IconColor = Color.FromArgb(30, 136, 229);
            btnLocalizarCidade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLocalizarCidade.IconSize = 30;
            btnLocalizarCidade.Location = new Point(516, 418);
            btnLocalizarCidade.Name = "btnLocalizarCidade";
            btnLocalizarCidade.Size = new Size(25, 25);
            btnLocalizarCidade.TabIndex = 1142;
            btnLocalizarCidade.TabStop = false;
            btnLocalizarCidade.UseVisualStyleBackColor = false;
            btnLocalizarCidade.Click += btnLocalizarCidade_Click;
            // 
            // FrmCadFornecedor
            // 
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(664, 645);
            ControlBox = false;
            Controls.Add(btnLocalizarCidade);
            Controls.Add(btnBuscarEnderecoPorCep);
            Controls.Add(dtpDataCriacao);
            Controls.Add(kryptonLabel1);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel4);
            Controls.Add(lblRotuloDtNascDtCriacao);
            Controls.Add(txtObservacoes);
            Controls.Add(txtTelefone);
            Controls.Add(txtCnpj);
            Controls.Add(label13);
            Controls.Add(txtEmail);
            Controls.Add(lblCnpj);
            Controls.Add(txtLogradouro);
            Controls.Add(label18);
            Controls.Add(txtNomeFornecedor);
            Controls.Add(txtFornecedorID);
            Controls.Add(label1);
            Controls.Add(lblIE);
            Controls.Add(label10);
            Controls.Add(label17);
            Controls.Add(txtIE);
            Controls.Add(pnlHeader);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(btnSair);
            Controls.Add(txtUF);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(label20);
            Controls.Add(kryptonStatusStrip1);
            Controls.Add(txtCep);
            Controls.Add(label14);
            Controls.Add(txtNumero);
            Controls.Add(txtCidade);
            Controls.Add(label15);
            Controls.Add(txtBairro);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadFornecedor";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            StateCommon.Back.Color1 = Color.White;
            StateCommon.Back.Color2 = Color.White;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "Cadastro de Fornecedor";
            WindowState = FormWindowState.Maximized;
            Load += FrmCadFornecedor_Load;
            Shown += FrmCadFornecedor_Shown;
            KeyDown += FrmCadFornecedor_KeyDown;
            kryptonStatusStrip1.ResumeLayout(false);
            kryptonStatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlHeader).EndInit();
            pnlHeader.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        public Krypton.Toolkit.KryptonTextBox txtTelefone;
        public Krypton.Toolkit.KryptonTextBox txtNomeFornecedor;
        public Krypton.Toolkit.KryptonTextBox txtFornecedorID;
        public Krypton.Toolkit.KryptonTextBox txtCidade;
        public Krypton.Toolkit.KryptonTextBox txtEmail;
        public Krypton.Toolkit.KryptonTextBox txtBairro;
        public Krypton.Toolkit.KryptonTextBox txtNumero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        public Krypton.Toolkit.KryptonTextBox txtUF;
        private System.Windows.Forms.Label label20;
        private Label label1;
        public Krypton.Toolkit.KryptonTextBox txtCep;
        private Label lblRotuloDtNascDtCriacao;
        public Krypton.Toolkit.KryptonTextBox txtDataNascimento;
        private Label lblIE;
        public Krypton.Toolkit.KryptonTextBox txtIE;
        public Krypton.Toolkit.KryptonTextBox txtObservacoes;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        public ToolStripStatusLabel toolStripStatusLabelUsuarioCriacao;
        private ToolStripStatusLabel toolStripStatusLabel2;
        public ToolStripStatusLabel ToolStripLabelDataCriacao;
        private ToolStripStatusLabel toolStripStatusLabel4;
        public ToolStripStatusLabel ToolStripLabelDataUtimaCompra;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabelUsuarioAtualizacao;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabelDataAtualizacao;
        public Krypton.Toolkit.KryptonTextBox txtCnpj;
        private Label lblCnpj;
        private Label label8;
        private ToolTip toolTip;
        public Krypton.Toolkit.KryptonButton btnSair;
        public Krypton.Toolkit.KryptonButton btnSalvar;
        public Krypton.Toolkit.KryptonButton btnNovo;
        public Krypton.Toolkit.KryptonTextBox txtLogradouro;
        private Krypton.Toolkit.KryptonPanel pnlHeader;
        private Krypton.Toolkit.KryptonTableLayoutPanel tlpTitulo;
        private Krypton.Toolkit.KryptonLabel lblSubTitulo;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        public Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        public Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        public Krypton.Toolkit.KryptonTextBox txtClienteID;
        public Krypton.Toolkit.KryptonTextBox txtRg;
        public Krypton.Toolkit.KryptonTextBox txtCpf;
        public Krypton.Toolkit.KryptonTextBox txtOrgaoExpedidorRG;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        public Krypton.Toolkit.KryptonDateTimePicker dtpDataCriacao;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private FontAwesome.Sharp.IconButton btnBuscarEnderecoPorCep;
        private FontAwesome.Sharp.IconButton btnLocalizarCidade;
    }
}
