using System;
using System.Collections.Generic;

class Principal{
    static void Main(){
        //string[] vss = {"Pipou", "Nabunda", "chapoca", };
        Queue <string> veiculos = new Queue<string>(); // é possivel inicializar a coleção com um array já existente
        veiculos.Enqueue("Carro");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Bike");
        veiculos.Enqueue("Avião");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Patins");
        veiculos.Enqueue("Mobilete");

        //veiculos.Clear(); // Limpa toda a fila

        string retornado = "Carro";
        if(veiculos.Contains(retornado)){
            Console.WriteLine("Veiculo {0} Encontrado", retornado);
        }else{
            Console.WriteLine("Veiculo {0} Não encontrado na fila", retornado);
        }
        //Console.WriteLine("Primeiro veiculo da fila {0}", veiculos.Dequeue()); // Mostra o primeiro item da fila e o remove da fila
        //Console.WriteLine("Primeiro veiculo da fila {0}", veiculos.Peek()); // Mostra o primeiro item da fila e não remove.
        foreach(string valores in veiculos){
            //valores = veiculos.Dequeue();
            Console.WriteLine("O veiculo {0}", valores);
        }
        Console.WriteLine("\n\ntamanho da fila atualmente {0}\n\n",veiculos.Count);
        while(veiculos.Count > 0){
            Console.WriteLine("O Veiculo {0} foi removido!", veiculos.Dequeue());
        }
         Console.WriteLine("\n\ntamanho da fila atualmente {0}\n\n",veiculos.Count);
    }
}