using System;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.Titular = "Matheus";

            Console.WriteLine(conta.Titular);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
