using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PsicomindClass
{
    public class Calendario
    {

        public int Id { get; set; }
        public DateTime Dia { get; set; }
        public TimeSpan Horario { get; set; }
        public bool Disponivel { get; set; }

        public Calendario () { }

        public Calendario(TimeSpan horario)
        {
            Horario = horario;
        }

        public Calendario(bool disponivel)
        {
            Disponivel = disponivel;
        }

        public static List<Calendario> ObterLIstaHorarios(string data)
        {
            List<Calendario> lista = new List<Calendario>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT horario FROM calendario where dispoivel = 1 and dia = '{data}';";

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Calendario(
                        dr.GetTimeSpan(0)
                    ));
            }

            return lista;
        }

        public static Calendario ObterPorDisponivelId(int id)
        {
            Calendario calendario = new ();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT dispoivel FROM calendario where id = 1;";

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                calendario = (new Calendario(
                        dr.GetBoolean(0)));
                   
            }

            return calendario;
        }

        public bool Editar (int id)
        {
            var dr = Banco.Abrir();
            dr.CommandType = CommandType.Text;
            dr.CommandText = $"UPDATE calendario SET dispoivel = 0 where id = {id}";
            

            return dr.ExecuteNonQuery() > -1 ? true : false;
        }
    }
}