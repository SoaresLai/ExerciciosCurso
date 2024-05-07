using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio10.Entities.Enums;

namespace Exercicio10.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return "Order: " + Id + ", Date: " + Moment + ", Status: " + Status;
        }
    }
}
