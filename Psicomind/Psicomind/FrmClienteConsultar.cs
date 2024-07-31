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
                dgvClientesDados.Rows[count].Cells[0].Value = cliente.Nome;
                dgvClientesDados.Rows[count].Cells[1].Value = cliente.Email;
                dgvClientesDados.Rows[count].Cells[2].Value = cliente.Cpf;
                dgvClientesDados.Rows[count].Cells[3].Value = cliente.Data_cad;
                dgvClientesDados.Rows[count].Cells[4].Value = cliente.Data_nasc;
                dgvClientesDados.Rows[count].Cells[5].Value = cliente.GeneroCliente.Genero_nome;
                dgvClientesDados.Rows[count].Cells[6].Value = cliente.Ativo;


                count++;

            }

        }

        private void CarregarEndereco()
        {

            var enderecos = Endereco.ObterListaEndereco();
            int count = 0;

            dgvClienteEndereco.Rows.Clear();
            foreach (var endereco in enderecos)
            {
                int rowIndex = dgvClienteEndereco.Rows.Add();
                dgvClienteEndereco.Rows[count].Cells[0].Value = endereco.Cliente_Id;
                dgvClienteEndereco.Rows[count].Cells[1].Value = endereco.Cep;
                dgvClienteEndereco.Rows[count].Cells[2].Value = endereco.Rua;
                dgvClienteEndereco.Rows[count].Cells[3].Value = endereco.Numero;
                dgvClienteEndereco.Rows[count].Cells[4].Value = endereco.Bairro;
                dgvClienteEndereco.Rows[count].Cells[5].Value = endereco.Cidade;
                dgvClienteEndereco.Rows[count].Cells[6].Value = endereco.Uf;
                dgvClienteEndereco.Rows[count].Cells[7].Value = endereco.TipoEndereco.Nome;

                count++;

            }

        }

        private void CarregarTelefoneCliente()
        {

            var telefones = TelefoneCliente.ObterListaTelefone();
            int count = 0;

            dgvClienteTelefone.Rows.Clear();
            foreach (var telefone in telefones)
            {
                int rowIndex = dgvClienteTelefone.Rows.Add();
                dgvClienteTelefone.Rows[count].Cells[0].Value = telefone.Cliente_id;
                dgvClienteTelefone.Rows[count].Cells[1].Value = telefone.Numero;
                dgvClienteTelefone.Rows[count].Cells[2].Value = telefone.TelefoneTipo_id.Tipo;

                count++;


            }

        }

    }
}
