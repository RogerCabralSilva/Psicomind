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
    public partial class CtrlPrincipal : UserControl
    {
        public CtrlPrincipal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void CtrlPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Start();

            lblRelogio.Text = DateTime.Now.ToLongTimeString();

            lblSemana.Text = DateTime.Now.ToLongDateString();
        }
    }
}
