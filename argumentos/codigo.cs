using System;
class Principal{
    static void Main(string[] args){ // string [] args salva os argumentos de entrada na string
        if(args[0] == "abc1234"){
            Console.WriteLine("SEJA BEM VINDO!");
        }else{
            Console.WriteLine("Você não tem permissão para executar esta aplicação!");
        }
    }
}