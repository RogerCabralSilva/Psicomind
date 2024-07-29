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
    public partial class FrmProfissionalConsultar : Form
    {
        public FrmProfissionalConsultar()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmProfissionalMenu FrmProfissionalMenu = new FrmProfissionalMenu();

            FrmProfissionalMenu.StartPosition = FormStartPosition.CenterScreen;

            FrmProfissionalMenu.Show();

            this.Close();
        }
    }
}
