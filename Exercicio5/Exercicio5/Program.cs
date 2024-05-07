using Exercicio5;
using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosPessoas a, b;

            a = new DadosPessoas();
            b = new DadosPessoas();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            a.nome = Console.ReadLine();

            Console.Write("Idade: ");
            a.idade = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            b.nome = Console.ReadLine();

            Console.Write("Idade: ");
            b.idade = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            if (a.idade < b.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {b.nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {a.nome}");
            }
        }
    }
}