using System;
class Sw{
    static void Main(){
        char resp;
        string veiculo = "";
        int tempo = 0;
        Console.WriteLine("De: BH Para: ES");
        Console.WriteLine("***** Escolha o transporte *****\n[1] - Avião\n[2] - Carro\n[3] - Ônibus\nResposta:>> ");
        resp = Console.ReadLine();

        switch(resp){
            case '1':
                tempo = 50;
                veiculo = "Avião";
                break;
            case '2':
                tempo = 400;
                veiculo = "Carro";
                break;
            case '3':
                tempo = 660;
                veiculo = "Ônibus";
                break;
            default:
                tempo = -1;
                break;
        }
        if(tempo < 0){
            Console.WriteLine("Transporte indisponivel.");
        }else{
            Console.WriteLine("O transporte escolhido foi {} e a duração da viagem será de {} minutos", veiculo, tempo);
        }
    }
}