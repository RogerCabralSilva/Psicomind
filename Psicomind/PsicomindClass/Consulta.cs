using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PsicomindClass
{
    public class Consulta
    {

        public int Id { get; set; }
        public int Agendamento_id { get; set; }
        public string Observacoes_consulta { get; set; }
        public string Nome_profissional { get; set; }
        public string Nome_cliente {  get; set; }
        public string Email_cliente { get; set; }
        public DateTime Data_nascimento_cliente { get; set; }
        public DateTime Dia_escala { get; set; }
        public TimeSpan Horario { get; set; }
        public string Status_pagamento { get; set; }
        public string Status_consulta { get; set; }



        public Consulta(int agendamento_id, string observacoes_consulta, string nome_profissional, string nome_cliente, string email_cliente, DateTime data_nascimento_cliente, DateTime dia_escala, string status_pagamento, string status_consulta)
        {
            Agendamento_id = agendamento_id;
            Observacoes_consulta = observacoes_consulta;
            Nome_profissional = nome_profissional;
            Nome_cliente = nome_cliente;
            Email_cliente = email_cliente;
            Data_nascimento_cliente = data_nascimento_cliente;
            Dia_escala = dia_escala;
            Status_pagamento = status_pagamento;
            Status_consulta = status_consulta;
        }

        public Consulta(string nome_profissional, string nome_cliente, string email_cliente, DateTime data_nascimento_cliente, DateTime dia_escala, TimeSpan horario, string status_pagamento, string status_consulta)
        {
            Nome_profissional = nome_profissional;
            Nome_cliente = nome_cliente;
            Email_cliente = email_cliente;
            Data_nascimento_cliente = data_nascimento_cliente;
            Dia_escala = dia_escala;
            Horario = horario;
            Status_pagamento = status_pagamento;
            Status_consulta = status_consulta;
        }

        public Consulta(int agendamento_id, string status_pagamento, string status_consulta)
        {
            Agendamento_id = agendamento_id;
            Status_pagamento = status_pagamento;
            Status_consulta = status_consulta;
        }

        public void Inserir ()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_consultas_insert";
            cmd.Parameters.AddWithValue("spagendamento_id", Agendamento_id);
            cmd.Parameters.AddWithValue("spobservacoes_consulta", Observacoes_consulta);
            cmd.Parameters.AddWithValue("spstatus_pagamento", Status_pagamento);
            cmd.Parameters.AddWithValue("spstatus_consulta", Status_consulta);

            cmd.ExecuteReader();
        }

        public static List<Consulta> ObterLista(string nome_cliente = null, DateTime? dia_escala = null, string? horario = null, string status_consulta = null)
        {
            List<Consulta> lista = new List<Consulta>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;

            // Início da query básica
            string query = "SELECT nome_profissional, nome_cliente, email_cliente, data_nascimento_cliente, dia_escala, horario_escala, status_pagamento, status_consulta FROM vw_consulta_informacoes_cliente WHERE 1=1";

            // Adicionando filtros dinamicamente
            if (nome_cliente != null)
            {
                query += " AND nome_cliente LIKE @nome_cliente";
                cmd.Parameters.AddWithValue("@nome_cliente", $"%{nome_cliente}%");
            }

            if (dia_escala != null)
            {
                query += " AND dia_escala = @dia_escala";
                cmd.Parameters.AddWithValue("@dia_escala", dia_escala.Value);
            }

            if (horario != null)
            {
                query += " AND horario_escala = @horario";
                cmd.Parameters.AddWithValue("@horario", horario);
            }

            if (status_consulta != null)
            {
                query += " AND status_consulta = @status_consulta";
                cmd.Parameters.AddWithValue("@status_consulta", status_consulta);
            }

            // Atribuindo a query ao comando
            cmd.CommandText = query;

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Consulta(
                    dr.GetString(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDateTime(3),
                    dr.GetDateTime(4),
                    dr.GetTimeSpan(5),
                    dr.GetString(6),
                    dr.GetString(7)
                ));
            }

            return lista;
        }

    }
}
