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
    public partial class FrmUsuarioMenu : Form
    {
        public FrmUsuarioMenu()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = FrmPrincipal.GetInstance();
            frmPrincipal.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }

        private void btnPagConsultarUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuarioConsultar userConsultar = new FrmUsuarioConsultar();
            userConsultar.StartPosition = FormStartPosition.CenterScreen;
            userConsultar.Show();
            this.Close();
        }
    }
}
