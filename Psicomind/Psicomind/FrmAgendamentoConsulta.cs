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
    public partial class FrmAgendamentoConsulta : Form
    {
        public FrmAgendamentoConsulta()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAgendamentoConsulta_Load(object sender, EventArgs e)
        {
            var consultas = Consulta.ObterLista();
            int count = 0;

            // laço para efetuar o preenchimento
            dgvClientesDados.Rows.Clear();
            foreach (var consulta in consultas)
            {

                int rowIndex = dgvClientesDados.Rows.Add();
                dgvClientesDados.Columns["clnDataNascimentoCliente"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvClientesDados.Columns["clnDia"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvClientesDados.Rows[count].Cells[0].Value = consulta.Nome_profissional;
                dgvClientesDados.Rows[count].Cells[1].Value = consulta.Nome_cliente;
                dgvClientesDados.Rows[count].Cells[2].Value = consulta.Email_cliente;
                dgvClientesDados.Rows[count].Cells[3].Value = consulta.Data_nascimento_cliente;
                dgvClientesDados.Rows[count].Cells[4].Value = consulta.Dia_escala;
                dgvClientesDados.Rows[count].Cells[5].Value = consulta.Horario;
                dgvClientesDados.Rows[count].Cells[6].Value = consulta.Status_pagamento;
                dgvClientesDados.Rows[count].Cells[7].Value = consulta.Status_consulta;

                count++;
            }

        }

        private void btnConsultarConsulta_Click(object sender, EventArgs e)
        {
            var consultas = Consulta.ObterLista(txtNomeConsulta.Text, dtpDataConsulta.Value, txtEmailConsulta.Text, mskHorarioConsulta.Text);
            int count = 0;

            // laço para efetuar o preenchimento
            dgvClientesDados.Rows.Clear();
            foreach (var consulta in consultas)
            {

                int rowIndex = dgvClientesDados.Rows.Add();
                dgvClientesDados.Columns["clnDataNascimentoCliente"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvClientesDados.Columns["clnDia"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvClientesDados.Rows[count].Cells[0].Value = consulta.Nome_profissional;
                dgvClientesDados.Rows[count].Cells[1].Value = consulta.Nome_cliente;
                dgvClientesDados.Rows[count].Cells[2].Value = consulta.Email_cliente;
                dgvClientesDados.Rows[count].Cells[3].Value = consulta.Data_nascimento_cliente;
                dgvClientesDados.Rows[count].Cells[4].Value = consulta.Dia_escala;
                dgvClientesDados.Rows[count].Cells[5].Value = consulta.Horario;
                dgvClientesDados.Rows[count].Cells[6].Value = consulta.Status_pagamento;
                dgvClientesDados.Rows[count].Cells[7].Value = consulta.Status_consulta;

                count++;
            }
        }
    }
}
