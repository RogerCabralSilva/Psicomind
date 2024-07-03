using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PsicomindClass
{
    public class TipoEndereco
    {
        public int Id { get; set; }
        public string Tipo_Endereco { get; set; }

        public TipoEndereco ()
        {

        }

        public TipoEndereco(int id, string tipo_Endereco)
        {
            Id = id;
            Tipo_Endereco = tipo_Endereco;
        }

        public static TipoEndereco ObterPorId(int id)
        {
            TipoEndereco tipoEndereco = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from tipo_endereco where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tipoEndereco.Id = dr.GetInt32(0);
                tipoEndereco.Tipo_Endereco = dr.GetString(1);
            }
            return tipoEndereco;
        }
    }
}
