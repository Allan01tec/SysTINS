using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Cliente
    {
        private int v1;
        private string v2;
        private string v3;

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Telefone {get;set; }
        public string? Email { get; set; }
        public DateTime DataNasc { get; set; }
        public Timestamp DataCad {  get; set; }
        public bool Ativo {  get; set; }
        public List<Endereco> Enderecos { get; set; }
        public Cliente(int id, string nome, string cpf, string telefone, string email, DateTime dataNasc, Timestamp dataCad, bool ativo, List<Endereco> enderecos)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = datanasc;
            DataCad = dataCad;
            Ativo = ativo;
            Enderecos = enderecos;
        }

        public Cliente(int v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public Cliente()
        {
        }

        //inserir
        public void Inserir ()
        /*spnome varchar(100), 
spcpf char(11), 
sptelefone char(14), 
spemail varchar(60), 
spdatanasc date
*/
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = $"sp_cliente_insert ";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdatanasc", DataNasc);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select id, nome from clientes where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cliente = new(dr.GetInt32(0), dr.GetString(1),
                    dr.GetString(2));
            }
            cmd.Connection.Close();
            return cliente;
        } 
   

    }


