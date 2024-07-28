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
    public partial class FrmClientesMenu : Form
    {
        public FrmClientesMenu()
        {
            InitializeComponent();
        }

        private void FrmClientesMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnPagInserirCliente_Click(object sender, EventArgs e)
        {
            FrmClientesInserir clienteInserir = new FrmClientesInserir();

            clienteInserir.StartPosition = FormStartPosition.CenterScreen;

            clienteInserir.Show();

            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmPrincipal FrmPrincipal = new FrmPrincipal();

            FrmPrincipal.StartPosition = FormStartPosition.CenterScreen;
            FrmPrincipal.Show();

            this.Close();
        }

        private void btnPagConsultarCliente_Click(object sender, EventArgs e)
        {
            FrmClienteConsultar clienteConsultar = new FrmClienteConsultar();

            clienteConsultar.StartPosition = FormStartPosition.CenterScreen;
            clienteConsultar.Show();

            this.Close();
        }

        private void btnPagEditarCliente_Click(object sender, EventArgs e)
        {
            FrmClienteEditar FrmClienteEditar = new FrmClienteEditar();

            FrmClienteEditar.StartPosition = FormStartPosition.CenterScreen;
            FrmClienteEditar.Show();

            this.Close();
        }
    }
}
