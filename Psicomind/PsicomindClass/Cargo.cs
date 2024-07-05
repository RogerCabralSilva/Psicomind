using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicomindClass
{
    public class Cargo
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public Cargo()
        {

        }

        public Cargo(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        public Cargo(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }

        public Cargo(string nome)
        {
            Nome = nome;
        }

        public static Cargo ObterPorId(int id)
        {

            Cargo cargo = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"SELECT * FROM cargos WHERE id = {id}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                cargo = (new Cargo(
                    
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    
                    ));

            }

            return cargo;

        }

        public List<Cargo> ObterLista()
        {

            List<Cargo> cargos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "SELECT * FROM cargos";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                cargos.Add(new (

                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)

                    ));

            }


            return cargos;

        }

    }
}
