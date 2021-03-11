using System;

class Veiculo{
    public int velAtual;
    private int velMax;
    protected bool ligado;

    public Veiculo(int veldef){
        velAtual = 0;
        this.velMax = veldef;
        ligado = false;
    }
    public bool getLigado(){
        return ligado;
    }
    public int getVelMax(){
        return velMax;
    }
}

class Carro:Veiculo{ // CLasse derivada de veiculo
    public string nome;
    public Carro(string nome, int vm):base(vm){
        this.nome = nome;
        this.ligado = true;
    }
}

class Principal{
    static void Main(){
        Carro c1 = new Carro("Ferrari", 231);
        Console.WriteLine("Nome.........: {0}", c1.nome);
        Console.WriteLine("Max Vel......: {0}", c1.getVelMax());
        Console.WriteLine("Atual Vel....: {0}", c1.velAtual);
    }
}