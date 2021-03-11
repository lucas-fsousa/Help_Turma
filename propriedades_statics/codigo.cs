using System;


// Para utilizar membros staticos de uma classe, não é preciso instanciar a classe.
class Mat{
    public static double pi = 3.1415; // Membro static de uma class
    public static int dobro(int n){ // Membro static de uma class
        return n*2;
    }
}
class Principal{
    static void Main(){
        double vpi = Mat.pi;
        int num = 10;
        Console.WriteLine(Mat.dobro(num));
        Console.WriteLine("-----------------");
        Console.WriteLine(vpi);
    }
}