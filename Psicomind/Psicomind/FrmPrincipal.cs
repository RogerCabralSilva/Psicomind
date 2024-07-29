using System;
using System.Windows.Forms;

namespace Psicomind
{
    public partial class FrmPrincipal : Form
    {
        private static FrmPrincipal instance;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public static FrmPrincipal GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmPrincipal();
            }
            return instance;
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
            FrmProfissionalMenu FrmProfissionalMenu = new FrmProfissionalMenu();

            FrmProfissionalMenu.StartPosition = FormStartPosition.CenterScreen;
            FrmProfissionalMenu.Show();
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
            FrmClientesMenu frmClientesMenu = new FrmClientesMenu();

            frmClientesMenu.StartPosition = FormStartPosition.CenterScreen;
            frmClientesMenu.Show();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
