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

        public int Cod_barras { get; set; }
        public int Valor_unit { get; set; }

        public DateTime Data_cad {  get; set; } 
        public string? Descricao { get; set; }
        public int Desconto { get; set; }

            public Categoria() { } // método construtor (new)

            public Categoria(string? nome, Categoria categoria)
            {
                Nome = nome;
               
            }
            public Categoria(int id, string? nome)
            {
                Id = id;
                Nome = nome;
          
            }

            // inserir
            public void Inserir()
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"insert produtos (nome, Cod_barras, Valor_unit, Data_cad ) values ('{Nome}, {Cod_barras},{Valor_unit},{Data_cad},{Descricao},{Desconto}') ";
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
                    // = dr.GetInt32(0);
                    // = dr.GetString(1);
                    //= dr.GetString(2);
                    categoria = new(dr.GetInt32(0), dr.GetString(1));
                }
                cmd.Connection.Close();
                return categoria;
            }
            // obter lista
            public static List<Categoria> ObterLista()
            {
                List<Categoria> categoria = new();
                var cmd = Banco.Abrir();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from produtos order by nome asc";
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                categoria.Add(new(dr.GetInt32(0), dr.GetString(1)));
                }
                cmd.Connection.Close();
                return categoria;
            }
            // atualizar
            public bool Atualizar()
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"update produtos set nome = '{Nome}', where id = {Id}";
                return cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            // deletar nivel
            public void Excluir()
            {
                var cmd = Banco.Abrir();
                cmd.CommandText = $"delete from produtos where id = {Id}";
                cmd.ExecuteNonQuery();
            }

        }
    }
