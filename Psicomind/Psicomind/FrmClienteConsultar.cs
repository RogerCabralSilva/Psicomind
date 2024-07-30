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

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pngTelefoneCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
