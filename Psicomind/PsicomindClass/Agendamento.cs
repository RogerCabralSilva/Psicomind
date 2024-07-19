using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicomindClass
{
    public class Agendamento
    {
        public int Id { get; set; }
        public int Profissionais_id { get; set; }
        public int Escala_id {  get; set; }
        public TipoAgendamento Tipo_agendamento_id { get; set; }
        public bool Status_agendamento { get; set; }

    }
}
