using System;
class Calc{
    public int soma(params int[]n){
        int somar = 0;
        for(int i = 0; i < n.Length; i++){
            somar += n[i];
        }
        return somar;
    }
    public double soma(params double[]n){
        double somar = 0;
        for(int i = 0; i < n.Length; i++){
            somar += n[i];
        }
        return somar;
    }
    public float soma(params float[]n){
        float somar = 0;
        for(int i = 0; i < n.Length; i++){
            somar += n[i];
        }
        return somar;
    }
}
class Principal{
    static void Main(){
        
        Calc somar = new Calc();
        var res = somar.soma(10.41,12);
        Console.WriteLine("O resultado é: {0}", res);
        var res1 = somar.soma(10.311,12,3.351);
        Console.WriteLine("O resultado é: {0}", res1);
        var res2 = somar.soma(10,12,31,19);
        Console.WriteLine("O resultado é: {0}", res2);
    }

}