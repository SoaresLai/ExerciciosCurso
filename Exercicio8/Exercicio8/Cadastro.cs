using System;
using System.ComponentModel;
using System.Globalization;

namespace Exercicio8
{
    internal class Cadastro
    {
        public int Conta { get; private set; }
        public string Titular {  get; set; }
        public double Saldo { get; private set; }

        public Cadastro (int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }

        public Cadastro (int conta, string titular, double saldo) : this(conta, titular)
        {
            Saldo = saldo;
        }


        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5;
        }

        public override string ToString()
        {
            return Conta + ", " + "Titular: " + Titular + ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
