using System;

// Definição da classe jogador
static public class Jogador{
    static public int energia;
    static public bool vivo;
    static public string nome;

    static public void info(){
        Console.WriteLine("Nome do Jogador: {0}\nEnergia do Jogador: {1}\nJogador está vivo: {2}", nome, energia, vivo);
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    }
    static public void iniciar(string n){
        Random rd = new Random();
        energia = rd.Next(100);
        vivo = true;
        nome = n;
    }
}
class Inimigo{
    static public bool alerta;
    public int power;
    public Inimigo(int p){
    alerta = false;
    power = p;
    }
    public void infoinimigo(){
        Console.WriteLine("Poder do inimigo> "+power);
        Console.WriteLine("Inimigo em Alerta> "+alerta);
        Console.WriteLine("=-=-=--=-=-=-=-=-=-=");
    }
}



//---------- Classe Principal onde contém o método principal.
class Principal{
    static void Main(){
        Jogador.iniciar("Jonas");
        Jogador.info();

        Inimigo i1 = new Inimigo(85);
        Inimigo i2 = new Inimigo(97);
        Inimigo i3 = new Inimigo(83);
        
        i1.infoinimigo();
        
        Inimigo.alerta = true;

        i2.infoinimigo();
        i3.infoinimigo();

    }
}