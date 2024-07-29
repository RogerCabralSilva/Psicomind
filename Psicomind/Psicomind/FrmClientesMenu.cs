using System;
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
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = FrmPrincipal.GetInstance();
            frmPrincipal.StartPosition = FormStartPosition.CenterScreen;
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
            FrmClienteEditar frmClienteEditar = new FrmClienteEditar();
            frmClienteEditar.StartPosition = FormStartPosition.CenterScreen;
            frmClienteEditar.Show();
            this.Close();
        }
    }
}
