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
        public Genero Genero { get; set; }
        public bool Ativo { get; set; }

        public Profissional()
        {

        }

        public Profissional(int id, string nome, string email, string senha, string cpf, string especializacao, DateTime data_contrato, DateTime data_cad, Genero genero, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Cpf = cpf;
            Especializacao = especializacao;
            Data_contrato = data_contrato;
            Data_cad = data_cad;
            Genero = genero;
            Ativo = ativo;
        }

        public Profissional(string nome, string email, string senha, string cpf, string especializacao, DateTime data_contrato, Genero genero, bool ativo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Cpf = cpf;
            Especializacao = especializacao;
            Data_contrato = data_contrato;
            Genero = genero;
            Ativo = ativo;
        }

        public Profissional(string nome, string email, string senha, string cpf, string especializacao, DateTime data_contrato, DateTime data_cad, Genero genero, bool ativo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Cpf = cpf;
            Especializacao = especializacao;
            Data_contrato = data_contrato;
            Data_cad = data_cad;
            Genero = genero;
            Ativo = ativo;
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
            cmd.Parameters.AddWithValue("spgenero_id", Genero.Id);


        }
        
        // Consultar profissional

        public static Profissional ObterPorId(int id)
        {

            Profissional profissional = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"SELECT * FROM profissionais WHERE id = {id}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                profissional.Id = dr.GetInt32(0);
                profissional.Nome = dr.GetString(1);
                profissional.Email = dr.GetString(2);
                profissional.Senha = dr.GetString(3);
                profissional.Cpf = dr.GetString(4);
                profissional.Especializacao = dr.GetString(5);
                profissional.Data_contrato = dr.GetDateTime(6);
                profissional.Data_cad = dr.GetDateTime(7);

            };

            return profissional;

        }

    }
}
