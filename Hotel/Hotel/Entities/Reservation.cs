﻿using Hotel.Entities.Exceptions;
using System.Data;

namespace Hotel.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }
        public Reservation(int roomNumber,  DateTime checkin, DateTime checkout)
        {
            if (checkout < checkin)
            {
                throw new DomainException("Check-out date must be check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public int Duration() 
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now) 
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            if (checkOut < checkIn) 
            {
                throw new DomainException("Check-out date must be check-in date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;

        }

        public override string ToString()
        {
            return "Room" + RoomNumber + ", Check-In: " + CheckIn.ToString("dd/MM/yyyy") + ", Check-Out: "
            + CheckOut.ToString("dd/MM/yyyy") + ", " + Duration() + " nights." ;
        }
    }
}
