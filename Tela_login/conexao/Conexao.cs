using System;
using System.Collections.Generic;
using System.Data.SqlClient; // Biblioteca de conexão com o banco de dados
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_login {
    public class Conexao {

        // Classe utilizada para conectar-se ao banco de dados
        SqlConnection conn = new SqlConnection();
        public Conexao() {
            //Aqui vem o endereço de conexão com o banco de dados
            conn.ConnectionString = @"Data Source=LUCAS;Initial Catalog=Banco_Teste;Integrated Security=True";
        }

        public SqlConnection Conectar() {
            // Verifica se a conexão com o banco de dados está fechada
            if(conn.State == System.Data.ConnectionState.Closed) {
                conn.Open(); // Abre uma conexão segura com o banco de dados
            }
            return conn; // Retorna um valor do tipo SQLCONNECTION
        }

        public void Desconectar() {
            // Verifica se a conexão com o banco de dados está aberta
            if(conn.State == System.Data.ConnectionState.Open) {
                conn.Close(); // Fecha a conexão com o banco de dados
            }
        }

    }
}
