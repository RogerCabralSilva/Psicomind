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

            Cliente cliente = new(
                txtNome.Text,
                txtCpf.Text,
                txtEmail.Text,
                txtSenha.Text,
                dptDataNascimento.Value,
                Genero.ObterPorId(Convert.ToInt32(cmbGenero.SelectedValue)

                ));
            cliente.Inserir();

            if (cliente.Id > 0)
            {
                txtClienteId.Text = cliente.Id.ToString();
                MessageBox.Show($"Cliente {cliente.Nome} Cadastrado com sucesso!");
            }
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
        }
    }
}
