using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
            {
                Console.Write("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());
            while ( senha != 2002)
            {
                Console.WriteLine("Senha invalida!");
                Console.Write("Digite a senha: ");
                int senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido");
        }
    }
}
