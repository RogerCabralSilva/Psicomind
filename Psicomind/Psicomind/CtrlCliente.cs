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
            ctrlCliente.Controls.Clear();
            ctrlCliente.Controls.Add(userControl);
            userControl.BringToFront();

        }


        private void btnPagInserirCliente_Click(object sender, EventArgs e)
        {

            CtrlPrincipal ctrlPrincipal = new();
            addUserControl(ctrlPrincipal);

        }
    }
}
