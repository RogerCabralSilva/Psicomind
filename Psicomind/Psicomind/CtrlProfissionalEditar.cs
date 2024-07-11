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
    public partial class CtrlProfissionalEditar : UserControl
    {
        public CtrlProfissionalEditar()
        {
            InitializeComponent();
        }

        private void AddUserControl(UserControl userControl)
        {

            CtrlProfissional ctrlProfissional = new();

            userControl.Dock = DockStyle.Fill;
            pnp.Controls.Clear();
            pnp.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            CtrlProfissional ctrlProfissional = new();
            AddUserControl(ctrlProfissional);
        }
    }
}
