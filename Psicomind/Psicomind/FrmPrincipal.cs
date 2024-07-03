﻿using System;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void addUserControl(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }


        private void btnHome_Click(object sender, EventArgs e)
        {

            CtrlPrincipal ctrlPrincipal = new();
            addUserControl(ctrlPrincipal);

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

            CtrlCliente ctrlCliente = new();
            addUserControl(ctrlCliente);

        }
    }
}
