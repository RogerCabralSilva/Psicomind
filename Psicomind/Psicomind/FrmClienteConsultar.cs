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
    public partial class FrmClienteConsultar : Form
    {
        public FrmClienteConsultar()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmClientesMenu FrmClientesMenu = new FrmClientesMenu();

            FrmClientesMenu.StartPosition = FormStartPosition.CenterScreen;

            FrmClientesMenu.Show();

            this.Close();
        }

        private void FrmClienteConsultar_Load(object sender, EventArgs e)
        {

            CarregarDadosCliente();
            CarregarEndereco();
            CarregarTelefoneCliente();

        }

        private void CarregarDadosCliente()
        {

            var clientes = Cliente.ObterLista();
            int count = 0;

            dgvClientesDados.Rows.Clear();
            foreach (var cliente in clientes)
            {
                int rowIndex = dgvClientesDados.Rows.Add();
                dgvClientesDados.Rows[count].Cells[0].Value = cliente.Id;
                dgvClientesDados.Rows[count].Cells[1].Value = cliente.Nome;
                dgvClientesDados.Rows[count].Cells[2].Value = cliente.Email;
                dgvClientesDados.Rows[count].Cells[3].Value = cliente.Cpf;
                dgvClientesDados.Rows[count].Cells[4].Value = cliente.Data_cad;
                dgvClientesDados.Rows[count].Cells[5].Value = cliente.Data_nasc;
                dgvClientesDados.Rows[count].Cells[6].Value = cliente.GeneroCliente.Genero_nome;
                dgvClientesDados.Rows[count].Cells[7].Value = cliente.Ativo;


                count++;

            }

        }

        private void CarregarEndereco()
        {

            var cliente = Cliente.ObterLista();
            int count = 0;

            dgvClienteEndereco.Rows.Clear();
            foreach (var clientes in cliente)
            {
                int rowIndex = dgvClienteEndereco.Rows.Add();
                dgvClienteEndereco.Rows[count].Cells[0].Value = clientes.Nome;
                dgvClienteEndereco.Rows[count].Cells[1].Value = clientes.Enderecos.Cep;
                dgvClienteEndereco.Rows[count].Cells[2].Value = clientes.Enderecos.Rua;
                dgvClienteEndereco.Rows[count].Cells[3].Value = clientes.Enderecos.Numero;
                dgvClienteEndereco.Rows[count].Cells[4].Value = clientes.Enderecos.Bairro;
                dgvClienteEndereco.Rows[count].Cells[5].Value = clientes.Enderecos.Cidade;
                dgvClienteEndereco.Rows[count].Cells[6].Value = clientes.Enderecos.Uf;
                dgvClienteEndereco.Rows[count].Cells[7].Value = clientes.Enderecos.TipoEndereco.Nome;

                count++;

            }

        }

        private void CarregarTelefoneCliente()
        {

            var clientes = Cliente.ObterLista();
            int count = 0;


            dgvClienteTelefone.Rows.Clear();
            foreach (var cliente in clientes)
            {
                int rowIndex = dgvClienteTelefone.Rows.Add();
                dgvClienteTelefone.Rows[count].Cells[0].Value = cliente.Nome;
                dgvClienteTelefone.Rows[count].Cells[1].Value = cliente.Telefone.Numero;
                dgvClienteTelefone.Rows[count].Cells[2].Value = cliente.Telefone.TelefoneTipo_id.Tipo;


                count++;


            }

        }

        private void dgvClientesDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            FrmClienteEditar frmClienteEditar = new();
            frmClienteEditar.txtClienteId.Text = dgvClientesDados.Rows[dgvClientesDados.CurrentRow.Index].Cells[0].Value.ToString();

            frmClienteEditar.Show();
            this.Hide();

        }

        private void btnVoltarTelefone_Click(object sender, EventArgs e)
        {
            FrmClientesMenu FrmClientesMenu = new FrmClientesMenu();

            FrmClientesMenu.StartPosition = FormStartPosition.CenterScreen;

            FrmClientesMenu.Show();

            this.Close();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            FrmClientesMenu FrmClientesMenu = new FrmClientesMenu();

            FrmClientesMenu.StartPosition = FormStartPosition.CenterScreen;

            FrmClientesMenu.Show();

            this.Close();
        }

        private void btnVoltarEndereco_Click(object sender, EventArgs e)
        {
            FrmClientesMenu FrmClientesMenu = new FrmClientesMenu();

            FrmClientesMenu.StartPosition = FormStartPosition.CenterScreen;

            FrmClientesMenu.Show();

            this.Close();
        }

        private void btn_consultar_dados_pessoais_cliente_Click(object sender, EventArgs e)
        {
            var clientes = Cliente.ObterLista(txtBuscaClienteDadosPessoais.Text);
            int count = 0;

            dgvClientesDados.Rows.Clear();
            foreach (var cliente in clientes)
            {
                int rowIndex = dgvClientesDados.Rows.Add();
                dgvClientesDados.Rows[count].Cells[0].Value = cliente.Id;
                dgvClientesDados.Rows[count].Cells[1].Value = cliente.Nome;
                dgvClientesDados.Rows[count].Cells[2].Value = cliente.Email;
                dgvClientesDados.Rows[count].Cells[3].Value = cliente.Cpf;
                dgvClientesDados.Rows[count].Cells[4].Value = cliente.Data_cad;
                dgvClientesDados.Rows[count].Cells[5].Value = cliente.Data_nasc;
                dgvClientesDados.Rows[count].Cells[6].Value = cliente.GeneroCliente.Genero_nome;
                dgvClientesDados.Rows[count].Cells[7].Value = cliente.Ativo;


                count++;

            }
        }

        private void btnConsultarEndereco_Click(object sender, EventArgs e)
        {
            var cliente = Cliente.ObterLista(txtBuscarEndereco.Text);
            int count = 0;

            dgvClienteEndereco.Rows.Clear();
            foreach (var clientes in cliente)
            {
                int rowIndex = dgvClienteEndereco.Rows.Add();
                dgvClienteEndereco.Rows[count].Cells[0].Value = clientes.Nome;
                dgvClienteEndereco.Rows[count].Cells[1].Value = clientes.Enderecos.Cep;
                dgvClienteEndereco.Rows[count].Cells[2].Value = clientes.Enderecos.Rua;
                dgvClienteEndereco.Rows[count].Cells[3].Value = clientes.Enderecos.Numero;
                dgvClienteEndereco.Rows[count].Cells[4].Value = clientes.Enderecos.Bairro;
                dgvClienteEndereco.Rows[count].Cells[5].Value = clientes.Enderecos.Cidade;
                dgvClienteEndereco.Rows[count].Cells[6].Value = clientes.Enderecos.Uf;
                dgvClienteEndereco.Rows[count].Cells[7].Value = clientes.Enderecos.TipoEndereco.Nome;

                count++;

            }
            CarregarDadosCliente();
        }

        private void btnConsultarTelefoneCliente_Click(object sender, EventArgs e)
        {
            var clientes = Cliente.ObterLista(txtBuscarTelefone.Text);
            int count = 0;


            dgvClienteTelefone.Rows.Clear();
            foreach (var cliente in clientes)
            {
                int rowIndex = dgvClienteTelefone.Rows.Add();
                dgvClienteTelefone.Rows[count].Cells[0].Value = cliente.Nome;
                dgvClienteTelefone.Rows[count].Cells[1].Value = cliente.Telefone.Numero;
                dgvClienteTelefone.Rows[count].Cells[2].Value = cliente.Telefone.TelefoneTipo_id.Tipo;


                count++;


            }
        }

        private void dgvClientesDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
