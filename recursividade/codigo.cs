using System;

class Calc{
    public int soma(params int []n){
        int s = 0;
        for(int i = 0; i <n.Length; i++){
            s += n[i];
        }
        return s;
    }
    // Função com recursividade
    public int fat(int n){
        int res;
        if(n <= 1){
            res = 1;
        }else{
            res = n * fat(n - 1);
        }
        return res;
    }
}
class Principal{
    static void Main(){
        Calc fatorar = new Calc();
        var res = fatorar.fat(10);
        Console.WriteLine(res);
    }
}