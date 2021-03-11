using System;
using System.Collections.Generic;


class Principal{
    static void Main(){
        Console.WriteLine("\n");
        List<string> carros = new List<string>();
        //List<string> carros2 = new List<string>();
        //string[] carros2 = new string[10]; // string padrão para testar o Copyto
        carros.Add("Golf");
        carros.Add("Porshe");
        carros.Add("Strada");
        carros.Add("Lamborguini");

        carros.Insert(3, "please"); // Insere uma string em na posição desejada
        carros.Sort(); // Ordena os elementos em ordem crescente.
        carros.Remove("Strada"); // Remove a primeira string com o nome selecionado

        carros.Capacity = 15; // Define o tamanho da lista.
        carros.RemoveAt(0); // remove o item da posição selecionada

        //carros2.AddRange(carros); // Copia os atributos de uma lista para outra lista do mesmo tipo.

        //carros.CopyTo(carros2,2);

        if(carros.Contains("Golf")){
            Console.WriteLine("Identificamos o elemento mencionado");
        }else{
            Console.WriteLine("Elemento não localizado.");
        }

        foreach(string c in carros){
            Console.WriteLine("Carro: {0}", c);
        }
        
        string item = "Lamborguini";
        int posicao = carros.LastIndexOf("Strada"); // Retorna a posição da ultima string encontrada - Definir a string a ser buscada.
        posicao = carros.IndexOf(item);
        Console.WriteLine("Tamanho da lista -> {0}", carros.Count); // Mostra o tamanho da lista atualmente
        Console.WriteLine("Carro {0} - Posição {1}", item, posicao);
    }
}