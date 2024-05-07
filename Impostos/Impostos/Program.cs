using System;
using System.Collections.Generic;
using Impostos.Entities;

namespace Impostos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nTax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healtExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(healtExpenditures, name, anualIncome));
                }
                else
                {
                    Console.Write("Number of employee: ");
                    int numberofEmployee = int.Parse(Console.ReadLine());
                    list.Add(new Company(numberofEmployee, name, anualIncome));
                }
            }

                double sum = 0.0;
                Console.WriteLine(" ");
                Console.WriteLine("TAXES PAID:");
                foreach (TaxPayer tp in list)
                {
                    double tax = tp.Tax();
                    Console.WriteLine(tp.Name + ": $ " + tax.ToString("F2"));
                    sum += tax;
                }

                Console.WriteLine(" ");
                Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2"));
        }
    }
}