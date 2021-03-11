using System;

class multivar{
    static void Main(){
        // int[] n = new int[5]; - Declaração de Array tipovar[] nome = new tipovar[tamanho];
        int[] n = {10, 15, 22};
        Console.WriteLine(n[2]);

        string[] veiculos = new string[2];

        veiculos[0] = "Carro";
        veiculos[1] = "Moto";
        int i;
        for(i = 0; i < 2; i++){
            Console.WriteLine(veiculos[i]);
        }
    }
}