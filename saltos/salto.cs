using System;
class salto{
    static void Main(){
        string nome = "";
        char resp;
        inicio:
        Console.Clear();
        Console.Write("Hello! Digite seu nome: ");
        nome = Console.ReadLine();
        Console.Write("O nome digitado foi: " + nome + "\n\nDeseja digitar outro nome? [S/N]: ");
        resp = char.Parse(Console.ReadLine());
        if((resp == 'S') || (resp == 's')){
            goto inicio;
        }else{
            Console.WriteLine("Fim do expediente.");
        }
    }
}