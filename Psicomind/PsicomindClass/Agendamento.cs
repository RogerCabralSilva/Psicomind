using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicomindClass
{
    public class Agendamento
    {
        
        public int Id { get; set; }
        public Profissional Profissional { get; set; }
        public Usuario Usuario { get; set; }
        public Escala Escala { get; set; }
        public Cliente Cliente { get; set; }
        public TipoAgendamento Tipo_agendamento_id { get; set; }
        public bool Status_agendamento { get; set; }
        

       

        public Agendamento()
        {

        }

        public Agendamento(int id, Profissional profissional, Usuario usuario, Escala escala, Cliente cliente, TipoAgendamento tipo_agendamento_id, bool status_agendamento)
        {
            Id = id;
            Profissional = profissional;
            Usuario = usuario;
            Escala = escala;
            Cliente = cliente;
            Tipo_agendamento_id = tipo_agendamento_id;
            Status_agendamento = status_agendamento;
        }

        public Agendamento(Profissional profissional, Usuario usuario, Escala escala, Cliente cliente, TipoAgendamento tipo_agendamento_id, bool status_agendamento)
        {
            Profissional = profissional;
            Usuario = usuario;
            Escala = escala;
            Cliente = cliente;
            Tipo_agendamento_id = tipo_agendamento_id;
            Status_agendamento = status_agendamento;
        }

        public void Inserir()
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_agendamentos_insert";

            cmd.Parameters.AddWithValue("spprofissional_id", Profissional.Id);
            cmd.Parameters.AddWithValue("spusuarios_id", Usuario.Id);
            cmd.Parameters.AddWithValue("spescala_id", Escala.Id);
            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id);
            cmd.Parameters.AddWithValue("sptipo_agendamento_id", Tipo_agendamento_id.Id);
            cmd.Parameters.AddWithValue("spstatus_agendamento", Status_agendamento);

            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }




    }
}
