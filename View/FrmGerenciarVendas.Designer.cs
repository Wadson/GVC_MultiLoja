namespace GVC.View
{
    partial class FrmGerenciarVendas
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
            lblStatus = new ToolStripStatusLabel();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            toolTip = new ToolTip(components);
            Timer1 = new System.Windows.Forms.Timer(components);
            txtCliente = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloNome = new Label();
            lblRotuloVendaID = new Label();
            txtVendaID = new Krypton.Toolkit.KryptonTextBox();
            btnSair = new Krypton.Toolkit.KryptonButton();
            btnExcluirVenda = new Krypton.Toolkit.KryptonButton();
            btnVisualizarVenda = new Krypton.Toolkit.KryptonButton();
            btnAlterarVenda = new Krypton.Toolkit.KryptonButton();
            dtpDataInicio = new Krypton.Toolkit.KryptonDateTimePicker();
            dtpDataFim = new Krypton.Toolkit.KryptonDateTimePicker();
            lblRotuloDataInicio = new Label();
            lblRotuloDataFim = new Label();
            btnBuscar = new Krypton.Toolkit.KryptonButton();
            dgvVendas = new Krypton.Toolkit.KryptonDataGridView();
            btnCancelarVenda = new Krypton.Toolkit.KryptonButton();
            btnLocalizarCliente = new Krypton.Toolkit.KryptonButton();
            tableLayoutPanelGerenciamentoVendas = new TableLayoutPanel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            lblTituloPDV = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            kryptonStatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendas).BeginInit();
            tableLayoutPanelGerenciamentoVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            kryptonPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelUsuarioCriacao, toolStripStatusLabel2, ToolStripLabelDataCriacao, toolStripStatusLabel4, ToolStripLabelDataUtimaCompra, toolStripStatusLabel1, toolStripStatusLabelUsuarioAtualizacao, toolStripStatusLabel3, toolStripStatusLabelDataAtualizacao, lblStatus });
            kryptonStatusStrip1.Location = new Point(0, 428);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            kryptonStatusStrip1.Size = new Size(927, 22);
            kryptonStatusStrip1.TabIndex = 1028;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // toolStripStatusLabelUsuarioCriacao
            // 
            toolStripStatusLabelUsuarioCriacao.ForeColor = Color.White;
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
            ToolStripLabelDataCriacao.ForeColor = Color.White;
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
            ToolStripLabelDataUtimaCompra.ForeColor = Color.White;
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
            toolStripStatusLabelDataAtualizacao.Name = "toolStripStatusLabelDataAtualizacao";
            toolStripStatusLabelDataAtualizacao.Size = new Size(95, 17);
            toolStripStatusLabelDataAtualizacao.Text = "Data Atualização";
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.FromArgb(0, 192, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 17);
            lblStatus.Text = "Status";
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
            // Timer1
            // 
            Timer1.Enabled = true;
            Timer1.Interval = 1000;
            // 
            // txtCliente
            // 
            txtCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCliente.CharacterCasing = CharacterCasing.Upper;
            txtCliente.Location = new Point(114, 31);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(496, 27);
            txtCliente.StateCommon.Back.Color1 = Color.White;
            txtCliente.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtCliente.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtCliente.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtCliente.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtCliente.StateCommon.Border.Rounding = 8F;
            txtCliente.StateCommon.Border.Width = 1;
            txtCliente.StateCommon.Content.Color1 = Color.Gray;
            txtCliente.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtCliente.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtCliente.TabIndex = 1029;
            // 
            // lblRotuloNome
            // 
            lblRotuloNome.AutoSize = true;
            lblRotuloNome.BackColor = Color.Transparent;
            lblRotuloNome.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloNome.ForeColor = Color.Navy;
            lblRotuloNome.Location = new Point(120, 10);
            lblRotuloNome.Name = "lblRotuloNome";
            lblRotuloNome.Size = new Size(112, 16);
            lblRotuloNome.TabIndex = 1030;
            lblRotuloNome.Text = "Nome do cliente?";
            // 
            // lblRotuloVendaID
            // 
            lblRotuloVendaID.AutoSize = true;
            lblRotuloVendaID.BackColor = Color.Transparent;
            lblRotuloVendaID.ForeColor = Color.Navy;
            lblRotuloVendaID.Location = new Point(2, 11);
            lblRotuloVendaID.Name = "lblRotuloVendaID";
            lblRotuloVendaID.Size = new Size(102, 15);
            lblRotuloVendaID.TabIndex = 1031;
            lblRotuloVendaID.Text = "Código da Venda?";
            // 
            // txtVendaID
            // 
            txtVendaID.Location = new Point(2, 31);
            txtVendaID.Name = "txtVendaID";
            txtVendaID.Size = new Size(102, 27);
            txtVendaID.StateCommon.Back.Color1 = Color.White;
            txtVendaID.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtVendaID.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtVendaID.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtVendaID.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtVendaID.StateCommon.Border.Rounding = 8F;
            txtVendaID.StateCommon.Border.Width = 1;
            txtVendaID.StateCommon.Content.Color1 = Color.Gray;
            txtVendaID.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtVendaID.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtVendaID.TabIndex = 1032;
            txtVendaID.TabStop = false;
            txtVendaID.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSair.CornerRoundingRadius = 10F;
            btnSair.Location = new Point(811, 0);
            btnSair.Margin = new Padding(5, 3, 5, 3);
            btnSair.Name = "btnSair";
            btnSair.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Back.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Border.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.OverrideDefault.Border.Rounding = 20F;
            btnSair.OverrideDefault.Border.Width = 1;
            btnSair.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSair.Size = new Size(100, 27);
            btnSair.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Back.ColorAngle = 45F;
            btnSair.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateCommon.Border.Rounding = 10F;
            btnSair.StateCommon.Border.Width = 1;
            btnSair.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSair.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSair.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
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
            btnSair.TabIndex = 1035;
            btnSair.Values.Text = "&Sair";
            btnSair.Click += btnSair_Click;
            // 
            // btnExcluirVenda
            // 
            btnExcluirVenda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExcluirVenda.CornerRoundingRadius = 10F;
            btnExcluirVenda.Location = new Point(711, 0);
            btnExcluirVenda.Margin = new Padding(5, 3, 5, 3);
            btnExcluirVenda.Name = "btnExcluirVenda";
            btnExcluirVenda.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnExcluirVenda.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnExcluirVenda.OverrideDefault.Back.ColorAngle = 45F;
            btnExcluirVenda.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExcluirVenda.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExcluirVenda.OverrideDefault.Border.ColorAngle = 45F;
            btnExcluirVenda.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluirVenda.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExcluirVenda.OverrideDefault.Border.Rounding = 20F;
            btnExcluirVenda.OverrideDefault.Border.Width = 1;
            btnExcluirVenda.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnExcluirVenda.Size = new Size(100, 27);
            btnExcluirVenda.StateCommon.Back.Color1 = Color.Red;
            btnExcluirVenda.StateCommon.Back.Color2 = Color.Red;
            btnExcluirVenda.StateCommon.Back.ColorAngle = 45F;
            btnExcluirVenda.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExcluirVenda.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExcluirVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluirVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExcluirVenda.StateCommon.Border.Rounding = 10F;
            btnExcluirVenda.StateCommon.Border.Width = 1;
            btnExcluirVenda.StateCommon.Content.ShortText.Color1 = Color.White;
            btnExcluirVenda.StateCommon.Content.ShortText.Color2 = Color.White;
            btnExcluirVenda.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnExcluirVenda.StateNormal.Back.Color1 = Color.Red;
            btnExcluirVenda.StateNormal.Back.Color2 = Color.Red;
            btnExcluirVenda.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnExcluirVenda.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnExcluirVenda.StatePressed.Back.ColorAngle = 135F;
            btnExcluirVenda.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnExcluirVenda.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnExcluirVenda.StatePressed.Border.ColorAngle = 135F;
            btnExcluirVenda.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluirVenda.StatePressed.Border.Rounding = 20F;
            btnExcluirVenda.StatePressed.Border.Width = 1;
            btnExcluirVenda.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnExcluirVenda.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnExcluirVenda.StateTracking.Back.ColorAngle = 45F;
            btnExcluirVenda.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExcluirVenda.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExcluirVenda.StateTracking.Border.ColorAngle = 45F;
            btnExcluirVenda.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluirVenda.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExcluirVenda.StateTracking.Border.Rounding = 20F;
            btnExcluirVenda.StateTracking.Border.Width = 1;
            btnExcluirVenda.TabIndex = 1033;
            btnExcluirVenda.Values.Text = "&Excluir";
            btnExcluirVenda.Click += btnExcluir_Click;
            // 
            // btnVisualizarVenda
            // 
            btnVisualizarVenda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVisualizarVenda.CornerRoundingRadius = 10F;
            btnVisualizarVenda.Location = new Point(411, 0);
            btnVisualizarVenda.Margin = new Padding(5, 3, 5, 3);
            btnVisualizarVenda.Name = "btnVisualizarVenda";
            btnVisualizarVenda.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnVisualizarVenda.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnVisualizarVenda.OverrideDefault.Back.ColorAngle = 45F;
            btnVisualizarVenda.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnVisualizarVenda.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnVisualizarVenda.OverrideDefault.Border.ColorAngle = 45F;
            btnVisualizarVenda.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnVisualizarVenda.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnVisualizarVenda.OverrideDefault.Border.Rounding = 20F;
            btnVisualizarVenda.OverrideDefault.Border.Width = 1;
            btnVisualizarVenda.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnVisualizarVenda.Size = new Size(100, 27);
            btnVisualizarVenda.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnVisualizarVenda.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnVisualizarVenda.StateCommon.Back.ColorAngle = 45F;
            btnVisualizarVenda.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnVisualizarVenda.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnVisualizarVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnVisualizarVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnVisualizarVenda.StateCommon.Border.Rounding = 10F;
            btnVisualizarVenda.StateCommon.Border.Width = 1;
            btnVisualizarVenda.StateCommon.Content.ShortText.Color1 = Color.White;
            btnVisualizarVenda.StateCommon.Content.ShortText.Color2 = Color.White;
            btnVisualizarVenda.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnVisualizarVenda.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnVisualizarVenda.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnVisualizarVenda.StatePressed.Back.ColorAngle = 135F;
            btnVisualizarVenda.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnVisualizarVenda.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnVisualizarVenda.StatePressed.Border.ColorAngle = 135F;
            btnVisualizarVenda.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnVisualizarVenda.StatePressed.Border.Rounding = 20F;
            btnVisualizarVenda.StatePressed.Border.Width = 1;
            btnVisualizarVenda.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnVisualizarVenda.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnVisualizarVenda.StateTracking.Back.ColorAngle = 45F;
            btnVisualizarVenda.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnVisualizarVenda.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnVisualizarVenda.StateTracking.Border.ColorAngle = 45F;
            btnVisualizarVenda.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnVisualizarVenda.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnVisualizarVenda.StateTracking.Border.Rounding = 20F;
            btnVisualizarVenda.StateTracking.Border.Width = 1;
            btnVisualizarVenda.TabIndex = 1036;
            btnVisualizarVenda.Values.Text = "&Visualizar";
            btnVisualizarVenda.Click += btnVisualizar_Click;
            // 
            // btnAlterarVenda
            // 
            btnAlterarVenda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAlterarVenda.CornerRoundingRadius = 10F;
            btnAlterarVenda.Location = new Point(511, 0);
            btnAlterarVenda.Margin = new Padding(5, 3, 5, 3);
            btnAlterarVenda.Name = "btnAlterarVenda";
            btnAlterarVenda.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnAlterarVenda.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnAlterarVenda.OverrideDefault.Back.ColorAngle = 45F;
            btnAlterarVenda.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnAlterarVenda.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAlterarVenda.OverrideDefault.Border.ColorAngle = 45F;
            btnAlterarVenda.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAlterarVenda.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAlterarVenda.OverrideDefault.Border.Rounding = 20F;
            btnAlterarVenda.OverrideDefault.Border.Width = 1;
            btnAlterarVenda.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnAlterarVenda.Size = new Size(100, 27);
            btnAlterarVenda.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnAlterarVenda.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnAlterarVenda.StateCommon.Back.ColorAngle = 45F;
            btnAlterarVenda.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAlterarVenda.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAlterarVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAlterarVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAlterarVenda.StateCommon.Border.Rounding = 10F;
            btnAlterarVenda.StateCommon.Border.Width = 1;
            btnAlterarVenda.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnAlterarVenda.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAlterarVenda.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnAlterarVenda.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnAlterarVenda.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnAlterarVenda.StatePressed.Back.ColorAngle = 135F;
            btnAlterarVenda.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnAlterarVenda.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnAlterarVenda.StatePressed.Border.ColorAngle = 135F;
            btnAlterarVenda.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAlterarVenda.StatePressed.Border.Rounding = 20F;
            btnAlterarVenda.StatePressed.Border.Width = 1;
            btnAlterarVenda.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnAlterarVenda.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnAlterarVenda.StateTracking.Back.ColorAngle = 45F;
            btnAlterarVenda.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAlterarVenda.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAlterarVenda.StateTracking.Border.ColorAngle = 45F;
            btnAlterarVenda.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAlterarVenda.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAlterarVenda.StateTracking.Border.Rounding = 20F;
            btnAlterarVenda.StateTracking.Border.Width = 1;
            btnAlterarVenda.StateTracking.Content.ShortText.Color1 = Color.White;
            btnAlterarVenda.TabIndex = 1034;
            btnAlterarVenda.Values.Text = "&Alterar";
            btnAlterarVenda.Click += btnAlterar_Click;
            // 
            // dtpDataInicio
            // 
            dtpDataInicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDataInicio.CornerRoundingRadius = 8F;
            dtpDataInicio.Format = DateTimePickerFormat.Short;
            dtpDataInicio.Location = new Point(653, 31);
            dtpDataInicio.Name = "dtpDataInicio";
            dtpDataInicio.Size = new Size(110, 27);
            dtpDataInicio.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataInicio.StateCommon.Border.Rounding = 8F;
            dtpDataInicio.TabIndex = 1037;
            // 
            // dtpDataFim
            // 
            dtpDataFim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDataFim.CornerRoundingRadius = 8F;
            dtpDataFim.Format = DateTimePickerFormat.Short;
            dtpDataFim.Location = new Point(768, 31);
            dtpDataFim.Name = "dtpDataFim";
            dtpDataFim.Size = new Size(110, 27);
            dtpDataFim.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataFim.StateCommon.Border.Rounding = 8F;
            dtpDataFim.TabIndex = 1038;
            // 
            // lblRotuloDataInicio
            // 
            lblRotuloDataInicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRotuloDataInicio.AutoSize = true;
            lblRotuloDataInicio.BackColor = Color.Transparent;
            lblRotuloDataInicio.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloDataInicio.ForeColor = Color.Navy;
            lblRotuloDataInicio.Location = new Point(653, 11);
            lblRotuloDataInicio.Name = "lblRotuloDataInicio";
            lblRotuloDataInicio.Size = new Size(70, 16);
            lblRotuloDataInicio.TabIndex = 1039;
            lblRotuloDataInicio.Text = "Data Inicio";
            // 
            // lblRotuloDataFim
            // 
            lblRotuloDataFim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRotuloDataFim.AutoSize = true;
            lblRotuloDataFim.BackColor = Color.Transparent;
            lblRotuloDataFim.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloDataFim.ForeColor = Color.Navy;
            lblRotuloDataFim.Location = new Point(768, 9);
            lblRotuloDataFim.Name = "lblRotuloDataFim";
            lblRotuloDataFim.Size = new Size(61, 16);
            lblRotuloDataFim.TabIndex = 1040;
            lblRotuloDataFim.Text = "Data Fim";
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.CornerRoundingRadius = 10F;
            btnBuscar.Location = new Point(884, 29);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnBuscar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnBuscar.OverrideDefault.Back.ColorAngle = 45F;
            btnBuscar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnBuscar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBuscar.OverrideDefault.Border.ColorAngle = 45F;
            btnBuscar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBuscar.OverrideDefault.Border.Rounding = 20F;
            btnBuscar.OverrideDefault.Border.Width = 1;
            btnBuscar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnBuscar.Size = new Size(30, 29);
            btnBuscar.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnBuscar.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnBuscar.StateCommon.Back.ColorAngle = 45F;
            btnBuscar.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            btnBuscar.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnBuscar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBuscar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBuscar.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopLeft;
            btnBuscar.StateCommon.Border.Rounding = 10F;
            btnBuscar.StateCommon.Border.Width = 1;
            btnBuscar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnBuscar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnBuscar.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnBuscar.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnBuscar.StatePressed.Back.ColorAngle = 135F;
            btnBuscar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnBuscar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnBuscar.StatePressed.Border.ColorAngle = 135F;
            btnBuscar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscar.StatePressed.Border.Rounding = 20F;
            btnBuscar.StatePressed.Border.Width = 1;
            btnBuscar.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnBuscar.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnBuscar.StateTracking.Back.ColorAngle = 45F;
            btnBuscar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnBuscar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBuscar.StateTracking.Border.ColorAngle = 45F;
            btnBuscar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBuscar.StateTracking.Border.Rounding = 20F;
            btnBuscar.StateTracking.Border.Width = 1;
            btnBuscar.TabIndex = 1041;
            btnBuscar.TabStop = false;
            btnBuscar.Values.Image = Properties.Resources.Pesquisar;
            btnBuscar.Values.Text = "";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvVendas
            // 
            dgvVendas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvVendas.Location = new Point(3, 103);
            dgvVendas.Name = "dgvVendas";
            dgvVendas.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            dgvVendas.RowHeadersWidth = 23;
            dgvVendas.Size = new Size(921, 287);
            dgvVendas.TabIndex = 1042;
            dgvVendas.TabStop = false;
            // 
            // btnCancelarVenda
            // 
            btnCancelarVenda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelarVenda.CornerRoundingRadius = 10F;
            btnCancelarVenda.Location = new Point(611, 0);
            btnCancelarVenda.Margin = new Padding(5, 3, 5, 3);
            btnCancelarVenda.Name = "btnCancelarVenda";
            btnCancelarVenda.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelarVenda.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelarVenda.OverrideDefault.Back.ColorAngle = 45F;
            btnCancelarVenda.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelarVenda.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelarVenda.OverrideDefault.Border.ColorAngle = 45F;
            btnCancelarVenda.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelarVenda.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelarVenda.OverrideDefault.Border.Rounding = 20F;
            btnCancelarVenda.OverrideDefault.Border.Width = 1;
            btnCancelarVenda.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnCancelarVenda.Size = new Size(100, 27);
            btnCancelarVenda.StateCommon.Back.Color1 = Color.Red;
            btnCancelarVenda.StateCommon.Back.Color2 = Color.Red;
            btnCancelarVenda.StateCommon.Back.ColorAngle = 45F;
            btnCancelarVenda.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelarVenda.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelarVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelarVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelarVenda.StateCommon.Border.Rounding = 10F;
            btnCancelarVenda.StateCommon.Border.Width = 1;
            btnCancelarVenda.StateCommon.Content.ShortText.Color1 = Color.White;
            btnCancelarVenda.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCancelarVenda.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnCancelarVenda.StateNormal.Back.Color1 = Color.Red;
            btnCancelarVenda.StateNormal.Back.Color2 = Color.Red;
            btnCancelarVenda.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnCancelarVenda.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnCancelarVenda.StatePressed.Back.ColorAngle = 135F;
            btnCancelarVenda.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnCancelarVenda.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnCancelarVenda.StatePressed.Border.ColorAngle = 135F;
            btnCancelarVenda.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelarVenda.StatePressed.Border.Rounding = 20F;
            btnCancelarVenda.StatePressed.Border.Width = 1;
            btnCancelarVenda.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnCancelarVenda.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnCancelarVenda.StateTracking.Back.ColorAngle = 45F;
            btnCancelarVenda.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelarVenda.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelarVenda.StateTracking.Border.ColorAngle = 45F;
            btnCancelarVenda.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelarVenda.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelarVenda.StateTracking.Border.Rounding = 20F;
            btnCancelarVenda.StateTracking.Border.Width = 1;
            btnCancelarVenda.TabIndex = 1043;
            btnCancelarVenda.Values.Text = "&Cancelar";
            btnCancelarVenda.Click += btnCancelar_Click;
            // 
            // btnLocalizarCliente
            // 
            btnLocalizarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLocalizarCliente.CornerRoundingRadius = 10F;
            btnLocalizarCliente.Location = new Point(616, 31);
            btnLocalizarCliente.Name = "btnLocalizarCliente";
            btnLocalizarCliente.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarCliente.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarCliente.OverrideDefault.Back.ColorAngle = 45F;
            btnLocalizarCliente.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarCliente.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarCliente.OverrideDefault.Border.ColorAngle = 45F;
            btnLocalizarCliente.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarCliente.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarCliente.OverrideDefault.Border.Rounding = 20F;
            btnLocalizarCliente.OverrideDefault.Border.Width = 1;
            btnLocalizarCliente.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnLocalizarCliente.Size = new Size(30, 29);
            btnLocalizarCliente.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnLocalizarCliente.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnLocalizarCliente.StateCommon.Back.ColorAngle = 45F;
            btnLocalizarCliente.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            btnLocalizarCliente.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarCliente.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarCliente.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarCliente.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarCliente.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopLeft;
            btnLocalizarCliente.StateCommon.Border.Rounding = 10F;
            btnLocalizarCliente.StateCommon.Border.Width = 1;
            btnLocalizarCliente.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLocalizarCliente.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLocalizarCliente.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalizarCliente.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalizarCliente.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalizarCliente.StatePressed.Back.ColorAngle = 135F;
            btnLocalizarCliente.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalizarCliente.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalizarCliente.StatePressed.Border.ColorAngle = 135F;
            btnLocalizarCliente.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarCliente.StatePressed.Border.Rounding = 20F;
            btnLocalizarCliente.StatePressed.Border.Width = 1;
            btnLocalizarCliente.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarCliente.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnLocalizarCliente.StateTracking.Back.ColorAngle = 45F;
            btnLocalizarCliente.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarCliente.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarCliente.StateTracking.Border.ColorAngle = 45F;
            btnLocalizarCliente.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarCliente.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarCliente.StateTracking.Border.Rounding = 20F;
            btnLocalizarCliente.StateTracking.Border.Width = 1;
            btnLocalizarCliente.TabIndex = 1044;
            btnLocalizarCliente.TabStop = false;
            btnLocalizarCliente.Values.Image = Properties.Resources.Pesquisar;
            btnLocalizarCliente.Values.Text = "";
            btnLocalizarCliente.Click += btnLocalizarCliente_Click;
            // 
            // tableLayoutPanelGerenciamentoVendas
            // 
            tableLayoutPanelGerenciamentoVendas.ColumnCount = 1;
            tableLayoutPanelGerenciamentoVendas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelGerenciamentoVendas.Controls.Add(kryptonPanel1, 0, 0);
            tableLayoutPanelGerenciamentoVendas.Controls.Add(kryptonPanel2, 0, 1);
            tableLayoutPanelGerenciamentoVendas.Controls.Add(dgvVendas, 0, 2);
            tableLayoutPanelGerenciamentoVendas.Controls.Add(kryptonPanel4, 0, 3);
            tableLayoutPanelGerenciamentoVendas.Dock = DockStyle.Fill;
            tableLayoutPanelGerenciamentoVendas.Location = new Point(0, 0);
            tableLayoutPanelGerenciamentoVendas.Name = "tableLayoutPanelGerenciamentoVendas";
            tableLayoutPanelGerenciamentoVendas.RowCount = 4;
            tableLayoutPanelGerenciamentoVendas.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelGerenciamentoVendas.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanelGerenciamentoVendas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelGerenciamentoVendas.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelGerenciamentoVendas.Size = new Size(927, 428);
            tableLayoutPanelGerenciamentoVendas.TabIndex = 1045;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(lblTituloPDV);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(3, 3);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonPanel1.Size = new Size(921, 24);
            kryptonPanel1.TabIndex = 0;
            // 
            // lblTituloPDV
            // 
            lblTituloPDV.Dock = DockStyle.Fill;
            lblTituloPDV.Location = new Point(0, 0);
            lblTituloPDV.Name = "lblTituloPDV";
            lblTituloPDV.Size = new Size(921, 24);
            lblTituloPDV.StateCommon.ShortText.Color1 = Color.Navy;
            lblTituloPDV.StateCommon.ShortText.Color2 = Color.Navy;
            lblTituloPDV.StateCommon.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloPDV.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTituloPDV.TabIndex = 1;
            lblTituloPDV.Values.Text = "GERENCIAMENTO DE VENDAS";
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(dtpDataFim);
            kryptonPanel2.Controls.Add(btnLocalizarCliente);
            kryptonPanel2.Controls.Add(txtVendaID);
            kryptonPanel2.Controls.Add(btnBuscar);
            kryptonPanel2.Controls.Add(lblRotuloVendaID);
            kryptonPanel2.Controls.Add(lblRotuloDataFim);
            kryptonPanel2.Controls.Add(lblRotuloNome);
            kryptonPanel2.Controls.Add(lblRotuloDataInicio);
            kryptonPanel2.Controls.Add(txtCliente);
            kryptonPanel2.Controls.Add(dtpDataInicio);
            kryptonPanel2.Dock = DockStyle.Fill;
            kryptonPanel2.Location = new Point(3, 33);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            kryptonPanel2.Size = new Size(921, 64);
            kryptonPanel2.TabIndex = 1;
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Controls.Add(btnCancelarVenda);
            kryptonPanel4.Controls.Add(btnAlterarVenda);
            kryptonPanel4.Controls.Add(btnVisualizarVenda);
            kryptonPanel4.Controls.Add(btnExcluirVenda);
            kryptonPanel4.Controls.Add(btnSair);
            kryptonPanel4.Dock = DockStyle.Fill;
            kryptonPanel4.Location = new Point(3, 396);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            kryptonPanel4.Size = new Size(921, 29);
            kryptonPanel4.TabIndex = 3;
            // 
            // FrmGerenciarVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(927, 450);
            Controls.Add(tableLayoutPanelGerenciamentoVendas);
            Controls.Add(kryptonStatusStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGerenciarVendas";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            Text = "Gerenciar Vendas";
            Load += FrmGerenciarVendas_Load;
            kryptonStatusStrip1.ResumeLayout(false);
            kryptonStatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendas).EndInit();
            tableLayoutPanelGerenciamentoVendas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            kryptonPanel4.ResumeLayout(false);
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
        private ToolTip toolTip;
        private System.Windows.Forms.Timer Timer1;
        public Krypton.Toolkit.KryptonTextBox txtCliente;
        private Label lblRotuloNome;
        private Label lblRotuloVendaID;
        public Krypton.Toolkit.KryptonTextBox txtVendaID;
        public Krypton.Toolkit.KryptonButton btnSair;
        public Krypton.Toolkit.KryptonButton btnExcluirVenda;
        public Krypton.Toolkit.KryptonButton btnVisualizarVenda;
        public Krypton.Toolkit.KryptonButton btnAlterarVenda;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDataInicio;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDataFim;
        private Label lblRotuloDataInicio;
        private Label lblRotuloDataFim;
        public Krypton.Toolkit.KryptonButton btnBuscar;
        private Krypton.Toolkit.KryptonDataGridView dgvVendas;
        public Krypton.Toolkit.KryptonButton btnCancelarVenda;
        public Krypton.Toolkit.KryptonButton btnLocalizarCliente;
        private TableLayoutPanel tableLayoutPanelGerenciamentoVendas;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonLabel lblTituloPDV;
    }
}