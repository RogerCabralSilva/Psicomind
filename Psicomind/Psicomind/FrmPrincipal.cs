using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            
        }

        private void btnAbrirUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrirUsuario_MouseHover(object sender, EventArgs e)
        {
            btnAbrirUsuario.ShadowDecoration.Enabled = true;
        }

        private void btnAbrirUsuario_MouseLeave(object sender, EventArgs e)
        {
            btnAbrirUsuario.ShadowDecoration.Enabled = false;
        }

        private void btnAbrirCliente_MouseHover(object sender, EventArgs e)
        {
            btnAbrirCliente.ShadowDecoration.Enabled = true;
        }

        private void btnAbrirCliente_MouseLeave(object sender, EventArgs e)
        {
            btnAbrirCliente.ShadowDecoration.Enabled = false;
        }

        private void btnAbrirAgendamento_MouseHover(object sender, EventArgs e)
        {
            btnAbrirAgendamento.ShadowDecoration.Enabled = true;
        }

        private void btnAbrirAgendamento_MouseLeave(object sender, EventArgs e)
        {
            btnAbrirAgendamento.ShadowDecoration.Enabled = false;
        }

        private void btnAbrirCliente_Click(object sender, EventArgs e)
        {
        }
    }
}
