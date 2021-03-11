using System;

sealed class Veiculo{
    protected string nome;
    protected int rodas;
    protected int kmMax;
    protected int kmatual;
}

class Carro:Veiculo{ // Não funciona, a classe selada não pode ter derivados.

}

class Principal{
    static void Main(){
        Carro c1 = new Carro();
    }
}