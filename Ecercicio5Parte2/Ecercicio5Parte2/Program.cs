using Ecercicio5Parte2;
using System;
using System.Globalization;

namespace course
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios a, b;

            a = new Funcionarios();
            b = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionaio:");
            Console.Write("Nome: ");
            a.NOME = Console.ReadLine();

            Console.Write("Salario: ");
            a.SALARIO = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDados do segundo funcionario:");
            Console.Write("Nome: ");
            b.NOME = Console.ReadLine();

            Console.Write("Salario: ");
            b.SALARIO = double.Parse(Console.ReadLine());

            Console.WriteLine("\nMédia Salarial: " + (a.SALARIO + b.SALARIO) / 2);
        }
    }
}