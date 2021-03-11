using System;

delegate int Op(int n1, int n2);

class Mat{
    public static int soma(int n1, int n2){
        return n1 + n2;
    }
    public static int mult(int n1, int n2){
        return n1 * n2;
    }
}
class Principal{
    static void Main(){
        int res;
        Op d1 = new Op(Mat.soma);

        res = d1(50,10);
        Console.WriteLine(res);
    }
}