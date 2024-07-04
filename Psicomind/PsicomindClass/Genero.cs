using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PsicomindClass
{
    public class Genero
    {
        public int Id { get; set; }
        public string Genero_nome { get; set; }

        public Genero()
        {

        }

        public Genero(int id, string genero_nome)
        {
            Id = id;
            Genero_nome = genero_nome;
        }

        public static Genero ObterPorId(int id)
        {
            Genero generoCliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from genero where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                generoCliente.Id = dr.GetInt32(0);
                generoCliente.Genero_nome = dr.GetString(1);
            }
            return generoCliente;
        }

        public static List<Genero> ObterLista()
        {
            List<Genero> genero = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from genero";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                genero.Add(new(dr.GetInt32(0), dr.GetString(1)));
            }
            return genero;
        }
    }
}
