using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PsicomindClass
{
    public class TelefoneProfissional
    {
        
        public int Id { get; set; }
        public string Numero { get; set; }
        public int Profissional_id { get; set; }
        public TelefoneTipo Telefonetipo_id { get; set; }

        public TelefoneProfissional()
        {

        }

        public TelefoneProfissional(string numero, int profissional_id, TelefoneTipo telefonetipo_id)
        {
            Numero = numero;
            Profissional_id = profissional_id;
            Telefonetipo_id = telefonetipo_id;
        }

        public TelefoneProfissional(int id, string numero, int profissional_id, TelefoneTipo telefonetipo_id)
        {
            Id = id;
            Numero = numero;
            Profissional_id = profissional_id;
            Telefonetipo_id = telefonetipo_id;
        }



        public void Inserir()
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_telefone_profissional_insert";
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spprofissional_id", Profissional_id);
            cmd.Parameters.AddWithValue("sptelefone_tipo_id", Telefonetipo_id.Id);
            cmd.ExecuteNonQuery();

        }

        public bool Editar(int id)
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_telefone_profissional_update";
            cmd.Parameters.AddWithValue("spprofissional_id", Profissional_id);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("sptelefone_tipo_id", Telefonetipo_id.Id);

            return cmd.ExecuteNonQuery() > -1 ? true : false;

        }

        public static TelefoneProfissional ObterPorId(int id)
        {

            TelefoneProfissional telefoneProfissional = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"SELECT * FROM telefone_profissional WHERE id = {id}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                telefoneProfissional = (new TelefoneProfissional(

                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetInt32(2),
                        TelefoneTipo.ObterPorId(dr.GetInt32(3))
                    ));

            }

            return telefoneProfissional;

        }

        public static List<TelefoneProfissional> ObterListaPorProfissional(int cliente_id)
        {

            List<TelefoneProfissional> telefoneProfissional = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM telefone_profissional WHERE id = {cliente_id}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                telefoneProfissional.Add(new(

                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetInt32(2),
                        TelefoneTipo.ObterPorId(dr.GetInt32(3))
                    ));

            }


            return telefoneProfissional;
        }

        public static List<TelefoneProfissional> ObterListaTelefone(string nome = null)
        {
            List<TelefoneProfissional> lista = new List<TelefoneProfissional>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;

            if (nome == null)
            {

                cmd.CommandText = "SELECT * FROM telefone_profissional";
            }
            else
            {
                cmd.CommandText = $"SELECT * FROM telefone_profissional WHERE nome LIKE '%{nome}%'";
            }

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new(

                         dr.GetInt32(0),
                         dr.GetString(1),
                         dr.GetInt32(2),
                         TelefoneTipo.ObterPorId(dr.GetInt32(3))
                     ));
            }

            return lista;
        }

    }

}
