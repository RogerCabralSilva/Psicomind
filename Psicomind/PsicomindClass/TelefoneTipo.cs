using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PsicomindClass
{
    public class TelefoneTipo
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        
        public TelefoneTipo()
        {

        }

        public TelefoneTipo(string tipo)
        {
            Tipo = tipo;
        }

        public TelefoneTipo(int id, string tipo)
        {
            Id = id;
            Tipo = tipo;
        }

        public static TelefoneTipo ObterPorId(int id)
        {

            TelefoneTipo telefoneTipo = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"SELECT * FROM telefone_tipo WHERE id = {id}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                telefoneTipo = (new TelefoneTipo(

                    dr.GetInt32(0),
                    dr.GetString(1)

                    ));

            }

            return telefoneTipo;

        }

        public List<TelefoneTipo> ObterLista()
        {

            List<TelefoneTipo> telefoneTipos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "SELECT * FROM telefone_tipo";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                telefoneTipos.Add(new (

                    dr.GetInt32(0),
                    dr.GetString(1)

                    ));

            }


            return telefoneTipos;

        }
       

    }
}
