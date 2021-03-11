using System;
class Principal{
    static void Main(){
        int[] vet01 = new int[5];
        int[] vet02 = new int[5];
        int[] vet03 = new int[5];
        int[,] matriz = new int[2,5]{{11,22,00,44,55}, {66,77,88,99,00}};

        Random random = new Random(); // Gera números aleatórios

        for(int i = 0; i < vet01.Length; i++){
            vet01[i] = random.Next(50);
        }

        Console.WriteLine("Elementos do 1° Vetor!");
        foreach(int n in vet01){
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------------------------");

        //public static int BinarySearch(array, valor);
        Console.WriteLine("BinarySearch");
        int procurado = 33;
        int pos=Array.BinarySearch(vet01, procurado);
        Console.WriteLine("Valor {0} está na posição {1}!", procurado, pos);
        Console.WriteLine("-------------------------------------------");

        //public static void Copy(Ar_origem, Ar_destino, qtd_element);
        Console.WriteLine("Copy");
        Array.Copy(vet01, vet02, vet01.Length);
        foreach(int n in vet02){
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------------------------");

        //public void CopyTo(Ar_destino, a_patir_desta_pos);
        Console.WriteLine("CopyTo");
        vet01.CopyTo(vet03,0);
        foreach(int n in vet03){
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------------------------");

        //public long GetLongLength(dimensão);
        Console.WriteLine("GetLongLenght");
        long qtd_element_vet = vet01.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}", qtd_element_vet);
        Console.WriteLine("-------------------------------------------");

        //public int GetLowerBound(dimensão);
        Console.WriteLine("GetLowerBound");
        int menorIndiceVet = vet01.GetLowerBound(0);
        int menorIndiceMatriz = matriz.GetLowerBound(1);
        Console.WriteLine("Menor indice do vetor 01 é> {0}", menorIndiceVet);
        Console.WriteLine("-------------------------------------------");

        //public int GetUpperBound(dimensão);
        Console.WriteLine("GetUpperBound");
        int maiorIndiceVet = vet01.GetUpperBound(0);
        int maiorIndiceMatriz = matriz.GetUpperBound(1);
        Console.WriteLine("Maior indice do vetor 01 é> {0}", maiorIndiceVet);
        Console.WriteLine("-------------------------------------------");

        //public object GetValue(long indice);
        Console.WriteLine("GetValue");
        int valor0 = Convert.ToInt32(vet01.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor da posição 3 do vetor 1 é > {0}", valor0);
        Console.WriteLine("-------------------------------------------");

        //public static int IndexOf(array, valor);
        Console.WriteLine("IndexOf");
        int indice1 = Array.IndexOf(vet01, 3);
        Console.WriteLine("Indice do primeiro valor 3:{0}", indice1);
        Console.WriteLine("-------------------------------------------");

        //public static int LastIndexOf(array, valor);
        Console.WriteLine("LastIndexOf");
        int indice2 = Array.LastIndexOf(vet01, 3);
        Console.WriteLine("Indice do ultimo valor 33:{0}", indice2);
        Console.WriteLine("-------------------------------------------");

        //public static void Reverse(array);
        Console.WriteLine("Reverse");
        Array.Reverse(vet01);
        foreach(int n in vet01){
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------------------------");

        //public void SetValue(objet valor, long pos);
        Console.WriteLine("SetValue - Vetor 1");
        vet02.SetValue(99,0);
        for(int i = 0; i < vet02.Length; i++){
            vet02.SetValue(0, i);
        }
        Console.WriteLine("SetValue - Vetor 2");
        foreach(int n in vet02){
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------------------------");

        //public static void Sort(array);
        Console.WriteLine("Sort - vetor 1");
        Array.Sort(vet01);
        Array.Sort(vet02);
        Array.Sort(vet03);
        foreach(int n in vet01){
            Console.WriteLine(n);
        }
        Console.WriteLine("Sort - Vetor 2");
        foreach(int n in vet02){
            Console.WriteLine(n);
        }
        Console.WriteLine("Sort - Vetor 3");
        foreach(int n in vet03){
            Console.WriteLine(n);
        }
    }
}