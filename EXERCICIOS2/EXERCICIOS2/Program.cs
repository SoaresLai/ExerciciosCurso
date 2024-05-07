using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor:");
            int valor = int.Parse(Console.ReadLine());

            if (valor < 0)
            {
                Console.WriteLine("O valor informado é Negativo");
            }
            else {
                Console.WriteLine("O valor informado é positivo");
            }

            Console.WriteLine("------------------");

            Console.WriteLine("Digite um valor:");
            int valor2 = int.Parse(Console.ReadLine());
            
            if (valor2 % 2 == 0)
            {
                Console.WriteLine("O valor informado é um valor par.");
            }
            else
            {
                Console.WriteLine("O valor informado é um valor ímpar.");
            }

            Console.WriteLine("------------------");

            Console.WriteLine("Alerta!: Os números devem ser descritos em ordem decrescente, ou seja, um maior e um menor.");
            Console.WriteLine("Digite um valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o próximo valor: ");
            int valor4 = int.Parse(Console.ReadLine());

            if (valor3 % valor4 == 0) {
                Console.WriteLine("Os números são multiplos entre si.");
            }
            else {
                Console.WriteLine("Os números não são multíplos entre si.");
            }

            Console.WriteLine("--------------");

        }
    }
}