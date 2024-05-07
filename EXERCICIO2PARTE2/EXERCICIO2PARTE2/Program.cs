// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite ohorário inicial e em seguida o horário final.");
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial - horaFinal;
            }
            Console.WriteLine($"A duração do jogo foi de {duracao} horas.");

            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Digite o código do primeiro produto e em seguida do segundo produto.");
            string[] valores1 = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores1[0]);
            int quantidade = int.Parse(valores1[1]);

            double total ;
            if (codigo == 1)
            {
                total = quantidade * 4.0;
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.5;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.0;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.0;
            }
            else
            {
                total = quantidade * 1.5;
            }
                Console.WriteLine($"Total R$:{total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
