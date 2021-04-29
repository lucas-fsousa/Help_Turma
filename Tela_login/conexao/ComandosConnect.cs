using System;
using System.Collections.Generic;
using System.Data.SqlClient; // Biblioteca para utilizar conexoes e comandos sql / banco de dados
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tela_login.conexao {
    class ComandosConnect {

        public bool validar = false;
        public string msg = "";

        SqlCommand cmd = new SqlCommand(); // Instancia a classe de comandos do banco de dados
        Conexao conection = new Conexao(); // Instancia a classe de conexão do banco de dados
        SqlDataReader dr; // Variavel para armazenar valores retornados do banco de dados quando usar select (retorno de dados)

        public bool Validar_Login(string login, string senha) {

            //Aqui vai a query que será executada no banco de dados
            cmd.CommandText = "SELECT * FROM cadastro WHERE login = @login AND senha = @senha";
            
            //Neste bloco o valor contido na variavel login e senha será transferido para "@login" e "@senha" respectivamente
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try {
                cmd.Connection = conection.Conectar();
                dr = cmd.ExecuteReader();
                if(dr.HasRows) {
                    validar = true;
                }
                dr.Close(); // Fecha o reader (leitor)
                conection.Desconectar(); // Fecha a conexão com o banco de dados
            } catch(SqlException) {

                this.msg = "Algo deu errado ao conectar-se ao banco de dados ou executar ações no banco de dados!";
            }

            return validar;
        }
        public string Cadastrar(string login, string senha, string conf_senha) {
            this.validar = false;
            if(senha.Equals(conf_senha)) {
                cmd.CommandText = "INSERT INTO cadastro VALUES (@login, @senha);";
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@senha", senha);

                try {
                    cmd.Connection = conection.Conectar();
                    cmd.ExecuteNonQuery();
                    conection.Desconectar();
                    this.msg = "Cadastrado com sucesso";
                    this.validar = true;

                } catch(SqlException) {

                    this.msg = "Erro durante ação ou conexão com banco de dados";
                }
            } else {
                this.msg = "Senhas não correspondem";
            }
            return msg;
        }
    }
}
