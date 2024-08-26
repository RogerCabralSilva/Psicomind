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
using System.Diagnostics;

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
                dgvClientesDados.Rows[count].Cells[0].Value = consulta.Id;
                dgvClientesDados.Rows[count].Cells[1].Value = consulta.Nome_profissional;
                dgvClientesDados.Rows[count].Cells[2].Value = consulta.Nome_cliente;
                dgvClientesDados.Rows[count].Cells[3].Value = consulta.Email_cliente;
                dgvClientesDados.Rows[count].Cells[4].Value = consulta.Data_nascimento_cliente;
                dgvClientesDados.Rows[count].Cells[5].Value = consulta.Dia_escala;
                dgvClientesDados.Rows[count].Cells[6].Value = consulta.Horario;
                dgvClientesDados.Rows[count].Cells[7].Value = consulta.Status_pagamento;
                dgvClientesDados.Rows[count].Cells[8].Value = consulta.Status_consulta;

                count++;
            }
        }

        private void btnConsultarConsulta_Click(object sender, EventArgs e)
        {
            string formatada = dtpDataConsulta.Value.ToString("yyyy/MM/dd");

            if (mskHorarioConsulta.Text == "  :")
            {

                var consultas = Consulta.ObterLista(txtNomeConsulta.Text, txtEmailConsulta.Text, formatada, cmbTipoAgendamento.SelectedItem.ToString()); ;

                // laço para efetuar o preenchimento
                dgvClientesDados.Rows.Clear();
                int count = 0;
                foreach (var consulta in consultas)
                {
                   

                    int rowIndex = dgvClientesDados.Rows.Add();
                    dgvClientesDados.Columns["clnDataNascimentoCliente"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvClientesDados.Columns["clnDia"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvClientesDados.Rows[count].Cells[0].Value = consulta.Id;
                    dgvClientesDados.Rows[count].Cells[1].Value = consulta.Nome_profissional;
                    dgvClientesDados.Rows[count].Cells[2].Value = consulta.Nome_cliente;
                    dgvClientesDados.Rows[count].Cells[3].Value = consulta.Email_cliente;
                    dgvClientesDados.Rows[count].Cells[4].Value = consulta.Data_nascimento_cliente;
                    dgvClientesDados.Rows[count].Cells[5].Value = consulta.Dia_escala;
                    dgvClientesDados.Rows[count].Cells[6].Value = consulta.Horario;
                    dgvClientesDados.Rows[count].Cells[7].Value = consulta.Status_pagamento;
                    dgvClientesDados.Rows[count].Cells[8].Value = consulta.Status_consulta;

                    count++;
                }
            }
            else
            {
                var consultas = Consulta.ObterLista(txtNomeConsulta.Text, formatada, txtEmailConsulta.Text, mskHorarioConsulta.Text);

                // laço para efetuar o preenchimento
                dgvClientesDados.Rows.Clear();
                int a = 0;
                foreach (var consulta in consultas)
                {
                    int rowIndex = dgvClientesDados.Rows.Add();
                    dgvClientesDados.Columns["clnDataNascimentoCliente"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvClientesDados.Columns["clnDia"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvClientesDados.Rows[a].Cells[0].Value = consulta.Id;
                    dgvClientesDados.Rows[a].Cells[1].Value = consulta.Nome_profissional;
                    dgvClientesDados.Rows[a].Cells[2].Value = consulta.Nome_cliente;
                    dgvClientesDados.Rows[a].Cells[3].Value = consulta.Email_cliente;
                    dgvClientesDados.Rows[a].Cells[4].Value = consulta.Data_nascimento_cliente;
                    dgvClientesDados.Rows[a].Cells[5].Value = consulta.Dia_escala;
                    dgvClientesDados.Rows[a].Cells[6].Value = consulta.Horario;
                    dgvClientesDados.Rows[a].Cells[7].Value = consulta.Status_pagamento;
                    dgvClientesDados.Rows[a].Cells[8].Value = consulta.Status_consulta;

                    a++;
                }
            }



        }

        private void btnListarTudo(object sender, EventArgs e)
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
                dgvClientesDados.Rows[count].Cells[0].Value = consulta.Id;
                dgvClientesDados.Rows[count].Cells[1].Value = consulta.Nome_profissional;
                dgvClientesDados.Rows[count].Cells[2].Value = consulta.Nome_cliente;
                dgvClientesDados.Rows[count].Cells[3].Value = consulta.Email_cliente;
                dgvClientesDados.Rows[count].Cells[4].Value = consulta.Data_nascimento_cliente;
                dgvClientesDados.Rows[count].Cells[5].Value = consulta.Dia_escala;
                dgvClientesDados.Rows[count].Cells[6].Value = consulta.Horario;
                dgvClientesDados.Rows[count].Cells[7].Value = consulta.Status_pagamento;
                dgvClientesDados.Rows[count].Cells[8].Value = consulta.Status_consulta;

                count++;
            }

            FrmAgendamentoConsulta_Load(sender, e);
        }

        private void dgvClientesDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Verifica se a linha e a coluna clicadas são válidas
            {
                DataGridViewRow row = dgvClientesDados.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["clnId"].Value); // Obtém o ID da consulta

                // Verifica se a célula clicada é um botão de "Concluir"
                if (dgvClientesDados.Columns[e.ColumnIndex].Name == "btnConcluir")
                {
                    // Chama o método Editar passando o texto "Concluir" e o ID da consulta
                    Consulta.Atualizar("Concluída", id);
                }
                // Verifica se a célula clicada é um botão de "Cancelar"
                else if (dgvClientesDados.Columns[e.ColumnIndex].Name == "btnCancelar")
                {
                    // Chama o método Editar passando o texto "Cancelar" e o ID da consulta
                    Consulta.Atualizar("Cancelada", id);
                }
            }
            else
            {
                MessageBox.Show("A ação selecionada não é válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FrmAgendamentoConsulta_Load(sender, e);
        }
    }
}
