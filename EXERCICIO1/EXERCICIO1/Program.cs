using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int NumeroA;
            int NumeroB;

            Console.WriteLine("Digite um número:");
            NumeroA = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("Digite um número:");
            NumeroB = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine($"A soma dos dois número é: {NumeroA + NumeroB}");
            Console.WriteLine(" ");


            double pi = 3.14159;

            Console.WriteLine("Insira o valor do raio:");
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            double resultado = pi * Math.Pow(raio,2);

            Console.WriteLine($"O resultado da área {raio} é de: {resultado:F4}");
            Console.WriteLine(" ");

            Console.WriteLine("Digite o código do funcionário: ");
            int funcionario = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("Digite o total de horas trabalhadas deste funcionario: ");
            double horas = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("Digite o salario hora deste funcionario: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine($"Funcionario: {funcionario}");
            Console.WriteLine($"Salario: R$ {salario * horas:F2}");



        }
    }
}