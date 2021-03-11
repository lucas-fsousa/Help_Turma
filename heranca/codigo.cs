using System;

class Veiculo{ // Classe base para outras classes
    private int rodas;
    public int VelMax = 0;
    public bool ligado = false;
    public void ligar(){
        ligado = true;
    }
    public Veiculo(int rodas){
        this.rodas = rodas;
    }
    public void desligar(){
        ligado = false;
    }
    public string getLigado(){
        //Operador ternário pra facilitar retornos
        return (ligado? "SIM":"NÃO");
    }
    public int getRodas(){
        return rodas;
    }
    public void setRodas(int rodas){
        if(rodas < 0){
            this.rodas = 0;
        }else if(rodas > 10){
            this.rodas = 10;
        }else{
            this.rodas = rodas;
        }
    }
}

class Carro:Veiculo{ // Usa-se dois pontos " : " para atribuir uma classe filha a classe pai
    public string nome = "", cor = "";

    public Carro(string nome, string cor):base(3){/*Referencia o construtor da classe base*/
        desligar();
        //rodas = 4;
        VelMax = 195;
        this.nome = nome;
        this.cor = cor;
    }
}

class CarroCombat:Carro{
    public int munic;

    public CarroCombat():base("Carro Blindado", "SELVA"){
        munic = 100;
        setRodas(8);
    }
}
class Principal{
    static void Main(){
        Carro c1 = new Carro("Corvete Bala", "Prata Metálico");
        Console.WriteLine("Cor do veiculo......: {0}",c1.cor);
        Console.WriteLine("Nome do veiculo.....: {0}",c1.nome);
        Console.WriteLine("Quantidade Rodas....: {0}",c1.getRodas());
        Console.WriteLine("Velocidade Max......: {0}",c1.VelMax);
        Console.WriteLine("Ligado..............: {0}",c1.getLigado());
        Console.WriteLine("\n--------------------------------------------------\n\n");
        CarroCombat cc = new CarroCombat();
        Console.WriteLine("Cor do veiculo......: {0}",cc.cor);
        Console.WriteLine("Nome do veiculo.....: {0}",cc.nome);
        Console.WriteLine("Quantidade Rodas....: {0}",cc.getRodas());
        Console.WriteLine("Velocidade Max......: {0}",cc.VelMax);
        Console.WriteLine("Ligado..............: {0}",cc.getLigado());
        Console.WriteLine("Munição.............: {0}",cc.munic);
    }
}