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

        private void CtrlCliente_Load(object sender, EventArgs e)
        {

        }

        public void btnPagInserirCliente_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();

            CtrlClienteInserir clienteInserir = new CtrlClienteInserir();

            frmPrincipal.addUserControl(clienteInserir);
        }
    }
}
