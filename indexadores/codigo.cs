using System;

class Carro{
    //Metodo indexador - Permite os objetos indexados a serem utilizados como Arrays
    private int[] velMax = new int[5]{80,120,160,240,300};
public Carro(){

    }
    // Metodo Get e Set Simplificado
    public int this[int i ]{
        get{
            return velMax[i];
        }
        set{
            if(value < 0){
                velMax[i] = 0;
            }else if(value > 210){
                velMax[i] = 210;
            }else{
                velMax[i] = value;
            }
        }
    }
}

class Principal{
    static void Main(){
        Carro c1 = new Carro();
        //c1[3] = 199;
        Console.WriteLine("Velocidade Atual: {0}", c1[3]);
    }
}