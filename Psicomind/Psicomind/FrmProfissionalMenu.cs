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
    public partial class FrmProfissionalMenu : Form
    {
        public FrmProfissionalMenu()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = FrmPrincipal.GetInstance();
            frmPrincipal.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }

        private void btnPagInserirProfissionais_Click(object sender, EventArgs e)
        {

            int cargo = Program.Usuario.Cargo.Id;

            if (cargo == 1 || cargo == 2)
            {
                
                FrmProfissionalInserir FrmProfissionalInserir = new FrmProfissionalInserir();
                FrmProfissionalInserir.StartPosition = FormStartPosition.CenterScreen;
                FrmProfissionalInserir.ShowDialog();
                this.Close();

            }
            else
            {

                MessageBox.Show("Você não possui permissão para entrar nessa área", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


           
        }

        private void btnPagConsultarProfissionais_Click(object sender, EventArgs e)
        {


            int cargo = Program.Usuario.Cargo.Id;

            if (cargo == 1 || cargo == 2)
            {
                
                FrmProfissionalConsultar FrmProfissionalConsultar = new FrmProfissionalConsultar();
                FrmProfissionalConsultar.StartPosition = FormStartPosition.CenterScreen;
                FrmProfissionalConsultar.ShowDialog();
                this.Close();

            }
            else
            {

                MessageBox.Show("Você não possui permissão para entrar nessa área", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            
        }

        private void btnPagEditarProfissionais_Click(object sender, EventArgs e)
        {


            int cargo = Program.Usuario.Cargo.Id;

            if (cargo == 1 || cargo == 2)
            {
                
                FrmProfissionalEditar FrmProfissionalEditar = new FrmProfissionalEditar();
                FrmProfissionalEditar.StartPosition = FormStartPosition.CenterScreen;
                FrmProfissionalEditar.ShowDialog();
                this.Close();

            }
            else
            {

                MessageBox.Show("Você não possui permissão para entrar nessa área", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            
        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {


            int cargo = Program.Usuario.Cargo.Id;

            if (cargo == 1 || cargo == 2 || cargo == 3)
            {
                
                FrmEscala FrmEscala = new FrmEscala();
                FrmEscala.StartPosition = FormStartPosition.CenterScreen;
                FrmEscala.ShowDialog();
                this.Close();

            }
            else
            {

                MessageBox.Show("Você não possui permissão para entrar nessa área", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
