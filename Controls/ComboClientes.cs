using GVC.Model;
using GVC.DTO;
using GVC.UTIL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuProjeto.Controls
{
    public partial class ComboClientes : UserControl
    {
        // Evento quando um cliente é selecionado
        public event EventHandler<int> ClienteSelecionado;

        // Componentes
        private TextBox txtBusca;
        private ListBox lstClientes;
        private Panel pnlContainer;
        private GVC.Model.ClienteService _clienteService;
        private System.Windows.Forms.Timer _timerBusca;
        private int _clienteIdSelecionado = 0;

        // Propriedades públicas
        [Browsable(false)]
        public int ClienteId
        {
            get => _clienteIdSelecionado;
            set
            {
                _clienteIdSelecionado = value;
                if (value > 0)
                    CarregarClientePorIdAsync(value).ConfigureAwait(false);
                else
                    txtBusca.Text = "";
            }
        }

        [Browsable(false)]
        public string NomeCliente => txtBusca.Text;

        public ComboClientes()
        {
            InitializeComponent();
            SetupComponents();
            SetupEvents();
        }

        private void InitializeComponent()
        {
            pnlContainer = new Panel();
            txtBusca = new TextBox();
            lstClientes = new ListBox();
            pnlContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(txtBusca);
            pnlContainer.Controls.Add(lstClientes);
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(300, 27);
            pnlContainer.TabIndex = 0;
            // 
            // txtBusca
            // 
            txtBusca.ForeColor = Color.Gray;
            txtBusca.Location = new Point(0, 0);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(300, 23);
            txtBusca.TabIndex = 0;
            txtBusca.Text = "Buscar cliente...";
            // 
            // lstClientes
            // 
            lstClientes.ItemHeight = 15;
            lstClientes.Location = new Point(0, 0);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(300, 19);
            lstClientes.TabIndex = 1;
            // 
            // ComboClientes
            // 
            BackColor = Color.White;
            Controls.Add(pnlContainer);
            Name = "ComboClientes";
            Size = new Size(300, 30);
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ResumeLayout(false);
        }

        private void SetupComponents()
        {
            // Inicializa serviço usando o helper
            using (var conn = Conexao.Conex())
            {
               
            }


            // Timer para delay na busca
            _timerBusca = new System.Windows.Forms.Timer();
            _timerBusca.Interval = 300;
            _timerBusca.Tick += TimerBusca_Tick;
        }

        private void SetupEvents()
        {
            // Evento quando texto muda
            txtBusca.TextChanged += (s, e) =>
            {
                _timerBusca.Stop();
                _timerBusca.Start();
            };

            // Eventos de teclado
            txtBusca.KeyDown += TxtBusca_KeyDown;
            txtBusca.KeyPress += TxtBusca_KeyPress;

            // Quando ganha foco, limpa placeholder
            txtBusca.GotFocus += (s, e) =>
            {
                if (txtBusca.Text == "Buscar cliente...")
                {
                    txtBusca.Text = "";
                    txtBusca.ForeColor = Color.Black;
                }
            };

            // Quando perde foco, mostra placeholder se vazio
            txtBusca.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtBusca.Text))
                {
                    txtBusca.Text = "Buscar cliente...";
                    txtBusca.ForeColor = Color.Gray;
                }

                // Esconde lista após um delay
                Task.Delay(200).ContinueWith(t =>
                {
                    if (this.InvokeRequired)
                        this.Invoke(new Action(() => lstClientes.Visible = false));
                });
            };

            // Eventos da ListBox
            lstClientes.DrawItem += LstClientes_DrawItem;
            lstClientes.MeasureItem += LstClientes_MeasureItem;
            lstClientes.Click += (s, e) => SelecionarClienteDaLista();
            lstClientes.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SelecionarClienteDaLista();
            };
        }

        private void TxtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se pressionar Enter e houver item selecionado
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (lstClientes.Visible && lstClientes.SelectedItem != null)
                {
                    SelecionarClienteDaLista();
                    e.Handled = true;
                }
            }
        }

        private void TxtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            if (!lstClientes.Visible) return;

            switch (e.KeyCode)
            {
                case Keys.Down:
                    if (lstClientes.Items.Count > 0)
                    {
                        int nextIndex = Math.Min(lstClientes.SelectedIndex + 1, lstClientes.Items.Count - 1);
                        lstClientes.SelectedIndex = nextIndex;
                        lstClientes.TopIndex = Math.Max(0, nextIndex - 3);
                        e.Handled = true;
                    }
                    break;

                case Keys.Up:
                    if (lstClientes.Items.Count > 0 && lstClientes.SelectedIndex > 0)
                    {
                        int prevIndex = Math.Max(lstClientes.SelectedIndex - 1, 0);
                        lstClientes.SelectedIndex = prevIndex;
                        lstClientes.TopIndex = Math.Max(0, prevIndex - 3);
                        e.Handled = true;
                    }
                    break;

                case Keys.Escape:
                    lstClientes.Visible = false;
                    e.Handled = true;
                    break;
            }
        }

        private async void TimerBusca_Tick(object sender, EventArgs e)
        {
            _timerBusca.Stop();
            await BuscarClientes();
        }

        private async Task BuscarClientes()
        {
            string termo = txtBusca.Text.Trim();

            // Ignora se for placeholder
            if (termo == "Buscar cliente..." || termo.Length < 2)
            {
                lstClientes.Visible = false;
                return;
            }

            try
            {
                var clientes = await _clienteService.BuscarClientesAsync(termo);

                this.Invoke(new Action(() =>
                {
                    lstClientes.Items.Clear();

                    if (clientes != null && clientes.Count > 0)
                    {
                        foreach (var cliente in clientes)
                        {
                            lstClientes.Items.Add(cliente);
                        }

                        // Mostra a lista
                        lstClientes.Visible = true;
                        lstClientes.BringToFront();
                        lstClientes.Height = Math.Min(clientes.Count * 30, 200);

                        // Seleciona o primeiro item
                        if (lstClientes.Items.Count > 0)
                            lstClientes.SelectedIndex = 0;
                    }
                    else
                    {
                        lstClientes.Visible = false;
                    }
                }));
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro($"Erro ao buscar clientes: {ex.Message}");
            }
        }

        private void SelecionarClienteDaLista()
        {
            if (lstClientes.SelectedItem is ClienteDisplayDTO cliente)
            {
                _clienteIdSelecionado = cliente.Id;
                txtBusca.Text = cliente.Nome;
                txtBusca.ForeColor = Color.Black;
                lstClientes.Visible = false;

                // Dispara evento
                ClienteSelecionado?.Invoke(this, cliente.Id);
            }
        }

        private async Task CarregarClientePorIdAsync(int clienteId)
        {
            if (clienteId > 0)
            {
                var cliente = await _clienteService.ObterClientePorIdAsync(clienteId);
                if (cliente != null)
                {
                    this.Invoke(new Action(() =>
                    {
                        _clienteIdSelecionado = cliente.Id;
                        txtBusca.Text = cliente.Nome;
                        txtBusca.ForeColor = Color.Black;
                    }));
                }
            }
        }

        // Método para desenhar os itens da lista
        private void LstClientes_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 30;
        }

        private void LstClientes_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= lstClientes.Items.Count) return;

            e.DrawBackground();

            bool itemSelecionado = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            // Cor de fundo
            Brush bgBrush = itemSelecionado ? SystemBrushes.Highlight : Brushes.White;
            e.Graphics.FillRectangle(bgBrush, e.Bounds);

            if (lstClientes.Items[e.Index] is ClienteDisplayDTO cliente)
            {
                // Cor do texto
                Brush textBrush = itemSelecionado ? Brushes.White : Brushes.Black;
                Brush detailBrush = itemSelecionado ? Brushes.LightGray : Brushes.Gray;

                // Nome em negrito
                using (var boldFont = new Font(e.Font, FontStyle.Bold))
                {
                    e.Graphics.DrawString(cliente.Nome, boldFont, textBrush,
                        e.Bounds.X + 2, e.Bounds.Y + 2);
                }

                // Documento
                using (var smallFont = new Font(e.Font, (FontStyle)8))
                {
                    e.Graphics.DrawString(cliente.Documento, smallFont, detailBrush,
                        e.Bounds.X + 2, e.Bounds.Y + 17);
                }
            }

            e.DrawFocusRectangle();
        }

        // ========== MÉTODOS PÚBLICOS ==========

        /// <summary>
        /// Limpa a seleção do cliente
        /// </summary>
        public void Limpar()
        {
            _clienteIdSelecionado = 0;
            txtBusca.Text = "Buscar cliente...";
            txtBusca.ForeColor = Color.Gray;
            lstClientes.Visible = false;
            lstClientes.Items.Clear();
        }

        /// <summary>
        /// Define o cliente selecionado
        /// </summary>
        public async Task DefinirClienteAsync(int clienteId)
        {
            await CarregarClientePorIdAsync(clienteId);
        }

        /// <summary>
        /// Foca no campo de busca
        /// </summary>
        public void FocusBusca()
        {
            txtBusca.Focus();
            txtBusca.SelectAll();
        }
    }
}