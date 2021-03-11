using System;

class Carro{
    private int velMax;
    public Carro(){
        vm = 210;
    }

    // Metodo Get e Set Simplificado
    public int vm{
        get{
            return velMax;
        }
        set{
            if(value < 0){
                velMax = 0;
            }else if(value > 210){
                velMax = 210;
            }else{
                velMax = value;
            }
        }
    }
}

class Principal{
    static void Main(){
        Carro c1 = new Carro();
        c1.vm = 211;
        Console.WriteLine("Velocidade Atual: {0}", c1.vm);
    }
}