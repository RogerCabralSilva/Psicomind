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

            // Editar Cliente

            Cliente cliente = new(
                int.Parse(txtClienteId.Text),
                txtNome.Text,
                txtSenha.Text,
                dptDataNascimento.Value,
                Genero.ObterPorId(Convert.ToInt32(cmbGenero.SelectedValue)),
                chkAtivo.Checked
                );

            // Editar Endereço

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

            // Editar Telefone

            TelefoneCliente telefoneCliente = new(
                    mtxTelefone.Text,
                    int.Parse(txtClienteId.Text),
                    TelefoneTipo.ObterPorId(Convert.ToInt32(cmbTipoTelefone.SelectedValue)));

            // Retorna True ou false e roda o que tiver dentro do if

            if (cliente.Editar(cliente.Id))
            {
                CtrlClienteEditar_Load(sender, e);
                MessageBox.Show($"O Cliente {cliente.Nome} foi alterado com sucesso!");

                // Limpando os campos após editar o Cliente

                txtClienteId.Clear();
                txtNome.Clear();
                txtSenha.Clear();
                mtxTelefone.Clear();
                mtxCep.Clear();
                txtRua.Clear();
                txtBairro.Clear();
                txtNumero.Clear();
                txtCidade.Clear();
                txtUf.Clear();

            }
            else
            {
                MessageBox.Show("Falha ao alterar o Cliente");
            }

            // Retorna True ou false e roda o que tiver dentro do if

            if (cliente.Editar(cliente.Id))
            {
                CtrlClienteEditar_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao alterar o Cliente");
            }

            // Retorna True ou false e roda o que tiver dentro do if

            if (telefoneCliente.Editar(cliente.Id))
            {
                CtrlClienteEditar_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao alterar o Cliente");
            }

        }

        private void CtrlClienteEditar_Load(object sender, EventArgs e)
        {
            // Preenche os combos box

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
            // Se o ClienteId for maior que 0 faça isso

            if (txtClienteId.Text.Length != 0)
            {
                Cliente cliente = Cliente.ObterPorId(int.Parse(txtClienteId.Text));
                TelefoneCliente telefone = TelefoneCliente.ObterPorId(int.Parse(txtClienteId.Text));

                if (cliente.Id != 0)
                {
                    // Busca o cliente
                    txtNome.Text = cliente.Nome;
                    txtSenha.Text = cliente.Senha;
                    cmbGenero.SelectedValue = cliente.GeneroCliente.Id;
                    dptDataNascimento.Value = cliente.Data_nasc;
                    chkAtivo.Checked = cliente.Ativo;


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

                    if(telefone.Id != 0) 
                    {
                        
                        // Verificando se o cliente possui telefone

                        mtxTelefone.Text = telefone.Numero;
                        cmbTipoTelefone.SelectedValue = telefone.TelefoneTipo_id.Id;

                    }

                    btnEditar.Enabled = true; 

                }
                else
                {
                    // Cliente não encontrado, exibe mensagem de erro e limpa os campos
                    MessageBox.Show("Cliente não encontrado.");
                    btnEditar.Enabled = false;

                    // Limpa os campos do formulário
                    txtClienteId.Clear();
                    txtNome.Clear();
                    txtSenha.Clear();
                    mtxTelefone.Clear();
                    mtxCep.Clear();
                    txtRua.Clear();
                    txtBairro.Clear();
                    txtNumero.Clear();
                    txtCidade.Clear();
                    txtUf.Clear();
                    cmbGenero.SelectedIndex = -1;
                    cmbTipoEndereco.SelectedIndex = -1;
                    cmbTipoTelefone.SelectedIndex = -1;
                    dptDataNascimento.Value = DateTime.Today; // Define uma data válida
                    chkAtivo.Checked = false;
                }
            }


        }


        private void txtClienteId_TextChanged(object sender, EventArgs e)
        {
            // Verifica se há valor no campo ClienteId

            if (txtClienteId.Text.Length == 0)
            {
                btnEditar.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            // Limpa os campos do formulário

            txtClienteId.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            mtxTelefone.Clear();
            mtxCep.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            txtUf.Clear();
        }

        private void addUserControl(UserControl userControl)
        {
            // Responsável por trocar as telas

            CtrlCliente ctrlCliente = new();

            userControl.Dock = DockStyle.Fill;
            pnp.Controls.Clear();
            pnp.Controls.Add(userControl);
            userControl.BringToFront();

        }


        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            CtrlCliente CtrlCliente = new();
            addUserControl(CtrlCliente);
        }

        private void guna2ContainerControl2_Click(object sender, EventArgs e)
        {


        }

        private void pnp_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
