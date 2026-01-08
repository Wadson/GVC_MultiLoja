namespace GVC
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            panel1 = new Panel();
            panelMenu = new Panel();
            panelLogo = new Panel();
            btnUsuario = new Button();
            btnCliente = new Button();
            btnFornecedor = new Button();
            btnProduto = new Button();
            btnVenda = new Button();
            btnFerramentas = new Button();
            btnContasReceber = new Button();
            btnRelatorio = new Button();
            imageList1 = new ImageList(components);
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(218, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 58);
            panel1.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(40, 130, 230);
            panelMenu.Controls.Add(btnRelatorio);
            panelMenu.Controls.Add(btnContasReceber);
            panelMenu.Controls.Add(btnFerramentas);
            panelMenu.Controls.Add(btnVenda);
            panelMenu.Controls.Add(btnProduto);
            panelMenu.Controls.Add(btnFornecedor);
            panelMenu.Controls.Add(btnCliente);
            panelMenu.Controls.Add(btnUsuario);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 580);
            panelMenu.TabIndex = 1;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(6, 100, 180);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 1;
            // 
            // btnUsuario
            // 
            btnUsuario.Dock = DockStyle.Top;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.ForeColor = Color.Gainsboro;
            btnUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuario.ImageKey = "usuario.png";
            btnUsuario.ImageList = imageList1;
            btnUsuario.Location = new Point(0, 80);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Padding = new Padding(11, 0, 0, 0);
            btnUsuario.Size = new Size(220, 50);
            btnUsuario.TabIndex = 3;
            btnUsuario.Text = "Cadastro Usuário";
            btnUsuario.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            btnCliente.Dock = DockStyle.Top;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.ForeColor = Color.Gainsboro;
            btnCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnCliente.ImageKey = "clientes.png";
            btnCliente.ImageList = imageList1;
            btnCliente.Location = new Point(0, 130);
            btnCliente.Name = "btnCliente";
            btnCliente.Padding = new Padding(11, 0, 0, 0);
            btnCliente.Size = new Size(220, 50);
            btnCliente.TabIndex = 4;
            btnCliente.Text = "Cadastro Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnFornecedor
            // 
            btnFornecedor.Dock = DockStyle.Top;
            btnFornecedor.FlatAppearance.BorderSize = 0;
            btnFornecedor.FlatStyle = FlatStyle.Flat;
            btnFornecedor.ForeColor = Color.Gainsboro;
            btnFornecedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnFornecedor.ImageKey = "fornecedores.png";
            btnFornecedor.ImageList = imageList1;
            btnFornecedor.Location = new Point(0, 180);
            btnFornecedor.Name = "btnFornecedor";
            btnFornecedor.Padding = new Padding(11, 0, 0, 0);
            btnFornecedor.Size = new Size(220, 50);
            btnFornecedor.TabIndex = 5;
            btnFornecedor.Text = "         Cadastro de Produtos";
            btnFornecedor.UseVisualStyleBackColor = true;
            // 
            // btnProduto
            // 
            btnProduto.Dock = DockStyle.Top;
            btnProduto.FlatAppearance.BorderSize = 0;
            btnProduto.FlatStyle = FlatStyle.Flat;
            btnProduto.ForeColor = Color.Gainsboro;
            btnProduto.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduto.ImageKey = "produtos.png";
            btnProduto.ImageList = imageList1;
            btnProduto.Location = new Point(0, 230);
            btnProduto.Name = "btnProduto";
            btnProduto.Padding = new Padding(11, 0, 0, 0);
            btnProduto.Size = new Size(220, 50);
            btnProduto.TabIndex = 6;
            btnProduto.Text = "    Cadastro Produtos";
            btnProduto.UseVisualStyleBackColor = true;
            // 
            // btnVenda
            // 
            btnVenda.Dock = DockStyle.Top;
            btnVenda.FlatAppearance.BorderSize = 0;
            btnVenda.FlatStyle = FlatStyle.Flat;
            btnVenda.ForeColor = Color.Gainsboro;
            btnVenda.ImageAlign = ContentAlignment.MiddleLeft;
            btnVenda.ImageKey = "venda.png";
            btnVenda.ImageList = imageList1;
            btnVenda.Location = new Point(0, 280);
            btnVenda.Name = "btnVenda";
            btnVenda.Padding = new Padding(11, 0, 0, 0);
            btnVenda.Size = new Size(220, 50);
            btnVenda.TabIndex = 7;
            btnVenda.Text = "                  PDV";
            btnVenda.TextAlign = ContentAlignment.MiddleLeft;
            btnVenda.UseVisualStyleBackColor = true;
            // 
            // btnFerramentas
            // 
            btnFerramentas.Dock = DockStyle.Top;
            btnFerramentas.FlatAppearance.BorderSize = 0;
            btnFerramentas.FlatStyle = FlatStyle.Flat;
            btnFerramentas.ForeColor = Color.Gainsboro;
            btnFerramentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnFerramentas.ImageKey = "ferramentas.png";
            btnFerramentas.ImageList = imageList1;
            btnFerramentas.Location = new Point(0, 330);
            btnFerramentas.Name = "btnFerramentas";
            btnFerramentas.Padding = new Padding(11, 0, 0, 0);
            btnFerramentas.Size = new Size(220, 50);
            btnFerramentas.TabIndex = 8;
            btnFerramentas.Text = "                  Ferramentas";
            btnFerramentas.TextAlign = ContentAlignment.MiddleLeft;
            btnFerramentas.UseVisualStyleBackColor = true;
            // 
            // btnContasReceber
            // 
            btnContasReceber.Dock = DockStyle.Top;
            btnContasReceber.FlatAppearance.BorderSize = 0;
            btnContasReceber.FlatStyle = FlatStyle.Flat;
            btnContasReceber.ForeColor = Color.Gainsboro;
            btnContasReceber.ImageAlign = ContentAlignment.MiddleLeft;
            btnContasReceber.ImageKey = "contas_receber.png";
            btnContasReceber.ImageList = imageList1;
            btnContasReceber.Location = new Point(0, 380);
            btnContasReceber.Name = "btnContasReceber";
            btnContasReceber.Padding = new Padding(11, 0, 0, 0);
            btnContasReceber.Size = new Size(220, 50);
            btnContasReceber.TabIndex = 9;
            btnContasReceber.Text = "  Contas a Receber";
            btnContasReceber.UseVisualStyleBackColor = true;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Dock = DockStyle.Top;
            btnRelatorio.FlatAppearance.BorderSize = 0;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.ForeColor = Color.Gainsboro;
            btnRelatorio.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelatorio.ImageKey = "relatorios.png";
            btnRelatorio.ImageList = imageList1;
            btnRelatorio.Location = new Point(0, 430);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Padding = new Padding(11, 0, 0, 0);
            btnRelatorio.Size = new Size(220, 50);
            btnRelatorio.TabIndex = 10;
            btnRelatorio.Text = "                  Relatórios";
            btnRelatorio.TextAlign = ContentAlignment.MiddleLeft;
            btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "cidades.png");
            imageList1.Images.SetKeyName(1, "clientes.png");
            imageList1.Images.SetKeyName(2, "contas_receber.png");
            imageList1.Images.SetKeyName(3, "empresa.png");
            imageList1.Images.SetKeyName(4, "estados.png");
            imageList1.Images.SetKeyName(5, "ferramentas.png");
            imageList1.Images.SetKeyName(6, "forma_pagamento.png");
            imageList1.Images.SetKeyName(7, "fornecedores.png");
            imageList1.Images.SetKeyName(8, "produtos.png");
            imageList1.Images.SetKeyName(9, "relatorios.png");
            imageList1.Images.SetKeyName(10, "usuario.png");
            imageList1.Images.SetKeyName(11, "venda.png");
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 580);
            Controls.Add(panelMenu);
            Controls.Add(panel1);
            Name = "FrmPrincipal";
            Text = "FrmTelaPrincipal";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnUsuario;
        private Button btnRelatorio;
        private Button btnContasReceber;
        private Button btnFerramentas;
        private Button btnVenda;
        private Button btnProduto;
        private Button btnFornecedor;
        private Button btnCliente;
        private ImageList imageList1;
    }
}