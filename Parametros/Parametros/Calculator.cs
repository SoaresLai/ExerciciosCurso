﻿using System;
using System.Globalization;

namespace Parametros
{
    internal class Calculator
    {
        public static int Sum(int[] numeros)
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i]; 
            }
            return soma;

        }
    }
}
