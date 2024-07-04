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
    public partial class CtrlClienteInserir : UserControl
    {
        public CtrlClienteInserir()
        {
            InitializeComponent();
        }

        private void CtrlClienteInserir_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            txtCep.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            txtUf.Clear();

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            Cliente cliente = new(
                
                
                
                );


        }
    }
}
