using System;
using System.Collections.Generic;

class Principal{
    static void Main(){
        LinkedList <string> transportes = new LinkedList <string>();

        transportes.AddFirst("Carro");
        transportes.AddFirst("Avião");
        transportes.AddFirst("Navio");
        transportes.AddFirst("Moto");

        transportes.AddLast("Bike");
        LinkedListNode <string> no;
        no = transportes.FindLast("Navio");
        transportes.AddAfter(no, "Patinete");

        //transportes.Clear(); // limpa tudo
        foreach(string t in transportes){
            Console.WriteLine("Transporte: {0}", t);
        }
    }
}