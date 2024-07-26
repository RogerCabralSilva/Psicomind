using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicomindClass
{
    public class Escala
    {
        public int Id { get; set; }
        public DateTime Data_inicio { get; set; }
        public DateTime Data_final {  get; set; }
        public DateTime Horario_comeco { get; set; }
        public DateTime Horario_fim { get; set; }
        public int Profissional_id { get; set; }
        public int Vagas_quantidade { get; set; }
        public Agendamento_Indisponivel Agend_indisponivel { get; set; }

        public Ferias Ferias { get; set; }
    }
}
