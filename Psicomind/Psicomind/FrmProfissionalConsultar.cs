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
    public partial class FrmProfissionalConsultar : Form
    {
        public FrmProfissionalConsultar()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmProfissionalMenu FrmProfissionalMenu = new FrmProfissionalMenu();

            FrmProfissionalMenu.StartPosition = FormStartPosition.CenterScreen;

            FrmProfissionalMenu.Show();

            this.Close();
        }

        private void guna2ContainerControl2_Click(object sender, EventArgs e)
        {

        }

        private void FrmProfissionalConsultar_Load(object sender, EventArgs e)
        {

            CarregarDadosProfissional();
            CarregarTelefoneProfissional();


        }

        private void CarregarDadosProfissional()
        {

            var profissionais = Profissional.ObterLista();
            int count = 0;

            dgvProfissionalDados.Rows.Clear();
            foreach (var profissional in profissionais)
            {
                int rowIndex = dgvProfissionalDados.Rows.Add();

                dgvProfissionalDados.Columns["clnDataNascProfissional"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvProfissionalDados.Columns["clnDataContrato"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvProfissionalDados.Rows[count].Cells[0].Value = profissional.Id;
                dgvProfissionalDados.Rows[count].Cells[1].Value = profissional.Nome;
                dgvProfissionalDados.Rows[count].Cells[2].Value = profissional.Email;
                dgvProfissionalDados.Rows[count].Cells[3].Value = profissional.Cpf;
                dgvProfissionalDados.Rows[count].Cells[4].Value = profissional.Especializacao;
                dgvProfissionalDados.Rows[count].Cells[5].Value = profissional.Data_contrato;
                dgvProfissionalDados.Rows[count].Cells[6].Value = profissional.Data_cad;
                dgvProfissionalDados.Rows[count].Cells[7].Value = profissional.Data_nasc;
                dgvProfissionalDados.Rows[count].Cells[8].Value = profissional.Genero.Genero_nome;
                dgvProfissionalDados.Rows[count].Cells[9].Value = profissional.Ativo;


                count++;

            }

        }

        private void CarregarTelefoneProfissional()
        {

            var profissionais = Profissional.ObterLista();
            int count = 0;

            dgvProfissionalTelefone.Rows.Clear();
            foreach (var profissional in profissionais)
            {
                int rowIndex = dgvProfissionalTelefone.Rows.Add();
                dgvProfissionalTelefone.Rows[count].Cells[0].Value = profissional.Nome;
                dgvProfissionalTelefone.Rows[count].Cells[1].Value = profissional.TelefoneProfissional.Numero;
                dgvProfissionalTelefone.Rows[count].Cells[2].Value = profissional.TelefoneProfissional.Telefonetipo_id.Tipo;

                count++;


            }

        }

        private void dgvProfissionalDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmProfissionalEditar frmProfissionalEditar = new();
            frmProfissionalEditar.txtProfissionalId.Text = dgvProfissionalDados.Rows[dgvProfissionalDados.CurrentRow.Index].Cells[0].Value.ToString();

            frmProfissionalEditar.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmClientesMenu FrmClientesMenu = new FrmClientesMenu();

            FrmClientesMenu.StartPosition = FormStartPosition.CenterScreen;

            FrmClientesMenu.Show();

            this.Close();
        }

        private void dgvProfissionalDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProfissionalTelefone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnConsultarDados_Click(object sender, EventArgs e)
        {
            var profissionais = Profissional.ObterLista(txtBuscarProfissional.Text);
            int count = 0;

            dgvProfissionalDados.Rows.Clear();
            foreach (var profissional in profissionais)
            {
                int rowIndex = dgvProfissionalDados.Rows.Add();

                dgvProfissionalDados.Columns["clnDataNascProfissional"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvProfissionalDados.Columns["clnDataContrato"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvProfissionalDados.Rows[count].Cells[0].Value = profissional.Id;
                dgvProfissionalDados.Rows[count].Cells[1].Value = profissional.Nome;
                dgvProfissionalDados.Rows[count].Cells[2].Value = profissional.Email;
                dgvProfissionalDados.Rows[count].Cells[3].Value = profissional.Cpf;
                dgvProfissionalDados.Rows[count].Cells[4].Value = profissional.Especializacao;
                dgvProfissionalDados.Rows[count].Cells[5].Value = profissional.Data_contrato;
                dgvProfissionalDados.Rows[count].Cells[6].Value = profissional.Data_cad;
                dgvProfissionalDados.Rows[count].Cells[7].Value = profissional.Data_nasc;
                dgvProfissionalDados.Rows[count].Cells[8].Value = profissional.Genero.Genero_nome;
                dgvProfissionalDados.Rows[count].Cells[9].Value = profissional.Ativo;


                count++;

            }
        }

        private void btnConsultarTelefoneProfissional_Click(object sender, EventArgs e)
        {
            var profissionais = Profissional.ObterLista(txtConsultarProfissional.Text);
            int count = 0;

            dgvProfissionalTelefone.Rows.Clear();
            foreach (var profissional in profissionais)
            {
                int rowIndex = dgvProfissionalTelefone.Rows.Add();
                dgvProfissionalTelefone.Rows[count].Cells[0].Value = profissional.Nome;
                dgvProfissionalTelefone.Rows[count].Cells[1].Value = profissional.TelefoneProfissional.Numero;
                dgvProfissionalTelefone.Rows[count].Cells[2].Value = profissional.TelefoneProfissional.Telefonetipo_id.Tipo;

                count++;


            }
        }

        private void txtBuscarProfissional_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultarDados_Click(object sender, EventArgs e)
        {

        }
    }
}
