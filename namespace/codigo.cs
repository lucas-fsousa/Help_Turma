using System;
/* Permite a criação de outra função com o mesmo nome desde que cada uma esteja em um namespace diferente. */
namespace Calc1{ 
    class Area{
        public static float Quad(float bas, float alt){
            if(bas == 0 || alt == 0){
                throw new Exception("Base ou Altura igual a ZERO");
            }
            return bas * alt;
        }
    }

}

class Principal{
    static void Main(){
        float area = 0;

        try{
            area = Calc1.Area.Quad(11.1f, 1.2f);
            Console.WriteLine("Area do quadrado: {0}m²", area);
        }catch(Exception e){
            Console.WriteLine("ERRO {0}", e.Message);
        }finally{
            Console.WriteLine("Fim do processo");
        }
    }
}