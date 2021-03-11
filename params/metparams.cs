using System;

class principal{
    static void Main(){
        soma(10, 20,1,3,6,11);
    }

    static void soma(params int[]n){
        int res = 0;
        if(n.Length < 1){
            Console.WriteLine("Não existe valor a ser calculado!");
        }else if(n.Length > 0 && n.Length < 2){
            Console.WriteLine("Não há soma para {0}. Argumentos insuficientes!", n[0]);
        }else{
            for(int i = 0; i < n.Length; i++){
                res += n[i];
            }
            Console.Write("A soma dos valores informados é {0}.", res);
        }
    }
}