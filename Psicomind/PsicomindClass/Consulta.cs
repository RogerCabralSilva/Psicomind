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
        public int Agendamento_id { get; set; }
        public DateTime Data_consulta { get; set; }
        public DateTime Horarios_consulta { get; set; }
        public string Motivos_consultas { get; set; }
        public string Observacoes_consulta { get; set; }
        public bool Status_pagamento { get; set; }

    }
}
