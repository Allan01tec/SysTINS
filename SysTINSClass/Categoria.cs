using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Categoria
    {

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        public Categoria() { } // método construtor (new)

        public Categoria(string? nome, string? sigla )
            {
            
                Nome = nome;
                Sigla = sigla;
               
            }
            public Categoria(int id, string? nome, string? sigla)
            {
                Id = id;
                Nome = nome;
                Sigla= sigla;
            }

        // inserir
        public void Inserir()
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = $"sp_categoria_insert ";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);

            cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            // consultar por id
            public static Categoria ObterPorId(int id)
            {
                Categoria categoria = new();
                var cmd = Banco.Abrir();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"select id, nome from produtos where id = {id}";
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    categoria = new(dr.GetInt32(0), dr.GetString(1),
                        dr.GetString(2));
                }
                cmd.Connection.Close();
                return categoria;
            }
            // obter lista
            public static List<Categoria> ObterLista()
            {
            List<Categoria> categorias = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from categorias order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                categorias.Add( new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2) 
                    ));
            }   
            return categorias;
        }
        // atualizar
        public bool Atualizar()
            {
            bool resposta = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.Connection.Close();
                resposta = true;
            }
            return resposta;
            }
            // deletar nivel
            public void Excluir()
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_categoria_update";
                cmd.Parameters.AddWithValue("spid", Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        }
    }
