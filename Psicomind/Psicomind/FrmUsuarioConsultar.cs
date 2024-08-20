using MySqlX.XDevAPI;
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
    public partial class FrmUsuarioConsultar : Form
    {
        public FrmUsuarioConsultar()
        {
            InitializeComponent();
        }

        private void FrmUsuarioConsultar_Load(object sender, EventArgs e)
        {

            CarregaDadosUser();

        }

        private void CarregaDadosUser()
        {

            var usuarios = Usuario.ObterLista();
            int count = 0;

            dgvUserDados.Rows.Clear();
            foreach (var usuario in usuarios)
            {
                int rowIndex = dgvUserDados.Rows.Add();
                dgvUserDados.Rows[count].Cells[0].Value = usuario.Id;
                dgvUserDados.Rows[count].Cells[1].Value = usuario.Nome;
                dgvUserDados.Rows[count].Cells[2].Value = usuario.Email;
                dgvUserDados.Rows[count].Cells[3].Value = usuario.Cargo.Nome;
                dgvUserDados.Rows[count].Cells[4].Value = usuario.Ativo;

                count++;


            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            FrmUsuarioMenu frmUsuarioMenu = new();

            frmUsuarioMenu.StartPosition = FormStartPosition.CenterScreen;

            frmUsuarioMenu.Show();

            this.Close();
        }

        private void txtBuscarProfissional_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultarDados_Click(object sender, EventArgs e)
        {

            var usuarios = Usuario.ObterLista(txtBuscarUsuario.Text);
            int count = 0;

            dgvUserDados.Rows.Clear();
            foreach (var usuario in usuarios)
            {
                int rowIndex = dgvUserDados.Rows.Add();
                dgvUserDados.Rows[count].Cells[0].Value = usuario.Id;
                dgvUserDados.Rows[count].Cells[1].Value = usuario.Nome;
                dgvUserDados.Rows[count].Cells[2].Value = usuario.Email;
                dgvUserDados.Rows[count].Cells[3].Value = usuario.Cargo.Nome;
                dgvUserDados.Rows[count].Cells[4].Value = usuario.Ativo;

                count++;


            }

        }
    }
}
