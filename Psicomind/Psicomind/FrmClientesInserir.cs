using PsicomindClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psicomind
{
    public partial class FrmClientesInserir : Form
    {
        public FrmClientesInserir()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa os campos do formulário

            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            mtxCpf.Clear();
            mtxTelefone.Clear();
            mtxCep.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            txtUf.Clear();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Tirando os traços do maskedTexBox
            mtxCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            // Validações de campos obrigatórios do cliente
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O nome é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(mtxCpf.Text))
            {
                MessageBox.Show("O CPF é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("O email é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("A senha é obrigatória.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbGenero.SelectedValue == null)
            {
                MessageBox.Show("O gênero é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(mtxTelefone.Text))
            {

                MessageBox.Show("O número de telefone é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            // Validações de campos obrigatórios do endereço
            if (string.IsNullOrWhiteSpace(mtxCep.Text))
            {
                MessageBox.Show("O CEP é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRua.Text))
            {
                MessageBox.Show("A rua é obrigatória.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("O número é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                MessageBox.Show("O bairro é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                MessageBox.Show("A cidade é obrigatória.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUf.Text))
            {
                MessageBox.Show("O estado (UF) é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbTipoEndereco.SelectedValue == null)
            {
                MessageBox.Show("O tipo de endereço é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // Inserir Cliente
            Cliente cliente = new(
                txtNome.Text,
                mtxCpf.Text,
                txtEmail.Text,
                txtSenha.Text,
                dptDataNascimento.Value,
                Genero.ObterPorId(Convert.ToInt32(cmbGenero.SelectedValue))
            );

            try
            {
                cliente.Inserir();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show($"Já existe alguma informação inserida !!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            // Se cliente tiver id mostre isso

            if (cliente.Id > 0)
            {
                txtClienteId.Text = cliente.Id.ToString();



                Endereco endereco = new(
                    int.Parse(txtClienteId.Text),
                    mtxCep.Text,
                    txtRua.Text,
                    txtNumero.Text,
                    txtBairro.Text,
                    txtCidade.Text,
                    txtUf.Text,
                    TipoEndereco.ObterPorId(Convert.ToInt32(cmbTipoEndereco.SelectedValue))
                );


                endereco.Inserir();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar endereço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Se cliente tiver id mostre isso

            if (cliente.Id > 0)
            {
                txtClienteId.Text = cliente.Id.ToString();
                MessageBox.Show($"Cliente {cliente.Nome} cadastrado com sucesso!");

                TelefoneCliente telefone = new(
                   mtxTelefone.Text,
                   int.Parse(txtClienteId.Text),
                   TelefoneTipo.ObterPorId(Convert.ToInt32(cmbTipoTelefone.SelectedValue))
                    );

                telefone.Inserir();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar telefone", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmClientesInserir_Load(object sender, EventArgs e)
        {
            // Preenche os combo box
            var genero = Genero.ObterLista();
            cmbGenero.DataSource = genero;
            cmbGenero.DisplayMember = "Genero_nome";
            cmbGenero.ValueMember = "id";

            var tipoEndereco = TipoEndereco.ObterLista();
            cmbTipoEndereco.DataSource = tipoEndereco;
            cmbTipoEndereco.DisplayMember = "Nome";
            cmbTipoEndereco.ValueMember = "id";

            var tipoTelefone = TelefoneTipo.ObterLista();
            cmbTipoTelefone.DataSource = tipoTelefone;
            cmbTipoTelefone.DisplayMember = "Tipo";
            cmbTipoTelefone.ValueMember = "id";
        }

        private void mtxCep_TextChanged_1(object sender, EventArgs e)
        {
            // Preenche as informações com os dados do cep
            if (mtxCep.Text.Length > 7)
            {
                mtxCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                WebCEP webCep = new(mtxCep.Text);
                txtBairro.Text = webCep.Bairro;
                txtCidade.Text = webCep.Cidade;
                txtUf.Text = webCep.UF;
                txtRua.Text = webCep.Lagradouro;
                txtNumero.Focus();

            }

            // Se tiver menos que 8 apaga as informações
            if (mtxCep.Text.Length < 8)
            {
                mtxCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                txtBairro.Clear();
                txtCidade.Clear();
                txtUf.Clear();
                txtRua.Clear();

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmClientesMenu clientesMenus = new FrmClientesMenu();

            clientesMenus.StartPosition = FormStartPosition.CenterScreen;
            clientesMenus.Show();

            this.Hide();
            clientesMenus.FormClosed += (s, args) => this.Close();
        }
    }
}
