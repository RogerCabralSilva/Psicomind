using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicomindClass
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime Data_nasc { get; set; }
        public DateTime Data_cad { get; set; }
        public bool Ativo { get; set; }
        public List<Endereco> Enderecos { get; set; }

        public Cliente()
        {
            Id = 0;
        }

        public Cliente(int id, string nome, string cpf, string telefone, string email, DateTime data_nasc, DateTime data_cad, bool ativo, List<Endereco> enderecos)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
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

        public Cliente(string nome, string cpf, string telefone, string email, DateTime data_nasc, DateTime data_cad, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            Ativo = ativo;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;

        }

    }
}
