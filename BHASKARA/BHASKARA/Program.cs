// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de a: ");
            float ValorA = float.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("Digite o valor de b: ");
            float ValorB = float.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("Digite o valor de c:");
            float ValorC = float.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine($"a = {ValorA}");
            Console.WriteLine($"b = {ValorB}");
            Console.WriteLine($"c = {ValorC}");
            Console.WriteLine(" ");

            float Delta = (ValorB * ValorB) - 4 * ValorA * ValorC;
            double x1 = (-ValorB + Math.Sqrt(Delta)) / 2 * ValorA;
            double x2 = (-ValorB - Math.Sqrt(Delta)) / 2 * ValorA;

            Console.WriteLine($"O valor de X1 é: {x1}");
            Console.WriteLine($"O valor de X2 é: {x2}");

        }
    }
}