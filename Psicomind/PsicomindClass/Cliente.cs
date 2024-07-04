using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PsicomindClass
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime Data_nasc { get; set; }
        public DateTime Data_cad { get; set; }
        public bool Ativo { get; set; }
        public Genero GeneroCliente { get; set; }
        public List<Endereco> Enderecos { get; set; }


        public Cliente()
        {
            
        }

        public Cliente(int id, string nome, string cpf, string telefone, string email, DateTime data_nasc, DateTime data_cad,Genero generoCliente, bool ativo, List<Endereco> enderecos)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            GeneroCliente = generoCliente;
            Ativo = ativo;
            Enderecos = enderecos;
        }

        public Cliente(int id, string nome, string cpf, string telefone, string email, DateTime data_nasc, DateTime data_cad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            Ativo = ativo;
        }

        public Cliente(string nome, string cpf, string telefone, string email, DateTime data_nasc, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Ativo = ativo;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("spdata_nasc", Data_nasc);
            cmd.Parameters.AddWithValue("spgenero_cliente", GeneroCliente.Id);
            Id = Convert.ToInt32(cmd.ExecuteReader());

        }

        public static List<Cliente> ObterLista(string nome = null)
        {
            List<Cliente> lista = new List<Cliente>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;

            if (nome == null)
            {
                cmd.CommandText = "SELECT * FROM clientes";
            }
            else
            {
                cmd.CommandText = $"SELECT * FROM clientes WHERE nome LIKE '%{nome}%' ";
            }

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDateTime(5),
                    dr.GetDateTime(6),
                    Genero.ObterPorId(dr.GetInt32(7)),
                    dr.GetBoolean(8),                    
                    Endereco.ObterListaPorCliente(dr.GetInt32(0))
                    ));
            }

            return lista;
        }


        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new ();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM clientes WHERE id = {id}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cliente = (new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDateTime(5),
                    dr.GetDateTime(6),
                    Genero.ObterPorId(dr.GetInt32(7)),
                    dr.GetBoolean(8),
                    Endereco.ObterListaPorCliente(dr.GetInt32(0))
                    ));
            }

            return cliente;
        }

        public bool Editar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spdata_nasc", Data_nasc);
            cmd.Parameters.AddWithValue("spgenero_cliente", GeneroCliente.Id);
            cmd.Parameters.AddWithValue("spativo", Ativo);

            return cmd.ExecuteNonQuery() > -1 ? true : false;

        }
    }
}
