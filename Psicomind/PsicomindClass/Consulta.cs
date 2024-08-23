using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicomindClass
{
    public class Consulta
    {


        public int Id { get; set; }
        public Agendamento Agendamento_id { get; set; }
        public string Observacoes_consulta { get; set; }
        public bool Status_pagamento { get; set; }
        public string Status_consulta { get; set; }

        public Consulta(int id, Agendamento agendamento_id, string observacoes_consulta, bool status_pagamento, string status_consulta)
        {
            Id = id;
            Agendamento_id = agendamento_id;
            Observacoes_consulta = observacoes_consulta;
            Status_pagamento = status_pagamento;
            Status_consulta = status_consulta;
        }

        public void Inserir ()
        {

        }
    }
}
