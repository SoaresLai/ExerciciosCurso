using Exercicio6Parte2;
using System;
using System.Globalization;

namespace course
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario p = new Funcionario();

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            p.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            p.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("\nFuncionario: " + p);

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double aumento = double.Parse(Console.ReadLine());
            p.AumentarSalario(aumento);

            Console.WriteLine("\nDados Atualizados: " + p);

        }
    }
}
