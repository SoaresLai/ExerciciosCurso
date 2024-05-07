using System;
using System.Globalization;

namespace Exercicio7
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 6.0;

        public static double DolarParaReal (double valor, double cotacao)
        {
            double total = valor * cotacao;
            return total + total * IOF / 100.0;
        }
    }
}
