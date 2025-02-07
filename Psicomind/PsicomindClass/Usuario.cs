﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static Mysqlx.Notice.Warning.Types;

namespace PsicomindClass
{
    public class Usuario
    {
        public int Id { get; set; }
        public Cargo Cargo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo {  get; set; }
        
        public Usuario()
        {

        }

        public Usuario(int id, string nome, string email, string senha, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Ativo = ativo;
        }

        public Usuario(int id, string nome, string email, bool ativo, Cargo cargo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Ativo = ativo;
            Cargo = cargo;
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

        public Usuario(int id, Cargo cargo, string nome, string email, string senha, bool ativo)
        {
            Id = id;
            Cargo = cargo;
            Nome = nome;
            Email = email;
            Senha = senha;
            Ativo = ativo;
        }

        public Usuario(int id)
        {
            Id = id;
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
                cmd.CommandText = "SELECT * FROM usuarios";
            }
            else
            {
                cmd.CommandText = $"SELECT * FROM usuarios WHERE nome LIKE '%{nome}%' ";
            }

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Usuario(
                    dr.GetInt32(0),
                    Cargo.ObterPorId(dr.GetInt32(1)),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetBoolean(5)
                    
                    ));
            }

            return lista;
        }

        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                usuario = (new Usuario(
                    dr.GetInt32(0)
                    ));
            }

            return usuario;
        }


        public static List<Usuario> ObterListaPsicologo(string nome = null)
        {
            List<Usuario> lista = new List<Usuario>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;

            if (nome == null)
            {
                cmd.CommandText = "SELECT * FROM usuarios WHERE cargo_id = '3'";
            }
            else
            {
                cmd.CommandText = $"SELECT * FROM usuarios WHERE nome LIKE '%{nome}%' ";
            }

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Usuario(
                    dr.GetInt32(0),
                    Cargo.ObterPorId(dr.GetInt32(1)),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetBoolean(5)

                    ));
            }

            return lista;
        }

        public static Usuario EfetuarLogin(string email, string senha)
        {

            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios" +
                $" where email = '{email}' and senha = md5('{senha}') and ativo = 1";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                usuario = new Usuario(

                    dr.GetInt32(0),
                    Cargo.ObterPorId(dr.GetInt32(1)),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetBoolean(5)

                    );
                

            }

            return usuario;

        }

    }
}
