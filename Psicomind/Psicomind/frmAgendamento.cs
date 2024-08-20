using PsicomindClass;
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
            // Inicialize o ToolTip
            toolTip1 = new ToolTip();
        }

        // Lista de datas com agendamentos disponíveis
        private DateTime[] datasComAgendamentos = new DateTime[]
        {
            new DateTime(2024, 8, 22),
            new DateTime(2024, 8, 25),
            new DateTime(2024, 9, 1)
        };

        private void frmAgendamento_Load(object sender, EventArgs e)
        {
            // Inicializa os dados no ComboBox de profissionais
            var profissional = Profissional.ObterLista();
            cmbProfissionais.DataSource = profissional;
            cmbProfissionais.DisplayMember = "nome";
            cmbProfissionais.ValueMember = "id";

            // Destaca as datas com agendamentos disponíveis
            mcAgendamento.BoldedDates = datasComAgendamentos;

            // Customiza o MonthCalendar
            CustomizeMonthCalendar();
        }

        private void CustomizeMonthCalendar()
        {
            // Configura a aparência do MonthCalendar
            mcAgendamento.BackColor = Color.WhiteSmoke; // Cor de fundo
            mcAgendamento.ForeColor = Color.DarkBlue; // Cor do texto
            mcAgendamento.TitleBackColor = Color.LightSkyBlue; // Cor de fundo do título
            mcAgendamento.TitleForeColor = Color.White; // Cor do texto do título

            // Adiciona tooltips às datas com agendamentos
            foreach (DateTime date in datasComAgendamentos)
            {
                // Configura o tooltip para o MonthCalendar
                toolTip1.SetToolTip(mcAgendamento, $"Data: {date.ToShortDateString()} - Agendamento Disponível");
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            var disp = Calendario.ObterPorDisponivelId(1);
            Calendario calendario = new(false);
            calendario.Editar(1);
        }

        private void btnConsultarProfissional_Click(object sender, EventArgs e)
        {
            string dataFormatada = mcAgendamento.SelectionStart.ToString("yyyy-MM-dd");
            var calendario = Escala.ObterLIstaHorarios(dataFormatada);

            cmbHorarios.DataSource = calendario;
            cmbHorarios.DisplayMember = "horario";
            cmbHorarios.ValueMember = "id";

            frmAgendamento_Load(sender, e);
        }

        private void mcAgendamento_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Destaca as datas com agendamentos disponíveis
            mcAgendamento.BoldedDates = datasComAgendamentos;
        }
    }
}
