using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Produtos.Entities;

namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product> ();

            Console.Write("Enter the number of product: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nProduct #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (ch == 'u')
                {
                    Console.Write("Manufacture date: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new Product(name, price));
                }
                else if (ch == 'c')
                {
                    list.Add(new Product (name, price));
                }
                else
                {
                    Console.Write("Customs Free: ");
                    double customsFree = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFree));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
