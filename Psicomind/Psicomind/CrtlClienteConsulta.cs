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
    public partial class CrtlClienteConsulta : UserControl
    {
        public CrtlClienteConsulta()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {

            CtrlCliente ctrlCliente = new();

            userControl.Dock = DockStyle.Fill;
            pnp.Controls.Clear();
            pnp.Controls.Add(userControl);
            userControl.BringToFront();
        }



        private void btnVoltar_Click(object sender, EventArgs e)
        {
            CtrlCliente CtrlCliente = new();
            addUserControl(CtrlCliente);
        }

        private void CrtlClienteConsulta_Load(object sender, EventArgs e)
        {
            var clientes = Cliente.ObterLista();
            int count = 0;

            dgvClientes.Rows.Clear();
            foreach (var cliente in clientes)
            {
                int rowIndex = dgvClientes.Rows.Add();
                dgvClientes.Rows[count].Cells[0].Value = cliente.Nome;
                dgvClientes.Rows[count].Cells[1].Value = cliente.Cpf;
                dgvClientes.Rows[count].Cells[2].Value = cliente.Email;


                count++;

            }
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
