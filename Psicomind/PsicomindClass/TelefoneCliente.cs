﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PsicomindClass
{
    /// <summary>
    /// Classe telefone do cliente
    /// </summary>
    public class TelefoneCliente
    {
        /// <summary>
        /// Id do telefone
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Numero do telefone
        /// </summary>
        public string Numero { get; set; }

        /// <summary>
        /// Id do cliente associado ao telefone
        /// </summary>
        public int Cliente_id { get; set; }

        /// <summary>
        /// Tipo do telefone
        /// </summary>
        public TelefoneTipo TelefoneTipo_id { get; set; }
        
        public TelefoneCliente()
        {

        }

        public TelefoneCliente(string numero, int cliente_id, TelefoneTipo telefoneTipo_id)
        {
            Numero = numero;
            Cliente_id = cliente_id;
            TelefoneTipo_id = telefoneTipo_id;
        }

        public TelefoneCliente(int id, string numero, int cliente_id, TelefoneTipo telefoneTipo_id)
        {
            Id = id;
            Numero = numero;
            Cliente_id = cliente_id;
            TelefoneTipo_id = telefoneTipo_id;
        }

        
        /// <summary>
        /// insere um telefone
        ///
        /// </summary>
        public void Inserir()
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_telefone_cliente_insert";
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcliente_id", Cliente_id);
            cmd.Parameters.AddWithValue("sptelefone_tipo_id", TelefoneTipo_id.Id);
            cmd.ExecuteNonQuery();

        }

        /// <summary>
        /// Edita telefone
        /// </summary>
        /// <param name="id">ID como parâmetro para editar</param>
        /// <returns></returns>
        public bool Editar(int id)
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_telefone_cliente_update";
            cmd.Parameters.AddWithValue("spcliente_id", Cliente_id);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("sptelefone_tipo_id", TelefoneTipo_id.Id);

            return cmd.ExecuteNonQuery() > -1 ? true : false;

        }
        
        public static TelefoneCliente ObterPorId(int id)
        {

            TelefoneCliente telefoneCliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"SELECT * FROM telefone_cliente WHERE id = {id}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                telefoneCliente = (new TelefoneCliente(

                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetInt32(2),
                        TelefoneTipo.ObterPorId(dr.GetInt32(3))
                    ));

            }

            return telefoneCliente;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cliente_id"></param>
        /// <returns></returns>
        public static List<TelefoneCliente> ObterListaPorCliente(int cliente_id)
        {

            List<TelefoneCliente> telefoneClientes = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM telefone_cliente WHERE id = {cliente_id}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                telefoneClientes.Add (new(

                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetInt32(2),
                        TelefoneTipo.ObterPorId(dr.GetInt32(3))
                    ));

            }


            return telefoneClientes;
        }

        public static List<TelefoneCliente> ObterListaTelefone(string nome = null)
        {
            List<TelefoneCliente> lista = new List<TelefoneCliente>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;

            if (nome == null)
            {

                cmd.CommandText = "SELECT * FROM telefone_cliente";
            }
            else
            {
                cmd.CommandText = $"SELECT * FROM telefone_cliente WHERE nome LIKE '%{nome}%'";
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
