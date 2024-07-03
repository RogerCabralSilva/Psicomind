using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicomindClass
{
    public class TipoAgendamento
    {
        public int Id { get; set; }
        public string Tipo_Agendamento { get; set; }

        public TipoAgendamento()
        {

        }

        public TipoAgendamento(int id, string tipo_Agendamento)
        {
            Id = id;
            Tipo_Agendamento = tipo_Agendamento;
        }
    }
}
