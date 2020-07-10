using System;
using Kamak.Core.Domain;

namespace Kamak.Core.Service
{
     public class BookingService
    {
        public BookingService()
        {
        }

        public BookingResponse BookLesson(Booking request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            return new BookingResponse
            {
                StudentId = request.StudentId,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Date = request.Date
            };
        }
    }
}