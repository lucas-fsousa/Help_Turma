using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_de_cadastro {
    class PessoaFisica {

        string nome;
        string cpf;
        string endereco;
        string numero;

        public PessoaFisica(string nome, string cpf, string endereco, string numero) {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.numero = numero;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Numero { get => numero; set => numero = value; }
    }
}
