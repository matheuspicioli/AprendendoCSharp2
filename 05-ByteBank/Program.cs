using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Cliente matheus = new Cliente();
            //matheus.Nome = "Matheus";
            //matheus.Profissao = "Developer";
            //matheus.Cpf = "401.232.111.55";

            ContaCorrente conta = new ContaCorrente();

            //conta.Titular = matheus;
            conta.Titular = new Cliente();
            conta.Titular.Nome = "Matheus";
            conta.Titular.Profissao = "Developer";
            conta.Titular.Cpf = "401.232.111.55";

            conta.Saldo = 500;
            conta.Agencia = 0001;
            conta.Numero = 0001238293;

            //Console.WriteLine(matheus.Nome);
            Console.WriteLine(conta.Titular.Nome);

            //matheus.Nome = "Matheus Picioli";

            //Console.WriteLine(matheus.Nome);
            Console.WriteLine(conta.Titular.Nome);

            Console.ReadLine();
        }
    }
}
