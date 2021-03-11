using System; // adiciona a biblioteca padrão
using System.Collections.Generic; // Adiciona a biblioteca de coleção gernéria
class Principal{
    static void Main(){
        Dictionary <int, string> veiculos = new Dictionary <int, string>(); // Criação de um dicionário padrão.

        veiculos.Add(10, "Corsa");
        veiculos.Add(5, "Palio");
        veiculos.Add(0, "Suziki");
        veiculos.Add(20, "CG 165");
        veiculos.Add(15, "Monster Truck");

        veiculos[20] = "IRINEU!!!!"; // Modifica o valor de uma KEY especifica
        veiculos.Remove(10); // Remove uma chave especifica do dicionário.
        Console.WriteLine("Tamanho do dicionario: {0} itens", veiculos.Count); // "Count" Verifica o tamanho do dicionario
        
        int chave = 10;
        string valor = "Corsa";
        if(veiculos.ContainsKey(chave)){ // Retorna true ou false para a localização da chave na biblioteca
            Console.WriteLine("A chave {0} está na coleção!", chave);
        }else{
            Console.WriteLine("A chave {0} não foi localizada!", chave);
        }
        if(veiculos.ContainsValue(valor)){ // Retorna true ou false para a localização de um valor na biblioteca
            Console.WriteLine("O valor {0} foi localizado na biblioteca.", valor);
        }else{
            Console.WriteLine("O valor {0} não foi localizado na biblioteca.", valor);
        }
        Console.WriteLine(veiculos.ContainsValue("IRINEU!!!!"));
        foreach(KeyValuePair<int,string> v in veiculos){
            Console.WriteLine(v.Key);
        }
        veiculos.Clear(); // Limpa o dicionario

    }
}