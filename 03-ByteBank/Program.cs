using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Titular = "Matheus";
            conta.Agencia = 863;
            conta.Conta = 863732;

            ContaCorrente conta2 = new ContaCorrente();
            conta2.Titular = "Matheus";
            conta2.Agencia = 863;
            conta2.Conta = 863732;

            Console.WriteLine(conta == conta2);

            Console.ReadLine();
        }
    }
}
