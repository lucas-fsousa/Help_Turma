using System;

namespace Pessoa_fisica {

    public class Pessoa_fisica {
        string endereco;
        string numero;
        string cpf;
        string nome;

        public Pessoa_fisica(string nome, string end, string num, string cpf_cad) {
            this.nome = nome;
            this.cpf = cpf_cad;
            this.endereco = end;
            this.numero = num;
        }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Cpf { get => cpf; set => cpf = value; }
    }
}
