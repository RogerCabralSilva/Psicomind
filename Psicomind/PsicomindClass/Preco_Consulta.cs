using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicomindClass
{
    public class Preco_Consulta
    {
        public int Id { get; set; }
        public float Preco { get; set; }
        public TipoAgendamento Tipo_agendamento { get; set; }
    }
}
