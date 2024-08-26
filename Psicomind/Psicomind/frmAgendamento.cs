using PsicomindClass;
using Syncfusion.WinForms.Input;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace Psicomind
{
    public partial class frmAgendamento : Form
    {

        private Preco_Consulta Preco_Consulta;
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

            var tipoAgendamento = TipoAgendamento.ObterLista();
            cmbTipoAgendamento.DataSource = tipoAgendamento;
            cmbTipoAgendamento.DisplayMember = "tipo_agendamento";
            cmbTipoAgendamento.ValueMember = "id";

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

        private void cmbProfissionais_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Atualiza as datas do calendário quando o profissional selecionado mudar
            AtualizarDatasCalendario();
        }

        private void cmbTipoAgendamento_SelectedValueChanged(object sender, EventArgs e)
        {
            int tipoAgendamento_id = cmbTipoAgendamento.SelectedIndex + 1;
            Preco_Consulta r = Preco_Consulta.ObterPorId(tipoAgendamento_id);


            decimal preco = 200m;
            string valorFormatado = preco.ToString("N2");
            txtPreco.Text = valorFormatado.ToString();

        }

        private void btnEfetuarAgendamento_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dataSelecionada = sfCalendar1.SelectedDate.Value;
                string dataFormatada = dataSelecionada.ToString("yyyy-MM-dd");
                string horario = Convert.ToString(cmbHorarios.Text);
                string profissional = cmbProfissionais.Text; // Nome do profissional
                string tipoAgendamento = cmbTipoAgendamento.Text; // Tipo de agendamento
                decimal valorFormatado = Convert.ToDecimal(txtPreco.Text); // Preço do agendamento

                var codigo = Escala.ObterIdDataHorario(dataFormatada, horario, Convert.ToInt32(cmbProfissionais.SelectedValue));
                int tipoAgendamento_id = cmbTipoAgendamento.SelectedIndex + 1;
                mtxCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                Agendamento agendamento = new(
                    Profissional.ObterPorId(Convert.ToInt32(cmbProfissionais.SelectedValue)),
                    Usuario.ObterPorId(Program.Usuario.Id),
                    codigo,
                    Cliente.ObterPorCpf(mtxCpf.Text),
                    TipoAgendamento.ObterPorId(Convert.ToInt32(cmbTipoAgendamento.SelectedValue)),
                    true
                );
                agendamento.Inserir();
                Escala.DarBaixa(dataFormatada, horario, Convert.ToInt32(cmbProfissionais.SelectedValue));

                Consulta consulta = new(agendamento.Id, "1", "Agendada");
                consulta.Inserir();

                // Envia o e-mail de confirmação

                string dataFormatadaEmail = dataSelecionada.ToString("dd/MM/yyyy");
                EnviarEmailConfirmacao(agendamento.Cliente.Email, dataFormatadaEmail, horario, valorFormatado, tipoAgendamento, profissional);

            }

            catch
            {
                MessageBox.Show($"Erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // limpa Campos 
            cmbProfissionais.SelectedIndex = -1;
            cmbHorarios.SelectedIndex = -1;
            cmbTipoAgendamento.SelectedIndex = -1;
            txtPreco.Clear();
            mtxCpf.Clear();
        }

        private void EnviarEmailConfirmacao(string emailCliente, string data, string horario, decimal preco, string tipoAgendamento, string profissional)
        {
            try
            {


                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("cabralroger159@gmail.com", "bbpd akhw yngi fgyk");

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("cabralroger159@gmail.com");
                mailMessage.To.Add("henrygabrielfiore@gmail.com");
                mailMessage.Subject = "Confirmação de Agendamento";
                mailMessage.Body = $"Olá, \n\nSeu agendamento foi confirmado com as seguintes informações:\n\n" +
                                   $"Data: {data}\nHorário: {horario}\nPreço: R$ {preco}\nTipo: {tipoAgendamento}\nProfissional: {profissional}\n\n" +
                                   "Aguardamos você no dia e horário agendado.\n\nAtenciosamente,\nSua Empresa";

                client.Send(mailMessage);
                MessageBox.Show("Agendamento realizado e e-mail de confirmação enviado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar e-mail: " + ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
