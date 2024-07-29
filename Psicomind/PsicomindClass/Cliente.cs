
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PsicomindClass
{
    /// <summary>
    /// Classe do cliente
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Id do cliente
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nome do cliente
        /// </summary>
        public string? Nome { get; set; }

        /// <summary>
        /// Email do Cliente
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// CPF do cliente
        /// </summary>
        public string? Cpf { get; set; }
        
        /// <summary>
        /// Senha do cliente
        /// </summary>
        public string? Senha { get; set; }

        /// <summary>
        /// Data de nascimento do cliente
        /// </summary>
        public DateTime Data_nasc { get; set; }

        /// <summary>
        /// Data de cadastro do cliente
        /// </summary>
        public DateTime Data_cad { get; set; }

        /// <summary>
        /// Se o cliente está ativo ou não
        /// </summary>
        public bool Ativo { get; set; }

        /// <summary>
        /// Classe do gênero do cliente
        /// </summary>
        public Genero GeneroCliente { get; set; }

        /// <summary>
        /// Lista de endereço de um cliente
        /// </summary>
        public List<Endereco>? Enderecos { get; set; }

        /// <summary>
        /// Lista de telefone do cliente
        /// </summary>
        public List<TelefoneCliente>? Telefone { get; set; }


        public Cliente()
        {


        }

        public Cliente(int id, string nome, string cpf, string email, string senha, DateTime data_nasc, DateTime data_cad, bool ativo, Genero generoCliente, List<Endereco> enderecos)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Senha = senha;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            Ativo = ativo;
            GeneroCliente = generoCliente;
            Enderecos = enderecos;
        }

        public Cliente(string nome, string cpf, string email, string senha, DateTime data_nasc, Genero generoCliente)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Senha = senha;
            Data_nasc = data_nasc;
            GeneroCliente = generoCliente;
        }

        public Cliente(int id, string nome, string senha, DateTime data_nasc, Genero generoCliente, bool ativo)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            Data_nasc = data_nasc;
            GeneroCliente = generoCliente;
            Ativo = ativo;

        }

        public Cliente(int id, string? nome, string? email, string? senha, string? cpf, DateTime data_cad, DateTime data_nasc, Genero generoCliente, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Cpf = cpf;
            Data_cad = data_cad;
            Data_nasc = data_nasc;
            GeneroCliente = generoCliente;
            Ativo = ativo;

        }

        /// <summary>
        /// Inserir cliente no banco de dados.
        /// <para>Parâmetros:</para>
        /// <para>- Nome</para>
        /// <para>- Email</para>
        /// <para>- Senha</para>
        /// <para>- CPF</para>
        /// <para>- Data_nasc</para>
        /// <para>- Genero clinte Id</para>
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_clientes_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("spdata_nasc", Data_nasc);
            cmd.Parameters.AddWithValue("spgenero_id", GeneroCliente.Id);

            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }

        /// <summary>
        /// Obtem uma lista de cliente 
        /// Parâmetro opcional 
        /// - nome
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>

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
                    dr.GetBoolean(8)

                    ));
            }

            return lista;
        }


        /// <summary>
        /// Obtem informações do cliente atráves do ID
        /// <param>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from clientes where id = {id}";
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
                    dr.GetBoolean(8)

                    ));
            }

            return cliente;
        }

        /// <para>Parâmetros:</para>
        /// <para>- Id para consultar</para>
        /// <para>- Nome </para>
        /// <para>- Senha</para>
        /// <para>- Data_nasc</para>
        /// <para>- Genero_id</para>
        /// <para>- Ativo </para>
        /// - Retorna True ou False
        public bool Editar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_clientes_update";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spdata_nasc", Data_nasc);
            cmd.Parameters.AddWithValue("spgenero_id", GeneroCliente.Id);
            cmd.Parameters.AddWithValue("spativo", Ativo);

            return cmd.ExecuteNonQuery() > -1 ? true : false;

        }
    }
}
