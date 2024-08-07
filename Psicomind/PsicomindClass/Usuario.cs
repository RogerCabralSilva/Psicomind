using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PsicomindClass
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo {  get; set; }
        public Cargo Cargo { get; set; }

        public Usuario(int id, string nome, string email, string senha, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Ativo = ativo;
        }

        public Usuario(string nome, string email, string senha, bool ativo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Ativo = ativo;
        }

        public Usuario(int id, string nome, string email, string senha, bool ativo, Cargo cargo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Ativo = ativo;
            Cargo = cargo;
        }

        public Usuario(string nome, string email, string senha, Cargo cargo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Cargo = cargo;
        }

        public void Inserir ()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuarios_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spcargo_id", Cargo.Id);

            cmd.ExecuteNonQuery();
        }

        public static List<Usuario> ObterLista(string nome = null)
        {
            List<Usuario> lista = new List<Usuario>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;

            if (nome == null)
            {
                cmd.CommandText = "SELECT * FROM usuario_cargo";
            }
            else
            {
                cmd.CommandText = $"SELECT * FROM usuario_cargos WHERE nome LIKE '%{nome}%' ";
            }

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Usuario(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetBoolean(4),
                    Cargo.ObterPorId(dr.GetInt32(5))

                    ));
            }

            return lista;
        }
    }
}
