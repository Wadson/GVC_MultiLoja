using Dapper;
using GVC.BLL;
using GVC.DAL;
using GVC.DAL;
using GVC.Model;
using GVC.MUI;
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
    public partial class FrmCadFormaPgto : KryptonForm
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string StatusOperacao { get; set; } // "NOVO", "ALTERAR", "EXCLUSAO"
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool CarregandoDados { get; set; }
        private readonly FormaPagamentoBLL _formaPgtoBll = new FormaPagamentoBLL();
        private FormaPagamentoDal _formaPgtoDal = new FormaPagamentoDal();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int FormaPgtoID { get; set; }
        private readonly string QueryMaxId = "SELECT MAX(FormaPgtoID) FROM FormaPagamento";
        public bool HouveAlteracao { get; private set; } // indica se houve alteração nos dados atualiza o datagrid do FrmManutFormaPgto



        public FrmCadFormaPgto()
        {
            InitializeComponent();
        }
        private void GerarNovoCodigo()
        {
            try
            {
                int novoId = Utilitario.ProximoId(QueryMaxId);

                FormaPgtoID = novoId;
                txtFormaPgtoID.Text = Utilitario.ZerosEsquerda(novoId, 4);
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro($"Erro ao gerar código: {ex.Message}");

                FormaPgtoID = 0;
                txtFormaPgtoID.Text = "0000";
            }
        }
        private FormaPagamentoModel MontarObjetoFormaPgto()
        {
            var formapgto = new FormaPagamentoModel
            {
                FormaPgtoID = int.Parse(txtFormaPgtoID.Text),
                NomeFormaPagamento = txtFormaPgto.Text?.Trim(),
            };

            if (StatusOperacao == "NOVO")
            {

            }
            if (StatusOperacao == "ALTERAR")
            {
            }

            return formapgto;
        }
        private void SalvarRegistro()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFormaPgto.Text))
                {
                    Utilitario.Mensagens.Aviso("Razão Social é obrigatória!");
                    txtFormaPgto.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtFormaPgtoID.Text))
                {
                    Utilitario.Mensagens.Aviso("Cnpj é obrigatório!");
                    txtFormaPgto.Focus();
                    return;
                }


                var formapgto = MontarObjetoFormaPgto();
                _formaPgtoBll.Salvar(formapgto);
                Utilitario.Mensagens.Info("Empresa cadastrada com sucesso!");
                HouveAlteracao = true;

                LimparCampos();
                txtFormaPgto.Focus();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro(ex.Message);
            }
        }

        private void AlterarRegistro()
        {
            try
            {
                if (FormaPgtoID <= 0)
                {
                    Utilitario.Mensagens.Aviso("ID da empresa inválido!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtFormaPgto.Text))
                {
                    Utilitario.Mensagens.Aviso("Razão Social é obrigatória!");
                    txtFormaPgto.Focus();
                    return;
                }

                var empresa = MontarObjetoFormaPgto();
                _formaPgtoBll.Alterar(empresa);
                Utilitario.Mensagens.Info("Empresa alterada com sucesso!");
                HouveAlteracao = true;
                this.Close();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro(ex.Message);
            }
        }

        private void ExcluirRegistro()
        {
            if (FormaPgtoID <= 0)
            {
                Utilitario.Mensagens.Aviso("Nenhuma forma de pagamento selecionada para exclusão!");
                return;
            }

            if (MessageBox.Show($"Deseja realmente excluir a forma de pagamento:\n\n{txtFormaPgto.Text}?\n\nEsta ação não pode ser desfeita!",
                "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    var formaPgto = MontarObjetoFormaPgto(); // Cria o objeto FormaPgtoModel
                    _formaPgtoBll.Excluir(formaPgto); // Passa o objeto para o método Excluir
                    Utilitario.Mensagens.Aviso("Empresa excluída com sucesso!");
                    HouveAlteracao = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    Utilitario.Mensagens.Erro($"Erro ao excluir empresa: {ex.Message}");
                }
            }
        }
        private void FrmCadFormaPgto_Shown(object sender, EventArgs e)
        {
            Utilitario.AplicarCorFocoNosTextBox(this);
        }
        private void FrmCadFormaPgto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }
      
        private void LimparCampos()
        {
            Utilitario.LimparCampos(this);

            GerarNovoCodigo();
        }
        private void BloquearTextBoxRecursivo(Control ctrl, bool habilitar)
        {
            // TextBox
            if (ctrl is KryptonTextBox txt)
                txt.ReadOnly = !habilitar;

            // MaskedTextBox
            else if (ctrl is MaskedTextBox mtxt)
                mtxt.ReadOnly = !habilitar;

            // ComboBox
            else if (ctrl is KryptonComboBox cbo)
                cbo.Enabled = habilitar;

            // DateTimePicker
            else if (ctrl is DateTimePicker dtp)
                dtp.Enabled = habilitar;

            // CheckBox
            else if (ctrl is CheckBox chk)
                chk.Enabled = habilitar;

            // Botões — exceção para Salvar/Cancelar
            else if (ctrl is KryptonButton btn)
            {
                if (btn.Name != "btnSalvar" && btn.Name != "btnCancelar")
                    btn.Enabled = habilitar;
            }

            // Recursão para controles filhos (Panel, GroupBox, etc.)
            foreach (Control filho in ctrl.Controls)
                BloquearTextBoxRecursivo(filho, habilitar);
        }
        private void AplicarHeader(Color cor)
        {
            StateCommon.Header.Content.ShortText.Color1 = cor;
            StateCommon.Header.Content.ShortText.Color2 = Color.White;
            StateCommon.Header.Content.ShortText.Font =
                new Font("Segoe UI", 12, FontStyle.Bold);
        }

        private void HabilitarCampos(bool habilitar)
        {
            foreach (Control ctrl in Controls)
                BloquearTextBoxRecursivo(ctrl, habilitar);
        }
        private void AplicarModoFormulario()
        {
            switch (StatusOperacao)
            {
                case "NOVO":
                    Text = "Nova Empresa";
                    btnSalvar.Text = "Salvar";
                    AplicarHeader(Color.Green);
                    HabilitarCampos(true);
                    break;

                case "ALTERAR":
                    Text = "Alterar Empresa";
                    btnSalvar.Text = "Alterar";
                    AplicarHeader(Color.Orange);
                    HabilitarCampos(true);
                    btnSair.Enabled = true;
                    break;

                case "EXCLUSAO":
                    Text = "Excluir Empresa";
                    btnSalvar.Text = "Excluir";
                    AplicarHeader(Color.Red);
                    HabilitarCampos(false);
                    btnSair.Enabled = true;
                    break;
            }
        }
        private void CarregarFormaPgto(int _formaPgtoId)
        {
            var formapgto = _formaPgtoBll.BuscarPorId(_formaPgtoId);
            if (formapgto == null)
                return;

            txtFormaPgtoID.Text = Utilitario.ZerosEsquerda((int)formapgto.FormaPgtoID, 4);
            txtFormaPgto.Text = formapgto.NomeFormaPagamento;

        }
        private void FrmCadFormaPgto_Load(object sender, EventArgs e)
        {
            if (!ValidadorSessao.Validar(this))
                return;

            if (string.IsNullOrWhiteSpace(StatusOperacao))
                throw new InvalidOperationException("StatusOperacao não definido.");
            if (StatusOperacao == "NOVO")
            {
                GerarNovoCodigo();
                BloquearTextBoxRecursivo(this, true);
            }

            // 🔹 Se for ALTERAR ou EXCLUIR, carrega os dados
            if (CarregandoDados)
            {
                CarregarFormaPgto((int)FormaPgtoID);
            }

            // 🔹 Aplica o estado visual conforme operação
            AplicarModoFormulario();

            CarregandoDados = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (StatusOperacao == "NOVO")
                SalvarRegistro();
            else if (StatusOperacao == "ALTERAR")
                AlterarRegistro();
            else if (StatusOperacao == "EXCLUSAO")
                ExcluirRegistro(); btnSalvar.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            GerarNovoCodigo();
            txtFormaPgto.Focus();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
