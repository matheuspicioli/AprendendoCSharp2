﻿namespace _05_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular;
        public int Agencia;
        public int Numero;
        public int Conta;
        public double Saldo = 100.00;

        public bool Sacar(double valor)
        {
            if (this.Saldo < valor)
            {
                return false;
            }

            this.Saldo -= valor;
            return true;

        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.Saldo < valor)
            {
                return false;
            }

            this.Saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }
    }
}
