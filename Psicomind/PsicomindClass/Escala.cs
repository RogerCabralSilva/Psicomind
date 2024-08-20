using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PsicomindClass
{
    public class Escala
    {
        public int Id { get; set; }

        public DateTime Dia { get; set; }
        public DateTime Horario { get; set; }
        public Boolean Disponivel { get; set; }
        public Profissional Profissional { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioFinal { get; set; }
        public int Duracao { get; set; }

        public Escala()
        {

        }

        public Escala(int id, Profissional profissional, DateTime dia, DateTime horario, bool disponivel)
        {
            Id = id;
            Profissional = profissional;
            Dia = dia;
            Horario = horario;
            Disponivel = disponivel;
        }

        public Escala(Profissional profissional, DateTime dia, DateTime horario, bool disponivel)
        {
            Profissional = profissional;
            Dia = dia;
            Horario = horario;
            Disponivel = disponivel;
        }

        public Escala(Profissional profissional, DateTime dia, DateTime horario, bool disponivel, int duracao)
        {
            Profissional = profissional;
            Dia = dia;
            Horario = horario;
            Disponivel = disponivel;
            Duracao = duracao;
        }

        public Escala(Profissional profissional, DateTime dataInicio, DateTime dataFinal, DateTime horarioInicio, DateTime horarioFinal, int duracao)
        {
            Profissional = profissional;
            DataInicio = dataInicio;
            DataFinal = dataFinal;
            HorarioInicio = horarioInicio;
            HorarioFinal = horarioFinal;
            Duracao = duracao;
        }

        public Escala(bool disponivel)
        {
            Disponivel = disponivel;
        }

        public Escala(DateTime horario)
        {
            Horario = horario;
        }

        public void Inserir()
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InserirHorariosSemana";

            cmd.Parameters.AddWithValue("data_inicio", DataInicio);
            cmd.Parameters.AddWithValue("data_fim", DataFinal);
            cmd.Parameters.AddWithValue("horario_inicio", HorarioInicio);
            cmd.Parameters.AddWithValue("horario_fim", HorarioFinal);
            cmd.Parameters.AddWithValue("intervalo_minutos",Duracao);
            cmd.Parameters.AddWithValue("profissional_id", Profissional.Id);

            cmd.ExecuteNonQuery();

        }

        public static List<Escala> ObterLIstaHorarios(string data)
        {
            List<Escala> lista = new List<Escala>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT horario FROM Escala where dispoivel = 1 and dia = '{data}';";

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Escala(
                        dr.GetDateTime(0)
                    ));
            }

            return lista;
        }

        public static Escala ObterPorDisponivelId(int id)
        {
            Escala calendario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT dispoivel FROM Escala where id = 1;";

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                calendario = (new Escala(
                        dr.GetBoolean(0)));

            }

            return calendario;
        }

        public bool Editar(int id)
        {
            var dr = Banco.Abrir();
            dr.CommandType = CommandType.Text;
            dr.CommandText = $"UPDATE Escala SET dispoivel = 0 where id = {id}";


            return dr.ExecuteNonQuery() > -1 ? true : false;
        }

    }
}
