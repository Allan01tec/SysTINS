using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    //classe Banco é a nossa classe de conexão
    public static class Banco // static pois nao precisaremos criar uma instancia de banco
                              // para conectar ás nossas bases de dados
    {
        public static MySqlCommand Abrir()//metodo para abrir conexão   //Dentro dessa classe tem uma coleção de metodos do MySql  
        {
            string strcon = @"server=127.0.0.1;database=systinsdb01;user=root;password=";// (string de conexao)dentro dessa string óde acontecer de ter algum caractere especial
            MySqlConnection cn = new(strcon); //criando um objeto de opçao 
            MySqlCommand cmd = new();
            try //tab tab (usado para que uma falha nao cause tela azul no sistema)
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (MySqlException ex) // MySqlException ela retorna um erro (ex nome dele) (catch caso ocorra um erro ele captura e mostra o erro)
            {
                Console.WriteLine(ex.Message);
               
              
            }

            return cmd;
        }
    }
}
