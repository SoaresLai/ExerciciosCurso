using Exercicio8;
using System;
using System.Globalization;
using System.Linq.Expressions;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro cad;
            
            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (Sim/Não) ");
            string deposito = Console.ReadLine();

            if ( deposito == "Sim" || deposito == "sim")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cad = new Cadastro(conta, titular, saldo);
            }
            else
            {
                cad = new Cadastro(conta, titular);
}

            Console.WriteLine("\n" + "Dados da conta: ");
            Console.WriteLine(cad);

            Console.Write("\n" + "Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cad.Deposito(quantia);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cad);

            Console.Write("\n" + "Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cad.Saque(quantia);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cad);



        }
    }
}
