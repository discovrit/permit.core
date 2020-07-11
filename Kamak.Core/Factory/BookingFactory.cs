using System;
using Kamak.Core.Domain;

namespace Kamak.Core.Factory
{
    public class BookingFactory
    {
        public Booking GetBaseBooking()
        {
            return BaseBooking();
        }

        private Booking BaseBooking()
        {
            return new Booking
            {
                StudentId = 1,
                FirstName = "Melody",
                LastName = "Sunshine",
                Email = "melody.sunshin@permit.com",
                Date = new DateTime(2020, 1, 1),
                Hours = 12,
                Minutes = 15
            };
        }
    }
}