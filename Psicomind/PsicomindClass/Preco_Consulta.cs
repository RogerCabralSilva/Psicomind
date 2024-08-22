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
        public double Preco { get; set; }
        
        public Preco_Consulta(double preco)
        {
            Preco = preco;
        }

        public Preco_Consulta(int id, double preco)
        {
            Id = id;
            Preco = preco;
        }

        public Preco_Consulta()
        {

        }



        public static Preco_Consulta ObterPorId(int id)
        {

            Preco_Consulta preco_Consulta = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"SELECT preco FROM preco_consulta WHERE id = {id}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                preco_Consulta = (new Preco_Consulta(

                    dr.GetDouble(0)
                    ));
                ;

            }

            return preco_Consulta;

        }




    }


}
