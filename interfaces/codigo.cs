using System;

public interface Veiculo{
    void ligar();
    void desligar();
    void info();
}
public interface Combat{
    void disparar();
}
class Carro:Veiculo,Combat{ // Utiliza duas interfaces na classe Carro
    private bool ligado;
    private int municao = 100;
    public Carro(){
       setMunicao(100);
    }
    public void setMunicao(int qtd){
        this.municao = qtd;
    }
    public void ligar(){
        this.ligado = true;
    }
    public void desligar(){
        this.ligado = false;
    }
    public void info(){

    }
    public void disparar(){
        
    }
}
class Principal{
    static void Main(){
        Carro c1 = new Carro();
    }
}