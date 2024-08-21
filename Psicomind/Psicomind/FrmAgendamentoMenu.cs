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

            frmAgendamento frmAgendamento = new();
            frmAgendamento.StartPosition = FormStartPosition.CenterScreen;
            frmAgendamento.Show();

        }
    }
}
