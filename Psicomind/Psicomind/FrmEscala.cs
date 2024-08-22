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


            //var user = Usuario.ObterListaPsicologo();
            //cmbProfissionais.DataSource = user;
            //cmbProfissionais.DisplayMember = "nome";
            //cmbProfissionais.ValueMember = "id";

            var profissional = Profissional.ObterLista();
            cmbProfissionais.DataSource = profissional;
            cmbProfissionais.DisplayMember = "nome";
            cmbProfissionais.ValueMember = "id";
            
            cmbProfissionais.SelectedValue = 0;

        }

        private void cmbProfissionais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            int profissionalId = Convert.ToInt32(cmbProfissionais.SelectedValue);

            if (cmbProfissionais.SelectedValue == null)
            {
                MessageBox.Show("Selecione um profissional para incluir sua escala", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!mskHorarioInicio.MaskFull || mskHorarioInicio.Text.Contains('_'))
            {
                MessageBox.Show("O horário de inicio deve ser indicado para incluir sua escala", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!mskHorarioFinal.MaskFull || mskHorarioFinal.Text.Contains('_'))
            {
                MessageBox.Show("O horário de final deve ser indicado para incluir sua escala", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnDuracao.Value == 0)
            {
                MessageBox.Show("Insira a duração da sua consulta para incluir sua escala", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
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
                MessageBox.Show("Escala Inserida com sucesso!!!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show($"Não foi possível inserir escala: {ex.Message}");
                return; // Abort if insertion fails
            }

            // Criar e exibir o FrmShowEscala com o ID da escala
            FrmShowEscala frmShowEscala = new(profissionalId);
            frmShowEscala.StartPosition = FormStartPosition.CenterScreen;
            frmShowEscala.Show();

            mskHorarioInicio.Clear();
            mskHorarioFinal.Clear();
            cmbProfissionais.SelectedValue = 0;
            btnDuracao.Value = 0;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            FrmProfissionalMenu frmProfissionalMenu = new();
            frmProfissionalMenu.StartPosition = FormStartPosition.CenterScreen;
            frmProfissionalMenu.Show();

            this.Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            int profissionalId = Convert.ToInt32(cmbProfissionais.SelectedValue);

            FrmShowEscala frmShowEscala = new(profissionalId);
            frmShowEscala.StartPosition = FormStartPosition.CenterScreen;
            frmShowEscala.Show();

        }
    }
}
