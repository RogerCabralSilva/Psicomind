using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicomindClass
{
    public class Agendamento_Indisponivel
    {
        public int Id { get; set; }
        public DateTime Datas_excluidas { get; set; }
        public string Motivo_indisponivel { get; set; }
    }
}
