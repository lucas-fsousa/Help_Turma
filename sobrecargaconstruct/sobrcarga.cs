using System;

// Definição da classe jogador
public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;

    // Metodo Jogador - Metodo construtor da classe jogador com 1 parametro
    public Jogador(string n){
        Random rd = new Random();
        energia = 100;
        vivo = true;
        nome = n;
    }
    // Metodo Jogador - Metodo construtor da classe jogador com 2 parametros
    public Jogador(string n, int e){
        energia = e;
        nome = n;
        vivo = true;
    }
    // Metodo Jogador - Metodo construtor da classe jogador com 3 parametros
    public Jogador(string n, int e, bool v){
        energia = e;
        nome = n;
        vivo = v;
    }
    public void info(){
        Console.WriteLine("Nome do Jogador: {0}\nEnergia do Jogador: {1}\nJogador está vivo: {2}", nome, energia, vivo);
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    }

    // Metodo Jogador - Metodo construtor da classe jogador sem parametro
    public Jogador(){
        Random rd = new Random();
        energia = rd.Next(100);
        vivo = true;
        nome = "Jogador";
    }
    // Metodo jogador - Metodo destrutor da calsse jogador
    ~Jogador(){
        Console.WriteLine("O jogador {0} foi deletado.", nome);

    }
}


//---------- Classe Principal onde contém o método principal.
class Principal{
    static void Main(){
        
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("Carlin bico torto");
        Jogador j3 = new Jogador("José pé de faca", 87);
        Jogador j4 = new Jogador("Boristiti cegueta", 33, false);
        j1.info();
        j2.info();
        j3.info();
        j4.info();
    }
}