using Exercicio9;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];

            Console.WriteLine("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nAluguel #{i}: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine("\nQuartos ocupados: ");
            for (int i = 1;i < 10; i++)
            {
                if (vect[i] !=null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}