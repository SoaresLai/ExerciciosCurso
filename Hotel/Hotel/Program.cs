using System;
using Hotel.Entities;
using Hotel.Entities.Exceptions;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-in date: (dd/mm/yyyy) ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date: (dd/mm/yyyy) ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine("");
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/mm/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date dd/mm/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine("Reservstion: " + reservation);
            }
            catch (DomainException e) 
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
        }
    }
}