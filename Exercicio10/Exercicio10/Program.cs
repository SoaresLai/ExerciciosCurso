using System;
using System.Globalization;
using Exercicio10.Entities;
using Exercicio10.Entities.Enums;

namespace Space
{
    class program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
        }
    }
}
