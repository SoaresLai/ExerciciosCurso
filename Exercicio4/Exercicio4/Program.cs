using System;
using System.Globalization;
using System.Runtime.Serialization.Formatters;

namespace curso {
    class Program {
        static void Main(string[] args)
        {

            Console.Write("Quantos valores inteiros serão digitados? ");
            int N = int.Parse(Console.ReadLine());

            int cont_in = 0;
            int cont_out = 0;

            for (int i = 1; i <= N; i++) {
            int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <=20 ) {
                    cont_in++;
                }
                else {
                    cont_out++;
                }
            }
            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out");

            Console.WriteLine("---------------------");

            Console.Write("Digite um número inteiro: ");
            int y = int.Parse(Console.ReadLine());

            for (int i = 1; i <= y ; i++)
            {
                if (i % 2 != 0 )
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
