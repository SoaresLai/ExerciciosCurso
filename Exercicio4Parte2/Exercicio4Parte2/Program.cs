using System;
using System.Globalization;
using System.Runtime.Serialization.Formatters;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite 3 números serão feitos os testes: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++ )
            {
                string[] linha = Console.ReadLine().Split(' ');

                double a = double.Parse(linha[0]);
                double b = double.Parse(linha[1]);
                double c = double.Parse(linha[2]);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine($"{media:F1}");
            }
        }
    }
}