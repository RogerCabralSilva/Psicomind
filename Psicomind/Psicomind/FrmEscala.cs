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
    public partial class FrmEscala : Form
    {
        public FrmEscala()
        {
            InitializeComponent();
        }

        private void txtClienteId_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEscala_Load(object sender, EventArgs e)
        {

            var profissional = Profissional.ObterLista();
            cmbProfissionais.DataSource = profissional;
            cmbProfissionais.DisplayMember = "nome";
            cmbProfissionais.ValueMember = "id";

        }

        private void cmbProfissionais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {


            Escala escala = new(
               Profissional.ObterPorId(Convert.ToInt32(cmbProfissionais.SelectedValue)),
               dtpDataInicio.Value,
               dtpDataFinal.Value,
               Convert.ToDateTime(mskHorarioInicio.Text),
               Convert.ToDateTime(mskHorarioFinal.Text),
               Convert.ToInt32(btnDuracao.Value)
                );

            try
            {
                escala.Inserir();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show($"Não foi possível inserir escala {ex}");
            }

            MessageBox.Show("Escala Inserida com sucesso!!!");

            FrmShowEscala frmShowEscala = new();
           

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            FrmProfissionalMenu frmProfissionalMenu = new();
            frmProfissionalMenu.StartPosition = FormStartPosition.CenterScreen;
            frmProfissionalMenu.Show();

            this.Close();

        }
    }
}
