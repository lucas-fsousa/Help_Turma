using System;

class Base{
    public Base(){
        Console.WriteLine("Construtor da classe Base!");
    }
    virtual public void Info(){} // Método info virtual para referencia.
}

class Deriv:Base{
    public Deriv(){
        Console.WriteLine("Construtor da Derivada 01!");
    }
    
    override public void Info(){
        Console.WriteLine("DV01");
    }
}
class Deriv02:Deriv{
    public Deriv02(){
        Console.WriteLine("Construtor da derivada 02!");
    }
    override public void Info(){
        Console.WriteLine("DV02");
    }
}
class Principal{
    static void Main(){
        Base Ref;
        Deriv dv = new Deriv();
        Deriv02 dv02 = new Deriv02();
        //dv.Info();
        //dv02.Info();
        Ref = dv02;
        Ref.Info();
    }
}