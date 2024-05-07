using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor A:");
            double valorA = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("Digite um valor B:");
            double valorB = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("Digite um valor C");
            double valorC = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            double triangulo = (valorA * valorC) / 2;
            Console.WriteLine($"TRIANGULO: {triangulo:F3}");
            Console.WriteLine(" ");

            double circulo = valorC * Math.Pow(3.14159, 2);
            Console.WriteLine($"CIRCULO: {circulo:F3}");
            Console.WriteLine(" ");

            double quadrado = Math.Pow(valorB, 2);
            Console.WriteLine($"QUADRADO: {quadrado:F3}");
            Console.WriteLine(" ");

            double retangulo = valorA * valorB;
            Console.WriteLine($"RETANGULO: {retangulo:F3}");
            Console.WriteLine(" ");

            if (valorA > valorB)
            {
                double trapezio = (valorA * valorB) / valorC;
                Console.WriteLine($"TRAPEZIO: {trapezio:F3}");
            }

            else
            {
                Console.WriteLine("Para calcular o trapézio o valor de A não pode ser menor que o valor de B.");
            }
        }
    }
}