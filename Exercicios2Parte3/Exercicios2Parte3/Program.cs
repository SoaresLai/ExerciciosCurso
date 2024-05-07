using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de X e em seguida o valor de Y.");
            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0]);
            double y = double.Parse(valores[1]);

            double coordenada;
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else
            {
                Console.WriteLine("Tente novamente");
            }

            Console.WriteLine("Insira o valor do salario");
            double salario = double.Parse(Console.ReadLine());

            double porcentagem1 = 0.8;
            double porcentagem2 = 0.18;
            double porcentagem3 = 0.28;
            double final;

            if (salario > 0.00 || salario < 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salario > 2001.00 || salario < 3000.00)
            {
                final = salario * porcentagem1;
                Console.WriteLine($"R$ {final}");
            }
            else if (salario > 3001.00 || salario < 4500.00)
            {
                final = salario * porcentagem2;
                Console.WriteLine($"R$ {final}");
            }

        }
    }
}

