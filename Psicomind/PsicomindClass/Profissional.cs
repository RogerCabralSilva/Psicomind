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
        public string Especializacao { get; set; }
        public DateTime Data_contrato { get; set; }
        public DateTime Data_cad { get; set; }
        public DateTime Data_nasc { get; set; }
        public Genero Genero { get; set; }
        public TelefoneProfissional TelefoneProfissional { get; set; }
        public Cargo Cargo { get; set; }
        public bool Ativo { get; set; }

        public Profissional()
        {


        }

        public Profissional(int id, string nome, string email, string senha, string cpf, string especializacao, DateTime data_contrato, DateTime data_cad, DateTime data_nasc, Genero genero, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Cpf = cpf;
            Especializacao = especializacao;
            Data_contrato = data_contrato;
            Data_cad = data_cad;
            Data_nasc = data_nasc;
            Genero = genero;
            Ativo = ativo;
        }

        public Profissional(int id, string nome, string senha, string especializacao, DateTime data_contrato, DateTime data_nasc, Genero genero, bool ativo)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            Especializacao = especializacao;
            Data_contrato = data_contrato;
            Data_nasc = data_nasc;
            Genero = genero;
            Ativo = ativo;
        }

        public Profissional(string nome, string email, string senha, string cpf, string especializacao, DateTime data_contrato, DateTime data_nasc, Genero genero, bool ativo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Cpf = cpf;
            Especializacao = especializacao;
            Data_contrato = data_contrato;
            Data_nasc = data_nasc;
            Genero = genero;
            Ativo = ativo;
        }

        public Profissional(string nome, string email, string senha, string cpf, string especializacao, DateTime data_contrato, DateTime data_cad, DateTime data_nasc, Genero genero, bool ativo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Cpf = cpf;
            Especializacao = especializacao;
            Data_contrato = data_contrato;
            Data_cad = data_cad;
            Data_nasc = data_nasc;
            Genero = genero;
            Ativo = ativo;
        }

        public Profissional(string nome, string email, string senha, string cpf, string especializacao, DateTime data_contrato, DateTime data_nasc, Genero genero)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Cpf = cpf;
            Especializacao = especializacao;
            Data_contrato = data_contrato;
            Data_nasc = data_nasc;
            Genero = genero;
        }

        public Profissional(int id, string nome, string email, string senha, string cpf, string especializacao, DateTime data_contrato, DateTime data_cad, DateTime data_nasc, Genero genero, TelefoneProfissional telefoneProfissional, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Cpf = cpf;
            Especializacao = especializacao;
            Data_contrato = data_contrato;
            Data_cad = data_cad;
            Data_nasc = data_nasc;
            Genero = genero;
            TelefoneProfissional = telefoneProfissional;
            Ativo = ativo;
        }

        public Profissional(string nome)
        {
            Nome = nome;
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
            cmd.Parameters.AddWithValue("spespecializacao", Especializacao);
            cmd.Parameters.AddWithValue("spdata_contrato", Data_contrato);
            cmd.Parameters.AddWithValue("spdata_nasc", Data_nasc);
            cmd.Parameters.AddWithValue("spgenero_id", Genero.Id);
            cmd.Parameters.AddWithValue("spcargo_id", Cargo.Id);

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
                dr.GetString(5),
                dr.GetDateTime(6),
                dr.GetDateTime(7),
                dr.GetDateTime(8),
                Genero.ObterPorId(dr.GetInt32(9)),
                TelefoneProfissional.ObterPorId(dr.GetInt32(10)),
                dr.GetBoolean(11)
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
            cmd.Parameters.AddWithValue("spespecializacao", Especializacao);
            cmd.Parameters.AddWithValue("spdata_contrato", Data_contrato);
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
                dr.GetString(5),
                dr.GetDateTime(6),
                dr.GetDateTime(7),
                dr.GetDateTime(8),
                Genero.ObterPorId(dr.GetInt32(9)),
                TelefoneProfissional.ObterPorId(dr.GetInt32(10)),
                dr.GetBoolean(11)
                ));

            }

            return lista;
        }




    }
}
