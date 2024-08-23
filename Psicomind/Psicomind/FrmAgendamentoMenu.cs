using PsicomindClass;
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
    public partial class FrmAgendamentoMenu : Form
    {


        public FrmAgendamentoMenu()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnPagEditarUsuario_Click(object sender, EventArgs e)
        {

            int cargo = Program.Usuario.Cargo.Id;

            if (cargo == 1 || cargo == 2)
            {
                frmAgendamento frmAgendamento = new();
                frmAgendamento.StartPosition = FormStartPosition.CenterScreen;
                frmAgendamento.Show();

            }
            else
            {

                MessageBox.Show("Você não possui permissão para entrar nessa área", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            FrmPrincipal frmPrincipal = FrmPrincipal.GetInstance();
            frmPrincipal.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }

        private void btnPagConsultarUsuario_Click(object sender, EventArgs e)
        {



        }
    }
}
