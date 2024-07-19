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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        public void addUserControl(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }


        private void btnHome_Click(object sender, EventArgs e)
        {

            CtrlPrincipal ctrlPrincipal = new();
            addUserControl(ctrlPrincipal);

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

            CtrlCliente ctrlCliente = new();
            addUserControl(ctrlCliente);

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnProfissional_Click(object sender, EventArgs e)
        {

            CtrlProfissional ctrlProfissional = new();
            addUserControl(ctrlProfissional);

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

            CtrlUsuario ctrlUsuario = new();
            addUserControl(ctrlUsuario);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
