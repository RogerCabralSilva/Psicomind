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

        private void btnAbrirProfissional_MouseLeave(object sender, EventArgs e)
        {
            btnAbrirProfissional.ShadowDecoration.Enabled = false;
        }

        private void btnAbrirProfissional_MouseHover(object sender, EventArgs e)
        {
            btnAbrirProfissional.ShadowDecoration.Enabled = true;
        }

        private void btnAbrirProfissional_Click(object sender, EventArgs e)
        {
            FrmClientesMenu frmClientesMenu = new FrmClientesMenu();
            frmClientesMenu.StartPosition = FormStartPosition.CenterParent;
            frmClientesMenu.Show();

           this.Hide();
            frmClientesMenu.FormClosed += (s, args) => this.Close();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
