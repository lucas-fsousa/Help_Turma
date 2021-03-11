using System;
/*
Uma classe abstrata serve como protótipo de classe para outras que herdarão
Todo método abstrato  na classe base é necessário ser implementado na classe que herdou*/

abstract class Veiculo{
    protected int velAmax;
    protected int velAtual;
    protected bool ligado;

    public Veiculo(){
        ligado = false;
        velAtual = 0;
    }
    public void setLigado(bool ligado){
        this.ligado = ligado;
    }
    public int getVelAtual(){
        return velAtual;
    }
    abstract public void aceleracao(int mult);
}

class Carro:Veiculo{
    public Carro(){
        velAmax = 200;

    }
    override public void aceleracao(int mult){
        velAtual+=10*mult;
    }
}
class Principal{
    static void Main(){
        Carro c1 = new Carro();
        c1.aceleracao(1);
        c1.aceleracao(-1);
        Console.WriteLine(c1.getVelAtual());
    }
}