using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args) {

            int Alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.Write("Digite o código do combustivel: ");
            int codigo = int.Parse(Console.ReadLine());

            while (codigo != 4 ) {
                if (codigo == 1)
                {
                    Alcool = Alcool + 1;

                }
                else if (codigo == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (codigo == 3)
                {
                    diesel = diesel + 1;
                }
                Console.Write("Digite o código do combustivel: ");
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine($"Álcool: {Alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");

        }
    }
}