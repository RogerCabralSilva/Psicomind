using PsicomindClass;
using Syncfusion.WinForms.Input;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Psicomind
{
    public partial class frmAgendamento : Form
    {
        public frmAgendamento()
        {
            InitializeComponent();
            toolTip1 = new ToolTip();
        }

        private void frmAgendamento_Load(object sender, EventArgs e)
        {
            var profissional = Profissional.ObterLista();
            cmbProfissionais.DataSource = profissional;
            cmbProfissionais.DisplayMember = "nome";
            cmbProfissionais.ValueMember = "id";

            sfCalendar1.FirstDayOfWeek = System.DayOfWeek.Monday;

            // Chamamos o método para atualizar as datas de acordo com o profissional selecionado
            AtualizarDatasCalendario();
        }

        // Método para atualizar as datas no calendário com base no profissional selecionado
        private void AtualizarDatasCalendario()
        {
            if (cmbProfissionais.SelectedValue == null) return;

            // Converta o SelectedValue para int de forma segura
            int profissionalId;
            if (int.TryParse(cmbProfissionais.SelectedValue.ToString(), out profissionalId))
            {
                List<Escala> listaDias = Escala.ObterTodosOsDias(profissionalId);

                // Limpa as datas especiais antes de adicionar as novas
                sfCalendar1.SpecialDates.Clear();

                List<SpecialDate> specialDates = new List<SpecialDate>();
                foreach (var escala in listaDias)
                {
                    specialDates.Add(new SpecialDate
                    {
                        BackColor = Color.FromArgb(32, 113, 227),
                        ForeColor = Color.White,
                        Value = escala.Dia
                    });
                }

                sfCalendar1.SpecialDates.AddRange(specialDates);
            }
        }


        private void btnConsultarProfissional_Click(object sender, EventArgs e)
        {
            DateTime dataSelecionada = sfCalendar1.SelectedDate.Value;
            string dataFormatada = dataSelecionada.ToString("yyyy-MM-dd");
            var calendario = Escala.ObterLIstaHorarios(dataFormatada, Convert.ToInt32(cmbProfissionais.SelectedValue));

            cmbHorarios.DataSource = calendario;
            cmbHorarios.DisplayMember = "horario";
            cmbHorarios.ValueMember = "id";
        }

        private void sfCalendar1_Click(object sender, EventArgs e)
        {
            // Lógica adicional se necessário
        }

        private void cmbProfissionais_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Atualiza as datas do calendário quando o profissional selecionado mudar
            AtualizarDatasCalendario();
        }

        private void cmbHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
