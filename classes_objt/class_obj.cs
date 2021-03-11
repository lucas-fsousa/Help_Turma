using System;

// Definição da classe jogador
public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;

    // Metodo Jogador - Metodo construtor da classe jogador
    public Jogador(string n){
        Random rd = new Random();
        energia = rd.Next(100);
        vivo = true;
        nome = n;
    }
    // Metodo jogador - Metodo destrutor da calsse jogador
    ~Jogador(){
        Console.WriteLine("O jogador {0} foi deletado.", nome);

    }
}


//---------- Classe Principal onde contém o método principal.
class Principal{
    static void Main(){
        string nick = "";
        Console.Write("Digite seu nome: ");
        nick = Console.ReadLine();
        Jogador j1 = new Jogador(nick);
        Console.WriteLine("Energia do jogador 1: {0}", j1.energia);
        Console.WriteLine("Nome do jogador 1: {0}", j1.nome);
    }
}