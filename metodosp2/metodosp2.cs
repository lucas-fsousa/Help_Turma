using System;

class Principal{
    static void Main(){
        int num = 10;
        dobrar(ref num);
        Console.WriteLine(num);
    }

    // Passagem por referência
    static void dobrar(ref int n){
        n *= 2;
    }
}