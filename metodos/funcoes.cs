using System;
class Principal{
    static void Main(){
        string nome;
        int n1, n2, receber;

        print("Nome do titular: ");
        nome = Console.ReadLine();
        println("O nome digitado foi "+nome);
        print("Digite o primeiro numero: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        print("Digite o segundo numero: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        somaint(n1, n2);
        receber = somaeretorna(n1, n2);
        print("O resultado da função soma e retorna é "+ receber);
    }
    // Metodo para escrever na tela
    static void print(string nome){
       Console.Write(nome);
    }

    // Metodo para escrever na tela e pular uma linha.
    static void println(string nome){
       Console.WriteLine(nome);
    }

    // Metodo para somar numeros inteiros com retorno vazio(void)
    static void somaint(int n1, int n2){
        int res = n1 + n2;
        Console.WriteLine("N1-> {0} + N2-> {1} = {2}", n1, n2, res);
    }

    //Metodo para somar numeros inteiros com retorno int
    static int somaeretorna(int n1, int n2){
        int res = n1 + n2;
        return res;
    }
}