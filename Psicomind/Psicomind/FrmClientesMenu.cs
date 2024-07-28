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
    public partial class FrmClientesMenu : Form
    {
        public FrmClientesMenu()
        {
            InitializeComponent();
        }

        private void FrmClientesMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnPagInserirCliente_Click(object sender, EventArgs e)
        {
            FrmClientesInserir clienteInserir = new FrmClientesInserir();

            clienteInserir.StartPosition = FormStartPosition.CenterScreen;

            clienteInserir.Show();

            this.Hide();
            clienteInserir.FormClosed += (s, args) => this.Close();
        }
    }
}
