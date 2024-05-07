using Exercicio7;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação atual do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares irá comprar? ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.DolarParaReal(valor, cotacao);

            Console.WriteLine("Valor a ser pago em reais: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
