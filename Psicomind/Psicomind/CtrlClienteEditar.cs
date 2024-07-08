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
    public partial class CtrlClienteEditar : UserControl
    {
        public CtrlClienteEditar()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Tirando os traços do maskedTexBox
            mtxCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            //
            Cliente cliente = new(
                int.Parse(txtClienteId.Text),
            txtNome.Text,
                txtSenha.Text,
                dptDataNascimento.Value,
                Genero.ObterPorId(Convert.ToInt32(cmbGenero.SelectedValue)),
                chkAtivo.Checked
                );

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

            TelefoneCliente telefoneCliente = new(
                    mtxTelefone.Text,
                    int.Parse(txtClienteId.Text),
                    TelefoneTipo.ObterPorId(Convert.ToInt32(cmbTipoTelefone.SelectedValue)));

            if (cliente.Editar(cliente.Id))
            {
                CtrlClienteEditar_Load(sender, e);
                MessageBox.Show($"O cliente {cliente.Nome} foi alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao alterar o usuário");
            }

            if (cliente.Editar(cliente.Id))
            {
                CtrlClienteEditar_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao alterar o usuário");
            }

            if (telefoneCliente.Editar(cliente.Id))
            {
                CtrlClienteEditar_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao alterar o usuário");
            }
        }

        private void CtrlClienteEditar_Load(object sender, EventArgs e)
        {
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtClienteId.Text.Length > 0)
            {
                // Busca o cliente
                Cliente cliente = Cliente.ObterPorId(int.Parse(txtClienteId.Text));
                txtNome.Text = cliente.Nome;
                txtSenha.Text = cliente.Senha;
                cmbGenero.SelectedValue = cliente.GeneroCliente.Id;
                dptDataNascimento.Value = cliente.Data_nasc;


                // Busca o Endereço
                Endereco endereco = Endereco.ObterPorId(int.Parse(txtClienteId.Text));
                mtxCep.Text = endereco.Cep;
                txtRua.Text = endereco.Rua;
                txtNumero.Text = endereco.Numero;
                txtBairro.Text = endereco.Bairro;
                txtCidade.Text = endereco.Cidade;
                txtUf.Text = endereco.Uf;

                cmbTipoEndereco.SelectedValue = endereco.TipoEndereco.Id;


                // Busca o telefone do cliente
                TelefoneCliente telefone = TelefoneCliente.ObterPorId(int.Parse(txtClienteId.Text));
                mtxTelefone.Text = telefone.Numero;

                btnEditar.Enabled = true;
            }
        }

        private void pnp_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
