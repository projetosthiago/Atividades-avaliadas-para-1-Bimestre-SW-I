namespace Exercicios_Conta_Bancaria;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercicios Conta Bancaria = ETECMCM  ");
         Conta conta = new Conta();
        conta.nomeCliente = "Thiago Menezes Teixeira";       
        conta.limite = 500;
       
        conta.depositar(260);
        conta.sacar(50);     
        double saldo = conta.Consultasaldo();

       Console.WriteLine("O seu saldo é:" + saldo);

    }
}
