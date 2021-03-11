using System;
class Principal{
    static void Main(){
        
        int[] vet = new int[5]{3,6,1,8,2}; // Declaração do vetor com 3 posições.

        /*
        // For comum para leitura de Arrays
        for(int i = 0; i < vet.Length; i++){
            Console.WriteLine(vet[i]);
        }
        */

        // For padrão de leitura para Arrays
        foreach(int n in vet){
            Console.WriteLine(n);
        }

    }

}