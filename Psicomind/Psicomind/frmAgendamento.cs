﻿using PsicomindClass;
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
    public partial class frmAgendamento : Form
    {
        public frmAgendamento()
        {
            InitializeComponent();
        }


        private void frmAgendamento_Load(object sender, EventArgs e)
        {

            var profissional = Profissional.ObterLista();
            cmbProfissionais.DataSource = profissional;
            cmbProfissionais.DisplayMember = "nome";
            cmbProfissionais.ValueMember = "id";



        }



        private void btn1_Click(object sender, EventArgs e)
        {
            var disp = Calendario.ObterPorDisponivelId(1);
            Calendario calendario = new(false);
            calendario.Editar(1);


        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnConsultarProfissional_Click(object sender, EventArgs e)
        {
            string dataFormatada = dtpDataAgendamento.Value.Date.ToString("yyyy-MM-dd");
            var calendario = Calendario.ObterLIstaHorarios(dataFormatada);

            cmbHorarios.DataSource = calendario;
            cmbHorarios.DisplayMember = "horario";
            cmbHorarios.ValueMember = "id";

            frmAgendamento_Load(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtpDataAgendamento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

