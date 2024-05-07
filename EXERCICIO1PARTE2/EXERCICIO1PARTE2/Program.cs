using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o código da peça: ");
            int pecaA = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("Digite o código da peça: ");
            int pecaB = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("Digte a quantidade da peça: ");
            int quantidadeA = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("Digite a quantidade da segunda peça: ");
            int quantidadeB = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("Digite o valor da peça: ");
            double valorA = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("Digite o valor da peça: ");
            double valorB = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine($"O valor total a pagar é de: R$ {(valorA*quantidadeA) + (valorB*quantidadeB):F2}");

        }
    }
}
