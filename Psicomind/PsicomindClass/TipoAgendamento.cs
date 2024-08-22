using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PsicomindClass
{
    public class TipoAgendamento
    {
        public int Id { get; set; }
        public string Tipo_Agendamento { get; set; }
        public Preco_Consulta Preco_Consulta { get; set; }
        
        public TipoAgendamento(int id, string tipo_Agendamento, Preco_Consulta preco_Consulta)
        {
            Id = id;
            Tipo_Agendamento = tipo_Agendamento;
            Preco_Consulta = preco_Consulta;
        }

        public TipoAgendamento(string tipo_Agendamento, Preco_Consulta preco_Consulta)
        {
            Tipo_Agendamento = tipo_Agendamento;
            Preco_Consulta = preco_Consulta;
        }

        public TipoAgendamento(int id)
        {
            Id = id;
        }

        

        public TipoAgendamento()
        {

        }

        public static TipoAgendamento ObterPorId(int id)
        {

            TipoAgendamento tipoAgendamento = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"SELECT * FROM tipo_agendamento WHERE id = {id}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                tipoAgendamento = (new TipoAgendamento(

                    dr.GetInt32(0),
                    dr.GetString(1),
                    Preco_Consulta.ObterPorId(Convert.ToInt32(dr.GetInt32(2)))
                    ));
                ;

            }

            return tipoAgendamento;

        }

        public static List<TipoAgendamento> ObterLista(string nome = null)
        {

            List<TipoAgendamento> tipoAgendamento = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "SELECT * FROM tipo_agendamento";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                tipoAgendamento.Add(new(

                    dr.GetInt32(0),
                    dr.GetString(1),
                    Preco_Consulta.ObterPorId(Convert.ToInt32(dr.GetInt32(2)))

                    ));

            }

            return tipoAgendamento;

        }


    }
}
