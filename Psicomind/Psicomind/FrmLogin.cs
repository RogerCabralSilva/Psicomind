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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text != string.Empty && txtSenha.Text != string.Empty)
            {

                var usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);

                if (usuario.Id > 0)
                {

                    Program.Usuario = usuario;

                    // Fecha o formulário de login e retorna DialogResult.OK
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {

                    MessageBox.Show("Email e/ou senha inválidos");
                    txtEmail.Focus();

                }

            }
            else
            {

                MessageBox.Show("Digite suas credenciais para prosseguir!");

            }


            // Limpando os campos ao clicar o botao
            txtEmail.Clear();
            txtSenha.Clear();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
