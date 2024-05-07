using System;
using System.Globalization;
using Cafeteria.Intities.Enums;
using Cafeteria.Intities;
using System.Diagnostics;
using System.Collections.Generic;


namespace Cafeteria
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date (MM/DD/YYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Enter Order Data: ");
            Console.Write("Status: ");
            OrderStatus item = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, date);
            Order order = new Order(DateTime.Now, item, client);

            Console.WriteLine("How Many Itens to this orde? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string product = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());

                Product product1 = new Product(product, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product1);

                order.AddItem(orderItem);
            }

            Console.WriteLine(" ");
            Console.Write("ORDER STATUS:");
            Console.WriteLine(order);






        }
    }
}
