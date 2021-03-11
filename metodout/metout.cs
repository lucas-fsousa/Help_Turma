using System;

class Principal{
    static void Main(){
        int divd, divs, rest, quoc;
        divd = 18;
        divs = 3;
        quoc = divide(divd, divs, out rest);
        Console.WriteLine("{0} dividido por {1} é igual a {2} e tem resto {3} na divisão!", divd, divs, quoc, rest);
    }
    static int divide(int dividendo, int divisor, out int resto){
        int quociente;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        return quociente;
    }
}
