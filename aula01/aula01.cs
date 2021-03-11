using System; // Utiliza a biblioteca padrão do sistema


// Definição da classe Conta
class Conta{
    private double saldo; // Criação do atributo saldo com visibilidade privada
    private double checkspecial; // Criação do atributo check especial com visibilidade privada 
    private double saldotot;// Criação do atributo saldo total com visibilidade privada 
    public Conta(){ // Metodo construtor da classe Conta
        this.saldo = 0; // definição de valor do saldo da conta
        this.checkspecial = 500; // Definição do valor do check especial da conta
        this.saldotot = this.saldo + this.checkspecial; // definição do valor do saldo total
    }
    public void Depositar(double dp){ // Método de depositar com retorno vazio
        this.saldotot += dp; // Calculo do saldo total (this.saldotot = this.saldotot + dp)
    }
    public double Consultar(){ // Método de consulta com retorno double
        return this.saldotot; // retorna o saldo total
    }
    public void Sacar(double sc){ // Método sacar com visibilidade publica
        if(this.saldotot <= 0){ // Condição para saber se há saldo positivo para saque
            Console.WriteLine("Saldo insuficiente"); // Informa ao usuario que o saldo é insuficiente
        }else{
                if(this.saldotot < sc){ // Verifica se o saldo total é menor que o valor solicitado pelo usuario para ser sacado
                    Console.WriteLine("Saldo insuficiente"); // informa ao usuario que o saldo é insuficiente
                }else{
                    this.saldotot = (this.saldotot - sc); // Será retirado do saldo total o valor que o usuario solicitou
                    Console.WriteLine("Você sacou R${0}", sc); // Informa ao usuario o valor sacado
                }
            }
        }
    }

class Principal{
    public static void Main(){
        Conta c1 = new Conta(); // instancia o objeto da classe Conta "c1 = conta01"

        c1.Depositar(500.44); // Deposita R$500.44 na conta01
        c1.Depositar(4141);// Deposita R$4141 na conta01
        Console.WriteLine("O saldo atual é de R${0}",c1.Consultar()); // Informa ao usuario o valor total da conta atualmente
        Console.WriteLine("\n-----------------\n");
        c1.Sacar(5000); // Realiza o saque de R$5000 da conta do usuario
        Console.WriteLine("O saldo atual é de R${0}",c1.Consultar());// Informa ao usuario o valor total da conta atualmente
        Console.WriteLine("\n-----------------\n");
        c1.Sacar(300); // Realiza o saque de R$300 da conta do usuario
        Console.WriteLine("O saldo atual é de R${0}",c1.Consultar());// Informa ao usuario o valor total da conta atualmente
        Console.WriteLine("\n-----------------\n");
    }
}