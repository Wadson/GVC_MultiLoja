namespace GVC.View
{
    partial class FrmPagamentosParcela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagamentosParcela));
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            panelHeader = new Krypton.Toolkit.KryptonPanel();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            pnlResumo = new Krypton.Toolkit.KryptonPanel();
            lblStatusParcela = new Krypton.Toolkit.KryptonLabel();
            lblRStatus = new Krypton.Toolkit.KryptonLabel();
            lblNumeroParcela = new Krypton.Toolkit.KryptonLabel();
            lblRNumeroParcela = new Krypton.Toolkit.KryptonLabel();
            lblVencimento = new Krypton.Toolkit.KryptonLabel();
            lblVendaId = new Krypton.Toolkit.KryptonLabel();
            lblRVencimento = new Krypton.Toolkit.KryptonLabel();
            lblRNumeroVenda = new Krypton.Toolkit.KryptonLabel();
            lblNomeCliente = new Krypton.Toolkit.KryptonLabel();
            lblDataVenda = new Krypton.Toolkit.KryptonLabel();
            lblRNomeCliente = new Krypton.Toolkit.KryptonLabel();
            lblRDataVenda = new Krypton.Toolkit.KryptonLabel();
            flpAcoesParcela = new FlowLayoutPanel();
            btnFechar = new FontAwesome.Sharp.IconButton();
            btnGerarPdfParcela = new FontAwesome.Sharp.IconButton();
            btnGerarPdfPagamentos = new FontAwesome.Sharp.IconButton();
            lblPagamentosDaParcela = new Krypton.Toolkit.KryptonLabel();
            dgvPagamentos = new Krypton.Toolkit.KryptonDataGridView();
            pnlPagamentos = new Krypton.Toolkit.KryptonPanel();
            kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            pnlTotalPagamentos = new Krypton.Toolkit.KryptonPanel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            lblValorParcela = new Krypton.Toolkit.KryptonLabel();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            lblSaldo = new Krypton.Toolkit.KryptonLabel();
            pnlCard3 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            lblCard3Titulo = new Krypton.Toolkit.KryptonLabel();
            lblTotalRecebido = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)panelHeader).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlResumo).BeginInit();
            pnlResumo.SuspendLayout();
            flpAcoesParcela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPagamentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlPagamentos).BeginInit();
            pnlPagamentos.SuspendLayout();
            kryptonTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlTotalPagamentos).BeginInit();
            pnlTotalPagamentos.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            pnlCard3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
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
            // panelHeader
            // 
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(687, 30);
            panelHeader.StateCommon.Color1 = Color.FromArgb(30, 136, 229);
            panelHeader.StateCommon.Color2 = Color.FromArgb(30, 136, 229);
            panelHeader.TabIndex = 1113;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(687, 30);
            lblTitulo.StateCommon.ShortText.Color1 = Color.White;
            lblTitulo.StateCommon.ShortText.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTitulo.TabIndex = 2;
            lblTitulo.Values.Text = "Detalhe da Parcela Selecionada";
            // 
            // pnlResumo
            // 
            pnlResumo.Controls.Add(lblStatusParcela);
            pnlResumo.Controls.Add(lblRStatus);
            pnlResumo.Controls.Add(lblNumeroParcela);
            pnlResumo.Controls.Add(lblRNumeroParcela);
            pnlResumo.Controls.Add(lblVencimento);
            pnlResumo.Controls.Add(lblVendaId);
            pnlResumo.Controls.Add(lblRVencimento);
            pnlResumo.Controls.Add(lblRNumeroVenda);
            pnlResumo.Controls.Add(lblNomeCliente);
            pnlResumo.Controls.Add(lblDataVenda);
            pnlResumo.Controls.Add(lblRNomeCliente);
            pnlResumo.Controls.Add(lblRDataVenda);
            pnlResumo.Dock = DockStyle.Top;
            pnlResumo.Location = new Point(0, 30);
            pnlResumo.Name = "pnlResumo";
            pnlResumo.Size = new Size(687, 104);
            pnlResumo.StateCommon.Color1 = Color.White;
            pnlResumo.StateCommon.Color2 = Color.White;
            pnlResumo.TabIndex = 1115;
            // 
            // lblStatusParcela
            // 
            lblStatusParcela.Location = new Point(126, 73);
            lblStatusParcela.Name = "lblStatusParcela";
            lblStatusParcela.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            lblStatusParcela.Size = new Size(60, 28);
            lblStatusParcela.StateCommon.ShortText.Color1 = Color.FromArgb(0, 76, 172);
            lblStatusParcela.StateCommon.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStatusParcela.TabIndex = 208;
            lblStatusParcela.Values.Text = "Status";
            // 
            // lblRStatus
            // 
            lblRStatus.Location = new Point(57, 73);
            lblRStatus.Name = "lblRStatus";
            lblRStatus.Size = new Size(65, 26);
            lblRStatus.StateCommon.ShortText.Color1 = Color.FromArgb(0, 76, 172);
            lblRStatus.StateCommon.ShortText.Font = new Font("Segoe UI", 12F);
            lblRStatus.TabIndex = 207;
            lblRStatus.Values.Text = " Status:";
            // 
            // lblNumeroParcela
            // 
            lblNumeroParcela.Location = new Point(623, 3);
            lblNumeroParcela.Name = "lblNumeroParcela";
            lblNumeroParcela.Size = new Size(37, 22);
            lblNumeroParcela.StateCommon.ShortText.Color1 = Color.FromArgb(0, 76, 172);
            lblNumeroParcela.StateCommon.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            lblNumeroParcela.TabIndex = 206;
            lblNumeroParcela.Values.Text = "000";
            // 
            // lblRNumeroParcela
            // 
            lblRNumeroParcela.Location = new Point(536, 3);
            lblRNumeroParcela.Name = "lblRNumeroParcela";
            lblRNumeroParcela.Size = new Size(83, 22);
            lblRNumeroParcela.StateCommon.ShortText.Color1 = Color.FromArgb(0, 76, 172);
            lblRNumeroParcela.StateCommon.ShortText.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRNumeroParcela.TabIndex = 205;
            lblRNumeroParcela.Values.Text = "Nº Parcela:";
            // 
            // lblVencimento
            // 
            lblVencimento.Location = new Point(126, 55);
            lblVencimento.Name = "lblVencimento";
            lblVencimento.Size = new Size(81, 22);
            lblVencimento.StateCommon.ShortText.Color1 = Color.FromArgb(0, 76, 172);
            lblVencimento.StateCommon.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblVencimento.TabIndex = 206;
            lblVencimento.Values.Text = "01/01/1999";
            // 
            // lblVendaId
            // 
            lblVendaId.Location = new Point(473, 3);
            lblVendaId.Name = "lblVendaId";
            lblVendaId.Size = new Size(37, 22);
            lblVendaId.StateCommon.ShortText.Color1 = Color.FromArgb(0, 76, 172);
            lblVendaId.StateCommon.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            lblVendaId.TabIndex = 204;
            lblVendaId.Values.Text = "000";
            // 
            // lblRVencimento
            // 
            lblRVencimento.Location = new Point(33, 55);
            lblRVencimento.Name = "lblRVencimento";
            lblRVencimento.Size = new Size(95, 22);
            lblRVencimento.StateCommon.ShortText.Color1 = Color.FromArgb(0, 76, 172);
            lblRVencimento.StateCommon.ShortText.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRVencimento.TabIndex = 205;
            lblRVencimento.Values.Text = "Vencimento:";
            // 
            // lblRNumeroVenda
            // 
            lblRNumeroVenda.Location = new Point(398, 3);
            lblRNumeroVenda.Name = "lblRNumeroVenda";
            lblRNumeroVenda.Size = new Size(77, 22);
            lblRNumeroVenda.StateCommon.ShortText.Color1 = Color.FromArgb(0, 76, 172);
            lblRNumeroVenda.StateCommon.ShortText.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRNumeroVenda.TabIndex = 203;
            lblRNumeroVenda.Values.Text = "Venda Nº:";
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.Location = new Point(126, 3);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(115, 22);
            lblNomeCliente.StateCommon.ShortText.Color1 = Color.FromArgb(0, 76, 172);
            lblNomeCliente.StateCommon.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            lblNomeCliente.TabIndex = 202;
            lblNomeCliente.Values.Text = "lblNomeCliente";
            // 
            // lblDataVenda
            // 
            lblDataVenda.Location = new Point(126, 32);
            lblDataVenda.Name = "lblDataVenda";
            lblDataVenda.Size = new Size(81, 22);
            lblDataVenda.StateCommon.ShortText.Color1 = Color.FromArgb(0, 76, 172);
            lblDataVenda.StateCommon.ShortText.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDataVenda.TabIndex = 204;
            lblDataVenda.Values.Text = "01/01/1999";
            // 
            // lblRNomeCliente
            // 
            lblRNomeCliente.Location = new Point(2, 3);
            lblRNomeCliente.Name = "lblRNomeCliente";
            lblRNomeCliente.Size = new Size(123, 22);
            lblRNomeCliente.StateCommon.ShortText.Color1 = Color.FromArgb(0, 76, 172);
            lblRNomeCliente.StateCommon.ShortText.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRNomeCliente.TabIndex = 201;
            lblRNomeCliente.Values.Text = "Nome do cliente:";
            // 
            // lblRDataVenda
            // 
            lblRDataVenda.Location = new Point(31, 32);
            lblRDataVenda.Name = "lblRDataVenda";
            lblRDataVenda.Size = new Size(94, 22);
            lblRDataVenda.StateCommon.ShortText.Color1 = Color.FromArgb(0, 76, 172);
            lblRDataVenda.StateCommon.ShortText.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRDataVenda.TabIndex = 203;
            lblRDataVenda.Values.Text = "Data Venda:";
            // 
            // flpAcoesParcela
            // 
            flpAcoesParcela.Controls.Add(btnFechar);
            flpAcoesParcela.Controls.Add(btnGerarPdfParcela);
            flpAcoesParcela.Controls.Add(btnGerarPdfPagamentos);
            flpAcoesParcela.Dock = DockStyle.Bottom;
            flpAcoesParcela.FlowDirection = FlowDirection.RightToLeft;
            flpAcoesParcela.Location = new Point(0, 452);
            flpAcoesParcela.Name = "flpAcoesParcela";
            flpAcoesParcela.Size = new Size(687, 41);
            flpAcoesParcela.TabIndex = 1073;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Gray;
            btnFechar.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnFechar.ForeColor = Color.White;
            btnFechar.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnFechar.IconColor = Color.White;
            btnFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFechar.IconSize = 28;
            btnFechar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFechar.Location = new Point(564, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.Padding = new Padding(10, 0, 10, 0);
            btnFechar.Size = new Size(120, 38);
            btnFechar.TabIndex = 1121;
            btnFechar.Text = "Sair";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnGerarPdfParcela
            // 
            btnGerarPdfParcela.BackColor = Color.White;
            btnGerarPdfParcela.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnGerarPdfParcela.ForeColor = Color.FromArgb(0, 76, 172);
            btnGerarPdfParcela.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnGerarPdfParcela.IconColor = Color.Red;
            btnGerarPdfParcela.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGerarPdfParcela.IconSize = 28;
            btnGerarPdfParcela.ImageAlign = ContentAlignment.MiddleLeft;
            btnGerarPdfParcela.Location = new Point(388, 3);
            btnGerarPdfParcela.Name = "btnGerarPdfParcela";
            btnGerarPdfParcela.Padding = new Padding(10, 0, 10, 0);
            btnGerarPdfParcela.Size = new Size(170, 38);
            btnGerarPdfParcela.TabIndex = 1131;
            btnGerarPdfParcela.Text = "  PDF Parcela";
            btnGerarPdfParcela.UseVisualStyleBackColor = false;
            btnGerarPdfParcela.Click += btnGerarPdf_Click;
            // 
            // btnGerarPdfPagamentos
            // 
            btnGerarPdfPagamentos.BackColor = Color.White;
            btnGerarPdfPagamentos.Font = new Font("Poppins Medium", 8.25F, FontStyle.Bold);
            btnGerarPdfPagamentos.ForeColor = Color.FromArgb(0, 76, 172);
            btnGerarPdfPagamentos.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnGerarPdfPagamentos.IconColor = Color.Red;
            btnGerarPdfPagamentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGerarPdfPagamentos.IconSize = 28;
            btnGerarPdfPagamentos.ImageAlign = ContentAlignment.MiddleLeft;
            btnGerarPdfPagamentos.Location = new Point(212, 3);
            btnGerarPdfPagamentos.Name = "btnGerarPdfPagamentos";
            btnGerarPdfPagamentos.Padding = new Padding(10, 0, 10, 0);
            btnGerarPdfPagamentos.Size = new Size(170, 38);
            btnGerarPdfPagamentos.TabIndex = 1132;
            btnGerarPdfPagamentos.Text = "      PDF Pagamentos";
            btnGerarPdfPagamentos.UseVisualStyleBackColor = false;
            // 
            // lblPagamentosDaParcela
            // 
            lblPagamentosDaParcela.Dock = DockStyle.Fill;
            lblPagamentosDaParcela.Location = new Point(3, 3);
            lblPagamentosDaParcela.Name = "lblPagamentosDaParcela";
            lblPagamentosDaParcela.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            lblPagamentosDaParcela.Size = new Size(675, 17);
            lblPagamentosDaParcela.StateCommon.ShortText.Color1 = Color.FromArgb(0, 76, 172);
            lblPagamentosDaParcela.StateCommon.ShortText.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPagamentosDaParcela.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblPagamentosDaParcela.TabIndex = 0;
            lblPagamentosDaParcela.Values.Text = "Pagamentos da Parcela";
            // 
            // dgvPagamentos
            // 
            dgvPagamentos.Dock = DockStyle.Fill;
            dgvPagamentos.Location = new Point(3, 26);
            dgvPagamentos.Name = "dgvPagamentos";
            dgvPagamentos.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueDarkMode;
            dgvPagamentos.Size = new Size(675, 165);
            dgvPagamentos.TabIndex = 1071;
            dgvPagamentos.CellFormatting += dgvItensVenda_CellFormatting;
            // 
            // pnlPagamentos
            // 
            pnlPagamentos.Controls.Add(kryptonTableLayoutPanel1);
            pnlPagamentos.Dock = DockStyle.Top;
            pnlPagamentos.Location = new Point(0, 134);
            pnlPagamentos.Name = "pnlPagamentos";
            pnlPagamentos.Padding = new Padding(3);
            pnlPagamentos.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            pnlPagamentos.Size = new Size(687, 200);
            pnlPagamentos.TabIndex = 1116;
            // 
            // kryptonTableLayoutPanel1
            // 
            kryptonTableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("kryptonTableLayoutPanel1.BackgroundImage");
            kryptonTableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            kryptonTableLayoutPanel1.ColumnCount = 1;
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            kryptonTableLayoutPanel1.Controls.Add(lblPagamentosDaParcela, 0, 0);
            kryptonTableLayoutPanel1.Controls.Add(dgvPagamentos, 0, 1);
            kryptonTableLayoutPanel1.Dock = DockStyle.Fill;
            kryptonTableLayoutPanel1.Location = new Point(3, 3);
            kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            kryptonTableLayoutPanel1.RowCount = 2;
            kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.0192308F));
            kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.98077F));
            kryptonTableLayoutPanel1.Size = new Size(681, 194);
            kryptonTableLayoutPanel1.TabIndex = 0;
            // 
            // pnlTotalPagamentos
            // 
            pnlTotalPagamentos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlTotalPagamentos.Controls.Add(panel2);
            pnlTotalPagamentos.Controls.Add(panel1);
            pnlTotalPagamentos.Controls.Add(pnlCard3);
            pnlTotalPagamentos.Location = new Point(1, 349);
            pnlTotalPagamentos.Name = "pnlTotalPagamentos";
            pnlTotalPagamentos.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            pnlTotalPagamentos.Size = new Size(683, 82);
            pnlTotalPagamentos.TabIndex = 1117;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Location = new Point(2, 1);
            panel2.Margin = new Padding(8);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 80);
            panel2.TabIndex = 213;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(iconPictureBox2, 0, 0);
            tableLayoutPanel2.Controls.Add(kryptonLabel2, 1, 0);
            tableLayoutPanel2.Controls.Add(lblValorParcela, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(158, 78);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.Dock = DockStyle.Fill;
            iconPictureBox2.ForeColor = Color.FromArgb(0, 76, 172);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            iconPictureBox2.IconColor = Color.FromArgb(0, 76, 172);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 30;
            iconPictureBox2.Location = new Point(3, 3);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(35, 30);
            iconPictureBox2.TabIndex = 0;
            iconPictureBox2.TabStop = false;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Dock = DockStyle.Fill;
            kryptonLabel2.Location = new Point(44, 3);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Black;
            kryptonLabel2.Size = new Size(111, 30);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.DimGray;
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.DimGray;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 3;
            kryptonLabel2.Values.Text = "Valor da Parcela";
            // 
            // lblValorParcela
            // 
            tableLayoutPanel2.SetColumnSpan(lblValorParcela, 2);
            lblValorParcela.Dock = DockStyle.Top;
            lblValorParcela.Location = new Point(3, 39);
            lblValorParcela.Name = "lblValorParcela";
            lblValorParcela.PaletteMode = Krypton.Toolkit.PaletteMode.Office365SilverLightMode;
            lblValorParcela.Size = new Size(152, 34);
            lblValorParcela.StateCommon.ShortText.Color1 = Color.FromArgb(0, 76, 172);
            lblValorParcela.StateCommon.ShortText.Color2 = Color.FromArgb(0, 76, 172);
            lblValorParcela.StateCommon.ShortText.Font = new Font("Segoe UI Semibold", 16.25F, FontStyle.Bold);
            lblValorParcela.TabIndex = 3;
            lblValorParcela.Values.Text = "R$ 0,00";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(328, 1);
            panel1.Margin = new Padding(8);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 80);
            panel1.TabIndex = 212;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(iconPictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(kryptonLabel1, 1, 0);
            tableLayoutPanel1.Controls.Add(lblSaldo, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(158, 78);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.Dock = DockStyle.Fill;
            iconPictureBox1.ForeColor = Color.Red;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            iconPictureBox1.IconColor = Color.Red;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(3, 3);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(33, 32);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Dock = DockStyle.Fill;
            kryptonLabel1.Location = new Point(42, 3);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Black;
            kryptonLabel1.Size = new Size(113, 32);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.DimGray;
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.DimGray;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 3;
            kryptonLabel1.Values.Text = "Saldo Devedor";
            // 
            // lblSaldo
            // 
            tableLayoutPanel1.SetColumnSpan(lblSaldo, 2);
            lblSaldo.Dock = DockStyle.Top;
            lblSaldo.Location = new Point(3, 41);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.PaletteMode = Krypton.Toolkit.PaletteMode.Office365SilverLightMode;
            lblSaldo.Size = new Size(152, 34);
            lblSaldo.StateCommon.ShortText.Color1 = Color.Red;
            lblSaldo.StateCommon.ShortText.Color2 = Color.Red;
            lblSaldo.StateCommon.ShortText.Font = new Font("Segoe UI Semibold", 16.25F, FontStyle.Bold);
            lblSaldo.TabIndex = 3;
            lblSaldo.Values.Text = "R$ 0,00";
            // 
            // pnlCard3
            // 
            pnlCard3.BorderStyle = BorderStyle.FixedSingle;
            pnlCard3.Controls.Add(tableLayoutPanel4);
            pnlCard3.Location = new Point(165, 1);
            pnlCard3.Margin = new Padding(8);
            pnlCard3.Name = "pnlCard3";
            pnlCard3.Size = new Size(160, 80);
            pnlCard3.TabIndex = 211;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(iconPictureBox3, 0, 0);
            tableLayoutPanel4.Controls.Add(lblCard3Titulo, 1, 0);
            tableLayoutPanel4.Controls.Add(lblTotalRecebido, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(158, 78);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.White;
            iconPictureBox3.Dock = DockStyle.Fill;
            iconPictureBox3.ForeColor = Color.Green;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            iconPictureBox3.IconColor = Color.Green;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.Location = new Point(3, 3);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(37, 32);
            iconPictureBox3.TabIndex = 0;
            iconPictureBox3.TabStop = false;
            // 
            // lblCard3Titulo
            // 
            lblCard3Titulo.Dock = DockStyle.Fill;
            lblCard3Titulo.Location = new Point(46, 3);
            lblCard3Titulo.Name = "lblCard3Titulo";
            lblCard3Titulo.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Black;
            lblCard3Titulo.Size = new Size(109, 32);
            lblCard3Titulo.StateCommon.ShortText.Color1 = Color.DimGray;
            lblCard3Titulo.StateCommon.ShortText.Color2 = Color.DimGray;
            lblCard3Titulo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCard3Titulo.TabIndex = 3;
            lblCard3Titulo.Values.Text = "Total Pago";
            // 
            // lblTotalRecebido
            // 
            tableLayoutPanel4.SetColumnSpan(lblTotalRecebido, 2);
            lblTotalRecebido.Dock = DockStyle.Top;
            lblTotalRecebido.Location = new Point(3, 41);
            lblTotalRecebido.Name = "lblTotalRecebido";
            lblTotalRecebido.PaletteMode = Krypton.Toolkit.PaletteMode.Office365SilverLightMode;
            lblTotalRecebido.Size = new Size(152, 34);
            lblTotalRecebido.StateCommon.ShortText.Color1 = Color.DarkGreen;
            lblTotalRecebido.StateCommon.ShortText.Color2 = Color.DarkGreen;
            lblTotalRecebido.StateCommon.ShortText.Font = new Font("Segoe UI Semibold", 16.25F, FontStyle.Bold);
            lblTotalRecebido.TabIndex = 3;
            lblTotalRecebido.Values.Text = "R$ 0,00";
            // 
            // FrmPagamentosParcela
            // 
            BackColor = Color.FromArgb(250, 252, 252);
            ClientSize = new Size(687, 493);
            Controls.Add(pnlTotalPagamentos);
            Controls.Add(pnlPagamentos);
            Controls.Add(pnlResumo);
            Controls.Add(panelHeader);
            Controls.Add(flpAcoesParcela);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPagamentosParcela";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "Pagamentos da Parcela";
            Load += FrmItensVenda_Load;
            ((System.ComponentModel.ISupportInitialize)panelHeader).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlResumo).EndInit();
            pnlResumo.ResumeLayout(false);
            pnlResumo.PerformLayout();
            flpAcoesParcela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPagamentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlPagamentos).EndInit();
            pnlPagamentos.ResumeLayout(false);
            kryptonTableLayoutPanel1.ResumeLayout(false);
            kryptonTableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlTotalPagamentos).EndInit();
            pnlTotalPagamentos.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            pnlCard3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblRotulo;
      
        private Krypton.Toolkit.KryptonButton btnLocalBackup;
        private Krypton.Toolkit.KryptonButton btnExecutar;       
        private Krypton.Toolkit.KryptonRadioButton rbtGerarBackup;
        private Krypton.Toolkit.KryptonRadioButton rbtRestaurarBackup;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        private ToolStripStatusLabel lblMensagem;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonPanel panelHeader;
        private FlowLayoutPanel flpAcoesParcela;
        private Krypton.Toolkit.KryptonButton btnSair;
        private FontAwesome.Sharp.IconButton btnFechar;
        private FontAwesome.Sharp.IconButton btnGerarPdfParcela;
        private Krypton.Toolkit.KryptonLabel lblPagamentosDaParcela;
        private Krypton.Toolkit.KryptonPanel pnlResumo;
       
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private Krypton.Toolkit.KryptonLabel lblRStatus;
        private Krypton.Toolkit.KryptonLabel lblNumeroParcela;
        private Krypton.Toolkit.KryptonLabel lblRNumeroParcela;
        private Krypton.Toolkit.KryptonLabel lblVendaId;
        private Krypton.Toolkit.KryptonLabel lblRNumeroVenda;
        private Krypton.Toolkit.KryptonLabel lblNomeCliente;
        private Krypton.Toolkit.KryptonLabel lblRNomeCliente;
        private Krypton.Toolkit.KryptonLabel lblStatusParcela;
        private Krypton.Toolkit.KryptonDataGridView dgvPagamentos;
        private Krypton.Toolkit.KryptonPanel pnlPagamentos;
        private Krypton.Toolkit.KryptonLabel lblRDataVenda;
        private Krypton.Toolkit.KryptonLabel lblDataVenda;
        private Krypton.Toolkit.KryptonLabel lblRVencimento;
        private Krypton.Toolkit.KryptonLabel lblVencimento;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
        private Krypton.Toolkit.KryptonPanel pnlTotalPagamentos;
        private Panel pnlCard3;
        private TableLayoutPanel tableLayoutPanel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Krypton.Toolkit.KryptonLabel lblCard3Titulo;
        private Krypton.Toolkit.KryptonLabel lblTotalRecebido;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel lblSaldo;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel lblValorParcela;
        private FontAwesome.Sharp.IconButton btnGerarPdfPagamentos;
    }
}
