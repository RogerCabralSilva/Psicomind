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
    public partial class CtrlProfissional : UserControl
    {
        public CtrlProfissional()
        {
            InitializeComponent();
        }

        private void AddUserControl(UserControl userControl)
        {

            CtrlProfissional ctrlProfissional = new();

            userControl.Dock = DockStyle.Fill;
            pnpProfissionais.Controls.Clear();
            pnpProfissionais.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void btnPagInserirProfissionais_Click(object sender, EventArgs e)
        {
            CtrlProfissionaisInserir ctrlProfissionaisInserir = new();
            AddUserControl(ctrlProfissionaisInserir);
        }

        private void btnPagConsultarProfissionais_Click(object sender, EventArgs e)
        {
            CtrlProfissionalEditar ctrlProfissionalEditar = new();
            AddUserControl(ctrlProfissionalEditar);
        }
    }
}
