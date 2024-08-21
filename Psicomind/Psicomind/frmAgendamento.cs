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
        // Lista de datas com agendamentos disponíveis
        private DateTime[] datasComAgendamentos;

        private void frmAgendamento_Load(object sender, EventArgs e)
        {
            // Inicializa os dados no ComboBox de profissionais
            var profissional = Profissional.ObterLista();
            cmbProfissionais.DataSource = profissional;
            cmbProfissionais.DisplayMember = "nome";
            cmbProfissionais.ValueMember = "id";

            // Obtém a lista de datas com agendamentos disponíveis e converte para array
            var listaDias = Escala.ObterTodosOsDias(); // Supondo que retorna uma lista de DateTime
            datasComAgendamentos = listaDias.ToArray(); // Converte a lista para um array

            // Destaca as datas com agendamentos disponíveis
            mcAgendamento.BoldedDates = datasComAgendamentos;
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
