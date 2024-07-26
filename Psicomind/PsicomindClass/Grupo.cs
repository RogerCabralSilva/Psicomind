using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicomindClass
{
    public class Grupo
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public int Maximo_pessosas { get; set; }
    }
}
