﻿using System;

namespace PrimeiraClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.Titular = "Matheus";
            conta.Agencia = 0001;
            conta.Conta = 7687150;
            conta.Saldo = 0.00;

            Console.WriteLine(conta.Titular);
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Conta);
            Console.WriteLine(conta.Saldo);


            Console.ReadLine();
        }
    }
}
