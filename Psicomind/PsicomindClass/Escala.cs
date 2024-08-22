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
        public TimeSpan Horario { get; set; }
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

        public Escala(int id, Profissional profissional, DateTime dia, TimeSpan horario, bool disponivel)
        {
            Id = id;
            Profissional = profissional;
            Dia = dia;
            Horario = horario;
            Disponivel = disponivel;
        }

        public Escala(Profissional profissional, DateTime dia, TimeSpan horario, bool disponivel)
        {
            Profissional = profissional;
            Dia = dia;
            Horario = horario;
            Disponivel = disponivel;
        }

        public Escala(Profissional profissional, DateTime dia, TimeSpan horario, bool disponivel, int duracao)
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

        public Escala(TimeSpan horario)
        {
            Horario = horario;
        }

        public Escala(DateTime dia, TimeSpan horario)
        {
            Dia = dia;
            Horario = horario;
        }

        public Escala(DateTime dia)
        {
            Dia = dia;
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
            cmd.Parameters.AddWithValue("id_profissional", Profissional.Id);

            cmd.ExecuteScalar();

        }

        public static List<Escala> ObterLIstaHorarios(string data, int id)
        {
            List<Escala> lista = new List<Escala>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT horario FROM escala where disponivel = 1 and dia = '{data}' and profissional_id = {id};";

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Escala(
                        dr.GetTimeSpan(0)
                    ));
            }

            return lista;
        }

        public static List<Escala> ObterTodosOsDias(int id)
        {
            List<Escala> lista = new List<Escala>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT dia FROM escala WHERE disponivel = 1 and profissional_id = {id};";

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
            cmd.CommandText = $"SELECT disponivel FROM Escala where id = 1;";

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
            dr.CommandText = $"UPDATE Escala SET disponivel = 0 where id = {id}";


            return dr.ExecuteNonQuery() > -1 ? true : false;
        }

        public static List<Escala> ObterListaProfissional(int id)
        {
            List<Escala> lista = new List<Escala>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT dia, horario FROM escala where disponivel = 1 and profissional_id = '{id}';";

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Escala(
                        dr.GetDateTime(0),
                        dr.GetTimeSpan(1)
                    ));
            }

            return lista;
        }

        public static void Deletar (string date, string horario) 
        { 
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"delete from escala where dia = '{date}' and horario = '{horario}'";
            cmd.ExecuteReader();
        }

        public static Escala ObterIdDataHorario (string data, string horario, int id) 
        {
            Escala codigo = new Escala();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select id from escala where dia = '{data}' and horario = '{horario}' and profissional_id = {id}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dr.GetInt32(0);
            }

            return codigo;
        }

    }
}
