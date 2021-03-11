using System;

public class Cachorro{
    private string raca;
    public void def_raca(string nm){
        do{
            Console.Write("Entre com a raça do cachorro: ");
            Console.ReadLine();
            if(nm.equals()"vira lata"){
                Console.WriteLine("Vira lata não é uma raça. Tente novamente");
            }
        }while(nm.equals("vira lata"));
            
    }
}

class Principal{
    static void Main(){
        Cachorro c1 = new Cachorro();
        c1.def_raca();
    }
}