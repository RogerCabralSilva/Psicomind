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
        public Agendamento Agendamento_id { get; set; }
        public string Observacoes_consulta { get; set; }
        public bool Status_pagamento { get; set; }
        public string Status_consulta { get; set; }
        public string Nome_profissional { get; set; }
        public string Nome_cliente {  get; set; }
        public string Email { get; set; }
        public string data_nascimento_cliente { get; set; }
        public string 

        public void Inserir ()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_consultas_insert";
            cmd.Parameters.AddWithValue("spagendamento_id", Agendamento_id.Id);
            cmd.Parameters.AddWithValue("spobservacoes_consulta", Observacoes_consulta);
            cmd.Parameters.AddWithValue("spstatus_pagamento", Status_pagamento);
            cmd.Parameters.AddWithValue("spstatus_consulta", Status_consulta);
        }

        public static List<Consulta> ObterLista(string nome = null, string status_agendamento = null) 
        {
            List<Consulta> lista = new List<Consulta>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;

            if (nome == null)
            {
                cmd.CommandText = "select nome_profissional, nome_cliente, email_cliente, data_nascimento_cliente, dia_escala, horario_escala, status_pagamento, status_consulta from vw_consulta_informacoes_cliente;";
            }
            else
            {
                cmd.CommandText = $"SELECT * FROM cliente_info WHERE nome LIKE '%{nome}%' ";
            }

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Consulta(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDateTime(5),
                    dr.GetDateTime(6),
                    dr.GetBoolean(7),
                    Genero.ObterPorId(dr.GetInt32(8)),
                    Endereco.ObterPorId(dr.GetInt32(9)),
                    TelefoneCliente.ObterPorId(dr.GetInt32(10))
                    ));
            }

            return lista;
        }
    }
}
