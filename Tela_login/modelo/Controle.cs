using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela_login.conexao; // Instancia os itens de outra pasta do projeto

namespace Tela_login.modelo {
    public class Controle {

        public bool validar = false;
        public string msg = "";

        // As informações deste método vem diretamente do formulario de login
        public bool Logar(string login, string senha) {

            ComandosConnect log_in = new ComandosConnect(); // Instancia a classe de comandos do banco de dados
            validar = log_in.Validar_Login(login, senha); // vai utilizar o método de validação da classe Comandos do banco dados

            if(!log_in.msg.Equals("")) { // Verifica se a string de mensagem de erros está vazia, se esiver preenchida, significa que ocorreu um erro ao acessar o banco de dados 
                this.msg = log_in.msg; // A string mensagem receberá o valor da string de mensagem de erro da classe de comandos do banco
            }

            return validar; // Retorna um valor booleano

        }

        public string Cadastrar(string login, string senha, string conf_senha) {

            ComandosConnect cad = new ComandosConnect();
            this.msg = cad.Cadastrar(login, senha, conf_senha);
            if(cad.validar) {
                this.validar = true;
            }
            return msg;
        }

    }
}
