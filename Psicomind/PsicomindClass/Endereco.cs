using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PsicomindClass
{
    public class Endereco
    {

        public int Id { get; set; }
        public int Cliente_Id { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Uf { get; set; }
        public TipoEndereco TipoEndereco { get; set; }

        public Endereco()
        {

        }

        public Endereco(int id, int cliente_Id, string cep, string rua, string numero, string bairro, string uf, TipoEndereco tipoEndereco)
        {
            Id = id;
            Cliente_Id = cliente_Id;
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }

        public Endereco(int cliente_Id, string cep, string rua, string numero, string bairro, string uf, TipoEndereco tipoEndereco)
        {
            Cliente_Id = cliente_Id;
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_enderecos_insert";
            cmd.Parameters.AddWithValue("spcliente_id", Cliente_Id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("sprua", Rua);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo_endereco", TipoEndereco.Id);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public bool Editar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_enderecos_update";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.Parameters.AddWithValue("spcliente_id", Cliente_Id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("sprua", Rua);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo_endereco", TipoEndereco.Id);


            return cmd.ExecuteNonQuery() > -1 ? true : false;
        }

        public static Endereco ObterPorId(int id)
        {
            Endereco endereco = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM enderecos WHERE id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco = new(
                        dr.GetInt32(0),
                        dr.GetInt32(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(6),
                        TipoEndereco.ObterPorId(dr.GetInt32(0))
                    );
            }
            return endereco;
        }

        public static List<Endereco> ObterListaPorCliente(int clienteId)
        {
            List<Endereco> endereco = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM enderecos WHERE id = {clienteId}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco.Add (new(
                        dr.GetInt32(0),
                        dr.GetInt32(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(6),
                        TipoEndereco.ObterPorId(dr.GetInt32(0))
                        )
                    );
            }
            return endereco;
        }
    }
}
