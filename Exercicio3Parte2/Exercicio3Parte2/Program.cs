using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de X e o valor de Y: ");
            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0]);
            double y = double.Parse(valores[1]);

            while (x != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto");
                }

                Console.Write("Digite o valor de X e o valor de Y: ");
                valores = Console.ReadLine().Split();
                x = double.Parse(valores[0]);
                y = double.Parse(valores[1]);
            }
            Console.WriteLine(" ");
        }
    }
}