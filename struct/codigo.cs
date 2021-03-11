/*Struc é uma forma simples de de trabalhar semelhante as classes, no entanto esta possui uma caracteristica especifica que é a de não ser herdada por outras classes ou structs.*/
using System;
struct Carro{
    public string marca;
    public string modelo;
    public string cor;
    public bool ligado;
    
    /*public Carro(string marca, string modelo, string cor, bool ligado){
        this.ligado = ligado;
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }*/
    public void info(){
        Console.WriteLine("-----> Especificações <-----");
        Console.WriteLine("Cor: {0}", this.cor);
        Console.WriteLine("Marca: {0}", this.marca);
        Console.WriteLine("Modelo: {0}", this.modelo);
        Console.WriteLine("Estado de funcionamento ligado: {0}", this.ligado);
        Console.WriteLine("----------------------------------------");
    }
}

class Principal{
    static void Main(){

        int[] numeros = new int[10]; // Declaração de um Array

        Carro[] carros = new Carro[3];
        carros[0].modelo = "HRV";
        carros[0].cor = "Cinza";

        carros[1].modelo = "Golf";
        carros[1].cor = "Branco";

        carros[2].modelo = "Uno";
        carros[2].cor = "preto";

        for(int i = 0; i < carros.Length; i++){
            carros[i].info();
        }
    }
}