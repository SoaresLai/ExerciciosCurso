using System;
using System.Globalization;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.Write("Produtos:");
            Console.WriteLine($"{produto1}, cujo valor é de R$ {preco1}.");
            Console.WriteLine($"{produto2}, cujo valor é de R$ {preco2}.");
            Console.WriteLine(" ");

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero {genero}.");
            Console.WriteLine(" ");

            Console.WriteLine($"Medida com 8 casas decimais: {medida}");
            Console.WriteLine($"Arredondado (Três casas decimais): {medida:F3}");

            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
