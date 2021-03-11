using System;

class Calculos{
    public int v1;
    public int v2;

    public Calculos(int v1, int v2){
        this.v1 = v1;
        this.v2 = v2;
    }
    public int somar(){
        return v1+v2;
    }
}

class Principal{
    static void Main(){
        Calculos calc = new Calculos(10, 21);
        Console.WriteLine(calc.somar());
    }
}