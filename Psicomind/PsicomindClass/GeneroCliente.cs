using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PsicomindClass
{
    public class GeneroCliente
    {
        public int Id { get; set; }
        public string Genero { get; set; }

        public GeneroCliente()
        {

        }

        public GeneroCliente(int id, string genero)
        {
            Id = id;
            Genero = genero;
        }

        public static GeneroCliente ObterPorId(int id)
        {
            GeneroCliente generoCliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from genero_cliente where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                generoCliente.Id = dr.GetInt32(0);
                generoCliente.Genero = dr.GetString(1);
            }
            return generoCliente;
        }

    }
}
