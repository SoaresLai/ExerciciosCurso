using Exercicio6;
using System;
using System.Globalization;

namespace course
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret;
            ret = new Retangulo();

            Console.WriteLine("Entre a largura e a altura do retangulo: ");
            ret.Largura = double.Parse(Console.ReadLine());
            ret.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Àrea: " + ret.Area().ToString("F2"));
            Console.WriteLine("Perímetro: " + ret.Perimetro().ToString("F2"));
            Console.WriteLine("Diagonal: " + ret.Diagonal().ToString("F2"));
        }
    }
}