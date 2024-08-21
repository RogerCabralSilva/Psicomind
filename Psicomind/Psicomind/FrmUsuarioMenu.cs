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

            int cargo = Program.Usuario.Cargo.Id;

            if (cargo == 1 || cargo == 2)
            {
                
                FrmUsuarioConsultar userConsultar = new FrmUsuarioConsultar();
                userConsultar.StartPosition = FormStartPosition.CenterScreen;
                userConsultar.Show();
                this.Close();

            }
            else
            {

                MessageBox.Show("Você não possui permissão para entrar nessa área", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            
        }
    }
}
