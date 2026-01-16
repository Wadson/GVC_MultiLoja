using Dapper;
using GVC.BLL;
using GVC.DAL;
using GVC.DAL;
using GVC.Model;
using GVC.UTIL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization; // Adicione no topo do arquivo
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GVC.View
{
    public partial class FrmBaixarParcela : KryptonForm
    {
        // Cultura brasileira fixa
        private readonly CultureInfo _culturaBR = new CultureInfo("pt-BR");
        private List<int> _parcelasIds = new();
        private decimal _saldoTotal;
        private readonly ParcelaBLL parcelaBLL = new ParcelaBLL();


        private int? FormaPgtoIDSelecionada => cmbFormaPagamento.SelectedValue == null
        ? (int?)null : Convert.ToInt32(cmbFormaPagamento.SelectedValue);

        //private long? _formaPgtoIdSelecionada;



        public FrmBaixarParcela()
        {
            InitializeComponent();
            this.txtValorRecebido.TextChanged += new System.EventHandler(this.txtValorRecebido_TextChanged);

        }

        public FrmBaixarParcela(int parcelaId, string nome, decimal valorParcela, decimal valorRecebido, decimal saldo)
        {
            InitializeComponent();

            _parcelasIds.Clear();
            _parcelasIds.Add(parcelaId);
            _saldoTotal = saldo;

            this.Text = nome;

            // 🔹 AGORA É SALDO
            lblSaldo.Text = saldo.ToString("C2", _culturaBR);

            txtValorRecebido.Text = valorRecebido.ToString("C2", _culturaBR);
            txtNovoSaldo.Text = saldo.ToString("C2", _culturaBR);

            lblRotuloValorParcela.Text = "Saldo Atual";
            txtValorRecebido.Focus();
        }
        private void ConfigurarGridBaixa()
        {
            dgvParcelasBaixa.AutoGenerateColumns = false;
            dgvParcelasBaixa.Columns.Clear();

            // Coluna ID (oculta)
            var colId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ParcelaID",
                HeaderText = "ID",
                Width = 50,
                Visible = false
            };
            dgvParcelasBaixa.Columns.Add(colId);

            // Coluna ID (oculta)
            var colIdVenda = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "VendaID",
                HeaderText = "VendaID",
                Width = 60,
                Visible = false
            };
            dgvParcelasBaixa.Columns.Add(colIdVenda);

            // Coluna Número da Parcela (centralizada)
            var colParcela = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumeroParcela",
                HeaderText = "Nº Parc.",
                Width = 60,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };
            dgvParcelasBaixa.Columns.Add(colParcela);

            // Demais colunas
            dgvParcelasBaixa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataVencimento",
                HeaderText = "Vencimento",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });
            dgvParcelasBaixa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorParcela",
                HeaderText = "Valor",
                Width = 95,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
            dgvParcelasBaixa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorRecebido",
                HeaderText = "Recebido",
                Width = 95,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
            dgvParcelasBaixa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Saldo",
                HeaderText = "Saldo",
                Width = 95,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgvParcelasBaixa.ReadOnly = true;
            dgvParcelasBaixa.AllowUserToAddRows = false;
            dgvParcelasBaixa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void CarregarDados(
           IEnumerable<ContaAReceberDTO> parcelas,
           string nomeCliente,
           decimal totalParcelas,
           decimal totalRecebido,
           decimal saldoTotal)
        {
            // Guarda os IDs das parcelas
            _parcelasIds = parcelas.Select(p => p.ParcelaID).ToList();
            _saldoTotal = saldoTotal;

            // Preenche campos          
            lblRotuloValorParcela.Text = "Saldo Atual";
            lblSaldo.Text = saldoTotal.ToString("C2", _culturaBR);
            txtValorRecebido.Text = totalRecebido.ToString("C2", _culturaBR);
            txtNovoSaldo.Text = saldoTotal.ToString("C2", _culturaBR);

            // Grid
            ConfigurarGridBaixa();
            dgvParcelasBaixa.DataSource = parcelas.ToList();

            // Define o título da janela com o nome do cliente
            this.Text = $"Cliente: {nomeCliente}";

            // Foco automático
            if (_parcelasIds.Count == 1)
                txtValorRecebido.Focus();
        }
        public static void SalvarNomesControles(Form form, string caminhoArquivo)
        {
            var nomes = new List<string>();
            PercorrerControles(form.Controls, nomes);

            // Salva todos os nomes no arquivo .txt
            File.WriteAllLines(caminhoArquivo, nomes);
        }

        private static void PercorrerControles(Control.ControlCollection controls, List<string> nomes)
        {
            foreach (Control ctrl in controls)
            {
                nomes.Add(ctrl.Name);

                if (ctrl.HasChildren)
                {
                    PercorrerControles(ctrl.Controls, nomes);
                }
            }
        }
        private void txtValorRecebido_TextChanged(object sender, EventArgs e)
        {
            string textoSaldo = lblSaldo.Text
         .Replace("R$", "")
         .Replace(".", "")
         .Replace(",", ".")
         .Trim();

            string textoRecebido = txtValorRecebido.Text
                .Replace("R$", "")
                .Replace(".", "")
                .Replace(",", ".")
                .Trim();

            if (!decimal.TryParse(textoSaldo, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal saldoAtual))
                return;

            if (!decimal.TryParse(textoRecebido, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal valorRecebido))
            {
                txtNovoSaldo.Text = saldoAtual.ToString("C2", _culturaBR);
                return;
            }

            decimal novoSaldo = saldoAtual - valorRecebido;

            if (novoSaldo < 0)
                novoSaldo = saldoAtual;

            txtNovoSaldo.Text = novoSaldo.ToString("C2", _culturaBR);
        }
        private void btnListarControlesDoForm_Click(object sender, EventArgs e)
        {
            // Caminho onde o arquivo será salvo
            string caminho = @"D:\ControlesForm.txt";

            FrmBaixarParcela.SalvarNomesControles(this, caminho);

            Utilitario.Mensagens.Aviso("Lista de controles salva em: " + caminho);
        }

        private void FrmBaixarParcela_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }
        private void FrmBaixarParcela_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void txtValorRecebido_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtValorRecebido.Text))
            {
                txtValorRecebido.Text = "0,00";
                return;
            }

            // Limpa possíveis caracteres indesejados
            string textoLimpo = txtValorRecebido.Text
                .Replace("R$", "")

                .Replace(" ", "")
                .Trim();

            if (decimal.TryParse(textoLimpo, NumberStyles.Any, _culturaBR, out decimal valor))
            {
                // Formata como 1.000,00 (sem R$ para evitar problema no parse)
                txtValorRecebido.Text = valor.ToString("N");
            }
            else
            {
                txtValorRecebido.Text = "0,00";
            }
        }

        private void dgvParcelasBaixa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Proteger índices inválidos
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var coluna = dgvParcelasBaixa.Columns[e.ColumnIndex].DataPropertyName;

            // 1) Datas: formatar dd/MM/yyyy
            if ((coluna == "DataVencimento") && e.Value != null)
            {
                if (e.Value is DateTime dt)
                {
                    e.Value = dt.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
                else if (DateTime.TryParse(e.Value.ToString(), out var parsed))
                {
                    e.Value = parsed.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
        }

        private void CarregarFormasPagamento()
        {
            var dal = new FormaPagamentoDal();
            var formas = dal.Listar(); // deve retornar ID + Nome


            cmbFormaPagamento.DisplayMember = "NomeFormaPagamento";
            cmbFormaPagamento.ValueMember = "FormaPgtoID";
            cmbFormaPagamento.DataSource = formas;

            cmbFormaPagamento.SelectedIndex = -1; // força seleção manual
        }

        private void FrmBaixarParcela_Load(object sender, EventArgs e)
        {
            CarregarFormasPagamento();
        }              

        private void btnConfirmarBaixa_Click(object sender, EventArgs e)
        {
            string _valorRecebido = txtValorRecebido.Text.Replace("R$", "").Replace(" ", "").Trim();

            if (FormaPgtoIDSelecionada == null)
            {
                Utilitario.Mensagens.Aviso("Selecione a forma de pagamento.");
                cmbFormaPagamento.Focus();
                return;
            }

            if (!decimal.TryParse(_valorRecebido, NumberStyles.Any, _culturaBR, out decimal valorBaixa) || valorBaixa <= 0)
            {
                Utilitario.Mensagens.Aviso("Informe um valor válido maior que zero.");
                return;
            }


            string textoParcela = lblSaldo.Text
                            .Replace("R$", "")
                            .Replace(".", "")
                            .Replace(",", ".")
                            .Trim();

            if (!decimal.TryParse(textoParcela, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal valorParcela))
            {
                Utilitario.Mensagens.Aviso("Valor da parcela inválido.");
                return;
            }

            if (valorBaixa > valorParcela)
            {
                Utilitario.Mensagens.Aviso("O valor pago não pode ser maior que o valor da parcela.");
                return;
            }

            // 🔹 OBSERVAÇÃO VEM DO FORM
            string? observacao = string.IsNullOrWhiteSpace(txtObservacao.Text)
                ? null : txtObservacao.Text.Trim();

            if (_parcelasIds.Count == 1)
            {
                parcelaBLL.BaixarParcelaParcial(_parcelasIds[0], valorBaixa, FormaPgtoIDSelecionada.Value, observacao);
            }
            else
            {
                var parcelasLong = _parcelasIds.Select(id => (long)id).ToList();

                parcelaBLL.BaixarParcelasEmLote(parcelasLong, DateTime.Now, FormaPgtoIDSelecionada.Value);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
