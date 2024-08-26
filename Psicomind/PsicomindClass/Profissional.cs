using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PsicomindClass
{
    public class Profissional
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public DateTime Data_cad { get; set; }
        public DateTime Data_nasc { get; set; }
        public Genero Genero { get; set; }
        public Cargo Cargo { get; set; }
        public bool Ativo { get; set; }
        public TelefoneProfissional TelefoneProfissional { get; set; }


        public Profissional()
        {


        }
        public Profissional(int id, string nome, string senha, string especializacao, DateTime data_nasc, Genero genero, bool ativo)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            Data_nasc = data_nasc;
            Genero = genero;
            Ativo = ativo;
        }

        public Profissional(string nome)
        {
            Nome = nome;
        }

        public Profissional(string nome, string email, string senha, string cpf, DateTime data_nasc, Cargo cargo, Genero genero)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Cpf = cpf;
            Data_nasc = data_nasc;
            Cargo = cargo;
            Genero = genero;

        }

        public Profissional(int id,string nome, string senha, DateTime data_nasc, Genero genero, Cargo cargo, bool ativo)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            Data_nasc = data_nasc;
            Genero = genero;
            Cargo = cargo;
            Ativo = ativo;
        }

        public Profissional(int id, string nome, string email, string senha, string cpf, DateTime data_cad, DateTime data_nasc, Genero genero, TelefoneProfissional telefoneProfissional, Cargo cargo, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Cpf = cpf;
            Data_cad = data_cad;
            Data_nasc = data_nasc;
            Genero = genero;
            TelefoneProfissional = telefoneProfissional;
            Cargo = cargo;
            Ativo = ativo;
        }

        public Profissional(int id, string nome, string email, string senha, string cpf, DateTime data_cad, DateTime data_nasc, Genero genero, Cargo cargo, bool ativo, TelefoneProfissional telefoneProfissional)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Cpf = cpf;
            Data_cad = data_cad;
            Data_nasc = data_nasc;
            Genero = genero;
            Cargo = cargo;
            Ativo = ativo;
            TelefoneProfissional = telefoneProfissional;
        }

        // Inserindo Profissional

        public void Inserir()
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_profissionais_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("spdata_nasc", Data_nasc);
            cmd.Parameters.AddWithValue("spcargo_id", Cargo.Id);
            cmd.Parameters.AddWithValue("spgenero_id", Genero.Id);


            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }
        
        // Consultar profissional

        public static Profissional ObterPorId(int id)
        {

            Profissional profissional = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"SELECT * FROM profissional_info WHERE id = {id}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                profissional = (new Profissional(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetString(4),
                dr.GetDateTime(5),
                dr.GetDateTime(6),
                Genero.ObterPorId(dr.GetInt32(7)),
                TelefoneProfissional.ObterPorId(dr.GetInt32(8)),
                Cargo.ObterPorId(dr.GetInt32(9)),
                dr.GetBoolean(10)
                ));
            }

            return profissional;


        }

        public static string ObterNomePorId(int id)
        {

            string nome = string.Empty;

            Profissional profissional = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"SELECT nome FROM profissionais WHERE id = {id}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                nome = dr.GetString(0);
                
            }

            return nome;


        }

        public bool Editar(int id)
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_profissionais_update";

            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spdata_nasc", Data_nasc);
            cmd.Parameters.AddWithValue("spgenero_id", Genero.Id);
            cmd.Parameters.AddWithValue("spcargo", Cargo.Id);
            cmd.Parameters.AddWithValue("spativo", Ativo);

            return cmd.ExecuteNonQuery() > -1 ? true:false;
        }


        public static List<Profissional> ObterLista(string nome = null)
        {

            List<Profissional> lista = new List<Profissional>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;

            if (nome == null)
            {

                cmd.CommandText = "SELECT * FROM profissional_info";
            }
            else
            {
                cmd.CommandText = $"SELECT * FROM profissional_info WHERE nome LIKE '%{nome}%'";
            }

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                lista.Add(new Profissional(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetString(4),
                dr.GetDateTime(5),
                dr.GetDateTime(6),
                Genero.ObterPorId(dr.GetInt32(7)),
                TelefoneProfissional.ObterPorId(dr.GetInt32(8)),
                Cargo.ObterPorId(dr.GetInt32(9)),
                dr.GetBoolean(10)
                ));

            }

            return lista;
        }




    }
}
