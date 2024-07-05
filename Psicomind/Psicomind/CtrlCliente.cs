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
    public partial class CtrlCliente : UserControl
    {
        public CtrlCliente()
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


        private void btnPagInserirCliente_Click_1(object sender, EventArgs e)
        {
            CtrlClienteInserir CtrlClienteInserir = new();
            addUserControl(CtrlClienteInserir);
        }

        private void btnPagEditarCliente_Click(object sender, EventArgs e)
        {
            CtrlClienteEditar CtrlClienteEditar = new();
            addUserControl(CtrlClienteEditar);
        }

        private void btnPagConsultarCliente_Click(object sender, EventArgs e)
        {

        }


    }
}
