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
    public partial class CtrlClienteInserir : UserControl
    {
        public CtrlClienteInserir()
        {
            InitializeComponent();
        }

        private void CtrlClienteInserir_Load(object sender, EventArgs e)
        {

            var genero = Genero.ObterLista();
            cmbGenero.DataSource = genero;
            cmbGenero.DisplayMember = "Genero_nome";
            cmbGenero.ValueMember = "id";

            var tipoEndereco = TipoEndereco.ObterLista();
            cmbTipoEndereco.DataSource = tipoEndereco;
            cmbTipoEndereco.DisplayMember = "Nome";
            cmbTipoEndereco.ValueMember = "id";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            txtCep.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            txtUf.Clear();

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Validações de campos obrigatórios do cliente
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O nome é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCpf.Text))
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

            // Validações de campos obrigatórios do endereço
            if (string.IsNullOrWhiteSpace(txtCep.Text))
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

            
            Cliente cliente = new(
                txtNome.Text,
                txtCpf.Text,
                txtEmail.Text,
                txtSenha.Text,
                dptDataNascimento.Value,
                Genero.ObterPorId(Convert.ToInt32(cmbGenero.SelectedValue))
            );

           
            cliente.Inserir();

           
            if (cliente.Id > 0)
            {
                txtClienteId.Text = cliente.Id.ToString();
                MessageBox.Show($"Cliente {cliente.Nome} cadastrado com sucesso!");

               
                Endereco endereco = new(
                    int.Parse(txtClienteId.Text),
                    txtCep.Text,
                    txtRua.Text,
                    txtNumero.Text,
                    txtBairro.Text,
                    txtUf.Text,
                    TipoEndereco.ObterPorId(Convert.ToInt32(cmbTipoEndereco.SelectedValue))
                );

                
                endereco.Inserir();

                MessageBox.Show("Endereço cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            if (txtCep.Text.Length > 7)
            {
                WebCEP webCep = new(txtCep.Text);
                txtBairro.Text = webCep.Bairro;
                txtCidade.Text = webCep.Cidade;
                txtUf.Text = webCep.UF;
                txtRua.Text = webCep.Lagradouro;


            }

            if (txtCep.Text.Length < 8)
            {
                txtBairro.Clear();
                txtCidade.Clear();
                txtUf.Clear();
                txtRua.Clear(); 

            }
        }
    }
}
