using System;

class Area{
    public static float Quad(float cbase, float calt){
        if(cbase == 0 || calt == 0){
            throw new Exception("Base ou altura igual a ZERO.");
        }
        return cbase*calt;
    }
}

class Principal{
    static void Main(){
        
        float area = 0;
        //int n1, n2, res;
        //res = n1 = n2 = 0;
        //n1 = 10;
        //n2 = 2;
        try{
            //res = n1/n2;
            //Console.WriteLine("{0}/{1}={2}", n1, n2, res);
            //throw new Exception("Novo erro"); // o throw serve para disparar uma nova exceção
            area = Area.Quad(0, 7.11f);
            Console.WriteLine("Resultado: {0}m²", area);
        }catch(Exception ex){
            Console.WriteLine("Erro na operação {0}.. Verifique os parametros que foram passados!",ex.Message); // Message mostra a mensagem do erro.
            Console.WriteLine("Tipo de erro {0}", ex.GetType());
        }finally{
            Console.WriteLine("Até mais!");
        }   
    }
}